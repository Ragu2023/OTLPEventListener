
using System.Net.Sockets;
using System.Net;
using OpenTelemetry.Proto.Trace.V1;
using OpenTelemetry.Proto.Logs.V1;
using System.Diagnostics;
using System;
using System.Text;
using System.Runtime.InteropServices.Marshalling;

namespace EventListener
{
    internal enum MessageType
    {
        Log,
        Trace
    }

    internal class SocketListener
    {
        public Task StartListening(string host, int logPort, int tracePort, CancellationToken cancellationToken)
        {
            return Task.Run(async () =>
            {
                try
                {
                    Task[] tasks = new Task[]{
                        SocketListener.HandleClientConnAsync(MessageType.Log, host, logPort, cancellationToken),
                        SocketListener.HandleClientConnAsync(MessageType.Trace, host, tracePort, cancellationToken)
                    };

                    await Task.WhenAll(tasks);
                }
                catch (IOException e)
                {
                    Console.WriteLine($"IOException {e}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception {ex}");
                }
            });
        }

        private static async Task HandleClientConnAsync(MessageType messageType, string host, int port, CancellationToken cancellationToken)
        {
            Socket listener = default;
            string endpointLookupKey = $"{host}.{port}";
            IPAddress ipAddress = IPAddress.Loopback;
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, port);

            try
            {
                listener = new Socket(localEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                listener.Bind(localEndPoint);
                listener.Listen(100);

                Console.WriteLine($"Listening for {messageType}: {endpointLookupKey}");
                var handler = await listener.AcceptAsync();
                {
                    byte[] receivedBuffer = new byte[4096];

                    while (!cancellationToken.IsCancellationRequested)
                    {
                        try
                        {
                            var received = await handler.ReceiveAsync(receivedBuffer, SocketFlags.None);
                            if (received > 0)
                            {
                                if (messageType == MessageType.Trace)
                                {
                                    Span traceObject = Span.Parser.ParseFrom(receivedBuffer, 0, received);
                                    Console.WriteLine($"Received: {traceObject.TraceId}");
                                }
                                else
                                {
                                    LogRecord logObject = LogRecord.Parser.ParseFrom(receivedBuffer, 0, received);
                                    Console.WriteLine($"Received: {logObject.TraceId}");
                                }
                            }
                        }
                        catch (TaskCanceledException)
                        {
                            Console.WriteLine($"TaskCanceledException");
                            break;
                        }
                        catch (OperationCanceledException)
                        {
                            Console.WriteLine($"OperationCanceledException");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exception {ex}");
                            break;
                        }
                    }
                }
            }
            finally
            {
                if (listener != null)
                {
                    listener.Shutdown(SocketShutdown.Both);
                    listener.Close();
                }
            }

        }
    }
}

// See https://aka.ms/new-console-template for more information
using EventListener;

Console.WriteLine("Event Listener Started!");


await new SocketListener().StartListening("localhost", 4321, 4322, CancellationToken.None);

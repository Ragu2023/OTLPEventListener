// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: resource.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OpenTelemetry.Proto.Resource.V1 {

  /// <summary>Holder for reflection information generated from resource.proto</summary>
  public static partial class ResourceReflection {

    #region Descriptor
    /// <summary>File descriptor for resource.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5yZXNvdXJjZS5wcm90bxIfb3BlbnRlbGVtZXRyeS5wcm90by5yZXNvdXJj",
            "ZS52MRoMY29tbW9uLnByb3RvImkKCFJlc291cmNlEjsKCmF0dHJpYnV0ZXMY",
            "ASADKAsyJy5vcGVudGVsZW1ldHJ5LnByb3RvLmNvbW1vbi52MS5LZXlWYWx1",
            "ZRIgChhkcm9wcGVkX2F0dHJpYnV0ZXNfY291bnQYAiABKA1CgwEKImlvLm9w",
            "ZW50ZWxlbWV0cnkucHJvdG8ucmVzb3VyY2UudjFCDVJlc291cmNlUHJvdG9Q",
            "AVoqZ28ub3BlbnRlbGVtZXRyeS5pby9wcm90by9vdGxwL3Jlc291cmNlL3Yx",
            "qgIfT3BlblRlbGVtZXRyeS5Qcm90by5SZXNvdXJjZS5WMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OpenTelemetry.Proto.Common.V1.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OpenTelemetry.Proto.Resource.V1.Resource), global::OpenTelemetry.Proto.Resource.V1.Resource.Parser, new[]{ "Attributes", "DroppedAttributesCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Resource information.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Resource : pb::IMessage<Resource>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Resource> _parser = new pb::MessageParser<Resource>(() => new Resource());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Resource> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OpenTelemetry.Proto.Resource.V1.ResourceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Resource() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Resource(Resource other) : this() {
      attributes_ = other.attributes_.Clone();
      droppedAttributesCount_ = other.droppedAttributesCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Resource Clone() {
      return new Resource(this);
    }

    /// <summary>Field number for the "attributes" field.</summary>
    public const int AttributesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::OpenTelemetry.Proto.Common.V1.KeyValue> _repeated_attributes_codec
        = pb::FieldCodec.ForMessage(10, global::OpenTelemetry.Proto.Common.V1.KeyValue.Parser);
    private readonly pbc::RepeatedField<global::OpenTelemetry.Proto.Common.V1.KeyValue> attributes_ = new pbc::RepeatedField<global::OpenTelemetry.Proto.Common.V1.KeyValue>();
    /// <summary>
    /// Set of attributes that describe the resource.
    /// Attribute keys MUST be unique (it is not allowed to have more than one
    /// attribute with the same key).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OpenTelemetry.Proto.Common.V1.KeyValue> Attributes {
      get { return attributes_; }
    }

    /// <summary>Field number for the "dropped_attributes_count" field.</summary>
    public const int DroppedAttributesCountFieldNumber = 2;
    private uint droppedAttributesCount_;
    /// <summary>
    /// dropped_attributes_count is the number of dropped attributes. If the value is 0, then
    /// no attributes were dropped.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DroppedAttributesCount {
      get { return droppedAttributesCount_; }
      set {
        droppedAttributesCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Resource);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Resource other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!attributes_.Equals(other.attributes_)) return false;
      if (DroppedAttributesCount != other.DroppedAttributesCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= attributes_.GetHashCode();
      if (DroppedAttributesCount != 0) hash ^= DroppedAttributesCount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      attributes_.WriteTo(output, _repeated_attributes_codec);
      if (DroppedAttributesCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DroppedAttributesCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      attributes_.WriteTo(ref output, _repeated_attributes_codec);
      if (DroppedAttributesCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(DroppedAttributesCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += attributes_.CalculateSize(_repeated_attributes_codec);
      if (DroppedAttributesCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DroppedAttributesCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Resource other) {
      if (other == null) {
        return;
      }
      attributes_.Add(other.attributes_);
      if (other.DroppedAttributesCount != 0) {
        DroppedAttributesCount = other.DroppedAttributesCount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            attributes_.AddEntriesFrom(input, _repeated_attributes_codec);
            break;
          }
          case 16: {
            DroppedAttributesCount = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            attributes_.AddEntriesFrom(ref input, _repeated_attributes_codec);
            break;
          }
          case 16: {
            DroppedAttributesCount = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code

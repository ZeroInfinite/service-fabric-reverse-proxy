// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: http/ip_tagging/v2/ip_tagging.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Http.IpTagging.V2 {

  /// <summary>Holder for reflection information generated from http/ip_tagging/v2/ip_tagging.proto</summary>
  public static partial class IpTaggingReflection {

    #region Descriptor
    /// <summary>File descriptor for http/ip_tagging/v2/ip_tagging.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IpTaggingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNodHRwL2lwX3RhZ2dpbmcvdjIvaXBfdGFnZ2luZy5wcm90bxImZW52b3ku",
            "Y29uZmlnLmZpbHRlci5odHRwLmlwX3RhZ2dpbmcudjIaH2Vudm95L2FwaS92",
            "Mi9jb3JlL2FkZHJlc3MucHJvdG8irAIKCUlQVGFnZ2luZxJTCgxyZXF1ZXN0",
            "X3R5cGUYASABKA4yPS5lbnZveS5jb25maWcuZmlsdGVyLmh0dHAuaXBfdGFn",
            "Z2luZy52Mi5JUFRhZ2dpbmcuUmVxdWVzdFR5cGUSSAoHaXBfdGFncxgCIAMo",
            "CzI3LmVudm95LmNvbmZpZy5maWx0ZXIuaHR0cC5pcF90YWdnaW5nLnYyLklQ",
            "VGFnZ2luZy5JUFRhZxpLCgVJUFRhZxITCgtpcF90YWdfbmFtZRgBIAEoCRIt",
            "CgdpcF9saXN0GAIgAygLMhwuZW52b3kuYXBpLnYyLmNvcmUuQ2lkclJhbmdl",
            "IjMKC1JlcXVlc3RUeXBlEggKBEJPVEgQABIMCghJTlRFUk5BTBABEgwKCEVY",
            "VEVSTkFMEAJCBFoCdjJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Core.AddressReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging), global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Parser, new[]{ "RequestType", "IpTags" }, null, new[]{ typeof(global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Types.RequestType) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Types.IPTag), global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Types.IPTag.Parser, new[]{ "IpTagName", "IpList" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// This is an HTTP filter which enables Envoy to tag requests with extra
  /// information such as location, cloud source, and any extra data. This is
  /// useful to prevent against DDoS.
  /// </summary>
  public sealed partial class IPTagging : pb::IMessage<IPTagging> {
    private static readonly pb::MessageParser<IPTagging> _parser = new pb::MessageParser<IPTagging>(() => new IPTagging());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IPTagging> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Http.IpTagging.V2.IpTaggingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IPTagging() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IPTagging(IPTagging other) : this() {
      requestType_ = other.requestType_;
      ipTags_ = other.ipTags_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IPTagging Clone() {
      return new IPTagging(this);
    }

    /// <summary>Field number for the "request_type" field.</summary>
    public const int RequestTypeFieldNumber = 1;
    private global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Types.RequestType requestType_ = 0;
    /// <summary>
    /// The type of requests the filter should apply to. The supported types
    /// are internal, external or both. A request is considered internal if
    /// x-envoy-internal is set to true. If x-envoy-internal is not set or
    /// false, a request is considered external. The filter defaults to both,
    /// and it will apply to all request types.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Types.RequestType RequestType {
      get { return requestType_; }
      set {
        requestType_ = value;
      }
    }

    /// <summary>Field number for the "ip_tags" field.</summary>
    public const int IpTagsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Types.IPTag> _repeated_ipTags_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Types.IPTag.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Types.IPTag> ipTags_ = new pbc::RepeatedField<global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Types.IPTag>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Types.IPTag> IpTags {
      get { return ipTags_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IPTagging);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IPTagging other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RequestType != other.RequestType) return false;
      if(!ipTags_.Equals(other.ipTags_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RequestType != 0) hash ^= RequestType.GetHashCode();
      hash ^= ipTags_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RequestType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) RequestType);
      }
      ipTags_.WriteTo(output, _repeated_ipTags_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RequestType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RequestType);
      }
      size += ipTags_.CalculateSize(_repeated_ipTags_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IPTagging other) {
      if (other == null) {
        return;
      }
      if (other.RequestType != 0) {
        RequestType = other.RequestType;
      }
      ipTags_.Add(other.ipTags_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            requestType_ = (global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Types.RequestType) input.ReadEnum();
            break;
          }
          case 18: {
            ipTags_.AddEntriesFrom(input, _repeated_ipTags_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the IPTagging message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum RequestType {
        [pbr::OriginalName("BOTH")] Both = 0,
        [pbr::OriginalName("INTERNAL")] Internal = 1,
        [pbr::OriginalName("EXTERNAL")] External = 2,
      }

      public sealed partial class IPTag : pb::IMessage<IPTag> {
        private static readonly pb::MessageParser<IPTag> _parser = new pb::MessageParser<IPTag>(() => new IPTag());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<IPTag> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Config.Filter.Http.IpTagging.V2.IPTagging.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public IPTag() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public IPTag(IPTag other) : this() {
          ipTagName_ = other.ipTagName_;
          ipList_ = other.ipList_.Clone();
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public IPTag Clone() {
          return new IPTag(this);
        }

        /// <summary>Field number for the "ip_tag_name" field.</summary>
        public const int IpTagNameFieldNumber = 1;
        private string ipTagName_ = "";
        /// <summary>
        /// Specifies the ip tag name to apply.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string IpTagName {
          get { return ipTagName_; }
          set {
            ipTagName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "ip_list" field.</summary>
        public const int IpListFieldNumber = 2;
        private static readonly pb::FieldCodec<global::Envoy.Api.V2.Core.CidrRange> _repeated_ipList_codec
            = pb::FieldCodec.ForMessage(18, global::Envoy.Api.V2.Core.CidrRange.Parser);
        private readonly pbc::RepeatedField<global::Envoy.Api.V2.Core.CidrRange> ipList_ = new pbc::RepeatedField<global::Envoy.Api.V2.Core.CidrRange>();
        /// <summary>
        /// A list of IP address and subnet masks that will be tagged with the
        /// ip_tag_name. Both IPv4 and IPv6 CIDR addresses are allowed here.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::Envoy.Api.V2.Core.CidrRange> IpList {
          get { return ipList_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as IPTag);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(IPTag other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (IpTagName != other.IpTagName) return false;
          if(!ipList_.Equals(other.ipList_)) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (IpTagName.Length != 0) hash ^= IpTagName.GetHashCode();
          hash ^= ipList_.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (IpTagName.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(IpTagName);
          }
          ipList_.WriteTo(output, _repeated_ipList_codec);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (IpTagName.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(IpTagName);
          }
          size += ipList_.CalculateSize(_repeated_ipList_codec);
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(IPTag other) {
          if (other == null) {
            return;
          }
          if (other.IpTagName.Length != 0) {
            IpTagName = other.IpTagName;
          }
          ipList_.Add(other.ipList_);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 10: {
                IpTagName = input.ReadString();
                break;
              }
              case 18: {
                ipList_.AddEntriesFrom(input, _repeated_ipList_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
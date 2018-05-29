// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ratelimit/v2/rls.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Service.Ratelimit.V2 {

  /// <summary>Holder for reflection information generated from ratelimit/v2/rls.proto</summary>
  public static partial class RlsReflection {

    #region Descriptor
    /// <summary>File descriptor for ratelimit/v2/rls.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RlsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZyYXRlbGltaXQvdjIvcmxzLnByb3RvEhplbnZveS5zZXJ2aWNlLnJhdGVs",
            "aW1pdC52MhomZW52b3kvYXBpL3YyL3JhdGVsaW1pdC9yYXRlbGltaXQucHJv",
            "dG8aF3ZhbGlkYXRlL3ZhbGlkYXRlLnByb3RvInkKEFJhdGVMaW1pdFJlcXVl",
            "c3QSDgoGZG9tYWluGAEgASgJEkAKC2Rlc2NyaXB0b3JzGAIgAygLMisuZW52",
            "b3kuYXBpLnYyLnJhdGVsaW1pdC5SYXRlTGltaXREZXNjcmlwdG9yEhMKC2hp",
            "dHNfYWRkZW5kGAMgASgNItEEChFSYXRlTGltaXRSZXNwb25zZRJICgxvdmVy",
            "YWxsX2NvZGUYASABKA4yMi5lbnZveS5zZXJ2aWNlLnJhdGVsaW1pdC52Mi5S",
            "YXRlTGltaXRSZXNwb25zZS5Db2RlElAKCHN0YXR1c2VzGAIgAygLMj4uZW52",
            "b3kuc2VydmljZS5yYXRlbGltaXQudjIuUmF0ZUxpbWl0UmVzcG9uc2UuRGVz",
            "Y3JpcHRvclN0YXR1cxqyAQoJUmF0ZUxpbWl0EhkKEXJlcXVlc3RzX3Blcl91",
            "bml0GAEgASgNEkoKBHVuaXQYAiABKA4yPC5lbnZveS5zZXJ2aWNlLnJhdGVs",
            "aW1pdC52Mi5SYXRlTGltaXRSZXNwb25zZS5SYXRlTGltaXQuVW5pdCI+CgRV",
            "bml0EgsKB1VOS05PV04QABIKCgZTRUNPTkQQARIKCgZNSU5VVEUQAhIICgRI",
            "T1VSEAMSBwoDREFZEAQavQEKEERlc2NyaXB0b3JTdGF0dXMSQAoEY29kZRgB",
            "IAEoDjIyLmVudm95LnNlcnZpY2UucmF0ZWxpbWl0LnYyLlJhdGVMaW1pdFJl",
            "c3BvbnNlLkNvZGUSTgoNY3VycmVudF9saW1pdBgCIAEoCzI3LmVudm95LnNl",
            "cnZpY2UucmF0ZWxpbWl0LnYyLlJhdGVMaW1pdFJlc3BvbnNlLlJhdGVMaW1p",
            "dBIXCg9saW1pdF9yZW1haW5pbmcYAyABKA0iKwoEQ29kZRILCgdVTktOT1dO",
            "EAASBgoCT0sQARIOCgpPVkVSX0xJTUlUEAIyhAEKEFJhdGVMaW1pdFNlcnZp",
            "Y2UScAoPU2hvdWxkUmF0ZUxpbWl0EiwuZW52b3kuc2VydmljZS5yYXRlbGlt",
            "aXQudjIuUmF0ZUxpbWl0UmVxdWVzdBotLmVudm95LnNlcnZpY2UucmF0ZWxp",
            "bWl0LnYyLlJhdGVMaW1pdFJlc3BvbnNlIgBCBFoCdjJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Ratelimit.RatelimitReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Ratelimit.V2.RateLimitRequest), global::Envoy.Service.Ratelimit.V2.RateLimitRequest.Parser, new[]{ "Domain", "Descriptors", "HitsAddend" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Ratelimit.V2.RateLimitResponse), global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Parser, new[]{ "OverallCode", "Statuses" }, null, new[]{ typeof(global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.Code) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.RateLimit), global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.RateLimit.Parser, new[]{ "RequestsPerUnit", "Unit" }, null, new[]{ typeof(global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.RateLimit.Types.Unit) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.DescriptorStatus), global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.DescriptorStatus.Parser, new[]{ "Code", "CurrentLimit", "LimitRemaining" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Main message for a rate limit request. The rate limit service is designed to be fully generic
  /// in the sense that it can operate on arbitrary hierarchical key/value pairs. The loaded
  /// configuration will parse the request and find the most specific limit to apply. In addition,
  /// a RateLimitRequest can contain multiple "descriptors" to limit on. When multiple descriptors
  /// are provided, the server will limit on *ALL* of them and return an OVER_LIMIT response if any
  /// of them are over limit. This enables more complex application level rate limiting scenarios
  /// if desired.
  /// [#not-implemented-hide:] Hiding API for now.
  /// </summary>
  public sealed partial class RateLimitRequest : pb::IMessage<RateLimitRequest> {
    private static readonly pb::MessageParser<RateLimitRequest> _parser = new pb::MessageParser<RateLimitRequest>(() => new RateLimitRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RateLimitRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Ratelimit.V2.RlsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitRequest(RateLimitRequest other) : this() {
      domain_ = other.domain_;
      descriptors_ = other.descriptors_.Clone();
      hitsAddend_ = other.hitsAddend_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitRequest Clone() {
      return new RateLimitRequest(this);
    }

    /// <summary>Field number for the "domain" field.</summary>
    public const int DomainFieldNumber = 1;
    private string domain_ = "";
    /// <summary>
    /// All rate limit requests must specify a domain. This enables the configuration to be per
    /// application without fear of overlap. E.g., "envoy".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Domain {
      get { return domain_; }
      set {
        domain_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "descriptors" field.</summary>
    public const int DescriptorsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor> _repeated_descriptors_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor> descriptors_ = new pbc::RepeatedField<global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor>();
    /// <summary>
    /// All rate limit requests must specify at least one RateLimitDescriptor. Each descriptor is
    /// processed by the service (see below). If any of the descriptors are over limit, the entire
    /// request is considered to be over limit.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Api.V2.Ratelimit.RateLimitDescriptor> Descriptors {
      get { return descriptors_; }
    }

    /// <summary>Field number for the "hits_addend" field.</summary>
    public const int HitsAddendFieldNumber = 3;
    private uint hitsAddend_;
    /// <summary>
    /// Rate limit requests can optionally specify the number of hits a request adds to the matched
    /// limit. If the value is not set in the message, a request increases the matched limit by 1.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint HitsAddend {
      get { return hitsAddend_; }
      set {
        hitsAddend_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RateLimitRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RateLimitRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Domain != other.Domain) return false;
      if(!descriptors_.Equals(other.descriptors_)) return false;
      if (HitsAddend != other.HitsAddend) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Domain.Length != 0) hash ^= Domain.GetHashCode();
      hash ^= descriptors_.GetHashCode();
      if (HitsAddend != 0) hash ^= HitsAddend.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Domain.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Domain);
      }
      descriptors_.WriteTo(output, _repeated_descriptors_codec);
      if (HitsAddend != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(HitsAddend);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Domain.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Domain);
      }
      size += descriptors_.CalculateSize(_repeated_descriptors_codec);
      if (HitsAddend != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HitsAddend);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RateLimitRequest other) {
      if (other == null) {
        return;
      }
      if (other.Domain.Length != 0) {
        Domain = other.Domain;
      }
      descriptors_.Add(other.descriptors_);
      if (other.HitsAddend != 0) {
        HitsAddend = other.HitsAddend;
      }
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
            Domain = input.ReadString();
            break;
          }
          case 18: {
            descriptors_.AddEntriesFrom(input, _repeated_descriptors_codec);
            break;
          }
          case 24: {
            HitsAddend = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A response from a ShouldRateLimit call.
  /// [#not-implemented-hide:] Hiding API for now.
  /// </summary>
  public sealed partial class RateLimitResponse : pb::IMessage<RateLimitResponse> {
    private static readonly pb::MessageParser<RateLimitResponse> _parser = new pb::MessageParser<RateLimitResponse>(() => new RateLimitResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RateLimitResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Service.Ratelimit.V2.RlsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitResponse(RateLimitResponse other) : this() {
      overallCode_ = other.overallCode_;
      statuses_ = other.statuses_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RateLimitResponse Clone() {
      return new RateLimitResponse(this);
    }

    /// <summary>Field number for the "overall_code" field.</summary>
    public const int OverallCodeFieldNumber = 1;
    private global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.Code overallCode_ = 0;
    /// <summary>
    /// The overall response code which takes into account all of the descriptors that were passed
    /// in the RateLimitRequest message.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.Code OverallCode {
      get { return overallCode_; }
      set {
        overallCode_ = value;
      }
    }

    /// <summary>Field number for the "statuses" field.</summary>
    public const int StatusesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.DescriptorStatus> _repeated_statuses_codec
        = pb::FieldCodec.ForMessage(18, global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.DescriptorStatus.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.DescriptorStatus> statuses_ = new pbc::RepeatedField<global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.DescriptorStatus>();
    /// <summary>
    /// A list of DescriptorStatus messages which matches the length of the descriptor list passed
    /// in the RateLimitRequest. This can be used by the caller to determine which individual
    /// descriptors failed and/or what the currently configured limits are for all of them.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.DescriptorStatus> Statuses {
      get { return statuses_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RateLimitResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RateLimitResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OverallCode != other.OverallCode) return false;
      if(!statuses_.Equals(other.statuses_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OverallCode != 0) hash ^= OverallCode.GetHashCode();
      hash ^= statuses_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (OverallCode != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OverallCode);
      }
      statuses_.WriteTo(output, _repeated_statuses_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OverallCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OverallCode);
      }
      size += statuses_.CalculateSize(_repeated_statuses_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RateLimitResponse other) {
      if (other == null) {
        return;
      }
      if (other.OverallCode != 0) {
        OverallCode = other.OverallCode;
      }
      statuses_.Add(other.statuses_);
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
            overallCode_ = (global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.Code) input.ReadEnum();
            break;
          }
          case 18: {
            statuses_.AddEntriesFrom(input, _repeated_statuses_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RateLimitResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Code {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("OK")] Ok = 1,
        [pbr::OriginalName("OVER_LIMIT")] OverLimit = 2,
      }

      /// <summary>
      /// Defines an actual rate limit in terms of requests per unit of time and the unit itself.
      /// </summary>
      public sealed partial class RateLimit : pb::IMessage<RateLimit> {
        private static readonly pb::MessageParser<RateLimit> _parser = new pb::MessageParser<RateLimit>(() => new RateLimit());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<RateLimit> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public RateLimit() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public RateLimit(RateLimit other) : this() {
          requestsPerUnit_ = other.requestsPerUnit_;
          unit_ = other.unit_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public RateLimit Clone() {
          return new RateLimit(this);
        }

        /// <summary>Field number for the "requests_per_unit" field.</summary>
        public const int RequestsPerUnitFieldNumber = 1;
        private uint requestsPerUnit_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint RequestsPerUnit {
          get { return requestsPerUnit_; }
          set {
            requestsPerUnit_ = value;
          }
        }

        /// <summary>Field number for the "unit" field.</summary>
        public const int UnitFieldNumber = 2;
        private global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.RateLimit.Types.Unit unit_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.RateLimit.Types.Unit Unit {
          get { return unit_; }
          set {
            unit_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as RateLimit);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(RateLimit other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (RequestsPerUnit != other.RequestsPerUnit) return false;
          if (Unit != other.Unit) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (RequestsPerUnit != 0) hash ^= RequestsPerUnit.GetHashCode();
          if (Unit != 0) hash ^= Unit.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (RequestsPerUnit != 0) {
            output.WriteRawTag(8);
            output.WriteUInt32(RequestsPerUnit);
          }
          if (Unit != 0) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Unit);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (RequestsPerUnit != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RequestsPerUnit);
          }
          if (Unit != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Unit);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(RateLimit other) {
          if (other == null) {
            return;
          }
          if (other.RequestsPerUnit != 0) {
            RequestsPerUnit = other.RequestsPerUnit;
          }
          if (other.Unit != 0) {
            Unit = other.Unit;
          }
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
                RequestsPerUnit = input.ReadUInt32();
                break;
              }
              case 16: {
                unit_ = (global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.RateLimit.Types.Unit) input.ReadEnum();
                break;
              }
            }
          }
        }

        #region Nested types
        /// <summary>Container for nested types declared in the RateLimit message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static partial class Types {
          public enum Unit {
            [pbr::OriginalName("UNKNOWN")] Unknown = 0,
            [pbr::OriginalName("SECOND")] Second = 1,
            [pbr::OriginalName("MINUTE")] Minute = 2,
            [pbr::OriginalName("HOUR")] Hour = 3,
            [pbr::OriginalName("DAY")] Day = 4,
          }

        }
        #endregion

      }

      public sealed partial class DescriptorStatus : pb::IMessage<DescriptorStatus> {
        private static readonly pb::MessageParser<DescriptorStatus> _parser = new pb::MessageParser<DescriptorStatus>(() => new DescriptorStatus());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<DescriptorStatus> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DescriptorStatus() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DescriptorStatus(DescriptorStatus other) : this() {
          code_ = other.code_;
          CurrentLimit = other.currentLimit_ != null ? other.CurrentLimit.Clone() : null;
          limitRemaining_ = other.limitRemaining_;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DescriptorStatus Clone() {
          return new DescriptorStatus(this);
        }

        /// <summary>Field number for the "code" field.</summary>
        public const int CodeFieldNumber = 1;
        private global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.Code code_ = 0;
        /// <summary>
        /// The response code for an individual descriptor.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.Code Code {
          get { return code_; }
          set {
            code_ = value;
          }
        }

        /// <summary>Field number for the "current_limit" field.</summary>
        public const int CurrentLimitFieldNumber = 2;
        private global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.RateLimit currentLimit_;
        /// <summary>
        /// The current limit as configured by the server. Useful for debugging, etc.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.RateLimit CurrentLimit {
          get { return currentLimit_; }
          set {
            currentLimit_ = value;
          }
        }

        /// <summary>Field number for the "limit_remaining" field.</summary>
        public const int LimitRemainingFieldNumber = 3;
        private uint limitRemaining_;
        /// <summary>
        /// The limit remaining in the current time unit.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public uint LimitRemaining {
          get { return limitRemaining_; }
          set {
            limitRemaining_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as DescriptorStatus);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(DescriptorStatus other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Code != other.Code) return false;
          if (!object.Equals(CurrentLimit, other.CurrentLimit)) return false;
          if (LimitRemaining != other.LimitRemaining) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Code != 0) hash ^= Code.GetHashCode();
          if (currentLimit_ != null) hash ^= CurrentLimit.GetHashCode();
          if (LimitRemaining != 0) hash ^= LimitRemaining.GetHashCode();
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Code != 0) {
            output.WriteRawTag(8);
            output.WriteEnum((int) Code);
          }
          if (currentLimit_ != null) {
            output.WriteRawTag(18);
            output.WriteMessage(CurrentLimit);
          }
          if (LimitRemaining != 0) {
            output.WriteRawTag(24);
            output.WriteUInt32(LimitRemaining);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Code != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Code);
          }
          if (currentLimit_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(CurrentLimit);
          }
          if (LimitRemaining != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LimitRemaining);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(DescriptorStatus other) {
          if (other == null) {
            return;
          }
          if (other.Code != 0) {
            Code = other.Code;
          }
          if (other.currentLimit_ != null) {
            if (currentLimit_ == null) {
              currentLimit_ = new global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.RateLimit();
            }
            CurrentLimit.MergeFrom(other.CurrentLimit);
          }
          if (other.LimitRemaining != 0) {
            LimitRemaining = other.LimitRemaining;
          }
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
                code_ = (global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.Code) input.ReadEnum();
                break;
              }
              case 18: {
                if (currentLimit_ == null) {
                  currentLimit_ = new global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Types.RateLimit();
                }
                input.ReadMessage(currentLimit_);
                break;
              }
              case 24: {
                LimitRemaining = input.ReadUInt32();
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
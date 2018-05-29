// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: als.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Accesslog.V2 {

  /// <summary>Holder for reflection information generated from als.proto</summary>
  public static partial class AlsReflection {

    #region Descriptor
    /// <summary>File descriptor for als.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AlsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CglhbHMucHJvdG8SGWVudm95LmNvbmZpZy5hY2Nlc3Nsb2cudjIaJGVudm95",
            "L2FwaS92Mi9jb3JlL2dycGNfc2VydmljZS5wcm90bxoXdmFsaWRhdGUvdmFs",
            "aWRhdGUucHJvdG8icQoWVGNwR3JwY0FjY2Vzc0xvZ0NvbmZpZxJXCg1jb21t",
            "b25fY29uZmlnGAEgASgLMjQuZW52b3kuY29uZmlnLmFjY2Vzc2xvZy52Mi5D",
            "b21tb25HcnBjQWNjZXNzTG9nQ29uZmlnQgq66cADBYoBAhABIskBChdIdHRw",
            "R3JwY0FjY2Vzc0xvZ0NvbmZpZxJXCg1jb21tb25fY29uZmlnGAEgASgLMjQu",
            "ZW52b3kuY29uZmlnLmFjY2Vzc2xvZy52Mi5Db21tb25HcnBjQWNjZXNzTG9n",
            "Q29uZmlnQgq66cADBYoBAhABEikKIWFkZGl0aW9uYWxfcmVxdWVzdF9oZWFk",
            "ZXJzX3RvX2xvZxgCIAMoCRIqCiJhZGRpdGlvbmFsX3Jlc3BvbnNlX2hlYWRl",
            "cnNfdG9fbG9nGAMgAygJInoKGUNvbW1vbkdycGNBY2Nlc3NMb2dDb25maWcS",
            "GwoIbG9nX25hbWUYASABKAlCCbrpwAMEcgIgARJACgxncnBjX3NlcnZpY2UY",
            "AiABKAsyHi5lbnZveS5hcGkudjIuY29yZS5HcnBjU2VydmljZUIKuunAAwWK",
            "AQIQAUIEWgJ2MmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Core.GrpcServiceReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Accesslog.V2.TcpGrpcAccessLogConfig), global::Envoy.Config.Accesslog.V2.TcpGrpcAccessLogConfig.Parser, new[]{ "CommonConfig" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Accesslog.V2.HttpGrpcAccessLogConfig), global::Envoy.Config.Accesslog.V2.HttpGrpcAccessLogConfig.Parser, new[]{ "CommonConfig", "AdditionalRequestHeadersToLog", "AdditionalResponseHeadersToLog" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Accesslog.V2.CommonGrpcAccessLogConfig), global::Envoy.Config.Accesslog.V2.CommonGrpcAccessLogConfig.Parser, new[]{ "LogName", "GrpcService" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configuration for the built-in *envoy.tcp_grpc_access_log* type. This configuration will
  /// populate *StreamAccessLogsMessage.tcp_logs*.
  /// [#not-implemented-hide:]
  /// [#comment:TODO(mattklein123): Block type in non-tcp proxy cases?]
  /// </summary>
  public sealed partial class TcpGrpcAccessLogConfig : pb::IMessage<TcpGrpcAccessLogConfig> {
    private static readonly pb::MessageParser<TcpGrpcAccessLogConfig> _parser = new pb::MessageParser<TcpGrpcAccessLogConfig>(() => new TcpGrpcAccessLogConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TcpGrpcAccessLogConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Accesslog.V2.AlsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TcpGrpcAccessLogConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TcpGrpcAccessLogConfig(TcpGrpcAccessLogConfig other) : this() {
      CommonConfig = other.commonConfig_ != null ? other.CommonConfig.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TcpGrpcAccessLogConfig Clone() {
      return new TcpGrpcAccessLogConfig(this);
    }

    /// <summary>Field number for the "common_config" field.</summary>
    public const int CommonConfigFieldNumber = 1;
    private global::Envoy.Config.Accesslog.V2.CommonGrpcAccessLogConfig commonConfig_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Accesslog.V2.CommonGrpcAccessLogConfig CommonConfig {
      get { return commonConfig_; }
      set {
        commonConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TcpGrpcAccessLogConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TcpGrpcAccessLogConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CommonConfig, other.CommonConfig)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (commonConfig_ != null) hash ^= CommonConfig.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (commonConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CommonConfig);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (commonConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CommonConfig);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TcpGrpcAccessLogConfig other) {
      if (other == null) {
        return;
      }
      if (other.commonConfig_ != null) {
        if (commonConfig_ == null) {
          commonConfig_ = new global::Envoy.Config.Accesslog.V2.CommonGrpcAccessLogConfig();
        }
        CommonConfig.MergeFrom(other.CommonConfig);
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
            if (commonConfig_ == null) {
              commonConfig_ = new global::Envoy.Config.Accesslog.V2.CommonGrpcAccessLogConfig();
            }
            input.ReadMessage(commonConfig_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Configuration for the built-in *envoy.http_grpc_access_log* type. This configuration will
  /// populate *StreamAccessLogsMessage.http_logs*.
  /// [#not-implemented-hide:]
  /// [#comment:TODO(mattklein123): Block type in non-http/router proxy cases?]
  /// </summary>
  public sealed partial class HttpGrpcAccessLogConfig : pb::IMessage<HttpGrpcAccessLogConfig> {
    private static readonly pb::MessageParser<HttpGrpcAccessLogConfig> _parser = new pb::MessageParser<HttpGrpcAccessLogConfig>(() => new HttpGrpcAccessLogConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HttpGrpcAccessLogConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Accesslog.V2.AlsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpGrpcAccessLogConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpGrpcAccessLogConfig(HttpGrpcAccessLogConfig other) : this() {
      CommonConfig = other.commonConfig_ != null ? other.CommonConfig.Clone() : null;
      additionalRequestHeadersToLog_ = other.additionalRequestHeadersToLog_.Clone();
      additionalResponseHeadersToLog_ = other.additionalResponseHeadersToLog_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HttpGrpcAccessLogConfig Clone() {
      return new HttpGrpcAccessLogConfig(this);
    }

    /// <summary>Field number for the "common_config" field.</summary>
    public const int CommonConfigFieldNumber = 1;
    private global::Envoy.Config.Accesslog.V2.CommonGrpcAccessLogConfig commonConfig_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Config.Accesslog.V2.CommonGrpcAccessLogConfig CommonConfig {
      get { return commonConfig_; }
      set {
        commonConfig_ = value;
      }
    }

    /// <summary>Field number for the "additional_request_headers_to_log" field.</summary>
    public const int AdditionalRequestHeadersToLogFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_additionalRequestHeadersToLog_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> additionalRequestHeadersToLog_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Additional request headers to log in *HTTPRequestProperties.request_headers*.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> AdditionalRequestHeadersToLog {
      get { return additionalRequestHeadersToLog_; }
    }

    /// <summary>Field number for the "additional_response_headers_to_log" field.</summary>
    public const int AdditionalResponseHeadersToLogFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_additionalResponseHeadersToLog_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> additionalResponseHeadersToLog_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Additional response headers to log in *HTTPResponseProperties.response_headers*.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> AdditionalResponseHeadersToLog {
      get { return additionalResponseHeadersToLog_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HttpGrpcAccessLogConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HttpGrpcAccessLogConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CommonConfig, other.CommonConfig)) return false;
      if(!additionalRequestHeadersToLog_.Equals(other.additionalRequestHeadersToLog_)) return false;
      if(!additionalResponseHeadersToLog_.Equals(other.additionalResponseHeadersToLog_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (commonConfig_ != null) hash ^= CommonConfig.GetHashCode();
      hash ^= additionalRequestHeadersToLog_.GetHashCode();
      hash ^= additionalResponseHeadersToLog_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (commonConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(CommonConfig);
      }
      additionalRequestHeadersToLog_.WriteTo(output, _repeated_additionalRequestHeadersToLog_codec);
      additionalResponseHeadersToLog_.WriteTo(output, _repeated_additionalResponseHeadersToLog_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (commonConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CommonConfig);
      }
      size += additionalRequestHeadersToLog_.CalculateSize(_repeated_additionalRequestHeadersToLog_codec);
      size += additionalResponseHeadersToLog_.CalculateSize(_repeated_additionalResponseHeadersToLog_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HttpGrpcAccessLogConfig other) {
      if (other == null) {
        return;
      }
      if (other.commonConfig_ != null) {
        if (commonConfig_ == null) {
          commonConfig_ = new global::Envoy.Config.Accesslog.V2.CommonGrpcAccessLogConfig();
        }
        CommonConfig.MergeFrom(other.CommonConfig);
      }
      additionalRequestHeadersToLog_.Add(other.additionalRequestHeadersToLog_);
      additionalResponseHeadersToLog_.Add(other.additionalResponseHeadersToLog_);
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
            if (commonConfig_ == null) {
              commonConfig_ = new global::Envoy.Config.Accesslog.V2.CommonGrpcAccessLogConfig();
            }
            input.ReadMessage(commonConfig_);
            break;
          }
          case 18: {
            additionalRequestHeadersToLog_.AddEntriesFrom(input, _repeated_additionalRequestHeadersToLog_codec);
            break;
          }
          case 26: {
            additionalResponseHeadersToLog_.AddEntriesFrom(input, _repeated_additionalResponseHeadersToLog_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Common configuration for gRPC access logs.
  /// [#not-implemented-hide:]
  /// </summary>
  public sealed partial class CommonGrpcAccessLogConfig : pb::IMessage<CommonGrpcAccessLogConfig> {
    private static readonly pb::MessageParser<CommonGrpcAccessLogConfig> _parser = new pb::MessageParser<CommonGrpcAccessLogConfig>(() => new CommonGrpcAccessLogConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommonGrpcAccessLogConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Accesslog.V2.AlsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonGrpcAccessLogConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonGrpcAccessLogConfig(CommonGrpcAccessLogConfig other) : this() {
      logName_ = other.logName_;
      GrpcService = other.grpcService_ != null ? other.GrpcService.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonGrpcAccessLogConfig Clone() {
      return new CommonGrpcAccessLogConfig(this);
    }

    /// <summary>Field number for the "log_name" field.</summary>
    public const int LogNameFieldNumber = 1;
    private string logName_ = "";
    /// <summary>
    /// The friendly name of the access log to be returned in StreamAccessLogsMessage.Identifier. This
    /// allows the access log server to differentiate between different access logs coming from the
    /// same Envoy.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LogName {
      get { return logName_; }
      set {
        logName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "grpc_service" field.</summary>
    public const int GrpcServiceFieldNumber = 2;
    private global::Envoy.Api.V2.Core.GrpcService grpcService_;
    /// <summary>
    /// The gRPC service for the access log service.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Envoy.Api.V2.Core.GrpcService GrpcService {
      get { return grpcService_; }
      set {
        grpcService_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommonGrpcAccessLogConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommonGrpcAccessLogConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LogName != other.LogName) return false;
      if (!object.Equals(GrpcService, other.GrpcService)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (LogName.Length != 0) hash ^= LogName.GetHashCode();
      if (grpcService_ != null) hash ^= GrpcService.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (LogName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(LogName);
      }
      if (grpcService_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GrpcService);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (LogName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LogName);
      }
      if (grpcService_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GrpcService);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommonGrpcAccessLogConfig other) {
      if (other == null) {
        return;
      }
      if (other.LogName.Length != 0) {
        LogName = other.LogName;
      }
      if (other.grpcService_ != null) {
        if (grpcService_ == null) {
          grpcService_ = new global::Envoy.Api.V2.Core.GrpcService();
        }
        GrpcService.MergeFrom(other.GrpcService);
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
            LogName = input.ReadString();
            break;
          }
          case 18: {
            if (grpcService_ == null) {
              grpcService_ = new global::Envoy.Api.V2.Core.GrpcService();
            }
            input.ReadMessage(grpcService_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
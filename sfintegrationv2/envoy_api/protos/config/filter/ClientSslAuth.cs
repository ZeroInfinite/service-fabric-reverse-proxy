// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: network/client_ssl_auth/v2/client_ssl_auth.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Envoy.Config.Filter.Network.ClientSslAuth.V2 {

  /// <summary>Holder for reflection information generated from network/client_ssl_auth/v2/client_ssl_auth.proto</summary>
  public static partial class ClientSslAuthReflection {

    #region Descriptor
    /// <summary>File descriptor for network/client_ssl_auth/v2/client_ssl_auth.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientSslAuthReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBuZXR3b3JrL2NsaWVudF9zc2xfYXV0aC92Mi9jbGllbnRfc3NsX2F1dGgu",
            "cHJvdG8SLmVudm95LmNvbmZpZy5maWx0ZXIubmV0d29yay5jbGllbnRfc3Ns",
            "X2F1dGgudjIaH2Vudm95L2FwaS92Mi9jb3JlL2FkZHJlc3MucHJvdG8aHmdv",
            "b2dsZS9wcm90b2J1Zi9kdXJhdGlvbi5wcm90bxoXdmFsaWRhdGUvdmFsaWRh",
            "dGUucHJvdG8aFGdvZ29wcm90by9nb2dvLnByb3RvIsEBCg1DbGllbnRTU0xB",
            "dXRoEiMKEGF1dGhfYXBpX2NsdXN0ZXIYASABKAlCCbrpwAMEcgIgARIeCgtz",
            "dGF0X3ByZWZpeBgCIAEoCUIJuunAAwRyAiABEjYKDXJlZnJlc2hfZGVsYXkY",
            "AyABKAsyGS5nb29nbGUucHJvdG9idWYuRHVyYXRpb25CBJjfHwESMwoNaXBf",
            "d2hpdGVfbGlzdBgEIAMoCzIcLmVudm95LmFwaS52Mi5jb3JlLkNpZHJSYW5n",
            "ZUIEWgJ2MmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Envoy.Api.V2.Core.AddressReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Validate.ValidateReflection.Descriptor, global::Gogoproto.GogoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Envoy.Config.Filter.Network.ClientSslAuth.V2.ClientSSLAuth), global::Envoy.Config.Filter.Network.ClientSslAuth.V2.ClientSSLAuth.Parser, new[]{ "AuthApiCluster", "StatPrefix", "RefreshDelay", "IpWhiteList" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientSSLAuth : pb::IMessage<ClientSSLAuth> {
    private static readonly pb::MessageParser<ClientSSLAuth> _parser = new pb::MessageParser<ClientSSLAuth>(() => new ClientSSLAuth());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientSSLAuth> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Envoy.Config.Filter.Network.ClientSslAuth.V2.ClientSslAuthReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientSSLAuth() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientSSLAuth(ClientSSLAuth other) : this() {
      authApiCluster_ = other.authApiCluster_;
      statPrefix_ = other.statPrefix_;
      RefreshDelay = other.refreshDelay_ != null ? other.RefreshDelay.Clone() : null;
      ipWhiteList_ = other.ipWhiteList_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientSSLAuth Clone() {
      return new ClientSSLAuth(this);
    }

    /// <summary>Field number for the "auth_api_cluster" field.</summary>
    public const int AuthApiClusterFieldNumber = 1;
    private string authApiCluster_ = "";
    /// <summary>
    /// The :ref:`cluster manager &lt;arch_overview_cluster_manager>` cluster that runs
    /// the authentication service. The filter will connect to the service every 60s to fetch the list
    /// of principals. The service must support the expected :ref:`REST API
    /// &lt;config_network_filters_client_ssl_auth_rest_api>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AuthApiCluster {
      get { return authApiCluster_; }
      set {
        authApiCluster_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "stat_prefix" field.</summary>
    public const int StatPrefixFieldNumber = 2;
    private string statPrefix_ = "";
    /// <summary>
    /// The prefix to use when emitting :ref:`statistics
    /// &lt;config_network_filters_client_ssl_auth_stats>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StatPrefix {
      get { return statPrefix_; }
      set {
        statPrefix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "refresh_delay" field.</summary>
    public const int RefreshDelayFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Duration refreshDelay_;
    /// <summary>
    /// Time in milliseconds between principal refreshes from the
    /// authentication service. Default is 60000 (60s). The actual fetch time
    /// will be this value plus a random jittered value between
    /// 0-refresh_delay_ms milliseconds.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration RefreshDelay {
      get { return refreshDelay_; }
      set {
        refreshDelay_ = value;
      }
    }

    /// <summary>Field number for the "ip_white_list" field.</summary>
    public const int IpWhiteListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Envoy.Api.V2.Core.CidrRange> _repeated_ipWhiteList_codec
        = pb::FieldCodec.ForMessage(34, global::Envoy.Api.V2.Core.CidrRange.Parser);
    private readonly pbc::RepeatedField<global::Envoy.Api.V2.Core.CidrRange> ipWhiteList_ = new pbc::RepeatedField<global::Envoy.Api.V2.Core.CidrRange>();
    /// <summary>
    /// An optional list of IP address and subnet masks that should be white
    /// listed for access by the filter. If no list is provided, there is no
    /// IP white list.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Envoy.Api.V2.Core.CidrRange> IpWhiteList {
      get { return ipWhiteList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientSSLAuth);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientSSLAuth other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AuthApiCluster != other.AuthApiCluster) return false;
      if (StatPrefix != other.StatPrefix) return false;
      if (!object.Equals(RefreshDelay, other.RefreshDelay)) return false;
      if(!ipWhiteList_.Equals(other.ipWhiteList_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AuthApiCluster.Length != 0) hash ^= AuthApiCluster.GetHashCode();
      if (StatPrefix.Length != 0) hash ^= StatPrefix.GetHashCode();
      if (refreshDelay_ != null) hash ^= RefreshDelay.GetHashCode();
      hash ^= ipWhiteList_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AuthApiCluster.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AuthApiCluster);
      }
      if (StatPrefix.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(StatPrefix);
      }
      if (refreshDelay_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RefreshDelay);
      }
      ipWhiteList_.WriteTo(output, _repeated_ipWhiteList_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AuthApiCluster.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AuthApiCluster);
      }
      if (StatPrefix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StatPrefix);
      }
      if (refreshDelay_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RefreshDelay);
      }
      size += ipWhiteList_.CalculateSize(_repeated_ipWhiteList_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientSSLAuth other) {
      if (other == null) {
        return;
      }
      if (other.AuthApiCluster.Length != 0) {
        AuthApiCluster = other.AuthApiCluster;
      }
      if (other.StatPrefix.Length != 0) {
        StatPrefix = other.StatPrefix;
      }
      if (other.refreshDelay_ != null) {
        if (refreshDelay_ == null) {
          refreshDelay_ = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        RefreshDelay.MergeFrom(other.RefreshDelay);
      }
      ipWhiteList_.Add(other.ipWhiteList_);
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
            AuthApiCluster = input.ReadString();
            break;
          }
          case 18: {
            StatPrefix = input.ReadString();
            break;
          }
          case 26: {
            if (refreshDelay_ == null) {
              refreshDelay_ = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(refreshDelay_);
            break;
          }
          case 34: {
            ipWhiteList_.AddEntriesFrom(input, _repeated_ipWhiteList_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
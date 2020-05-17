// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: protos/PMsgWelfareOnline.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Sw {

  /// <summary>Holder for reflection information generated from protos/PMsgWelfareOnline.proto</summary>
  public static partial class PMsgWelfareOnlineReflection {

    #region Descriptor
    /// <summary>File descriptor for protos/PMsgWelfareOnline.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PMsgWelfareOnlineReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5wcm90b3MvUE1zZ1dlbGZhcmVPbmxpbmUucHJvdG8SAnN3IjAKG1BNc2dX",
            "ZWxmYXJlT25saW5lUXVlcnlJbmZvQxIRCgluUmVzZXJ2ZWQYASABKAUiaQob",
            "UE1zZ1dlbGZhcmVPbmxpbmVRdWVyeUluZm9TEiAKGHVuT25saW5lUmV3YXJk",
            "RmV0Y2hMZXZlbBgBIAEoDRITCgt1bkNvdW50ZG93bhgCIAEoDRITCgt1bkVy",
            "cm9yQ29kZRhjIAEoDSI1Ch1QTXNnV2VsZmFyZU9ubGluZVN5bkNhbkZldGNo",
            "UxIUCgx1bkZldGNoTGV2ZWwYASABKA0iNQodUE1zZ1dlbGZhcmVPbmxpbmVG",
            "ZXRjaFJld2FyZEMSFAoMdW5GZXRjaExldmVsGAEgASgNIl8KHVBNc2dXZWxm",
            "YXJlT25saW5lRmV0Y2hSZXdhcmRTEhQKDHVuRmV0Y2hMZXZlbBgBIAEoDRIT",
            "Cgt1bkNvdW50ZG93bhgCIAEoDRITCgt1bkVycm9yQ29kZRhjIAEoDWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Sw.PMsgWelfareOnlineQueryInfoC), global::Sw.PMsgWelfareOnlineQueryInfoC.Parser, new[]{ "NReserved" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sw.PMsgWelfareOnlineQueryInfoS), global::Sw.PMsgWelfareOnlineQueryInfoS.Parser, new[]{ "UnOnlineRewardFetchLevel", "UnCountdown", "UnErrorCode" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sw.PMsgWelfareOnlineSynCanFetchS), global::Sw.PMsgWelfareOnlineSynCanFetchS.Parser, new[]{ "UnFetchLevel" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sw.PMsgWelfareOnlineFetchRewardC), global::Sw.PMsgWelfareOnlineFetchRewardC.Parser, new[]{ "UnFetchLevel" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sw.PMsgWelfareOnlineFetchRewardS), global::Sw.PMsgWelfareOnlineFetchRewardS.Parser, new[]{ "UnFetchLevel", "UnCountdown", "UnErrorCode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 客户端：查询当天在线领取奖励信息请求
  /// _MSG_WELFAREONLINE_QUERY_INFO_C
  /// </summary>
  public sealed partial class PMsgWelfareOnlineQueryInfoC : pb::IMessage<PMsgWelfareOnlineQueryInfoC> {
    private static readonly pb::MessageParser<PMsgWelfareOnlineQueryInfoC> _parser = new pb::MessageParser<PMsgWelfareOnlineQueryInfoC>(() => new PMsgWelfareOnlineQueryInfoC());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PMsgWelfareOnlineQueryInfoC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sw.PMsgWelfareOnlineReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineQueryInfoC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineQueryInfoC(PMsgWelfareOnlineQueryInfoC other) : this() {
      nReserved_ = other.nReserved_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineQueryInfoC Clone() {
      return new PMsgWelfareOnlineQueryInfoC(this);
    }

    /// <summary>Field number for the "nReserved" field.</summary>
    public const int NReservedFieldNumber = 1;
    private int nReserved_;
    /// <summary>
    /// 保留字段
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NReserved {
      get { return nReserved_; }
      set {
        nReserved_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PMsgWelfareOnlineQueryInfoC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PMsgWelfareOnlineQueryInfoC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NReserved != other.NReserved) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (NReserved != 0) hash ^= NReserved.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (NReserved != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(NReserved);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (NReserved != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NReserved);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PMsgWelfareOnlineQueryInfoC other) {
      if (other == null) {
        return;
      }
      if (other.NReserved != 0) {
        NReserved = other.NReserved;
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
            NReserved = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 服务端：查询当天在线领取奖励信息请求回复
  /// _MSG_WELFAREONLINE_QUERY_INFO_S
  /// </summary>
  public sealed partial class PMsgWelfareOnlineQueryInfoS : pb::IMessage<PMsgWelfareOnlineQueryInfoS> {
    private static readonly pb::MessageParser<PMsgWelfareOnlineQueryInfoS> _parser = new pb::MessageParser<PMsgWelfareOnlineQueryInfoS>(() => new PMsgWelfareOnlineQueryInfoS());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PMsgWelfareOnlineQueryInfoS> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sw.PMsgWelfareOnlineReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineQueryInfoS() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineQueryInfoS(PMsgWelfareOnlineQueryInfoS other) : this() {
      unOnlineRewardFetchLevel_ = other.unOnlineRewardFetchLevel_;
      unCountdown_ = other.unCountdown_;
      unErrorCode_ = other.unErrorCode_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineQueryInfoS Clone() {
      return new PMsgWelfareOnlineQueryInfoS(this);
    }

    /// <summary>Field number for the "unOnlineRewardFetchLevel" field.</summary>
    public const int UnOnlineRewardFetchLevelFieldNumber = 1;
    private uint unOnlineRewardFetchLevel_;
    /// <summary>
    /// 下一次领取的阶段,从1阶段开始累计
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint UnOnlineRewardFetchLevel {
      get { return unOnlineRewardFetchLevel_; }
      set {
        unOnlineRewardFetchLevel_ = value;
      }
    }

    /// <summary>Field number for the "unCountdown" field.</summary>
    public const int UnCountdownFieldNumber = 2;
    private uint unCountdown_;
    /// <summary>
    /// 下一次领取在线奖励的倒计时(秒),0表示可以领取
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint UnCountdown {
      get { return unCountdown_; }
      set {
        unCountdown_ = value;
      }
    }

    /// <summary>Field number for the "unErrorCode" field.</summary>
    public const int UnErrorCodeFieldNumber = 99;
    private uint unErrorCode_;
    /// <summary>
    /// 返回错误码 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint UnErrorCode {
      get { return unErrorCode_; }
      set {
        unErrorCode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PMsgWelfareOnlineQueryInfoS);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PMsgWelfareOnlineQueryInfoS other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnOnlineRewardFetchLevel != other.UnOnlineRewardFetchLevel) return false;
      if (UnCountdown != other.UnCountdown) return false;
      if (UnErrorCode != other.UnErrorCode) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UnOnlineRewardFetchLevel != 0) hash ^= UnOnlineRewardFetchLevel.GetHashCode();
      if (UnCountdown != 0) hash ^= UnCountdown.GetHashCode();
      if (UnErrorCode != 0) hash ^= UnErrorCode.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UnOnlineRewardFetchLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UnOnlineRewardFetchLevel);
      }
      if (UnCountdown != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(UnCountdown);
      }
      if (UnErrorCode != 0) {
        output.WriteRawTag(152, 6);
        output.WriteUInt32(UnErrorCode);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UnOnlineRewardFetchLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnOnlineRewardFetchLevel);
      }
      if (UnCountdown != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnCountdown);
      }
      if (UnErrorCode != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(UnErrorCode);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PMsgWelfareOnlineQueryInfoS other) {
      if (other == null) {
        return;
      }
      if (other.UnOnlineRewardFetchLevel != 0) {
        UnOnlineRewardFetchLevel = other.UnOnlineRewardFetchLevel;
      }
      if (other.UnCountdown != 0) {
        UnCountdown = other.UnCountdown;
      }
      if (other.UnErrorCode != 0) {
        UnErrorCode = other.UnErrorCode;
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
            UnOnlineRewardFetchLevel = input.ReadUInt32();
            break;
          }
          case 16: {
            UnCountdown = input.ReadUInt32();
            break;
          }
          case 792: {
            UnErrorCode = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 服务端：通知客户端可以领取奖励了
  /// _MSG_WELFAREONLINE_SYN_CAN_FETCH_S
  /// </summary>
  public sealed partial class PMsgWelfareOnlineSynCanFetchS : pb::IMessage<PMsgWelfareOnlineSynCanFetchS> {
    private static readonly pb::MessageParser<PMsgWelfareOnlineSynCanFetchS> _parser = new pb::MessageParser<PMsgWelfareOnlineSynCanFetchS>(() => new PMsgWelfareOnlineSynCanFetchS());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PMsgWelfareOnlineSynCanFetchS> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sw.PMsgWelfareOnlineReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineSynCanFetchS() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineSynCanFetchS(PMsgWelfareOnlineSynCanFetchS other) : this() {
      unFetchLevel_ = other.unFetchLevel_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineSynCanFetchS Clone() {
      return new PMsgWelfareOnlineSynCanFetchS(this);
    }

    /// <summary>Field number for the "unFetchLevel" field.</summary>
    public const int UnFetchLevelFieldNumber = 1;
    private uint unFetchLevel_;
    /// <summary>
    /// 可以领取第几个分钟阶段
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint UnFetchLevel {
      get { return unFetchLevel_; }
      set {
        unFetchLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PMsgWelfareOnlineSynCanFetchS);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PMsgWelfareOnlineSynCanFetchS other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnFetchLevel != other.UnFetchLevel) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UnFetchLevel != 0) hash ^= UnFetchLevel.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UnFetchLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UnFetchLevel);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UnFetchLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnFetchLevel);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PMsgWelfareOnlineSynCanFetchS other) {
      if (other == null) {
        return;
      }
      if (other.UnFetchLevel != 0) {
        UnFetchLevel = other.UnFetchLevel;
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
            UnFetchLevel = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 客户端：领取在线奖励
  /// _MSG_WELFAREONLINE_FETCH_REWARD_C
  /// </summary>
  public sealed partial class PMsgWelfareOnlineFetchRewardC : pb::IMessage<PMsgWelfareOnlineFetchRewardC> {
    private static readonly pb::MessageParser<PMsgWelfareOnlineFetchRewardC> _parser = new pb::MessageParser<PMsgWelfareOnlineFetchRewardC>(() => new PMsgWelfareOnlineFetchRewardC());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PMsgWelfareOnlineFetchRewardC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sw.PMsgWelfareOnlineReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineFetchRewardC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineFetchRewardC(PMsgWelfareOnlineFetchRewardC other) : this() {
      unFetchLevel_ = other.unFetchLevel_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineFetchRewardC Clone() {
      return new PMsgWelfareOnlineFetchRewardC(this);
    }

    /// <summary>Field number for the "unFetchLevel" field.</summary>
    public const int UnFetchLevelFieldNumber = 1;
    private uint unFetchLevel_;
    /// <summary>
    /// 第几个分钟阶段,现在配置有6个阶段,具体看配置
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint UnFetchLevel {
      get { return unFetchLevel_; }
      set {
        unFetchLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PMsgWelfareOnlineFetchRewardC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PMsgWelfareOnlineFetchRewardC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnFetchLevel != other.UnFetchLevel) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UnFetchLevel != 0) hash ^= UnFetchLevel.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UnFetchLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UnFetchLevel);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UnFetchLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnFetchLevel);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PMsgWelfareOnlineFetchRewardC other) {
      if (other == null) {
        return;
      }
      if (other.UnFetchLevel != 0) {
        UnFetchLevel = other.UnFetchLevel;
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
            UnFetchLevel = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 服务端：领取在线奖励回复
  /// _MSG_WELFAREONLINE_FETCH_REWARD_S
  /// </summary>
  public sealed partial class PMsgWelfareOnlineFetchRewardS : pb::IMessage<PMsgWelfareOnlineFetchRewardS> {
    private static readonly pb::MessageParser<PMsgWelfareOnlineFetchRewardS> _parser = new pb::MessageParser<PMsgWelfareOnlineFetchRewardS>(() => new PMsgWelfareOnlineFetchRewardS());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PMsgWelfareOnlineFetchRewardS> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sw.PMsgWelfareOnlineReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineFetchRewardS() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineFetchRewardS(PMsgWelfareOnlineFetchRewardS other) : this() {
      unFetchLevel_ = other.unFetchLevel_;
      unCountdown_ = other.unCountdown_;
      unErrorCode_ = other.unErrorCode_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgWelfareOnlineFetchRewardS Clone() {
      return new PMsgWelfareOnlineFetchRewardS(this);
    }

    /// <summary>Field number for the "unFetchLevel" field.</summary>
    public const int UnFetchLevelFieldNumber = 1;
    private uint unFetchLevel_;
    /// <summary>
    /// 第几个分钟阶段(下一次领取的阶段)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint UnFetchLevel {
      get { return unFetchLevel_; }
      set {
        unFetchLevel_ = value;
      }
    }

    /// <summary>Field number for the "unCountdown" field.</summary>
    public const int UnCountdownFieldNumber = 2;
    private uint unCountdown_;
    /// <summary>
    /// 下一次领取在线奖励的倒计时(秒)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint UnCountdown {
      get { return unCountdown_; }
      set {
        unCountdown_ = value;
      }
    }

    /// <summary>Field number for the "unErrorCode" field.</summary>
    public const int UnErrorCodeFieldNumber = 99;
    private uint unErrorCode_;
    /// <summary>
    /// 返回错误码 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint UnErrorCode {
      get { return unErrorCode_; }
      set {
        unErrorCode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PMsgWelfareOnlineFetchRewardS);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PMsgWelfareOnlineFetchRewardS other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnFetchLevel != other.UnFetchLevel) return false;
      if (UnCountdown != other.UnCountdown) return false;
      if (UnErrorCode != other.UnErrorCode) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UnFetchLevel != 0) hash ^= UnFetchLevel.GetHashCode();
      if (UnCountdown != 0) hash ^= UnCountdown.GetHashCode();
      if (UnErrorCode != 0) hash ^= UnErrorCode.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UnFetchLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(UnFetchLevel);
      }
      if (UnCountdown != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(UnCountdown);
      }
      if (UnErrorCode != 0) {
        output.WriteRawTag(152, 6);
        output.WriteUInt32(UnErrorCode);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UnFetchLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnFetchLevel);
      }
      if (UnCountdown != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnCountdown);
      }
      if (UnErrorCode != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(UnErrorCode);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PMsgWelfareOnlineFetchRewardS other) {
      if (other == null) {
        return;
      }
      if (other.UnFetchLevel != 0) {
        UnFetchLevel = other.UnFetchLevel;
      }
      if (other.UnCountdown != 0) {
        UnCountdown = other.UnCountdown;
      }
      if (other.UnErrorCode != 0) {
        UnErrorCode = other.UnErrorCode;
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
            UnFetchLevel = input.ReadUInt32();
            break;
          }
          case 16: {
            UnCountdown = input.ReadUInt32();
            break;
          }
          case 792: {
            UnErrorCode = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

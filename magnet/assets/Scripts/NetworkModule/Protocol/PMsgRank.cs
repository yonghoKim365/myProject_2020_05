// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: protos/PMsgRank.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Sw {

  /// <summary>Holder for reflection information generated from protos/PMsgRank.proto</summary>
  public static partial class PMsgRankReflection {

    #region Descriptor
    /// <summary>File descriptor for protos/PMsgRank.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PMsgRankReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVwcm90b3MvUE1zZ1JhbmsucHJvdG8SAnN3IiQKDlBNc2dSYW5rUXVlcnlD",
            "EhIKCnVuUmFua1R5cGUYASABKAUihwEKCFJhbmtJbmZvEg4KBnVuUmFuaxgB",
            "IAEoBRIRCgl1bGxSb2xlSWQYAiABKAMSEgoKdW5Sb2xlVHlwZRgDIAEoBRIO",
            "CgZzek5hbWUYBCABKAkSDwoHdW5MZXZlbBgFIAEoBRIPCgd1bGxEYXRhGAYg",
            "ASgDEhIKCnVuVmlwTGV2ZWwYByABKAUidwoOUE1zZ1JhbmtRdWVyeVMSEgoK",
            "dW5SYW5rVHlwZRgBIAEoBRIQCgh1bk15UmFuaxgCIAEoBRIPCgd1bkNvdW50",
            "GAMgASgFEhsKBWNJbmZvGAQgAygLMgwuc3cuUmFua0luZm8SEQoJdWxsTXlE",
            "YXRhGAUgASgDIikKE1BNc2dSYW5rR3VpbGRRdWVyeUMSEgoKdW5SYW5rVHlw",
            "ZRgBIAEoBSJ8ChNQTXNnUmFua0d1aWxkUXVlcnlTEhIKCnVuUmFua1R5cGUY",
            "ASABKAUSEAoIdW5NeVJhbmsYAiABKAUSDwoHdW5Db3VudBgDIAEoBRIbCgVj",
            "SW5mbxgEIAMoCzIMLnN3LlJhbmtJbmZvEhEKCXVsbE15RGF0YRgFIAEoA2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Sw.PMsgRankQueryC), global::Sw.PMsgRankQueryC.Parser, new[]{ "UnRankType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sw.RankInfo), global::Sw.RankInfo.Parser, new[]{ "UnRank", "UllRoleId", "UnRoleType", "SzName", "UnLevel", "UllData", "UnVipLevel" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sw.PMsgRankQueryS), global::Sw.PMsgRankQueryS.Parser, new[]{ "UnRankType", "UnMyRank", "UnCount", "CInfo", "UllMyData" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sw.PMsgRankGuildQueryC), global::Sw.PMsgRankGuildQueryC.Parser, new[]{ "UnRankType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Sw.PMsgRankGuildQueryS), global::Sw.PMsgRankGuildQueryS.Parser, new[]{ "UnRankType", "UnMyRank", "UnCount", "CInfo", "UllMyData" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 客户端：查询排行榜列表
  /// _MSG_RANK_QUERY_C
  /// </summary>
  public sealed partial class PMsgRankQueryC : pb::IMessage<PMsgRankQueryC> {
    private static readonly pb::MessageParser<PMsgRankQueryC> _parser = new pb::MessageParser<PMsgRankQueryC>(() => new PMsgRankQueryC());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PMsgRankQueryC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sw.PMsgRankReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgRankQueryC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgRankQueryC(PMsgRankQueryC other) : this() {
      unRankType_ = other.unRankType_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgRankQueryC Clone() {
      return new PMsgRankQueryC(this);
    }

    /// <summary>Field number for the "unRankType" field.</summary>
    public const int UnRankTypeFieldNumber = 1;
    private int unRankType_;
    /// <summary>
    /// 排行榜类型(sw::RANK_TYPE)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnRankType {
      get { return unRankType_; }
      set {
        unRankType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PMsgRankQueryC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PMsgRankQueryC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnRankType != other.UnRankType) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UnRankType != 0) hash ^= UnRankType.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UnRankType != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UnRankType);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UnRankType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnRankType);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PMsgRankQueryC other) {
      if (other == null) {
        return;
      }
      if (other.UnRankType != 0) {
        UnRankType = other.UnRankType;
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
            UnRankType = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 排行榜信息
  /// </summary>
  public sealed partial class RankInfo : pb::IMessage<RankInfo> {
    private static readonly pb::MessageParser<RankInfo> _parser = new pb::MessageParser<RankInfo>(() => new RankInfo());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RankInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sw.PMsgRankReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RankInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RankInfo(RankInfo other) : this() {
      unRank_ = other.unRank_;
      ullRoleId_ = other.ullRoleId_;
      unRoleType_ = other.unRoleType_;
      szName_ = other.szName_;
      unLevel_ = other.unLevel_;
      ullData_ = other.ullData_;
      unVipLevel_ = other.unVipLevel_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RankInfo Clone() {
      return new RankInfo(this);
    }

    /// <summary>Field number for the "unRank" field.</summary>
    public const int UnRankFieldNumber = 1;
    private int unRank_;
    /// <summary>
    /// 名次
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnRank {
      get { return unRank_; }
      set {
        unRank_ = value;
      }
    }

    /// <summary>Field number for the "ullRoleId" field.</summary>
    public const int UllRoleIdFieldNumber = 2;
    private long ullRoleId_;
    /// <summary>
    /// 角色id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long UllRoleId {
      get { return ullRoleId_; }
      set {
        ullRoleId_ = value;
      }
    }

    /// <summary>Field number for the "unRoleType" field.</summary>
    public const int UnRoleTypeFieldNumber = 3;
    private int unRoleType_;
    /// <summary>
    /// 角色类型
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnRoleType {
      get { return unRoleType_; }
      set {
        unRoleType_ = value;
      }
    }

    /// <summary>Field number for the "szName" field.</summary>
    public const int SzNameFieldNumber = 4;
    private string szName_ = "";
    /// <summary>
    /// 角色名字
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SzName {
      get { return szName_; }
      set {
        szName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unLevel" field.</summary>
    public const int UnLevelFieldNumber = 5;
    private int unLevel_;
    /// <summary>
    /// 角色等级
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnLevel {
      get { return unLevel_; }
      set {
        unLevel_ = value;
      }
    }

    /// <summary>Field number for the "ullData" field.</summary>
    public const int UllDataFieldNumber = 6;
    private long ullData_;
    /// <summary>
    /// 排行数据
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long UllData {
      get { return ullData_; }
      set {
        ullData_ = value;
      }
    }

    /// <summary>Field number for the "unVipLevel" field.</summary>
    public const int UnVipLevelFieldNumber = 7;
    private int unVipLevel_;
    /// <summary>
    /// Vip等级
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnVipLevel {
      get { return unVipLevel_; }
      set {
        unVipLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RankInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RankInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnRank != other.UnRank) return false;
      if (UllRoleId != other.UllRoleId) return false;
      if (UnRoleType != other.UnRoleType) return false;
      if (SzName != other.SzName) return false;
      if (UnLevel != other.UnLevel) return false;
      if (UllData != other.UllData) return false;
      if (UnVipLevel != other.UnVipLevel) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UnRank != 0) hash ^= UnRank.GetHashCode();
      if (UllRoleId != 0L) hash ^= UllRoleId.GetHashCode();
      if (UnRoleType != 0) hash ^= UnRoleType.GetHashCode();
      if (SzName.Length != 0) hash ^= SzName.GetHashCode();
      if (UnLevel != 0) hash ^= UnLevel.GetHashCode();
      if (UllData != 0L) hash ^= UllData.GetHashCode();
      if (UnVipLevel != 0) hash ^= UnVipLevel.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UnRank != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UnRank);
      }
      if (UllRoleId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(UllRoleId);
      }
      if (UnRoleType != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(UnRoleType);
      }
      if (SzName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(SzName);
      }
      if (UnLevel != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(UnLevel);
      }
      if (UllData != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(UllData);
      }
      if (UnVipLevel != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(UnVipLevel);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UnRank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnRank);
      }
      if (UllRoleId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UllRoleId);
      }
      if (UnRoleType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnRoleType);
      }
      if (SzName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SzName);
      }
      if (UnLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnLevel);
      }
      if (UllData != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UllData);
      }
      if (UnVipLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnVipLevel);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RankInfo other) {
      if (other == null) {
        return;
      }
      if (other.UnRank != 0) {
        UnRank = other.UnRank;
      }
      if (other.UllRoleId != 0L) {
        UllRoleId = other.UllRoleId;
      }
      if (other.UnRoleType != 0) {
        UnRoleType = other.UnRoleType;
      }
      if (other.SzName.Length != 0) {
        SzName = other.SzName;
      }
      if (other.UnLevel != 0) {
        UnLevel = other.UnLevel;
      }
      if (other.UllData != 0L) {
        UllData = other.UllData;
      }
      if (other.UnVipLevel != 0) {
        UnVipLevel = other.UnVipLevel;
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
            UnRank = input.ReadInt32();
            break;
          }
          case 16: {
            UllRoleId = input.ReadInt64();
            break;
          }
          case 24: {
            UnRoleType = input.ReadInt32();
            break;
          }
          case 34: {
            SzName = input.ReadString();
            break;
          }
          case 40: {
            UnLevel = input.ReadInt32();
            break;
          }
          case 48: {
            UllData = input.ReadInt64();
            break;
          }
          case 56: {
            UnVipLevel = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 服务器：查询排行榜列表回复
  /// _MSG_RANK_QUERY_S
  /// </summary>
  public sealed partial class PMsgRankQueryS : pb::IMessage<PMsgRankQueryS> {
    private static readonly pb::MessageParser<PMsgRankQueryS> _parser = new pb::MessageParser<PMsgRankQueryS>(() => new PMsgRankQueryS());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PMsgRankQueryS> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sw.PMsgRankReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgRankQueryS() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgRankQueryS(PMsgRankQueryS other) : this() {
      unRankType_ = other.unRankType_;
      unMyRank_ = other.unMyRank_;
      unCount_ = other.unCount_;
      cInfo_ = other.cInfo_.Clone();
      ullMyData_ = other.ullMyData_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgRankQueryS Clone() {
      return new PMsgRankQueryS(this);
    }

    /// <summary>Field number for the "unRankType" field.</summary>
    public const int UnRankTypeFieldNumber = 1;
    private int unRankType_;
    /// <summary>
    /// 排行榜类型(sw::RANK_TYPE)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnRankType {
      get { return unRankType_; }
      set {
        unRankType_ = value;
      }
    }

    /// <summary>Field number for the "unMyRank" field.</summary>
    public const int UnMyRankFieldNumber = 2;
    private int unMyRank_;
    /// <summary>
    /// 自己的名次
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnMyRank {
      get { return unMyRank_; }
      set {
        unMyRank_ = value;
      }
    }

    /// <summary>Field number for the "unCount" field.</summary>
    public const int UnCountFieldNumber = 3;
    private int unCount_;
    /// <summary>
    /// 排行榜数量
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnCount {
      get { return unCount_; }
      set {
        unCount_ = value;
      }
    }

    /// <summary>Field number for the "cInfo" field.</summary>
    public const int CInfoFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Sw.RankInfo> _repeated_cInfo_codec
        = pb::FieldCodec.ForMessage(34, global::Sw.RankInfo.Parser);
    private readonly pbc::RepeatedField<global::Sw.RankInfo> cInfo_ = new pbc::RepeatedField<global::Sw.RankInfo>();
    /// <summary>
    /// 排行榜信息列表
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Sw.RankInfo> CInfo {
      get { return cInfo_; }
    }

    /// <summary>Field number for the "ullMyData" field.</summary>
    public const int UllMyDataFieldNumber = 5;
    private long ullMyData_;
    /// <summary>
    /// 自己的数据
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long UllMyData {
      get { return ullMyData_; }
      set {
        ullMyData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PMsgRankQueryS);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PMsgRankQueryS other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnRankType != other.UnRankType) return false;
      if (UnMyRank != other.UnMyRank) return false;
      if (UnCount != other.UnCount) return false;
      if(!cInfo_.Equals(other.cInfo_)) return false;
      if (UllMyData != other.UllMyData) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UnRankType != 0) hash ^= UnRankType.GetHashCode();
      if (UnMyRank != 0) hash ^= UnMyRank.GetHashCode();
      if (UnCount != 0) hash ^= UnCount.GetHashCode();
      hash ^= cInfo_.GetHashCode();
      if (UllMyData != 0L) hash ^= UllMyData.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UnRankType != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UnRankType);
      }
      if (UnMyRank != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(UnMyRank);
      }
      if (UnCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(UnCount);
      }
      cInfo_.WriteTo(output, _repeated_cInfo_codec);
      if (UllMyData != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(UllMyData);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UnRankType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnRankType);
      }
      if (UnMyRank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnMyRank);
      }
      if (UnCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnCount);
      }
      size += cInfo_.CalculateSize(_repeated_cInfo_codec);
      if (UllMyData != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UllMyData);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PMsgRankQueryS other) {
      if (other == null) {
        return;
      }
      if (other.UnRankType != 0) {
        UnRankType = other.UnRankType;
      }
      if (other.UnMyRank != 0) {
        UnMyRank = other.UnMyRank;
      }
      if (other.UnCount != 0) {
        UnCount = other.UnCount;
      }
      cInfo_.Add(other.cInfo_);
      if (other.UllMyData != 0L) {
        UllMyData = other.UllMyData;
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
            UnRankType = input.ReadInt32();
            break;
          }
          case 16: {
            UnMyRank = input.ReadInt32();
            break;
          }
          case 24: {
            UnCount = input.ReadInt32();
            break;
          }
          case 34: {
            cInfo_.AddEntriesFrom(input, _repeated_cInfo_codec);
            break;
          }
          case 40: {
            UllMyData = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 客户端：查询帮会排行榜列表
  /// _MSG_RANK_GUILD_QUERY_C
  /// </summary>
  public sealed partial class PMsgRankGuildQueryC : pb::IMessage<PMsgRankGuildQueryC> {
    private static readonly pb::MessageParser<PMsgRankGuildQueryC> _parser = new pb::MessageParser<PMsgRankGuildQueryC>(() => new PMsgRankGuildQueryC());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PMsgRankGuildQueryC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sw.PMsgRankReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgRankGuildQueryC() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgRankGuildQueryC(PMsgRankGuildQueryC other) : this() {
      unRankType_ = other.unRankType_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgRankGuildQueryC Clone() {
      return new PMsgRankGuildQueryC(this);
    }

    /// <summary>Field number for the "unRankType" field.</summary>
    public const int UnRankTypeFieldNumber = 1;
    private int unRankType_;
    /// <summary>
    /// 排行榜类型(sw::RANK_TYPE) RANK_TYPE_GUILD_LEVEL or RANK_TYPE_GUILD_BLESS RANK_TYPE_GUILD_WAR_POINT
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnRankType {
      get { return unRankType_; }
      set {
        unRankType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PMsgRankGuildQueryC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PMsgRankGuildQueryC other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnRankType != other.UnRankType) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UnRankType != 0) hash ^= UnRankType.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UnRankType != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UnRankType);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UnRankType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnRankType);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PMsgRankGuildQueryC other) {
      if (other == null) {
        return;
      }
      if (other.UnRankType != 0) {
        UnRankType = other.UnRankType;
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
            UnRankType = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 服务器：查询帮会排行榜列表回复
  /// _MSG_RANK_GUILD_QUERY_S
  /// </summary>
  public sealed partial class PMsgRankGuildQueryS : pb::IMessage<PMsgRankGuildQueryS> {
    private static readonly pb::MessageParser<PMsgRankGuildQueryS> _parser = new pb::MessageParser<PMsgRankGuildQueryS>(() => new PMsgRankGuildQueryS());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PMsgRankGuildQueryS> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Sw.PMsgRankReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgRankGuildQueryS() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgRankGuildQueryS(PMsgRankGuildQueryS other) : this() {
      unRankType_ = other.unRankType_;
      unMyRank_ = other.unMyRank_;
      unCount_ = other.unCount_;
      cInfo_ = other.cInfo_.Clone();
      ullMyData_ = other.ullMyData_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PMsgRankGuildQueryS Clone() {
      return new PMsgRankGuildQueryS(this);
    }

    /// <summary>Field number for the "unRankType" field.</summary>
    public const int UnRankTypeFieldNumber = 1;
    private int unRankType_;
    /// <summary>
    /// 排行榜类型(sw::RANK_TYPE) RANK_TYPE_GUILD_LEVEL or RANK_TYPE_GUILD_BLESS
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnRankType {
      get { return unRankType_; }
      set {
        unRankType_ = value;
      }
    }

    /// <summary>Field number for the "unMyRank" field.</summary>
    public const int UnMyRankFieldNumber = 2;
    private int unMyRank_;
    /// <summary>
    /// 自己的名次
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnMyRank {
      get { return unMyRank_; }
      set {
        unMyRank_ = value;
      }
    }

    /// <summary>Field number for the "unCount" field.</summary>
    public const int UnCountFieldNumber = 3;
    private int unCount_;
    /// <summary>
    /// 排行榜数量
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UnCount {
      get { return unCount_; }
      set {
        unCount_ = value;
      }
    }

    /// <summary>Field number for the "cInfo" field.</summary>
    public const int CInfoFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Sw.RankInfo> _repeated_cInfo_codec
        = pb::FieldCodec.ForMessage(34, global::Sw.RankInfo.Parser);
    private readonly pbc::RepeatedField<global::Sw.RankInfo> cInfo_ = new pbc::RepeatedField<global::Sw.RankInfo>();
    /// <summary>
    /// 排行榜信息列表
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Sw.RankInfo> CInfo {
      get { return cInfo_; }
    }

    /// <summary>Field number for the "ullMyData" field.</summary>
    public const int UllMyDataFieldNumber = 5;
    private long ullMyData_;
    /// <summary>
    /// 自己的数据
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long UllMyData {
      get { return ullMyData_; }
      set {
        ullMyData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PMsgRankGuildQueryS);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PMsgRankGuildQueryS other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UnRankType != other.UnRankType) return false;
      if (UnMyRank != other.UnMyRank) return false;
      if (UnCount != other.UnCount) return false;
      if(!cInfo_.Equals(other.cInfo_)) return false;
      if (UllMyData != other.UllMyData) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UnRankType != 0) hash ^= UnRankType.GetHashCode();
      if (UnMyRank != 0) hash ^= UnMyRank.GetHashCode();
      if (UnCount != 0) hash ^= UnCount.GetHashCode();
      hash ^= cInfo_.GetHashCode();
      if (UllMyData != 0L) hash ^= UllMyData.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (UnRankType != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(UnRankType);
      }
      if (UnMyRank != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(UnMyRank);
      }
      if (UnCount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(UnCount);
      }
      cInfo_.WriteTo(output, _repeated_cInfo_codec);
      if (UllMyData != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(UllMyData);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UnRankType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnRankType);
      }
      if (UnMyRank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnMyRank);
      }
      if (UnCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UnCount);
      }
      size += cInfo_.CalculateSize(_repeated_cInfo_codec);
      if (UllMyData != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UllMyData);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PMsgRankGuildQueryS other) {
      if (other == null) {
        return;
      }
      if (other.UnRankType != 0) {
        UnRankType = other.UnRankType;
      }
      if (other.UnMyRank != 0) {
        UnMyRank = other.UnMyRank;
      }
      if (other.UnCount != 0) {
        UnCount = other.UnCount;
      }
      cInfo_.Add(other.cInfo_);
      if (other.UllMyData != 0L) {
        UllMyData = other.UllMyData;
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
            UnRankType = input.ReadInt32();
            break;
          }
          case 16: {
            UnMyRank = input.ReadInt32();
            break;
          }
          case 24: {
            UnCount = input.ReadInt32();
            break;
          }
          case 34: {
            cInfo_.AddEntriesFrom(input, _repeated_cInfo_codec);
            break;
          }
          case 40: {
            UllMyData = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

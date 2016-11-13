// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: protos/chat.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Lite {

  /// <summary>Holder for reflection information generated from protos/chat.proto</summary>
  public static partial class ChatReflection {

    #region Descriptor
    /// <summary>File descriptor for protos/chat.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChatReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFwcm90b3MvY2hhdC5wcm90bxIETGl0ZSIXCgdzZW5kTXNnEgwKBHRleHQY",
            "ASABKAkiNQoHcmVjdk1zZxIOCgZyb2xlSWQYASABKAMSDAoEbmFtZRgCIAEo",
            "CRIMCgR0ZXh0GAMgASgJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Lite.sendMsg), global::Lite.sendMsg.Parser, new[]{ "Text" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Lite.recvMsg), global::Lite.recvMsg.Parser, new[]{ "RoleId", "Name", "Text" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class sendMsg : pb::IMessage<sendMsg> {
    private static readonly pb::MessageParser<sendMsg> _parser = new pb::MessageParser<sendMsg>(() => new sendMsg());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<sendMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lite.ChatReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public sendMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public sendMsg(sendMsg other) : this() {
      text_ = other.text_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public sendMsg Clone() {
      return new sendMsg(this);
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 1;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as sendMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(sendMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Text != other.Text) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Text.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Text);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(sendMsg other) {
      if (other == null) {
        return;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
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
            Text = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class recvMsg : pb::IMessage<recvMsg> {
    private static readonly pb::MessageParser<recvMsg> _parser = new pb::MessageParser<recvMsg>(() => new recvMsg());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<recvMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Lite.ChatReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public recvMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public recvMsg(recvMsg other) : this() {
      roleId_ = other.roleId_;
      name_ = other.name_;
      text_ = other.text_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public recvMsg Clone() {
      return new recvMsg(this);
    }

    /// <summary>Field number for the "roleId" field.</summary>
    public const int RoleIdFieldNumber = 1;
    private long roleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RoleId {
      get { return roleId_; }
      set {
        roleId_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 3;
    private string text_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as recvMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(recvMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoleId != other.RoleId) return false;
      if (Name != other.Name) return false;
      if (Text != other.Text) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoleId != 0L) hash ^= RoleId.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Text.Length != 0) hash ^= Text.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoleId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RoleId);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Text.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Text);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoleId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RoleId);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Text.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(recvMsg other) {
      if (other == null) {
        return;
      }
      if (other.RoleId != 0L) {
        RoleId = other.RoleId;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Text.Length != 0) {
        Text = other.Text;
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
            RoleId = input.ReadInt64();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Text = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

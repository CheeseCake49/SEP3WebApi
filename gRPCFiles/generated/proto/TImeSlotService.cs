// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/TImeSlotService.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace sep3client.timeslot {

  /// <summary>Holder for reflection information generated from proto/TImeSlotService.proto</summary>
  public static partial class TImeSlotServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for proto/TImeSlotService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TImeSlotServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Chtwcm90by9USW1lU2xvdFNlcnZpY2UucHJvdG8SG3NlcDNkYXRhbGF5ZXIu",
            "Z3JwYy5wcm90b2J1ZhobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3RvIocB",
            "ChBDcmVhdGluZ1RpbWVTbG90Eg8KB2NvdXJ0SWQYASABKAUSDAoEeWVhchgC",
            "IAEoBRINCgVtb250aBgDIAEoBRILCgNkYXkYBCABKAUSEQoJc3RhcnRIb3Vy",
            "GAUgASgFEhMKC3N0YXJ0TWludXRlGAYgASgFEhAKCGR1cmF0aW9uGAcgASgF",
            "Io8BCgxUaW1lU2xvdEdycGMSCgoCaWQYASABKAUSDwoHY291cnRJZBgCIAEo",
            "BRIMCgR5ZWFyGAMgASgFEg0KBW1vbnRoGAQgASgFEgsKA2RheRgFIAEoBRIR",
            "CglzdGFydEhvdXIYBiABKAUSEwoLc3RhcnRNaW51dGUYByABKAUSEAoIZHVy",
            "YXRpb24YCCABKAUiTQoNVGltZVNsb3RzR3JwYxI8Cgl0aW1lU2xvdHMYASAD",
            "KAsyKS5zZXAzZGF0YWxheWVyLmdycGMucHJvdG9idWYuVGltZVNsb3RHcnBj",
            "Mn0KD1RpbWVTbG90U2VydmljZRJqCg5DcmVhdGVUaW1lU2xvdBItLnNlcDNk",
            "YXRhbGF5ZXIuZ3JwYy5wcm90b2J1Zi5DcmVhdGluZ1RpbWVTbG90Gikuc2Vw",
            "M2RhdGFsYXllci5ncnBjLnByb3RvYnVmLlRpbWVTbG90R3JwY0IYUAGqAhNz",
            "ZXAzY2xpZW50LnRpbWVzbG90YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::sep3client.timeslot.CreatingTimeSlot), global::sep3client.timeslot.CreatingTimeSlot.Parser, new[]{ "CourtId", "Year", "Month", "Day", "StartHour", "StartMinute", "Duration" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::sep3client.timeslot.TimeSlotGrpc), global::sep3client.timeslot.TimeSlotGrpc.Parser, new[]{ "Id", "CourtId", "Year", "Month", "Day", "StartHour", "StartMinute", "Duration" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::sep3client.timeslot.TimeSlotsGrpc), global::sep3client.timeslot.TimeSlotsGrpc.Parser, new[]{ "TimeSlots" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CreatingTimeSlot : pb::IMessage<CreatingTimeSlot>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreatingTimeSlot> _parser = new pb::MessageParser<CreatingTimeSlot>(() => new CreatingTimeSlot());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreatingTimeSlot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::sep3client.timeslot.TImeSlotServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreatingTimeSlot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreatingTimeSlot(CreatingTimeSlot other) : this() {
      courtId_ = other.courtId_;
      year_ = other.year_;
      month_ = other.month_;
      day_ = other.day_;
      startHour_ = other.startHour_;
      startMinute_ = other.startMinute_;
      duration_ = other.duration_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreatingTimeSlot Clone() {
      return new CreatingTimeSlot(this);
    }

    /// <summary>Field number for the "courtId" field.</summary>
    public const int CourtIdFieldNumber = 1;
    private int courtId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CourtId {
      get { return courtId_; }
      set {
        courtId_ = value;
      }
    }

    /// <summary>Field number for the "year" field.</summary>
    public const int YearFieldNumber = 2;
    private int year_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Year {
      get { return year_; }
      set {
        year_ = value;
      }
    }

    /// <summary>Field number for the "month" field.</summary>
    public const int MonthFieldNumber = 3;
    private int month_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Month {
      get { return month_; }
      set {
        month_ = value;
      }
    }

    /// <summary>Field number for the "day" field.</summary>
    public const int DayFieldNumber = 4;
    private int day_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Day {
      get { return day_; }
      set {
        day_ = value;
      }
    }

    /// <summary>Field number for the "startHour" field.</summary>
    public const int StartHourFieldNumber = 5;
    private int startHour_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int StartHour {
      get { return startHour_; }
      set {
        startHour_ = value;
      }
    }

    /// <summary>Field number for the "startMinute" field.</summary>
    public const int StartMinuteFieldNumber = 6;
    private int startMinute_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int StartMinute {
      get { return startMinute_; }
      set {
        startMinute_ = value;
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 7;
    private int duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreatingTimeSlot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreatingTimeSlot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CourtId != other.CourtId) return false;
      if (Year != other.Year) return false;
      if (Month != other.Month) return false;
      if (Day != other.Day) return false;
      if (StartHour != other.StartHour) return false;
      if (StartMinute != other.StartMinute) return false;
      if (Duration != other.Duration) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CourtId != 0) hash ^= CourtId.GetHashCode();
      if (Year != 0) hash ^= Year.GetHashCode();
      if (Month != 0) hash ^= Month.GetHashCode();
      if (Day != 0) hash ^= Day.GetHashCode();
      if (StartHour != 0) hash ^= StartHour.GetHashCode();
      if (StartMinute != 0) hash ^= StartMinute.GetHashCode();
      if (Duration != 0) hash ^= Duration.GetHashCode();
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
      if (CourtId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CourtId);
      }
      if (Year != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Year);
      }
      if (Month != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Month);
      }
      if (Day != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Day);
      }
      if (StartHour != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(StartHour);
      }
      if (StartMinute != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(StartMinute);
      }
      if (Duration != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Duration);
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
      if (CourtId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(CourtId);
      }
      if (Year != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Year);
      }
      if (Month != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Month);
      }
      if (Day != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Day);
      }
      if (StartHour != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(StartHour);
      }
      if (StartMinute != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(StartMinute);
      }
      if (Duration != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Duration);
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
      if (CourtId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CourtId);
      }
      if (Year != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Year);
      }
      if (Month != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Month);
      }
      if (Day != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Day);
      }
      if (StartHour != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StartHour);
      }
      if (StartMinute != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StartMinute);
      }
      if (Duration != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Duration);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreatingTimeSlot other) {
      if (other == null) {
        return;
      }
      if (other.CourtId != 0) {
        CourtId = other.CourtId;
      }
      if (other.Year != 0) {
        Year = other.Year;
      }
      if (other.Month != 0) {
        Month = other.Month;
      }
      if (other.Day != 0) {
        Day = other.Day;
      }
      if (other.StartHour != 0) {
        StartHour = other.StartHour;
      }
      if (other.StartMinute != 0) {
        StartMinute = other.StartMinute;
      }
      if (other.Duration != 0) {
        Duration = other.Duration;
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
          case 8: {
            CourtId = input.ReadInt32();
            break;
          }
          case 16: {
            Year = input.ReadInt32();
            break;
          }
          case 24: {
            Month = input.ReadInt32();
            break;
          }
          case 32: {
            Day = input.ReadInt32();
            break;
          }
          case 40: {
            StartHour = input.ReadInt32();
            break;
          }
          case 48: {
            StartMinute = input.ReadInt32();
            break;
          }
          case 56: {
            Duration = input.ReadInt32();
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
          case 8: {
            CourtId = input.ReadInt32();
            break;
          }
          case 16: {
            Year = input.ReadInt32();
            break;
          }
          case 24: {
            Month = input.ReadInt32();
            break;
          }
          case 32: {
            Day = input.ReadInt32();
            break;
          }
          case 40: {
            StartHour = input.ReadInt32();
            break;
          }
          case 48: {
            StartMinute = input.ReadInt32();
            break;
          }
          case 56: {
            Duration = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class TimeSlotGrpc : pb::IMessage<TimeSlotGrpc>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TimeSlotGrpc> _parser = new pb::MessageParser<TimeSlotGrpc>(() => new TimeSlotGrpc());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TimeSlotGrpc> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::sep3client.timeslot.TImeSlotServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TimeSlotGrpc() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TimeSlotGrpc(TimeSlotGrpc other) : this() {
      id_ = other.id_;
      courtId_ = other.courtId_;
      year_ = other.year_;
      month_ = other.month_;
      day_ = other.day_;
      startHour_ = other.startHour_;
      startMinute_ = other.startMinute_;
      duration_ = other.duration_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TimeSlotGrpc Clone() {
      return new TimeSlotGrpc(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "courtId" field.</summary>
    public const int CourtIdFieldNumber = 2;
    private int courtId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CourtId {
      get { return courtId_; }
      set {
        courtId_ = value;
      }
    }

    /// <summary>Field number for the "year" field.</summary>
    public const int YearFieldNumber = 3;
    private int year_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Year {
      get { return year_; }
      set {
        year_ = value;
      }
    }

    /// <summary>Field number for the "month" field.</summary>
    public const int MonthFieldNumber = 4;
    private int month_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Month {
      get { return month_; }
      set {
        month_ = value;
      }
    }

    /// <summary>Field number for the "day" field.</summary>
    public const int DayFieldNumber = 5;
    private int day_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Day {
      get { return day_; }
      set {
        day_ = value;
      }
    }

    /// <summary>Field number for the "startHour" field.</summary>
    public const int StartHourFieldNumber = 6;
    private int startHour_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int StartHour {
      get { return startHour_; }
      set {
        startHour_ = value;
      }
    }

    /// <summary>Field number for the "startMinute" field.</summary>
    public const int StartMinuteFieldNumber = 7;
    private int startMinute_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int StartMinute {
      get { return startMinute_; }
      set {
        startMinute_ = value;
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 8;
    private int duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TimeSlotGrpc);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TimeSlotGrpc other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (CourtId != other.CourtId) return false;
      if (Year != other.Year) return false;
      if (Month != other.Month) return false;
      if (Day != other.Day) return false;
      if (StartHour != other.StartHour) return false;
      if (StartMinute != other.StartMinute) return false;
      if (Duration != other.Duration) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (CourtId != 0) hash ^= CourtId.GetHashCode();
      if (Year != 0) hash ^= Year.GetHashCode();
      if (Month != 0) hash ^= Month.GetHashCode();
      if (Day != 0) hash ^= Day.GetHashCode();
      if (StartHour != 0) hash ^= StartHour.GetHashCode();
      if (StartMinute != 0) hash ^= StartMinute.GetHashCode();
      if (Duration != 0) hash ^= Duration.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (CourtId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CourtId);
      }
      if (Year != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Year);
      }
      if (Month != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Month);
      }
      if (Day != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Day);
      }
      if (StartHour != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(StartHour);
      }
      if (StartMinute != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(StartMinute);
      }
      if (Duration != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Duration);
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (CourtId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CourtId);
      }
      if (Year != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Year);
      }
      if (Month != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Month);
      }
      if (Day != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Day);
      }
      if (StartHour != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(StartHour);
      }
      if (StartMinute != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(StartMinute);
      }
      if (Duration != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Duration);
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
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (CourtId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CourtId);
      }
      if (Year != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Year);
      }
      if (Month != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Month);
      }
      if (Day != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Day);
      }
      if (StartHour != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StartHour);
      }
      if (StartMinute != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StartMinute);
      }
      if (Duration != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Duration);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TimeSlotGrpc other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.CourtId != 0) {
        CourtId = other.CourtId;
      }
      if (other.Year != 0) {
        Year = other.Year;
      }
      if (other.Month != 0) {
        Month = other.Month;
      }
      if (other.Day != 0) {
        Day = other.Day;
      }
      if (other.StartHour != 0) {
        StartHour = other.StartHour;
      }
      if (other.StartMinute != 0) {
        StartMinute = other.StartMinute;
      }
      if (other.Duration != 0) {
        Duration = other.Duration;
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
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            CourtId = input.ReadInt32();
            break;
          }
          case 24: {
            Year = input.ReadInt32();
            break;
          }
          case 32: {
            Month = input.ReadInt32();
            break;
          }
          case 40: {
            Day = input.ReadInt32();
            break;
          }
          case 48: {
            StartHour = input.ReadInt32();
            break;
          }
          case 56: {
            StartMinute = input.ReadInt32();
            break;
          }
          case 64: {
            Duration = input.ReadInt32();
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
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            CourtId = input.ReadInt32();
            break;
          }
          case 24: {
            Year = input.ReadInt32();
            break;
          }
          case 32: {
            Month = input.ReadInt32();
            break;
          }
          case 40: {
            Day = input.ReadInt32();
            break;
          }
          case 48: {
            StartHour = input.ReadInt32();
            break;
          }
          case 56: {
            StartMinute = input.ReadInt32();
            break;
          }
          case 64: {
            Duration = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class TimeSlotsGrpc : pb::IMessage<TimeSlotsGrpc>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TimeSlotsGrpc> _parser = new pb::MessageParser<TimeSlotsGrpc>(() => new TimeSlotsGrpc());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TimeSlotsGrpc> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::sep3client.timeslot.TImeSlotServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TimeSlotsGrpc() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TimeSlotsGrpc(TimeSlotsGrpc other) : this() {
      timeSlots_ = other.timeSlots_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TimeSlotsGrpc Clone() {
      return new TimeSlotsGrpc(this);
    }

    /// <summary>Field number for the "timeSlots" field.</summary>
    public const int TimeSlotsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::sep3client.timeslot.TimeSlotGrpc> _repeated_timeSlots_codec
        = pb::FieldCodec.ForMessage(10, global::sep3client.timeslot.TimeSlotGrpc.Parser);
    private readonly pbc::RepeatedField<global::sep3client.timeslot.TimeSlotGrpc> timeSlots_ = new pbc::RepeatedField<global::sep3client.timeslot.TimeSlotGrpc>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::sep3client.timeslot.TimeSlotGrpc> TimeSlots {
      get { return timeSlots_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TimeSlotsGrpc);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TimeSlotsGrpc other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!timeSlots_.Equals(other.timeSlots_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= timeSlots_.GetHashCode();
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
      timeSlots_.WriteTo(output, _repeated_timeSlots_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      timeSlots_.WriteTo(ref output, _repeated_timeSlots_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += timeSlots_.CalculateSize(_repeated_timeSlots_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TimeSlotsGrpc other) {
      if (other == null) {
        return;
      }
      timeSlots_.Add(other.timeSlots_);
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
            timeSlots_.AddEntriesFrom(input, _repeated_timeSlots_codec);
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
            timeSlots_.AddEntriesFrom(ref input, _repeated_timeSlots_codec);
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

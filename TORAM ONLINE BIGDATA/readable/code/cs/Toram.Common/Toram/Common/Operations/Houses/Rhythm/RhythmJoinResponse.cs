// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Rhythm
public class RhythmJoinResponse : OperationResponseBase // TypeDefIndex: 12214
{
	// Fields
	[CompilerGenerated]
	private RhythmSettingData <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RhythmMemberData[] <Members>k__BackingField; // 0x28
	[CompilerGenerated]
	private RhythmRecordData[] <Record>k__BackingField; // 0x30

	// Properties
	public RhythmSettingData Setting { get; set; }
	public RhythmMemberData[] Members { get; set; }
	public RhythmRecordData[] Record { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E1F44 Offset: 0x35DDF44 VA: 0x35E1F44
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E1F4C Offset: 0x35DDF4C VA: 0x35E1F4C
	public RhythmSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x35E1F54 Offset: 0x35DDF54 VA: 0x35E1F54
	public void set_Setting(RhythmSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x35E1F5C Offset: 0x35DDF5C VA: 0x35E1F5C
	public RhythmMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x35E1F64 Offset: 0x35DDF64 VA: 0x35E1F64
	public void set_Members(RhythmMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35E1F6C Offset: 0x35DDF6C VA: 0x35E1F6C
	public RhythmRecordData[] get_Record() { }

	[CompilerGenerated]
	// RVA: 0x35E1F74 Offset: 0x35DDF74 VA: 0x35E1F74
	public void set_Record(RhythmRecordData[] value) { }

	// RVA: 0x35E1F7C Offset: 0x35DDF7C VA: 0x35E1F7C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E1F84 Offset: 0x35DDF84 VA: 0x35E1F84 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E1F8C Offset: 0x35DDF8C VA: 0x35E1F8C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E2220 Offset: 0x35DE220 VA: 0x35E2220 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House
public class RhythmGameGiveupEvent : EventSubBase // TypeDefIndex: 12812
{
	// Fields
	[CompilerGenerated]
	private RhythmSettingData <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RhythmMemberData[] <Members>k__BackingField; // 0x28

	// Properties
	public RhythmSettingData Setting { get; set; }
	public RhythmMemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365F04C Offset: 0x365B04C VA: 0x365F04C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365F054 Offset: 0x365B054 VA: 0x365F054
	public RhythmSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x365F05C Offset: 0x365B05C VA: 0x365F05C
	public void set_Setting(RhythmSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x365F064 Offset: 0x365B064 VA: 0x365F064
	public RhythmMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x365F06C Offset: 0x365B06C VA: 0x365F06C
	public void set_Members(RhythmMemberData[] value) { }

	// RVA: 0x365F074 Offset: 0x365B074 VA: 0x365F074 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365F07C Offset: 0x365B07C VA: 0x365F07C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365F084 Offset: 0x365B084 VA: 0x365F084 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365F2C8 Offset: 0x365B2C8 VA: 0x365F2C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

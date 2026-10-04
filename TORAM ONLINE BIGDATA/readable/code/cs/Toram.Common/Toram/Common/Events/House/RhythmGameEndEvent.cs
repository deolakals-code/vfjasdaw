// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House
public class RhythmGameEndEvent : EventSubBase // TypeDefIndex: 12811
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

	// RVA: 0x365ED0C Offset: 0x365AD0C VA: 0x365ED0C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365ED14 Offset: 0x365AD14 VA: 0x365ED14
	public RhythmSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x365ED1C Offset: 0x365AD1C VA: 0x365ED1C
	public void set_Setting(RhythmSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x365ED24 Offset: 0x365AD24 VA: 0x365ED24
	public RhythmMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x365ED2C Offset: 0x365AD2C VA: 0x365ED2C
	public void set_Members(RhythmMemberData[] value) { }

	// RVA: 0x365ED34 Offset: 0x365AD34 VA: 0x365ED34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365ED3C Offset: 0x365AD3C VA: 0x365ED3C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365ED44 Offset: 0x365AD44 VA: 0x365ED44 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365EF88 Offset: 0x365AF88 VA: 0x365EF88 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

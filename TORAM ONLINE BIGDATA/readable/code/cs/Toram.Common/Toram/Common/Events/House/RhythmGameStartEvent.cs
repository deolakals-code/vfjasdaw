// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House
public class RhythmGameStartEvent : EventSubBase // TypeDefIndex: 12817
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

	// RVA: 0x3660490 Offset: 0x365C490 VA: 0x3660490
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3660498 Offset: 0x365C498 VA: 0x3660498
	public RhythmSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x36604A0 Offset: 0x365C4A0 VA: 0x36604A0
	public void set_Setting(RhythmSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x36604A8 Offset: 0x365C4A8 VA: 0x36604A8
	public RhythmMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x36604B0 Offset: 0x365C4B0 VA: 0x36604B0
	public void set_Members(RhythmMemberData[] value) { }

	// RVA: 0x36604B8 Offset: 0x365C4B8 VA: 0x36604B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36604C0 Offset: 0x365C4C0 VA: 0x36604C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36604C8 Offset: 0x365C4C8 VA: 0x36604C8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366070C Offset: 0x365C70C VA: 0x366070C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

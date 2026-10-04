// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House
public class RhythmGameStartPrepareEvent : EventSubBase // TypeDefIndex: 12818
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

	// RVA: 0x36607D0 Offset: 0x365C7D0 VA: 0x36607D0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36607D8 Offset: 0x365C7D8 VA: 0x36607D8
	public RhythmSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x36607E0 Offset: 0x365C7E0 VA: 0x36607E0
	public void set_Setting(RhythmSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x36607E8 Offset: 0x365C7E8 VA: 0x36607E8
	public RhythmMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x36607F0 Offset: 0x365C7F0 VA: 0x36607F0
	public void set_Members(RhythmMemberData[] value) { }

	// RVA: 0x36607F8 Offset: 0x365C7F8 VA: 0x36607F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3660800 Offset: 0x365C800 VA: 0x3660800 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3660808 Offset: 0x365C808 VA: 0x3660808 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3660A4C Offset: 0x365CA4C VA: 0x3660A4C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

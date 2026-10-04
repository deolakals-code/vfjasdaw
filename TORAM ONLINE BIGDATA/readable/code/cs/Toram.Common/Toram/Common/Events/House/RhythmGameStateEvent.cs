// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House
public class RhythmGameStateEvent : EventSubBase // TypeDefIndex: 12819
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

	// RVA: 0x3660B10 Offset: 0x365CB10 VA: 0x3660B10
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3660B18 Offset: 0x365CB18 VA: 0x3660B18
	public RhythmSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3660B20 Offset: 0x365CB20 VA: 0x3660B20
	public void set_Setting(RhythmSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x3660B28 Offset: 0x365CB28 VA: 0x3660B28
	public RhythmMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3660B30 Offset: 0x365CB30 VA: 0x3660B30
	public void set_Members(RhythmMemberData[] value) { }

	// RVA: 0x3660B38 Offset: 0x365CB38 VA: 0x3660B38 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3660B40 Offset: 0x365CB40 VA: 0x3660B40 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3660B48 Offset: 0x365CB48 VA: 0x3660B48 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3660D8C Offset: 0x365CD8C VA: 0x3660D8C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House
public class RhythmGameKickoutEvent : EventSubBase // TypeDefIndex: 12813
{
	// Fields
	[CompilerGenerated]
	private RhythmSettingData <Setting>k__BackingField; // 0x20

	// Properties
	public RhythmSettingData Setting { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365F38C Offset: 0x365B38C VA: 0x365F38C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365F394 Offset: 0x365B394 VA: 0x365F394
	public RhythmSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x365F39C Offset: 0x365B39C VA: 0x365F39C
	public void set_Setting(RhythmSettingData value) { }

	// RVA: 0x365F3A4 Offset: 0x365B3A4 VA: 0x365F3A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365F3AC Offset: 0x365B3AC VA: 0x365F3AC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365F3B4 Offset: 0x365B3B4 VA: 0x365F3B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x365F550 Offset: 0x365B550 VA: 0x365F550 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

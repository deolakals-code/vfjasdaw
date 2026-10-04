// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House
public class RhythmGameScoreStateEvent : EventSubBase // TypeDefIndex: 12816
{
	// Fields
	[CompilerGenerated]
	private int <BossHp>k__BackingField; // 0x20

	// Properties
	public int BossHp { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36602A8 Offset: 0x365C2A8 VA: 0x36602A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36602B0 Offset: 0x365C2B0 VA: 0x36602B0
	public int get_BossHp() { }

	[CompilerGenerated]
	// RVA: 0x36602B8 Offset: 0x365C2B8 VA: 0x36602B8
	public void set_BossHp(int value) { }

	// RVA: 0x36602C0 Offset: 0x365C2C0 VA: 0x36602C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36602C8 Offset: 0x365C2C8 VA: 0x36602C8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36602D0 Offset: 0x365C2D0 VA: 0x36602D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36603F0 Offset: 0x365C3F0 VA: 0x36603F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

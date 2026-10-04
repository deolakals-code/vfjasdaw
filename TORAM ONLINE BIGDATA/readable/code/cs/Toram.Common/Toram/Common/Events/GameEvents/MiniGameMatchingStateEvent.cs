// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents
public class MiniGameMatchingStateEvent : EventSubBase // TypeDefIndex: 12687
{
	// Fields
	[CompilerGenerated]
	private int <WaitMatchingCount>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <BattleCount>k__BackingField; // 0x24

	// Properties
	public int WaitMatchingCount { get; set; }
	public int BattleCount { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36421BC Offset: 0x363E1BC VA: 0x36421BC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36421C4 Offset: 0x363E1C4 VA: 0x36421C4
	public int get_WaitMatchingCount() { }

	[CompilerGenerated]
	// RVA: 0x36421CC Offset: 0x363E1CC VA: 0x36421CC
	public void set_WaitMatchingCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x36421D4 Offset: 0x363E1D4 VA: 0x36421D4
	public int get_BattleCount() { }

	[CompilerGenerated]
	// RVA: 0x36421DC Offset: 0x363E1DC VA: 0x36421DC
	public void set_BattleCount(int value) { }

	// RVA: 0x36421E4 Offset: 0x363E1E4 VA: 0x36421E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36421EC Offset: 0x363E1EC VA: 0x36421EC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36421F4 Offset: 0x363E1F4 VA: 0x36421F4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3642360 Offset: 0x363E360 VA: 0x3642360 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

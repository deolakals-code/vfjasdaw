// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.TreasureHunt
public class TreasureHuntGameStartEvent : EventSubBase // TypeDefIndex: 12793
{
	// Fields
	[CompilerGenerated]
	private int <TimeLeft>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 172)]
	public int TimeLeft { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365A8A0 Offset: 0x36568A0 VA: 0x365A8A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365A8A8 Offset: 0x36568A8 VA: 0x365A8A8
	public int get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x365A8B0 Offset: 0x36568B0 VA: 0x365A8B0
	public void set_TimeLeft(int value) { }

	// RVA: 0x365A8B8 Offset: 0x36568B8 VA: 0x365A8B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365A8C0 Offset: 0x36568C0 VA: 0x365A8C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365A8C8 Offset: 0x36568C8 VA: 0x365A8C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x365A968 Offset: 0x3656968 VA: 0x365A968 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

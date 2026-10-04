// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Defence
public class DefenceStartGame : EventSubBase // TypeDefIndex: 12775
{
	// Fields
	[CompilerGenerated]
	private long <TimeLeft>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 172)]
	public long TimeLeft { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36564AC Offset: 0x36524AC VA: 0x36564AC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36564B4 Offset: 0x36524B4 VA: 0x36564B4
	public long get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x36564BC Offset: 0x36524BC VA: 0x36564BC
	public void set_TimeLeft(long value) { }

	// RVA: 0x36564C4 Offset: 0x36524C4 VA: 0x36564C4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36564C8 Offset: 0x36524C8 VA: 0x36564C8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36564CC Offset: 0x36524CC VA: 0x36564CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36564D4 Offset: 0x36524D4 VA: 0x36564D4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36564DC Offset: 0x36524DC VA: 0x36564DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36565FC Offset: 0x36525FC VA: 0x36565FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

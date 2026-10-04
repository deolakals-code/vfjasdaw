// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Events
public class BCollaborationGameStartEvent : EventSubBase // TypeDefIndex: 13077
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

	// RVA: 0x369E270 Offset: 0x369A270 VA: 0x369E270
	public void .ctor(Dictionary<byte, object> paramters) { }

	[CompilerGenerated]
	// RVA: 0x369E278 Offset: 0x369A278 VA: 0x369E278
	public int get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x369E280 Offset: 0x369A280 VA: 0x369E280
	public void set_TimeLeft(int value) { }

	// RVA: 0x369E288 Offset: 0x369A288 VA: 0x369E288 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369E290 Offset: 0x369A290 VA: 0x369E290 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369E298 Offset: 0x369A298 VA: 0x369E298 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x369E338 Offset: 0x369A338 VA: 0x369E338 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

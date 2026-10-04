// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GameEventResult : OperationRequestBase // TypeDefIndex: 11622
{
	// Fields
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x20

	// Properties
	public byte EventType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3726FB0 Offset: 0x3722FB0 VA: 0x3726FB0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3726FB8 Offset: 0x3722FB8 VA: 0x3726FB8
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3726FC0 Offset: 0x3722FC0 VA: 0x3726FC0
	public void set_EventType(byte value) { }

	// RVA: 0x3726FC8 Offset: 0x3722FC8 VA: 0x3726FC8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3726FD0 Offset: 0x3722FD0 VA: 0x3726FD0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3726FD8 Offset: 0x3722FD8 VA: 0x3726FD8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37270F8 Offset: 0x37230F8 VA: 0x37270F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

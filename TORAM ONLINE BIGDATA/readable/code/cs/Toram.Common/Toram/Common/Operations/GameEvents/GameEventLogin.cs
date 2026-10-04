// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GameEventLogin : OperationRequestBase // TypeDefIndex: 11620
{
	// Fields
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x20

	// Properties
	public byte EventType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3726B18 Offset: 0x3722B18 VA: 0x3726B18
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3726B20 Offset: 0x3722B20 VA: 0x3726B20
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3726B28 Offset: 0x3722B28 VA: 0x3726B28
	public void set_EventType(byte value) { }

	// RVA: 0x3726B30 Offset: 0x3722B30 VA: 0x3726B30 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3726B38 Offset: 0x3722B38 VA: 0x3726B38 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3726B40 Offset: 0x3722B40 VA: 0x3726B40 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3726C60 Offset: 0x3722C60 VA: 0x3726C60 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

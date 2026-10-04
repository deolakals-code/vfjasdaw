// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class GetEventResponse : OperationResponseBase // TypeDefIndex: 11632
{
	// Fields
	[CompilerGenerated]
	private byte <EventType>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<byte, object> <Parameters>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 245)]
	public byte EventType { get; set; }
	[PacketParameter(Code = 18, IsOptional = True)]
	public Dictionary<byte, object> Parameters { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3728B40 Offset: 0x3724B40 VA: 0x3728B40
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3728B48 Offset: 0x3724B48 VA: 0x3728B48
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3728B50 Offset: 0x3724B50 VA: 0x3728B50
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3728B58 Offset: 0x3724B58 VA: 0x3728B58
	public Dictionary<byte, object> get_Parameters() { }

	[CompilerGenerated]
	// RVA: 0x3728B60 Offset: 0x3724B60 VA: 0x3728B60
	public void set_Parameters(Dictionary<byte, object> value) { }

	// RVA: 0x3728B68 Offset: 0x3724B68 VA: 0x3728B68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3728B70 Offset: 0x3724B70 VA: 0x3728B70 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3728B78 Offset: 0x3724B78 VA: 0x3728B78 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3728D38 Offset: 0x3724D38 VA: 0x3728D38 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

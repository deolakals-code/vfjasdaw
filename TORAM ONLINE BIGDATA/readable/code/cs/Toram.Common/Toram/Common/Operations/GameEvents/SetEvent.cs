// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.GameEvents
public class SetEvent : OperationRequestBase // TypeDefIndex: 11633
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

	// RVA: 0x3728DF0 Offset: 0x3724DF0 VA: 0x3728DF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3728DF8 Offset: 0x3724DF8 VA: 0x3728DF8
	public byte get_EventType() { }

	[CompilerGenerated]
	// RVA: 0x3728E00 Offset: 0x3724E00 VA: 0x3728E00
	public void set_EventType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3728E08 Offset: 0x3724E08 VA: 0x3728E08
	public Dictionary<byte, object> get_Parameters() { }

	[CompilerGenerated]
	// RVA: 0x3728E10 Offset: 0x3724E10 VA: 0x3728E10
	public void set_Parameters(Dictionary<byte, object> value) { }

	// RVA: 0x3728E18 Offset: 0x3724E18 VA: 0x3728E18 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3728E20 Offset: 0x3724E20 VA: 0x3728E20 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3728E28 Offset: 0x3724E28 VA: 0x3728E28 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3728FE8 Offset: 0x3724FE8 VA: 0x3728FE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

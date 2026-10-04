// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.EventField
public class HalloweenSearch : OperationRequestBase // TypeDefIndex: 11669
{
	// Fields
	[CompilerGenerated]
	private byte <FloorNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <PointNo>k__BackingField; // 0x21

	// Properties
	[PacketParameter(Code = 36)]
	public byte FloorNo { get; set; }
	[PacketParameter(Code = 37)]
	public byte PointNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372EF24 Offset: 0x372AF24 VA: 0x372EF24
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372EF2C Offset: 0x372AF2C VA: 0x372EF2C
	public byte get_FloorNo() { }

	[CompilerGenerated]
	// RVA: 0x372EF34 Offset: 0x372AF34 VA: 0x372EF34
	public void set_FloorNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x372EF3C Offset: 0x372AF3C VA: 0x372EF3C
	public byte get_PointNo() { }

	[CompilerGenerated]
	// RVA: 0x372EF44 Offset: 0x372AF44 VA: 0x372EF44
	public void set_PointNo(byte value) { }

	// RVA: 0x372EF4C Offset: 0x372AF4C VA: 0x372EF4C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372EF54 Offset: 0x372AF54 VA: 0x372EF54 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372EF5C Offset: 0x372AF5C VA: 0x372EF5C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372F0C8 Offset: 0x372B0C8 VA: 0x372F0C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Treasure
public class TreasureOpen : OperationRequestBase // TypeDefIndex: 11393
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <TreasureNo>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 60)]
	public int FieldId { get; set; }
	[PacketParameter(Code = 210)]
	public byte TreasureNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3700168 Offset: 0x36FC168 VA: 0x3700168
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3700170 Offset: 0x36FC170 VA: 0x3700170
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x3700178 Offset: 0x36FC178 VA: 0x3700178
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3700180 Offset: 0x36FC180 VA: 0x3700180
	public byte get_TreasureNo() { }

	[CompilerGenerated]
	// RVA: 0x3700188 Offset: 0x36FC188 VA: 0x3700188
	public void set_TreasureNo(byte value) { }

	// RVA: 0x3700190 Offset: 0x36FC190 VA: 0x3700190 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3700198 Offset: 0x36FC198 VA: 0x3700198 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37001A0 Offset: 0x36FC1A0 VA: 0x37001A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3700318 Offset: 0x36FC318 VA: 0x3700318 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

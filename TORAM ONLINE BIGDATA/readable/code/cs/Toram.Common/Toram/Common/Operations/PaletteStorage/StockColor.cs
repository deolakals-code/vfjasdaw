// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.PaletteStorage
public class StockColor : OperationRequestBase // TypeDefIndex: 11526
{
	// Fields
	[CompilerGenerated]
	private int[] <ItemUuids>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 15)]
	public int[] ItemUuids { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371661C Offset: 0x371261C VA: 0x371661C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3716624 Offset: 0x3712624 VA: 0x3716624
	public int[] get_ItemUuids() { }

	[CompilerGenerated]
	// RVA: 0x371662C Offset: 0x371262C VA: 0x371662C
	public void set_ItemUuids(int[] value) { }

	// RVA: 0x3716634 Offset: 0x3712634 VA: 0x3716634 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371663C Offset: 0x371263C VA: 0x371663C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3716644 Offset: 0x3712644 VA: 0x3716644 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37166B0 Offset: 0x37126B0 VA: 0x37166B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

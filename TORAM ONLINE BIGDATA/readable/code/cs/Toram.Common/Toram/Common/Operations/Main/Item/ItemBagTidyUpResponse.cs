// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
[CLSCompliant(False)]
public class ItemBagTidyUpResponse : OperationResponseBase // TypeDefIndex: 12123
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x20

	// Properties
	public ItemDatav2[] ItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378BDD4 Offset: 0x3787DD4 VA: 0x378BDD4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378BDDC Offset: 0x3787DDC VA: 0x378BDDC
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x378BDE4 Offset: 0x3787DE4 VA: 0x378BDE4
	public void set_ItemList(ItemDatav2[] value) { }

	// RVA: 0x378BDEC Offset: 0x3787DEC VA: 0x378BDEC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378BDF4 Offset: 0x3787DF4 VA: 0x378BDF4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378BDFC Offset: 0x3787DFC VA: 0x378BDFC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378BEA4 Offset: 0x3787EA4 VA: 0x378BEA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

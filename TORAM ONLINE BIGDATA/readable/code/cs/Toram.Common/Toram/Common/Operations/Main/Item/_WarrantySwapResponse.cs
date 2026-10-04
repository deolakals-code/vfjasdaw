// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
[CLSCompliant(False)]
public class _WarrantySwapResponse : OperationResponseBase // TypeDefIndex: 12148
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private WarrantyItemDatav2[] <WarrantyItem>k__BackingField; // 0x28

	// Properties
	public ItemDatav2[] ItemList { get; set; }
	public WarrantyItemDatav2[] WarrantyItem { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3790AFC Offset: 0x378CAFC VA: 0x3790AFC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3790B04 Offset: 0x378CB04 VA: 0x3790B04
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3790B0C Offset: 0x378CB0C VA: 0x3790B0C
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3790B14 Offset: 0x378CB14 VA: 0x3790B14
	public WarrantyItemDatav2[] get_WarrantyItem() { }

	[CompilerGenerated]
	// RVA: 0x3790B1C Offset: 0x378CB1C VA: 0x3790B1C
	public void set_WarrantyItem(WarrantyItemDatav2[] value) { }

	// RVA: 0x3790B24 Offset: 0x378CB24 VA: 0x3790B24 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3790B2C Offset: 0x378CB2C VA: 0x3790B2C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3790B34 Offset: 0x378CB34 VA: 0x3790B34 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3790C20 Offset: 0x378CC20 VA: 0x3790C20 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

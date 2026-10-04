// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageTakeItemResponse : OperationResponseBase // TypeDefIndex: 12068
{
	// Fields
	[CompilerGenerated]
	private byte <StorageNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private StorageItemDatav3 <StorageItem>k__BackingField; // 0x30

	// Properties
	public byte StorageNo { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public StorageItemDatav3 StorageItem { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3781194 Offset: 0x377D194 VA: 0x3781194
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378119C Offset: 0x377D19C VA: 0x378119C
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x37811A4 Offset: 0x377D1A4 VA: 0x37811A4
	public void set_StorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37811AC Offset: 0x377D1AC VA: 0x37811AC
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x37811B4 Offset: 0x377D1B4 VA: 0x37811B4
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x37811BC Offset: 0x377D1BC VA: 0x37811BC
	public StorageItemDatav3 get_StorageItem() { }

	[CompilerGenerated]
	// RVA: 0x37811C4 Offset: 0x377D1C4 VA: 0x37811C4
	public void set_StorageItem(StorageItemDatav3 value) { }

	// RVA: 0x37811CC Offset: 0x377D1CC VA: 0x37811CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37811D4 Offset: 0x377D1D4 VA: 0x37811D4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37811DC Offset: 0x377D1DC VA: 0x37811DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3781470 Offset: 0x377D470 VA: 0x3781470 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

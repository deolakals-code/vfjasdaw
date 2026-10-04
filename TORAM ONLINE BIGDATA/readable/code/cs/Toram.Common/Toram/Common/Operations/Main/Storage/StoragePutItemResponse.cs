// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StoragePutItemResponse : OperationResponseBase // TypeDefIndex: 12064
{
	// Fields
	[CompilerGenerated]
	private byte <StorageNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2 <ItemData>k__BackingField; // 0x28
	[CompilerGenerated]
	private StorageItemDatav3[] <StorageItemList>k__BackingField; // 0x30

	// Properties
	public byte StorageNo { get; set; }
	public ItemDatav2 ItemData { get; set; }
	public StorageItemDatav3[] StorageItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37803D0 Offset: 0x377C3D0 VA: 0x37803D0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37803D8 Offset: 0x377C3D8 VA: 0x37803D8
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x37803E0 Offset: 0x377C3E0 VA: 0x37803E0
	public void set_StorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37803E8 Offset: 0x377C3E8 VA: 0x37803E8
	public ItemDatav2 get_ItemData() { }

	[CompilerGenerated]
	// RVA: 0x37803F0 Offset: 0x377C3F0 VA: 0x37803F0
	public void set_ItemData(ItemDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x37803F8 Offset: 0x377C3F8 VA: 0x37803F8
	public StorageItemDatav3[] get_StorageItemList() { }

	[CompilerGenerated]
	// RVA: 0x3780400 Offset: 0x377C400 VA: 0x3780400
	public void set_StorageItemList(StorageItemDatav3[] value) { }

	// RVA: 0x3780408 Offset: 0x377C408 VA: 0x3780408 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3780410 Offset: 0x377C410 VA: 0x3780410 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3780418 Offset: 0x377C418 VA: 0x3780418 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3780698 Offset: 0x377C698 VA: 0x3780698 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageSearchPickupResponse : OperationResponseBase // TypeDefIndex: 12051
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private StorageItemDatav3 <StorageItem>k__BackingField; // 0x28

	// Properties
	public ItemDatav2[] ItemList { get; set; }
	public StorageItemDatav3 StorageItem { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377DFC0 Offset: 0x3779FC0 VA: 0x377DFC0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377DFC8 Offset: 0x3779FC8 VA: 0x377DFC8
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x377DFD0 Offset: 0x3779FD0 VA: 0x377DFD0
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x377DFD8 Offset: 0x3779FD8 VA: 0x377DFD8
	public StorageItemDatav3 get_StorageItem() { }

	[CompilerGenerated]
	// RVA: 0x377DFE0 Offset: 0x3779FE0 VA: 0x377DFE0
	public void set_StorageItem(StorageItemDatav3 value) { }

	// RVA: 0x377DFE8 Offset: 0x3779FE8 VA: 0x377DFE8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377DFF0 Offset: 0x3779FF0 VA: 0x377DFF0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377DFF8 Offset: 0x3779FF8 VA: 0x377DFF8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x377E0D4 Offset: 0x377A0D4 VA: 0x377E0D4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

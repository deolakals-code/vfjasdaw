// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageGetItemsResponse : OperationResponseBase // TypeDefIndex: 12058
{
	// Fields
	[CompilerGenerated]
	private StorageDatav2 <StorageData>k__BackingField; // 0x20
	[CompilerGenerated]
	private StorageItemDatav3[] <StorageItemList>k__BackingField; // 0x28

	// Properties
	public StorageDatav2 StorageData { get; set; }
	public StorageItemDatav3[] StorageItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377F264 Offset: 0x377B264 VA: 0x377F264
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377F26C Offset: 0x377B26C VA: 0x377F26C
	public StorageDatav2 get_StorageData() { }

	[CompilerGenerated]
	// RVA: 0x377F274 Offset: 0x377B274 VA: 0x377F274
	public void set_StorageData(StorageDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x377F27C Offset: 0x377B27C VA: 0x377F27C
	public StorageItemDatav3[] get_StorageItemList() { }

	[CompilerGenerated]
	// RVA: 0x377F284 Offset: 0x377B284 VA: 0x377F284
	public void set_StorageItemList(StorageItemDatav3[] value) { }

	// RVA: 0x377F28C Offset: 0x377B28C VA: 0x377F28C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377F294 Offset: 0x377B294 VA: 0x377F294 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377F29C Offset: 0x377B29C VA: 0x377F29C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377F48C Offset: 0x377B48C VA: 0x377F48C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

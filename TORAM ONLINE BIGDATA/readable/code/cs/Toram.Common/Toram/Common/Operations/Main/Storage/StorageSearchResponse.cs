// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageSearchResponse : OperationResponseBase // TypeDefIndex: 12052
{
	// Fields
	[CompilerGenerated]
	private StorageItemDatav3[] <StorageItemList>k__BackingField; // 0x20

	// Properties
	public StorageItemDatav3[] StorageItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377E310 Offset: 0x377A310 VA: 0x377E310
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377E318 Offset: 0x377A318 VA: 0x377E318
	public StorageItemDatav3[] get_StorageItemList() { }

	[CompilerGenerated]
	// RVA: 0x377E320 Offset: 0x377A320 VA: 0x377E320
	public void set_StorageItemList(StorageItemDatav3[] value) { }

	// RVA: 0x377E328 Offset: 0x377A328 VA: 0x377E328 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377E330 Offset: 0x377A330 VA: 0x377E330 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377E338 Offset: 0x377A338 VA: 0x377E338 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x377E3A8 Offset: 0x377A3A8 VA: 0x377E3A8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

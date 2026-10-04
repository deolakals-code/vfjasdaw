// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageSortItemResponse : OperationRequestBase // TypeDefIndex: 12066
{
	// Fields
	[CompilerGenerated]
	private byte <StorageNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private StorageItemDatav3[] <StorageItemList>k__BackingField; // 0x28

	// Properties
	public byte StorageNo { get; set; }
	public StorageItemDatav3[] StorageItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3780A04 Offset: 0x377CA04 VA: 0x3780A04
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3780A0C Offset: 0x377CA0C VA: 0x3780A0C
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x3780A14 Offset: 0x377CA14 VA: 0x3780A14
	public void set_StorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3780A1C Offset: 0x377CA1C VA: 0x3780A1C
	public StorageItemDatav3[] get_StorageItemList() { }

	[CompilerGenerated]
	// RVA: 0x3780A24 Offset: 0x377CA24 VA: 0x3780A24
	public void set_StorageItemList(StorageItemDatav3[] value) { }

	// RVA: 0x3780A2C Offset: 0x377CA2C VA: 0x3780A2C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3780A34 Offset: 0x377CA34 VA: 0x3780A34 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3780A3C Offset: 0x377CA3C VA: 0x3780A3C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3780BC4 Offset: 0x377CBC4 VA: 0x3780BC4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

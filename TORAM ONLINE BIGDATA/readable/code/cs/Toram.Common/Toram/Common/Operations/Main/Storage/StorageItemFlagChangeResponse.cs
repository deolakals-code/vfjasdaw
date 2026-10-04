// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageItemFlagChangeResponse : OperationResponseBase // TypeDefIndex: 12062
{
	// Fields
	[CompilerGenerated]
	private byte <StorageNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private StorageItemDatav3 <StorageItem>k__BackingField; // 0x28

	// Properties
	public byte StorageNo { get; set; }
	public StorageItemDatav3 StorageItem { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377FD50 Offset: 0x377BD50 VA: 0x377FD50
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377FD58 Offset: 0x377BD58 VA: 0x377FD58
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x377FD60 Offset: 0x377BD60 VA: 0x377FD60
	public void set_StorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377FD68 Offset: 0x377BD68 VA: 0x377FD68
	public StorageItemDatav3 get_StorageItem() { }

	[CompilerGenerated]
	// RVA: 0x377FD70 Offset: 0x377BD70 VA: 0x377FD70
	public void set_StorageItem(StorageItemDatav3 value) { }

	// RVA: 0x377FD78 Offset: 0x377BD78 VA: 0x377FD78 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377FD80 Offset: 0x377BD80 VA: 0x377FD80 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377FD88 Offset: 0x377BD88 VA: 0x377FD88 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377FF74 Offset: 0x377BF74 VA: 0x377FF74 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

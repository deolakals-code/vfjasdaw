// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StoragePutItem : OperationRequestBase // TypeDefIndex: 12063
{
	// Fields
	[CompilerGenerated]
	private ItemSelectData <SelectItem>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <StorageNo>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <UseType>k__BackingField; // 0x29

	// Properties
	public ItemSelectData SelectItem { get; set; }
	public byte StorageNo { get; set; }
	public byte UseType { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378003C Offset: 0x377C03C VA: 0x378003C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3780044 Offset: 0x377C044 VA: 0x3780044
	public ItemSelectData get_SelectItem() { }

	[CompilerGenerated]
	// RVA: 0x378004C Offset: 0x377C04C VA: 0x378004C
	public void set_SelectItem(ItemSelectData value) { }

	[CompilerGenerated]
	// RVA: 0x3780054 Offset: 0x377C054 VA: 0x3780054
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x378005C Offset: 0x377C05C VA: 0x378005C
	public void set_StorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3780064 Offset: 0x377C064 VA: 0x3780064
	public byte get_UseType() { }

	[CompilerGenerated]
	// RVA: 0x378006C Offset: 0x377C06C VA: 0x378006C
	public void set_UseType(byte value) { }

	// RVA: 0x3780074 Offset: 0x377C074 VA: 0x3780074 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378007C Offset: 0x377C07C VA: 0x378007C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3780084 Offset: 0x377C084 VA: 0x3780084 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37802D4 Offset: 0x377C2D4 VA: 0x37802D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

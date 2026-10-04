// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Storage
public class StorageDiscardItemResponse : OperationResponseBase // TypeDefIndex: 12056
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

	// RVA: 0x377ED90 Offset: 0x377AD90 VA: 0x377ED90
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377ED98 Offset: 0x377AD98 VA: 0x377ED98
	public byte get_StorageNo() { }

	[CompilerGenerated]
	// RVA: 0x377EDA0 Offset: 0x377ADA0 VA: 0x377EDA0
	public void set_StorageNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377EDA8 Offset: 0x377ADA8 VA: 0x377EDA8
	public StorageItemDatav3 get_StorageItem() { }

	[CompilerGenerated]
	// RVA: 0x377EDB0 Offset: 0x377ADB0 VA: 0x377EDB0
	public void set_StorageItem(StorageItemDatav3 value) { }

	// RVA: 0x377EDB8 Offset: 0x377ADB8 VA: 0x377EDB8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377EDC0 Offset: 0x377ADC0 VA: 0x377EDC0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377EDC8 Offset: 0x377ADC8 VA: 0x377EDC8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377EFB4 Offset: 0x377AFB4 VA: 0x377EFB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

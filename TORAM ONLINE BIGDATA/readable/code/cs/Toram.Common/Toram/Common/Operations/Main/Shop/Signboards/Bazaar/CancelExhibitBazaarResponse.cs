// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Shop.Signboards.Bazaar
public class CancelExhibitBazaarResponse : OperationResponseBase // TypeDefIndex: 11972
{
	// Fields
	[CompilerGenerated]
	private byte <SlotIndex>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <UpdateItemList>k__BackingField; // 0x28

	// Properties
	public byte SlotIndex { get; set; }
	public ItemDatav2[] UpdateItemList { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3770124 Offset: 0x376C124 VA: 0x3770124
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x377012C Offset: 0x376C12C VA: 0x377012C
	public byte get_SlotIndex() { }

	[CompilerGenerated]
	// RVA: 0x3770134 Offset: 0x376C134 VA: 0x3770134
	public void set_SlotIndex(byte value) { }

	[CompilerGenerated]
	// RVA: 0x377013C Offset: 0x376C13C VA: 0x377013C
	public ItemDatav2[] get_UpdateItemList() { }

	[CompilerGenerated]
	// RVA: 0x3770144 Offset: 0x376C144 VA: 0x3770144
	public void set_UpdateItemList(ItemDatav2[] value) { }

	// RVA: 0x377014C Offset: 0x376C14C VA: 0x377014C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3770154 Offset: 0x376C154 VA: 0x3770154 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377015C Offset: 0x376C15C VA: 0x377015C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3770244 Offset: 0x376C244 VA: 0x3770244 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

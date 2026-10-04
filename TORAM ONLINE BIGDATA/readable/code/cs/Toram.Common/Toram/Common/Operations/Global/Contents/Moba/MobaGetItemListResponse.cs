// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaGetItemListResponse : OperationResponseBase // TypeDefIndex: 11602
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <ShopItemIds>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x30

	// Properties
	public short ReturnCode { get; set; }
	public int[] ShopItemIds { get; set; }
	public int Price { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3722AC0 Offset: 0x371EAC0 VA: 0x3722AC0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3722AC8 Offset: 0x371EAC8 VA: 0x3722AC8
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3722AD0 Offset: 0x371EAD0 VA: 0x3722AD0
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3722AD8 Offset: 0x371EAD8 VA: 0x3722AD8
	public int[] get_ShopItemIds() { }

	[CompilerGenerated]
	// RVA: 0x3722AE0 Offset: 0x371EAE0 VA: 0x3722AE0
	public void set_ShopItemIds(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3722AE8 Offset: 0x371EAE8 VA: 0x3722AE8
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x3722AF0 Offset: 0x371EAF0 VA: 0x3722AF0
	public void set_Price(int value) { }

	// RVA: 0x3722AF8 Offset: 0x371EAF8 VA: 0x3722AF8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3722B00 Offset: 0x371EB00 VA: 0x3722B00 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3722B08 Offset: 0x371EB08 VA: 0x3722B08 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3722BFC Offset: 0x371EBFC VA: 0x3722BFC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

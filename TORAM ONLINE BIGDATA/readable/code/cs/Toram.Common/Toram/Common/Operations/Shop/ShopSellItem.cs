// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class ShopSellItem : OperationRequestBase // TypeDefIndex: 11718
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private ItemSelectData[] <SelectItem>k__BackingField; // 0x30

	// Properties
	public int ShopId { get; set; }
	public short[] Position { get; set; }
	public ItemSelectData[] SelectItem { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373A248 Offset: 0x3736248 VA: 0x373A248
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x373A250 Offset: 0x3736250 VA: 0x373A250
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x373A258 Offset: 0x3736258 VA: 0x373A258
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x373A260 Offset: 0x3736260 VA: 0x373A260
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x373A268 Offset: 0x3736268 VA: 0x373A268
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x373A270 Offset: 0x3736270 VA: 0x373A270
	public ItemSelectData[] get_SelectItem() { }

	[CompilerGenerated]
	// RVA: 0x373A278 Offset: 0x3736278 VA: 0x373A278
	public void set_SelectItem(ItemSelectData[] value) { }

	// RVA: 0x373A280 Offset: 0x3736280 VA: 0x373A280 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373A288 Offset: 0x3736288 VA: 0x373A288 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373A290 Offset: 0x3736290 VA: 0x373A290 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373A380 Offset: 0x3736380 VA: 0x373A380 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class ShopSellItemResponse : OperationResponseBase // TypeDefIndex: 11719
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x30

	// Properties
	public int ShopId { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373A5DC Offset: 0x37365DC VA: 0x373A5DC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x373A5E4 Offset: 0x37365E4 VA: 0x373A5E4
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x373A5EC Offset: 0x37365EC VA: 0x373A5EC
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x373A5F4 Offset: 0x37365F4 VA: 0x373A5F4
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x373A5FC Offset: 0x37365FC VA: 0x373A5FC
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x373A604 Offset: 0x3736604 VA: 0x373A604
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x373A60C Offset: 0x373660C VA: 0x373A60C
	public void set_Gold(int value) { }

	// RVA: 0x373A614 Offset: 0x3736614 VA: 0x373A614 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373A61C Offset: 0x373661C VA: 0x373A61C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373A624 Offset: 0x3736624 VA: 0x373A624 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373A738 Offset: 0x3736738 VA: 0x373A738 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

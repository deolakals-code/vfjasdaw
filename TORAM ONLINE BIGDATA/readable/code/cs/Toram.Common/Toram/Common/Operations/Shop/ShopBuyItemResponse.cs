// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class ShopBuyItemResponse : OperationResponseBase // TypeDefIndex: 11715
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

	// RVA: 0x3739930 Offset: 0x3735930 VA: 0x3739930
	public void .ctor() { }

	// RVA: 0x3739938 Offset: 0x3735938 VA: 0x3739938
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3739940 Offset: 0x3735940 VA: 0x3739940
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x3739948 Offset: 0x3735948 VA: 0x3739948
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3739950 Offset: 0x3735950 VA: 0x3739950
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3739958 Offset: 0x3735958 VA: 0x3739958
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3739960 Offset: 0x3735960 VA: 0x3739960
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3739968 Offset: 0x3735968 VA: 0x3739968
	public void set_Gold(int value) { }

	// RVA: 0x3739970 Offset: 0x3735970 VA: 0x3739970 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3739978 Offset: 0x3735978 VA: 0x3739978 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3739980 Offset: 0x3735980 VA: 0x3739980 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3739A94 Offset: 0x3735A94 VA: 0x3739A94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

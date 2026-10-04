// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class MaterialProcessingResponse : OperationResponseBase // TypeDefIndex: 11711
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <MaterialPoint>k__BackingField; // 0x30
	[CompilerGenerated]
	private MaterialData <Material>k__BackingField; // 0x38

	// Properties
	public int ShopId { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public int MaterialPoint { get; set; }
	public MaterialData Material { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37381F8 Offset: 0x37341F8 VA: 0x37381F8
	public void .ctor() { }

	// RVA: 0x3738200 Offset: 0x3734200 VA: 0x3738200
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3738208 Offset: 0x3734208 VA: 0x3738208
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x3738210 Offset: 0x3734210 VA: 0x3738210
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3738218 Offset: 0x3734218 VA: 0x3738218
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3738220 Offset: 0x3734220 VA: 0x3738220
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3738228 Offset: 0x3734228 VA: 0x3738228
	public int get_MaterialPoint() { }

	[CompilerGenerated]
	// RVA: 0x3738230 Offset: 0x3734230 VA: 0x3738230
	public void set_MaterialPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x3738238 Offset: 0x3734238 VA: 0x3738238
	public MaterialData get_Material() { }

	[CompilerGenerated]
	// RVA: 0x3738240 Offset: 0x3734240 VA: 0x3738240
	public void set_Material(MaterialData value) { }

	// RVA: 0x3738248 Offset: 0x3734248 VA: 0x3738248 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3738250 Offset: 0x3734250 VA: 0x3738250 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3738258 Offset: 0x3734258 VA: 0x3738258 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3738394 Offset: 0x3734394 VA: 0x3738394 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class ArmorRemodelingResponse : OperationResponseBase // TypeDefIndex: 11703
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2 <ItemData>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x30

	// Properties
	public int ShopId { get; set; }
	public ItemDatav2 ItemData { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3735C6C Offset: 0x3731C6C VA: 0x3735C6C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3735C74 Offset: 0x3731C74 VA: 0x3735C74
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x3735C7C Offset: 0x3731C7C VA: 0x3735C7C
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3735C84 Offset: 0x3731C84 VA: 0x3735C84
	public ItemDatav2 get_ItemData() { }

	[CompilerGenerated]
	// RVA: 0x3735C8C Offset: 0x3731C8C VA: 0x3735C8C
	public void set_ItemData(ItemDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x3735C94 Offset: 0x3731C94 VA: 0x3735C94
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3735C9C Offset: 0x3731C9C VA: 0x3735C9C
	public void set_Gold(int value) { }

	// RVA: 0x3735CA4 Offset: 0x3731CA4 VA: 0x3735CA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3735CAC Offset: 0x3731CAC VA: 0x3735CAC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3735CB4 Offset: 0x3731CB4 VA: 0x3735CB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3735DB4 Offset: 0x3731DB4 VA: 0x3735DB4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

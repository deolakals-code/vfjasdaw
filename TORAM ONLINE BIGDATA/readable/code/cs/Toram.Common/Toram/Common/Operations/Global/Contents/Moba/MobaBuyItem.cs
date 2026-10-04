// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaBuyItem : OperationRequestBase // TypeDefIndex: 11591
{
	// Fields
	[CompilerGenerated]
	private int <ShopItemId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x24

	// Properties
	public int ShopItemId { get; set; }
	public int Price { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3720A44 Offset: 0x371CA44 VA: 0x3720A44
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3720A4C Offset: 0x371CA4C VA: 0x3720A4C
	public int get_ShopItemId() { }

	[CompilerGenerated]
	// RVA: 0x3720A54 Offset: 0x371CA54 VA: 0x3720A54
	public void set_ShopItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3720A5C Offset: 0x371CA5C VA: 0x3720A5C
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x3720A64 Offset: 0x371CA64 VA: 0x3720A64
	public void set_Price(int value) { }

	// RVA: 0x3720A6C Offset: 0x371CA6C VA: 0x3720A6C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3720A74 Offset: 0x371CA74 VA: 0x3720A74 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3720A7C Offset: 0x371CA7C VA: 0x3720A7C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3720B44 Offset: 0x371CB44 VA: 0x3720B44 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

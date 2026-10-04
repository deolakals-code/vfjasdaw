// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaBuyItemResponse : OperationResponseBase // TypeDefIndex: 11592
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ShopItemId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <NextPrice>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x2C

	// Properties
	public short ReturnCode { get; set; }
	public int ShopItemId { get; set; }
	public int NextPrice { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3720CB0 Offset: 0x371CCB0 VA: 0x3720CB0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3720CB8 Offset: 0x371CCB8 VA: 0x3720CB8
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3720CC0 Offset: 0x371CCC0 VA: 0x3720CC0
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3720CC8 Offset: 0x371CCC8 VA: 0x3720CC8
	public int get_ShopItemId() { }

	[CompilerGenerated]
	// RVA: 0x3720CD0 Offset: 0x371CCD0 VA: 0x3720CD0
	public void set_ShopItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3720CD8 Offset: 0x371CCD8 VA: 0x3720CD8
	public int get_NextPrice() { }

	[CompilerGenerated]
	// RVA: 0x3720CE0 Offset: 0x371CCE0 VA: 0x3720CE0
	public void set_NextPrice(int value) { }

	[CompilerGenerated]
	// RVA: 0x3720CE8 Offset: 0x371CCE8 VA: 0x3720CE8
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3720CF0 Offset: 0x371CCF0 VA: 0x3720CF0
	public void set_Gold(int value) { }

	// RVA: 0x3720CF8 Offset: 0x371CCF8 VA: 0x3720CF8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3720D00 Offset: 0x371CD00 VA: 0x3720D00 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3720D08 Offset: 0x371CD08 VA: 0x3720D08 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3720E3C Offset: 0x371CE3C VA: 0x3720E3C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

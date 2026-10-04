// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class ShopBuyItem : OperationRequestBase // TypeDefIndex: 11714
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <ItemNum>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x38

	// Properties
	public int ShopId { get; set; }
	public short[] Position { get; set; }
	public int ItemId { get; set; }
	public short ItemNum { get; set; }
	public int Gold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37394C4 Offset: 0x37354C4 VA: 0x37394C4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37394CC Offset: 0x37354CC VA: 0x37394CC
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x37394D4 Offset: 0x37354D4 VA: 0x37394D4
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37394DC Offset: 0x37354DC VA: 0x37394DC
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x37394E4 Offset: 0x37354E4 VA: 0x37394E4
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x37394EC Offset: 0x37354EC VA: 0x37394EC
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x37394F4 Offset: 0x37354F4 VA: 0x37394F4
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37394FC Offset: 0x37354FC VA: 0x37394FC
	public short get_ItemNum() { }

	[CompilerGenerated]
	// RVA: 0x3739504 Offset: 0x3735504 VA: 0x3739504
	public void set_ItemNum(short value) { }

	[CompilerGenerated]
	// RVA: 0x373950C Offset: 0x373550C VA: 0x373950C
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3739514 Offset: 0x3735514 VA: 0x3739514
	public void set_Gold(int value) { }

	// RVA: 0x373951C Offset: 0x373551C VA: 0x373951C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3739524 Offset: 0x3735524 VA: 0x3739524 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373952C Offset: 0x373552C VA: 0x373952C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3739678 Offset: 0x3735678 VA: 0x3739678 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

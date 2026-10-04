// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaBuyEquip : OperationRequestBase // TypeDefIndex: 11589
{
	// Fields
	[CompilerGenerated]
	private byte <BuyEquipType>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <BuyItemType>k__BackingField; // 0x21
	[CompilerGenerated]
	private int <Atk>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsUpdate>k__BackingField; // 0x2C

	// Properties
	public byte BuyEquipType { get; set; }
	public byte BuyItemType { get; set; }
	public int Atk { get; set; }
	public int Price { get; set; }
	public bool IsUpdate { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371FE10 Offset: 0x371BE10 VA: 0x371FE10
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371FE18 Offset: 0x371BE18 VA: 0x371FE18
	public byte get_BuyEquipType() { }

	[CompilerGenerated]
	// RVA: 0x371FE20 Offset: 0x371BE20 VA: 0x371FE20
	public void set_BuyEquipType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371FE28 Offset: 0x371BE28 VA: 0x371FE28
	public byte get_BuyItemType() { }

	[CompilerGenerated]
	// RVA: 0x371FE30 Offset: 0x371BE30 VA: 0x371FE30
	public void set_BuyItemType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371FE38 Offset: 0x371BE38 VA: 0x371FE38
	public int get_Atk() { }

	[CompilerGenerated]
	// RVA: 0x371FE40 Offset: 0x371BE40 VA: 0x371FE40
	public void set_Atk(int value) { }

	[CompilerGenerated]
	// RVA: 0x371FE48 Offset: 0x371BE48 VA: 0x371FE48
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x371FE50 Offset: 0x371BE50 VA: 0x371FE50
	public void set_Price(int value) { }

	[CompilerGenerated]
	// RVA: 0x371FE58 Offset: 0x371BE58 VA: 0x371FE58
	public bool get_IsUpdate() { }

	[CompilerGenerated]
	// RVA: 0x371FE60 Offset: 0x371BE60 VA: 0x371FE60
	public void set_IsUpdate(bool value) { }

	// RVA: 0x371FE6C Offset: 0x371BE6C VA: 0x371FE6C Slot: 3
	public override string ToString() { }

	// RVA: 0x3720070 Offset: 0x371C070 VA: 0x3720070 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3720078 Offset: 0x371C078 VA: 0x3720078 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3720080 Offset: 0x371C080 VA: 0x3720080 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37201F8 Offset: 0x371C1F8 VA: 0x37201F8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

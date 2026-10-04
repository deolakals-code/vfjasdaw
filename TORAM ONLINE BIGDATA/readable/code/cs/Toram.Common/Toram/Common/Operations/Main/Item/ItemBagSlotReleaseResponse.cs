// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Item
public class ItemBagSlotReleaseResponse : OperationResponseBase // TypeDefIndex: 12129
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <VariableType>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <VariableValue>k__BackingField; // 0x38
	[CompilerGenerated]
	private short[] <InventoryCapacity>k__BackingField; // 0x40

	// Properties
	public ItemDatav2[] ItemList { get; set; }
	public MaterialData[] MaterialList { get; set; }
	public int Gold { get; set; }
	public byte VariableType { get; set; }
	public int VariableValue { get; set; }
	public short[] InventoryCapacity { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378D4C4 Offset: 0x37894C4 VA: 0x378D4C4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378D4CC Offset: 0x37894CC VA: 0x378D4CC
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x378D4D4 Offset: 0x37894D4 VA: 0x378D4D4
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x378D4DC Offset: 0x37894DC VA: 0x378D4DC
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x378D4E4 Offset: 0x37894E4 VA: 0x378D4E4
	public void set_MaterialList(MaterialData[] value) { }

	[CompilerGenerated]
	// RVA: 0x378D4EC Offset: 0x37894EC VA: 0x378D4EC
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x378D4F4 Offset: 0x37894F4 VA: 0x378D4F4
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x378D4FC Offset: 0x37894FC VA: 0x378D4FC
	public byte get_VariableType() { }

	[CompilerGenerated]
	// RVA: 0x378D504 Offset: 0x3789504 VA: 0x378D504
	public void set_VariableType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378D50C Offset: 0x378950C VA: 0x378D50C
	public int get_VariableValue() { }

	[CompilerGenerated]
	// RVA: 0x378D514 Offset: 0x3789514 VA: 0x378D514
	public void set_VariableValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x378D51C Offset: 0x378951C VA: 0x378D51C
	public short[] get_InventoryCapacity() { }

	[CompilerGenerated]
	// RVA: 0x378D524 Offset: 0x3789524 VA: 0x378D524
	public void set_InventoryCapacity(short[] value) { }

	// RVA: 0x378D52C Offset: 0x378952C VA: 0x378D52C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378D534 Offset: 0x3789534 VA: 0x378D534 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378D53C Offset: 0x378953C VA: 0x378D53C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378D6EC Offset: 0x37896EC VA: 0x378D6EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

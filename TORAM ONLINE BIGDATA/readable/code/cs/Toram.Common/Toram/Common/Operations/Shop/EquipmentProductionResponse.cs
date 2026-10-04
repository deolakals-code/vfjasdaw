// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class EquipmentProductionResponse : OperationResponseBase // TypeDefIndex: 11709
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <BlackSmith>k__BackingField; // 0x3C
	[CompilerGenerated]
	private bool <Result>k__BackingField; // 0x40

	// Properties
	public int ShopId { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public MaterialData[] MaterialList { get; set; }
	public int Gold { get; set; }
	public int BlackSmith { get; set; }
	public bool Result { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3737708 Offset: 0x3733708 VA: 0x3737708
	public void .ctor() { }

	// RVA: 0x3737710 Offset: 0x3733710 VA: 0x3737710
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3737718 Offset: 0x3733718 VA: 0x3737718
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x3737720 Offset: 0x3733720 VA: 0x3737720
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3737728 Offset: 0x3733728 VA: 0x3737728
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3737730 Offset: 0x3733730 VA: 0x3737730
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3737738 Offset: 0x3733738 VA: 0x3737738
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x3737740 Offset: 0x3733740 VA: 0x3737740
	public void set_MaterialList(MaterialData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3737748 Offset: 0x3733748 VA: 0x3737748
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3737750 Offset: 0x3733750 VA: 0x3737750
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x3737758 Offset: 0x3733758 VA: 0x3737758
	public int get_BlackSmith() { }

	[CompilerGenerated]
	// RVA: 0x3737760 Offset: 0x3733760 VA: 0x3737760
	public void set_BlackSmith(int value) { }

	[CompilerGenerated]
	// RVA: 0x3737768 Offset: 0x3733768 VA: 0x3737768
	public bool get_Result() { }

	[CompilerGenerated]
	// RVA: 0x3737770 Offset: 0x3733770 VA: 0x3737770
	public void set_Result(bool value) { }

	// RVA: 0x373777C Offset: 0x373377C VA: 0x373777C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3737784 Offset: 0x3733784 VA: 0x3737784 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373778C Offset: 0x373378C VA: 0x373778C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x373795C Offset: 0x373395C VA: 0x373795C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

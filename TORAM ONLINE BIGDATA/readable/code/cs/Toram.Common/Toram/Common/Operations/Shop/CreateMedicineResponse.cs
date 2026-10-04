// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class CreateMedicineResponse : OperationResponseBase // TypeDefIndex: 11705
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x28
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <ItemNum>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x3C
	[CompilerGenerated]
	private int <Alchemy>k__BackingField; // 0x40

	// Properties
	public int ShopId { get; set; }
	public ItemDatav2[] ItemList { get; set; }
	public MaterialData[] MaterialList { get; set; }
	public short ItemNum { get; set; }
	public int Gold { get; set; }
	public int Alchemy { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3736498 Offset: 0x3732498 VA: 0x3736498
	public void .ctor() { }

	// RVA: 0x37364A0 Offset: 0x37324A0 VA: 0x37364A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37364A8 Offset: 0x37324A8 VA: 0x37364A8
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x37364B0 Offset: 0x37324B0 VA: 0x37364B0
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37364B8 Offset: 0x37324B8 VA: 0x37364B8
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x37364C0 Offset: 0x37324C0 VA: 0x37364C0
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x37364C8 Offset: 0x37324C8 VA: 0x37364C8
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x37364D0 Offset: 0x37324D0 VA: 0x37364D0
	public void set_MaterialList(MaterialData[] value) { }

	[CompilerGenerated]
	// RVA: 0x37364D8 Offset: 0x37324D8 VA: 0x37364D8
	public short get_ItemNum() { }

	[CompilerGenerated]
	// RVA: 0x37364E0 Offset: 0x37324E0 VA: 0x37364E0
	public void set_ItemNum(short value) { }

	[CompilerGenerated]
	// RVA: 0x37364E8 Offset: 0x37324E8 VA: 0x37364E8
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x37364F0 Offset: 0x37324F0 VA: 0x37364F0
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x37364F8 Offset: 0x37324F8 VA: 0x37364F8
	public int get_Alchemy() { }

	[CompilerGenerated]
	// RVA: 0x3736500 Offset: 0x3732500 VA: 0x3736500
	public void set_Alchemy(int value) { }

	// RVA: 0x3736508 Offset: 0x3732508 VA: 0x3736508 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3736510 Offset: 0x3732510 VA: 0x3736510 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3736518 Offset: 0x3732518 VA: 0x3736518 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37366F4 Offset: 0x37326F4 VA: 0x37366F4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

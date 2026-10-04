// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class MaterialProcessing : OperationRequestBase // TypeDefIndex: 11710
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ShopType>k__BackingField; // 0x24
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x30
	[CompilerGenerated]
	private ItemSelectData[] <ItemList>k__BackingField; // 0x38

	// Properties
	public int ShopId { get; set; }
	public byte ShopType { get; set; }
	public short[] Position { get; set; }
	public short SkillId { get; set; }
	public ItemSelectData[] ItemList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3737D14 Offset: 0x3733D14 VA: 0x3737D14
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3737D1C Offset: 0x3733D1C VA: 0x3737D1C
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x3737D24 Offset: 0x3733D24 VA: 0x3737D24
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3737D2C Offset: 0x3733D2C VA: 0x3737D2C
	public byte get_ShopType() { }

	[CompilerGenerated]
	// RVA: 0x3737D34 Offset: 0x3733D34 VA: 0x3737D34
	public void set_ShopType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3737D3C Offset: 0x3733D3C VA: 0x3737D3C
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3737D44 Offset: 0x3733D44 VA: 0x3737D44
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3737D4C Offset: 0x3733D4C VA: 0x3737D4C
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x3737D54 Offset: 0x3733D54 VA: 0x3737D54
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3737D5C Offset: 0x3733D5C VA: 0x3737D5C
	public ItemSelectData[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3737D64 Offset: 0x3733D64 VA: 0x3737D64
	public void set_ItemList(ItemSelectData[] value) { }

	// RVA: 0x3737D6C Offset: 0x3733D6C VA: 0x3737D6C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3737D74 Offset: 0x3733D74 VA: 0x3737D74 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3737D7C Offset: 0x3733D7C VA: 0x3737D7C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3737EEC Offset: 0x3733EEC VA: 0x3737EEC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

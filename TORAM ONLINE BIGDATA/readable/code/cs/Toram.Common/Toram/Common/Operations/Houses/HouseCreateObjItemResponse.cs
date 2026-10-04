// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseCreateObjItemResponse : OperationResponseBase // TypeDefIndex: 12170
{
	// Fields
	[CompilerGenerated]
	private ItemDatav2[] <ItemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private MaterialData[] <MaterialList>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <PaidOrb>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <ObjId>k__BackingField; // 0x3C
	[CompilerGenerated]
	private byte <Num>k__BackingField; // 0x40
	[CompilerGenerated]
	private short[] <FishIndexList>k__BackingField; // 0x48

	// Properties
	public ItemDatav2[] ItemList { get; set; }
	public MaterialData[] MaterialList { get; set; }
	public int Gold { get; set; }
	public int Orb { get; set; }
	public int PaidOrb { get; set; }
	public int ObjId { get; set; }
	public byte Num { get; set; }
	public short[] FishIndexList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3794AFC Offset: 0x3790AFC VA: 0x3794AFC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3794B04 Offset: 0x3790B04 VA: 0x3794B04
	public ItemDatav2[] get_ItemList() { }

	[CompilerGenerated]
	// RVA: 0x3794B0C Offset: 0x3790B0C VA: 0x3794B0C
	public void set_ItemList(ItemDatav2[] value) { }

	[CompilerGenerated]
	// RVA: 0x3794B14 Offset: 0x3790B14 VA: 0x3794B14
	public MaterialData[] get_MaterialList() { }

	[CompilerGenerated]
	// RVA: 0x3794B1C Offset: 0x3790B1C VA: 0x3794B1C
	public void set_MaterialList(MaterialData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3794B24 Offset: 0x3790B24 VA: 0x3794B24
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x3794B2C Offset: 0x3790B2C VA: 0x3794B2C
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x3794B34 Offset: 0x3790B34 VA: 0x3794B34
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x3794B3C Offset: 0x3790B3C VA: 0x3794B3C
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3794B44 Offset: 0x3790B44 VA: 0x3794B44
	public int get_PaidOrb() { }

	[CompilerGenerated]
	// RVA: 0x3794B4C Offset: 0x3790B4C VA: 0x3794B4C
	public void set_PaidOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3794B54 Offset: 0x3790B54 VA: 0x3794B54
	public int get_ObjId() { }

	[CompilerGenerated]
	// RVA: 0x3794B5C Offset: 0x3790B5C VA: 0x3794B5C
	public void set_ObjId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3794B64 Offset: 0x3790B64 VA: 0x3794B64
	public byte get_Num() { }

	[CompilerGenerated]
	// RVA: 0x3794B6C Offset: 0x3790B6C VA: 0x3794B6C
	public void set_Num(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3794B74 Offset: 0x3790B74 VA: 0x3794B74
	public short[] get_FishIndexList() { }

	[CompilerGenerated]
	// RVA: 0x3794B7C Offset: 0x3790B7C VA: 0x3794B7C
	public void set_FishIndexList(short[] value) { }

	// RVA: 0x3794B84 Offset: 0x3790B84 VA: 0x3794B84 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3794B8C Offset: 0x3790B8C VA: 0x3794B8C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3794B94 Offset: 0x3790B94 VA: 0x3794B94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x379500C Offset: 0x379100C VA: 0x379500C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}

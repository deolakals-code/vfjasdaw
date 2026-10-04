// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaRefineEquip : OperationRequestBase // TypeDefIndex: 11609
{
	// Fields
	[CompilerGenerated]
	private byte <RefineEquipType>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <RefineItemType>k__BackingField; // 0x21
	[CompilerGenerated]
	private byte <Refine>k__BackingField; // 0x22
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x24

	// Properties
	public byte RefineEquipType { get; set; }
	public byte RefineItemType { get; set; }
	public byte Refine { get; set; }
	public int Price { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3723ED0 Offset: 0x371FED0 VA: 0x3723ED0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3723ED8 Offset: 0x371FED8 VA: 0x3723ED8
	public byte get_RefineEquipType() { }

	[CompilerGenerated]
	// RVA: 0x3723EE0 Offset: 0x371FEE0 VA: 0x3723EE0
	public void set_RefineEquipType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3723EE8 Offset: 0x371FEE8 VA: 0x3723EE8
	public byte get_RefineItemType() { }

	[CompilerGenerated]
	// RVA: 0x3723EF0 Offset: 0x371FEF0 VA: 0x3723EF0
	public void set_RefineItemType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3723EF8 Offset: 0x371FEF8 VA: 0x3723EF8
	public byte get_Refine() { }

	[CompilerGenerated]
	// RVA: 0x3723F00 Offset: 0x371FF00 VA: 0x3723F00
	public void set_Refine(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3723F08 Offset: 0x371FF08 VA: 0x3723F08
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x3723F10 Offset: 0x371FF10 VA: 0x3723F10
	public void set_Price(int value) { }

	// RVA: 0x3723F18 Offset: 0x371FF18 VA: 0x3723F18 Slot: 3
	public override string ToString() { }

	// RVA: 0x3724130 Offset: 0x3720130 VA: 0x3724130 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3724138 Offset: 0x3720138 VA: 0x3724138 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3724140 Offset: 0x3720140 VA: 0x3724140 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3724274 Offset: 0x3720274 VA: 0x3724274 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

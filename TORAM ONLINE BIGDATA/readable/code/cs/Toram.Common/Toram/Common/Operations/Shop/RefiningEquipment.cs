// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class RefiningEquipment : OperationRequestBase // TypeDefIndex: 11712
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <ItemUuid>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <SupportItemId>k__BackingField; // 0x3C
	[CompilerGenerated]
	private bool <IsDirectSupport>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x44

	// Properties
	public int ShopId { get; set; }
	public short[] Position { get; set; }
	public short SkillId { get; set; }
	public int ItemUuid { get; set; }
	public int ItemId { get; set; }
	public int SupportItemId { get; set; }
	public bool IsDirectSupport { get; set; }
	public int Orb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373866C Offset: 0x373466C VA: 0x373866C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3738674 Offset: 0x3734674 VA: 0x3738674
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x373867C Offset: 0x373467C VA: 0x373867C
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3738684 Offset: 0x3734684 VA: 0x3738684
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x373868C Offset: 0x373468C VA: 0x373868C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3738694 Offset: 0x3734694 VA: 0x3738694
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x373869C Offset: 0x373469C VA: 0x373869C
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x37386A4 Offset: 0x37346A4 VA: 0x37386A4
	public int get_ItemUuid() { }

	[CompilerGenerated]
	// RVA: 0x37386AC Offset: 0x37346AC VA: 0x37386AC
	public void set_ItemUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x37386B4 Offset: 0x37346B4 VA: 0x37386B4
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x37386BC Offset: 0x37346BC VA: 0x37386BC
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37386C4 Offset: 0x37346C4 VA: 0x37386C4
	public int get_SupportItemId() { }

	[CompilerGenerated]
	// RVA: 0x37386CC Offset: 0x37346CC VA: 0x37386CC
	public void set_SupportItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37386D4 Offset: 0x37346D4 VA: 0x37386D4
	public bool get_IsDirectSupport() { }

	[CompilerGenerated]
	// RVA: 0x37386DC Offset: 0x37346DC VA: 0x37386DC
	public void set_IsDirectSupport(bool value) { }

	[CompilerGenerated]
	// RVA: 0x37386E8 Offset: 0x37346E8 VA: 0x37386E8
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x37386F0 Offset: 0x37346F0 VA: 0x37386F0
	public void set_Orb(int value) { }

	// RVA: 0x37386F8 Offset: 0x37346F8 VA: 0x37386F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3738700 Offset: 0x3734700 VA: 0x3738700 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3738708 Offset: 0x3734708 VA: 0x3738708 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37388F8 Offset: 0x37348F8 VA: 0x37388F8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}

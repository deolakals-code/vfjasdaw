// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ItemDBData : IDbItemData // TypeDefIndex: 2002
{
	// Fields
	private short[] capId; // 0x10
	private short[] capVal; // 0x18
	private List<BonusParameter> bonusLines; // 0x20
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <SortId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <TypeId>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Price>k__BackingField; // 0x34
	[CompilerGenerated]
	private byte <MaterialLv>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <MaterialId>k__BackingField; // 0x39
	[CompilerGenerated]
	private short <Process>k__BackingField; // 0x3A
	[CompilerGenerated]
	private short <Stack>k__BackingField; // 0x3C
	[CompilerGenerated]
	private short <Function>k__BackingField; // 0x3E
	[CompilerGenerated]
	private byte <Stable>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <Range>k__BackingField; // 0x41
	[CompilerGenerated]
	private byte <SlotMax>k__BackingField; // 0x42
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x44
	[CompilerGenerated]
	private int <Model>k__BackingField; // 0x48
	[CompilerGenerated]
	private short <Potential>k__BackingField; // 0x4C

	// Properties
	public int Id { get; set; }
	public int SortId { get; set; }
	public short TypeId { get; set; }
	public int Price { get; set; }
	public byte MaterialLv { get; set; }
	public byte MaterialId { get; set; }
	public short Process { get; set; }
	public short Stack { get; set; }
	public short Function { get; set; }
	public byte Stable { get; set; }
	public byte Range { get; set; }
	public byte SlotMax { get; set; }
	public int Flag { get; set; }
	public int Model { get; set; }
	public short Potential { get; set; }
	public short CapId1 { get; }
	public short CapId2 { get; }
	public short CapId3 { get; }
	public short CapId4 { get; }
	public short CapId5 { get; }
	public short CapId6 { get; }
	public short CapId7 { get; }
	public short CapId8 { get; }
	public short CapId9 { get; }
	public short CapId10 { get; }
	public short CapVal1 { get; }
	public short CapVal2 { get; }
	public short CapVal3 { get; }
	public short CapVal4 { get; }
	public short CapVal5 { get; }
	public short CapVal6 { get; }
	public short CapVal7 { get; }
	public short CapVal8 { get; }
	public short CapVal9 { get; }
	public short CapVal10 { get; }
	public ReadOnlyCollection<BonusParameter> BonusLines { get; }
	public short[] CapId { get; }
	public short[] CapVal { get; }
	public int AvatarCategory { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x21308C4 Offset: 0x212C8C4 VA: 0x21308C4 Slot: 4
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x21308CC Offset: 0x212C8CC VA: 0x21308CC
	private void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x21308D4 Offset: 0x212C8D4 VA: 0x21308D4 Slot: 5
	public int get_SortId() { }

	[CompilerGenerated]
	// RVA: 0x21308DC Offset: 0x212C8DC VA: 0x21308DC
	private void set_SortId(int value) { }

	[CompilerGenerated]
	// RVA: 0x21308E4 Offset: 0x212C8E4 VA: 0x21308E4 Slot: 6
	public short get_TypeId() { }

	[CompilerGenerated]
	// RVA: 0x21308EC Offset: 0x212C8EC VA: 0x21308EC
	private void set_TypeId(short value) { }

	[CompilerGenerated]
	// RVA: 0x21308F4 Offset: 0x212C8F4 VA: 0x21308F4 Slot: 7
	public int get_Price() { }

	[CompilerGenerated]
	// RVA: 0x21308FC Offset: 0x212C8FC VA: 0x21308FC
	private void set_Price(int value) { }

	[CompilerGenerated]
	// RVA: 0x2130904 Offset: 0x212C904 VA: 0x2130904 Slot: 8
	public byte get_MaterialLv() { }

	[CompilerGenerated]
	// RVA: 0x213090C Offset: 0x212C90C VA: 0x213090C
	private void set_MaterialLv(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2130914 Offset: 0x212C914 VA: 0x2130914 Slot: 9
	public byte get_MaterialId() { }

	[CompilerGenerated]
	// RVA: 0x213091C Offset: 0x212C91C VA: 0x213091C
	private void set_MaterialId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2130924 Offset: 0x212C924 VA: 0x2130924 Slot: 10
	public short get_Process() { }

	[CompilerGenerated]
	// RVA: 0x213092C Offset: 0x212C92C VA: 0x213092C
	private void set_Process(short value) { }

	[CompilerGenerated]
	// RVA: 0x2130934 Offset: 0x212C934 VA: 0x2130934 Slot: 11
	public short get_Stack() { }

	[CompilerGenerated]
	// RVA: 0x213093C Offset: 0x212C93C VA: 0x213093C
	private void set_Stack(short value) { }

	[CompilerGenerated]
	// RVA: 0x2130944 Offset: 0x212C944 VA: 0x2130944 Slot: 12
	public short get_Function() { }

	[CompilerGenerated]
	// RVA: 0x213094C Offset: 0x212C94C VA: 0x213094C
	private void set_Function(short value) { }

	[CompilerGenerated]
	// RVA: 0x2130954 Offset: 0x212C954 VA: 0x2130954 Slot: 13
	public byte get_Stable() { }

	[CompilerGenerated]
	// RVA: 0x213095C Offset: 0x212C95C VA: 0x213095C
	private void set_Stable(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2130964 Offset: 0x212C964 VA: 0x2130964 Slot: 14
	public byte get_Range() { }

	[CompilerGenerated]
	// RVA: 0x213096C Offset: 0x212C96C VA: 0x213096C
	private void set_Range(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2130974 Offset: 0x212C974 VA: 0x2130974 Slot: 15
	public byte get_SlotMax() { }

	[CompilerGenerated]
	// RVA: 0x213097C Offset: 0x212C97C VA: 0x213097C
	private void set_SlotMax(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2130984 Offset: 0x212C984 VA: 0x2130984 Slot: 16
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x213098C Offset: 0x212C98C VA: 0x213098C
	private void set_Flag(int value) { }

	[CompilerGenerated]
	// RVA: 0x2130994 Offset: 0x212C994 VA: 0x2130994 Slot: 17
	public int get_Model() { }

	[CompilerGenerated]
	// RVA: 0x213099C Offset: 0x212C99C VA: 0x213099C
	private void set_Model(int value) { }

	[CompilerGenerated]
	// RVA: 0x21309A4 Offset: 0x212C9A4 VA: 0x21309A4 Slot: 18
	public short get_Potential() { }

	[CompilerGenerated]
	// RVA: 0x21309AC Offset: 0x212C9AC VA: 0x21309AC
	private void set_Potential(short value) { }

	// RVA: 0x212B758 Offset: 0x2127758 VA: 0x212B758
	public short get_CapId1() { }

	// RVA: 0x212B7F8 Offset: 0x21277F8 VA: 0x212B7F8
	public short get_CapId2() { }

	// RVA: 0x212B8A8 Offset: 0x21278A8 VA: 0x212B8A8
	public short get_CapId3() { }

	// RVA: 0x212B958 Offset: 0x2127958 VA: 0x212B958
	public short get_CapId4() { }

	// RVA: 0x212BA08 Offset: 0x2127A08 VA: 0x212BA08
	public short get_CapId5() { }

	// RVA: 0x212BAB8 Offset: 0x2127AB8 VA: 0x212BAB8
	public short get_CapId6() { }

	// RVA: 0x212BB68 Offset: 0x2127B68 VA: 0x212BB68
	public short get_CapId7() { }

	// RVA: 0x212BC18 Offset: 0x2127C18 VA: 0x212BC18
	public short get_CapId8() { }

	// RVA: 0x212BCC8 Offset: 0x2127CC8 VA: 0x212BCC8
	public short get_CapId9() { }

	// RVA: 0x212BD78 Offset: 0x2127D78 VA: 0x212BD78
	public short get_CapId10() { }

	// RVA: 0x212B7A8 Offset: 0x21277A8 VA: 0x212B7A8
	public short get_CapVal1() { }

	// RVA: 0x212B850 Offset: 0x2127850 VA: 0x212B850
	public short get_CapVal2() { }

	// RVA: 0x212B900 Offset: 0x2127900 VA: 0x212B900
	public short get_CapVal3() { }

	// RVA: 0x212B9B0 Offset: 0x21279B0 VA: 0x212B9B0
	public short get_CapVal4() { }

	// RVA: 0x212BA60 Offset: 0x2127A60 VA: 0x212BA60
	public short get_CapVal5() { }

	// RVA: 0x212BB10 Offset: 0x2127B10 VA: 0x212BB10
	public short get_CapVal6() { }

	// RVA: 0x212BBC0 Offset: 0x2127BC0 VA: 0x212BBC0
	public short get_CapVal7() { }

	// RVA: 0x212BC70 Offset: 0x2127C70 VA: 0x212BC70
	public short get_CapVal8() { }

	// RVA: 0x212BD20 Offset: 0x2127D20 VA: 0x212BD20
	public short get_CapVal9() { }

	// RVA: 0x212BDD0 Offset: 0x2127DD0 VA: 0x212BDD0
	public short get_CapVal10() { }

	// RVA: 0x212BE28 Offset: 0x2127E28 VA: 0x212BE28
	public ReadOnlyCollection<BonusParameter> get_BonusLines() { }

	// RVA: 0x21309B4 Offset: 0x212C9B4 VA: 0x21309B4 Slot: 19
	public short[] get_CapId() { }

	// RVA: 0x21309BC Offset: 0x212C9BC VA: 0x21309BC Slot: 20
	public short[] get_CapVal() { }

	// RVA: 0x21309C4 Offset: 0x212C9C4 VA: 0x21309C4
	public int get_AvatarCategory() { }

	// RVA: 0x21309D4 Offset: 0x212C9D4 VA: 0x21309D4
	public static ItemDBData CreateItemData(BinaryReader reader) { }

	// RVA: 0x2130C5C Offset: 0x212CC5C VA: 0x2130C5C
	public static void SetItemDataProperty(ItemDBData item, BinaryReader reader) { }

	// RVA: 0x2130E04 Offset: 0x212CE04 VA: 0x2130E04
	public static bool IsSubWeapon(int type) { }

	// RVA: 0x2130E2C Offset: 0x212CE2C VA: 0x2130E2C
	public static bool CheckArmorAbility(ItemData armorItem, ItemDBData.ArmorAbility type) { }

	// RVA: 0x2130E44 Offset: 0x212CE44 VA: 0x2130E44
	public static bool CheckEquipItem(ItemDBData.ItemType type) { }

	// RVA: 0x2130E54 Offset: 0x212CE54 VA: 0x2130E54
	public static bool CheckAvatarEquipItem(ItemDBData.ItemType type) { }

	// RVA: 0x2130E64 Offset: 0x212CE64 VA: 0x2130E64
	public static bool CheckWeaponItem(ItemDBData.ItemType type) { }

	// RVA: 0x2130E80 Offset: 0x212CE80 VA: 0x2130E80
	public static bool CheckCristaItem(ItemDBData.ItemType type) { }

	// RVA: 0x2130EA4 Offset: 0x212CEA4 VA: 0x2130EA4
	public static bool CheckPowerUpCristaItem(ItemDBData.ItemType type) { }

	// RVA: 0x2130EB4 Offset: 0x212CEB4 VA: 0x2130EB4
	public static bool CheckUseItem(ItemDBData.ItemType type) { }

	// RVA: 0x2130B88 Offset: 0x212CB88 VA: 0x2130B88
	public void .ctor() { }
}

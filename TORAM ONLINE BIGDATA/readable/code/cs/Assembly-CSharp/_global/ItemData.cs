// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ItemData // TypeDefIndex: 1996
{
	// Fields
	private const int EnableCapSpace = 9;
	private static byte[] AppearanceValue; // 0x0
	protected short[] capId; // 0x10
	protected short[] capVal; // 0x18
	protected List<BonusParameter> bonusLines; // 0x20
	protected ItemDBData dbData; // 0x28
	[CompilerGenerated]
	private int <Uuid>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <Type>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <IsEquip>k__BackingField; // 0x3C
	[CompilerGenerated]
	private short <Max>k__BackingField; // 0x3E
	[CompilerGenerated]
	private byte <UserFlag>k__BackingField; // 0x40
	[CompilerGenerated]
	private short <Function>k__BackingField; // 0x42
	protected byte slotMax; // 0x44
	[CompilerGenerated]
	private int <Slot1>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <Slot2>k__BackingField; // 0x4C
	[CompilerGenerated]
	private short <Potential>k__BackingField; // 0x50
	protected byte refine; // 0x52
	protected byte ability; // 0x53
	[CompilerGenerated]
	private int <Model>k__BackingField; // 0x54
	[CompilerGenerated]
	private byte <Color1>k__BackingField; // 0x58
	[CompilerGenerated]
	private byte <Color2>k__BackingField; // 0x59
	[CompilerGenerated]
	private byte <Color3>k__BackingField; // 0x5A
	[CompilerGenerated]
	private string <Creater>k__BackingField; // 0x60
	[CompilerGenerated]
	private long <UniqueId>k__BackingField; // 0x68
	[CompilerGenerated]
	private int <Rrproperty>k__BackingField; // 0x70
	[CompilerGenerated]
	private byte <Premium>k__BackingField; // 0x74
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x78
	[CompilerGenerated]
	private byte <ItemDataType>k__BackingField; // 0x7C
	[CompilerGenerated]
	private int <ItemBoxOpenCount>k__BackingField; // 0x80

	// Properties
	public int Uuid { get; set; }
	public int Id { get; set; }
	public int Type { get; set; }
	public bool IsEquip { get; set; }
	public short Max { get; set; }
	public byte UserFlag { get; set; }
	public short Function { get; set; }
	public byte SlotMax { get; }
	public byte ServerSlotMax { get; }
	public int Slot1 { get; set; }
	public int Slot2 { get; set; }
	public short CapId1 { get; set; }
	public short CapVal1 { get; set; }
	public short CapId2 { get; set; }
	public short CapVal2 { get; set; }
	public short CapId3 { get; set; }
	public short CapVal3 { get; set; }
	public short CapId4 { get; set; }
	public short CapVal4 { get; set; }
	public short CapId5 { get; set; }
	public short CapVal5 { get; set; }
	public short CapId6 { get; set; }
	public short CapVal6 { get; set; }
	public short CapId7 { get; set; }
	public short CapVal7 { get; set; }
	public short CapId8 { get; set; }
	public short CapVal8 { get; set; }
	public short CapId9 { get; set; }
	public short CapVal9 { get; set; }
	public short CapId10 { get; set; }
	public short CapVal10 { get; set; }
	public short Potential { get; set; }
	public byte Refine { get; set; }
	public int Model { get; set; }
	public byte Color1 { get; set; }
	public byte Color2 { get; set; }
	public byte Color3 { get; set; }
	public string Creater { get; set; }
	public long UniqueId { get; set; }
	public int Rrproperty { get; set; }
	public short RandamProperty { get; }
	public short OreBonus { get; }
	public byte Premium { get; set; }
	public ReadOnlyCollection<BonusParameter> BonusLines { get; }
	public ItemDBData ItemMasterData { get; }
	public int Count { get; set; }
	public bool IsLock { get; }
	public bool IsFavorite { get; }
	public bool IsIndefeasible { get; }
	public bool IsTradable { get; }
	public short[] CapId { get; }
	public short[] CapVal { get; }
	public byte ItemDataType { get; set; }
	public int ItemBoxOpenCount { get; set; }
	public byte Customize { get; }
	public byte BattleCustomize { get; }
	public byte AbilityValue { get; }
	public byte[] Colors { get; }
	public int[] Slots { get; }
	public bool IsWarpItem { get; }

	// Methods

	// RVA: 0x212ACB4 Offset: 0x2126CB4 VA: 0x212ACB4
	public static ItemData CreateItemData(ItemDBData itemData, byte refine, Pair<short, short>[] caps) { }

	// RVA: 0x212AD24 Offset: 0x2126D24 VA: 0x212AD24
	public static ItemData CreateItemData(ItemDBData itemData, byte refine, short weaponAtk, Pair<short, short>[] caps) { }

	// RVA: 0x212ADAC Offset: 0x2126DAC VA: 0x212ADAC
	public static ItemData CreateItemData(ItemDBData itemData, Pair<short, short>[] caps) { }

	// RVA: 0x212B144 Offset: 0x2127144 VA: 0x212B144
	public static ItemData CreateItemData(ItemDatav2 itemData) { }

	// RVA: 0x212BE78 Offset: 0x2127E78 VA: 0x212BE78
	public static ItemData CreateItemData(SyntheticEquipItem itemData) { }

	// RVA: 0x212C5D0 Offset: 0x21285D0 VA: 0x212C5D0
	public static ItemData CreateItemData(WarrantyItemDatav2 itemData, short uuid) { }

	// RVA: 0x212CAFC Offset: 0x2128AFC VA: 0x212CAFC
	public static ItemData CreateItemData(OrbEquipItemData itemData, short location) { }

	// RVA: 0x212CE30 Offset: 0x2128E30 VA: 0x212CE30
	public static ItemData CreateItemData(IItemv2 itemData, int uuid, short locationId) { }

	// RVA: 0x212DFF8 Offset: 0x2129FF8 VA: 0x212DFF8
	public static ItemData CreateItemData(StorageItemDatav3 itemData, int uuid, int locationId) { }

	// RVA: 0x212E568 Offset: 0x212A568 VA: 0x212E568
	public static ItemData CreateItemData(MarketItemDatav2 itemData) { }

	// RVA: 0x212EB14 Offset: 0x212AB14 VA: 0x212EB14
	public static ItemData CreateItemData(BazaarItemData itemData) { }

	// RVA: 0x212F0CC Offset: 0x212B0CC VA: 0x212F0CC
	public static ItemData CreateItemData(GuildStaffEquipData itemData) { }

	// RVA: 0x212F274 Offset: 0x212B274 VA: 0x212F274
	public static ItemData CreateItemData(int itemId) { }

	// RVA: 0x212F6E8 Offset: 0x212B6E8 VA: 0x212F6E8
	public static int GetItemColor(int color1, int color2, int color3) { }

	// RVA: 0x212F6F8 Offset: 0x212B6F8 VA: 0x212F6F8
	public static bool CheckHaveProperty(ItemData item, BonusType[] type) { }

	[CompilerGenerated]
	// RVA: 0x212FD80 Offset: 0x212BD80 VA: 0x212FD80
	public int get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x212FD88 Offset: 0x212BD88 VA: 0x212FD88
	protected void set_Uuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x212FD90 Offset: 0x212BD90 VA: 0x212FD90
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x212FD98 Offset: 0x212BD98 VA: 0x212FD98
	protected void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x212FDA0 Offset: 0x212BDA0 VA: 0x212FDA0
	public int get_Type() { }

	[CompilerGenerated]
	// RVA: 0x212FDA8 Offset: 0x212BDA8 VA: 0x212FDA8
	protected void set_Type(int value) { }

	[CompilerGenerated]
	// RVA: 0x212FDB0 Offset: 0x212BDB0 VA: 0x212FDB0
	public bool get_IsEquip() { }

	[CompilerGenerated]
	// RVA: 0x212FDB8 Offset: 0x212BDB8 VA: 0x212FDB8
	protected void set_IsEquip(bool value) { }

	[CompilerGenerated]
	// RVA: 0x212FDC4 Offset: 0x212BDC4 VA: 0x212FDC4
	public short get_Max() { }

	[CompilerGenerated]
	// RVA: 0x212FDCC Offset: 0x212BDCC VA: 0x212FDCC
	protected void set_Max(short value) { }

	[CompilerGenerated]
	// RVA: 0x212FDD4 Offset: 0x212BDD4 VA: 0x212FDD4
	public byte get_UserFlag() { }

	[CompilerGenerated]
	// RVA: 0x212FDDC Offset: 0x212BDDC VA: 0x212FDDC
	protected void set_UserFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x212FDE4 Offset: 0x212BDE4 VA: 0x212FDE4
	public short get_Function() { }

	[CompilerGenerated]
	// RVA: 0x212FDEC Offset: 0x212BDEC VA: 0x212FDEC
	protected void set_Function(short value) { }

	// RVA: 0x212FDF4 Offset: 0x212BDF4 VA: 0x212FDF4
	public byte get_SlotMax() { }

	// RVA: 0x212FE14 Offset: 0x212BE14 VA: 0x212FE14
	public byte get_ServerSlotMax() { }

	[CompilerGenerated]
	// RVA: 0x212FE1C Offset: 0x212BE1C VA: 0x212FE1C
	public int get_Slot1() { }

	[CompilerGenerated]
	// RVA: 0x212FE24 Offset: 0x212BE24 VA: 0x212FE24
	protected void set_Slot1(int value) { }

	[CompilerGenerated]
	// RVA: 0x212FE2C Offset: 0x212BE2C VA: 0x212FE2C
	public int get_Slot2() { }

	[CompilerGenerated]
	// RVA: 0x212FE34 Offset: 0x212BE34 VA: 0x212FE34
	protected void set_Slot2(int value) { }

	// RVA: 0x212FBCC Offset: 0x212BBCC VA: 0x212FBCC
	public short get_CapId1() { }

	// RVA: 0x212B780 Offset: 0x2127780 VA: 0x212B780
	private void set_CapId1(short value) { }

	// RVA: 0x212FE3C Offset: 0x212BE3C VA: 0x212FE3C
	public short get_CapVal1() { }

	// RVA: 0x212B7D0 Offset: 0x21277D0 VA: 0x212B7D0
	private void set_CapVal1(short value) { }

	// RVA: 0x212FBF4 Offset: 0x212BBF4 VA: 0x212FBF4
	public short get_CapId2() { }

	// RVA: 0x212B824 Offset: 0x2127824 VA: 0x212B824
	private void set_CapId2(short value) { }

	// RVA: 0x212FE64 Offset: 0x212BE64 VA: 0x212FE64
	public short get_CapVal2() { }

	// RVA: 0x212B87C Offset: 0x212787C VA: 0x212B87C
	private void set_CapVal2(short value) { }

	// RVA: 0x212FC20 Offset: 0x212BC20 VA: 0x212FC20
	public short get_CapId3() { }

	// RVA: 0x212B8D4 Offset: 0x21278D4 VA: 0x212B8D4
	private void set_CapId3(short value) { }

	// RVA: 0x212FE90 Offset: 0x212BE90 VA: 0x212FE90
	public short get_CapVal3() { }

	// RVA: 0x212B92C Offset: 0x212792C VA: 0x212B92C
	private void set_CapVal3(short value) { }

	// RVA: 0x212FC4C Offset: 0x212BC4C VA: 0x212FC4C
	public short get_CapId4() { }

	// RVA: 0x212B984 Offset: 0x2127984 VA: 0x212B984
	private void set_CapId4(short value) { }

	// RVA: 0x212FEBC Offset: 0x212BEBC VA: 0x212FEBC
	public short get_CapVal4() { }

	// RVA: 0x212B9DC Offset: 0x21279DC VA: 0x212B9DC
	private void set_CapVal4(short value) { }

	// RVA: 0x212FC78 Offset: 0x212BC78 VA: 0x212FC78
	public short get_CapId5() { }

	// RVA: 0x212BA34 Offset: 0x2127A34 VA: 0x212BA34
	private void set_CapId5(short value) { }

	// RVA: 0x212FEE8 Offset: 0x212BEE8 VA: 0x212FEE8
	public short get_CapVal5() { }

	// RVA: 0x212BA8C Offset: 0x2127A8C VA: 0x212BA8C
	private void set_CapVal5(short value) { }

	// RVA: 0x212FCA4 Offset: 0x212BCA4 VA: 0x212FCA4
	public short get_CapId6() { }

	// RVA: 0x212BAE4 Offset: 0x2127AE4 VA: 0x212BAE4
	private void set_CapId6(short value) { }

	// RVA: 0x212FF14 Offset: 0x212BF14 VA: 0x212FF14
	public short get_CapVal6() { }

	// RVA: 0x212BB3C Offset: 0x2127B3C VA: 0x212BB3C
	private void set_CapVal6(short value) { }

	// RVA: 0x212FCD0 Offset: 0x212BCD0 VA: 0x212FCD0
	public short get_CapId7() { }

	// RVA: 0x212BB94 Offset: 0x2127B94 VA: 0x212BB94
	private void set_CapId7(short value) { }

	// RVA: 0x212FF40 Offset: 0x212BF40 VA: 0x212FF40
	public short get_CapVal7() { }

	// RVA: 0x212BBEC Offset: 0x2127BEC VA: 0x212BBEC
	private void set_CapVal7(short value) { }

	// RVA: 0x212FCFC Offset: 0x212BCFC VA: 0x212FCFC
	public short get_CapId8() { }

	// RVA: 0x212BC44 Offset: 0x2127C44 VA: 0x212BC44
	private void set_CapId8(short value) { }

	// RVA: 0x212FF6C Offset: 0x212BF6C VA: 0x212FF6C
	public short get_CapVal8() { }

	// RVA: 0x212BC9C Offset: 0x2127C9C VA: 0x212BC9C
	private void set_CapVal8(short value) { }

	// RVA: 0x212FD28 Offset: 0x212BD28 VA: 0x212FD28
	public short get_CapId9() { }

	// RVA: 0x212BCF4 Offset: 0x2127CF4 VA: 0x212BCF4
	private void set_CapId9(short value) { }

	// RVA: 0x212FF98 Offset: 0x212BF98 VA: 0x212FF98
	public short get_CapVal9() { }

	// RVA: 0x212BD4C Offset: 0x2127D4C VA: 0x212BD4C
	private void set_CapVal9(short value) { }

	// RVA: 0x212FD54 Offset: 0x212BD54 VA: 0x212FD54
	public short get_CapId10() { }

	// RVA: 0x212BDA4 Offset: 0x2127DA4 VA: 0x212BDA4
	private void set_CapId10(short value) { }

	// RVA: 0x212FFC4 Offset: 0x212BFC4 VA: 0x212FFC4
	public short get_CapVal10() { }

	// RVA: 0x212BDFC Offset: 0x2127DFC VA: 0x212BDFC
	private void set_CapVal10(short value) { }

	[CompilerGenerated]
	// RVA: 0x212FFF0 Offset: 0x212BFF0 VA: 0x212FFF0
	public short get_Potential() { }

	[CompilerGenerated]
	// RVA: 0x212FFF8 Offset: 0x212BFF8 VA: 0x212FFF8
	protected void set_Potential(short value) { }

	// RVA: 0x2130000 Offset: 0x212C000 VA: 0x2130000
	public byte get_Refine() { }

	// RVA: 0x213001C Offset: 0x212C01C VA: 0x213001C
	private void set_Refine(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2130024 Offset: 0x212C024 VA: 0x2130024
	public int get_Model() { }

	[CompilerGenerated]
	// RVA: 0x213002C Offset: 0x212C02C VA: 0x213002C
	protected void set_Model(int value) { }

	[CompilerGenerated]
	// RVA: 0x2130034 Offset: 0x212C034 VA: 0x2130034
	public byte get_Color1() { }

	[CompilerGenerated]
	// RVA: 0x213003C Offset: 0x212C03C VA: 0x213003C
	protected void set_Color1(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2130044 Offset: 0x212C044 VA: 0x2130044
	public byte get_Color2() { }

	[CompilerGenerated]
	// RVA: 0x213004C Offset: 0x212C04C VA: 0x213004C
	protected void set_Color2(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2130054 Offset: 0x212C054 VA: 0x2130054
	public byte get_Color3() { }

	[CompilerGenerated]
	// RVA: 0x213005C Offset: 0x212C05C VA: 0x213005C
	protected void set_Color3(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2130064 Offset: 0x212C064 VA: 0x2130064
	public string get_Creater() { }

	[CompilerGenerated]
	// RVA: 0x213006C Offset: 0x212C06C VA: 0x213006C
	protected void set_Creater(string value) { }

	[CompilerGenerated]
	// RVA: 0x2130074 Offset: 0x212C074 VA: 0x2130074
	public long get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x213007C Offset: 0x212C07C VA: 0x213007C
	protected void set_UniqueId(long value) { }

	[CompilerGenerated]
	// RVA: 0x2130084 Offset: 0x212C084 VA: 0x2130084
	public int get_Rrproperty() { }

	[CompilerGenerated]
	// RVA: 0x213008C Offset: 0x212C08C VA: 0x213008C
	protected void set_Rrproperty(int value) { }

	// RVA: 0x2130094 Offset: 0x212C094 VA: 0x2130094
	public short get_RandamProperty() { }

	// RVA: 0x213009C Offset: 0x212C09C VA: 0x213009C
	public short get_OreBonus() { }

	[CompilerGenerated]
	// RVA: 0x21300A4 Offset: 0x212C0A4 VA: 0x21300A4
	public byte get_Premium() { }

	[CompilerGenerated]
	// RVA: 0x21300AC Offset: 0x212C0AC VA: 0x21300AC
	protected void set_Premium(byte value) { }

	// RVA: 0x21300B4 Offset: 0x212C0B4 VA: 0x21300B4
	public ReadOnlyCollection<BonusParameter> get_BonusLines() { }

	// RVA: 0x2130104 Offset: 0x212C104 VA: 0x2130104
	public ItemDBData get_ItemMasterData() { }

	[CompilerGenerated]
	// RVA: 0x213010C Offset: 0x212C10C VA: 0x213010C
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x2130114 Offset: 0x212C114 VA: 0x2130114
	protected void set_Count(int value) { }

	// RVA: 0x213011C Offset: 0x212C11C VA: 0x213011C
	public bool get_IsLock() { }

	// RVA: 0x2130128 Offset: 0x212C128 VA: 0x2130128
	public bool get_IsFavorite() { }

	// RVA: 0x2130134 Offset: 0x212C134 VA: 0x2130134
	public bool get_IsIndefeasible() { }

	// RVA: 0x2130154 Offset: 0x212C154 VA: 0x2130154
	public bool get_IsTradable() { }

	// RVA: 0x2130198 Offset: 0x212C198 VA: 0x2130198
	public void SetLocation(short location) { }

	// RVA: 0x213019C Offset: 0x212C19C VA: 0x213019C
	public void ResetItemCount() { }

	// RVA: 0x21301A8 Offset: 0x212C1A8 VA: 0x21301A8
	public void SetLocalItemCount(int num) { }

	// RVA: 0x21301B0 Offset: 0x212C1B0 VA: 0x21301B0
	public void LocalUseItem(int num) { }

	// RVA: 0x21301C0 Offset: 0x212C1C0 VA: 0x21301C0
	public string RefineToString() { }

	// RVA: 0x2130580 Offset: 0x212C580 VA: 0x2130580
	public void SetItemLock(bool lockFlag) { }

	// RVA: 0x213059C Offset: 0x212C59C VA: 0x213059C
	public void SetItemFavorite(bool isFavorite) { }

	// RVA: 0x21305B8 Offset: 0x212C5B8 VA: 0x21305B8
	public void SetUserFlag(byte setFlag) { }

	// RVA: 0x21305C0 Offset: 0x212C5C0 VA: 0x21305C0
	public int GetInnerModelId() { }

	// RVA: 0x21305E0 Offset: 0x212C5E0 VA: 0x21305E0
	public int GetColor() { }

	// RVA: 0x21305FC Offset: 0x212C5FC VA: 0x21305FC
	public short[] get_CapId() { }

	// RVA: 0x2130604 Offset: 0x212C604 VA: 0x2130604
	public short[] get_CapVal() { }

	[CompilerGenerated]
	// RVA: 0x213060C Offset: 0x212C60C VA: 0x213060C
	public byte get_ItemDataType() { }

	[CompilerGenerated]
	// RVA: 0x2130614 Offset: 0x212C614 VA: 0x2130614
	protected void set_ItemDataType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x213061C Offset: 0x212C61C VA: 0x213061C
	public int get_ItemBoxOpenCount() { }

	[CompilerGenerated]
	// RVA: 0x2130624 Offset: 0x212C624 VA: 0x2130624
	protected void set_ItemBoxOpenCount(int value) { }

	// RVA: 0x213062C Offset: 0x212C62C VA: 0x213062C
	public void SetItemBoxOpenCount(int count) { }

	// RVA: 0x2130634 Offset: 0x212C634 VA: 0x2130634
	private byte GetCustomize() { }

	// RVA: 0x21306C8 Offset: 0x212C6C8 VA: 0x21306C8
	public byte get_Customize() { }

	// RVA: 0x21306CC Offset: 0x212C6CC VA: 0x21306CC
	public byte get_BattleCustomize() { }

	// RVA: 0x21306D8 Offset: 0x212C6D8 VA: 0x21306D8
	public byte get_AbilityValue() { }

	// RVA: 0x21306E0 Offset: 0x212C6E0 VA: 0x21306E0
	public byte[] get_Colors() { }

	// RVA: 0x2130768 Offset: 0x212C768 VA: 0x2130768
	public int GetBrightLv() { }

	// RVA: 0x2130778 Offset: 0x212C778 VA: 0x2130778
	public int[] get_Slots() { }

	// RVA: 0x21307F0 Offset: 0x212C7F0 VA: 0x21307F0
	public bool get_IsWarpItem() { }

	// RVA: 0x212B068 Offset: 0x2127068 VA: 0x212B068
	public void .ctor() { }

	// RVA: 0x2130820 Offset: 0x212C820 VA: 0x2130820
	private static void .cctor() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class ItemManager // TypeDefIndex: 2029
{
	// Fields
	private ItemManager.ItemConnectFlag connectFlag; // 0x10
	public const int BagSize = 20;
	private List<ItemData> itemList; // 0x18
	private EquipData equipData; // 0x20
	public List<RewardData> randamItemBoxReward; // 0x28
	private List<ItemDatav2> reinforceCristaResponseList; // 0x30
	private List<WarrantyItemDatav2> warrantyItemList; // 0x38
	private SortCategory smithItemCategory; // 0x40
	[CompilerGenerated]
	private short[] <InventoryCapacity>k__BackingField; // 0x48
	[CompilerGenerated]
	private InventoryPackData <InventoryPackData>k__BackingField; // 0x50
	public const int MaxInventoryCapacity = 100;
	public const int MaxCollectInventoryCapacity = 300;
	[CompilerGenerated]
	private int <ItemBoxOpenCount>k__BackingField; // 0x58
	private List<ItemData> favoriteExtendedItemList; // 0x60

	// Properties
	public int BagCapacity { get; }
	public IList<ItemData> BagItemList { get; }
	public int BagItemCount { get; }
	public int BagRestCount { get; }
	public int BagCount { get; }
	public EquipData EquipData { get; }
	public RewardData[] RandamItemBoxReward { get; }
	public ItemDatav2[] ReinforceCristaResponseList { get; }
	public List<ItemData> WarrantyItemList { get; }
	public int WarrantyItemNum { get; }
	public bool IsWarrantyItem { get; }
	public SortCategory SmithItemCategory { get; }
	public short[] InventoryCapacity { get; set; }
	public InventoryPackData InventoryPackData { get; set; }
	public bool IsCollectsBagFull { get; }
	public bool IsConsumesBagFull { get; }
	public bool IsEquipsBagFull { get; }
	public bool IsAllBagFull { get; }
	public bool IsAnyBagFull { get; }
	public bool IsAddSlot { get; }
	public int ItemBoxOpenCount { get; set; }

	// Methods

	// RVA: 0x2130EE4 Offset: 0x212CEE4 VA: 0x2130EE4
	public int get_BagCapacity() { }

	// RVA: 0x2130F30 Offset: 0x212CF30 VA: 0x2130F30
	public IList<ItemData> get_BagItemList() { }

	// RVA: 0x2130F80 Offset: 0x212CF80 VA: 0x2130F80
	public int get_BagItemCount() { }

	// RVA: 0x2130FC8 Offset: 0x212CFC8 VA: 0x2130FC8
	public int get_BagRestCount() { }

	// RVA: 0x213101C Offset: 0x212D01C VA: 0x213101C
	public int get_BagCount() { }

	// RVA: 0x2131098 Offset: 0x212D098 VA: 0x2131098
	public EquipData get_EquipData() { }

	// RVA: 0x21310A0 Offset: 0x212D0A0 VA: 0x21310A0
	public bool IsViewAvatar(BodyCustomType type) { }

	// RVA: 0x21310C0 Offset: 0x212D0C0 VA: 0x21310C0
	public RewardData[] get_RandamItemBoxReward() { }

	// RVA: 0x2131110 Offset: 0x212D110 VA: 0x2131110
	public ItemDatav2[] get_ReinforceCristaResponseList() { }

	// RVA: 0x2131160 Offset: 0x212D160 VA: 0x2131160
	public List<ItemData> get_WarrantyItemList() { }

	// RVA: 0x213149C Offset: 0x212D49C VA: 0x213149C
	public int get_WarrantyItemNum() { }

	// RVA: 0x2131598 Offset: 0x212D598 VA: 0x2131598
	public bool get_IsWarrantyItem() { }

	// RVA: 0x21315B0 Offset: 0x212D5B0 VA: 0x21315B0
	public SortCategory get_SmithItemCategory() { }

	[CompilerGenerated]
	// RVA: 0x21315B8 Offset: 0x212D5B8 VA: 0x21315B8
	public short[] get_InventoryCapacity() { }

	[CompilerGenerated]
	// RVA: 0x21315C0 Offset: 0x212D5C0 VA: 0x21315C0
	private void set_InventoryCapacity(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x21315C8 Offset: 0x212D5C8 VA: 0x21315C8
	public InventoryPackData get_InventoryPackData() { }

	[CompilerGenerated]
	// RVA: 0x21315D0 Offset: 0x212D5D0 VA: 0x21315D0
	private void set_InventoryPackData(InventoryPackData value) { }

	// RVA: 0x21315D8 Offset: 0x212D5D8 VA: 0x21315D8
	public bool get_IsCollectsBagFull() { }

	// RVA: 0x2131620 Offset: 0x212D620 VA: 0x2131620
	public bool get_IsConsumesBagFull() { }

	// RVA: 0x213166C Offset: 0x212D66C VA: 0x213166C
	public bool get_IsEquipsBagFull() { }

	// RVA: 0x21316B8 Offset: 0x212D6B8 VA: 0x21316B8
	public bool get_IsAllBagFull() { }

	// RVA: 0x21316EC Offset: 0x212D6EC VA: 0x21316EC
	public bool get_IsAnyBagFull() { }

	// RVA: 0x2131720 Offset: 0x212D720 VA: 0x2131720
	public bool get_IsAddSlot() { }

	[CompilerGenerated]
	// RVA: 0x2131784 Offset: 0x212D784 VA: 0x2131784
	public int get_ItemBoxOpenCount() { }

	[CompilerGenerated]
	// RVA: 0x213178C Offset: 0x212D78C VA: 0x213178C
	private void set_ItemBoxOpenCount(int value) { }

	// RVA: 0x2131794 Offset: 0x212D794 VA: 0x2131794
	public void InitializeBagItems(short[] inventoryCapacity, InventoryPackData inventoryPackData, AvatarEquipData equipData, WarrantyItemPackData warrantyItemPackData) { }

	// RVA: 0x2131E9C Offset: 0x212DE9C VA: 0x2131E9C
	public void UpdateBagCapacity(short[] inventoryCapacity) { }

	// RVA: 0x2131EBC Offset: 0x212DEBC VA: 0x2131EBC
	public List<ItemData> GetItemTypeList(ItemDBData.ItemType[] type) { }

	// RVA: 0x2132004 Offset: 0x212E004 VA: 0x2132004
	public List<ItemData> GetItemList(Func<ItemData, bool> check) { }

	// RVA: 0x2132110 Offset: 0x212E110 VA: 0x2132110
	public List<int> GetItemIdTypeList(ItemDBData.ItemType[] type) { }

	// RVA: 0x2132334 Offset: 0x212E334 VA: 0x2132334
	public List<ItemData> GetItemFlagList(ItemDBData.ItemFlag flag) { }

	// RVA: 0x213242C Offset: 0x212E42C VA: 0x213242C
	public List<ItemData> GetItemMaterialTypeList(byte type) { }

	// RVA: 0x2132770 Offset: 0x212E770 VA: 0x2132770
	public ItemData GetItemDataFromUuid(int uuid) { }

	// RVA: 0x213284C Offset: 0x212E84C VA: 0x213284C
	public ItemData GetItemDataFromId(int id) { }

	// RVA: 0x212A9F4 Offset: 0x21269F4 VA: 0x212A9F4
	public ItemData GetItemMinStackDataFromId(int id) { }

	// RVA: 0x212AB14 Offset: 0x2126B14 VA: 0x212AB14
	public int GetItemCount(int id) { }

	// RVA: 0x2132928 Offset: 0x212E928 VA: 0x2132928
	public int GetItemSlotCount(int id) { }

	// RVA: 0x2132A04 Offset: 0x212EA04 VA: 0x2132A04
	public bool CheckItemType(int uuid, ItemDBData.ItemType itemType) { }

	// RVA: 0x2132A28 Offset: 0x212EA28 VA: 0x2132A28
	public bool CheckWarrantyItemId(int[] itemId) { }

	// RVA: 0x2132B90 Offset: 0x212EB90 VA: 0x2132B90
	public ItemData GetWarrantyItemDataFromUuid(int uuid) { }

	// RVA: 0x2132CB0 Offset: 0x212ECB0 VA: 0x2132CB0
	public WarrantyItemDatav2 CheckConnectWarrantyItemData(int uuid, ItemManager.ItemConnectFlag flag) { }

	// RVA: 0x2132DF0 Offset: 0x212EDF0 VA: 0x2132DF0
	public bool ExpendItem(int uuid, int num) { }

	// RVA: 0x2132E2C Offset: 0x212EE2C VA: 0x2132E2C
	public bool DiscardItem(int uuid) { }

	// RVA: 0x2132EFC Offset: 0x212EEFC VA: 0x2132EFC
	public bool LockItem(int uuid, bool lockFlag, out byte userFlag) { }

	// RVA: 0x2132F80 Offset: 0x212EF80 VA: 0x2132F80
	public bool FavoriteItem(int uuid, bool isFavorite, out byte userFlag) { }

	// RVA: 0x2133004 Offset: 0x212F004 VA: 0x2133004
	public bool ItemBagLoad() { }

	// RVA: 0x2132E94 Offset: 0x212EE94 VA: 0x2132E94
	public bool CheckEquipItem(int uuid) { }

	// RVA: 0x2133020 Offset: 0x212F020 VA: 0x2133020
	public ItemDBData.EquipType GetItemEquipedType(int uuid) { }

	// RVA: 0x21330AC Offset: 0x212F0AC VA: 0x21330AC
	public bool CheckAvatarEquipItem(int uuid) { }

	// RVA: 0x21330FC Offset: 0x212F0FC VA: 0x21330FC
	public bool CheckDiscardableItem(int uuid) { }

	// RVA: 0x2133180 Offset: 0x212F180 VA: 0x2133180
	public ItemData GetEquipData(ItemDBData.EquipType type) { }

	// RVA: 0x21332F0 Offset: 0x212F2F0 VA: 0x21332F0
	public bool SetEquip(ItemDBData.EquipType type, int uuid, SkillId[] equipSkillId) { }

	// RVA: 0x213393C Offset: 0x212F93C VA: 0x213393C
	public void EquipAllPurge() { }

	// RVA: 0x2133964 Offset: 0x212F964 VA: 0x2133964
	public void ResetItem(int uuid) { }

	// RVA: 0x21339C4 Offset: 0x212F9C4 VA: 0x21339C4
	public void AllResetItem() { }

	// RVA: 0x2133B0C Offset: 0x212FB0C VA: 0x2133B0C Slot: 4
	protected virtual ItemData CreateItem(ItemDatav2 itemDatav) { }

	// RVA: 0x2133B60 Offset: 0x212FB60 VA: 0x2133B60
	public void UpdateItem(ItemDatav2 itemData, bool isNewItem) { }

	// RVA: 0x2133E60 Offset: 0x212FE60 VA: 0x2133E60
	protected void RemoveItem(ItemData item) { }

	// RVA: 0x2134B48 Offset: 0x2130B48 VA: 0x2134B48
	public void UpdateItem(InventoryPackData inventoryPackData) { }

	// RVA: 0x2134D30 Offset: 0x2130D30 VA: 0x2134D30
	public void UpdateWarrantItem(WarrantyItemDatav2 itemData) { }

	// RVA: 0x2134F70 Offset: 0x2130F70 VA: 0x2134F70
	public void DiscardWarrantyItem(byte index) { }

	// RVA: 0x213508C Offset: 0x213108C VA: 0x213508C
	public bool CheckAddItem(int itemid, int count) { }

	// RVA: 0x213526C Offset: 0x213126C VA: 0x213526C
	public List<BonusParameter> GetBonusLines(int itemUuid) { }

	// RVA: 0x2135304 Offset: 0x2131304 VA: 0x2135304
	public int GetFreeBag(byte itemDataType) { }

	// RVA: 0x2135398 Offset: 0x2131398 VA: 0x2135398
	public int GetBagItemNum(byte itemDataType) { }

	// RVA: 0x21353E4 Offset: 0x21313E4 VA: 0x21353E4
	public Pair<short, short>[] GetProperties(int itemUuid) { }

	// RVA: 0x2135AA0 Offset: 0x2131AA0 VA: 0x2135AA0
	public int ItemLocationSwap(int uid, int location) { }

	// RVA: 0x2135B00 Offset: 0x2131B00 VA: 0x2135B00
	public int ItemLocationBagSwap(int uid, byte bagId) { }

	// RVA: 0x2135B60 Offset: 0x2131B60 VA: 0x2135B60
	public void ReceiveItemSort(Dictionary<int, short> itemLocationList) { }

	// RVA: 0x2136038 Offset: 0x2132038 VA: 0x2136038
	public bool ItemStoragePut(int uuid) { }

	// RVA: 0x2136080 Offset: 0x2132080 VA: 0x2136080
	public bool ItemBoxOpen(int uuid, int usedNum) { }

	// RVA: 0x213619C Offset: 0x213219C VA: 0x213619C
	public void ReceiveUseRandamItemBox(RewardData[] rewardData) { }

	// RVA: 0x2136348 Offset: 0x2132348 VA: 0x2136348
	public void ReceiveAttachReinforceCrista(ItemDatav2[] itemList) { }

	// RVA: 0x21363E8 Offset: 0x21323E8 VA: 0x21363E8
	public void ChangeSmithItemCategory(SortCategory category) { }

	// RVA: 0x21363F0 Offset: 0x21323F0 VA: 0x21363F0
	public ItemDBData.EquipType GetSelectItemEquipType(int itemType) { }

	// RVA: 0x2136414 Offset: 0x2132414 VA: 0x2136414
	public void ChangeEquipDataAvatarVisible(ItemType itemType, bool isVisible) { }

	// RVA: 0x2136468 Offset: 0x2132468 VA: 0x2136468
	public bool IsSameEquipData(EquipData data) { }

	// RVA: 0x2132DC0 Offset: 0x212EDC0 VA: 0x2132DC0
	public bool CheckConnectFlag(ItemManager.ItemConnectFlag flag) { }

	// RVA: 0x2132DD0 Offset: 0x212EDD0 VA: 0x2132DD0
	public bool SetConnectFlag(ItemManager.ItemConnectFlag flag) { }

	// RVA: 0x213653C Offset: 0x213253C VA: 0x213653C
	private short GetFreeLocation(short[] location, int startIndex, int endIndex) { }

	// RVA: 0x213398C Offset: 0x212F98C VA: 0x213398C
	public bool ClearConnectFlag(ItemManager.ItemConnectFlag flag) { }

	// RVA: 0x21365C4 Offset: 0x21325C4 VA: 0x21365C4
	public void SortTidyItemList() { }

	// RVA: 0x21367B4 Offset: 0x21327B4 VA: 0x21367B4
	public ItemDatav2 GetItemDatav2(byte itemDataType, int uuid) { }

	// RVA: 0x2136988 Offset: 0x2132988 VA: 0x2136988
	public EquipItemDatav2 GetEquipItemDatav2(int uuid) { }

	// RVA: 0x2136A80 Offset: 0x2132A80 VA: 0x2136A80
	public IList<ItemData> GetItemDataTypeList(byte itemDataType) { }

	// RVA: 0x2136B98 Offset: 0x2132B98 VA: 0x2136B98
	public bool CheckRestInventory(byte itemDataType) { }

	// RVA: 0x2134124 Offset: 0x2130124 VA: 0x2134124
	public void UpdateItemInventoryPackData(ItemDatav2 itemData) { }

	// RVA: 0x21347B8 Offset: 0x21307B8 VA: 0x21347B8
	public void SubItemInventoryPackData(ItemData item) { }

	// RVA: 0x2136BF0 Offset: 0x2132BF0 VA: 0x2136BF0
	public int GetInventoryFreeIndex(ItemDataTypev2 itemDataType) { }

	// RVA: 0x2136C8C Offset: 0x2132C8C VA: 0x2136C8C
	public bool BagSlotRelease() { }

	// RVA: 0x2136CA8 Offset: 0x2132CA8 VA: 0x2136CA8
	public void AddItemBoxOpenCount() { }

	// RVA: 0x2136CB8 Offset: 0x2132CB8 VA: 0x2136CB8
	public List<ItemData> GetFavoriteItemList(bool isFavorite) { }

	// RVA: 0x2133EDC Offset: 0x212FEDC VA: 0x2133EDC
	private void SendFavoriteInheritItem(ItemData data) { }

	// RVA: 0x2136DBC Offset: 0x2132DBC VA: 0x2136DBC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2136F6C Offset: 0x2132F6C VA: 0x2136F6C
	private bool <InitializeBagItems>b__61_0(ItemData x) { }
}

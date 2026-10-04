// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbEquipItemManager // TypeDefIndex: 2149
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x10
	private Dictionary<int, ItemData> orbEquipItemDataList; // 0x18
	private List<OrbEnchantData> oldEnchantDataList; // 0x20
	private List<OrbEnchantData> enchantDataList; // 0x28
	private Dictionary<byte, byte> enchantSlotLimits; // 0x30
	private Game engine; // 0x38
	private Dictionary<int, RewardData[]> orbEquipRecycleRewardDataList; // 0x40
	public const int MaxItem = 30000;
	private bool isNewAvatar; // 0x48

	// Properties
	public List<OrbEnchantData> EnchantDataList { get; }
	public List<OrbEnchantData> OldEnchantDataList { get; }
	public int ItemNum { get; }
	public bool IsNewAvatar { get; }

	// Methods

	// RVA: 0x214DC98 Offset: 0x2149C98 VA: 0x214DC98
	public List<OrbEnchantData> get_EnchantDataList() { }

	// RVA: 0x214DCA0 Offset: 0x2149CA0 VA: 0x214DCA0
	public List<OrbEnchantData> get_OldEnchantDataList() { }

	// RVA: 0x214DCA8 Offset: 0x2149CA8 VA: 0x214DCA8
	public int get_ItemNum() { }

	// RVA: 0x214DCF8 Offset: 0x2149CF8 VA: 0x214DCF8
	public bool get_IsNewAvatar() { }

	// RVA: 0x214DD00 Offset: 0x2149D00 VA: 0x214DD00
	public void Initialize(OrbClosetData orbClosetData) { }

	// RVA: 0x214E05C Offset: 0x214A05C VA: 0x214E05C
	public bool ContainsItem(int uuid) { }

	// RVA: 0x214E0B4 Offset: 0x214A0B4 VA: 0x214E0B4
	public ItemData GetItemDataFromUuid(int uuid) { }

	// RVA: 0x214E12C Offset: 0x214A12C VA: 0x214E12C
	public void UpdateOrbEquipItem(OrbEquipItemData[] itemList) { }

	// RVA: 0x214E2A0 Offset: 0x214A2A0 VA: 0x214E2A0
	public bool EquipOrbItem(int uuid) { }

	// RVA: 0x214E504 Offset: 0x214A504 VA: 0x214E504
	public void RemoveOrbItem(int uuid) { }

	// RVA: 0x214E55C Offset: 0x214A55C VA: 0x214E55C
	public List<ItemData> GetItemTypeList(ItemDBData.ItemType[] type) { }

	// RVA: 0x214E6CC Offset: 0x214A6CC VA: 0x214E6CC
	public void ReceiveRecycleItem(int uuid, RewardData[] rewardData) { }

	// RVA: 0x214E768 Offset: 0x214A768 VA: 0x214E768
	public RewardData[] GetRecycleRewardItem(int uuid) { }

	// RVA: 0x214E82C Offset: 0x214A82C VA: 0x214E82C
	public void EnterOrbShop() { }

	// RVA: 0x214E834 Offset: 0x214A834 VA: 0x214E834
	public void EnterEquipPanel() { }

	// RVA: 0x214E83C Offset: 0x214A83C VA: 0x214E83C
	public void NewAvatarDataResult() { }

	// RVA: 0x214E848 Offset: 0x214A848 VA: 0x214E848
	public void SetEngine(Game engine) { }

	// RVA: 0x214E850 Offset: 0x214A850 VA: 0x214E850
	public bool ReEnchantment(int targetItemId, EquipType targetEquipType, byte enchantIndex) { }

	// RVA: 0x214E994 Offset: 0x214A994 VA: 0x214E994
	public bool EnchantGetList() { }

	// RVA: 0x214EA70 Offset: 0x214AA70 VA: 0x214EA70
	public bool ItemUseEnchant(int orbItemId, int avatarUuid, EquipType type, byte index) { }

	// RVA: 0x214EBB0 Offset: 0x214ABB0 VA: 0x214EBB0
	public void EnchantSave(int targetItemUuid, byte targetType, byte index) { }

	// RVA: 0x214ECB0 Offset: 0x214ACB0 VA: 0x214ECB0
	private void UpdateEnchantList(OrbEnchantGetListResponse response) { }

	// RVA: 0x214EDD8 Offset: 0x214ADD8 VA: 0x214EDD8
	private void DeleteEnchantData(bool isOld, byte targetType, byte index) { }

	// RVA: 0x214EF18 Offset: 0x214AF18 VA: 0x214EF18
	private void UpdateEnchantData(OrbEnchantData data) { }

	// RVA: 0x214F0B8 Offset: 0x214B0B8 VA: 0x214F0B8
	public byte GetEnchantSlotLimit(byte equipType) { }

	// RVA: 0x214F14C Offset: 0x214B14C VA: 0x214F14C
	public bool HasOldEnchantData(byte targetType) { }

	// RVA: 0x214F234 Offset: 0x214B234 VA: 0x214F234
	public void .ctor() { }
}

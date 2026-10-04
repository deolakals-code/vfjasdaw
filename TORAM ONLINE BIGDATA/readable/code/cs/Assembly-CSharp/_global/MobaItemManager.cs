// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaItemManager : ItemManager // TypeDefIndex: 2050
{
	// Fields
	[CompilerGenerated]
	private int[] <ShopItemIds>k__BackingField; // 0x68
	[CompilerGenerated]
	private int <ShopPrice>k__BackingField; // 0x70
	[CompilerGenerated]
	private List<int> <Abilities>k__BackingField; // 0x78
	private MobaPlayer mobaPlayer; // 0x80
	private int[] equipItemUid; // 0x88
	private int[] equipUpdate; // 0x90
	private int[] equipRefine; // 0x98

	// Properties
	public int[] ShopItemIds { get; set; }
	public int ShopPrice { get; set; }
	public List<int> Abilities { get; set; }
	public int MaxAbilityNum { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x213D71C Offset: 0x213971C VA: 0x213D71C
	public int[] get_ShopItemIds() { }

	[CompilerGenerated]
	// RVA: 0x213D724 Offset: 0x2139724 VA: 0x213D724
	private void set_ShopItemIds(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x213D72C Offset: 0x213972C VA: 0x213D72C
	public int get_ShopPrice() { }

	[CompilerGenerated]
	// RVA: 0x213D734 Offset: 0x2139734 VA: 0x213D734
	private void set_ShopPrice(int value) { }

	[CompilerGenerated]
	// RVA: 0x213D73C Offset: 0x213973C VA: 0x213D73C
	public List<int> get_Abilities() { }

	[CompilerGenerated]
	// RVA: 0x213D744 Offset: 0x2139744 VA: 0x213D744
	private void set_Abilities(List<int> value) { }

	// RVA: 0x213D74C Offset: 0x213974C VA: 0x213D74C
	public int get_MaxAbilityNum() { }

	// RVA: 0x213D754 Offset: 0x2139754 VA: 0x213D754
	public void .ctor(MobaPlayer mobaPlayer) { }

	// RVA: 0x213D860 Offset: 0x2139860 VA: 0x213D860
	public void Initialize(MobaEquipData equip, int[] abilities) { }

	// RVA: 0x213DD98 Offset: 0x2139D98 VA: 0x213DD98
	public MobaEquipItemData GetActiveShopItemData(EquipType equipType, ItemType selectItemType) { }

	// RVA: 0x213DEB0 Offset: 0x2139EB0 VA: 0x213DEB0
	public ItemData GetEquipTypeBagData(EquipType equipType, out bool isEquip) { }

	// RVA: 0x213DF4C Offset: 0x2139F4C VA: 0x213DF4C Slot: 4
	protected override ItemData CreateItem(ItemDatav2 itemDatav) { }

	// RVA: 0x213DF90 Offset: 0x2139F90 VA: 0x213DF90
	private void UpdateEquipItem(int gold, byte equipType, ItemDatav2 updateEquip, bool isEquip) { }

	// RVA: 0x213E158 Offset: 0x213A158 VA: 0x213E158
	private void RemoveItem(int uuid) { }

	// RVA: 0x213E188 Offset: 0x213A188 VA: 0x213E188
	private void UpdateAbilities(bool isRemove, int ability, int gold) { }

	// RVA: 0x213DA98 Offset: 0x2139A98 VA: 0x213DA98
	private void UpdateAbilities() { }

	// RVA: 0x213E2BC Offset: 0x213A2BC VA: 0x213E2BC
	public void BuyEquip(byte equipType, byte itemType, int atk, int price, bool isUpdate) { }

	// RVA: 0x213E3E0 Offset: 0x213A3E0 VA: 0x213E3E0
	public void SellEquip(byte equipType, byte itemType, int price) { }

	// RVA: 0x213E4E0 Offset: 0x213A4E0 VA: 0x213E4E0
	public void RefineEquip(byte equipType, byte itemType, byte refine, int price) { }

	// RVA: 0x213E5F4 Offset: 0x213A5F4 VA: 0x213E5F4
	public void GetItemList() { }

	// RVA: 0x213E6D4 Offset: 0x213A6D4 VA: 0x213E6D4
	public void BuyItem(int shopItemId, int buyPrice) { }

	// RVA: 0x213E7C8 Offset: 0x213A7C8 VA: 0x213E7C8
	public void BuyAbility(int abilityId, int price) { }

	// RVA: 0x213E8BC Offset: 0x213A8BC VA: 0x213E8BC
	public void SellAbility(int abilityId, int price) { }
}

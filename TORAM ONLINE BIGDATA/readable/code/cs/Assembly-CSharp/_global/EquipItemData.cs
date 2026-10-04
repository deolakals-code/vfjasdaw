// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class EquipItemData // TypeDefIndex: 564
{
	// Fields
	private Dictionary<ItemDBData.EquipType, ItemData> equipItem; // 0x10
	private EquipItemData.WeaponTypeCalculatorBase mainWeaponCalculator; // 0x18
	private EquipItemData.WeaponTypeCalculatorBase subWeaponCalculator; // 0x20

	// Properties
	public EquipItemData.WeaponTypeCalculatorBase MainWeaponCalculator { get; }
	public EquipItemData.WeaponTypeCalculatorBase SubWeaponCalculator { get; }
	public ItemData Weapon { get; }
	public int WeaponItemType { get; }
	public ItemData SubWeapon { get; }
	public int SubWeaponItemType { get; }
	public ItemData Body { get; }
	public ItemData Option { get; }
	public ItemData Special { get; }
	public ItemData AvatarOption { get; }
	public ItemData AvatarTop { get; }
	public ItemData AvatarBottom { get; }
	public ItemData Decoration { get; }

	// Methods

	// RVA: 0x18F1E28 Offset: 0x18EDE28 VA: 0x18F1E28
	public EquipItemData.WeaponTypeCalculatorBase get_MainWeaponCalculator() { }

	// RVA: 0x18F1E30 Offset: 0x18EDE30 VA: 0x18F1E30
	public EquipItemData.WeaponTypeCalculatorBase get_SubWeaponCalculator() { }

	// RVA: 0x18F1E38 Offset: 0x18EDE38 VA: 0x18F1E38
	public void SetEquipItem(ItemDBData.EquipType type, ItemData item) { }

	// RVA: 0x18F2194 Offset: 0x18EE194 VA: 0x18F2194
	public ItemData GetEquip(ItemDBData.EquipType type) { }

	[Obsolete]
	// RVA: 0x18F2228 Offset: 0x18EE228 VA: 0x18F2228
	public bool CheckEquipItem(int uuid) { }

	// RVA: 0x18F1FA8 Offset: 0x18EDFA8 VA: 0x18F1FA8
	private EquipItemData.WeaponTypeCalculatorBase createWeaponCalculator(ItemData item) { }

	// RVA: 0x18F2644 Offset: 0x18EE644 VA: 0x18F2644
	public ItemData get_Weapon() { }

	// RVA: 0x18F26B0 Offset: 0x18EE6B0 VA: 0x18F26B0
	public int get_WeaponItemType() { }

	// RVA: 0x18F26DC Offset: 0x18EE6DC VA: 0x18F26DC
	public ItemData get_SubWeapon() { }

	// RVA: 0x18F2748 Offset: 0x18EE748 VA: 0x18F2748
	public int get_SubWeaponItemType() { }

	// RVA: 0x18F2774 Offset: 0x18EE774 VA: 0x18F2774
	public ItemData get_Body() { }

	// RVA: 0x18F27E0 Offset: 0x18EE7E0 VA: 0x18F27E0
	public ItemData get_Option() { }

	// RVA: 0x18F284C Offset: 0x18EE84C VA: 0x18F284C
	public ItemData get_Special() { }

	// RVA: 0x18F28B8 Offset: 0x18EE8B8 VA: 0x18F28B8
	public ItemData get_AvatarOption() { }

	// RVA: 0x18F2924 Offset: 0x18EE924 VA: 0x18F2924
	public ItemData get_AvatarTop() { }

	// RVA: 0x18F2990 Offset: 0x18EE990 VA: 0x18F2990
	public ItemData get_AvatarBottom() { }

	// RVA: 0x18F29FC Offset: 0x18EE9FC VA: 0x18F29FC
	public ItemData get_Decoration() { }

	// RVA: 0x18F2A68 Offset: 0x18EEA68 VA: 0x18F2A68
	public int CalcFlee(PlayerStatusBase status) { }

	// RVA: 0x18F3138 Offset: 0x18EF138 VA: 0x18F3138
	public int CalcDef(PlayerStatusBase status) { }

	// RVA: 0x18F3ADC Offset: 0x18EFADC VA: 0x18F3ADC
	public int CalcMdef(PlayerStatusBase status) { }

	// RVA: 0x18F4490 Offset: 0x18F0490 VA: 0x18F4490
	public int CalcEqDef(PlayerStatusBase status) { }

	// RVA: 0x18F4600 Offset: 0x18F0600 VA: 0x18F4600
	public void .ctor() { }
}

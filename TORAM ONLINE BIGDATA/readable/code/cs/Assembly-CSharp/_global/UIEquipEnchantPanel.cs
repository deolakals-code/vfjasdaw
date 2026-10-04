// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEquipEnchantPanel : UIEquipBasePanel // TypeDefIndex: 6930
{
	// Fields
	[SerializeField]
	private GameObject enchantPanelObj; // 0x28
	private UIIruna2Anchor enchantPanelAnchor; // 0x30
	[SerializeField]
	private UIEquipSlotButton selectEquipItem; // 0x38
	[SerializeField]
	private UILabel selectItemLabel; // 0x40
	[SerializeField]
	private GameObject selectLabelObj; // 0x48
	[SerializeField]
	private UILabel useExpLabel; // 0x50
	[SerializeField]
	private UIImageButton repairButton; // 0x58
	[SerializeField]
	private GameObject[] abilityElementObj; // 0x60
	private UILabel[] abilityLabel; // 0x68
	private GameObject[] haveAbilityIconObj; // 0x70
	private GameObject[] maxAbilityIconObj; // 0x78
	private UIQuestBoradPopLabel[] abilityPopLabel; // 0x80
	private TweenAlpha[] abilityAlpha; // 0x88
	[SerializeField]
	private UIEquipRepairAbilityPanel repairAbilityPanel; // 0x90
	[SerializeField]
	private UIIruna2Anchor orbPanel; // 0x98
	[SerializeField]
	private UILabel orbNumLabel; // 0xA0
	[SerializeField]
	private GameObject repairExpPanel; // 0xA8
	[SerializeField]
	private GameObject regrantExpPanel; // 0xB0
	[SerializeField]
	private UILabel regrantExpLabel; // 0xB8
	[SerializeField]
	private UIImageButton[] regrantButtons; // 0xC0
	[SerializeField]
	private GameObject[] regrantIcons; // 0xC8
	[SerializeField]
	private UIEquipRegrantAbilityPanel regrantAbilityPanel; // 0xD0
	private UIEquipMainManager manager; // 0xD8
	private PlayerDataManager playerDataManager; // 0xE0
	private SystemTextManager systemTextManager; // 0xE8
	private ItemTextManager itemTextManager; // 0xF0
	private ItemPropertyTextManager itemPropertyTextManager; // 0xF8
	private ItemDBData.EquipType selectedEquipType; // 0x100
	private int selectedItemUid; // 0x104
	private int selectedItemId; // 0x108
	private ItemData selectItemData; // 0x110
	private OrbManager orbManager; // 0x118
	private int orbItemNum; // 0x120
	private bool isResult; // 0x124
	private bool isRepairExp; // 0x125

	// Properties
	public bool IsOpenWindow { get; }

	// Methods

	// RVA: 0x1A4D268 Offset: 0x1A49268 VA: 0x1A4D268
	public bool get_IsOpenWindow() { }

	// RVA: 0x1A4D2A4 Offset: 0x1A492A4 VA: 0x1A4D2A4 Slot: 5
	public override void Initialize(PlayerDataManager playerDataManager, IUIEquipMainManager manager) { }

	// RVA: 0x1A4D99C Offset: 0x1A4999C VA: 0x1A4D99C Slot: 6
	public override void Open() { }

	// RVA: 0x1A4DC10 Offset: 0x1A49C10 VA: 0x1A4DC10 Slot: 7
	public override void Close() { }

	// RVA: 0x1A4DC88 Offset: 0x1A49C88 VA: 0x1A4DC88 Slot: 10
	public override bool Enter() { }

	// RVA: 0x1A4DCC0 Offset: 0x1A49CC0 VA: 0x1A4DCC0 Slot: 9
	public override bool Cancel() { }

	// RVA: 0x1A4DFA8 Offset: 0x1A49FA8 VA: 0x1A4DFA8 Slot: 12
	public override string GetSelectedItemText(ItemData itemData) { }

	// RVA: 0x1A4DFE8 Offset: 0x1A49FE8 VA: 0x1A4DFE8 Slot: 4
	public override bool InputLock() { }

	// RVA: 0x1A4DFF0 Offset: 0x1A49FF0 VA: 0x1A4DFF0 Slot: 8
	public override void SelectedEquipType(ItemDBData.EquipType equipType) { }

	// RVA: 0x1A4E610 Offset: 0x1A4A610 VA: 0x1A4E610 Slot: 11
	public override void SelectedItem(ItemData itemData) { }

	// RVA: 0x1A4E63C Offset: 0x1A4A63C VA: 0x1A4E63C
	public void SetVisibleMenuButton(bool enable) { }

	// RVA: 0x1A4DEF0 Offset: 0x1A49EF0 VA: 0x1A4DEF0
	public void OrbPanelEnable(bool enable) { }

	// RVA: 0x1A4E058 Offset: 0x1A4A058 VA: 0x1A4E058
	private void SetEquipItemLabel() { }

	// RVA: 0x1A4DB28 Offset: 0x1A49B28 VA: 0x1A4DB28
	private void NoSelectItemLabel() { }

	// RVA: 0x1A4E7AC Offset: 0x1A4A7AC VA: 0x1A4E7AC
	private void onRepair() { }

	// RVA: 0x1A4DD68 Offset: 0x1A49D68 VA: 0x1A4DD68
	private void OpenRepairWindow() { }

	// RVA: 0x1A4E82C Offset: 0x1A4A82C VA: 0x1A4E82C
	private void ResultEffect() { }

	[IteratorStateMachine(typeof(UIEquipEnchantPanel.<ResultFlashLabel>d__53))]
	// RVA: 0x1A4E858 Offset: 0x1A4A858 VA: 0x1A4E858
	private IEnumerator ResultFlashLabel() { }

	// RVA: 0x1A4E8EC Offset: 0x1A4A8EC VA: 0x1A4E8EC
	private void AfterBuyOrbItem() { }

	[IteratorStateMachine(typeof(UIEquipEnchantPanel.<InitAbilityPanel>d__55))]
	// RVA: 0x1A4E90C Offset: 0x1A4A90C VA: 0x1A4E90C
	private IEnumerator InitAbilityPanel() { }

	[IteratorStateMachine(typeof(UIEquipEnchantPanel.<InitProcess>d__56))]
	// RVA: 0x1A4D930 Offset: 0x1A49930 VA: 0x1A4D930
	private IEnumerator InitProcess() { }

	[IteratorStateMachine(typeof(UIEquipEnchantPanel.<CheckOrbItem>d__57))]
	// RVA: 0x1A4E9C8 Offset: 0x1A4A9C8 VA: 0x1A4E9C8
	private IEnumerator CheckOrbItem(bool isLoadStart = True) { }

	[IteratorStateMachine(typeof(UIEquipEnchantPanel.<WaitForSecondCheckOrbItem>d__58))]
	// RVA: 0x1A4EA70 Offset: 0x1A4AA70 VA: 0x1A4EA70
	private IEnumerator WaitForSecondCheckOrbItem() { }

	[IteratorStateMachine(typeof(UIEquipEnchantPanel.<CheckFairySewingToolsNum>d__59))]
	// RVA: 0x1A4EB04 Offset: 0x1A4AB04 VA: 0x1A4EB04
	private IEnumerator CheckFairySewingToolsNum() { }

	[IteratorStateMachine(typeof(UIEquipEnchantPanel.<CheckFairyPatternPaperNum>d__60))]
	// RVA: 0x1A4EB98 Offset: 0x1A4AB98 VA: 0x1A4EB98
	private IEnumerator CheckFairyPatternPaperNum() { }

	// RVA: 0x1A4EC2C Offset: 0x1A4AC2C VA: 0x1A4EC2C
	private void onChangeExp() { }

	// RVA: 0x1A4EC7C Offset: 0x1A4AC7C VA: 0x1A4EC7C
	private void onRegrant(int param) { }

	// RVA: 0x1A4ED68 Offset: 0x1A4AD68 VA: 0x1A4ED68
	private void RegrantCloseAfterAction() { }

	[IteratorStateMachine(typeof(UIEquipEnchantPanel.<AfterActionCoroutine>d__64))]
	// RVA: 0x1A4ED88 Offset: 0x1A4AD88 VA: 0x1A4ED88
	private IEnumerator AfterActionCoroutine() { }

	// RVA: 0x1A4EE1C Offset: 0x1A4AE1C VA: 0x1A4EE1C
	private void UpdateAbilityLabels(ItemData itemData) { }

	// RVA: 0x1A4E65C Offset: 0x1A4A65C VA: 0x1A4E65C
	private void UpdateButton(ItemData itemData) { }

	// RVA: 0x1A4F2F4 Offset: 0x1A4B2F4 VA: 0x1A4F2F4
	public void .ctor() { }
}

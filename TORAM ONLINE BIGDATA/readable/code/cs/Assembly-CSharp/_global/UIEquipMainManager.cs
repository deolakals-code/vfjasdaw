// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEquipMainManager : UIBasePanel, UIIItemPanelManager, IUIEquipMainManager // TypeDefIndex: 6951
{
	// Fields
	[SerializeField]
	private GameObject itemListManagerObject; // 0x30
	private UIItemListManager itemListManager; // 0x38
	[SerializeField]
	private GameObject itemListLeftAnchorObject; // 0x40
	private UIIruna2Anchor itemListLeftAnchor; // 0x48
	[SerializeField]
	private GameObject itemListRightAnchorObject; // 0x50
	private UIIruna2Anchor itemListRightAnchor; // 0x58
	[SerializeField]
	private GameObject equipPanelAnchorObject; // 0x60
	private UIIruna2Anchor equipPanelAnchor; // 0x68
	[SerializeField]
	private GameObject avatarEquipPanelAnchorObject; // 0x70
	private UIIruna2Anchor avatarEquipPanelAnchor; // 0x78
	[SerializeField]
	private GameObject[] equipSlotButtonObject; // 0x80
	private UIEquipSlotButton[] equipSlotButton; // 0x88
	[SerializeField]
	private UILabel changeLabel; // 0x90
	[SerializeField]
	private GameObject listButtonObject; // 0x98
	[SerializeField]
	private GameObject listEnterButtonObject; // 0xA0
	private UIImageButton listEnterImageButton; // 0xA8
	[SerializeField]
	private UILabel listEnterButtonLabel; // 0xB0
	[SerializeField]
	private GameObject enterButtonObject; // 0xB8
	private UIImageButton enterImageButton; // 0xC0
	[SerializeField]
	private UILabel enterButtonLabel; // 0xC8
	[SerializeField]
	private UIImageButton cristaCustomPanelButton; // 0xD0
	[SerializeField]
	private UILabel customPanelButtonLabel; // 0xD8
	[SerializeField]
	private UIImageButton avatarEquipPanelButton; // 0xE0
	[SerializeField]
	private UIImageButton equipPanelButton; // 0xE8
	[SerializeField]
	private GameObject menuButtonPanel; // 0xF0
	private UIIruna2Anchor menuAnchor; // 0xF8
	[SerializeField]
	private GameObject touchPanel; // 0x100
	[SerializeField]
	private GameObject hidePanel; // 0x108
	[SerializeField]
	private UIImageButton normalEquipButton; // 0x110
	[SerializeField]
	private UILabel itemTitleLabel; // 0x118
	[SerializeField]
	private GameObject equipBackPanel; // 0x120
	[SerializeField]
	private GameObject avatarBackPanel; // 0x128
	[SerializeField]
	private GameObject cristaListButton; // 0x130
	[SerializeField]
	private GameObject itemListScrollCameraObj; // 0x138
	[SerializeField]
	private GameObject enchantButtonObj; // 0x140
	private UIImageButton ehchantImageButton; // 0x148
	[SerializeField]
	private GameObject[] avatarEnableButton; // 0x150
	private EquipData firstEquipData; // 0x158
	private List<ItemData> selectItemDataList; // 0x160
	private ItemTextManager itemTextManager; // 0x168
	private PlayerDataManager playerDataManager; // 0x170
	private UIItemPanelButton selectedButton; // 0x178
	private int pageId; // 0x180
	private int pageItemNum; // 0x184
	private bool changeBattleAcviteFlag; // 0x188
	[SerializeField]
	private GameObject[] basePanelObject; // 0x190
	private UIEquipBasePanel[] basePanel; // 0x198
	private UIEquipMainManager.BasePanelType selectedPanel; // 0x1A0
	[SerializeField]
	private GameObject backButtonObj; // 0x1A8
	private bool isActiveEquipButton; // 0x1B0

	// Properties
	private bool inputLock { get; }
	public bool IsBattleActive { get; }
	public bool IsSystemLock { get; }
	public int PageId { get; }

	// Methods

	// RVA: 0x1A56288 Offset: 0x1A52288 VA: 0x1A56288
	public void SetTouchPanel(bool flag) { }

	// RVA: 0x1A5BF9C Offset: 0x1A57F9C VA: 0x1A5BF9C
	private bool get_inputLock() { }

	// RVA: 0x1A5C124 Offset: 0x1A58124 VA: 0x1A5C124
	public bool get_IsBattleActive() { }

	// RVA: 0x1A5C22C Offset: 0x1A5822C VA: 0x1A5C22C
	public bool get_IsSystemLock() { }

	// RVA: 0x1A5C250 Offset: 0x1A58250 VA: 0x1A5C250
	public int get_PageId() { }

	// RVA: 0x1A5C258 Offset: 0x1A58258 VA: 0x1A5C258
	public void UpdatePanel() { }

	// RVA: 0x1A5C5B8 Offset: 0x1A585B8 VA: 0x1A5C5B8
	private void Start() { }

	// RVA: 0x1A5CD14 Offset: 0x1A58D14 VA: 0x1A5CD14
	private void Update() { }

	// RVA: 0x1A5CD64 Offset: 0x1A58D64 VA: 0x1A5CD64
	private void UpdateBattleActiveUI() { }

	// RVA: 0x1A5D198 Offset: 0x1A59198 VA: 0x1A5D198 Slot: 14
	public void OnClickEquipButton(ItemDBData.EquipType selectedEquipType) { }

	// RVA: 0x1A542B8 Offset: 0x1A502B8 VA: 0x1A542B8
	public void SetItemList(List<ItemData> itemList, string buttonText) { }

	// RVA: 0x1A56A20 Offset: 0x1A52A20 VA: 0x1A56A20
	public void SetItemList(List<ItemData> itemList, string buttonText, int pageId) { }

	// RVA: 0x1A5E120 Offset: 0x1A5A120 VA: 0x1A5E120
	public void UpdateItemList() { }

	// RVA: 0x1A55BC8 Offset: 0x1A51BC8 VA: 0x1A55BC8
	public void SetItemListLabel(string buttonText, bool isActive) { }

	// RVA: 0x1A5D570 Offset: 0x1A59570 VA: 0x1A5D570
	private void OpenItemList() { }

	// RVA: 0x1A54740 Offset: 0x1A50740 VA: 0x1A54740
	public void ItemPanelClose() { }

	// RVA: 0x1A5486C Offset: 0x1A5086C VA: 0x1A5486C
	public void ResetEquipMenu() { }

	// RVA: 0x1A54C80 Offset: 0x1A50C80 VA: 0x1A54C80
	public void SetEquipItemLabel(ItemDBData.EquipType equipType, ItemData equipItem) { }

	// RVA: 0x1A55974 Offset: 0x1A51974 VA: 0x1A55974
	public void UpdateSelectButton() { }

	// RVA: 0x1A562A8 Offset: 0x1A522A8 VA: 0x1A562A8
	public void EquipButtonPointUp(int type, bool onlyFlag, bool isCheckBattle = True) { }

	// RVA: 0x1A5CF8C Offset: 0x1A58F8C VA: 0x1A5CF8C
	public void EquipNamePointUp(int type, bool onlyFlag, bool isCheckBattle = True) { }

	// RVA: 0x1A561C8 Offset: 0x1A521C8 VA: 0x1A561C8
	public void SetVisibleMenuButton(bool flag) { }

	// RVA: 0x1A5707C Offset: 0x1A5307C VA: 0x1A5707C
	public void MoveAvatarPanel(bool isEnable) { }

	// RVA: 0x1A573B4 Offset: 0x1A533B4 VA: 0x1A573B4
	public void ResetItemProperty() { }

	// RVA: 0x1A5E12C Offset: 0x1A5A12C VA: 0x1A5E12C
	private void ChangeAvatarEnebleButton(bool isActive) { }

	// RVA: 0x1A5E1C4 Offset: 0x1A5A1C4 VA: 0x1A5E1C4 Slot: 7
	public void OnPress(UIItemPanelButton select) { }

	// RVA: 0x1A5E330 Offset: 0x1A5A330 VA: 0x1A5E330 Slot: 8
	public void OnRelease(UIItemPanelButton select) { }

	// RVA: 0x1A5E334 Offset: 0x1A5A334 VA: 0x1A5E334 Slot: 9
	public void OnDrag(UIItemPanelButton select) { }

	// RVA: 0x1A5E338 Offset: 0x1A5A338 VA: 0x1A5E338 Slot: 10
	public void OnDragRelease(UIItemPanelButton select) { }

	// RVA: 0x1A5E33C Offset: 0x1A5A33C VA: 0x1A5E33C Slot: 11
	public void OnPanelChangeClick() { }

	// RVA: 0x1A5E3D0 Offset: 0x1A5A3D0 VA: 0x1A5E3D0 Slot: 12
	public void OnRightButtonClick() { }

	// RVA: 0x1A5E440 Offset: 0x1A5A440 VA: 0x1A5E440 Slot: 13
	public void OnLeftButtonClick() { }

	// RVA: 0x1A5E490 Offset: 0x1A5A490 VA: 0x1A5E490
	public void OnPageBackButtonClick() { }

	// RVA: 0x1A5E500 Offset: 0x1A5A500 VA: 0x1A5E500
	private void OnEquipPanelSlideIn() { }

	// RVA: 0x1A5E7F4 Offset: 0x1A5A7F4 VA: 0x1A5E7F4
	private void OnAvatarPanelSlideIn() { }

	// RVA: 0x1A5E71C Offset: 0x1A5A71C VA: 0x1A5E71C
	private void OnLeftPanelChange() { }

	// RVA: 0x1A5EB24 Offset: 0x1A5AB24 VA: 0x1A5EB24
	private void AvatarToCristaPanel() { }

	// RVA: 0x1A5EB3C Offset: 0x1A5AB3C VA: 0x1A5EB3C
	private void OnEnchantPanelIn() { }

	// RVA: 0x1A5E624 Offset: 0x1A5A624 VA: 0x1A5E624
	private void MenuButtonChangeFunction(bool avatarFlag) { }

	// RVA: 0x1A5EA6C Offset: 0x1A5AA6C VA: 0x1A5EA6C
	private void LeftPanelUpdate() { }

	// RVA: 0x1A5EC24 Offset: 0x1A5AC24 VA: 0x1A5EC24 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A5ED80 Offset: 0x1A5AD80 VA: 0x1A5ED80 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A5EE20 Offset: 0x1A5AE20 VA: 0x1A5EE20
	public void OpenAvatarPanel() { }

	[IteratorStateMachine(typeof(UIEquipMainManager.<ToOpenAvatarPanel>d__98))]
	// RVA: 0x1A5EE40 Offset: 0x1A5AE40 VA: 0x1A5EE40
	private IEnumerator ToOpenAvatarPanel() { }

	// RVA: 0x1A56F2C Offset: 0x1A52F2C VA: 0x1A56F2C
	public void UpdateEquipItem() { }

	// RVA: 0x1A54710 Offset: 0x1A50710 VA: 0x1A54710
	public void ChangeEnableEnchantButton(bool isEnable) { }

	// RVA: 0x1A5EED4 Offset: 0x1A5AED4 VA: 0x1A5EED4
	private void OnDestroy() { }

	// RVA: 0x1A5EED8 Offset: 0x1A5AED8 VA: 0x1A5EED8
	public void .ctor() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIItemBagManager : UIBasePanel, UIItemScrollPanelManager // TypeDefIndex: 7353
{
	// Fields
	private UIItemScrollListManager listManager; // 0x30
	private PlayerDataManager playerManager; // 0x38
	private UIItemScrollPanelButton activeButton; // 0x40
	private ItemManager itemManager; // 0x48
	private UIItemBagManager.CommandPanelType commandPanelPage; // 0x50
	[SerializeField]
	private GameObject useButtonAnchorObejct; // 0x58
	private UIIruna2Anchor useButtonAnchor; // 0x60
	[SerializeField]
	private GameObject equipButtonAnchorObejct; // 0x68
	private UIIruna2Anchor equipButtonAnchor; // 0x70
	[SerializeField]
	private GameObject deleteButtonAnchorObejct; // 0x78
	private UIIruna2Anchor deleteButtonAnchor; // 0x80
	[SerializeField]
	private GameObject sortButtonAnchorObejct; // 0x88
	private UIIruna2Anchor sortButtonAnchor; // 0x90
	[SerializeField]
	private GameObject changeButtonAnchorObejct; // 0x98
	private UIIruna2Anchor changeButtonAnchor; // 0xA0
	[SerializeField]
	private UILabel changeButtonLabel; // 0xA8
	[SerializeField]
	private GameObject lockButtonAnchorObejct; // 0xB0
	private UIIruna2Anchor lockButtonAnchor; // 0xB8
	[SerializeField]
	private UILabel lockButtonLabel; // 0xC0
	[SerializeField]
	private UISprite lockButtonIcon; // 0xC8
	[SerializeField]
	private GameObject bagButtonAnchorObejct; // 0xD0
	private UIIruna2Anchor bagButtonAnchor; // 0xD8
	[SerializeField]
	private GameObject bagPanelAnchorObejct; // 0xE0
	private UIIruna2Anchor bagPanelAnchor; // 0xE8
	[SerializeField]
	private GameObject[] bagIconObject; // 0xF0
	private UIBagIcon[] bagIcon; // 0xF8
	[SerializeField]
	private GameObject sortIconObject; // 0x100
	private int sortBitFlag; // 0x108
	private int bagId; // 0x10C
	private int popUpSelectId; // 0x110
	private UIPopBaseWindow popUpWindow; // 0x118
	private InactiveTimer popUpWindowInactiveTimer; // 0x120
	private bool cancelCheck; // 0x128
	private ItemTextManager itemTextManager; // 0x130
	private bool inputLock; // 0x138
	private float updateAutoItemCheck; // 0x13C
	private List<int> selectedItemList; // 0x140
	[SerializeField]
	private GameObject sortCheckBox; // 0x148
	[SerializeField]
	private BoxCollider lockPanelCollider; // 0x150
	[SerializeField]
	private GameObject[] buyNewSlotButtons; // 0x158
	private EnemyTextManager enemyTextManager; // 0x160
	private PetOperationManager petOperation; // 0x168
	private ItemData useItemData; // 0x170
	private bool isBagChangeLock; // 0x178
	private int bagItemNum; // 0x17C
	[SerializeField]
	private UIToggle[] openItemBoxToggle; // 0x180
	[SerializeField]
	private UILabel[] openItemBoxLabel; // 0x188
	[SerializeField]
	private GameObject openItemBoxPanel; // 0x190
	private int openItemBoxNum; // 0x198
	[SerializeField]
	private UIIruna2Anchor bagFullPanelAnchor; // 0x1A0
	[SerializeField]
	private UISprite[] bagFullPanelIcons; // 0x1A8
	[SerializeField]
	private UILabel[] bagFullPanelLabels; // 0x1B0
	[SerializeField]
	private UIIruna2Anchor addSlotPanelAnchor; // 0x1B8
	[SerializeField]
	private GameObject autoDeleteOptionObj; // 0x1C0
	[SerializeField]
	private GameObject collectBuySlotPanel; // 0x1C8
	[SerializeField]
	private GameObject[] collectBuySlotInnerPanel; // 0x1D0
	[SerializeField]
	private UILabel collectBuySlotErrorLabel; // 0x1D8
	[SerializeField]
	private UILabel needGoldLabel; // 0x1E0
	[SerializeField]
	private ItemIcon[] needItemIcons; // 0x1E8
	[SerializeField]
	private GameObject needMissionProgressLabel; // 0x1F0
	[SerializeField]
	private UIImageButton collectButSlotButton; // 0x1F8
	[SerializeField]
	private UILabel collectButSlotButtonLabel; // 0x200
	[SerializeField]
	private UILabel collectSlotNextNumLabel; // 0x208
	[SerializeField]
	private GameObject materialSearchButtonObj; // 0x210
	private List<RecipeDBData> collectRecipeDataList; // 0x218
	private RecipeDBDataManager recipeDBMaster; // 0x220
	private bool isErrorOpenBuyPanel; // 0x228
	private int slotReleaseRecipeId; // 0x22C
	private List<MaterialSearchData> recipeMaterialData; // 0x230
	private bool isPopUpMaterialSearch; // 0x238
	private List<ItemData> newItemDataList; // 0x240

	// Properties
	private UIIruna2Anchor UseButtonAnchor { get; }
	private UIIruna2Anchor EquipButtonAnchor { get; }
	private UIIruna2Anchor DeleteButtonAnchor { get; }
	private UIIruna2Anchor SortButtonAnchor { get; }
	private UIIruna2Anchor ChangeButtonAnchor { get; }
	private UIIruna2Anchor LockButtonAnchor { get; }
	private UIIruna2Anchor BagButtonAnchor { get; }
	private UIIruna2Anchor BagPanelAnchor { get; }

	// Methods

	// RVA: 0x1B13480 Offset: 0x1B0F480 VA: 0x1B13480
	private UIIruna2Anchor get_UseButtonAnchor() { }

	// RVA: 0x1B13530 Offset: 0x1B0F530 VA: 0x1B13530
	private UIIruna2Anchor get_EquipButtonAnchor() { }

	// RVA: 0x1B135E0 Offset: 0x1B0F5E0 VA: 0x1B135E0
	private UIIruna2Anchor get_DeleteButtonAnchor() { }

	// RVA: 0x1B13690 Offset: 0x1B0F690 VA: 0x1B13690
	private UIIruna2Anchor get_SortButtonAnchor() { }

	// RVA: 0x1B13740 Offset: 0x1B0F740 VA: 0x1B13740
	private UIIruna2Anchor get_ChangeButtonAnchor() { }

	// RVA: 0x1B137F0 Offset: 0x1B0F7F0 VA: 0x1B137F0
	private UIIruna2Anchor get_LockButtonAnchor() { }

	// RVA: 0x1B138A0 Offset: 0x1B0F8A0 VA: 0x1B138A0
	private UIIruna2Anchor get_BagButtonAnchor() { }

	// RVA: 0x1B13950 Offset: 0x1B0F950 VA: 0x1B13950
	private UIIruna2Anchor get_BagPanelAnchor() { }

	// RVA: 0x1B13A00 Offset: 0x1B0FA00 VA: 0x1B13A00
	public void OpenWarrantyItem() { }

	// RVA: 0x1B13A0C Offset: 0x1B0FA0C VA: 0x1B13A0C
	private void Awake() { }

	// RVA: 0x1B13C28 Offset: 0x1B0FC28 VA: 0x1B13C28
	private void Start() { }

	// RVA: 0x1B15084 Offset: 0x1B11084 VA: 0x1B15084
	private void Update() { }

	// RVA: 0x1B151D4 Offset: 0x1B111D4 VA: 0x1B151D4
	private void OnDestroy() { }

	// RVA: 0x1B1410C Offset: 0x1B1010C VA: 0x1B1410C
	private void UpdateNewItemList() { }

	// RVA: 0x1B14230 Offset: 0x1B10230 VA: 0x1B14230
	private bool ItemList(bool update) { }

	// RVA: 0x1B15358 Offset: 0x1B11358 VA: 0x1B15358
	private void OpenButtonList(ItemDBData.ItemType type) { }

	// RVA: 0x1B15E78 Offset: 0x1B11E78 VA: 0x1B15E78
	private void CloseButtonList() { }

	// RVA: 0x1B15E80 Offset: 0x1B11E80 VA: 0x1B15E80
	private void CloseButtonListEx(bool cloasSort) { }

	// RVA: 0x1B16128 Offset: 0x1B12128 VA: 0x1B16128
	private void ChangeButtonNowCommand() { }

	// RVA: 0x1B1595C Offset: 0x1B1195C VA: 0x1B1595C
	private void ChangeButtonCommand(UIItemBagManager.CommandPanelType type) { }

	// RVA: 0x1B14D08 Offset: 0x1B10D08 VA: 0x1B14D08
	private void UpdateBagFullPanel() { }

	// RVA: 0x1B161B8 Offset: 0x1B121B8 VA: 0x1B161B8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1B1634C Offset: 0x1B1234C VA: 0x1B1634C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1B163E8 Offset: 0x1B123E8 VA: 0x1B163E8 Slot: 11
	public void OnPanelChangeClick() { }

	// RVA: 0x1B164D4 Offset: 0x1B124D4 VA: 0x1B164D4 Slot: 12
	public void OnRightButtonClick() { }

	// RVA: 0x1B16618 Offset: 0x1B12618 VA: 0x1B16618 Slot: 13
	public void OnLeftButtonClick() { }

	// RVA: 0x1B164F0 Offset: 0x1B124F0 VA: 0x1B164F0
	private void BagChange(int add) { }

	// RVA: 0x1B16634 Offset: 0x1B12634 VA: 0x1B16634
	private void OnWarrantyItemBag() { }

	// RVA: 0x1B16A44 Offset: 0x1B12A44 VA: 0x1B16A44
	private void OnUseItem() { }

	// RVA: 0x1B174E0 Offset: 0x1B134E0 VA: 0x1B174E0
	public void OnOpenItemBoxUpdateNum(int id) { }

	// RVA: 0x1B1765C Offset: 0x1B1365C VA: 0x1B1765C
	private void CallBackUseItem() { }

	// RVA: 0x1B17A64 Offset: 0x1B13A64 VA: 0x1B17A64
	private void CallBackItemToPet() { }

	// RVA: 0x1B17D80 Offset: 0x1B13D80 VA: 0x1B17D80
	private void OnEquipItem() { }

	// RVA: 0x1B180F8 Offset: 0x1B140F8 VA: 0x1B180F8
	private void CallBackEquipItem() { }

	// RVA: 0x1B18434 Offset: 0x1B14434 VA: 0x1B18434
	private ItemDBData.EquipType GetSelectItemEquipType(int itemType) { }

	// RVA: 0x1B18458 Offset: 0x1B14458 VA: 0x1B18458
	private void OnSortItem() { }

	// RVA: 0x1B1873C Offset: 0x1B1473C VA: 0x1B1873C
	private void OnGetBitFlag(int bitFlag) { }

	// RVA: 0x1B18744 Offset: 0x1B14744 VA: 0x1B18744
	private void CallBackSortItem() { }

	// RVA: 0x1B18834 Offset: 0x1B14834 VA: 0x1B18834
	private void OnDeleteItem() { }

	// RVA: 0x1B18DDC Offset: 0x1B14DDC VA: 0x1B18DDC
	private void CallBackDeleteItem() { }

	// RVA: 0x1B19004 Offset: 0x1B15004 VA: 0x1B19004
	private void OnChangeCommand() { }

	// RVA: 0x1B19020 Offset: 0x1B15020 VA: 0x1B19020
	private void OnLockCommand() { }

	// RVA: 0x1B19300 Offset: 0x1B15300 VA: 0x1B19300
	private void CallBackLockItem() { }

	// RVA: 0x1B194B0 Offset: 0x1B154B0 VA: 0x1B194B0
	public void OnBuyNewSlot() { }

	[IteratorStateMachine(typeof(UIItemBagManager.<BuyNewSlot>d__126))]
	// RVA: 0x1B19544 Offset: 0x1B15544 VA: 0x1B19544
	private IEnumerator BuyNewSlot() { }

	// RVA: 0x1B151D8 Offset: 0x1B111D8 VA: 0x1B151D8
	private void ItemDeSelect() { }

	[IteratorStateMachine(typeof(UIItemBagManager.<PopUpWindow>d__128))]
	// RVA: 0x1B168FC Offset: 0x1B128FC VA: 0x1B168FC
	private IEnumerator PopUpWindow(Action callBack) { }

	[IteratorStateMachine(typeof(UIItemBagManager.<PopUpSelectWindow>d__129))]
	// RVA: 0x1B195B8 Offset: 0x1B155B8 VA: 0x1B195B8
	private IEnumerator PopUpSelectWindow(Action<int> callBack) { }

	// RVA: 0x1B19648 Offset: 0x1B15648 VA: 0x1B19648
	public void PopUpSelectWindowData(int param) { }

	[IteratorStateMachine(typeof(UIItemBagManager.<ItemToPet>d__131))]
	// RVA: 0x1B17D0C Offset: 0x1B13D0C VA: 0x1B17D0C
	private IEnumerator ItemToPet() { }

	// RVA: 0x1B19650 Offset: 0x1B15650 VA: 0x1B19650
	public void OpenSkillBookFailureWindow() { }

	// RVA: 0x1B197F0 Offset: 0x1B157F0 VA: 0x1B197F0
	public void UnlockItemFailureWindow() { }

	[IteratorStateMachine(typeof(UIItemBagManager.<ConnectWait>d__134))]
	// RVA: 0x1B1698C Offset: 0x1B1298C VA: 0x1B1698C
	private IEnumerator ConnectWait(bool update, Func<bool> func, Action callback) { }

	// RVA: 0x1B19A0C Offset: 0x1B15A0C VA: 0x1B19A0C
	private void OpenCollectBuySlotPanel() { }

	// RVA: 0x1B1A24C Offset: 0x1B1624C VA: 0x1B1A24C
	private void OpenErrorBuyPanel(string text) { }

	// RVA: 0x1B1A330 Offset: 0x1B16330 VA: 0x1B1A330
	private void OpenBuyPanel() { }

	[IteratorStateMachine(typeof(UIItemBagManager.<RecipeLoadData>d__138))]
	// RVA: 0x1B1A408 Offset: 0x1B16408 VA: 0x1B1A408
	private IEnumerator RecipeLoadData() { }

	// RVA: 0x1B1A47C Offset: 0x1B1647C VA: 0x1B1A47C
	public void OnCollectButSlot() { }

	// RVA: 0x1B1A5D0 Offset: 0x1B165D0 VA: 0x1B1A5D0
	private void FavoriteItem() { }

	[IteratorStateMachine(typeof(UIItemBagManager.<SendFavoriteItemData>d__141))]
	// RVA: 0x1B1A678 Offset: 0x1B16678 VA: 0x1B1A678
	private IEnumerator SendFavoriteItemData(ItemData item) { }

	// RVA: 0x1B1A708 Offset: 0x1B16708 VA: 0x1B1A708
	public void OnBagFull() { }

	// RVA: 0x1B16314 Offset: 0x1B12314 VA: 0x1B16314
	private void ChangeBagFullPanel() { }

	// RVA: 0x1B1A73C Offset: 0x1B1673C VA: 0x1B1A73C
	public void OnMaterialSearchButon() { }

	[IteratorStateMachine(typeof(UIItemBagManager.<PopUpMaterialSearchWindow>d__145))]
	// RVA: 0x1B1A75C Offset: 0x1B1675C VA: 0x1B1A75C
	private IEnumerator PopUpMaterialSearchWindow() { }

	// RVA: 0x1B1A7D0 Offset: 0x1B167D0 VA: 0x1B1A7D0
	public void OnAutoDeleteOption() { }

	// RVA: 0x1B1A8C0 Offset: 0x1B168C0 VA: 0x1B1A8C0 Slot: 7
	public void OnPress(UIItemScrollPanelButton select) { }

	// RVA: 0x1B1A8C4 Offset: 0x1B168C4 VA: 0x1B1A8C4 Slot: 8
	public void OnRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x1B1ACA8 Offset: 0x1B16CA8 VA: 0x1B1ACA8 Slot: 9
	public void OnDrag(UIItemScrollPanelButton select) { }

	// RVA: 0x1B1AA0C Offset: 0x1B16A0C VA: 0x1B1AA0C
	private void SelectItemButton(UIItemScrollPanelButton select) { }

	// RVA: 0x1B1ADD0 Offset: 0x1B16DD0 VA: 0x1B1ADD0 Slot: 10
	public void OnDragRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x1B1B038 Offset: 0x1B17038 VA: 0x1B1B038 Slot: 14
	public void OnFilterButton() { }

	// RVA: 0x1B1B040 Offset: 0x1B17040 VA: 0x1B1B040 Slot: 15
	public bool CheckIconDrag() { }

	// RVA: 0x1B1B05C Offset: 0x1B1705C VA: 0x1B1B05C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1B1B3A0 Offset: 0x1B173A0 VA: 0x1B1B3A0
	private bool <UpdateNewItemList>b__95_0(ItemData x) { }

	[CompilerGenerated]
	// RVA: 0x1B1B3CC Offset: 0x1B173CC VA: 0x1B1B3CC
	private void <OnWarrantyItemBag>b__109_0() { }

	[CompilerGenerated]
	// RVA: 0x1B1B3F8 Offset: 0x1B173F8 VA: 0x1B1B3F8
	private bool <OnWarrantyItemBag>b__109_1() { }

	[CompilerGenerated]
	// RVA: 0x1B1B418 Offset: 0x1B17418 VA: 0x1B1B418
	private bool <CallBackSortItem>b__119_0() { }

	[CompilerGenerated]
	// RVA: 0x1B1B438 Offset: 0x1B17438 VA: 0x1B1B438
	private bool <CallBackLockItem>b__124_0() { }

	[CompilerGenerated]
	// RVA: 0x1B1B458 Offset: 0x1B17458 VA: 0x1B1B458
	private void <OpenSkillBookFailureWindow>b__132_0() { }

	[CompilerGenerated]
	// RVA: 0x1B1B460 Offset: 0x1B17460 VA: 0x1B1B460
	private void <UnlockItemFailureWindow>b__133_0() { }

	[CompilerGenerated]
	// RVA: 0x1B1B468 Offset: 0x1B17468 VA: 0x1B1B468
	private bool <OnCollectButSlot>b__139_0() { }

	[CompilerGenerated]
	// RVA: 0x1B1B488 Offset: 0x1B17488 VA: 0x1B1B488
	private void <OnCollectButSlot>b__139_1() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStorageItemPanel : MonoBehaviour, UIItemScrollPanelManager // TypeDefIndex: 8603
{
	// Fields
	private UIStoragePanelManager manager; // 0x20
	private UIItemScrollListManager listManager; // 0x28
	private UIItemScrollPanelButton activeButton; // 0x30
	private ItemManager itemManager; // 0x38
	[SerializeField]
	private GameObject moveButtonAnchorObejct; // 0x40
	private UIIruna2Anchor moveButtonAnchor; // 0x48
	[SerializeField]
	private UISprite moveButtonIcon; // 0x50
	[SerializeField]
	private GameObject deleteButtonAnchorObejct; // 0x58
	private UIIruna2Anchor deleteButtonAnchor; // 0x60
	[SerializeField]
	private GameObject sortButtonAnchorObejct; // 0x68
	private UIIruna2Anchor sortButtonAnchor; // 0x70
	[SerializeField]
	private GameObject sortIconObject; // 0x78
	[SerializeField]
	private GameObject sortCheckBox; // 0x80
	[SerializeField]
	private GameObject changeButtonAnchorObejct; // 0x88
	private UIIruna2Anchor changeButtonAnchor; // 0x90
	[SerializeField]
	private UILabel changeButtonLabel; // 0x98
	[SerializeField]
	private GameObject[] buyNewSlotOrbButtons; // 0xA0
	private UIStorageItemPanel.CommandPanelType commandPanelPage; // 0xA8
	[SerializeField]
	private GameObject lockButtonAnchorObejct; // 0xB0
	private UIIruna2Anchor lockButtonAnchor; // 0xB8
	[SerializeField]
	private UILabel lockButtonLabel; // 0xC0
	[SerializeField]
	private UISprite lockButtonIcon; // 0xC8
	[SerializeField]
	private UILabel searchStorageNameLabel; // 0xD0
	[SerializeField]
	private UIIruna2Anchor searchMoveButtonAnchor; // 0xD8
	[SerializeField]
	private UIScrollWindow searchMoveScrollWindow; // 0xE0
	private UIIruna2Anchor searchMoveScrollAnchor; // 0xE8
	[SerializeField]
	private GameObject searchMoveElement; // 0xF0
	private UIIruna2Anchor listAnchor; // 0xF8
	private UIIruna2Anchor propertyAnchor; // 0x100
	private int selectedPanelId; // 0x108
	private int sortBitFlag; // 0x10C
	private ItemTextManager itemTextManager; // 0x110
	private SystemTextManager systemTextManager; // 0x118
	private PlayerDataManager playerDataManager; // 0x120
	private UIPopBaseWindow popUpWindow; // 0x128
	private InactiveTimer popUpWindowInactiveTimer; // 0x130
	private bool cancelCheck; // 0x138
	private int popUpSelectId; // 0x13C
	private bool storageBoxFlag; // 0x140
	private bool isMoveBoxMax; // 0x141
	private int bagItemNum; // 0x144
	private UIStorageItemPanel.StorageItemPanelData selectItemPanelData; // 0x148
	private List<ItemData> newItemDataList; // 0x150
	private UIGuildStaffFieldMenuManager guildStaffFieldMenuManager; // 0x158
	private UIItemCountSelectionDialog countSelectDialog; // 0x160
	private bool isSearchItemList; // 0x168
	private StorageItemDatav3[] searchItemList; // 0x170
	[CompilerGenerated]
	private bool <IsSearchMoveList>k__BackingField; // 0x178

	// Properties
	public UIItemScrollListManager ItemListManager { get; }
	public bool IsSearchItemList { get; }
	public bool IsSearchMoveList { get; set; }
	public bool IsOpenPopWindow { get; }
	public bool IsOpenCountSelectDialog { get; }

	// Methods

	// RVA: 0x1DB3A38 Offset: 0x1DAFA38 VA: 0x1DB3A38
	public UIItemScrollListManager get_ItemListManager() { }

	// RVA: 0x1DB3A40 Offset: 0x1DAFA40 VA: 0x1DB3A40
	public bool get_IsSearchItemList() { }

	[CompilerGenerated]
	// RVA: 0x1DB3A7C Offset: 0x1DAFA7C VA: 0x1DB3A7C
	public bool get_IsSearchMoveList() { }

	[CompilerGenerated]
	// RVA: 0x1DB3A84 Offset: 0x1DAFA84 VA: 0x1DB3A84
	private void set_IsSearchMoveList(bool value) { }

	// RVA: 0x1DB3A90 Offset: 0x1DAFA90 VA: 0x1DB3A90
	public bool get_IsOpenPopWindow() { }

	// RVA: 0x1DB3B38 Offset: 0x1DAFB38 VA: 0x1DB3B38
	public bool get_IsOpenCountSelectDialog() { }

	// RVA: 0x1DB3BCC Offset: 0x1DAFBCC VA: 0x1DB3BCC
	private void Start() { }

	// RVA: 0x1DB4398 Offset: 0x1DB0398 VA: 0x1DB4398
	private void Update() { }

	// RVA: 0x1DB459C Offset: 0x1DB059C VA: 0x1DB459C
	public void Initialize(UIStoragePanelManager panelManager, ItemManager playerItemManager, bool boxFlag) { }

	// RVA: 0x1DB474C Offset: 0x1DB074C VA: 0x1DB474C
	public void ActiveItemList(bool acitve) { }

	// RVA: 0x1DB4A78 Offset: 0x1DB0A78 VA: 0x1DB4A78
	public bool SetItemList(UIStorageItemPanel.StorageItemPanelData panelData, bool updatePanel) { }

	// RVA: 0x1DB4B68 Offset: 0x1DB0B68 VA: 0x1DB4B68
	public bool SetItemList(UIStorageItemPanel.StorageItemPanelData panelData, bool moveBoxMax, bool updatePanel, bool isDefaultScrollUpdate) { }

	// RVA: 0x1DB53B8 Offset: 0x1DB13B8 VA: 0x1DB53B8
	public void SetSearchItemList(StorageItemDatav3[] itemList) { }

	// RVA: 0x1DB56B4 Offset: 0x1DB16B4 VA: 0x1DB56B4
	private void OnChangeCommand() { }

	// RVA: 0x1DB56DC Offset: 0x1DB16DC VA: 0x1DB56DC
	private void ChangeButtonNowCommand() { }

	// RVA: 0x1DB56E4 Offset: 0x1DB16E4 VA: 0x1DB56E4
	private void CloseAllButton() { }

	// RVA: 0x1DB4A48 Offset: 0x1DB0A48 VA: 0x1DB4A48
	private void ActiveCommandButton(bool close) { }

	// RVA: 0x1DB56F0 Offset: 0x1DB16F0 VA: 0x1DB56F0
	private void ActiveCommandButton(bool close, bool sortClose) { }

	// RVA: 0x1DB52A4 Offset: 0x1DB12A4 VA: 0x1DB52A4
	private void ItemDeSelect() { }

	[IteratorStateMachine(typeof(UIStorageItemPanel.<PopUpWindow>d__74))]
	// RVA: 0x1DB5DE8 Offset: 0x1DB1DE8 VA: 0x1DB5DE8
	private IEnumerator PopUpWindow(Action callBack) { }

	// RVA: 0x1DB5E98 Offset: 0x1DB1E98 VA: 0x1DB5E98
	public bool PopUpWindowCancelCheck() { }

	// RVA: 0x1DB4AB0 Offset: 0x1DB0AB0 VA: 0x1DB4AB0
	private bool CheckMoveBoxMax() { }

	// RVA: 0x1DB5EB0 Offset: 0x1DB1EB0 VA: 0x1DB5EB0 Slot: 4
	public void OnPress(UIItemScrollPanelButton select) { }

	// RVA: 0x1DB5EB4 Offset: 0x1DB1EB4 VA: 0x1DB5EB4 Slot: 5
	public void OnRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x1DB6324 Offset: 0x1DB2324 VA: 0x1DB6324 Slot: 6
	public void OnDrag(UIItemScrollPanelButton select) { }

	// RVA: 0x1DB5F48 Offset: 0x1DB1F48 VA: 0x1DB5F48
	private void SelectItemButton(UIItemScrollPanelButton select) { }

	// RVA: 0x1DB6474 Offset: 0x1DB2474 VA: 0x1DB6474 Slot: 7
	public void OnDragRelease(UIItemScrollPanelButton select) { }

	// RVA: 0x1DB5CCC Offset: 0x1DB1CCC VA: 0x1DB5CCC
	private void UpdateStorageNameTextPos() { }

	// RVA: 0x1DB72A0 Offset: 0x1DB32A0 VA: 0x1DB72A0 Slot: 8
	public void OnPanelChangeClick() { }

	// RVA: 0x1DB736C Offset: 0x1DB336C VA: 0x1DB736C Slot: 9
	public void OnRightButtonClick() { }

	// RVA: 0x1DB7494 Offset: 0x1DB3494 VA: 0x1DB7494 Slot: 10
	public void OnLeftButtonClick() { }

	// RVA: 0x1DB6B68 Offset: 0x1DB2B68 VA: 0x1DB6B68
	private void OnMoveItemBox() { }

	// RVA: 0x1DB7634 Offset: 0x1DB3634 VA: 0x1DB7634
	private void OpenMoveItemBoxWindow(short selectCount) { }

	// RVA: 0x1DB7960 Offset: 0x1DB3960 VA: 0x1DB7960
	private void CallBackMoveItemBox(short selectCount) { }

	// RVA: 0x1DB6D90 Offset: 0x1DB2D90 VA: 0x1DB6D90
	private void OnSortItem() { }

	// RVA: 0x1DB7B60 Offset: 0x1DB3B60 VA: 0x1DB7B60
	private void OnGetBitFlag(int bitFlag) { }

	// RVA: 0x1DB7B68 Offset: 0x1DB3B68 VA: 0x1DB7B68
	private void CallBackSortItem() { }

	// RVA: 0x1DB7C6C Offset: 0x1DB3C6C VA: 0x1DB7C6C
	private void OnLockCommand() { }

	// RVA: 0x1DB7EF4 Offset: 0x1DB3EF4 VA: 0x1DB7EF4
	private void CallBackLockItem() { }

	// RVA: 0x1DB65FC Offset: 0x1DB25FC VA: 0x1DB65FC
	private void OnDeleteItem() { }

	// RVA: 0x1DB80BC Offset: 0x1DB40BC VA: 0x1DB80BC
	private void CallBackDeleteItem() { }

	// RVA: 0x1DB5F28 Offset: 0x1DB1F28 VA: 0x1DB5F28
	private void OnBuyNewSlot() { }

	[IteratorStateMachine(typeof(UIStorageItemPanel.<BuyNewSlot>d__97))]
	// RVA: 0x1DB81BC Offset: 0x1DB41BC VA: 0x1DB81BC
	private IEnumerator BuyNewSlot() { }

	// RVA: 0x1DB8250 Offset: 0x1DB4250 VA: 0x1DB8250 Slot: 11
	public void OnFilterButton() { }

	// RVA: 0x1DB82BC Offset: 0x1DB42BC VA: 0x1DB82BC Slot: 12
	public bool CheckIconDrag() { }

	[IteratorStateMachine(typeof(UIStorageItemPanel.<PopUpSelectWindow>d__100))]
	// RVA: 0x1DB82D8 Offset: 0x1DB42D8 VA: 0x1DB82D8
	private IEnumerator PopUpSelectWindow(Action<int> callBack) { }

	// RVA: 0x1DB8388 Offset: 0x1DB4388 VA: 0x1DB8388
	public void PopUpSelectWindowData(int param) { }

	// RVA: 0x1DB6D94 Offset: 0x1DB2D94 VA: 0x1DB6D94
	public void OnSearchMoveButton() { }

	// RVA: 0x1DB83FC Offset: 0x1DB43FC VA: 0x1DB83FC
	private GameObject AddStorageListButton(Vector3 pos, int id, string text) { }

	// RVA: 0x1DB8608 Offset: 0x1DB4608 VA: 0x1DB8608
	public void OnSearchMoveElementButton(int param) { }

	// RVA: 0x1DB7518 Offset: 0x1DB3518 VA: 0x1DB7518
	public void CloseSearchMoveList() { }

	// RVA: 0x1DB87E8 Offset: 0x1DB47E8 VA: 0x1DB87E8
	public void OpenSelectModePopWindow(bool isCountSelect, Action callBack) { }

	// RVA: 0x1DB8AA8 Offset: 0x1DB4AA8 VA: 0x1DB8AA8
	public bool CheckReturnCountSelectPanel() { }

	// RVA: 0x1DB8B08 Offset: 0x1DB4B08 VA: 0x1DB8B08
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1DB8BC8 Offset: 0x1DB4BC8 VA: 0x1DB8BC8
	private bool <Start>b__60_0(ItemData x) { }

	[CompilerGenerated]
	// RVA: 0x1DB8C00 Offset: 0x1DB4C00 VA: 0x1DB8C00
	private void <OnMoveItemBox>b__86_0(short select) { }

	[IteratorStateMachine(typeof(UIStorageItemPanel.<<OnSearchMoveButton>g__MoveItemList|102_0>d))]
	[CompilerGenerated]
	// RVA: 0x1DB8390 Offset: 0x1DB4390 VA: 0x1DB8390
	private IEnumerator <OnSearchMoveButton>g__MoveItemList|102_0() { }

	[IteratorStateMachine(typeof(UIStorageItemPanel.<<CloseSearchMoveList>g__ResetCameraPos|105_0>d))]
	[CompilerGenerated]
	// RVA: 0x1DB877C Offset: 0x1DB477C VA: 0x1DB877C
	private IEnumerator <CloseSearchMoveList>g__ResetCameraPos|105_0() { }
}

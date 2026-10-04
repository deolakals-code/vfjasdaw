// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStoragePanelManager : UIBasePanel, IShop // TypeDefIndex: 8627
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x30
	private Action returnAction; // 0x38
	[SerializeField]
	private UILabel shopLabel; // 0x40
	[SerializeField]
	private GameObject switchButtonObj; // 0x48
	[SerializeField]
	private GameObject swtichArrowIcon; // 0x50
	[SerializeField]
	private GameObject swtichEndIcon; // 0x58
	[SerializeField]
	private UILabel switchLabel; // 0x60
	private bool isSwitch; // 0x68
	private int selectSwitchId; // 0x6C
	private byte[] prevStorageOrderList; // 0x70
	private bool isSwitchMove; // 0x78
	private List<GameObject> storageObjList; // 0x80
	private bool inputLock; // 0x88
	private bool cancelCheck; // 0x89
	private bool popUpOrbWindow; // 0x8A
	private const float elementHeight = 160;
	private bool isOpenMenu; // 0x8B
	private const int EmptyPetCageItemId = 9051;
	private const int PetCageItemId = 9052;
	[SerializeField]
	private UIScrollWindow scrollListWindow; // 0x90
	[SerializeField]
	private GameObject listButton; // 0x98
	[SerializeField]
	private Transform selectedPosition; // 0xA0
	private GameObject selectedButton; // 0xA8
	private int selectId; // 0xB0
	[SerializeField]
	private GameObject commandPanelObejct; // 0xB8
	private UIIruna2Anchor commandPanel; // 0xC0
	[SerializeField]
	private GameObject customPanelObejct; // 0xC8
	private UIIruna2Anchor customPanel; // 0xD0
	[SerializeField]
	private GameObject itemPanelObejct; // 0xD8
	private UIStorageItemPanel itemPanel; // 0xE0
	[SerializeField]
	private UILabel pickUpLabel; // 0xE8
	[SerializeField]
	private UILabel putInLabel; // 0xF0
	[SerializeField]
	private UIInput warehouseNameInput; // 0xF8
	[SerializeField]
	private UILabel warehouseText; // 0x100
	[SerializeField]
	private UIImageButton selectModeButton; // 0x108
	[SerializeField]
	private UILabel selectModeButtonLabel; // 0x110
	private bool isCountSelectMode; // 0x118
	private StorageBaseCommand itemCommand; // 0x120
	private int selectPanelId; // 0x128
	private int shopId; // 0x12C
	private bool isClosed; // 0x130
	private string shopName; // 0x138
	[SerializeField]
	private GameObject searchButtonObj; // 0x140
	[SerializeField]
	private UIStorageSearchPanel searchPanel; // 0x148
	private List<StorageItemDatav3> searchItemList; // 0x150
	private bool searchPopWindow; // 0x158
	private bool isSearchGetItem; // 0x159
	private int[] searchSelectIdList; // 0x160

	// Properties
	public bool IsSwitch { get; }
	public int ShopId { get; set; }
	public string ShopName { get; set; }
	public bool IsClosed { get; set; }

	// Methods

	// RVA: 0x1DBA6D4 Offset: 0x1DB66D4 VA: 0x1DBA6D4
	public bool get_IsSwitch() { }

	// RVA: 0x1DBA6DC Offset: 0x1DB66DC VA: 0x1DBA6DC
	private void Start() { }

	// RVA: 0x1DBACD8 Offset: 0x1DB6CD8 VA: 0x1DBACD8
	private bool StorageManagerConnect() { }

	// RVA: 0x1DBAD50 Offset: 0x1DB6D50 VA: 0x1DBAD50
	private void CreateList() { }

	// RVA: 0x1DBB310 Offset: 0x1DB7310 VA: 0x1DBB310
	private UIStorageButton AddListButton(Vector3 position) { }

	[IteratorStateMachine(typeof(UIStoragePanelManager.<ConnectWait>d__30))]
	// RVA: 0x1DBAB28 Offset: 0x1DB6B28 VA: 0x1DBAB28
	private IEnumerator ConnectWait(Func<bool> checkConnect, Action callBack) { }

	[IteratorStateMachine(typeof(UIStoragePanelManager.<PopUpWindow>d__31))]
	// RVA: 0x1DBB618 Offset: 0x1DB7618 VA: 0x1DBB618
	private IEnumerator PopUpWindow(UIPopBaseWindow popUpWindow, Action callBack) { }

	// RVA: 0x1DB2EE0 Offset: 0x1DAEEE0 VA: 0x1DB2EE0
	public void SelectStorageBox(int id, Vector3 selectButtonPos) { }

	// RVA: 0x1DBB6BC Offset: 0x1DB76BC VA: 0x1DBB6BC
	private void SelectedWarehouseCustom() { }

	// RVA: 0x1DBB998 Offset: 0x1DB7998 VA: 0x1DBB998
	private void UpdateSelectedWarehouse() { }

	// RVA: 0x1DBBD90 Offset: 0x1DB7D90 VA: 0x1DBBD90
	private void ReturnSelectedBox() { }

	// RVA: 0x1DB357C Offset: 0x1DAF57C VA: 0x1DB357C
	public void BuyNewStorageBox() { }

	[IteratorStateMachine(typeof(UIStoragePanelManager.<BuyNewStorageBoxThread>d__50))]
	// RVA: 0x1DBBE88 Offset: 0x1DB7E88 VA: 0x1DBBE88
	public IEnumerator BuyNewStorageBoxThread() { }

	// RVA: 0x1DB2D5C Offset: 0x1DAED5C VA: 0x1DB2D5C
	public void SelectSwitchStorage(int id) { }

	// RVA: 0x1DB3638 Offset: 0x1DAF638 VA: 0x1DB3638
	public void SwitchStorageList(int id) { }

	[IteratorStateMachine(typeof(UIStoragePanelManager.<SwitchMoveCounter>d__53))]
	// RVA: 0x1DBBEFC Offset: 0x1DB7EFC VA: 0x1DBBEFC
	private IEnumerator SwitchMoveCounter() { }

	// RVA: 0x1DBBF70 Offset: 0x1DB7F70 VA: 0x1DBBF70
	private void OnSwitch() { }

	// RVA: 0x1DBC260 Offset: 0x1DB8260 VA: 0x1DBC260
	private void UpdateOrderList() { }

	[IteratorStateMachine(typeof(UIStoragePanelManager.<OrderChange>d__56))]
	// RVA: 0x1DBC540 Offset: 0x1DB8540 VA: 0x1DBC540
	private IEnumerator OrderChange() { }

	// RVA: 0x1DBC5B4 Offset: 0x1DB85B4 VA: 0x1DBC5B4
	private bool CheckOrderList(byte[] baseList, byte[] checkList) { }

	// RVA: 0x1DBC63C Offset: 0x1DB863C VA: 0x1DBC63C
	private byte GetShopType() { }

	// RVA: 0x1DBC6B0 Offset: 0x1DB86B0 VA: 0x1DBC6B0
	private void PickUpItemBox() { }

	// RVA: 0x1DBCAC4 Offset: 0x1DB8AC4 VA: 0x1DBCAC4
	private void PutInItemBox() { }

	// RVA: 0x1DBC764 Offset: 0x1DB8764 VA: 0x1DBC764
	private void OpenItemBox(StorageBaseCommand command, bool storage) { }

	// RVA: 0x1DBA2A4 Offset: 0x1DB62A4 VA: 0x1DBA2A4
	public void UpdateItemPanelList() { }

	// RVA: 0x1DBCBAC Offset: 0x1DB8BAC VA: 0x1DBCBAC
	public void UpdateItemPanelList(bool isScrollUpdate) { }

	// RVA: 0x1DB73F0 Offset: 0x1DB33F0 VA: 0x1DB73F0
	public bool UpdateItemPanelList(int panelId, int addId, bool isScrollUpdate = True) { }

	// RVA: 0x1DBCBC0 Offset: 0x1DB8BC0 VA: 0x1DBCBC0
	private bool ItemConnectCheck() { }

	[IteratorStateMachine(typeof(UIStoragePanelManager.<MoveItemBox>d__68))]
	// RVA: 0x1DB7AC4 Offset: 0x1DB3AC4 VA: 0x1DB7AC4
	public IEnumerator MoveItemBox(int itemUid, byte itemDataType, short num) { }

	// RVA: 0x1DBCBD8 Offset: 0x1DB8BD8 VA: 0x1DBCBD8
	public bool MoveItem(int itemUid, int itemLocation) { }

	// RVA: 0x1DB7BE8 Offset: 0x1DB3BE8 VA: 0x1DB7BE8
	public bool SortItem(int panelId) { }

	// RVA: 0x1DB8138 Offset: 0x1DB4138 VA: 0x1DB8138
	public bool DeleteItem(int itemUid) { }

	// RVA: 0x1DB7F88 Offset: 0x1DB3F88 VA: 0x1DB7F88
	public bool LockItem(int itemUid, bool lockFlag) { }

	[IteratorStateMachine(typeof(UIStoragePanelManager.<BuyNewSlot>d__73))]
	// RVA: 0x1DBA20C Offset: 0x1DB620C VA: 0x1DBA20C
	public IEnumerator BuyNewSlot(byte dataType, Action<PopUpMessageWindow> callback) { }

	// RVA: 0x1DBCD38 Offset: 0x1DB8D38 VA: 0x1DBCD38
	public int GetBagNum() { }

	// RVA: 0x1DB9ED0 Offset: 0x1DB5ED0 VA: 0x1DB9ED0
	public PopBaseWindow CriatePopMessageWindow() { }

	// RVA: 0x1DBCD5C Offset: 0x1DB8D5C VA: 0x1DBCD5C
	public int GetBagCapacity(int panelId) { }

	// RVA: 0x1DBCD80 Offset: 0x1DB8D80 VA: 0x1DBCD80
	public int GetBagItemCount(int panelId) { }

	// RVA: 0x1DBCC0C Offset: 0x1DB8C0C VA: 0x1DBCC0C
	private bool CommandCheck(Func<int, bool> func, int id) { }

	// RVA: 0x1DBCDA4 Offset: 0x1DB8DA4 VA: 0x1DBCDA4
	public void OnChangeSelectMode() { }

	// RVA: 0x1DBABCC Offset: 0x1DB6BCC VA: 0x1DBABCC
	private void UpdateSelectModeButton(bool isCountSelectMode) { }

	// RVA: 0x1DBB45C Offset: 0x1DB745C VA: 0x1DBB45C
	private void ChangeActiveSelectModeButton(bool isActive) { }

	// RVA: 0x1DBCE88 Offset: 0x1DB8E88 VA: 0x1DBCE88 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1DBD220 Offset: 0x1DB9220 VA: 0x1DBD220 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1DBD338 Offset: 0x1DB9338 VA: 0x1DBD338 Slot: 7
	public int get_ShopId() { }

	// RVA: 0x1DBD340 Offset: 0x1DB9340 VA: 0x1DBD340 Slot: 8
	public void set_ShopId(int value) { }

	// RVA: 0x1DBD348 Offset: 0x1DB9348 VA: 0x1DBD348 Slot: 9
	public string get_ShopName() { }

	// RVA: 0x1DBD350 Offset: 0x1DB9350 VA: 0x1DBD350 Slot: 10
	public void set_ShopName(string value) { }

	// RVA: 0x1DBD360 Offset: 0x1DB9360 VA: 0x1DBD360 Slot: 11
	public bool get_IsClosed() { }

	// RVA: 0x1DBD368 Offset: 0x1DB9368 VA: 0x1DBD368 Slot: 12
	public void set_IsClosed(bool value) { }

	// RVA: 0x1DB63A0 Offset: 0x1DB23A0 VA: 0x1DB63A0
	public StorageItemDatav3 GetSearchItemData(int uuid) { }

	// RVA: 0x1DBD374 Offset: 0x1DB9374 VA: 0x1DBD374
	public void OnSearch() { }

	// RVA: 0x1DBD138 Offset: 0x1DB9138 VA: 0x1DBD138
	private void ChangeActiveSearchPanel(bool isActive) { }

	[IteratorStateMachine(typeof(UIStoragePanelManager.<DoSearch>d__108))]
	// RVA: 0x1DBD408 Offset: 0x1DB9408 VA: 0x1DBD408
	private IEnumerator DoSearch(bool isLoadingBarEnd, bool isPrevSearch) { }

	// RVA: 0x1DBD49C Offset: 0x1DB949C VA: 0x1DBD49C
	private void SearchCategory(ItemType type, int modelId) { }

	// RVA: 0x1DBD59C Offset: 0x1DB959C VA: 0x1DBD59C
	private void SearchItemId(int itemId, int modelId) { }

	// RVA: 0x1DBD69C Offset: 0x1DB969C VA: 0x1DBD69C
	private void UpdateSearchItemList() { }

	[IteratorStateMachine(typeof(UIStoragePanelManager.<SearchPickUpItem>d__112))]
	// RVA: 0x1DB7A38 Offset: 0x1DB3A38 VA: 0x1DB7A38
	public IEnumerator SearchPickUpItem(int uuid, short num) { }

	[IteratorStateMachine(typeof(UIStoragePanelManager.<CreateSearchPopWindow>d__113))]
	// RVA: 0x1DBDCA4 Offset: 0x1DB9CA4 VA: 0x1DBDCA4
	private IEnumerator CreateSearchPopWindow(string title, string mes, Action closeAction) { }

	// RVA: 0x1DBDD64 Offset: 0x1DB9D64 VA: 0x1DBDD64
	private void UpdateStockLabel() { }

	[IteratorStateMachine(typeof(UIStoragePanelManager.<ItemMove>d__116))]
	// RVA: 0x1DB86D8 Offset: 0x1DB46D8 VA: 0x1DB86D8
	public IEnumerator ItemMove(short location, int itemId, byte beforeStorageNo, byte afterStorageNo) { }

	// RVA: 0x1DBDF4C Offset: 0x1DB9F4C VA: 0x1DBDF4C
	private void SearchAfterMove() { }

	[IteratorStateMachine(typeof(UIStoragePanelManager.<SearchAfterMoveProcess>d__118))]
	// RVA: 0x1DBDF6C Offset: 0x1DB9F6C VA: 0x1DBDF6C
	private IEnumerator SearchAfterMoveProcess() { }

	// RVA: 0x1DBDFE0 Offset: 0x1DB9FE0 VA: 0x1DBDFE0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1DBE12C Offset: 0x1DBA12C VA: 0x1DBE12C
	private void <Start>b__21_0() { }

	[CompilerGenerated]
	// RVA: 0x1DBE138 Offset: 0x1DBA138 VA: 0x1DBE138
	private void <OpenItemBox>b__63_0() { }

	[CompilerGenerated]
	// RVA: 0x1DBE16C Offset: 0x1DBA16C VA: 0x1DBE16C
	private void <MoveItemBox>b__68_0() { }

	[CompilerGenerated]
	// RVA: 0x1DBE178 Offset: 0x1DBA178 VA: 0x1DBE178
	private void <OnChangeSelectMode>b__79_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(UIStoragePanelManager.<<OnSearch>g__OpenSearchPanel|106_0>d))]
	// RVA: 0x1DBD394 Offset: 0x1DB9394 VA: 0x1DBD394
	private IEnumerator <OnSearch>g__OpenSearchPanel|106_0() { }

	[CompilerGenerated]
	// RVA: 0x1DBE1E4 Offset: 0x1DBA1E4 VA: 0x1DBE1E4
	private void <OnSearch>b__106_1() { }

	[CompilerGenerated]
	// RVA: 0x1DBE20C Offset: 0x1DBA20C VA: 0x1DBE20C
	private void <DoSearch>b__108_0() { }

	[CompilerGenerated]
	// RVA: 0x1DBE238 Offset: 0x1DBA238 VA: 0x1DBE238
	private void <UpdateSearchItemList>b__111_0() { }

	[CompilerGenerated]
	// RVA: 0x1DBE264 Offset: 0x1DBA264 VA: 0x1DBE264
	private void <CreateSearchPopWindow>b__113_0() { }
}

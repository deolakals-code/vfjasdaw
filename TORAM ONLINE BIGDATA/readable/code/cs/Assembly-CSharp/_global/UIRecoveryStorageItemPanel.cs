// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRecoveryStorageItemPanel : MonoBehaviour, UIIItemPanelManager // TypeDefIndex: 8463
{
	// Fields
	private UIRecoveryStoragePanelManager manager; // 0x20
	private UIItemListManager listManager; // 0x28
	private UIItemPanelButton activeButton; // 0x30
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
	private UIRecoveryStorageItemPanel.CommandPanelType commandPanelPage; // 0xA0
	[SerializeField]
	private GameObject lockButtonAnchorObejct; // 0xA8
	private UIIruna2Anchor lockButtonAnchor; // 0xB0
	[SerializeField]
	private UILabel lockButtonLabel; // 0xB8
	[SerializeField]
	private UISprite lockButtonIcon; // 0xC0
	private UIIruna2Anchor listAnchor; // 0xC8
	private UIIruna2Anchor propertyAnchor; // 0xD0
	private int selectedPanelId; // 0xD8
	private ItemTextManager itemTextManager; // 0xE0
	private SystemTextManager systemTextManager; // 0xE8
	private PlayerDataManager playerDataManager; // 0xF0
	private UIPopBaseWindow popUpWindow; // 0xF8
	private InactiveTimer popUpWindowInactiveTimer; // 0x100
	private bool cancelCheck; // 0x108
	private bool isMoveBoxMax; // 0x109

	// Properties
	public UIItemListManager ItemListManager { get; }

	// Methods

	// RVA: 0x1D6EEF4 Offset: 0x1D6AEF4 VA: 0x1D6EEF4
	public UIItemListManager get_ItemListManager() { }

	// RVA: 0x1D6EEFC Offset: 0x1D6AEFC VA: 0x1D6EEFC
	private void Start() { }

	// RVA: 0x1D6F560 Offset: 0x1D6B560 VA: 0x1D6F560
	public void Initialize(UIRecoveryStoragePanelManager panelManager, ItemManager playerItemManager) { }

	// RVA: 0x1D6F69C Offset: 0x1D6B69C VA: 0x1D6F69C
	public void ActiveItemList(bool acitve) { }

	// RVA: 0x1D6F954 Offset: 0x1D6B954 VA: 0x1D6F954
	public bool SetItemList(int panelId, Color color, ItemData[] itemList) { }

	// RVA: 0x1D6FBD8 Offset: 0x1D6BBD8 VA: 0x1D6FBD8
	private void ChangeButtonNowCommand() { }

	// RVA: 0x1D6FBE0 Offset: 0x1D6BBE0 VA: 0x1D6FBE0
	private void CloseAllButton() { }

	// RVA: 0x1D6F924 Offset: 0x1D6B924 VA: 0x1D6F924
	private void ActiveCommandButton(bool close) { }

	// RVA: 0x1D6FBEC Offset: 0x1D6BBEC VA: 0x1D6FBEC
	private void ActiveCommandButton(bool close, bool sortClose) { }

	// RVA: 0x1D6FAEC Offset: 0x1D6BAEC VA: 0x1D6FAEC
	private void ItemDeSelect() { }

	[IteratorStateMachine(typeof(UIRecoveryStorageItemPanel.<PopUpWindow>d__43))]
	// RVA: 0x1D70110 Offset: 0x1D6C110 VA: 0x1D70110
	private IEnumerator PopUpWindow(Action callBack) { }

	// RVA: 0x1D701C0 Offset: 0x1D6C1C0 VA: 0x1D701C0
	public bool PopUpWindowCancelCheck() { }

	// RVA: 0x1D701D8 Offset: 0x1D6C1D8 VA: 0x1D701D8 Slot: 4
	public void OnPress(UIItemPanelButton select) { }

	// RVA: 0x1D70354 Offset: 0x1D6C354 VA: 0x1D70354 Slot: 5
	public void OnRelease(UIItemPanelButton select) { }

	// RVA: 0x1D70370 Offset: 0x1D6C370 VA: 0x1D70370 Slot: 6
	public void OnDrag(UIItemPanelButton select) { }

	// RVA: 0x1D70390 Offset: 0x1D6C390 VA: 0x1D70390 Slot: 7
	public void OnDragRelease(UIItemPanelButton select) { }

	// RVA: 0x1D706A4 Offset: 0x1D6C6A4 VA: 0x1D706A4 Slot: 8
	public void OnPanelChangeClick() { }

	// RVA: 0x1D70770 Offset: 0x1D6C770 VA: 0x1D70770 Slot: 9
	public void OnRightButtonClick() { }

	// RVA: 0x1D70C84 Offset: 0x1D6CC84 VA: 0x1D70C84 Slot: 10
	public void OnLeftButtonClick() { }

	// RVA: 0x1D70404 Offset: 0x1D6C404 VA: 0x1D70404
	private void OnMoveItemBox() { }

	// RVA: 0x1D70D04 Offset: 0x1D6CD04 VA: 0x1D70D04
	private void CallBackMoveItemBox() { }

	// RVA: 0x1D71070 Offset: 0x1D6D070 VA: 0x1D71070
	public void .ctor() { }
}

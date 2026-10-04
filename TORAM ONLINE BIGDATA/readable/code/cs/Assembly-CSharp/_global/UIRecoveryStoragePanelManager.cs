// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRecoveryStoragePanelManager : UIBasePanel, IShop // TypeDefIndex: 8469
{
	// Fields
	[SerializeField]
	private UILabel shopLabel; // 0x30
	[SerializeField]
	private GameObject listButton; // 0x38
	[SerializeField]
	private GameObject itemPanelObejct; // 0x40
	private UIRecoveryStorageItemPanel itemPanel; // 0x48
	private UIScrollWindow scrollListWindow; // 0x50
	private PlayerDataManager playerDataManager; // 0x58
	private Action returnAction; // 0x60
	private int selectId; // 0x68
	private int selectPanelId; // 0x6C
	private bool inputLock; // 0x70
	private bool cancelCheck; // 0x71
	private int[] boxData; // 0x78
	private Dictionary<byte, List<ItemData>> boxItemData; // 0x80
	private Dictionary<byte, int[]> indexDbList; // 0x88
	private int shopId; // 0x90
	private bool isClosed; // 0x94
	private string shopName; // 0x98

	// Properties
	public int ShopId { get; set; }
	public string ShopName { get; set; }
	public bool IsClosed { get; set; }

	// Methods

	// RVA: 0x1D71298 Offset: 0x1D6D298 VA: 0x1D71298
	private void Start() { }

	// RVA: 0x1D715E4 Offset: 0x1D6D5E4 VA: 0x1D715E4
	private void Initialize() { }

	// RVA: 0x1D7165C Offset: 0x1D6D65C VA: 0x1D7165C
	public void ReceiveGetRecoveryStorageInfo(int[] boxData) { }

	// RVA: 0x1D716C0 Offset: 0x1D6D6C0 VA: 0x1D716C0
	public void ReceiveUpdateItemBox(byte boxNo, StorageItemDatav3[] storageItemDatas) { }

	// RVA: 0x1D718B0 Offset: 0x1D6D8B0 VA: 0x1D718B0
	public void ReceiveRemoveItemBox(byte boxNo, StorageItemDatav3 storageItemData) { }

	// RVA: 0x1D71A2C Offset: 0x1D6DA2C VA: 0x1D71A2C
	private void CreateList() { }

	// RVA: 0x1D71EDC Offset: 0x1D6DEDC VA: 0x1D71EDC
	private UIRecoveryStorageButton AddListButton(Vector3 position) { }

	[IteratorStateMachine(typeof(UIRecoveryStoragePanelManager.<ConnectWait>d__21))]
	// RVA: 0x1D72028 Offset: 0x1D6E028 VA: 0x1D72028
	private IEnumerator ConnectWait(byte subOpe, Action callBack, Action errcallBack) { }

	[IteratorStateMachine(typeof(UIRecoveryStoragePanelManager.<PopUpWindow>d__22))]
	// RVA: 0x1D720FC Offset: 0x1D6E0FC VA: 0x1D720FC
	private IEnumerator PopUpWindow(UIPopBaseWindow popUpWindow, Action callBack) { }

	// RVA: 0x1D6EAB8 Offset: 0x1D6AAB8 VA: 0x1D6EAB8
	public void SelectStorageBox(int id, Vector3 selectButtonPos) { }

	// RVA: 0x1D721C0 Offset: 0x1D6E1C0 VA: 0x1D721C0
	public void UpdateItemPanelList() { }

	// RVA: 0x1D707F0 Offset: 0x1D6C7F0 VA: 0x1D707F0
	public bool UpdateItemPanelList(int panelId, int addId) { }

	// RVA: 0x1D70D84 Offset: 0x1D6CD84 VA: 0x1D70D84
	public bool MoveItemBox(int itemUid, byte itemDataType) { }

	// RVA: 0x1D721DC Offset: 0x1D6E1DC VA: 0x1D721DC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1D722B4 Offset: 0x1D6E2B4 VA: 0x1D722B4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1D72324 Offset: 0x1D6E324 VA: 0x1D72324 Slot: 7
	public int get_ShopId() { }

	// RVA: 0x1D7232C Offset: 0x1D6E32C VA: 0x1D7232C Slot: 8
	public void set_ShopId(int value) { }

	// RVA: 0x1D72334 Offset: 0x1D6E334 VA: 0x1D72334 Slot: 9
	public string get_ShopName() { }

	// RVA: 0x1D7233C Offset: 0x1D6E33C VA: 0x1D7233C Slot: 10
	public void set_ShopName(string value) { }

	// RVA: 0x1D72344 Offset: 0x1D6E344 VA: 0x1D72344 Slot: 11
	public bool get_IsClosed() { }

	// RVA: 0x1D7234C Offset: 0x1D6E34C VA: 0x1D7234C Slot: 12
	public void set_IsClosed(bool value) { }

	// RVA: 0x1D72358 Offset: 0x1D6E358 VA: 0x1D72358
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D72464 Offset: 0x1D6E464 VA: 0x1D72464
	private void <SelectStorageBox>b__23_0() { }

	[CompilerGenerated]
	// RVA: 0x1D7246C Offset: 0x1D6E46C VA: 0x1D7246C
	private void <SelectStorageBox>b__23_1() { }
}

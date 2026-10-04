// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseItemManager : UIBasePanel, UIIHouseItemPanelResponse, UIHouseColorPalletPanelResponse // TypeDefIndex: 7254
{
	// Fields
	[SerializeField]
	private GameObject topButton; // 0x30
	[SerializeField]
	private Transform parentTopScrollTrans; // 0x38
	[SerializeField]
	private GameObject scrollButton; // 0x40
	[SerializeField]
	private Vector3 d3ViewOffset; // 0x48
	[SerializeField]
	private GameObject createPanel; // 0x58
	[SerializeField]
	private UIImageButton pointButton; // 0x60
	private UIIruna2ImageButtonDisableWidget pointButtonLabel; // 0x68
	[SerializeField]
	private UIImageButton orbButton; // 0x70
	[SerializeField]
	private GameObject recipeLabel; // 0x78
	private UIHouseRecipeLabel uiRecipeLabel; // 0x80
	[SerializeField]
	private GameObject putButton; // 0x88
	[SerializeField]
	private GameObject selectMessage; // 0x90
	[SerializeField]
	private UILabel houseItemLabel; // 0x98
	[SerializeField]
	private UIIruna2Anchor colorPalletPanelAnchor; // 0xA0
	[SerializeField]
	private GameObject colorPalletPanel; // 0xA8
	private UIHouseColorPalletPanel colorPalletPanelData; // 0xB0
	[SerializeField]
	private GameObject editColorChangeButton; // 0xB8
	[SerializeField]
	private GameObject colorChangeButton; // 0xC0
	[SerializeField]
	private GameObject[] selectColorButton; // 0xC8
	private UIToggle[] selectColorToggle; // 0xD0
	private UIHouseItemPanel uiHousePartsPanel; // 0xD8
	[SerializeField]
	private int houseItemEnvironmentType; // 0xE0
	[SerializeField]
	private UIActiveState backMenu; // 0xE4
	[SerializeField]
	private GameObject messageLabel; // 0xE8
	[SerializeField]
	private UILabel houseItemErrLabel; // 0xF0
	[SerializeField]
	private GameObject recipeButton; // 0xF8
	private int selectedObjType; // 0x100
	private int selectedObjId; // 0x104
	private byte selectedColorType; // 0x108
	private bool initFlag; // 0x109
	private HouseItemTextManager houseTextManager; // 0x110
	private HouseManager houseManager; // 0x118
	private Dictionary<int, GameObject> categoryButtonList; // 0x120
	private byte[] editColor; // 0x128
	private bool setItemFlag; // 0x130
	private bool editColorPanel; // 0x131
	private bool isLoaded; // 0x132
	private GameObject loadModelPop; // 0x138
	private UIPopBaseWindow popUpWindow; // 0x140
	private InactiveTimer popUpWindowInactiveTimer; // 0x148
	private bool cancelCheck; // 0x150
	private List<MaterialSearchData> itemSearchData; // 0x158
	private List<UIHouseItemButton> loadingItemButton; // 0x160
	private UIHouseItemButton currentLoadingButton; // 0x168
	private int currentLoadingIndex; // 0x170

	// Methods

	[IteratorStateMachine(typeof(UIHouseItemManager.<Start>d__45))]
	// RVA: 0x1AEE354 Offset: 0x1AEA354 VA: 0x1AEE354
	public IEnumerator Start() { }

	// RVA: 0x1AEE3E8 Offset: 0x1AEA3E8 VA: 0x1AEE3E8
	private void SetTopScrollTrans(GameObject button, float x) { }

	// RVA: 0x1AEE4E4 Offset: 0x1AEA4E4 VA: 0x1AEE4E4
	public void Initialize(int itemId) { }

	// RVA: 0x1AEF54C Offset: 0x1AEB54C VA: 0x1AEF54C
	private void EbabledCategoryButton(bool enabled) { }

	// RVA: 0x1AEF778 Offset: 0x1AEB778 VA: 0x1AEF778
	private void Update() { }

	[IteratorStateMachine(typeof(UIHouseItemManager.<ConnectWait>d__50))]
	// RVA: 0x1AEF8BC Offset: 0x1AEB8BC VA: 0x1AEF8BC
	private IEnumerator ConnectWait(Action callback) { }

	// RVA: 0x1AEF96C Offset: 0x1AEB96C VA: 0x1AEF96C
	public void OnEditTypeClick(int id) { }

	// RVA: 0x1AEEE44 Offset: 0x1AEAE44 VA: 0x1AEEE44
	public void OnClickItem(int objId) { }

	// RVA: 0x1AEFC40 Offset: 0x1AEBC40 VA: 0x1AEFC40
	public void OnCreateItemUseOrb() { }

	// RVA: 0x1AF01D0 Offset: 0x1AEC1D0 VA: 0x1AF01D0
	public void OnCreateItemUsePoint() { }

	// RVA: 0x1AF06B0 Offset: 0x1AEC6B0 VA: 0x1AF06B0
	public void OnPutItem() { }

	// RVA: 0x1AF0944 Offset: 0x1AEC944 VA: 0x1AF0944
	public void OnClickRecipeSearch() { }

	[IteratorStateMachine(typeof(UIHouseItemManager.<PopUpWindow>d__57))]
	// RVA: 0x1AF0C1C Offset: 0x1AECC1C VA: 0x1AF0C1C
	protected IEnumerator PopUpWindow() { }

	// RVA: 0x1AF0CB0 Offset: 0x1AECCB0 VA: 0x1AF0CB0
	private void UpdateScrollList() { }

	// RVA: 0x1AEE5E4 Offset: 0x1AEA5E4 VA: 0x1AEE5E4
	private void UpdateScrollList(int selectItemId) { }

	// RVA: 0x1AF0CB8 Offset: 0x1AECCB8 VA: 0x1AF0CB8 Slot: 7
	public void OnEnterPopUpCreateWindow() { }

	// RVA: 0x1AF0CD8 Offset: 0x1AECCD8 VA: 0x1AF0CD8
	private void OnDragOverCheck() { }

	// RVA: 0x1AF0DF4 Offset: 0x1AECDF4 VA: 0x1AF0DF4 Slot: 9
	public void OnHouseItemChangeColor(byte colorId) { }

	// RVA: 0x1AF0F84 Offset: 0x1AECF84 VA: 0x1AF0F84
	public void OnEnterColorChange() { }

	// RVA: 0x1AF1028 Offset: 0x1AED028 VA: 0x1AF1028
	public void OnEnterEditColorChange() { }

	// RVA: 0x1AF10B8 Offset: 0x1AED0B8 VA: 0x1AF10B8
	private void OnSelectEditColor(int type) { }

	// RVA: 0x1AF131C Offset: 0x1AED31C VA: 0x1AF131C Slot: 8
	public void OnLoadModelData(HousePartsModelType type, int modelId, int itemId) { }

	// RVA: 0x1AF13C0 Offset: 0x1AED3C0 VA: 0x1AF13C0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1AF14DC Offset: 0x1AED4DC VA: 0x1AF14DC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AF1568 Offset: 0x1AED568 VA: 0x1AF1568
	public void .ctor() { }
}

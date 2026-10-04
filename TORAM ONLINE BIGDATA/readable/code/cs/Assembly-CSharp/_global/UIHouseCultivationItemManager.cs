// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseCultivationItemManager : UIBasePanel, UIIHouseItemPanelResponse // TypeDefIndex: 7227
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
	private GameObject recipeLabel; // 0x70
	private UIHouseRecipeLabel uiRecipeLabel; // 0x78
	[SerializeField]
	private GameObject selectMessage; // 0x80
	[SerializeField]
	private UILabel houseItemLabel; // 0x88
	[SerializeField]
	private GameObject popWindowPanel; // 0x90
	private UIHouseSeedPanel houseSeedPanel; // 0x98
	private UIHouseItemPanel uiHousePartsPanel; // 0xA0
	[SerializeField]
	private GameObject messageLabel; // 0xA8
	[SerializeField]
	private UILabel houseItemErrLabel; // 0xB0
	[SerializeField]
	private GameObject panelSizeTopObject; // 0xB8
	[SerializeField]
	private Transform[] panelSizeObject; // 0xC0
	[SerializeField]
	private UILabel panelSizeLabel; // 0xC8
	[SerializeField]
	private UILabel typeSetCountLabel; // 0xD0
	private int selectedObjType; // 0xD8
	private int selectedObjId; // 0xDC
	private bool initFlag; // 0xE0
	private HouseItemTextManager houseTextManager; // 0xE8
	private HouseManager houseManager; // 0xF0
	private Dictionary<int, GameObject> categoryButtonList; // 0xF8
	private bool setItemFlag; // 0x100
	private bool isLoaded; // 0x101
	private GameObject loadModelPop; // 0x108
	private byte houseItemEnvironmentType; // 0x110
	private int materialPoint; // 0x114

	// Methods

	[IteratorStateMachine(typeof(UIHouseCultivationItemManager.<Start>d__31))]
	// RVA: 0x1AE1480 Offset: 0x1ADD480 VA: 0x1AE1480
	public IEnumerator Start() { }

	// RVA: 0x1AE1514 Offset: 0x1ADD514 VA: 0x1AE1514
	private void SetTopScrollTrans(GameObject button, float x) { }

	// RVA: 0x1AE1610 Offset: 0x1ADD610 VA: 0x1AE1610
	public void Initialize(int itemId) { }

	// RVA: 0x1AE2470 Offset: 0x1ADE470 VA: 0x1AE2470
	private void EnabledCategoryButton(bool enabled) { }

	[IteratorStateMachine(typeof(UIHouseCultivationItemManager.<ConnectWait>d__35))]
	// RVA: 0x1AE269C Offset: 0x1ADE69C VA: 0x1AE269C
	private IEnumerator ConnectWait(Action callback) { }

	// RVA: 0x1AE274C Offset: 0x1ADE74C VA: 0x1AE274C
	public void OnEditTypeClick(int id) { }

	// RVA: 0x1AE1DC8 Offset: 0x1ADDDC8 VA: 0x1AE1DC8
	public void OnClickItem(int objId) { }

	// RVA: 0x1AE2954 Offset: 0x1ADE954 VA: 0x1AE2954
	public void OnCreateItemUsePoint() { }

	// RVA: 0x1AE2E28 Offset: 0x1ADEE28 VA: 0x1AE2E28
	private void UpdateScrollList() { }

	// RVA: 0x1AE1710 Offset: 0x1ADD710 VA: 0x1AE1710
	private void UpdateScrollList(int selectItemId) { }

	// RVA: 0x1AE3414 Offset: 0x1ADF414 VA: 0x1AE3414 Slot: 7
	public void OnEnterPopUpCreateWindow() { }

	// RVA: 0x1AE3698 Offset: 0x1ADF698 VA: 0x1AE3698
	private void OnDragOverCheck() { }

	// RVA: 0x1AE37B4 Offset: 0x1ADF7B4 VA: 0x1AE37B4 Slot: 8
	public void OnLoadModelData(HousePartsModelType type, int modelId, int itemId) { }

	// RVA: 0x1AE396C Offset: 0x1ADF96C VA: 0x1AE396C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1AE3AF4 Offset: 0x1ADFAF4 VA: 0x1AE3AF4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AE3B80 Offset: 0x1ADFB80 VA: 0x1AE3B80
	public void .ctor() { }
}

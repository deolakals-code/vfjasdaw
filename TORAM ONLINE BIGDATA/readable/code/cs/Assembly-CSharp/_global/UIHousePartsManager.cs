// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHousePartsManager : UIBasePanel, UIIHouseItemPanelResponse // TypeDefIndex: 7321
{
	// Fields
	[SerializeField]
	private GameObject topButton; // 0x30
	[SerializeField]
	private GameObject scrollButton; // 0x38
	[SerializeField]
	private Vector3 d3ViewOffset; // 0x40
	[SerializeField]
	private UILabel houseItemLabel; // 0x50
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
	private GameObject recipeButton; // 0x88
	[SerializeField]
	private GameObject enterButton; // 0x90
	[SerializeField]
	private GameObject selectedPopLabel; // 0x98
	private UIHouseItemPanel uiHousePartsPanel; // 0xA0
	private HouseManager houseManager; // 0xA8
	private int selectedItemType; // 0xB0
	private Transform parentTopScrollTrans; // 0xB8
	private Dictionary<HousePartsModelType, int> editPartsTypeData; // 0xC0
	private HouseItemTextManager textManager; // 0xC8
	private bool isCreateItem; // 0xD0
	private int selectedObjId; // 0xD4
	private List<GameObject> categoryButtonList; // 0xD8
	private bool[] loadModelFlag; // 0xE0
	private UIPopBaseWindow popUpWindow; // 0xE8
	private InactiveTimer popUpWindowInactiveTimer; // 0xF0
	private bool cancelCheck; // 0xF8
	private List<MaterialSearchData> itemSearchData; // 0x100
	private List<UIHouseItemButton> loadingItemButton; // 0x108
	private UIHouseItemButton currentLoadingButton; // 0x110
	private int currentLoadingIndex; // 0x118

	// Methods

	[IteratorStateMachine(typeof(UIHousePartsManager.<Start>d__30))]
	// RVA: 0x1B0CC48 Offset: 0x1B08C48 VA: 0x1B0CC48
	public IEnumerator Start() { }

	// RVA: 0x1B0CCDC Offset: 0x1B08CDC VA: 0x1B0CCDC
	private void SetTopScrollTrans(GameObject button, float x) { }

	// RVA: 0x1B0CDD8 Offset: 0x1B08DD8 VA: 0x1B0CDD8
	private void EbabledCategoryButton(bool enabled) { }

	// RVA: 0x1B0CFE0 Offset: 0x1B08FE0 VA: 0x1B0CFE0
	private void Update() { }

	// RVA: 0x1B0D118 Offset: 0x1B09118 VA: 0x1B0D118
	public void OnEditTypeClick(int id) { }

	// RVA: 0x1B0DA7C Offset: 0x1B09A7C VA: 0x1B0DA7C
	public void OnClickItem(int objId) { }

	// RVA: 0x1B0E808 Offset: 0x1B0A808 VA: 0x1B0E808
	public void OnCreateItemUseOrb() { }

	// RVA: 0x1B0E8FC Offset: 0x1B0A8FC VA: 0x1B0E8FC
	public void OnCreateItemUsePoint() { }

	// RVA: 0x1B0E9F0 Offset: 0x1B0A9F0 VA: 0x1B0E9F0
	private void InRoomTypeButton() { }

	// RVA: 0x1B0EAE0 Offset: 0x1B0AAE0 VA: 0x1B0EAE0
	private void OutRoomTypeButton() { }

	// RVA: 0x1B0D348 Offset: 0x1B09348 VA: 0x1B0D348
	private void RestSelectedItem() { }

	// RVA: 0x1B0D458 Offset: 0x1B09458 VA: 0x1B0D458
	private void UpdateScrollList(int selectItemId) { }

	// RVA: 0x1B0EBCC Offset: 0x1B0ABCC VA: 0x1B0EBCC
	private void OnEnterMyHomeCreate() { }

	[IteratorStateMachine(typeof(UIHousePartsManager.<Connection>d__43))]
	// RVA: 0x1B0EEB4 Offset: 0x1B0AEB4 VA: 0x1B0EEB4
	private IEnumerator Connection() { }

	// RVA: 0x1B0EF48 Offset: 0x1B0AF48 VA: 0x1B0EF48 Slot: 7
	public void OnEnterPopUpCreateWindow() { }

	// RVA: 0x1B0EF74 Offset: 0x1B0AF74 VA: 0x1B0EF74 Slot: 8
	public void OnLoadModelData(HousePartsModelType type, int modelId, int itemId) { }

	// RVA: 0x1B0EFB8 Offset: 0x1B0AFB8 VA: 0x1B0EFB8
	public void OnClickRecipeSearch() { }

	[IteratorStateMachine(typeof(UIHousePartsManager.<PopUpWindow>d__47))]
	// RVA: 0x1B0F210 Offset: 0x1B0B210 VA: 0x1B0F210
	protected IEnumerator PopUpWindow() { }

	// RVA: 0x1B0F2A4 Offset: 0x1B0B2A4 VA: 0x1B0F2A4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1B0F3B8 Offset: 0x1B0B3B8 VA: 0x1B0F3B8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1B0F488 Offset: 0x1B0B488 VA: 0x1B0F488
	public void .ctor() { }
}

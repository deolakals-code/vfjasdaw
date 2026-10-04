// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIItemScrollListManager : MonoBehaviour // TypeDefIndex: 8988
{
	// Fields
	private UIItemScrollPanelManager manager; // 0x20
	private ItemTextManager itemTextManager; // 0x28
	private SystemTextManager systemTextManager; // 0x30
	private int itemPanelNum; // 0x38
	private GameObject parentObj; // 0x40
	private bool isItemSlotMessage; // 0x48
	private const float scrollCameraPosX = 2000;
	private GameObject mainAnimationObject; // 0x50
	private Animation mainAnimation; // 0x58
	private SkinnedMeshRenderer mainAnimationSkin; // 0x60
	private Transform mainAnimationHeadBone; // 0x68
	private float charaHeight; // 0x70
	private OptionsSystem optionsSysmtem; // 0x78
	private bool initDisplayOption; // 0x80
	private const float ScrollHeight = 122;
	private IUIItemScrollPanelButton[] buttonListS; // 0x88
	[SerializeField]
	private GameObject glbutton; // 0x90
	[SerializeField]
	private GameObject baseButton; // 0x98
	[SerializeField]
	private UISprite itemListPanelBackSprite; // 0xA0
	[SerializeField]
	private GameObject rightAnchorObject; // 0xA8
	[SerializeField]
	private UIScrollWindow scrollListWindow; // 0xB0
	[SerializeField]
	private UICamera scrollListUICamera; // 0xB8
	[SerializeField]
	private UIDraggableCamera scrollListDragCamera; // 0xC0
	[SerializeField]
	private UIImageButton[] filterButtonList; // 0xC8
	[SerializeField]
	private UILabel[] filterButtonLabels; // 0xD0
	[SerializeField]
	private UILabel[] nonFilterNumLabels; // 0xD8
	[SerializeField]
	private GameObject nonFilterPanel; // 0xE0
	[SerializeField]
	private GameObject nonFilterLabelObj; // 0xE8
	[SerializeField]
	private UIToggle displayOptionButton; // 0xF0
	private byte filterType; // 0xF8
	[CompilerGenerated]
	private byte <LockFilterType>k__BackingField; // 0xF9
	[SerializeField]
	private UIImageButton organizeButton; // 0x100
	private bool isOrganize; // 0x108
	private bool isCameraStop; // 0x109
	private Vector3 cameraPos; // 0x10C
	private UIItemScrollListManager.PropertyPanelState panelState; // 0x118
	public bool Close; // 0x11C
	public bool Check; // 0x11D
	public bool Full; // 0x11E
	[SerializeField]
	private GameObject propertyPanelTop; // 0x120
	[SerializeField]
	private UILabel propertyPanelItemLabel; // 0x128
	[SerializeField]
	private UILabel propertyPanelNumLabel; // 0x130
	[SerializeField]
	private UIIcon propertyPanelItemIcon; // 0x138
	[SerializeField]
	private GameObject propertyPanelButton; // 0x140
	[SerializeField]
	private UISprite propertyPanelButtonIcon; // 0x148
	[SerializeField]
	private UILabel propertyPanelButtonLabel; // 0x150
	[SerializeField]
	private GameObject propertyPanelBackground; // 0x158
	[SerializeField]
	private GameObject propertyPanelTopObject; // 0x160
	[SerializeField]
	private UIScrollBar propertyPanelTextBar; // 0x168
	[SerializeField]
	private Transform scrollTopBar; // 0x170
	[SerializeField]
	private Transform scrollBottomBar; // 0x178
	[SerializeField]
	private Camera scrollCamera; // 0x180
	private UIIruna2Viewport scrollView; // 0x188
	private UIDragCamera scrollDragCamera; // 0x190
	[SerializeField]
	private GameObject propertyPanelObject; // 0x198
	[CompilerGenerated]
	private UIItemProperty <propertyPanel>k__BackingField; // 0x1A0
	private float scrollHeight; // 0x1A8
	[SerializeField]
	private GameObject leftAnchorObject; // 0x1B0
	private UIIruna2Anchor leftAnchor; // 0x1B8
	private GameObject scrollLoadingObj; // 0x1C0
	private const int scrollLoadingTime = 100;
	private Stopwatch sw; // 0x1C8
	[SerializeField]
	private GameObject glassIconObj; // 0x1D0
	[SerializeField]
	private UIIruna2Anchor modelAnchoerObj; // 0x1D8
	[SerializeField]
	private GameObject previewCamera; // 0x1E0
	[SerializeField]
	private GameObject modelParentObj; // 0x1E8
	[SerializeField]
	private UIIruna2DragPinch dragPinch; // 0x1F0
	[SerializeField]
	private GameObject modelPropObj; // 0x1F8
	[SerializeField]
	private GameObject modelPropCustomObj; // 0x200
	[SerializeField]
	private UILabel modelPropCustomLabel; // 0x208
	private float previewAngle; // 0x210
	private Action previewAction; // 0x218
	private Action previewCloseAction; // 0x220
	private ItemData prevItemData; // 0x228
	private ItemData selectedItemData; // 0x230
	private Dictionary<UIItemScrollListManager.PreviewData, List<GameObject>> modelList; // 0x238
	private List<GameObject> activeModelList; // 0x240
	private GameObject faceModel; // 0x248
	private List<GameObject> hairModelList; // 0x250
	private List<GameObject> adventurerArmorModelList; // 0x258
	private PlayerDataManager playerDataManager; // 0x260
	private bool isPreviewIcon; // 0x268
	private bool isPreviewSword; // 0x269
	private Animation activeAnimation; // 0x270
	private float previewPressTime; // 0x278
	private bool isPreviewPress; // 0x27C
	private const float clickTime = 0.2;
	private string standAnimeName; // 0x280
	private Vector3 bodyPos; // 0x288
	private float bodyScale; // 0x294
	private Vector3 bowRotation; // 0x298
	private List<GameObject> loadModelObjList; // 0x2A8
	private UISprite[] modelColorPanel; // 0x2B0
	private UILabel modelNameLabel; // 0x2B8
	private bool isPreviewModelDelete; // 0x2C0
	private bool isPreviewInfluenceFull; // 0x2C1
	[CompilerGenerated]
	private bool <IsPreview>k__BackingField; // 0x2C2
	[SerializeField]
	private GameObject favoriteObj; // 0x2C8
	[SerializeField]
	private UISprite[] favoriteSprites; // 0x2D0
	private bool isFavoriteButton; // 0x2D8
	private Action favoriteAction; // 0x2E0
	[SerializeField]
	private UIIconBase dragIcon; // 0x2E8
	[SerializeField]
	private GameObject dragButton; // 0x2F0
	[SerializeField]
	private UIIconBase secondDragIcon; // 0x2F8
	[SerializeField]
	private GameObject secondDragButton; // 0x300
	private int activeUid; // 0x308

	// Properties
	public int ItemPanelNum { get; }
	public byte NowFilterType { get; }
	public byte LockFilterType { get; set; }
	public int FilterInventoryCapacity { get; }
	public int FilterInventoryViewItemNum { get; }
	public bool IsCameraStop { get; }
	public GameObject RightAnchorObject { get; }
	public UIScrollWindow ScrollWindow { get; }
	public UIItemProperty propertyPanel { get; set; }
	public GameObject LeftAnchorObject { get; }
	private int AnimeNum { get; }
	public bool IsPreview { get; set; }
	public bool IsActiveScrollText { set; }

	// Methods

	// RVA: 0x1E6D0F8 Offset: 0x1E690F8 VA: 0x1E6D0F8
	public int get_ItemPanelNum() { }

	// RVA: 0x1E6D100 Offset: 0x1E69100 VA: 0x1E6D100
	public void Initialize(UIItemScrollPanelManager manager, GameObject parentObj) { }

	// RVA: 0x1E6D1C4 Offset: 0x1E691C4 VA: 0x1E6D1C4
	public void Initialize(UIItemScrollPanelManager manager, int itemNum, GameObject parentObj) { }

	// RVA: 0x1E6DAD4 Offset: 0x1E69AD4 VA: 0x1E6DAD4
	private void Update() { }

	// RVA: 0x1E6E278 Offset: 0x1E6A278 VA: 0x1E6E278
	private void LateUpdate() { }

	// RVA: 0x1E6EA1C Offset: 0x1E6AA1C VA: 0x1E6EA1C
	private void OnDestroy() { }

	// RVA: 0x1E6EC68 Offset: 0x1E6AC68 VA: 0x1E6EC68
	public byte get_NowFilterType() { }

	[CompilerGenerated]
	// RVA: 0x1E6EC70 Offset: 0x1E6AC70 VA: 0x1E6EC70
	public byte get_LockFilterType() { }

	[CompilerGenerated]
	// RVA: 0x1E6EC78 Offset: 0x1E6AC78 VA: 0x1E6EC78
	private void set_LockFilterType(byte value) { }

	// RVA: 0x1E6EC80 Offset: 0x1E6AC80 VA: 0x1E6EC80
	public int get_FilterInventoryCapacity() { }

	// RVA: 0x1E6ED54 Offset: 0x1E6AD54 VA: 0x1E6ED54
	public int get_FilterInventoryViewItemNum() { }

	// RVA: 0x1E6EF40 Offset: 0x1E6AF40 VA: 0x1E6EF40
	public bool get_IsCameraStop() { }

	// RVA: 0x1E6EF48 Offset: 0x1E6AF48 VA: 0x1E6EF48
	public GameObject get_RightAnchorObject() { }

	// RVA: 0x1E6EF50 Offset: 0x1E6AF50 VA: 0x1E6EF50
	public UIScrollWindow get_ScrollWindow() { }

	// RVA: 0x1E6EF58 Offset: 0x1E6AF58 VA: 0x1E6EF58
	public void ItemPanelVacancyButton(int num) { }

	// RVA: 0x1E6F168 Offset: 0x1E6B168 VA: 0x1E6F168
	public void Clear() { }

	// RVA: 0x1E6F250 Offset: 0x1E6B250 VA: 0x1E6F250
	public void SetBagListPanelColor(Color color) { }

	// RVA: 0x1E6F270 Offset: 0x1E6B270 VA: 0x1E6F270
	public void ItemPanelButton(int locationId, ItemData data) { }

	// RVA: 0x1E6F278 Offset: 0x1E6B278 VA: 0x1E6F278
	public void ItemPanelButton(int locationId, ItemData data, bool enabled) { }

	// RVA: 0x1E6F504 Offset: 0x1E6B504 VA: 0x1E6F504
	public void ItemPanelAvatarButton(int locationId, ItemData data) { }

	// RVA: 0x1E6F88C Offset: 0x1E6B88C VA: 0x1E6F88C
	public void NewSlotPanelButton(int locationId) { }

	// RVA: 0x1E6FA88 Offset: 0x1E6BA88 VA: 0x1E6FA88
	public void ActiveItemSlotMessage(bool isDropLabel = True) { }

	// RVA: 0x1E6FB58 Offset: 0x1E6BB58 VA: 0x1E6FB58
	public bool UpdateUsedItemData(ItemManager itemManager) { }

	// RVA: 0x1E6D480 Offset: 0x1E69480 VA: 0x1E6D480
	public void ItemListButtonCreate() { }

	// RVA: 0x1E6FD98 Offset: 0x1E6BD98 VA: 0x1E6FD98
	public void ItemListButtonCreate(bool isAllUpdate, bool isDefaultScrollUpdate = False) { }

	// RVA: 0x1E70344 Offset: 0x1E6C344 VA: 0x1E70344
	public IUIItemScrollPanelButton[] GetItemButtons() { }

	// RVA: 0x1E7034C Offset: 0x1E6C34C VA: 0x1E7034C
	public IUIItemScrollPanelButton GetItemButton(int locationId) { }

	// RVA: 0x1E70420 Offset: 0x1E6C420 VA: 0x1E70420
	public void ItemPanelButtonEquipCheck(int locationId, bool flag) { }

	// RVA: 0x1E70500 Offset: 0x1E6C500 VA: 0x1E70500
	public void ItemPanelButtonQuestCheck(int locationId, bool flag) { }

	// RVA: 0x1E705E0 Offset: 0x1E6C5E0 VA: 0x1E705E0
	public void ItemPanelButtonNewItemCheck(int locationId, bool flag) { }

	// RVA: 0x1E706C0 Offset: 0x1E6C6C0 VA: 0x1E706C0
	public void ItemPanelButtonFavoriteCheck(int locationId, bool flag, bool isNewItem) { }

	// RVA: 0x1E707A8 Offset: 0x1E6C7A8 VA: 0x1E707A8
	private void OnRightButtonClick() { }

	// RVA: 0x1E70B40 Offset: 0x1E6CB40 VA: 0x1E70B40
	private void OnLeftButtonClick() { }

	// RVA: 0x1E6D48C Offset: 0x1E6948C VA: 0x1E6D48C
	public void UpdateCameraEnable(bool isEnable) { }

	// RVA: 0x1E70BEC Offset: 0x1E6CBEC VA: 0x1E70BEC
	public void UpdateScrollArea(int itemNum) { }

	// RVA: 0x1E70C7C Offset: 0x1E6CC7C VA: 0x1E70C7C
	public void ResetScrollCameraPos() { }

	// RVA: 0x1E70D00 Offset: 0x1E6CD00 VA: 0x1E70D00
	public void ResetScrollCameraPosX() { }

	// RVA: 0x1E70D8C Offset: 0x1E6CD8C VA: 0x1E70D8C
	public void OnFilter(int param) { }

	// RVA: 0x1E6D910 Offset: 0x1E69910 VA: 0x1E6D910
	private void UpdateFilterButton() { }

	// RVA: 0x1E6D56C Offset: 0x1E6956C VA: 0x1E6D56C
	public void UpdateInvenrtyButtonCount() { }

	// RVA: 0x1E70EC0 Offset: 0x1E6CEC0 VA: 0x1E70EC0
	public void SetInvenrtyButtonCount(int[] nums) { }

	// RVA: 0x1E712F0 Offset: 0x1E6D2F0 VA: 0x1E712F0
	public void ClearInvenrtyButtonCount() { }

	// RVA: 0x1E712F4 Offset: 0x1E6D2F4 VA: 0x1E712F4
	public bool CheckItemDataTypeFilter(ItemDataTypev2 dataType) { }

	// RVA: 0x1E71328 Offset: 0x1E6D328 VA: 0x1E71328
	public void SetLockFilter(byte lockFilter) { }

	// RVA: 0x1E71334 Offset: 0x1E6D334 VA: 0x1E71334
	public void ScrollCameraMoveStop(bool isStop) { }

	// RVA: 0x1E71390 Offset: 0x1E6D390 VA: 0x1E71390
	public void UpdateItemPanelNum(int itemPanelNum, bool isDefaultScrollUpdate = False) { }

	// RVA: 0x1E713A4 Offset: 0x1E6D3A4 VA: 0x1E713A4
	public void OnOrganize() { }

	// RVA: 0x1E7148C Offset: 0x1E6D48C VA: 0x1E7148C
	public void ResetOrganizeButton() { }

	// RVA: 0x1E71494 Offset: 0x1E6D494 VA: 0x1E71494
	private void UpdateOrganizeButton() { }

	[IteratorStateMachine(typeof(UIItemScrollListManager.<OrganizeProcess>d__94))]
	// RVA: 0x1E71418 Offset: 0x1E6D418 VA: 0x1E71418
	private IEnumerator OrganizeProcess() { }

	[CompilerGenerated]
	// RVA: 0x1E714C0 Offset: 0x1E6D4C0 VA: 0x1E714C0
	public UIItemProperty get_propertyPanel() { }

	[CompilerGenerated]
	// RVA: 0x1E714C8 Offset: 0x1E6D4C8 VA: 0x1E714C8
	private void set_propertyPanel(UIItemProperty value) { }

	// RVA: 0x1E714D8 Offset: 0x1E6D4D8 VA: 0x1E714D8
	public GameObject get_LeftAnchorObject() { }

	// RVA: 0x1E714E0 Offset: 0x1E6D4E0 VA: 0x1E714E0
	private int get_AnimeNum() { }

	[CompilerGenerated]
	// RVA: 0x1E714EC Offset: 0x1E6D4EC VA: 0x1E714EC
	public bool get_IsPreview() { }

	[CompilerGenerated]
	// RVA: 0x1E714F4 Offset: 0x1E6D4F4 VA: 0x1E714F4
	private void set_IsPreview(bool value) { }

	// RVA: 0x1E71500 Offset: 0x1E6D500 VA: 0x1E71500
	public void set_IsActiveScrollText(bool value) { }

	// RVA: 0x1E715E0 Offset: 0x1E6D5E0 VA: 0x1E715E0
	private void Awake() { }

	// RVA: 0x1E6E3EC Offset: 0x1E6A3EC VA: 0x1E6E3EC
	private void PropertyPanelCheck(UIItemScrollListManager.PropertyPanelState state) { }

	// RVA: 0x1E72118 Offset: 0x1E6E118 VA: 0x1E72118
	public void SelectItem(ItemData itemData) { }

	// RVA: 0x1E72170 Offset: 0x1E6E170 VA: 0x1E72170
	public void SelectItem(ItemData itemData, string text) { }

	// RVA: 0x1E72B14 Offset: 0x1E6EB14 VA: 0x1E72B14
	public void TopLabel(string text) { }

	// RVA: 0x1E72094 Offset: 0x1E6E094 VA: 0x1E72094
	public void ButtonLabel(string text) { }

	// RVA: 0x1E72C74 Offset: 0x1E6EC74 VA: 0x1E72C74
	private void OnChangeClick() { }

	// RVA: 0x1E72D18 Offset: 0x1E6ED18 VA: 0x1E72D18
	public void ChangeActiveScrollCamera(bool isActive) { }

	// RVA: 0x1E6DD94 Offset: 0x1E69D94 VA: 0x1E6DD94
	private void UpdateElementActive() { }

	// RVA: 0x1E72DBC Offset: 0x1E6EDBC VA: 0x1E72DBC
	private GameObject CreateButton(GameObject buttonObj, Transform parent, int i) { }

	// RVA: 0x1E72F3C Offset: 0x1E6EF3C VA: 0x1E72F3C
	public void SetPreviewAction(Action action, Action closeAction) { }

	// RVA: 0x1E72F70 Offset: 0x1E6EF70 VA: 0x1E72F70
	public void SetPreviewIconActive(bool isActive) { }

	// RVA: 0x1E72F7C Offset: 0x1E6EF7C VA: 0x1E72F7C
	public bool ClosePreviewAction() { }

	// RVA: 0x1E73000 Offset: 0x1E6F000 VA: 0x1E73000
	public void ClosePreview() { }

	// RVA: 0x1E7307C Offset: 0x1E6F07C VA: 0x1E7307C
	public void ChangeModelDeleteFlag(bool isFlag) { }

	// RVA: 0x1E73088 Offset: 0x1E6F088 VA: 0x1E73088
	public void ChangeInfluenceFull(bool isFlag) { }

	// RVA: 0x1E70854 Offset: 0x1E6C854 VA: 0x1E70854
	public void ChangePagePreviewProcess() { }

	// RVA: 0x1E733B0 Offset: 0x1E6F3B0 VA: 0x1E733B0
	private void OnGlassIconClick() { }

	// RVA: 0x1E70104 Offset: 0x1E6C104 VA: 0x1E70104
	private void SwitchPreviewWindow() { }

	// RVA: 0x1E73414 Offset: 0x1E6F414 VA: 0x1E73414
	private void OnPreviewPress() { }

	// RVA: 0x1E73420 Offset: 0x1E6F420 VA: 0x1E73420
	private void OnPreviewRelease() { }

	// RVA: 0x1E73454 Offset: 0x1E6F454 VA: 0x1E73454
	private void OnPreviewClick() { }

	// RVA: 0x1E71A98 Offset: 0x1E6DA98 VA: 0x1E71A98
	private void ChangeModelPropEnable(bool isEnable) { }

	[IteratorStateMachine(typeof(UIItemScrollListManager.<LoadModel>d__198))]
	// RVA: 0x1E72970 Offset: 0x1E6E970 VA: 0x1E72970
	private IEnumerator LoadModel(ItemData itemData) { }

	[IteratorStateMachine(typeof(UIItemScrollListManager.<LoadWeaponModel>d__199))]
	// RVA: 0x1E73948 Offset: 0x1E6F948 VA: 0x1E73948
	private IEnumerator LoadWeaponModel(ItemData itemData) { }

	[IteratorStateMachine(typeof(UIItemScrollListManager.<LoadArmorModel>d__200))]
	// RVA: 0x1E739D8 Offset: 0x1E6F9D8 VA: 0x1E739D8
	private IEnumerator LoadArmorModel(ItemData itemData) { }

	[IteratorStateMachine(typeof(UIItemScrollListManager.<LoadOptionModel>d__201))]
	// RVA: 0x1E73A68 Offset: 0x1E6FA68 VA: 0x1E73A68
	private IEnumerator LoadOptionModel(ItemData itemData) { }

	[IteratorStateMachine(typeof(UIItemScrollListManager.<LoadAvatarModel>d__202))]
	// RVA: 0x1E73AF8 Offset: 0x1E6FAF8 VA: 0x1E73AF8
	private IEnumerator LoadAvatarModel(ItemData itemData) { }

	[IteratorStateMachine(typeof(UIItemScrollListManager.<LoadAvatarOptionModel>d__203))]
	// RVA: 0x1E73B88 Offset: 0x1E6FB88 VA: 0x1E73B88
	private IEnumerator LoadAvatarOptionModel(ItemData itemData) { }

	[IteratorStateMachine(typeof(UIItemScrollListManager.<LoadFaceModel>d__204))]
	// RVA: 0x1E73C18 Offset: 0x1E6FC18 VA: 0x1E73C18
	private IEnumerator LoadFaceModel() { }

	[IteratorStateMachine(typeof(UIItemScrollListManager.<LoadHairModel>d__205))]
	// RVA: 0x1E73C8C Offset: 0x1E6FC8C VA: 0x1E73C8C
	private IEnumerator LoadHairModel(MasterModelDataManager.OptionModelFlag optionFlag) { }

	[IteratorStateMachine(typeof(UIItemScrollListManager.<LoadModelObj>d__206))]
	// RVA: 0x1E73D10 Offset: 0x1E6FD10 VA: 0x1E73D10
	private IEnumerator LoadModelObj(ModelManager.LoadModelType type, int modelId, string filePath, Action<bool, GameObject> callBack) { }

	// RVA: 0x1E73DC8 Offset: 0x1E6FDC8 VA: 0x1E73DC8
	private void ModelSetting(GameObject obj) { }

	// RVA: 0x1E73FD8 Offset: 0x1E6FFD8 VA: 0x1E73FD8
	private void SetModelBaseColor(GameObject obj) { }

	// RVA: 0x1E74114 Offset: 0x1E70114 VA: 0x1E74114
	private void SetModelColor(GameObject obj, byte rColor, byte gColor, byte bColor) { }

	// RVA: 0x1E73750 Offset: 0x1E6F750 VA: 0x1E73750
	public static bool IsSwordAnimation(ItemType type) { }

	// RVA: 0x1E7378C Offset: 0x1E6F78C VA: 0x1E7378C
	public static string[] GetAnimationName(ItemType type) { }

	// RVA: 0x1E74534 Offset: 0x1E70534 VA: 0x1E74534
	private Vector3 PreviewWeaponPos(ItemType type) { }

	// RVA: 0x1E74578 Offset: 0x1E70578 VA: 0x1E74578
	private Vector3 PreviewWeaponScale(ItemType type) { }

	// RVA: 0x1E73094 Offset: 0x1E6F094 VA: 0x1E73094
	private void DestroyAllModel() { }

	// RVA: 0x1E74634 Offset: 0x1E70634 VA: 0x1E74634
	private void SwitchFaceHairBodyModel(bool isActive) { }

	// RVA: 0x1E748C8 Offset: 0x1E708C8 VA: 0x1E748C8
	private void SwitchFaceHairBodyModel(ItemData itemData) { }

	// RVA: 0x1E7520C Offset: 0x1E7120C VA: 0x1E7520C
	public void OnFavorite() { }

	// RVA: 0x1E72A00 Offset: 0x1E6EA00 VA: 0x1E72A00
	public void UpdateFavoriteIcon(bool isFavorite) { }

	// RVA: 0x1E75230 Offset: 0x1E71230 VA: 0x1E75230
	public void ChangeActiveFavoriteButton(bool isActive) { }

	// RVA: 0x1E7523C Offset: 0x1E7123C VA: 0x1E7523C
	public void SetFavoriteAction(Action action) { }

	// RVA: 0x1E7524C Offset: 0x1E7124C VA: 0x1E7524C
	private void SetDragObjectActive(bool flag) { }

	// RVA: 0x1E7547C Offset: 0x1E7147C VA: 0x1E7547C
	public bool ActiveDragItem(ItemData itemData, Vector3 dragPoint) { }

	// RVA: 0x1E755B8 Offset: 0x1E715B8 VA: 0x1E755B8
	public bool DragCheckDist(Vector3 position, float r) { }

	// RVA: 0x1E7569C Offset: 0x1E7169C VA: 0x1E7569C
	public bool MoveDragItem(int uuid, Vector3 pos, Vector3 secondPos) { }

	// RVA: 0x1E75750 Offset: 0x1E71750 VA: 0x1E75750
	public bool ReleaseDragItem(int uuid) { }

	// RVA: 0x1E75790 Offset: 0x1E71790 VA: 0x1E75790
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1E75A50 Offset: 0x1E71A50 VA: 0x1E75A50
	private void <OrganizeProcess>b__94_0() { }

	[CompilerGenerated]
	// RVA: 0x1E75A74 Offset: 0x1E71A74 VA: 0x1E75A74
	private void <OrganizeProcess>b__94_1() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIItemListManager : MonoBehaviour // TypeDefIndex: 8959
{
	// Fields
	private UIIItemPanelManager manager; // 0x20
	private ItemTextManager itemTextManager; // 0x28
	private SystemTextManager systemTextManager; // 0x30
	private int itemPanelNum; // 0x38
	private UIItemPanelButton[] buttonListS; // 0x40
	[SerializeField]
	private GameObject baseButton; // 0x48
	[SerializeField]
	private UILabel bagNameLabel; // 0x50
	[SerializeField]
	private GameObject bagIconObj; // 0x58
	[SerializeField]
	private UISprite itemListPanelBackSprite; // 0x60
	[SerializeField]
	private GameObject rightAnchorObject; // 0x68
	private UIItemListManager.PropertyPanelState panelState; // 0x70
	public bool Close; // 0x74
	public bool Check; // 0x75
	public bool Full; // 0x76
	[SerializeField]
	private GameObject propertyPanelTop; // 0x78
	[SerializeField]
	private UILabel propertyPanelItemLabel; // 0x80
	[SerializeField]
	private UILabel propertyPanelNumLabel; // 0x88
	[SerializeField]
	private UIIcon propertyPanelItemIcon; // 0x90
	[SerializeField]
	private GameObject propertyPanelButton; // 0x98
	[SerializeField]
	private UISprite propertyPanelButtonIcon; // 0xA0
	[SerializeField]
	private UILabel propertyPanelButtonLabel; // 0xA8
	[SerializeField]
	private GameObject propertyPanelBackground; // 0xB0
	[SerializeField]
	private GameObject propertyPanelTopObject; // 0xB8
	[SerializeField]
	private UIScrollBar propertyPanelTextBar; // 0xC0
	[SerializeField]
	private Transform scrollTopBar; // 0xC8
	[SerializeField]
	private Transform scrollBottomBar; // 0xD0
	[SerializeField]
	private Camera scrollCamera; // 0xD8
	private UIIruna2Viewport scrollView; // 0xE0
	private SpringPosition scrollSpringPosition; // 0xE8
	[SerializeField]
	private GameObject propertyPanelObject; // 0xF0
	[CompilerGenerated]
	private UIItemProperty <propertyPanel>k__BackingField; // 0xF8
	private float scrollHeight; // 0x100
	[SerializeField]
	private GameObject leftAnchorObject; // 0x108
	private UIIruna2Anchor leftAnchor; // 0x110
	[SerializeField]
	private GameObject glassIconObj; // 0x118
	[SerializeField]
	private UIIruna2Anchor modelAnchoerObj; // 0x120
	[SerializeField]
	private GameObject previewCamera; // 0x128
	[SerializeField]
	private GameObject modelParentObj; // 0x130
	[SerializeField]
	private UIIruna2DragPinch dragPinch; // 0x138
	[SerializeField]
	private GameObject modelPropObj; // 0x140
	private float previewAngle; // 0x148
	private Action previewAction; // 0x150
	private Action previewCloseAction; // 0x158
	private ItemData prevItemData; // 0x160
	private ItemData selectedItemData; // 0x168
	private Dictionary<UIItemListManager.PreviewData, List<GameObject>> modelList; // 0x170
	private List<GameObject> activeModelList; // 0x178
	private GameObject faceModel; // 0x180
	private List<GameObject> hairModelList; // 0x188
	private List<GameObject> adventurerArmorModelList; // 0x190
	private PlayerDataManager playerDataManager; // 0x198
	private bool isPreviewIcon; // 0x1A0
	private bool isPreviewSword; // 0x1A1
	private Animation activeAnimation; // 0x1A8
	private float previewPressTime; // 0x1B0
	private bool isPreviewPress; // 0x1B4
	private const float clickTime = 0.2;
	private string standAnimeName; // 0x1B8
	private Vector3 bodyPos; // 0x1C0
	private float bodyScale; // 0x1CC
	private Vector3 bowRotation; // 0x1D0
	private List<GameObject> loadModelObjList; // 0x1E0
	private UISprite[] modelColorPanel; // 0x1E8
	private UILabel modelNameLabel; // 0x1F0
	private bool isPreviewModelDelete; // 0x1F8
	private bool isPreviewInfluenceFull; // 0x1F9
	[CompilerGenerated]
	private bool <IsPreview>k__BackingField; // 0x1FA

	// Properties
	public GameObject RightAnchorObject { get; }
	public UIItemProperty propertyPanel { get; set; }
	public GameObject LeftAnchorObject { get; }
	private int AnimeNum { get; }
	public bool IsPreview { get; set; }
	public bool IsActiveScrollText { set; }

	// Methods

	// RVA: 0x1E5E734 Offset: 0x1E5A734 VA: 0x1E5E734
	public static bool CheckEquipItem(ItemDBData.ItemType type) { }

	// RVA: 0x1E5E744 Offset: 0x1E5A744 VA: 0x1E5E744
	public static bool CheckAvatarEquipItem(ItemDBData.ItemType type) { }

	// RVA: 0x1E5E754 Offset: 0x1E5A754 VA: 0x1E5E754
	public static bool CheckWeaponItem(ItemDBData.ItemType type) { }

	// RVA: 0x1E5E780 Offset: 0x1E5A780 VA: 0x1E5E780
	public static bool CheckCristaItem(ItemDBData.ItemType type) { }

	// RVA: 0x1E5E7A4 Offset: 0x1E5A7A4 VA: 0x1E5E7A4
	public static bool CheckPowerCristaItem(ItemDBData.ItemType type) { }

	// RVA: 0x1E5E7B4 Offset: 0x1E5A7B4 VA: 0x1E5E7B4
	public static bool CheckUseItem(ItemDBData.ItemType type) { }

	// RVA: 0x1E5E7E4 Offset: 0x1E5A7E4 VA: 0x1E5E7E4
	public void Initialize(UIIItemPanelManager manager) { }

	// RVA: 0x1E5E7EC Offset: 0x1E5A7EC VA: 0x1E5E7EC
	public void Initialize(UIIItemPanelManager manager, int itemNum) { }

	// RVA: 0x1E5EC98 Offset: 0x1E5AC98 VA: 0x1E5EC98
	private void Update() { }

	// RVA: 0x1E5EDFC Offset: 0x1E5ADFC VA: 0x1E5EDFC
	private void LateUpdate() { }

	// RVA: 0x1E5F460 Offset: 0x1E5B460 VA: 0x1E5F460
	private void OnDestroy() { }

	// RVA: 0x1E5F608 Offset: 0x1E5B608 VA: 0x1E5F608
	public GameObject get_RightAnchorObject() { }

	// RVA: 0x1E5F610 Offset: 0x1E5B610 VA: 0x1E5F610
	public void ItemPanelVacancyButton(int num) { }

	// RVA: 0x1E5FBEC Offset: 0x1E5BBEC VA: 0x1E5FBEC
	public void Clear() { }

	// RVA: 0x1E5FC48 Offset: 0x1E5BC48 VA: 0x1E5FC48
	public void SetBagName(string text) { }

	// RVA: 0x1E5FCE0 Offset: 0x1E5BCE0 VA: 0x1E5FCE0
	public void SetBagListPanelColor(Color color) { }

	// RVA: 0x1E5FD00 Offset: 0x1E5BD00 VA: 0x1E5FD00
	public void ItemPanelButton(int locationId, ItemData data) { }

	// RVA: 0x1E5FD08 Offset: 0x1E5BD08 VA: 0x1E5FD08
	public void ItemPanelButton(int locationId, ItemData data, bool enabled) { }

	// RVA: 0x1E60064 Offset: 0x1E5C064 VA: 0x1E60064
	public void ItemPanelDetachButton(int locationId, ItemData data) { }

	// RVA: 0x1E603D4 Offset: 0x1E5C3D4 VA: 0x1E603D4
	public void ItemPanelAvatarButton(int locationId, ItemData data) { }

	// RVA: 0x1E6098C Offset: 0x1E5C98C VA: 0x1E6098C
	public void NewSlotPanelButton(int locationId) { }

	// RVA: 0x1E5E9C8 Offset: 0x1E5A9C8 VA: 0x1E5E9C8
	public void ItemListButtonCreate() { }

	// RVA: 0x1E60DF8 Offset: 0x1E5CDF8 VA: 0x1E60DF8
	public UIItemPanelButton[] GetItemButtons() { }

	// RVA: 0x1E60E00 Offset: 0x1E5CE00 VA: 0x1E60E00
	public void ItemPanelButtonEquipCheck(int locationId, bool flag) { }

	// RVA: 0x1E60ED8 Offset: 0x1E5CED8 VA: 0x1E60ED8
	public void ItemPanelButtonQuestCheck(int locationId, bool flag) { }

	// RVA: 0x1E6107C Offset: 0x1E5D07C VA: 0x1E6107C
	public int ItemDragListCheck(UIItemPanelButton select) { }

	// RVA: 0x1E61204 Offset: 0x1E5D204 VA: 0x1E61204
	public void SetBagIconEnable(bool isEnable) { }

	// RVA: 0x1E61224 Offset: 0x1E5D224 VA: 0x1E61224
	private void OnRightButtonClick() { }

	// RVA: 0x1E615BC Offset: 0x1E5D5BC VA: 0x1E615BC
	private void OnLeftButtonClick() { }

	[CompilerGenerated]
	// RVA: 0x1E61668 Offset: 0x1E5D668 VA: 0x1E61668
	public UIItemProperty get_propertyPanel() { }

	[CompilerGenerated]
	// RVA: 0x1E61670 Offset: 0x1E5D670 VA: 0x1E61670
	private void set_propertyPanel(UIItemProperty value) { }

	// RVA: 0x1E61678 Offset: 0x1E5D678 VA: 0x1E61678
	public GameObject get_LeftAnchorObject() { }

	// RVA: 0x1E61680 Offset: 0x1E5D680 VA: 0x1E61680
	private int get_AnimeNum() { }

	[CompilerGenerated]
	// RVA: 0x1E6168C Offset: 0x1E5D68C VA: 0x1E6168C
	public bool get_IsPreview() { }

	[CompilerGenerated]
	// RVA: 0x1E61694 Offset: 0x1E5D694 VA: 0x1E61694
	private void set_IsPreview(bool value) { }

	// RVA: 0x1E616A0 Offset: 0x1E5D6A0 VA: 0x1E616A0
	public void set_IsActiveScrollText(bool value) { }

	// RVA: 0x1E61780 Offset: 0x1E5D780 VA: 0x1E61780
	private void Awake() { }

	// RVA: 0x1E5EE30 Offset: 0x1E5AE30 VA: 0x1E5EE30
	private void PropertyPanelCheck(UIItemListManager.PropertyPanelState state) { }

	// RVA: 0x1E61F1C Offset: 0x1E5DF1C VA: 0x1E61F1C
	public void SelectItem(ItemData itemData) { }

	// RVA: 0x1E61F74 Offset: 0x1E5DF74 VA: 0x1E61F74
	public void SelectItem(ItemData itemData, string text) { }

	// RVA: 0x1E629B4 Offset: 0x1E5E9B4 VA: 0x1E629B4
	public void TopLabel(string text) { }

	// RVA: 0x1E61E98 Offset: 0x1E5DE98 VA: 0x1E61E98
	public void ButtonLabel(string text) { }

	// RVA: 0x1E62AD8 Offset: 0x1E5EAD8 VA: 0x1E62AD8
	private void OnChangeClick() { }

	// RVA: 0x1E62B7C Offset: 0x1E5EB7C VA: 0x1E62B7C
	public void SetPreviewAction(Action action, Action closeAction) { }

	// RVA: 0x1E62BB0 Offset: 0x1E5EBB0 VA: 0x1E62BB0
	public void SetPreviewIconActive(bool isActive) { }

	// RVA: 0x1E62BBC Offset: 0x1E5EBBC VA: 0x1E62BBC
	public bool ClosePreviewAction() { }

	// RVA: 0x1E62C40 Offset: 0x1E5EC40 VA: 0x1E62C40
	public void ClosePreview() { }

	// RVA: 0x1E62CBC Offset: 0x1E5ECBC VA: 0x1E62CBC
	public void ChangeModelDeleteFlag(bool isFlag) { }

	// RVA: 0x1E62CC8 Offset: 0x1E5ECC8 VA: 0x1E62CC8
	public void ChangeInfluenceFull(bool isFlag) { }

	// RVA: 0x1E612D0 Offset: 0x1E5D2D0 VA: 0x1E612D0
	public void ChangePagePreviewProcess() { }

	// RVA: 0x1E62FF0 Offset: 0x1E5EFF0 VA: 0x1E62FF0
	private void OnGlassIconClick() { }

	// RVA: 0x1E626C8 Offset: 0x1E5E6C8 VA: 0x1E626C8
	private void SwitchPreviewWindow() { }

	// RVA: 0x1E63054 Offset: 0x1E5F054 VA: 0x1E63054
	private void OnPreviewPress() { }

	// RVA: 0x1E63060 Offset: 0x1E5F060 VA: 0x1E63060
	private void OnPreviewRelease() { }

	// RVA: 0x1E63094 Offset: 0x1E5F094 VA: 0x1E63094
	private void OnPreviewClick() { }

	// RVA: 0x1E618EC Offset: 0x1E5D8EC VA: 0x1E618EC
	private void ChangeModelPropEnable(bool isEnable) { }

	[IteratorStateMachine(typeof(UIItemListManager.<LoadModel>d__131))]
	// RVA: 0x1E6292C Offset: 0x1E5E92C VA: 0x1E6292C
	private IEnumerator LoadModel(ItemData itemData) { }

	[IteratorStateMachine(typeof(UIItemListManager.<LoadWeaponModel>d__132))]
	// RVA: 0x1E634B8 Offset: 0x1E5F4B8 VA: 0x1E634B8
	private IEnumerator LoadWeaponModel(ItemData itemData) { }

	[IteratorStateMachine(typeof(UIItemListManager.<LoadArmorModel>d__133))]
	// RVA: 0x1E63568 Offset: 0x1E5F568 VA: 0x1E63568
	private IEnumerator LoadArmorModel(ItemData itemData) { }

	[IteratorStateMachine(typeof(UIItemListManager.<LoadOptionModel>d__134))]
	// RVA: 0x1E63618 Offset: 0x1E5F618 VA: 0x1E63618
	private IEnumerator LoadOptionModel(ItemData itemData) { }

	[IteratorStateMachine(typeof(UIItemListManager.<LoadAvatarModel>d__135))]
	// RVA: 0x1E636C8 Offset: 0x1E5F6C8 VA: 0x1E636C8
	private IEnumerator LoadAvatarModel(ItemData itemData) { }

	[IteratorStateMachine(typeof(UIItemListManager.<LoadAvatarOptionModel>d__136))]
	// RVA: 0x1E63778 Offset: 0x1E5F778 VA: 0x1E63778
	private IEnumerator LoadAvatarOptionModel(ItemData itemData) { }

	[IteratorStateMachine(typeof(UIItemListManager.<LoadFaceModel>d__137))]
	// RVA: 0x1E63828 Offset: 0x1E5F828 VA: 0x1E63828
	private IEnumerator LoadFaceModel() { }

	[IteratorStateMachine(typeof(UIItemListManager.<LoadHairModel>d__138))]
	// RVA: 0x1E638BC Offset: 0x1E5F8BC VA: 0x1E638BC
	private IEnumerator LoadHairModel(MasterModelDataManager.OptionModelFlag optionFlag) { }

	[IteratorStateMachine(typeof(UIItemListManager.<LoadModelObj>d__139))]
	// RVA: 0x1E63960 Offset: 0x1E5F960 VA: 0x1E63960
	private IEnumerator LoadModelObj(ModelManager.LoadModelType type, int modelId, string filePath, Action<bool, GameObject> callBack) { }

	// RVA: 0x1E63A38 Offset: 0x1E5FA38 VA: 0x1E63A38
	private void ModelSetting(GameObject obj) { }

	// RVA: 0x1E63C30 Offset: 0x1E5FC30 VA: 0x1E63C30
	private void SetModelBaseColor(GameObject obj) { }

	// RVA: 0x1E63D6C Offset: 0x1E5FD6C VA: 0x1E63D6C
	private void SetModelColor(GameObject obj, byte rColor, byte gColor, byte bColor) { }

	// RVA: 0x1E63298 Offset: 0x1E5F298 VA: 0x1E63298
	public static bool IsSwordAnimation(ItemType type) { }

	// RVA: 0x1E632D4 Offset: 0x1E5F2D4 VA: 0x1E632D4
	public static string[] GetAnimationName(ItemType type) { }

	// RVA: 0x1E6418C Offset: 0x1E6018C VA: 0x1E6418C
	private Vector3 PreviewWeaponPos(ItemType type) { }

	// RVA: 0x1E641D0 Offset: 0x1E601D0 VA: 0x1E641D0
	private Vector3 PreviewWeaponScale(ItemType type) { }

	// RVA: 0x1E62CD4 Offset: 0x1E5ECD4 VA: 0x1E62CD4
	private void DestroyAllModel() { }

	// RVA: 0x1E6428C Offset: 0x1E6028C VA: 0x1E6428C
	private void SwitchFaceHairBodyModel(bool isActive) { }

	// RVA: 0x1E64520 Offset: 0x1E60520 VA: 0x1E64520
	private void SwitchFaceHairBodyModel(ItemData itemData) { }

	// RVA: 0x1E64EE0 Offset: 0x1E60EE0 VA: 0x1E64EE0
	private void StartFaceHairBodyAnimation(ItemData itemData) { }

	// RVA: 0x1E6520C Offset: 0x1E6120C VA: 0x1E6520C
	public void .ctor() { }
}

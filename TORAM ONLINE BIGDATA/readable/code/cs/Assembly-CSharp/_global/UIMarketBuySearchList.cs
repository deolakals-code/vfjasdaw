// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMarketBuySearchList : MonoBehaviour // TypeDefIndex: 8429
{
	// Fields
	private readonly float elementHeight; // 0x20
	[SerializeField]
	private UIMarketBuySearchElement addElementOriginal; // 0x28
	[SerializeField]
	private UIScrollWindow scroll; // 0x30
	[SerializeField]
	private UIItemPropertyStretch property; // 0x38
	[SerializeField]
	private Transform modelParent; // 0x40
	[SerializeField]
	private UILabel detailCantViewModelLabel; // 0x48
	[SerializeField]
	private GameObject backWindow; // 0x50
	[SerializeField]
	private UIIruna2DragPinch modelDrag; // 0x58
	[SerializeField]
	private BoxCollider[] pageCollider; // 0x60
	[SerializeField]
	private GameObject[] checkDisableObjects; // 0x68
	[SerializeField]
	private UIMarketBuyCheckWindow checkWindow; // 0x70
	[SerializeField]
	private UIMarketBuyCompleteWindow completeWindow; // 0x78
	[SerializeField]
	private GameObject[] modelCheckButtonObjs; // 0x80
	[SerializeField]
	private UISprite backColorButton; // 0x88
	[SerializeField]
	private UISprite backColorPanel; // 0x90
	[SerializeField]
	private GameObject previewChagneButtonObj; // 0x98
	[SerializeField]
	private UILabel modelNameLabel; // 0xA0
	[SerializeField]
	private GameObject modelCustomPanel; // 0xA8
	[SerializeField]
	private UILabel modelCustomLabel; // 0xB0
	[SerializeField]
	private UILabel pageNumLabel; // 0xB8
	[SerializeField]
	private GameObject NonItemLabel; // 0xC0
	private List<UIMarketProductData> productList; // 0xC8
	private Dictionary<int, UIMarketBuySearchElement> elementList; // 0xD0
	private Dictionary<byte, byte> countryRateList; // 0xD8
	private List<GameObject> modelList; // 0xE0
	private PlayerDataManager playerDataManager; // 0xE8
	private UIMarketControl topControl; // 0xF0
	private SystemTextManager systemTextManager; // 0xF8
	private bool isDuringInitializeScroll; // 0x100
	private MarketType currentMarketType; // 0x104
	private MarketOrderType currentOrderType; // 0x108
	private int currentItemId; // 0x10C
	private ItemType currentItemType; // 0x110
	private GameObject petModelObject; // 0x118
	private Transform petModelParent; // 0x120
	private ItemData cageItem; // 0x128
	private PetModelLoader petModelLoader; // 0x130
	private Color[] backPanelColor; // 0x138
	private int backColor; // 0x140
	public const int capMax = 8;
	private bool isEquipOption; // 0x144
	private MarketProductList.EnumOptionsSlot currentOptionSlot; // 0x145
	private MarketProductList.EnumOptionsParts currentOptionParts; // 0x146
	private byte currentOptionColor; // 0x147
	private int currentModelId; // 0x148
	private short currentCapId; // 0x14C
	private short currentRProperty; // 0x14E
	private bool isPetSearch; // 0x150
	private int currentPetId; // 0x154
	private UIPopBaseWindow skillPopWindow; // 0x158
	private bool isSkillPopWindow; // 0x160
	private GameObject skillIconObj; // 0x168
	private GameObject previewObj; // 0x170
	private const float previewScale = 125;
	private bool isPreviewPress; // 0x178
	private float previewPressTime; // 0x17C
	private const float clickTime = 0.2;
	private bool isPreviewSword; // 0x180
	private Animation activePreviewAnimation; // 0x188
	private List<Animation> activeNormalAnimationList; // 0x190
	private string attackAnimeName; // 0x198
	private ItemType previewItemType; // 0x1A0
	private ItemTextManager itemTextManager; // 0x1A8
	private int selectElementId; // 0x1B0
	private ItemData showModelItemData; // 0x1B8
	private short nowPage; // 0x1C0
	private byte nowMaxPage; // 0x1C2
	private const byte MaxPage = 30;
	private UIImageButton[] topButtons; // 0x1C8
	private float pageButtonIntervalTimer; // 0x1D0
	private const float IntervalTime = 2;
	private const byte SkipPageNum = 10;
	private const float DefaultScrollDepth = 6;
	private List<GameObject> loadModelObjList; // 0x1D8
	private bool isModelLoading; // 0x1E0

	// Properties
	private int AnimeNum { get; }
	private bool isPreviewWeapon { get; }
	private byte NowPageNum { get; }
	private byte NowMaxPageNum { get; }

	// Methods

	// RVA: 0x1D3C40C Offset: 0x1D3840C VA: 0x1D3C40C
	private int get_AnimeNum() { }

	// RVA: 0x1D3C418 Offset: 0x1D38418 VA: 0x1D3C418
	private bool get_isPreviewWeapon() { }

	// RVA: 0x1D3C4A0 Offset: 0x1D384A0 VA: 0x1D3C4A0
	private byte get_NowPageNum() { }

	// RVA: 0x1D3C50C Offset: 0x1D3850C VA: 0x1D3C50C
	private byte get_NowMaxPageNum() { }

	// RVA: 0x1D3C578 Offset: 0x1D38578 VA: 0x1D3C578
	private void Awake() { }

	// RVA: 0x1D3CA2C Offset: 0x1D38A2C VA: 0x1D3CA2C
	private void Start() { }

	// RVA: 0x1D3CA30 Offset: 0x1D38A30 VA: 0x1D3CA30
	private void Update() { }

	// RVA: 0x1D3D744 Offset: 0x1D39744 VA: 0x1D3D744
	private void OnDisable() { }

	// RVA: 0x1D3D7C4 Offset: 0x1D397C4 VA: 0x1D3D7C4
	private void OnDestroy() { }

	// RVA: 0x1D3CB9C Offset: 0x1D38B9C VA: 0x1D3CB9C
	private void updateModelRotate() { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<Initialize>d__90))]
	// RVA: 0x1D33C08 Offset: 0x1D2FC08 VA: 0x1D33C08
	public IEnumerator Initialize(MarketType marketType, MarketOrderType ordertype, int itemid, ItemType type, UIMarketControl control) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<getProductList>d__91))]
	// RVA: 0x1D3D994 Offset: 0x1D39994 VA: 0x1D3D994
	private IEnumerator getProductList(MarketType marketType, MarketOrderType orderType, int itemid, ItemType type) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<Initialize>d__92))]
	// RVA: 0x1D33A54 Offset: 0x1D2FA54 VA: 0x1D33A54
	public IEnumerator Initialize(MarketType marketType, MarketOrderType ordertype, int itemid, ItemType type, MarketProductList.EnumOptionsSlot slot, byte color, MarketProductList.EnumOptionsParts parts, int modelId, short capId, short rProperty, UIMarketControl control) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<getProductList>d__93))]
	// RVA: 0x1D3DA7C Offset: 0x1D39A7C VA: 0x1D3DA7C
	private IEnumerator getProductList(MarketType marketType, MarketOrderType orderType, int itemid, ItemType type, MarketProductList.EnumOptionsSlot slot, byte color, MarketProductList.EnumOptionsParts parts, int modelId, short capId, short rProperty) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<Initialize>d__94))]
	// RVA: 0x1D33B50 Offset: 0x1D2FB50 VA: 0x1D33B50
	public IEnumerator Initialize(MarketType marketType, MarketOrderType ordertype, int itemid, ItemType type, int petId, UIMarketControl control) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<getProductList>d__95))]
	// RVA: 0x1D3DB90 Offset: 0x1D39B90 VA: 0x1D3DB90
	private IEnumerator getProductList(MarketType marketType, MarketOrderType orderType, int itemid, ItemType type, int petId) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<initializeScroll>d__96))]
	// RVA: 0x1D3DC3C Offset: 0x1D39C3C VA: 0x1D3DC3C
	private IEnumerator initializeScroll() { }

	// RVA: 0x1D3DCB0 Offset: 0x1D39CB0 VA: 0x1D3DCB0
	private void onDetail(int id) { }

	// RVA: 0x1D3E5F8 Offset: 0x1D3A5F8 VA: 0x1D3E5F8
	private void onCloseDetail() { }

	// RVA: 0x1D3E788 Offset: 0x1D3A788 VA: 0x1D3E788
	private void onBuy(int id) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<onBuyCoroutine>d__100))]
	// RVA: 0x1D3E8F4 Offset: 0x1D3A8F4 VA: 0x1D3E8F4
	private IEnumerator onBuyCoroutine(UIMarketProductData product) { }

	// RVA: 0x1D3E984 Offset: 0x1D3A984 VA: 0x1D3E984
	private void onCloseCheckWindow() { }

	// RVA: 0x1D3EA98 Offset: 0x1D3AA98 VA: 0x1D3EA98
	private void onBuyDetermine() { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<onBuyDetermineCoroutine>d__103))]
	// RVA: 0x1D3EAF8 Offset: 0x1D3AAF8 VA: 0x1D3EAF8
	private IEnumerator onBuyDetermineCoroutine() { }

	// RVA: 0x1D3EB6C Offset: 0x1D3AB6C VA: 0x1D3EB6C
	private void onCloseCompleteWindow() { }

	// RVA: 0x1D3EC98 Offset: 0x1D3AC98 VA: 0x1D3EC98
	private void onNext() { }

	// RVA: 0x1D3ED20 Offset: 0x1D3AD20 VA: 0x1D3ED20
	private void onLast() { }

	// RVA: 0x1D3ED28 Offset: 0x1D3AD28 VA: 0x1D3ED28
	private void onBack() { }

	// RVA: 0x1D3EDAC Offset: 0x1D3ADAC VA: 0x1D3EDAC
	private void onFirst() { }

	// RVA: 0x1D3ECA0 Offset: 0x1D3ACA0 VA: 0x1D3ECA0
	private void AddPage(byte page) { }

	// RVA: 0x1D3ED30 Offset: 0x1D3AD30 VA: 0x1D3ED30
	private void SubPage(byte page) { }

	// RVA: 0x1D3EE20 Offset: 0x1D3AE20 VA: 0x1D3EE20
	private void UpdatePageNumLabel(bool isActive) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<GetNowPageProductList>d__112))]
	// RVA: 0x1D3EDB4 Offset: 0x1D3ADB4 VA: 0x1D3EDB4
	private IEnumerator GetNowPageProductList() { }

	// RVA: 0x1D3F0B0 Offset: 0x1D3B0B0 VA: 0x1D3F0B0
	private void StartTopButtonIntervalTime() { }

	// RVA: 0x1D3D64C Offset: 0x1D3964C VA: 0x1D3D64C
	private void UpdateTopButtonEnable() { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<onCheckModel>d__115))]
	// RVA: 0x1D3F120 Offset: 0x1D3B120 VA: 0x1D3F120
	private IEnumerator onCheckModel() { }

	// RVA: 0x1D3F194 Offset: 0x1D3B194 VA: 0x1D3F194
	private void onChangeBackPanel() { }

	// RVA: 0x1D3F1F0 Offset: 0x1D3B1F0 VA: 0x1D3F1F0
	private void onChangePreview() { }

	// RVA: 0x1D3D488 Offset: 0x1D39488 VA: 0x1D3D488
	private void relativeScroll(int count) { }

	// RVA: 0x1D3E21C Offset: 0x1D3A21C VA: 0x1D3E21C
	private void setEnabledElement(bool isEnabled) { }

	// RVA: 0x1D3E3FC Offset: 0x1D3A3FC VA: 0x1D3E3FC
	private void setEnablePageCollider(bool isEnabled) { }

	// RVA: 0x1D3CCC4 Offset: 0x1D38CC4 VA: 0x1D3CCC4
	private void updateElementActive() { }

	// RVA: 0x1D3C9C4 Offset: 0x1D389C4 VA: 0x1D3C9C4
	private void setEnableCheckDisableObject(bool isEnabled) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<OpenSkillInfo>d__123))]
	// RVA: 0x1D3E46C Offset: 0x1D3A46C VA: 0x1D3E46C
	private IEnumerator OpenSkillInfo(StarGemData data) { }

	// RVA: 0x1D33A30 Offset: 0x1D2FA30 VA: 0x1D33A30
	public void Open() { }

	// RVA: 0x1D33DBC Offset: 0x1D2FDBC VA: 0x1D33DBC
	public void Close() { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<showEquip>d__126))]
	// RVA: 0x1D3E4F4 Offset: 0x1D3A4F4 VA: 0x1D3E4F4
	private IEnumerator showEquip(ItemData item, Transform parent, int model, byte color1, byte color2, byte color3, List<GameObject> list, UILabel cantViewLabel) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<showEquip>d__128))]
	// RVA: 0x1D3F758 Offset: 0x1D3B758 VA: 0x1D3F758
	private IEnumerator showEquip(ItemData item, Transform parent, int model, byte color1, byte color2, byte color3, List<GameObject> list, List<GameObject> coloringList, Action callback, UILabel cantViewLabel) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<loadWeapon>d__129))]
	// RVA: 0x1D3F88C Offset: 0x1D3B88C VA: 0x1D3F88C
	private IEnumerator loadWeapon(int modelId, byte color1, byte color2, byte color3, Action<GameObject> ret) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<loadArmor>d__130))]
	// RVA: 0x1D3F94C Offset: 0x1D3B94C VA: 0x1D3F94C
	private IEnumerator loadArmor(ItemData item, int model, byte color1, byte color2, byte color3, Action<GameObject[]> ret) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<loadArmor>d__131))]
	// RVA: 0x1D3FA20 Offset: 0x1D3BA20 VA: 0x1D3FA20
	private IEnumerator loadArmor(int model, short ability, byte color1, byte color2, byte color3, Action<GameObject[]> ret) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<loadFace>d__132))]
	// RVA: 0x1D3FAE8 Offset: 0x1D3BAE8 VA: 0x1D3FAE8
	private IEnumerator loadFace(MasterModelDataManager.OptionModelFlag optionFlag, Action<GameObject> ret) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<loadOption>d__133))]
	// RVA: 0x1D3FB80 Offset: 0x1D3BB80 VA: 0x1D3FB80
	private IEnumerator loadOption(int optionId, byte color1, byte color2, byte color3, Action<MasterModelDataManager.OptionModelFlag> flagRet, Action<GameObject> ret) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<loadHair>d__134))]
	// RVA: 0x1D3FC54 Offset: 0x1D3BC54 VA: 0x1D3FC54
	private IEnumerator loadHair(MasterModelDataManager.OptionModelFlag optionFlag, Action<GameObject[]> ret) { }

	// RVA: 0x1D3FCEC Offset: 0x1D3BCEC VA: 0x1D3FCEC
	private void setModelColor(GameObject obj, byte rColor, byte gColor, byte bColor) { }

	[IteratorStateMachine(typeof(UIMarketBuySearchList.<LoadPetModel>d__136))]
	// RVA: 0x1D4010C Offset: 0x1D3C10C VA: 0x1D4010C
	private IEnumerator LoadPetModel(string Id) { }

	// RVA: 0x1D3F3FC Offset: 0x1D3B3FC VA: 0x1D3F3FC
	private void SetActiveModelList(bool isActive) { }

	// RVA: 0x1D401BC Offset: 0x1D3C1BC VA: 0x1D401BC
	private void SetPreviewModel(GameObject obj, Transform parent, ItemType itemType) { }

	// RVA: 0x1D405C8 Offset: 0x1D3C5C8 VA: 0x1D405C8
	private Vector3 PreviewWeaponPos(ItemType type) { }

	// RVA: 0x1D4060C Offset: 0x1D3C60C VA: 0x1D4060C
	private void onPreviewPress() { }

	// RVA: 0x1D40618 Offset: 0x1D3C618 VA: 0x1D40618
	private void onPreviewRelease() { }

	// RVA: 0x1D4064C Offset: 0x1D3C64C VA: 0x1D4064C
	private void onPreviewClick() { }

	// RVA: 0x1D40DEC Offset: 0x1D3CDEC VA: 0x1D40DEC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D41158 Offset: 0x1D3D158 VA: 0x1D41158
	private void <LoadPetModel>b__136_0(GameObject x) { }
}

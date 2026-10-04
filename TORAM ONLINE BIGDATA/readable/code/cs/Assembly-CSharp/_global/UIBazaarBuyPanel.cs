// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBazaarBuyPanel : UIBasePanelControl // TypeDefIndex: 8282
{
	// Fields
	private readonly float elementHeight; // 0x54
	[SerializeField]
	private UILabel titleLabel; // 0x58
	[SerializeField]
	private UIBazaarBuyElement addElementOriginal; // 0x60
	[SerializeField]
	private UIScrollWindow scroll; // 0x68
	[SerializeField]
	private UIItemPropertyStretch property; // 0x70
	[SerializeField]
	private Transform modelParent; // 0x78
	[SerializeField]
	private UILabel detailCantViewModelLabel; // 0x80
	[SerializeField]
	private GameObject backWindow; // 0x88
	[SerializeField]
	private UIIruna2DragPinch modelDrag; // 0x90
	[SerializeField]
	private GameObject[] checkDisableObjects; // 0x98
	[SerializeField]
	private UIBazaarBuyCheckWindow checkWindow; // 0xA0
	[SerializeField]
	private UIBazaarBuyCompleteWindow completeWindow; // 0xA8
	[SerializeField]
	private GameObject[] modelCheckButtonObjs; // 0xB0
	[SerializeField]
	private UISprite backColorButton; // 0xB8
	[SerializeField]
	private UISprite backColorPanel; // 0xC0
	[SerializeField]
	private GameObject previewChagneButtonObj; // 0xC8
	[SerializeField]
	private UILabel modelNameLabel; // 0xD0
	[SerializeField]
	private GameObject modelCustomPanel; // 0xD8
	[SerializeField]
	private UILabel modelCustomLabel; // 0xE0
	private List<BazaarItemData> productList; // 0xE8
	private Dictionary<byte, short> errorProductList; // 0xF0
	private Dictionary<int, UIBazaarBuyElement> elementList; // 0xF8
	private Dictionary<byte, byte> countryRateList; // 0x100
	private List<GameObject> modelList; // 0x108
	private PlayerDataManager playerDataManager; // 0x110
	private SystemTextManager systemTextManager; // 0x118
	private bool isDuringInitializeScroll; // 0x120
	private MarketType currentMarketType; // 0x124
	private MarketOrderType currentOrderType; // 0x128
	private int currentItemId; // 0x12C
	private ItemType currentItemType; // 0x130
	private GameObject petModelObject; // 0x138
	private Transform petModelParent; // 0x140
	private ItemData cageItem; // 0x148
	private PetModelLoader petModelLoader; // 0x150
	private ItemType[] powerUpCristaType; // 0x158
	private Color[] backPanelColor; // 0x160
	private int backColor; // 0x168
	private const int capMax = 8;
	private bool isEquipOption; // 0x16C
	private UIPopBaseWindow skillPopWindow; // 0x170
	private bool isSkillPopWindow; // 0x178
	private GameObject skillIconObj; // 0x180
	private GameObject previewObj; // 0x188
	private const float previewScale = 125;
	private bool isPreviewPress; // 0x190
	private float previewPressTime; // 0x194
	private const float clickTime = 0.2;
	private bool isPreviewSword; // 0x198
	private Animation activePreviewAnimation; // 0x1A0
	private List<Animation> activeNormalAnimationList; // 0x1A8
	private string attackAnimeName; // 0x1B0
	private ItemType previewItemType; // 0x1B8
	private ItemTextManager itemTextManager; // 0x1C0
	private int selectElementId; // 0x1C8
	private ItemData showModelItemData; // 0x1D0
	private bool isPreviewWeapon; // 0x1D8
	private List<GameObject> loadModelObjList; // 0x1E0
	private OtherPlayer target; // 0x1E8
	private SignboardPropertyData boardData; // 0x1F0
	private bool isModelLoading; // 0x1F8

	// Properties
	private int AnimeNum { get; }

	// Methods

	// RVA: 0x1D044A8 Offset: 0x1D004A8 VA: 0x1D044A8
	private int get_AnimeNum() { }

	// RVA: 0x1D044B4 Offset: 0x1D004B4 VA: 0x1D044B4
	private void Awake() { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<Start>d__64))]
	// RVA: 0x1D04948 Offset: 0x1D00948 VA: 0x1D04948
	private IEnumerator Start() { }

	// RVA: 0x1D049BC Offset: 0x1D009BC VA: 0x1D049BC
	private void Update() { }

	// RVA: 0x1D05584 Offset: 0x1D01584 VA: 0x1D05584
	private void OnDisable() { }

	// RVA: 0x1D05604 Offset: 0x1D01604 VA: 0x1D05604
	private void OnDestroy() { }

	// RVA: 0x1D04B24 Offset: 0x1D00B24 VA: 0x1D04B24
	private void updateModelRotate() { }

	// RVA: 0x1D057AC Offset: 0x1D017AC VA: 0x1D057AC
	public void Initialize(OtherPlayer target, SignboardPropertyData boardData) { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<initializeScroll>d__70))]
	// RVA: 0x1D05998 Offset: 0x1D01998 VA: 0x1D05998
	private IEnumerator initializeScroll() { }

	// RVA: 0x1D05A0C Offset: 0x1D01A0C VA: 0x1D05A0C
	private void onDetail(int id) { }

	// RVA: 0x1D062C0 Offset: 0x1D022C0 VA: 0x1D062C0
	private void onCloseDetail() { }

	// RVA: 0x1D06444 Offset: 0x1D02444 VA: 0x1D06444
	private void onBuy(int id) { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<onBuyCoroutine>d__74))]
	// RVA: 0x1D0660C Offset: 0x1D0260C VA: 0x1D0660C
	private IEnumerator onBuyCoroutine(UIBazaarBuyElement element) { }

	// RVA: 0x1D0669C Offset: 0x1D0269C VA: 0x1D0669C
	private void onCloseCheckWindow() { }

	// RVA: 0x1D067B0 Offset: 0x1D027B0 VA: 0x1D067B0
	private void onBuyDetermine() { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<onBuyDetermineCoroutine>d__77))]
	// RVA: 0x1D06810 Offset: 0x1D02810 VA: 0x1D06810
	private IEnumerator onBuyDetermineCoroutine() { }

	// RVA: 0x1D06884 Offset: 0x1D02884 VA: 0x1D06884
	private void onCloseCompleteWindow() { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<OnFailedPurchase>d__79))]
	// RVA: 0x1D06A24 Offset: 0x1D02A24 VA: 0x1D06A24
	private IEnumerator OnFailedPurchase(GameReturnCode returnCode) { }

	// RVA: 0x1D06AA8 Offset: 0x1D02AA8 VA: 0x1D06AA8
	private void onNext() { }

	// RVA: 0x1D06AB0 Offset: 0x1D02AB0 VA: 0x1D06AB0
	private void onLast() { }

	// RVA: 0x1D06AB8 Offset: 0x1D02AB8 VA: 0x1D06AB8
	private void onBack() { }

	// RVA: 0x1D06AC0 Offset: 0x1D02AC0 VA: 0x1D06AC0
	private void onFirst() { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<onCheckModel>d__84))]
	// RVA: 0x1D06AC8 Offset: 0x1D02AC8 VA: 0x1D06AC8
	private IEnumerator onCheckModel() { }

	// RVA: 0x1D06B3C Offset: 0x1D02B3C VA: 0x1D06B3C
	private void onChangeBackPanel() { }

	// RVA: 0x1D06B98 Offset: 0x1D02B98 VA: 0x1D06B98
	private void onChangePreview() { }

	// RVA: 0x1D053C0 Offset: 0x1D013C0 VA: 0x1D053C0
	private void relativeScroll(int count) { }

	// RVA: 0x1D05F4C Offset: 0x1D01F4C VA: 0x1D05F4C
	private void setEnabledElement(bool isEnabled) { }

	// RVA: 0x1D04C4C Offset: 0x1D00C4C VA: 0x1D04C4C
	private void updateElementActive() { }

	// RVA: 0x1D048E0 Offset: 0x1D008E0 VA: 0x1D048E0
	private void setEnableCheckDisableObject(bool isEnabled) { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<OpenSkillInfo>d__91))]
	// RVA: 0x1D0612C Offset: 0x1D0212C VA: 0x1D0612C
	private IEnumerator OpenSkillInfo(StarGemData data) { }

	// RVA: 0x1D07094 Offset: 0x1D03094 VA: 0x1D07094
	public void Open() { }

	// RVA: 0x1D070B8 Offset: 0x1D030B8 VA: 0x1D070B8
	public void Close() { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<showEquip>d__94))]
	// RVA: 0x1D061BC Offset: 0x1D021BC VA: 0x1D061BC
	private IEnumerator showEquip(ItemData item, Transform parent, int model, byte color1, byte color2, byte color3, List<GameObject> list, UILabel cantViewLabel) { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<showEquip>d__96))]
	// RVA: 0x1D070DC Offset: 0x1D030DC VA: 0x1D070DC
	private IEnumerator showEquip(ItemData item, Transform parent, int model, byte color1, byte color2, byte color3, List<GameObject> list, List<GameObject> coloringList, Action callback, UILabel cantViewLabel) { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<loadWeapon>d__97))]
	// RVA: 0x1D07210 Offset: 0x1D03210 VA: 0x1D07210
	private IEnumerator loadWeapon(int modelId, byte color1, byte color2, byte color3, Action<GameObject> ret) { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<loadArmor>d__98))]
	// RVA: 0x1D072D0 Offset: 0x1D032D0 VA: 0x1D072D0
	private IEnumerator loadArmor(ItemData item, int model, byte color1, byte color2, byte color3, Action<GameObject[]> ret) { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<loadArmor>d__99))]
	// RVA: 0x1D073A4 Offset: 0x1D033A4 VA: 0x1D073A4
	private IEnumerator loadArmor(int model, short ability, byte color1, byte color2, byte color3, Action<GameObject[]> ret) { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<loadFace>d__100))]
	// RVA: 0x1D0746C Offset: 0x1D0346C VA: 0x1D0746C
	private IEnumerator loadFace(MasterModelDataManager.OptionModelFlag optionFlag, Action<GameObject> ret) { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<loadOption>d__101))]
	// RVA: 0x1D07504 Offset: 0x1D03504 VA: 0x1D07504
	private IEnumerator loadOption(int optionId, byte color1, byte color2, byte color3, Action<MasterModelDataManager.OptionModelFlag> flagRet, Action<GameObject> ret) { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<loadHair>d__102))]
	// RVA: 0x1D075D8 Offset: 0x1D035D8 VA: 0x1D075D8
	private IEnumerator loadHair(MasterModelDataManager.OptionModelFlag optionFlag, Action<GameObject[]> ret) { }

	// RVA: 0x1D07670 Offset: 0x1D03670 VA: 0x1D07670
	private void setModelColor(GameObject obj, byte rColor, byte gColor, byte bColor) { }

	[IteratorStateMachine(typeof(UIBazaarBuyPanel.<LoadPetModel>d__104))]
	// RVA: 0x1D07A90 Offset: 0x1D03A90 VA: 0x1D07A90
	private IEnumerator LoadPetModel(string Id) { }

	// RVA: 0x1D06D60 Offset: 0x1D02D60 VA: 0x1D06D60
	private void SetActiveModelList(bool isActive) { }

	// RVA: 0x1D07B20 Offset: 0x1D03B20 VA: 0x1D07B20
	private void SetPreviewModel(GameObject obj, Transform parent, ItemType itemType) { }

	// RVA: 0x1D07F24 Offset: 0x1D03F24 VA: 0x1D07F24
	private Vector3 PreviewWeaponPos(ItemType type) { }

	// RVA: 0x1D07F68 Offset: 0x1D03F68 VA: 0x1D07F68
	private void onPreviewPress() { }

	// RVA: 0x1D07F74 Offset: 0x1D03F74 VA: 0x1D07F74
	private void onPreviewRelease() { }

	// RVA: 0x1D07FA8 Offset: 0x1D03FA8 VA: 0x1D07FA8
	private void onPreviewClick() { }

	// RVA: 0x1D08730 Offset: 0x1D04730 VA: 0x1D08730 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1D087E0 Offset: 0x1D047E0 VA: 0x1D087E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D08B94 Offset: 0x1D04B94 VA: 0x1D08B94
	private void <LoadPetModel>b__104_0(GameObject x) { }
}

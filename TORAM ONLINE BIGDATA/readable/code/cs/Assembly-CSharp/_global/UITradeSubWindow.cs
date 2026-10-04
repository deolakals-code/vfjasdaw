// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITradeSubWindow : MonoBehaviour // TypeDefIndex: 8130
{
	// Fields
	[SerializeField]
	private GameObject[] itemIcons; // 0x20
	[SerializeField]
	private UILabel spinaLabel; // 0x28
	[SerializeField]
	private GameObject spinaButton; // 0x30
	[SerializeField]
	private UILabel spinaInputLabel; // 0x38
	[SerializeField]
	private UILabel getReadyLabel; // 0x40
	[SerializeField]
	private LocalizeText nameLocalize; // 0x48
	[SerializeField]
	private UIIcon dragIcon; // 0x50
	[SerializeField]
	private UIItemPropertyStretch itemProperty; // 0x58
	[SerializeField]
	private UIIruna2Anchor propertyAnchor; // 0x60
	[SerializeField]
	private UIIruna2Anchor modelViewAnchor; // 0x68
	[SerializeField]
	private Transform modelParent; // 0x70
	[SerializeField]
	private UIIruna2DragPinch modelDrag; // 0x78
	[SerializeField]
	private UIImageButton[] modelViewDisableButton; // 0x80
	[SerializeField]
	private GameObject modelViewWindowObject; // 0x88
	[SerializeField]
	private GameObject modelDataPanel; // 0x90
	[SerializeField]
	private UISprite[] modelColorPanel; // 0x98
	[SerializeField]
	private UILabel modelNameLabel; // 0xA0
	[SerializeField]
	private GameObject modelCustomPanel; // 0xA8
	[SerializeField]
	private UILabel modelCustomLabel; // 0xB0
	public List<TradeItemData> SetTradeItemList; // 0xB8
	private static List<GameObject> modelList; // 0x0
	private static GameObject petModelObj; // 0x8
	private PetModelLoader petModelLoader; // 0xC0
	[CompilerGenerated]
	private Action <itemRemoveCallback>k__BackingField; // 0xC8
	private SystemTextManager systemTextManager; // 0xD0
	private PlayerDataManager playerDataManager; // 0xD8
	private int spina; // 0xE0
	private int lastSelectedSlot; // 0xE4
	private bool isDragIcon; // 0xE8
	private int selectedDirectIndex; // 0xEC
	private TweenScale tscale; // 0xF0
	private bool isInitializedDirectIndex; // 0xF8
	private bool isInitializedFinalize; // 0xF9
	private bool isPlayer; // 0xFA
	private List<GameObject> loadModelObjList; // 0x100
	private int selectParamId; // 0x108
	[SerializeField]
	private UIInput spinaInput; // 0x110
	private bool isSpinaInputActive; // 0x118
	private ItemTextManager itemTextManager; // 0x120
	private const int MaxSelectNum = 4;
	private UITrade tradePanel; // 0x128
	private bool isModelLoading; // 0x130

	// Properties
	public Action itemRemoveCallback { get; set; }
	public int Spina { get; }
	public bool IsPlayerProperty { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CCAE90 Offset: 0x1CC6E90 VA: 0x1CCAE90
	public Action get_itemRemoveCallback() { }

	[CompilerGenerated]
	// RVA: 0x1CCAE98 Offset: 0x1CC6E98 VA: 0x1CCAE98
	public void set_itemRemoveCallback(Action value) { }

	// RVA: 0x1CCAEA0 Offset: 0x1CC6EA0 VA: 0x1CCAEA0
	public int get_Spina() { }

	// RVA: 0x1CC3C44 Offset: 0x1CBFC44 VA: 0x1CC3C44
	public bool get_IsPlayerProperty() { }

	// RVA: 0x1CCAEA8 Offset: 0x1CC6EA8 VA: 0x1CCAEA8
	private void Awake() { }

	// RVA: 0x1CCB5CC Offset: 0x1CC75CC VA: 0x1CCB5CC
	private void Update() { }

	// RVA: 0x1CCB83C Offset: 0x1CC783C VA: 0x1CCB83C
	private void OnDestroy() { }

	// RVA: 0x1CBF2CC Offset: 0x1CBB2CC VA: 0x1CBF2CC
	public void Initialize(string name, bool isplayer, UITrade tradePanel) { }

	// RVA: 0x1CC2C60 Offset: 0x1CBEC60 VA: 0x1CC2C60
	public void AddItem(ItemData itemData, int count) { }

	// RVA: 0x1CC3964 Offset: 0x1CBF964 VA: 0x1CC3964
	public void AddStarGem(StarGemData starGemData) { }

	// RVA: 0x1CC07A8 Offset: 0x1CBC7A8 VA: 0x1CC07A8
	public void SetItemDirect(ItemDatav2[] items, StarGemData[] starGems) { }

	// RVA: 0x1CCB158 Offset: 0x1CC7158 VA: 0x1CCB158
	private void updateItem() { }

	// RVA: 0x1CC005C Offset: 0x1CBC05C VA: 0x1CC005C
	public void SetShowItems(bool isShow) { }

	// RVA: 0x1CC2DEC Offset: 0x1CBEDEC VA: 0x1CC2DEC
	public void OnSpinaSubmit() { }

	// RVA: 0x1CC014C Offset: 0x1CBC14C VA: 0x1CC014C
	public void SetSpina(int _spina) { }

	// RVA: 0x1CC3088 Offset: 0x1CBF088 VA: 0x1CC3088
	public void onClickItem(int param) { }

	// RVA: 0x1CCBD0C Offset: 0x1CC7D0C VA: 0x1CCBD0C
	public bool onClickItemDirect(int param) { }

	// RVA: 0x1CC0A44 Offset: 0x1CBCA44 VA: 0x1CC0A44
	public void InitializeFinalize() { }

	// RVA: 0x1CC1A7C Offset: 0x1CBDA7C VA: 0x1CC1A7C
	public bool onClickItemDirectInitialize(bool isSetSelectedDirectIndex) { }

	// RVA: 0x1CCB9E4 Offset: 0x1CC79E4 VA: 0x1CCB9E4
	private void updatePropertyAnchor(int itemid) { }

	// RVA: 0x1CCC3A4 Offset: 0x1CC83A4 VA: 0x1CCC3A4
	private void setSelectedFrame(int frame) { }

	// RVA: 0x1CCBB9C Offset: 0x1CC7B9C VA: 0x1CCBB9C
	private void updateFrame() { }

	// RVA: 0x1CCC3AC Offset: 0x1CC83AC VA: 0x1CCC3AC
	private void onPress(int param) { }

	// RVA: 0x1CCC538 Offset: 0x1CC8538 VA: 0x1CCC538
	private void onRelease(int param) { }

	// RVA: 0x1CCC53C Offset: 0x1CC853C VA: 0x1CCC53C
	public void OnDrag(Vector2 delta) { }

	// RVA: 0x1CC1A48 Offset: 0x1CBDA48 VA: 0x1CC1A48
	public void OnCloseDescription() { }

	// RVA: 0x1CCB074 Offset: 0x1CC7074 VA: 0x1CCB074
	private void setModelViewEnabled(bool isEnabled) { }

	// RVA: 0x1CC1D80 Offset: 0x1CBDD80 VA: 0x1CC1D80
	public bool OnOpenDescription() { }

	// RVA: 0x1CCC180 Offset: 0x1CC8180 VA: 0x1CCC180
	private void setModelView(bool isEnabled) { }

	// RVA: 0x1CCC0D8 Offset: 0x1CC80D8 VA: 0x1CCC0D8
	private void setPetModelView(bool isEnabled) { }

	// RVA: 0x1CC23D0 Offset: 0x1CBE3D0 VA: 0x1CC23D0
	public void StopItemAnimation() { }

	// RVA: 0x1CCC004 Offset: 0x1CC8004 VA: 0x1CCC004
	private void updateDisableButton(bool isEnabled) { }

	// RVA: 0x1CCB6AC Offset: 0x1CC76AC VA: 0x1CCB6AC
	private void checkModelDrag() { }

	// RVA: 0x1CC35CC Offset: 0x1CBF5CC VA: 0x1CC35CC
	public void ChangeActiveModelView(bool isActive) { }

	// RVA: 0x1CC3C68 Offset: 0x1CBFC68 VA: 0x1CC3C68
	public void ChangeActiveModelName(bool isActive) { }

	[IteratorStateMachine(typeof(UITradeSubWindow.<showEquip>d__79))]
	// RVA: 0x1CCC660 Offset: 0x1CC8660 VA: 0x1CCC660
	private IEnumerator showEquip(ItemData item, Transform parent, int model, byte color1, byte color2, byte color3, List<GameObject> list) { }

	// RVA: 0x1CCC750 Offset: 0x1CC8750 VA: 0x1CCC750
	private void setEnableModelViewCamera(bool isEnabled) { }

	[IteratorStateMachine(typeof(UITradeSubWindow.<showEquip>d__82))]
	// RVA: 0x1CCC754 Offset: 0x1CC8754 VA: 0x1CCC754
	private IEnumerator showEquip(ItemData item, Transform parent, int model, byte color1, byte color2, byte color3, List<GameObject> list, List<GameObject> coloringList, Action callback) { }

	[IteratorStateMachine(typeof(UITradeSubWindow.<loadWeapon>d__83))]
	// RVA: 0x1CCC868 Offset: 0x1CC8868 VA: 0x1CCC868
	private IEnumerator loadWeapon(int modelId, byte color1, byte color2, byte color3, Action<GameObject> ret) { }

	[IteratorStateMachine(typeof(UITradeSubWindow.<loadArmor>d__84))]
	// RVA: 0x1CCC928 Offset: 0x1CC8928 VA: 0x1CCC928
	private IEnumerator loadArmor(ItemData item, int model, byte color1, byte color2, byte color3, Action<GameObject[]> ret) { }

	[IteratorStateMachine(typeof(UITradeSubWindow.<loadArmor>d__85))]
	// RVA: 0x1CCC9FC Offset: 0x1CC89FC VA: 0x1CCC9FC
	private IEnumerator loadArmor(int model, short ability, byte color1, byte color2, byte color3, Action<GameObject[]> ret) { }

	[IteratorStateMachine(typeof(UITradeSubWindow.<loadFace>d__86))]
	// RVA: 0x1CCCAC4 Offset: 0x1CC8AC4 VA: 0x1CCCAC4
	private IEnumerator loadFace(MasterModelDataManager.OptionModelFlag optionFlag, Action<GameObject> ret) { }

	[IteratorStateMachine(typeof(UITradeSubWindow.<loadOption>d__87))]
	// RVA: 0x1CCCB5C Offset: 0x1CC8B5C VA: 0x1CCCB5C
	private IEnumerator loadOption(int optionId, byte color1, byte color2, byte color3, Action<MasterModelDataManager.OptionModelFlag> flagRet, Action<GameObject> ret) { }

	[IteratorStateMachine(typeof(UITradeSubWindow.<loadHair>d__88))]
	// RVA: 0x1CCCC30 Offset: 0x1CC8C30 VA: 0x1CCCC30
	private IEnumerator loadHair(MasterModelDataManager.OptionModelFlag optionFlag, Action<GameObject[]> ret) { }

	// RVA: 0x1CCCCC8 Offset: 0x1CC8CC8 VA: 0x1CCCCC8
	private void setModelColor(GameObject obj, byte rColor, byte gColor, byte bColor) { }

	[IteratorStateMachine(typeof(UITradeSubWindow.<showPetModel>d__90))]
	// RVA: 0x1CCC5BC Offset: 0x1CC85BC VA: 0x1CCC5BC
	private IEnumerator showPetModel(ItemData item, Transform parent) { }

	[IteratorStateMachine(typeof(UITradeSubWindow.<LoadPetModel>d__91))]
	// RVA: 0x1CCD0E8 Offset: 0x1CC90E8 VA: 0x1CCD0E8
	private IEnumerator LoadPetModel(string modelId) { }

	// RVA: 0x1CCD178 Offset: 0x1CC9178 VA: 0x1CCD178
	public void .ctor() { }

	// RVA: 0x1CCD2DC Offset: 0x1CC92DC VA: 0x1CCD2DC
	private static void .cctor() { }
}

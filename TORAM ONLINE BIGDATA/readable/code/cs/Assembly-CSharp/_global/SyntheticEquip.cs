// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SyntheticEquip : SmithUIMaterialBase // TypeDefIndex: 8709
{
	// Fields
	private int[] requireSpina; // 0x68
	private int[] requireOrb; // 0x70
	private const int defaultPreviewEquipNum = 2;
	private const int allPreviewEquipNum = 4;
	[SerializeField]
	private GameObject mainUIParent; // 0x78
	[SerializeField]
	private GameObject costUIParent; // 0x80
	[SerializeField]
	private UILabel costLabel; // 0x88
	[SerializeField]
	private GameObject nextButtonObject; // 0x90
	[SerializeField]
	private UISprite backGroundSprite; // 0x98
	[SerializeField]
	private GameObject selectParent; // 0xA0
	[SerializeField]
	private UIImageButton subItemButton; // 0xA8
	[SerializeField]
	private UIImageButton selectToModelButton; // 0xB0
	[SerializeField]
	private UILabel mainItemLabel; // 0xB8
	[SerializeField]
	private UILabel subItemLabel; // 0xC0
	[SerializeField]
	private SyntheticEquipItemLabel mainItemDataLabel; // 0xC8
	[SerializeField]
	private SyntheticEquipItemLabel subItemDataLabel; // 0xD0
	[SerializeField]
	private Transform mainModelViewPosition; // 0xD8
	[SerializeField]
	private Transform subModelViewPosition; // 0xE0
	[SerializeField]
	private GameObject[] modelSelectDisableObject; // 0xE8
	[SerializeField]
	private GameObject modelParent; // 0xF0
	[SerializeField]
	private SyntheticEquipSelector modelSelector; // 0xF8
	[SerializeField]
	private SyntheticEquipItemLabel modelLabel; // 0x100
	[SerializeField]
	private Transform modelPreviewParent; // 0x108
	[SerializeField]
	private GameObject colorParent; // 0x110
	[SerializeField]
	private Transform colorModelViewPosition; // 0x118
	[SerializeField]
	private UIIruna2DragPinch colorDrag; // 0x120
	[SerializeField]
	private UILabel[] colorLabel; // 0x128
	[SerializeField]
	private UISprite[] colorSprite; // 0x130
	[SerializeField]
	private SyntheticEquipSelector[] colorSelector; // 0x138
	[SerializeField]
	private GameObject baseParent; // 0x140
	[SerializeField]
	private SyntheticEquipItemLabel baseLabel; // 0x148
	[SerializeField]
	private SyntheticEquipSelector baseSelector; // 0x150
	[SerializeField]
	private SyntheticEquipItemProperty baseProperty; // 0x158
	[SerializeField]
	private Camera scrollCamera; // 0x160
	[SerializeField]
	private GameObject checkParent; // 0x168
	[SerializeField]
	private UIImageButton startButton; // 0x170
	[SerializeField]
	private Transform checkModelViewPosition; // 0x178
	[SerializeField]
	private LocalizeText checkRateLabel; // 0x180
	[SerializeField]
	private UIIruna2DragPinch checkDrag; // 0x188
	[SerializeField]
	private GameObject[] checkEnableObject; // 0x190
	[SerializeField]
	private GameObject orbPaymentObject; // 0x198
	[SerializeField]
	private GameObject orbPaymentButtonObject; // 0x1A0
	[SerializeField]
	private GameObject orbPaymentWindowObject; // 0x1A8
	[SerializeField]
	private GameObject orbPaymentWindowButtonObject; // 0x1B0
	[SerializeField]
	private GameObject modelCameraObject; // 0x1B8
	[SerializeField]
	private GameObject addObject; // 0x1C0
	[SerializeField]
	private GameObject resultParent; // 0x1C8
	[SerializeField]
	private GameObject itemLabelObject; // 0x1D0
	[SerializeField]
	private UILabel resultLabel; // 0x1D8
	[SerializeField]
	private GameObject takeEffectParent; // 0x1E0
	[SerializeField]
	private GameObject takeEffectBackGround; // 0x1E8
	[SerializeField]
	private GameObject modelSwitchButton; // 0x1F0
	[SerializeField]
	private Transform weaponModelParent; // 0x1F8
	private PlayerDataManager playerDataManager; // 0x200
	private List<GameObject> mainModelObjects; // 0x208
	private List<GameObject> subModelObjects; // 0x210
	private List<GameObject> previewModelObjects; // 0x218
	private List<GameObject> checkModelObjects; // 0x220
	private List<Transform> viewModelHeadBones; // 0x228
	private Dictionary<object, Trio<Color, Color, Color>> modelDefaultColor; // 0x230
	private Dictionary<MasterModelDataManager.OptionModelFlag, GameObject> hairObject; // 0x238
	private Dictionary<int, List<GameObject>> coloringObjects; // 0x240
	private byte[] oldColor; // 0x248
	private byte nowPreviewEquip; // 0x250
	private Vector3 equipScale; // 0x254
	private bool isWeaponPreview; // 0x260
	private int previewWeaponAnimeNum; // 0x264
	private float previewPressTime; // 0x268
	private string playAnimName; // 0x270
	private List<GameObject> weaponModelObjects; // 0x278
	private ItemSelector itemSelector; // 0x280
	private ItemData MainItem; // 0x288
	private ItemData SubItem; // 0x290
	private bool[] lockFlag; // 0x298
	private ItemData[] lockItem; // 0x2A0
	private bool isModelLoading; // 0x2A8
	private Coroutine randomSwitch; // 0x2B0
	private bool isOrbPayment; // 0x2B8
	private UIPopWindow popWindow; // 0x2C0
	private GameObject addedObject; // 0x2C8
	private SyntheticEquipSelectSupport supportSelector; // 0x2D0
	private SyntheticEquip.PageState page; // 0x2D8
	private List<GameObject> loadModelObjList; // 0x2E0
	private bool isConnect; // 0x2E8
	private SynthesizeEquipmentResponse connectResponse; // 0x2F0

	// Methods

	// RVA: 0x1DD9C28 Offset: 0x1DD5C28 VA: 0x1DD9C28
	private void Awake() { }

	// RVA: 0x1DD9F90 Offset: 0x1DD5F90 VA: 0x1DD9F90
	private void Start() { }

	// RVA: 0x1DDA010 Offset: 0x1DD6010 VA: 0x1DDA010
	private void Update() { }

	// RVA: 0x1DDA3C8 Offset: 0x1DD63C8 VA: 0x1DDA3C8
	private void OnDestroy() { }

	// RVA: 0x1DDA570 Offset: 0x1DD6570 VA: 0x1DDA570
	private void onNext() { }

	// RVA: 0x1DDBD44 Offset: 0x1DD7D44 VA: 0x1DDBD44
	private void resetSelect() { }

	// RVA: 0x1DDC334 Offset: 0x1DD8334 VA: 0x1DDC334
	private void onSelectMainButton() { }

	// RVA: 0x1DDC5C4 Offset: 0x1DD85C4 VA: 0x1DDC5C4
	private bool CheckShowCharacter(ItemData item) { }

	// RVA: 0x1DDC618 Offset: 0x1DD8618 VA: 0x1DDC618
	private void onSelectSubButton() { }

	// RVA: 0x1DDC914 Offset: 0x1DD8914 VA: 0x1DDC914
	private void onSelectedMain(ItemData item, int count) { }

	// RVA: 0x1DDCF48 Offset: 0x1DD8F48 VA: 0x1DDCF48
	private bool updateSubItemButton() { }

	// RVA: 0x1DDDC84 Offset: 0x1DD9C84 VA: 0x1DDDC84
	private void onSelectedSub(ItemData item, int count) { }

	// RVA: 0x1DDDBD4 Offset: 0x1DD9BD4 VA: 0x1DDDBD4
	private bool checkSubItem(ItemData item) { }

	// RVA: 0x1DDDE9C Offset: 0x1DD9E9C VA: 0x1DDDE9C
	private void ModelSelectArrowCallback(ItemData item) { }

	// RVA: 0x1DDE394 Offset: 0x1DDA394 VA: 0x1DDE394
	private void ColorSelectCallback(ItemData item, int index) { }

	[IteratorStateMachine(typeof(SyntheticEquip.<OnCreateColorModel>d__103))]
	// RVA: 0x1DDEC24 Offset: 0x1DDAC24 VA: 0x1DDEC24
	private IEnumerator OnCreateColorModel() { }

	[IteratorStateMachine(typeof(SyntheticEquip.<RandomSwitchPreviewModel>d__104))]
	// RVA: 0x1DDEC98 Offset: 0x1DDAC98 VA: 0x1DDEC98
	private IEnumerator RandomSwitchPreviewModel() { }

	// RVA: 0x1DDE7F0 Offset: 0x1DDA7F0 VA: 0x1DDE7F0
	private void updateColorModel(List<GameObject> objs) { }

	// RVA: 0x1DDF2C8 Offset: 0x1DDB2C8 VA: 0x1DDF2C8
	private void OnSwitchModel() { }

	// RVA: 0x1DE0160 Offset: 0x1DDC160 VA: 0x1DE0160
	private int PreviewEquipArmor() { }

	// RVA: 0x1DE0550 Offset: 0x1DDC550 VA: 0x1DE0550
	private void ChangePreviewParent(Transform parent) { }

	// RVA: 0x1DDA028 Offset: 0x1DD6028 VA: 0x1DDA028
	private void checkColorDrag() { }

	// RVA: 0x1DE02C0 Offset: 0x1DDC2C0 VA: 0x1DE02C0
	private void ChangePreviewModelHair(Vector3 equipScale) { }

	// RVA: 0x1DE05C4 Offset: 0x1DDC5C4 VA: 0x1DE05C4
	private void baseSelectCallback(ItemData item) { }

	// RVA: 0x1DE0740 Offset: 0x1DDC740 VA: 0x1DE0740
	private void SetPropertyColors() { }

	// RVA: 0x1DDA164 Offset: 0x1DD6164 VA: 0x1DDA164
	private void checkCheckDrag() { }

	// RVA: 0x1DE0EAC Offset: 0x1DDCEAC VA: 0x1DE0EAC
	private void OnClickOrbPaymentStart() { }

	// RVA: 0x1DE10C8 Offset: 0x1DDD0C8 VA: 0x1DE10C8
	private void OnClickOrbPayment() { }

	[IteratorStateMachine(typeof(SyntheticEquip.<OpenOrbPaymentWindow>d__116))]
	// RVA: 0x1DE118C Offset: 0x1DDD18C VA: 0x1DE118C
	private IEnumerator OpenOrbPaymentWindow() { }

	// RVA: 0x1DE0FA8 Offset: 0x1DDCFA8 VA: 0x1DE0FA8
	private void CloseOrbPaymentWindow() { }

	// RVA: 0x1DE1200 Offset: 0x1DDD200 VA: 0x1DE1200
	private void toConnect() { }

	[IteratorStateMachine(typeof(SyntheticEquip.<Connect>d__119))]
	// RVA: 0x1DE1404 Offset: 0x1DDD404 VA: 0x1DE1404
	private IEnumerator Connect() { }

	// RVA: 0x1DE1478 Offset: 0x1DDD478 VA: 0x1DE1478
	private ItemData ResultItem(ItemDatav2[] data) { }

	[IteratorStateMachine(typeof(SyntheticEquip.<SynthesizeEquipWait>d__121))]
	// RVA: 0x1DE15E0 Offset: 0x1DDD5E0 VA: 0x1DE15E0
	private IEnumerator SynthesizeEquipWait(int[] useItemUuids, int supportItemId, TakeController takeController, int takeUid) { }

	// RVA: 0x1DE169C Offset: 0x1DDD69C VA: 0x1DE169C
	private void onComplete() { }

	// RVA: 0x1DE16BC Offset: 0x1DDD6BC VA: 0x1DE16BC
	private void SetResultMessage(bool isSuccess, bool isLuckyFailure) { }

	// RVA: 0x1DDAC14 Offset: 0x1DD6C14 VA: 0x1DDAC14
	private void toModelSelect() { }

	// RVA: 0x1DDADE4 Offset: 0x1DD6DE4 VA: 0x1DDADE4
	private void toColorSelect() { }

	// RVA: 0x1DDB158 Offset: 0x1DD7158 VA: 0x1DDB158
	private void toBaseSelect() { }

	// RVA: 0x1DDB30C Offset: 0x1DD730C VA: 0x1DDB30C
	private void toCheck() { }

	// RVA: 0x1DDBA5C Offset: 0x1DD7A5C VA: 0x1DDBA5C
	private void toSupport() { }

	// RVA: 0x1DE1BF8 Offset: 0x1DDDBF8 VA: 0x1DE1BF8
	private void toResult() { }

	// RVA: 0x1DE2070 Offset: 0x1DDE070 VA: 0x1DE2070
	private void toSelectFromModel() { }

	// RVA: 0x1DE2198 Offset: 0x1DDE198 VA: 0x1DE2198
	private void toModelFromColor() { }

	// RVA: 0x1DE229C Offset: 0x1DDE29C VA: 0x1DE229C
	private void toColorFromBase() { }

	// RVA: 0x1DE23B8 Offset: 0x1DDE3B8 VA: 0x1DE23B8
	private void toBaseFromCheck() { }

	// RVA: 0x1DE258C Offset: 0x1DDE58C VA: 0x1DE258C
	private void toCheckFromSupport() { }

	// RVA: 0x1DE2618 Offset: 0x1DDE618 VA: 0x1DE2618
	private void toCheckFromResult() { }

	// RVA: 0x1DE26D8 Offset: 0x1DDE6D8 VA: 0x1DE26D8
	private void toSelectFromResult() { }

	[IteratorStateMachine(typeof(SyntheticEquip.<showEquip>d__137))]
	// RVA: 0x1DE29D8 Offset: 0x1DDE9D8 VA: 0x1DE29D8
	private IEnumerator showEquip(ItemData item, Transform parent, int model, byte color1, byte color2, byte color3, List<GameObject> list) { }

	[IteratorStateMachine(typeof(SyntheticEquip.<showEquip>d__138))]
	// RVA: 0x1DDD348 Offset: 0x1DD9348 VA: 0x1DDD348
	private IEnumerator showEquip(ItemData item, Transform parent, int model, byte color1, byte color2, byte color3, bool isRandomPreview, List<GameObject> list, Action callback) { }

	[IteratorStateMachine(typeof(SyntheticEquip.<loadWeapon>d__139))]
	// RVA: 0x1DE2AC8 Offset: 0x1DDEAC8 VA: 0x1DE2AC8
	private IEnumerator loadWeapon(int modelId, byte color1, byte color2, byte color3, Action<GameObject> ret) { }

	[IteratorStateMachine(typeof(SyntheticEquip.<loadArmor>d__140))]
	// RVA: 0x1DE2B88 Offset: 0x1DDEB88 VA: 0x1DE2B88
	private IEnumerator loadArmor(ItemData item, int model, byte color1, byte color2, byte color3, Action<GameObject[]> ret) { }

	[IteratorStateMachine(typeof(SyntheticEquip.<loadArmor>d__141))]
	// RVA: 0x1DE2C5C Offset: 0x1DDEC5C VA: 0x1DE2C5C
	private IEnumerator loadArmor(int model, short ability, byte color1, byte color2, byte color3, Action<GameObject[]> ret) { }

	[IteratorStateMachine(typeof(SyntheticEquip.<loadFace>d__142))]
	// RVA: 0x1DE2D24 Offset: 0x1DDED24 VA: 0x1DE2D24
	private IEnumerator loadFace(MasterModelDataManager.OptionModelFlag modelFlag, Action<GameObject> ret) { }

	[IteratorStateMachine(typeof(SyntheticEquip.<loadOption>d__143))]
	// RVA: 0x1DE2DBC Offset: 0x1DDEDBC VA: 0x1DE2DBC
	private IEnumerator loadOption(int optionId, byte color1, byte color2, byte color3, Action<MasterModelDataManager.OptionModelFlag> flagRet, Action<GameObject> ret) { }

	[IteratorStateMachine(typeof(SyntheticEquip.<loadHair>d__144))]
	// RVA: 0x1DE2E90 Offset: 0x1DDEE90 VA: 0x1DE2E90
	private IEnumerator loadHair(MasterModelDataManager.OptionModelFlag modelFlag, Action<GameObject[]> ret) { }

	// RVA: 0x1DDED0C Offset: 0x1DDAD0C VA: 0x1DDED0C
	private void setModelColor(GameObject obj, byte rColor, byte gColor, byte bColor) { }

	// RVA: 0x1DDD59C Offset: 0x1DD959C VA: 0x1DDD59C
	private void playModelAnimation(List<GameObject> modelList) { }

	// RVA: 0x1DE1300 Offset: 0x1DDD300 VA: 0x1DE1300
	private void closePopup() { }

	// RVA: 0x1DDE37C Offset: 0x1DDA37C VA: 0x1DDE37C
	private string getCostLabelText() { }

	// RVA: 0x1DE1878 Offset: 0x1DDD878 VA: 0x1DE1878
	private int getCost() { }

	// RVA: 0x1DE1F34 Offset: 0x1DDDF34 VA: 0x1DE1F34
	private string getCostOrbLabelText() { }

	// RVA: 0x1DE19AC Offset: 0x1DDD9AC VA: 0x1DE19AC
	private int getCostOrb() { }

	// RVA: 0x1DE3170 Offset: 0x1DDF170 VA: 0x1DE3170
	private string getDetermineNumText() { }

	// RVA: 0x1DE18B0 Offset: 0x1DDD8B0 VA: 0x1DE18B0
	private int getLockCount() { }

	// RVA: 0x1DE333C Offset: 0x1DDF33C VA: 0x1DE333C
	private int getSelectableCount() { }

	// RVA: 0x1DDA8C4 Offset: 0x1DD68C4 VA: 0x1DDA8C4
	private void updateSelectableSelector() { }

	// RVA: 0x1DE19E4 Offset: 0x1DDD9E4 VA: 0x1DE19E4
	private int getRate() { }

	// RVA: 0x1DE2F28 Offset: 0x1DDEF28 VA: 0x1DE2F28
	private void updateHeadSize() { }

	// RVA: 0x1DE342C Offset: 0x1DDF42C VA: 0x1DE342C
	private void setEnableModelViewCamera(bool isEnable) { }

	// RVA: 0x1DE383C Offset: 0x1DDF83C VA: 0x1DE383C
	private void enableModelLayerInvoke() { }

	// RVA: 0x1DE34E0 Offset: 0x1DDF4E0 VA: 0x1DE34E0
	private Camera getViewPositionParentCamera(Transform viewPosition) { }

	// RVA: 0x1DE3678 Offset: 0x1DDF678 VA: 0x1DE3678
	private void setEnabledViewCamera(Camera camera, bool isEnabled) { }

	// RVA: 0x1DE12BC Offset: 0x1DDD2BC VA: 0x1DE12BC
	private void StopRandomSwitch() { }

	// RVA: 0x1DE38D4 Offset: 0x1DDF8D4 VA: 0x1DE38D4
	public void OnModelSwitch() { }

	// RVA: 0x1DDD454 Offset: 0x1DD9454 VA: 0x1DDD454
	private void ChangePreviewParent(bool isWeaponPreview) { }

	// RVA: 0x1DDC16C Offset: 0x1DD816C VA: 0x1DDC16C
	private void DestroyPreviewModelObjects() { }

	// RVA: 0x1DE38E4 Offset: 0x1DDF8E4 VA: 0x1DE38E4
	private void SetPreviewModel(GameObject obj) { }

	// RVA: 0x1DE088C Offset: 0x1DDC88C VA: 0x1DE088C
	private void OnPreviewPress() { }

	// RVA: 0x1DE3CD0 Offset: 0x1DDFCD0 VA: 0x1DE3CD0
	private Vector3 PreviewWeaponPos(ItemType type) { }

	// RVA: 0x1DE0530 Offset: 0x1DDC530 VA: 0x1DE0530
	private float PreviewWeaponScale(ItemType type) { }

	// RVA: 0x1DE3D14 Offset: 0x1DDFD14 VA: 0x1DE3D14
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1DE41F0 Offset: 0x1DE01F0 VA: 0x1DE41F0
	private bool <onSelectMainButton>b__94_0(ItemData item) { }

	[CompilerGenerated]
	// RVA: 0x1DE41F4 Offset: 0x1DE01F4 VA: 0x1DE41F4
	private bool <onSelectMainButton>b__94_1(ItemData item) { }

	[CompilerGenerated]
	// RVA: 0x1DE41F8 Offset: 0x1DE01F8 VA: 0x1DE41F8
	private bool <onSelectSubButton>b__96_0(ItemData item) { }

	[CompilerGenerated]
	// RVA: 0x1DE41FC Offset: 0x1DE01FC VA: 0x1DE41FC
	private void <onSelectedMain>b__97_0() { }

	[CompilerGenerated]
	// RVA: 0x1DE421C Offset: 0x1DE021C VA: 0x1DE421C
	private void <onSelectedSub>b__99_0() { }

	[CompilerGenerated]
	// RVA: 0x1DE423C Offset: 0x1DE023C VA: 0x1DE423C
	private void <OnCreateColorModel>b__103_0() { }

	[CompilerGenerated]
	// RVA: 0x1DE4244 Offset: 0x1DE0244 VA: 0x1DE4244
	private bool <ResultItem>b__120_0(ItemDatav2 d) { }

	[CompilerGenerated]
	// RVA: 0x1DE4270 Offset: 0x1DE0270 VA: 0x1DE4270
	private bool <ResultItem>b__120_1(ItemDatav2 d) { }

	[CompilerGenerated]
	// RVA: 0x1DE429C Offset: 0x1DE029C VA: 0x1DE429C
	private void <toColorSelect>b__125_0(ItemData it) { }

	[CompilerGenerated]
	// RVA: 0x1DE42A4 Offset: 0x1DE02A4 VA: 0x1DE42A4
	private void <toColorSelect>b__125_1(ItemData it) { }

	[CompilerGenerated]
	// RVA: 0x1DE42AC Offset: 0x1DE02AC VA: 0x1DE42AC
	private void <toColorSelect>b__125_2(ItemData it) { }

	[CompilerGenerated]
	// RVA: 0x1DE42B4 Offset: 0x1DE02B4 VA: 0x1DE42B4
	private void <toSupport>b__128_0() { }
}

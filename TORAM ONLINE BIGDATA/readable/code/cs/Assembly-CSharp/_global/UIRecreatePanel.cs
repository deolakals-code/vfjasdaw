// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRecreatePanel : UIBasePanelControl // TypeDefIndex: 8677
{
	// Fields
	private readonly string[] customPath; // 0x58
	private Dictionary<RecreateType, int> savedRecreateDatas; // 0x60
	private Dictionary<RecreateType, List<RecipeDBData>> recipeDatas; // 0x68
	private readonly Dictionary<UIRecreatePanel.RecreateCategory, List<RecreateType>> recipeCategory; // 0x70
	private Dictionary<UIRecreatePanel.PartsType, UICharacterModel> partsModelList; // 0x78
	private int selectedModel; // 0x80
	private UIRecreatePanel.EquipPartsFlag equipPartsFlag; // 0x84
	private GameObject mainAnimationObject; // 0x88
	private SkinnedMeshRenderer mainAnimationSkin; // 0x90
	private Transform mainAnimationHeadBone; // 0x98
	[SerializeField]
	private Camera viewportCamera; // 0xA0
	private int animationId; // 0xA8
	private int modelSexId; // 0xAC
	private int motionSexId; // 0xB0
	private int playerSexId; // 0xB4
	[SerializeField]
	private UILabel playerSexLabel; // 0xB8
	private int hairFrontId; // 0xC0
	[SerializeField]
	private UILabel hairLabel; // 0xC8
	private int hairBackId; // 0xD0
	[SerializeField]
	private UILabel headLabel; // 0xD8
	private int hairTailId; // 0xE0
	[SerializeField]
	private UILabel hairTailLabel; // 0xE8
	private int hairColorId; // 0xF0
	[SerializeField]
	private UILabel hairColorLabel; // 0xF8
	private int hairStreakColorId; // 0x100
	[SerializeField]
	private UILabel hairStreakColorLabel; // 0x108
	[SerializeField]
	private GameObject[] hairButton; // 0x110
	[SerializeField]
	private UIScrollWindow hairScrollWindow; // 0x118
	private int skinColorId; // 0x120
	[SerializeField]
	private UILabel skinColorLabel; // 0x128
	private int skinTextureId; // 0x130
	[SerializeField]
	private UILabel skinTextureLabel; // 0x138
	private int oddEyeColorId; // 0x140
	[SerializeField]
	private UILabel oddEyeColorLabel; // 0x148
	private int heightId; // 0x150
	[SerializeField]
	private UILabel heightLabel; // 0x158
	[SerializeField]
	private Transform baseObject; // 0x160
	private int eyeColorId; // 0x168
	[SerializeField]
	private UILabel eyeColorLabel; // 0x170
	private int faceId; // 0x178
	[SerializeField]
	private UILabel faceLabel; // 0x180
	private int eyeTexId; // 0x188
	[SerializeField]
	private UILabel eyeLabel; // 0x190
	private int battleStyleId; // 0x198
	private int bodyId; // 0x19C
	private bool destoryFlag; // 0x1A0
	[SerializeField]
	private UIIruna2AnchorSimple pageBodyPanel; // 0x1A8
	[SerializeField]
	private UIIruna2AnchorSimple pageFacePanel; // 0x1B0
	[SerializeField]
	private UIIruna2AnchorSimple pageHeadPanel; // 0x1B8
	[SerializeField]
	private UIIruna2AnchorSimple pageMenuPanel; // 0x1C0
	[SerializeField]
	private UIIruna2AnchorSimple pageRecipePanel; // 0x1C8
	[SerializeField]
	private UIIruna2AnchorSimple pageCheckPanel; // 0x1D0
	[SerializeField]
	private UIIruna2AnchorSimple lastPanel; // 0x1D8
	[SerializeField]
	private UIIruna2AnchorSimple openPanel; // 0x1E0
	[SerializeField]
	private UIIruna2AnchorSimple closePanel; // 0x1E8
	[SerializeField]
	private UIIruna2AnchorSimple currentItemView; // 0x1F0
	[SerializeField]
	private UIIruna2AnchorSimple determineButton; // 0x1F8
	[SerializeField]
	private UIIruna2AnchorSimple orbButton; // 0x200
	[SerializeField]
	private UIIruna2AnchorSimple orbViewPanel; // 0x208
	[SerializeField]
	private UIIruna2AnchorSimple equipSwitchButton; // 0x210
	[SerializeField]
	private RecreatePage menuPageButtonControl; // 0x218
	[SerializeField]
	private WindowCreater itemWindow; // 0x220
	[SerializeField]
	private RecreateItemLabel itemIcons; // 0x228
	[SerializeField]
	private RecreateRecipeWindow recipeWindow; // 0x230
	[SerializeField]
	private UIScrollWindow checkScrollWindow; // 0x238
	[SerializeField]
	private GameObject checkScrollElement; // 0x240
	[SerializeField]
	private GameObject orbIcon; // 0x248
	[SerializeField]
	private UILabel orbLabel; // 0x250
	[SerializeField]
	private UIImageButton confirmationButton; // 0x258
	[SerializeField]
	private TweenAlpha backgroundTween; // 0x260
	[SerializeField]
	private RecreateCompleteDialog completeDialog; // 0x268
	private Texture skinTex; // 0x270
	private Texture hairTex; // 0x278
	private Texture faceTex; // 0x280
	private RecipeDBDataManager recipeDBMaster; // 0x288
	private PlayerDataManager playerDataManager; // 0x290
	private UICharacterStyleData styleModelData; // 0x298
	private GameObject backgroundObject; // 0x2A0
	private int convertGroupId; // 0x2A8
	private Dictionary<RecreateType, int> defaultParameters; // 0x2B0
	private bool isItemOver; // 0x2B8
	private Dictionary<int, Pair<int, bool>> useItemList; // 0x2C0
	private int useOrbCount; // 0x2C8
	private int useSpina; // 0x2CC
	private MasterModelDataManager.OptionModelFlag hideFlag; // 0x2D0
	private UIPopWindow exitCheckWindow; // 0x2D8
	private bool IsLeave; // 0x2E0
	private float recconectWaitTime; // 0x2E4
	[SerializeField]
	private UIIruna2DragPinch dragPinch; // 0x2E8
	private readonly float defaultCameraDist; // 0x2F0
	private float cameraDist; // 0x2F4
	private readonly Vector3[] startPosition; // 0x2F8
	private readonly Vector3[] zoomPosition; // 0x300
	private readonly Vector3[] playerCameraRotation; // 0x308
	private readonly Vector3[] heightDifference; // 0x310

	// Properties
	private SystemTextManager sysTextManager { get; }
	private bool isPayOrb { get; }

	// Methods

	// RVA: 0x1DC6CCC Offset: 0x1DC2CCC VA: 0x1DC6CCC
	private SystemTextManager get_sysTextManager() { }

	// RVA: 0x1DC6DC4 Offset: 0x1DC2DC4 VA: 0x1DC6DC4
	public NewStyleData GetCharacterStyle() { }

	// RVA: 0x1DC6E8C Offset: 0x1DC2E8C VA: 0x1DC6E8C
	private byte getEyeColor(byte eye) { }

	// RVA: 0x1DC6E94 Offset: 0x1DC2E94 VA: 0x1DC6E94
	public byte GetWeaponNo() { }

	// RVA: 0x1DC6EA0 Offset: 0x1DC2EA0 VA: 0x1DC6EA0
	private bool get_isPayOrb() { }

	// RVA: 0x1DC6EBC Offset: 0x1DC2EBC VA: 0x1DC6EBC
	private void exitRecreate() { }

	// RVA: 0x1DC72A8 Offset: 0x1DC32A8 VA: 0x1DC72A8
	private void Awake() { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<Start>d__102))]
	// RVA: 0x1DC7398 Offset: 0x1DC3398 VA: 0x1DC7398
	private IEnumerator Start() { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<firstProc>d__103))]
	// RVA: 0x1DC740C Offset: 0x1DC340C VA: 0x1DC740C
	private IEnumerator firstProc() { }

	// RVA: 0x1DC7480 Offset: 0x1DC3480 VA: 0x1DC7480
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<initializeRecipe>d__105))]
	// RVA: 0x1DC7744 Offset: 0x1DC3744 VA: 0x1DC7744
	private IEnumerator initializeRecipe() { }

	// RVA: 0x1DC77B8 Offset: 0x1DC37B8 VA: 0x1DC77B8
	private void initializeMenu() { }

	// RVA: 0x1DC7B9C Offset: 0x1DC3B9C VA: 0x1DC7B9C
	private void initializeRecipeWindow(UIRecreatePanel.RecreateCategory category) { }

	// RVA: 0x1DC80C4 Offset: 0x1DC40C4 VA: 0x1DC80C4
	private void initializeCheckList() { }

	// RVA: 0x1DC8040 Offset: 0x1DC4040 VA: 0x1DC8040
	private void checkMoveRecipeWindow() { }

	// RVA: 0x1DC95C0 Offset: 0x1DC55C0 VA: 0x1DC95C0
	private void initializeProperty() { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<Initialize>d__111))]
	// RVA: 0x1DC9830 Offset: 0x1DC5830 VA: 0x1DC9830
	public IEnumerator Initialize() { }

	// RVA: 0x1DC98A4 Offset: 0x1DC58A4 VA: 0x1DC98A4
	private void setLabelColorFromItem(UILabel label, RecreateType type, int createId) { }

	// RVA: 0x1DC9B1C Offset: 0x1DC5B1C VA: 0x1DC9B1C
	private void setPlayerSex(int add) { }

	// RVA: 0x1DC9F8C Offset: 0x1DC5F8C VA: 0x1DC9F8C
	private void setHair(int add) { }

	// RVA: 0x1DCA294 Offset: 0x1DC6294 VA: 0x1DCA294
	private void setHead(int add) { }

	// RVA: 0x1DCA4A4 Offset: 0x1DC64A4 VA: 0x1DCA4A4
	private void setHairTail(int add) { }

	// RVA: 0x1DCA6B4 Offset: 0x1DC66B4 VA: 0x1DCA6B4
	private void setHairColor(int add) { }

	// RVA: 0x1DCAB5C Offset: 0x1DC6B5C VA: 0x1DCAB5C
	private void setHairStreakColor(int add) { }

	// RVA: 0x1DCAD50 Offset: 0x1DC6D50 VA: 0x1DCAD50
	private void setFace(int add) { }

	// RVA: 0x1DCB554 Offset: 0x1DC7554 VA: 0x1DCB554
	private void setEyeTex(int add) { }

	// RVA: 0x1DCB8B8 Offset: 0x1DC78B8 VA: 0x1DCB8B8
	private void setEyeColor(int add) { }

	// RVA: 0x1DCBA30 Offset: 0x1DC7A30 VA: 0x1DCBA30
	private void setOddEyeColor(int add) { }

	// RVA: 0x1DCBC24 Offset: 0x1DC7C24 VA: 0x1DCBC24
	private void setSkinColor(int add) { }

	// RVA: 0x1DCBD9C Offset: 0x1DC7D9C VA: 0x1DCBD9C
	private void setSkinTextureColor(int add) { }

	// RVA: 0x1DCC100 Offset: 0x1DC8100 VA: 0x1DCC100
	private void setHeight(int add) { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<loadBackground>d__126))]
	// RVA: 0x1DCC4E0 Offset: 0x1DC84E0 VA: 0x1DCC4E0
	private IEnumerator loadBackground() { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<loadSex>d__127))]
	// RVA: 0x1DC9D58 Offset: 0x1DC5D58 VA: 0x1DC9D58
	private IEnumerator loadSex(int sexId) { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<loadFace>d__128))]
	// RVA: 0x1DCB050 Offset: 0x1DC7050 VA: 0x1DCB050
	private IEnumerator loadFace(int loadFaceId) { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<loadHair>d__129))]
	// RVA: 0x1DCA210 Offset: 0x1DC6210 VA: 0x1DCA210
	private IEnumerator loadHair(int modelId) { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<loadHead>d__130))]
	// RVA: 0x1DCA420 Offset: 0x1DC6420 VA: 0x1DCA420
	private IEnumerator loadHead(int modelId) { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<loadHairTail>d__131))]
	// RVA: 0x1DCA630 Offset: 0x1DC6630 VA: 0x1DCA630
	private IEnumerator loadHairTail(int modelId) { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<LoadBodyModel>d__132))]
	// RVA: 0x1DCC554 Offset: 0x1DC8554 VA: 0x1DCC554
	private IEnumerator LoadBodyModel() { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<LoadDecoModel>d__133))]
	// RVA: 0x1DCC5C8 Offset: 0x1DC85C8 VA: 0x1DCC5C8
	private IEnumerator LoadDecoModel() { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<LoadOptionModel>d__134))]
	// RVA: 0x1DCC63C Offset: 0x1DC863C VA: 0x1DCC63C
	private IEnumerator LoadOptionModel() { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<cacheModel>d__135))]
	// RVA: 0x1DCC6B0 Offset: 0x1DC86B0 VA: 0x1DCC6B0
	private IEnumerator cacheModel(ModelManager.LoadModelType type, int id, string filePath, UnityAction<UICharacterModel> act) { }

	// RVA: 0x1DCC76C Offset: 0x1DC876C VA: 0x1DCC76C
	private UICharacterModel changeModel(string parts, int id, string addlabel) { }

	// RVA: 0x1DCCBF8 Offset: 0x1DC8BF8 VA: 0x1DCCBF8
	private UICharacterModel updateModel(UICharacterModel model, string parts, int id, string addlabel) { }

	// RVA: 0x1DCB0D4 Offset: 0x1DC70D4 VA: 0x1DCB0D4
	private void updateModel(int motionId, int motionQueuedId) { }

	// RVA: 0x1DCCF88 Offset: 0x1DC8F88 VA: 0x1DCCF88
	private void ChangeModel(UIRecreatePanel.PartsType type, string path, bool isActive = True) { }

	// RVA: 0x1DCD454 Offset: 0x1DC9454 VA: 0x1DCD454
	private void ChangeBodyModel() { }

	// RVA: 0x1DCE5D0 Offset: 0x1DCA5D0 VA: 0x1DCE5D0
	private void SetGroundPosition() { }

	// RVA: 0x1DCE844 Offset: 0x1DCA844 VA: 0x1DCE844
	public void EmotionPlay(float timer) { }

	// RVA: 0x1DCE8A0 Offset: 0x1DCA8A0 VA: 0x1DCE8A0
	public void EmotionPlay() { }

	// RVA: 0x1DCA82C Offset: 0x1DC682C VA: 0x1DCA82C
	private void changeModelSkinColor() { }

	// RVA: 0x1DCE8D8 Offset: 0x1DCA8D8 VA: 0x1DCE8D8
	private void SwitchEquipModel() { }

	// RVA: 0x1DCCD28 Offset: 0x1DC8D28 VA: 0x1DCCD28
	private void HideActiveSwitch(UIRecreatePanel.PartsType type) { }

	// RVA: 0x1DCEE98 Offset: 0x1DCAE98 VA: 0x1DCEE98
	private void SetDefaultModel(UIRecreatePanel.PartsType type, UICharacterModel model, int checkModelSexId) { }

	// RVA: 0x1DCF274 Offset: 0x1DCB274 VA: 0x1DCF274
	private void SetEquipModel(UIRecreatePanel.PartsType type, UICharacterModel model, byte[] colors) { }

	// RVA: 0x1DCF3C8 Offset: 0x1DCB3C8 VA: 0x1DCF3C8
	private void toMenuPage() { }

	// RVA: 0x1DCF47C Offset: 0x1DCB47C VA: 0x1DCF47C
	private void switchCurrentItemView() { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<switchCurrentItemViewCoroutine>d__151))]
	// RVA: 0x1DCF49C Offset: 0x1DCB49C VA: 0x1DCF49C
	private IEnumerator switchCurrentItemViewCoroutine() { }

	// RVA: 0x1DCF510 Offset: 0x1DCB510 VA: 0x1DCF510
	private void onMenuPage() { }

	// RVA: 0x1DCF5D4 Offset: 0x1DCB5D4 VA: 0x1DCF5D4
	private void onBodyPage() { }

	// RVA: 0x1DCF6D8 Offset: 0x1DCB6D8 VA: 0x1DCF6D8
	private void onHeadPage() { }

	// RVA: 0x1DCFA64 Offset: 0x1DCBA64 VA: 0x1DCFA64
	private void onFacePage() { }

	// RVA: 0x1DCFB68 Offset: 0x1DCBB68 VA: 0x1DCFB68
	private void onVoicePage() { }

	// RVA: 0x1DCFB6C Offset: 0x1DCBB6C VA: 0x1DCFB6C
	private void onCheckPage() { }

	// RVA: 0x1DCFCA0 Offset: 0x1DCBCA0 VA: 0x1DCFCA0
	private void onRecipeOpen() { }

	// RVA: 0x1DCFD58 Offset: 0x1DCBD58 VA: 0x1DCFD58
	private void onRecipeClose() { }

	// RVA: 0x1DC7084 Offset: 0x1DC3084 VA: 0x1DC7084
	public void ChangePage(UIRecreatePanel.PanelSettingFlag setting) { }

	// RVA: 0x1DCFEBC Offset: 0x1DCBEBC VA: 0x1DCFEBC
	private void toBodySelect() { }

	// RVA: 0x1DCFF10 Offset: 0x1DCBF10 VA: 0x1DCFF10
	private void toFaceSelect() { }

	// RVA: 0x1DCFF64 Offset: 0x1DCBF64 VA: 0x1DCFF64
	private void toHeadSelect() { }

	// RVA: 0x1DCFFB8 Offset: 0x1DCBFB8 VA: 0x1DCFFB8
	private void toVoiceSelect() { }

	// RVA: 0x1DD000C Offset: 0x1DCC00C VA: 0x1DD000C
	private void toCheckSelect() { }

	// RVA: 0x1DD0060 Offset: 0x1DCC060 VA: 0x1DD0060
	private void switchOrbUse() { }

	// RVA: 0x1DD0158 Offset: 0x1DCC158 VA: 0x1DD0158
	private void onConfirmation() { }

	// RVA: 0x1DD02D4 Offset: 0x1DCC2D4 VA: 0x1DD02D4
	private void OnSwitchModel() { }

	// RVA: 0x1DC7A18 Offset: 0x1DC3A18 VA: 0x1DC7A18
	private bool checkEnableCategory(List<RecreateType> types) { }

	// RVA: 0x1DD02F8 Offset: 0x1DCC2F8 VA: 0x1DD02F8
	private bool checkCanChange(List<RecipeDBData> recipes) { }

	// RVA: 0x1DD0440 Offset: 0x1DCC440 VA: 0x1DD0440
	private bool haveRecipeItem(RecipeDBData recipe) { }

	// RVA: 0x1DC99CC Offset: 0x1DC59CC VA: 0x1DC99CC
	private bool haveRecipeItem(RecreateType type, int createId) { }

	// RVA: 0x1DD0644 Offset: 0x1DCC644 VA: 0x1DD0644
	private int getNextModelIdSeeker(int tempIndex, RecreateType type, int[] modelIdList, Func<int, int> seeker) { }

	// RVA: 0x1DCA118 Offset: 0x1DC6118 VA: 0x1DCA118
	private int getNextModelId(RecreateType type, int currentModelId, int add, int modelCount, int[] modelIdList) { }

	// RVA: 0x1DD08D0 Offset: 0x1DCC8D0 VA: 0x1DD08D0
	private int getModelIdFromIndex(int index, int[] modelIdList) { }

	// RVA: 0x1DC9DDC Offset: 0x1DC5DDC VA: 0x1DC9DDC
	private void recreateTypeChangedCallback(RecreateType type, int createId) { }

	// RVA: 0x1DC7EFC Offset: 0x1DC3EFC VA: 0x1DC7EFC
	private RecipeDBData getRecipeData(RecreateType type, int createId) { }

	// RVA: 0x1DD0900 Offset: 0x1DCC900 VA: 0x1DD0900
	private void updateRequireItems() { }

	// RVA: 0x1DCFDE4 Offset: 0x1DCBDE4 VA: 0x1DCFDE4
	private void checkDetermineButton() { }

	// RVA: 0x1DC9CE0 Offset: 0x1DC5CE0 VA: 0x1DC9CE0
	private string getModelIndexString(int modelId, int[] modelList) { }

	// RVA: 0x1DD0884 Offset: 0x1DCC884 VA: 0x1DD0884
	private int getModelIndex(int modelId, int[] modelList) { }

	// RVA: 0x1DCC314 Offset: 0x1DC8314 VA: 0x1DCC314
	public void SetSexCameraPosition(bool zoom) { }

	// RVA: 0x1DD0904 Offset: 0x1DCC904 VA: 0x1DD0904
	public void SetCameraPosition(Vector3 position, Vector3 rot) { }

	// RVA: 0x1DD0A8C Offset: 0x1DCCA8C VA: 0x1DD0A8C
	private void Update() { }

	// RVA: 0x1DD0D7C Offset: 0x1DCCD7C VA: 0x1DD0D7C
	private void LateUpdate() { }

	// RVA: 0x1DD0E98 Offset: 0x1DCCE98 VA: 0x1DD0E98
	private void OnWillRenderObject() { }

	// RVA: 0x1DD0D80 Offset: 0x1DCCD80 VA: 0x1DD0D80
	private void HeadUpdate() { }

	// RVA: 0x1DCCEAC Offset: 0x1DC8EAC VA: 0x1DCCEAC
	private void playAnimationChildren(int motionId, bool queued) { }

	// RVA: 0x1DD0E9C Offset: 0x1DCCE9C VA: 0x1DD0E9C
	private void CreateExitCheckWindow() { }

	// RVA: 0x1DD103C Offset: 0x1DCD03C VA: 0x1DD103C
	private void OnExitCancel() { }

	// RVA: 0x1DD02B4 Offset: 0x1DCC2B4 VA: 0x1DD02B4
	private void startConnection() { }

	[IteratorStateMachine(typeof(UIRecreatePanel.<startConnectionCoroutine>d__199))]
	// RVA: 0x1DD10D0 Offset: 0x1DCD0D0 VA: 0x1DD10D0
	private IEnumerator startConnectionCoroutine() { }

	// RVA: 0x1DD1144 Offset: 0x1DCD144 VA: 0x1DD1144
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1DD1D3C Offset: 0x1DCDD3C VA: 0x1DD1D3C
	private void <exitRecreate>b__100_0() { }

	[CompilerGenerated]
	// RVA: 0x1DD1E10 Offset: 0x1DCDE10 VA: 0x1DD1E10
	private void <Initialize>b__111_0(UICharacterModel m) { }

	[CompilerGenerated]
	// RVA: 0x1DD1E20 Offset: 0x1DCDE20 VA: 0x1DD1E20
	private void <Initialize>b__111_1(UICharacterModel m) { }

	[CompilerGenerated]
	// RVA: 0x1DD1E30 Offset: 0x1DCDE30 VA: 0x1DD1E30
	private void <Initialize>b__111_2(UICharacterModel m) { }

	[CompilerGenerated]
	// RVA: 0x1DD1E40 Offset: 0x1DCDE40 VA: 0x1DD1E40
	private void <Initialize>b__111_3(UICharacterModel m) { }

	[CompilerGenerated]
	// RVA: 0x1DD1E50 Offset: 0x1DCDE50 VA: 0x1DD1E50
	private void <Initialize>b__111_4(UICharacterModel m) { }

	[CompilerGenerated]
	// RVA: 0x1DD1E60 Offset: 0x1DCDE60 VA: 0x1DD1E60
	private void <Initialize>b__111_5(UICharacterModel m) { }

	[CompilerGenerated]
	// RVA: 0x1DD1E70 Offset: 0x1DCDE70 VA: 0x1DD1E70
	private void <Initialize>b__111_6(UICharacterModel m) { }

	[CompilerGenerated]
	// RVA: 0x1DD1E80 Offset: 0x1DCDE80 VA: 0x1DD1E80
	private void <Initialize>b__111_7(UICharacterModel m) { }

	[CompilerGenerated]
	// RVA: 0x1DD1E90 Offset: 0x1DCDE90 VA: 0x1DD1E90
	private void <Initialize>b__111_8(UICharacterModel m) { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1DD1EA0 Offset: 0x1DCDEA0 VA: 0x1DD1EA0
	private void <>n__0() { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1DD1EA8 Offset: 0x1DCDEA8 VA: 0x1DD1EA8
	private void <>n__1(Action pushFunction) { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithManufacture : SmithUIMaterialBase // TypeDefIndex: 8518
{
	// Fields
	protected static readonly int[] limitedCategoryRange; // 0x0
	[SerializeField]
	protected UIScrollWindow Scroll; // 0x68
	[SerializeField]
	protected GameObject AddElement; // 0x70
	[SerializeField]
	protected UILabel AddElementLabel; // 0x78
	[SerializeField]
	protected UILabel[] AddElementSubLabel; // 0x80
	[SerializeField]
	protected UILabel AddElementCreateValLabel; // 0x88
	[SerializeField]
	protected float ElementSpace; // 0x90
	[SerializeField]
	protected GameObject MaterialList; // 0x98
	[SerializeField]
	protected UIImageButton RecipeButton; // 0xA0
	[SerializeField]
	protected UIImageButton InfomationButton; // 0xA8
	[SerializeField]
	protected UIImageButton ManufactureButton; // 0xB0
	[SerializeField]
	protected UIIruna2AnchorSimple MainView; // 0xB8
	[SerializeField]
	protected SmithManufactureDialog InfoWindowDialog; // 0xC0
	[SerializeField]
	protected SmithManufactureCompleteDialog CompleteDialog; // 0xC8
	[SerializeField]
	protected GameObject ManufactureButtonObj; // 0xD0
	[SerializeField]
	protected UIWidget upperBackGround; // 0xD8
	[SerializeField]
	protected GameObject scrollBackGround; // 0xE0
	[SerializeField]
	protected Camera scrollCamera; // 0xE8
	[SerializeField]
	protected UIIruna2AnchorSimple detailAnchor; // 0xF0
	[SerializeField]
	protected UILabel detailLabel; // 0xF8
	[SerializeField]
	protected UILabel selectCategoryLabel; // 0x100
	[SerializeField]
	protected UILabel cannotCreateLabel; // 0x108
	[SerializeField]
	private GameObject strengthEffectBackground; // 0x110
	[SerializeField]
	private GameObject strengthEffectParent; // 0x118
	[SerializeField]
	private LocalizeText manufactureStartButton; // 0x120
	[SerializeField]
	protected GameObject materialSearchButtonObj; // 0x128
	[SerializeField]
	private GameObject[] manufactureButtonIconObjs; // 0x130
	protected ItemPropertyTextManager itemPropertyTextManager; // 0x138
	protected RecipeDBDataManager recipeManager; // 0x140
	protected List<Dictionary<int, List<RecipeDBData>>> RecipeDatas; // 0x148
	protected InactiveTimer windowInactiveTimer; // 0x150
	protected int WeaponType; // 0x158
	protected int WeaponLv; // 0x15C
	protected int WeaponIndex; // 0x160
	protected Vector3 cameraHistoryType; // 0x164
	protected Dictionary<int, Vector3> cameraHistoryLv; // 0x170
	protected Dictionary<int, Dictionary<int, Vector4>> cameraHistoryWeapon; // 0x178
	[CompilerGenerated]
	private bool <IsMaterialSearchPopWindow>k__BackingField; // 0x180
	protected PlayerDataManager playerDataManager; // 0x188
	private UIPopBaseWindow popUpWindow; // 0x190
	private InactiveTimer popUpWindowInactiveTimer; // 0x198
	private bool cancelCheck; // 0x1A0
	protected List<MaterialSearchData> recipeMaterialData; // 0x1A8
	protected List<GameObject> AddedElement; // 0x1B0
	protected string[] TypeNameList; // 0x1B8
	protected string[] WeaponNameList; // 0x1C0
	protected List<Trio<int, int, byte>> RequiredMaterialData; // 0x1C8
	private UIPopWindow errorPopWindow; // 0x1D0
	private bool isConnect; // 0x1D8
	private EquipmentProductionResponse connectResponse; // 0x1E0

	// Properties
	protected bool IsMaterialSearchPopWindow { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D8D7F8 Offset: 0x1D897F8 VA: 0x1D8D7F8
	protected bool get_IsMaterialSearchPopWindow() { }

	[CompilerGenerated]
	// RVA: 0x1D8D800 Offset: 0x1D89800 VA: 0x1D8D800
	private void set_IsMaterialSearchPopWindow(bool value) { }

	// RVA: 0x1D8D80C Offset: 0x1D8980C VA: 0x1D8D80C
	private void Awake() { }

	[IteratorStateMachine(typeof(SmithManufacture.<getAccountLevel>d__56))]
	// RVA: 0x1D8DB28 Offset: 0x1D89B28 VA: 0x1D8DB28
	protected IEnumerator getAccountLevel() { }

	[IteratorStateMachine(typeof(SmithManufacture.<Start>d__57))]
	// RVA: 0x1D8DB80 Offset: 0x1D89B80 VA: 0x1D8DB80 Slot: 6
	protected virtual IEnumerator Start() { }

	// RVA: 0x1D8DBF4 Offset: 0x1D89BF4 VA: 0x1D8DBF4
	protected void Update() { }

	// RVA: 0x1D8DBF8 Offset: 0x1D89BF8 VA: 0x1D8DBF8 Slot: 5
	protected override void OnDestroy() { }

	// RVA: 0x1D8DC9C Offset: 0x1D89C9C VA: 0x1D8DC9C
	private RecipeDBData[] loadRecipe(RecipeDBDataManager recipeManager, int category, int proficiency, bool isShop) { }

	// RVA: 0x1D8DE24 Offset: 0x1D89E24 VA: 0x1D8DE24 Slot: 7
	public virtual void InitTypeSelect() { }

	// RVA: 0x1D8F92C Offset: 0x1D8B92C VA: 0x1D8F92C Slot: 8
	public virtual void InitLevelSelectFromElement(int index) { }

	// RVA: 0x1D8F9A0 Offset: 0x1D8B9A0 VA: 0x1D8F9A0 Slot: 9
	public virtual void InitLevelSelect(int index) { }

	// RVA: 0x1D90920 Offset: 0x1D8C920 VA: 0x1D90920
	private bool isSkipType(int weaponTypeIndex) { }

	// RVA: 0x1D91980 Offset: 0x1D8D980 VA: 0x1D91980 Slot: 10
	public virtual void InitWeaponSelectFromElement(int index, bool isSkip = False) { }

	// RVA: 0x1D91A4C Offset: 0x1D8DA4C VA: 0x1D91A4C Slot: 11
	public virtual void InitWeaponSelect(int index, bool isSkip) { }

	// RVA: 0x1D928E0 Offset: 0x1D8E8E0 VA: 0x1D928E0
	public void CreateManufactureNextLevelElement(int index, int nextLevel, int category) { }

	// RVA: 0x1D92FE4 Offset: 0x1D8EFE4 VA: 0x1D92FE4
	private bool IsCreateNextLevelLabel(int category, int nextLevel) { }

	// RVA: 0x1D8F61C Offset: 0x1D8B61C VA: 0x1D8F61C
	protected Dictionary<int, List<RecipeDBData>> GetRecipeListByLevel(RecipeDBData[] recipeData) { }

	// RVA: 0x1D8F178 Offset: 0x1D8B178 VA: 0x1D8F178
	protected Dictionary<int, List<RecipeDBData>> GetRecipeListByItemType(RecipeDBData[] recipeData) { }

	// RVA: 0x1D8F480 Offset: 0x1D8B480 VA: 0x1D8F480
	protected string GetCategoryName(int type) { }

	// RVA: 0x1D8F528 Offset: 0x1D8B528 VA: 0x1D8F528
	protected int GetRecipeDataElementsCount(RecipeDBData[] recipeData, int accountLevel) { }

	// RVA: 0x1D909F0 Offset: 0x1D8C9F0 VA: 0x1D909F0
	protected void CreateItemTypeWindow(Dictionary<int, List<RecipeDBData>> recipe, GameObject elem) { }

	// RVA: 0x1D930B8 Offset: 0x1D8F0B8 VA: 0x1D930B8 Slot: 12
	public virtual void SelectElement(int index) { }

	// RVA: 0x1D93514 Offset: 0x1D8F514 VA: 0x1D93514 Slot: 13
	public virtual void SelectElementFirst(int index) { }

	[IteratorStateMachine(typeof(SmithManufacture.<selectElementWait>d__76))]
	// RVA: 0x1D93480 Offset: 0x1D8F480 VA: 0x1D93480
	protected IEnumerator selectElementWait(int index, float waitTime) { }

	// RVA: 0x1D937A8 Offset: 0x1D8F7A8 VA: 0x1D937A8 Slot: 14
	public virtual void SetRequiredMaterial(int index) { }

	[IteratorStateMachine(typeof(SmithManufacture.<PopUpWindow>d__78))]
	// RVA: 0x1D94CB8 Offset: 0x1D90CB8 VA: 0x1D94CB8
	protected IEnumerator PopUpWindow() { }

	// RVA: 0x1D94D2C Offset: 0x1D90D2C VA: 0x1D94D2C
	public void OnInfomationButton() { }

	// RVA: 0x1D8F0E0 Offset: 0x1D8B0E0 VA: 0x1D8F0E0
	public void OnRecipeButton() { }

	// RVA: 0x1D94DC4 Offset: 0x1D90DC4 VA: 0x1D94DC4
	public void OnManufactureButton() { }

	// RVA: 0x1D95518 Offset: 0x1D91518 VA: 0x1D95518
	public void OnManufactureStartButton() { }

	// RVA: 0x1D95714 Offset: 0x1D91714 VA: 0x1D95714
	public void OnManufactureCompleteButton() { }

	// RVA: 0x1D95928 Offset: 0x1D91928 VA: 0x1D95928 Slot: 15
	protected virtual void OnMaterialSearchButon() { }

	// RVA: 0x1D95C10 Offset: 0x1D91C10 VA: 0x1D95C10
	protected void OnMyQuestRegister() { }

	[IteratorStateMachine(typeof(SmithManufacture.<ConnectWaitManufacture>d__86))]
	// RVA: 0x1D95C14 Offset: 0x1D91C14 VA: 0x1D95C14 Slot: 16
	protected virtual IEnumerator ConnectWaitManufacture() { }

	[IteratorStateMachine(typeof(SmithManufacture.<SetSpriteAlpha>d__87))]
	// RVA: 0x1D95C88 Offset: 0x1D91C88 VA: 0x1D95C88
	private IEnumerator SetSpriteAlpha(UISprite spr, float toAlpha, float time) { }

	[IteratorStateMachine(typeof(SmithManufacture.<EquipmentProductionConnect>d__88))]
	// RVA: 0x1D95D10 Offset: 0x1D91D10 VA: 0x1D95D10
	private IEnumerator EquipmentProductionConnect(TakeController takeController, int takeUid) { }

	// RVA: 0x1D95854 Offset: 0x1D91854 VA: 0x1D95854
	protected void ToTypeSelect() { }

	// RVA: 0x1D95DA8 Offset: 0x1D91DA8 VA: 0x1D95DA8
	protected void ToLevelSelect() { }

	// RVA: 0x1D92828 Offset: 0x1D8E828 VA: 0x1D92828
	protected void SetEnableRecipeButton(bool enable) { }

	// RVA: 0x1D92884 Offset: 0x1D8E884 VA: 0x1D92884
	protected void SetEnableInfomationButton(bool enable) { }

	// RVA: 0x1D94C98 Offset: 0x1D90C98 VA: 0x1D94C98
	protected void SetEnableButton(UIImageButton button, bool enable) { }

	// RVA: 0x1D8F960 Offset: 0x1D8B960 VA: 0x1D8F960
	protected void SaveCurrentCameraPosition(ref Vector3 history) { }

	// RVA: 0x1D919C0 Offset: 0x1D8D9C0 VA: 0x1D919C0
	protected void SaveCurrentCameraPosition(int weaponType, ref Dictionary<int, Vector3> history) { }

	// RVA: 0x1D932F4 Offset: 0x1D8F2F4 VA: 0x1D932F4
	protected void SaveCurrentCameraPosition(int weaponType, int lvType, int weapon, ref Dictionary<int, Dictionary<int, Vector4>> history) { }

	// RVA: 0x1D8F8F0 Offset: 0x1D8B8F0 VA: 0x1D8F8F0
	protected void LoadCameraPosition(ref Vector3 history) { }

	// RVA: 0x1D918B0 Offset: 0x1D8D8B0 VA: 0x1D918B0
	protected void LoadCameraPosition(int weaponType, ref Dictionary<int, Vector3> history) { }

	// RVA: 0x1D92EB0 Offset: 0x1D8EEB0 VA: 0x1D92EB0
	protected void LoadCameraPosition(int weaponType, int lv, ref Dictionary<int, Dictionary<int, Vector4>> history) { }

	// RVA: 0x1D92D9C Offset: 0x1D8ED9C VA: 0x1D92D9C
	protected int GetHistorySelectedWeapon(int weaponType, int lv, ref Dictionary<int, Dictionary<int, Vector4>> history) { }

	// RVA: 0x1D95DB8 Offset: 0x1D91DB8 VA: 0x1D95DB8
	private void ManufactureIconTweenScaleSet(GameObject obj, float delay, int no) { }

	// RVA: 0x1D95278 Offset: 0x1D91278 VA: 0x1D95278
	private void ScrollPositionAdjust() { }

	// RVA: 0x1D96020 Offset: 0x1D92020 VA: 0x1D96020
	protected void ToWeaponeSelectFromCheckDialog() { }

	// RVA: 0x1D96194 Offset: 0x1D92194 VA: 0x1D96194 Slot: 17
	protected virtual bool CheckManufactureMaterial(List<Trio<int, int, byte>> data, int startIndex, int count, RecipeDBData recipe) { }

	// RVA: 0x1D964E0 Offset: 0x1D924E0 VA: 0x1D964E0
	public void .ctor() { }

	// RVA: 0x1D966F0 Offset: 0x1D926F0 VA: 0x1D966F0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1D96790 Offset: 0x1D92790 VA: 0x1D96790
	private void <SetRequiredMaterial>b__77_0() { }

	[CompilerGenerated]
	// RVA: 0x1D967C0 Offset: 0x1D927C0 VA: 0x1D967C0
	private void <SetRequiredMaterial>b__77_1() { }

	[CompilerGenerated]
	// RVA: 0x1D967F4 Offset: 0x1D927F4 VA: 0x1D967F4
	private void <OnMaterialSearchButon>b__84_0() { }

	[CompilerGenerated]
	// RVA: 0x1D96864 Offset: 0x1D92864 VA: 0x1D96864
	private void <EquipmentProductionConnect>b__88_0() { }
}

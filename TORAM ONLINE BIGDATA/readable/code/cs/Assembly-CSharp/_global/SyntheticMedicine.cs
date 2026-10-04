// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SyntheticMedicine : SmithManufacture // TypeDefIndex: 8730
{
	// Fields
	[SerializeField]
	private GameObject SliderObj; // 0x1E8
	[SerializeField]
	private CountSystem countSystem; // 0x1F0
	[SerializeField]
	private LocalizeText createCountLabel; // 0x1F8
	[SerializeField]
	private SyntheticMedicineCreateBar createBar; // 0x200
	[SerializeField]
	private UIImageButton createButton; // 0x208
	[SerializeField]
	private LocalizeText createWarningLabel; // 0x210
	[SerializeField]
	private GameObject medicineEffectParent; // 0x218
	[SerializeField]
	private GameObject medicineEffectModelParent; // 0x220
	[SerializeField]
	private GameObject medicineEffectBackground; // 0x228
	[SerializeField]
	private GameObject cancelButton; // 0x230
	[SerializeField]
	private GameObject mainViewFrame; // 0x238
	private Vector3 labelDefaultPos; // 0x240
	[SerializeField]
	private UILabel titleLabel; // 0x250
	[SerializeField]
	private UISprites titleFrame; // 0x258
	private bool isCanceled; // 0x260
	private Coroutine syntheticMedicinCreateBar; // 0x268
	[SerializeField]
	private GameObject anyBagFullPanelObj; // 0x270
	[SerializeField]
	private UILabel[] anyBugFullLabels; // 0x278
	[SerializeField]
	private UISprite detailCristaIcon; // 0x280
	[SerializeField]
	private UIScrollWindow detailTextScrollWindow; // 0x288
	private CreateMedicineResponse connectResponse; // 0x290

	// Methods

	// RVA: 0x1DF2308 Offset: 0x1DEE308 VA: 0x1DF2308
	private void Awake() { }

	[IteratorStateMachine(typeof(SyntheticMedicine.<Start>d__23))]
	// RVA: 0x1DF26AC Offset: 0x1DEE6AC VA: 0x1DF26AC Slot: 6
	protected override IEnumerator Start() { }

	[IteratorStateMachine(typeof(SyntheticMedicine.<checkBagFreeSpace>d__24))]
	// RVA: 0x1DF2720 Offset: 0x1DEE720 VA: 0x1DF2720
	private IEnumerator checkBagFreeSpace() { }

	// RVA: 0x1DF2794 Offset: 0x1DEE794 VA: 0x1DF2794
	public void OnAnyBagFullButton() { }

	// RVA: 0x1DF27B4 Offset: 0x1DEE7B4 VA: 0x1DF27B4 Slot: 7
	public override void InitTypeSelect() { }

	// RVA: 0x1DF3C08 Offset: 0x1DEFC08 VA: 0x1DF3C08 Slot: 11
	public override void InitWeaponSelect(int index, bool isSkip) { }

	// RVA: 0x1DF3C98 Offset: 0x1DEFC98 VA: 0x1DF3C98 Slot: 14
	public override void SetRequiredMaterial(int index) { }

	[IteratorStateMachine(typeof(SyntheticMedicine.<UpdateDetailScrollBar>d__29))]
	// RVA: 0x1DF56F4 Offset: 0x1DF16F4 VA: 0x1DF56F4
	private IEnumerator UpdateDetailScrollBar() { }

	// RVA: 0x1DF4510 Offset: 0x1DF0510 VA: 0x1DF4510
	private void updateRequireMaterial(int count) { }

	// RVA: 0x1DF5828 Offset: 0x1DF1828 VA: 0x1DF5828
	private void onCreate() { }

	[IteratorStateMachine(typeof(SyntheticMedicine.<ConnectWaitManufacture>d__32))]
	// RVA: 0x1DF5894 Offset: 0x1DF1894 VA: 0x1DF5894 Slot: 16
	protected override IEnumerator ConnectWaitManufacture() { }

	[IteratorStateMachine(typeof(SyntheticMedicine.<showMedicineEffect>d__33))]
	// RVA: 0x1DF5908 Offset: 0x1DF1908 VA: 0x1DF5908
	private IEnumerator showMedicineEffect(int sendCount, Action nextCallback, Action<CreateMedicineResponse> responseCallback) { }

	// RVA: 0x1DF59BC Offset: 0x1DF19BC VA: 0x1DF59BC Slot: 17
	protected override bool CheckManufactureMaterial(List<Trio<int, int, byte>> data, int startIndex, int count, RecipeDBData recipe) { }

	// RVA: 0x1DF5768 Offset: 0x1DF1768 VA: 0x1DF5768
	private double getMaterialRate(bool isShop) { }

	// RVA: 0x1DF5D6C Offset: 0x1DF1D6C VA: 0x1DF5D6C
	private void onSetCount() { }

	// RVA: 0x1DF6350 Offset: 0x1DF2350 VA: 0x1DF6350
	private void onRemoveCount() { }

	// RVA: 0x1DF5F68 Offset: 0x1DF1F68 VA: 0x1DF5F68
	private void updateCreateNumLabel() { }

	// RVA: 0x1DF6408 Offset: 0x1DF2408 VA: 0x1DF6408
	private void CreateBarStop() { }

	[IteratorStateMachine(typeof(SyntheticMedicine.<SynthesizeMedicineWait>d__40))]
	// RVA: 0x1DF6474 Offset: 0x1DF2474 VA: 0x1DF6474
	private IEnumerator SynthesizeMedicineWait(UnityAction<bool, GameReturnCode> callback) { }

	// RVA: 0x1DF64E8 Offset: 0x1DF24E8 VA: 0x1DF64E8
	private void OnCancel() { }

	// RVA: 0x1DF652C Offset: 0x1DF252C VA: 0x1DF652C
	private void onClose() { }

	// RVA: 0x1DF65B0 Offset: 0x1DF25B0 VA: 0x1DF65B0 Slot: 15
	protected override void OnMaterialSearchButon() { }

	// RVA: 0x1DF65B8 Offset: 0x1DF25B8 VA: 0x1DF65B8
	private void CreateShop(int shopId, short[] position, int recipeId, short createNum) { }

	// RVA: 0x1DF6680 Offset: 0x1DF2680 VA: 0x1DF6680
	private void CreateSkill(int recipeId, short createNum, ItemSelectData selectItem) { }

	// RVA: 0x1DF6730 Offset: 0x1DF2730 VA: 0x1DF6730
	public void OnSyntheticInfomationButton() { }

	// RVA: 0x1DF67A8 Offset: 0x1DF27A8 VA: 0x1DF67A8
	public void .ctor() { }
}

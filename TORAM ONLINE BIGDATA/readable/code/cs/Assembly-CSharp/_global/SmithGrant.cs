// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithGrant : SmithUIMaterialBase // TypeDefIndex: 8486
{
	// Fields
	[SerializeField]
	private List<Pair<string, int>> WeaponNameList; // 0x68
	[SerializeField]
	private UIScrollWindow Scroll; // 0x70
	[SerializeField]
	private GameObject AddElement; // 0x78
	[SerializeField]
	private UILabel AddElementLabel; // 0x80
	[SerializeField]
	private UILabel AddElementOXLabel; // 0x88
	[SerializeField]
	private UILabel CheckPotentialLabel; // 0x90
	[SerializeField]
	private float ElementSpace; // 0x98
	[SerializeField]
	private UIIruna2AnchorSimple MainView; // 0xA0
	[SerializeField]
	private UIIruna2AnchorSimple MainWindow; // 0xA8
	[SerializeField]
	private SmithGrantInfoWindow InfoWindow; // 0xB0
	[SerializeField]
	private UIIruna2AnchorSimple WarningWindow; // 0xB8
	[SerializeField]
	private LocalizeText successRateLabel; // 0xC0
	[SerializeField]
	private UIImageButton grantWarningStartButton; // 0xC8
	[SerializeField]
	private SmithGrantCompleteDialog CompleteWIndow; // 0xD0
	[SerializeField]
	private GameObject GrantStartButton; // 0xD8
	[SerializeField]
	private GameObject takeEffectParent; // 0xE0
	[SerializeField]
	private GameObject takeEffectBackGround; // 0xE8
	private static readonly int MaxSlotNum; // 0x0
	private Pair<string, int>[] SlotDetail; // 0xF0
	[SerializeField]
	private int[] RequireMaterial; // 0xF8
	[SerializeField]
	private GameObject noCotainsLabel; // 0x100
	[SerializeField]
	private GameObject attentionWindowObj; // 0x108
	[SerializeField]
	private UILabel attentionLabel; // 0x110
	private SmithGrant.RequireData SlotRequire; // 0x118
	private int[] SelectedIndex; // 0x120
	private List<int> showEnhance; // 0x128
	private List<GameObject> AddedElement; // 0x130
	private PlayerDataManager playerDataManager; // 0x138
	private ItemData selectedItemData; // 0x140
	private EnhanceEquipmentResponse connectResponse; // 0x148
	private bool isGrantConnecting; // 0x150

	// Properties
	private bool isElement { get; }

	// Methods

	// RVA: 0x1D78680 Offset: 0x1D74680 VA: 0x1D78680
	private bool get_isElement() { }

	// RVA: 0x1D786B4 Offset: 0x1D746B4 VA: 0x1D786B4
	private void Awake() { }

	// RVA: 0x1D788CC Offset: 0x1D748CC VA: 0x1D788CC
	private void Start() { }

	// RVA: 0x1D797EC Offset: 0x1D757EC VA: 0x1D797EC
	private void Update() { }

	// RVA: 0x1D78904 Offset: 0x1D74904 VA: 0x1D78904
	private void Reset() { }

	// RVA: 0x1D79910 Offset: 0x1D75910 VA: 0x1D79910
	private void SetEquipEnhance() { }

	// RVA: 0x1D78DE4 Offset: 0x1D74DE4 VA: 0x1D78DE4
	public void InitWeaponSelect() { }

	// RVA: 0x1D7ACF8 Offset: 0x1D76CF8 VA: 0x1D7ACF8
	public void InitSlotSelect() { }

	// RVA: 0x1D7BE14 Offset: 0x1D77E14 VA: 0x1D7BE14
	public void InitMaterialTypeSelect() { }

	// RVA: 0x1D7C6C4 Offset: 0x1D786C4 VA: 0x1D7C6C4
	public void InitDetailSelect() { }

	// RVA: 0x1D7D228 Offset: 0x1D79228 VA: 0x1D7D228
	private void InitCompleteWindow(bool result, Pair<short, short>[] properties) { }

	// RVA: 0x1D7A060 Offset: 0x1D76060 VA: 0x1D7A060
	public void SetSelected(int step, int index) { }

	// RVA: 0x1D7D938 Offset: 0x1D79938 VA: 0x1D7D938
	public void SetRequireMaterial() { }

	// RVA: 0x1D7ABB4 Offset: 0x1D76BB4 VA: 0x1D7ABB4
	private int getEmptySlotCount() { }

	// RVA: 0x1D7DF38 Offset: 0x1D79F38 VA: 0x1D7DF38
	public void OnGrantCheckButton() { }

	// RVA: 0x1D7E0D8 Offset: 0x1D7A0D8 VA: 0x1D7E0D8
	public void ToSlotSelectFromCheck() { }

	// RVA: 0x1D7E11C Offset: 0x1D7A11C VA: 0x1D7E11C
	public void OnGrantBeforeStartButton() { }

	// RVA: 0x1D7E5D8 Offset: 0x1D7A5D8 VA: 0x1D7E5D8
	private void ToBeforeStartPanel() { }

	// RVA: 0x1D7E570 Offset: 0x1D7A570 VA: 0x1D7E570
	public void OnGrantStartButton() { }

	// RVA: 0x1D7E6D4 Offset: 0x1D7A6D4 VA: 0x1D7E6D4
	public void ToSlotFromWarning() { }

	// RVA: 0x1D7E748 Offset: 0x1D7A748 VA: 0x1D7E748
	public void OnGrantWarningButton() { }

	// RVA: 0x1D7E7C0 Offset: 0x1D7A7C0 VA: 0x1D7E7C0
	public void ToWeaponSelectFromComplete() { }

	// RVA: 0x1D7E960 Offset: 0x1D7A960 VA: 0x1D7E960
	public void OnGrantWeaponSelected() { }

	// RVA: 0x1D7E83C Offset: 0x1D7A83C VA: 0x1D7E83C
	public void ToWeaponSelect() { }

	// RVA: 0x1D7EB60 Offset: 0x1D7AB60 VA: 0x1D7EB60
	public void OnDetailButton(int detailValue) { }

	[IteratorStateMachine(typeof(SmithGrant.<ConnectWaitManufactureGuard>d__59))]
	// RVA: 0x1D7E660 Offset: 0x1D7A660 VA: 0x1D7E660
	private IEnumerator ConnectWaitManufactureGuard() { }

	[IteratorStateMachine(typeof(SmithGrant.<ConnectWaitManufacture>d__60))]
	// RVA: 0x1D7EBC8 Offset: 0x1D7ABC8 VA: 0x1D7EBC8
	private IEnumerator ConnectWaitManufacture() { }

	// RVA: 0x1D7BAEC Offset: 0x1D77AEC VA: 0x1D7BAEC
	private int getUsableSlotCount() { }

	// RVA: 0x1D7E4DC Offset: 0x1D7A4DC VA: 0x1D7E4DC
	private int getSuccessSkillRate() { }

	// RVA: 0x1D7EC5C Offset: 0x1D7AC5C VA: 0x1D7EC5C
	private void ToWeaponeSelectFromCheckDialog() { }

	// RVA: 0x1D7EBC4 Offset: 0x1D7ABC4 VA: 0x1D7EBC4
	private void ToSlotSelectFromMaterialTypeSelect() { }

	// RVA: 0x1D7EB9C Offset: 0x1D7AB9C VA: 0x1D7EB9C
	private void ToMaterialSelectFromDetail() { }

	// RVA: 0x1D7EC78 Offset: 0x1D7AC78 VA: 0x1D7EC78
	private bool CheckManufactureMaterial(int require, int have) { }

	// RVA: 0x1D7EC84 Offset: 0x1D7AC84 VA: 0x1D7EC84
	private bool CheckManufactureMaterial(List<Pair<string, int>> data, int startIndex, int count, int have) { }

	// RVA: 0x1D7BE0C Offset: 0x1D77E0C VA: 0x1D7BE0C
	private int GetUsePotentialPoint() { }

	// RVA: 0x1D7D764 Offset: 0x1D79764 VA: 0x1D7D764
	private int GetUsePotentialPoint(BonusType exclusionType) { }

	// RVA: 0x1D7EF84 Offset: 0x1D7AF84 VA: 0x1D7EF84
	private void EnhanceGetPropertyPosition(ItemData item, BonusParameter[] property, out BonusParameter[] changeProperties, out BonusParameter[] newProperties) { }

	// RVA: 0x1D7F55C Offset: 0x1D7B55C VA: 0x1D7F55C
	private short CalcUsePotentialPoint(ItemData customItem, BonusParameter[] changeProperties, BonusParameter[] newProperties, BonusType exclusionType) { }

	// RVA: 0x1D7FEB0 Offset: 0x1D7BEB0 VA: 0x1D7FEB0
	public void .ctor() { }

	// RVA: 0x1D7FFD8 Offset: 0x1D7BFD8 VA: 0x1D7FFD8
	private static void .cctor() { }
}

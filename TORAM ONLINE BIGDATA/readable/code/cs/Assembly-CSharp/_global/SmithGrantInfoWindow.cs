// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SmithGrantInfoWindow : MonoBehaviour // TypeDefIndex: 8492
{
	// Fields
	[SerializeField]
	private UILabel TitleLabel; // 0x20
	[SerializeField]
	private UILabel NameLabel; // 0x28
	[SerializeField]
	private LocalizeText PotentialLabel; // 0x30
	[SerializeField]
	private UILabel GrantNumLabel; // 0x38
	[SerializeField]
	private GameObject firstButton; // 0x40
	[SerializeField]
	private UILabel DetailConsumptionPotentialLabel; // 0x48
	[SerializeField]
	private ItemIcon DetailTypeLabel; // 0x50
	[SerializeField]
	private UILabel DetailRequireLabel; // 0x58
	[SerializeField]
	private UILabel SelectSlotPotentialLabel; // 0x60
	[SerializeField]
	private float RequireSpace; // 0x68
	[SerializeField]
	private GameObject RequireParent; // 0x70
	[SerializeField]
	private GameObject RequireLabelOrigin; // 0x78
	[SerializeField]
	private GameObject[] MaterialListPage; // 0x80
	[SerializeField]
	private GameObject[] CheckDisableObj; // 0x88
	[SerializeField]
	private GameObject[] CheckEnableObj; // 0x90
	[SerializeField]
	private UILabel DetailValLabel; // 0x98
	private int DetailVal; // 0xA0
	private int DetailType; // 0xA4
	private int DetailRequireNum; // 0xA8
	private int DetailRequireType; // 0xAC
	private int UsedPotential; // 0xB0
	[CompilerGenerated]
	private int <DetailConsumptionPotential>k__BackingField; // 0xB4
	[SerializeField]
	private UIImageButton checkStartButton; // 0xB8
	[SerializeField]
	private UILabel propertyTypeText; // 0xC0
	[CompilerGenerated]
	private int <WeaponPotential>k__BackingField; // 0xC8
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0xCC
	[CompilerGenerated]
	private int <remainPotential>k__BackingField; // 0xD0
	private int fixedVal; // 0xD4
	private int realFixedVal; // 0xD8
	private PlayerDataManager playerDataManager; // 0xE0
	private SystemTextManager systemTextManager; // 0xE8
	private ItemTextManager itemTextManager; // 0xF0
	private int requirePotential; // 0xF8
	private bool IsElement; // 0xFC
	private readonly List<SkillId> CoefficientMitigationSkillList; // 0x100

	// Properties
	public int DetailConsumptionPotential { get; set; }
	public int WeaponPotential { get; set; }
	public int DetailValue { get; set; }
	public int ItemId { get; set; }
	public int remainPotential { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D85628 Offset: 0x1D81628 VA: 0x1D85628
	public int get_DetailConsumptionPotential() { }

	[CompilerGenerated]
	// RVA: 0x1D85630 Offset: 0x1D81630 VA: 0x1D85630
	private void set_DetailConsumptionPotential(int value) { }

	[CompilerGenerated]
	// RVA: 0x1D85638 Offset: 0x1D81638 VA: 0x1D85638
	public int get_WeaponPotential() { }

	[CompilerGenerated]
	// RVA: 0x1D85640 Offset: 0x1D81640 VA: 0x1D85640
	private void set_WeaponPotential(int value) { }

	// RVA: 0x1D85648 Offset: 0x1D81648 VA: 0x1D85648
	public int get_DetailValue() { }

	// RVA: 0x1D85650 Offset: 0x1D81650 VA: 0x1D85650
	private void set_DetailValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x1D85658 Offset: 0x1D81658 VA: 0x1D85658
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x1D85660 Offset: 0x1D81660 VA: 0x1D85660
	private void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1D85668 Offset: 0x1D81668 VA: 0x1D85668
	public int get_remainPotential() { }

	[CompilerGenerated]
	// RVA: 0x1D85670 Offset: 0x1D81670 VA: 0x1D85670
	private void set_remainPotential(int value) { }

	// RVA: 0x1D85678 Offset: 0x1D81678 VA: 0x1D85678
	private void Awake() { }

	// RVA: 0x1D85828 Offset: 0x1D81828 VA: 0x1D85828
	private void Start() { }

	// RVA: 0x1D8582C Offset: 0x1D8182C VA: 0x1D8582C
	private void Update() { }

	// RVA: 0x1D85830 Offset: 0x1D81830 VA: 0x1D85830
	public void SetWeaponData(int itemId, string name, int potential, int grantnum, bool buttonEnabled) { }

	// RVA: 0x1D85A04 Offset: 0x1D81A04 VA: 0x1D85A04
	public void SetWeaponEmptyData() { }

	// RVA: 0x1D85BDC Offset: 0x1D81BDC VA: 0x1D85BDC
	public void SetFixedValue(int fixedVal) { }

	// RVA: 0x1D85BE4 Offset: 0x1D81BE4 VA: 0x1D85BE4
	public void SetMaterialList(int page) { }

	// RVA: 0x1D85C50 Offset: 0x1D81C50 VA: 0x1D85C50
	public void SetRequire(int[] requireMaterial, int requirePotential) { }

	[IteratorStateMachine(typeof(SmithGrantInfoWindow.<SetDetailType>d__58))]
	// RVA: 0x1D86464 Offset: 0x1D82464 VA: 0x1D86464
	public IEnumerator SetDetailType(int enhanceType, bool isElement) { }

	// RVA: 0x1D86514 Offset: 0x1D82514 VA: 0x1D86514
	public void SetDetailValue(int enhanceValue) { }

	// RVA: 0x1D86DE8 Offset: 0x1D82DE8 VA: 0x1D86DE8
	public void SetConsumptionPotential(int onePotential, int usedPotential) { }

	// RVA: 0x1D86E8C Offset: 0x1D82E8C VA: 0x1D86E8C
	public void SetRequireMaterialTypeAndValue(int type, int requireValue) { }

	// RVA: 0x1D87118 Offset: 0x1D83118 VA: 0x1D87118
	public void SetTitle(string localize_key) { }

	// RVA: 0x1D87150 Offset: 0x1D83150 VA: 0x1D87150
	public void SetTitle(int localize_uuid) { }

	// RVA: 0x1D87218 Offset: 0x1D83218 VA: 0x1D87218
	public void ShowCheckWindow(bool isMaterialOK) { }

	// RVA: 0x1D87324 Offset: 0x1D83324 VA: 0x1D87324
	public void CloseCheckWIndow() { }

	// RVA: 0x1D87414 Offset: 0x1D83414 VA: 0x1D87414
	public void OnPlus() { }

	// RVA: 0x1D87A2C Offset: 0x1D83A2C VA: 0x1D87A2C
	public void OnPlusMax() { }

	// RVA: 0x1D87B3C Offset: 0x1D83B3C VA: 0x1D87B3C
	public void OnMinus() { }

	// RVA: 0x1D87C84 Offset: 0x1D83C84 VA: 0x1D87C84
	public void OnMinusMax() { }

	// RVA: 0x1D87DA0 Offset: 0x1D83DA0 VA: 0x1D87DA0
	public void FromOnDetail() { }

	// RVA: 0x1D87528 Offset: 0x1D83528 VA: 0x1D87528
	public int getEnhanceMax(bool isUpper, BonusType checkType) { }

	// RVA: 0x1D866BC Offset: 0x1D826BC VA: 0x1D866BC
	private void UpdateDetailVal() { }

	// RVA: 0x1D87E1C Offset: 0x1D83E1C VA: 0x1D87E1C
	public int GetCurrentRequireMaterialPoint() { }

	// RVA: 0x1D86694 Offset: 0x1D82694 VA: 0x1D86694
	public bool CheckOverRateType(BonusType type) { }

	// RVA: 0x1D88328 Offset: 0x1D84328 VA: 0x1D88328
	private int CalcUnderstandSkill(int usePoint, MaterialType materialType) { }

	// RVA: 0x1D86FD4 Offset: 0x1D82FD4 VA: 0x1D86FD4
	private int CalcCoefficientMitigation(int coefficient) { }

	// RVA: 0x1D8844C Offset: 0x1D8444C VA: 0x1D8844C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D8867C Offset: 0x1D8467C VA: 0x1D8867C
	private int <CalcCoefficientMitigation>b__76_0(SkillId skill) { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBazaarBuyCheckWindow : MonoBehaviour // TypeDefIndex: 8246
{
	// Fields
	[SerializeField]
	private UIItemProperty property; // 0x20
	[SerializeField]
	private Camera propertyCamera; // 0x28
	[SerializeField]
	private Camera modelCamera; // 0x30
	[SerializeField]
	private GameObject modelParent; // 0x38
	[SerializeField]
	private UIIruna2DragPinch modelDrag; // 0x40
	[SerializeField]
	private UILabel cantViewModelLabel; // 0x48
	[SerializeField]
	private UIBazaarBuyElement itemName; // 0x50
	[SerializeField]
	private UILabel priceLabel; // 0x58
	[SerializeField]
	private UILabel possessionSpinaLabel; // 0x60
	[SerializeField]
	private GameObject determineButton; // 0x68
	[SerializeField]
	private GameObject itemPropPanel; // 0x70
	[SerializeField]
	private GameObject stargemPanel; // 0x78
	[SerializeField]
	private UILabel stargemExLabel; // 0x80
	[SerializeField]
	private UILabel stargemPropLabel; // 0x88
	[SerializeField]
	private UICamera propCamera; // 0x90
	[SerializeField]
	private GameObject numberOperation; // 0x98
	[SerializeField]
	private UILabel purchaseNumLabel; // 0xA0
	[SerializeField]
	private CountSystem countSystem; // 0xA8
	private const int COUNT_SYSTEM_KEY = 0;
	[SerializeField]
	private UIToggle notEnoughCancelToggle; // 0xB0
	[CompilerGenerated]
	private UIBazaarBuyElement <SelectedData>k__BackingField; // 0xB8
	private SystemTextManager systemTextManager; // 0xC0
	private PlayerDataManager playerDataManager; // 0xC8
	private SkillTextManager skillTextManager; // 0xD0
	private int possession; // 0xD8
	private int price; // 0xDC
	private UIPopBaseWindow skillPopWindow; // 0xE0
	private bool isSkillPopWindow; // 0xE8
	private GameObject skillIconObj; // 0xF0
	private UIMarketControl topControl; // 0xF8
	private const int capMax = 8;

	// Properties
	public UIBazaarBuyElement SelectedData { get; set; }
	public int PurchaseCount { get; }
	public bool IsNotEnoughCancel { get; }
	public Transform ModelParentTransform { get; }
	public UILabel CantViewModelLabel { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D00D90 Offset: 0x1CFCD90 VA: 0x1D00D90
	public UIBazaarBuyElement get_SelectedData() { }

	[CompilerGenerated]
	// RVA: 0x1D00D98 Offset: 0x1CFCD98 VA: 0x1D00D98
	private void set_SelectedData(UIBazaarBuyElement value) { }

	// RVA: 0x1D00DA0 Offset: 0x1CFCDA0 VA: 0x1D00DA0
	public int get_PurchaseCount() { }

	// RVA: 0x1D00DC0 Offset: 0x1CFCDC0 VA: 0x1D00DC0
	public bool get_IsNotEnoughCancel() { }

	// RVA: 0x1D00DDC Offset: 0x1CFCDDC VA: 0x1D00DDC
	public Transform get_ModelParentTransform() { }

	// RVA: 0x1D00DF8 Offset: 0x1CFCDF8 VA: 0x1D00DF8
	public UILabel get_CantViewModelLabel() { }

	// RVA: 0x1D00E00 Offset: 0x1CFCE00 VA: 0x1D00E00
	private void Awake() { }

	// RVA: 0x1D00FCC Offset: 0x1CFCFCC VA: 0x1D00FCC
	private void Update() { }

	// RVA: 0x1D01104 Offset: 0x1CFD104 VA: 0x1D01104
	private void OnDisable() { }

	// RVA: 0x1D011A8 Offset: 0x1CFD1A8 VA: 0x1D011A8
	public void Initialize(UIBazaarBuyElement element) { }

	// RVA: 0x1D02178 Offset: 0x1CFE178 VA: 0x1D02178
	public void InializeStarGem(UIBazaarBuyElement element, UIMarketControl topControl) { }

	// RVA: 0x1D00FD0 Offset: 0x1CFCFD0 VA: 0x1D00FD0
	private void updateModelRotate() { }

	[IteratorStateMachine(typeof(UIBazaarBuyCheckWindow.<enableDetermineButton>d__48))]
	// RVA: 0x1D0113C Offset: 0x1CFD13C VA: 0x1D0113C
	private IEnumerator enableDetermineButton() { }

	// RVA: 0x1D0272C Offset: 0x1CFE72C VA: 0x1D0272C
	public void SetEnablePropertyCamera(bool isEnabled) { }

	// RVA: 0x1D026E4 Offset: 0x1CFE6E4 VA: 0x1D026E4
	public void SetEnableModelCamera(bool isEnabled) { }

	// RVA: 0x1D0277C Offset: 0x1CFE77C VA: 0x1D0277C
	private void CloseInfo() { }

	// RVA: 0x1D027A4 Offset: 0x1CFE7A4 VA: 0x1D027A4
	private void OnOpenInfo() { }

	[IteratorStateMachine(typeof(UIBazaarBuyCheckWindow.<OpenSkillInfo>d__53))]
	// RVA: 0x1D02864 Offset: 0x1CFE864 VA: 0x1D02864
	private IEnumerator OpenSkillInfo() { }

	// RVA: 0x1D028F8 Offset: 0x1CFE8F8 VA: 0x1D028F8
	public void OnCountDownMax() { }

	// RVA: 0x1D02924 Offset: 0x1CFE924 VA: 0x1D02924
	public void OnCountDown() { }

	// RVA: 0x1D02950 Offset: 0x1CFE950 VA: 0x1D02950
	public void OnCountUp() { }

	// RVA: 0x1D0297C Offset: 0x1CFE97C VA: 0x1D0297C
	public void OnCountUpMax() { }

	// RVA: 0x1D01F74 Offset: 0x1CFDF74 VA: 0x1D01F74
	public void ChangedPurchaseNum() { }

	// RVA: 0x1D029A8 Offset: 0x1CFE9A8 VA: 0x1D029A8
	public void ChangeActiveDetermineButton(bool isActive) { }

	// RVA: 0x1D029D8 Offset: 0x1CFE9D8 VA: 0x1D029D8
	public void .ctor() { }
}

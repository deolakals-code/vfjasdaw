// Assembly: Assembly-CSharp.dll
// Namespace: 
public class Smith : UIBasePanelControl, IShop // TypeDefIndex: 8474
{
	// Fields
	[SerializeField]
	private UIIruna2AnchorSimple[] SelectMenus; // 0x58
	[SerializeField]
	private UIIruna2AnchorSimple[] StrengtheningMenus; // 0x60
	private SmithUIMaterialBase NowShowObj; // 0x68
	[SerializeField]
	private GameObject ProcessingObj; // 0x70
	[SerializeField]
	private GameObject ManufactureObj; // 0x78
	[SerializeField]
	private GameObject StrengtheningObj; // 0x80
	[SerializeField]
	private GameObject ReconstructionObj; // 0x88
	[SerializeField]
	private GameObject GrantObj; // 0x90
	[SerializeField]
	private GameObject TitleObj; // 0x98
	[SerializeField]
	private GameObject transferObj; // 0xA0
	private int smithId; // 0xA8
	private bool isClosed; // 0xAC
	private bool IsStrengthMenu; // 0xAD

	// Properties
	public bool IsPlayer { get; }
	public SmithUIMaterialBase SmithUIBase { get; }
	public int ShopId { get; set; }
	public string ShopName { get; set; }
	public bool IsClosed { get; set; }

	// Methods

	// RVA: 0x1D76D1C Offset: 0x1D72D1C VA: 0x1D76D1C
	public bool get_IsPlayer() { }

	// RVA: 0x1D76D28 Offset: 0x1D72D28 VA: 0x1D76D28
	public SmithUIMaterialBase get_SmithUIBase() { }

	// RVA: 0x1D76D30 Offset: 0x1D72D30 VA: 0x1D76D30
	private void Awake() { }

	// RVA: 0x1D76E1C Offset: 0x1D72E1C VA: 0x1D76E1C
	private void Start() { }

	// RVA: 0x1D77038 Offset: 0x1D73038 VA: 0x1D77038
	public void ToProcessing() { }

	// RVA: 0x1D77388 Offset: 0x1D73388 VA: 0x1D77388
	public void ToManufacture() { }

	// RVA: 0x1D7762C Offset: 0x1D7362C VA: 0x1D7762C
	public void ToStrengtheningSelect() { }

	// RVA: 0x1D7782C Offset: 0x1D7382C VA: 0x1D7782C
	public void ToStrengthening() { }

	// RVA: 0x1D77B30 Offset: 0x1D73B30 VA: 0x1D77B30
	public void ToReconstruction() { }

	// RVA: 0x1D77DD4 Offset: 0x1D73DD4 VA: 0x1D77DD4
	public void ToGrant() { }

	// RVA: 0x1D78078 Offset: 0x1D74078 VA: 0x1D78078
	public void ToTransfer() { }

	// RVA: 0x1D7831C Offset: 0x1D7431C VA: 0x1D7831C
	public void CloseNowObjectAndToStrengtheningMenu() { }

	// RVA: 0x1D783A8 Offset: 0x1D743A8 VA: 0x1D783A8
	public void ToMenuFromStrengthening() { }

	// RVA: 0x1D783C8 Offset: 0x1D743C8 VA: 0x1D783C8
	public void CloseNowObject() { }

	// RVA: 0x1D77328 Offset: 0x1D73328 VA: 0x1D77328
	private void CloseMenu() { }

	// RVA: 0x1D76FD8 Offset: 0x1D72FD8 VA: 0x1D76FD8
	private void ShowMenu() { }

	// RVA: 0x1D77AD0 Offset: 0x1D73AD0 VA: 0x1D77AD0
	private void CloseStrengtheningMenu() { }

	// RVA: 0x1D77708 Offset: 0x1D73708 VA: 0x1D77708
	private void ShowStrengtheningMenu() { }

	// RVA: 0x1D7844C Offset: 0x1D7444C VA: 0x1D7844C
	private void CloseSmith() { }

	// RVA: 0x1D78458 Offset: 0x1D74458 VA: 0x1D78458
	private void OnDestroy() { }

	// RVA: 0x1D7845C Offset: 0x1D7445C VA: 0x1D7845C
	public void SwitchPlayer() { }

	// RVA: 0x1D78460 Offset: 0x1D74460 VA: 0x1D78460 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1D78580 Offset: 0x1D74580 VA: 0x1D78580 Slot: 14
	public int get_ShopId() { }

	// RVA: 0x1D78588 Offset: 0x1D74588 VA: 0x1D78588 Slot: 15
	public void set_ShopId(int value) { }

	// RVA: 0x1D78590 Offset: 0x1D74590 VA: 0x1D78590 Slot: 16
	public string get_ShopName() { }

	// RVA: 0x1D785EC Offset: 0x1D745EC VA: 0x1D785EC Slot: 17
	public void set_ShopName(string value) { }

	// RVA: 0x1D78650 Offset: 0x1D74650 VA: 0x1D78650 Slot: 18
	public bool get_IsClosed() { }

	// RVA: 0x1D78658 Offset: 0x1D74658 VA: 0x1D78658 Slot: 19
	public void set_IsClosed(bool value) { }

	// RVA: 0x1D78664 Offset: 0x1D74664 VA: 0x1D78664
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D78674 Offset: 0x1D74674 VA: 0x1D78674
	private void <Start>b__18_0() { }
}

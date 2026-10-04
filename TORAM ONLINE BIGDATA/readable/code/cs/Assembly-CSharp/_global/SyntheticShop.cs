// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SyntheticShop : UIBasePanelControl, IShop // TypeDefIndex: 8734
{
	// Fields
	[SerializeField]
	private UIIruna2AnchorSimple[] anchor; // 0x58
	[SerializeField]
	private UILabel titleLabel; // 0x60
	[SerializeField]
	private GameObject syntheticMedicine; // 0x68
	[SerializeField]
	private GameObject syntheticEquip; // 0x70
	[SerializeField]
	private GameObject processingObj; // 0x78
	private SmithUIMaterialBase NowShowObj; // 0x80
	[CompilerGenerated]
	private SyntheticMedicine <SyntheticMedicinePanel>k__BackingField; // 0x88
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x90
	[CompilerGenerated]
	private bool <IsClosed>k__BackingField; // 0x94

	// Properties
	public SyntheticMedicine SyntheticMedicinePanel { get; set; }
	public int ShopId { get; set; }
	public string ShopName { get; set; }
	public bool IsClosed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1DFA128 Offset: 0x1DF6128 VA: 0x1DFA128
	public SyntheticMedicine get_SyntheticMedicinePanel() { }

	[CompilerGenerated]
	// RVA: 0x1DFA130 Offset: 0x1DF6130 VA: 0x1DFA130
	private void set_SyntheticMedicinePanel(SyntheticMedicine value) { }

	// RVA: 0x1DFA138 Offset: 0x1DF6138 VA: 0x1DFA138
	private void Awake() { }

	// RVA: 0x1DFA2F8 Offset: 0x1DF62F8 VA: 0x1DFA2F8
	private void Start() { }

	// RVA: 0x1DFA3F8 Offset: 0x1DF63F8 VA: 0x1DFA3F8
	private void Update() { }

	// RVA: 0x1DFA3FC Offset: 0x1DF63FC VA: 0x1DFA3FC
	private void onMedicine() { }

	// RVA: 0x1DFA6EC Offset: 0x1DF66EC VA: 0x1DFA6EC
	private void onEquip() { }

	// RVA: 0x1DFA95C Offset: 0x1DF695C VA: 0x1DFA95C
	private void onProcessing() { }

	// RVA: 0x1DFAC64 Offset: 0x1DF6C64 VA: 0x1DFAC64
	private void reSetup() { }

	// RVA: 0x1DFA67C Offset: 0x1DF667C VA: 0x1DFA67C
	private void showMenu(bool isShow) { }

	// RVA: 0x1DFAD0C Offset: 0x1DF6D0C VA: 0x1DFAD0C
	private void onClose() { }

	[CompilerGenerated]
	// RVA: 0x1DFAD18 Offset: 0x1DF6D18 VA: 0x1DFAD18 Slot: 14
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x1DFAD20 Offset: 0x1DF6D20 VA: 0x1DFAD20 Slot: 15
	public void set_ShopId(int value) { }

	// RVA: 0x1DFAD28 Offset: 0x1DF6D28 VA: 0x1DFAD28 Slot: 16
	public string get_ShopName() { }

	// RVA: 0x1DFAD44 Offset: 0x1DF6D44 VA: 0x1DFAD44 Slot: 17
	public void set_ShopName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1DFAD60 Offset: 0x1DF6D60 VA: 0x1DFAD60 Slot: 18
	public bool get_IsClosed() { }

	[CompilerGenerated]
	// RVA: 0x1DFAD68 Offset: 0x1DF6D68 VA: 0x1DFAD68 Slot: 19
	public void set_IsClosed(bool value) { }

	// RVA: 0x1DFAD74 Offset: 0x1DF6D74 VA: 0x1DFAD74
	public void .ctor() { }
}

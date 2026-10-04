// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWorldTreasureManager : UIBasePanel // TypeDefIndex: 8232
{
	// Fields
	[SerializeField]
	private GameObject BasePanelObj; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private UIIcon titleIcon; // 0x40
	[SerializeField]
	private UILabel orbLabel; // 0x48
	[SerializeField]
	private UIIruna2Anchor orbAnchor; // 0x50
	private SystemTextManager systemTextManager; // 0x58
	private PlayerDataManager playerDataManager; // 0x60
	private Dictionary<UIWorldTreasureManager.PanelState, IWorldTreasurePanel> panelList; // 0x68
	private bool isFromMainMenu; // 0x70
	[CompilerGenerated]
	private UIWorldTreasureManager.PanelState <state>k__BackingField; // 0x74
	[CompilerGenerated]
	private int <ManageId>k__BackingField; // 0x78

	// Properties
	public bool IsFromMainMenu { get; }
	public WorldTreasureManager WorldTreasureManager { get; }
	public UIWorldTreasureManager.PanelState state { get; set; }
	public int ManageId { get; set; }

	// Methods

	// RVA: 0x1CFE354 Offset: 0x1CFA354 VA: 0x1CFE354
	public bool get_IsFromMainMenu() { }

	// RVA: 0x1CFC804 Offset: 0x1CF8804 VA: 0x1CFC804
	public WorldTreasureManager get_WorldTreasureManager() { }

	[CompilerGenerated]
	// RVA: 0x1CFE35C Offset: 0x1CFA35C VA: 0x1CFE35C
	public UIWorldTreasureManager.PanelState get_state() { }

	[CompilerGenerated]
	// RVA: 0x1CFE364 Offset: 0x1CFA364 VA: 0x1CFE364
	private void set_state(UIWorldTreasureManager.PanelState value) { }

	[CompilerGenerated]
	// RVA: 0x1CFE36C Offset: 0x1CFA36C VA: 0x1CFE36C
	public int get_ManageId() { }

	[CompilerGenerated]
	// RVA: 0x1CFE374 Offset: 0x1CFA374 VA: 0x1CFE374
	private void set_ManageId(int value) { }

	// RVA: 0x1CFE37C Offset: 0x1CFA37C VA: 0x1CFE37C
	public void OpenSearchPotumPanel(int manageId) { }

	// RVA: 0x1CFE388 Offset: 0x1CFA388 VA: 0x1CFE388
	public void ReceiveHideSeekCheck(HideSeekCheckResponse response) { }

	// RVA: 0x1CFE5A4 Offset: 0x1CFA5A4 VA: 0x1CFE5A4
	private void Awake() { }

	[IteratorStateMachine(typeof(UIWorldTreasureManager.<Start>d__25))]
	// RVA: 0x1CFE69C Offset: 0x1CFA69C VA: 0x1CFE69C
	private IEnumerator Start() { }

	// RVA: 0x1CFD810 Offset: 0x1CF9810 VA: 0x1CFD810
	public void ChangeTitle(string titleText, string spriteName) { }

	// RVA: 0x1CFCDE4 Offset: 0x1CF8DE4 VA: 0x1CFCDE4
	public void MoveOrbFrame(bool isOpen) { }

	// RVA: 0x1CFCDA4 Offset: 0x1CF8DA4 VA: 0x1CFCDA4
	public void UpdateOrbLabel(int num) { }

	// RVA: 0x1CFD7F0 Offset: 0x1CF97F0 VA: 0x1CFD7F0
	public void BasePanelSetActive(bool isActive) { }

	// RVA: 0x1CFE730 Offset: 0x1CFA730 VA: 0x1CFE730
	private IWorldTreasurePanel LoadPanel(string path) { }

	// RVA: 0x1CFC820 Offset: 0x1CF8820 VA: 0x1CFC820
	public void ChangePanelState(UIWorldTreasureManager.PanelState change) { }

	// RVA: 0x1CFE960 Offset: 0x1CFA960 VA: 0x1CFE960 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1CFEB10 Offset: 0x1CFAB10 VA: 0x1CFEB10 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1CFEBB8 Offset: 0x1CFABB8 VA: 0x1CFEBB8
	public void .ctor() { }
}

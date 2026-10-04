// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBazaarOpen : UIBasePanelConnection, IUISignBoard // TypeDefIndex: 8288
{
	// Fields
	[SerializeField]
	private UIBazaarItemPlate itemPlate; // 0x30
	[SerializeField]
	private UIIruna2Anchor window; // 0x38
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x40
	[SerializeField]
	private GameObject[] windows; // 0x48
	[SerializeField]
	private UISprite[] windowBacks; // 0x50
	[SerializeField]
	private UILabel salesLabel; // 0x58
	[SerializeField]
	private UISprite scalingButtonIcon; // 0x60
	[SerializeField]
	private GameObject closeDialogTitle; // 0x68
	[SerializeField]
	private GameObject closeDialogMessage; // 0x70
	[SerializeField]
	private LabelWithIcon cloaseDialogButtonLabelWithIcon; // 0x78
	private readonly List<BazaarItemData> BazaarItemDataList; // 0x80
	private int sales; // 0x88
	private GameObject shortcutManager; // 0x90
	private bool isFirstInit; // 0x98
	private Vector2 move; // 0x9C

	// Properties
	public int ActiveWindowIndex { get; }
	public bool IsOpenShortCutPanel { get; }

	// Methods

	// RVA: 0x1D13AD4 Offset: 0x1D0FAD4 VA: 0x1D13AD4
	public int get_ActiveWindowIndex() { }

	// RVA: 0x1D13B80 Offset: 0x1D0FB80 VA: 0x1D13B80 Slot: 8
	public bool get_IsOpenShortCutPanel() { }

	// RVA: 0x1D13BE0 Offset: 0x1D0FBE0 VA: 0x1D13BE0
	private void Awake() { }

	// RVA: 0x1D13DDC Offset: 0x1D0FDDC VA: 0x1D13DDC
	private void OnDestroy() { }

	// RVA: 0x1D13D20 Offset: 0x1D0FD20 VA: 0x1D13D20
	private void DefaultfTopButton() { }

	// RVA: 0x1D13E6C Offset: 0x1D0FE6C VA: 0x1D13E6C
	private void Update() { }

	// RVA: 0x1D13FE8 Offset: 0x1D0FFE8 VA: 0x1D13FE8
	internal void Initialize(SignboardPropertyData boardData) { }

	// RVA: 0x1D144CC Offset: 0x1D104CC VA: 0x1D144CC
	public void OnChangeFrame() { }

	// RVA: 0x1D14600 Offset: 0x1D10600 VA: 0x1D14600
	public void OnCloseBazaar() { }

	// RVA: 0x1D146F8 Offset: 0x1D106F8 VA: 0x1D146F8
	public void OnLogOutButton() { }

	[IteratorStateMachine(typeof(UIBazaarOpen.<LogOut>d__26))]
	// RVA: 0x1D147A8 Offset: 0x1D107A8 VA: 0x1D147A8
	private IEnumerator LogOut() { }

	[IteratorStateMachine(typeof(UIBazaarOpen.<PutAwaySignBoard>d__27))]
	// RVA: 0x1D13F7C Offset: 0x1D0FF7C VA: 0x1D13F7C
	private IEnumerator PutAwaySignBoard() { }

	// RVA: 0x1D14850 Offset: 0x1D10850 VA: 0x1D14850
	private void OpenFailureWindow() { }

	// RVA: 0x1D14AB0 Offset: 0x1D10AB0 VA: 0x1D14AB0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1D14E74 Offset: 0x1D10E74 VA: 0x1D14E74 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1D14FD4 Offset: 0x1D10FD4 VA: 0x1D14FD4 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x1D145FC Offset: 0x1D105FC VA: 0x1D145FC
	public void OnDrag(Vector2 delta) { }

	// RVA: 0x1D150BC Offset: 0x1D110BC VA: 0x1D150BC
	public void .ctor() { }
}

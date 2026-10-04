// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIComboPanelManager : UIBasePanel // TypeDefIndex: 6868
{
	// Fields
	private readonly SkillEqLimitFlag[] skillEquipList; // 0x30
	private readonly ItemDBData.ItemType[] itemTypeList; // 0x38
	private readonly List<SkillId> ngSkillList; // 0x40
	[SerializeField]
	private GameObject listButton; // 0x48
	[SerializeField]
	private GameObject mainPanel; // 0x50
	[SerializeField]
	private UIComboWindow comboWindow; // 0x58
	[SerializeField]
	private GameObject windowObject; // 0x60
	[SerializeField]
	private GameObject controlPanel; // 0x68
	[SerializeField]
	private UILabel comboExpPointLabel; // 0x70
	[SerializeField]
	private UISprite comboExpPointSlider; // 0x78
	[SerializeField]
	private GameObject comboPointObject; // 0x80
	[SerializeField]
	private UILabel comboPointLabel; // 0x88
	[SerializeField]
	private UISprite comboPointSlider; // 0x90
	[SerializeField]
	private GameObject comboErrPanel; // 0x98
	[SerializeField]
	private GameObject[] pageButtonObjects; // 0xA0
	[SerializeField]
	private GameObject releaseWindowObject; // 0xA8
	[SerializeField]
	private GameObject[] releaseWindowButtonObjects; // 0xB0
	[SerializeField]
	private UILabel releaseWindowMessageLabel; // 0xB8
	[SerializeField]
	private UILabel releaseWindowButtonLabel; // 0xC0
	[SerializeField]
	private UIIruna2Anchor orbAnchor; // 0xC8
	[SerializeField]
	private UILabel orbNumLabel; // 0xD0
	private static readonly int ReleaseCost; // 0x0
	private static readonly int ComboListNum; // 0x4
	private static readonly int MaxComboPoint; // 0x8
	private UIScrollWindow scrollListWindow; // 0xD8
	private UIComboPanelManager.State state; // 0xE0
	private int selectedComboId; // 0xE4
	private PlayerDataManager playerDataManager; // 0xE8
	private SkillComboManager skillComboManager; // 0xF0
	private bool updateConnection; // 0xF8
	private int currentPageId; // 0xFC
	private List<UIComboSetButton> comboSetButtonList; // 0x100
	private Dictionary<int, string> comboMemoList; // 0x108
	private List<UISprite>[] pageButtonSprites; // 0x110
	private UIPopBaseWindow popWindow; // 0x118
	private bool isBattleActive; // 0x120

	// Properties
	private bool IsBattleActive { get; }

	// Methods

	// RVA: 0x1A1F864 Offset: 0x1A1B864 VA: 0x1A1F864
	private bool get_IsBattleActive() { }

	// RVA: 0x1A1F938 Offset: 0x1A1B938 VA: 0x1A1F938
	private void Awake() { }

	// RVA: 0x1A1FA54 Offset: 0x1A1BA54 VA: 0x1A1FA54
	private void Start() { }

	// RVA: 0x1A21314 Offset: 0x1A1D314 VA: 0x1A21314
	private void Update() { }

	// RVA: 0x1A216E4 Offset: 0x1A1D6E4 VA: 0x1A216E4
	private void OnDestroy() { }

	// RVA: 0x1A1FEEC Offset: 0x1A1BEEC VA: 0x1A1FEEC
	private void SetComboExpPoint() { }

	// RVA: 0x1A21748 Offset: 0x1A1D748 VA: 0x1A21748
	public void SetComboPoint(int useComboPoint) { }

	// RVA: 0x1A20074 Offset: 0x1A1C074 VA: 0x1A20074
	private void CreateComboListWindow() { }

	// RVA: 0x1A20DC0 Offset: 0x1A1CDC0 VA: 0x1A20DC0
	private void CreateComboList() { }

	// RVA: 0x1A21B3C Offset: 0x1A1DB3C VA: 0x1A21B3C
	private bool IsComboNG(SkillComboLine line, short[] skillId) { }

	// RVA: 0x1A22BB0 Offset: 0x1A1EBB0 VA: 0x1A22BB0
	public bool SetComboEnable(int comboId, bool flag) { }

	// RVA: 0x1A22C5C Offset: 0x1A1EC5C VA: 0x1A22C5C
	private void ComboLineDisable(int comboId) { }

	// RVA: 0x1A2327C Offset: 0x1A1F27C VA: 0x1A2327C
	public void SelectComboId(int comboId) { }

	// RVA: 0x1A238D4 Offset: 0x1A1F8D4 VA: 0x1A238D4
	public void SaveComboLine(byte lineId, short[] skillId, byte[] buffer) { }

	// RVA: 0x1A23C04 Offset: 0x1A1FC04 VA: 0x1A23C04
	public void BackToComboListWindow() { }

	// RVA: 0x1A1FD80 Offset: 0x1A1BD80 VA: 0x1A1FD80
	public void LoadComboMemoData() { }

	// RVA: 0x1A23C3C Offset: 0x1A1FC3C VA: 0x1A23C3C
	public void SaveComboMemoData() { }

	// RVA: 0x1A23F1C Offset: 0x1A1FF1C VA: 0x1A23F1C
	public void SetComboMemoData(int id, string text) { }

	// RVA: 0x1A23F84 Offset: 0x1A1FF84 VA: 0x1A23F84
	public string GetComboMemoText(int id) { }

	[IteratorStateMachine(typeof(UIComboPanelManager.<OpenReleaseWindow>d__57))]
	// RVA: 0x1A24018 Offset: 0x1A20018 VA: 0x1A24018
	public IEnumerator OpenReleaseWindow(int id) { }

	[IteratorStateMachine(typeof(UIComboPanelManager.<ReleaseWaitWindow>d__58))]
	// RVA: 0x1A240BC Offset: 0x1A200BC VA: 0x1A240BC
	private IEnumerator ReleaseWaitWindow() { }

	// RVA: 0x1A24150 Offset: 0x1A20150 VA: 0x1A24150
	private void OnOrbCreateButton() { }

	// RVA: 0x1A241F4 Offset: 0x1A201F4 VA: 0x1A241F4
	private void OnReleaseButton() { }

	// RVA: 0x1A24230 Offset: 0x1A20230 VA: 0x1A24230
	private void OnPageButton(int id) { }

	// RVA: 0x1A24158 Offset: 0x1A20158 VA: 0x1A24158
	private void ChangePanelLoad(UIActiveState activeState) { }

	// RVA: 0x1A24458 Offset: 0x1A20458 VA: 0x1A24458 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1A2464C Offset: 0x1A2064C VA: 0x1A2464C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1A24704 Offset: 0x1A20704 VA: 0x1A24704
	public void .ctor() { }

	// RVA: 0x1A25068 Offset: 0x1A21068 VA: 0x1A25068
	private static void .cctor() { }
}

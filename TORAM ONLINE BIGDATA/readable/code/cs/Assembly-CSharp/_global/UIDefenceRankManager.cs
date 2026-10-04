// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIDefenceRankManager : UIBasePanel // TypeDefIndex: 5751
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x30
	private UIIruna2Anchor mainAnchor; // 0x38
	[SerializeField]
	private GameObject[] subPanel; // 0x40
	[SerializeField]
	private UIScrollWindow fullscreenWindow; // 0x48
	[SerializeField]
	private GameObject cameraObject; // 0x50
	private GameObject scrollWindowObject; // 0x58
	private UIScrollWindow scrollWindow; // 0x60
	[SerializeField]
	private GameObject rankElementObject; // 0x68
	private float elementHeight; // 0x70
	[SerializeField]
	private UILabel titleLabel; // 0x78
	[SerializeField]
	private UIImageButton myRankButton; // 0x80
	[SerializeField]
	private UIImageButton nextRankButton; // 0x88
	[SerializeField]
	private UILabel challengerRankLabel; // 0x90
	[SerializeField]
	private UILabel expLabel; // 0x98
	[SerializeField]
	private GameObject bestScoreObj; // 0xA0
	[SerializeField]
	private UILabel bestScoreLabel; // 0xA8
	[SerializeField]
	private UILabel bestTimeLabel; // 0xB0
	private float clock; // 0xB8
	private UIWidget widget; // 0xC0
	private UIDefenceRankManager.RankPanelType rankType; // 0xC8
	protected UIPartyMember[] partyMemberData; // 0xD0
	protected TweenPosition[] partyMemberEffect; // 0xD8
	private List<string> partyMemberName; // 0xE0
	private UIDefenceRankBasePanel defenceRankBasePanel; // 0xE8
	private UIDefenceRankManager defenceRankManager; // 0xF0
	private float loadingTimer; // 0xF8
	private GameObject loadingObject; // 0x100
	private PlayerDataManager playerDataManager; // 0x108
	private DefenceRoomData defenceRoomData; // 0x110
	private bool cancel; // 0x118
	private bool close; // 0x119
	private GameObject shortcutManager; // 0x120
	private bool openShortcut; // 0x128
	private bool isThereRankFlag; // 0x129

	// Properties
	public bool IsCancel { get; }
	public bool IsClose { get; }

	// Methods

	// RVA: 0x17DB91C Offset: 0x17D791C VA: 0x17DB91C
	public bool get_IsCancel() { }

	// RVA: 0x17DB924 Offset: 0x17D7924 VA: 0x17DB924
	public bool get_IsClose() { }

	// RVA: 0x17DB92C Offset: 0x17D792C VA: 0x17DB92C
	private void Awake() { }

	// RVA: 0x17DB934 Offset: 0x17D7934 VA: 0x17DB934
	private void Start() { }

	// RVA: 0x17D61E8 Offset: 0x17D21E8 VA: 0x17D61E8
	public void Initialize() { }

	// RVA: 0x17DB9AC Offset: 0x17D79AC VA: 0x17DB9AC
	private void InitRanking() { }

	// RVA: 0x17DBFD4 Offset: 0x17D7FD4 VA: 0x17DBFD4
	private void RankElementInit(int rank, GameObject Obj) { }

	// RVA: 0x17DBDC8 Offset: 0x17D7DC8 VA: 0x17DBDC8
	private string ChallengerRankLabel(int rank) { }

	// RVA: 0x17DC7A0 Offset: 0x17D87A0 VA: 0x17DC7A0
	private void Update() { }

	// RVA: 0x17DC84C Offset: 0x17D884C VA: 0x17DC84C
	private void NextRanking() { }

	[IteratorStateMachine(typeof(UIDefenceRankManager.<GetByRankData>d__47))]
	// RVA: 0x17DC8F8 Offset: 0x17D88F8 VA: 0x17DC8F8
	private IEnumerator GetByRankData() { }

	// RVA: 0x17DC98C Offset: 0x17D898C VA: 0x17DC98C
	private void MyRanking() { }

	// RVA: 0x17DC990 Offset: 0x17D8990 VA: 0x17DC990 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x17DC9F8 Offset: 0x17D89F8 VA: 0x17DC9F8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x17DC9FC Offset: 0x17D89FC VA: 0x17DC9FC Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x17DCA84 Offset: 0x17D8A84 VA: 0x17DCA84
	public void .ctor() { }
}

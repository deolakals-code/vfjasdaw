// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackResultManager : UIBasePanel // TypeDefIndex: 6268
{
	// Fields
	[SerializeField]
	private UIScoreAttackPointResultManager pointResultManager; // 0x30
	[SerializeField]
	private UIScoreAttackCategoryResultManager categoryResultManager; // 0x38
	[SerializeField]
	private GameObject modelParent; // 0x40
	[SerializeField]
	private GameObject titleObj; // 0x48
	[SerializeField]
	private UILabel bossNameLabel; // 0x50
	[SerializeField]
	private UILabel battleTimeLabel; // 0x58
	[SerializeField]
	private UILabel sTrophyTypeLabel; // 0x60
	[SerializeField]
	private UILabel trophyTypeLabel; // 0x68
	[SerializeField]
	private UILabel trophyTypeRankingLabel; // 0x70
	[SerializeField]
	private UILabel rankingLabel; // 0x78
	[SerializeField]
	private UILabel playerNameLabel; // 0x80
	[SerializeField]
	private UILabel playerLevelLabel; // 0x88
	[SerializeField]
	private UISprite trophyIconSprite; // 0x90
	[SerializeField]
	private GameObject resultDataObj; // 0x98
	[SerializeField]
	private GameObject resultBaseBar; // 0xA0
	[SerializeField]
	private GameObject deadPenaltyLabel; // 0xA8
	[SerializeField]
	private GameObject noUser; // 0xB0
	[SerializeField]
	private GameObject resultPanel; // 0xB8
	[SerializeField]
	[Header("ScoreAttackResult")]
	private GameObject scoreAttackResultPanel; // 0xC0
	[SerializeField]
	private GameObject nextButton; // 0xC8
	[SerializeField]
	private UILabel titleLabel; // 0xD0
	[SerializeField]
	private UIButtonCallAction resultButton; // 0xD8
	[SerializeField]
	private GameObject pointResult; // 0xE0
	[SerializeField]
	private GameObject categoryResult; // 0xE8
	[Header("PopupWindow")]
	[SerializeField]
	private GameObject popupWindow; // 0xF0
	[SerializeField]
	private UILabel popupWindowTitleLabel; // 0xF8
	[SerializeField]
	private UILabel popupWindowLabel; // 0x100
	[SerializeField]
	private UIButtonCallAction popupButton; // 0x108
	[SerializeField]
	private GameObject retireWindow; // 0x110
	private ScoreAttackRoomData roomData; // 0x118
	private int bossUid; // 0x120
	private UISprite[] resultBar; // 0x128
	private ScoreAttackResultData resultData; // 0x130
	private UIScoreAttackResultManager.BossTrophy selectTrophyType; // 0x138
	private const int TrophyNum = 4;
	private bool isMerged; // 0x13C
	private Dictionary<int, GameObject> topPlayerModel; // 0x140
	private GameObject targetObject; // 0x148
	private ChatChannelType saveChatType; // 0x150
	private UIScoreAttackResultManager.PanelState panelState; // 0x154
	private List<UIScoreAttackResultManager.RollType> mvpTypes; // 0x158
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x160

	// Properties
	public bool IsClose { get; set; }
	public List<UIScoreAttackResultManager.RollType> MvpTypes { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18D4118 Offset: 0x18D0118 VA: 0x18D4118
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x18D4120 Offset: 0x18D0120 VA: 0x18D4120
	private void set_IsClose(bool value) { }

	// RVA: 0x18D412C Offset: 0x18D012C VA: 0x18D412C
	public List<UIScoreAttackResultManager.RollType> get_MvpTypes() { }

	// RVA: 0x18D4134 Offset: 0x18D0134 VA: 0x18D4134
	public void set_MvpTypes(List<UIScoreAttackResultManager.RollType> value) { }

	// RVA: 0x18D4144 Offset: 0x18D0144 VA: 0x18D4144
	private void Update() { }

	// RVA: 0x18D4228 Offset: 0x18D0228 VA: 0x18D4228
	private void OnDestroy() { }

	// RVA: 0x18D4408 Offset: 0x18D0408 VA: 0x18D4408
	public void Initialize(int uid) { }

	// RVA: 0x18D4C50 Offset: 0x18D0C50 VA: 0x18D4C50
	public void OpenRetireWindow() { }

	// RVA: 0x18D4E10 Offset: 0x18D0E10 VA: 0x18D4E10
	public void ChangeSelect(int add) { }

	// RVA: 0x18D58D4 Offset: 0x18D18D4 VA: 0x18D58D4
	public void OnScoreAttackNextButton() { }

	// RVA: 0x18D5DE0 Offset: 0x18D1DE0 VA: 0x18D5DE0
	public void OnClickNextProgress() { }

	// RVA: 0x18D5EE8 Offset: 0x18D1EE8 VA: 0x18D5EE8
	public void OnClickRetireOK() { }

	// RVA: 0x18D4824 Offset: 0x18D0824 VA: 0x18D4824
	private void ChangePanel(UIScoreAttackResultManager.PanelState state) { }

	// RVA: 0x18D5F8C Offset: 0x18D1F8C VA: 0x18D5F8C
	private void BaseResultInitialize() { }

	// RVA: 0x18D5A24 Offset: 0x18D1A24 VA: 0x18D5A24
	private void ScoreAttackInitialize() { }

	// RVA: 0x18D6858 Offset: 0x18D2858 VA: 0x18D6858
	private void PopupWindowInitialize() { }

	// RVA: 0x18D4E38 Offset: 0x18D0E38 VA: 0x18D4E38
	private bool UpdateResult(UIScoreAttackResultManager.BossTrophy trophyType) { }

	// RVA: 0x18D5EDC Offset: 0x18D1EDC VA: 0x18D5EDC
	private void ResultEnd() { }

	// RVA: 0x18D68F4 Offset: 0x18D28F4 VA: 0x18D68F4
	private List<Color32> GetColorList() { }

	// RVA: 0x18D6AF8 Offset: 0x18D2AF8 VA: 0x18D6AF8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18D6BEC Offset: 0x18D2BEC VA: 0x18D6BEC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18D6C90 Offset: 0x18D2C90 VA: 0x18D6C90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18D6D20 Offset: 0x18D2D20 VA: 0x18D6D20
	private void <PopupWindowInitialize>b__62_0() { }
}

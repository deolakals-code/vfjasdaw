// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackRankingManager : MonoBehaviour // TypeDefIndex: 6263
{
	// Fields
	[SerializeField]
	private GameObject window; // 0x20
	[SerializeField]
	private GameObject topWindow; // 0x28
	[SerializeField]
	private GameObject centerWindow; // 0x30
	[Header("Title")]
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private UILabel subTitleLabel; // 0x40
	[SerializeField]
	private GameObject leftTitleButton; // 0x48
	[SerializeField]
	private GameObject rightTitleButton; // 0x50
	[SerializeField]
	private UILabel rewardTitleLabel; // 0x58
	[SerializeField]
	[Header("Ranking")]
	private GameObject rankingWindow; // 0x60
	[SerializeField]
	private UIScoreAttackRankingContent rankingContent; // 0x68
	[SerializeField]
	private UIScrollWindow rankingScrollWindow; // 0x70
	[SerializeField]
	private UILabel[] departmentButtonLabel; // 0x78
	[SerializeField]
	private GameObject userScoreWindow; // 0x80
	[SerializeField]
	private GameObject tallyingMessage; // 0x88
	[SerializeField]
	[Header("BossButton")]
	private UISprite boss1Button; // 0x90
	[SerializeField]
	private UILabel boss1Label; // 0x98
	[SerializeField]
	private UISprite boss2Button; // 0xA0
	[SerializeField]
	private UILabel boss2Label; // 0xA8
	[SerializeField]
	[Header("UserScore")]
	private UIScoreAttackRankingContent userScoreScoreObjectParent; // 0xB0
	[SerializeField]
	private GameObject userScoreNonDataObjectParent; // 0xB8
	[SerializeField]
	[Header("Reward")]
	private GameObject rewardWindow; // 0xC0
	[SerializeField]
	private UILabel[] rewardLabels; // 0xC8
	[SerializeField]
	private GameObject rewardPlayerContent; // 0xD0
	[SerializeField]
	private float[] rewardPlayerContentPosY; // 0xD8
	[SerializeField]
	private UILabel rewardPlayerLabel; // 0xE0
	[SerializeField]
	private UILabel rewardPlayerRewardLabel; // 0xE8
	[Header("PopWindow")]
	[SerializeField]
	private GameObject popWindow; // 0xF0
	[SerializeField]
	private UILabel popWindowTitleLabel; // 0xF8
	[SerializeField]
	private UILabel popWindowLabel; // 0x100
	private ScoreAttackRoomData roomData; // 0x108
	private SystemTextManager systemTextManager; // 0x110
	private EnemyTextManager enemyTextManager; // 0x118
	private bool inputLock; // 0x120
	private Dictionary<UIScoreAttackRankingManager.RankingType, UIScoreAttackRankingManager.RankingData> rankingData; // 0x128
	private UIActiveState previousState; // 0x130
	private UIScoreAttackRankingManager.RankingType rankingType; // 0x134
	private UIScoreAttackRankingManager.ScreenState screenState; // 0x138
	private UIScoreAttackRankingManager.ScreenState prevScreenState; // 0x13C
	private UIScoreAttackRankingManager.BossType bossType; // 0x140
	private Dictionary<UIScoreAttackRankingManager.RankingType, byte> rankingRotationIds; // 0x148
	private const float rankingContentBasePos = -50;
	private const int rankingContentHeight = 105;
	private const int rankingContentMaxCount = 30;
	private List<UIScoreAttackRankingContent> rankingContents; // 0x150
	private UIIruna2Viewport viewCamera; // 0x158
	private bool isInstans; // 0x160
	private Action popWindowCallBack; // 0x168
	private const string CalculatingKey = "CalculatingPeriod";

	// Properties
	public bool IsRankingActive { get; }
	public bool IsPopUpWindow { get; }
	public bool InputLock { get; }
	private bool isDisplayRanking { get; }
	public bool IsRewardConf { get; }
	public ScoreAttackRankingType NowRankingType { get; }

	// Methods

	// RVA: 0x18CF2FC Offset: 0x18CB2FC VA: 0x18CF2FC
	public bool get_IsRankingActive() { }

	// RVA: 0x18CF330 Offset: 0x18CB330 VA: 0x18CF330
	public bool get_IsPopUpWindow() { }

	// RVA: 0x18D157C Offset: 0x18CD57C VA: 0x18D157C
	public bool get_InputLock() { }

	// RVA: 0x18D159C Offset: 0x18CD59C VA: 0x18D159C
	private bool get_isDisplayRanking() { }

	// RVA: 0x18CF318 Offset: 0x18CB318 VA: 0x18CF318
	public bool get_IsRewardConf() { }

	// RVA: 0x18D15AC Offset: 0x18CD5AC VA: 0x18D15AC
	public ScoreAttackRankingType get_NowRankingType() { }

	// RVA: 0x18D15D0 Offset: 0x18CD5D0 VA: 0x18D15D0
	private void Update() { }

	// RVA: 0x18CC9C0 Offset: 0x18C89C0 VA: 0x18CC9C0
	public void Initialize(ScoreAttackRoomData roomData, Action popWindowCallBack) { }

	// RVA: 0x18D17D0 Offset: 0x18CD7D0 VA: 0x18D17D0
	public void ChangeScreen(UIScoreAttackRankingManager.ScreenState state) { }

	// RVA: 0x18CF328 Offset: 0x18CB328 VA: 0x18CF328
	public void ChangePrevScreen() { }

	// RVA: 0x18CC9A0 Offset: 0x18C89A0 VA: 0x18CC9A0
	public void ChangeWindowActive(bool active) { }

	// RVA: 0x18D29F0 Offset: 0x18CE9F0 VA: 0x18D29F0
	public void OnClickChangeDepartment(int department) { }

	// RVA: 0x18D2AA0 Offset: 0x18CEAA0 VA: 0x18D2AA0
	public void OnClickChangeRankingType(bool isRight) { }

	// RVA: 0x18D2B54 Offset: 0x18CEB54 VA: 0x18D2B54
	public void OnClickChangeBossType(int bossType) { }

	// RVA: 0x18D2C10 Offset: 0x18CEC10 VA: 0x18D2C10
	public void OnClickChangeRewardConf() { }

	// RVA: 0x18CF340 Offset: 0x18CB340 VA: 0x18CF340
	public void OnClickPopUpWindowButton() { }

	// RVA: 0x18D2C98 Offset: 0x18CEC98 VA: 0x18D2C98
	private void ErrorCallBack(string error) { }

	// RVA: 0x18D214C Offset: 0x18CE14C VA: 0x18D214C
	private void SetRanking(bool isCalculatingPeriod = False) { }

	// RVA: 0x18D2E6C Offset: 0x18CEE6C VA: 0x18D2E6C
	private void SetRankingContent() { }

	// RVA: 0x18D34F4 Offset: 0x18CF4F4 VA: 0x18D34F4
	private void SetUserScore() { }

	// RVA: 0x18D24CC Offset: 0x18CE4CC VA: 0x18D24CC
	private void SetRewardScreen() { }

	// RVA: 0x18D37B0 Offset: 0x18CF7B0 VA: 0x18D37B0
	private string FormatCategory(string s) { }

	// RVA: 0x18D2390 Offset: 0x18CE390 VA: 0x18D2390
	private byte GetRotationBossId(byte rotationId, UIScoreAttackRankingManager.BossType bossType) { }

	// RVA: 0x18D1F1C Offset: 0x18CDF1C VA: 0x18D1F1C
	private void ChangeBossName() { }

	// RVA: 0x18D3828 Offset: 0x18CF828 VA: 0x18D3828
	private int GetTargetRotationId() { }

	// RVA: 0x18D3894 Offset: 0x18CF894 VA: 0x18D3894
	public void .ctor() { }
}

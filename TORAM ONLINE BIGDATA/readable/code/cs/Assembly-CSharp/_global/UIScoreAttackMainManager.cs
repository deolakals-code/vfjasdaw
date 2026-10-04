// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScoreAttackMainManager : UIBasePanel // TypeDefIndex: 6251
{
	// Fields
	[SerializeField]
	private GameObject screen; // 0x30
	[SerializeField]
	[Header("Title")]
	private GameObject titleWindow; // 0x38
	[SerializeField]
	private UILabel titleLabel; // 0x40
	[SerializeField]
	[Header("BossList")]
	private GameObject[] listObjects; // 0x48
	[SerializeField]
	private UILabel remainingTimeLabel; // 0x50
	[SerializeField]
	private GameObject exclamationMark; // 0x58
	[SerializeField]
	private UIScrollWindow bossListScrollWindow; // 0x60
	[SerializeField]
	private UIScoreAttackMainListContent bossListContent; // 0x68
	[SerializeField]
	[Header("Information")]
	private GameObject infomationWindow; // 0x70
	[SerializeField]
	private UILabel infoTitleLabel; // 0x78
	[SerializeField]
	private UILabel infoLabel; // 0x80
	[SerializeField]
	private GameObject infoRightButton; // 0x88
	[SerializeField]
	private GameObject infoLeftButton; // 0x90
	[SerializeField]
	private GameObject rankChangedObj; // 0x98
	[SerializeField]
	private UIScrollWindow rankChangedScrollWindow; // 0xA0
	[SerializeField]
	private UIScoreAttackRewardsContent rankChangedContent; // 0xA8
	[SerializeField]
	[Header("PopWindow")]
	private GameObject popWindow; // 0xB0
	[SerializeField]
	private UILabel popWindowTitleLabel; // 0xB8
	[SerializeField]
	private UILabel popWindowLabel; // 0xC0
	[SerializeField]
	[Header("Gm")]
	private GameObject gmButton; // 0xC8
	private ScoreAttackRoomData roomData; // 0xD0
	private List<GameObject> bossListContents; // 0xD8
	private const float listContentBasePos = 280;
	private const float listContentHeight = 160;
	private UIScoreAttackMainManager.PanelState panelState; // 0xE0
	private UIScoreAttackMainManager.InfoPage pageNum; // 0xE4
	private EmergencyPositionData emergencyPosition; // 0xE8
	private UIScoreAttackRankingManager rankingManager; // 0xF0
	private UIScoreAttackRewardsManager rewardsManager; // 0xF8
	private Action popWindowCallBack; // 0x100
	private bool isIgnoreRotation; // 0x108
	private UIScoreAttackRewardsContent[] rankChangedScrollButtons; // 0x110
	private const float rankChangedContentBasePos = -70;
	private const float rankChangedContentHeight = 130;
	private List<ScoreAttackRankUpData> receivedRankUpDatas; // 0x118
	[CompilerGenerated]
	private bool <IsClose>k__BackingField; // 0x120
	[CompilerGenerated]
	private bool <IsCancel>k__BackingField; // 0x121

	// Properties
	public bool IsClose { get; set; }
	public bool IsCancel { get; set; }
	public ScoreAttackRotationData[] RotationDatas { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18CBEB8 Offset: 0x18C7EB8 VA: 0x18CBEB8
	public bool get_IsClose() { }

	[CompilerGenerated]
	// RVA: 0x18CBEC0 Offset: 0x18C7EC0 VA: 0x18CBEC0
	private void set_IsClose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x18CBECC Offset: 0x18C7ECC VA: 0x18CBECC
	public bool get_IsCancel() { }

	[CompilerGenerated]
	// RVA: 0x18CBED4 Offset: 0x18C7ED4 VA: 0x18CBED4
	private void set_IsCancel(bool value) { }

	// RVA: 0x18CBEE0 Offset: 0x18C7EE0 VA: 0x18CBEE0
	public ScoreAttackRotationData[] get_RotationDatas() { }

	// RVA: 0x18CBEFC Offset: 0x18C7EFC VA: 0x18CBEFC
	private void Awake() { }

	// RVA: 0x18CC04C Offset: 0x18C804C VA: 0x18CC04C
	private void Start() { }

	// RVA: 0x18CC1DC Offset: 0x18C81DC VA: 0x18CC1DC
	public void OnClickChangeInformation() { }

	// RVA: 0x18CC3DC Offset: 0x18C83DC VA: 0x18CC3DC
	public void OnClickChangeInfoPage(bool isNext) { }

	// RVA: 0x18CC60C Offset: 0x18C860C VA: 0x18CC60C
	public void OnClickRanking() { }

	// RVA: 0x18CCF4C Offset: 0x18C8F4C VA: 0x18CCF4C
	public void OnClickRewardReceipt() { }

	// RVA: 0x18CD458 Offset: 0x18C9458 VA: 0x18CD458
	public void OnClickBossSelect(ScoreAttackBossData bossData) { }

	// RVA: 0x18CD598 Offset: 0x18C9598 VA: 0x18CD598
	public void OnClickPopUpWindowButton() { }

	// RVA: 0x18CD620 Offset: 0x18C9620 VA: 0x18CD620
	public void OnClickGmOpenBossList() { }

	// RVA: 0x18CD630 Offset: 0x18C9630 VA: 0x18CD630
	public void OnClickRankChangedReceiveCompleate() { }

	// RVA: 0x18CD698 Offset: 0x18C9698 VA: 0x18CD698
	public void SetEmergencyPositionData(EmergencyPositionData data) { }

	// RVA: 0x18CC050 Offset: 0x18C8050 VA: 0x18CC050
	private void Initialize() { }

	// RVA: 0x18CC244 Offset: 0x18C8244 VA: 0x18CC244
	private void ChangePanel(UIScoreAttackMainManager.PanelState state) { }

	// RVA: 0x18CD6A0 Offset: 0x18C96A0 VA: 0x18CD6A0
	private void InitializeBossList() { }

	// RVA: 0x18CE568 Offset: 0x18CA568 VA: 0x18CE568
	private void InitializeInfo() { }

	// RVA: 0x18CE62C Offset: 0x18CA62C VA: 0x18CE62C
	private void InitializeRankChanged() { }

	// RVA: 0x18CC470 Offset: 0x18C8470 VA: 0x18CC470
	private void ChangeInfoPage(UIScoreAttackMainManager.InfoPage infoPage) { }

	// RVA: 0x18CE9C0 Offset: 0x18CA9C0 VA: 0x18CE9C0
	private void InitializePopWindow() { }

	// RVA: 0x18CF068 Offset: 0x18CB068 VA: 0x18CF068
	private void PopupWindow(string title, string message, Action callBack) { }

	// RVA: 0x18CEA84 Offset: 0x18CAA84 VA: 0x18CEA84
	private bool IsNotAnyReceivedRankUpData(ScoreAttackRankUpData[] rankUpDatas) { }

	// RVA: 0x18CF0D4 Offset: 0x18CB0D4 VA: 0x18CF0D4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18CF628 Offset: 0x18CB628 VA: 0x18CF628 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18CF878 Offset: 0x18CB878 VA: 0x18CF878
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x18CF88C Offset: 0x18CB88C VA: 0x18CF88C
	private void <OnClickRanking>b__51_0() { }

	[CompilerGenerated]
	// RVA: 0x18CF8C4 Offset: 0x18CB8C4 VA: 0x18CF8C4
	private void <OnClickRewardReceipt>b__52_0() { }

	[CompilerGenerated]
	// RVA: 0x18CF8FC Offset: 0x18CB8FC VA: 0x18CF8FC
	private void <Initialize>b__58_0(ScoreAttackGetRotationResponse response) { }

	[CompilerGenerated]
	// RVA: 0x18CFA80 Offset: 0x18CBA80 VA: 0x18CFA80
	private void <Initialize>b__58_2(ScoreAttackGetRewardInfoResponse response) { }

	[CompilerGenerated]
	// RVA: 0x18CFB00 Offset: 0x18CBB00 VA: 0x18CFB00
	private void <Initialize>b__58_3(string error) { }

	[CompilerGenerated]
	// RVA: 0x18CFB08 Offset: 0x18CBB08 VA: 0x18CFB08
	private void <Initialize>b__58_1(string error) { }

	[CompilerGenerated]
	// RVA: 0x18CFBF4 Offset: 0x18CBBF4 VA: 0x18CFBF4
	private void <Initialize>b__58_4() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISnowballResultManager : UIBasePanel // TypeDefIndex: 6029
{
	// Fields
	[SerializeField]
	private Transform modelParent; // 0x30
	[SerializeField]
	private UILabel resultLabel; // 0x38
	[SerializeField]
	private GameObject resultEffect; // 0x40
	[SerializeField]
	private GameObject resultIcons; // 0x48
	[SerializeField]
	private UILabel[] throwLabels; // 0x50
	[SerializeField]
	private UILabel[] hitLabels; // 0x58
	[SerializeField]
	private UILabel[] damageLabels; // 0x60
	[SerializeField]
	private UIIruna2Anchor rewardAnchor; // 0x68
	[SerializeField]
	private UILabel rewardLabel; // 0x70
	[SerializeField]
	private UILabel[] hpLabel; // 0x78
	[SerializeField]
	private UIIcon rewardIcon; // 0x80
	private MiniGameRoomData roomData; // 0x88
	private PlayerDataManager playerDataManager; // 0x90
	private GameObject playerModelObj; // 0x98
	private GameObject targetObject; // 0xA0
	private TakeController takeController; // 0xA8
	private int takeUid; // 0xB0
	private Animation animationModel; // 0xB8
	private int takeId; // 0xC0
	private bool isMerged; // 0xC4
	private List<MiniGameMemberResultData> allResultDataList; // 0xC8
	private ChatChannelType saveChatType; // 0xD0

	// Methods

	// RVA: 0x186E53C Offset: 0x186A53C VA: 0x186E53C
	private void Start() { }

	// RVA: 0x186F218 Offset: 0x186B218 VA: 0x186F218
	private void Update() { }

	// RVA: 0x186F270 Offset: 0x186B270 VA: 0x186F270
	private void OnDestroy() { }

	// RVA: 0x186E540 Offset: 0x186A540 VA: 0x186E540
	private void Initialize() { }

	// RVA: 0x186F318 Offset: 0x186B318 VA: 0x186F318
	private void InitScoreRank() { }

	// RVA: 0x186F6DC Offset: 0x186B6DC VA: 0x186F6DC
	private int GetThrowRankInTeam(MiniGameMemberResultData myData) { }

	// RVA: 0x186F8F8 Offset: 0x186B8F8 VA: 0x186F8F8
	private int GetHitRankInTeam(MiniGameMemberResultData myData) { }

	// RVA: 0x186FB14 Offset: 0x186BB14 VA: 0x186FB14
	private int GetDamageRankInTeam(MiniGameMemberResultData myData) { }

	// RVA: 0x186F770 Offset: 0x186B770 VA: 0x186F770
	private int GetThrowRankInAll(MiniGameMemberResultData myData) { }

	// RVA: 0x186F98C Offset: 0x186B98C VA: 0x186F98C
	private int GetHitRankInAll(MiniGameMemberResultData myData) { }

	// RVA: 0x186FBA8 Offset: 0x186BBA8 VA: 0x186FBA8
	private int GetDamageRankInAll(MiniGameMemberResultData myData) { }

	// RVA: 0x186FD30 Offset: 0x186BD30 VA: 0x186FD30
	private void OnTakeEvent(int takePlayerUid, TakeEventType eventType, int param) { }

	[IteratorStateMachine(typeof(UISnowballResultManager.<TakePlay>d__34))]
	// RVA: 0x186FD70 Offset: 0x186BD70 VA: 0x186FD70
	private IEnumerator TakePlay() { }

	// RVA: 0x186FE04 Offset: 0x186BE04 VA: 0x186FE04
	private string GetRewardText(RewardData data) { }

	// RVA: 0x1870288 Offset: 0x186C288 VA: 0x1870288 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x187034C Offset: 0x186C34C VA: 0x187034C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18703F0 Offset: 0x186C3F0 VA: 0x18703F0
	public void .ctor() { }
}

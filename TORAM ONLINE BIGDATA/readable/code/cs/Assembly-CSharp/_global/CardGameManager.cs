// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CardGameManager : Singleton<CardGameManager>, ISceneChangeManager // TypeDefIndex: 4285
{
	// Fields
	private int operationErrCount; // 0x20
	private bool isLastChance; // 0x24
	private bool lastChanceSelector; // 0x25
	private GameManager gameManager; // 0x28
	private CameraManager cameraManager; // 0x30
	private PlayerDataManager playerDataManager; // 0x38
	private UICardGameManager uiManager; // 0x40
	private CardGameFieldCardManager fieldCardManager; // 0x48
	private CardGameBossCardManager bossCardManager; // 0x50
	private CardGameBattleManager battleManager; // 0x58
	private List<CardGameManager.CardGameBossId> turnBossList; // 0x60
	private CardGameManager.CardGameUseCardData useCardData; // 0x68
	private Dictionary<int, List<CardGameManager.CardGameAttackCardData>> speedAttackForBossA; // 0x70
	private Dictionary<int, List<CardGameManager.CardGameAttackCardData>> speedAttackForBossB; // 0x78
	private Dictionary<int, List<CardGameManager.CardGameAttackCardData>> speedAttackForBossC; // 0x80
	private Dictionary<int, List<CardGameManager.CardGameAttackCardData>> speedAttackForBossD; // 0x88
	private Dictionary<int, List<CardGameManager.CardGameAttackCardData>> speedAttackForBossEx; // 0x90
	private CardGameTurnTableData saveServerData; // 0x98
	private List<CardGameMemberModel> memberModel; // 0xA0
	private Dictionary<int, CardGameBossModel> bossModels; // 0xA8
	private readonly Vector3 bossPositionDefault; // 0xB0
	private const float bossPositionInterval = 10.7;
	private Object[] textureData; // 0xC0
	private int haveSpina; // 0xC8
	private bool isBattlePhase; // 0xCC
	private byte turnCount; // 0xCD
	private const float screenFadeTime = 0.5;
	private readonly Vector3 defaultCameraPos; // 0xD0
	private readonly Vector3 defaultCameraRot; // 0xDC
	private const int houseItemId = 600130;
	private SystemTextManager systemTextManager; // 0xE8
	private bool isPopWindow; // 0xF0
	private CardGameMemberData[] memberData; // 0xF8
	private CardGameMemberData myMemberData; // 0x100
	private CardGameSettingData setting; // 0x108
	private int menuBGMId; // 0x110
	private int gameBGMId; // 0x114
	private int lastBossBGMId; // 0x118
	private int activeBGMId; // 0x11C
	private CardGameResultData gameResultData; // 0x120
	private byte accumulationCount; // 0x128
	private Dictionary<int, short> accumulationScore; // 0x130
	[CompilerGenerated]
	private short <HighestScore>k__BackingField; // 0x138
	[CompilerGenerated]
	private int <MyRate>k__BackingField; // 0x13C
	[CompilerGenerated]
	private bool <IsRateValid>k__BackingField; // 0x140
	[CompilerGenerated]
	private bool <IsGameStart>k__BackingField; // 0x141
	[CompilerGenerated]
	private int <TableOwnerId>k__BackingField; // 0x144
	private bool errAllReset; // 0x148

	// Properties
	public short HighestScore { get; set; }
	public int MyRate { get; set; }
	public bool IsRateValid { get; set; }
	public bool IsOwner { get; }
	public int HaveSpina { get; }
	public CardGameBossCardManager BossManager { get; }
	public List<CardGamePlayerCard> PlayerCardList { get; }
	public List<CardGamePlayerCard> MarketCardList { get; }
	public List<CardGameBossCard> BossCardList { get; }
	public List<CardGameBossCard> FieldBossCardList { get; }
	public Dictionary<byte, byte>[] PlayerAttackCardData { get; }
	public bool IsGameStart { get; set; }
	public int TableOwnerId { get; set; }
	public int BossNum { get; }
	public CardGameMemberData[] MemberData { get; }
	public List<CardGameMemberModel> MemberModel { get; }
	public Dictionary<int, CardGameBossModel> BossModel { get; }
	public CardGameSettingData Setting { get; }

	// Methods

	// RVA: 0x24BB0EC Offset: 0x24B70EC VA: 0x24BB0EC
	public static CardGameManager LoginManager() { }

	[CompilerGenerated]
	// RVA: 0x24BB1EC Offset: 0x24B71EC VA: 0x24BB1EC
	public short get_HighestScore() { }

	[CompilerGenerated]
	// RVA: 0x24BB1F4 Offset: 0x24B71F4 VA: 0x24BB1F4
	private void set_HighestScore(short value) { }

	[CompilerGenerated]
	// RVA: 0x24BB1FC Offset: 0x24B71FC VA: 0x24BB1FC
	public int get_MyRate() { }

	[CompilerGenerated]
	// RVA: 0x24BB204 Offset: 0x24B7204 VA: 0x24BB204
	private void set_MyRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x24BB20C Offset: 0x24B720C VA: 0x24BB20C
	public bool get_IsRateValid() { }

	[CompilerGenerated]
	// RVA: 0x24BB214 Offset: 0x24B7214 VA: 0x24BB214
	private void set_IsRateValid(bool value) { }

	// RVA: 0x24BB220 Offset: 0x24B7220 VA: 0x24BB220
	public bool get_IsOwner() { }

	// RVA: 0x24BB298 Offset: 0x24B7298 VA: 0x24BB298
	public int get_HaveSpina() { }

	// RVA: 0x24BB2A0 Offset: 0x24B72A0 VA: 0x24BB2A0
	public CardGameBossCardManager get_BossManager() { }

	// RVA: 0x24BB2A8 Offset: 0x24B72A8 VA: 0x24BB2A8
	public List<CardGamePlayerCard> get_PlayerCardList() { }

	// RVA: 0x24BB5D4 Offset: 0x24B75D4 VA: 0x24BB5D4
	public List<CardGamePlayerCard> get_MarketCardList() { }

	// RVA: 0x24B74FC Offset: 0x24B34FC VA: 0x24B74FC
	public List<CardGameBossCard> get_BossCardList() { }

	// RVA: 0x24BB5F0 Offset: 0x24B75F0 VA: 0x24BB5F0
	public List<CardGameBossCard> get_FieldBossCardList() { }

	// RVA: 0x24BB608 Offset: 0x24B7608 VA: 0x24BB608
	public Dictionary<byte, byte>[] get_PlayerAttackCardData() { }

	[CompilerGenerated]
	// RVA: 0x24BB624 Offset: 0x24B7624 VA: 0x24BB624
	public bool get_IsGameStart() { }

	[CompilerGenerated]
	// RVA: 0x24BB62C Offset: 0x24B762C VA: 0x24BB62C
	private void set_IsGameStart(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24BB638 Offset: 0x24B7638 VA: 0x24BB638
	public int get_TableOwnerId() { }

	[CompilerGenerated]
	// RVA: 0x24BB640 Offset: 0x24B7640 VA: 0x24BB640
	private void set_TableOwnerId(int value) { }

	// RVA: 0x24BB648 Offset: 0x24B7648 VA: 0x24BB648
	public int get_BossNum() { }

	// RVA: 0x24BB664 Offset: 0x24B7664 VA: 0x24BB664
	public CardGameMemberData[] get_MemberData() { }

	// RVA: 0x24BB66C Offset: 0x24B766C VA: 0x24BB66C
	public List<CardGameMemberModel> get_MemberModel() { }

	// RVA: 0x24BB674 Offset: 0x24B7674 VA: 0x24BB674
	public Dictionary<int, CardGameBossModel> get_BossModel() { }

	// RVA: 0x24BB67C Offset: 0x24B767C VA: 0x24BB67C
	public CardGameSettingData get_Setting() { }

	// RVA: 0x24BB684 Offset: 0x24B7684 VA: 0x24BB684
	private void Awake() { }

	// RVA: 0x24BB814 Offset: 0x24B7814 VA: 0x24BB814
	private void Update() { }

	// RVA: 0x24BBC20 Offset: 0x24B7C20 VA: 0x24BBC20
	private void OnApplicationPause(bool pauseStatus) { }

	// RVA: 0x24BBCD0 Offset: 0x24B7CD0 VA: 0x24BBCD0
	public void Enter() { }

	// RVA: 0x24BBCF4 Offset: 0x24B7CF4 VA: 0x24BBCF4
	public void EnterReady(CardGameSettingData data) { }

	// RVA: 0x24BBD10 Offset: 0x24B7D10 VA: 0x24BBD10
	public void EnterReadyCancel() { }

	// RVA: 0x24BBD2C Offset: 0x24B7D2C VA: 0x24BBD2C
	public void GiveUp() { }

	// RVA: 0x24BBD48 Offset: 0x24B7D48 VA: 0x24BBD48
	public void Leave() { }

	// RVA: 0x24BBD64 Offset: 0x24B7D64 VA: 0x24BBD64
	public void TurnEnd() { }

	// RVA: 0x24BBF2C Offset: 0x24B7F2C VA: 0x24BBF2C
	public void CheckReconnection() { }

	// RVA: 0x24BC024 Offset: 0x24B8024 VA: 0x24BC024
	public void Reacquire() { }

	// RVA: 0x24BC04C Offset: 0x24B804C VA: 0x24BC04C
	public void ResultEnd() { }

	// RVA: 0x24BC1E4 Offset: 0x24B81E4 VA: 0x24BC1E4
	public void LastChanceSelected(byte select) { }

	// RVA: 0x24BC220 Offset: 0x24B8220 VA: 0x24BC220
	public void GetCardGameBattleRecord(Action callback) { }

	// RVA: 0x24BC350 Offset: 0x24B8350 VA: 0x24BC350
	public void ReceiveJoinResponse(CardGameJoinResponse response) { }

	// RVA: 0x24BC940 Offset: 0x24B8940 VA: 0x24BC940
	public void ReceiveTurnEnd() { }

	// RVA: 0x24BC944 Offset: 0x24B8944 VA: 0x24BC944
	public void ReceiveLeave() { }

	// RVA: 0x24BC97C Offset: 0x24B897C VA: 0x24BC97C
	public void ReceiveGiveUp() { }

	// RVA: 0x24BC9B4 Offset: 0x24B89B4 VA: 0x24BC9B4
	public void ReceiveEventCardGameState(CardGameStateEvent state) { }

	// RVA: 0x24BCD08 Offset: 0x24B8D08 VA: 0x24BCD08
	public void ReceiveEventCardGameTableCheck(CardGameTableCheckResponse response) { }

	// RVA: 0x24BCD0C Offset: 0x24B8D0C VA: 0x24BCD0C
	public void ReceiveEventCardGameStart(CardGameStartEvent start) { }

	// RVA: 0x24BD658 Offset: 0x24B9658 VA: 0x24BD658
	public void ReceiveEventCardGameTurnEnd(bool isLastChance, bool lastChanceSelector, CardGameTurnCardData[] allTurnData, CardGameTurnTableData tableData) { }

	// RVA: 0x24BE7B8 Offset: 0x24BA7B8 VA: 0x24BE7B8
	public void ReceiveEventEndCardGameResult(CardGameEndEvent end) { }

	// RVA: 0x24BE82C Offset: 0x24BA82C VA: 0x24BE82C
	public void ReceiveEventCardGameLastChanceEnd(CardGameLastChanceEndEvent turn) { }

	// RVA: 0x24BF484 Offset: 0x24BB484 VA: 0x24BF484
	public void ReceiveEventCardGameReacquire(CardGameReconnectPlayResponse response) { }

	// RVA: 0x24C0178 Offset: 0x24BC178 VA: 0x24C0178
	public void ReceiveEventCardGameResult(CardGameResultData result, Dictionary<int, short> total, byte accumulationCount) { }

	// RVA: 0x24C034C Offset: 0x24BC34C VA: 0x24C034C
	public void ReceiveEventCardGameEnd() { }

	// RVA: 0x24C0438 Offset: 0x24BC438 VA: 0x24C0438
	public void ReceiveEventCardGameGiveUp(CardGameGiveupEvent giveup) { }

	// RVA: 0x24C043C Offset: 0x24BC43C VA: 0x24C043C
	public void ReceiveEventCardGameKickout(CardGameKickoutEvent kickout) { }

	// RVA: 0x24C044C Offset: 0x24BC44C VA: 0x24C044C Slot: 4
	public void OnEnter() { }

	// RVA: 0x24C060C Offset: 0x24BC60C VA: 0x24C060C Slot: 5
	public void OnLeave() { }

	// RVA: 0x24C0A6C Offset: 0x24BCA6C VA: 0x24C0A6C
	public CardGameManager.RetrunPurchaseCardCode PurchaseCard(byte uniqueId) { }

	// RVA: 0x24C0D34 Offset: 0x24BCD34 VA: 0x24C0D34
	public bool ReserveSaleCard(byte uniqueId) { }

	// RVA: 0x24C0E14 Offset: 0x24BCE14 VA: 0x24C0E14
	public bool ReserveAttackToEnemy(int uniqueId, byte cardId) { }

	// RVA: 0x24C0EE0 Offset: 0x24BCEE0 VA: 0x24C0EE0
	public bool ResetAttackReservation(CardGamePlayerCard card) { }

	// RVA: 0x24B8BA0 Offset: 0x24B4BA0 VA: 0x24B8BA0
	public void AttackDamage(CardGameManager.CardGameAttackCardData atkData, bool last) { }

	// RVA: 0x24B79D4 Offset: 0x24B39D4 VA: 0x24B79D4
	public void AttackEnd(int boss, bool lastAttack) { }

	// RVA: 0x24B7C50 Offset: 0x24B3C50 VA: 0x24B7C50
	public void BattleEnd(int boss) { }

	// RVA: 0x24C10A8 Offset: 0x24BD0A8 VA: 0x24C10A8
	private void BossBattleTarget(CardGameManager.CardGameBossId boss, float timer) { }

	// RVA: 0x24B6ED8 Offset: 0x24B2ED8 VA: 0x24B6ED8
	public void BossDead(int boss, List<int> aidList) { }

	[IteratorStateMachine(typeof(CardGameManager.<BossResetDamage>d__135))]
	// RVA: 0x24C1024 Offset: 0x24BD024 VA: 0x24C1024
	private IEnumerator BossResetDamage(int boss) { }

	// RVA: 0x24C151C Offset: 0x24BD51C VA: 0x24C151C
	public void LoadCardTexture() { }

	// RVA: 0x24C1598 Offset: 0x24BD598 VA: 0x24C1598
	public Texture GetCardTexture(int id) { }

	// RVA: 0x24C1640 Offset: 0x24BD640 VA: 0x24C1640
	public void SelectPhaseEnd() { }

	// RVA: 0x24BC5F8 Offset: 0x24B85F8 VA: 0x24BC5F8
	public void SetUIManager(UICardGameManager manager) { }

	[IteratorStateMachine(typeof(CardGameManager.<LoadBGM>d__140))]
	// RVA: 0x24C1644 Offset: 0x24BD644 VA: 0x24C1644
	public IEnumerator LoadBGM() { }

	// RVA: 0x24BC84C Offset: 0x24B884C VA: 0x24BC84C
	private void CheckPlayBGM() { }

	// RVA: 0x24BD190 Offset: 0x24B9190 VA: 0x24BD190
	private List<byte> UpdateTableData(CardGameTurnTableData tableData) { }

	// RVA: 0x24BE698 Offset: 0x24BA698 VA: 0x24BE698
	private void PhaseBattle(bool isSpecial) { }

	// RVA: 0x24C124C Offset: 0x24BD24C VA: 0x24C124C
	private void PhaseResult() { }

	// RVA: 0x24C00B4 Offset: 0x24BC0B4 VA: 0x24C00B4
	private void BossHpUpdate(int id, bool isView, byte viewHp, byte severHp, short spina, bool isLastAttack) { }

	[IteratorStateMachine(typeof(CardGameManager.<ChangeResultPanel>d__146))]
	// RVA: 0x24C16F0 Offset: 0x24BD6F0 VA: 0x24C16F0
	private IEnumerator ChangeResultPanel(CardGameResultData result, Dictionary<int, short> total, byte accumulationCount) { }

	// RVA: 0x24BE024 Offset: 0x24BA024 VA: 0x24BE024
	private bool CreateAttackData(List<byte> card, int archetypeId, CardGameManager.CardGameBossId targetBoss, out CardGameManager.CardGameAttackCardData data) { }

	// RVA: 0x24BE2C4 Offset: 0x24BA2C4 VA: 0x24BE2C4
	private void CreateSpeedAtkData(bool isSpecialCard, List<CardGameManager.CardGameAttackCardData> atkData, out Dictionary<int, List<CardGameManager.CardGameAttackCardData>> speed) { }

	// RVA: 0x24BEF18 Offset: 0x24BAF18 VA: 0x24BEF18
	private void PopExBoss(int id) { }

	[IteratorStateMachine(typeof(CardGameManager.<LoadBossModel>d__150))]
	// RVA: 0x24BD5EC Offset: 0x24B95EC VA: 0x24BD5EC
	private IEnumerator LoadBossModel() { }

	// RVA: 0x24BC774 Offset: 0x24B8774 VA: 0x24BC774
	private void UpdateCameraPosition(Vector3 pos, Vector3 rot) { }

	// RVA: 0x24C182C Offset: 0x24BD82C VA: 0x24C182C
	private void SetBattleCamera() { }

	// RVA: 0x24BC534 Offset: 0x24B8534 VA: 0x24BC534
	private void UpdateMyMemberData() { }

	[IteratorStateMachine(typeof(CardGameManager.<UpdateMemberModelList>d__154))]
	// RVA: 0x24BC69C Offset: 0x24B869C VA: 0x24BC69C
	private IEnumerator UpdateMemberModelList() { }

	// RVA: 0x24C1898 Offset: 0x24BD898 VA: 0x24C1898
	private GameObject CloneOtherPlayer(int archetypeId) { }

	// RVA: 0x24C1D50 Offset: 0x24BDD50 VA: 0x24C1D50
	private void StopResultMotion() { }

	// RVA: 0x24C1EC8 Offset: 0x24BDEC8 VA: 0x24C1EC8
	private void ErrorWindow() { }

	// RVA: 0x24BBA90 Offset: 0x24B7A90 VA: 0x24BBA90
	private void LeaveWindow() { }

	// RVA: 0x24C2000 Offset: 0x24BE000 VA: 0x24C2000
	private void LeaveButton() { }

	[IteratorStateMachine(typeof(CardGameManager.<ChangeMainGameNonPanel>d__160))]
	// RVA: 0x24BBA2C Offset: 0x24B7A2C VA: 0x24BBA2C
	private IEnumerator ChangeMainGameNonPanel(bool isPanelCheck) { }

	[IteratorStateMachine(typeof(CardGameManager.<ChangeMainPanel>d__161))]
	// RVA: 0x24C05A0 Offset: 0x24BC5A0 VA: 0x24C05A0
	private IEnumerator ChangeMainPanel() { }

	[IteratorStateMachine(typeof(CardGameManager.<FinishWait>d__162))]
	// RVA: 0x24BC708 Offset: 0x24B8708 VA: 0x24BC708
	private IEnumerator FinishWait() { }

	[IteratorStateMachine(typeof(CardGameManager.<LeaveWait>d__163))]
	// RVA: 0x24C2024 Offset: 0x24BE024 VA: 0x24C2024
	public IEnumerator LeaveWait() { }

	// RVA: 0x24C2130 Offset: 0x24BE130 VA: 0x24C2130
	public void CheckOperationFailure(byte operationCode, byte subCode, short returnCode) { }

	// RVA: 0x24C2628 Offset: 0x24BE628 VA: 0x24C2628
	public bool CheckGameState(byte type) { }

	// RVA: 0x24C2648 Offset: 0x24BE648 VA: 0x24C2648
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x24C2CB8 Offset: 0x24BECB8 VA: 0x24C2CB8
	private void <CheckReconnection>b__104_0() { }

	[CompilerGenerated]
	// RVA: 0x24C2CD4 Offset: 0x24BECD4 VA: 0x24C2CD4
	private bool <ReceiveEventCardGameState>b__113_0(CardGameMemberData x) { }

	[CompilerGenerated]
	// RVA: 0x24C2D04 Offset: 0x24BED04 VA: 0x24C2D04
	private bool <ReceiveEventCardGameState>b__113_1(CardGameMemberData x) { }

	[CompilerGenerated]
	// RVA: 0x24C2D28 Offset: 0x24BED28 VA: 0x24C2D28
	private void <ReceiveEventCardGameEnd>b__121_0() { }

	[CompilerGenerated]
	// RVA: 0x24C2E10 Offset: 0x24BEE10 VA: 0x24C2E10
	private bool <AttackDamage>b__130_0(CardGameMemberModel x) { }

	[CompilerGenerated]
	// RVA: 0x24C2E40 Offset: 0x24BEE40 VA: 0x24C2E40
	private void <PhaseBattle>b__143_0() { }

	[CompilerGenerated]
	// RVA: 0x24C2F00 Offset: 0x24BEF00 VA: 0x24C2F00
	private void <PhaseBattle>b__143_1() { }

	[CompilerGenerated]
	// RVA: 0x24C2F58 Offset: 0x24BEF58 VA: 0x24C2F58
	private void <PhaseResult>b__144_0() { }

	[CompilerGenerated]
	// RVA: 0x24C3024 Offset: 0x24BF024 VA: 0x24C3024
	private void <PhaseResult>b__144_1() { }

	[CompilerGenerated]
	// RVA: 0x24C316C Offset: 0x24BF16C VA: 0x24C316C
	private bool <UpdateMyMemberData>b__153_0(CardGameMemberData x) { }
}

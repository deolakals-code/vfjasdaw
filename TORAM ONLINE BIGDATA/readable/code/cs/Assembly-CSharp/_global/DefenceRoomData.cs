// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DefenceRoomData : RoomDataBase // TypeDefIndex: 2335
{
	// Fields
	private GameObject mapDataManagerObject; // 0x68
	private DefenceMapDataManager _defenceMapDataManager; // 0x70
	private List<DefenceMapChip> serverList; // 0x78
	private Vector3 startPosition; // 0x80
	private double timeLeft; // 0x90
	private float oldTime; // 0x98
	private bool isInitMap; // 0x9C
	private DefenceRoomData.GameState gameState; // 0xA0
	private DefenceRoomData.GamePhaseActionDelegate[] gamePhaseAction; // 0xA8
	private GameObject defenceBattlePanel; // 0xB0
	private UIDefenceResultManager defenceResultPanel; // 0xB8
	private DefenceRoomData.DeadCycle deadCycleState; // 0xC0
	private DefenceRoomData.DeadCycleDelegate[] deadCycle; // 0xC8
	private float deadFadeTimer; // 0xD0
	private readonly float deadFadeTimerMax; // 0xD4
	private bool isFadeIn; // 0xD8
	private bool isRespawn; // 0xD9
	private DefenceRoomData.Result result; // 0xE0
	[CompilerGenerated]
	private RoomGroupSetting <GroupSetting>k__BackingField; // 0x100
	private float innerTimer; // 0x108
	private GameObject startWall; // 0x110
	private MeshCollider wallCollider; // 0x118
	private Ray playerRay; // 0x120
	private RaycastHit castHit; // 0x138
	[CompilerGenerated]
	private bool <IsBossAppear>k__BackingField; // 0x164
	private bool checkDefenceDataConnect; // 0x165
	[CompilerGenerated]
	private int <BestScore>k__BackingField; // 0x168
	[CompilerGenerated]
	private TimeSpan <BestTime>k__BackingField; // 0x170
	[CompilerGenerated]
	private TimeSpan <ResetTime>k__BackingField; // 0x178
	[CompilerGenerated]
	private int <TrialPoint>k__BackingField; // 0x180
	[CompilerGenerated]
	private int <Difficulty>k__BackingField; // 0x184
	[CompilerGenerated]
	private int <DiffNum>k__BackingField; // 0x188
	[CompilerGenerated]
	private int <PlayerRankType>k__BackingField; // 0x18C
	[CompilerGenerated]
	private int <RankingType>k__BackingField; // 0x190
	[CompilerGenerated]
	private Dictionary<int, DefenceRankingData[]> <ByRankingData>k__BackingField; // 0x198
	[CompilerGenerated]
	private int <CurrentRank>k__BackingField; // 0x1A0
	[CompilerGenerated]
	private int <OldRank>k__BackingField; // 0x1A4
	[CompilerGenerated]
	private DefenceRankingData <RankingResultData>k__BackingField; // 0x1A8
	[CompilerGenerated]
	private bool <ReceiveReward>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private RewardData <Reward>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private int <SeasonId>k__BackingField; // 0x1C0

	// Properties
	public RoomGroupSetting GroupSetting { get; set; }
	public DefenceMapDataManager MapDataManager { get; }
	public int TimeLeft { get; }
	public bool IsStart { get; }
	public bool IsEnd { get; }
	public override byte RoomType { get; }
	public GameObject DefenceBattlePanel { get; }
	public bool IsBossAppear { get; set; }
	public override string[] LoadAssetsPath { get; }
	public int BestScore { get; set; }
	public TimeSpan BestTime { get; set; }
	public TimeSpan ResetTime { get; set; }
	public int TrialPoint { get; set; }
	public int Difficulty { get; set; }
	public int DiffNum { get; set; }
	public int PlayerRankType { get; set; }
	public int RankingType { get; set; }
	public Dictionary<int, DefenceRankingData[]> ByRankingData { get; set; }
	public int CurrentRank { get; set; }
	public int OldRank { get; set; }
	public DefenceRankingData RankingResultData { get; set; }
	public bool ReceiveReward { get; set; }
	public RewardData Reward { get; set; }
	public int SeasonId { get; set; }
	public override string LoadFieldAssetsName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2187354 Offset: 0x2183354 VA: 0x2187354
	public RoomGroupSetting get_GroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x218735C Offset: 0x218335C VA: 0x218735C
	private void set_GroupSetting(RoomGroupSetting value) { }

	// RVA: 0x218736C Offset: 0x218336C VA: 0x218736C
	public DefenceMapDataManager get_MapDataManager() { }

	// RVA: 0x2187424 Offset: 0x2183424 VA: 0x2187424
	public int get_TimeLeft() { }

	// RVA: 0x2187444 Offset: 0x2183444 VA: 0x2187444
	public bool get_IsStart() { }

	// RVA: 0x2187454 Offset: 0x2183454 VA: 0x2187454
	public bool get_IsEnd() { }

	// RVA: 0x2187464 Offset: 0x2183464 VA: 0x2187464 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x218746C Offset: 0x218346C VA: 0x218746C
	public GameObject get_DefenceBattlePanel() { }

	[CompilerGenerated]
	// RVA: 0x2187474 Offset: 0x2183474 VA: 0x2187474
	public bool get_IsBossAppear() { }

	[CompilerGenerated]
	// RVA: 0x218747C Offset: 0x218347C VA: 0x218747C
	private void set_IsBossAppear(bool value) { }

	// RVA: 0x2187488 Offset: 0x2183488 VA: 0x2187488 Slot: 5
	public override string[] get_LoadAssetsPath() { }

	[CompilerGenerated]
	// RVA: 0x2187510 Offset: 0x2183510 VA: 0x2187510
	public int get_BestScore() { }

	[CompilerGenerated]
	// RVA: 0x2187518 Offset: 0x2183518 VA: 0x2187518
	private void set_BestScore(int value) { }

	[CompilerGenerated]
	// RVA: 0x2187520 Offset: 0x2183520 VA: 0x2187520
	public TimeSpan get_BestTime() { }

	[CompilerGenerated]
	// RVA: 0x2187528 Offset: 0x2183528 VA: 0x2187528
	private void set_BestTime(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x2187530 Offset: 0x2183530 VA: 0x2187530
	public TimeSpan get_ResetTime() { }

	[CompilerGenerated]
	// RVA: 0x2187538 Offset: 0x2183538 VA: 0x2187538
	private void set_ResetTime(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x2187540 Offset: 0x2183540 VA: 0x2187540
	public int get_TrialPoint() { }

	[CompilerGenerated]
	// RVA: 0x2187548 Offset: 0x2183548 VA: 0x2187548
	private void set_TrialPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x2187550 Offset: 0x2183550 VA: 0x2187550
	public int get_Difficulty() { }

	[CompilerGenerated]
	// RVA: 0x2187558 Offset: 0x2183558 VA: 0x2187558
	private void set_Difficulty(int value) { }

	[CompilerGenerated]
	// RVA: 0x2187560 Offset: 0x2183560 VA: 0x2187560
	public int get_DiffNum() { }

	[CompilerGenerated]
	// RVA: 0x2187568 Offset: 0x2183568 VA: 0x2187568
	private void set_DiffNum(int value) { }

	[CompilerGenerated]
	// RVA: 0x2187570 Offset: 0x2183570 VA: 0x2187570
	public int get_PlayerRankType() { }

	[CompilerGenerated]
	// RVA: 0x2187578 Offset: 0x2183578 VA: 0x2187578
	private void set_PlayerRankType(int value) { }

	[CompilerGenerated]
	// RVA: 0x2187580 Offset: 0x2183580 VA: 0x2187580
	public int get_RankingType() { }

	[CompilerGenerated]
	// RVA: 0x2187588 Offset: 0x2183588 VA: 0x2187588
	private void set_RankingType(int value) { }

	[CompilerGenerated]
	// RVA: 0x2187590 Offset: 0x2183590 VA: 0x2187590
	public Dictionary<int, DefenceRankingData[]> get_ByRankingData() { }

	[CompilerGenerated]
	// RVA: 0x2187598 Offset: 0x2183598 VA: 0x2187598
	private void set_ByRankingData(Dictionary<int, DefenceRankingData[]> value) { }

	[CompilerGenerated]
	// RVA: 0x21875A8 Offset: 0x21835A8 VA: 0x21875A8
	public int get_CurrentRank() { }

	[CompilerGenerated]
	// RVA: 0x21875B0 Offset: 0x21835B0 VA: 0x21875B0
	private void set_CurrentRank(int value) { }

	[CompilerGenerated]
	// RVA: 0x21875B8 Offset: 0x21835B8 VA: 0x21875B8
	public int get_OldRank() { }

	[CompilerGenerated]
	// RVA: 0x21875C0 Offset: 0x21835C0 VA: 0x21875C0
	private void set_OldRank(int value) { }

	[CompilerGenerated]
	// RVA: 0x21875C8 Offset: 0x21835C8 VA: 0x21875C8
	public DefenceRankingData get_RankingResultData() { }

	[CompilerGenerated]
	// RVA: 0x21875D0 Offset: 0x21835D0 VA: 0x21875D0
	private void set_RankingResultData(DefenceRankingData value) { }

	[CompilerGenerated]
	// RVA: 0x21875E0 Offset: 0x21835E0 VA: 0x21875E0
	public bool get_ReceiveReward() { }

	[CompilerGenerated]
	// RVA: 0x21875E8 Offset: 0x21835E8 VA: 0x21875E8
	private void set_ReceiveReward(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21875F4 Offset: 0x21835F4 VA: 0x21875F4
	public RewardData get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x21875FC Offset: 0x21835FC VA: 0x21875FC
	private void set_Reward(RewardData value) { }

	[CompilerGenerated]
	// RVA: 0x218760C Offset: 0x218360C VA: 0x218760C
	public int get_SeasonId() { }

	[CompilerGenerated]
	// RVA: 0x2187614 Offset: 0x2183614 VA: 0x2187614
	private void set_SeasonId(int value) { }

	// RVA: 0x218761C Offset: 0x218361C VA: 0x218761C Slot: 6
	public override string get_LoadFieldAssetsName() { }

	// RVA: 0x218768C Offset: 0x218368C VA: 0x218768C
	public void .ctor() { }

	// RVA: 0x2187BCC Offset: 0x2183BCC VA: 0x2187BCC Slot: 12
	public override void Clear() { }

	// RVA: 0x2187BD4 Offset: 0x2183BD4 VA: 0x2187BD4 Slot: 13
	public override void Enter() { }

	// RVA: 0x2188760 Offset: 0x2184760 VA: 0x2188760 Slot: 14
	public override void Leave() { }

	// RVA: 0x2188998 Offset: 0x2184998 VA: 0x2188998 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x2188A44 Offset: 0x2184A44 VA: 0x2188A44 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x2188A48 Offset: 0x2184A48 VA: 0x2188A48 Slot: 20
	public override void EnterRoomConnection() { }

	// RVA: 0x2188A4C Offset: 0x2184A4C VA: 0x2188A4C Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x2188A60 Offset: 0x2184A60 VA: 0x2188A60 Slot: 15
	public override void Update() { }

	// RVA: 0x2188F80 Offset: 0x2184F80 VA: 0x2188F80
	public void OnStart() { }

	// RVA: 0x218909C Offset: 0x218509C VA: 0x218909C
	public void UpdateEventPosition(Vector3 startPos) { }

	// RVA: 0x21891F8 Offset: 0x21851F8 VA: 0x21891F8
	public void SetSeasonId(int id) { }

	// RVA: 0x2189200 Offset: 0x2185200 VA: 0x2189200
	public void CreateMapObject() { }

	// RVA: 0x2189380 Offset: 0x2185380 VA: 0x2189380
	public void CrystalUpdate(DefenceCrystalData[] crystals) { }

	// RVA: 0x21894B0 Offset: 0x21854B0 VA: 0x21894B0
	private void CrystalBreake() { }

	// RVA: 0x21886B4 Offset: 0x21846B4 VA: 0x21886B4
	public void BossAppear() { }

	// RVA: 0x218962C Offset: 0x218562C VA: 0x218962C
	public void GameEnd(byte code, DefenceScore score, int exp) { }

	// RVA: 0x2189AC4 Offset: 0x2185AC4 VA: 0x2189AC4
	private void Win() { }

	// RVA: 0x2189BC4 Offset: 0x2185BC4 VA: 0x2189BC4
	private void Lose() { }

	// RVA: 0x218A040 Offset: 0x2186040 VA: 0x218A040
	public bool CheckGameStart() { }

	// RVA: 0x218A054 Offset: 0x2186054 VA: 0x218A054
	public void ReceiveMapList(DefenceMapChip[] receiveMapChip) { }

	// RVA: 0x218A5DC Offset: 0x21865DC VA: 0x218A5DC
	public void ReceiveCheckDefenceRoom(long remainingTime) { }

	// RVA: 0x218A6EC Offset: 0x21866EC VA: 0x218A6EC
	public bool CheckDefenceRoomConnect() { }

	// RVA: 0x218A708 Offset: 0x2186708 VA: 0x218A708
	public void ReceiveMobPop(DefenceMobData[] mobList, byte popType) { }

	// RVA: 0x218ABE0 Offset: 0x2186BE0 VA: 0x218ABE0
	private void Wait() { }

	// RVA: 0x218ADEC Offset: 0x2186DEC VA: 0x218ADEC
	private void StartWait() { }

	// RVA: 0x218AE7C Offset: 0x2186E7C VA: 0x218AE7C
	private void Play() { }

	// RVA: 0x218AEC0 Offset: 0x2186EC0 VA: 0x218AEC0
	private void End() { }

	// RVA: 0x218B0A8 Offset: 0x21870A8 VA: 0x218B0A8
	private void KnockBack() { }

	// RVA: 0x218B0E4 Offset: 0x21870E4 VA: 0x218B0E4
	private void FadeIn() { }

	// RVA: 0x218B2CC Offset: 0x21872CC VA: 0x218B2CC
	private void WaitRespawn() { }

	// RVA: 0x218B318 Offset: 0x2187318 VA: 0x218B318
	private void FadeOut() { }

	// RVA: 0x218B3F4 Offset: 0x21873F4 VA: 0x218B3F4 Slot: 18
	public override bool OnDead() { }

	// RVA: 0x218B49C Offset: 0x218749C VA: 0x218B49C
	public void Respawn(int hp, int mp) { }

	// RVA: 0x218B57C Offset: 0x218757C VA: 0x218B57C Slot: 19
	public override void RoomSynchronization(RoomSynchronizationEvent syncEvent) { }

	// RVA: 0x2187F2C Offset: 0x2183F2C VA: 0x2187F2C
	private GameObject CreateWall(Vector3 pos) { }

	// RVA: 0x218B710 Offset: 0x2187710 VA: 0x218B710
	public void ReceiveEnterDefenceRoom(int bestScore, TimeSpan bestTime, TimeSpan resetTimer, int trialPoint) { }

	// RVA: 0x218B724 Offset: 0x2187724 VA: 0x218B724
	public void UpdateTrialPoint(int point) { }

	// RVA: 0x218B72C Offset: 0x218772C VA: 0x218B72C
	public void SetDifficulty(int diff, int diffNum) { }

	// RVA: 0x218B738 Offset: 0x2187738 VA: 0x218B738
	public bool CheckRankingData() { }

	// RVA: 0x218B80C Offset: 0x218780C VA: 0x218B80C
	public void GetNowRanking(DefenceRankingData[] data) { }

	// RVA: 0x218B878 Offset: 0x2187878 VA: 0x218B878
	public void NextRankType() { }

	// RVA: 0x218B890 Offset: 0x2187890 VA: 0x218B890
	public void ResetRankType() { }

	// RVA: 0x218B89C Offset: 0x218789C VA: 0x218B89C
	public void GetRankScore(byte rankType, int point, long time) { }

	// RVA: 0x218B928 Offset: 0x2187928 VA: 0x218B928
	public void GetRankingResult(byte currentRank, byte oldRank, DefenceRankingData data, bool receiveReward, RewardData reward) { }

	// RVA: 0x218B97C Offset: 0x218797C VA: 0x218B97C
	public void GetRankingReward(byte currentRank, byte oldRank, DefenceRankingData data) { }

	[CompilerGenerated]
	// RVA: 0x218B9A0 Offset: 0x21879A0 VA: 0x218B9A0
	private void <Update>b__122_0() { }

	[CompilerGenerated]
	// RVA: 0x218B9A8 Offset: 0x21879A8 VA: 0x218B9A8
	private void <Update>b__122_1() { }

	[CompilerGenerated]
	// RVA: 0x218B9B0 Offset: 0x21879B0 VA: 0x218B9B0
	private void <End>b__141_0() { }
}

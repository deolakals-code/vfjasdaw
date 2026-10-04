// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ScoreAttackRoomData : RoomDataBase // TypeDefIndex: 2469
{
	// Fields
	[CompilerGenerated]
	private int <DifficultyState>k__BackingField; // 0x64
	[CompilerGenerated]
	private int[] <ResultPoints>k__BackingField; // 0x68
	[CompilerGenerated]
	private BossSymbolData <BossSymbolData>k__BackingField; // 0x70
	[CompilerGenerated]
	private ScoreAttackResultData <ResultData>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <IsRetire>k__BackingField; // 0x80
	private long leftTime; // 0x88
	private float updateTime; // 0x90
	private byte currentRotationId; // 0x94
	private TimeSpan currentRotationLeftTime; // 0x98
	private ScoreAttackRotationData[] rotationDatas; // 0xA0
	private bool isEndBattleEvent; // 0xA8
	private readonly int endScriptId; // 0xAC
	private ScoreAttackRewardData[] rewardDatas; // 0xB0
	private ScoreAttackRankUpData[] rankUpDatas; // 0xB8
	private int rankUpTotalPoint; // 0xC0
	private byte registFailedType; // 0xC4
	private List<byte> newRecordList; // 0xC8
	private float waitFrame; // 0xD0

	// Properties
	public override byte RoomType { get; }
	public override short AreaLevel { get; }
	public override short MobDifficultyLevel { get; }
	public int DifficultyState { get; set; }
	public int[] ResultPoints { get; set; }
	public BossSymbolData BossSymbolData { get; set; }
	public ScoreAttackResultData ResultData { get; set; }
	public bool IsRetire { get; set; }
	public byte CurrentRotationId { get; }
	public TimeSpan CurrentRotationLeftTime { get; }
	public ScoreAttackRotationData[] RotationDatas { get; }
	public float LeftTime { get; }
	public ScoreAttackRewardData[] RewardDatas { get; }
	public ScoreAttackRankUpData[] RankUpDatas { get; }
	public int RankUpTotalPoint { get; }
	public byte RegistFailedType { get; }
	public byte[] NewRecordList { get; }

	// Methods

	// RVA: 0x21BB1AC Offset: 0x21B71AC VA: 0x21BB1AC Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x21BB1B4 Offset: 0x21B71B4 VA: 0x21BB1B4 Slot: 7
	public override short get_AreaLevel() { }

	// RVA: 0x21BB1CC Offset: 0x21B71CC VA: 0x21BB1CC Slot: 8
	public override short get_MobDifficultyLevel() { }

	[CompilerGenerated]
	// RVA: 0x21BB1D4 Offset: 0x21B71D4 VA: 0x21BB1D4
	public int get_DifficultyState() { }

	[CompilerGenerated]
	// RVA: 0x21BB1DC Offset: 0x21B71DC VA: 0x21BB1DC
	private void set_DifficultyState(int value) { }

	[CompilerGenerated]
	// RVA: 0x21BB1E4 Offset: 0x21B71E4 VA: 0x21BB1E4
	public int[] get_ResultPoints() { }

	[CompilerGenerated]
	// RVA: 0x21BB1EC Offset: 0x21B71EC VA: 0x21BB1EC
	private void set_ResultPoints(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x21BB1F4 Offset: 0x21B71F4 VA: 0x21BB1F4
	public BossSymbolData get_BossSymbolData() { }

	[CompilerGenerated]
	// RVA: 0x21BB1FC Offset: 0x21B71FC VA: 0x21BB1FC
	private void set_BossSymbolData(BossSymbolData value) { }

	[CompilerGenerated]
	// RVA: 0x21BB204 Offset: 0x21B7204 VA: 0x21BB204
	public ScoreAttackResultData get_ResultData() { }

	[CompilerGenerated]
	// RVA: 0x21BB20C Offset: 0x21B720C VA: 0x21BB20C
	private void set_ResultData(ScoreAttackResultData value) { }

	[CompilerGenerated]
	// RVA: 0x21BB214 Offset: 0x21B7214 VA: 0x21BB214
	public bool get_IsRetire() { }

	[CompilerGenerated]
	// RVA: 0x21BB21C Offset: 0x21B721C VA: 0x21BB21C
	private void set_IsRetire(bool value) { }

	// RVA: 0x21BB228 Offset: 0x21B7228 VA: 0x21BB228
	public byte get_CurrentRotationId() { }

	// RVA: 0x21BB230 Offset: 0x21B7230 VA: 0x21BB230
	public TimeSpan get_CurrentRotationLeftTime() { }

	// RVA: 0x21BB238 Offset: 0x21B7238 VA: 0x21BB238
	public ScoreAttackRotationData[] get_RotationDatas() { }

	// RVA: 0x21BB280 Offset: 0x21B7280 VA: 0x21BB280
	public float get_LeftTime() { }

	// RVA: 0x21BB2C4 Offset: 0x21B72C4 VA: 0x21BB2C4
	public ScoreAttackRewardData[] get_RewardDatas() { }

	// RVA: 0x21BB2CC Offset: 0x21B72CC VA: 0x21BB2CC
	public ScoreAttackRankUpData[] get_RankUpDatas() { }

	// RVA: 0x21BB2D4 Offset: 0x21B72D4 VA: 0x21BB2D4
	public int get_RankUpTotalPoint() { }

	// RVA: 0x21BB2DC Offset: 0x21B72DC VA: 0x21BB2DC
	public byte get_RegistFailedType() { }

	// RVA: 0x21BB2E4 Offset: 0x21B72E4 VA: 0x21BB2E4
	public byte[] get_NewRecordList() { }

	// RVA: 0x21B8A84 Offset: 0x21B4A84 VA: 0x21B8A84
	public void .ctor() { }

	// RVA: 0x21BB33C Offset: 0x21B733C VA: 0x21BB33C Slot: 13
	public override void Enter() { }

	// RVA: 0x21BB3F8 Offset: 0x21B73F8 VA: 0x21BB3F8 Slot: 14
	public override void Leave() { }

	// RVA: 0x21BB448 Offset: 0x21B7448 VA: 0x21BB448 Slot: 15
	public override void Update() { }

	// RVA: 0x21BBC7C Offset: 0x21B7C7C VA: 0x21BBC7C Slot: 12
	public override void Clear() { }

	// RVA: 0x21BBCB4 Offset: 0x21B7CB4 VA: 0x21BBCB4 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21BBCB8 Offset: 0x21B7CB8 VA: 0x21BBCB8 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21BBD54 Offset: 0x21B7D54 VA: 0x21BBD54 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21BBD58 Offset: 0x21B7D58 VA: 0x21BBD58 Slot: 19
	public override void RoomSynchronization(RoomSynchronizationEvent syncEvent) { }

	// RVA: 0x21BBE50 Offset: 0x21B7E50 VA: 0x21BBE50
	public void CheckScoreAttackRoomOperation(bool isSolo, byte bossId, Action callBack, Action<string> errorCallBack, bool isIgnoreRotation = False) { }

	// RVA: 0x21BC060 Offset: 0x21B8060 VA: 0x21BC060
	public void SetRotationData(ScoreAttackGetRotationResponse response) { }

	// RVA: 0x21BC08C Offset: 0x21B808C VA: 0x21BC08C
	public void ReceiveResultData(ScoreAttackResultData resultData, bool isRetire, byte registFailedType, List<byte> newRecordList) { }

	// RVA: 0x21BB804 Offset: 0x21B7804 VA: 0x21BB804
	public void GameEnd(int scriptRetval) { }

	// RVA: 0x21BC0D8 Offset: 0x21B80D8 VA: 0x21BC0D8
	public void SetRewardInfo(ScoreAttackRewardData[] rewardDatas, ScoreAttackRankUpData[] rankUpDatas, int rankUpTotalPoint) { }
}

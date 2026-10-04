// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MiniGameRoomData : RoomDataBase // TypeDefIndex: 2388
{
	// Fields
	private int teamNo; // 0x64
	private int teamAHp; // 0x68
	private int teamBHp; // 0x6C
	private int maxHp; // 0x70
	private MiniGameMemberData[] teamMembarDataA; // 0x78
	private MiniGameMemberData[] teamMembarDataB; // 0x80
	private double leftStartUpTime; // 0x88
	private double leftEndTime; // 0x90
	private float oldTime; // 0x98
	private MiniGameStateType stateType; // 0x9C
	private MiniGameTeamResultData resultDataA; // 0xA0
	private MiniGameTeamResultData resultDataB; // 0xA8
	private byte victoryTeamNo; // 0xB0
	private MiniGameResultData resultData; // 0xB8
	private int playBGM; // 0xC0
	[CompilerGenerated]
	private bool <ItemPermission>k__BackingField; // 0xC4

	// Properties
	public override byte RoomType { get; }
	public MiniGameMemberData[] TeamMemberDataA { get; }
	public MiniGameMemberData[] TeamMemberDataB { get; }
	public MiniGameMemberData[] MyTeamMemberData { get; }
	public MiniGameMemberData[] EnemyTeamMemberData { get; }
	public int MyTeamHp { get; }
	public int EnemyTeamHp { get; }
	public int TeamMaxHp { get; }
	public double StartUpTime { get; }
	public double EndTime { get; }
	public MiniGameStateType StateType { get; }
	public MiniGameTeamResultData MyTeamResultData { get; }
	public MiniGameTeamResultData EnemyTeamResultData { get; }
	public bool IsVictory { get; }
	public bool IsDraw { get; }
	public MiniGameResultData ResultData { get; }
	public bool IsGameEnd { get; }
	public bool ItemPermission { get; set; }

	// Methods

	// RVA: 0x21A0160 Offset: 0x219C160 VA: 0x21A0160 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x21A0168 Offset: 0x219C168 VA: 0x21A0168
	public MiniGameMemberData[] get_TeamMemberDataA() { }

	// RVA: 0x21A0170 Offset: 0x219C170 VA: 0x21A0170
	public MiniGameMemberData[] get_TeamMemberDataB() { }

	// RVA: 0x21A0178 Offset: 0x219C178 VA: 0x21A0178
	public MiniGameMemberData[] get_MyTeamMemberData() { }

	// RVA: 0x21A0194 Offset: 0x219C194 VA: 0x21A0194
	public MiniGameMemberData[] get_EnemyTeamMemberData() { }

	// RVA: 0x21A01B0 Offset: 0x219C1B0 VA: 0x21A01B0
	public int get_MyTeamHp() { }

	// RVA: 0x21A01CC Offset: 0x219C1CC VA: 0x21A01CC
	public int get_EnemyTeamHp() { }

	// RVA: 0x21A01E8 Offset: 0x219C1E8 VA: 0x21A01E8
	public int get_TeamMaxHp() { }

	// RVA: 0x21A01F0 Offset: 0x219C1F0 VA: 0x21A01F0
	public double get_StartUpTime() { }

	// RVA: 0x21A01F8 Offset: 0x219C1F8 VA: 0x21A01F8
	public double get_EndTime() { }

	// RVA: 0x21A0200 Offset: 0x219C200 VA: 0x21A0200
	public MiniGameStateType get_StateType() { }

	// RVA: 0x21A0208 Offset: 0x219C208 VA: 0x21A0208
	public MiniGameTeamResultData get_MyTeamResultData() { }

	// RVA: 0x21A0224 Offset: 0x219C224 VA: 0x21A0224
	public MiniGameTeamResultData get_EnemyTeamResultData() { }

	// RVA: 0x21A0240 Offset: 0x219C240 VA: 0x21A0240
	public bool get_IsVictory() { }

	// RVA: 0x21A0254 Offset: 0x219C254 VA: 0x21A0254
	public bool get_IsDraw() { }

	// RVA: 0x21A0264 Offset: 0x219C264 VA: 0x21A0264
	public MiniGameResultData get_ResultData() { }

	// RVA: 0x21A026C Offset: 0x219C26C VA: 0x21A026C
	public bool get_IsGameEnd() { }

	[CompilerGenerated]
	// RVA: 0x21A027C Offset: 0x219C27C VA: 0x21A027C
	public bool get_ItemPermission() { }

	[CompilerGenerated]
	// RVA: 0x21A0284 Offset: 0x219C284 VA: 0x21A0284
	private void set_ItemPermission(bool value) { }

	// RVA: 0x21A0290 Offset: 0x219C290 VA: 0x21A0290
	public void .ctor() { }

	// RVA: 0x21A03B0 Offset: 0x219C3B0 VA: 0x21A03B0
	public void Destroy() { }

	// RVA: 0x21A0400 Offset: 0x219C400 VA: 0x21A0400
	public void Initialize(MiniGameJoinResponse response) { }

	// RVA: 0x21A0C84 Offset: 0x219CC84 VA: 0x21A0C84
	public void GameStart(MiniGameStartEvent eventData) { }

	// RVA: 0x21A0CD8 Offset: 0x219CCD8 VA: 0x21A0CD8
	public void GameEnd(MiniGameEndEvent eventData) { }

	// RVA: 0x21A0744 Offset: 0x219C744 VA: 0x21A0744
	public void UpdateMemberData(MiniGameTeamData teamA, MiniGameTeamData teamB, bool initialize) { }

	// RVA: 0x21A073C Offset: 0x219C73C VA: 0x21A073C
	public void UpdateTeamHp(int teamA, int teamB) { }

	// RVA: 0x21A0BDC Offset: 0x219CBDC VA: 0x21A0BDC
	public void ServerUpdateTimer(long leftStartUpTime, long leftEndTime) { }

	// RVA: 0x21A0E48 Offset: 0x219CE48 VA: 0x21A0E48
	public void UpdateTimer() { }

	// RVA: 0x21A0ED8 Offset: 0x219CED8 VA: 0x21A0ED8
	private void UpdateBGM() { }

	// RVA: 0x21A10A4 Offset: 0x219D0A4 VA: 0x21A10A4
	public void UpdateState(byte stateType) { }

	// RVA: 0x21A0C34 Offset: 0x219CC34 VA: 0x21A0C34
	public void UpdateResultData(MiniGameResultData data) { }

	// RVA: 0x21A0D48 Offset: 0x219CD48 VA: 0x21A0D48
	public bool IsMyTeam(int archetypeId) { }

	// RVA: 0x21A10B8 Offset: 0x219D0B8 VA: 0x21A10B8
	public SnowballFightManager.BattleArea AreaCheck(int archetypeId, Vector3 pos) { }

	// RVA: 0x21A1168 Offset: 0x219D168 VA: 0x21A1168
	public void LobbyReEnter() { }

	// RVA: 0x21A122C Offset: 0x219D22C VA: 0x21A122C Slot: 23
	public override NewArchetypeProperties UpdatePlayerProperty(NewArchetypeProperties property) { }

	// RVA: 0x21A1248 Offset: 0x219D248 VA: 0x21A1248 Slot: 12
	public override void Clear() { }

	// RVA: 0x21A124C Offset: 0x219D24C VA: 0x21A124C Slot: 13
	public override void Enter() { }

	// RVA: 0x21A1388 Offset: 0x219D388 VA: 0x21A1388 Slot: 14
	public override void Leave() { }

	// RVA: 0x21A1450 Offset: 0x219D450 VA: 0x21A1450 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21A1454 Offset: 0x219D454 VA: 0x21A1454 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21A1458 Offset: 0x219D458 VA: 0x21A1458 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21A145C Offset: 0x219D45C VA: 0x21A145C Slot: 15
	public override void Update() { }

	// RVA: 0x21A14F8 Offset: 0x219D4F8 VA: 0x21A14F8 Slot: 32
	public override bool InitCameraUpdate(CameraManager manager) { }

	// RVA: 0x21A1558 Offset: 0x219D558 VA: 0x21A1558 Slot: 22
	public override void OnGameRoomRejoin(IEnterAvatarPacket avatarData, GameReJoinResponse rejoin) { }

	[CompilerGenerated]
	// RVA: 0x21A15E4 Offset: 0x219D5E4 VA: 0x21A15E4
	private bool <Initialize>b__55_0(MiniGameMemberData x) { }

	[CompilerGenerated]
	// RVA: 0x21A1618 Offset: 0x219D618 VA: 0x21A1618
	private bool <Initialize>b__55_1(MiniGameMemberData x) { }
}

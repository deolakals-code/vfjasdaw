// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackKnightRoomData : RoomDataBase // TypeDefIndex: 2313
{
	// Fields
	public const int MaxStageNum = 4;
	public const int StartScriptId = 3;
	public const int BossBattleEndScriptId = 5;
	public const int DeadScriptId = 6;
	public const int LootBoxPrice = 100;
	public const int LootBoxGrayCristaPrice = 10000;
	public const int MaxEquipCost = 5;
	public const int MaxEquipCristaNum = 10;
	public const int MaxGold = 99999;
	public const int MaxReinforcePriceUp = 10;
	public const int BalftAxeModelId = 1022;
	public const int BlackKnightHouseItemId = 600074;
	private CameraManager cameraManager; // 0x68
	private BlackKnightManager action2DManager; // 0x70
	[CompilerGenerated]
	private byte <GameState>k__BackingField; // 0x78
	private BlackKnightSaveData[] saveDatas; // 0x80
	private int fieldLevel; // 0x88
	private byte selectedSaveId; // 0x8C
	private GameObject motion; // 0x90
	private int thisGameGold; // 0x98
	private List<BlackKnightRecordData> thisGameRecords; // 0xA0
	private byte nowStageId; // 0xA8
	private int playerHp; // 0xAC
	private byte prevGetCristaId; // 0xB0
	private byte prevAvatarType; // 0xB1
	private byte[] prevEquipData; // 0xB8
	private float timer; // 0xC0
	private bool isMoveTimer; // 0xC4
	private UIBlackKnightMainManager actionUIMainManager; // 0xC8
	private Camera viewportCamera; // 0xD0
	private bool isEndGame; // 0xD8
	private BlackKnightEndType prevEndType; // 0xDC
	private int[] reinforcePrice; // 0xE0
	private readonly Dictionary<int, int[]> reinforcePriceList; // 0xE8
	private int[] reinforceCounts; // 0xF0
	private BlackKnightRoomData.ResultType nowResultType; // 0xF8
	private BlackKnightRecordData prevRecordData; // 0x100
	private float nowStageStartTime; // 0x108
	private float nowStageEndTime; // 0x10C
	private int nowStageReinforceCount; // 0x110
	private int ownerGold; // 0x114
	[CompilerGenerated]
	private bool <IsEnterBossRoom>k__BackingField; // 0x118
	private BlackKnightBossManager bossManager; // 0x120
	private bool isHalfWay; // 0x128

	// Properties
	public byte GameState { get; set; }
	public bool IsEnterBossRoom { get; set; }
	public override string[] LoadAssetsPath { get; }
	public override byte RoomType { get; }
	public GuideRail PlayerGuide { get; }
	public BlackKnightPlayerManager PlayerManager { get; }
	public BlackKnightMobManagerBase NearMobManager { get; }
	public BlackKnightSaveData[] SaveDatas { get; }
	public BlackKnightSaveData SelectedSaveData { get; }
	public byte PrevGetCristaId { get; }
	public Camera ViewportCamera { get; }
	public int[] ReinforcePrice { get; }
	public BlackKnightRoomData.ResultType NowResultType { get; }
	public int ThisGameGold { get; }
	public List<BlackKnightRecordData> ThisGameRecords { get; }
	public int[] ReinforceCounts { get; }
	public bool IsOwner { get; }
	public int NowStageId { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x217EE40 Offset: 0x217AE40 VA: 0x217EE40
	public byte get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x217EE48 Offset: 0x217AE48 VA: 0x217EE48
	private void set_GameState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x217EE50 Offset: 0x217AE50 VA: 0x217EE50
	public bool get_IsEnterBossRoom() { }

	[CompilerGenerated]
	// RVA: 0x217EE58 Offset: 0x217AE58 VA: 0x217EE58
	private void set_IsEnterBossRoom(bool value) { }

	// RVA: 0x217EE64 Offset: 0x217AE64 VA: 0x217EE64 Slot: 5
	public override string[] get_LoadAssetsPath() { }

	// RVA: 0x217EF88 Offset: 0x217AF88 VA: 0x217EF88 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x217EF90 Offset: 0x217AF90 VA: 0x217EF90
	public GuideRail get_PlayerGuide() { }

	// RVA: 0x217EFA8 Offset: 0x217AFA8 VA: 0x217EFA8
	public BlackKnightPlayerManager get_PlayerManager() { }

	// RVA: 0x217EFC0 Offset: 0x217AFC0 VA: 0x217EFC0
	public BlackKnightMobManagerBase get_NearMobManager() { }

	// RVA: 0x217EFF0 Offset: 0x217AFF0 VA: 0x217EFF0
	public BlackKnightSaveData[] get_SaveDatas() { }

	// RVA: 0x217EFF8 Offset: 0x217AFF8 VA: 0x217EFF8
	public BlackKnightSaveData get_SelectedSaveData() { }

	// RVA: 0x217F0A8 Offset: 0x217B0A8 VA: 0x217F0A8
	public byte get_PrevGetCristaId() { }

	// RVA: 0x217F0B0 Offset: 0x217B0B0 VA: 0x217F0B0
	public Camera get_ViewportCamera() { }

	// RVA: 0x217F0B8 Offset: 0x217B0B8 VA: 0x217F0B8
	public int[] get_ReinforcePrice() { }

	// RVA: 0x217F274 Offset: 0x217B274 VA: 0x217F274
	public BlackKnightRoomData.ResultType get_NowResultType() { }

	// RVA: 0x217F27C Offset: 0x217B27C VA: 0x217F27C
	public int get_ThisGameGold() { }

	// RVA: 0x217F284 Offset: 0x217B284 VA: 0x217F284
	public List<BlackKnightRecordData> get_ThisGameRecords() { }

	// RVA: 0x217F28C Offset: 0x217B28C VA: 0x217F28C
	public int[] get_ReinforceCounts() { }

	// RVA: 0x217F294 Offset: 0x217B294 VA: 0x217F294
	public bool get_IsOwner() { }

	// RVA: 0x217F310 Offset: 0x217B310 VA: 0x217F310
	public int get_NowStageId() { }

	// RVA: 0x217F318 Offset: 0x217B318 VA: 0x217F318
	public void .ctor() { }

	// RVA: 0x217F698 Offset: 0x217B698 VA: 0x217F698 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x217F774 Offset: 0x217B774 VA: 0x217F774 Slot: 15
	public override void Update() { }

	// RVA: 0x217F978 Offset: 0x217B978 VA: 0x217F978
	public float GetMoveSpeed(float defaultSpeed) { }

	// RVA: 0x217F980 Offset: 0x217B980 VA: 0x217F980
	public void SetRoomId(byte roomId) { }

	// RVA: 0x217F990 Offset: 0x217B990 VA: 0x217F990 Slot: 35
	public override bool PlayerInputMoveCheck() { }

	// RVA: 0x217F998 Offset: 0x217B998 VA: 0x217F998 Slot: 36
	public override bool FieldScriptRoomEndCommand() { }

	// RVA: 0x217FB6C Offset: 0x217BB6C VA: 0x217FB6C
	public void ReceiveJoinSaveData(BlackKnightSaveData[] saves) { }

	// RVA: 0x217FB74 Offset: 0x217BB74 VA: 0x217FB74
	public void SelectSaveData(byte saveId) { }

	// RVA: 0x217FBDC Offset: 0x217BBDC VA: 0x217FBDC
	public bool LoadSaveData() { }

	// RVA: 0x217FC64 Offset: 0x217BC64 VA: 0x217FC64
	public void DeleteSaveData() { }

	// RVA: 0x217FCB4 Offset: 0x217BCB4 VA: 0x217FCB4
	public void ChangeAvatar(byte type) { }

	// RVA: 0x217FD1C Offset: 0x217BD1C VA: 0x217FD1C
	public void ChangeEquip(byte[] equip) { }

	// RVA: 0x217FD90 Offset: 0x217BD90 VA: 0x217FD90
	public void SetViewportCamera(Camera viewportCamera) { }

	// RVA: 0x217FD98 Offset: 0x217BD98 VA: 0x217FD98
	public void ReceiveStartGame() { }

	// RVA: 0x217FF4C Offset: 0x217BF4C VA: 0x217FF4C
	public void ReceiveNextStage() { }

	// RVA: 0x217FF68 Offset: 0x217BF68 VA: 0x217FF68
	public void ReceiveEndGame() { }

	// RVA: 0x21801E8 Offset: 0x217C1E8 VA: 0x21801E8
	public void ReceiveLootBox(byte cristaId) { }

	// RVA: 0x2180258 Offset: 0x217C258 VA: 0x2180258
	public void ReceiveDeleteSaveData() { }

	// RVA: 0x218034C Offset: 0x217C34C VA: 0x218034C
	public void ReceiveChangeEquip() { }

	// RVA: 0x2180374 Offset: 0x217C374 VA: 0x2180374
	public void ReceiveChangeAvatar() { }

	// RVA: 0x2180394 Offset: 0x217C394 VA: 0x2180394
	public void ReceiveUpdateRanking() { }

	[IteratorStateMachine(typeof(BlackKnightRoomData.<OnScriptEventCommand>d__108))]
	// RVA: 0x2180398 Offset: 0x217C398 VA: 0x2180398
	public IEnumerator OnScriptEventCommand(byte command, int[] data) { }

	// RVA: 0x218043C Offset: 0x217C43C VA: 0x218043C
	public bool Reinforce(BlackKnightRoomData.ReinforceType type) { }

	// RVA: 0x217F1A8 Offset: 0x217B1A8 VA: 0x217F1A8
	private int GetReinforcePrice(BlackKnightRoomData.ReinforceType type, int price) { }

	// RVA: 0x2180650 Offset: 0x217C650 VA: 0x2180650
	public void SelectStage(int nowStageScore) { }

	// RVA: 0x218072C Offset: 0x217C72C VA: 0x218072C
	public void GameEnd(byte endType, int totalScore) { }

	// RVA: 0x217F820 Offset: 0x217B820 VA: 0x217F820
	private void UpdateTimer() { }

	// RVA: 0x2180554 Offset: 0x217C554 VA: 0x2180554
	public void UpdateGold(int add) { }

	// RVA: 0x2180884 Offset: 0x217C884 VA: 0x2180884
	public int GetNowTimeScore() { }

	// RVA: 0x2180994 Offset: 0x217C994 VA: 0x2180994
	public int GetNowBattleScore() { }

	// RVA: 0x2180A64 Offset: 0x217CA64 VA: 0x2180A64
	public int GetNowAttackScore() { }

	// RVA: 0x2180B28 Offset: 0x217CB28 VA: 0x2180B28
	public int GetNowStageScore() { }

	// RVA: 0x2180BCC Offset: 0x217CBCC VA: 0x2180BCC
	public float GetBossHpPercent() { }

	// RVA: 0x2180E1C Offset: 0x217CE1C VA: 0x2180E1C
	public void SetHalfWay(bool isHalfWay) { }

	// RVA: 0x2180E28 Offset: 0x217CE28 VA: 0x2180E28 Slot: 12
	public override void Clear() { }

	// RVA: 0x2180EBC Offset: 0x217CEBC VA: 0x2180EBC Slot: 13
	public override void Enter() { }

	// RVA: 0x21811B0 Offset: 0x217D1B0 VA: 0x21811B0 Slot: 14
	public override void Leave() { }

	// RVA: 0x21813F8 Offset: 0x217D3F8 VA: 0x21813F8 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21813FC Offset: 0x217D3FC VA: 0x21813FC Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x2181400 Offset: 0x217D400 VA: 0x2181400 Slot: 28
	public override bool CheckTapPlayerRoom() { }

	// RVA: 0x2181408 Offset: 0x217D408 VA: 0x2181408 Slot: 21
	public override void OnGameEventLogin(GameEventLoginResponse login, short returnCode) { }

	// RVA: 0x218140C Offset: 0x217D40C VA: 0x218140C Slot: 29
	public override bool CheckVisibleOtherPlayerRoom(Archetype archetype) { }

	// RVA: 0x2181414 Offset: 0x217D414 VA: 0x2181414 Slot: 18
	public override bool OnDead() { }

	[CompilerGenerated]
	// RVA: 0x218141C Offset: 0x217D41C VA: 0x218141C
	private bool <get_SelectedSaveData>b__67_0(BlackKnightSaveData x) { }

	[CompilerGenerated]
	// RVA: 0x2181440 Offset: 0x217D440 VA: 0x2181440
	private bool <SelectStage>b__111_0(BlackKnightRecordData x) { }
}

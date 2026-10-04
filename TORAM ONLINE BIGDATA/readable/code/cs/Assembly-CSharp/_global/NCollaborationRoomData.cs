// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NCollaborationRoomData : RoomDataBase // TypeDefIndex: 2423
{
	// Fields
	private BossSymbolData bossSymbolData; // 0x68
	private BossResultData bossResultData; // 0x70
	private ItemTextManager itemTextManager; // 0x78
	private MonsterDropDetailData[] monsterDropDetailDatas; // 0x80
	[CompilerGenerated]
	private int <DifficultyState>k__BackingField; // 0x88
	[CompilerGenerated]
	private int[] <ResultPoints>k__BackingField; // 0x90
	[CompilerGenerated]
	private bool <IsUserMatchingSettingFlag>k__BackingField; // 0x98
	[CompilerGenerated]
	private byte <PointBoost>k__BackingField; // 0x99
	[CompilerGenerated]
	private int <BossCheckConnect>k__BackingField; // 0x9C
	public const int MaxPointBoost = 10;
	[CompilerGenerated]
	private ExchangePointGetEvent <PointEventData>k__BackingField; // 0xA0

	// Properties
	public override byte RoomType { get; }
	public BossSymbolData BossSymbolData { get; }
	public BossResultData BossResultData { get; }
	public override short AreaLevel { get; }
	public int DifficultyState { get; set; }
	public int[] ResultPoints { get; set; }
	public bool IsBattle { get; }
	public List<MonsterDropDetailData> MonsterDropDetailDatas { get; }
	public bool IsUserMatchingSettingFlag { get; set; }
	public byte PointBoost { get; set; }
	public int BossCheckConnect { get; set; }
	public ExchangePointGetEvent PointEventData { get; set; }

	// Methods

	// RVA: 0x21ABFBC Offset: 0x21A7FBC VA: 0x21ABFBC Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x21ABFC4 Offset: 0x21A7FC4 VA: 0x21ABFC4
	public BossSymbolData get_BossSymbolData() { }

	// RVA: 0x21ABFCC Offset: 0x21A7FCC VA: 0x21ABFCC
	public BossResultData get_BossResultData() { }

	// RVA: 0x21ABFD4 Offset: 0x21A7FD4 VA: 0x21ABFD4 Slot: 7
	public override short get_AreaLevel() { }

	[CompilerGenerated]
	// RVA: 0x21ABFEC Offset: 0x21A7FEC VA: 0x21ABFEC
	public int get_DifficultyState() { }

	[CompilerGenerated]
	// RVA: 0x21ABFF4 Offset: 0x21A7FF4 VA: 0x21ABFF4
	private void set_DifficultyState(int value) { }

	[CompilerGenerated]
	// RVA: 0x21ABFFC Offset: 0x21A7FFC VA: 0x21ABFFC
	public int[] get_ResultPoints() { }

	[CompilerGenerated]
	// RVA: 0x21AC004 Offset: 0x21A8004 VA: 0x21AC004
	private void set_ResultPoints(int[] value) { }

	// RVA: 0x21AC00C Offset: 0x21A800C VA: 0x21AC00C
	public bool get_IsBattle() { }

	// RVA: 0x21AC020 Offset: 0x21A8020 VA: 0x21AC020
	public List<MonsterDropDetailData> get_MonsterDropDetailDatas() { }

	[CompilerGenerated]
	// RVA: 0x21AC078 Offset: 0x21A8078 VA: 0x21AC078
	private void set_IsUserMatchingSettingFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21AC084 Offset: 0x21A8084 VA: 0x21AC084
	public bool get_IsUserMatchingSettingFlag() { }

	[CompilerGenerated]
	// RVA: 0x21AC08C Offset: 0x21A808C VA: 0x21AC08C
	public byte get_PointBoost() { }

	[CompilerGenerated]
	// RVA: 0x21AC094 Offset: 0x21A8094 VA: 0x21AC094
	private void set_PointBoost(byte value) { }

	[CompilerGenerated]
	// RVA: 0x21AC09C Offset: 0x21A809C VA: 0x21AC09C
	public int get_BossCheckConnect() { }

	[CompilerGenerated]
	// RVA: 0x21AC0A4 Offset: 0x21A80A4 VA: 0x21AC0A4
	private void set_BossCheckConnect(int value) { }

	[CompilerGenerated]
	// RVA: 0x21AC0AC Offset: 0x21A80AC VA: 0x21AC0AC
	public ExchangePointGetEvent get_PointEventData() { }

	[CompilerGenerated]
	// RVA: 0x21AC0B4 Offset: 0x21A80B4 VA: 0x21AC0B4
	private void set_PointEventData(ExchangePointGetEvent value) { }

	// RVA: 0x21AC0BC Offset: 0x21A80BC VA: 0x21AC0BC
	public void .ctor() { }

	// RVA: 0x21AC28C Offset: 0x21A828C VA: 0x21AC28C Slot: 12
	public override void Clear() { }

	// RVA: 0x21AC2CC Offset: 0x21A82CC VA: 0x21AC2CC Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21AC2D0 Offset: 0x21A82D0 VA: 0x21AC2D0 Slot: 15
	public override void Update() { }

	// RVA: 0x21AC354 Offset: 0x21A8354 VA: 0x21AC354 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21AC3F0 Offset: 0x21A83F0 VA: 0x21AC3F0 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21AC408 Offset: 0x21A8408 VA: 0x21AC408 Slot: 11
	public override void OnFailure(byte operationCode, byte subCode, short returnCode) { }

	// RVA: 0x21AC4A8 Offset: 0x21A84A8 VA: 0x21AC4A8 Slot: 13
	public override void Enter() { }

	// RVA: 0x21AC548 Offset: 0x21A8548 VA: 0x21AC548 Slot: 14
	public override void Leave() { }

	// RVA: 0x21AC5D0 Offset: 0x21A85D0 VA: 0x21AC5D0
	public void CheckRoom(int fieldId, byte roomId, byte flag) { }

	// RVA: 0x21AC6D0 Offset: 0x21A86D0 VA: 0x21AC6D0
	public void ReceiveBossResultData(BossResultData data, int[] points) { }

	// RVA: 0x21ACA98 Offset: 0x21A8A98 VA: 0x21ACA98
	public void ReceivePointGetEvent(ExchangePointGetEvent eventData) { }

	// RVA: 0x21ACAA0 Offset: 0x21A8AA0 VA: 0x21ACAA0
	public bool CheckEnterAreaLevel(int level) { }

	// RVA: 0x21ACAD8 Offset: 0x21A8AD8 VA: 0x21ACAD8
	public void DifficultyReset() { }

	// RVA: 0x21ACAE0 Offset: 0x21A8AE0 VA: 0x21ACAE0
	public void SetDifficultyState(int state) { }

	// RVA: 0x21ACAE8 Offset: 0x21A8AE8 VA: 0x21ACAE8
	public void UpdateUserMatchingFlag(bool isFlag) { }
}

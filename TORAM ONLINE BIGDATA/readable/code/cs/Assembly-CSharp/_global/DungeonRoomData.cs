// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DungeonRoomData : RoomDataBase // TypeDefIndex: 2338
{
	// Fields
	private Dictionary<byte, DungeonRoomData.DungeonTrapEventData> trapManager; // 0x68
	[CompilerGenerated]
	private bool <EnterLock>k__BackingField; // 0x70
	[CompilerGenerated]
	private int <AvatarLevel>k__BackingField; // 0x74
	[CompilerGenerated]
	private int <AreaDay>k__BackingField; // 0x78
	[CompilerGenerated]
	private int <AreaLevel>k__BackingField; // 0x7C
	[CompilerGenerated]
	private int <StartAreaLevel>k__BackingField; // 0x80
	[CompilerGenerated]
	private int <GuildAreaLevel>k__BackingField; // 0x84
	[CompilerGenerated]
	private int <LeaderAreaLevel>k__BackingField; // 0x88
	[CompilerGenerated]
	private bool <IsRoomLeader>k__BackingField; // 0x8C
	private short eventPopRate; // 0x8E
	[CompilerGenerated]
	private DungeonFloorEventType <DungeonFloorEventType>k__BackingField; // 0x90
	[CompilerGenerated]
	private short <MaxMagicGauge>k__BackingField; // 0x94
	[CompilerGenerated]
	private TimeSpan <RemainingTime>k__BackingField; // 0x98
	[CompilerGenerated]
	private Vector3 <StartPosition>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Vector3 <GoalPosition>k__BackingField; // 0xAC
	private bool checkDungeonDataConnect; // 0xB8
	private bool isEnterField; // 0xB9
	private TakeController controller; // 0xC0
	private bool reConnectCheck; // 0xC8
	private GameObject treasureRoom; // 0xD0
	private Dictionary<int, int> takeHitIncludeManager; // 0xD8

	// Properties
	public bool EnterLock { get; set; }
	public int AvatarLevel { get; set; }
	public int AreaDay { get; set; }
	public int AreaLevel { get; set; }
	public int StartAreaLevel { get; set; }
	public int GuildAreaLevel { get; set; }
	public int LeaderAreaLevel { get; set; }
	public bool IsRoomLeader { get; set; }
	public short EventPopRate { get; }
	public DungeonFloorEventType DungeonFloorEventType { get; set; }
	public short MaxMagicGauge { get; set; }
	public TimeSpan RemainingTime { get; set; }
	public Vector3 StartPosition { get; set; }
	public Vector3 GoalPosition { get; set; }
	public bool CheckDungeonDataConnect { get; }
	private TakeController takeController { get; }
	public override string[] LoadAssetsPath { get; }
	public bool IsHoldTreasureRoom { get; }
	public override byte RoomType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x218BA74 Offset: 0x2187A74 VA: 0x218BA74
	private void set_EnterLock(bool value) { }

	[CompilerGenerated]
	// RVA: 0x218BA80 Offset: 0x2187A80 VA: 0x218BA80
	public bool get_EnterLock() { }

	[CompilerGenerated]
	// RVA: 0x218BA88 Offset: 0x2187A88 VA: 0x218BA88
	private void set_AvatarLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x218BA90 Offset: 0x2187A90 VA: 0x218BA90
	public int get_AvatarLevel() { }

	[CompilerGenerated]
	// RVA: 0x218BA98 Offset: 0x2187A98 VA: 0x218BA98
	private void set_AreaDay(int value) { }

	[CompilerGenerated]
	// RVA: 0x218BAA0 Offset: 0x2187AA0 VA: 0x218BAA0
	public int get_AreaDay() { }

	[CompilerGenerated]
	// RVA: 0x218BAA8 Offset: 0x2187AA8 VA: 0x218BAA8
	private void set_AreaLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x218BAB0 Offset: 0x2187AB0 VA: 0x218BAB0
	public int get_AreaLevel() { }

	[CompilerGenerated]
	// RVA: 0x218BAB8 Offset: 0x2187AB8 VA: 0x218BAB8
	private void set_StartAreaLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x218BAC0 Offset: 0x2187AC0 VA: 0x218BAC0
	public int get_StartAreaLevel() { }

	[CompilerGenerated]
	// RVA: 0x218BAC8 Offset: 0x2187AC8 VA: 0x218BAC8
	private void set_GuildAreaLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x218BAD0 Offset: 0x2187AD0 VA: 0x218BAD0
	public int get_GuildAreaLevel() { }

	[CompilerGenerated]
	// RVA: 0x218BAD8 Offset: 0x2187AD8 VA: 0x218BAD8
	private void set_LeaderAreaLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x218BAE0 Offset: 0x2187AE0 VA: 0x218BAE0
	public int get_LeaderAreaLevel() { }

	[CompilerGenerated]
	// RVA: 0x218BAE8 Offset: 0x2187AE8 VA: 0x218BAE8
	private void set_IsRoomLeader(bool value) { }

	[CompilerGenerated]
	// RVA: 0x218BAF4 Offset: 0x2187AF4 VA: 0x218BAF4
	public bool get_IsRoomLeader() { }

	// RVA: 0x218BAFC Offset: 0x2187AFC VA: 0x218BAFC
	public short get_EventPopRate() { }

	[CompilerGenerated]
	// RVA: 0x218BB14 Offset: 0x2187B14 VA: 0x218BB14
	private void set_DungeonFloorEventType(DungeonFloorEventType value) { }

	[CompilerGenerated]
	// RVA: 0x218BB1C Offset: 0x2187B1C VA: 0x218BB1C
	public DungeonFloorEventType get_DungeonFloorEventType() { }

	[CompilerGenerated]
	// RVA: 0x218BB24 Offset: 0x2187B24 VA: 0x218BB24
	private void set_MaxMagicGauge(short value) { }

	[CompilerGenerated]
	// RVA: 0x218BB2C Offset: 0x2187B2C VA: 0x218BB2C
	public short get_MaxMagicGauge() { }

	[CompilerGenerated]
	// RVA: 0x218BB34 Offset: 0x2187B34 VA: 0x218BB34
	private void set_RemainingTime(TimeSpan value) { }

	[CompilerGenerated]
	// RVA: 0x218BB3C Offset: 0x2187B3C VA: 0x218BB3C
	public TimeSpan get_RemainingTime() { }

	[CompilerGenerated]
	// RVA: 0x218BB44 Offset: 0x2187B44 VA: 0x218BB44
	private void set_StartPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x218BB50 Offset: 0x2187B50 VA: 0x218BB50
	public Vector3 get_StartPosition() { }

	[CompilerGenerated]
	// RVA: 0x218BB5C Offset: 0x2187B5C VA: 0x218BB5C
	private void set_GoalPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x218BB68 Offset: 0x2187B68 VA: 0x218BB68
	public Vector3 get_GoalPosition() { }

	// RVA: 0x218BB74 Offset: 0x2187B74 VA: 0x218BB74
	public bool get_CheckDungeonDataConnect() { }

	// RVA: 0x218BB7C Offset: 0x2187B7C VA: 0x218BB7C
	private TakeController get_takeController() { }

	// RVA: 0x218BC1C Offset: 0x2187C1C VA: 0x218BC1C Slot: 5
	public override string[] get_LoadAssetsPath() { }

	// RVA: 0x218BCE8 Offset: 0x2187CE8 VA: 0x218BCE8
	public bool get_IsHoldTreasureRoom() { }

	// RVA: 0x218BD48 Offset: 0x2187D48 VA: 0x218BD48 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x218BD50 Offset: 0x2187D50 VA: 0x218BD50
	public void .ctor() { }

	// RVA: 0x218BE64 Offset: 0x2187E64 VA: 0x218BE64 Slot: 12
	public override void Clear() { }

	// RVA: 0x218C030 Offset: 0x2188030 VA: 0x218C030 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x218C148 Offset: 0x2188148 VA: 0x218C148 Slot: 15
	public override void Update() { }

	// RVA: 0x218C31C Offset: 0x218831C VA: 0x218C31C Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x218C4D4 Offset: 0x21884D4 VA: 0x218C4D4 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x218C4D8 Offset: 0x21884D8 VA: 0x218C4D8 Slot: 20
	public override void EnterRoomConnection() { }

	// RVA: 0x218C4DC Offset: 0x21884DC VA: 0x218C4DC Slot: 13
	public override void Enter() { }

	// RVA: 0x218C680 Offset: 0x2188680 VA: 0x218C680 Slot: 14
	public override void Leave() { }

	// RVA: 0x218C7FC Offset: 0x21887FC VA: 0x218C7FC
	public void EnterLocked() { }

	// RVA: 0x218C808 Offset: 0x2188808 VA: 0x218C808
	public bool CheckDungeonRoomConnect() { }

	// RVA: 0x218C824 Offset: 0x2188824 VA: 0x218C824
	public void ReceiveCheckDungeonRoom(short lastAreaLevel, short guildAreaLevel, short maxMagicGauge, TimeSpan remainingTime) { }

	// RVA: 0x218C850 Offset: 0x2188850 VA: 0x218C850
	public void UpdateAreaData(int areaLevel, byte areaDay, DungeonFloorEventType floorEventType, bool enterField) { }

	// RVA: 0x218C868 Offset: 0x2188868 VA: 0x218C868
	public void UpdateEventPosition(Vector3 startPos, Vector3 goalPos) { }

	// RVA: 0x218C7C8 Offset: 0x21887C8 VA: 0x218C7C8
	public void UpdateRoomAvatarData(short avatarLevel, bool roomLeader, byte rate) { }

	// RVA: 0x218C9D8 Offset: 0x21889D8 VA: 0x218C9D8
	public bool CheckEnterAreaLevel(int level) { }

	// RVA: 0x218CA14 Offset: 0x2188A14 VA: 0x218CA14
	public void ReceiveCheckEnterAreaLevel(int level) { }

	// RVA: 0x218CA30 Offset: 0x2188A30 VA: 0x218CA30
	public void PlayerDead() { }

	// RVA: 0x218CCC8 Offset: 0x2188CC8 VA: 0x218CCC8
	public byte CheckDungeonDownstairs() { }

	// RVA: 0x218CFBC Offset: 0x2188FBC VA: 0x218CFBC
	public GameObject ChangeFieldModel() { }

	// RVA: 0x218D040 Offset: 0x2189040 VA: 0x218D040
	public bool AddTrapEvent(byte id, byte type, Vector3 position) { }

	// RVA: 0x218D2FC Offset: 0x21892FC VA: 0x218D2FC
	public bool TryGetTrapData(byte id, out DungeonRoomData.DungeonTrapEventData trap) { }

	// RVA: 0x218D364 Offset: 0x2189364 VA: 0x218D364
	public bool ActiveTrap(byte senderType, int senderId, byte id) { }

	// RVA: 0x218D87C Offset: 0x218987C VA: 0x218D87C
	public bool TrapData(DungeonTrapData dungeonTrapData, bool self) { }

	// RVA: 0x218D6A4 Offset: 0x21896A4 VA: 0x218D6A4
	private void TrapEffect(DungeonRoomData.DungeonTrapEventData trapData) { }

	// RVA: 0x218DA68 Offset: 0x2189A68 VA: 0x218DA68
	public short GetNaerTrap(Vector3 position, float dist, out Vector3 trapPosition) { }

	// RVA: 0x218DD34 Offset: 0x2189D34 VA: 0x218DD34
	public void TrapTakeEvent(int takePlayerUid, TakeEventType eventType, int param) { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HighRaidRoomData : RoomDataBase // TypeDefIndex: 2351
{
	// Fields
	private const byte TodayAddCountMax = 5;
	private const byte ChallengePointMax = 30;
	[CompilerGenerated]
	private byte <ChallengePoint>k__BackingField; // 0x64
	[CompilerGenerated]
	private byte <ChallengeCount>k__BackingField; // 0x65
	[CompilerGenerated]
	private BossSymbolData <BossSymbolData>k__BackingField; // 0x68
	[CompilerGenerated]
	private HighRaidMonsterDropDetailData[] <DetailDatas>k__BackingField; // 0x70
	[CompilerGenerated]
	private BossResultData <BossResultData>k__BackingField; // 0x78
	[CompilerGenerated]
	private int <DifficultyState>k__BackingField; // 0x80
	[CompilerGenerated]
	private int[] <ResultPoints>k__BackingField; // 0x88
	private Dictionary<string, List<int>> gemList; // 0x90
	private Dictionary<int, List<int>> gemEffectList; // 0x98
	private float gemTimer; // 0xA0
	private ItemTextManager itemTextManager; // 0xA8
	private int[] targetMobUniqueIdList; // 0xB0

	// Properties
	public override byte RoomType { get; }
	public override short AreaLevel { get; }
	public override short MobDifficultyLevel { get; }
	public byte ChallengePoint { get; set; }
	public byte ChallengeCount { get; set; }
	public bool IsAddEnable { get; }
	public BossSymbolData BossSymbolData { get; set; }
	public HighRaidMonsterDropDetailData[] DetailDatas { get; set; }
	public BossResultData BossResultData { get; set; }
	public int DifficultyState { get; set; }
	public int[] ResultPoints { get; set; }

	// Methods

	// RVA: 0x2194638 Offset: 0x2190638 VA: 0x2194638 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x2194640 Offset: 0x2190640 VA: 0x2194640 Slot: 7
	public override short get_AreaLevel() { }

	// RVA: 0x2194658 Offset: 0x2190658 VA: 0x2194658 Slot: 8
	public override short get_MobDifficultyLevel() { }

	[CompilerGenerated]
	// RVA: 0x2194660 Offset: 0x2190660 VA: 0x2194660
	public byte get_ChallengePoint() { }

	[CompilerGenerated]
	// RVA: 0x2194668 Offset: 0x2190668 VA: 0x2194668
	private void set_ChallengePoint(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2194670 Offset: 0x2190670 VA: 0x2194670
	public byte get_ChallengeCount() { }

	[CompilerGenerated]
	// RVA: 0x2194678 Offset: 0x2190678 VA: 0x2194678
	private void set_ChallengeCount(byte value) { }

	// RVA: 0x2194680 Offset: 0x2190680 VA: 0x2194680
	public bool get_IsAddEnable() { }

	[CompilerGenerated]
	// RVA: 0x21946A4 Offset: 0x21906A4 VA: 0x21946A4
	public BossSymbolData get_BossSymbolData() { }

	[CompilerGenerated]
	// RVA: 0x21946AC Offset: 0x21906AC VA: 0x21946AC
	private void set_BossSymbolData(BossSymbolData value) { }

	[CompilerGenerated]
	// RVA: 0x21946B4 Offset: 0x21906B4 VA: 0x21946B4
	public HighRaidMonsterDropDetailData[] get_DetailDatas() { }

	[CompilerGenerated]
	// RVA: 0x21946BC Offset: 0x21906BC VA: 0x21946BC
	private void set_DetailDatas(HighRaidMonsterDropDetailData[] value) { }

	[CompilerGenerated]
	// RVA: 0x21946C4 Offset: 0x21906C4 VA: 0x21946C4
	public BossResultData get_BossResultData() { }

	[CompilerGenerated]
	// RVA: 0x21946CC Offset: 0x21906CC VA: 0x21946CC
	private void set_BossResultData(BossResultData value) { }

	[CompilerGenerated]
	// RVA: 0x21946D4 Offset: 0x21906D4 VA: 0x21946D4
	public int get_DifficultyState() { }

	[CompilerGenerated]
	// RVA: 0x21946DC Offset: 0x21906DC VA: 0x21946DC
	public void set_DifficultyState(int value) { }

	[CompilerGenerated]
	// RVA: 0x21946E4 Offset: 0x21906E4 VA: 0x21946E4
	public int[] get_ResultPoints() { }

	[CompilerGenerated]
	// RVA: 0x21946EC Offset: 0x21906EC VA: 0x21946EC
	private void set_ResultPoints(int[] value) { }

	// RVA: 0x21946F4 Offset: 0x21906F4 VA: 0x21946F4
	public void .ctor() { }

	// RVA: 0x21947E8 Offset: 0x21907E8 VA: 0x21947E8 Slot: 13
	public override void Enter() { }

	// RVA: 0x2194874 Offset: 0x2190874 VA: 0x2194874 Slot: 14
	public override void Leave() { }

	// RVA: 0x2194900 Offset: 0x2190900 VA: 0x2194900 Slot: 15
	public override void Update() { }

	// RVA: 0x2194E78 Offset: 0x2190E78 VA: 0x2194E78 Slot: 12
	public override void Clear() { }

	// RVA: 0x2194F40 Offset: 0x2190F40 VA: 0x2194F40 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x2194F44 Offset: 0x2190F44 VA: 0x2194F44 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x2194FE4 Offset: 0x2190FE4 VA: 0x2194FE4 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x2194FE8 Offset: 0x2190FE8 VA: 0x2194FE8
	public void ReceiveCheckRoom(CheckHighRaidRoomResponse response) { }

	// RVA: 0x2195024 Offset: 0x2191024 VA: 0x2195024
	public void ReceiveBossResultData(BossResultData data, int[] points) { }

	// RVA: 0x21953C8 Offset: 0x21913C8 VA: 0x21953C8
	public bool CheckRaid() { }

	// RVA: 0x21953D0 Offset: 0x21913D0 VA: 0x21953D0
	public void AddUseGemList(string avatarName, int avatarUuid, int itemId) { }

	// RVA: 0x21957F4 Offset: 0x21917F4 VA: 0x21957F4
	public void SetTargetMobUniqueIdList(int[] targetList) { }

	// RVA: 0x21957FC Offset: 0x21917FC VA: 0x21957FC
	public bool CheckSubjugationTarget(int mobUniqueId) { }
}

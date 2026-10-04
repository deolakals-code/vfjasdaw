// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BossRoomData : RoomDataBase // TypeDefIndex: 2317
{
	// Fields
	private BossSymbolData bossSymbolData; // 0x68
	private BossResultData bossResultData; // 0x70
	private Dictionary<string, List<int>> gemList; // 0x78
	private Dictionary<int, List<int>> gemEffectList; // 0x80
	private float gemTimer; // 0x88
	private ItemTextManager itemTextManager; // 0x90
	private MonsterDropDetailData[] monsterDropDetailDatas; // 0x98
	private int[] targetMobUniqueIdList; // 0xA0
	[CompilerGenerated]
	private int <BossCheckConnect>k__BackingField; // 0xA8
	[CompilerGenerated]
	private int <DifficultyState>k__BackingField; // 0xAC

	// Properties
	public int BossCheckConnect { get; set; }
	public override byte RoomType { get; }
	public BossSymbolData BossSymbolData { get; }
	public BossResultData BossResultData { get; }
	public override short AreaLevel { get; }
	public int DifficultyState { get; set; }
	public bool IsBattle { get; }
	public List<MonsterDropDetailData> MonsterDropDetailDatas { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2183500 Offset: 0x217F500 VA: 0x2183500
	public int get_BossCheckConnect() { }

	[CompilerGenerated]
	// RVA: 0x2183508 Offset: 0x217F508 VA: 0x2183508
	private void set_BossCheckConnect(int value) { }

	// RVA: 0x2183510 Offset: 0x217F510 VA: 0x2183510 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x2183518 Offset: 0x217F518 VA: 0x2183518
	public BossSymbolData get_BossSymbolData() { }

	// RVA: 0x2183520 Offset: 0x217F520 VA: 0x2183520
	public BossResultData get_BossResultData() { }

	// RVA: 0x2183528 Offset: 0x217F528 VA: 0x2183528 Slot: 7
	public override short get_AreaLevel() { }

	[CompilerGenerated]
	// RVA: 0x2183540 Offset: 0x217F540 VA: 0x2183540
	public int get_DifficultyState() { }

	[CompilerGenerated]
	// RVA: 0x2183548 Offset: 0x217F548 VA: 0x2183548
	public void set_DifficultyState(int value) { }

	// RVA: 0x2183550 Offset: 0x217F550 VA: 0x2183550
	public bool get_IsBattle() { }

	// RVA: 0x2183564 Offset: 0x217F564 VA: 0x2183564
	public List<MonsterDropDetailData> get_MonsterDropDetailDatas() { }

	// RVA: 0x21835BC Offset: 0x217F5BC VA: 0x21835BC
	public void .ctor() { }

	// RVA: 0x21836B0 Offset: 0x217F6B0 VA: 0x21836B0 Slot: 12
	public override void Clear() { }

	// RVA: 0x2183778 Offset: 0x217F778 VA: 0x2183778
	public void ReceiveBossSymbolData(BossSymbolData data) { }

	// RVA: 0x2183784 Offset: 0x217F784 VA: 0x2183784
	public void ReceiveMonsterDropDetailData(MonsterDropDetailData[] datas) { }

	// RVA: 0x218378C Offset: 0x217F78C VA: 0x218378C
	public void ReceiveBossResultData(BossResultData data) { }

	// RVA: 0x2183B44 Offset: 0x217FB44 VA: 0x2183B44
	public void AddUseGemList(string avatarName, int avatarUuid, int itemId) { }

	// RVA: 0x2183F68 Offset: 0x217FF68 VA: 0x2183F68
	public void SetTargetMobUniqueIdList(int[] targetList) { }

	// RVA: 0x2183F70 Offset: 0x217FF70 VA: 0x2183F70
	public bool CheckSubjugationTarget(int mobUniqueId) { }

	// RVA: 0x2183FD0 Offset: 0x217FFD0 VA: 0x2183FD0 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x2183FD4 Offset: 0x217FFD4 VA: 0x2183FD4 Slot: 15
	public override void Update() { }

	// RVA: 0x218454C Offset: 0x218054C VA: 0x218454C Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21845EC Offset: 0x21805EC VA: 0x21845EC Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x2184604 Offset: 0x2180604 VA: 0x2184604 Slot: 13
	public override void Enter() { }

	// RVA: 0x21846A4 Offset: 0x21806A4 VA: 0x21846A4 Slot: 14
	public override void Leave() { }

	// RVA: 0x2184730 Offset: 0x2180730 VA: 0x2184730 Slot: 19
	public override void RoomSynchronization(RoomSynchronizationEvent syncEvent) { }

	// RVA: 0x21847F0 Offset: 0x21807F0 VA: 0x21847F0
	public bool CheckEnterAreaLevel(int level) { }

	// RVA: 0x2184824 Offset: 0x2180824 VA: 0x2184824
	public void ReceiveCheckEnterAreaLevel(int level) { }

	// RVA: 0x2184854 Offset: 0x2180854 VA: 0x2184854
	public void DifficultyReset() { }

	// RVA: 0x218485C Offset: 0x218085C VA: 0x218485C
	public void DifficultyUp() { }

	// RVA: 0x2184878 Offset: 0x2180878 VA: 0x2184878
	public void DifficultyDown() { }
}

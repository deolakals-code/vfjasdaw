// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BossRaidRoomData : RoomDataBase // TypeDefIndex: 2315
{
	// Fields
	private BossSymbolData bossSymbolData; // 0x68
	private BossResultData bossResultData; // 0x70
	private Dictionary<string, List<int>> gemList; // 0x78
	private Dictionary<int, List<int>> gemEffectList; // 0x80
	private float gemTimer; // 0x88
	private ItemTextManager itemTextManager; // 0x90
	private MonsterDropDetailData[] monsterDropDetailDatas; // 0x98
	[CompilerGenerated]
	private int <BossCheckConnect>k__BackingField; // 0xA0
	[CompilerGenerated]
	private int <DifficultyState>k__BackingField; // 0xA4
	[CompilerGenerated]
	private bool <IsUserMatchingSettingFlag>k__BackingField; // 0xA8

	// Properties
	public int BossCheckConnect { get; set; }
	public override byte RoomType { get; }
	public BossSymbolData BossSymbolData { get; }
	public BossResultData BossResultData { get; }
	public override short AreaLevel { get; }
	public int DifficultyState { get; set; }
	public bool IsBattle { get; }
	public List<MonsterDropDetailData> MonsterDropDetailDatas { get; }
	public bool IsUserMatchingSettingFlag { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2182008 Offset: 0x217E008 VA: 0x2182008
	public int get_BossCheckConnect() { }

	[CompilerGenerated]
	// RVA: 0x2182010 Offset: 0x217E010 VA: 0x2182010
	private void set_BossCheckConnect(int value) { }

	// RVA: 0x2182018 Offset: 0x217E018 VA: 0x2182018 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x2182020 Offset: 0x217E020 VA: 0x2182020
	public BossSymbolData get_BossSymbolData() { }

	// RVA: 0x2182028 Offset: 0x217E028 VA: 0x2182028
	public BossResultData get_BossResultData() { }

	// RVA: 0x2182030 Offset: 0x217E030 VA: 0x2182030 Slot: 7
	public override short get_AreaLevel() { }

	[CompilerGenerated]
	// RVA: 0x2182048 Offset: 0x217E048 VA: 0x2182048
	public int get_DifficultyState() { }

	[CompilerGenerated]
	// RVA: 0x2182050 Offset: 0x217E050 VA: 0x2182050
	public void set_DifficultyState(int value) { }

	// RVA: 0x2182058 Offset: 0x217E058 VA: 0x2182058
	public bool get_IsBattle() { }

	// RVA: 0x218206C Offset: 0x217E06C VA: 0x218206C
	public List<MonsterDropDetailData> get_MonsterDropDetailDatas() { }

	[CompilerGenerated]
	// RVA: 0x21820C4 Offset: 0x217E0C4 VA: 0x21820C4
	private void set_IsUserMatchingSettingFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21820D0 Offset: 0x217E0D0 VA: 0x21820D0
	public bool get_IsUserMatchingSettingFlag() { }

	// RVA: 0x21820D8 Offset: 0x217E0D8 VA: 0x21820D8
	public void .ctor() { }

	// RVA: 0x21821CC Offset: 0x217E1CC VA: 0x21821CC Slot: 12
	public override void Clear() { }

	// RVA: 0x2182294 Offset: 0x217E294 VA: 0x2182294
	public void ReceiveBossSymbolData(BossSymbolData data) { }

	// RVA: 0x21822A0 Offset: 0x217E2A0 VA: 0x21822A0
	public void ReceiveMonsterDropDetailData(MonsterDropDetailData[] datas) { }

	// RVA: 0x21822A8 Offset: 0x217E2A8 VA: 0x21822A8
	public void ReceiveBossResultData(BossResultData data) { }

	// RVA: 0x2182660 Offset: 0x217E660 VA: 0x2182660
	public void AddUseGemList(string avatarName, int avatarUuid, int itemId) { }

	// RVA: 0x2182A84 Offset: 0x217EA84 VA: 0x2182A84 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x2182A88 Offset: 0x217EA88 VA: 0x2182A88 Slot: 15
	public override void Update() { }

	// RVA: 0x2183000 Offset: 0x217F000 VA: 0x2183000 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21830A0 Offset: 0x217F0A0 VA: 0x21830A0 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21830B8 Offset: 0x217F0B8 VA: 0x21830B8 Slot: 11
	public override void OnFailure(byte operationCode, byte subCode, short returnCode) { }

	// RVA: 0x2183158 Offset: 0x217F158 VA: 0x2183158 Slot: 13
	public override void Enter() { }

	// RVA: 0x21831F8 Offset: 0x217F1F8 VA: 0x21831F8 Slot: 14
	public override void Leave() { }

	// RVA: 0x2183284 Offset: 0x217F284 VA: 0x2183284 Slot: 19
	public override void RoomSynchronization(RoomSynchronizationEvent syncEvent) { }

	// RVA: 0x2183344 Offset: 0x217F344 VA: 0x2183344
	public bool CheckEnterAreaLevel(int level) { }

	// RVA: 0x2183378 Offset: 0x217F378 VA: 0x2183378
	public void ReceiveCheckEnterAreaLevel(int level) { }

	// RVA: 0x21833A8 Offset: 0x217F3A8 VA: 0x21833A8
	public void DifficultyReset() { }

	// RVA: 0x21833B0 Offset: 0x217F3B0 VA: 0x21833B0
	public void DifficultyUp() { }

	// RVA: 0x21833CC Offset: 0x217F3CC VA: 0x21833CC
	public void DifficultyDown() { }

	// RVA: 0x21833E4 Offset: 0x217F3E4 VA: 0x21833E4
	public void UpdateUserMatchingFlag(bool isFlag) { }
}

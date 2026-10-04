// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuildRaidRoomData : RoomDataBase // TypeDefIndex: 2342
{
	// Fields
	public const byte PracticeRoomId = 210;
	private readonly Dictionary<GuildRaidRandomPropertyId, ItemDBData.ItemType> EquipDamageUpList; // 0x68
	private GuildRaidRandomPropertyData[] bossRandomPropertyList; // 0x70
	private BossResultData bossResultData; // 0x78
	private GuildEndGuildRaidBattleEvent battleEndData; // 0x80
	private bool isEndBattleEvent; // 0x88
	private int bossSubdueRewardNum; // 0x8C
	private float serverLeftTime; // 0x90
	private float updateTime; // 0x94
	[CompilerGenerated]
	private int <BossCheckConnect>k__BackingField; // 0x98
	[CompilerGenerated]
	private int <BossResultRewardItemId>k__BackingField; // 0x9C
	[CompilerGenerated]
	private bool <IsPractice>k__BackingField; // 0xA0
	[CompilerGenerated]
	private int <MonsterUUid>k__BackingField; // 0xA4
	[CompilerGenerated]
	private ElementType <MonsterElement>k__BackingField; // 0xA8
	[CompilerGenerated]
	private int <CurrentLevel>k__BackingField; // 0xAC
	[CompilerGenerated]
	private short <GuildRaidLevel>k__BackingField; // 0xB0
	[CompilerGenerated]
	private short <StartHpCount>k__BackingField; // 0xB2
	[CompilerGenerated]
	private short <CurrentHpCount>k__BackingField; // 0xB4
	[CompilerGenerated]
	private short <MaxHpNum>k__BackingField; // 0xB6
	[CompilerGenerated]
	private float <BossHpGaugeRate>k__BackingField; // 0xB8
	[CompilerGenerated]
	private int <RandamPropertyOrbUsePoint>k__BackingField; // 0xBC
	[CompilerGenerated]
	private bool <IsOverTime>k__BackingField; // 0xC0
	[CompilerGenerated]
	private bool <IsEscape>k__BackingField; // 0xC1
	[CompilerGenerated]
	private bool <IsUserMatchingSettingFlag>k__BackingField; // 0xC2

	// Properties
	public int BossCheckConnect { get; set; }
	public override byte RoomType { get; }
	public List<GuildRaidRandomPropertyData> BossRandomPropertyList { get; }
	public BossResultData BossResultData { get; }
	public int BossResultHpCount { get; }
	public int BossResultRewardItemId { get; set; }
	public bool IsPractice { get; set; }
	public int BossResultRewardItemNum { get; }
	public override short AreaLevel { get; }
	public int MonsterUUid { get; set; }
	public ElementType MonsterElement { get; set; }
	public int CurrentLevel { get; set; }
	public short GuildRaidLevel { get; set; }
	public short StartHpCount { get; set; }
	public short CurrentHpCount { get; set; }
	public short MaxHpNum { get; set; }
	public float BossHpGaugeRate { get; set; }
	public int RandamPropertyOrbUsePoint { get; set; }
	public bool IsOverTime { get; set; }
	public bool IsEscape { get; set; }
	public float LeftTime { get; }
	public bool IsPlayGame { get; }
	public bool IsBattle { get; }
	public bool IsUserMatchingSettingFlag { get; set; }
	public bool IsSubdue { get; }
	public float BossResultHpGaugeRate { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x218E10C Offset: 0x218A10C VA: 0x218E10C
	public int get_BossCheckConnect() { }

	[CompilerGenerated]
	// RVA: 0x218E114 Offset: 0x218A114 VA: 0x218E114
	private void set_BossCheckConnect(int value) { }

	// RVA: 0x218E11C Offset: 0x218A11C VA: 0x218E11C Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x218E124 Offset: 0x218A124 VA: 0x218E124
	public List<GuildRaidRandomPropertyData> get_BossRandomPropertyList() { }

	// RVA: 0x218E1BC Offset: 0x218A1BC VA: 0x218E1BC
	public BossResultData get_BossResultData() { }

	// RVA: 0x218E1C4 Offset: 0x218A1C4 VA: 0x218E1C4
	public int get_BossResultHpCount() { }

	[CompilerGenerated]
	// RVA: 0x218E1DC Offset: 0x218A1DC VA: 0x218E1DC
	public int get_BossResultRewardItemId() { }

	[CompilerGenerated]
	// RVA: 0x218E1E4 Offset: 0x218A1E4 VA: 0x218E1E4
	private void set_BossResultRewardItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x218E1EC Offset: 0x218A1EC VA: 0x218E1EC
	public bool get_IsPractice() { }

	[CompilerGenerated]
	// RVA: 0x218E1F4 Offset: 0x218A1F4 VA: 0x218E1F4
	private void set_IsPractice(bool value) { }

	// RVA: 0x218E200 Offset: 0x218A200 VA: 0x218E200
	public int get_BossResultRewardItemNum() { }

	// RVA: 0x218E22C Offset: 0x218A22C VA: 0x218E22C Slot: 7
	public override short get_AreaLevel() { }

	[CompilerGenerated]
	// RVA: 0x218E234 Offset: 0x218A234 VA: 0x218E234
	private void set_MonsterUUid(int value) { }

	[CompilerGenerated]
	// RVA: 0x218E23C Offset: 0x218A23C VA: 0x218E23C
	public int get_MonsterUUid() { }

	[CompilerGenerated]
	// RVA: 0x218E244 Offset: 0x218A244 VA: 0x218E244
	private void set_MonsterElement(ElementType value) { }

	[CompilerGenerated]
	// RVA: 0x218E24C Offset: 0x218A24C VA: 0x218E24C
	public ElementType get_MonsterElement() { }

	[CompilerGenerated]
	// RVA: 0x218E254 Offset: 0x218A254 VA: 0x218E254
	private void set_CurrentLevel(int value) { }

	[CompilerGenerated]
	// RVA: 0x218E25C Offset: 0x218A25C VA: 0x218E25C
	public int get_CurrentLevel() { }

	[CompilerGenerated]
	// RVA: 0x218E264 Offset: 0x218A264 VA: 0x218E264
	public short get_GuildRaidLevel() { }

	[CompilerGenerated]
	// RVA: 0x218E26C Offset: 0x218A26C VA: 0x218E26C
	private void set_GuildRaidLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x218E274 Offset: 0x218A274 VA: 0x218E274
	public short get_StartHpCount() { }

	[CompilerGenerated]
	// RVA: 0x218E27C Offset: 0x218A27C VA: 0x218E27C
	private void set_StartHpCount(short value) { }

	[CompilerGenerated]
	// RVA: 0x218E284 Offset: 0x218A284 VA: 0x218E284
	public short get_CurrentHpCount() { }

	[CompilerGenerated]
	// RVA: 0x218E28C Offset: 0x218A28C VA: 0x218E28C
	private void set_CurrentHpCount(short value) { }

	[CompilerGenerated]
	// RVA: 0x218E294 Offset: 0x218A294 VA: 0x218E294
	public short get_MaxHpNum() { }

	[CompilerGenerated]
	// RVA: 0x218E29C Offset: 0x218A29C VA: 0x218E29C
	private void set_MaxHpNum(short value) { }

	[CompilerGenerated]
	// RVA: 0x218E2A4 Offset: 0x218A2A4 VA: 0x218E2A4
	public float get_BossHpGaugeRate() { }

	[CompilerGenerated]
	// RVA: 0x218E2AC Offset: 0x218A2AC VA: 0x218E2AC
	private void set_BossHpGaugeRate(float value) { }

	[CompilerGenerated]
	// RVA: 0x218E2B4 Offset: 0x218A2B4 VA: 0x218E2B4
	public int get_RandamPropertyOrbUsePoint() { }

	[CompilerGenerated]
	// RVA: 0x218E2BC Offset: 0x218A2BC VA: 0x218E2BC
	private void set_RandamPropertyOrbUsePoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x218E2C4 Offset: 0x218A2C4 VA: 0x218E2C4
	public bool get_IsOverTime() { }

	[CompilerGenerated]
	// RVA: 0x218E2CC Offset: 0x218A2CC VA: 0x218E2CC
	private void set_IsOverTime(bool value) { }

	[CompilerGenerated]
	// RVA: 0x218E2D8 Offset: 0x218A2D8 VA: 0x218E2D8
	public bool get_IsEscape() { }

	[CompilerGenerated]
	// RVA: 0x218E2E0 Offset: 0x218A2E0 VA: 0x218E2E0
	private void set_IsEscape(bool value) { }

	// RVA: 0x218E2EC Offset: 0x218A2EC VA: 0x218E2EC
	public float get_LeftTime() { }

	// RVA: 0x218E328 Offset: 0x218A328 VA: 0x218E328
	public bool get_IsPlayGame() { }

	// RVA: 0x218E338 Offset: 0x218A338 VA: 0x218E338
	public bool get_IsBattle() { }

	[CompilerGenerated]
	// RVA: 0x218E34C Offset: 0x218A34C VA: 0x218E34C
	private void set_IsUserMatchingSettingFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x218E358 Offset: 0x218A358 VA: 0x218E358
	public bool get_IsUserMatchingSettingFlag() { }

	// RVA: 0x218E360 Offset: 0x218A360 VA: 0x218E360
	public bool get_IsSubdue() { }

	// RVA: 0x218E380 Offset: 0x218A380 VA: 0x218E380
	public float get_BossResultHpGaugeRate() { }

	// RVA: 0x218E4E4 Offset: 0x218A4E4 VA: 0x218E4E4
	public void .ctor() { }

	// RVA: 0x218E7DC Offset: 0x218A7DC VA: 0x218E7DC Slot: 12
	public override void Clear() { }

	// RVA: 0x218E8F8 Offset: 0x218A8F8 VA: 0x218E8F8
	public void ReceiveBossSymbolData(int mobUuid, int currentHpGauge, int maxHpGauge, int battleHp, byte element, bool isPractice) { }

	// RVA: 0x218EADC Offset: 0x218AADC VA: 0x218EADC
	public void ReceiveGuildRaidRandomPropertyData(GuildRaidRandomPropertyData[] datas) { }

	// RVA: 0x218EAE4 Offset: 0x218AAE4 VA: 0x218EAE4
	public void ReceiveUpdateGuildRaidRandomPropertyData(byte index, string name) { }

	// RVA: 0x218EB90 Offset: 0x218AB90 VA: 0x218EB90
	public void ReceiveRaidEndBattleData(GuildEndGuildRaidBattleEvent endEvent) { }

	// RVA: 0x218EBF4 Offset: 0x218ABF4 VA: 0x218EBF4
	public void ReceiveRaidEnd(int subdueRewardNum) { }

	// RVA: 0x218EBFC Offset: 0x218ABFC VA: 0x218EBFC Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x218EC00 Offset: 0x218AC00 VA: 0x218EC00 Slot: 15
	public override void Update() { }

	// RVA: 0x218EDB8 Offset: 0x218ADB8 VA: 0x218EDB8 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x218EE58 Offset: 0x218AE58 VA: 0x218EE58 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x218EE70 Offset: 0x218AE70 VA: 0x218EE70 Slot: 11
	public override void OnFailure(byte operationCode, byte subCode, short returnCode) { }

	// RVA: 0x218EF10 Offset: 0x218AF10 VA: 0x218EF10 Slot: 13
	public override void Enter() { }

	// RVA: 0x218F1DC Offset: 0x218B1DC VA: 0x218F1DC Slot: 14
	public override void Leave() { }

	// RVA: 0x218EAD4 Offset: 0x218AAD4 VA: 0x218EAD4
	public void SetGuildRaidLevel(short level) { }

	// RVA: 0x218EAA8 Offset: 0x218AAA8 VA: 0x218EAA8
	public void SetStartHpCount(byte hpCount) { }

	// RVA: 0x218EAB4 Offset: 0x218AAB4 VA: 0x218EAB4
	public void SetCurrentHpCount(byte hpCount) { }

	// RVA: 0x218F278 Offset: 0x218B278 VA: 0x218F278 Slot: 19
	public override void RoomSynchronization(RoomSynchronizationEvent syncEvent) { }

	// RVA: 0x218F3C4 Offset: 0x218B3C4 VA: 0x218F3C4
	public void EscapVote() { }

	// RVA: 0x218F4AC Offset: 0x218B4AC VA: 0x218F4AC
	public void OnReceiveOverTime() { }

	// RVA: 0x218F4D4 Offset: 0x218B4D4 VA: 0x218F4D4 Slot: 24
	public override void UpdatePlayerPropertyEnd(GameObject player, SkinnedMeshRenderer skin, PlayerAnimation animation, CharacterMove move) { }

	// RVA: 0x218F998 Offset: 0x218B998 VA: 0x218F998
	public List<BonusParameter> GetPlayerGuildRaidBonus() { }

	// RVA: 0x218FEBC Offset: 0x218BEBC VA: 0x218FEBC
	public MobPropertyMaster[] GetMobGuildRaidBonus() { }

	// RVA: 0x2190534 Offset: 0x218C534 VA: 0x2190534
	public bool TryGetAbnormalAdaptation(out int flinchAdaptation, out int tumbleAdaptation, out int stunAdaptation) { }

	// RVA: 0x218E848 Offset: 0x218A848 VA: 0x218E848
	public bool CheckItemUseProhibited() { }

	// RVA: 0x2190624 Offset: 0x218C624 VA: 0x2190624
	public GuildRaidRandomPropertyData GetRandomPropertyData(byte index) { }
}

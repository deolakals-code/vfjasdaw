// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NaCollaborationRoomData : RoomDataBase // TypeDefIndex: 2421
{
	// Fields
	private BossSymbolData bossSymbolData; // 0x68
	private BossResultData bossResultData; // 0x70
	private MonsterDropDetailData[] monsterDropDetailDatas; // 0x78
	private Dictionary<string, List<int>> gemList; // 0x80
	private Dictionary<int, List<int>> gemEffectList; // 0x88
	private float gemTimer; // 0x90
	private ItemTextManager itemTextManager; // 0x98
	private int[] targetMobUniqueIdList; // 0xA0
	[CompilerGenerated]
	private int <DifficultyState>k__BackingField; // 0xA8
	[CompilerGenerated]
	private int[] <ResultPoints>k__BackingField; // 0xB0
	[CompilerGenerated]
	private bool <IsUserMatchingSettingFlag>k__BackingField; // 0xB8
	[CompilerGenerated]
	private byte <PointBoost>k__BackingField; // 0xB9
	[CompilerGenerated]
	private NaCollaborationSpecialRewardState <SpecialRewardState>k__BackingField; // 0xBA
	[CompilerGenerated]
	private byte[] <WeaponStack>k__BackingField; // 0xC0
	[CompilerGenerated]
	private int <BossCheckConnect>k__BackingField; // 0xC8
	public const int MaxPointBoost = 10;
	[CompilerGenerated]
	private ExchangePointGetEvent <PointEventData>k__BackingField; // 0xD0
	[CompilerGenerated]
	private float <NextResetTimeLeft>k__BackingField; // 0xD8
	[CompilerGenerated]
	private RewardResponseDatav2 <SpecialRewardData>k__BackingField; // 0xE0

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
	public NaCollaborationSpecialRewardState SpecialRewardState { get; set; }
	public byte[] WeaponStack { get; set; }
	public int BossCheckConnect { get; set; }
	public ExchangePointGetEvent PointEventData { get; set; }
	public float NextResetTimeLeft { get; set; }
	public RewardResponseDatav2 SpecialRewardData { get; set; }

	// Methods

	// RVA: 0x21AA580 Offset: 0x21A6580 VA: 0x21AA580 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x21AA588 Offset: 0x21A6588 VA: 0x21AA588
	public BossSymbolData get_BossSymbolData() { }

	// RVA: 0x21AA590 Offset: 0x21A6590 VA: 0x21AA590
	public BossResultData get_BossResultData() { }

	// RVA: 0x21AA598 Offset: 0x21A6598 VA: 0x21AA598 Slot: 7
	public override short get_AreaLevel() { }

	[CompilerGenerated]
	// RVA: 0x21AA5B0 Offset: 0x21A65B0 VA: 0x21AA5B0
	public int get_DifficultyState() { }

	[CompilerGenerated]
	// RVA: 0x21AA5B8 Offset: 0x21A65B8 VA: 0x21AA5B8
	private void set_DifficultyState(int value) { }

	[CompilerGenerated]
	// RVA: 0x21AA5C0 Offset: 0x21A65C0 VA: 0x21AA5C0
	public int[] get_ResultPoints() { }

	[CompilerGenerated]
	// RVA: 0x21AA5C8 Offset: 0x21A65C8 VA: 0x21AA5C8
	private void set_ResultPoints(int[] value) { }

	// RVA: 0x21AA5D0 Offset: 0x21A65D0 VA: 0x21AA5D0
	public bool get_IsBattle() { }

	// RVA: 0x21AA5E4 Offset: 0x21A65E4 VA: 0x21AA5E4
	public List<MonsterDropDetailData> get_MonsterDropDetailDatas() { }

	[CompilerGenerated]
	// RVA: 0x21AA63C Offset: 0x21A663C VA: 0x21AA63C
	private void set_IsUserMatchingSettingFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x21AA648 Offset: 0x21A6648 VA: 0x21AA648
	public bool get_IsUserMatchingSettingFlag() { }

	[CompilerGenerated]
	// RVA: 0x21AA650 Offset: 0x21A6650 VA: 0x21AA650
	public byte get_PointBoost() { }

	[CompilerGenerated]
	// RVA: 0x21AA658 Offset: 0x21A6658 VA: 0x21AA658
	private void set_PointBoost(byte value) { }

	[CompilerGenerated]
	// RVA: 0x21AA660 Offset: 0x21A6660 VA: 0x21AA660
	public NaCollaborationSpecialRewardState get_SpecialRewardState() { }

	[CompilerGenerated]
	// RVA: 0x21AA668 Offset: 0x21A6668 VA: 0x21AA668
	private void set_SpecialRewardState(NaCollaborationSpecialRewardState value) { }

	[CompilerGenerated]
	// RVA: 0x21AA670 Offset: 0x21A6670 VA: 0x21AA670
	public byte[] get_WeaponStack() { }

	[CompilerGenerated]
	// RVA: 0x21AA678 Offset: 0x21A6678 VA: 0x21AA678
	private void set_WeaponStack(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x21AA680 Offset: 0x21A6680 VA: 0x21AA680
	public int get_BossCheckConnect() { }

	[CompilerGenerated]
	// RVA: 0x21AA688 Offset: 0x21A6688 VA: 0x21AA688
	private void set_BossCheckConnect(int value) { }

	[CompilerGenerated]
	// RVA: 0x21AA690 Offset: 0x21A6690 VA: 0x21AA690
	public ExchangePointGetEvent get_PointEventData() { }

	[CompilerGenerated]
	// RVA: 0x21AA698 Offset: 0x21A6698 VA: 0x21AA698
	private void set_PointEventData(ExchangePointGetEvent value) { }

	[CompilerGenerated]
	// RVA: 0x21AA6A0 Offset: 0x21A66A0 VA: 0x21AA6A0
	public float get_NextResetTimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x21AA6A8 Offset: 0x21A66A8 VA: 0x21AA6A8
	private void set_NextResetTimeLeft(float value) { }

	[CompilerGenerated]
	// RVA: 0x21AA6B0 Offset: 0x21A66B0 VA: 0x21AA6B0
	public RewardResponseDatav2 get_SpecialRewardData() { }

	[CompilerGenerated]
	// RVA: 0x21AA6B8 Offset: 0x21A66B8 VA: 0x21AA6B8
	private void set_SpecialRewardData(RewardResponseDatav2 value) { }

	// RVA: 0x21AA6C0 Offset: 0x21A66C0 VA: 0x21AA6C0
	public void .ctor() { }

	// RVA: 0x21AA7BC Offset: 0x21A67BC VA: 0x21AA7BC Slot: 12
	public override void Clear() { }

	// RVA: 0x21AA92C Offset: 0x21A692C VA: 0x21AA92C Slot: 13
	public override void Enter() { }

	// RVA: 0x21AA9CC Offset: 0x21A69CC VA: 0x21AA9CC Slot: 14
	public override void Leave() { }

	// RVA: 0x21AAA54 Offset: 0x21A6A54 VA: 0x21AAA54 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x21AAA58 Offset: 0x21A6A58 VA: 0x21AAA58 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21AAAF4 Offset: 0x21A6AF4 VA: 0x21AAAF4 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21AAB0C Offset: 0x21A6B0C VA: 0x21AAB0C Slot: 15
	public override void Update() { }

	// RVA: 0x21AB10C Offset: 0x21A710C VA: 0x21AB10C
	public void CheckRoom(int fieldId, byte roomId, byte flag) { }

	// RVA: 0x21AB200 Offset: 0x21A7200 VA: 0x21AB200
	public void ReceiveBossResultData(BossResultData data, int[] points) { }

	// RVA: 0x21AB5C8 Offset: 0x21A75C8 VA: 0x21AB5C8
	public void ReceivePointGetEvent(ExchangePointGetEvent eventData) { }

	// RVA: 0x21AB5D0 Offset: 0x21A75D0 VA: 0x21AB5D0
	public bool CheckEnterAreaLevel(int level) { }

	// RVA: 0x21AB608 Offset: 0x21A7608 VA: 0x21AB608
	public void DifficultyReset() { }

	// RVA: 0x21AB610 Offset: 0x21A7610 VA: 0x21AB610
	public void SetDifficultyState(int state) { }

	// RVA: 0x21AB618 Offset: 0x21A7618 VA: 0x21AB618
	public void UpdateUserMatchingFlag(bool isFlag) { }

	// RVA: 0x21AB624 Offset: 0x21A7624 VA: 0x21AB624
	public void ReceiveSpecialReward() { }

	// RVA: 0x21AB708 Offset: 0x21A7708 VA: 0x21AB708
	public void AddUseGemList(string avatarName, int avatarUuid, int itemId) { }

	// RVA: 0x21ABB2C Offset: 0x21A7B2C VA: 0x21ABB2C
	public void SetTargetMobUniqueIdList(int[] targetList) { }

	// RVA: 0x21ABB34 Offset: 0x21A7B34 VA: 0x21ABB34
	public bool CheckSubjugationTarget(int mobUniqueId) { }

	// RVA: 0x21AB088 Offset: 0x21A7088 VA: 0x21AB088
	private void UpdateResetTimeLeft() { }
}

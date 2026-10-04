// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class BonusManager // TypeDefIndex: 1734
{
	// Fields
	private static Dictionary<BonusType, int> AvatarBonusTimes; // 0x0
	private static Dictionary<BonusType, float> BonusTimes; // 0x8
	private static readonly BonusType[] limitList; // 0x10
	[CompilerGenerated]
	private BonusManager.BonusActionHandler OnInvokeBonus; // 0x10
	private BonusScriptManager bonusScriptManager; // 0x18
	private Dictionary<ItemDBData.EquipType, BonusData> equipBonusList; // 0x20
	private Dictionary<ItemDBData.EquipType, List<BonusData>> equipCristaBonusList; // 0x28
	private Dictionary<BonusType, BonusData> durationBonusList; // 0x30
	private Dictionary<int, BonusData> gemBonusList; // 0x38
	private Dictionary<DungeonEventType, DungeonBonusData> dungeonBonusList; // 0x40
	private Dictionary<int, TreasureHuntBonusData> treasureHuntBonusList; // 0x48
	private Dictionary<short, BonusData> gemCartBonusList; // 0x50
	private Dictionary<short, int> guildFacilityValueList; // 0x58
	private BonusData guildFacilityBonusData; // 0x60
	private Dictionary<BonusType, DebuffBonusDataBase> debuffList; // 0x68
	private Dictionary<ItemDBData.EquipType, BonusData> itemRandomPropertyBonusList; // 0x70
	private List<BonusData> allBonusList; // 0x78

	// Properties
	public BonusScriptManager BonusScriptManager { get; }
	public IList<BonusData> AllBonusList { get; }
	public IList<BonusData> DurationBonusList { get; }
	public TreasureHuntBonusData[] TreasureHuntBonusList { get; }
	public IList<DebuffBonusDataBase> DebuffList { get; }
	public bool HasGemBonus { get; }
	public Dictionary<ItemDBData.EquipType, BonusData> ItemRandomPropertyBonusList { get; }

	// Methods

	// RVA: 0x20B57D0 Offset: 0x20B17D0 VA: 0x20B57D0
	public static float GetBonusTime(BonusType bonusType) { }

	// RVA: 0x20B58D0 Offset: 0x20B18D0 VA: 0x20B58D0
	public static bool CheckEquipLimitBonusId(short id) { }

	[CompilerGenerated]
	// RVA: 0x20B59D8 Offset: 0x20B19D8 VA: 0x20B59D8
	public void add_OnInvokeBonus(BonusManager.BonusActionHandler value) { }

	[CompilerGenerated]
	// RVA: 0x20B5A74 Offset: 0x20B1A74 VA: 0x20B5A74
	public void remove_OnInvokeBonus(BonusManager.BonusActionHandler value) { }

	// RVA: 0x20B5B10 Offset: 0x20B1B10 VA: 0x20B5B10
	public BonusScriptManager get_BonusScriptManager() { }

	// RVA: 0x20B5B18 Offset: 0x20B1B18 VA: 0x20B5B18
	public IList<BonusData> get_AllBonusList() { }

	// RVA: 0x20B5B68 Offset: 0x20B1B68 VA: 0x20B5B68
	public IList<BonusData> get_DurationBonusList() { }

	// RVA: 0x20B5BD4 Offset: 0x20B1BD4 VA: 0x20B5BD4
	public TreasureHuntBonusData[] get_TreasureHuntBonusList() { }

	// RVA: 0x20B5C40 Offset: 0x20B1C40 VA: 0x20B5C40
	public IList<DebuffBonusDataBase> get_DebuffList() { }

	// RVA: 0x20B5CCC Offset: 0x20B1CCC VA: 0x20B5CCC
	public bool get_HasGemBonus() { }

	// RVA: 0x20B5D28 Offset: 0x20B1D28 VA: 0x20B5D28
	public Dictionary<ItemDBData.EquipType, BonusData> get_ItemRandomPropertyBonusList() { }

	// RVA: 0x20B5D30 Offset: 0x20B1D30 VA: 0x20B5D30
	public void .ctor() { }

	// RVA: 0x20B60A0 Offset: 0x20B20A0 VA: 0x20B60A0
	public void Initialize(PlayerStatusBase playerStatus) { }

	// RVA: 0x20B611C Offset: 0x20B211C VA: 0x20B611C
	public BonusData CreateBonus(IList<BonusParameter> bonusLines, bool exec) { }

	// RVA: 0x20B621C Offset: 0x20B221C VA: 0x20B621C
	public BonusData CreateBonus(IList<BonusParameter> bonusLines, bool exec, int stack) { }

	// RVA: 0x20B671C Offset: 0x20B271C VA: 0x20B671C
	public void ClearDurationBonus() { }

	[Obsolete]
	// RVA: 0x20B68CC Offset: 0x20B28CC VA: 0x20B68CC
	public void InitBonus(BonusData bonus, float time) { }

	// RVA: 0x20B61E8 Offset: 0x20B21E8 VA: 0x20B61E8
	public void RunBonus(BonusData bonus, bool updateTime) { }

	// RVA: 0x20B6AD8 Offset: 0x20B2AD8 VA: 0x20B6AD8
	public void SetEquipBonus(ItemDBData.EquipType type, BonusData bonus) { }

	// RVA: 0x20B6E9C Offset: 0x20B2E9C VA: 0x20B6E9C
	public void AddEquipCristaBonus(ItemDBData.EquipType type, BonusData bonus) { }

	// RVA: 0x20B70AC Offset: 0x20B30AC VA: 0x20B70AC
	public void UpdateEquipLimitBonus() { }

	// RVA: 0x20B7318 Offset: 0x20B3318 VA: 0x20B7318
	public BonusData GetDurationBonus(BonusType type) { }

	// RVA: 0x20B693C Offset: 0x20B293C VA: 0x20B693C
	public void SetDurationBonus(BonusData bonus) { }

	// RVA: 0x20B73AC Offset: 0x20B33AC VA: 0x20B73AC
	public void ClearDebuff() { }

	// RVA: 0x20B73FC Offset: 0x20B33FC VA: 0x20B73FC
	public void SetDebuff(BonusData bonus) { }

	// RVA: 0x20B77B8 Offset: 0x20B37B8 VA: 0x20B77B8
	public bool TryGetDebuff(BonusType type, out DebuffBonusDataBase debuff) { }

	// RVA: 0x20B7748 Offset: 0x20B3748 VA: 0x20B7748
	private static DebuffBonusDataBase CreateDebuff(BonusType type, int value) { }

	// RVA: 0x20B7820 Offset: 0x20B3820 VA: 0x20B7820
	public bool AddGemBonus(int itemId) { }

	// RVA: 0x20B79A0 Offset: 0x20B39A0 VA: 0x20B79A0
	public void StartGemBonus() { }

	// RVA: 0x20B7BF8 Offset: 0x20B3BF8 VA: 0x20B7BF8
	public void EndGemBonus(int itemId) { }

	// RVA: 0x20B7CFC Offset: 0x20B3CFC VA: 0x20B7CFC
	public void ClearGemBonus() { }

	// RVA: 0x20B7EAC Offset: 0x20B3EAC VA: 0x20B7EAC
	public bool AddDungeonBonus(DungeonEventType eventType) { }

	// RVA: 0x20B80E0 Offset: 0x20B40E0 VA: 0x20B80E0
	public void ClearDungeonBonus() { }

	// RVA: 0x20B82A0 Offset: 0x20B42A0 VA: 0x20B82A0
	public bool AddTreasureHuntBonus(RoomSupportUseData supportData) { }

	// RVA: 0x20B8428 Offset: 0x20B4428 VA: 0x20B8428
	public void ClearTreasureHuntBonus() { }

	// RVA: 0x20B85E8 Offset: 0x20B45E8 VA: 0x20B85E8
	public float GetTreasureHuntLastDmgRateBonus() { }

	// RVA: 0x20B8650 Offset: 0x20B4650 VA: 0x20B8650
	public float GetTreasureHuntLastDmgedDownRateBonus() { }

	// RVA: 0x20B86BC Offset: 0x20B46BC VA: 0x20B86BC
	public bool AddGemCartBonus(short id, short[] type, short[] val) { }

	// RVA: 0x20B89AC Offset: 0x20B49AC VA: 0x20B89AC
	public void ClearGemCartBonus() { }

	// RVA: 0x20B8B5C Offset: 0x20B4B5C VA: 0x20B8B5C
	public void RemoveGemCartBonus(short id) { }

	// RVA: 0x20B8C1C Offset: 0x20B4C1C VA: 0x20B8C1C
	public void UpdateGemCartBonus(short id, short[] type, short[] val) { }

	// RVA: 0x20B8804 Offset: 0x20B4804 VA: 0x20B8804
	private List<BonusParameter> CreateBonusParameter(short[] type, short[] val) { }

	// RVA: 0x20B8D4C Offset: 0x20B4D4C VA: 0x20B8D4C
	public void AddGuildFacilityBonus(short[] types, short[] values) { }

	// RVA: 0x20B9098 Offset: 0x20B5098 VA: 0x20B9098
	public int GetGuildFacilityElementBonus(ElementType type) { }

	// RVA: 0x20B9178 Offset: 0x20B5178 VA: 0x20B9178
	public int GetGuildFacilityExpBonus(BonusType type) { }

	// RVA: 0x20B9228 Offset: 0x20B5228 VA: 0x20B9228
	public void Update(PlayerStatusBase playerStatus) { }

	// RVA: 0x20BA3B0 Offset: 0x20B63B0 VA: 0x20BA3B0
	public ElementType GetEquipElement(ItemDBData.EquipType type) { }

	// RVA: 0x20BA524 Offset: 0x20B6524 VA: 0x20BA524
	public int GetCalcBonusValue(int baseVal, BonusType rateType, BonusType constType) { }

	// RVA: 0x20BA898 Offset: 0x20B6898 VA: 0x20BA898
	public int GetBonusValue(BonusType type) { }

	// RVA: 0x20BA9CC Offset: 0x20B69CC VA: 0x20BA9CC
	public float GetBonusPercentValue(BonusType type) { }

	// RVA: 0x20BA9EC Offset: 0x20B69EC VA: 0x20BA9EC
	public int GetAvatarBonusValue(BonusType type) { }

	// RVA: 0x20BA89C Offset: 0x20B689C VA: 0x20BA89C
	private int getDataBonusValue(BonusType type) { }

	// RVA: 0x20BAA94 Offset: 0x20B6A94 VA: 0x20BAA94
	public void GetBonusConstant_AvatarConstan_Rate(BonusType constantType, BonusType constantToAvatarType, BonusType rateType, out int constant, out float rate) { }

	// RVA: 0x20BACB0 Offset: 0x20B6CB0 VA: 0x20BACB0
	public void GetBonusConstant_AvatarConstan_Rate(BonusType constantType, BonusType constantToAvatarType, BonusType rateType, out int constant, out float rate, out int plusValue, out float plusRateValue, out int minusValue, out float minusRateValue) { }

	// RVA: 0x20BAFC4 Offset: 0x20B6FC4 VA: 0x20BAFC4
	public void GetBonusConstant_Rate(BonusType constantType, BonusType rateType, out int constant, out float rate) { }

	// RVA: 0x20BB148 Offset: 0x20B7148 VA: 0x20BB148
	public void GetMaxHpBonusConstant_Rate(out int maxHpConstant, out float maxHpRate) { }

	// RVA: 0x20BB3A4 Offset: 0x20B73A4 VA: 0x20BB3A4
	public void GetMaxMpBonusConstant_Rate(out int maxMpConstant, out float maxMpRate) { }

	// RVA: 0x20BB164 Offset: 0x20B7164 VA: 0x20BB164
	private void GetMaxBonusConstant_Rate(BonusType constantType, BonusType constantTo10Type, BonusType constantToAvatarType, BonusType rateType, out int constant, out float rate) { }

	// RVA: 0x20BB3C0 Offset: 0x20B73C0 VA: 0x20BB3C0
	public float GetBonusMultiPercentValue(BonusType type) { }

	// RVA: 0x20BB9D0 Offset: 0x20B79D0 VA: 0x20BB9D0
	public int CulcConvertAtk(PlayerPrimaryStatus status, out int plusValue, out int minusValue) { }

	// RVA: 0x20BBC84 Offset: 0x20B7C84 VA: 0x20BBC84
	public int CulcConvertMAtk(PlayerPrimaryStatus status, out int plusValue, out int minusValue) { }

	// RVA: 0x20BBF38 Offset: 0x20B7F38 VA: 0x20BBF38
	public float GetRestTime(BonusType type) { }

	// RVA: 0x20BBFD4 Offset: 0x20B7FD4 VA: 0x20BBFD4
	public bool TryGetAvatarSkillEquipType(SkillId skillId, out ItemDBData.EquipType equipType) { }

	// RVA: 0x20BC198 Offset: 0x20B8198 VA: 0x20BC198
	public int GetBuffValue(BonusType type) { }

	// RVA: 0x20BC2B0 Offset: 0x20B82B0 VA: 0x20BC2B0
	public static BonusType GetElementKiller(ElementType type) { }

	// RVA: 0x20BC2CC Offset: 0x20B82CC VA: 0x20BC2CC
	public void StartItemRandomProperty(ItemDBData.EquipType equipType, BonusData bonusData) { }

	// RVA: 0x20BC434 Offset: 0x20B8434 VA: 0x20BC434
	public void EndItemRandomProperty(ItemDBData.EquipType equipType) { }

	// RVA: 0x20BC4F4 Offset: 0x20B84F4 VA: 0x20BC4F4
	public void ClearItemRandomProperty() { }

	// RVA: 0x20BC6A4 Offset: 0x20B86A4 VA: 0x20BC6A4
	private static void .cctor() { }
}

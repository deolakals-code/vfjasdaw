// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class PlayerAttackBase : SkillActionBase // TypeDefIndex: 1518
{
	// Fields
	private readonly CountUpIdManager localIdManager; // 0xA0
	[CompilerGenerated]
	private Action<bool> EndFunction; // 0xA8
	[CompilerGenerated]
	private Action MotionEndFunction; // 0xB0
	protected SkillMasterData skillMaster; // 0xB8
	protected MobaSkillData mobaSkillMaster; // 0xC0
	private int costMp; // 0xC8
	private int comboSkillRate; // 0xCC
	private SkillComboType comboType; // 0xD0
	private SkillComboState _currentSkillCombo; // 0xD8
	private int furiousEffortsExtremeLastDamageRate; // 0xE0
	private int stormAndUrgeExtremePowerResistBreaker; // 0xE4
	protected int DragonToothResistBreaker; // 0xE8
	private int auraBladeLastDamageRate; // 0xEC
	protected float actionStartTime; // 0xF0
	protected PlayerAttackBase.QuicklyType appliedQuicklyType; // 0xF4
	protected byte appliedQuicklyMotionSpeedValue; // 0xF8
	[CompilerGenerated]
	private bool <IsActiveAssistMove>k__BackingField; // 0xF9
	[CompilerGenerated]
	private bool <IsShukuchiAssistMove>k__BackingField; // 0xFA
	[CompilerGenerated]
	private ItemDBData.ItemType <WeaponType>k__BackingField; // 0xFC
	[CompilerGenerated]
	private ItemDBData.ItemType <SubWeaponType>k__BackingField; // 0x100
	[CompilerGenerated]
	private int <SkillIndividualFlag>k__BackingField; // 0x104
	[CompilerGenerated]
	private int <SkillParam>k__BackingField; // 0x108
	[CompilerGenerated]
	private List<SkillCalcTemplate> <SkillTemplateList>k__BackingField; // 0x110
	[CompilerGenerated]
	private bool <MobaMode>k__BackingField; // 0x118
	[CompilerGenerated]
	private byte <ClientCainCastCount>k__BackingField; // 0x119
	[CompilerGenerated]
	private PlayerAttackBase.CalcCostMpType <CostMpType>k__BackingField; // 0x11C

	// Properties
	public override int ActionID { get; }
	public override bool IsMoveAssistContinue { get; }
	public bool IsActiveAssistMove { get; set; }
	public bool IsShukuchiAssistMove { get; set; }
	public virtual bool NoCost { get; }
	public override int Mp { get; }
	public override bool IsSupport { get; }
	public virtual bool IsSupportChangeEndTiming { get; }
	public ItemDBData.ItemType WeaponType { get; set; }
	public ItemDBData.ItemType SubWeaponType { get; set; }
	public int SkillIndividualFlag { get; set; }
	public int SkillParam { get; set; }
	protected List<SkillCalcTemplate> SkillTemplateList { get; set; }
	public virtual SkillTreeType TreeType { get; }
	public virtual bool IsHideAttackApplied { get; }
	protected virtual bool IsRangeEquipBonus { get; }
	protected virtual bool IsRangeSkillBonus { get; }
	protected int ComboSkillRate { get; }
	protected SkillComboState CurrentSkillCombo { get; }
	protected virtual bool CheckBlank { get; }
	protected bool MobaMode { get; set; }
	protected virtual bool IsMotionSpeedVariable { get; }
	public byte ClientCainCastCount { get; set; }
	public PlayerAttackBase.CalcCostMpType CostMpType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x206CCD8 Offset: 0x2068CD8 VA: 0x206CCD8
	protected void add_EndFunction(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x206CD88 Offset: 0x2068D88 VA: 0x206CD88
	protected void remove_EndFunction(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x206CE38 Offset: 0x2068E38 VA: 0x206CE38
	protected void add_MotionEndFunction(Action value) { }

	[CompilerGenerated]
	// RVA: 0x206CED4 Offset: 0x2068ED4 VA: 0x206CED4
	protected void remove_MotionEndFunction(Action value) { }

	// RVA: 0x206CF70 Offset: 0x2068F70 VA: 0x206CF70 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x206CF8C Offset: 0x2068F8C VA: 0x206CF8C Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	[CompilerGenerated]
	// RVA: 0x206CFA8 Offset: 0x2068FA8 VA: 0x206CFA8
	public bool get_IsActiveAssistMove() { }

	[CompilerGenerated]
	// RVA: 0x206CFB0 Offset: 0x2068FB0 VA: 0x206CFB0
	public void set_IsActiveAssistMove(bool value) { }

	[CompilerGenerated]
	// RVA: 0x206CFBC Offset: 0x2068FBC VA: 0x206CFBC
	public bool get_IsShukuchiAssistMove() { }

	[CompilerGenerated]
	// RVA: 0x206CFC4 Offset: 0x2068FC4 VA: 0x206CFC4
	public void set_IsShukuchiAssistMove(bool value) { }

	// RVA: 0x206CFD0 Offset: 0x2068FD0 VA: 0x206CFD0 Slot: 67
	public virtual bool get_NoCost() { }

	// RVA: 0x206CFD8 Offset: 0x2068FD8 VA: 0x206CFD8 Slot: 22
	public override int get_Mp() { }

	// RVA: 0x206CFE0 Offset: 0x2068FE0 VA: 0x206CFE0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x206D004 Offset: 0x2069004 VA: 0x206D004 Slot: 68
	public virtual bool get_IsSupportChangeEndTiming() { }

	[CompilerGenerated]
	// RVA: 0x206D00C Offset: 0x206900C VA: 0x206D00C
	public ItemDBData.ItemType get_WeaponType() { }

	[CompilerGenerated]
	// RVA: 0x206D014 Offset: 0x2069014 VA: 0x206D014
	protected void set_WeaponType(ItemDBData.ItemType value) { }

	[CompilerGenerated]
	// RVA: 0x206D01C Offset: 0x206901C VA: 0x206D01C
	public ItemDBData.ItemType get_SubWeaponType() { }

	[CompilerGenerated]
	// RVA: 0x206D024 Offset: 0x2069024 VA: 0x206D024
	protected void set_SubWeaponType(ItemDBData.ItemType value) { }

	[CompilerGenerated]
	// RVA: 0x206D02C Offset: 0x206902C VA: 0x206D02C
	public int get_SkillIndividualFlag() { }

	[CompilerGenerated]
	// RVA: 0x206D034 Offset: 0x2069034 VA: 0x206D034
	protected void set_SkillIndividualFlag(int value) { }

	[CompilerGenerated]
	// RVA: 0x206D03C Offset: 0x206903C VA: 0x206D03C
	public int get_SkillParam() { }

	[CompilerGenerated]
	// RVA: 0x206D044 Offset: 0x2069044 VA: 0x206D044
	protected void set_SkillParam(int value) { }

	[CompilerGenerated]
	// RVA: 0x206D04C Offset: 0x206904C VA: 0x206D04C
	protected List<SkillCalcTemplate> get_SkillTemplateList() { }

	[CompilerGenerated]
	// RVA: 0x206D054 Offset: 0x2069054 VA: 0x206D054
	protected void set_SkillTemplateList(List<SkillCalcTemplate> value) { }

	// RVA: 0x206D064 Offset: 0x2069064 VA: 0x206D064 Slot: 69
	public virtual SkillTreeType get_TreeType() { }

	// RVA: 0x206D07C Offset: 0x206907C VA: 0x206D07C Slot: 70
	public virtual bool get_IsHideAttackApplied() { }

	// RVA: 0x206D084 Offset: 0x2069084 VA: 0x206D084 Slot: 71
	protected virtual bool get_IsRangeEquipBonus() { }

	// RVA: 0x206D0A8 Offset: 0x20690A8 VA: 0x206D0A8 Slot: 72
	protected virtual bool get_IsRangeSkillBonus() { }

	// RVA: 0x206D0CC Offset: 0x20690CC VA: 0x206D0CC
	protected int get_ComboSkillRate() { }

	// RVA: 0x206D0D4 Offset: 0x20690D4 VA: 0x206D0D4
	protected SkillComboState get_CurrentSkillCombo() { }

	// RVA: 0x206D0DC Offset: 0x20690DC VA: 0x206D0DC Slot: 73
	protected virtual bool get_CheckBlank() { }

	[CompilerGenerated]
	// RVA: 0x206D0E4 Offset: 0x20690E4 VA: 0x206D0E4
	protected bool get_MobaMode() { }

	[CompilerGenerated]
	// RVA: 0x206D0EC Offset: 0x20690EC VA: 0x206D0EC
	private void set_MobaMode(bool value) { }

	// RVA: 0x206D0F8 Offset: 0x20690F8 VA: 0x206D0F8 Slot: 74
	protected virtual bool get_IsMotionSpeedVariable() { }

	[CompilerGenerated]
	// RVA: 0x206D100 Offset: 0x2069100 VA: 0x206D100
	public byte get_ClientCainCastCount() { }

	[CompilerGenerated]
	// RVA: 0x206D108 Offset: 0x2069108 VA: 0x206D108
	private void set_ClientCainCastCount(byte value) { }

	// RVA: 0x206CBB4 Offset: 0x2068BB4 VA: 0x206CBB4
	public void .ctor() { }

	// RVA: 0x206D110 Offset: 0x2069110 VA: 0x206D110
	public SkillIdData GetSkillIdData() { }

	// RVA: 0x206D138 Offset: 0x2069138 VA: 0x206D138
	public void SetComboUse(bool flag) { }

	// RVA: 0x206D14C Offset: 0x206914C VA: 0x206D14C
	public void SetSkillMaster(SkillMasterData skillMaster) { }

	// RVA: 0x206D154 Offset: 0x2069154 VA: 0x206D154
	public void SetMobaSkillData(MobaSkillData mobaSkillMaster) { }

	// RVA: 0x206D15C Offset: 0x206915C VA: 0x206D15C Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x206D208 Offset: 0x2069208 VA: 0x206D208
	public void SetComboMp(int mp) { }

	// RVA: 0x206D210 Offset: 0x2069210 VA: 0x206D210
	public void SetHardHitEndCalcMp(int mp) { }

	// RVA: 0x206D224 Offset: 0x2069224 VA: 0x206D224 Slot: 75
	public virtual void SetComboRate(int rate) { }

	// RVA: 0x206D22C Offset: 0x206922C VA: 0x206D22C Slot: 76
	public virtual void SetComboType(SkillComboType comboType) { }

	// RVA: 0x206D24C Offset: 0x206924C VA: 0x206D24C Slot: 77
	public virtual void SetCurrentSkillCombo(SkillComboState combo) { }

	// RVA: 0x206D254 Offset: 0x2069254 VA: 0x206D254 Slot: 78
	public virtual int CorrectComboRate() { }

	// RVA: 0x206D25C Offset: 0x206925C VA: 0x206D25C Slot: 79
	public virtual bool CheckComboAccept(SkillComboType comboType) { }

	// RVA: 0x206D264 Offset: 0x2069264 VA: 0x206D264
	public void SetComboMotionSpeed(int speed) { }

	// RVA: 0x206D26C Offset: 0x206926C VA: 0x206D26C
	public void CopyCombo(PlayerAttackBase source) { }

	// RVA: 0x206D2C4 Offset: 0x20692C4 VA: 0x206D2C4
	public SkillType GetSkillType() { }

	// RVA: 0x206D2DC Offset: 0x20692DC VA: 0x206D2DC
	protected void ValidSkillParamFlag(SkillParamFlag flag) { }

	// RVA: 0x206D2EC Offset: 0x20692EC VA: 0x206D2EC
	protected void ValidSkillParamFlag(int flag) { }

	// RVA: 0x206D2FC Offset: 0x20692FC VA: 0x206D2FC
	public bool CheckSkillParamFlag(SkillParamFlag flag) { }

	// RVA: 0x206D30C Offset: 0x206930C VA: 0x206D30C
	public bool CheckSkillParamFlag(int flag) { }

	// RVA: 0x206D31C Offset: 0x206931C VA: 0x206D31C
	public bool CheckSkillIndividualFlag(int flag) { }

	// RVA: 0x206D32C Offset: 0x206932C VA: 0x206D32C
	public void OnCopyTemporarySkillBuffer(PlayerAttackBase sorce) { }

	// RVA: 0x206D36C Offset: 0x206936C VA: 0x206D36C Slot: 53
	protected override void OnEnd(bool cancel) { }

	// RVA: 0x206D3B8 Offset: 0x20693B8 VA: 0x206D3B8 Slot: 54
	protected override void OnMotionEnd() { }

	// RVA: 0x206D3EC Offset: 0x20693EC VA: 0x206D3EC
	public void RestoreDefalutlMotionSpeed() { }

	// RVA: 0x206AF48 Offset: 0x2066F48 VA: 0x206AF48 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x206D520 Offset: 0x2069520 VA: 0x206D520
	protected void ApplyAuraBlade(PlayerActionManagerBase playerAction) { }

	// RVA: 0x206D66C Offset: 0x206966C VA: 0x206D66C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x206DF8C Offset: 0x2069F8C VA: 0x206DF8C
	protected void SetSendAtkParam(PlayerActionManagerBase playerAction) { }

	// RVA: 0x206E81C Offset: 0x206A81C VA: 0x206E81C
	protected void RemoveAfterSkillBuf(PlayerActionManagerBase playerAct) { }

	// RVA: 0x206E4B4 Offset: 0x206A4B4 VA: 0x206E4B4
	protected void ActionStartMagicSkill(PlayerActionManagerBase playerAction) { }

	// RVA: 0x206F03C Offset: 0x206B03C VA: 0x206F03C
	protected void RemoveUnannouncedDestinationBuf(PlayerActionManagerBase playerAction) { }

	// RVA: 0x206F3E0 Offset: 0x206B3E0 VA: 0x206F3E0
	private void RegistChronosShift(PlayerActionManagerBase playerAction) { }

	// RVA: 0x206F6AC Offset: 0x206B6AC VA: 0x206F6AC Slot: 80
	public virtual void AttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x206F6B4 Offset: 0x206B6B4 VA: 0x206F6B4 Slot: 81
	public virtual void SupportStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x206F6B8 Offset: 0x206B6B8 VA: 0x206F6B8 Slot: 82
	public virtual void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x206F6C4 Offset: 0x206B6C4 VA: 0x206F6C4 Slot: 83
	public virtual void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x206F880 Offset: 0x206B880 VA: 0x206F880
	protected static ItemDBData.ItemType GetWeaponType(PlayerActionManagerBase playerAction) { }

	// RVA: 0x206F92C Offset: 0x206B92C VA: 0x206F92C
	protected static ItemDBData.ItemType GetWeaponType(PlayerActionManagerBase playerAction, out ItemData item) { }

	// RVA: 0x206FA08 Offset: 0x206BA08 VA: 0x206FA08
	protected static ItemDBData.ItemType GetSubWeaponType(PlayerActionManagerBase playerAction) { }

	// RVA: 0x206FAB4 Offset: 0x206BAB4 VA: 0x206FAB4
	protected static ItemDBData.ItemType GetSubWeaponType(PlayerActionManagerBase playerAction, out ItemData item) { }

	// RVA: 0x206FB90 Offset: 0x206BB90 VA: 0x206FB90
	protected static bool ExistWeaponType(PlayerActionManagerBase playerAction, ItemDBData.ItemType type) { }

	// RVA: 0x206FC94 Offset: 0x206BC94 VA: 0x206FC94
	protected static bool ExistWeaponType(PlayerActionManagerBase playerAction, ItemDBData.ItemType type, out ItemData item) { }

	// RVA: 0x206FDC0 Offset: 0x206BDC0 VA: 0x206FDC0
	protected static float GetWeaponRange(ItemData weapon) { }

	// RVA: 0x206FDEC Offset: 0x206BDEC VA: 0x206FDEC
	protected float CalcCastTime(float baseTime, PlayerStatusBase status) { }

	// RVA: 0x206FFC8 Offset: 0x206BFC8 VA: 0x206FFC8
	protected static int CalcMotionSpeed(PlayerStatusBase status) { }

	// RVA: 0x20700FC Offset: 0x206C0FC VA: 0x20700FC
	protected void CalcMp(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2070140 Offset: 0x206C140 VA: 0x2070140
	protected int CalcCostMp(PlayerActionManagerBase playerAction) { }

	[CompilerGenerated]
	// RVA: 0x2070908 Offset: 0x206C908 VA: 0x2070908
	public PlayerAttackBase.CalcCostMpType get_CostMpType() { }

	[CompilerGenerated]
	// RVA: 0x2070910 Offset: 0x206C910 VA: 0x2070910
	private void set_CostMpType(PlayerAttackBase.CalcCostMpType value) { }

	// RVA: 0x2070918 Offset: 0x206C918 VA: 0x2070918 Slot: 84
	public virtual void RecalcCostMp(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2070980 Offset: 0x206C980 VA: 0x2070980 Slot: 85
	protected virtual bool CheckHit(PlayerStatusBase status, int needHit, int mp, bool isFlash, out bool correct) { }

	// RVA: 0x2070B38 Offset: 0x206CB38 VA: 0x2070B38
	protected bool ChackCorrectHit(PlayerStatusBase status, int hit, bool isFlash, out bool correct) { }

	// RVA: 0x2070E2C Offset: 0x206CE2C VA: 0x2070E2C
	protected static int CalcPowerResistDamage(PlayerStatusBase status, int targetDef, float addResist) { }

	// RVA: 0x2070EF8 Offset: 0x206CEF8 VA: 0x2070EF8
	protected static int CalcMagicResistDamage(PlayerStatusBase status, int targetMdef, float addResist) { }

	// RVA: 0x2070FC4 Offset: 0x206CFC4 VA: 0x2070FC4
	protected float CalcElementBonus(PlayerStatusBase status, SkillAttackType attackType, ElementType targetType, out bool weak) { }

	// RVA: 0x2071434 Offset: 0x206D434 VA: 0x2071434
	protected float CalcElementBonus(PlayerStatusBase status, SkillAttackType attackType, ElementType playerType, ElementType targetType, out bool weak) { }

	// RVA: 0x2071328 Offset: 0x206D328 VA: 0x2071328
	private static int CalcElementKillerBonus(PlayerStatusBase status, ElementType targetElement) { }

	// RVA: 0x2071790 Offset: 0x206D790 VA: 0x2071790
	protected static float CalcNormalElementWeaponDamageResistRate(PlayerStatusBase status, MobActionManagerBase mobAction) { }

	// RVA: 0x2071958 Offset: 0x206D958 VA: 0x2071958
	protected static float CalcDistanceResistRate(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2071A48 Offset: 0x206DA48 VA: 0x2071A48
	protected static float CalcSkillTypeBonusRate(PlayerStatusBase playerStatus, BonusType attackTypeBonus, BonusType skillTypeBonus) { }

	// RVA: 0x2071AE0 Offset: 0x206DAE0 VA: 0x2071AE0
	protected float CalcLastDamageRate(PlayerStatusBase playerStatus, SkillAttackType attackType) { }

	// RVA: 0x20721E8 Offset: 0x206E1E8 VA: 0x20721E8
	protected float CalcBufferLastDamageRate(PlayerStatusBase playerStatus) { }

	// RVA: 0x20723F0 Offset: 0x206E3F0 VA: 0x20723F0
	protected float CalcCobmoRate() { }

	// RVA: 0x207243C Offset: 0x206E43C VA: 0x207243C
	protected float CalcDoubleThrowLastDamageRate(PlayerStatusBase status) { }

	// RVA: 0x2072BA0 Offset: 0x206EBA0 VA: 0x2072BA0 Slot: 37
	protected sealed override void InitializeElement(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2072CE0 Offset: 0x206ECE0 VA: 0x2072CE0
	protected ElementType GetWeaponElementType(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2071C8C Offset: 0x206DC8C VA: 0x2071C8C
	protected float CalcSkillMasteryLastDamageRate(PlayerStatusBase playerStatus, SkillAttackType attackType) { }

	// RVA: 0x20721E0 Offset: 0x206E1E0 VA: 0x20721E0
	protected float CalcWeaponCharacteristicsLastDamageRate(PlayerStatusBase status, SkillAttackType attackType) { }

	// RVA: 0x2072604 Offset: 0x206E604 VA: 0x2072604
	private float CalcBonusLastDamageRate(PlayerStatusBase playerStatus) { }

	// RVA: 0x2072E08 Offset: 0x206EE08 VA: 0x2072E08
	protected float CalcGemLastDamageRate(PlayerStatusBase playerStatus) { }

	// RVA: 0x2072EB0 Offset: 0x206EEB0 VA: 0x2072EB0
	protected bool checkRangeHeight(float dy, float _size) { }

	// RVA: 0x2072ED8 Offset: 0x206EED8 VA: 0x2072ED8
	protected bool cheakRangeAngle(Vector3 _actor_position, Vector3 _target_position) { }

	// RVA: 0x207304C Offset: 0x206F04C VA: 0x207304C
	protected SkillDamageData createMultiHitDamage(SkillActionBase.DamageData damageData, int damage) { }

	// RVA: 0x2073134 Offset: 0x206F134 VA: 0x2073134
	protected List<SkillDamageData> createExcetraDamage(SkillActionBase.DamageData data, int damage, SkillHitType hitType, SkillHitReactionType reactionType, int damageCount) { }

	// RVA: 0x20733B0 Offset: 0x206F3B0 VA: 0x20733B0 Slot: 86
	protected virtual int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x2073D58 Offset: 0x206FD58 VA: 0x2073D58
	protected static bool CheckSpecificWeaponBaseDamageRate(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, out float rate) { }

	// RVA: 0x2073EF8 Offset: 0x206FEF8 VA: 0x2073EF8
	protected static int calcBaseDamage(int atk, int lv, int targetLv, int cut, float mobPropCut) { }

	// RVA: 0x2073E9C Offset: 0x206FE9C VA: 0x2073E9C
	protected static int calcDualBaseDamage(int mainAtk, int subAtk, int subStable, int lv, int targetLv, int cut, float mobPropCut) { }

	// RVA: 0x2073F40 Offset: 0x206FF40 VA: 0x2073F40
	protected int calcFastAttackDamage(PlayerActionManagerBase action) { }

	// RVA: 0x2074014 Offset: 0x2070014 VA: 0x2074014
	protected static int calcFastAttackDamageRate(PlayerActionManagerBase action) { }

	// RVA: 0x2074238 Offset: 0x2070238 VA: 0x2074238
	protected static float GetSpecificWeaponLastDamageRate(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2074378 Offset: 0x2070378 VA: 0x2074378
	protected SkillCalcTemplate TemplateAssignment(SkillCalcTemplate template, PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType SkillType, SkillTreeType TreeType, int addRegist, bool isCritical) { }

	// RVA: 0x2074380 Offset: 0x2070380 VA: 0x2074380
	protected SkillCalcTemplate TemplateAssignment(SkillCalcTemplate template, PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType SkillType, SkillTreeType TreeType, int addRegist, bool isCritical, bool isSecureHit) { }

	// RVA: 0x207439C Offset: 0x207039C VA: 0x207439C
	protected SkillCalcTemplate TemplateAssignment(SkillCalcTemplate template, PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType SkillType, SkillTreeType TreeType, int addRegist, PlayerAttackBase.HitState hitState) { }

	// RVA: 0x206BBB0 Offset: 0x2067BB0 VA: 0x206BBB0
	protected SkillCalcTemplate TemplateAssignment(SkillCalcTemplate template, PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType attackType, SkillTreeType TreeType, int addRegist) { }

	// RVA: 0x206C8D0 Offset: 0x20688D0 VA: 0x206C8D0
	protected SkillActionBase.DamageData templateToDamageData(SkillActionBase.DamageData damageData, SkillCalcTemplate template, int damageCount) { }

	// RVA: 0x20756FC Offset: 0x20716FC VA: 0x20756FC
	protected SkillActionBase.DamageData templateToDamageData(SkillActionBase.DamageData damageData, IEnumerable<SkillCalcTemplate> templateList) { }

	// RVA: 0x2075EBC Offset: 0x2071EBC VA: 0x2075EBC
	protected SkillActionBase.DamageData CreateDummyDamageData(MobActionManagerBase mobAction) { }

	// RVA: 0x2074538 Offset: 0x2070538 VA: 0x2074538
	public SkillCalcTemplate HitReactionAssign(SkillCalcTemplate template, PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType attackType, bool isCritical, bool igoneAvoid = False, bool igoneGuard = False) { }

	// RVA: 0x2076EA8 Offset: 0x2072EA8 VA: 0x2076EA8
	protected void SetBufferConstantDamage(SkillCalcTemplate template, int damageCount) { }

	// RVA: 0x2074DBC Offset: 0x2070DBC VA: 0x2074DBC
	protected int CalcRegistDamage(SkillAttackType type, PlayerStatusBase playerStatus, IMobStatusCalculator mobStatus, float addRegistvalue) { }

	// RVA: 0x2076F24 Offset: 0x2072F24 VA: 0x2076F24 Slot: 87
	protected virtual float CalcStable(SkillAttackType type, int stableSource, bool correctHit, PlayerStatusBase status) { }

	// RVA: 0x2077184 Offset: 0x2073184 VA: 0x2077184 Slot: 88
	public virtual AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x20771C8 Offset: 0x20731C8 VA: 0x20771C8 Slot: 89
	public virtual void CheckAbnormalSubEffect(AbnormalType abnormalType, GameObject actor) { }

	// RVA: 0x2075FC4 Offset: 0x2071FC4 VA: 0x2075FC4
	protected SkillHitReactionType CalcHitReaction(SkillAttackType attackType, PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, out SkillHitReactionType resistReactionType) { }

	// RVA: 0x206BB5C Offset: 0x2067B5C VA: 0x206BB5C
	protected SkillHitReactionType checkMobReaction(int guard, int avoid) { }

	// RVA: 0x20771D8 Offset: 0x20731D8 VA: 0x20771D8
	public static void ViewPreventedHitReactionIcon(SkillHitReactionType reactionType, Vector3 pos, int equipType, int mainWeaponType, int subWeaponType) { }

	// RVA: 0x2077340 Offset: 0x2073340 VA: 0x2077340
	public static void ViewPreventedHitReactionIconToGemCart(SkillHitReactionType reactionType, Vector3 pos) { }

	// RVA: 0x207740C Offset: 0x207340C VA: 0x207740C
	protected SkillCalcTemplate CopyHitReaction(SkillCalcTemplate sourceTemplate, SkillCalcTemplate destTemplate) { }

	// RVA: 0x206D448 Offset: 0x2069448 VA: 0x206D448
	public static bool ContainsNotApplicableSkill(int skillId) { }

	// RVA: 0x206D43C Offset: 0x206943C VA: 0x206D43C
	protected bool IsBlank() { }

	// RVA: 0x207501C Offset: 0x207101C VA: 0x207501C
	public bool CheckPlayerDamageUpLimit(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, out int limitDamage) { }

	// RVA: 0x2077498 Offset: 0x2073498 VA: 0x2077498
	public int CalcPlayerDamageUpLimit(int baseDamage, PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2075224 Offset: 0x2071224 VA: 0x2075224
	public bool CheckDamageLimit(MobActionManagerBase mobAction, out int min, out int max) { }

	// RVA: 0x207769C Offset: 0x207369C VA: 0x207769C
	public int GetLimitDamage(int baseDamage, MobActionManagerBase mobAction, out bool isMinDamage, out bool isMaxDamage) { }

	// RVA: 0x2075588 Offset: 0x2071588 VA: 0x2075588
	public bool CheckAbnormalDamageIncrease(MobActionManagerBase mobAction, out float rate) { }

	// RVA: 0x2077744 Offset: 0x2073744 VA: 0x2077744
	protected bool checkAbnormalPercent(AbnormalType abnormalType, int per, PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, out float addResistTime) { }

	// RVA: 0x2077CB4 Offset: 0x2073CB4 VA: 0x2077CB4
	protected bool checkCriticalPercent(int criticalParcent, MobActionManagerBase mobAction) { }

	// RVA: 0x2077DCC Offset: 0x2073DCC VA: 0x2077DCC
	protected bool CheckMagicCritical(PlayerStatusBase playerStatus, MobActionManagerBase mobAction) { }

	// RVA: 0x2077EA8 Offset: 0x2073EA8 VA: 0x2077EA8
	protected bool CheckMagicCritical(int baseCritical, PlayerStatusBase status, MobActionManagerBase mobAction) { }

	// RVA: 0x2078380 Offset: 0x2074380 VA: 0x2078380
	protected float CalcDistanceToTarget(Vector3 actorPos, Vector3 mobTargetPos, float mobSize) { }

	// RVA: 0x2078498 Offset: 0x2074498 VA: 0x2078498
	public bool CheckGemCartEmergencyMpRecovery(PlayerStatusBase status) { }

	// RVA: 0x20785D0 Offset: 0x20745D0 VA: 0x20785D0
	public bool CheckEnchantedSpellMpLessInvoke(PlayerStatusBase status) { }

	// RVA: 0x207881C Offset: 0x207481C VA: 0x207881C
	private void MagicCannonCharge(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2072D88 Offset: 0x206ED88 VA: 0x2072D88
	protected bool CheckLongRangeAttack() { }

	// RVA: 0x2078BD8 Offset: 0x2074BD8 VA: 0x2078BD8 Slot: 65
	public override void PopSkillNameLabel() { }

	// RVA: 0x2078D58 Offset: 0x2074D58 VA: 0x2078D58 Slot: 66
	public override string GetLocalizeKey(byte element) { }

	// RVA: 0x2078D6C Offset: 0x2074D6C VA: 0x2078D6C Slot: 90
	public virtual string GetLocalizeKey(byte element, int skillIndividualFlag) { }

	// RVA: 0x2078D74 Offset: 0x2074D74 VA: 0x2078D74
	protected bool CheckMobActionUnobstructable(MobActionManagerBase mobAction) { }

	// RVA: 0x2078EAC Offset: 0x2074EAC VA: 0x2078EAC
	public static int GetElementKillerBonus(PlayerStatusBase status, ElementType targetElement) { }

	// RVA: 0x2073390 Offset: 0x206F390 VA: 0x2073390
	protected short GetNextDamageLocalId() { }

	// RVA: 0x2073088 Offset: 0x206F088 VA: 0x2073088
	protected short[] GetNextDamageLocalIds(int count) { }
}

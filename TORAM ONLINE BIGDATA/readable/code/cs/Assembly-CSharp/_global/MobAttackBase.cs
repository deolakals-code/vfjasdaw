// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class MobAttackBase : SkillActionBase // TypeDefIndex: 1135
{
	// Fields
	[CompilerGenerated]
	private MobActionPattern <MasterActionPattern>k__BackingField; // 0xA0
	[CompilerGenerated]
	private MobPatternBase <MobPattern>k__BackingField; // 0xA8
	[CompilerGenerated]
	private MobAttackCategory <AttackCategory>k__BackingField; // 0xB0
	[CompilerGenerated]
	private MobAttackBase.AttackStartFlag <StartFlag>k__BackingField; // 0xB4
	[CompilerGenerated]
	private long <PersonaTarget>k__BackingField; // 0xB8
	protected static readonly MobActionType[] DisableTypeList; // 0x0
	private short difficulty; // 0xC0
	private bool isRange; // 0xC2
	private bool isSupport; // 0xC3
	protected int stoneSkinCutValue; // 0xC4
	protected bool earthStyleDamageCut; // 0xC8
	protected int arkSaberMpDamage; // 0xCC
	protected int geoImpactUseBarrier; // 0xD0
	protected bool illusionarySceneDamageCut; // 0xD4
	protected bool tornadoLanceFree; // 0xD5
	protected int knightPladge; // 0xD8
	protected int barrierScreenReduceDamageValue; // 0xDC

	// Properties
	public override int ActionID { get; }
	public override int Mp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }
	public MobActionPattern MasterActionPattern { get; set; }
	public MobPatternBase MobPattern { get; set; }
	public MobAttackCategory AttackCategory { get; set; }
	public MobAttackBase.AttackStartFlag StartFlag { get; set; }
	public long PersonaTarget { get; set; }
	public bool IsNormalAttack { get; }

	// Methods

	// RVA: 0x1F503E4 Offset: 0x1F4C3E4 VA: 0x1F503E4 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x1F50400 Offset: 0x1F4C400 VA: 0x1F50400 Slot: 22
	public override int get_Mp() { }

	// RVA: 0x1F50408 Offset: 0x1F4C408 VA: 0x1F50408 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x1F50410 Offset: 0x1F4C410 VA: 0x1F50410 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x1F50418 Offset: 0x1F4C418 VA: 0x1F50418 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x1F50420 Offset: 0x1F4C420 VA: 0x1F50420 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x1F50428 Offset: 0x1F4C428 VA: 0x1F50428 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x1F50430 Offset: 0x1F4C430 VA: 0x1F50430 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x1F50438 Offset: 0x1F4C438 VA: 0x1F50438 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x1F50440 Offset: 0x1F4C440 VA: 0x1F50440 Slot: 15
	public override bool get_IsSupport() { }

	[CompilerGenerated]
	// RVA: 0x1F50448 Offset: 0x1F4C448 VA: 0x1F50448
	public MobActionPattern get_MasterActionPattern() { }

	[CompilerGenerated]
	// RVA: 0x1F50450 Offset: 0x1F4C450 VA: 0x1F50450
	protected void set_MasterActionPattern(MobActionPattern value) { }

	[CompilerGenerated]
	// RVA: 0x1F50458 Offset: 0x1F4C458 VA: 0x1F50458
	public MobPatternBase get_MobPattern() { }

	[CompilerGenerated]
	// RVA: 0x1F50460 Offset: 0x1F4C460 VA: 0x1F50460
	private void set_MobPattern(MobPatternBase value) { }

	[CompilerGenerated]
	// RVA: 0x1F50468 Offset: 0x1F4C468 VA: 0x1F50468
	public MobAttackCategory get_AttackCategory() { }

	[CompilerGenerated]
	// RVA: 0x1F50470 Offset: 0x1F4C470 VA: 0x1F50470
	private void set_AttackCategory(MobAttackCategory value) { }

	[CompilerGenerated]
	// RVA: 0x1F50478 Offset: 0x1F4C478 VA: 0x1F50478
	public MobAttackBase.AttackStartFlag get_StartFlag() { }

	[CompilerGenerated]
	// RVA: 0x1F50480 Offset: 0x1F4C480 VA: 0x1F50480
	private void set_StartFlag(MobAttackBase.AttackStartFlag value) { }

	[CompilerGenerated]
	// RVA: 0x1F50488 Offset: 0x1F4C488 VA: 0x1F50488
	public long get_PersonaTarget() { }

	[CompilerGenerated]
	// RVA: 0x1F50490 Offset: 0x1F4C490 VA: 0x1F50490
	private void set_PersonaTarget(long value) { }

	// RVA: 0x1F50498 Offset: 0x1F4C498 VA: 0x1F50498
	public bool get_IsNormalAttack() { }

	// RVA: 0x1F504B4 Offset: 0x1F4C4B4 VA: 0x1F504B4
	protected void .ctor() { }

	// RVA: 0x1F504D4 Offset: 0x1F4C4D4 VA: 0x1F504D4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x1F504D8 Offset: 0x1F4C4D8 VA: 0x1F504D8
	public void ValidAttackStartFlag(MobAttackBase.AttackStartFlag flag) { }

	// RVA: 0x1F504E8 Offset: 0x1F4C4E8 VA: 0x1F504E8
	public void InvalidAttackStartFlag(MobAttackBase.AttackStartFlag flag) { }

	// RVA: 0x1F504F8 Offset: 0x1F4C4F8 VA: 0x1F504F8
	public void Initialize(MobActionPattern pattern, MobStatusMaster status, short difficulty) { }

	// RVA: 0x1F508B8 Offset: 0x1F4C8B8 VA: 0x1F508B8
	public void SetMobPattern(MobPatternBase mobPattern) { }

	// RVA: 0x1F508C0 Offset: 0x1F4C8C0 VA: 0x1F508C0 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x1F508EC Offset: 0x1F4C8EC VA: 0x1F508EC Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x1F5095C Offset: 0x1F4C95C VA: 0x1F5095C
	protected void CalcHit(SkillActionBase.DamageData damageData, MobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F51298 Offset: 0x1F4D298 VA: 0x1F51298
	private bool CheckCriticalPercent(MobActionManagerBase mobAction) { }

	// RVA: 0x1F5203C Offset: 0x1F4E03C VA: 0x1F5203C
	protected int CalcCriticalPercent(MobActionManagerBase mobAction) { }

	// RVA: 0x1F52058 Offset: 0x1F4E058 VA: 0x1F52058
	protected int CalcCriticalPercent(MobActionManagerBase mobAction, int baseCriticalPercent) { }

	// RVA: 0x1F5223C Offset: 0x1F4E23C VA: 0x1F5223C
	protected int CalcCriticalDamage(MobActionManagerBase mobAction) { }

	// RVA: 0x1F52258 Offset: 0x1F4E258 VA: 0x1F52258
	protected int CalcCriticalDamage(MobActionManagerBase mobAction, int baseCriticalDamage) { }

	// RVA: 0x1F523E4 Offset: 0x1F4E3E4 VA: 0x1F523E4
	protected bool CheckCritical(int percent) { }

	// RVA: 0x1F51AEC Offset: 0x1F4DAEC VA: 0x1F51AEC
	protected bool checkHit(int mobFlee, int flee, int reduce) { }

	// RVA: 0x1F514DC Offset: 0x1F4D4DC VA: 0x1F514DC
	protected bool checkHighRaidHit(MobActionManagerBase mobAction, int flee, int reduce) { }

	// RVA: 0x1F518F8 Offset: 0x1F4D8F8 VA: 0x1F518F8
	protected bool checkScoreAttackHit(MobActionManagerBase mobAction, float necessaryFleePercent, int flee, int reduce) { }

	// RVA: 0x1F523F4 Offset: 0x1F4E3F4 VA: 0x1F523F4
	protected float CalcStable(MobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F525F0 Offset: 0x1F4E5F0 VA: 0x1F525F0
	protected float CalcStableRate(MobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F52614 Offset: 0x1F4E614 VA: 0x1F52614
	protected float CalcStableRate(int baseStable, MobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F5283C Offset: 0x1F4E83C VA: 0x1F5283C
	protected float calcEquipDefPercent(float eqDef) { }

	// RVA: 0x1F52854 Offset: 0x1F4E854 VA: 0x1F52854
	protected int calcResistDamage(int damage, int resistVal) { }

	// RVA: 0x1F52A04 Offset: 0x1F4EA04 VA: 0x1F52A04
	protected int calcResistDamage(int damage, float resistVal) { }

	// RVA: 0x1F52BC8 Offset: 0x1F4EBC8 VA: 0x1F52BC8
	protected BonusType getElementShield(ElementType element) { }

	// RVA: 0x1F52BE4 Offset: 0x1F4EBE4 VA: 0x1F52BE4
	protected int calcElementResistDamage(int damage, int resistVal) { }

	// RVA: 0x1F52D94 Offset: 0x1F4ED94 VA: 0x1F52D94
	protected int CalcSkillComboTough(PlayerActionManagerBase playerAction, int damage) { }

	// RVA: 0x1F53048 Offset: 0x1F4F048 VA: 0x1F53048
	protected int CalcLastDamage(MobActionManagerBase mobAction, PlayerActionManagerBase playerAction, int damage, SkillHitReactionType hitReactionType, bool allowBuffChanges = True) { }

	// RVA: 0x1F55834 Offset: 0x1F51834 VA: 0x1F55834 Slot: 67
	public virtual bool CheckPercentageDamage() { }

	// RVA: 0x1F55854 Offset: 0x1F51854 VA: 0x1F55854 Slot: 68
	public virtual bool CheckActionType(MobActionType[] actionTypes) { }

	// RVA: 0x1F558C4 Offset: 0x1F518C4 VA: 0x1F558C4
	protected int CalcBarrier(int damage, PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x1F55B1C Offset: 0x1F51B1C VA: 0x1F55B1C
	protected int CalcMobaBonusDamageResist(int damage, PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F51AD0 Offset: 0x1F4DAD0 VA: 0x1F51AD0
	protected int CalcFlee() { }

	// RVA: 0x1F55F5C Offset: 0x1F51F5C VA: 0x1F55F5C
	protected int CalcFlee(int flee) { }

	// RVA: 0x1F55FC8 Offset: 0x1F51FC8 VA: 0x1F55FC8
	protected int CalcBaseAttack(CharacterActionManagerBase actarAction) { }

	// RVA: 0x1F56888 Offset: 0x1F52888 VA: 0x1F56888
	protected int CalcHighRaidMonsterBaseAttack(MobActionType actionType, int baseAttack, MobActionManagerBase mobAction) { }

	// RVA: 0x1F565D0 Offset: 0x1F525D0 VA: 0x1F565D0
	protected int CalcScoreAttackBossBaseAttack(MobActionType actionType, int baseAttack, MobActionManagerBase mobAction) { }

	// RVA: 0x1F56D68 Offset: 0x1F52D68 VA: 0x1F56D68
	protected float GetMobPatternSpecialDamegeRate() { }

	// RVA: 0x1F56D80 Offset: 0x1F52D80 VA: 0x1F56D80
	public int GetSupportValue() { }

	// RVA: 0x1F56DC4 Offset: 0x1F52DC4 VA: 0x1F56DC4
	public float GetDistDamageRegistRate(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x1F51B5C Offset: 0x1F4DB5C VA: 0x1F51B5C
	protected bool AbsoluteFree(PlayerActionManagerBase playerAction, SkillHitType type, ref bool hit) { }

	// RVA: 0x1F57070 Offset: 0x1F53070 VA: 0x1F57070
	protected void CreateFamiliaDamageData(FamiliaActionManager familiaAction) { }

	// RVA: 0x1F57290 Offset: 0x1F53290 VA: 0x1F57290
	protected int CalcUnavoidableAttack(MobActionManagerBase mobAction, PlayerActionManagerBase playerAction, SkillActionBase.DamageData damageData, out int guardPower, out bool justGuard) { }

	// RVA: 0x1F57778 Offset: 0x1F53778 VA: 0x1F57778
	protected int CreateFixDamage(int baseDamage, MobActionManagerBase mobAction, PlayerActionManagerBase playerAction, SkillActionBase.DamageData damageData, out int guardPower, out bool justGuard) { }

	// RVA: -1 Offset: -1 Slot: 69
	public abstract int CalcTemporaryDamage(EnemyMobActionManagerBase mobAction, PlayerActionManagerBase playerAction);

	// RVA: 0x1F57B18 Offset: 0x1F53B18 VA: 0x1F57B18
	protected void SetAbnormalEffect(SkillDamageData skillDamageData, PlayerStatusBase status, int guardPower, bool justGuard) { }

	// RVA: 0x1F57B48 Offset: 0x1F53B48 VA: 0x1F57B48
	protected void SetAbnormalEffect(SkillDamageData skillDamageData, PlayerStatusBase status, int guardPower, bool justGuard, AbnormalType baseAbnormalType, int baseAbnormalPercent, int abnormalEffectTime) { }

	// RVA: 0x1F584CC Offset: 0x1F544CC VA: 0x1F584CC
	protected int GetMobPatternAbnormalPercent() { }

	// RVA: 0x1F584E4 Offset: 0x1F544E4 VA: 0x1F584E4
	protected void setAbnormalEffect(SkillDamageData skillDamageData) { }

	// RVA: 0x1F585B4 Offset: 0x1F545B4 VA: 0x1F585B4
	protected int GetActionTypeResist(PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F58774 Offset: 0x1F54774 VA: 0x1F58774
	public int GetLimitDamage(int baseDamage, MobActionManagerBase mobAction, out bool isMinDamage, out bool isMaxDamage) { }

	// RVA: 0x1F58808 Offset: 0x1F54808 VA: 0x1F58808
	public bool CheckDamageLimit(MobActionManagerBase mobAction, out int min, out int max) { }

	// RVA: 0x1F58D00 Offset: 0x1F54D00 VA: 0x1F58D00
	public bool CheckAbnormalDamageIncrease(MobActionManagerBase mobAction, out float rate) { }

	// RVA: 0x1F58E70 Offset: 0x1F54E70 VA: 0x1F58E70
	protected float CalcElementBonus(MobStatus status, ElementType targetType) { }

	// RVA: 0x1F58EF0 Offset: 0x1F54EF0 VA: 0x1F58EF0
	protected SkillHitReactionType checkMobReaction(int guard, int avoid) { }

	// RVA: 0x1F51EA8 Offset: 0x1F4DEA8 VA: 0x1F51EA8
	protected bool CheckUnavoidable(PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F58F44 Offset: 0x1F54F44 VA: 0x1F58F44 Slot: 70
	protected virtual bool CheckGuard(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, int damage, out SkillHitReactionType guardType, out bool justGuard) { }

	// RVA: 0x1F574D8 Offset: 0x1F534D8 VA: 0x1F574D8
	protected int CalcGuard(int damage, PlayerActionManagerBase playerAction, out int guardPower) { }

	// RVA: 0x1F590C8 Offset: 0x1F550C8 VA: 0x1F590C8
	protected void FinawGuard(SkillDamageData damageData, int guardPower) { }

	// RVA: 0x1F59164 Offset: 0x1F55164 VA: 0x1F59164 Slot: 71
	protected virtual bool CheckAvoid(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x1F59258 Offset: 0x1F55258 VA: 0x1F59258
	protected static BonusType GetBarrierType(MobAttackBase mobAttack) { }

	// RVA: 0x1F575D8 Offset: 0x1F535D8 VA: 0x1F575D8
	protected static SkillBufferDataBase GetBarrierBuf(MobAttackBase mobAttack, PlayerStatusBase status) { }

	// RVA: 0x1F5938C Offset: 0x1F5538C VA: 0x1F5938C
	public bool CheckAIRetreatAttack(AutoMemberAIRetreat aiRetreat) { }

	// RVA: 0x1F57944 Offset: 0x1F53944 VA: 0x1F57944
	protected bool InvalidDamage(PlayerActionManagerBase playerAction) { }

	// RVA: 0x1F59624 Offset: 0x1F55624 VA: 0x1F59624
	public bool CheckMainTarget(GameObject target) { }

	// RVA: 0x1F59638 Offset: 0x1F55638 VA: 0x1F59638
	public void SetPersonaTarget(byte archetypeType, int archetypeId) { }

	// RVA: 0x1F5964C Offset: 0x1F5564C VA: 0x1F5964C
	public void SetPersonaTarget(long target) { }

	// RVA: 0x1F59654 Offset: 0x1F55654 VA: 0x1F59654
	public void EffectiveBarrierScreen(BarrierScreenAction barrierScreen) { }

	// RVA: 0x1F596A0 Offset: 0x1F556A0 VA: 0x1F596A0
	private static void .cctor() { }
}

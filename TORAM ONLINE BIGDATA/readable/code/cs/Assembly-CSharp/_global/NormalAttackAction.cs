// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NormalAttackAction : PlayerAttackBase, ISwordMove // TypeDefIndex: 1505
{
	// Fields
	[CompilerGenerated]
	private bool <IsSwordMoveStart>k__BackingField; // 0x120
	public const int PairOfShieldsTakeId = 202093000;
	public const int PairOfShieldsPowerWaveTakeId = 202093001;
	public const int TwinStormTakeId = 200516000;
	protected int damageCount; // 0x124
	private float defaultRange; // 0x128
	private float powerWaveRate; // 0x12C
	private bool powerWaveEnable; // 0x130
	private SkillMasteryBase powerWaveMastery; // 0x138
	protected bool isUnsheatheMode; // 0x140
	private List<int[]> passiveList; // 0x148
	private ItemDBData.ItemType subWeaponType; // 0x150
	private bool isInterruptable; // 0x154
	private bool isMoveEventIgnone; // 0x155
	private SheatheMove sheatheMove; // 0x158
	private short sheatheMoveEventCounter; // 0x160
	private int subRange; // 0x164
	private bool checkSamuraiArchery; // 0x168
	private int twinStormEffectColorR; // 0x16C
	private int twinStormEffectColorG; // 0x170
	private bool checkTwinStorm; // 0x174
	private bool checkUnannouncedDestination; // 0x175
	private bool checkIchijhinnokaze; // 0x176
	private IchijhinnokazeBuf.AttackMode ichijhinnokazeAttackMode; // 0x178
	private byte ichijhinnokazeLevel; // 0x17C
	private SkillCalcTemplate calcTemplate; // 0x180
	private float orgaslashBonusSkillRate; // 0x188
	private int orgaslashBonusResistBreaker; // 0x18C

	// Properties
	public override int ActionID { get; }
	public override bool NoCost { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override bool IsEventIgnoreOther { get; }
	public override bool IsExpDefFluctuate { get; }
	public List<int[]> PassiveList { get; }
	public bool IsKnifeCombat { get; }
	private bool IsRampage { get; }
	public bool IsEarthShattering { get; }
	public bool IsSwordMoveStart { get; set; }

	// Methods

	// RVA: 0x2063930 Offset: 0x205F930 VA: 0x2063930 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2063938 Offset: 0x205F938 VA: 0x2063938 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x2063940 Offset: 0x205F940 VA: 0x2063940 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2063948 Offset: 0x205F948 VA: 0x2063948 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2063950 Offset: 0x205F950 VA: 0x2063950 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2063958 Offset: 0x205F958 VA: 0x2063958 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2063960 Offset: 0x205F960 VA: 0x2063960 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2063968 Offset: 0x205F968 VA: 0x2063968 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2063970 Offset: 0x205F970 VA: 0x2063970 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2063978 Offset: 0x205F978 VA: 0x2063978 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2063980 Offset: 0x205F980 VA: 0x2063980 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x2063990 Offset: 0x205F990 VA: 0x2063990 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2063998 Offset: 0x205F998 VA: 0x2063998 Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x20639A0 Offset: 0x205F9A0 VA: 0x20639A0 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x20639CC Offset: 0x205F9CC VA: 0x20639CC
	public List<int[]> get_PassiveList() { }

	// RVA: 0x20639C0 Offset: 0x205F9C0 VA: 0x20639C0
	public bool get_IsKnifeCombat() { }

	// RVA: 0x20639D4 Offset: 0x205F9D4 VA: 0x20639D4
	private bool get_IsRampage() { }

	// RVA: 0x20639E4 Offset: 0x205F9E4 VA: 0x20639E4
	public bool get_IsEarthShattering() { }

	[CompilerGenerated]
	// RVA: 0x20639F0 Offset: 0x205F9F0 VA: 0x20639F0 Slot: 91
	public bool get_IsSwordMoveStart() { }

	[CompilerGenerated]
	// RVA: 0x20639F8 Offset: 0x205F9F8 VA: 0x20639F8
	private void set_IsSwordMoveStart(bool value) { }

	// RVA: 0x2063A04 Offset: 0x205FA04 VA: 0x2063A04 Slot: 36
	public override void UnsheatheWeaponAction() { }

	// RVA: 0x2063C50 Offset: 0x205FC50 VA: 0x2063C50 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x205D128 Offset: 0x2059128 VA: 0x205D128 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x205DFF4 Offset: 0x2059FF4 VA: 0x205DFF4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2064E78 Offset: 0x2060E78 VA: 0x2064E78 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x206524C Offset: 0x206124C VA: 0x206524C Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x2065300 Offset: 0x2061300 VA: 0x2065300 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2065450 Offset: 0x2061450 VA: 0x2065450 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x20659A8 Offset: 0x20619A8 VA: 0x20659A8 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2065C20 Offset: 0x2061C20 VA: 0x2065C20
	public void PrevActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x205E0F0 Offset: 0x205A0F0 VA: 0x205E0F0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x205E3A0 Offset: 0x205A3A0 VA: 0x205E3A0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x206A1D8 Offset: 0x20661D8 VA: 0x206A1D8 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x206A284 Offset: 0x2066284 VA: 0x206A284 Slot: 89
	public override void CheckAbnormalSubEffect(AbnormalType abnormalType, GameObject actor) { }

	// RVA: 0x206A404 Offset: 0x2066404 VA: 0x206A404
	public void Damaged(PlayerActionManagerBase playerActionManager, MobActionManagerBase mobActionManager, SkillDamageData damageData, bool isFirstAttack) { }

	// RVA: 0x20664E4 Offset: 0x20624E4 VA: 0x20664E4
	private int CalcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillHitType hitType) { }

	// RVA: 0x2066C6C Offset: 0x2062C6C VA: 0x2066C6C
	private int CalcDef(PlayerActionManagerBase playerAction, IMobStatusCalculator mobBattleStatus) { }

	// RVA: 0x206705C Offset: 0x206305C VA: 0x206705C
	private int CalcMercenaryDamage(PlayerActionManagerBase playerAction, int damage) { }

	// RVA: 0x20683F8 Offset: 0x20643F8 VA: 0x20683F8
	private void attachOneChanceDamage(PlayerActionManagerBase playerAct, MobActionManagerBase mobAct, bool correctHit, SkillHitReactionType reaction, SkillActionBase.DamageData damageData) { }

	// RVA: 0x2068294 Offset: 0x2064294 VA: 0x2068294
	private bool CheckOneChance(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2069290 Offset: 0x2065290 VA: 0x2069290
	private void attachSecondArmDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAct, bool correctHit, SkillHitReactionType reaction, SkillActionBase.DamageData damageData) { }

	// RVA: 0x2069110 Offset: 0x2065110 VA: 0x2069110
	private bool CheckSecondArm(PlayerActionManagerBase playerAction) { }

	// RVA: 0x20673B4 Offset: 0x20633B4 VA: 0x20673B4
	private int calcDualSwordDamage(int atk, PlayerActionManagerBase playerAct, MobActionManagerBase mobAct, bool correctHit, bool critical, bool guard, out bool subElementWeak) { }

	// RVA: 0x2067D64 Offset: 0x2063D64 VA: 0x2067D64
	private SkillActionBase.DamageData calcDualSwordDamageDate(int damageMain, int damageSub, int hitCount, SkillHitType hitType, SkillHitReactionType hitReactionType, bool correctHit, CharacterActionManagerBase target, bool isMaxDamage, bool isMinDamage, bool mainElementWeak, bool subElementWeak) { }

	// RVA: 0x2066B44 Offset: 0x2062B44 VA: 0x2066B44
	private int calcRampageConstantDamage(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2067194 Offset: 0x2063194 VA: 0x2067194
	private float calcRampageSkillRate(PlayerActionManagerBase playerAction, int attackStage = 0) { }

	// RVA: 0x2065E98 Offset: 0x2061E98 VA: 0x2065E98
	private void calcRampageFinish(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x20646BC Offset: 0x20606BC VA: 0x20646BC
	private bool PowerWaveCheck(CharacterActionManagerBase actar, CharacterActionManagerBase target) { }

	// RVA: 0x20647A0 Offset: 0x20607A0 VA: 0x20647A0
	private void SetPowerWaveTake(ItemDBData.ItemType weaponType, ItemDBData.ItemType subWeaponType) { }

	// RVA: 0x2065D60 Offset: 0x2061D60 VA: 0x2065D60
	private bool RampageHitCheck(PlayerActionManagerBase playerAction, bool hit) { }

	// RVA: 0x20649D0 Offset: 0x20609D0 VA: 0x20649D0
	private void SetEarthShatteringTake() { }

	// RVA: 0x206A884 Offset: 0x2066884 VA: 0x206A884
	public static int GetNormalAttackTake(ItemDBData.ItemType mainWeaponType, ItemDBData.ItemType subWeaponType) { }

	// RVA: 0x20645A8 Offset: 0x20605A8 VA: 0x20645A8
	public static int GetNormalAttackTake(ItemDBData.ItemType mainWeaponType, ItemDBData.ItemType subWeaponType, bool patternA, out int maxDamageCount) { }

	// RVA: 0x206A8C8 Offset: 0x20668C8 VA: 0x206A8C8
	public static bool IsNormalAttack(int skillId) { }

	// RVA: 0x20604BC Offset: 0x205C4BC VA: 0x20604BC
	public void .ctor() { }
}

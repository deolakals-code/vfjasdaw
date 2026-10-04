// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HorizontalCutAction : PlayerAttackBase // TypeDefIndex: 2629
{
	// Fields
	private int baseMp; // 0x120
	private float baseActionRange; // 0x124
	private int skillRate; // 0x128
	private int fixAddDamage; // 0x12C
	private int secondSkillRate; // 0x130
	private int secondFixDamage; // 0x134
	private bool isDualSword; // 0x138
	private bool isLongRangeAttack; // 0x139

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x2218020 Offset: 0x2214020 VA: 0x2218020 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2218028 Offset: 0x2214028 VA: 0x2218028 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2218030 Offset: 0x2214030 VA: 0x2218030 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2218038 Offset: 0x2214038 VA: 0x2218038 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2218040 Offset: 0x2214040 VA: 0x2218040 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2218048 Offset: 0x2214048 VA: 0x2218048 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2218050 Offset: 0x2214050 VA: 0x2218050 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2218058 Offset: 0x2214058 VA: 0x2218058 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2218060 Offset: 0x2214060 VA: 0x2218060 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x2218068 Offset: 0x2214068 VA: 0x2218068 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x221857C Offset: 0x221457C VA: 0x221857C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22186D4 Offset: 0x22146D4 VA: 0x22186D4 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22187BC Offset: 0x22147BC VA: 0x22187BC
	public void ChangeMpDuringCombo(PlayerActionManagerBase playerAction, SkillComboState combo) { }

	// RVA: 0x2218858 Offset: 0x2214858 VA: 0x2218858 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22189B4 Offset: 0x22149B4 VA: 0x22189B4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2218BF4 Offset: 0x2214BF4 VA: 0x2218BF4
	private SkillCalcTemplate calcFirstDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2218DBC Offset: 0x2214DBC VA: 0x2218DBC
	private SkillCalcTemplate calcSecondDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2218F84 Offset: 0x2214F84 VA: 0x2218F84
	public static void Damaged(PlayerActionManagerBase playerAction, GameObject actor, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x22194C0 Offset: 0x22154C0 VA: 0x22194C0
	public void .ctor() { }
}

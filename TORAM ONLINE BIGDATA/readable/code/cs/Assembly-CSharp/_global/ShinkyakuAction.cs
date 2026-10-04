// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShinkyakuAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2811
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int flinchPercent; // 0x128
	private int ignoreAvoidPercent; // 0x12C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x228509C Offset: 0x228109C VA: 0x228509C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22850A4 Offset: 0x22810A4 VA: 0x22850A4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22850AC Offset: 0x22810AC VA: 0x22850AC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22850B4 Offset: 0x22810B4 VA: 0x22850B4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22850BC Offset: 0x22810BC VA: 0x22850BC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22850C4 Offset: 0x22810C4 VA: 0x22850C4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22850CC Offset: 0x22810CC VA: 0x22850CC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22850D4 Offset: 0x22810D4 VA: 0x22850D4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22850DC Offset: 0x22810DC VA: 0x22850DC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2285440 Offset: 0x2281440 VA: 0x2285440 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22854C4 Offset: 0x22814C4 VA: 0x22854C4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x228558C Offset: 0x228158C VA: 0x228558C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2285978 Offset: 0x2281978 VA: 0x2285978 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22859DC Offset: 0x22819DC VA: 0x22859DC
	internal void OnSuccessAddAbnormalState(EnemyMobActionManagerBase enemyMobActionManager, GameObject actor, AbnormalType type) { }

	// RVA: 0x2285BE4 Offset: 0x2281BE4 VA: 0x2285BE4
	public void .ctor() { }
}

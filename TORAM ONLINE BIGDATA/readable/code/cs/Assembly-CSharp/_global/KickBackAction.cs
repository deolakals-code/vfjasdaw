// Assembly: Assembly-CSharp.dll
// Namespace: 
public class KickBackAction : PlayerAttackBase, IAbnormalStateSkill // TypeDefIndex: 2704
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int knockBackPercent; // 0x128
	private int knockBackDist; // 0x12C

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

	// RVA: 0x223EC34 Offset: 0x223AC34 VA: 0x223EC34 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x223EC3C Offset: 0x223AC3C VA: 0x223EC3C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x223EC44 Offset: 0x223AC44 VA: 0x223EC44 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x223EC4C Offset: 0x223AC4C VA: 0x223EC4C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x223EC54 Offset: 0x223AC54 VA: 0x223EC54 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x223EC5C Offset: 0x223AC5C VA: 0x223EC5C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x223EC64 Offset: 0x223AC64 VA: 0x223EC64 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x223EC6C Offset: 0x223AC6C VA: 0x223EC6C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x223EC74 Offset: 0x223AC74 VA: 0x223EC74 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x223EE88 Offset: 0x223AE88 VA: 0x223EE88 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x223EF50 Offset: 0x223AF50 VA: 0x223EF50 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x223F264 Offset: 0x223B264 VA: 0x223F264 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x223F2C8 Offset: 0x223B2C8 VA: 0x223F2C8
	public void .ctor() { }
}

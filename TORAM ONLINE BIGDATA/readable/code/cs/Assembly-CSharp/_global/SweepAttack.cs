// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SweepAttack : PetSkillActionBase, IAbnormalStateSkill // TypeDefIndex: 3540
{
	// Fields
	private float skillRate; // 0x150
	private float fixAddDamage; // 0x154
	private int abnormalPercent; // 0x158

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsSupport { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	protected override bool UseSkillEffect { get; }
	protected override int HitTakeId { get; }

	// Methods

	// RVA: 0x2367AEC Offset: 0x2363AEC VA: 0x2367AEC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2367AF4 Offset: 0x2363AF4 VA: 0x2367AF4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2367AFC Offset: 0x2363AFC VA: 0x2367AFC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2367B04 Offset: 0x2363B04 VA: 0x2367B04 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2367B0C Offset: 0x2363B0C VA: 0x2367B0C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2367B14 Offset: 0x2363B14 VA: 0x2367B14 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2367B1C Offset: 0x2363B1C VA: 0x2367B1C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2367B24 Offset: 0x2363B24 VA: 0x2367B24 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2367B2C Offset: 0x2363B2C VA: 0x2367B2C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2367B34 Offset: 0x2363B34 VA: 0x2367B34 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2367B3C Offset: 0x2363B3C VA: 0x2367B3C Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2367B48 Offset: 0x2363B48 VA: 0x2367B48 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2367CE8 Offset: 0x2363CE8 VA: 0x2367CE8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2368028 Offset: 0x2364028 VA: 0x2368028 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x236808C Offset: 0x236408C VA: 0x236808C
	public void .ctor() { }
}

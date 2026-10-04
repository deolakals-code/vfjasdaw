// Assembly: Assembly-CSharp.dll
// Namespace: 
public class StanAttack : PetSkillActionBase, IAbnormalStateSkill // TypeDefIndex: 3539
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

	// RVA: 0x2367540 Offset: 0x2363540 VA: 0x2367540 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2367548 Offset: 0x2363548 VA: 0x2367548 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2367550 Offset: 0x2363550 VA: 0x2367550 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2367558 Offset: 0x2363558 VA: 0x2367558 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2367560 Offset: 0x2363560 VA: 0x2367560 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2367568 Offset: 0x2363568 VA: 0x2367568 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2367570 Offset: 0x2363570 VA: 0x2367570 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2367578 Offset: 0x2363578 VA: 0x2367578 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2367580 Offset: 0x2363580 VA: 0x2367580 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2367588 Offset: 0x2363588 VA: 0x2367588 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2367590 Offset: 0x2363590 VA: 0x2367590 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x236759C Offset: 0x236359C VA: 0x236759C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2367740 Offset: 0x2363740 VA: 0x2367740 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2367A80 Offset: 0x2363A80 VA: 0x2367A80 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2367AE4 Offset: 0x2363AE4 VA: 0x2367AE4
	public void .ctor() { }
}

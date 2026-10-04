// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicShot : PetSkillActionBase // TypeDefIndex: 3529
{
	// Fields
	private float skillRate; // 0x150
	private float fixAddDamage; // 0x154

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

	// RVA: 0x2362508 Offset: 0x235E508 VA: 0x2362508 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2362510 Offset: 0x235E510 VA: 0x2362510 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2362518 Offset: 0x235E518 VA: 0x2362518 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2362520 Offset: 0x235E520 VA: 0x2362520 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2362528 Offset: 0x235E528 VA: 0x2362528 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2362530 Offset: 0x235E530 VA: 0x2362530 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2362538 Offset: 0x235E538 VA: 0x2362538 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2362540 Offset: 0x235E540 VA: 0x2362540 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2362548 Offset: 0x235E548 VA: 0x2362548 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2362550 Offset: 0x235E550 VA: 0x2362550 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2362558 Offset: 0x235E558 VA: 0x2362558 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2362564 Offset: 0x235E564 VA: 0x2362564 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x236268C Offset: 0x235E68C VA: 0x236268C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2362938 Offset: 0x235E938 VA: 0x2362938
	public void .ctor() { }
}

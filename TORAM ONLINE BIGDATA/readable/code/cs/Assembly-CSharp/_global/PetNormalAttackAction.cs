// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetNormalAttackAction : PetNormalAttackBase // TypeDefIndex: 3532
{
	// Properties
	public override int ActionID { get; }
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

	// RVA: 0x2363298 Offset: 0x235F298 VA: 0x2363298 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23632A0 Offset: 0x235F2A0 VA: 0x23632A0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23632A8 Offset: 0x235F2A8 VA: 0x23632A8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23632B0 Offset: 0x235F2B0 VA: 0x23632B0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23632B8 Offset: 0x235F2B8 VA: 0x23632B8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23632C0 Offset: 0x235F2C0 VA: 0x23632C0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23632C8 Offset: 0x235F2C8 VA: 0x23632C8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23632D0 Offset: 0x235F2D0 VA: 0x23632D0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23632D8 Offset: 0x235F2D8 VA: 0x23632D8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23632E0 Offset: 0x235F2E0 VA: 0x23632E0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23632E8 Offset: 0x235F2E8 VA: 0x23632E8 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x23632F0 Offset: 0x235F2F0 VA: 0x23632F0 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x23632FC Offset: 0x235F2FC VA: 0x23632FC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23633C8 Offset: 0x235F3C8 VA: 0x23633C8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2363744 Offset: 0x235F744 VA: 0x2363744
	public void .ctor() { }
}

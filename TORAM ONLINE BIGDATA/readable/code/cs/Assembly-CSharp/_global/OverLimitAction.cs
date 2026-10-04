// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OverLimitAction : PlayerAttackBase // TypeDefIndex: 3716
{
	// Properties
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x23D25D8 Offset: 0x23CE5D8 VA: 0x23D25D8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D25E0 Offset: 0x23CE5E0 VA: 0x23D25E0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D25E8 Offset: 0x23CE5E8 VA: 0x23D25E8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D25F0 Offset: 0x23CE5F0 VA: 0x23D25F0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D25F8 Offset: 0x23CE5F8 VA: 0x23D25F8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D2600 Offset: 0x23CE600 VA: 0x23D2600 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D2608 Offset: 0x23CE608 VA: 0x23D2608 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D2610 Offset: 0x23CE610 VA: 0x23D2610 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D2618 Offset: 0x23CE618 VA: 0x23D2618 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D2620 Offset: 0x23CE620 VA: 0x23D2620 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D2758 Offset: 0x23CE758 VA: 0x23D2758 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D2810 Offset: 0x23CE810 VA: 0x23D2810 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D2968 Offset: 0x23CE968 VA: 0x23D2968
	public void .ctor() { }
}

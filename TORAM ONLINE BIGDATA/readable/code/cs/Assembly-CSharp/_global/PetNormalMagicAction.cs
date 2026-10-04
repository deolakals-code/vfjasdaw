// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetNormalMagicAction : PetNormalAttackBase // TypeDefIndex: 3534
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
	protected override int HitTakeId { get; }
	protected override bool UseSkillEffect { get; }

	// Methods

	// RVA: 0x2363B48 Offset: 0x235FB48 VA: 0x2363B48 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2363B50 Offset: 0x235FB50 VA: 0x2363B50 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2363B58 Offset: 0x235FB58 VA: 0x2363B58 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2363B60 Offset: 0x235FB60 VA: 0x2363B60 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2363B68 Offset: 0x235FB68 VA: 0x2363B68 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2363B70 Offset: 0x235FB70 VA: 0x2363B70 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2363B78 Offset: 0x235FB78 VA: 0x2363B78 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2363B80 Offset: 0x235FB80 VA: 0x2363B80 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2363B88 Offset: 0x235FB88 VA: 0x2363B88 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2363B90 Offset: 0x235FB90 VA: 0x2363B90 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2363B98 Offset: 0x235FB98 VA: 0x2363B98 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2363BA4 Offset: 0x235FBA4 VA: 0x2363BA4 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2363BAC Offset: 0x235FBAC VA: 0x2363BAC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2363C78 Offset: 0x235FC78 VA: 0x2363C78 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2364030 Offset: 0x2360030 VA: 0x2364030
	public void .ctor() { }
}

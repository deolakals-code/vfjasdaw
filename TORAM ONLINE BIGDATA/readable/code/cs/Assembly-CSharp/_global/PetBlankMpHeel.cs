// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetBlankMpHeel : PetSkillActionBase // TypeDefIndex: 3524
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override int ActionID { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }
	protected override int HitTakeId { get; }
	protected override bool UseSkillEffect { get; }

	// Methods

	// RVA: 0x2360798 Offset: 0x235C798 VA: 0x2360798 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23607A0 Offset: 0x235C7A0 VA: 0x23607A0 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23607A8 Offset: 0x235C7A8 VA: 0x23607A8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23607B0 Offset: 0x235C7B0 VA: 0x23607B0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23607B8 Offset: 0x235C7B8 VA: 0x23607B8 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23607C0 Offset: 0x235C7C0 VA: 0x23607C0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23607C8 Offset: 0x235C7C8 VA: 0x23607C8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23607D0 Offset: 0x235C7D0 VA: 0x23607D0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23607D8 Offset: 0x235C7D8 VA: 0x23607D8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23607E0 Offset: 0x235C7E0 VA: 0x23607E0 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23607E8 Offset: 0x235C7E8 VA: 0x23607E8 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x23607F0 Offset: 0x235C7F0 VA: 0x23607F0 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x23607F8 Offset: 0x235C7F8 VA: 0x23607F8 Slot: 94
	protected override void OnPetSkillInitialize(CharacterActionManagerBase action, byte lv, PetAttackPatternData.PatternData motion) { }

	// RVA: 0x2360818 Offset: 0x235C818 VA: 0x2360818 Slot: 96
	public override TakeClip GetTakeClip(GameObject actor, GameObject target) { }

	// RVA: 0x2360AE0 Offset: 0x235CAE0 VA: 0x2360AE0
	public void .ctor() { }
}

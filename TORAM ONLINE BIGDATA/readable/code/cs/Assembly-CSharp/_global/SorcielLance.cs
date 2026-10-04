// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SorcielLance : PetSkillActionBase // TypeDefIndex: 3531
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

	// RVA: 0x2362E60 Offset: 0x235EE60 VA: 0x2362E60 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2362E68 Offset: 0x235EE68 VA: 0x2362E68 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2362E70 Offset: 0x235EE70 VA: 0x2362E70 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2362E78 Offset: 0x235EE78 VA: 0x2362E78 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2362E80 Offset: 0x235EE80 VA: 0x2362E80 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2362E88 Offset: 0x235EE88 VA: 0x2362E88 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2362E90 Offset: 0x235EE90 VA: 0x2362E90 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2362E98 Offset: 0x235EE98 VA: 0x2362E98 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2362EA0 Offset: 0x235EEA0 VA: 0x2362EA0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2362EA8 Offset: 0x235EEA8 VA: 0x2362EA8 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2362EB0 Offset: 0x235EEB0 VA: 0x2362EB0 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2362EBC Offset: 0x235EEBC VA: 0x2362EBC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2362FE4 Offset: 0x235EFE4 VA: 0x2362FE4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2363290 Offset: 0x235F290 VA: 0x2363290
	public void .ctor() { }
}

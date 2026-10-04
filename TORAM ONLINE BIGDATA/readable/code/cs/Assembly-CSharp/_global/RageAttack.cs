// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RageAttack : PetSkillActionBase // TypeDefIndex: 3525
{
	// Fields
	private float skillRate; // 0x150
	private float fixAddDamage; // 0x154
	private SkillAttackType attackType; // 0x158

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

	// RVA: 0x2360AE8 Offset: 0x235CAE8 VA: 0x2360AE8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2360AF0 Offset: 0x235CAF0 VA: 0x2360AF0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2360AF8 Offset: 0x235CAF8 VA: 0x2360AF8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2360B00 Offset: 0x235CB00 VA: 0x2360B00 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2360B08 Offset: 0x235CB08 VA: 0x2360B08 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2360B10 Offset: 0x235CB10 VA: 0x2360B10 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2360B18 Offset: 0x235CB18 VA: 0x2360B18 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2360B20 Offset: 0x235CB20 VA: 0x2360B20 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2360B28 Offset: 0x235CB28 VA: 0x2360B28 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2360B30 Offset: 0x235CB30 VA: 0x2360B30 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2360B38 Offset: 0x235CB38 VA: 0x2360B38 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2360B44 Offset: 0x235CB44 VA: 0x2360B44 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2360DE0 Offset: 0x235CDE0 VA: 0x2360DE0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2361220 Offset: 0x235D220 VA: 0x2361220
	public void .ctor() { }
}

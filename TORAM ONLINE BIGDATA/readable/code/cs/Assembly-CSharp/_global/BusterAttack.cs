// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BusterAttack : PetSkillActionBase // TypeDefIndex: 3536
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

	// RVA: 0x2366664 Offset: 0x2362664 VA: 0x2366664 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x236666C Offset: 0x236266C VA: 0x236666C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2366674 Offset: 0x2362674 VA: 0x2366674 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x236667C Offset: 0x236267C VA: 0x236667C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2366684 Offset: 0x2362684 VA: 0x2366684 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x236668C Offset: 0x236268C VA: 0x236668C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2366694 Offset: 0x2362694 VA: 0x2366694 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x236669C Offset: 0x236269C VA: 0x236669C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23666A4 Offset: 0x23626A4 VA: 0x23666A4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23666AC Offset: 0x23626AC VA: 0x23666AC Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x23666B4 Offset: 0x23626B4 VA: 0x23666B4 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x23666C0 Offset: 0x23626C0 VA: 0x23666C0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2366800 Offset: 0x2362800 VA: 0x2366800 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2366AFC Offset: 0x2362AFC VA: 0x2366AFC
	public void .ctor() { }
}

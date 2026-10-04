// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HeavyAttack : PetSkillActionBase // TypeDefIndex: 3538
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

	// RVA: 0x23670A4 Offset: 0x23630A4 VA: 0x23670A4 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23670AC Offset: 0x23630AC VA: 0x23670AC Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23670B4 Offset: 0x23630B4 VA: 0x23670B4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23670BC Offset: 0x23630BC VA: 0x23670BC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23670C4 Offset: 0x23630C4 VA: 0x23670C4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23670CC Offset: 0x23630CC VA: 0x23670CC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23670D4 Offset: 0x23630D4 VA: 0x23670D4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23670DC Offset: 0x23630DC VA: 0x23670DC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23670E4 Offset: 0x23630E4 VA: 0x23670E4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23670EC Offset: 0x23630EC VA: 0x23670EC Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x23670F4 Offset: 0x23630F4 VA: 0x23670F4 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2367100 Offset: 0x2363100 VA: 0x2367100 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x236723C Offset: 0x236323C VA: 0x236723C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2367538 Offset: 0x2363538 VA: 0x2367538
	public void .ctor() { }
}

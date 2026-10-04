// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SneakAttack : PetSkillActionBase // TypeDefIndex: 3526
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

	// RVA: 0x2361228 Offset: 0x235D228 VA: 0x2361228 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2361230 Offset: 0x235D230 VA: 0x2361230 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2361238 Offset: 0x235D238 VA: 0x2361238 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2361240 Offset: 0x235D240 VA: 0x2361240 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2361248 Offset: 0x235D248 VA: 0x2361248 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2361250 Offset: 0x235D250 VA: 0x2361250 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2361258 Offset: 0x235D258 VA: 0x2361258 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2361260 Offset: 0x235D260 VA: 0x2361260 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2361268 Offset: 0x235D268 VA: 0x2361268 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2361270 Offset: 0x235D270 VA: 0x2361270 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x2361278 Offset: 0x235D278 VA: 0x2361278 Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x2361284 Offset: 0x235D284 VA: 0x2361284 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2361554 Offset: 0x235D554 VA: 0x2361554 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2361994 Offset: 0x235D994 VA: 0x2361994
	public void .ctor() { }
}

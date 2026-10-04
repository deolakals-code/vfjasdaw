// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlastFlare : PetSkillActionBase // TypeDefIndex: 3527
{
	// Fields
	private float skillRate; // 0x150
	private float fixAddDamage; // 0x154
	private float rad; // 0x158
	private Transform attackTransform; // 0x160
	private Vector3 attackPosition; // 0x168

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
	protected override int EffectTake { get; }

	// Methods

	// RVA: 0x236199C Offset: 0x235D99C VA: 0x236199C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23619A4 Offset: 0x235D9A4 VA: 0x23619A4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23619AC Offset: 0x235D9AC VA: 0x23619AC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23619B4 Offset: 0x235D9B4 VA: 0x23619B4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23619BC Offset: 0x235D9BC VA: 0x23619BC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23619C4 Offset: 0x235D9C4 VA: 0x23619C4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23619CC Offset: 0x235D9CC VA: 0x23619CC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23619D4 Offset: 0x235D9D4 VA: 0x23619D4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23619DC Offset: 0x235D9DC VA: 0x23619DC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23619E4 Offset: 0x235D9E4 VA: 0x23619E4 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x23619EC Offset: 0x235D9EC VA: 0x23619EC Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x23619F8 Offset: 0x235D9F8 VA: 0x23619F8 Slot: 93
	protected override int get_EffectTake() { }

	// RVA: 0x2361A04 Offset: 0x235DA04 VA: 0x2361A04 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2361B80 Offset: 0x235DB80 VA: 0x2361B80 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2361E2C Offset: 0x235DE2C VA: 0x2361E2C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2361EAC Offset: 0x235DEAC VA: 0x2361EAC Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2362014 Offset: 0x235E014 VA: 0x2362014
	public void .ctor() { }
}

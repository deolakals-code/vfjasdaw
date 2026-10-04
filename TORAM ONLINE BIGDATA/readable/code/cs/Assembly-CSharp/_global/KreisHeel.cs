// Assembly: Assembly-CSharp.dll
// Namespace: 
public class KreisHeel : PetSkillActionBase // TypeDefIndex: 3543
{
	// Fields
	private Vector3 checkPos; // 0x150
	private float range; // 0x15C

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

	// RVA: 0x236865C Offset: 0x236465C VA: 0x236865C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2368664 Offset: 0x2364664 VA: 0x2368664 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x236866C Offset: 0x236466C VA: 0x236866C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2368674 Offset: 0x2364674 VA: 0x2368674 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x236867C Offset: 0x236467C VA: 0x236867C Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2368684 Offset: 0x2364684 VA: 0x2368684 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x236868C Offset: 0x236468C VA: 0x236868C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2368694 Offset: 0x2364694 VA: 0x2368694 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x236869C Offset: 0x236469C VA: 0x236869C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23686A4 Offset: 0x23646A4 VA: 0x23686A4 Slot: 91
	protected override bool get_UseSkillEffect() { }

	// RVA: 0x23686AC Offset: 0x23646AC VA: 0x23686AC Slot: 92
	protected override int get_HitTakeId() { }

	// RVA: 0x23686B4 Offset: 0x23646B4 VA: 0x23686B4 Slot: 93
	protected override int get_EffectTake() { }

	// RVA: 0x23686C0 Offset: 0x23646C0 VA: 0x23686C0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x236874C Offset: 0x236474C VA: 0x236874C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2368788 Offset: 0x2364788 VA: 0x2368788 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2368800 Offset: 0x2364800 VA: 0x2368800
	public void .ctor() { }
}

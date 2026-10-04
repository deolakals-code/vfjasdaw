// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BraveAuraAction : PlayerAttackBase // TypeDefIndex: 3623
{
	// Fields
	private int range; // 0x120
	private Vector3 checkPos; // 0x124

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23B147C Offset: 0x23AD47C VA: 0x23B147C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B1484 Offset: 0x23AD484 VA: 0x23B1484 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B148C Offset: 0x23AD48C VA: 0x23B148C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B1494 Offset: 0x23AD494 VA: 0x23B1494 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B149C Offset: 0x23AD49C VA: 0x23B149C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B14A4 Offset: 0x23AD4A4 VA: 0x23B14A4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B14AC Offset: 0x23AD4AC VA: 0x23B14AC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B14B4 Offset: 0x23AD4B4 VA: 0x23B14B4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B14BC Offset: 0x23AD4BC VA: 0x23B14BC Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B14C4 Offset: 0x23AD4C4 VA: 0x23B14C4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B168C Offset: 0x23AD68C VA: 0x23B168C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B175C Offset: 0x23AD75C VA: 0x23B175C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B1830 Offset: 0x23AD830 VA: 0x23B1830 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23B18AC Offset: 0x23AD8AC VA: 0x23B18AC
	public void .ctor() { }
}

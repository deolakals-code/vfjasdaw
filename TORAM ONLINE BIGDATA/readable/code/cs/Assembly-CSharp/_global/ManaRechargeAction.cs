// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ManaRechargeAction : PlayerAttackBase // TypeDefIndex: 3709
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

	// RVA: 0x23CE378 Offset: 0x23CA378 VA: 0x23CE378 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23CE380 Offset: 0x23CA380 VA: 0x23CE380 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23CE388 Offset: 0x23CA388 VA: 0x23CE388 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23CE390 Offset: 0x23CA390 VA: 0x23CE390 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23CE398 Offset: 0x23CA398 VA: 0x23CE398 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23CE3A0 Offset: 0x23CA3A0 VA: 0x23CE3A0 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23CE3A8 Offset: 0x23CA3A8 VA: 0x23CE3A8 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23CE3B0 Offset: 0x23CA3B0 VA: 0x23CE3B0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23CE3B8 Offset: 0x23CA3B8 VA: 0x23CE3B8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23CE3C0 Offset: 0x23CA3C0 VA: 0x23CE3C0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23CE530 Offset: 0x23CA530 VA: 0x23CE530 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23CE600 Offset: 0x23CA600 VA: 0x23CE600 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23CE80C Offset: 0x23CA80C VA: 0x23CE80C Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23CE888 Offset: 0x23CA888 VA: 0x23CE888
	public void .ctor() { }
}

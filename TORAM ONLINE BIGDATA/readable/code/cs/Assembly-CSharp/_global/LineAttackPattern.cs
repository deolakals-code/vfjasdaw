// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LineAttackPattern : MobPatternBase, ILineParam // TypeDefIndex: 789
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private float attackRangeDist; // 0x78
	private float attackRangeWidth; // 0x7C
	private float attackSafeRangeDist; // 0x80
	private Vector3 lineStart; // 0x84
	private Vector3 lineEnd; // 0x90
	private bool createAttackArea; // 0x9C
	private bool setupEnd; // 0x9D
	private float runTime; // 0xA0
	private float hitInterval; // 0xA4
	private Dictionary<Transform, float> hitTargets; // 0xA8
	private AttackArea attackArea; // 0xB0
	private float warningFloorReducedTime; // 0xB8
	private float attackRotationRad; // 0xBC
	private Vector3 attackDir; // 0xC0

	// Properties
	public Vector3 LineVector { get; }
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1D4CD24 Offset: 0x1D48D24 VA: 0x1D4CD24 Slot: 36
	public Vector3 get_LineVector() { }

	// RVA: 0x1D4CD44 Offset: 0x1D48D44 VA: 0x1D4CD44 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1D4CD4C Offset: 0x1D48D4C VA: 0x1D4CD4C Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1D4CD8C Offset: 0x1D48D8C VA: 0x1D4CD8C
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1D4D014 Offset: 0x1D49014 VA: 0x1D4D014
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 lineTarget, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1D4D294 Offset: 0x1D49294 VA: 0x1D4D294 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1D4D5F4 Offset: 0x1D495F4 VA: 0x1D4D5F4
	private void chargeStart() { }

	// RVA: 0x1D4D694 Offset: 0x1D49694 VA: 0x1D4D694
	private void initLine(Vector3 actorPos, Vector3 lineTarget, bool createArea) { }

	// RVA: 0x1D4D928 Offset: 0x1D49928 VA: 0x1D4D928
	private void updateLine(Vector3 actorPos) { }

	// RVA: 0x1D4DAD8 Offset: 0x1D49AD8 VA: 0x1D4DAD8
	private void UpdateActorRotation(bool updateAttackLine) { }

	// RVA: 0x1D4DC58 Offset: 0x1D49C58 VA: 0x1D4DC58 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1D4DC98 Offset: 0x1D49C98 VA: 0x1D4DC98 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1D4DC9C Offset: 0x1D49C9C VA: 0x1D4DC9C Slot: 20
	protected override bool OnPreUpdate() { }

	// RVA: 0x1D4DD2C Offset: 0x1D49D2C VA: 0x1D4DD2C Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1D4DDEC Offset: 0x1D49DEC VA: 0x1D4DDEC Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1D4DFD0 Offset: 0x1D49FD0 VA: 0x1D4DFD0 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1D4E05C Offset: 0x1D4A05C VA: 0x1D4E05C Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1D4E288 Offset: 0x1D4A288 VA: 0x1D4E288 Slot: 32
	public override bool CheckRayArea(Vector3 position, Vector3 ray, float range) { }

	// RVA: 0x1D4E350 Offset: 0x1D4A350 VA: 0x1D4E350 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1D4DC5C Offset: 0x1D49C5C VA: 0x1D4DC5C
	private void HideAttackArea() { }
}

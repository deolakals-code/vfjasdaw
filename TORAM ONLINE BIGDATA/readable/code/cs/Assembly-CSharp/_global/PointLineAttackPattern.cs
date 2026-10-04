// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PointLineAttackPattern : MobPatternBase, ILineParam // TypeDefIndex: 814
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private Vector3 lineStart; // 0x78
	private Vector3 lineEnd; // 0x84
	private bool createAttackArea; // 0x90
	private bool setupEnd; // 0x91
	private float attackRange; // 0x94
	private AttackArea attackArea; // 0x98
	private float warningFloorReducedTime; // 0xA0
	private float runTime; // 0xA4
	private float hitInterval; // 0xA8
	private Dictionary<Transform, float> hitTargets; // 0xB0

	// Properties
	public Vector3 LineVector { get; }
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }
	public Vector3 StartPos { get; }

	// Methods

	// RVA: 0x1E18D50 Offset: 0x1E14D50 VA: 0x1E18D50 Slot: 36
	public Vector3 get_LineVector() { }

	// RVA: 0x1E18D70 Offset: 0x1E14D70 VA: 0x1E18D70 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E18D78 Offset: 0x1E14D78 VA: 0x1E18D78 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E18D98 Offset: 0x1E14D98 VA: 0x1E18D98
	public Vector3 get_StartPos() { }

	// RVA: 0x1E18DA4 Offset: 0x1E14DA4 VA: 0x1E18DA4
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E18FD4 Offset: 0x1E14FD4 VA: 0x1E18FD4
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 lineTarget, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E19204 Offset: 0x1E15204 VA: 0x1E19204 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E19A9C Offset: 0x1E15A9C VA: 0x1E19A9C Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E19ADC Offset: 0x1E15ADC VA: 0x1E19ADC Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1E19AE0 Offset: 0x1E15AE0 VA: 0x1E19AE0 Slot: 20
	protected override bool OnPreUpdate() { }

	// RVA: 0x1E19B70 Offset: 0x1E15B70 VA: 0x1E19B70 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E19C10 Offset: 0x1E15C10 VA: 0x1E19C10 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E19D00 Offset: 0x1E15D00 VA: 0x1E19D00 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1E19D8C Offset: 0x1E15D8C VA: 0x1E19D8C Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1E19FB8 Offset: 0x1E15FB8 VA: 0x1E19FB8 Slot: 32
	public override bool CheckRayArea(Vector3 position, Vector3 ray, float range) { }

	// RVA: 0x1E1A080 Offset: 0x1E16080 VA: 0x1E1A080 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1E199FC Offset: 0x1E159FC VA: 0x1E199FC
	private void chargeStart() { }

	// RVA: 0x1E19AA0 Offset: 0x1E15AA0 VA: 0x1E19AA0
	private void HideAttackArea() { }

	// RVA: 0x1E19594 Offset: 0x1E15594 VA: 0x1E19594
	private void initLine(Vector3 actorPos, Vector3 lineTarget, bool createArea) { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SurroundAttackPattern : MobPatternBase, ICircleparam // TypeDefIndex: 828
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private float attackRangeRad; // 0x78
	private float attackSafeRangeRad; // 0x7C
	private bool createAttackArea; // 0x80
	private bool setupEnd; // 0x81
	private AttackArea attackArea; // 0x88
	private float warningFloorReducedTime; // 0x90

	// Properties
	public Vector3 CenterPosition { get; }
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1E1FBE0 Offset: 0x1E1BBE0 VA: 0x1E1FBE0 Slot: 36
	public Vector3 get_CenterPosition() { }

	// RVA: 0x1E1FC08 Offset: 0x1E1BC08 VA: 0x1E1FC08 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E1FC10 Offset: 0x1E1BC10 VA: 0x1E1FC10 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E1FC50 Offset: 0x1E1BC50 VA: 0x1E1FC50
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E1FE38 Offset: 0x1E1BE38 VA: 0x1E1FE38
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 targetPos, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E20020 Offset: 0x1E1C020 VA: 0x1E20020 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E2030C Offset: 0x1E1C30C VA: 0x1E2030C
	private void chargeStart() { }

	// RVA: 0x1E204E4 Offset: 0x1E1C4E4 VA: 0x1E204E4 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E20524 Offset: 0x1E1C524 VA: 0x1E20524 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1E20528 Offset: 0x1E1C528 VA: 0x1E20528 Slot: 20
	protected override bool OnPreUpdate() { }

	// RVA: 0x1E205B8 Offset: 0x1E1C5B8 VA: 0x1E205B8 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E20698 Offset: 0x1E1C698 VA: 0x1E20698 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E206D4 Offset: 0x1E1C6D4 VA: 0x1E206D4 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1E20784 Offset: 0x1E1C784 VA: 0x1E20784 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1E20834 Offset: 0x1E1C834 VA: 0x1E20834 Slot: 32
	public override bool CheckRayArea(Vector3 position, Vector3 ray, float range) { }

	// RVA: 0x1E2092C Offset: 0x1E1C92C VA: 0x1E2092C Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1E20994 Offset: 0x1E1C994 VA: 0x1E20994 Slot: 37
	public bool CheckNearCircumfrence(Transform targetTransform) { }

	// RVA: 0x1E204E8 Offset: 0x1E1C4E8 VA: 0x1E204E8
	private void HideAttackArea() { }
}

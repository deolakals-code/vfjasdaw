// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RangeAttackPattern : MobPatternBase, ICircleparam // TypeDefIndex: 821
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private float attackRangeRad; // 0x78
	private float attackSafeRangeRad; // 0x7C
	private bool createAttackArea; // 0x80
	private bool setupEnd; // 0x81
	private bool isTargetDirection; // 0x82
	private AttackArea attackArea; // 0x88
	private Vector3 prevPos; // 0x90
	private float warningFloorReducedTime; // 0x9C

	// Properties
	public Vector3 CenterPosition { get; }
	public override KnockBackResistType KnockBackResist { get; }
	public override bool IsTargetDirection { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1E1CB18 Offset: 0x1E18B18 VA: 0x1E1CB18 Slot: 36
	public Vector3 get_CenterPosition() { }

	// RVA: 0x1E1CB24 Offset: 0x1E18B24 VA: 0x1E1CB24 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E1CB2C Offset: 0x1E18B2C VA: 0x1E1CB2C Slot: 6
	public override bool get_IsTargetDirection() { }

	// RVA: 0x1E1CB5C Offset: 0x1E18B5C VA: 0x1E1CB5C Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E1CB9C Offset: 0x1E18B9C VA: 0x1E1CB9C
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, Vector3 prevAttackPos, float playSpeed) { }

	// RVA: 0x1E1CDC4 Offset: 0x1E18DC4 VA: 0x1E1CDC4
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 rangeCenter, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E1CFB0 Offset: 0x1E18FB0 VA: 0x1E1CFB0 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E1D350 Offset: 0x1E19350 VA: 0x1E1D350
	private void chargeStart() { }

	// RVA: 0x1E1D508 Offset: 0x1E19508 VA: 0x1E1D508 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E1D548 Offset: 0x1E19548 VA: 0x1E1D548 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1E1D54C Offset: 0x1E1954C VA: 0x1E1D54C Slot: 20
	protected override bool OnPreUpdate() { }

	// RVA: 0x1E1D5DC Offset: 0x1E195DC VA: 0x1E1D5DC Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E1D67C Offset: 0x1E1967C VA: 0x1E1D67C Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E1D6B8 Offset: 0x1E196B8 VA: 0x1E1D6B8 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1E1D740 Offset: 0x1E19740 VA: 0x1E1D740 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1E1D7C8 Offset: 0x1E197C8 VA: 0x1E1D7C8 Slot: 32
	public override bool CheckRayArea(Vector3 position, Vector3 ray, float range) { }

	// RVA: 0x1E1D838 Offset: 0x1E19838 VA: 0x1E1D838 Slot: 37
	public bool CheckNearCircumfrence(Transform targetTransform) { }

	// RVA: 0x1E1D50C Offset: 0x1E1950C VA: 0x1E1D50C
	private void HideAttackArea() { }
}

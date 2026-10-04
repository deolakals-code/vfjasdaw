// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SectorAttackPattern : MobPatternBase, ICircleparam // TypeDefIndex: 824
{
	// Fields
	private MobAnimation animation; // 0x70
	private CharacterMove charaMove; // 0x78
	private List<Transform> hitTarget; // 0x80
	private float attackLoopTime; // 0x88
	private float hitInterval; // 0x8C
	private float attackIntervalTime; // 0x90
	private float attackDist; // 0x94
	private float safeDist; // 0x98
	private float initAngle; // 0x9C
	private float startAngle; // 0xA0
	private float attackAngle; // 0xA4
	private Vector3 centerPos; // 0xA8
	private bool createAttackArea; // 0xB4
	private AttackArea attackArea; // 0xB8
	private float warningFloorReducedTime; // 0xC0

	// Properties
	public Vector3 CenterPosition { get; }
	public override KnockBackResistType KnockBackResist { get; }
	public override bool IsTargetDirection { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1E1DCA0 Offset: 0x1E19CA0 VA: 0x1E1DCA0 Slot: 36
	public Vector3 get_CenterPosition() { }

	// RVA: 0x1E1DCAC Offset: 0x1E19CAC VA: 0x1E1DCAC Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E1DCB4 Offset: 0x1E19CB4 VA: 0x1E1DCB4 Slot: 6
	public override bool get_IsTargetDirection() { }

	// RVA: 0x1E1DCF4 Offset: 0x1E19CF4 VA: 0x1E1DCF4 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E1DD34 Offset: 0x1E19D34 VA: 0x1E1DD34
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAction, GameObject target, MobAnimation animation, CharacterMove charaMove, float playSpeed) { }

	// RVA: 0x1E1E2B8 Offset: 0x1E1A2B8 VA: 0x1E1E2B8 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E1E75C Offset: 0x1E1A75C VA: 0x1E1E75C Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E1E79C Offset: 0x1E1A79C VA: 0x1E1E79C Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1E1E7A0 Offset: 0x1E1A7A0 VA: 0x1E1E7A0 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E1E884 Offset: 0x1E1A884 VA: 0x1E1E884 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E1EA20 Offset: 0x1E1AA20 VA: 0x1E1EA20 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1E1EC88 Offset: 0x1E1AC88 VA: 0x1E1EC88 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1E1ECC8 Offset: 0x1E1ACC8 VA: 0x1E1ECC8 Slot: 32
	public override bool CheckRayArea(Vector3 position, Vector3 ray, float range) { }

	// RVA: 0x1E1EDC0 Offset: 0x1E1ADC0 VA: 0x1E1EDC0 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1E1EE28 Offset: 0x1E1AE28 VA: 0x1E1EE28 Slot: 37
	public bool CheckNearCircumfrence(Transform targetTransform) { }

	// RVA: 0x1E1EA60 Offset: 0x1E1AA60 VA: 0x1E1EA60
	private static bool IsPointAndSectorHit(Transform actor, Transform target, float safeDist, float attackDist, float initAngle, float startAngle, float attackAngle) { }

	// RVA: 0x1E1E760 Offset: 0x1E1A760 VA: 0x1E1E760
	private void HideAttackArea() { }
}

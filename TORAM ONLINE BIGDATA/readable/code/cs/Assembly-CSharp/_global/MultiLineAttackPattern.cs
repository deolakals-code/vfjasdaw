// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MultiLineAttackPattern : MobPatternBase, ILineParam // TypeDefIndex: 807
{
	// Fields
	private readonly int chargeMotionId; // 0x70
	private readonly int maxLineNum; // 0x74
	private readonly float safeWidth; // 0x78
	private readonly float offsetFrontAndBack; // 0x7C
	private readonly float offsetLeftAndRight; // 0x80
	private readonly float initRot; // 0x84
	private readonly int bulletCommandId; // 0x88
	private readonly float attackDist; // 0x8C
	private readonly float attackWidth; // 0x90
	private MobAnimation animation; // 0x98
	private AttackArea attackArea; // 0xA0
	private Vector3 actorPos; // 0xA8
	private Vector3 lineStart; // 0xB4
	private Vector3 lineEnd; // 0xC0
	private float attackRot; // 0xCC
	private float attackTimingTime; // 0xD0
	private bool isAttackble; // 0xD4
	[TupleElementNames(new[] { "ls", "le" })]
	private List<ValueTuple<Vector3, Vector3>> attackLineList; // 0xD8

	// Properties
	public override bool VisibleAttackArea { get; }
	public override KnockBackResistType KnockBackResist { get; }
	public Vector3 LineVector { get; }
	public override bool IsTargetDirection { get; }

	// Methods

	// RVA: 0x1E17018 Offset: 0x1E13018 VA: 0x1E17018
	private void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, MobAnimation animation, GameObject target, float playSpeed) { }

	// RVA: 0x1E172A8 Offset: 0x1E132A8 VA: 0x1E172A8
	public static MultiLineAttackPattern CreateManagedPattern(MobAttackBase action, EnemyMobActionManagerBase mobAction, MobAnimation animation, GameObject target, float playSpeed) { }

	// RVA: 0x1E17364 Offset: 0x1E13364 VA: 0x1E17364
	public static MultiLineAttackPattern CreateUnmanagedPattern(MobAttackBase action, EnemyMobActionManagerBase mobAction, MobAnimation animation, GameObject target, Vector3 targetPos, float playSpeed) { }

	// RVA: 0x1E17418 Offset: 0x1E13418 VA: 0x1E17418 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E17438 Offset: 0x1E13438 VA: 0x1E17438 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E17440 Offset: 0x1E13440 VA: 0x1E17440 Slot: 36
	public Vector3 get_LineVector() { }

	// RVA: 0x1E17460 Offset: 0x1E13460 VA: 0x1E17460 Slot: 6
	public override bool get_IsTargetDirection() { }

	// RVA: 0x1E174A0 Offset: 0x1E134A0 VA: 0x1E174A0 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E17F7C Offset: 0x1E13F7C VA: 0x1E17F7C Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E18008 Offset: 0x1E14008 VA: 0x1E18008 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1E1800C Offset: 0x1E1400C VA: 0x1E1800C Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E18120 Offset: 0x1E14120 VA: 0x1E18120 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E1845C Offset: 0x1E1445C VA: 0x1E1845C Slot: 32
	public override bool CheckRayArea(Vector3 position, Vector3 ray, float dist) { }

	// RVA: 0x1E18534 Offset: 0x1E14534 VA: 0x1E18534 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1E17864 Offset: 0x1E13864 VA: 0x1E17864
	private void UpdateRot() { }

	// RVA: 0x1E179E8 Offset: 0x1E139E8 VA: 0x1E179E8
	private void UpdatePos() { }

	// RVA: 0x1E17C00 Offset: 0x1E13C00 VA: 0x1E17C00
	private void UpdateAttackLine() { }

	// RVA: 0x1E180F4 Offset: 0x1E140F4 VA: 0x1E180F4
	private void UpdateAttackArea() { }

	// RVA: 0x1E17FBC Offset: 0x1E13FBC VA: 0x1E17FBC
	private void StopAttackArea() { }
}

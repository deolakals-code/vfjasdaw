// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BarrierScreenAttackPattern : MobPatternBase // TypeDefIndex: 741
{
	// Fields
	private readonly MobPatternTargetType[] targetTypes; // 0x70
	private readonly int maxLineNum; // 0x78
	private readonly int chargeMotionId; // 0x7C
	private readonly float safeWidth; // 0x80
	private readonly float offsetFrontAndBack; // 0x84
	private readonly float offsetLeftAndRight; // 0x88
	private readonly float initRot; // 0x8C
	private readonly BarrierScreenAttackPattern.AttackFlag attackFlag; // 0x90
	private readonly bool alternateDirectionFlag; // 0x94
	private readonly bool reverseDirectionFlag; // 0x95
	private readonly int bulletCommandId; // 0x98
	private readonly float attackWidth; // 0x9C
	private readonly float moveRange; // 0xA0
	private MobAnimation mobAnimation; // 0xA8
	private Vector3 actorPos; // 0xB0
	private Vector3 lineStart; // 0xBC
	private float attackRot; // 0xC8
	private float attackTimingTime; // 0xCC
	private AttackArea attackArea; // 0xD0
	[TupleElementNames(new[] { "Start", "End" })]
	private List<ValueTuple<Vector3, Vector3>> attackLines; // 0xD8

	// Properties
	public override bool VisibleAttackArea { get; }
	[TupleElementNames(new[] { "Start", "End" })]
	public IReadOnlyList<ValueTuple<Vector3, Vector3>> AttackLines { get; }

	// Methods

	// RVA: 0x1C6AB9C Offset: 0x1C66B9C VA: 0x1C6AB9C Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1C6ABBC Offset: 0x1C66BBC VA: 0x1C6ABBC
	public IReadOnlyList<ValueTuple<Vector3, Vector3>> get_AttackLines() { }

	// RVA: 0x1C6ABC4 Offset: 0x1C66BC4 VA: 0x1C6ABC4
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAction, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1C6B1B4 Offset: 0x1C671B4 VA: 0x1C6B1B4
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAction, GameObject target, Vector3 targetPos, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1C6B500 Offset: 0x1C67500 VA: 0x1C6B500 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1C6B9E4 Offset: 0x1C679E4 VA: 0x1C6B9E4 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1C6BA70 Offset: 0x1C67A70 VA: 0x1C6BA70 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1C6BA74 Offset: 0x1C67A74 VA: 0x1C6BA74 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1C6BB18 Offset: 0x1C67B18 VA: 0x1C6BB18 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1C6BE80 Offset: 0x1C67E80 VA: 0x1C6BE80 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1C6AF04 Offset: 0x1C66F04 VA: 0x1C6AF04
	private void CreateAttackPos() { }

	// RVA: 0x1C6B6A4 Offset: 0x1C676A4 VA: 0x1C6B6A4
	private void UpdateRot() { }

	// RVA: 0x1C6B800 Offset: 0x1C67800 VA: 0x1C6B800
	private void UpdatePos() { }

	// RVA: 0x1C6BB9C Offset: 0x1C67B9C VA: 0x1C6BB9C
	private void AddInstallation() { }

	// RVA: 0x1C6C114 Offset: 0x1C68114 VA: 0x1C6C114
	private List<ValueTuple<Vector3, Vector3>> CreateAttackLines() { }

	// RVA: 0x1C6BAF0 Offset: 0x1C67AF0 VA: 0x1C6BAF0
	private void UpdateAttackArea() { }

	// RVA: 0x1C6BA24 Offset: 0x1C67A24 VA: 0x1C6BA24
	private void StopAttackArea() { }
}

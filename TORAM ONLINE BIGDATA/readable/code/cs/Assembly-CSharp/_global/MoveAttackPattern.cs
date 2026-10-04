// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MoveAttackPattern : MobPatternBase, ILineParam // TypeDefIndex: 799
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private CharacterMove charaMove; // 0x78
	private float attackRangeRad; // 0x80
	private float attackSafeRangeRad; // 0x84
	private Vector3 startPos; // 0x88
	private MoveAttackPattern.State state; // 0x94
	private bool moveFrame; // 0x98
	private List<Transform> hitTargetList; // 0xA0
	private float moveTime; // 0xA8
	private bool isHitNextAttack; // 0xAC
	private AttackArea attackArea; // 0xB0
	private Vector3 movePos; // 0xB8
	private float warningFloorReducedTime; // 0xC4

	// Properties
	public Vector3 LineVector { get; }
	public override KnockBackResistType KnockBackResist { get; }
	public override bool IsTargetDirection { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1D5577C Offset: 0x1D5177C VA: 0x1D5577C Slot: 36
	public Vector3 get_LineVector() { }

	// RVA: 0x1D5579C Offset: 0x1D5179C VA: 0x1D5579C Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1D557A4 Offset: 0x1D517A4 VA: 0x1D557A4 Slot: 6
	public override bool get_IsTargetDirection() { }

	// RVA: 0x1D557E4 Offset: 0x1D517E4 VA: 0x1D557E4 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1D55824 Offset: 0x1D51824 VA: 0x1D55824
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, CharacterMove charaMove, float playSpeed) { }

	// RVA: 0x1D55A54 Offset: 0x1D51A54 VA: 0x1D55A54
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 moveTarget, MobAnimation animation, CharacterMove charaMove, float playSpeed) { }

	// RVA: 0x1D55CA8 Offset: 0x1D51CA8 VA: 0x1D55CA8
	private void initMoveTarget(Vector3 actorPos, Vector3 moveTarget, bool createArea) { }

	// RVA: 0x1D560C4 Offset: 0x1D520C4 VA: 0x1D560C4 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1D5646C Offset: 0x1D5246C VA: 0x1D5646C Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1D56574 Offset: 0x1D52574 VA: 0x1D56574 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1D56578 Offset: 0x1D52578 VA: 0x1D56578 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1D56624 Offset: 0x1D52624 VA: 0x1D56624 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1D56910 Offset: 0x1D52910 VA: 0x1D56910 Slot: 25
	public override void LateUpdate() { }

	// RVA: 0x1D569CC Offset: 0x1D529CC VA: 0x1D569CC Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1D56A5C Offset: 0x1D52A5C VA: 0x1D56A5C Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1D56BA8 Offset: 0x1D52BA8 VA: 0x1D56BA8 Slot: 32
	public override bool CheckRayArea(Vector3 position, Vector3 ray, float range) { }

	// RVA: 0x1D56C74 Offset: 0x1D52C74 VA: 0x1D56C74 Slot: 27
	public override void OnAttackDamage() { }

	// RVA: 0x1D56CE8 Offset: 0x1D52CE8 VA: 0x1D56CE8 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1D56538 Offset: 0x1D52538 VA: 0x1D56538
	private void HideAttackArea() { }

	[CompilerGenerated]
	// RVA: 0x1D56D50 Offset: 0x1D52D50 VA: 0x1D56D50
	private void <OnPostUpdate>b__30_0() { }
}

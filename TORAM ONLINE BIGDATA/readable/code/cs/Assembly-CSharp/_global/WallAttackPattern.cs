// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WallAttackPattern : MobPatternBase, ICircleparam // TypeDefIndex: 841
{
	// Fields
	private readonly MobPatternTargetType[] targetTypes; // 0x70
	private MobAnimation mobAnimation; // 0x78
	private float attackRangeRad; // 0x80
	private float safeRangeRad; // 0x84
	private Dictionary<AttackArea, Vector3> attackAreaList; // 0x88
	private List<Vector3> targetList; // 0x90
	private float hitEffectTiming; // 0x98
	private bool isAttack; // 0x9C
	private bool isAttackable; // 0x9D
	private ElementType element; // 0xA0
	private float warningFloorReducedTime; // 0xA4

	// Properties
	public override bool VisibleAttackArea { get; }
	public override KnockBackResistType KnockBackResist { get; }
	public Vector3 CenterPosition { get; }

	// Methods

	// RVA: 0x1EC383C Offset: 0x1EBF83C VA: 0x1EC383C Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1EC39C8 Offset: 0x1EBF9C8 VA: 0x1EC39C8 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1EC39D0 Offset: 0x1EBF9D0 VA: 0x1EC39D0 Slot: 36
	public Vector3 get_CenterPosition() { }

	// RVA: 0x1EC39DC Offset: 0x1EBF9DC VA: 0x1EC39DC
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1EC4430 Offset: 0x1EC0430 VA: 0x1EC4430
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, List<MobActionTargetData> targetList, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1EC494C Offset: 0x1EC094C VA: 0x1EC494C
	private void ChargeUpdate() { }

	// RVA: 0x1EC4B3C Offset: 0x1EC0B3C VA: 0x1EC4B3C Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1EC4E50 Offset: 0x1EC0E50 VA: 0x1EC4E50 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1EC4F2C Offset: 0x1EC0F2C VA: 0x1EC4F2C Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1EC50FC Offset: 0x1EC10FC VA: 0x1EC50FC Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1EC5444 Offset: 0x1EC1444 VA: 0x1EC5444 Slot: 29
	public override bool CheckInArea(Transform targetTransform) { }

	// RVA: 0x1EC5498 Offset: 0x1EC1498 VA: 0x1EC5498 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1EC5668 Offset: 0x1EC1668 VA: 0x1EC5668 Slot: 37
	public bool CheckNearCircumfrence(Transform targetTransform) { }

	// RVA: 0x1EC3F40 Offset: 0x1EBFF40 VA: 0x1EC3F40
	private void CreateTargets() { }
}

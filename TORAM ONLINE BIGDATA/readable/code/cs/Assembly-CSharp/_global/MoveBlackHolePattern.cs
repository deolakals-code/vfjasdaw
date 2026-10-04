// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MoveBlackHolePattern : MobPatternBase // TypeDefIndex: 802
{
	// Fields
	private readonly MobPatternTargetType[] targetTypes; // 0x70
	private MobAnimation mobAnimation; // 0x78
	private float attackRange; // 0x80
	private float hitEffectTiming; // 0x84
	private List<MoveBlackHolePattern.TargetData> targetDataList; // 0x88
	private List<AttackArea> attackAreaList; // 0x90
	private bool isAttack; // 0x98

	// Properties
	public override bool VisibleAttackArea { get; }
	public GameObject MainTarget { get; }

	// Methods

	// RVA: 0x1D56D5C Offset: 0x1D52D5C VA: 0x1D56D5C
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase actionManager, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1D57BE8 Offset: 0x1D53BE8 VA: 0x1D57BE8
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase actionManager, GameObject target, List<MobActionTargetData> targetList, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1D58210 Offset: 0x1D54210 VA: 0x1D58210 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1D5833C Offset: 0x1D5433C VA: 0x1D5833C
	public GameObject get_MainTarget() { }

	// RVA: 0x1D58344 Offset: 0x1D54344 VA: 0x1D58344 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1D58570 Offset: 0x1D54570 VA: 0x1D58570 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1D58714 Offset: 0x1D54714 VA: 0x1D58714 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1D5875C Offset: 0x1D5475C VA: 0x1D5875C Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1D58B5C Offset: 0x1D54B5C VA: 0x1D58B5C Slot: 29
	public override bool CheckInArea(Transform targetTransform) { }

	// RVA: 0x1D58BB0 Offset: 0x1D54BB0 VA: 0x1D58BB0 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1D58420 Offset: 0x1D54420 VA: 0x1D58420
	private void ActiveAttackArea() { }

	// RVA: 0x1D58574 Offset: 0x1D54574 VA: 0x1D58574
	private void RemoveAttackArea() { }

	// RVA: 0x1D56FB4 Offset: 0x1D52FB4 VA: 0x1D56FB4
	private void CreateTarget() { }
}

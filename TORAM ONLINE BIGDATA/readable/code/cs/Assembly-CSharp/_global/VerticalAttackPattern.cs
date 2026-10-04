// Assembly: Assembly-CSharp.dll
// Namespace: 
public class VerticalAttackPattern : MobPatternBase // TypeDefIndex: 837
{
	// Fields
	private readonly MobPatternTargetType[] targetTypes; // 0x70
	private MobAnimation mobAnimation; // 0x78
	private float attackRangeRed; // 0x80
	private List<MobPatternAttackData> attackList; // 0x88
	private float hitEffectTiming; // 0x90
	private bool isAttack; // 0x94
	private bool isAttackable; // 0x95
	private ElementType element; // 0x98

	// Properties
	public override bool IsTargetDirection { get; }
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1EC0118 Offset: 0x1EBC118 VA: 0x1EC0118 Slot: 6
	public override bool get_IsTargetDirection() { }

	// RVA: 0x1EC0120 Offset: 0x1EBC120 VA: 0x1EC0120 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1EC0128 Offset: 0x1EBC128 VA: 0x1EC0128 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1EC0158 Offset: 0x1EBC158 VA: 0x1EC0158
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1EC091C Offset: 0x1EBC91C VA: 0x1EC091C
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, List<MobActionTargetData> targetList, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1EC10A8 Offset: 0x1EBD0A8 VA: 0x1EC10A8 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1EC12C8 Offset: 0x1EBD2C8 VA: 0x1EC12C8 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1EC1438 Offset: 0x1EBD438 VA: 0x1EC1438 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1EC1590 Offset: 0x1EBD590 VA: 0x1EC1590 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1EC1750 Offset: 0x1EBD750 VA: 0x1EC1750 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1EC1B8C Offset: 0x1EBDB8C VA: 0x1EC1B8C Slot: 29
	public override bool CheckInArea(Transform targetTransform) { }

	// RVA: 0x1EC1BE0 Offset: 0x1EBDBE0 VA: 0x1EC1BE0 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1EC0364 Offset: 0x1EBC364 VA: 0x1EC0364
	private void CreateTargets() { }

	// RVA: 0x1EC0B30 Offset: 0x1EBCB30 VA: 0x1EC0B30
	private void CreateTargetsOther(List<MobActionTargetData> targetList) { }

	// RVA: 0x1EC15E8 Offset: 0x1EBD5E8 VA: 0x1EC15E8
	private void UpdateAttackArea() { }
}

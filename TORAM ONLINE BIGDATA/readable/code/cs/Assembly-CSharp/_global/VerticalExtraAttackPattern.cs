// Assembly: Assembly-CSharp.dll
// Namespace: 
public class VerticalExtraAttackPattern : MobPatternBase // TypeDefIndex: 839
{
	// Fields
	private readonly MobPatternTargetType[] targetTypes; // 0x70
	private readonly MobAnimation mobAnimation; // 0x78
	private readonly float attackRangeRed; // 0x80
	private readonly ElementType element; // 0x84
	private float hitEffectTiming; // 0x88
	private List<MobPatternAttackData> attackList; // 0x90
	private bool isAttacked; // 0x98

	// Properties
	public override bool IsTargetDirection { get; }
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }
	private bool IsAttackPosUpdate { get; }

	// Methods

	// RVA: 0x1EC1DBC Offset: 0x1EBDDBC VA: 0x1EC1DBC Slot: 6
	public override bool get_IsTargetDirection() { }

	// RVA: 0x1EC1DC4 Offset: 0x1EBDDC4 VA: 0x1EC1DC4 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1EC1DCC Offset: 0x1EBDDCC VA: 0x1EC1DCC Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1EC1DD4 Offset: 0x1EBDDD4 VA: 0x1EC1DD4
	private bool get_IsAttackPosUpdate() { }

	// RVA: 0x1EC1DF8 Offset: 0x1EBDDF8 VA: 0x1EC1DF8
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobActionManager, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1EC25CC Offset: 0x1EBE5CC VA: 0x1EC25CC
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobActionManager, GameObject target, List<MobActionTargetData> targetList, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1EC2D60 Offset: 0x1EBED60 VA: 0x1EC2D60 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1EC2F80 Offset: 0x1EBEF80 VA: 0x1EC2F80 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1EC30F0 Offset: 0x1EBF0F0 VA: 0x1EC30F0 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1EC3248 Offset: 0x1EBF248 VA: 0x1EC3248 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1EC3400 Offset: 0x1EBF400 VA: 0x1EC3400 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1EC2014 Offset: 0x1EBE014 VA: 0x1EC2014
	private void CreateTargets() { }

	// RVA: 0x1EC27E8 Offset: 0x1EBE7E8 VA: 0x1EC27E8
	private void CreateTargetsOther(List<MobActionTargetData> targetList) { }

	// RVA: 0x1EC32A0 Offset: 0x1EBF2A0 VA: 0x1EC32A0
	private void UpdateAttackArea() { }
}

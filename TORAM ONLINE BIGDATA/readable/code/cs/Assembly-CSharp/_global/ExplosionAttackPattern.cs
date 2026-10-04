// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ExplosionAttackPattern : MobPatternBase // TypeDefIndex: 758
{
	// Fields
	private readonly MobPatternTargetType[] targetTypes; // 0x70
	private readonly MobAnimation mobAnimation; // 0x78
	private readonly float attackRad; // 0x80
	private float hitEffectTiming; // 0x84
	private bool isAttack; // 0x88
	private List<MobPatternAttackData> attackList; // 0x90

	// Properties
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1C75838 Offset: 0x1C71838 VA: 0x1C75838 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1C75840 Offset: 0x1C71840 VA: 0x1C75840
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase actionManager, GameObject target, MobAnimation mobAnimation, float playSpeed) { }

	// RVA: 0x1C76030 Offset: 0x1C72030 VA: 0x1C76030
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase actionManager, GameObject target, MobAnimation mobAnimation, List<MobActionTargetData> targetList, float playSpeed) { }

	// RVA: 0x1C7679C Offset: 0x1C7279C VA: 0x1C7679C Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1C769BC Offset: 0x1C729BC VA: 0x1C769BC Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1C76B08 Offset: 0x1C72B08 VA: 0x1C76B08 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1C76C60 Offset: 0x1C72C60 VA: 0x1C76C60 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1C76E30 Offset: 0x1C72E30 VA: 0x1C76E30 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1C75A78 Offset: 0x1C71A78 VA: 0x1C75A78
	private void CreateTargets() { }

	// RVA: 0x1C76270 Offset: 0x1C72270 VA: 0x1C76270
	private void CreateTargetsOther(List<MobActionTargetData> targetList) { }

	// RVA: 0x1C76CC8 Offset: 0x1C72CC8 VA: 0x1C76CC8
	private void UpdateAttackArea() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ChantNormalAttackPattern : MobPatternBase // TypeDefIndex: 756
{
	// Fields
	private MobAnimation animation; // 0x70
	private int targetEffectUid; // 0x78

	// Properties
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1C74FD0 Offset: 0x1C70FD0 VA: 0x1C74FD0 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1C74FD8 Offset: 0x1C70FD8 VA: 0x1C74FD8
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation mobAnimation, float playSpeed) { }

	// RVA: 0x1C75380 Offset: 0x1C71380 VA: 0x1C75380
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 targetPos, MobAnimation mobAnimation, float playSpeed) { }

	// RVA: 0x1C75610 Offset: 0x1C71610 VA: 0x1C75610 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1C756DC Offset: 0x1C716DC VA: 0x1C756DC Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1C75750 Offset: 0x1C71750 VA: 0x1C75750 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1C7578C Offset: 0x1C7178C VA: 0x1C7578C Slot: 19
	protected override void OnChargeUpdate(bool end) { }
}

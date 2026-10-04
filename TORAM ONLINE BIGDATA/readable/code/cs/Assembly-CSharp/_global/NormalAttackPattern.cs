// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NormalAttackPattern : MobPatternBase // TypeDefIndex: 808
{
	// Fields
	private MobAnimation animation; // 0x70

	// Properties
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1E186A8 Offset: 0x1E146A8 VA: 0x1E186A8 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E186B0 Offset: 0x1E146B0 VA: 0x1E186B0
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation mobAnimation, float playSpeed) { }

	// RVA: 0x1E18730 Offset: 0x1E14730 VA: 0x1E18730 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E187AC Offset: 0x1E147AC VA: 0x1E187AC Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E187B0 Offset: 0x1E147B0 VA: 0x1E187B0 Slot: 24
	protected override PatternCommand OnPostUpdate() { }
}

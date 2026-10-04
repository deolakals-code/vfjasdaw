// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BlackHoleExtraPattern : MobPatternBase // TypeDefIndex: 742
{
	// Fields
	private readonly Vector3 startPos; // 0x70
	private readonly ElementType element; // 0x7C

	// Properties
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1C6C548 Offset: 0x1C68548 VA: 0x1C6C548
	public void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase actionManager, GameObject target, Vector3 bulletPos) { }

	// RVA: 0x1C6C5AC Offset: 0x1C685AC VA: 0x1C6C5AC Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1C6C5B4 Offset: 0x1C685B4 VA: 0x1C6C5B4 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1C6C5B8 Offset: 0x1C685B8 VA: 0x1C6C5B8 Slot: 24
	protected override PatternCommand OnPostUpdate() { }
}

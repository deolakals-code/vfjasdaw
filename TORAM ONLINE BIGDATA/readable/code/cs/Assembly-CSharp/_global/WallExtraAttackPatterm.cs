// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WallExtraAttackPatterm : MobPatternBase // TypeDefIndex: 842
{
	// Fields
	private readonly Vector3 startPos; // 0x70
	private readonly ElementType element; // 0x7C

	// Properties
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1EC5790 Offset: 0x1EC1790 VA: 0x1EC5790 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1EC5798 Offset: 0x1EC1798 VA: 0x1EC5798
	public void .ctor(MobActionPattern pattern, EnemyMobActionManagerBase actionManager, GameObject target, Vector3 bulletPos) { }

	// RVA: 0x1EC57FC Offset: 0x1EC17FC VA: 0x1EC57FC Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1EC5800 Offset: 0x1EC1800 VA: 0x1EC5800 Slot: 24
	protected override PatternCommand OnPostUpdate() { }
}

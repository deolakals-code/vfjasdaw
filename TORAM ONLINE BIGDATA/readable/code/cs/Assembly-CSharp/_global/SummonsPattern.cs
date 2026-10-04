// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummonsPattern : MobPatternBase // TypeDefIndex: 827
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private bool isAttackSoundTiming; // 0x78

	// Properties
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1E1FA04 Offset: 0x1E1BA04 VA: 0x1E1FA04 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E1FA0C Offset: 0x1E1BA0C VA: 0x1E1FA0C Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E1FA14 Offset: 0x1E1BA14 VA: 0x1E1FA14
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAction, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E1FA9C Offset: 0x1E1BA9C VA: 0x1E1FA9C Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E1FB0C Offset: 0x1E1BB0C VA: 0x1E1FB0C Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E1FB44 Offset: 0x1E1BB44 VA: 0x1E1FB44 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E1FB88 Offset: 0x1E1BB88 VA: 0x1E1FB88 Slot: 24
	protected override PatternCommand OnPostUpdate() { }
}

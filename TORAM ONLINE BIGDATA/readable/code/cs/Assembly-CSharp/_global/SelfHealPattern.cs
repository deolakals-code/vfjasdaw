// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SelfHealPattern : MobPatternBase // TypeDefIndex: 825
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private int healValue; // 0x78
	private int healPercentValue; // 0x7C
	private bool isAttackSoundTiming; // 0x80

	// Properties
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1E1EED4 Offset: 0x1E1AED4 VA: 0x1E1EED4 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E1EEDC Offset: 0x1E1AEDC VA: 0x1E1EEDC Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E1EEE4 Offset: 0x1E1AEE4 VA: 0x1E1EEE4
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E1F0E4 Offset: 0x1E1B0E4 VA: 0x1E1F0E4 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E1F1B0 Offset: 0x1E1B1B0 VA: 0x1E1F1B0 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E1F1E8 Offset: 0x1E1B1E8 VA: 0x1E1F1E8 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E1F22C Offset: 0x1E1B22C VA: 0x1E1F22C Slot: 24
	protected override PatternCommand OnPostUpdate() { }
}

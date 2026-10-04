// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SelfInjuryPattern : MobPatternBase // TypeDefIndex: 826
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private float rot; // 0x78
	private CharacterMove charaMove; // 0x80
	private bool isAttackSoundTiming; // 0x88

	// Properties
	public override KnockBackResistType KnockBackResist { get; }
	public override bool IsTargetDirection { get; }
	public override bool IsDead { get; }
	public override bool IsForceAddAbnormal { get; }
	public override bool IsDisplayDamageLabel { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1E1F284 Offset: 0x1E1B284 VA: 0x1E1F284 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E1F28C Offset: 0x1E1B28C VA: 0x1E1F28C Slot: 6
	public override bool get_IsTargetDirection() { }

	// RVA: 0x1E1F294 Offset: 0x1E1B294 VA: 0x1E1F294 Slot: 8
	public override bool get_IsDead() { }

	// RVA: 0x1E1F2B8 Offset: 0x1E1B2B8 VA: 0x1E1F2B8 Slot: 12
	public override bool get_IsForceAddAbnormal() { }

	// RVA: 0x1E1F2E0 Offset: 0x1E1B2E0 VA: 0x1E1F2E0 Slot: 14
	public override bool get_IsDisplayDamageLabel() { }

	// RVA: 0x1E1F308 Offset: 0x1E1B308 VA: 0x1E1F308 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E1F310 Offset: 0x1E1B310 VA: 0x1E1F310
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAction, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E1F788 Offset: 0x1E1B788 VA: 0x1E1F788 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E1F8F8 Offset: 0x1E1B8F8 VA: 0x1E1F8F8 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E1F8FC Offset: 0x1E1B8FC VA: 0x1E1F8FC Slot: 20
	protected override bool OnPreUpdate() { }

	// RVA: 0x1E1F9C8 Offset: 0x1E1B9C8 VA: 0x1E1F9C8 Slot: 24
	protected override PatternCommand OnPostUpdate() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PerformancePattern : MobPatternBase // TypeDefIndex: 813
{
	// Fields
	private PerformancePattern.Flag flag; // 0x70
	private PerformancePattern.State state; // 0x74
	private float rot; // 0x78
	private int playId; // 0x7C
	private int loopCount; // 0x80
	private CharacterMove charaMove; // 0x88
	private MobAnimation animation; // 0x90
	private PerformancePattern.MotionState motionState; // 0x98

	// Properties
	public override bool IsTargetDirection { get; }
	public override bool IsTarget { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1E18808 Offset: 0x1E14808 VA: 0x1E18808 Slot: 6
	public override bool get_IsTargetDirection() { }

	// RVA: 0x1E18838 Offset: 0x1E14838 VA: 0x1E18838 Slot: 7
	public override bool get_IsTarget() { }

	// RVA: 0x1E18848 Offset: 0x1E14848 VA: 0x1E18848 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E18850 Offset: 0x1E14850 VA: 0x1E18850
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E1898C Offset: 0x1E1498C VA: 0x1E1898C Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E18B20 Offset: 0x1E14B20 VA: 0x1E18B20 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E18B24 Offset: 0x1E14B24 VA: 0x1E18B24 Slot: 28
	public override void OnDamage(bool isPlayerManaged) { }

	// RVA: 0x1E18B30 Offset: 0x1E14B30 VA: 0x1E18B30 Slot: 20
	protected override bool OnPreUpdate() { }

	// RVA: 0x1E18C08 Offset: 0x1E14C08 VA: 0x1E18C08 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E18AF0 Offset: 0x1E14AF0 VA: 0x1E18AF0
	private void OncePlay(int playId) { }
}

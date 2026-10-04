// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PointRushPattern : MobPatternBase // TypeDefIndex: 818
{
	// Fields
	private readonly MobAnimation animation; // 0x70
	private readonly CharacterMove charaMove; // 0x78
	private readonly PointRushPattern.Flag flag; // 0x80
	private readonly float attackRange; // 0x84
	private List<Transform> hitTargetList; // 0x88
	private PointRushPattern.RushState state; // 0x90
	private AttackArea attackArea; // 0x98
	private float moveTime; // 0xA0
	private bool checkMoveFrame; // 0xA4
	private float warningFloorReducedTime; // 0xA8
	private Vector3 startPos; // 0xAC
	private bool rotate; // 0xB8
	private bool isHitNextAttack; // 0xB9

	// Properties
	public override bool VisibleAttackArea { get; }
	public override KnockBackResistType KnockBackResist { get; }

	// Methods

	// RVA: 0x1E1ADB0 Offset: 0x1E16DB0 VA: 0x1E1ADB0
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAction, GameObject target, MobAnimation animation, CharacterMove charaMove, float playSpeed) { }

	// RVA: 0x1E1B058 Offset: 0x1E17058 VA: 0x1E1B058 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E1B098 Offset: 0x1E17098 VA: 0x1E1B098 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E1B0A0 Offset: 0x1E170A0 VA: 0x1E1B0A0 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E1B734 Offset: 0x1E17734 VA: 0x1E1B734 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E1B830 Offset: 0x1E17830 VA: 0x1E1B830 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1E1B838 Offset: 0x1E17838 VA: 0x1E1B838 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E1B8E4 Offset: 0x1E178E4 VA: 0x1E1B8E4 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E1BBC0 Offset: 0x1E17BC0 VA: 0x1E1BBC0 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1E1BC50 Offset: 0x1E17C50 VA: 0x1E1BC50 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1E1BD9C Offset: 0x1E17D9C VA: 0x1E1BD9C Slot: 32
	public override bool CheckRayArea(Vector3 position, Vector3 ray, float dist) { }

	// RVA: 0x1E1BE68 Offset: 0x1E17E68 VA: 0x1E1BE68 Slot: 25
	public override void LateUpdate() { }

	// RVA: 0x1E1BF2C Offset: 0x1E17F2C VA: 0x1E1BF2C Slot: 27
	public override void OnAttackDamage() { }

	// RVA: 0x1E1BFA0 Offset: 0x1E17FA0 VA: 0x1E1BFA0 Slot: 35
	public override float[] GetAttackRange() { }

	// RVA: 0x1E1B7FC Offset: 0x1E177FC VA: 0x1E1B7FC
	private void DestroyAttackArea() { }

	[CompilerGenerated]
	// RVA: 0x1E1C008 Offset: 0x1E18008 VA: 0x1E1C008
	private void <OnPostUpdate>b__24_1() { }

	[CompilerGenerated]
	// RVA: 0x1E1C03C Offset: 0x1E1803C VA: 0x1E1C03C
	private void <OnPostUpdate>b__24_0() { }
}

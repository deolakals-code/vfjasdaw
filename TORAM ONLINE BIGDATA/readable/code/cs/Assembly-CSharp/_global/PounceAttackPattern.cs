// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PounceAttackPattern : MobPatternBase, ICircleparam // TypeDefIndex: 820
{
	// Fields
	private readonly MobPatternTargetType[] targetTypes; // 0x70
	private CharacterMove charaMove; // 0x78
	private MobAnimation animation; // 0x80
	private int chargeMotionId; // 0x88
	private float attackRange; // 0x8C
	private AttackArea attackArea; // 0x90
	private float warningFloorReducedTime; // 0x98
	private int state; // 0x9C
	private float moveStartWaitTime; // 0xA0
	private float moveTime; // 0xA4

	// Properties
	public override bool VisibleAttackArea { get; }
	public Vector3 CenterPosition { get; }

	// Methods

	// RVA: 0x1E1C044 Offset: 0x1E18044 VA: 0x1E1C044
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAction, CharacterMove charaMove, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E1C3BC Offset: 0x1E183BC VA: 0x1E1C3BC
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAction, CharacterMove charaMove, GameObject target, Vector3 targetPos, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E1C534 Offset: 0x1E18534 VA: 0x1E1C534 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E1C554 Offset: 0x1E18554 VA: 0x1E1C554 Slot: 36
	public Vector3 get_CenterPosition() { }

	// RVA: 0x1E1C560 Offset: 0x1E18560 VA: 0x1E1C560 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E1C7A0 Offset: 0x1E187A0 VA: 0x1E1C7A0 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E1C850 Offset: 0x1E18850 VA: 0x1E1C850 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E1C8C8 Offset: 0x1E188C8 VA: 0x1E1C8C8 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E1CA50 Offset: 0x1E18A50 VA: 0x1E1CA50 Slot: 30
	public override bool CheckInAreaNotCheckVisible(Transform targetTransform) { }

	// RVA: 0x1E1CAB0 Offset: 0x1E18AB0 VA: 0x1E1CAB0 Slot: 31
	public override bool CheckHit(Transform targetTransform) { }

	// RVA: 0x1E1C1C0 Offset: 0x1E181C0 VA: 0x1E1C1C0
	private void CreateAttackPos() { }

	// RVA: 0x1E1C6C0 Offset: 0x1E186C0 VA: 0x1E1C6C0
	private void CreateAttackArea() { }

	// RVA: 0x1E1C814 Offset: 0x1E18814 VA: 0x1E1C814
	private void HideAttackArea() { }

	// RVA: 0x1E1CB10 Offset: 0x1E18B10 VA: 0x1E1CB10 Slot: 37
	public bool CheckNearCircumfrence(Transform targetTransform) { }
}

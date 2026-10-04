// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MovePattern : MobPatternBase // TypeDefIndex: 804
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private CharacterMove charaMove; // 0x78
	private float moveTime; // 0x80
	private bool moveEnd; // 0x84

	// Properties
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1E16594 Offset: 0x1E12594 VA: 0x1E16594 Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E1659C Offset: 0x1E1259C VA: 0x1E1659C Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E165A4 Offset: 0x1E125A4 VA: 0x1E165A4
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E16898 Offset: 0x1E12898 VA: 0x1E16898
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 moveTarget, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E16A00 Offset: 0x1E12A00 VA: 0x1E16A00 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E16C3C Offset: 0x1E12C3C VA: 0x1E16C3C Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E16ED0 Offset: 0x1E12ED0 VA: 0x1E16ED0 Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1E16F88 Offset: 0x1E12F88 VA: 0x1E16F88 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E16F94 Offset: 0x1E12F94 VA: 0x1E16F94 Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E16AD4 Offset: 0x1E12AD4 VA: 0x1E16AD4
	private void SetMoveDirection(MovePattern.MoveDirection dir) { }

	// RVA: 0x1E16B38 Offset: 0x1E12B38 VA: 0x1E16B38
	private void StartMove() { }

	// RVA: 0x1E16CB0 Offset: 0x1E12CB0 VA: 0x1E16CB0
	private bool EndMoveLoop() { }

	[CompilerGenerated]
	// RVA: 0x1E16FF4 Offset: 0x1E12FF4 VA: 0x1E16FF4
	private void <StartMove>b__17_0() { }
}

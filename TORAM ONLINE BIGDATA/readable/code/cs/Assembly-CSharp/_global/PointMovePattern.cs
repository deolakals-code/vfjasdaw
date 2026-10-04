// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PointMovePattern : MobPatternBase // TypeDefIndex: 815
{
	// Fields
	private MobAnimation mobAnimation; // 0x70
	private CharacterMove charaMove; // 0x78
	private float moveTime; // 0x80
	private float rotateTime; // 0x84
	private bool moveEnd; // 0x88
	private bool rotateEnd; // 0x89
	private bool motionCheck; // 0x8A
	private bool motionEnd; // 0x8B

	// Properties
	public override KnockBackResistType KnockBackResist { get; }
	public override bool VisibleAttackArea { get; }

	// Methods

	// RVA: 0x1E1A17C Offset: 0x1E1617C VA: 0x1E1A17C Slot: 5
	public override KnockBackResistType get_KnockBackResist() { }

	// RVA: 0x1E1A184 Offset: 0x1E16184 VA: 0x1E1A184 Slot: 4
	public override bool get_VisibleAttackArea() { }

	// RVA: 0x1E1A18C Offset: 0x1E1618C VA: 0x1E1A18C
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E1A3EC Offset: 0x1E163EC VA: 0x1E1A3EC
	public void .ctor(MobAttackBase action, EnemyMobActionManagerBase mobAct, GameObject target, Vector3 moveTarget, MobAnimation animation, float playSpeed) { }

	// RVA: 0x1E1A618 Offset: 0x1E16618 VA: 0x1E1A618 Slot: 17
	public override void Initialize(bool other) { }

	// RVA: 0x1E1A7D8 Offset: 0x1E167D8 VA: 0x1E1A7D8 Slot: 18
	public override void ActionCancel() { }

	// RVA: 0x1E1A7DC Offset: 0x1E167DC VA: 0x1E1A7DC Slot: 26
	public override void OnEnd() { }

	// RVA: 0x1E1AA50 Offset: 0x1E16A50 VA: 0x1E1AA50 Slot: 19
	protected override void OnChargeUpdate(bool end) { }

	// RVA: 0x1E1AA5C Offset: 0x1E16A5C VA: 0x1E1AA5C Slot: 24
	protected override PatternCommand OnPostUpdate() { }

	// RVA: 0x1E1A6D4 Offset: 0x1E166D4 VA: 0x1E1A6D4
	private void StartMove() { }

	// RVA: 0x1E1A830 Offset: 0x1E16830 VA: 0x1E1A830
	private bool EndMoveLoop() { }

	[CompilerGenerated]
	// RVA: 0x1E1AD80 Offset: 0x1E16D80 VA: 0x1E1AD80
	private void <OnPostUpdate>b__18_0() { }

	[CompilerGenerated]
	// RVA: 0x1E1AD8C Offset: 0x1E16D8C VA: 0x1E1AD8C
	private void <StartMove>b__19_0() { }
}

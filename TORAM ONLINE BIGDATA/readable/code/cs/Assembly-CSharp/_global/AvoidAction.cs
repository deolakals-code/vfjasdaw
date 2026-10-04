// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AvoidAction : PlayerAttackBase // TypeDefIndex: 1483
{
	// Fields
	private AvoidAction.CharacterMoveDirection charaDir; // 0x120

	// Properties
	public override int ActionID { get; }
	public override bool NoCost { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override bool IsEventIgnoreOther { get; }

	// Methods

	// RVA: 0x205AB8C Offset: 0x2056B8C VA: 0x205AB8C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x205AB94 Offset: 0x2056B94 VA: 0x205AB94 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x205AB9C Offset: 0x2056B9C VA: 0x205AB9C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x205ABA4 Offset: 0x2056BA4 VA: 0x205ABA4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x205ABAC Offset: 0x2056BAC VA: 0x205ABAC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x205ABB4 Offset: 0x2056BB4 VA: 0x205ABB4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x205ABBC Offset: 0x2056BBC VA: 0x205ABBC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x205ABC4 Offset: 0x2056BC4 VA: 0x205ABC4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x205ABCC Offset: 0x2056BCC VA: 0x205ABCC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x205ABD4 Offset: 0x2056BD4 VA: 0x205ABD4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x205ABDC Offset: 0x2056BDC VA: 0x205ABDC Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x205ABE4 Offset: 0x2056BE4 VA: 0x205ABE4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x205ABEC Offset: 0x2056BEC VA: 0x205ABEC Slot: 30
	public override bool get_IsEventIgnoreOther() { }

	// RVA: 0x205ABF4 Offset: 0x2056BF4 VA: 0x205ABF4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x205B400 Offset: 0x2057400 VA: 0x205B400 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x205B7EC Offset: 0x20577EC VA: 0x205B7EC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x205B7F0 Offset: 0x20577F0 VA: 0x205B7F0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x205AE44 Offset: 0x2056E44 VA: 0x205AE44
	public static Vector3 CalcMoveAngle(Transform transform) { }

	// RVA: 0x205B00C Offset: 0x205700C VA: 0x205B00C
	private SkillLinkedTake CreateTake(float angle, Vector3 moveVec, Vector3 effectPos, out AvoidAction.CharacterMoveDirection charaDir) { }

	// RVA: 0x2053B00 Offset: 0x204FB00 VA: 0x2053B00
	public void .ctor() { }
}

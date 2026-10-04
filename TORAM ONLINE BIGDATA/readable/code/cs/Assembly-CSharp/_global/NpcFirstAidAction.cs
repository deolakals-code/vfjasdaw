// Assembly: Assembly-CSharp.dll
// Namespace: 
public class NpcFirstAidAction : PlayerAttackBase // TypeDefIndex: 3714
{
	// Fields
	private int cost; // 0x120

	// Properties
	public override int ActionID { get; }
	public override bool IsMoveAssistContinue { get; }
	public override bool IsSupport { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }

	// Methods

	// RVA: 0x23D1E44 Offset: 0x23CDE44 VA: 0x23D1E44 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23D1E4C Offset: 0x23CDE4C VA: 0x23D1E4C Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x23D1E54 Offset: 0x23CDE54 VA: 0x23D1E54 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D1E5C Offset: 0x23CDE5C VA: 0x23D1E5C Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D1E64 Offset: 0x23CDE64 VA: 0x23D1E64 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D1E6C Offset: 0x23CDE6C VA: 0x23D1E6C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D1E74 Offset: 0x23CDE74 VA: 0x23D1E74 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D1E7C Offset: 0x23CDE7C VA: 0x23D1E7C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D1E84 Offset: 0x23CDE84 VA: 0x23D1E84 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D1E8C Offset: 0x23CDE8C VA: 0x23D1E8C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D1E94 Offset: 0x23CDE94 VA: 0x23D1E94 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D1E9C Offset: 0x23CDE9C VA: 0x23D1E9C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D201C Offset: 0x23CE01C VA: 0x23D201C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D20B0 Offset: 0x23CE0B0 VA: 0x23D20B0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D214C Offset: 0x23CE14C VA: 0x23D214C
	public void .ctor() { }
}

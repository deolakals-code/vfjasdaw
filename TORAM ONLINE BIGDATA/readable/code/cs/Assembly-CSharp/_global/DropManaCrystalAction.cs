// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DropManaCrystalAction : PlayerAttackBase // TypeDefIndex: 3638
{
	// Properties
	public override int ActionID { get; }
	public override bool NoCost { get; }
	public override int BaseMp { get; }
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsExpDefFluctuate { get; }
	public override bool IsNoMotionTake { get; }

	// Methods

	// RVA: 0x23B5BE8 Offset: 0x23B1BE8 VA: 0x23B5BE8 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23B5BF0 Offset: 0x23B1BF0 VA: 0x23B5BF0 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x23B5BF8 Offset: 0x23B1BF8 VA: 0x23B5BF8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B5C00 Offset: 0x23B1C00 VA: 0x23B5C00 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B5C08 Offset: 0x23B1C08 VA: 0x23B5C08 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B5C10 Offset: 0x23B1C10 VA: 0x23B5C10 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B5C18 Offset: 0x23B1C18 VA: 0x23B5C18 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B5C20 Offset: 0x23B1C20 VA: 0x23B5C20 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B5C28 Offset: 0x23B1C28 VA: 0x23B5C28 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B5C30 Offset: 0x23B1C30 VA: 0x23B5C30 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B5C38 Offset: 0x23B1C38 VA: 0x23B5C38 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x23B5C40 Offset: 0x23B1C40 VA: 0x23B5C40 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x23B5C48 Offset: 0x23B1C48 VA: 0x23B5C48 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B5CB8 Offset: 0x23B1CB8 VA: 0x23B5CB8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B5CC4 Offset: 0x23B1CC4 VA: 0x23B5CC4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B5F10 Offset: 0x23B1F10 VA: 0x23B5F10
	public static bool CalcMasterToFamiliaCenter(Vector3 masterPos, Vector3 familiaPos, out Vector3 center) { }

	// RVA: 0x23B613C Offset: 0x23B213C VA: 0x23B613C
	public void .ctor() { }
}

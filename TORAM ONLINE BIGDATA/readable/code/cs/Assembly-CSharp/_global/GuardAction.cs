// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GuardAction : PlayerAttackBase // TypeDefIndex: 1491
{
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

	// Methods

	// RVA: 0x2061C38 Offset: 0x205DC38 VA: 0x2061C38 Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x2061C40 Offset: 0x205DC40 VA: 0x2061C40 Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x2061C48 Offset: 0x205DC48 VA: 0x2061C48 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2061C50 Offset: 0x205DC50 VA: 0x2061C50 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2061C58 Offset: 0x205DC58 VA: 0x2061C58 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2061C60 Offset: 0x205DC60 VA: 0x2061C60 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2061C68 Offset: 0x205DC68 VA: 0x2061C68 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2061C70 Offset: 0x205DC70 VA: 0x2061C70 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2061C78 Offset: 0x205DC78 VA: 0x2061C78 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2061C80 Offset: 0x205DC80 VA: 0x2061C80 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2061C88 Offset: 0x205DC88 VA: 0x2061C88 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x2061C90 Offset: 0x205DC90 VA: 0x2061C90 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x2061C98 Offset: 0x205DC98 VA: 0x2061C98 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2061EC4 Offset: 0x205DEC4 VA: 0x2061EC4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2053828 Offset: 0x204F828 VA: 0x2053828
	public void UpdateDamageGuardTake() { }

	// RVA: 0x2061DA4 Offset: 0x205DDA4 VA: 0x2061DA4
	private int GetGuardTakeId(ItemDBData.ItemType weaponType, ItemDBData.ItemType subWeaponType) { }

	// RVA: 0x2053654 Offset: 0x204F654 VA: 0x2053654
	public void .ctor() { }
}

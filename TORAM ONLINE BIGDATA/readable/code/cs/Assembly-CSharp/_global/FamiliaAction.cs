// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FamiliaAction : PlayerAttackBase // TypeDefIndex: 3653
{
	// Properties
	public override int ActionID { get; }
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsSupport { get; }
	public override bool IsSupportChangeEndTiming { get; }
	public override SkillChargingType ChargingType { get; }

	// Methods

	// RVA: 0x23BA7FC Offset: 0x23B67FC VA: 0x23BA7FC Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x23BA804 Offset: 0x23B6804 VA: 0x23BA804 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23BA80C Offset: 0x23B680C VA: 0x23BA80C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23BA814 Offset: 0x23B6814 VA: 0x23BA814 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23BA81C Offset: 0x23B681C VA: 0x23BA81C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23BA824 Offset: 0x23B6824 VA: 0x23BA824 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23BA82C Offset: 0x23B682C VA: 0x23BA82C Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23BA834 Offset: 0x23B6834 VA: 0x23BA834 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23BA83C Offset: 0x23B683C VA: 0x23BA83C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23BA844 Offset: 0x23B6844 VA: 0x23BA844 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23BA84C Offset: 0x23B684C VA: 0x23BA84C Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x23BA854 Offset: 0x23B6854 VA: 0x23BA854 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23BA85C Offset: 0x23B685C VA: 0x23BA85C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23BA9B4 Offset: 0x23B69B4 VA: 0x23BA9B4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BA9D4 Offset: 0x23B69D4 VA: 0x23BA9D4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23BAA9C Offset: 0x23B6A9C VA: 0x23BAA9C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BAB48 Offset: 0x23B6B48 VA: 0x23BAB48
	public static Vector3 CenterShiftPos(Transform transform) { }

	// RVA: 0x23BAE8C Offset: 0x23B6E8C VA: 0x23BAE8C
	public void .ctor() { }
}

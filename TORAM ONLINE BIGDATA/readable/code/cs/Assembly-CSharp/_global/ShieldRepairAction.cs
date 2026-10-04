// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShieldRepairAction : PlayerAttackBase // TypeDefIndex: 3744
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override SkillChargingType ChargingType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }

	// Methods

	// RVA: 0x23DADC0 Offset: 0x23D6DC0 VA: 0x23DADC0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23DADC8 Offset: 0x23D6DC8 VA: 0x23DADC8 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23DADD0 Offset: 0x23D6DD0 VA: 0x23DADD0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23DADD8 Offset: 0x23D6DD8 VA: 0x23DADD8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23DADE0 Offset: 0x23D6DE0 VA: 0x23DADE0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23DADE8 Offset: 0x23D6DE8 VA: 0x23DADE8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23DADF0 Offset: 0x23D6DF0 VA: 0x23DADF0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23DADF8 Offset: 0x23D6DF8 VA: 0x23DADF8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23DAE00 Offset: 0x23D6E00 VA: 0x23DAE00 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23DAE08 Offset: 0x23D6E08 VA: 0x23DAE08 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23DAE10 Offset: 0x23D6E10 VA: 0x23DAE10 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23DAF0C Offset: 0x23D6F0C VA: 0x23DAF0C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23DB028 Offset: 0x23D7028 VA: 0x23DB028 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23DB0B8 Offset: 0x23D70B8 VA: 0x23DB0B8
	public void .ctor() { }
}

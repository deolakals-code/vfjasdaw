// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DrainBarrierAction : PlayerAttackBase // TypeDefIndex: 3637
{
	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool IsSupport { get; }
	public override bool IsSupportChangeEndTiming { get; }

	// Methods

	// RVA: 0x23B4F88 Offset: 0x23B0F88 VA: 0x23B4F88 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23B4F90 Offset: 0x23B0F90 VA: 0x23B4F90 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23B4F98 Offset: 0x23B0F98 VA: 0x23B4F98 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23B4FA0 Offset: 0x23B0FA0 VA: 0x23B4FA0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23B4FA8 Offset: 0x23B0FA8 VA: 0x23B4FA8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23B4FB0 Offset: 0x23B0FB0 VA: 0x23B4FB0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23B4FB8 Offset: 0x23B0FB8 VA: 0x23B4FB8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23B4FC0 Offset: 0x23B0FC0 VA: 0x23B4FC0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23B4FC8 Offset: 0x23B0FC8 VA: 0x23B4FC8 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23B4FD0 Offset: 0x23B0FD0 VA: 0x23B4FD0 Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x23B4FD8 Offset: 0x23B0FD8 VA: 0x23B4FD8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23B507C Offset: 0x23B107C VA: 0x23B507C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23B543C Offset: 0x23B143C VA: 0x23B543C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23B5574 Offset: 0x23B1574 VA: 0x23B5574
	public static void DamageFunction(PlayerActionManagerBase playerAction, MobAttackBase mobAttack) { }

	// RVA: 0x23B57D4 Offset: 0x23B17D4 VA: 0x23B57D4
	public static void DamageFunction(PlayerActionManagerBase playerAction, MobaMobResponseData responseData) { }

	// RVA: 0x23B5B04 Offset: 0x23B1B04 VA: 0x23B5B04
	public void .ctor() { }
}

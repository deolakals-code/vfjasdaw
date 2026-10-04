// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HighFamiliaAction : PlayerAttackBase // TypeDefIndex: 3677
{
	// Fields
	public static readonly SkillId[] ControlBufSkillId; // 0x0

	// Properties
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

	// RVA: 0x23C2494 Offset: 0x23BE494 VA: 0x23C2494 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C249C Offset: 0x23BE49C VA: 0x23C249C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23C24A4 Offset: 0x23BE4A4 VA: 0x23C24A4 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C24AC Offset: 0x23BE4AC VA: 0x23C24AC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C24B4 Offset: 0x23BE4B4 VA: 0x23C24B4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C24BC Offset: 0x23BE4BC VA: 0x23C24BC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C24C4 Offset: 0x23BE4C4 VA: 0x23C24C4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C24CC Offset: 0x23BE4CC VA: 0x23C24CC Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C24D4 Offset: 0x23BE4D4 VA: 0x23C24D4 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C24DC Offset: 0x23BE4DC VA: 0x23C24DC Slot: 68
	public override bool get_IsSupportChangeEndTiming() { }

	// RVA: 0x23C24E4 Offset: 0x23BE4E4 VA: 0x23C24E4 Slot: 27
	public override SkillChargingType get_ChargingType() { }

	// RVA: 0x23C24EC Offset: 0x23BE4EC VA: 0x23C24EC Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C2644 Offset: 0x23BE644 VA: 0x23C2644 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C2664 Offset: 0x23BE664 VA: 0x23C2664 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23C26E0 Offset: 0x23BE6E0 VA: 0x23C26E0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C27A8 Offset: 0x23BE7A8 VA: 0x23C27A8 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C2854 Offset: 0x23BE854 VA: 0x23C2854
	private Vector3 CenterShiftPos(Transform transform) { }

	// RVA: 0x23C2B98 Offset: 0x23BEB98 VA: 0x23C2B98
	public static float GetCoolTime(int skillLevel) { }

	// RVA: 0x23C2BB8 Offset: 0x23BEBB8 VA: 0x23C2BB8
	public static float GetLightningPowerUpValue(int skillLevel) { }

	// RVA: 0x23C2BD4 Offset: 0x23BEBD4 VA: 0x23C2BD4
	public static float GetBlizzardPowerUpValue(int skillLevel) { }

	// RVA: 0x23C2C14 Offset: 0x23BEC14 VA: 0x23C2C14
	public static float GetMeteorStrikePowerUpValue(int skillLevel) { }

	// RVA: 0x23C2C30 Offset: 0x23BEC30 VA: 0x23C2C30
	public void .ctor() { }

	// RVA: 0x23C2C38 Offset: 0x23BEC38 VA: 0x23C2C38
	private static void .cctor() { }
}

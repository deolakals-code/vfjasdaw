// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TwinStormAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 3762
{
	// Fields
	public const int TakeId = 200513000;

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
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x23E14D8 Offset: 0x23DD4D8 VA: 0x23E14D8 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23E14E0 Offset: 0x23DD4E0 VA: 0x23E14E0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23E14E8 Offset: 0x23DD4E8 VA: 0x23E14E8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23E14F0 Offset: 0x23DD4F0 VA: 0x23E14F0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23E14F8 Offset: 0x23DD4F8 VA: 0x23E14F8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23E1500 Offset: 0x23DD500 VA: 0x23E1500 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23E1508 Offset: 0x23DD508 VA: 0x23E1508 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23E1510 Offset: 0x23DD510 VA: 0x23E1510 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23E1518 Offset: 0x23DD518 VA: 0x23E1518 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23E1520 Offset: 0x23DD520 VA: 0x23E1520 Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x23E1528 Offset: 0x23DD528 VA: 0x23E1528 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23E160C Offset: 0x23DD60C VA: 0x23E160C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23E168C Offset: 0x23DD68C VA: 0x23E168C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23E1828 Offset: 0x23DD828 VA: 0x23E1828 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23E1A44 Offset: 0x23DDA44 VA: 0x23E1A44
	public static void ValidDamageUp(PlayerActionManagerBase actionManager, SkillActionBase action) { }

	// RVA: 0x23E1BC8 Offset: 0x23DDBC8 VA: 0x23E1BC8
	public static void InvalidDamageUp(PlayerActionManagerBase actionManager) { }

	// RVA: 0x23E1C60 Offset: 0x23DDC60 VA: 0x23E1C60
	public void .ctor() { }
}

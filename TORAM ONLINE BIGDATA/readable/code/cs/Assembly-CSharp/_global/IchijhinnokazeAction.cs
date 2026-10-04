// Assembly: Assembly-CSharp.dll
// Namespace: 
public class IchijhinnokazeAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 3684
{
	// Fields
	public const int MotionTakeId = 201221000;

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
	public override string LocalizeKey { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x23C4D28 Offset: 0x23C0D28 VA: 0x23C4D28 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23C4D30 Offset: 0x23C0D30 VA: 0x23C4D30 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23C4D38 Offset: 0x23C0D38 VA: 0x23C4D38 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23C4D40 Offset: 0x23C0D40 VA: 0x23C4D40 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23C4D48 Offset: 0x23C0D48 VA: 0x23C4D48 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23C4D50 Offset: 0x23C0D50 VA: 0x23C4D50 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23C4D58 Offset: 0x23C0D58 VA: 0x23C4D58 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23C4D60 Offset: 0x23C0D60 VA: 0x23C4D60 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23C4D68 Offset: 0x23C0D68 VA: 0x23C4D68 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23C4D70 Offset: 0x23C0D70 VA: 0x23C4D70 Slot: 21
	public override string get_LocalizeKey() { }

	// RVA: 0x23C4DB0 Offset: 0x23C0DB0 VA: 0x23C4DB0 Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x23C4DB8 Offset: 0x23C0DB8 VA: 0x23C4DB8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23C4E9C Offset: 0x23C0E9C VA: 0x23C4E9C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23C50AC Offset: 0x23C10AC VA: 0x23C50AC Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23C52C8 Offset: 0x23C12C8 VA: 0x23C52C8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23C5408 Offset: 0x23C1408 VA: 0x23C5408
	public static void ReceiveEventSupport(SupportResultData supportData) { }

	// RVA: 0x23C5524 Offset: 0x23C1524 VA: 0x23C5524
	public static void NormalAttackDamaged(PlayerActionManagerBase actorAction, SkillDamageData damageData) { }

	// RVA: 0x23C5650 Offset: 0x23C1650 VA: 0x23C5650
	public static void UpdateFirstAttackParam(PlayerStatusBase status) { }

	// RVA: 0x23C5714 Offset: 0x23C1714 VA: 0x23C5714
	public static void ResetSpecialAcion(PlayerStatusBase status) { }

	// RVA: 0x23C5840 Offset: 0x23C1840 VA: 0x23C5840
	public void .ctor() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SaberAuraAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 3740
{
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
	public override bool IsOverlay { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x23D9958 Offset: 0x23D5958 VA: 0x23D9958 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23D9960 Offset: 0x23D5960 VA: 0x23D9960 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23D9968 Offset: 0x23D5968 VA: 0x23D9968 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23D9970 Offset: 0x23D5970 VA: 0x23D9970 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23D9978 Offset: 0x23D5978 VA: 0x23D9978 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23D9980 Offset: 0x23D5980 VA: 0x23D9980 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23D9988 Offset: 0x23D5988 VA: 0x23D9988 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23D9990 Offset: 0x23D5990 VA: 0x23D9990 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23D9998 Offset: 0x23D5998 VA: 0x23D9998 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23D99A0 Offset: 0x23D59A0 VA: 0x23D99A0 Slot: 19
	public override bool get_IsOverlay() { }

	// RVA: 0x23D99A8 Offset: 0x23D59A8 VA: 0x23D99A8 Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x23D99B0 Offset: 0x23D59B0 VA: 0x23D99B0 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23D9AD8 Offset: 0x23D5AD8 VA: 0x23D9AD8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23D9B90 Offset: 0x23D5B90 VA: 0x23D9B90 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23D9D70 Offset: 0x23D5D70 VA: 0x23D9D70 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23D9F54 Offset: 0x23D5F54 VA: 0x23D9F54
	public void .ctor() { }
}

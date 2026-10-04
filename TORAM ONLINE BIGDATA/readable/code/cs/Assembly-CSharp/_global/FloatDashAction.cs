// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FloatDashAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 3657
{
	// Fields
	public const int TakeId = 200702000;

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
	public override bool IsMoveAssistContinue { get; }
	public MotionSwitchType MotionSwitchType { get; }
	public override bool IsOverlay { get; }

	// Methods

	// RVA: 0x23BB528 Offset: 0x23B7528 VA: 0x23BB528 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x23BB530 Offset: 0x23B7530 VA: 0x23BB530 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x23BB538 Offset: 0x23B7538 VA: 0x23BB538 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x23BB540 Offset: 0x23B7540 VA: 0x23BB540 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x23BB548 Offset: 0x23B7548 VA: 0x23BB548 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x23BB550 Offset: 0x23B7550 VA: 0x23BB550 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x23BB558 Offset: 0x23B7558 VA: 0x23BB558 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x23BB560 Offset: 0x23B7560 VA: 0x23BB560 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x23BB568 Offset: 0x23B7568 VA: 0x23BB568 Slot: 15
	public override bool get_IsSupport() { }

	// RVA: 0x23BB570 Offset: 0x23B7570 VA: 0x23BB570 Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x23BB578 Offset: 0x23B7578 VA: 0x23BB578 Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x23BB580 Offset: 0x23B7580 VA: 0x23BB580 Slot: 19
	public override bool get_IsOverlay() { }

	// RVA: 0x23BB588 Offset: 0x23B7588 VA: 0x23BB588 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23BB6BC Offset: 0x23B76BC VA: 0x23BB6BC Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BB810 Offset: 0x23B7810 VA: 0x23BB810 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23BBA10 Offset: 0x23B7A10 VA: 0x23BBA10 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x23BBBF4 Offset: 0x23B7BF4 VA: 0x23BBBF4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23BBBF8 Offset: 0x23B7BF8 VA: 0x23BBBF8
	public void .ctor() { }
}

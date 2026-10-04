// Assembly: Assembly-CSharp.dll
// Namespace: 
public class KnifeCombatAction : PlayerAttackBase, IMotionSwitchSkill // TypeDefIndex: 2731
{
	// Fields
	private float skillRate; // 0x120
	private Action addExcetraDamage; // 0x128

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public MotionSwitchType MotionSwitchType { get; }

	// Methods

	// RVA: 0x224DAD0 Offset: 0x2249AD0 VA: 0x224DAD0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x224DAD8 Offset: 0x2249AD8 VA: 0x224DAD8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x224DAE0 Offset: 0x2249AE0 VA: 0x224DAE0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x224DAE8 Offset: 0x2249AE8 VA: 0x224DAE8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x224DAF0 Offset: 0x2249AF0 VA: 0x224DAF0 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x224DAF8 Offset: 0x2249AF8 VA: 0x224DAF8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x224DB00 Offset: 0x2249B00 VA: 0x224DB00 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x224DB08 Offset: 0x2249B08 VA: 0x224DB08 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x224DB10 Offset: 0x2249B10 VA: 0x224DB10 Slot: 91
	public MotionSwitchType get_MotionSwitchType() { }

	// RVA: 0x224DB18 Offset: 0x2249B18 VA: 0x224DB18 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x224DCC4 Offset: 0x2249CC4 VA: 0x224DCC4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x224DD8C Offset: 0x2249D8C VA: 0x224DD8C Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x224DF14 Offset: 0x2249F14 VA: 0x224DF14 Slot: 80
	public override void AttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x224DF68 Offset: 0x2249F68 VA: 0x224DF68 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x224E450 Offset: 0x224A450 VA: 0x224E450 Slot: 63
	public override bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x224E634 Offset: 0x224A634 VA: 0x224E634
	public void .ctor() { }
}

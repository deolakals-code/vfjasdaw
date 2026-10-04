// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FreezeGrenadeAction : GolemGrenadeSkillBase, IAbnormalStateSkill // TypeDefIndex: 3363
{
	// Fields
	private int percent; // 0x130

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }
	public override bool IsExpDefFluctuate { get; }
	protected override int GrenadeEffectColor { get; }

	// Methods

	// RVA: 0x2350804 Offset: 0x234C804 VA: 0x2350804 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x235080C Offset: 0x234C80C VA: 0x235080C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2350814 Offset: 0x234C814 VA: 0x2350814 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x235081C Offset: 0x234C81C VA: 0x235081C Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2350824 Offset: 0x234C824 VA: 0x2350824 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x235082C Offset: 0x234C82C VA: 0x235082C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2350834 Offset: 0x234C834 VA: 0x2350834 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x235083C Offset: 0x234C83C VA: 0x235083C Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2350844 Offset: 0x234C844 VA: 0x2350844 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x235084C Offset: 0x234C84C VA: 0x235084C Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x2350854 Offset: 0x234C854 VA: 0x2350854 Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x235085C Offset: 0x234C85C VA: 0x235085C Slot: 91
	protected override int get_GrenadeEffectColor() { }

	// RVA: 0x235086C Offset: 0x234C86C VA: 0x235086C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x23509E4 Offset: 0x234C9E4 VA: 0x23509E4 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2350DF0 Offset: 0x234CDF0 VA: 0x2350DF0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x23510A8 Offset: 0x234D0A8 VA: 0x23510A8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x23511D8 Offset: 0x234D1D8 VA: 0x23511D8 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2351420 Offset: 0x234D420 VA: 0x2351420 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2351484 Offset: 0x234D484 VA: 0x2351484 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x23514D4 Offset: 0x234D4D4 VA: 0x23514D4 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x23517A8 Offset: 0x234D7A8 VA: 0x23517A8
	public void .ctor() { }
}

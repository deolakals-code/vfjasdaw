// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CallGolemNormalAttackAction : PlayerAttackBase // TypeDefIndex: 3361
{
	// Fields
	private readonly SkillId[] validSkillBufIds; // 0x120
	private float skillRate; // 0x128
	private int addResist; // 0x12C
	private int addCritical; // 0x130
	private int addHit; // 0x134
	private int addMotionSpeed; // 0x138
	private float assistMoveTargetDistance; // 0x13C
	public CallGolemType golemType; // 0x140
	public SkillAttackType attackType; // 0x144
	public bool isBoost; // 0x148

	// Properties
	public override int ActionID { get; }
	public override SkillTreeType TreeType { get; }
	public override bool IsMoveAssistContinue { get; }
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public override bool NoCost { get; }
	protected override bool CheckBlank { get; }
	public override bool IsExpDefFluctuate { get; }

	// Methods

	// RVA: 0x234C87C Offset: 0x234887C VA: 0x234C87C Slot: 5
	public override int get_ActionID() { }

	// RVA: 0x234C884 Offset: 0x2348884 VA: 0x234C884 Slot: 69
	public override SkillTreeType get_TreeType() { }

	// RVA: 0x234C88C Offset: 0x234888C VA: 0x234C88C Slot: 10
	public override bool get_IsMoveAssistContinue() { }

	// RVA: 0x234C894 Offset: 0x2348894 VA: 0x234C894 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x234C89C Offset: 0x234889C VA: 0x234C89C Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x234C8A4 Offset: 0x23488A4 VA: 0x234C8A4 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x234C8AC Offset: 0x23488AC VA: 0x234C8AC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x234C8B4 Offset: 0x23488B4 VA: 0x234C8B4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x234C8BC Offset: 0x23488BC VA: 0x234C8BC Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x234C8C4 Offset: 0x23488C4 VA: 0x234C8C4 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x234C8CC Offset: 0x23488CC VA: 0x234C8CC Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x234C8D4 Offset: 0x23488D4 VA: 0x234C8D4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x234C8DC Offset: 0x23488DC VA: 0x234C8DC Slot: 67
	public override bool get_NoCost() { }

	// RVA: 0x234C8E4 Offset: 0x23488E4 VA: 0x234C8E4 Slot: 73
	protected override bool get_CheckBlank() { }

	// RVA: 0x234C8EC Offset: 0x23488EC VA: 0x234C8EC Slot: 29
	public override bool get_IsExpDefFluctuate() { }

	// RVA: 0x234C8F4 Offset: 0x23488F4 VA: 0x234C8F4 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x234D59C Offset: 0x234959C VA: 0x234D59C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x234D5B0 Offset: 0x23495B0 VA: 0x234D5B0 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x234D69C Offset: 0x234969C VA: 0x234D69C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x234D820 Offset: 0x2349820 VA: 0x234D820 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x234DA3C Offset: 0x2349A3C VA: 0x234DA3C Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x234F184 Offset: 0x234B184 VA: 0x234F184 Slot: 86
	protected override int calcBaseDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction, SkillAttackType type, SkillEqLimitFlag eqLimit, bool isCritical) { }

	// RVA: 0x234F4B0 Offset: 0x234B4B0 VA: 0x234F4B0
	public void UpdateAssistMoveTargetDistance(float assistMoveTargetDistance) { }

	// RVA: 0x234CEC4 Offset: 0x2348EC4 VA: 0x234CEC4
	private void InitLancerAttack(PlayerActionManagerBase playerAction) { }

	// RVA: 0x234D0EC Offset: 0x23490EC VA: 0x234D0EC
	private void InitShieldAttack(PlayerActionManagerBase playerAction) { }

	// RVA: 0x234D364 Offset: 0x2349364 VA: 0x234D364
	private void InitBusterAttack(PlayerActionManagerBase playerAction) { }

	// RVA: 0x234F4B8 Offset: 0x234B4B8 VA: 0x234F4B8
	public void .ctor() { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicLancerAction : PlayerAttackBase, IEnchantedSpellInvokeSkill, IEnchantSkill, IChronosShift, IAbnormalStateSkill // TypeDefIndex: 2788
{
	// Fields
	private int damageCount; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private int stopPercent; // 0x12C
	private int interval; // 0x130
	private int magicResistBreaker; // 0x134
	private MagicLancerAction lastUsedSkill; // 0x138
	[TupleElementNames(new[] { "a", "b" })]
	private ValueTuple<bool, bool> spellTuningLancer; // 0x140

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }
	public override bool IsNoMotionTake { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x2271500 Offset: 0x226D500 VA: 0x2271500 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2271508 Offset: 0x226D508 VA: 0x2271508 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2271510 Offset: 0x226D510 VA: 0x2271510 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2271518 Offset: 0x226D518 VA: 0x2271518 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2271520 Offset: 0x226D520 VA: 0x2271520 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2271528 Offset: 0x226D528 VA: 0x2271528 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2271530 Offset: 0x226D530 VA: 0x2271530 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2271538 Offset: 0x226D538 VA: 0x2271538 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2271540 Offset: 0x226D540 VA: 0x2271540 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x2271548 Offset: 0x226D548 VA: 0x2271548 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x2271550 Offset: 0x226D550 VA: 0x2271550 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x2271584 Offset: 0x226D584 VA: 0x2271584 Slot: 92
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x227158C Offset: 0x226D58C VA: 0x227158C Slot: 93
	public bool get_IsEnchantMotion() { }

	// RVA: 0x2271594 Offset: 0x226D594 VA: 0x2271594 Slot: 94
	public bool get_IsStackChainCast() { }

	// RVA: 0x227159C Offset: 0x226D59C VA: 0x227159C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2271B80 Offset: 0x226DB80 VA: 0x2271B80 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2271DDC Offset: 0x226DDDC VA: 0x2271DDC Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2271E04 Offset: 0x226DE04 VA: 0x2271E04 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x227225C Offset: 0x226E25C VA: 0x227225C Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2272404 Offset: 0x226E404 VA: 0x2272404 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22724D4 Offset: 0x226E4D4 VA: 0x22724D4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2272828 Offset: 0x226E828 VA: 0x2272828 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x227288C Offset: 0x226E88C VA: 0x227288C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2271AB4 Offset: 0x226DAB4 VA: 0x2271AB4
	private SkillLinkedTake CreateEventTake() { }

	// RVA: 0x2271F20 Offset: 0x226DF20 VA: 0x2271F20 Slot: 91
	public void InitializeEnchantedSpell(CharacterActionManagerBase actarAction, bool isPlayer) { }

	// RVA: 0x227297C Offset: 0x226E97C VA: 0x227297C Slot: 97
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x227243C Offset: 0x226E43C VA: 0x227243C Slot: 98
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x2272A3C Offset: 0x226EA3C VA: 0x2272A3C Slot: 95
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x2272B10 Offset: 0x226EB10 VA: 0x2272B10 Slot: 96
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x2272BE4 Offset: 0x226EBE4 VA: 0x2272BE4
	public void .ctor() { }
}

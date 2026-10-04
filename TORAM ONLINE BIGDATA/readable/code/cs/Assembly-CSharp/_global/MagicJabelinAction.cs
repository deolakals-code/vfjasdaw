// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicJabelinAction : PlayerAttackBase, IEnchantedSpellInvokeSkill, IEnchantSkill, IChronosShift, IAbnormalStateSkill // TypeDefIndex: 2785
{
	// Fields
	private float skillRate; // 0x120
	private int fixAddDamage; // 0x124
	private int abnormalRate; // 0x128
	private MagicJabelinAction lastUsedSkill; // 0x130
	[TupleElementNames(new[] { "a", "b" })]
	private ValueTuple<bool, bool> spellTuningJabelin; // 0x138
	private int state; // 0x13C

	// Properties
	public override SkillAttackType AttackType { get; }
	public override SkillAttackType ExpType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override bool IsNoMotionTake { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x226F0CC Offset: 0x226B0CC VA: 0x226F0CC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x226F0D4 Offset: 0x226B0D4 VA: 0x226F0D4 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x226F0F0 Offset: 0x226B0F0 VA: 0x226F0F0 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x226F0F8 Offset: 0x226B0F8 VA: 0x226F0F8 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x226F100 Offset: 0x226B100 VA: 0x226F100 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x226F108 Offset: 0x226B108 VA: 0x226F108 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x226F110 Offset: 0x226B110 VA: 0x226F110 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x226F118 Offset: 0x226B118 VA: 0x226F118 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x226F120 Offset: 0x226B120 VA: 0x226F120 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x226F128 Offset: 0x226B128 VA: 0x226F128 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x226F15C Offset: 0x226B15C VA: 0x226F15C Slot: 92
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x226F164 Offset: 0x226B164 VA: 0x226F164 Slot: 93
	public bool get_IsEnchantMotion() { }

	// RVA: 0x226F16C Offset: 0x226B16C VA: 0x226F16C Slot: 94
	public bool get_IsStackChainCast() { }

	// RVA: 0x226F174 Offset: 0x226B174 VA: 0x226F174 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x226F49C Offset: 0x226B49C VA: 0x226F49C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x226F9D4 Offset: 0x226B9D4 VA: 0x226F9D4 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x226FB20 Offset: 0x226BB20 VA: 0x226FB20 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x226FD00 Offset: 0x226BD00 VA: 0x226FD00 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x226FDD0 Offset: 0x226BDD0 VA: 0x226FDD0 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22701F4 Offset: 0x226C1F4 VA: 0x22701F4 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x22702D0 Offset: 0x226C2D0 VA: 0x22702D0 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x22703C0 Offset: 0x226C3C0 VA: 0x22703C0 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x22701D0 Offset: 0x226C1D0 VA: 0x22701D0
	public static AbnormalType GetAbnormalType(ElementType type) { }

	// RVA: 0x2270514 Offset: 0x226C514 VA: 0x2270514
	public void OnFailedAddAbnormalState(GameObject actor) { }

	// RVA: 0x226F78C Offset: 0x226B78C VA: 0x226F78C Slot: 91
	public void InitializeEnchantedSpell(CharacterActionManagerBase actarAction, bool isPlayer) { }

	// RVA: 0x22706A8 Offset: 0x226C6A8 VA: 0x22706A8 Slot: 97
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x226FD38 Offset: 0x226BD38 VA: 0x226FD38 Slot: 98
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x2270768 Offset: 0x226C768 VA: 0x2270768 Slot: 95
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x227083C Offset: 0x226C83C VA: 0x227083C Slot: 96
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x2270910 Offset: 0x226C910 VA: 0x2270910
	public void .ctor() { }
}

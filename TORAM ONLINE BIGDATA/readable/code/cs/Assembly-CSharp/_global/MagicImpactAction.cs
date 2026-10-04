// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicImpactAction : PlayerAttackBase, IEnchantSkill, IChronosShift, IAbnormalStateSkill, IEnchantedSpellInvokeSkill // TypeDefIndex: 2784
{
	// Fields
	private Vector3 attackPosition; // 0x120
	private float skillRate; // 0x12C
	private int fixAddDamage; // 0x130
	private int abnormalRate; // 0x134
	private float rad; // 0x138
	private bool isEnchantStartMotion; // 0x13C
	private MagicImpactAction lastUsedSkill; // 0x140
	private bool isUseMagicImpact; // 0x148
	private bool isGemCart; // 0x149

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
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x226DB20 Offset: 0x2269B20 VA: 0x226DB20 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x226DB28 Offset: 0x2269B28 VA: 0x226DB28 Slot: 7
	public override SkillAttackType get_ExpType() { }

	// RVA: 0x226DB44 Offset: 0x2269B44 VA: 0x226DB44 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x226DB4C Offset: 0x2269B4C VA: 0x226DB4C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x226DB54 Offset: 0x2269B54 VA: 0x226DB54 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x226DB5C Offset: 0x2269B5C VA: 0x226DB5C Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x226DB64 Offset: 0x2269B64 VA: 0x226DB64 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x226DB6C Offset: 0x2269B6C VA: 0x226DB6C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x226DB74 Offset: 0x2269B74 VA: 0x226DB74 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x226DB7C Offset: 0x2269B7C VA: 0x226DB7C Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x226DB84 Offset: 0x2269B84 VA: 0x226DB84 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x226DB8C Offset: 0x2269B8C VA: 0x226DB8C Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x226DB94 Offset: 0x2269B94 VA: 0x226DB94 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x226E064 Offset: 0x226A064 VA: 0x226E064
	private void WriteIndividualFlag() { }

	// RVA: 0x226E090 Offset: 0x226A090 VA: 0x226E090
	private void ReadIndividualParameter() { }

	// RVA: 0x226E0A8 Offset: 0x226A0A8 VA: 0x226E0A8 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x226E1F0 Offset: 0x226A1F0 VA: 0x226E1F0 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x226E374 Offset: 0x226A374 VA: 0x226E374 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x226E614 Offset: 0x226A614 VA: 0x226E614 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x226E708 Offset: 0x226A708 VA: 0x226E708 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x226E9A8 Offset: 0x226A9A8 VA: 0x226E9A8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x226EAA4 Offset: 0x226AAA4 VA: 0x226EAA4 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x226EB08 Offset: 0x226AB08 VA: 0x226EB08 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x226EC24 Offset: 0x226AC24 VA: 0x226EC24 Slot: 96
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x226E8D0 Offset: 0x226A8D0 VA: 0x226E8D0 Slot: 97
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x226ECE4 Offset: 0x226ACE4 VA: 0x226ECE4 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x226EDB8 Offset: 0x226ADB8 VA: 0x226EDB8 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x226EE8C Offset: 0x226AE8C VA: 0x226EE8C Slot: 99
	public void InitializeEnchantedSpell(CharacterActionManagerBase actarAction, bool isPlayer) { }

	// RVA: 0x226F05C Offset: 0x226B05C VA: 0x226F05C
	public void .ctor() { }
}

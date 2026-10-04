// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicBlastAction : PlayerAttackBase, IEnchantedSpellInvokeSkill, IEnchantSkill, IChronosShift, IAbnormalStateSkill // TypeDefIndex: 2770
{
	// Fields
	private Vector3 attackPosition; // 0x120
	private Transform attackTransform; // 0x130
	private float skillRate; // 0x138
	private int fixAddDamage; // 0x13C
	private int abnormalRate; // 0x140
	private float rad; // 0x144
	private MagicBlastAction lastUsedSkill; // 0x148
	[TupleElementNames(new[] { "a", "b" })]
	private ValueTuple<bool, bool> spellTuningBlast; // 0x150

	// Properties
	public override SkillAttackType AttackType { get; }
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

	// RVA: 0x22613C0 Offset: 0x225D3C0 VA: 0x22613C0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x22613C8 Offset: 0x225D3C8 VA: 0x22613C8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22613D0 Offset: 0x225D3D0 VA: 0x22613D0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x22613D8 Offset: 0x225D3D8 VA: 0x22613D8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x22613E0 Offset: 0x225D3E0 VA: 0x22613E0 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x22613E8 Offset: 0x225D3E8 VA: 0x22613E8 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x22613F0 Offset: 0x225D3F0 VA: 0x22613F0 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22613F8 Offset: 0x225D3F8 VA: 0x22613F8 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2261408 Offset: 0x225D408 VA: 0x2261408 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x226143C Offset: 0x225D43C VA: 0x226143C Slot: 92
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x2261444 Offset: 0x225D444 VA: 0x2261444 Slot: 93
	public bool get_IsEnchantMotion() { }

	// RVA: 0x226144C Offset: 0x225D44C VA: 0x226144C Slot: 94
	public bool get_IsStackChainCast() { }

	// RVA: 0x2261454 Offset: 0x225D454 VA: 0x2261454 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x226199C Offset: 0x225D99C VA: 0x226199C Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2261FA8 Offset: 0x225DFA8 VA: 0x2261FA8 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x22620F4 Offset: 0x225E0F4 VA: 0x22620F4 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2262438 Offset: 0x225E438 VA: 0x2262438 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2262618 Offset: 0x225E618 VA: 0x2262618 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2262738 Offset: 0x225E738 VA: 0x2262738 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x22628A0 Offset: 0x225E8A0 VA: 0x22628A0 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2262AB4 Offset: 0x225EAB4 VA: 0x2262AB4 Slot: 88
	public override AbnormalType[] PossibilityAbnormalState(PlayerStatusBase status) { }

	// RVA: 0x2262B90 Offset: 0x225EB90 VA: 0x2262B90 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2262414 Offset: 0x225E414 VA: 0x2262414
	public static AbnormalType GetAbnormalType(ElementType type) { }

	// RVA: 0x2261C8C Offset: 0x225DC8C VA: 0x2261C8C Slot: 91
	public void InitializeEnchantedSpell(CharacterActionManagerBase actarAction, bool isPlayer) { }

	// RVA: 0x2262C80 Offset: 0x225EC80 VA: 0x2262C80 Slot: 97
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x22626A0 Offset: 0x225E6A0 VA: 0x22626A0 Slot: 98
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x2262D40 Offset: 0x225ED40 VA: 0x2262D40 Slot: 95
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x2262E14 Offset: 0x225EE14 VA: 0x2262E14 Slot: 96
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x2262EE8 Offset: 0x225EEE8 VA: 0x2262EE8
	public void .ctor() { }
}

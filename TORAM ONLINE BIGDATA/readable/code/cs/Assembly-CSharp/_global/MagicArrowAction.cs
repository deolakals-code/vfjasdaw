// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicArrowAction : PlayerAttackBase, IEnchantedSpellInvokeSkill, IEnchantSkill, IChronosShift // TypeDefIndex: 2768
{
	// Fields
	private int damageCount; // 0x120
	private float skillRate; // 0x124
	private int fixAddDamage; // 0x128
	private bool firstHit; // 0x12C
	private MagicArrowAction lastUsedSkill; // 0x130
	[TupleElementNames(new[] { "a", "b" })]
	private ValueTuple<bool, bool> spellTuningArrow; // 0x138

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

	// RVA: 0x225FCAC Offset: 0x225BCAC VA: 0x225FCAC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x225FCB4 Offset: 0x225BCB4 VA: 0x225FCB4 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x225FCBC Offset: 0x225BCBC VA: 0x225FCBC Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x225FCC4 Offset: 0x225BCC4 VA: 0x225FCC4 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x225FCCC Offset: 0x225BCCC VA: 0x225FCCC Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x225FCD4 Offset: 0x225BCD4 VA: 0x225FCD4 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x225FCDC Offset: 0x225BCDC VA: 0x225FCDC Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x225FCE4 Offset: 0x225BCE4 VA: 0x225FCE4 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x225FCEC Offset: 0x225BCEC VA: 0x225FCEC Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x225FCF4 Offset: 0x225BCF4 VA: 0x225FCF4 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x225FCFC Offset: 0x225BCFC VA: 0x225FCFC Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x225FD30 Offset: 0x225BD30 VA: 0x225FD30 Slot: 92
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x225FD38 Offset: 0x225BD38 VA: 0x225FD38 Slot: 93
	public bool get_IsEnchantMotion() { }

	// RVA: 0x225FD40 Offset: 0x225BD40 VA: 0x225FD40 Slot: 94
	public bool get_IsStackChainCast() { }

	// RVA: 0x225FD48 Offset: 0x225BD48 VA: 0x225FD48 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2260218 Offset: 0x225C218 VA: 0x2260218 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2260728 Offset: 0x225C728 VA: 0x2260728 Slot: 82
	public override void OtherPlayerAttackStartReceive(int skillParamFlag, int skillIndividualFlag) { }

	// RVA: 0x2260838 Offset: 0x225C838 VA: 0x2260838 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2260A94 Offset: 0x225CA94 VA: 0x2260A94 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2260E94 Offset: 0x225CE94 VA: 0x2260E94 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2260098 Offset: 0x225C098 VA: 0x2260098
	private SkillLinkedTake CreateEventTake() { }

	// RVA: 0x226111C Offset: 0x225D11C VA: 0x226111C
	public float GetShakeWidth(byte attackCount) { }

	// RVA: 0x22604F0 Offset: 0x225C4F0 VA: 0x22604F0 Slot: 91
	public void InitializeEnchantedSpell(CharacterActionManagerBase actarAction, bool isPlayer) { }

	// RVA: 0x2261140 Offset: 0x225D140 VA: 0x2261140 Slot: 97
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x22609FC Offset: 0x225C9FC VA: 0x22609FC Slot: 98
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x2261200 Offset: 0x225D200 VA: 0x2261200 Slot: 95
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x22612D4 Offset: 0x225D2D4 VA: 0x22612D4 Slot: 96
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x22613A8 Offset: 0x225D3A8 VA: 0x22613A8
	public void .ctor() { }
}

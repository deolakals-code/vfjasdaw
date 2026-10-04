// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicStormAction : PlayerAttackBase, IEnchantSkill, IChronosShift, IEnchantedSpellInvokeSkill // TypeDefIndex: 2791
{
	// Fields
	public GameObject StormObject; // 0x120
	private int damageCount; // 0x128
	private float rad; // 0x12C
	private float skillRate; // 0x130
	private int constantDamage; // 0x134
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x138
	private Transform targetTransform; // 0x140
	private MagicStormAction lastUsedSkill; // 0x148
	private int hitCount; // 0x150
	[TupleElementNames(new[] { "a", "b" })]
	private ValueTuple<bool, bool> spellTuningStorm; // 0x154

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

	// RVA: 0x2273CE0 Offset: 0x226FCE0 VA: 0x2273CE0 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2273CE8 Offset: 0x226FCE8 VA: 0x2273CE8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x2273CF0 Offset: 0x226FCF0 VA: 0x2273CF0 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2273CF8 Offset: 0x226FCF8 VA: 0x2273CF8 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2273D00 Offset: 0x226FD00 VA: 0x2273D00 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2273D08 Offset: 0x226FD08 VA: 0x2273D08 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2273D10 Offset: 0x226FD10 VA: 0x2273D10 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x2273D18 Offset: 0x226FD18 VA: 0x2273D18 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x2273D20 Offset: 0x226FD20 VA: 0x2273D20 Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x2273D28 Offset: 0x226FD28 VA: 0x2273D28 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x2273D30 Offset: 0x226FD30 VA: 0x2273D30 Slot: 31
	public override bool get_IsNoMotionTake() { }

	// RVA: 0x2273D64 Offset: 0x226FD64 VA: 0x2273D64 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x2273D6C Offset: 0x226FD6C VA: 0x2273D6C Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x2273D74 Offset: 0x226FD74 VA: 0x2273D74 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x2273D7C Offset: 0x226FD7C VA: 0x2273D7C Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2274154 Offset: 0x2270154 VA: 0x2274154
	private void WriteIndividualFlag() { }

	// RVA: 0x22743CC Offset: 0x22703CC VA: 0x22743CC
	private void ReadIndividualParameter() { }

	// RVA: 0x2274450 Offset: 0x2270450 VA: 0x2274450 Slot: 39
	public override void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22745F8 Offset: 0x22705F8 VA: 0x22745F8 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22747E0 Offset: 0x22707E0 VA: 0x22747E0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x22749BC Offset: 0x22709BC VA: 0x22749BC Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2274F18 Offset: 0x2270F18 VA: 0x2274F18 Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x2274F30 Offset: 0x2270F30 VA: 0x2274F30 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x2275518 Offset: 0x2271518 VA: 0x2275518 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x227568C Offset: 0x227168C VA: 0x227568C
	public void AddHitCount() { }

	// RVA: 0x227569C Offset: 0x227169C VA: 0x227569C Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x227570C Offset: 0x227170C VA: 0x227570C Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2275A40 Offset: 0x2271A40 VA: 0x2275A40 Slot: 48
	public override void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x2275A70 Offset: 0x2271A70 VA: 0x2275A70 Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2275B58 Offset: 0x2271B58 VA: 0x2275B58 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22741EC Offset: 0x22701EC VA: 0x22741EC
	private SkillLinkedTake CreateEventTake() { }

	// RVA: 0x2275D80 Offset: 0x2271D80 VA: 0x2275D80 Slot: 96
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x2274708 Offset: 0x2270708 VA: 0x2274708 Slot: 97
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x2275E40 Offset: 0x2271E40 VA: 0x2275E40 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x2275F14 Offset: 0x2271F14 VA: 0x2275F14 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x2275FE8 Offset: 0x2271FE8 VA: 0x2275FE8
	public static bool TryGetAbnormalSuctionData(GameObject actor, ActionAppendData appendData, out Vector3 effectPos, out float range) { }

	// RVA: 0x2274CB8 Offset: 0x2270CB8 VA: 0x2274CB8 Slot: 98
	public void InitializeEnchantedSpell(CharacterActionManagerBase actarAction, bool isPlayer) { }

	// RVA: 0x22763EC Offset: 0x22723EC VA: 0x22763EC
	public void .ctor() { }
}

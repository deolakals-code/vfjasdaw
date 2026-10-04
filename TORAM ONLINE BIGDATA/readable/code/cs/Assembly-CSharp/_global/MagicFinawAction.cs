// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicFinawAction : PlayerAttackBase, IEnchantSkill, IChronosShift // TypeDefIndex: 2781
{
	// Fields
	private float[] skillRate; // 0x120
	private int[] fixAddDamage; // 0x128
	private Dictionary<CharacterActionManagerBase, int> targetExpRegister; // 0x130
	private readonly int maxDamageCount; // 0x138
	private int damageCount; // 0x13C
	private float[] rad; // 0x140
	private Vector3 attackPos; // 0x148
	private GameObject targetObj; // 0x158
	private bool addHate; // 0x160
	private MagicFinawAction lastUsedSkill; // 0x168
	private bool enchantedBurstStack; // 0x170

	// Properties
	public override SkillAttackType AttackType { get; }
	public override int BaseMp { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsInterruptable { get; }
	public override bool IsPlace { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsRange { get; }
	public override bool IsUnsheatheWeapon { get; }
	protected override bool IsRangeEquipBonus { get; }
	protected override bool IsRangeSkillBonus { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }

	// Methods

	// RVA: 0x226A6FC Offset: 0x22666FC VA: 0x226A6FC Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x226A704 Offset: 0x2266704 VA: 0x226A704 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x226A70C Offset: 0x226670C VA: 0x226A70C Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x226A714 Offset: 0x2266714 VA: 0x226A714 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x226A71C Offset: 0x226671C VA: 0x226A71C Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x226A724 Offset: 0x2266724 VA: 0x226A724 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x226A72C Offset: 0x226672C VA: 0x226A72C Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x226A734 Offset: 0x2266734 VA: 0x226A734 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x226A73C Offset: 0x226673C VA: 0x226A73C Slot: 71
	protected override bool get_IsRangeEquipBonus() { }

	// RVA: 0x226A744 Offset: 0x2266744 VA: 0x226A744 Slot: 72
	protected override bool get_IsRangeSkillBonus() { }

	// RVA: 0x226A74C Offset: 0x226674C VA: 0x226A74C Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x226A754 Offset: 0x2266754 VA: 0x226A754 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x226A75C Offset: 0x226675C VA: 0x226A75C Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x226A764 Offset: 0x2266764 VA: 0x226A764 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x226ACC0 Offset: 0x2266CC0 VA: 0x226ACC0 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x226AEAC Offset: 0x2266EAC VA: 0x226AEAC Slot: 42
	public override void SetTargetMobOthers(GameObject target) { }

	// RVA: 0x226AEBC Offset: 0x2266EBC VA: 0x226AEBC Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x226B178 Offset: 0x2267178 VA: 0x226B178 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x226B498 Offset: 0x2267498 VA: 0x226B498 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x226B930 Offset: 0x2267930 VA: 0x226B930 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x226BD50 Offset: 0x2267D50 VA: 0x226BD50 Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x226BF04 Offset: 0x2267F04 VA: 0x226BF04 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x226BF88 Offset: 0x2267F88 VA: 0x226BF88 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x226C41C Offset: 0x226841C VA: 0x226C41C
	private SkillActionBase.DamageData calcFinawData(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x226C084 Offset: 0x2268084 VA: 0x226C084
	private SkillActionBase.DamageData calcDummyData(MobActionManagerBase mobAction) { }

	// RVA: 0x226C850 Offset: 0x2268850 VA: 0x226C850 Slot: 96
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x226AEF4 Offset: 0x2266EF4 VA: 0x226AEF4 Slot: 97
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x226C910 Offset: 0x2268910 VA: 0x226C910 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x226C9E4 Offset: 0x22689E4 VA: 0x226C9E4 Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x226CAB8 Offset: 0x2268AB8 VA: 0x226CAB8
	public void .ctor() { }
}

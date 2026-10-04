// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MagicFallAction : PlayerAttackBase, IEnchantSkill, IChronosShift // TypeDefIndex: 2778
{
	// Fields
	private static int MAX_NUM; // 0x0
	private static int MAX_LOOP_ATTACK_COUNT; // 0x4
	private float[] skillRate; // 0x120
	private int fixAddDamage; // 0x128
	private int[] criticalBonus; // 0x130
	private int[] breakingPercent; // 0x138
	private int[] dizzyPercent; // 0x140
	private float targetSize; // 0x148
	private GameObject targetObject; // 0x150
	private Dictionary<MobActionManagerBase, int> targetExpList; // 0x158
	private Vector3 attackCenterPos; // 0x160
	private List<Vector3> effectPosList; // 0x170
	private Random random; // 0x178
	private float effectSize; // 0x180
	private MagicFallAction lastUsedSkill; // 0x188
	private Dictionary<int, SkillLinkedTake> meteorEventData; // 0x190
	private List<bool> endList; // 0x198
	private int currentMeteorNumber; // 0x1A0
	private bool[] attackHits; // 0x1A8
	private CharacterActionManagerBase actarAction; // 0x1B0
	private bool enchantedBurstStack; // 0x1B8
	private short gemCartLv; // 0x1BA

	// Properties
	public override SkillAttackType AttackType { get; }
	public override bool IsInterruptable { get; }
	public override bool IsHitRigidity { get; }
	public override bool IsUnsheatheWeapon { get; }
	public override bool IsPutUpWeapon { get; }
	public override bool IsPlace { get; }
	public override bool IsRange { get; }
	public override int BaseMp { get; }
	public bool IsEnchantStartMotion { get; }
	public bool IsEnchantMotion { get; }
	public bool IsStackChainCast { get; }
	private bool IsGemCart { get; }

	// Methods

	// RVA: 0x2267170 Offset: 0x2263170 VA: 0x2267170 Slot: 6
	public override SkillAttackType get_AttackType() { }

	// RVA: 0x2267178 Offset: 0x2263178 VA: 0x2267178 Slot: 8
	public override bool get_IsInterruptable() { }

	// RVA: 0x2267180 Offset: 0x2263180 VA: 0x2267180 Slot: 9
	public override bool get_IsHitRigidity() { }

	// RVA: 0x2267188 Offset: 0x2263188 VA: 0x2267188 Slot: 11
	public override bool get_IsUnsheatheWeapon() { }

	// RVA: 0x2267190 Offset: 0x2263190 VA: 0x2267190 Slot: 12
	public override bool get_IsPutUpWeapon() { }

	// RVA: 0x2267198 Offset: 0x2263198 VA: 0x2267198 Slot: 13
	public override bool get_IsPlace() { }

	// RVA: 0x22671A0 Offset: 0x22631A0 VA: 0x22671A0 Slot: 14
	public override bool get_IsRange() { }

	// RVA: 0x22671A8 Offset: 0x22631A8 VA: 0x22671A8 Slot: 23
	public override int get_BaseMp() { }

	// RVA: 0x22671B0 Offset: 0x22631B0 VA: 0x22671B0 Slot: 91
	public bool get_IsEnchantStartMotion() { }

	// RVA: 0x22671B8 Offset: 0x22631B8 VA: 0x22671B8 Slot: 92
	public bool get_IsEnchantMotion() { }

	// RVA: 0x22671C0 Offset: 0x22631C0 VA: 0x22671C0 Slot: 93
	public bool get_IsStackChainCast() { }

	// RVA: 0x22671C8 Offset: 0x22631C8 VA: 0x22671C8
	private bool get_IsGemCart() { }

	// RVA: 0x22671D8 Offset: 0x22631D8 VA: 0x22671D8 Slot: 38
	protected override void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x22676D0 Offset: 0x22636D0 VA: 0x22676D0 Slot: 40
	public override void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22681B8 Offset: 0x22641B8 VA: 0x22681B8 Slot: 46
	public override void ActionSkillEventPreparation(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2268968 Offset: 0x2264968 VA: 0x2268968 Slot: 47
	public override void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2268EF0 Offset: 0x2264EF0 VA: 0x2268EF0 Slot: 50
	public override bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2268FF8 Offset: 0x2264FF8 VA: 0x2268FF8 Slot: 59
	public override bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x226914C Offset: 0x226514C VA: 0x226914C Slot: 44
	public override void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x22692F8 Offset: 0x22652F8 VA: 0x22692F8 Slot: 60
	public override void NextRangeHit() { }

	// RVA: 0x2269418 Offset: 0x2265418 VA: 0x2269418 Slot: 55
	protected override void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x22680A0 Offset: 0x22640A0 VA: 0x22680A0
	private SkillLinkedTake CreateSkillEventData() { }

	// RVA: 0x22687D8 Offset: 0x22647D8 VA: 0x22687D8
	private void InitializeTakeEventData(SkillLinkedTake eventData, Vector3 pos, float angle) { }

	// RVA: 0x22685CC Offset: 0x22645CC VA: 0x22685CC
	private float CalcAngle(Vector3 actarPos, Vector3 targetPos) { }

	// RVA: 0x226802C Offset: 0x226402C VA: 0x226802C Slot: 97
	public void InitializeChronosShift(CharacterActionManagerBase actorAction) { }

	// RVA: 0x22699E4 Offset: 0x22659E4 VA: 0x22699E4 Slot: 96
	public void UseChronosShift(SkillActionBase lastUsedSkill) { }

	// RVA: 0x2269AA4 Offset: 0x2265AA4 VA: 0x2269AA4 Slot: 41
	public override void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2269C74 Offset: 0x2265C74 VA: 0x2269C74 Slot: 43
	public override void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x226A23C Offset: 0x226623C VA: 0x226A23C Slot: 83
	public override void OtherPlayerSkillEventReceive(CharacterActionManagerBase actorAction, short skillEventId, Dictionary<int, int> values) { }

	// RVA: 0x226A288 Offset: 0x2266288 VA: 0x226A288 Slot: 94
	public void EnchantStart(CharacterActionManagerBase actor) { }

	// RVA: 0x226A35C Offset: 0x226635C VA: 0x226A35C Slot: 95
	public void EnchantEnd(CharacterActionManagerBase actor) { }

	// RVA: 0x226A430 Offset: 0x2266430 VA: 0x226A430
	public void .ctor() { }

	// RVA: 0x226A630 Offset: 0x2266630 VA: 0x226A630
	private static void .cctor() { }
}

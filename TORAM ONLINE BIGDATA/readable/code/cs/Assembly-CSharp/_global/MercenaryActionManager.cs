// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(MercenarySkillDelayManager))]
[RequireComponent(typeof(FadeAnimationManager))]
[RequireComponent(typeof(TakeController))]
[RequireComponent(typeof(SkillManager))]
[RequireComponent(typeof(MercenaryTirednessManager))]
public class MercenaryActionManager : AutoMemberActionManager // TypeDefIndex: 688
{
	// Fields
	private bool CanDirectedMercenary; // 0x161
	private PlayerStatus autoPlayerStatus; // 0x168
	private AIActionType lastSelectAction; // 0x170
	private AutoMemberAILoop aiLoop; // 0x178
	private MobRangeAttackCollection rangeList; // 0x180
	private PlayerActionManagerBase playerActionManager; // 0x188
	private PlayerBattleManager playerBattleManager; // 0x190
	private GameObject lastTarget; // 0x198
	private int specialFlag; // 0x1A0
	private IAICentral aiCentralmanager; // 0x1A8
	private MobManager mobManager; // 0x1B0
	private AutoMemberBattleManager autoBattleManager; // 0x1B8
	private BufferingVector3 traceTarget; // 0x1C0
	private CharacterMove playerCharacterMove; // 0x1C8
	private AnimationBase autoAnimation; // 0x1D0
	private SkillManager skillManager; // 0x1D8
	private SkillBufferManager skillBufManager; // 0x1E0
	private AIMoveType nowMoveType; // 0x1E8
	private bool isAction; // 0x1EC
	private bool IsInterrupted; // 0x1ED
	private float actionTime; // 0x1F0
	private MercenarySetting setting; // 0x1F8
	private Vector3 oldMove; // 0x200
	private MercenarySkillDelayManager skillDelayManager; // 0x210
	private bool isEvent; // 0x218
	[CompilerGenerated]
	private MercenaryTirednessManager <Tiredness>k__BackingField; // 0x220

	// Properties
	public override PlayerStatusBase PlayerStatus { get; }
	public override bool IsDead { get; }
	public override bool IsDistDamageRegist { get; }
	private bool IsActionLock { get; }
	private bool IsNotFlinch { get; }
	private bool IsNotTumble { get; }
	public MercenarySetting Setting { get; }
	public MercenaryTirednessManager Tiredness { get; set; }

	// Methods

	// RVA: 0x1ABD970 Offset: 0x1AB9970 VA: 0x1ABD970 Slot: 22
	public override PlayerStatusBase get_PlayerStatus() { }

	// RVA: 0x1ABD978 Offset: 0x1AB9978 VA: 0x1ABD978 Slot: 7
	public override bool get_IsDead() { }

	// RVA: 0x1ABD9C8 Offset: 0x1AB99C8 VA: 0x1ABD9C8 Slot: 50
	public override bool get_IsDistDamageRegist() { }

	[IteratorStateMachine(typeof(MercenaryActionManager.<GetAIParam>d__9))]
	// RVA: 0x1ABD9D0 Offset: 0x1AB99D0 VA: 0x1ABD9D0
	public IEnumerable<string> GetAIParam() { }

	// RVA: 0x1ABDA80 Offset: 0x1AB9A80 VA: 0x1ABDA80
	private bool get_IsActionLock() { }

	// RVA: 0x1ABDAD0 Offset: 0x1AB9AD0 VA: 0x1ABDAD0
	private bool get_IsNotFlinch() { }

	// RVA: 0x1ABDADC Offset: 0x1AB9ADC VA: 0x1ABDADC
	private bool get_IsNotTumble() { }

	// RVA: 0x1ABDAE8 Offset: 0x1AB9AE8 VA: 0x1ABDAE8
	public MercenarySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x1ABDAF0 Offset: 0x1AB9AF0 VA: 0x1ABDAF0
	public MercenaryTirednessManager get_Tiredness() { }

	[CompilerGenerated]
	// RVA: 0x1ABDAF8 Offset: 0x1AB9AF8 VA: 0x1ABDAF8
	private void set_Tiredness(MercenaryTirednessManager value) { }

	// RVA: 0x1ABDB08 Offset: 0x1AB9B08 VA: 0x1ABDB08 Slot: 46
	protected override void Initialize(PlayerObjectBase playerObject) { }

	// RVA: 0x1ABDB78 Offset: 0x1AB9B78 VA: 0x1ABDB78
	private void initialize(ArchetypeUid archetypeUid, MercenarySetting setting) { }

	// RVA: 0x1ABE7D8 Offset: 0x1ABA7D8 VA: 0x1ABE7D8
	private void InitAI(bool isMercenary) { }

	// RVA: 0x1ABED8C Offset: 0x1ABAD8C VA: 0x1ABED8C
	public void InitializeAI(ArchetypeUid archetypeUid, MobRangeAttackCollection rangeList, MercenarySetting setting) { }

	// RVA: 0x1ABE054 Offset: 0x1ABA054 VA: 0x1ABE054
	private void InitEquipAndStatus(ArchetypeUid archetypeUid, MercenarySetting setting) { }

	// RVA: 0x1ABF008 Offset: 0x1ABB008 VA: 0x1ABF008
	private List<Pair<short, short>> CreateSpecialBonus(ItemData weaponItem, ItemData subWeaponItem, StanceType stance, short specialResisrRate) { }

	// RVA: 0x1ABDBD8 Offset: 0x1AB9BD8 VA: 0x1ABDBD8
	private void InitReference(ArchetypeUid archetypeUid) { }

	// RVA: 0x1ABF2FC Offset: 0x1ABB2FC VA: 0x1ABF2FC
	public void StartchackAction() { }

	// RVA: 0x1ABEEA8 Offset: 0x1ABAEA8 VA: 0x1ABEEA8
	private void CreateAI() { }

	// RVA: 0x1ABF3B0 Offset: 0x1ABB3B0 VA: 0x1ABF3B0
	public void InitializeAITacticalPattern(SkillId firstSkillId, bool isUsedFirstSkill, Trio<int, int, byte>[] pattern) { }

	// RVA: 0x1ABF458 Offset: 0x1ABB458 VA: 0x1ABF458
	public void ChangeAITActicalPattern(SkillId firstSkillId, bool isUsedFirstSkill, Trio<int, int, byte>[] settings) { }

	// RVA: 0x1ABF498 Offset: 0x1ABB498 VA: 0x1ABF498
	public void InitializeAILoopPattern(bool isUsedFirstSkill, Trio<int, int, byte>[] pattern) { }

	// RVA: 0x1ABF524 Offset: 0x1ABB524 VA: 0x1ABF524
	public void ChangeAILoopPattern(Trio<int, int, byte>[] pattern) { }

	// RVA: 0x1ABF544 Offset: 0x1ABB544 VA: 0x1ABF544
	public void InitializeSkill(Dictionary<short, byte> skillList) { }

	// RVA: 0x1ABF56C Offset: 0x1ABB56C VA: 0x1ABF56C
	private void Start() { }

	// RVA: 0x1ABF570 Offset: 0x1ABB570 VA: 0x1ABF570
	private void Update() { }

	// RVA: 0x1ABF758 Offset: 0x1ABB758 VA: 0x1ABF758
	private void interruptAction() { }

	// RVA: 0x1ABF864 Offset: 0x1ABB864 VA: 0x1ABF864 Slot: 31
	public override void FirstEnemyContact(GameObject actor, bool isActiveInvoke) { }

	// RVA: 0x1ABF930 Offset: 0x1ABB930 VA: 0x1ABF930 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1AC0BE4 Offset: 0x1ABCBE4 VA: 0x1AC0BE4 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1AC130C Offset: 0x1ABD30C VA: 0x1AC130C
	private bool ApplyKnockBack(GameObject actor, float time, float resist, byte localId, bool force, Vector3 dir) { }

	// RVA: 0x1AC09F4 Offset: 0x1ABC9F4 VA: 0x1AC09F4
	private bool AddAbnormalKnockBack(GameObject actor, SkillDamageData damageData, Vector3 dir, byte localId) { }

	// RVA: 0x1AC1644 Offset: 0x1ABD644 VA: 0x1AC1644
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1AC1994 Offset: 0x1ABD994 VA: 0x1AC1994 Slot: 32
	public override void VanishingObject(GameObject enemy) { }

	// RVA: 0x1AC1A80 Offset: 0x1ABDA80 VA: 0x1AC1A80 Slot: 17
	public override void OnDead() { }

	// RVA: 0x1AC1BCC Offset: 0x1ABDBCC VA: 0x1AC1BCC Slot: 30
	public override void OnRespawn() { }

	// RVA: 0x1AC1CAC Offset: 0x1ABDCAC VA: 0x1AC1CAC Slot: 53
	public override void EventReserve(GameObject target, int memberNum) { }

	// RVA: 0x1AC1E58 Offset: 0x1ABDE58 VA: 0x1AC1E58 Slot: 55
	public override void ForcedAction(AIStateType stateType) { }

	// RVA: 0x1AC1FC0 Offset: 0x1ABDFC0 VA: 0x1AC1FC0 Slot: 54
	public override void EmotionReserve(EmotionPlayer.EmotionType emotionType, int memberNum) { }

	// RVA: 0x1AC1FC4 Offset: 0x1ABDFC4 VA: 0x1AC1FC4 Slot: 52
	public override void RemovePartyMember() { }

	// RVA: 0x1AC2158 Offset: 0x1ABE158 VA: 0x1AC2158
	public void SettingCommandObject(Trio<AIActionCondition, SkillId, byte>[] data) { }

	// RVA: 0x1AC2174 Offset: 0x1ABE174 VA: 0x1AC2174
	public void SetCommand(int no, Trio<AIActionCondition, SkillId, byte> data) { }

	// RVA: 0x1ABF804 Offset: 0x1ABB804 VA: 0x1ABF804
	private void ActionCancel() { }

	// RVA: 0x1AC2190 Offset: 0x1ABE190 VA: 0x1AC2190
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1AC223C Offset: 0x1ABE23C VA: 0x1AC223C
	private void <ForcedAction>b__71_0() { }
}

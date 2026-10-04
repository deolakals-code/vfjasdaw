// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(TakeController))]
[RequireComponent(typeof(SkillManager))]
public class AutoMemberActionManager : PlayerActionManagerBase // TypeDefIndex: 441
{
	// Fields
	private PlayerStatus autoPlayerStatus; // 0x88
	[CompilerGenerated]
	private ArchetypeUid <archetypeUid>k__BackingField; // 0x90
	private readonly float defaultInterruptActionTimer; // 0x98
	public AutoMemberAIAtkBase aiAtk; // 0xA0
	public AutoMemberAIAction aiAction; // 0xA8
	public AutoMemberAIRetreat aiRetreat; // 0xB0
	protected AutoMemberAITactical aiTactical; // 0xB8
	private AutoMemberAILoop aiLoop; // 0xC0
	private MobRangeAttackCollection rangeList; // 0xC8
	private PlayerBattleManager playerBattleManager; // 0xD0
	private int specialFlag; // 0xD8
	private MobManager mobManager; // 0xE0
	[CompilerGenerated]
	private GameObject <targetObject>k__BackingField; // 0xE8
	private AutoMemberBattleManager autoBattleManager; // 0xF0
	private Transform traceTarget; // 0xF8
	private AIPersonalityType personalityType; // 0x100
	private AnimationBase autoAnimation; // 0x108
	private SkillManager skillManager; // 0x110
	private SkillBufferManager skillBufManager; // 0x118
	private BufferEffectManager bufferEffectManager; // 0x120
	[CompilerGenerated]
	private AbnormalStateManager <abnormalStateManager>k__BackingField; // 0x128
	private AIMoveType nowMoveType; // 0x130
	private bool isAction; // 0x134
	private bool IsInterrupted; // 0x135
	private float actionTime; // 0x138
	private AutoMemberSettingBase setting; // 0x140
	private Vector3 oldMove; // 0x148
	private float warpCoolTime; // 0x154
	private bool roomEventHoldFlag; // 0x158
	private float stokingWaitTimer; // 0x15C
	private bool isRoomEnterStart; // 0x160

	// Properties
	public override PlayerStatusBase PlayerStatus { get; }
	public ArchetypeUid archetypeUid { get; set; }
	public override bool IsDead { get; }
	public virtual bool IsDistDamageRegist { get; }
	public override AbnormalStateManager AbnormalStatusManager { get; }
	private bool IsActionLock { get; }
	private bool IsNotFlinch { get; }
	private bool IsNotTumble { get; }
	private bool IsNotStun { get; }
	private bool IsNotKnockBack { get; }
	public bool IsNotReserve { get; }
	public bool IsAllRange { get; }
	public bool IsRootAreaRetreat { get; }
	public bool IsCompanionWarp { get; }
	public bool IsFixed_Turret { get; }
	public GameObject targetObject { get; set; }
	public AbnormalStateManager abnormalStateManager { get; set; }
	public override BufferEffectManager BufferEffectManager { get; }

	// Methods

	// RVA: 0x173F504 Offset: 0x173B504 VA: 0x173F504 Slot: 22
	public override PlayerStatusBase get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x173F50C Offset: 0x173B50C VA: 0x173F50C
	public ArchetypeUid get_archetypeUid() { }

	[CompilerGenerated]
	// RVA: 0x173F514 Offset: 0x173B514 VA: 0x173F514
	protected void set_archetypeUid(ArchetypeUid value) { }

	// RVA: 0x173F51C Offset: 0x173B51C VA: 0x173F51C Slot: 7
	public override bool get_IsDead() { }

	// RVA: 0x173F56C Offset: 0x173B56C VA: 0x173F56C Slot: 50
	public virtual bool get_IsDistDamageRegist() { }

	// RVA: 0x173F574 Offset: 0x173B574 VA: 0x173F574 Slot: 23
	public override AbnormalStateManager get_AbnormalStatusManager() { }

	// RVA: 0x173F57C Offset: 0x173B57C VA: 0x173F57C
	private bool get_IsActionLock() { }

	// RVA: 0x173F5CC Offset: 0x173B5CC VA: 0x173F5CC
	private bool get_IsNotFlinch() { }

	// RVA: 0x173F5D8 Offset: 0x173B5D8 VA: 0x173F5D8
	private bool get_IsNotTumble() { }

	// RVA: 0x173F5E4 Offset: 0x173B5E4 VA: 0x173F5E4
	private bool get_IsNotStun() { }

	// RVA: 0x173F5F0 Offset: 0x173B5F0 VA: 0x173F5F0
	private bool get_IsNotKnockBack() { }

	// RVA: 0x173CA68 Offset: 0x1738A68 VA: 0x173CA68
	public bool get_IsNotReserve() { }

	// RVA: 0x173F5FC Offset: 0x173B5FC VA: 0x173F5FC
	public bool get_IsAllRange() { }

	// RVA: 0x173F608 Offset: 0x173B608 VA: 0x173F608
	public bool get_IsRootAreaRetreat() { }

	// RVA: 0x173F614 Offset: 0x173B614 VA: 0x173F614
	public bool get_IsCompanionWarp() { }

	// RVA: 0x173F620 Offset: 0x173B620 VA: 0x173F620
	public bool get_IsFixed_Turret() { }

	[CompilerGenerated]
	// RVA: 0x173F62C Offset: 0x173B62C VA: 0x173F62C
	public GameObject get_targetObject() { }

	[CompilerGenerated]
	// RVA: 0x173F634 Offset: 0x173B634 VA: 0x173F634
	protected void set_targetObject(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x173F63C Offset: 0x173B63C VA: 0x173F63C
	protected void set_abnormalStateManager(AbnormalStateManager value) { }

	[CompilerGenerated]
	// RVA: 0x173F64C Offset: 0x173B64C VA: 0x173F64C
	public AbnormalStateManager get_abnormalStateManager() { }

	// RVA: 0x173F654 Offset: 0x173B654 VA: 0x173F654 Slot: 24
	public override BufferEffectManager get_BufferEffectManager() { }

	// RVA: 0x173F65C Offset: 0x173B65C VA: 0x173F65C Slot: 46
	protected override void Initialize(PlayerObjectBase playerObject) { }

	// RVA: 0x173F6F0 Offset: 0x173B6F0 VA: 0x173F6F0
	private void initialize(ArchetypeUid archetypeUid, AutoMemberSettingBase setting) { }

	// RVA: 0x173FB10 Offset: 0x173BB10 VA: 0x173FB10
	private void InitEquipAndStatus(ArchetypeUid archetypeUid, AutoMemberSettingBase setting) { }

	// RVA: 0x173F730 Offset: 0x173B730 VA: 0x173F730
	private void InitReference() { }

	// RVA: 0x1740204 Offset: 0x173C204 VA: 0x1740204
	private void StartchackAction() { }

	// RVA: 0x17402D0 Offset: 0x173C2D0 VA: 0x17402D0
	private void CreateAI() { }

	// RVA: 0x1740140 Offset: 0x173C140 VA: 0x1740140
	private void InitAI() { }

	// RVA: 0x173D50C Offset: 0x173950C VA: 0x173D50C
	public void InitializeAI(ArchetypeUid archetypeUid, MobRangeAttackCollection rangeList, AutoMemberSettingBase setting) { }

	// RVA: 0x173EA60 Offset: 0x173AA60 VA: 0x173EA60
	public void InitializeAITacticalPattern(SkillId firstSkillId, bool isUsedFirstSkill, Trio<int, int, byte>[] pattern) { }

	// RVA: 0x173EAF0 Offset: 0x173AAF0 VA: 0x173EAF0
	public void InitializeAILoopPattern(bool isUsedFirstSkill, Trio<int, int, byte>[] pattern) { }

	// RVA: 0x173EA28 Offset: 0x173AA28 VA: 0x173EA28
	public void InitializeSkill(Dictionary<short, byte> skillList) { }

	// RVA: 0x1740398 Offset: 0x173C398 VA: 0x1740398
	private void Start() { }

	// RVA: 0x174039C Offset: 0x173C39C VA: 0x174039C
	private void Update() { }

	// RVA: 0x174070C Offset: 0x173C70C VA: 0x174070C
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<checkAction>d__84))]
	// RVA: 0x1740264 Offset: 0x173C264 VA: 0x1740264
	private IEnumerator checkAction() { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<checkInterruptAction>d__85))]
	// RVA: 0x1740738 Offset: 0x173C738 VA: 0x1740738
	private IEnumerator checkInterruptAction() { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<checkSkillAttack>d__86))]
	// RVA: 0x17407CC Offset: 0x173C7CC VA: 0x17407CC
	private IEnumerator checkSkillAttack() { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<checkAttack>d__87))]
	// RVA: 0x1740860 Offset: 0x173C860 VA: 0x1740860
	private IEnumerator checkAttack() { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<checkRetreat>d__88))]
	// RVA: 0x17408F4 Offset: 0x173C8F4 VA: 0x17408F4
	private IEnumerator checkRetreat() { }

	// RVA: 0x173E080 Offset: 0x173A080 VA: 0x173E080
	public void SetTacticalValue(int val) { }

	// RVA: 0x1740988 Offset: 0x173C988 VA: 0x1740988
	private void actionBattleStart(GameObject target) { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<actionSkill>d__91))]
	// RVA: 0x1740A88 Offset: 0x173CA88 VA: 0x1740A88
	private IEnumerator actionSkill(GameObject target, SkillActionBase skill) { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<actionSkillAttack>d__92))]
	// RVA: 0x1740B4C Offset: 0x173CB4C VA: 0x1740B4C
	private IEnumerator actionSkillAttack(SkillActionBase skill) { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<actionTraceTarget>d__93))]
	// RVA: 0x1740BFC Offset: 0x173CBFC VA: 0x1740BFC
	private IEnumerator actionTraceTarget() { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<somethingActionWait>d__94))]
	// RVA: 0x1740C90 Offset: 0x173CC90 VA: 0x1740C90
	private IEnumerator somethingActionWait(float waitTime, Func<float, bool> act) { }

	// RVA: 0x1740D34 Offset: 0x173CD34 VA: 0x1740D34
	private void MoveWrapper(Vector3 move, float nowRate) { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<interruptActionCoroutine>d__96))]
	// RVA: 0x1741084 Offset: 0x173D084 VA: 0x1741084
	private IEnumerator interruptActionCoroutine() { }

	// RVA: 0x174064C Offset: 0x173C64C VA: 0x174064C
	private void interruptAction() { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<interruptActionWait>d__98))]
	// RVA: 0x1741118 Offset: 0x173D118 VA: 0x1741118
	private IEnumerator interruptActionWait(float wait) { }

	// RVA: 0x17411BC Offset: 0x173D1BC VA: 0x17411BC
	private void stopAction() { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<moveToTarget>d__100))]
	// RVA: 0x17411C0 Offset: 0x173D1C0 VA: 0x17411C0
	private IEnumerator moveToTarget(Transform target, float range) { }

	[IteratorStateMachine(typeof(AutoMemberActionManager.<checkWallMove>d__101))]
	// RVA: 0x1741280 Offset: 0x173D280 VA: 0x1741280
	private IEnumerator checkWallMove() { }

	// RVA: 0x1741314 Offset: 0x173D314 VA: 0x1741314
	private GameObject searchTarget() { }

	// RVA: 0x17420B4 Offset: 0x173E0B4 VA: 0x17420B4
	private GameObject getNearTarget() { }

	// RVA: 0x17421B4 Offset: 0x173E1B4 VA: 0x17421B4
	private GameObject getNotMatchMob() { }

	// RVA: 0x17424BC Offset: 0x173E4BC VA: 0x17424BC
	private GameObject getTarget() { }

	// RVA: 0x17427FC Offset: 0x173E7FC VA: 0x17427FC
	private void battleReserve(GameObject target, SkillActionBase skillAction) { }

	// RVA: 0x1740A74 Offset: 0x173CA74 VA: 0x1740A74
	private SkillActionBase getNormalSkillAction() { }

	// RVA: 0x1742900 Offset: 0x173E900 VA: 0x1742900
	public void RoomEnterStart() { }

	// RVA: 0x174290C Offset: 0x173E90C VA: 0x174290C Slot: 31
	public override void FirstEnemyContact(GameObject actor, bool isActiveInvoke) { }

	// RVA: 0x17429D8 Offset: 0x173E9D8 VA: 0x17429D8 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1743868 Offset: 0x173F868 VA: 0x1743868 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1744014 Offset: 0x1740014 VA: 0x1744014
	private bool ApplyKnockBack(GameObject actor, float time, float resist, byte localId, bool force, Vector3 dir) { }

	// RVA: 0x1743678 Offset: 0x173F678 VA: 0x1743678
	private bool AddAbnormalKnockBack(GameObject actor, SkillDamageData damageData, Vector3 dir, byte localId) { }

	// RVA: 0x17443EC Offset: 0x17403EC VA: 0x17443EC
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1744830 Offset: 0x1740830 VA: 0x1744830 Slot: 51
	protected virtual void CalcAbnormalKnockBackDistance(SkillDamageData damageData) { }

	// RVA: 0x1744960 Offset: 0x1740960 VA: 0x1744960 Slot: 32
	public override void VanishingObject(GameObject enemy) { }

	// RVA: 0x1744A9C Offset: 0x1740A9C VA: 0x1744A9C Slot: 17
	public override void OnDead() { }

	// RVA: 0x1744BB0 Offset: 0x1740BB0 VA: 0x1744BB0 Slot: 30
	public override void OnRespawn() { }

	// RVA: 0x1744C90 Offset: 0x1740C90 VA: 0x1744C90 Slot: 52
	public virtual void RemovePartyMember() { }

	// RVA: 0x1744C94 Offset: 0x1740C94 VA: 0x1744C94 Slot: 53
	public virtual void EventReserve(GameObject target, int memberNum) { }

	// RVA: 0x1744C98 Offset: 0x1740C98 VA: 0x1744C98 Slot: 54
	public virtual void EmotionReserve(EmotionPlayer.EmotionType emotionType, int memberNum) { }

	// RVA: 0x1744C9C Offset: 0x1740C9C VA: 0x1744C9C Slot: 55
	public virtual void ForcedAction(AIStateType state) { }

	// RVA: 0x1744CA0 Offset: 0x1740CA0 VA: 0x1744CA0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1744E40 Offset: 0x1740E40 VA: 0x1744E40
	private bool <checkAction>b__84_0(float x) { }

	[CompilerGenerated]
	// RVA: 0x1744E7C Offset: 0x1740E7C VA: 0x1744E7C
	private int <searchTarget>b__102_0(GameObject mob) { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(TakeController))]
[RequireComponent(typeof(SkillDelayManager))]
[RequireComponent(typeof(SkillManager))]
[RequireComponent(typeof(FadeAnimationManager))]
public class PetMemberActionManager : AutoMemberActionManager // TypeDefIndex: 1318
{
	// Fields
	private PlayerStatus autoPlayerStatus; // 0x168
	private AutoMemberAITactical aiTactical; // 0x170
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
	private PetMemberSettingBase setting; // 0x1F8
	private Vector3 oldMove; // 0x200
	private SkillDelayManager skillDelayManager; // 0x210
	private bool isEvent; // 0x218
	private float size; // 0x21C

	// Properties
	public override PlayerStatusBase PlayerStatus { get; }
	public override float Size { get; }
	public override bool IsDead { get; }
	public override float MoveSpeed { get; }
	public float PartyPetDamageDownRate { get; }
	public override bool IsDistDamageRegist { get; }
	private bool IsActionLock { get; }
	private bool IsNotFlinch { get; }
	private bool IsNotTumble { get; }
	public PetMemberSettingBase Setting { get; }

	// Methods

	// RVA: 0x1FBBAD4 Offset: 0x1FB7AD4 VA: 0x1FBBAD4 Slot: 22
	public override PlayerStatusBase get_PlayerStatus() { }

	// RVA: 0x1FBBADC Offset: 0x1FB7ADC VA: 0x1FBBADC Slot: 4
	public override float get_Size() { }

	// RVA: 0x1FBBAE4 Offset: 0x1FB7AE4 VA: 0x1FBBAE4 Slot: 7
	public override bool get_IsDead() { }

	// RVA: 0x1FBBB34 Offset: 0x1FB7B34 VA: 0x1FBBB34 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1FBBC80 Offset: 0x1FB7C80 VA: 0x1FBBC80
	public float get_PartyPetDamageDownRate() { }

	// RVA: 0x1FBBF28 Offset: 0x1FB7F28 VA: 0x1FBBF28 Slot: 50
	public override bool get_IsDistDamageRegist() { }

	[IteratorStateMachine(typeof(PetMemberActionManager.<GetParam>d__13))]
	// RVA: 0x1FBBF30 Offset: 0x1FB7F30 VA: 0x1FBBF30
	public IEnumerable<string> GetParam() { }

	[IteratorStateMachine(typeof(PetMemberActionManager.<GetAIParam>d__14))]
	// RVA: 0x1FBBFE0 Offset: 0x1FB7FE0 VA: 0x1FBBFE0
	public IEnumerable<string> GetAIParam() { }

	[IteratorStateMachine(typeof(PetMemberActionManager.<GetBonusLimitParam>d__15))]
	// RVA: 0x1FBC090 Offset: 0x1FB8090 VA: 0x1FBC090
	public IEnumerable<string> GetBonusLimitParam() { }

	[IteratorStateMachine(typeof(PetMemberActionManager.<GetBonusParam>d__16))]
	// RVA: 0x1FBC140 Offset: 0x1FB8140 VA: 0x1FBC140
	public IEnumerable<string> GetBonusParam() { }

	// RVA: 0x1FBC1F0 Offset: 0x1FB81F0 VA: 0x1FBC1F0
	private bool get_IsActionLock() { }

	// RVA: 0x1FBC240 Offset: 0x1FB8240 VA: 0x1FBC240
	private bool get_IsNotFlinch() { }

	// RVA: 0x1FBC24C Offset: 0x1FB824C VA: 0x1FBC24C
	private bool get_IsNotTumble() { }

	// RVA: 0x1FBC258 Offset: 0x1FB8258 VA: 0x1FBC258
	public PetMemberSettingBase get_Setting() { }

	// RVA: 0x1FBC260 Offset: 0x1FB8260 VA: 0x1FBC260 Slot: 46
	protected override void Initialize(PlayerObjectBase playerObject) { }

	// RVA: 0x1FBC2D0 Offset: 0x1FB82D0 VA: 0x1FBC2D0
	private void initialize(ArchetypeUid archetypeUid, PetMemberSettingBase setting) { }

	// RVA: 0x1FBCADC Offset: 0x1FB8ADC VA: 0x1FBCADC
	private void InitAI() { }

	// RVA: 0x1FB97DC Offset: 0x1FB57DC VA: 0x1FB97DC
	public void InitializeAI(ArchetypeUid archetypeUid, MobRangeAttackCollection rangeList, PetMemberSettingBase setting) { }

	// RVA: 0x1FBB7F4 Offset: 0x1FB77F4 VA: 0x1FBB7F4
	public void SetSize(float offSet) { }

	// RVA: 0x1FBC790 Offset: 0x1FB8790 VA: 0x1FBC790
	private void InitEquipAndStatus(ArchetypeUid archetypeUid, PetMemberSettingBase setting) { }

	// RVA: 0x1FBAEBC Offset: 0x1FB6EBC VA: 0x1FBAEBC
	public ItemData CreateWeapon(PetMemberSettingBase setting) { }

	// RVA: 0x1FBC308 Offset: 0x1FB8308 VA: 0x1FBC308
	private void InitReference() { }

	// RVA: 0x1FBD054 Offset: 0x1FB9054 VA: 0x1FBD054
	public void StartchackAction() { }

	// RVA: 0x1FBCF5C Offset: 0x1FB8F5C VA: 0x1FBCF5C
	private void CreateAI() { }

	// RVA: 0x1FBA2DC Offset: 0x1FB62DC VA: 0x1FBA2DC
	public void InitializeAITacticalPattern(SkillId firstSkillId, bool isUsedFirstSkill, Trio<int, int, byte>[] pattern) { }

	// RVA: 0x1FBA36C Offset: 0x1FB636C VA: 0x1FBA36C
	public void InitializeAILoopPattern(bool isUsedFirstSkill, Trio<int, int, byte>[] pattern) { }

	// RVA: 0x1FBA2A4 Offset: 0x1FB62A4 VA: 0x1FBA2A4
	public void InitializeSkill(Dictionary<short, byte> skillList) { }

	// RVA: 0x1FBD070 Offset: 0x1FB9070 VA: 0x1FBD070
	private void Start() { }

	// RVA: 0x1FBD074 Offset: 0x1FB9074 VA: 0x1FBD074
	private void Update() { }

	// RVA: 0x1FBD268 Offset: 0x1FB9268 VA: 0x1FBD268
	private void interruptAction() { }

	// RVA: 0x1FBD30C Offset: 0x1FB930C VA: 0x1FBD30C Slot: 31
	public override void FirstEnemyContact(GameObject actor, bool isActiveInvoke) { }

	// RVA: 0x1FBD3D8 Offset: 0x1FB93D8 VA: 0x1FBD3D8 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1FBDF1C Offset: 0x1FB9F1C VA: 0x1FBDF1C Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1FBE62C Offset: 0x1FBA62C VA: 0x1FBE62C
	private bool ApplyKnockBack(GameObject actor, float time, float resist, byte localId, bool force, Vector3 dir) { }

	// RVA: 0x1FBDD2C Offset: 0x1FB9D2C VA: 0x1FBDD2C
	private bool AddAbnormalKnockBack(GameObject actor, SkillDamageData damageData, Vector3 dir, byte localId) { }

	// RVA: 0x1FBE9D8 Offset: 0x1FBA9D8 VA: 0x1FBE9D8
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1FBEE1C Offset: 0x1FBAE1C VA: 0x1FBEE1C Slot: 32
	public override void VanishingObject(GameObject enemy) { }

	// RVA: 0x1FBEF08 Offset: 0x1FBAF08 VA: 0x1FBEF08 Slot: 17
	public override void OnDead() { }

	// RVA: 0x1FBF0A0 Offset: 0x1FBB0A0 VA: 0x1FBF0A0 Slot: 30
	public override void OnRespawn() { }

	// RVA: 0x1FBF18C Offset: 0x1FBB18C VA: 0x1FBF18C Slot: 53
	public override void EventReserve(GameObject target, int memberNum) { }

	// RVA: 0x1FBF32C Offset: 0x1FBB32C VA: 0x1FBF32C Slot: 55
	public override void ForcedAction(AIStateType stateType) { }

	// RVA: 0x1FBF494 Offset: 0x1FBB494 VA: 0x1FBF494 Slot: 52
	public override void RemovePartyMember() { }

	// RVA: 0x1FBF628 Offset: 0x1FBB628 VA: 0x1FBF628 Slot: 35
	public override SkillActionBase.DamageData DamageTransfer(SkillActionBase.DamageData source) { }

	// RVA: 0x1FBF83C Offset: 0x1FBB83C VA: 0x1FBF83C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1FBF8E8 Offset: 0x1FBB8E8 VA: 0x1FBF8E8
	private void <ForcedAction>b__75_0() { }
}

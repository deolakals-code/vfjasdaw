// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class SkillActionManager : SkillActionManagerBase // TypeDefIndex: 1535
{
	// Fields
	protected const int MaxPlaceSkill = 6;
	protected TakeController takeController; // 0x58
	protected CharacterMove charaMove; // 0x60
	protected CharacterActionManagerBase actionManager; // 0x68
	protected List<SkillActionManager.SkillActionData> skillDataList; // 0x70
	protected Dictionary<int, SkillActionManager.SkillActionData> skillPlayTakeList; // 0x78
	protected List<SkillActionManager.DelayData> delayHitSkillData; // 0x80
	protected List<SkillActionManager.PlaceSkillData> placeSkilList; // 0x88
	protected SkillActionManager.SkillActionData currentSkillData; // 0x90
	protected float castTime; // 0x98
	protected List<SkillActionManager.SkillCastData> skillCastList; // 0xA0
	protected int chargePlayId; // 0xA8
	protected SoundManager.SEType seType; // 0xAC
	protected List<int> stopFailureTakeUid; // 0xB0
	protected Dictionary<SkillActionManager.PlaceSkillData, float> hitCheckSkillList; // 0xB8
	[CompilerGenerated]
	private SkillActionManager.ChantingStateType <ChantingState>k__BackingField; // 0xC0

	// Properties
	public override bool IsInterruptable { get; }
	public override bool IsCasting { get; }
	public float CastTime { get; }
	public override SkillActionBase CurrentSkill { get; }
	public IEnumerable<SkillActionBase> PlaceSkilList { get; }
	public IEnumerable<SkillActionBase> BreakableSkillList { get; }
	public SkillActionManager.ChantingStateType ChantingState { get; set; }

	// Methods

	// RVA: 0x2079BB0 Offset: 0x2075BB0 VA: 0x2079BB0 Slot: 4
	public override bool get_IsInterruptable() { }

	// RVA: 0x2079C08 Offset: 0x2075C08 VA: 0x2079C08 Slot: 6
	public override bool get_IsCasting() { }

	// RVA: 0x2079C18 Offset: 0x2075C18 VA: 0x2079C18
	public float get_CastTime() { }

	// RVA: 0x2079C20 Offset: 0x2075C20 VA: 0x2079C20 Slot: 5
	public override SkillActionBase get_CurrentSkill() { }

	// RVA: 0x2079C38 Offset: 0x2075C38 VA: 0x2079C38
	public IEnumerable<SkillActionBase> get_PlaceSkilList() { }

	// RVA: 0x2079D34 Offset: 0x2075D34 VA: 0x2079D34
	public IEnumerable<SkillActionBase> get_BreakableSkillList() { }

	[CompilerGenerated]
	// RVA: 0x2079EF0 Offset: 0x2075EF0 VA: 0x2079EF0
	public SkillActionManager.ChantingStateType get_ChantingState() { }

	[CompilerGenerated]
	// RVA: 0x2079EF8 Offset: 0x2075EF8 VA: 0x2079EF8
	protected void set_ChantingState(SkillActionManager.ChantingStateType value) { }

	// RVA: 0x2079F00 Offset: 0x2075F00 VA: 0x2079F00 Slot: 12
	protected virtual void Awake() { }

	// RVA: 0x2079FC0 Offset: 0x2075FC0 VA: 0x2079FC0 Slot: 13
	protected virtual void Update() { }

	// RVA: 0x207AC78 Offset: 0x2076C78 VA: 0x207AC78 Slot: 14
	protected virtual void uniqueUpdate() { }

	// RVA: 0x207B75C Offset: 0x207775C VA: 0x207B75C Slot: 15
	public virtual void StopPlaceSkill(SkillActionBase action) { }

	// RVA: 0x207C444 Offset: 0x2078444 VA: 0x207C444
	public void StopPlaceSkillAction(int actionId) { }

	// RVA: 0x207AB5C Offset: 0x2076B5C VA: 0x207AB5C
	public void CancelPlaceSkill(int actionId, int localId) { }

	// RVA: 0x207C5DC Offset: 0x20785DC VA: 0x207C5DC
	public void EndTakeLoop(int skillId, bool checkPlace = False, bool skillEnd = False) { }

	// RVA: 0x207C834 Offset: 0x2078834 VA: 0x207C834
	public bool IsPlaySkillData(SkillId skillId) { }

	// RVA: 0x207C91C Offset: 0x207891C VA: 0x207C91C
	public void InheritanceMindimageSenju() { }

	// RVA: 0x207CF1C Offset: 0x2078F1C VA: 0x207CF1C
	public void SkipSkillData(int skillId) { }

	// RVA: 0x207D134 Offset: 0x2079134 VA: 0x207D134 Slot: 7
	public override void Initialize() { }

	// RVA: 0x207D318 Offset: 0x2079318 VA: 0x207D318 Slot: 8
	public override void End() { }

	// RVA: 0x207D770 Offset: 0x2079770 VA: 0x207D770 Slot: 10
	public override void ActionCancel() { }

	// RVA: 0x207DC34 Offset: 0x2079C34 VA: 0x207DC34
	public void VanishingObject(GameObject obj) { }

	// RVA: 0x207E2F4 Offset: 0x207A2F4 VA: 0x207E2F4
	protected void startSkill(GameObject target, SkillActionBase action) { }

	// RVA: 0x207E7EC Offset: 0x207A7EC VA: 0x207E7EC
	private SkillActionManager.SkillActionData playHitTake(SkillActionManager.SkillActionData skillData, SkillActionBase.DamageData damageData) { }

	// RVA: 0x207E86C Offset: 0x207A86C VA: 0x207E86C Slot: 16
	protected virtual SkillActionManager.SkillActionData OnPlayHitTake(SkillActionManager.SkillActionData skillData, SkillActionBase.DamageData damageData) { }

	// RVA: 0x207E874 Offset: 0x207A874 VA: 0x207E874 Slot: 17
	protected virtual SkillActionManager.SkillActionData OnPlayRangeHitTake(SkillActionManager.SkillActionData skillData, SkillActionBase.DamageData damageData) { }

	// RVA: 0x207A9D0 Offset: 0x20769D0 VA: 0x207A9D0
	private void playDelayHitTake(SkillActionManager.DelayData delayData) { }

	// RVA: 0x207E87C Offset: 0x207A87C VA: 0x207E87C
	private void playNextTake(SkillActionManager.SkillActionData skillData, SkillLinkedTake nextTake, int parentId) { }

	// RVA: 0x207EB50 Offset: 0x207AB50 VA: 0x207EB50
	private bool CheckSameSkill(SkillActionManager.SkillActionData source, SkillActionManager.SkillActionData destination) { }

	// RVA: 0x207ED5C Offset: 0x207AD5C VA: 0x207ED5C
	private void playEndTake(SkillActionManager.SkillActionData skillData) { }

	// RVA: 0x207F08C Offset: 0x207B08C VA: 0x207F08C
	private void playChargeTake(SkillActionManager.SkillActionData skillData, int takeId) { }

	// RVA: 0x207F3E8 Offset: 0x207B3E8 VA: 0x207F3E8
	private void playTargetTakePlayChargeTake(int uid, SkillActionManager.SkillActionData skillData, int takeId) { }

	// RVA: 0x207F9B4 Offset: 0x207B9B4 VA: 0x207F9B4
	private void playRequestTake(SkillActionManager.SkillActionData skillData, int takeId) { }

	// RVA: 0x207FBDC Offset: 0x207BBDC VA: 0x207FBDC
	private void playAbnormalTake(SkillActionManager.SkillActionData skillData, int takeId) { }

	// RVA: 0x207FD28 Offset: 0x207BD28 VA: 0x207FD28
	private void playEventTake(SkillActionManager.SkillActionData skillData, int parentTakeUid, int param) { }

	// RVA: 0x2080050 Offset: 0x207C050 VA: 0x2080050
	private void takeEnd(SkillActionManager.SkillActionData skillData) { }

	// RVA: 0x207D494 Offset: 0x2079494 VA: 0x207D494
	protected void stopSkillAction(SkillActionManager.SkillActionData skillData, bool immediately) { }

	// RVA: 0x207C36C Offset: 0x207836C VA: 0x207C36C
	protected void stopPlaceSkillAction(SkillActionManager.PlaceSkillData placeData) { }

	// RVA: 0x20803C0 Offset: 0x207C3C0 VA: 0x20803C0
	private void removeSkillAction(SkillActionManager.SkillActionData skillData) { }

	// RVA: 0x20802C8 Offset: 0x207C2C8 VA: 0x20802C8
	private void checkParentTakeEnd(SkillActionManager.SkillActionData skillData) { }

	// RVA: 0x207EFCC Offset: 0x207AFCC VA: 0x207EFCC
	private bool takeStopWrapper(int uid) { }

	// RVA: 0x20804E0 Offset: 0x207C4E0 VA: 0x20804E0
	private bool takePlayerDestroyWrapper(int uid) { }

	// RVA: 0x20805A0 Offset: 0x207C5A0 VA: 0x20805A0
	protected void onTakeEvent(int uid, TakeEventType eventType, int param) { }

	// RVA: 0x2083800 Offset: 0x207F800 VA: 0x2083800 Slot: 18
	protected virtual void OnTakeEvent(SkillActionManager.SkillActionData skillData, TakeEventType eventType, int param) { }

	// RVA: 0x2083804 Offset: 0x207F804 VA: 0x2083804
	public Vector3 GetPlaceSkillPos(SkillId id) { }

	// RVA: 0x2083784 Offset: 0x207F784 VA: 0x2083784
	public void OnEndChant(int callTakeUid, int param) { }

	// RVA: 0x2083934 Offset: 0x207F934 VA: 0x2083934 Slot: 19
	protected virtual void OnCastEnd(SkillActionManager.SkillActionData skill) { }

	// RVA: 0x207BAAC Offset: 0x2077AAC VA: 0x207BAAC
	protected int PlaceCount() { }

	// RVA: 0x207BF48 Offset: 0x2077F48 VA: 0x207BF48
	protected void StopPlaceSkillUpperLimit(SkillActionManager.PlaceSkillData skill) { }

	// RVA: 0x2083940 Offset: 0x207F940 VA: 0x2083940
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2083BB4 Offset: 0x207FBB4 VA: 0x2083BB4
	private bool <ActionCancel>b__45_0(SkillActionManager.PlaceSkillData x) { }

	[CompilerGenerated]
	// RVA: 0x2083BD8 Offset: 0x207FBD8 VA: 0x2083BD8
	private bool <ActionCancel>b__45_1(SkillActionManager.PlaceSkillData x) { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(CharacterMove))]
public abstract class BattleManagerBase : MonoBehaviour // TypeDefIndex: 327
{
	// Fields
	protected Transform charaTransform; // 0x20
	protected CharacterActionManagerBase actionManager; // 0x28
	protected SkillActionManagerBase skillActManager; // 0x30
	protected CharacterMove charaMove; // 0x38
	protected AnimationBase charaAnimation; // 0x40
	private readonly BattleManagerBase.TargetData mainTargetData; // 0x48
	private readonly BattleManagerBase.TargetData supportTargetData; // 0x50
	private readonly BattleManagerBase.TargetData nextTargetData; // 0x58
	private SkillActionBase nextAction; // 0x60
	private bool isFirstHit; // 0x68
	[CompilerGenerated]
	private bool <IsBattleActionLock>k__BackingField; // 0x69
	[CompilerGenerated]
	private bool <IsUnsheathe>k__BackingField; // 0x6A
	[CompilerGenerated]
	private bool <IsBattleActive>k__BackingField; // 0x6B
	[CompilerGenerated]
	private bool <IsNotReadyBattle>k__BackingField; // 0x6C
	[CompilerGenerated]
	private bool <IsRigidity>k__BackingField; // 0x6D
	[CompilerGenerated]
	private bool <IsDelay>k__BackingField; // 0x6E
	[CompilerGenerated]
	private bool <IsAssistMove>k__BackingField; // 0x6F
	[CompilerGenerated]
	private bool <IsDistanceCancel>k__BackingField; // 0x70

	// Properties
	public BattleManagerBase.TargetData MainTargetData { get; }
	public BattleManagerBase.TargetData SupportTargetData { get; }
	public BattleManagerBase.TargetData NextTargetData { get; }
	public bool IsTargeting { get; }
	public SkillActionBase NextAction { get; }
	public SkillActionManagerBase SkillActionManager { get; }
	public bool IsBattleActionLock { get; set; }
	public bool IsUnsheathe { get; set; }
	public bool IsBattleActive { get; set; }
	public bool IsNotReadyBattle { get; set; }
	public bool IsRigidity { get; set; }
	public bool IsInterruptable { get; }
	public bool IsReservedAction { get; }
	public bool IsRegisteredAction { get; }
	public bool IsDelay { get; set; }
	public bool IsAssistMove { get; set; }
	public bool IsDistanceCancel { get; set; }
	public abstract GuardType GuardType { get; }
	public abstract AvoidType AvoidType { get; }

	// Methods

	// RVA: 0x247FA08 Offset: 0x247BA08 VA: 0x247FA08
	public BattleManagerBase.TargetData get_MainTargetData() { }

	// RVA: 0x247FA10 Offset: 0x247BA10 VA: 0x247FA10
	public BattleManagerBase.TargetData get_SupportTargetData() { }

	// RVA: 0x247FA18 Offset: 0x247BA18 VA: 0x247FA18
	public BattleManagerBase.TargetData get_NextTargetData() { }

	// RVA: 0x247FA20 Offset: 0x247BA20 VA: 0x247FA20
	public bool get_IsTargeting() { }

	// RVA: 0x247FA30 Offset: 0x247BA30 VA: 0x247FA30
	public SkillActionBase get_NextAction() { }

	// RVA: 0x247FA38 Offset: 0x247BA38 VA: 0x247FA38
	public SkillActionManagerBase get_SkillActionManager() { }

	[CompilerGenerated]
	// RVA: 0x247FA40 Offset: 0x247BA40 VA: 0x247FA40
	public bool get_IsBattleActionLock() { }

	[CompilerGenerated]
	// RVA: 0x247FA48 Offset: 0x247BA48 VA: 0x247FA48
	protected void set_IsBattleActionLock(bool value) { }

	[CompilerGenerated]
	// RVA: 0x247FA54 Offset: 0x247BA54 VA: 0x247FA54
	public bool get_IsUnsheathe() { }

	[CompilerGenerated]
	// RVA: 0x247FA5C Offset: 0x247BA5C VA: 0x247FA5C
	protected void set_IsUnsheathe(bool value) { }

	[CompilerGenerated]
	// RVA: 0x247FA68 Offset: 0x247BA68 VA: 0x247FA68
	public bool get_IsBattleActive() { }

	[CompilerGenerated]
	// RVA: 0x247FA70 Offset: 0x247BA70 VA: 0x247FA70
	private void set_IsBattleActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x247FA7C Offset: 0x247BA7C VA: 0x247FA7C
	public bool get_IsNotReadyBattle() { }

	[CompilerGenerated]
	// RVA: 0x247FA84 Offset: 0x247BA84 VA: 0x247FA84
	public void set_IsNotReadyBattle(bool value) { }

	[CompilerGenerated]
	// RVA: 0x247FA90 Offset: 0x247BA90 VA: 0x247FA90
	public bool get_IsRigidity() { }

	[CompilerGenerated]
	// RVA: 0x247FA98 Offset: 0x247BA98 VA: 0x247FA98
	private void set_IsRigidity(bool value) { }

	// RVA: 0x247FAA4 Offset: 0x247BAA4 VA: 0x247FAA4
	public bool get_IsInterruptable() { }

	// RVA: 0x247FAC4 Offset: 0x247BAC4 VA: 0x247FAC4
	public bool get_IsReservedAction() { }

	// RVA: 0x247FB38 Offset: 0x247BB38 VA: 0x247FB38
	public bool get_IsRegisteredAction() { }

	[CompilerGenerated]
	// RVA: 0x247FB64 Offset: 0x247BB64 VA: 0x247FB64
	public bool get_IsDelay() { }

	[CompilerGenerated]
	// RVA: 0x247FB6C Offset: 0x247BB6C VA: 0x247FB6C
	protected void set_IsDelay(bool value) { }

	[CompilerGenerated]
	// RVA: 0x247FB78 Offset: 0x247BB78 VA: 0x247FB78
	public bool get_IsAssistMove() { }

	[CompilerGenerated]
	// RVA: 0x247FB80 Offset: 0x247BB80 VA: 0x247FB80
	protected void set_IsAssistMove(bool value) { }

	[CompilerGenerated]
	// RVA: 0x247FB8C Offset: 0x247BB8C VA: 0x247FB8C
	public bool get_IsDistanceCancel() { }

	[CompilerGenerated]
	// RVA: 0x247FB94 Offset: 0x247BB94 VA: 0x247FB94
	protected void set_IsDistanceCancel(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract GuardType get_GuardType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract AvoidType get_AvoidType();

	// RVA: 0x247FBA0 Offset: 0x247BBA0 VA: 0x247FBA0 Slot: 6
	protected virtual void Awake() { }

	// RVA: -1 Offset: -1
	public T SetSkillActionManager<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27DBDB0 Offset: 0x27D7DB0 VA: 0x27DBDB0
	|-BattleManagerBase.SetSkillActionManager<object>
	*/

	// RVA: 0x2480458 Offset: 0x247C458 VA: 0x2480458 Slot: 7
	protected virtual bool CheckInterruptable() { }

	// RVA: 0x2480460 Offset: 0x247C460 VA: 0x2480460 Slot: 8
	public virtual void ActionUpdate() { }

	// RVA: 0x2480EFC Offset: 0x247CEFC VA: 0x2480EFC
	protected void FlagClear() { }

	// RVA: 0x2480FEC Offset: 0x247CFEC VA: 0x2480FEC
	public void Initialize() { }

	// RVA: 0x2481024 Offset: 0x247D024 VA: 0x2481024 Slot: 9
	protected virtual void OnInitialize() { }

	// RVA: 0x2481028 Offset: 0x247D028 VA: 0x2481028
	public void End() { }

	// RVA: 0x2481060 Offset: 0x247D060 VA: 0x2481060 Slot: 10
	protected virtual void OnEnd() { }

	// RVA: 0x2481064 Offset: 0x247D064 VA: 0x2481064
	public void Dead() { }

	// RVA: 0x248109C Offset: 0x247D09C VA: 0x248109C Slot: 11
	protected virtual void OnDead() { }

	// RVA: 0x24810A0 Offset: 0x247D0A0 VA: 0x24810A0
	public void ApparentDeath() { }

	// RVA: 0x2481110 Offset: 0x247D110 VA: 0x2481110
	public void Respawn(bool orbRespawn) { }

	// RVA: 0x2481120 Offset: 0x247D120 VA: 0x2481120 Slot: 12
	protected virtual void OnRespawn(bool orbRespawn) { }

	// RVA: 0x2481124 Offset: 0x247D124 VA: 0x2481124
	public void ReviveFromApparentDeath() { }

	// RVA: 0x248112C Offset: 0x247D12C VA: 0x248112C
	public void ClearTarget() { }

	// RVA: 0x2481168 Offset: 0x247D168 VA: 0x2481168
	public void ClearSupportTarget() { }

	// RVA: 0x24811A4 Offset: 0x247D1A4 VA: 0x24811A4 Slot: 13
	public virtual void CancelCurrentAction() { }

	// RVA: 0x24811C4 Offset: 0x247D1C4 VA: 0x24811C4 Slot: 14
	public virtual void CancelNextAction() { }

	// RVA: 0x2481230 Offset: 0x247D230 VA: 0x2481230 Slot: 15
	protected virtual void OnNextActionCancel() { }

	// RVA: 0x2481234 Offset: 0x247D234 VA: 0x2481234 Slot: 16
	public virtual void ClearDelay() { }

	// RVA: 0x248123C Offset: 0x247D23C VA: 0x248123C
	public void ClearRigidity() { }

	// RVA: 0x2481244 Offset: 0x247D244 VA: 0x2481244
	public bool BattleReserve(GameObject target, SkillActionBase action, bool ignoreDelay, bool isTargetAction = False) { }

	// RVA: 0x248190C Offset: 0x247D90C VA: 0x248190C
	public bool SupportReserve(GameObject target, SkillActionBase action, bool ignoreDelay, bool isTargetAction = False) { }

	// RVA: 0x2481314 Offset: 0x247D314 VA: 0x2481314
	private bool actionReserve(GameObject target, SkillActionBase action, BattleManagerBase.NextTargetType type, bool ignoreDelay, bool isTargetAction) { }

	// RVA: 0x2481A14 Offset: 0x247DA14 VA: 0x2481A14 Slot: 17
	protected virtual bool CheckActionRange() { }

	// RVA: 0x24805DC Offset: 0x247C5DC VA: 0x24805DC
	protected bool BattleEntry(GameObject target, SkillActionBase action) { }

	// RVA: 0x2480AD0 Offset: 0x247CAD0 VA: 0x2480AD0
	protected bool SupportEntry(GameObject target, SkillActionBase action) { }

	// RVA: 0x2481AF4 Offset: 0x247DAF4 VA: 0x2481AF4
	public void BattleActive() { }

	// RVA: 0x2481B18 Offset: 0x247DB18 VA: 0x2481B18 Slot: 18
	public virtual void CheckBattleEnd() { }

	// RVA: 0x2481B1C Offset: 0x247DB1C VA: 0x2481B1C
	public void BattleEnd() { }

	// RVA: 0x2481B68 Offset: 0x247DB68 VA: 0x2481B68 Slot: 19
	protected virtual bool OnActionRange(GameObject target, SkillActionBase action) { }

	// RVA: 0x2481B70 Offset: 0x247DB70 VA: 0x2481B70 Slot: 20
	protected virtual bool OnActionOutOfRange(GameObject target, SkillActionBase action) { }

	// RVA: 0x2481AE4 Offset: 0x247DAE4 VA: 0x2481AE4
	public bool EndAssistMove(GameObject target) { }

	// RVA: 0x2481B78 Offset: 0x247DB78 VA: 0x2481B78 Slot: 21
	protected virtual bool OnEndAssistMove(GameObject target) { }

	// RVA: 0x2481B80 Offset: 0x247DB80 VA: 0x2481B80 Slot: 22
	protected virtual void OnBattleActive() { }

	// RVA: 0x2481B84 Offset: 0x247DB84 VA: 0x2481B84 Slot: 23
	protected virtual void OnBattleEnd() { }

	// RVA: 0x2481B88 Offset: 0x247DB88 VA: 0x2481B88 Slot: 24
	public virtual void OnInputMove() { }

	// RVA: 0x2481B8C Offset: 0x247DB8C VA: 0x2481B8C Slot: 25
	public virtual void OnGuard(GameObject actor, SkillDamageData damageData) { }

	// RVA: 0x2481B90 Offset: 0x247DB90 VA: 0x2481B90 Slot: 26
	public virtual int CalcGuard(int damage, out int guardPower) { }

	// RVA: 0x2481B9C Offset: 0x247DB9C VA: 0x2481B9C Slot: 27
	public virtual void OnAvoid(GameObject actor) { }

	// RVA: 0x2481BA0 Offset: 0x247DBA0 VA: 0x2481BA0 Slot: 28
	protected virtual bool OnSkillActionStart(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x2481BA8 Offset: 0x247DBA8 VA: 0x2481BA8
	private void OnSkillActionHitBase(GameObject target, SkillActionBase action) { }

	// RVA: 0x2481C8C Offset: 0x247DC8C VA: 0x2481C8C Slot: 29
	protected virtual void OnSkillActionHit(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x2481C90 Offset: 0x247DC90 VA: 0x2481C90
	private void OnSkillActionDamagedBase(GameObject target, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x2481D58 Offset: 0x247DD58 VA: 0x2481D58 Slot: 30
	protected virtual void OnSkillActionDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x2481D5C Offset: 0x247DD5C VA: 0x2481D5C
	private void OnSkillActionRangeDamagedBase(GameObject target, SkillActionBase action) { }

	// RVA: 0x2481E18 Offset: 0x247DE18 VA: 0x2481E18 Slot: 31
	protected virtual void OnSkillActionRangeDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x2481E1C Offset: 0x247DE1C VA: 0x2481E1C
	private void OnSkillActionEndBase(GameObject target, SkillActionBase action) { }

	// RVA: 0x2481F5C Offset: 0x247DF5C VA: 0x2481F5C Slot: 32
	protected virtual void OnSkillActionEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x2481F60 Offset: 0x247DF60 VA: 0x2481F60
	private void OnSkillActionAllEndBase(GameObject target, SkillActionBase action) { }

	// RVA: 0x2482038 Offset: 0x247E038 VA: 0x2482038 Slot: 33
	protected virtual void OnSkillActionAllEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x248203C Offset: 0x247E03C VA: 0x248203C
	private void OnSkillActionCancelBase(GameObject target, SkillActionBase action) { }

	// RVA: 0x2482090 Offset: 0x247E090 VA: 0x2482090 Slot: 34
	protected virtual void OnSkillActionCancel(GameObject target, SkillActionBase action) { }

	// RVA: 0x2482094 Offset: 0x247E094 VA: 0x2482094
	private void OnSkillActionSupportBase(GameObject target, SkillActionBase action) { }

	// RVA: 0x2482150 Offset: 0x247E150 VA: 0x2482150 Slot: 35
	protected virtual void OnSkillActionSupport(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x2482154 Offset: 0x247E154 VA: 0x2482154
	public void SetNextSkillAction(SkillActionBase action) { }

	// RVA: 0x2482158 Offset: 0x247E158 VA: 0x2482158
	public void InterruptSkillAction(SkillActionBase action) { }

	// RVA: 0x248215C Offset: 0x247E15C VA: 0x248215C Slot: 36
	public virtual void ChangeField() { }

	// RVA: 0x2482160 Offset: 0x247E160 VA: 0x2482160 Slot: 37
	public virtual void ChangeStatus() { }

	// RVA: 0x2482164 Offset: 0x247E164 VA: 0x2482164
	protected void .ctor() { }
}

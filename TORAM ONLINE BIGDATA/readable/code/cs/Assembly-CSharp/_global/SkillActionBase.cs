// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class SkillActionBase : IEquatable<SkillActionBase> // TypeDefIndex: 355
{
	// Fields
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <Level>k__BackingField; // 0x14
	[CompilerGenerated]
	private bool <IsTargetActive>k__BackingField; // 0x15
	private GameObject skillPosition; // 0x18
	[CompilerGenerated]
	private float <ActionRange>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <CastTime>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <LoopParam>k__BackingField; // 0x28
	[CompilerGenerated]
	private float <Delay>k__BackingField; // 0x2C
	[CompilerGenerated]
	private ElementType <Element>k__BackingField; // 0x30
	[CompilerGenerated]
	private ElementType <SubElement>k__BackingField; // 0x34
	[CompilerGenerated]
	private float <Param>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <AtkParam>k__BackingField; // 0x3C
	[CompilerGenerated]
	private int <CspdParam>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x44
	[CompilerGenerated]
	private float <Radius>k__BackingField; // 0x48
	protected List<SkillActionBase.ApplyBufferData> temporaryApplySkillBuffer; // 0x50
	[CompilerGenerated]
	private SkillLinkedTake <CurrentTake>k__BackingField; // 0x58
	[CompilerGenerated]
	private Dictionary<TakeParameterType, int> <HitTakeAppendParam>k__BackingField; // 0x60
	[CompilerGenerated]
	private Dictionary<int, bool> <TargetMobDamageLimitList>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <IsOtherPlayer>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <IsMotionEnd>k__BackingField; // 0x71
	[CompilerGenerated]
	private bool <ChangeCriticalHitTake>k__BackingField; // 0x72
	[CompilerGenerated]
	private bool <UnmanagedHitTake>k__BackingField; // 0x73
	protected float startTargetDist; // 0x74
	private int _motionSpeed; // 0x78
	private int _attackCount; // 0x7C
	private List<SkillActionBase.DamageData> targetDamageData; // 0x80
	private List<SkillActionBase.TargetData> hitTargetData; // 0x88
	private bool isStatusTemporary; // 0x90
	private Dictionary<IMobIdData, byte> damageCountList; // 0x98

	// Properties
	public int Id { get; set; }
	public byte Level { get; set; }
	public abstract int ActionID { get; }
	public abstract SkillAttackType AttackType { get; }
	public virtual SkillAttackType ExpType { get; }
	public abstract bool IsInterruptable { get; }
	public abstract bool IsHitRigidity { get; }
	public abstract bool IsMoveAssistContinue { get; }
	public bool IsTargetActive { get; set; }
	public abstract bool IsUnsheatheWeapon { get; }
	public abstract bool IsPutUpWeapon { get; }
	public abstract bool IsPlace { get; }
	public abstract bool IsRange { get; }
	public abstract bool IsSupport { get; }
	public virtual bool IsSupportSetLocalId { get; }
	public virtual bool IsBreakable { get; }
	public virtual bool IsNotContactPlaced { get; }
	public virtual bool IsOverlay { get; }
	public virtual bool IsFallFailure { get; }
	public virtual string LocalizeKey { get; }
	public abstract int Mp { get; }
	public abstract int BaseMp { get; }
	public GameObject SkillPosition { get; set; }
	public float ActionRange { get; set; }
	public float CastTime { get; set; }
	public int MotionSpeed { get; set; }
	public int LoopParam { get; set; }
	public float Delay { get; set; }
	public ElementType Element { get; set; }
	public ElementType SubElement { get; set; }
	public float Param { get; set; }
	public int AtkParam { get; set; }
	public int CspdParam { get; set; }
	public bool IsEnd { get; set; }
	public float Radius { get; set; }
	public virtual bool IsOverMp { get; }
	public SkillLinkedTake CurrentTake { get; set; }
	public SkillLinkedTake CurrentEventTake { get; }
	public Dictionary<TakeParameterType, int> HitTakeAppendParam { get; set; }
	public List<SkillActionBase.DamageData> TargetDamageData { get; }
	public virtual bool IsChatLog { get; }
	public virtual bool IsPayHp { get; }
	public virtual SkillChargingType ChargingType { get; }
	public virtual bool IsMove { get; }
	public virtual bool IsExpDefFluctuate { get; }
	public Dictionary<int, bool> TargetMobDamageLimitList { get; set; }
	public virtual bool IsEventIgnoreOther { get; }
	public virtual bool IsNoMotionTake { get; }
	public virtual bool IsSkillStartTargetLook { get; }
	public virtual bool IsNotPlayToOtherPlayer { get; }
	public bool IsOtherPlayer { get; set; }
	public bool IsMotionEnd { get; set; }
	public byte AttackCount { get; }
	public virtual bool IsServantSkill { get; }
	public virtual bool NonElementEffect { get; }
	public bool ChangeCriticalHitTake { get; set; }
	public bool UnmanagedHitTake { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2487AAC Offset: 0x2483AAC VA: 0x2487AAC
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x2487AB4 Offset: 0x2483AB4 VA: 0x2487AB4
	private void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x2487ABC Offset: 0x2483ABC VA: 0x2487ABC
	public byte get_Level() { }

	[CompilerGenerated]
	// RVA: 0x2487AC4 Offset: 0x2483AC4 VA: 0x2487AC4
	private void set_Level(byte value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_ActionID();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract SkillAttackType get_AttackType();

	// RVA: 0x2487ACC Offset: 0x2483ACC VA: 0x2487ACC Slot: 7
	public virtual SkillAttackType get_ExpType() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_IsInterruptable();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsHitRigidity();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsMoveAssistContinue();

	[CompilerGenerated]
	// RVA: 0x2487AD8 Offset: 0x2483AD8 VA: 0x2487AD8
	public bool get_IsTargetActive() { }

	[CompilerGenerated]
	// RVA: 0x2487AE0 Offset: 0x2483AE0 VA: 0x2487AE0
	public void set_IsTargetActive(bool value) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsUnsheatheWeapon();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool get_IsPutUpWeapon();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_IsPlace();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsRange();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_IsSupport();

	// RVA: 0x2487AEC Offset: 0x2483AEC VA: 0x2487AEC Slot: 16
	public virtual bool get_IsSupportSetLocalId() { }

	// RVA: 0x2487AF4 Offset: 0x2483AF4 VA: 0x2487AF4 Slot: 17
	public virtual bool get_IsBreakable() { }

	// RVA: 0x2487AFC Offset: 0x2483AFC VA: 0x2487AFC Slot: 18
	public virtual bool get_IsNotContactPlaced() { }

	// RVA: 0x2487B04 Offset: 0x2483B04 VA: 0x2487B04 Slot: 19
	public virtual bool get_IsOverlay() { }

	// RVA: 0x2487B0C Offset: 0x2483B0C VA: 0x2487B0C Slot: 20
	public virtual bool get_IsFallFailure() { }

	// RVA: 0x2487B14 Offset: 0x2483B14 VA: 0x2487B14 Slot: 21
	public virtual string get_LocalizeKey() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract int get_Mp();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract int get_BaseMp();

	// RVA: 0x2487BC0 Offset: 0x2483BC0 VA: 0x2487BC0
	public GameObject get_SkillPosition() { }

	// RVA: 0x2487BC8 Offset: 0x2483BC8 VA: 0x2487BC8
	protected void set_SkillPosition(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x2487CA0 Offset: 0x2483CA0 VA: 0x2487CA0
	public float get_ActionRange() { }

	[CompilerGenerated]
	// RVA: 0x2487CA8 Offset: 0x2483CA8 VA: 0x2487CA8
	protected void set_ActionRange(float value) { }

	[CompilerGenerated]
	// RVA: 0x2487CB0 Offset: 0x2483CB0 VA: 0x2487CB0
	public float get_CastTime() { }

	[CompilerGenerated]
	// RVA: 0x2487CB8 Offset: 0x2483CB8 VA: 0x2487CB8
	protected void set_CastTime(float value) { }

	// RVA: 0x2487CC0 Offset: 0x2483CC0 VA: 0x2487CC0
	public int get_MotionSpeed() { }

	// RVA: 0x2487CE0 Offset: 0x2483CE0 VA: 0x2487CE0
	protected void set_MotionSpeed(int value) { }

	[CompilerGenerated]
	// RVA: 0x2487CE8 Offset: 0x2483CE8 VA: 0x2487CE8
	public int get_LoopParam() { }

	[CompilerGenerated]
	// RVA: 0x2487CF0 Offset: 0x2483CF0 VA: 0x2487CF0
	protected void set_LoopParam(int value) { }

	[CompilerGenerated]
	// RVA: 0x2487CF8 Offset: 0x2483CF8 VA: 0x2487CF8
	public float get_Delay() { }

	[CompilerGenerated]
	// RVA: 0x2487D00 Offset: 0x2483D00 VA: 0x2487D00
	protected void set_Delay(float value) { }

	[CompilerGenerated]
	// RVA: 0x2487D08 Offset: 0x2483D08 VA: 0x2487D08
	public ElementType get_Element() { }

	[CompilerGenerated]
	// RVA: 0x2487D10 Offset: 0x2483D10 VA: 0x2487D10
	protected void set_Element(ElementType value) { }

	[CompilerGenerated]
	// RVA: 0x2487D18 Offset: 0x2483D18 VA: 0x2487D18
	public ElementType get_SubElement() { }

	[CompilerGenerated]
	// RVA: 0x2487D20 Offset: 0x2483D20 VA: 0x2487D20
	protected void set_SubElement(ElementType value) { }

	[CompilerGenerated]
	// RVA: 0x2487D28 Offset: 0x2483D28 VA: 0x2487D28
	public float get_Param() { }

	[CompilerGenerated]
	// RVA: 0x2487D30 Offset: 0x2483D30 VA: 0x2487D30
	protected void set_Param(float value) { }

	[CompilerGenerated]
	// RVA: 0x2487D38 Offset: 0x2483D38 VA: 0x2487D38
	public int get_AtkParam() { }

	[CompilerGenerated]
	// RVA: 0x2487D40 Offset: 0x2483D40 VA: 0x2487D40
	protected void set_AtkParam(int value) { }

	[CompilerGenerated]
	// RVA: 0x2487D48 Offset: 0x2483D48 VA: 0x2487D48
	public int get_CspdParam() { }

	[CompilerGenerated]
	// RVA: 0x2487D50 Offset: 0x2483D50 VA: 0x2487D50
	protected void set_CspdParam(int value) { }

	[CompilerGenerated]
	// RVA: 0x2487D58 Offset: 0x2483D58 VA: 0x2487D58
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x2487D60 Offset: 0x2483D60 VA: 0x2487D60
	protected void set_IsEnd(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2487D6C Offset: 0x2483D6C VA: 0x2487D6C
	public float get_Radius() { }

	[CompilerGenerated]
	// RVA: 0x2487D74 Offset: 0x2483D74 VA: 0x2487D74
	protected void set_Radius(float value) { }

	// RVA: 0x2487D7C Offset: 0x2483D7C VA: 0x2487D7C Slot: 24
	public virtual bool get_IsOverMp() { }

	[CompilerGenerated]
	// RVA: 0x2487D84 Offset: 0x2483D84 VA: 0x2487D84
	public SkillLinkedTake get_CurrentTake() { }

	[CompilerGenerated]
	// RVA: 0x2487D8C Offset: 0x2483D8C VA: 0x2487D8C
	public void set_CurrentTake(SkillLinkedTake value) { }

	// RVA: 0x2487D94 Offset: 0x2483D94 VA: 0x2487D94
	public SkillLinkedTake get_CurrentEventTake() { }

	[CompilerGenerated]
	// RVA: 0x2487DAC Offset: 0x2483DAC VA: 0x2487DAC
	public Dictionary<TakeParameterType, int> get_HitTakeAppendParam() { }

	[CompilerGenerated]
	// RVA: 0x2487DB4 Offset: 0x2483DB4 VA: 0x2487DB4
	private void set_HitTakeAppendParam(Dictionary<TakeParameterType, int> value) { }

	// RVA: 0x2487DBC Offset: 0x2483DBC VA: 0x2487DBC
	public List<SkillActionBase.DamageData> get_TargetDamageData() { }

	// RVA: 0x2487DC4 Offset: 0x2483DC4 VA: 0x2487DC4 Slot: 25
	public virtual bool get_IsChatLog() { }

	// RVA: 0x2487DCC Offset: 0x2483DCC VA: 0x2487DCC Slot: 26
	public virtual bool get_IsPayHp() { }

	// RVA: 0x2487DD4 Offset: 0x2483DD4 VA: 0x2487DD4 Slot: 27
	public virtual SkillChargingType get_ChargingType() { }

	// RVA: 0x2487DF4 Offset: 0x2483DF4 VA: 0x2487DF4 Slot: 28
	public virtual bool get_IsMove() { }

	// RVA: 0x2487DFC Offset: 0x2483DFC VA: 0x2487DFC Slot: 29
	public virtual bool get_IsExpDefFluctuate() { }

	[CompilerGenerated]
	// RVA: 0x2487E04 Offset: 0x2483E04 VA: 0x2487E04
	public Dictionary<int, bool> get_TargetMobDamageLimitList() { }

	[CompilerGenerated]
	// RVA: 0x2487E0C Offset: 0x2483E0C VA: 0x2487E0C
	private void set_TargetMobDamageLimitList(Dictionary<int, bool> value) { }

	// RVA: 0x2487E14 Offset: 0x2483E14 VA: 0x2487E14 Slot: 30
	public virtual bool get_IsEventIgnoreOther() { }

	// RVA: 0x2487E1C Offset: 0x2483E1C VA: 0x2487E1C Slot: 31
	public virtual bool get_IsNoMotionTake() { }

	// RVA: 0x2487E24 Offset: 0x2483E24 VA: 0x2487E24 Slot: 32
	public virtual bool get_IsSkillStartTargetLook() { }

	// RVA: 0x2487E2C Offset: 0x2483E2C VA: 0x2487E2C Slot: 33
	public virtual bool get_IsNotPlayToOtherPlayer() { }

	[CompilerGenerated]
	// RVA: 0x2487E34 Offset: 0x2483E34 VA: 0x2487E34
	public bool get_IsOtherPlayer() { }

	[CompilerGenerated]
	// RVA: 0x2487E3C Offset: 0x2483E3C VA: 0x2487E3C
	private void set_IsOtherPlayer(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2487E48 Offset: 0x2483E48 VA: 0x2487E48
	public bool get_IsMotionEnd() { }

	[CompilerGenerated]
	// RVA: 0x2487E50 Offset: 0x2483E50 VA: 0x2487E50
	private void set_IsMotionEnd(bool value) { }

	// RVA: 0x2487E5C Offset: 0x2483E5C VA: 0x2487E5C
	public byte get_AttackCount() { }

	// RVA: 0x2487E64 Offset: 0x2483E64 VA: 0x2487E64 Slot: 34
	public virtual bool get_IsServantSkill() { }

	// RVA: 0x2487E6C Offset: 0x2483E6C VA: 0x2487E6C Slot: 35
	public virtual bool get_NonElementEffect() { }

	[CompilerGenerated]
	// RVA: 0x2487E74 Offset: 0x2483E74 VA: 0x2487E74
	public bool get_ChangeCriticalHitTake() { }

	[CompilerGenerated]
	// RVA: 0x2487E7C Offset: 0x2483E7C VA: 0x2487E7C
	public void set_ChangeCriticalHitTake(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2487E88 Offset: 0x2483E88 VA: 0x2487E88
	public bool get_UnmanagedHitTake() { }

	[CompilerGenerated]
	// RVA: 0x2487E90 Offset: 0x2483E90 VA: 0x2487E90
	public void set_UnmanagedHitTake(bool value) { }

	// RVA: 0x2487E9C Offset: 0x2483E9C VA: 0x2487E9C
	public void AddHitTakeAppendParam(TakeParameterType type, int param) { }

	// RVA: 0x2487F58 Offset: 0x2483F58 VA: 0x2487F58 Slot: 36
	public virtual void UnsheatheWeaponAction() { }

	// RVA: 0x2487F5C Offset: 0x2483F5C VA: 0x2487F5C
	protected void .ctor() { }

	// RVA: 0x248814C Offset: 0x248414C VA: 0x248814C
	public void SetId(int id) { }

	// RVA: 0x2488160 Offset: 0x2484160 VA: 0x2488160
	public void AddAttackCount() { }

	// RVA: 0x248817C Offset: 0x248417C VA: 0x248817C
	public void TemporaryStatus() { }

	// RVA: 0x2488188 Offset: 0x2484188 VA: 0x2488188
	public void RestoreStatus() { }

	// RVA: 0x2488190 Offset: 0x2484190 VA: 0x2488190
	public void Initialize(CharacterActionManagerBase actarAction, byte lv) { }

	// RVA: 0x24881E4 Offset: 0x24841E4 VA: 0x24881E4 Slot: 37
	protected virtual void InitializeElement(CharacterActionManagerBase actarAction) { }

	// RVA: 0x24881E8 Offset: 0x24841E8 VA: 0x24881E8 Slot: 38
	protected virtual void OnInitialize(CharacterActionManagerBase actarAction) { }

	// RVA: 0x24881EC Offset: 0x24841EC VA: 0x24881EC Slot: 39
	public virtual void ActionPreparation(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x24881F0 Offset: 0x24841F0 VA: 0x24881F0 Slot: 40
	public virtual void ActionStart(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x24881F4 Offset: 0x24841F4 VA: 0x24881F4
	public void UseOtherPlayer() { }

	// RVA: 0x2488200 Offset: 0x2484200 VA: 0x2488200
	public void InitializeOthers(IOtherPlayerActionManager actarAction, AttackStartEventData eventData) { }

	// RVA: 0x248826C Offset: 0x248426C VA: 0x248826C
	public void InitializeOthers(IOtherPlayerActionManager actarAction, SupportStartEventData eventData) { }

	// RVA: 0x2488400 Offset: 0x2484400 VA: 0x2488400 Slot: 41
	public virtual void InitializeOthers(IOtherPlayerActionManager actarAction, Vector3 targetPos, int motionSpeed, float castTime, int loopCount, int element) { }

	// RVA: 0x2488404 Offset: 0x2484404 VA: 0x2488404 Slot: 42
	public virtual void SetTargetMobOthers(GameObject target) { }

	// RVA: 0x2488408 Offset: 0x2484408 VA: 0x2488408 Slot: 43
	public virtual void ActionStartOthers(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x248840C Offset: 0x248440C VA: 0x248840C Slot: 44
	public virtual void ActionHit(CharacterActionManagerBase actarAction, GameObject target) { }

	// RVA: 0x2488410 Offset: 0x2484410 VA: 0x2488410 Slot: 45
	public virtual void ReceiveMobaActionHit(MobaPlayerActionManager actarAction, CharacterActionManagerBase targetAction, byte attackCount) { }

	// RVA: 0x2488414 Offset: 0x2484414 VA: 0x2488414 Slot: 46
	public virtual void ActionSkillEventPreparation(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x2488418 Offset: 0x2484418 VA: 0x2488418 Slot: 47
	public virtual void ActionSkillEvent(CharacterActionManagerBase actarAction, int param) { }

	// RVA: 0x248841C Offset: 0x248441C VA: 0x248841C Slot: 48
	public virtual void ActionSkillReceiveEffect(GameObject effect) { }

	// RVA: 0x2488420 Offset: 0x2484420 VA: 0x2488420 Slot: 49
	public virtual bool ActionSkillEventIfMoveIndex(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2488428 Offset: 0x2484428 VA: 0x2488428 Slot: 50
	public virtual bool ActionSkillEndCheck(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2488430 Offset: 0x2484430 VA: 0x2488430 Slot: 51
	public virtual bool ActionSkillEventCheckPlaySE(CharacterActionManagerBase actarAction) { }

	// RVA: 0x2488438 Offset: 0x2484438 VA: 0x2488438 Slot: 52
	public virtual void ActionSkillUpdateAppendParam(CharacterActionManagerBase actarAction, Func<TakeParameterType, int, bool> updateAppendParam, int param) { }

	// RVA: 0x248843C Offset: 0x248443C VA: 0x248843C
	public void End(bool cancel) { }

	// RVA: 0x24884F8 Offset: 0x24844F8 VA: 0x24884F8 Slot: 53
	protected virtual void OnEnd(bool cancel) { }

	// RVA: 0x24884FC Offset: 0x24844FC VA: 0x24884FC
	public void MotionEnd() { }

	// RVA: 0x2488514 Offset: 0x2484514 VA: 0x2488514 Slot: 54
	protected virtual void OnMotionEnd() { }

	// RVA: 0x2488518 Offset: 0x2484518 VA: 0x2488518
	public bool NextTake() { }

	// RVA: 0x2488554 Offset: 0x2484554 VA: 0x2488554
	public void SetMotionSpeed(int speed) { }

	// RVA: 0x248855C Offset: 0x248455C VA: 0x248855C
	public void CalcDamage(CharacterActionManagerBase actarAction, CharacterActionManagerBase targetAction) { }

	// RVA: 0x2489148 Offset: 0x2485148 VA: 0x2489148 Slot: 55
	protected virtual void calcPlayerToMobDamage(PlayerActionManagerBase playerAction, MobActionManagerBase mobAction) { }

	// RVA: 0x248914C Offset: 0x248514C VA: 0x248914C Slot: 56
	protected virtual void calcMobToPlayerDamage(MobActionManagerBase mobAction, PlayerActionManagerBase playerAction) { }

	// RVA: 0x2489150 Offset: 0x2485150 VA: 0x2489150 Slot: 57
	protected virtual void calcPlayerToPlayerDamage(PlayerActionManagerBase playerAction, PlayerActionManagerBase targetAction) { }

	// RVA: 0x2489154 Offset: 0x2485154 VA: 0x2489154 Slot: 58
	protected virtual void calcMobToMobDamage(MobActionManagerBase mobAction, MobActionManagerBase targetAction) { }

	// RVA: 0x2489158 Offset: 0x2485158 VA: 0x2489158 Slot: 59
	public virtual bool CheckRangeHit(Transform actorTransform, Transform targetTransform, float size) { }

	// RVA: 0x2489160 Offset: 0x2485160 VA: 0x2489160 Slot: 60
	public virtual void NextRangeHit() { }

	// RVA: 0x2489164 Offset: 0x2485164 VA: 0x2489164
	protected static float CalcStablePercent(int stable) { }

	// RVA: 0x24891A8 Offset: 0x24851A8 VA: 0x24891A8
	protected static float CalcMagicStablePercent(int stable) { }

	// RVA: 0x24891B0 Offset: 0x24851B0 VA: 0x24891B0
	protected static float CalcMagicStablePercent(int stable, int limit) { }

	// RVA: 0x2489260 Offset: 0x2485260 VA: 0x2489260
	protected bool checkPercent(int max, int per) { }

	// RVA: 0x2489284 Offset: 0x2485284 VA: 0x2489284 Slot: 61
	public virtual bool CheckPayHp(CharacterActionManagerBase actarAction) { }

	// RVA: 0x248928C Offset: 0x248528C VA: 0x248928C Slot: 62
	public virtual void StrengthPayHp(CharacterActionManagerBase actarAction) { }

	// RVA: 0x24812EC Offset: 0x247D2EC VA: 0x24812EC
	public static bool op_Equality(SkillActionBase x, SkillActionBase y) { }

	// RVA: 0x247FAD4 Offset: 0x247BAD4 VA: 0x247FAD4
	public static bool op_Inequality(SkillActionBase x, SkillActionBase y) { }

	// RVA: 0x24892DC Offset: 0x24852DC VA: 0x24892DC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2489384 Offset: 0x2485384 VA: 0x2489384 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2489290 Offset: 0x2485290 VA: 0x2489290 Slot: 4
	public bool Equals(SkillActionBase other) { }

	// RVA: 0x24893AC Offset: 0x24853AC VA: 0x24893AC
	protected void AddTemporarySkillBuffer(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2488DDC Offset: 0x2484DDC VA: 0x2488DDC
	private void TemporarySkillBufferActivation(PlayerActionManagerBase playerAction) { }

	// RVA: 0x2488F94 Offset: 0x2484F94 VA: 0x2488F94
	private void TemporarySkillBufferInvalidation(PlayerActionManagerBase playerAction) { }

	// RVA: 0x24897C0 Offset: 0x24857C0 VA: 0x24897C0
	protected void CopyTemporarySkillBuffer(SkillActionBase sorce) { }

	// RVA: 0x248988C Offset: 0x248588C VA: 0x248988C Slot: 63
	public virtual bool IsFailure(PlayerStatusBase status, out UI3DLabelManager.SkillMissType missType) { }

	// RVA: 0x2489898 Offset: 0x2485898 VA: 0x2489898
	public void SetMainTarget(CharacterActionManagerBase mainTarget) { }

	// RVA: 0x24899F0 Offset: 0x24859F0 VA: 0x24899F0
	public CharacterActionManagerBase GetMainTarget() { }

	// RVA: 0x2489B1C Offset: 0x2485B1C VA: 0x2489B1C
	public void AddHitTarget(CharacterActionManagerBase target) { }

	// RVA: 0x2489C00 Offset: 0x2485C00 VA: 0x2489C00
	public bool ContainsHitTarget(CharacterActionManagerBase target) { }

	// RVA: 0x2489D14 Offset: 0x2485D14 VA: 0x2489D14
	public bool CheckMainTarget(CharacterActionManagerBase target) { }

	// RVA: 0x2489E28 Offset: 0x2485E28 VA: 0x2489E28
	public bool CheckHitTarget(CharacterActionManagerBase target) { }

	// RVA: 0x2489F2C Offset: 0x2485F2C VA: 0x2489F2C
	public int HitTargetNum() { }

	// RVA: 0x248A04C Offset: 0x248604C VA: 0x248A04C
	public CharacterActionManagerBase[] GetAttackedTargets() { }

	// RVA: 0x248A250 Offset: 0x2486250 VA: 0x248A250
	public void HitTarget(CharacterActionManagerBase target) { }

	// RVA: 0x248A35C Offset: 0x248635C VA: 0x248A35C
	public void CopyHitTargetData(SkillActionBase source) { }

	// RVA: 0x248A748 Offset: 0x2486748 VA: 0x248A748
	public int CalcActualDamage(EnemyMobActionManagerBase monster, int damage) { }

	// RVA: 0x248A9C0 Offset: 0x24869C0 VA: 0x248A9C0 Slot: 64
	protected virtual void ActiveHpLock(int uniqueId) { }

	// RVA: 0x248AA7C Offset: 0x2486A7C VA: 0x248AA7C
	public void CalcMultiDamage(PlayerActionManagerBase playerAction, EnemyMobActionManagerBase enemyAction, SkillDamageData damageData) { }

	// RVA: 0x248AC78 Offset: 0x2486C78 VA: 0x248AC78 Slot: 65
	public virtual void PopSkillNameLabel() { }

	// RVA: 0x248AD04 Offset: 0x2486D04 VA: 0x248AD04 Slot: 66
	public virtual string GetLocalizeKey(byte element) { }
}

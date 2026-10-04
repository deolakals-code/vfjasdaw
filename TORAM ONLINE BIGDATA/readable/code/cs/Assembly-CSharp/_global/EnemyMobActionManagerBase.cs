// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class EnemyMobActionManagerBase : CharacterActionManagerBase, MobActionManagerBase // TypeDefIndex: 881
{
	// Fields
	protected MobAIBase mobAI; // 0x58
	private MobBattleSystemManager battleSystemManager; // 0x60
	protected MobBattlePlayer battlePlayer; // 0x68
	[SerializeField]
	protected MobStatusMaster mobStatusMaster; // 0x70
	[SerializeField]
	protected MobStatus mobStatus; // 0x78
	protected AbnormalStateManager abnormalManager; // 0x80
	protected MobBuffManager buffManager; // 0x88
	protected BufferEffectManager bufferEffectManager; // 0x90
	protected MobAnimation mobAnimation; // 0x98
	protected PlayerDataManager playerDataManager; // 0xA0
	private byte ApparentDeathId; // 0xA8
	private bool isExsitCheck; // 0xA9
	private MobColorChanger ColorChanger; // 0xB0
	[SerializeField]
	protected MobBoneManager boneManager; // 0xB8
	private MobStateFlag mobStateFlag; // 0xC0
	protected HyperModeEffectManager hypermodeEffectManager; // 0xC8
	private UIMobNameLabel mobNameLabel; // 0xD0
	private bool localIsFeigningDeathState; // 0xD8
	private float systemInvincibleTime; // 0xDC
	private float invincibleTime; // 0xE0
	private MobHyperModeManager hyperModeManager; // 0xE8
	private MultiTargetPosition multiTargetPosition; // 0xF0
	private EnemyMobActionManagerBase parentActionManager; // 0xF8
	private GameObject mainPlayer; // 0x100
	private CharacterActionManagerBase mainPlayerActionManager; // 0x108
	private byte managedArchetypeType; // 0x110
	private int managedArchetypeId; // 0x114
	private MobFootAttackManager footAttackManager; // 0x118
	private MobSizeChanger sizeChanger; // 0x120
	protected MobEventCircleManager eventCircleManager; // 0x128
	private MobScriptActionManager scriptActionManager; // 0x130
	protected MobScreenEffectManager screenEffectManager; // 0x138
	[CompilerGenerated]
	private GameObject <Target>k__BackingField; // 0x140
	[CompilerGenerated]
	private bool <IsPlayerManaged>k__BackingField; // 0x148
	[CompilerGenerated]
	private bool <IsPlayerCreated>k__BackingField; // 0x149
	[CompilerGenerated]
	private bool <IsTargetAutoMember>k__BackingField; // 0x14A
	[CompilerGenerated]
	private bool <IsRemain>k__BackingField; // 0x14B
	[CompilerGenerated]
	private float <PlayerDistance>k__BackingField; // 0x14C
	[CompilerGenerated]
	private bool <IsAttackable>k__BackingField; // 0x150
	[CompilerGenerated]
	private bool <IsDummy>k__BackingField; // 0x151

	// Properties
	public MobAIBase MobAI { get; }
	public MobStatusMaster MobStatusMaster { get; }
	public MobStatus MobStatus { get; }
	public abstract IMobStatusCalculator MobBattleStatus { get; }
	public MobBattleSystemManager MobBattleSystemManager { get; }
	public BufferEffectManager BufferEffectManager { get; }
	public AbnormalStateManager AbnormalStateManager { get; }
	public MobBuffManager BuffManager { get; }
	public GameObject MainPlayer { get; }
	public CharacterActionManagerBase MainPlayerAction { get; }
	public GameObject Target { get; set; }
	public bool IsPlayerManaged { get; set; }
	public bool IsPlayerCreated { get; set; }
	public bool IsTargetAutoMember { get; set; }
	public bool IsRemain { get; set; }
	public bool IsBattleActive { get; }
	public override float Size { get; }
	public float PlayerDistance { get; set; }
	public int PlayerMeterDistance { get; }
	public override bool IsLocalDead { get; }
	public override bool IsDead { get; }
	public bool IsActionLock { get; }
	public bool IsAttackable { get; set; }
	public abstract bool IsBoss { get; }
	public virtual bool IsInvalidKnockBack { get; }
	public virtual bool IsInvalidSuction { get; }
	public bool FixedDirection { get; }
	public bool UnableTarget { get; }
	public MobBoneManager BoneManager { get; }
	public virtual bool IsTargetable { get; }
	public override float UnTargetDist { get; }
	public virtual bool HideNameLabel { get; }
	public bool IsFeigningDeathState { get; }
	public bool IsLocalFeigningDeathState { get; }
	public bool SystemInvincible { get; }
	public bool IsDummy { get; set; }
	public MobActionManagerBase ParentActionManager { get; }
	public CharacterActionManagerBase CharacterActionManagerBase { get; }
	public virtual ElementType Element { get; }
	public virtual string MobName { get; }
	public MobFootAttackManager FootAttackManager { get; }
	public virtual bool IsNearRoomStart { get; }

	// Methods

	// RVA: 0x1EE8134 Offset: 0x1EE4134 VA: 0x1EE8134
	public MobAIBase get_MobAI() { }

	// RVA: 0x1EE481C Offset: 0x1EE081C VA: 0x1EE481C
	public MobStatusMaster get_MobStatusMaster() { }

	// RVA: 0x1EE3204 Offset: 0x1EDF204 VA: 0x1EE3204 Slot: 28
	public MobStatus get_MobStatus() { }

	// RVA: -1 Offset: -1 Slot: 62
	public abstract IMobStatusCalculator get_MobBattleStatus();

	// RVA: 0x1EE813C Offset: 0x1EE413C VA: 0x1EE813C
	public MobBattleSystemManager get_MobBattleSystemManager() { }

	// RVA: 0x1EE8144 Offset: 0x1EE4144 VA: 0x1EE8144 Slot: 63
	public BufferEffectManager get_BufferEffectManager() { }

	// RVA: 0x1EE814C Offset: 0x1EE414C VA: 0x1EE814C Slot: 30
	public AbnormalStateManager get_AbnormalStateManager() { }

	// RVA: 0x1EE8170 Offset: 0x1EE4170 VA: 0x1EE8170 Slot: 31
	public MobBuffManager get_BuffManager() { }

	// RVA: 0x1EE34F4 Offset: 0x1EDF4F4 VA: 0x1EE34F4 Slot: 32
	public GameObject get_MainPlayer() { }

	// RVA: 0x1EE8194 Offset: 0x1EE4194 VA: 0x1EE8194
	public CharacterActionManagerBase get_MainPlayerAction() { }

	[CompilerGenerated]
	// RVA: 0x1EE827C Offset: 0x1EE427C VA: 0x1EE827C Slot: 33
	public GameObject get_Target() { }

	[CompilerGenerated]
	// RVA: 0x1EE8284 Offset: 0x1EE4284 VA: 0x1EE8284
	private void set_Target(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x1EE8294 Offset: 0x1EE4294 VA: 0x1EE8294 Slot: 34
	public bool get_IsPlayerManaged() { }

	[CompilerGenerated]
	// RVA: 0x1EE829C Offset: 0x1EE429C VA: 0x1EE829C
	private void set_IsPlayerManaged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1EE82A8 Offset: 0x1EE42A8 VA: 0x1EE82A8
	public bool get_IsPlayerCreated() { }

	[CompilerGenerated]
	// RVA: 0x1EE82B0 Offset: 0x1EE42B0 VA: 0x1EE82B0
	private void set_IsPlayerCreated(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1EE82BC Offset: 0x1EE42BC VA: 0x1EE82BC
	public bool get_IsTargetAutoMember() { }

	[CompilerGenerated]
	// RVA: 0x1EE82C4 Offset: 0x1EE42C4 VA: 0x1EE82C4
	private void set_IsTargetAutoMember(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1EE82D0 Offset: 0x1EE42D0 VA: 0x1EE82D0
	public bool get_IsRemain() { }

	[CompilerGenerated]
	// RVA: 0x1EE82D8 Offset: 0x1EE42D8 VA: 0x1EE82D8
	private void set_IsRemain(bool value) { }

	// RVA: 0x1EE82E4 Offset: 0x1EE42E4 VA: 0x1EE82E4 Slot: 24
	public bool get_IsBattleActive() { }

	// RVA: 0x1EE836C Offset: 0x1EE436C VA: 0x1EE836C Slot: 4
	public override float get_Size() { }

	[CompilerGenerated]
	// RVA: 0x1EE8388 Offset: 0x1EE4388 VA: 0x1EE8388 Slot: 35
	public float get_PlayerDistance() { }

	[CompilerGenerated]
	// RVA: 0x1EE8390 Offset: 0x1EE4390 VA: 0x1EE8390
	private void set_PlayerDistance(float value) { }

	// RVA: 0x1EE8398 Offset: 0x1EE4398 VA: 0x1EE8398 Slot: 36
	public int get_PlayerMeterDistance() { }

	// RVA: 0x1EE8410 Offset: 0x1EE4410 VA: 0x1EE8410 Slot: 5
	public override bool get_IsLocalDead() { }

	// RVA: 0x1EE8438 Offset: 0x1EE4438 VA: 0x1EE8438 Slot: 7
	public override bool get_IsDead() { }

	// RVA: 0x1EE31A4 Offset: 0x1EDF1A4 VA: 0x1EE31A4
	public bool get_IsActionLock() { }

	[CompilerGenerated]
	// RVA: 0x1EE8460 Offset: 0x1EE4460 VA: 0x1EE8460
	public bool get_IsAttackable() { }

	[CompilerGenerated]
	// RVA: 0x1EE8468 Offset: 0x1EE4468 VA: 0x1EE8468
	private void set_IsAttackable(bool value) { }

	// RVA: -1 Offset: -1 Slot: 64
	public abstract bool get_IsBoss();

	// RVA: 0x1EE8474 Offset: 0x1EE4474 VA: 0x1EE8474 Slot: 65
	public virtual bool get_IsInvalidKnockBack() { }

	// RVA: 0x1EE8488 Offset: 0x1EE4488 VA: 0x1EE8488 Slot: 66
	public virtual bool get_IsInvalidSuction() { }

	// RVA: 0x1EE31C4 Offset: 0x1EDF1C4 VA: 0x1EE31C4
	public bool get_FixedDirection() { }

	// RVA: 0x1EE849C Offset: 0x1EE449C VA: 0x1EE849C
	public bool get_UnableTarget() { }

	// RVA: 0x1EE84B0 Offset: 0x1EE44B0 VA: 0x1EE84B0
	public MobBoneManager get_BoneManager() { }

	// RVA: 0x1EE84B8 Offset: 0x1EE44B8 VA: 0x1EE84B8 Slot: 67
	public virtual bool get_IsTargetable() { }

	// RVA: 0x1EE85C4 Offset: 0x1EE45C4 VA: 0x1EE85C4 Slot: 6
	public override float get_UnTargetDist() { }

	// RVA: 0x1EE8634 Offset: 0x1EE4634 VA: 0x1EE8634 Slot: 68
	public virtual bool get_HideNameLabel() { }

	// RVA: 0x1EE8500 Offset: 0x1EE4500 VA: 0x1EE8500
	public bool get_IsFeigningDeathState() { }

	// RVA: 0x1EE8658 Offset: 0x1EE4658 VA: 0x1EE8658
	public bool get_IsLocalFeigningDeathState() { }

	// RVA: 0x1EE8660 Offset: 0x1EE4660 VA: 0x1EE8660 Slot: 40
	public bool get_SystemInvincible() { }

	[CompilerGenerated]
	// RVA: 0x1EE8684 Offset: 0x1EE4684 VA: 0x1EE8684 Slot: 25
	public bool get_IsDummy() { }

	[CompilerGenerated]
	// RVA: 0x1EE868C Offset: 0x1EE468C VA: 0x1EE868C
	private void set_IsDummy(bool value) { }

	// RVA: 0x1EE8698 Offset: 0x1EE4698 VA: 0x1EE8698
	public MobActionManagerBase get_ParentActionManager() { }

	// RVA: 0x1EE86A0 Offset: 0x1EE46A0 VA: 0x1EE86A0 Slot: 26
	public CharacterActionManagerBase get_CharacterActionManagerBase() { }

	// RVA: 0x1EE86A4 Offset: 0x1EE46A4 VA: 0x1EE86A4 Slot: 69
	public virtual ElementType get_Element() { }

	// RVA: 0x1EE86D0 Offset: 0x1EE46D0 VA: 0x1EE86D0 Slot: 70
	public virtual string get_MobName() { }

	// RVA: 0x1EE8810 Offset: 0x1EE4810 VA: 0x1EE8810
	public MobFootAttackManager get_FootAttackManager() { }

	// RVA: 0x1EE8818 Offset: 0x1EE4818 VA: 0x1EE8818 Slot: 71
	public virtual bool get_IsNearRoomStart() { }

	// RVA: 0x1EE8820 Offset: 0x1EE4820 VA: 0x1EE8820 Slot: 72
	protected virtual void Awake() { }

	// RVA: 0x1EE8CF4 Offset: 0x1EE4CF4 VA: 0x1EE8CF4 Slot: 73
	protected virtual void Update() { }

	// RVA: 0x1EE8FB4 Offset: 0x1EE4FB4 VA: 0x1EE8FB4
	protected void UpdateFootAttack() { }

	// RVA: 0x1EE8FC8 Offset: 0x1EE4FC8 VA: 0x1EE8FC8
	protected void UpdateSizeChange() { }

	// RVA: 0x1EE8FDC Offset: 0x1EE4FDC VA: 0x1EE8FDC
	protected void UpdateInvincibleTime() { }

	// RVA: 0x1EE9044 Offset: 0x1EE5044 VA: 0x1EE9044 Slot: 18
	protected override void OnDestroy() { }

	// RVA: 0x1EE90F8 Offset: 0x1EE50F8 VA: 0x1EE90F8
	public void UpdateDist(Vector3 pos) { }

	// RVA: 0x1EE9210 Offset: 0x1EE5210 VA: 0x1EE9210 Slot: 45
	public float GetHpPercent() { }

	// RVA: 0x1EE92F8 Offset: 0x1EE52F8 VA: 0x1EE92F8 Slot: 74
	public virtual bool CheckMultiFlag(MobMultiFlag flag) { }

	// RVA: -1 Offset: -1 Slot: 44
	public bool TryGetProperties<T>(MonsterPropertyType id, out T properties) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EAA58 Offset: 0x27E6A58 VA: 0x27EAA58
	|-EnemyMobActionManagerBase.TryGetProperties<object>
	*/

	// RVA: 0x1EE930C Offset: 0x1EE530C VA: 0x1EE930C Slot: 60
	public bool CheckMobRangeAttck(Transform actor) { }

	// RVA: 0x1EE951C Offset: 0x1EE551C VA: 0x1EE951C Slot: 61
	public bool CheckDamageMissing() { }

	// RVA: 0x1EE9658 Offset: 0x1EE5658 VA: 0x1EE9658
	private void setMasterStatus(MobStatusMaster status) { }

	// RVA: 0x1EE9A9C Offset: 0x1EE5A9C VA: 0x1EE9A9C
	private List<MobIconLabelData> GetPropertyTypes(MonsterPropertyType[] iconPropertys) { }

	[IteratorStateMachine(typeof(EnemyMobActionManagerBase.<AddPropertyLabelIfNeeded>d__147))]
	// RVA: 0x1EE9A30 Offset: 0x1EE5A30 VA: 0x1EE9A30
	private IEnumerator AddPropertyLabelIfNeeded() { }

	// RVA: 0x1EE9C64 Offset: 0x1EE5C64 VA: 0x1EE9C64 Slot: 75
	public virtual void AddNameLabel() { }

	// RVA: -1 Offset: -1 Slot: 76
	protected abstract void OnSetStatus();

	// RVA: 0x1EE5704 Offset: 0x1EE1704 VA: 0x1EE5704 Slot: 46
	public bool GetHate() { }

	// RVA: 0x1EE9CD0 Offset: 0x1EE5CD0 VA: 0x1EE9CD0
	private void UpdateManagedArchetypeCache(GameObject managedObject) { }

	// RVA: 0x1EE9E08 Offset: 0x1EE5E08 VA: 0x1EE9E08
	public bool GetHateManager(out byte type, out int id) { }

	// RVA: 0x1EEA030 Offset: 0x1EE6030 VA: 0x1EEA030
	public bool HasOnlyPlayerHate() { }

	// RVA: 0x1EEA224 Offset: 0x1EE6224 VA: 0x1EEA224
	public int GetPlayerHate() { }

	// RVA: 0x1EEA274 Offset: 0x1EE6274 VA: 0x1EEA274
	public int GetTargetHate(byte archetypeType, int archeTypeId) { }

	// RVA: 0x1EEA34C Offset: 0x1EE634C VA: 0x1EEA34C Slot: 47
	public bool HasPlayerHate(bool includingZeroHate = False) { }

	// RVA: 0x1EEA560 Offset: 0x1EE6560 VA: 0x1EEA560 Slot: 48
	public bool HasOtherPlayerHate(int archetypeId, byte archetypeType) { }

	// RVA: 0x1EEA720 Offset: 0x1EE6720 VA: 0x1EEA720
	public EnemyMobActionManagerBase.HateState GetHateState() { }

	// RVA: 0x1EEA8EC Offset: 0x1EE68EC VA: 0x1EEA8EC Slot: 49
	public bool CorrectionTarget() { }

	// RVA: 0x1EEAA8C Offset: 0x1EE6A8C VA: 0x1EEAA8C
	public void InitializeMobAI() { }

	// RVA: -1 Offset: -1
	public T SetMobAI<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27EA7D8 Offset: 0x27E67D8 VA: 0x27EA7D8
	|-EnemyMobActionManagerBase.SetMobAI<object>
	*/

	// RVA: 0x1EEAC64 Offset: 0x1EE6C64 VA: 0x1EEAC64
	public void RemoveMobAI() { }

	// RVA: 0x1EEAD04 Offset: 0x1EE6D04 VA: 0x1EEAD04
	public void SetHyperModeStatus(MobStatusMaster status, MobModeData mobModeData, MobPartData[] mobParts) { }

	// RVA: 0x1EEB8EC Offset: 0x1EE78EC VA: 0x1EEB8EC
	public void SetStatusMaster(MobStatusMaster status) { }

	// RVA: 0x1EEB8F8 Offset: 0x1EE78F8 VA: 0x1EEB8F8 Slot: 77
	public virtual void InitManagedMob(GameObject target, bool isActiveInvoke) { }

	// RVA: 0x1EEBE78 Offset: 0x1EE7E78 VA: 0x1EEBE78
	public void InitUnmanagedMob(GameObject target, MobStatusMaster status, byte localId, int uniqueId) { }

	// RVA: 0x1EEC128 Offset: 0x1EE8128 VA: 0x1EEC128
	public void SetAttackableMob(bool flag) { }

	// RVA: 0x1EEC134 Offset: 0x1EE8134 VA: 0x1EEC134
	public int RemoveStatusMaster() { }

	// RVA: 0x1EEC18C Offset: 0x1EE818C VA: 0x1EEC18C
	public void InitializeFromPlayer() { }

	// RVA: 0x1EEC198 Offset: 0x1EE8198 VA: 0x1EEC198
	public void SetLocalID(int id) { }

	// RVA: 0x1EEC1C4 Offset: 0x1EE81C4 VA: 0x1EEC1C4 Slot: 78
	public virtual bool IsValidMatch(IMobIdData mobId) { }

	// RVA: 0x1EE3960 Offset: 0x1EDF960 VA: 0x1EE3960
	public void SetTarget(GameObject target) { }

	// RVA: 0x1EEC220 Offset: 0x1EE8220 VA: 0x1EEC220
	public void SetRemain() { }

	// RVA: 0x1EEC22C Offset: 0x1EE822C VA: 0x1EEC22C
	public void SetDummyParent(MobActionManagerBase parent) { }

	// RVA: 0x1EEC3C8 Offset: 0x1EE83C8 VA: 0x1EEC3C8 Slot: 79
	public virtual void UpdateHp(int hp) { }

	// RVA: 0x1EEC45C Offset: 0x1EE845C VA: 0x1EEC45C
	public void DamageUpdateHp(byte id, int hp) { }

	// RVA: 0x1EEC4E4 Offset: 0x1EE84E4 VA: 0x1EEC4E4
	public void UpdateDpsLimit(int allowDamage) { }

	// RVA: 0x1EEC55C Offset: 0x1EE855C VA: 0x1EEC55C
	public void UpdateState(int state) { }

	// RVA: 0x1EEC830 Offset: 0x1EE8830 VA: 0x1EEC830
	public void ResetServerHp() { }

	// RVA: 0x1EEC85C Offset: 0x1EE885C VA: 0x1EEC85C
	public void ResetDamageServerHp(byte id) { }

	// RVA: 0x1EEC8A8 Offset: 0x1EE88A8 VA: 0x1EEC8A8
	public void UpdateHate(MobHateData[] hate) { }

	// RVA: 0x1EEC8D4 Offset: 0x1EE88D4 VA: 0x1EEC8D4
	public void EnsureConsistencyInHate(MobHateData hateData) { }

	// RVA: 0x1EECE8C Offset: 0x1EE8E8C VA: 0x1EECE8C
	public void SetServerAbnormal(AbnormalData[] abnormalStateList) { }

	// RVA: 0x1EED300 Offset: 0x1EE9300 VA: 0x1EED300
	public void SetServerMobBuff(MobBuffData[] buffList, bool other = False) { }

	// RVA: 0x1EED4D8 Offset: 0x1EE94D8 VA: 0x1EED4D8
	public void ResetServerExpDef() { }

	// RVA: 0x1EED504 Offset: 0x1EE9504 VA: 0x1EED504
	public void UpdateExpDef(int normal, int skill, int magic) { }

	// RVA: 0x1EED530 Offset: 0x1EE9530 VA: 0x1EED530
	public void SetActionMove(MobResponseData eventData) { }

	// RVA: 0x1EED584 Offset: 0x1EE9584 VA: 0x1EED584
	public void SetActionStart(MobActionStartEventData eventData) { }

	// RVA: 0x1EEDE48 Offset: 0x1EE9E48 VA: 0x1EEDE48 Slot: 80
	public virtual void Invalidation() { }

	// RVA: 0x1EEDE50 Offset: 0x1EE9E50 VA: 0x1EEDE50 Slot: 81
	public virtual void Validation() { }

	// RVA: 0x1EEDE5C Offset: 0x1EE9E5C VA: 0x1EEDE5C
	public void ScriptAction(byte propertyId, GameObject target) { }

	// RVA: 0x1EEC774 Offset: 0x1EE8774 VA: 0x1EEC774
	public void BattleStop() { }

	// RVA: 0x1EE5510 Offset: 0x1EE1510 VA: 0x1EE5510
	public void BattleEnd() { }

	// RVA: 0x1EEDE78 Offset: 0x1EE9E78 VA: 0x1EEDE78 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1EEF4C4 Offset: 0x1EEB4C4 VA: 0x1EEF4C4
	protected bool CheckCurrentPatternDamageInvalid(SkillDamageData damageData) { }

	// RVA: 0x1EEFA6C Offset: 0x1EEBA6C VA: 0x1EEFA6C
	protected bool DamagedAddAbnormal(GameObject actor, SkillActionBase action, SkillDamageData damageData, bool playEffect = True) { }

	// RVA: 0x1EF13C8 Offset: 0x1EED3C8 VA: 0x1EF13C8 Slot: 82
	protected virtual void DrawAbnormalResistLabel(AbnormalType type, int skillId) { }

	// RVA: 0x1EF1540 Offset: 0x1EED540 VA: 0x1EF1540 Slot: 83
	protected virtual void DrawAbnormalResistLabel(AbnormalType type, ItemDBData.EquipType equipType, int mainWeaponType, int subWeaponType) { }

	// RVA: 0x1EEF618 Offset: 0x1EEB618 VA: 0x1EEF618
	protected int GemDamageLimit(int damage, PlayerActionManagerBase playerActionManager) { }

	// RVA: 0x1EF16D0 Offset: 0x1EED6D0 VA: 0x1EF16D0 Slot: 84
	public virtual void OnDamaged() { }

	// RVA: 0x1EEF9A4 Offset: 0x1EEB9A4 VA: 0x1EEF9A4
	protected bool CheckInvalidAbnormal(AbnormalType abnormalType) { }

	// RVA: 0x1EEC498 Offset: 0x1EE8498 VA: 0x1EEC498
	public void CheckApparentDeathId(byte id) { }

	// RVA: 0x1EF10DC Offset: 0x1EED0DC VA: 0x1EF10DC
	public void ApparentDeath(byte id) { }

	// RVA: 0x1EF171C Offset: 0x1EED71C VA: 0x1EF171C
	public void ReviveFromApparentDeath() { }

	// RVA: 0x1EF177C Offset: 0x1EED77C VA: 0x1EF177C
	public void CheckMobExsit() { }

	[IteratorStateMachine(typeof(EnemyMobActionManagerBase.<mobExistCheck>d__206))]
	// RVA: 0x1EF17E4 Offset: 0x1EED7E4 VA: 0x1EF17E4
	private IEnumerator mobExistCheck() { }

	// RVA: 0x1EF1878 Offset: 0x1EED878 VA: 0x1EF1878 Slot: 17
	public override void OnDead() { }

	// RVA: 0x1EF1A1C Offset: 0x1EEDA1C VA: 0x1EF1A1C
	public MobManager.PlayerDeadActionType CheckRemoveType() { }

	// RVA: 0x1EF1A98 Offset: 0x1EEDA98 VA: 0x1EF1A98
	public void LeaveTarget() { }

	[IteratorStateMachine(typeof(EnemyMobActionManagerBase.<leaveTarget>d__210))]
	// RVA: 0x1EF1B4C Offset: 0x1EEDB4C VA: 0x1EF1B4C Slot: 85
	protected virtual IEnumerator leaveTarget() { }

	// RVA: 0x1EF1BE0 Offset: 0x1EEDBE0 VA: 0x1EF1BE0 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1EE3104 Offset: 0x1EDF104 VA: 0x1EE3104
	public float checkAddAbnormalResistTime(float resist, float addResist) { }

	// RVA: 0x1EF12C0 Offset: 0x1EED2C0 VA: 0x1EF12C0
	public void PlayAbnormalEffect(AbnormalType type, float effectTime) { }

	// RVA: 0x1EF1BE8 Offset: 0x1EEDBE8 VA: 0x1EF1BE8
	public void PlayDebuffEffect(MobBuffBase mobBuff) { }

	// RVA: 0x1EEBE64 Offset: 0x1EE7E64 VA: 0x1EEBE64
	public bool CheckFeigningDeathState() { }

	// RVA: 0x1EF1C2C Offset: 0x1EEDC2C VA: 0x1EF1C2C
	public void SetLocalIsFeigningDeathState(bool state) { }

	// RVA: 0x1EF1C38 Offset: 0x1EEDC38 VA: 0x1EF1C38
	public void SetSystemInvincible(float time) { }

	// RVA: 0x1EF1148 Offset: 0x1EED148 VA: 0x1EF1148
	public bool PartsAttackPermission(AbnormalType type, bool force) { }

	// RVA: 0x1EF1C40 Offset: 0x1EEDC40 VA: 0x1EF1C40
	public void ReleaseAbandonedChat() { }

	// RVA: 0x1EF1CF4 Offset: 0x1EEDCF4 VA: 0x1EF1CF4
	public void ClearDelay() { }

	// RVA: 0x1EF1DB8 Offset: 0x1EEDDB8 VA: 0x1EF1DB8 Slot: 86
	public virtual MobSendData CreateMobSendData() { }

	// RVA: 0x1EF1ECC Offset: 0x1EEDECC VA: 0x1EF1ECC Slot: 87
	public virtual MobSendDataLight CreateMobSendDataLight() { }

	// RVA: 0x1EF1FE0 Offset: 0x1EEDFE0 VA: 0x1EF1FE0 Slot: 88
	public virtual MobIdData CreateMobIdData() { }

	// RVA: 0x1EE4DFC Offset: 0x1EE0DFC VA: 0x1EE4DFC Slot: 89
	public virtual bool MobToEnemy() { }

	// RVA: 0x1EE850C Offset: 0x1EE450C VA: 0x1EE850C
	public bool IsCurrentActionTarget() { }

	// RVA: 0x1EF12D4 Offset: 0x1EED2D4 VA: 0x1EF12D4
	private void AddAbnormalMessage(AbnormalType type) { }

	// RVA: 0x1EF2070 Offset: 0x1EEE070 VA: 0x1EF2070 Slot: 90
	public virtual Vector3 GetNearTargetPosition(Vector3 pos) { }

	// RVA: 0x1EF21C8 Offset: 0x1EEE1C8 VA: 0x1EF21C8 Slot: 91
	public virtual bool CheckTargetMob(Vector3 pos, out GameObject target) { }

	// RVA: 0x1EF2200 Offset: 0x1EEE200 VA: 0x1EF2200 Slot: 92
	public virtual bool GetNearTargetDist(Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1EF2478 Offset: 0x1EEE478 VA: 0x1EF2478 Slot: 93
	public virtual bool GetNearTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1EF2778 Offset: 0x1EEE778 VA: 0x1EF2778 Slot: 94
	public virtual bool GetFarTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x1EF0800 Offset: 0x1EEC800 VA: 0x1EF0800
	protected void PursuitImperialRay(GameObject actor, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x1EF0D54 Offset: 0x1EECD54 VA: 0x1EF0D54
	protected void PursuitJumpbackShot(GameObject actor, SkillActionBase action) { }

	// RVA: 0x1EF2A78 Offset: 0x1EEEA78 VA: 0x1EF2A78
	public bool CheckAddAbnormalSyncPosition(AbnormalType type) { }

	// RVA: 0x1EE608C Offset: 0x1EE208C VA: 0x1EE608C
	protected void .ctor() { }

	// RVA: 0x1EF2AA0 Offset: 0x1EEEAA0 VA: 0x1EF2AA0 Slot: 41
	private GameObject MobActionManagerBase.get_gameObject() { }

	// RVA: 0x1EF2AA8 Offset: 0x1EEEAA8 VA: 0x1EF2AA8 Slot: 42
	private Transform MobActionManagerBase.get_transform() { }

	[CompilerGenerated]
	// RVA: 0x1EF2AB0 Offset: 0x1EEEAB0 VA: 0x1EF2AB0
	private bool <GetHateManager>b__152_0(MobStatus.HateData x) { }
}

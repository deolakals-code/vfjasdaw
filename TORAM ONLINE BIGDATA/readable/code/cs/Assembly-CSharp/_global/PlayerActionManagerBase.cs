// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class PlayerActionManagerBase : CharacterActionManagerBase // TypeDefIndex: 1436
{
	// Fields
	[CompilerGenerated]
	private TakeController <TakeController>k__BackingField; // 0x58
	private float attentionTime; // 0x60
	protected CharacterBoneManager boneManager; // 0x68
	protected byte apparentDeathId; // 0x70
	protected GhostPlayer ghostPlayer; // 0x78
	protected ScriptFlagManager scriptFlagManager; // 0x80

	// Properties
	public bool IsBattleActive { get; }
	public bool IsInterruptable { get; }
	public virtual bool IsGhost { get; }
	public TakeController TakeController { get; set; }
	public virtual bool IsHideUser { get; }
	public abstract PlayerStatusBase PlayerStatus { get; }
	public abstract AbnormalStateManager AbnormalStatusManager { get; }
	public abstract BufferEffectManager BufferEffectManager { get; }
	public CharacterBoneManager BoneManager { get; }
	public ScriptFlagManager ScriptManager { get; }
	public bool DetectionDanger { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T Add<T>(PlayerObjectBase baseModel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DEFA8 Offset: 0x26DAFA8 VA: 0x26DEFA8
	|-PlayerActionManagerBase.Add<object>
	*/

	// RVA: 0x203FA60 Offset: 0x203BA60 VA: 0x203FA60
	public bool get_IsBattleActive() { }

	// RVA: 0x203FA7C Offset: 0x203BA7C VA: 0x203FA7C
	public bool get_IsInterruptable() { }

	// RVA: 0x203FA98 Offset: 0x203BA98 VA: 0x203FA98 Slot: 20
	public virtual bool get_IsGhost() { }

	[CompilerGenerated]
	// RVA: 0x203FB10 Offset: 0x203BB10 VA: 0x203FB10
	public TakeController get_TakeController() { }

	[CompilerGenerated]
	// RVA: 0x203FB18 Offset: 0x203BB18 VA: 0x203FB18
	protected void set_TakeController(TakeController value) { }

	// RVA: 0x203FB20 Offset: 0x203BB20 VA: 0x203FB20 Slot: 21
	public virtual bool get_IsHideUser() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract PlayerStatusBase get_PlayerStatus();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract AbnormalStateManager get_AbnormalStatusManager();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract BufferEffectManager get_BufferEffectManager();

	// RVA: 0x203FB28 Offset: 0x203BB28 VA: 0x203FB28
	public CharacterBoneManager get_BoneManager() { }

	// RVA: 0x203FB30 Offset: 0x203BB30 VA: 0x203FB30
	public ScriptFlagManager get_ScriptManager() { }

	// RVA: 0x203FB38 Offset: 0x203BB38 VA: 0x203FB38
	public bool get_DetectionDanger() { }

	// RVA: 0x203FB48 Offset: 0x203BB48 VA: 0x203FB48
	public void AddAttention(float time) { }

	// RVA: 0x203FB50 Offset: 0x203BB50 VA: 0x203FB50 Slot: 25
	protected virtual void Update() { }

	// RVA: 0x203FBB8 Offset: 0x203BBB8 VA: 0x203FBB8 Slot: 26
	public virtual void EventDamage(int damage, byte state, byte flag, bool popFlag) { }

	// RVA: 0x203FBBC Offset: 0x203BBBC VA: 0x203FBBC Slot: 27
	public virtual void EventMonsterDamage(byte attackType, int damage, int stable, ElementType element, int criticalPercent, int criticalDamage, int free, AbnormalType abnormalType, int abnormalPercent, short abnormalTime, int guardType, int avoidType, short hitSE, short hitEffect, byte hitEffectMotion) { }

	// RVA: 0x203FBC0 Offset: 0x203BBC0 VA: 0x203FBC0 Slot: 28
	public virtual void AddEventAbnormal(byte abnormalState, short state, float stateTime, bool popLabelFlag, bool forceAdd) { }

	// RVA: 0x203FBC4 Offset: 0x203BBC4 VA: 0x203FBC4 Slot: 29
	public virtual void DungeonDamage(byte senderType, int senderId, byte trapId, DungeonEventType eventType, GameObject trapObject) { }

	// RVA: 0x203FBC8 Offset: 0x203BBC8 VA: 0x203FBC8 Slot: 30
	public virtual void OnRespawn() { }

	// RVA: 0x203FBCC Offset: 0x203BBCC VA: 0x203FBCC Slot: 31
	public virtual void FirstEnemyContact(GameObject actor, bool isActiveInvoke) { }

	// RVA: 0x203FBD0 Offset: 0x203BBD0 VA: 0x203FBD0 Slot: 32
	public virtual void VanishingObject(GameObject actor) { }

	// RVA: 0x203FBD4 Offset: 0x203BBD4 VA: 0x203FBD4 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x203FBD8 Offset: 0x203BBD8 VA: 0x203FBD8 Slot: 33
	public virtual void SuccessAddAbnormal(AbnormalType type, float effectTime, ActionAppendData append) { }

	// RVA: 0x203FBDC Offset: 0x203BBDC VA: 0x203FBDC Slot: 34
	public virtual bool CreateAbnormalEffect(AbnormalType type, float effectTime, bool abnormalBreakthroughLimit) { }

	// RVA: 0x203FBE4 Offset: 0x203BBE4 VA: 0x203FBE4 Slot: 35
	public virtual SkillActionBase.DamageData DamageTransfer(SkillActionBase.DamageData source) { }

	// RVA: 0x203FBEC Offset: 0x203BBEC VA: 0x203FBEC Slot: 36
	public virtual void ActionCancelFlinch() { }

	// RVA: 0x203FBF0 Offset: 0x203BBF0 VA: 0x203FBF0 Slot: 37
	public virtual void ActionCancel() { }

	// RVA: 0x203FBF4 Offset: 0x203BBF4 VA: 0x203FBF4 Slot: 38
	public virtual void BattlePause() { }

	// RVA: 0x203FBF8 Offset: 0x203BBF8 VA: 0x203FBF8 Slot: 39
	public virtual void OnReleaseEnemy() { }

	// RVA: 0x203FBFC Offset: 0x203BBFC VA: 0x203FBFC Slot: 40
	public virtual void OnUnsheathe() { }

	// RVA: 0x203FC00 Offset: 0x203BC00 VA: 0x203FC00 Slot: 41
	public virtual void ApparentDeath(GameObject actor, byte id, int damage) { }

	// RVA: 0x203FC04 Offset: 0x203BC04 VA: 0x203FC04 Slot: 42
	public virtual void CheckApparentDeathId(byte id) { }

	// RVA: 0x203FC08 Offset: 0x203BC08 VA: 0x203FC08 Slot: 43
	public virtual void ReviveFromApparentDeath() { }

	// RVA: 0x203FC0C Offset: 0x203BC0C VA: 0x203FC0C Slot: 44
	public virtual bool CheckAvailableSkill(SkillId skillId) { }

	// RVA: 0x203FC14 Offset: 0x203BC14 VA: 0x203FC14 Slot: 45
	public virtual void InMobAttackArea(EnemyMobActionManagerBase enemyAction, MobAttackBase mobAttack) { }

	// RVA: 0x203FCF4 Offset: 0x203BCF4 VA: 0x203FCF4 Slot: 46
	protected virtual void Initialize(PlayerObjectBase playerObject) { }

	// RVA: 0x203FDC4 Offset: 0x203BDC4 VA: 0x203FDC4 Slot: 47
	protected virtual void moveAnimationCheck() { }

	// RVA: 0x203FEC0 Offset: 0x203BEC0 VA: 0x203FEC0 Slot: 48
	protected virtual void DeadGhost() { }

	// RVA: 0x203FFB4 Offset: 0x203BFB4 VA: 0x203FFB4 Slot: 49
	protected virtual void GhostRespawn() { }

	// RVA: 0x203FB84 Offset: 0x203BB84 VA: 0x203FB84
	protected void AttentionUpdate() { }

	// RVA: 0x20400A8 Offset: 0x203C0A8 VA: 0x20400A8
	protected void .ctor() { }
}

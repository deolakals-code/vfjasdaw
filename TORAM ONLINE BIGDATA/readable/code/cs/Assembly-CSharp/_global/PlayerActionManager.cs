// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(PlayerAnimation))]
public class PlayerActionManager : PlayerActionManagerBase, IPlayerControl // TypeDefIndex: 1435
{
	// Fields
	private SuppressionBonusGameManager supprettionBonus; // 0x88
	private PlayerDataManager playerDataManager; // 0x90
	private PlayerAnimation playerAnimation; // 0x98
	private PlayerBattleManager _playerBattleManager; // 0xA0
	private BufferEffectManager _bufferEffectManager; // 0xA8
	private InputManager input; // 0xB0
	private TargetManager targetManager; // 0xB8
	private EmotionPlayer emotionPlayer; // 0xC0
	private bool isInputLock; // 0xC8
	private const float TargetingRange = 30;
	private const float TargetingHeightRange = 8;
	private bool externalTarget; // 0xC9
	private bool isAutoEventSelect; // 0xCA
	private bool isMenuOpen; // 0xCB
	private bool closeMenuFlag; // 0xCC
	private short nextSkill; // 0xCE
	private SkillTargetType nextTargetType; // 0xD0
	private GameObject reserveNextTarget; // 0xD8
	private BoxCollider snowballCol; // 0xE0
	private SnowballColorShadow snowballShadow; // 0xE8
	private float moveDashTimer; // 0xF0
	private float battleEndDashWait; // 0xF4
	private Vector3 dashStartPos; // 0xF8
	protected CountUpIdManager abnormalLocalIdManager; // 0x108
	private PlayerStatus _playerStatus; // 0x110
	[CompilerGenerated]
	private SkillComboManager <ComboManager>k__BackingField; // 0x118
	[CompilerGenerated]
	private StarGemManager <StarGemManager>k__BackingField; // 0x120
	[CompilerGenerated]
	private EffectPlayer <EffectPlayer>k__BackingField; // 0x128

	// Properties
	public override PlayerStatusBase PlayerStatus { get; }
	public bool IsInputLock { get; }
	public override bool IsLocalDead { get; }
	public override bool IsDead { get; }
	public override float MoveSpeed { get; }
	public bool IsMoveOrRotation { get; }
	public override bool IsHideUser { get; }
	public override AbnormalStateManager AbnormalStatusManager { get; }
	public override BufferEffectManager BufferEffectManager { get; }
	public bool GmMoveSpeedDush { get; }
	private PlayerBattleManager PlayerBattleManager { get; }
	private SkillComboManager ComboManager { get; set; }
	private StarGemManager StarGemManager { get; set; }
	private EffectPlayer EffectPlayer { get; set; }

	// Methods

	// RVA: 0x200BF04 Offset: 0x2007F04 VA: 0x200BF04 Slot: 22
	public override PlayerStatusBase get_PlayerStatus() { }

	// RVA: 0x200BF0C Offset: 0x2007F0C VA: 0x200BF0C Slot: 50
	public bool get_IsInputLock() { }

	// RVA: 0x200BF98 Offset: 0x2007F98 VA: 0x200BF98 Slot: 5
	public override bool get_IsLocalDead() { }

	// RVA: 0x200BFC8 Offset: 0x2007FC8 VA: 0x200BFC8 Slot: 7
	public override bool get_IsDead() { }

	// RVA: 0x200BFF8 Offset: 0x2007FF8 VA: 0x200BFF8 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x200C588 Offset: 0x2008588 VA: 0x200C588
	public bool get_IsMoveOrRotation() { }

	// RVA: 0x200C60C Offset: 0x200860C VA: 0x200C60C Slot: 21
	public override bool get_IsHideUser() { }

	// RVA: 0x200C680 Offset: 0x2008680 VA: 0x200C680 Slot: 23
	public override AbnormalStateManager get_AbnormalStatusManager() { }

	// RVA: 0x200C6AC Offset: 0x20086AC VA: 0x200C6AC Slot: 24
	public override BufferEffectManager get_BufferEffectManager() { }

	// RVA: 0x200C6B4 Offset: 0x20086B4 VA: 0x200C6B4
	public bool get_GmMoveSpeedDush() { }

	// RVA: 0x200C6BC Offset: 0x20086BC VA: 0x200C6BC
	private PlayerBattleManager get_PlayerBattleManager() { }

	[CompilerGenerated]
	// RVA: 0x200C7C8 Offset: 0x20087C8 VA: 0x200C7C8
	private SkillComboManager get_ComboManager() { }

	[CompilerGenerated]
	// RVA: 0x200C7D0 Offset: 0x20087D0 VA: 0x200C7D0
	private void set_ComboManager(SkillComboManager value) { }

	[CompilerGenerated]
	// RVA: 0x200C7E0 Offset: 0x20087E0 VA: 0x200C7E0
	private StarGemManager get_StarGemManager() { }

	[CompilerGenerated]
	// RVA: 0x200C7E8 Offset: 0x20087E8 VA: 0x200C7E8
	private void set_StarGemManager(StarGemManager value) { }

	[CompilerGenerated]
	// RVA: 0x200C7F8 Offset: 0x20087F8 VA: 0x200C7F8
	private EffectPlayer get_EffectPlayer() { }

	[CompilerGenerated]
	// RVA: 0x200C800 Offset: 0x2008800 VA: 0x200C800
	private void set_EffectPlayer(EffectPlayer value) { }

	// RVA: 0x200C810 Offset: 0x2008810 VA: 0x200C810 Slot: 46
	protected override void Initialize(PlayerObjectBase playerObject) { }

	// RVA: 0x200CE54 Offset: 0x2008E54 VA: 0x200CE54 Slot: 25
	protected override void Update() { }

	// RVA: 0x200E448 Offset: 0x200A448 VA: 0x200E448
	private void LateUpdate() { }

	// RVA: 0x200D4C0 Offset: 0x20094C0 VA: 0x200D4C0
	private void DashClear() { }

	// RVA: 0x200E838 Offset: 0x200A838 VA: 0x200E838
	public void TargetMove(float speed, Vector3 position, float range) { }

	// RVA: 0x200DFA8 Offset: 0x2009FA8 VA: 0x200DFA8
	private void moveCheck() { }

	// RVA: 0x200E854 Offset: 0x200A854 VA: 0x200E854 Slot: 52
	public void OnLeaveField() { }

	// RVA: 0x200EA28 Offset: 0x200AA28 VA: 0x200EA28 Slot: 53
	public void OnEnterField() { }

	// RVA: 0x200EDD0 Offset: 0x200ADD0 VA: 0x200EDD0 Slot: 65
	public void OnMenuOpen() { }

	// RVA: 0x200EDDC Offset: 0x200ADDC VA: 0x200EDDC Slot: 66
	public void OnMenuClose() { }

	// RVA: 0x200EDE8 Offset: 0x200ADE8 VA: 0x200EDE8 Slot: 37
	public override void ActionCancel() { }

	// RVA: 0x200EEEC Offset: 0x200AEEC VA: 0x200EEEC Slot: 36
	public override void ActionCancelFlinch() { }

	// RVA: 0x200EFBC Offset: 0x200AFBC VA: 0x200EFBC Slot: 51
	public PlayerActionReturnType OnActionButton(PlayerActionType type, int id) { }

	// RVA: 0x200DE5C Offset: 0x2009E5C VA: 0x200DE5C
	private bool supportTargetToReserve(SkillTargetType targetType, int skillid) { }

	// RVA: 0x200FC30 Offset: 0x200BC30 VA: 0x200FC30
	private GameObject SelectTargetMob(GameObject defaultTarget) { }

	// RVA: 0x20104A4 Offset: 0x200C4A4 VA: 0x20104A4 Slot: 54
	public void ClearTarget() { }

	// RVA: 0x200F398 Offset: 0x200B398 VA: 0x200F398 Slot: 55
	public void TargetingAction() { }

	// RVA: 0x200FEDC Offset: 0x200BEDC VA: 0x200FEDC
	private void targetMobBattleReserve(GameObject target, int skillId) { }

	// RVA: 0x2010290 Offset: 0x200C290 VA: 0x2010290
	private void targetSupportReserve(GameObject target, int skillId) { }

	// RVA: 0x2010774 Offset: 0x200C774 VA: 0x2010774 Slot: 56
	public void TargetEventArea(GameObject target) { }

	// RVA: 0x2010AF0 Offset: 0x200CAF0 VA: 0x2010AF0 Slot: 58
	public void TargetMob(GameObject target) { }

	// RVA: 0x2011CA4 Offset: 0x200DCA4 VA: 0x2011CA4 Slot: 57
	public void TargetSideMob(bool right) { }

	// RVA: 0x2011D0C Offset: 0x200DD0C VA: 0x2011D0C Slot: 59
	public void TargetPlayer(GameObject target) { }

	// RVA: 0x2011EE0 Offset: 0x200DEE0 VA: 0x2011EE0 Slot: 60
	public void ChangeNearTarget() { }

	// RVA: 0x20122D8 Offset: 0x200E2D8 VA: 0x20122D8 Slot: 61
	public void ChangeFarTarget() { }

	// RVA: 0x201186C Offset: 0x200D86C VA: 0x201186C
	public void EventReserve(GameObject target) { }

	// RVA: 0x20126D0 Offset: 0x200E6D0 VA: 0x20126D0
	public void SetNextSkill(short skillId) { }

	// RVA: 0x200D4F4 Offset: 0x20094F4 VA: 0x200D4F4
	public void BattleReserve(GameObject target, int skillId, bool assistCheck) { }

	// RVA: 0x2010DF4 Offset: 0x200CDF4 VA: 0x2010DF4
	public void SupportReserve(GameObject target, int skillId, bool assistCheck) { }

	// RVA: 0x20128C4 Offset: 0x200E8C4 VA: 0x20128C4
	public bool SkillReserveMpLess(SkillActionBase action, out bool sendActionStart) { }

	// RVA: 0x2012B64 Offset: 0x200EB64 VA: 0x2012B64 Slot: 40
	public override void OnUnsheathe() { }

	// RVA: 0x2012BA8 Offset: 0x200EBA8 VA: 0x2012BA8 Slot: 31
	public override void FirstEnemyContact(GameObject actor, bool isActiveInvoke) { }

	// RVA: 0x2012CF8 Offset: 0x200ECF8 VA: 0x2012CF8
	public void EventDamaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id, bool trapDamage) { }

	// RVA: 0x201380C Offset: 0x200F80C VA: 0x201380C
	public void EventMonsterDamage(SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x201382C Offset: 0x200F82C VA: 0x201382C Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x20165C4 Offset: 0x20125C4 VA: 0x20165C4
	private void DamagedKnightHeal(GameObject actor, SkillDamageData damageData) { }

	// RVA: 0x20136B4 Offset: 0x200F6B4 VA: 0x20136B4
	private void DamagedCloseMenu() { }

	// RVA: 0x2016F9C Offset: 0x2012F9C VA: 0x2016F9C Slot: 33
	public override void SuccessAddAbnormal(AbnormalType type, float effectTime, ActionAppendData append) { }

	// RVA: 0x20171A8 Offset: 0x20131A8 VA: 0x20171A8 Slot: 34
	public override bool CreateAbnormalEffect(AbnormalType type, float effectTime, bool abnormalBreakthroughLimit) { }

	// RVA: 0x2016D64 Offset: 0x2012D64 VA: 0x2016D64
	private void AddGuardResistAbnormal(GameObject actor, SkillDamageData damageData) { }

	// RVA: 0x20172B8 Offset: 0x20132B8 VA: 0x20172B8 Slot: 29
	public override void DungeonDamage(byte senderType, int senderId, byte trapId, DungeonEventType eventType, GameObject trapObject) { }

	// RVA: 0x20176B8 Offset: 0x20136B8 VA: 0x20176B8 Slot: 26
	public override void EventDamage(int damage, byte state, byte flag, bool popFlag) { }

	// RVA: 0x2017A00 Offset: 0x2013A00 VA: 0x2017A00 Slot: 27
	public override void EventMonsterDamage(byte attackType, int damage, int stable, ElementType element, int criticalPercent, int criticalDamage, int free, AbnormalType abnormalType, int abnormalPercent, short abnormalTime, int guardType, int avoidType, short hitSE, short hitEffect, byte hitEffectMotion) { }

	// RVA: 0x2018044 Offset: 0x2014044 VA: 0x2018044 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x20193F0 Offset: 0x20153F0 VA: 0x20193F0
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x20198A8 Offset: 0x20158A8 VA: 0x20198A8 Slot: 28
	public override void AddEventAbnormal(byte abnormalState, short state, float stateTime, bool popLabelFlag, bool forceAdd) { }

	// RVA: 0x2016948 Offset: 0x2012948 VA: 0x2016948
	private void CalcAbnormalKnockBackDistance(SkillDamageData damageData) { }

	// RVA: 0x2016A78 Offset: 0x2012A78 VA: 0x2016A78
	private bool AddAbnormalKnockBack(GameObject actor, SkillDamageData damageData, Vector3 dir, byte localId) { }

	// RVA: 0x2018E4C Offset: 0x2014E4C VA: 0x2018E4C
	private bool ApplyKnockBack(GameObject actor, float time, float resist, byte localId, bool force, Vector3 dir) { }

	// RVA: 0x2019CD0 Offset: 0x2015CD0 VA: 0x2019CD0 Slot: 62
	public bool ExistsCurrentCobmoSkill(SkillId skillId) { }

	// RVA: 0x2019D34 Offset: 0x2015D34 VA: 0x2019D34 Slot: 63
	public bool IsCurrentComboLastSkill(SkillId skillId) { }

	// RVA: 0x2019D98 Offset: 0x2015D98 VA: 0x2019D98 Slot: 64
	public void AttackParts(EnemyMobActionManagerBase mobAction, IBossParts parts, byte id) { }

	// RVA: 0x2019E38 Offset: 0x2015E38 VA: 0x2019E38 Slot: 17
	public override void OnDead() { }

	// RVA: 0x2019ECC Offset: 0x2015ECC VA: 0x2019ECC Slot: 30
	public override void OnRespawn() { }

	// RVA: 0x2019ED4 Offset: 0x2015ED4 VA: 0x2019ED4
	public void OnRespawn(bool orbRespawn) { }

	// RVA: 0x201A2B4 Offset: 0x20162B4 VA: 0x201A2B4 Slot: 42
	public override void CheckApparentDeathId(byte id) { }

	// RVA: 0x201A30C Offset: 0x201630C VA: 0x201A30C Slot: 41
	public override void ApparentDeath(GameObject actor, byte id, int damage) { }

	// RVA: 0x201A5C4 Offset: 0x20165C4 VA: 0x201A5C4 Slot: 43
	public override void ReviveFromApparentDeath() { }

	// RVA: 0x201A650 Offset: 0x2016650 VA: 0x201A650 Slot: 32
	public override void VanishingObject(GameObject actor) { }

	// RVA: 0x201A9E0 Offset: 0x20169E0 VA: 0x201A9E0 Slot: 39
	public override void OnReleaseEnemy() { }

	// RVA: 0x201AA04 Offset: 0x2016A04 VA: 0x201AA04 Slot: 47
	protected override void moveAnimationCheck() { }

	// RVA: 0x201ADE0 Offset: 0x2016DE0 VA: 0x201ADE0 Slot: 38
	public override void BattlePause() { }

	// RVA: 0x201AEA0 Offset: 0x2016EA0 VA: 0x201AEA0 Slot: 35
	public override SkillActionBase.DamageData DamageTransfer(SkillActionBase.DamageData source) { }

	// RVA: 0x201B224 Offset: 0x2017224 VA: 0x201B224 Slot: 68
	public void SnowballFightAction(int id) { }

	// RVA: 0x200E328 Offset: 0x200A328 VA: 0x200E328
	private void SnowballColCheck() { }

	// RVA: 0x200ED48 Offset: 0x200AD48 VA: 0x200ED48
	private void ChangeSnowballColSize(bool isReload) { }

	// RVA: 0x200F808 Offset: 0x200B808 VA: 0x200F808
	private SkillTargetType GetSkillTargetType(int skillId) { }

	// RVA: 0x201BE3C Offset: 0x2017E3C VA: 0x201BE3C Slot: 67
	public void SetDashKey(bool bPush) { }

	// RVA: 0x201BE88 Offset: 0x2017E88 VA: 0x201BE88 Slot: 44
	public override bool CheckAvailableSkill(SkillId id) { }

	// RVA: 0x201C0E8 Offset: 0x20180E8 VA: 0x201C0E8 Slot: 45
	public override void InMobAttackArea(EnemyMobActionManagerBase enemyAction, MobAttackBase mobAttack) { }

	// RVA: 0x2016CB0 Offset: 0x2012CB0 VA: 0x2016CB0
	private void AddAbnormalMessage(AbnormalType type) { }

	// RVA: 0x201C2E8 Offset: 0x20182E8 VA: 0x201C2E8
	public bool TryGetAbnormalLocalId(out byte abnormalLocalId) { }

	// RVA: 0x201C320 Offset: 0x2018320 VA: 0x201C320
	public bool ReleaseAbnormalLocalId(byte localId) { }

	// RVA: 0x201C340 Offset: 0x2018340 VA: 0x201C340 Slot: 69
	public PlayerActionReturnType HalloweenAction(PlayerActionType type, int id) { }

	// RVA: 0x201C47C Offset: 0x201847C VA: 0x201C47C
	private void HalloweenTargetingAction() { }

	// RVA: 0x201C850 Offset: 0x2018850 VA: 0x201C850
	private bool HalloweenAttackReserve(GameObject target, int skillId) { }

	// RVA: 0x201CC5C Offset: 0x2018C5C VA: 0x201CC5C
	public void HalloweenDamge(GameObject actor) { }

	// RVA: 0x201CCB4 Offset: 0x2018CB4 VA: 0x201CCB4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x201CD7C Offset: 0x2018D7C VA: 0x201CD7C
	private void <Initialize>b__59_0() { }

	[CompilerGenerated]
	// RVA: 0x201CD8C Offset: 0x2018D8C VA: 0x201CD8C
	private void <Initialize>b__59_1(RewardResponseDatav2 x) { }

	[CompilerGenerated]
	// RVA: 0x201CE00 Offset: 0x2018E00 VA: 0x201CE00
	private void <Initialize>b__59_2(int id, RewardResponseDatav2 reward) { }

	[CompilerGenerated]
	// RVA: 0x201CFF4 Offset: 0x2018FF4 VA: 0x201CFF4
	private bool <ClearTarget>b__74_0(MobActionManagerBase x) { }

	[CompilerGenerated]
	// RVA: 0x201D0DC Offset: 0x20190DC VA: 0x201D0DC
	private void <TargetEventArea>b__78_0() { }
}

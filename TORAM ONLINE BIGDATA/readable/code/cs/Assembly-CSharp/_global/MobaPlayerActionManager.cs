// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaPlayerActionManager : PlayerActionManagerBase, IPlayerControl // TypeDefIndex: 1414
{
	// Fields
	[CompilerGenerated]
	private SkillComboManager <ComboManager>k__BackingField; // 0x88
	[CompilerGenerated]
	private bool <IsGameSystemLock>k__BackingField; // 0x90
	[CompilerGenerated]
	private bool <IsTargettingSearchPlayer>k__BackingField; // 0x91
	private const float TargetingRange = 30;
	private const float TargetingHeightRange = 8;
	private MobaPlayer mobaPlayer; // 0x98
	private PlayerAnimation playerAnimation; // 0xA0
	private EmotionPlayer emotionPlayer; // 0xA8
	private BufferEffectManager bufferEffect; // 0xB0
	private EffectPlayer effectPlayer; // 0xB8
	private MobaPlayerStatus playerStatus; // 0xC0
	private MobaPlayerBattleManager _mobaBattleManager; // 0xC8
	private InputManager input; // 0xD0
	private int nextSkill; // 0xD8
	private SkillTargetType nextTargetType; // 0xDC
	private GameObject reserveNextTarget; // 0xE0
	protected CountUpIdManager abnormalLocalIdManager; // 0xE8
	private bool isInputLock; // 0xF0
	private bool externalTarget; // 0xF1
	private bool isAutoEventSelect; // 0xF2
	private TargetManager targetManager; // 0xF8
	private float moveDashTimer; // 0x100
	private float battleEndDashWait; // 0x104
	private Vector3 dashStartPos; // 0x108
	private bool isMenuOpen; // 0x114
	private bool closeMenuFlag; // 0x115
	private MobaRoomData roomData; // 0x118

	// Properties
	public override PlayerStatusBase PlayerStatus { get; }
	public override AbnormalStateManager AbnormalStatusManager { get; }
	public override BufferEffectManager BufferEffectManager { get; }
	public bool IsInputLock { get; }
	private SkillComboManager ComboManager { get; set; }
	private MobaPlayerBattleManager MobaBattleManager { get; }
	public override bool IsGhost { get; }
	public override float MoveSpeed { get; }
	public override bool IsLocalDead { get; }
	public override bool IsDead { get; }
	public bool IsGameSystemLock { get; set; }
	public bool IsTargettingSearchPlayer { get; set; }
	private MobaRoomData mobaRoomData { get; }

	// Methods

	// RVA: 0x1FEB394 Offset: 0x1FE7394 VA: 0x1FEB394 Slot: 22
	public override PlayerStatusBase get_PlayerStatus() { }

	// RVA: 0x1FEB39C Offset: 0x1FE739C VA: 0x1FEB39C Slot: 23
	public override AbnormalStateManager get_AbnormalStatusManager() { }

	// RVA: 0x1FEB3C8 Offset: 0x1FE73C8 VA: 0x1FEB3C8 Slot: 24
	public override BufferEffectManager get_BufferEffectManager() { }

	// RVA: 0x1FEB3D0 Offset: 0x1FE73D0 VA: 0x1FEB3D0 Slot: 50
	public bool get_IsInputLock() { }

	[CompilerGenerated]
	// RVA: 0x1FEB474 Offset: 0x1FE7474 VA: 0x1FEB474
	private SkillComboManager get_ComboManager() { }

	[CompilerGenerated]
	// RVA: 0x1FEB47C Offset: 0x1FE747C VA: 0x1FEB47C
	private void set_ComboManager(SkillComboManager value) { }

	// RVA: 0x1FEB484 Offset: 0x1FE7484 VA: 0x1FEB484
	private MobaPlayerBattleManager get_MobaBattleManager() { }

	// RVA: 0x1FEB590 Offset: 0x1FE7590 VA: 0x1FEB590 Slot: 20
	public override bool get_IsGhost() { }

	// RVA: 0x1FEB618 Offset: 0x1FE7618 VA: 0x1FEB618 Slot: 10
	public override float get_MoveSpeed() { }

	// RVA: 0x1FEBB14 Offset: 0x1FE7B14 VA: 0x1FEBB14 Slot: 5
	public override bool get_IsLocalDead() { }

	// RVA: 0x1FEBB44 Offset: 0x1FE7B44 VA: 0x1FEBB44 Slot: 7
	public override bool get_IsDead() { }

	[CompilerGenerated]
	// RVA: 0x1FEBB74 Offset: 0x1FE7B74 VA: 0x1FEBB74
	public bool get_IsGameSystemLock() { }

	[CompilerGenerated]
	// RVA: 0x1FEBB7C Offset: 0x1FE7B7C VA: 0x1FEBB7C
	private void set_IsGameSystemLock(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1FEBB88 Offset: 0x1FE7B88 VA: 0x1FEBB88
	public bool get_IsTargettingSearchPlayer() { }

	[CompilerGenerated]
	// RVA: 0x1FEBB90 Offset: 0x1FE7B90 VA: 0x1FEBB90
	private void set_IsTargettingSearchPlayer(bool value) { }

	// RVA: 0x1FEBA20 Offset: 0x1FE7A20 VA: 0x1FEBA20
	private MobaRoomData get_mobaRoomData() { }

	// RVA: 0x1FEBB9C Offset: 0x1FE7B9C VA: 0x1FEBB9C Slot: 46
	protected override void Initialize(PlayerObjectBase playerObject) { }

	// RVA: 0x1FEBEC0 Offset: 0x1FE7EC0 VA: 0x1FEBEC0 Slot: 25
	protected override void Update() { }

	// RVA: 0x1FECD70 Offset: 0x1FE8D70 VA: 0x1FECD70
	private void LateUpdate() { }

	// RVA: 0x1FEC18C Offset: 0x1FE818C VA: 0x1FEC18C
	private void NextSkillReserve() { }

	// RVA: 0x1FED10C Offset: 0x1FE910C VA: 0x1FED10C
	public void BattleReserve(GameObject target, int skillId, bool assistCheck) { }

	// RVA: 0x1FEDA80 Offset: 0x1FE9A80 VA: 0x1FEDA80
	public void SupportReserve(GameObject target, int skillId, bool assistCheck) { }

	// RVA: 0x1FED834 Offset: 0x1FE9834 VA: 0x1FED834
	public bool SkillReserveMpLess(SkillActionBase action, out bool sendActionStart) { }

	// RVA: 0x1FEE254 Offset: 0x1FEA254 VA: 0x1FEE254
	public void EventReserve(GameObject target) { }

	// RVA: 0x1FEE324 Offset: 0x1FEA324 VA: 0x1FEE324 Slot: 15
	public override bool AddAbnormalState(GameObject actor, AbnormalType type, float time, float resist, float addResist, byte localId, bool force) { }

	// RVA: 0x1FEF1BC Offset: 0x1FEB1BC VA: 0x1FEF1BC Slot: 36
	public override void ActionCancelFlinch() { }

	// RVA: 0x1FEECB4 Offset: 0x1FEACB4 VA: 0x1FEECB4
	private bool ApplyKnockBack(GameObject actor, float time, float resist, byte localId, bool force, Vector3 dir) { }

	// RVA: 0x1FEF264 Offset: 0x1FEB264 VA: 0x1FEF264
	private bool AddAbnormalKnockBack(GameObject actor, SkillDamageData damageData, Vector3 dir, byte localId) { }

	// RVA: 0x1FEF49C Offset: 0x1FEB49C VA: 0x1FEF49C
	private void abnormalActionLockCheck(AbnormalData abnormalData) { }

	// RVA: 0x1FEF870 Offset: 0x1FEB870 VA: 0x1FEF870 Slot: 37
	public override void ActionCancel() { }

	// RVA: 0x1FEFAC0 Offset: 0x1FEBAC0 VA: 0x1FEFAC0 Slot: 38
	public override void BattlePause() { }

	// RVA: 0x1FEFB80 Offset: 0x1FEBB80 VA: 0x1FEFB80 Slot: 39
	public override void OnReleaseEnemy() { }

	// RVA: 0x1FEFBA4 Offset: 0x1FEBBA4 VA: 0x1FEFBA4 Slot: 17
	public override void OnDead() { }

	// RVA: 0x1FEFC38 Offset: 0x1FEBC38 VA: 0x1FEFC38 Slot: 30
	public override void OnRespawn() { }

	// RVA: 0x1FEFC40 Offset: 0x1FEBC40 VA: 0x1FEFC40
	public void OnRespawn(bool orbRespawn) { }

	// RVA: 0x1FEFD38 Offset: 0x1FEBD38 VA: 0x1FEFD38 Slot: 48
	protected override void DeadGhost() { }

	// RVA: 0x1FEFE20 Offset: 0x1FEBE20 VA: 0x1FEFE20 Slot: 49
	protected override void GhostRespawn() { }

	// RVA: 0x1FEFEE0 Offset: 0x1FEBEE0 VA: 0x1FEFEE0 Slot: 42
	public override void CheckApparentDeathId(byte id) { }

	// RVA: 0x1FEFF38 Offset: 0x1FEBF38 VA: 0x1FEFF38 Slot: 41
	public override void ApparentDeath(GameObject actor, byte id, int damage) { }

	// RVA: 0x1FF018C Offset: 0x1FEC18C VA: 0x1FF018C Slot: 43
	public override void ReviveFromApparentDeath() { }

	// RVA: 0x1FF0200 Offset: 0x1FEC200 VA: 0x1FF0200 Slot: 14
	public override void Damaged(GameObject actor, SkillActionBase action, SkillDamageData damageData, byte id) { }

	// RVA: 0x1FF1CF8 Offset: 0x1FEDCF8 VA: 0x1FF1CF8 Slot: 33
	public override void SuccessAddAbnormal(AbnormalType type, float effectTime, ActionAppendData append) { }

	// RVA: 0x1FF1D4C Offset: 0x1FEDD4C VA: 0x1FF1D4C Slot: 34
	public override bool CreateAbnormalEffect(AbnormalType type, float effectTime, bool abnormalBreakthroughLimit) { }

	// RVA: 0x1FF1A28 Offset: 0x1FEDA28 VA: 0x1FF1A28
	private void AddGuardResistAbnormal(GameObject actor, SkillDamageData damageData) { }

	// RVA: 0x1FF1E60 Offset: 0x1FEDE60 VA: 0x1FF1E60 Slot: 62
	public bool ExistsCurrentCobmoSkill(SkillId skillId) { }

	// RVA: 0x1FF1EC4 Offset: 0x1FEDEC4 VA: 0x1FF1EC4 Slot: 63
	public bool IsCurrentComboLastSkill(SkillId skillId) { }

	// RVA: 0x1FF1F28 Offset: 0x1FEDF28 VA: 0x1FF1F28 Slot: 51
	public PlayerActionReturnType OnActionButton(PlayerActionType type, int id) { }

	// RVA: 0x1FF2E6C Offset: 0x1FEEE6C VA: 0x1FF2E6C Slot: 52
	public void OnLeaveField() { }

	// RVA: 0x1FF2F74 Offset: 0x1FEEF74 VA: 0x1FF2F74 Slot: 53
	public void OnEnterField() { }

	// RVA: 0x1FF31A8 Offset: 0x1FEF1A8 VA: 0x1FF31A8 Slot: 54
	public void ClearTarget() { }

	// RVA: 0x1FF2200 Offset: 0x1FEE200 VA: 0x1FF2200 Slot: 55
	public void TargetingAction() { }

	// RVA: 0x1FF3478 Offset: 0x1FEF478 VA: 0x1FF3478 Slot: 56
	public void TargetEventArea(GameObject target) { }

	// RVA: 0x1FF3AF4 Offset: 0x1FEFAF4 VA: 0x1FF3AF4 Slot: 57
	public void TargetSideMob(bool right) { }

	// RVA: 0x1FF37C4 Offset: 0x1FEF7C4 VA: 0x1FF37C4 Slot: 58
	public void TargetMob(GameObject target) { }

	// RVA: 0x1FF3B5C Offset: 0x1FEFB5C VA: 0x1FF3B5C Slot: 59
	public void TargetPlayer(GameObject target) { }

	// RVA: 0x1FF2C38 Offset: 0x1FEEC38 VA: 0x1FF2C38
	private void TargetMobBattleReserve(GameObject target, int skillId) { }

	// RVA: 0x1FF3D64 Offset: 0x1FEFD64 VA: 0x1FF3D64
	private void targetSupportReserve(GameObject target, int skillId) { }

	// RVA: 0x1FF2998 Offset: 0x1FEE998 VA: 0x1FF2998
	private GameObject SelectTargetMob(GameObject defaultTarget) { }

	// RVA: 0x1FF2634 Offset: 0x1FEE634 VA: 0x1FF2634
	private SkillTargetType GetSkillTargetType(int skillId) { }

	// RVA: 0x1FED760 Offset: 0x1FE9760 VA: 0x1FED760
	private bool supportTargetToReserve(SkillTargetType targetType, int skillid) { }

	// RVA: 0x1FF3E80 Offset: 0x1FEFE80 VA: 0x1FF3E80 Slot: 60
	public void ChangeNearTarget() { }

	// RVA: 0x1FF4270 Offset: 0x1FF0270 VA: 0x1FF4270 Slot: 61
	public void ChangeFarTarget() { }

	// RVA: 0x1FF4660 Offset: 0x1FF0660 VA: 0x1FF4660 Slot: 64
	public void AttackParts(EnemyMobActionManagerBase mobAction, IBossParts parts, byte id) { }

	// RVA: 0x1FF4664 Offset: 0x1FF0664 VA: 0x1FF4664 Slot: 65
	public void OnMenuOpen() { }

	// RVA: 0x1FF4670 Offset: 0x1FF0670 VA: 0x1FF4670 Slot: 66
	public void OnMenuClose() { }

	// RVA: 0x1FF467C Offset: 0x1FF067C VA: 0x1FF467C Slot: 67
	public void SetDashKey(bool bPush) { }

	// RVA: 0x1FF46C8 Offset: 0x1FF06C8 VA: 0x1FF46C8 Slot: 68
	public void SnowballFightAction(int id) { }

	// RVA: 0x1FF46CC Offset: 0x1FF06CC VA: 0x1FF46CC Slot: 69
	public PlayerActionReturnType HalloweenAction(PlayerActionType type, int id) { }

	// RVA: 0x1FF46D4 Offset: 0x1FF06D4 VA: 0x1FF46D4
	public void SetNextSkill(short skillId) { }

	// RVA: 0x1FECA60 Offset: 0x1FE8A60 VA: 0x1FECA60
	private void moveCheck() { }

	// RVA: 0x1FF48B4 Offset: 0x1FF08B4 VA: 0x1FF48B4 Slot: 32
	public override void VanishingObject(GameObject actor) { }

	// RVA: 0x1FF4BFC Offset: 0x1FF0BFC VA: 0x1FF4BFC
	public void OtherPlayerDead(GameObject target) { }

	// RVA: 0x1FF4E14 Offset: 0x1FF0E14 VA: 0x1FF4E14 Slot: 44
	public override bool CheckAvailableSkill(SkillId skillId) { }

	// RVA: 0x1FEC154 Offset: 0x1FE8154 VA: 0x1FEC154
	private void DashClear() { }

	// RVA: 0x1FF4E8C Offset: 0x1FF0E8C VA: 0x1FF4E8C Slot: 40
	public override void OnUnsheathe() { }

	// RVA: 0x1FF4ED0 Offset: 0x1FF0ED0 VA: 0x1FF4ED0 Slot: 31
	public override void FirstEnemyContact(GameObject actor, bool isActiveInvoke) { }

	// RVA: 0x1FF4FC4 Offset: 0x1FF0FC4 VA: 0x1FF4FC4 Slot: 47
	protected override void moveAnimationCheck() { }

	// RVA: 0x1FF53A4 Offset: 0x1FF13A4 VA: 0x1FF53A4
	public void ReconnectionUpdateTimestump() { }

	// RVA: 0x1FF54A4 Offset: 0x1FF14A4 VA: 0x1FF54A4
	public void ReceiveAttack(SkillActionBase skill, CharacterActionManagerBase targetAction, AttackResponseData attackResponseData, MobaMobResponseData mobResponseData) { }

	[IteratorStateMachine(typeof(MobaPlayerActionManager.<FakeDamageDisp>d__120))]
	// RVA: 0x1FF65B4 Offset: 0x1FF25B4 VA: 0x1FF65B4
	private IEnumerator FakeDamageDisp(int damage, int damageCount, float wait, SkillId skillId, string localizeKey, SkillHitType hitType, bool isScratch, bool isOutOfRange, SkillHitReactionType reactionType, Vector3 popPosition, byte nowDamageCount) { }

	// RVA: 0x1FF66D0 Offset: 0x1FF26D0 VA: 0x1FF66D0
	private void ViewMobaMobDamageLabel(SkillId skillId, string localizeKey, int damage, SkillHitType hitType, bool isScratch, bool isOutOfRange, SkillHitReactionType reactionType, Vector3 popPosition, byte damageCount) { }

	// RVA: 0x1FF6994 Offset: 0x1FF2994 VA: 0x1FF6994
	public void ReceiveOtherPlayerToPlayerDamaged(MobaOtherPlayer otherPlayer, AttackEventData eventData, MobaMobResponseData responseData) { }

	// RVA: 0x1FF6DEC Offset: 0x1FF2DEC VA: 0x1FF6DEC
	private void ReceiveDamaged(MobaOtherPlayer otherPlayer, short skillId, MobaMobResponseData responseData) { }

	// RVA: 0x1FF87E4 Offset: 0x1FF47E4 VA: 0x1FF87E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1FF88B0 Offset: 0x1FF48B0 VA: 0x1FF88B0
	private bool <ClearTarget>b__89_0(MobActionManagerBase x) { }

	[CompilerGenerated]
	// RVA: 0x1FF8998 Offset: 0x1FF4998 VA: 0x1FF8998
	private void <TargetEventArea>b__91_0() { }
}

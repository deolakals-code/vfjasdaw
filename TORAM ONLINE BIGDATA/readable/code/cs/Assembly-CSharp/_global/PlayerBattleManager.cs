// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(PlayerSkillActionManager))]
public class PlayerBattleManager : BattleManagerBase, IAvoidAction, IGuardAction, IMagicEgelBattleManager // TypeDefIndex: 1453
{
	// Fields
	private IMainPlayer mainPlayer; // 0x78
	private PlayerAnimation playerAnimation; // 0x80
	private PlayerActionManagerBase playerAction; // 0x88
	private IPlayerControl playerControl; // 0x90
	private GuardActionManager guardManager; // 0x98
	private AvoidActionManager avoidManager; // 0xA0
	private SkillComboManager comboManager; // 0xA8
	private bool isMoveAssist; // 0xB0
	private bool isAssistMovingCheck; // 0xB1
	private float assistMoveTime; // 0xB4
	private GameObject assistTarget; // 0xB8
	private float attackDelay; // 0xC0
	private float partsAttackDelay; // 0xC4
	private float guardNextAttackDelay; // 0xC8
	protected CountUpIdManager localIdManager; // 0xD0
	private bool nextComboFlag; // 0xD8
	private Dictionary<KeyValuePair<SkillId, int>, KeyValuePair<ActionCode, int>> actionEndReconnection; // 0xE0
	private Dictionary<KeyValuePair<SkillId, int>, KeyValuePair<ActionCode, int>> skillCancelReconnection; // 0xE8
	private CameraManager cameraManager; // 0xF0
	private const float GuardStrikeInterval = 0.5;
	private float guardStrikeCoolTime; // 0xF8
	private IEnumerator activeWaitPutUpWeapon; // 0x100
	private readonly int[] NoCheckSkillId; // 0x108

	// Properties
	public bool IsMoveAssist { get; }
	public bool IsAvoid { get; }
	public override GuardType GuardType { get; }
	public bool IsGuard { get; }
	public override AvoidType AvoidType { get; }
	public virtual bool IsPlayer { get; }
	public GuardActionManager GuardManager { get; }
	public AvoidActionManager AvoidManager { get; }

	// Methods

	// RVA: 0x201D0F8 Offset: 0x20190F8 VA: 0x201D0F8
	public bool get_IsMoveAssist() { }

	// RVA: 0x201D100 Offset: 0x2019100 VA: 0x201D100 Slot: 38
	public bool get_IsAvoid() { }

	// RVA: 0x201D188 Offset: 0x2019188 VA: 0x201D188 Slot: 4
	public override GuardType get_GuardType() { }

	// RVA: 0x201D1E0 Offset: 0x20191E0 VA: 0x201D1E0 Slot: 47
	public bool get_IsGuard() { }

	// RVA: 0x201D268 Offset: 0x2019268 VA: 0x201D268 Slot: 5
	public override AvoidType get_AvoidType() { }

	// RVA: 0x201D2C0 Offset: 0x20192C0 VA: 0x201D2C0 Slot: 59
	public virtual bool get_IsPlayer() { }

	// RVA: 0x201D2C8 Offset: 0x20192C8 VA: 0x201D2C8 Slot: 49
	public GuardActionManager get_GuardManager() { }

	// RVA: 0x201D2D0 Offset: 0x20192D0 VA: 0x201D2D0 Slot: 40
	public AvoidActionManager get_AvoidManager() { }

	// RVA: 0x201D2D8 Offset: 0x20192D8 VA: 0x201D2D8 Slot: 6
	protected override void Awake() { }

	// RVA: 0x201D5B0 Offset: 0x20195B0 VA: 0x201D5B0 Slot: 8
	public override void ActionUpdate() { }

	// RVA: 0x201D880 Offset: 0x2019880 VA: 0x201D880 Slot: 9
	protected override void OnInitialize() { }

	// RVA: 0x201DC94 Offset: 0x2019C94 VA: 0x201DC94 Slot: 10
	protected override void OnEnd() { }

	// RVA: 0x201DCA8 Offset: 0x2019CA8 VA: 0x201DCA8 Slot: 11
	protected override void OnDead() { }

	// RVA: 0x201DD70 Offset: 0x2019D70 VA: 0x201DD70 Slot: 12
	protected override void OnRespawn(bool orbRespawn) { }

	// RVA: 0x201D9B8 Offset: 0x20199B8 VA: 0x201D9B8
	private void ClearReconnection() { }

	// RVA: 0x201DE44 Offset: 0x2019E44 VA: 0x201DE44 Slot: 15
	protected override void OnNextActionCancel() { }

	// RVA: 0x201DEB8 Offset: 0x2019EB8 VA: 0x201DEB8
	public void SetMoveAssistFlag(bool flag) { }

	// RVA: 0x201DEC4 Offset: 0x2019EC4 VA: 0x201DEC4
	public void SetAssistMoveTarget(GameObject target) { }

	// RVA: 0x201D86C Offset: 0x201986C VA: 0x201D86C
	public void AssistMoveResetToEnemy() { }

	// RVA: 0x201D7A8 Offset: 0x20197A8 VA: 0x201D7A8
	private bool targetToEnemy(MobActionManagerBase manager) { }

	// RVA: 0x201DEF0 Offset: 0x2019EF0 VA: 0x201DEF0 Slot: 21
	protected override bool OnEndAssistMove(GameObject target) { }

	// RVA: 0x201DF1C Offset: 0x2019F1C VA: 0x201DF1C Slot: 19
	protected override bool OnActionRange(GameObject target, SkillActionBase action) { }

	// RVA: 0x201E050 Offset: 0x201A050 VA: 0x201E050 Slot: 20
	protected override bool OnActionOutOfRange(GameObject target, SkillActionBase action) { }

	[IteratorStateMachine(typeof(PlayerBattleManager.<waitUnsheatheWeapon>d__52))]
	// RVA: 0x201E15C Offset: 0x201A15C VA: 0x201E15C
	private IEnumerator waitUnsheatheWeapon() { }

	// RVA: 0x201E1D0 Offset: 0x201A1D0 VA: 0x201E1D0
	private void checkAssistMove(GameObject target, SkillActionBase action) { }

	[IteratorStateMachine(typeof(PlayerBattleManager.<ShukuchiMoveWait>d__54))]
	// RVA: 0x201E75C Offset: 0x201A75C VA: 0x201E75C
	private IEnumerator ShukuchiMoveWait(GameObject target, SkillActionBase action) { }

	[IteratorStateMachine(typeof(PlayerBattleManager.<AbnormalStopCheck>d__55))]
	// RVA: 0x201E800 Offset: 0x201A800 VA: 0x201E800
	private IEnumerator AbnormalStopCheck(GameObject target, SkillActionBase action) { }

	// RVA: 0x201E8A4 Offset: 0x201A8A4 VA: 0x201E8A4 Slot: 22
	protected override void OnBattleActive() { }

	// RVA: 0x201EA20 Offset: 0x201AA20 VA: 0x201EA20 Slot: 23
	protected override void OnBattleEnd() { }

	// RVA: 0x201ED5C Offset: 0x201AD5C VA: 0x201ED5C Slot: 24
	public override void OnInputMove() { }

	[IteratorStateMachine(typeof(PlayerBattleManager.<waitPutUpWeapon>d__60))]
	// RVA: 0x201ECE8 Offset: 0x201ACE8 VA: 0x201ECE8
	private IEnumerator waitPutUpWeapon() { }

	// RVA: 0x201F0CC Offset: 0x201B0CC VA: 0x201F0CC Slot: 36
	public override void ChangeField() { }

	// RVA: 0x201F188 Offset: 0x201B188 VA: 0x201F188 Slot: 37
	public override void ChangeStatus() { }

	// RVA: 0x201D8B0 Offset: 0x20198B0 VA: 0x201D8B0 Slot: 50
	public void InitializeGuard() { }

	// RVA: 0x201F244 Offset: 0x201B244 VA: 0x201F244 Slot: 51
	public bool CheckGuard(MobActionManagerBase mobAction, MobAttackBase action, int damage, out SkillHitReactionType guardType, out bool justGuard) { }

	// RVA: 0x201F320 Offset: 0x201B320 VA: 0x201F320 Slot: 52
	public void GuardEnd(bool forceEnd) { }

	// RVA: 0x201F3B8 Offset: 0x201B3B8 VA: 0x201F3B8 Slot: 25
	public override void OnGuard(GameObject actor, SkillDamageData damageData) { }

	// RVA: 0x201F614 Offset: 0x201B614 VA: 0x201F614 Slot: 26
	public override int CalcGuard(int damage, out int guardPower) { }

	// RVA: 0x201F454 Offset: 0x201B454 VA: 0x201F454
	private void GuardStrikeAction(GameObject actor) { }

	// RVA: 0x201F878 Offset: 0x201B878 VA: 0x201F878 Slot: 55
	public void GuardEndNextAttackDelay() { }

	// RVA: 0x201D934 Offset: 0x2019934 VA: 0x201D934 Slot: 41
	public void InitializeAvoid() { }

	// RVA: 0x201F88C Offset: 0x201B88C VA: 0x201F88C Slot: 42
	public bool CheckAvoid(MobActionManagerBase mobAction, MobAttackBase mobAttack) { }

	// RVA: 0x201F930 Offset: 0x201B930 VA: 0x201F930 Slot: 43
	public void AvoidEnd(bool forceEnd) { }

	// RVA: 0x201F9C8 Offset: 0x201B9C8 VA: 0x201F9C8 Slot: 27
	public override void OnAvoid(GameObject actor) { }

	// RVA: 0x201FA60 Offset: 0x201BA60 VA: 0x201FA60
	public void PlayPhiloEclair(PlayerActionManagerBase actorActionManager, GameObject target) { }

	// RVA: 0x2020480 Offset: 0x201C480 VA: 0x2020480
	public void PlayShadowWalkAttack(PlayerActionManagerBase actorActionManager, GameObject target) { }

	// RVA: 0x2020798 Offset: 0x201C798 VA: 0x2020798 Slot: 45
	public void DamagedAvoid(int damage) { }

	// RVA: 0x2020830 Offset: 0x201C830 VA: 0x2020830 Slot: 46
	public void ReceiveAvoid(int param) { }

	// RVA: 0x20208C8 Offset: 0x201C8C8 VA: 0x20208C8
	private void CameraPlayerBack() { }

	// RVA: 0x20209AC Offset: 0x201C9AC VA: 0x20209AC
	public void OnPartsAttack(EnemyMobActionManagerBase mobAction, IBossParts parts, byte id) { }

	// RVA: 0x202105C Offset: 0x201D05C VA: 0x202105C
	private int calcPartsBaseDamage(MobActionManagerBase mobAction, MobPartsStatus parts) { }

	// RVA: 0x202158C Offset: 0x201D58C VA: 0x202158C Slot: 28
	protected override bool OnSkillActionStart(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x2024C38 Offset: 0x2020C38 VA: 0x2024C38
	protected bool CheckSkillStartAbnormalState(SkillActionBase action) { }

	// RVA: 0x2024CE0 Offset: 0x2020CE0 VA: 0x2024CE0 Slot: 60
	protected virtual bool AbnormalFear(SkillActionBase action) { }

	// RVA: 0x202491C Offset: 0x202091C VA: 0x202491C
	public bool SkillPayHp(SkillActionBase action) { }

	// RVA: 0x2024998 Offset: 0x2020998 VA: 0x2024998
	private void StartSkillComboInvincibility(SkillActionBase action) { }

	// RVA: 0x20234D8 Offset: 0x201F4D8 VA: 0x20234D8
	private void ConvertNinjutsuSkill(GameObject target, SkillActionBase action) { }

	// RVA: 0x20237A8 Offset: 0x201F7A8 VA: 0x20237A8
	private bool CheckConvertRapidAqueVortex(SkillActionBase action) { }

	// RVA: 0x2023A88 Offset: 0x201FA88 VA: 0x2023A88
	private void ChronosShift(GameObject target, CharacterActionManagerBase targetActionManager, SkillActionBase action) { }

	// RVA: 0x2023CCC Offset: 0x201FCCC VA: 0x2023CCC
	private bool TenjhoTengeMusouSword(GameObject target, CharacterActionManagerBase targetActionManager, SkillActionBase action) { }

	// RVA: 0x2023E54 Offset: 0x201FE54 VA: 0x2023E54
	private bool Setlist(SkillActionBase action) { }

	// RVA: 0x202474C Offset: 0x202074C VA: 0x202474C
	private bool ActionStartSkillMpLess(SkillActionBase action, out bool sendActionStart) { }

	// RVA: 0x20251A0 Offset: 0x20211A0 VA: 0x20251A0 Slot: 29
	protected override void OnSkillActionHit(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x2025BE4 Offset: 0x2021BE4 VA: 0x2025BE4
	private void OnSkillActionHitToSupport(SkillActionBase action) { }

	// RVA: 0x2026FE0 Offset: 0x2022FE0 VA: 0x2026FE0 Slot: 30
	protected override void OnSkillActionDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x2029570 Offset: 0x2025570 VA: 0x2029570 Slot: 31
	protected override void OnSkillActionRangeDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x2028020 Offset: 0x2024020 VA: 0x2028020
	private void ConsumeBuffAttack(SkillActionBase action, SkillHitType hitType) { }

	// RVA: 0x202AA10 Offset: 0x2026A10 VA: 0x202AA10 Slot: 35
	protected override void OnSkillActionSupport(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x202BE60 Offset: 0x2027E60 VA: 0x202BE60 Slot: 32
	protected override void OnSkillActionEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x202D608 Offset: 0x2029608 VA: 0x202D608
	private void AddDelay(float delayTime) { }

	// RVA: 0x202D6B4 Offset: 0x20296B4 VA: 0x202D6B4
	private bool CheckZeroActionDelay() { }

	[IteratorStateMachine(typeof(PlayerBattleManager.<NextActionSetEndFrame>d__102))]
	// RVA: 0x202D830 Offset: 0x2029830 VA: 0x202D830
	private IEnumerator NextActionSetEndFrame(CharacterActionManagerBase targetActManager, short skill) { }

	[IteratorStateMachine(typeof(PlayerBattleManager.<FakeDamageDisp>d__103))]
	// RVA: 0x202A95C Offset: 0x202695C VA: 0x202A95C
	private IEnumerator FakeDamageDisp(SkillActionBase.DamageData damage, float wait, SkillActionBase action) { }

	// RVA: 0x202D8C0 Offset: 0x20298C0 VA: 0x202D8C0 Slot: 33
	protected override void OnSkillActionAllEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x202EE68 Offset: 0x202AE68 VA: 0x202EE68 Slot: 34
	protected override void OnSkillActionCancel(GameObject target, SkillActionBase action) { }

	// RVA: 0x202F2E8 Offset: 0x202B2E8 VA: 0x202F2E8 Slot: 18
	public override void CheckBattleEnd() { }

	// RVA: 0x201F6C4 Offset: 0x201B6C4 VA: 0x201F6C4
	public void AddReconnectionActionEnd(SkillActionBase action) { }

	// RVA: 0x202F14C Offset: 0x202B14C VA: 0x202F14C
	public void AddReconnectionActionCancel(SkillActionBase action) { }

	// RVA: 0x202F768 Offset: 0x202B768 VA: 0x202F768
	public void ReceiveAttackEnd(SkillId skillId, int localId) { }

	// RVA: 0x202F8A8 Offset: 0x202B8A8 VA: 0x202F8A8
	public void ReceiveSkillCancel(SkillId skillId, int localId) { }

	// RVA: 0x202F9E8 Offset: 0x202B9E8 VA: 0x202F9E8
	public void DamagerReflection(MobActionManagerBase actMgr) { }

	// RVA: 0x202CD48 Offset: 0x2028D48 VA: 0x202CD48
	protected void PursuitAttack(CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x202FC54 Offset: 0x202BC54 VA: 0x202FC54
	public void EquipBuffAttack(BonusType type, MobActionManagerBase mobAction) { }

	// RVA: 0x20301E0 Offset: 0x202C1E0 VA: 0x20301E0
	public void BonusDamageAttack(Dictionary<BonusType, short> bonusList) { }

	// RVA: 0x203047C Offset: 0x202C47C VA: 0x203047C
	private void StartBonusDamageAttack(BonusType type, int val, MobActionManagerBase mobAction) { }

	// RVA: 0x2030A08 Offset: 0x202CA08 VA: 0x2030A08
	public void SkillComboReflection(CharacterActionManagerBase targetActManager) { }

	// RVA: 0x2030B38 Offset: 0x202CB38 VA: 0x2030B38 Slot: 7
	protected override bool CheckInterruptable() { }

	// RVA: 0x2030C30 Offset: 0x202CC30 VA: 0x2030C30 Slot: 56
	public void CastingMagicEgelAttack(SkillActionBase action) { }

	// RVA: 0x2031410 Offset: 0x202D410 VA: 0x2031410
	public bool CounterMagicEgleAttack(CharacterActionManagerBase target, MagicEgelBuf magicEgelBuf) { }

	// RVA: 0x2028C78 Offset: 0x2024C78 VA: 0x2028C78 Slot: 57
	public void CheckMagicEgelAttackTarget(SkillActionBase action, CharacterActionManagerBase targetAction) { }

	// RVA: 0x202DF30 Offset: 0x2029F30 VA: 0x202DF30 Slot: 58
	public void MagicEgelAttack(SkillActionBase action) { }

	// RVA: 0x203162C Offset: 0x202D62C VA: 0x203162C
	public void PursuitImperialRayAttack(EnemyMobActionManagerBase targetActionManager, ElementType element, bool critical) { }

	// RVA: 0x20318D0 Offset: 0x202D8D0 VA: 0x20318D0
	public void PursuitJumpbackShotAttack(EnemyMobActionManagerBase targetActionManager) { }

	// RVA: 0x2031DF0 Offset: 0x202DDF0 VA: 0x2031DF0
	public bool StartHighFamiliaSkill(SkillActionBase action) { }

	// RVA: 0x2032438 Offset: 0x202E438 VA: 0x2032438
	public bool StartEnchantedSpellSkill(SkillActionBase action) { }

	// RVA: 0x20284F0 Offset: 0x20244F0 VA: 0x20284F0
	private bool IsPersuitAction(SkillActionBase action) { }

	// RVA: 0x2028E08 Offset: 0x2024E08 VA: 0x2028E08
	public void StartHolyBiblePursuitAttack(CharacterActionManagerBase targetActionManager, SkillActionBase action) { }

	// RVA: 0x2032D6C Offset: 0x202ED6C VA: 0x2032D6C
	public bool StartEarthStyleAttack(byte skillLocalId) { }

	// RVA: 0x202EB10 Offset: 0x202AB10 VA: 0x202EB10
	public bool StartMoonSlashPursuit(EnemyMobActionManagerBase mobAction) { }

	// RVA: 0x20335B8 Offset: 0x202F5B8 VA: 0x20335B8
	public bool StartMindimageSenju(SkillActionBase baseSkill) { }

	// RVA: 0x2033B5C Offset: 0x202FB5C VA: 0x2033B5C
	public bool InheritanceMindimageSenju() { }

	// RVA: 0x20291EC Offset: 0x20251EC VA: 0x20291EC
	public bool CheckAshuraAuraAttackStart(MobActionManagerBase mobAction, SkillActionBase action) { }

	// RVA: 0x20245DC Offset: 0x20205DC VA: 0x20245DC
	public bool CheckAshuraAuraAttackStop(SkillActionBase action) { }

	// RVA: 0x2033FDC Offset: 0x202FFDC VA: 0x2033FDC
	public bool StartAshuraAuraAttack(MobActionManagerBase mobActionManager) { }

	[IteratorStateMachine(typeof(PlayerBattleManager.<startAshuraAuraAttack>d__135))]
	// RVA: 0x20341D0 Offset: 0x20301D0 VA: 0x20341D0
	private IEnumerator startAshuraAuraAttack(AshuraAuraAttackAction action, byte sLv, MobActionManagerBase mobActionManager) { }

	// RVA: 0x2029308 Offset: 0x2025308 VA: 0x2029308
	public void StartMagicFinawPursuitAttack(CharacterActionManagerBase targetActionManager, SkillActionBase action) { }

	// RVA: 0x2034284 Offset: 0x2030284 VA: 0x2034284
	public void StartCounterForceAttack(GameObject actor, GameObject target, out SkillActionBase skill) { }

	// RVA: 0x2034440 Offset: 0x2030440 VA: 0x2034440
	public void StartAutoDeviceAttack(SkillBufferDataBase buf) { }

	// RVA: 0x2034A88 Offset: 0x2030A88 VA: 0x2034A88
	public bool StartAstralLanceAttack() { }

	// RVA: 0x2034CA0 Offset: 0x2030CA0 VA: 0x2034CA0
	public void StartLifeExplosionDamage(EnemyMobActionManagerBase enemyAction, byte lv, int chargeVal) { }

	// RVA: 0x2034E10 Offset: 0x2030E10 VA: 0x2034E10
	public bool StartBattleNotesAttack() { }

	// RVA: 0x2035124 Offset: 0x2031124 VA: 0x2035124
	public bool StartRangeHateAttack(CharacterActionManagerBase target) { }

	// RVA: 0x202DD90 Offset: 0x2029D90 VA: 0x202DD90
	private void BoomerangEndPreparation(SkillActionBase action) { }

	// RVA: 0x20267F0 Offset: 0x20227F0 VA: 0x20267F0
	private void TrapActionHit(GameObject target, SkillActionBase action) { }

	// RVA: 0x20352C8 Offset: 0x20312C8 VA: 0x20352C8
	public void StartDetectionDecoyShooter() { }

	// RVA: 0x2035534 Offset: 0x2031534 VA: 0x2035534
	public void StartCatsDropItem(PlayerAttackBase skill) { }

	// RVA: 0x20359D0 Offset: 0x20319D0 VA: 0x20359D0
	public void StartHolyGracePursuitAttack() { }

	[IteratorStateMachine(typeof(PlayerBattleManager.<HolyGracePursuitAttack>d__148))]
	// RVA: 0x20359F0 Offset: 0x20319F0 VA: 0x20359F0
	private IEnumerator HolyGracePursuitAttack() { }

	// RVA: 0x2035A64 Offset: 0x2031A64 VA: 0x2035A64
	public void StartLunaDitherStarBladeRain(LunaDitherStarAction parentSkill, Vector3 attackPos, Dictionary<MobActionManagerBase, int> targetExpList) { }

	// RVA: 0x2035DC0 Offset: 0x2031DC0 VA: 0x2035DC0
	public bool StartBlitzPikePursuit(byte level, Vector3 pos, ref bool firstHit) { }

	// RVA: 0x2024154 Offset: 0x2020154 VA: 0x2024154
	private bool OnSkillActionStartSummonSkeleton(SkillActionBase action) { }

	// RVA: 0x20363CC Offset: 0x20323CC VA: 0x20363CC
	public void HarvestSummonSkeleton() { }

	// RVA: 0x2036998 Offset: 0x2032998 VA: 0x2036998
	public void StartSummonSkeletonBomb(SkillActionBase baseSkill, CharacterActionManagerBase targetAction) { }

	// RVA: 0x2036FD4 Offset: 0x2032FD4 VA: 0x2036FD4
	private void PlaySummonSkeletonBombEffect(Vector3 pos, float angleY) { }

	// RVA: 0x203719C Offset: 0x203319C VA: 0x203719C
	public SlashReaperAction StartSlashReaper(byte level) { }

	// RVA: 0x20373A0 Offset: 0x20333A0 VA: 0x20373A0
	public SkillActionBase StartCrazyDaggerPursuit(byte level, MobActionManagerBase mobAction) { }

	// RVA: 0x203785C Offset: 0x203385C VA: 0x203785C
	public void .ctor() { }
}

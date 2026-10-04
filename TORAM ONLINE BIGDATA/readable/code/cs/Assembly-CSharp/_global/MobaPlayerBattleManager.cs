// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(PlayerSkillActionManager))]
public class MobaPlayerBattleManager : BattleManagerBase, IAvoidAction, IGuardAction, IMagicEgelBattleManager // TypeDefIndex: 1426
{
	// Fields
	private PlayerAnimation playerAnimation; // 0x78
	private MobaPlayerActionManager playerAction; // 0x80
	private SkillComboManager comboManager; // 0x88
	private Dictionary<KeyValuePair<SkillId, int>, KeyValuePair<ActionCode, int>> actionEndReconnection; // 0x90
	private Dictionary<KeyValuePair<SkillId, int>, KeyValuePair<ActionCode, int>> skillCancelReconnection; // 0x98
	private GuardActionManager guardManager; // 0xA0
	private AvoidActionManager avoidManager; // 0xA8
	private float guardNextAttackDelay; // 0xB0
	private const float GuardStrikeInterval = 0.5;
	private float guardStrikeCoolTime; // 0xB4
	private bool isMoveAssist; // 0xB8
	private bool isAssistMovingCheck; // 0xB9
	private float assistMoveTime; // 0xBC
	private GameObject assistTarget; // 0xC0
	protected CountUpIdManager localIdManager; // 0xC8
	private float attackDelay; // 0xD0
	private bool nextComboFlag; // 0xD4
	private MobaPlayerBattleManager.MobaVSState vsState; // 0xD8
	private IEnumerator activeWaitPutUpWeapon; // 0xE0

	// Properties
	public override GuardType GuardType { get; }
	public override AvoidType AvoidType { get; }
	public bool IsAvoid { get; }
	public bool IsGuard { get; }
	public AvoidActionManager AvoidManager { get; }
	public GuardActionManager GuardManager { get; }

	// Methods

	// RVA: 0x1FF908C Offset: 0x1FF508C VA: 0x1FF908C Slot: 4
	public override GuardType get_GuardType() { }

	// RVA: 0x1FF90E4 Offset: 0x1FF50E4 VA: 0x1FF90E4 Slot: 5
	public override AvoidType get_AvoidType() { }

	// RVA: 0x1FEF974 Offset: 0x1FEB974 VA: 0x1FEF974 Slot: 38
	public bool get_IsAvoid() { }

	// RVA: 0x1FED818 Offset: 0x1FE9818 VA: 0x1FED818 Slot: 47
	public bool get_IsGuard() { }

	// RVA: 0x1FF913C Offset: 0x1FF513C VA: 0x1FF913C Slot: 40
	public AvoidActionManager get_AvoidManager() { }

	// RVA: 0x1FF9144 Offset: 0x1FF5144 VA: 0x1FF9144 Slot: 49
	public GuardActionManager get_GuardManager() { }

	// RVA: 0x1FF914C Offset: 0x1FF514C VA: 0x1FF914C Slot: 6
	protected override void Awake() { }

	// RVA: 0x1FF9398 Offset: 0x1FF5398 VA: 0x1FF9398 Slot: 8
	public override void ActionUpdate() { }

	// RVA: 0x1FF9610 Offset: 0x1FF5610 VA: 0x1FF9610 Slot: 9
	protected override void OnInitialize() { }

	// RVA: 0x1FF9A24 Offset: 0x1FF5A24 VA: 0x1FF9A24 Slot: 10
	protected override void OnEnd() { }

	// RVA: 0x1FF9A38 Offset: 0x1FF5A38 VA: 0x1FF9A38 Slot: 11
	protected override void OnDead() { }

	// RVA: 0x1FF9B00 Offset: 0x1FF5B00 VA: 0x1FF9B00 Slot: 12
	protected override void OnRespawn(bool orbRespawn) { }

	// RVA: 0x1FF9BE4 Offset: 0x1FF5BE4 VA: 0x1FF9BE4 Slot: 15
	protected override void OnNextActionCancel() { }

	// RVA: 0x1FF9C58 Offset: 0x1FF5C58 VA: 0x1FF9C58 Slot: 37
	public override void ChangeStatus() { }

	// RVA: 0x1FF9D14 Offset: 0x1FF5D14 VA: 0x1FF9D14 Slot: 22
	protected override void OnBattleActive() { }

	// RVA: 0x1FF9F04 Offset: 0x1FF5F04 VA: 0x1FF9F04 Slot: 23
	protected override void OnBattleEnd() { }

	// RVA: 0x1FFA240 Offset: 0x1FF6240 VA: 0x1FFA240 Slot: 24
	public override void OnInputMove() { }

	// RVA: 0x1FFA3C8 Offset: 0x1FF63C8 VA: 0x1FFA3C8 Slot: 28
	protected override bool OnSkillActionStart(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1FFC780 Offset: 0x1FF8780 VA: 0x1FFC780
	protected bool CheckSkillStartAbnormalState(SkillActionBase action) { }

	// RVA: 0x1FFDF84 Offset: 0x1FF9F84 VA: 0x1FFDF84 Slot: 59
	protected virtual bool AbnormalFear(SkillActionBase action) { }

	// RVA: 0x1FFD248 Offset: 0x1FF9248 VA: 0x1FFD248
	public bool SkillPayHp(SkillActionBase action) { }

	// RVA: 0x1FFDCE4 Offset: 0x1FF9CE4 VA: 0x1FFDCE4
	private void StartSkillComboInvincibility(SkillActionBase action) { }

	// RVA: 0x1FFBE04 Offset: 0x1FF7E04 VA: 0x1FFBE04
	private void ConvertNinjutsuSkill(GameObject target, SkillActionBase action) { }

	// RVA: 0x1FFC0D4 Offset: 0x1FF80D4 VA: 0x1FFC0D4
	private bool CheckConvertRapidAqueVortex(SkillActionBase action) { }

	// RVA: 0x1FFC3B4 Offset: 0x1FF83B4 VA: 0x1FFC3B4
	private void ChronosShift(GameObject target, CharacterActionManagerBase targetActionManager, SkillActionBase action) { }

	// RVA: 0x1FFC5F8 Offset: 0x1FF85F8 VA: 0x1FFC5F8
	private bool TenjhoTengeMusouSword(GameObject target, CharacterActionManagerBase targetActionManager, SkillActionBase action) { }

	// RVA: 0x1FFE444 Offset: 0x1FFA444 VA: 0x1FFE444 Slot: 29
	protected override void OnSkillActionHit(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x1FFEDE8 Offset: 0x1FFADE8 VA: 0x1FFEDE8
	private void OnSkillActionHitToSupport(SkillActionBase action) { }

	// RVA: 0x20001A0 Offset: 0x1FFC1A0 VA: 0x20001A0 Slot: 30
	protected override void OnSkillActionDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action, SkillDamageData damageData) { }

	// RVA: 0x2001854 Offset: 0x1FFD854 VA: 0x2001854 Slot: 31
	protected override void OnSkillActionRangeDamaged(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x2000AE0 Offset: 0x1FFCAE0 VA: 0x2000AE0
	private void ConsumeBuffAttack(SkillActionBase action, SkillHitType hitType) { }

	// RVA: 0x20026D0 Offset: 0x1FFE6D0 VA: 0x20026D0 Slot: 35
	protected override void OnSkillActionSupport(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x20030A8 Offset: 0x1FFF0A8 VA: 0x20030A8 Slot: 32
	protected override void OnSkillActionEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x2003F5C Offset: 0x1FFFF5C VA: 0x2003F5C
	private void AddDelay(float delayTime) { }

	[IteratorStateMachine(typeof(MobaPlayerBattleManager.<FakeDamageDisp>d__59))]
	// RVA: 0x2003FFC Offset: 0x1FFFFFC VA: 0x2003FFC
	private IEnumerator FakeDamageDisp(SkillActionBase.DamageData damage, float wait, SkillActionBase action) { }

	// RVA: 0x20040B0 Offset: 0x20000B0 VA: 0x20040B0 Slot: 33
	protected override void OnSkillActionAllEnd(GameObject target, CharacterActionManagerBase targetActManager, SkillActionBase action) { }

	// RVA: 0x20051D0 Offset: 0x20011D0 VA: 0x20051D0 Slot: 34
	protected override void OnSkillActionCancel(GameObject target, SkillActionBase action) { }

	// RVA: 0x2005650 Offset: 0x2001650 VA: 0x2005650 Slot: 18
	public override void CheckBattleEnd() { }

	// RVA: 0x20056E8 Offset: 0x20016E8 VA: 0x20056E8
	public void SetMoveAssistFlag(bool flag) { }

	// RVA: 0x20056F4 Offset: 0x20016F4 VA: 0x20056F4
	public void SetAssistMoveTarget(GameObject target) { }

	// RVA: 0x1FF95FC Offset: 0x1FF55FC VA: 0x1FF95FC
	public void AssistMoveResetToEnemy() { }

	// RVA: 0x1FF9640 Offset: 0x1FF5640 VA: 0x1FF9640 Slot: 50
	public void InitializeGuard() { }

	// RVA: 0x2005720 Offset: 0x2001720 VA: 0x2005720 Slot: 51
	public bool CheckGuard(MobActionManagerBase mobAction, MobAttackBase action, int damage, out SkillHitReactionType guardType, out bool justGuard) { }

	// RVA: 0x1FEFA28 Offset: 0x1FEBA28 VA: 0x1FEFA28 Slot: 52
	public void GuardEnd(bool forceEnd) { }

	// RVA: 0x20057FC Offset: 0x20017FC VA: 0x20057FC Slot: 25
	public override void OnGuard(GameObject actor, SkillDamageData damageData) { }

	// RVA: 0x1FF86F0 Offset: 0x1FF46F0 VA: 0x1FF86F0
	public void OtherPlayerGuard(MobaOtherPlayer otherPlayer, MobaMobResponseData responseData, SkillHitReactionType reaction) { }

	// RVA: 0x2005A58 Offset: 0x2001A58 VA: 0x2005A58 Slot: 26
	public override int CalcGuard(int damage, out int guardPower) { }

	// RVA: 0x2005898 Offset: 0x2001898 VA: 0x2005898
	private void GuardStrikeAction(GameObject actor) { }

	// RVA: 0x2005B08 Offset: 0x2001B08 VA: 0x2005B08 Slot: 55
	public void GuardEndNextAttackDelay() { }

	// RVA: 0x1FF96C4 Offset: 0x1FF56C4 VA: 0x1FF96C4 Slot: 41
	public void InitializeAvoid() { }

	// RVA: 0x2005B1C Offset: 0x2001B1C VA: 0x2005B1C Slot: 42
	public bool CheckAvoid(MobActionManagerBase mobAction, MobAttackBase mobAttack) { }

	// RVA: 0x1FEF990 Offset: 0x1FEB990 VA: 0x1FEF990 Slot: 43
	public void AvoidEnd(bool forceEnd) { }

	// RVA: 0x2005BC0 Offset: 0x2001BC0 VA: 0x2005BC0 Slot: 27
	public override void OnAvoid(GameObject actor) { }

	// RVA: 0x1FFD2C4 Offset: 0x1FF92C4 VA: 0x1FFD2C4
	public void PlayPhiloEclair(PlayerActionManagerBase actorActionManager, GameObject target) { }

	// RVA: 0x2005C58 Offset: 0x2001C58 VA: 0x2005C58
	public void PlayShadowWalkAttack(PlayerActionManagerBase actorActionManager, GameObject target) { }

	// RVA: 0x1FF1C60 Offset: 0x1FEDC60 VA: 0x1FF1C60 Slot: 45
	public void DamagedAvoid(int damage) { }

	// RVA: 0x2005F70 Offset: 0x2001F70 VA: 0x2005F70 Slot: 46
	public void ReceiveAvoid(int param) { }

	// RVA: 0x2006008 Offset: 0x2002008 VA: 0x2006008 Slot: 36
	public override void ChangeField() { }

	// RVA: 0x1FF9748 Offset: 0x1FF5748 VA: 0x1FF9748
	private void ClearReconnection() { }

	// RVA: 0x2002EF4 Offset: 0x1FFEEF4 VA: 0x2002EF4
	public void AddReconnectionActionEnd(SkillActionBase action) { }

	// RVA: 0x20054B4 Offset: 0x20014B4 VA: 0x20054B4
	public void AddReconnectionActionCancel(SkillActionBase action) { }

	// RVA: 0x20060C4 Offset: 0x20020C4 VA: 0x20060C4
	public void ReceiveAttackEnd(SkillId skillId, int localId) { }

	// RVA: 0x2006204 Offset: 0x2002204 VA: 0x2006204
	public void ReceiveSkillCancel(SkillId skillId, int localId) { }

	// RVA: 0x1FF9550 Offset: 0x1FF5550 VA: 0x1FF9550
	private bool TargetToEnemy(MobActionManagerBase manager) { }

	// RVA: 0x2006344 Offset: 0x2002344 VA: 0x2006344 Slot: 21
	protected override bool OnEndAssistMove(GameObject target) { }

	// RVA: 0x2006370 Offset: 0x2002370 VA: 0x2006370 Slot: 19
	protected override bool OnActionRange(GameObject target, SkillActionBase action) { }

	// RVA: 0x20064A4 Offset: 0x20024A4 VA: 0x20064A4 Slot: 20
	protected override bool OnActionOutOfRange(GameObject target, SkillActionBase action) { }

	// RVA: 0x20065B0 Offset: 0x20025B0 VA: 0x20065B0
	private void checkAssistMove(GameObject target, SkillActionBase action) { }

	[IteratorStateMachine(typeof(MobaPlayerBattleManager.<ShukuchiMoveWait>d__93))]
	// RVA: 0x2006858 Offset: 0x2002858 VA: 0x2006858
	private IEnumerator ShukuchiMoveWait(GameObject target, SkillActionBase action) { }

	[IteratorStateMachine(typeof(MobaPlayerBattleManager.<AbnormalStopCheck>d__94))]
	// RVA: 0x20068FC Offset: 0x20028FC VA: 0x20068FC
	private IEnumerator AbnormalStopCheck(GameObject target, SkillActionBase action) { }

	[IteratorStateMachine(typeof(MobaPlayerBattleManager.<waitPutUpWeapon>d__96))]
	// RVA: 0x1FFA1CC Offset: 0x1FF61CC VA: 0x1FFA1CC
	private IEnumerator waitPutUpWeapon() { }

	[IteratorStateMachine(typeof(MobaPlayerBattleManager.<waitUnsheatheWeapon>d__97))]
	// RVA: 0x1FF9E90 Offset: 0x1FF5E90 VA: 0x1FF9E90
	private IEnumerator waitUnsheatheWeapon() { }

	// RVA: 0x20069A0 Offset: 0x20029A0 VA: 0x20069A0 Slot: 7
	protected override bool CheckInterruptable() { }

	// RVA: 0x2006A30 Offset: 0x2002A30 VA: 0x2006A30
	public void ReceiveSkillMotionEnd(SkillMotionEndResponseData response) { }

	// RVA: 0x2007464 Offset: 0x2003464 VA: 0x2007464
	public void MobaVSBattleStart() { }

	// RVA: 0x2007490 Offset: 0x2003490 VA: 0x2007490
	public void MobaVSBattleStop() { }

	// RVA: 0x20075A4 Offset: 0x20035A4 VA: 0x20075A4
	public void MobaVSBattleEnd() { }

	// RVA: 0x2006ED8 Offset: 0x2002ED8 VA: 0x2006ED8
	public void EquipBuffAttack(BonusType type, MobActionManagerBase mobAction) { }

	// RVA: 0x20075CC Offset: 0x20035CC VA: 0x20075CC
	public void BonusDamageAttack(Dictionary<BonusType, short> bonusList) { }

	// RVA: 0x2007868 Offset: 0x2003868 VA: 0x2007868
	private void StartBonusDamageAttack(BonusType type, int val, MobActionManagerBase mobAction) { }

	// RVA: 0x2007DF4 Offset: 0x2003DF4 VA: 0x2007DF4
	public void DamagerReflection(MobActionManagerBase actionManager) { }

	// RVA: 0x1FF18F8 Offset: 0x1FED8F8 VA: 0x1FF18F8
	public void SkillComboReflection(CharacterActionManagerBase targetActManager) { }

	// RVA: 0x2008060 Offset: 0x2004060 VA: 0x2008060
	public bool StartMindimageSenju(SkillActionBase baseSkill) { }

	// RVA: 0x2008604 Offset: 0x2004604 VA: 0x2008604
	public bool InheritanceMindimageSenju() { }

	// RVA: 0x20014D0 Offset: 0x1FFD4D0 VA: 0x20014D0
	public bool CheckAshuraAuraAttackStart(MobActionManagerBase mobAction, SkillActionBase action) { }

	// RVA: 0x1FFD0C4 Offset: 0x1FF90C4 VA: 0x1FFD0C4
	public bool CheckAshuraAuraAttackStop(SkillActionBase action) { }

	// RVA: 0x2008834 Offset: 0x2004834 VA: 0x2008834
	public bool StartAshuraAuraAttack(MobActionManagerBase mobActionManager) { }

	[IteratorStateMachine(typeof(MobaPlayerBattleManager.<startAshuraAuraAttack>d__113))]
	// RVA: 0x2008A28 Offset: 0x2004A28 VA: 0x2008A28
	private IEnumerator startAshuraAuraAttack(AshuraAuraAttackAction action, byte sLv, MobActionManagerBase mobActionManager) { }

	// RVA: 0x2008ADC Offset: 0x2004ADC VA: 0x2008ADC Slot: 56
	public void CastingMagicEgelAttack(SkillActionBase action) { }

	// RVA: 0x2000F5C Offset: 0x1FFCF5C VA: 0x2000F5C Slot: 57
	public void CheckMagicEgelAttackTarget(SkillActionBase action, CharacterActionManagerBase targetAction) { }

	// RVA: 0x2004450 Offset: 0x2000450 VA: 0x2004450 Slot: 58
	public void MagicEgelAttack(SkillActionBase action) { }

	// RVA: 0x20015EC Offset: 0x1FFD5EC VA: 0x20015EC
	public void StartMagicFinawPursuitAttack(CharacterActionManagerBase targetActionManager, SkillActionBase action) { }

	// RVA: 0x200924C Offset: 0x200524C VA: 0x200924C
	public void StartCounterForceAttack(GameObject actor, GameObject target, out SkillActionBase skill) { }

	// RVA: 0x1FEC450 Offset: 0x1FE8450 VA: 0x1FEC450
	public void StartAutoDeviceAttack(SkillBufferDataBase buf) { }

	// RVA: 0x2009408 Offset: 0x2005408 VA: 0x2009408
	public bool StartAstralLanceAttack() { }

	// RVA: 0x2009620 Offset: 0x2005620 VA: 0x2009620
	public void PursuitImperialRayAttack(EnemyMobActionManagerBase targetActionManager, ElementType element, bool critical) { }

	// RVA: 0x20098BC Offset: 0x20058BC VA: 0x20098BC
	public void PursuitJumpbackShotAttack(EnemyMobActionManagerBase targetActionManager) { }

	// RVA: 0x2009DDC Offset: 0x2005DDC VA: 0x2009DDC
	public bool StartHighFamiliaSkill(SkillActionBase action) { }

	// RVA: 0x200A424 Offset: 0x2006424 VA: 0x200A424
	public bool StartEnchantedSpellSkill(SkillActionBase action) { }

	// RVA: 0x20010EC Offset: 0x1FFD0EC VA: 0x20010EC
	public void StartHolyBiblePursuitAttack(CharacterActionManagerBase targetActionManager, SkillActionBase action) { }

	// RVA: 0x200AD58 Offset: 0x2006D58 VA: 0x200AD58
	public bool StartEarthStyleAttack(byte skillLocalId) { }

	// RVA: 0x2004E78 Offset: 0x2000E78 VA: 0x2004E78
	public bool StartMoonSlashPursuit(EnemyMobActionManagerBase mobAction) { }

	// RVA: 0x1FFF9B0 Offset: 0x1FFB9B0 VA: 0x1FFF9B0
	private void TrapActionHit(GameObject target, SkillActionBase action) { }

	// RVA: 0x200B5A4 Offset: 0x20075A4 VA: 0x200B5A4
	public void StartDetectionDecoyShooter() { }

	// RVA: 0x200B810 Offset: 0x2007810 VA: 0x200B810
	public bool StartBlitzPikePursuit(byte level, Vector3 pos, ref bool firstHit) { }

	// RVA: 0x1FFCB24 Offset: 0x1FF8B24 VA: 0x1FFCB24
	private bool OnSkillActionStartSummonSkeleton(SkillActionBase action) { }

	// RVA: 0x200BE10 Offset: 0x2007E10 VA: 0x200BE10
	public void .ctor() { }
}

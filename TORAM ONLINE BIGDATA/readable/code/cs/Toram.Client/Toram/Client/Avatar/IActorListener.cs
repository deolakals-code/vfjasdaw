// Assembly: Toram.Client.dll
// Namespace: Toram.Client.Avatar
public interface IActorListener // TypeDefIndex: 15150
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnLevelUp(LevelupEvent response);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnSetEquip(EquipEventData response);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnDeadEquipCheck(EquipEventData response);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnSetProperties(ArchetypeSetProperties response);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnGetProperties(ArchetypeGetProperties response);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnChangeState(ArchetypeChangeState response);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnMonsterFollowersPop(MonsterFollowersPop response);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void OnAbnormalStateEnd(AbnormalStateEndEvent abnormalStateEndEvent);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnAddAbnormalState(AddAbnormalStateEvent addAbnormalStateEvent);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnStopMove(StopMoveEvent response);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnWarpPosition(WarpPositionEvent warpPositon);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OnSkillBuffEnd(SkillBuffEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void OnUpdateGameStatus(UpdateGameStatusEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnActionMove(IMoveData eventData);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void OnActionAttackStart(AttackStartEventData eventData);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnActionAttack(AttackEventData eventData);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnActionSupportStart(SupportStartEventData eventData);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void OnActionSkillCancel(SkillCancelData cancelData);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void OnActionBattleEndCheck(BattleEndCheckData eventData);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void OnActionMobCreate(MobResponseData eventData);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void OnActionMobRelease(MobIdData eventData);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void OnActionMobMove(MobMoveEventData eventData);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void OnActionMobActionStart(MobActionStartEventData eventData);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void OnActionMobAttack(MobAttackEventData eventData);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void OnActionMobAttackToMob(MobAttackToMobEventData eventData);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void OnActionMobSupport(MobAttackEventData eventData);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void OnActionMobActionCancel(MobCancelData cancelData);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void OnActionMobCheck(MobIdData checkData);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void OnActionMoodMessage(MoodMessageData eventData);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void OnActionEmotion(EmotionData eventData);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void OnActionEventAbnormal(EventAbnormalData eventAbnormalData);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void OnActionEventMonsterDamage(EventMonsterDamageEventData eventMonsterDamageData);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void OnActionHousePetMove(PetMoveEventData eventData);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void OnActionSkillEvent(SkillEventData eventData);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void OnActionSkillSummons(SkillSummonsEventData eventData);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void OnActionSkillSummonsRemove(SkillSummonsRemoveEventData eventData);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract void OnActionMobEmergencyMove(MobEmergencyMoveEventData eventData);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void OnActionMobEventAttack(MobEventAttackEventData eventData);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void OnActionGuardAndAvoid(GuardAndAvoidData eventData);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract void OnActionSummerThrow(SummerThrowData throwData);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract void OnActionSummerFishAttack(MobAttackEventData attackData);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract void OnActionSnowballFightThrow(SnowballFightThrowData eventData);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract void OnActionSnowballFightReload(SnowballFightReloadData eventData);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void OnActionSnowballFightDodge(SnowballFightDodgeData eventData);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract void OnActionSnowballFightAttack(SnowballFightAttackData eventData);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract void OnActionSnowballFightSkillAttack(SnowballFightSkillAttackData eventData);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract void OnActionSnowballFightDamage(SnowballFightDamageData eventData);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract void OnActionSnowballFightDead(SnowballFightDeadData eventData);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract void OnActionSnowballFightResurrection(SnowballFightResurrectionData eventData);

	// RVA: -1 Offset: -1 Slot: 49
	public abstract void OnActionSnowballFightGetItem(SnowballFightGetItemData eventData);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract void OnActionSnowballFightUseItem(SnowballFightUseItemData eventData);
}

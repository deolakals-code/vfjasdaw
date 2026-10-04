// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaOtherPlayer : ModelObjectBase, IActorListener, IMobaTreasureEquip // TypeDefIndex: 1219
{
	// Fields
	private Archetype archetype; // 0x80
	private FadeAnimationManager fadeAnimationManager; // 0x88
	private OtherPlayerSkillActionPlayer skillPlayer; // 0x90
	private PlayerDataManager playerDataManager; // 0x98
	private MobaPropertiesData mobaPropertiesData; // 0xA0
	private int state; // 0xA8
	private bool isInitialized; // 0xAC
	private byte[] supplyEquipLevel; // 0xB0
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0xB8

	// Properties
	private MobaOtherPlayerActionManager ActionManager { get; }
	public bool IsValid { get; set; }
	public bool IsInitialized { get; }
	public bool IsGhost { get; }
	public override bool IsHideUser { get; }
	public override bool IsPartyMember { get; }
	public bool IsFirstAidTarget { get; }
	public byte TreasureEquipLevel { get; }
	public byte TreasureLevel { get; }

	// Methods

	// RVA: 0x1F89A64 Offset: 0x1F85A64 VA: 0x1F89A64
	public static MobaOtherPlayer CreatePlayer(Archetype archetype, MobaPropertiesData mobaPropertiesData) { }

	// RVA: 0x1F89DC8 Offset: 0x1F85DC8 VA: 0x1F89DC8
	private MobaOtherPlayerActionManager get_ActionManager() { }

	[CompilerGenerated]
	// RVA: 0x1F89E40 Offset: 0x1F85E40 VA: 0x1F89E40
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x1F89E48 Offset: 0x1F85E48 VA: 0x1F89E48
	private void set_IsValid(bool value) { }

	// RVA: 0x1F89E54 Offset: 0x1F85E54 VA: 0x1F89E54
	public bool get_IsInitialized() { }

	// RVA: 0x1F89E5C Offset: 0x1F85E5C VA: 0x1F89E5C
	public bool get_IsGhost() { }

	// RVA: 0x1F89E6C Offset: 0x1F85E6C VA: 0x1F89E6C Slot: 19
	public override bool get_IsHideUser() { }

	// RVA: 0x1F89E78 Offset: 0x1F85E78 VA: 0x1F89E78 Slot: 12
	public override bool get_IsPartyMember() { }

	// RVA: 0x1F89F0C Offset: 0x1F85F0C VA: 0x1F89F0C
	public bool get_IsFirstAidTarget() { }

	// RVA: 0x1F89F14 Offset: 0x1F85F14 VA: 0x1F89F14 Slot: 89
	public byte get_TreasureEquipLevel() { }

	// RVA: 0x1F89F70 Offset: 0x1F85F70 VA: 0x1F89F70 Slot: 90
	public byte get_TreasureLevel() { }

	// RVA: 0x1F89F78 Offset: 0x1F85F78 VA: 0x1F89F78
	public void Invalidation() { }

	// RVA: 0x1F89F80 Offset: 0x1F85F80 VA: 0x1F89F80
	public void Validation() { }

	// RVA: 0x1F89CC0 Offset: 0x1F85CC0 VA: 0x1F89CC0
	public void Initialize(Archetype archetype, MobaPropertiesData mobaPropertiesData) { }

	// RVA: 0x1F89F8C Offset: 0x1F85F8C VA: 0x1F89F8C
	public void UpdateArchetype(Archetype archetype) { }

	// RVA: 0x1F8A090 Offset: 0x1F86090 VA: 0x1F8A090
	public void Destroy() { }

	// RVA: 0x1F8A16C Offset: 0x1F8616C VA: 0x1F8A16C
	public void FadeoutToDestroy() { }

	// RVA: 0x1F8A414 Offset: 0x1F86414 VA: 0x1F8A414
	public void CancelFadeout() { }

	// RVA: 0x1F8A518 Offset: 0x1F86518 VA: 0x1F8A518
	public void SetRenderSetting(bool isRender, float fade) { }

	// RVA: 0x1F8A620 Offset: 0x1F86620 VA: 0x1F8A620
	public void SetBattleStart() { }

	// RVA: 0x1F8A624 Offset: 0x1F86624 VA: 0x1F8A624
	public void SetBattleEnd() { }

	// RVA: 0x1F8A648 Offset: 0x1F86648 VA: 0x1F8A648
	public void UpdateEquip(Dictionary<byte, object> equipProperties, int propertiesRevision) { }

	// RVA: 0x1F8A8AC Offset: 0x1F868AC VA: 0x1F8A8AC
	public bool CheckResurrection() { }

	// RVA: 0x1F8A8B4 Offset: 0x1F868B4 VA: 0x1F8A8B4
	public void ReceiveMobaDuelAbilityTrample(short[] removeSkillId) { }

	// RVA: 0x1F8A9E8 Offset: 0x1F869E8 VA: 0x1F8A9E8 Slot: 33
	protected override bool OnPropertyUpdateStart() { }

	// RVA: 0x1F8A9F0 Offset: 0x1F869F0 VA: 0x1F8A9F0 Slot: 36
	protected override void OnPropertyUpdateEnd() { }

	// RVA: 0x1F8AE38 Offset: 0x1F86E38 VA: 0x1F8AE38
	private void OnDestroy() { }

	// RVA: 0x1F8AC80 Offset: 0x1F86C80 VA: 0x1F8AC80
	private void setInvisible(bool isInvisible) { }

	// RVA: 0x1F8A56C Offset: 0x1F8656C VA: 0x1F8A56C
	private NewArchetypeProperties getProperties() { }

	// RVA: 0x1F8A6C8 Offset: 0x1F866C8 VA: 0x1F8A6C8
	private void updaetSupplyEquipData(Dictionary<byte, object> equipProperties) { }

	[IteratorStateMachine(typeof(MobaOtherPlayer.<VsModeRespawn>d__48))]
	// RVA: 0x1F8AF04 Offset: 0x1F86F04 VA: 0x1F8AF04
	private IEnumerator VsModeRespawn() { }

	// RVA: 0x1F8AF98 Offset: 0x1F86F98 VA: 0x1F8AF98
	public void ReceiveActionEvent(ArchetypeActionEvent actionEvent) { }

	// RVA: 0x1F8AFAC Offset: 0x1F86FAC VA: 0x1F8AFAC Slot: 42
	public void OnGetProperties(ArchetypeGetProperties response) { }

	// RVA: 0x1F8B158 Offset: 0x1F87158 VA: 0x1F8B158 Slot: 38
	public void OnLevelUp(LevelupEvent response) { }

	// RVA: 0x1F8B15C Offset: 0x1F8715C VA: 0x1F8B15C Slot: 39
	public void OnSetEquip(EquipEventData response) { }

	// RVA: 0x1F8B1FC Offset: 0x1F871FC VA: 0x1F8B1FC Slot: 40
	public void OnDeadEquipCheck(EquipEventData response) { }

	// RVA: 0x1F8B23C Offset: 0x1F8723C VA: 0x1F8B23C Slot: 43
	public void OnChangeState(ArchetypeChangeState response) { }

	// RVA: 0x1F8B5A8 Offset: 0x1F875A8 VA: 0x1F8B5A8 Slot: 51
	public void OnActionMove(IMoveData eventData) { }

	// RVA: 0x1F8BD18 Offset: 0x1F87D18 VA: 0x1F8BD18 Slot: 52
	public void OnActionAttackStart(AttackStartEventData eventData) { }

	// RVA: 0x1F8C458 Offset: 0x1F88458 VA: 0x1F8C458 Slot: 53
	public void OnActionAttack(AttackEventData eventData) { }

	// RVA: 0x1F8C8FC Offset: 0x1F888FC VA: 0x1F8C8FC Slot: 54
	public void OnActionSupportStart(SupportStartEventData eventData) { }

	// RVA: 0x1F8CED8 Offset: 0x1F88ED8 VA: 0x1F8CED8 Slot: 55
	public void OnActionSkillCancel(SkillCancelData cancelData) { }

	// RVA: 0x1F8D38C Offset: 0x1F8938C VA: 0x1F8D38C Slot: 67
	public void OnActionEmotion(EmotionData eventData) { }

	// RVA: 0x1F8D9A8 Offset: 0x1F899A8 VA: 0x1F8D9A8 Slot: 68
	public void OnActionEventAbnormal(EventAbnormalData eventData) { }

	// RVA: 0x1F8D9AC Offset: 0x1F899AC VA: 0x1F8D9AC Slot: 57
	public void OnActionMobCreate(MobResponseData mobData) { }

	// RVA: 0x1F8D9B0 Offset: 0x1F899B0 VA: 0x1F8D9B0 Slot: 59
	public void OnActionMobMove(MobMoveEventData eventData) { }

	// RVA: 0x1F8DA08 Offset: 0x1F89A08 VA: 0x1F8DA08 Slot: 60
	public void OnActionMobActionStart(MobActionStartEventData eventData) { }

	// RVA: 0x1F8DAA0 Offset: 0x1F89AA0 VA: 0x1F8DAA0 Slot: 61
	public void OnActionMobAttack(MobAttackEventData eventData) { }

	// RVA: 0x1F8DC8C Offset: 0x1F89C8C VA: 0x1F8DC8C Slot: 62
	public void OnActionMobAttackToMob(MobAttackToMobEventData eventData) { }

	// RVA: 0x1F8DC90 Offset: 0x1F89C90 VA: 0x1F8DC90 Slot: 63
	public void OnActionMobSupport(MobAttackEventData eventData) { }

	// RVA: 0x1F8DC94 Offset: 0x1F89C94 VA: 0x1F8DC94 Slot: 64
	public void OnActionMobActionCancel(MobCancelData cancelData) { }

	// RVA: 0x1F8DC98 Offset: 0x1F89C98 VA: 0x1F8DC98 Slot: 58
	public void OnActionMobRelease(MobIdData eventData) { }

	// RVA: 0x1F8DC9C Offset: 0x1F89C9C VA: 0x1F8DC9C Slot: 65
	public void OnActionMobCheck(MobIdData checkData) { }

	// RVA: 0x1F8DCF4 Offset: 0x1F89CF4 VA: 0x1F8DCF4 Slot: 44
	public void OnMonsterFollowersPop(MonsterFollowersPop response) { }

	// RVA: 0x1F8DD74 Offset: 0x1F89D74 VA: 0x1F8DD74 Slot: 41
	public void OnSetProperties(ArchetypeSetProperties response) { }

	// RVA: 0x1F8DDD8 Offset: 0x1F89DD8 VA: 0x1F8DDD8 Slot: 45
	public void OnAbnormalStateEnd(AbnormalStateEndEvent abnormalStateEndEvent) { }

	// RVA: 0x1F8DE7C Offset: 0x1F89E7C VA: 0x1F8DE7C Slot: 46
	public void OnAddAbnormalState(AddAbnormalStateEvent addAbnormalStateEvent) { }

	// RVA: 0x1F8E258 Offset: 0x1F8A258 VA: 0x1F8E258 Slot: 70
	public void OnActionHousePetMove(PetMoveEventData eventData) { }

	// RVA: 0x1F8E25C Offset: 0x1F8A25C VA: 0x1F8E25C Slot: 56
	public void OnActionBattleEndCheck(BattleEndCheckData eventData) { }

	// RVA: 0x1F8E260 Offset: 0x1F8A260 VA: 0x1F8E260 Slot: 71
	public void OnActionSkillEvent(SkillEventData eventData) { }

	// RVA: 0x1F8EEF4 Offset: 0x1F8AEF4 VA: 0x1F8EEF4 Slot: 76
	public void OnActionGuardAndAvoid(GuardAndAvoidData eventData) { }

	// RVA: 0x1F8F85C Offset: 0x1F8B85C VA: 0x1F8F85C Slot: 66
	public void OnActionMoodMessage(MoodMessageData eventData) { }

	// RVA: 0x1F8F860 Offset: 0x1F8B860 VA: 0x1F8F860 Slot: 79
	public void OnActionSnowballFightThrow(SnowballFightThrowData eventData) { }

	// RVA: 0x1F8F864 Offset: 0x1F8B864 VA: 0x1F8F864 Slot: 80
	public void OnActionSnowballFightReload(SnowballFightReloadData eventData) { }

	// RVA: 0x1F8F868 Offset: 0x1F8B868 VA: 0x1F8F868
	public void OnActionSnowballFightReload(int uuid, short eventReloadTime) { }

	// RVA: 0x1F8F86C Offset: 0x1F8B86C VA: 0x1F8F86C Slot: 81
	public void OnActionSnowballFightDodge(SnowballFightDodgeData eventData) { }

	// RVA: 0x1F8F870 Offset: 0x1F8B870 VA: 0x1F8F870 Slot: 82
	public void OnActionSnowballFightAttack(SnowballFightAttackData eventData) { }

	// RVA: 0x1F8F874 Offset: 0x1F8B874 VA: 0x1F8F874 Slot: 83
	public void OnActionSnowballFightSkillAttack(SnowballFightSkillAttackData eventData) { }

	// RVA: 0x1F8F878 Offset: 0x1F8B878 VA: 0x1F8F878 Slot: 84
	public void OnActionSnowballFightDamage(SnowballFightDamageData eventData) { }

	// RVA: 0x1F8F87C Offset: 0x1F8B87C VA: 0x1F8F87C Slot: 85
	public void OnActionSnowballFightDead(SnowballFightDeadData eventData) { }

	// RVA: 0x1F8F880 Offset: 0x1F8B880 VA: 0x1F8F880 Slot: 86
	public void OnActionSnowballFightResurrection(SnowballFightResurrectionData eventData) { }

	// RVA: 0x1F8F884 Offset: 0x1F8B884 VA: 0x1F8F884 Slot: 77
	public void OnActionSummerThrow(SummerThrowData throwData) { }

	// RVA: 0x1F8F888 Offset: 0x1F8B888 VA: 0x1F8F888 Slot: 78
	public void OnActionSummerFishAttack(MobAttackEventData attackData) { }

	// RVA: 0x1F8F88C Offset: 0x1F8B88C VA: 0x1F8F88C Slot: 47
	public void OnStopMove(StopMoveEvent response) { }

	// RVA: 0x1F8F890 Offset: 0x1F8B890 VA: 0x1F8F890 Slot: 48
	public void OnWarpPosition(WarpPositionEvent warpPositon) { }

	// RVA: 0x1F8F894 Offset: 0x1F8B894 VA: 0x1F8F894 Slot: 72
	public void OnActionSkillSummons(SkillSummonsEventData eventData) { }

	// RVA: 0x1F8F898 Offset: 0x1F8B898 VA: 0x1F8F898 Slot: 73
	public void OnActionSkillSummonsRemove(SkillSummonsRemoveEventData eventData) { }

	// RVA: 0x1F8F89C Offset: 0x1F8B89C VA: 0x1F8F89C Slot: 74
	public void OnActionMobEmergencyMove(MobEmergencyMoveEventData eventData) { }

	// RVA: 0x1F8F8A0 Offset: 0x1F8B8A0 VA: 0x1F8F8A0 Slot: 49
	public void OnSkillBuffEnd(SkillBuffEndEvent endEvent) { }

	// RVA: 0x1F8F8A4 Offset: 0x1F8B8A4 VA: 0x1F8F8A4 Slot: 87
	public void OnActionSnowballFightGetItem(SnowballFightGetItemData eventData) { }

	// RVA: 0x1F8F8A8 Offset: 0x1F8B8A8 VA: 0x1F8F8A8 Slot: 88
	public void OnActionSnowballFightUseItem(SnowballFightUseItemData eventData) { }

	// RVA: 0x1F8F8AC Offset: 0x1F8B8AC VA: 0x1F8F8AC Slot: 75
	public void OnActionMobEventAttack(MobEventAttackEventData eventData) { }

	// RVA: 0x1F8F8B0 Offset: 0x1F8B8B0 VA: 0x1F8F8B0 Slot: 50
	public void OnUpdateGameStatus(UpdateGameStatusEvent updateEvent) { }

	// RVA: 0x1F8F8B4 Offset: 0x1F8B8B4 VA: 0x1F8F8B4 Slot: 69
	public void OnActionEventMonsterDamage(EventMonsterDamageEventData eventMonsterDamageData) { }

	// RVA: 0x1F8F8B8 Offset: 0x1F8B8B8 VA: 0x1F8F8B8
	public void .ctor() { }

	// RVA: 0x1F8F91C Offset: 0x1F8B91C VA: 0x1F8F91C Slot: 91
	private Transform IMobaTreasureEquip.get_transform() { }
}

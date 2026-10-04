// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OtherPlayer : PlayerObjectBase, IActorListener // TypeDefIndex: 1243
{
	// Fields
	private Archetype archetype; // 0x90
	private Game game; // 0x98
	private byte firstEmotionType; // 0xA0
	private byte firstEmotionId; // 0xA1
	private bool isRenderEnabled; // 0xA2
	private short skinModelMergeCount; // 0xA4
	private short renderCountTimer; // 0xA6
	private List<IMobIdData> ManageEnemyIdList; // 0xA8
	private string moodMessage; // 0xB0
	private int ngCheckCount; // 0xB8
	private int voiceChannel; // 0xBC
	private float revivalTime; // 0xC0
	private BoxCollider snowballCol; // 0xC8
	private SnowballColorShadow snowballShadow; // 0xD0
	private FadeAnimationManager fadeAnimationManager; // 0xD8
	private OtherPlayerSkillActionPlayer skillPlayer; // 0xE0
	private PlayerDataManager playerDataManager; // 0xE8
	[CompilerGenerated]
	private bool <IsFirstAidTarget>k__BackingField; // 0xF0
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0xF1
	private bool isInitialized; // 0xF2
	private string moodGuildName; // 0xF8
	private bool isFriend; // 0x100

	// Properties
	private OtherPlayerActionManager actionManager { get; }
	public bool IsFirstAidTarget { get; set; }
	public override Archetype Archetype { get; }
	public bool IsValid { get; set; }
	public bool IsInitialized { get; }
	public override bool IsPartyMember { get; }
	public override bool IsGuildMember { get; }
	public bool IsGuildFree { get; }
	public bool IsGuildAllianceInvitationt { get; }
	public override string GuildName { get; }
	public override string MoodMessage { get; }
	public override bool IsFriend { get; }
	public override bool IsGhost { get; }
	public bool IsInvisible { get; }
	public override bool IsHideUser { get; }
	public override bool IsGMEventPlayer { get; }
	public override bool IsRenderEnabled { get; }
	public bool IsServerMobCreate { get; }
	public SnowballColorShadow SnowballShadow { get; }

	// Methods

	// RVA: 0x1F93EBC Offset: 0x1F8FEBC VA: 0x1F93EBC
	public static OtherPlayer CreatePlayer(byte type, int id, string name) { }

	// RVA: 0x1F9430C Offset: 0x1F9030C VA: 0x1F9430C
	private OtherPlayerActionManager get_actionManager() { }

	[CompilerGenerated]
	// RVA: 0x1F9438C Offset: 0x1F9038C VA: 0x1F9438C
	public bool get_IsFirstAidTarget() { }

	[CompilerGenerated]
	// RVA: 0x1F94394 Offset: 0x1F90394 VA: 0x1F94394
	private void set_IsFirstAidTarget(bool value) { }

	// RVA: 0x1F943A0 Offset: 0x1F903A0 VA: 0x1F943A0 Slot: 11
	public override Archetype get_Archetype() { }

	[CompilerGenerated]
	// RVA: 0x1F943A8 Offset: 0x1F903A8 VA: 0x1F943A8
	public bool get_IsValid() { }

	[CompilerGenerated]
	// RVA: 0x1F943B0 Offset: 0x1F903B0 VA: 0x1F943B0
	private void set_IsValid(bool value) { }

	// RVA: 0x1F943BC Offset: 0x1F903BC VA: 0x1F943BC
	public bool get_IsInitialized() { }

	// RVA: 0x1F943C4 Offset: 0x1F903C4 VA: 0x1F943C4 Slot: 12
	public override bool get_IsPartyMember() { }

	// RVA: 0x1F9445C Offset: 0x1F9045C VA: 0x1F9445C Slot: 13
	public override bool get_IsGuildMember() { }

	// RVA: 0x1F9456C Offset: 0x1F9056C VA: 0x1F9456C
	public bool get_IsGuildFree() { }

	// RVA: 0x1F94590 Offset: 0x1F90590 VA: 0x1F94590
	public bool get_IsGuildAllianceInvitationt() { }

	// RVA: 0x1F945B8 Offset: 0x1F905B8 VA: 0x1F945B8 Slot: 21
	public override string get_GuildName() { }

	// RVA: 0x1F9464C Offset: 0x1F9064C VA: 0x1F9464C Slot: 20
	public override string get_MoodMessage() { }

	// RVA: 0x1F94654 Offset: 0x1F90654 VA: 0x1F94654 Slot: 14
	public override bool get_IsFriend() { }

	// RVA: 0x1F946F4 Offset: 0x1F906F4 VA: 0x1F946F4 Slot: 38
	public override bool get_IsGhost() { }

	// RVA: 0x1F9479C Offset: 0x1F9079C VA: 0x1F9479C
	public bool get_IsInvisible() { }

	// RVA: 0x1F947C4 Offset: 0x1F907C4 VA: 0x1F947C4 Slot: 19
	public override bool get_IsHideUser() { }

	// RVA: 0x1F948C0 Offset: 0x1F908C0 VA: 0x1F948C0 Slot: 18
	public override bool get_IsGMEventPlayer() { }

	// RVA: 0x1F948E8 Offset: 0x1F908E8 VA: 0x1F948E8 Slot: 15
	public override bool get_IsRenderEnabled() { }

	// RVA: 0x1F948F0 Offset: 0x1F908F0 VA: 0x1F948F0
	public bool get_IsServerMobCreate() { }

	// RVA: 0x1F949A0 Offset: 0x1F909A0 VA: 0x1F949A0
	public SnowballColorShadow get_SnowballShadow() { }

	// RVA: 0x1F949A8 Offset: 0x1F909A8 VA: 0x1F949A8
	private void Update() { }

	// RVA: 0x1F949AC Offset: 0x1F909AC VA: 0x1F949AC
	public void Invalidation() { }

	// RVA: 0x1F949B4 Offset: 0x1F909B4 VA: 0x1F949B4
	public void Validation() { }

	// RVA: 0x1F949C0 Offset: 0x1F909C0 VA: 0x1F949C0
	public void Initialize(Game game, Archetype archetype) { }

	// RVA: 0x1F94AE0 Offset: 0x1F90AE0 VA: 0x1F94AE0
	public void Destroy() { }

	// RVA: 0x1F94E80 Offset: 0x1F90E80 VA: 0x1F94E80
	public void FadeoutToDestroy(Action fadeoutCallback) { }

	// RVA: 0x1F95174 Offset: 0x1F91174 VA: 0x1F95174
	public void CancelFadeout() { }

	// RVA: 0x1F9527C Offset: 0x1F9127C VA: 0x1F9527C
	public void AddManagedEnemyId(IMobIdData enemyId) { }

	// RVA: 0x1F95328 Offset: 0x1F91328 VA: 0x1F95328
	public void RemoveManagedEnemyId(IMobIdData enemyId) { }

	// RVA: 0x1F95510 Offset: 0x1F91510 VA: 0x1F95510
	public IEnumerable<IMobIdData> GetManagedMobIdDatas() { }

	// RVA: 0x1F95518 Offset: 0x1F91518 VA: 0x1F95518
	public void SetRenderSetting(bool isRender, float fade) { }

	// RVA: 0x1F9583C Offset: 0x1F9183C VA: 0x1F9583C
	public void SetBattleStart() { }

	// RVA: 0x1F954EC Offset: 0x1F914EC VA: 0x1F954EC
	public void SetBattleEnd() { }

	// RVA: 0x1F95840 Offset: 0x1F91840 VA: 0x1F95840
	public void SetAutoMemberAnimation() { }

	// RVA: 0x1F95910 Offset: 0x1F91910 VA: 0x1F95910
	public void RemoveSummons(byte type, int id) { }

	// RVA: 0x1F95958 Offset: 0x1F91958 VA: 0x1F95958
	public void SetRevivalTime(float time) { }

	// RVA: 0x1F95960 Offset: 0x1F91960 VA: 0x1F95960
	public bool CheckResurrection() { }

	// RVA: 0x1F95A04 Offset: 0x1F91A04 VA: 0x1F95A04 Slot: 29
	public override GameObject CloneModelObject() { }

	// RVA: 0x1F96004 Offset: 0x1F92004 VA: 0x1F96004
	public void OnEventFishingSuccess(int fishId, int size) { }

	// RVA: 0x1F960AC Offset: 0x1F920AC VA: 0x1F960AC Slot: 35
	protected override void UpdateModelProperty(NewArchetypeProperties property) { }

	// RVA: 0x1F96614 Offset: 0x1F92614 VA: 0x1F96614 Slot: 33
	protected override bool OnPropertyUpdateStart() { }

	// RVA: 0x1F9672C Offset: 0x1F9272C VA: 0x1F9672C Slot: 36
	protected override void OnPropertyUpdateEnd() { }

	// RVA: 0x1F96F74 Offset: 0x1F92F74 VA: 0x1F96F74 Slot: 41
	protected override byte[] GetSignboardBinary() { }

	[IteratorStateMachine(typeof(OtherPlayer.<delayInitEmotionSet>d__86))]
	// RVA: 0x1F96F00 Offset: 0x1F92F00 VA: 0x1F96F00
	private IEnumerator delayInitEmotionSet() { }

	// RVA: 0x1F94284 Offset: 0x1F90284 VA: 0x1F94284
	private void ChangeSnowballColSize(bool isReload) { }

	[IteratorStateMachine(typeof(OtherPlayer.<petAnimationChange>d__88))]
	// RVA: 0x1F96FA4 Offset: 0x1F92FA4 VA: 0x1F96FA4
	private IEnumerator petAnimationChange(Animation baseAnim, Action callback) { }

	[IteratorStateMachine(typeof(OtherPlayer.<familiaAnimationChange>d__89))]
	// RVA: 0x1F97048 Offset: 0x1F93048 VA: 0x1F97048
	private IEnumerator familiaAnimationChange(FamiliaOtherData otherData, Animation baseAnim, Action callback) { }

	[IteratorStateMachine(typeof(OtherPlayer.<huntingOneAnimationChange>d__90))]
	// RVA: 0x1F97108 Offset: 0x1F93108 VA: 0x1F97108
	private IEnumerator huntingOneAnimationChange(HuntingOneOtherData otherData, Animation baseAnim, Action callback) { }

	[IteratorStateMachine(typeof(OtherPlayer.<summonDemonicAnimationChange>d__91))]
	// RVA: 0x1F971C8 Offset: 0x1F931C8 VA: 0x1F971C8
	private IEnumerator summonDemonicAnimationChange(SummonDemonicOtherData otherData, Animation baseAnim, Action callback) { }

	[IteratorStateMachine(typeof(OtherPlayer.<callGolemAnimationChange>d__92))]
	// RVA: 0x1F97288 Offset: 0x1F93288 VA: 0x1F97288
	private IEnumerator callGolemAnimationChange(CallGolemOtherData otherData, Animation baseAnim, Action callback) { }

	[IteratorStateMachine(typeof(OtherPlayer.<animationChange>d__93))]
	// RVA: 0x1F97348 Offset: 0x1F93348 VA: 0x1F97348
	private IEnumerator animationChange(Animation baseAnim, NpcOtherData npc, Dictionary<byte, object> hash, Action callback) { }

	// RVA: 0x1F96484 Offset: 0x1F92484 VA: 0x1F96484
	private void setInvisible(bool isInvisible) { }

	// RVA: 0x1F97408 Offset: 0x1F93408 VA: 0x1F97408
	private void SetMoodMessage(string mes) { }

	// RVA: 0x1F96340 Offset: 0x1F92340 VA: 0x1F96340
	private void AddSignboard() { }

	// RVA: 0x1F97600 Offset: 0x1F93600 VA: 0x1F97600
	public void ReceiveActionEvent(ArchetypeActionEvent actionEvent) { }

	// RVA: 0x1F97614 Offset: 0x1F93614 VA: 0x1F97614 Slot: 46
	public void OnGetProperties(ArchetypeGetProperties response) { }

	// RVA: 0x1F97B5C Offset: 0x1F93B5C VA: 0x1F97B5C Slot: 42
	public void OnLevelUp(LevelupEvent response) { }

	// RVA: 0x1F97C28 Offset: 0x1F93C28 VA: 0x1F97C28 Slot: 43
	public void OnSetEquip(EquipEventData response) { }

	// RVA: 0x1F97D7C Offset: 0x1F93D7C VA: 0x1F97D7C Slot: 44
	public void OnDeadEquipCheck(EquipEventData response) { }

	// RVA: 0x1F97DBC Offset: 0x1F93DBC VA: 0x1F97DBC Slot: 47
	public void OnChangeState(ArchetypeChangeState response) { }

	// RVA: 0x1F97EC4 Offset: 0x1F93EC4 VA: 0x1F97EC4 Slot: 55
	public void OnActionMove(IMoveData eventData) { }

	// RVA: 0x1F982D4 Offset: 0x1F942D4 VA: 0x1F982D4 Slot: 56
	public void OnActionAttackStart(AttackStartEventData eventData) { }

	// RVA: 0x1F98630 Offset: 0x1F94630 VA: 0x1F98630 Slot: 57
	public void OnActionAttack(AttackEventData eventData) { }

	// RVA: 0x1F98BCC Offset: 0x1F94BCC VA: 0x1F98BCC Slot: 58
	public void OnActionSupportStart(SupportStartEventData eventData) { }

	// RVA: 0x1F98FEC Offset: 0x1F94FEC VA: 0x1F98FEC Slot: 59
	public void OnActionSkillCancel(SkillCancelData cancelData) { }

	// RVA: 0x1F99018 Offset: 0x1F95018 VA: 0x1F99018 Slot: 71
	public void OnActionEmotion(EmotionData eventData) { }

	// RVA: 0x1F99040 Offset: 0x1F95040 VA: 0x1F99040 Slot: 72
	public void OnActionEventAbnormal(EventAbnormalData eventData) { }

	// RVA: 0x1F99128 Offset: 0x1F95128 VA: 0x1F99128 Slot: 73
	public void OnActionEventMonsterDamage(EventMonsterDamageEventData eventMonsterDamageData) { }

	// RVA: 0x1F991F8 Offset: 0x1F951F8 VA: 0x1F991F8 Slot: 61
	public void OnActionMobCreate(MobResponseData mobData) { }

	// RVA: 0x1F992CC Offset: 0x1F952CC VA: 0x1F992CC Slot: 63
	public void OnActionMobMove(MobMoveEventData eventData) { }

	// RVA: 0x1F994A0 Offset: 0x1F954A0 VA: 0x1F994A0 Slot: 64
	public void OnActionMobActionStart(MobActionStartEventData eventData) { }

	// RVA: 0x1F99608 Offset: 0x1F95608 VA: 0x1F99608 Slot: 65
	public void OnActionMobAttack(MobAttackEventData eventData) { }

	// RVA: 0x1F99A14 Offset: 0x1F95A14 VA: 0x1F99A14 Slot: 66
	public void OnActionMobAttackToMob(MobAttackToMobEventData eventData) { }

	// RVA: 0x1F99E18 Offset: 0x1F95E18 VA: 0x1F99E18 Slot: 67
	public void OnActionMobSupport(MobAttackEventData eventData) { }

	// RVA: 0x1F9A274 Offset: 0x1F96274 VA: 0x1F9A274 Slot: 68
	public void OnActionMobActionCancel(MobCancelData cancelData) { }

	// RVA: 0x1F9A2DC Offset: 0x1F962DC VA: 0x1F9A2DC Slot: 62
	public void OnActionMobRelease(MobIdData eventData) { }

	// RVA: 0x1F9A344 Offset: 0x1F96344 VA: 0x1F9A344 Slot: 69
	public void OnActionMobCheck(MobIdData checkData) { }

	// RVA: 0x1F9A3E0 Offset: 0x1F963E0 VA: 0x1F9A3E0 Slot: 48
	public void OnMonsterFollowersPop(MonsterFollowersPop response) { }

	// RVA: 0x1F9A4B4 Offset: 0x1F964B4 VA: 0x1F9A4B4 Slot: 45
	public void OnSetProperties(ArchetypeSetProperties response) { }

	// RVA: 0x1F9A59C Offset: 0x1F9659C VA: 0x1F9A59C Slot: 49
	public void OnAbnormalStateEnd(AbnormalStateEndEvent abnormalStateEndEvent) { }

	// RVA: 0x1F9A80C Offset: 0x1F9680C VA: 0x1F9A80C Slot: 50
	public void OnAddAbnormalState(AddAbnormalStateEvent addAbnormalStateEvent) { }

	// RVA: 0x1F9A810 Offset: 0x1F96810 VA: 0x1F9A810 Slot: 74
	public void OnActionHousePetMove(PetMoveEventData eventData) { }

	// RVA: 0x1F9A874 Offset: 0x1F96874 VA: 0x1F9A874 Slot: 60
	public void OnActionBattleEndCheck(BattleEndCheckData eventData) { }

	// RVA: 0x1F9A878 Offset: 0x1F96878 VA: 0x1F9A878 Slot: 75
	public void OnActionSkillEvent(SkillEventData eventData) { }

	// RVA: 0x1F9A89C Offset: 0x1F9689C VA: 0x1F9A89C Slot: 80
	public void OnActionGuardAndAvoid(GuardAndAvoidData eventData) { }

	// RVA: 0x1F9AD7C Offset: 0x1F96D7C VA: 0x1F9AD7C Slot: 70
	public void OnActionMoodMessage(MoodMessageData eventData) { }

	// RVA: 0x1F9AD94 Offset: 0x1F96D94 VA: 0x1F9AD94 Slot: 83
	public void OnActionSnowballFightThrow(SnowballFightThrowData eventData) { }

	// RVA: 0x1F9B0E4 Offset: 0x1F970E4 VA: 0x1F9B0E4 Slot: 84
	public void OnActionSnowballFightReload(SnowballFightReloadData eventData) { }

	// RVA: 0x1F88C5C Offset: 0x1F84C5C VA: 0x1F88C5C
	public void OnActionSnowballFightReload(int uuid, short eventReloadTime) { }

	// RVA: 0x1F9B280 Offset: 0x1F97280 VA: 0x1F9B280 Slot: 85
	public void OnActionSnowballFightDodge(SnowballFightDodgeData eventData) { }

	// RVA: 0x1F9B488 Offset: 0x1F97488 VA: 0x1F9B488 Slot: 86
	public void OnActionSnowballFightAttack(SnowballFightAttackData eventData) { }

	// RVA: 0x1F9B48C Offset: 0x1F9748C VA: 0x1F9B48C Slot: 87
	public void OnActionSnowballFightSkillAttack(SnowballFightSkillAttackData eventData) { }

	// RVA: 0x1F9B490 Offset: 0x1F97490 VA: 0x1F9B490 Slot: 88
	public void OnActionSnowballFightDamage(SnowballFightDamageData eventData) { }

	// RVA: 0x1F9B710 Offset: 0x1F97710 VA: 0x1F9B710 Slot: 89
	public void OnActionSnowballFightDead(SnowballFightDeadData eventData) { }

	// RVA: 0x1F9B93C Offset: 0x1F9793C VA: 0x1F9B93C Slot: 90
	public void OnActionSnowballFightResurrection(SnowballFightResurrectionData eventData) { }

	// RVA: 0x1F9BCB4 Offset: 0x1F97CB4 VA: 0x1F9BCB4 Slot: 81
	public void OnActionSummerThrow(SummerThrowData throwData) { }

	// RVA: 0x1F9BE10 Offset: 0x1F97E10 VA: 0x1F9BE10 Slot: 82
	public void OnActionSummerFishAttack(MobAttackEventData attackData) { }

	// RVA: 0x1F9BF4C Offset: 0x1F97F4C VA: 0x1F9BF4C Slot: 51
	public void OnStopMove(StopMoveEvent response) { }

	// RVA: 0x1F9C034 Offset: 0x1F98034 VA: 0x1F9C034 Slot: 52
	public void OnWarpPosition(WarpPositionEvent warpPositon) { }

	// RVA: 0x1F9C0F4 Offset: 0x1F980F4 VA: 0x1F9C0F4 Slot: 76
	public void OnActionSkillSummons(SkillSummonsEventData eventData) { }

	// RVA: 0x1F9C180 Offset: 0x1F98180 VA: 0x1F9C180 Slot: 77
	public void OnActionSkillSummonsRemove(SkillSummonsRemoveEventData eventData) { }

	// RVA: 0x1F9C1D4 Offset: 0x1F981D4 VA: 0x1F9C1D4 Slot: 78
	public void OnActionMobEmergencyMove(MobEmergencyMoveEventData eventData) { }

	// RVA: 0x1F9C1D8 Offset: 0x1F981D8 VA: 0x1F9C1D8 Slot: 53
	public void OnSkillBuffEnd(SkillBuffEndEvent endEvent) { }

	// RVA: 0x1F9C310 Offset: 0x1F98310 VA: 0x1F9C310 Slot: 91
	public void OnActionSnowballFightGetItem(SnowballFightGetItemData eventData) { }

	// RVA: 0x1F9C38C Offset: 0x1F9838C VA: 0x1F9C38C Slot: 92
	public void OnActionSnowballFightUseItem(SnowballFightUseItemData eventData) { }

	// RVA: 0x1F9C428 Offset: 0x1F98428 VA: 0x1F9C428 Slot: 79
	public void OnActionMobEventAttack(MobEventAttackEventData eventData) { }

	// RVA: 0x1F9CBEC Offset: 0x1F98BEC VA: 0x1F9CBEC Slot: 54
	public void OnUpdateGameStatus(UpdateGameStatusEvent updateEvent) { }

	// RVA: 0x1F9CBF0 Offset: 0x1F98BF0 VA: 0x1F9CBF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F9CCB0 Offset: 0x1F98CB0 VA: 0x1F9CCB0
	private void <SetRenderSetting>b__73_0() { }

	[IteratorStateMachine(typeof(OtherPlayer.<<OnEventFishingSuccess>g__FishingSuccess|81_0>d))]
	[CompilerGenerated]
	// RVA: 0x1F96024 Offset: 0x1F92024 VA: 0x1F96024
	private IEnumerator <OnEventFishingSuccess>g__FishingSuccess|81_0(int fishId, int size) { }

	[CompilerGenerated]
	// RVA: 0x1F9CD40 Offset: 0x1F98D40 VA: 0x1F9CD40
	private void <setInvisible>b__94_0() { }

	[CompilerGenerated]
	// RVA: 0x1F9CD94 Offset: 0x1F98D94 VA: 0x1F9CD94
	private void <SetMoodMessage>b__95_0(string m) { }

	[CompilerGenerated]
	// RVA: 0x1F9CDD8 Offset: 0x1F98DD8 VA: 0x1F9CDD8
	private void <OnActionSnowballFightReload>b__131_0() { }
}

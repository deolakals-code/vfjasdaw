// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies.GameScene
internal class GameMain : IGameLogicStrategy // TypeDefIndex: 14895
{
	// Fields
	public static readonly IGameLogicStrategy Instance; // 0x0

	// Properties
	public GameState State { get; }

	// Methods

	// RVA: 0x3527304 Offset: 0x3523304 VA: 0x3527304 Slot: 4
	public GameState get_State() { }

	// RVA: 0x352730C Offset: 0x352330C VA: 0x352730C Slot: 5
	public void OnEventReceive(Game game, EventData eventData) { }

	// RVA: 0x3535ED0 Offset: 0x3531ED0 VA: 0x3535ED0 Slot: 6
	public void OnOperationReturn(Game game, OperationResponse operationResponse) { }

	// RVA: 0x354ADA8 Offset: 0x3546DA8 VA: 0x354ADA8 Slot: 7
	public void OnPeerStatusCallback(Game game, StatusCode returnCode) { }

	// RVA: 0x354AEA8 Offset: 0x3546EA8 VA: 0x354AEA8 Slot: 8
	public void OnUpdate(Game game) { }

	// RVA: 0x354AECC Offset: 0x3546ECC VA: 0x354AECC Slot: 9
	public void SendOperation(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x353758C Offset: 0x353358C VA: 0x353758C
	private void HandleOperationAction(Game game, OperationResponse responseObject) { }

	// RVA: 0x3538BDC Offset: 0x3534BDC VA: 0x3538BDC
	private void HandleOperationActionLight(Game game, OperationResponse responseObject) { }

	// RVA: 0x354AF10 Offset: 0x3546F10 VA: 0x354AF10
	private void HandleSetEquip(Game game, GameReturnCode returnCode, EquipResponseData equipResponseData) { }

	// RVA: 0x354AFF0 Offset: 0x3546FF0 VA: 0x354AFF0
	private void HandleMobCreate(Game game, ActionData actionData, GameReturnCode returnCode) { }

	// RVA: 0x354B238 Offset: 0x3547238 VA: 0x354B238
	private void HandleMobMove(Game game, ActionData actionData, GameReturnCode returnCode) { }

	// RVA: 0x354C08C Offset: 0x354808C VA: 0x354C08C
	private void HandleMobMove(Game game, Dictionary<object, object> actionParam, GameReturnCode returnCode) { }

	// RVA: 0x352AADC Offset: 0x3526ADC VA: 0x352AADC
	private void HandleEventArchetypeAction(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x354C270 Offset: 0x3548270 VA: 0x354C270
	private void HandleActionResult(Game game, byte archetypeType, int archetypeId, ActionData actionData) { }

	// RVA: 0x354C4B8 Offset: 0x35484B8 VA: 0x354C4B8
	private void HandleActionPartyResult(Game game, byte archetypeType, int archetypeId, ActionData actionData) { }

	// RVA: 0x354C620 Offset: 0x3548620 VA: 0x354C620
	private void HandleActionPartyRelease(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x354C6F4 Offset: 0x35486F4 VA: 0x354C6F4
	private void HandleActionPartyChangeHate(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x354C8C0 Offset: 0x35488C0 VA: 0x354C8C0
	private void HandleActionRoomResult(Game game, byte archetypeType, int archetypeId, ActionData actionData) { }

	// RVA: 0x354CA44 Offset: 0x3548A44 VA: 0x354CA44
	private void HandleActionRoomBossResult(Game game, byte archetypeType, int archetypeId, ActionData actionData) { }

	// RVA: 0x354CD64 Offset: 0x3548D64 VA: 0x354CD64
	private void HandleActionRoomRelease(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x354CE38 Offset: 0x3548E38 VA: 0x354CE38
	private void HandleActionRoomChangeHate(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x352BC88 Offset: 0x3527C88 VA: 0x352BC88
	private void HandleEventActionLight(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352BFA8 Offset: 0x3527FA8 VA: 0x352BFA8
	private void HandleEventSupport(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352C0B8 Offset: 0x35280B8 VA: 0x352C0B8
	private void HandleEventSupportDelay(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352C1C8 Offset: 0x35281C8 VA: 0x352C1C8
	private void HandleEventAbnormalDamage(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352C288 Offset: 0x3528288 VA: 0x352C288
	private void HandleEventAbnormalStateEnd(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352C330 Offset: 0x3528330 VA: 0x352C330
	private void HandleEventAddAbnormalState(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352C3D8 Offset: 0x35283D8 VA: 0x352C3D8
	private void HandleEventMobAbnormalDamage(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352C4FC Offset: 0x35284FC VA: 0x352C4FC
	private void HandleEventMobAbnormalStateEnd(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352C620 Offset: 0x3528620 VA: 0x352C620
	private void HandleEventMonsterFollowersPop(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352C6C8 Offset: 0x35286C8 VA: 0x352C6C8
	private void HandleEventNaturalRecovery(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352C788 Offset: 0x3528788 VA: 0x352C788
	private void HandleEventRespawnLatency(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352CDD4 Offset: 0x3528DD4 VA: 0x352CDD4
	private void HandleEventReUseSkill(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352C898 Offset: 0x3528898 VA: 0x352C898
	private void HandleEventMob(Game game, EventData eventData) { }

	// RVA: 0x352CB74 Offset: 0x3528B74 VA: 0x352CB74
	private void HandleEventSkillBuffEnd(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352CC1C Offset: 0x3528C1C VA: 0x352CC1C
	private void HandleEventMobBuffEvent(Game game, EventData eventData) { }

	// RVA: 0x352CE7C Offset: 0x3528E7C VA: 0x352CE7C
	private void HandleEventUpdateGameStatus(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352CF24 Offset: 0x3528F24 VA: 0x352CF24
	private void HandleEventRemoveSkillBuffer(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352D11C Offset: 0x352911C VA: 0x352D11C
	private void HandleEventBonusDuration(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x353479C Offset: 0x353079C VA: 0x353479C
	private void HandleEventExchangePointGetEvent(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352D034 Offset: 0x3529034 VA: 0x352D034
	private void HandleEventFunnelAttackStartEvent(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x3538DC0 Offset: 0x3534DC0 VA: 0x3538DC0
	private void HandleOperationStatusUp(Game game, OperationResponse response) { }

	// RVA: 0x3538E84 Offset: 0x3534E84 VA: 0x3538E84
	private void HandleOperationDeterminePersonality(Game game, OperationResponse response) { }

	// RVA: 0x3538FB4 Offset: 0x3534FB4 VA: 0x3538FB4
	private void HandleOperationAccountLevel(Game game, OperationResponse response) { }

	// RVA: 0x35390E8 Offset: 0x35350E8 VA: 0x35390E8
	private void HandleOperationAcceptPrison(Game game, OperationResponse response) { }

	// RVA: 0x353921C Offset: 0x353521C VA: 0x353921C
	private void HandleOperationGameLogout(Game game, OperationResponse response) { }

	// RVA: 0x353931C Offset: 0x353531C VA: 0x353931C
	private void HandleViewPersonsChange(Game game, OperationResponse response) { }

	// RVA: 0x3539454 Offset: 0x3535454 VA: 0x3539454
	private void HandleOperationRenameChange(Game game, OperationResponse response) { }

	// RVA: 0x352DB9C Offset: 0x3529B9C VA: 0x352DB9C
	private void HandleEventArchetypeSubscribed(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352DD48 Offset: 0x3529D48 VA: 0x352DD48
	private void HandleEventArchetypeUnsubscribed(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352DE14 Offset: 0x3529E14 VA: 0x352DE14
	private void HandleEventArchetypeSetProperties(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352DEBC Offset: 0x3529EBC VA: 0x352DEBC
	private void HandleEventArchetypeGetProperties(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352DFA8 Offset: 0x3529FA8 VA: 0x352DFA8
	private void HandleEventArchetypeDestroyed(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352E058 Offset: 0x352A058 VA: 0x352E058
	private void HandleEventArchetypeStopMove(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352E100 Offset: 0x352A100 VA: 0x352E100
	private void HandleEventLevelUp(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352E1A8 Offset: 0x352A1A8 VA: 0x352E1A8
	private void HandleEventArchetypeChangeState(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352E250 Offset: 0x352A250 VA: 0x352E250
	private void HandleEventComboPointUp(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352E448 Offset: 0x352A448 VA: 0x352E448
	private void HandleEventWarpPosition(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352E2F8 Offset: 0x352A2F8 VA: 0x352E2F8
	private void HandleEventStartComboBonus(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352E3A0 Offset: 0x352A3A0 VA: 0x352E3A0
	private void HandleEventEndComboBonus(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x35394D8 Offset: 0x35354D8 VA: 0x35394D8
	private void HandleOperationChangeField(Game game, OperationResponse response) { }

	// RVA: 0x35395B4 Offset: 0x35355B4 VA: 0x35395B4
	private void HandleOperationReload(Game game, OperationResponse response) { }

	// RVA: 0x3539638 Offset: 0x3535638 VA: 0x3539638
	private void HandleOperationRespawn(Game game, OperationResponse response) { }

	// RVA: 0x353976C Offset: 0x353576C VA: 0x353976C
	private void HandleOperationSystemRespawn(Game game, OperationResponse response) { }

	// RVA: 0x35398A0 Offset: 0x35358A0 VA: 0x35398A0
	private void HandleOperationSaveRespawnPosition(Game game, OperationResponse response) { }

	// RVA: 0x35399D4 Offset: 0x35359D4 VA: 0x35399D4
	private void HandleItem(Game game, OperationResponse response) { }

	// RVA: 0x353A00C Offset: 0x353600C VA: 0x353A00C
	private void HandleOperationStorage(Game game, OperationResponse response) { }

	// RVA: 0x353A5A8 Offset: 0x35365A8 VA: 0x353A5A8
	private void HandleOperationMarket(Game game, OperationResponse response) { }

	// RVA: 0x354DAF0 Offset: 0x3549AF0 VA: 0x354DAF0
	public void HandleMarketSales(Game game, byte subCode, OperationResponse response) { }

	// RVA: 0x354DCDC Offset: 0x3549CDC VA: 0x354DCDC
	public void HandleMarketPurchase(Game game, byte subCode, OperationResponse response) { }

	// RVA: 0x354DF4C Offset: 0x3549F4C VA: 0x354DF4C
	private short GetResponseSubReturnCode(OperationResponse response) { }

	// RVA: 0x35346DC Offset: 0x35306DC VA: 0x35346DC
	private void HandleEventItemDurationEnd(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x353AA48 Offset: 0x3536A48 VA: 0x353AA48
	private void HandleOperationSkillLibrary(Game game, OperationResponse response) { }

	// RVA: 0x353AB70 Offset: 0x3536B70 VA: 0x353AB70
	private void HandleOperationSkillLevelUp(Game game, OperationResponse response) { }

	// RVA: 0x353AC98 Offset: 0x3536C98 VA: 0x353AC98
	private void HandleOperationDeleteSkillTree(Game game, OperationResponse response) { }

	// RVA: 0x353ADC0 Offset: 0x3536DC0 VA: 0x353ADC0
	private void HandleSkill(Game game, OperationResponse response) { }

	// RVA: 0x353B21C Offset: 0x353721C VA: 0x353B21C
	private void HandleOperationSkillComboSet(Game game, OperationResponse response) { }

	// RVA: 0x353B310 Offset: 0x3537310 VA: 0x353B310
	private void HandleOperationCompensation(Game game, OperationResponse responseObject) { }

	// RVA: 0x353B604 Offset: 0x3537604 VA: 0x353B604
	private void HandleOperationParameterChange(Game game, OperationResponse response) { }

	// RVA: 0x353B688 Offset: 0x3537688 VA: 0x353B688
	private void HandleOperationParameterCreate(Game game, OperationResponse response) { }

	// RVA: 0x353B70C Offset: 0x353770C VA: 0x353B70C
	private void HandleOperationParameterGetList(Game game, OperationResponse response) { }

	// RVA: 0x353B834 Offset: 0x3537834 VA: 0x353B834
	private void HandleOperationParameterGetStatus(Game game, OperationResponse response) { }

	// RVA: 0x353B95C Offset: 0x353795C VA: 0x353B95C
	private void HandleOperationParameterNameChange(Game game, OperationResponse response) { }

	// RVA: 0x353BA84 Offset: 0x3537A84 VA: 0x353BA84
	private void HandleOperationParameterDelete(Game game, OperationResponse response) { }

	// RVA: 0x353BBAC Offset: 0x3537BAC VA: 0x353BBAC
	private void HandleOperationParameter(Game game, OperationResponse response) { }

	// RVA: 0x353BF30 Offset: 0x3537F30 VA: 0x353BF30
	private void HandleOperationMissionGetData(Game game, OperationResponse response) { }

	// RVA: 0x353C078 Offset: 0x3538078 VA: 0x353C078
	private void HandleOperationMissionStart(Game game, OperationResponse response) { }

	// RVA: 0x353C1DC Offset: 0x35381DC VA: 0x353C1DC
	private void HandleOperationMissionSetKey(Game game, OperationResponse response) { }

	// RVA: 0x353C2F8 Offset: 0x35382F8 VA: 0x353C2F8
	private void HandleOperationMissionViewChange(Game game, OperationResponse response) { }

	// RVA: 0x353C414 Offset: 0x3538414 VA: 0x353C414
	private void HandleOperationMissionReward(Game game, OperationResponse response) { }

	// RVA: 0x353C578 Offset: 0x3538578 VA: 0x353C578
	private void HandleOperationMissionAbandonment(Game game, OperationResponse response) { }

	// RVA: 0x353C6DC Offset: 0x35386DC VA: 0x353C6DC
	private void HandleOperationMissionEnd(Game game, OperationResponse response) { }

	// RVA: 0x353C840 Offset: 0x3538840 VA: 0x353C840
	private void HandleOperationQuestGetData(Game game, OperationResponse response) { }

	// RVA: 0x353C988 Offset: 0x3538988 VA: 0x353C988
	private void HandleOperationQuestStart(Game game, OperationResponse response) { }

	// RVA: 0x353CAEC Offset: 0x3538AEC VA: 0x353CAEC
	private void HandleOperationQuestSetKey(Game game, OperationResponse response) { }

	// RVA: 0x353CC08 Offset: 0x3538C08 VA: 0x353CC08
	private void HandleOperationQuestViewChange(Game game, OperationResponse response) { }

	// RVA: 0x353CD24 Offset: 0x3538D24 VA: 0x353CD24
	private void HandleOperationQuestReward(Game game, OperationResponse response) { }

	// RVA: 0x353CE88 Offset: 0x3538E88 VA: 0x353CE88
	private void HandleOperationQuestContinuousReward(Game game, OperationResponse response) { }

	// RVA: 0x353CFEC Offset: 0x3538FEC VA: 0x353CFEC
	private void HandleOperationQuestAbandonment(Game game, OperationResponse response) { }

	// RVA: 0x353D150 Offset: 0x3539150 VA: 0x353D150
	private void HandleOperationQuestEnd(Game game, OperationResponse response) { }

	// RVA: 0x353D2B4 Offset: 0x35392B4 VA: 0x353D2B4
	private void HandleOperationRecreateChange(Game game, OperationResponse response) { }

	// RVA: 0x353D338 Offset: 0x3539338 VA: 0x353D338
	private void HandleOperationRecreateStyle(Game game, OperationResponse response) { }

	// RVA: 0x353D460 Offset: 0x3539460 VA: 0x353D460
	private void HandleOperationSignboard(Game game, OperationResponse response) { }

	// RVA: 0x353D808 Offset: 0x3539808 VA: 0x353D808
	private void HandleOperationTrophyReward(Game game, OperationResponse response) { }

	// RVA: 0x353D930 Offset: 0x3539930 VA: 0x353D930
	private void HandleOperationDailyTrophyReward(Game game, OperationResponse response) { }

	// RVA: 0x353DA58 Offset: 0x3539A58 VA: 0x353DA58
	private void HandleOperationWeeklyTrophyReward(Game game, OperationResponse response) { }

	// RVA: 0x353DB80 Offset: 0x3539B80 VA: 0x353DB80
	private void HandleOperationLoginStampReward(Game game, OperationResponse response) { }

	// RVA: 0x353DCA8 Offset: 0x3539CA8 VA: 0x353DCA8
	private void HandleOperationAvatarVariableUpdate(Game game, OperationResponse response) { }

	// RVA: 0x353DDD0 Offset: 0x3539DD0 VA: 0x353DDD0
	private void HandleOperationNpcRespawn(Game game, OperationResponse responseObject) { }

	// RVA: 0x353DF3C Offset: 0x3539F3C VA: 0x353DF3C
	private void HandleOperationNpcAvatarJoin(Game game, OperationResponse responseObject) { }

	// RVA: 0x353E00C Offset: 0x353A00C VA: 0x353E00C
	private void HandleOperationNpcAvatarRejoin(Game game, OperationResponse responseObject) { }

	// RVA: 0x353E0DC Offset: 0x353A0DC VA: 0x353E0DC
	private void HandleOperationPartyInvitation(Game game, OperationResponse response) { }

	// RVA: 0x353E204 Offset: 0x353A204 VA: 0x353E204
	private void HandleOperationPartyInviteCancel(Game game, OperationResponse response) { }

	// RVA: 0x353E304 Offset: 0x353A304 VA: 0x353E304
	private void HandleOperationPartySenderInvitedCancel(Game game, OperationResponse response) { }

	// RVA: 0x353E404 Offset: 0x353A404 VA: 0x353E404
	private void HandleOperationPartyAcceptance(Game game, OperationResponse response) { }

	// RVA: 0x353E52C Offset: 0x353A52C VA: 0x353E52C
	private void HandleOperationPartySecede(Game game, OperationResponse response) { }

	// RVA: 0x353E5E8 Offset: 0x353A5E8 VA: 0x353E5E8
	private void HandleOperationParty(Game game, OperationResponse response) { }

	// RVA: 0x352FBC0 Offset: 0x352BBC0 VA: 0x352FBC0
	private void HandlePartyEvent(Game game, EventData eventData) { }

	// RVA: 0x35303D8 Offset: 0x352C3D8 VA: 0x35303D8
	private void HandleEventPartyFieldMemberList(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x3530254 Offset: 0x352C254 VA: 0x3530254
	private void HandleEventPartyFieldJoin(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x353032C Offset: 0x352C32C VA: 0x353032C
	private void HandleEventPartyFieldLeave(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x353F040 Offset: 0x353B040 VA: 0x353F040
	private void HandleOperationFriendUpdate(Game game, OperationResponse response) { }

	// RVA: 0x353F168 Offset: 0x353B168 VA: 0x353F168
	private void HandleOperationFriendRequest(Game game, OperationResponse response) { }

	// RVA: 0x353F290 Offset: 0x353B290 VA: 0x353F290
	private void HandleOperationFriendRequestCancel(Game game, OperationResponse response) { }

	// RVA: 0x353F3B8 Offset: 0x353B3B8 VA: 0x353F3B8
	private void HandleOperationFriendSenderRequestCancel(Game game, OperationResponse response) { }

	// RVA: 0x353F4E0 Offset: 0x353B4E0 VA: 0x353F4E0
	private void HandleOperationFriendAcceptance(Game game, OperationResponse response) { }

	// RVA: 0x353F608 Offset: 0x353B608 VA: 0x353F608
	private void HandleOperationFriendRemove(Game game, OperationResponse response) { }

	// RVA: 0x353F730 Offset: 0x353B730 VA: 0x353F730
	private void HandleOperationFriendChangeOnlineNotice(Game game, OperationResponse response) { }

	// RVA: 0x353F824 Offset: 0x353B824 VA: 0x353F824
	private void HandleOperationGuildNameCheck(Game game, OperationResponse response) { }

	// RVA: 0x353F918 Offset: 0x353B918 VA: 0x353F918
	private void HandleOperationGuildCreate(Game game, OperationResponse response) { }

	// RVA: 0x353FA40 Offset: 0x353BA40 VA: 0x353FA40
	private void HandleOperationGuildNameChange(Game game, OperationResponse response) { }

	// RVA: 0x353FB68 Offset: 0x353BB68 VA: 0x353FB68
	private void HandleOperationGuildInvitation(Game game, OperationResponse response) { }

	// RVA: 0x353FC90 Offset: 0x353BC90 VA: 0x353FC90
	private void HandleOperationGuildInviteCancel(Game game, OperationResponse response) { }

	// RVA: 0x353FDB8 Offset: 0x353BDB8 VA: 0x353FDB8
	private void HandleOperationGuildInviteSenderCancel(Game game, OperationResponse response) { }

	// RVA: 0x353FEE0 Offset: 0x353BEE0 VA: 0x353FEE0
	private void HandleOperationGuildAcceptance(Game game, OperationResponse response) { }

	// RVA: 0x3540008 Offset: 0x353C008 VA: 0x3540008
	private void HandleOperationGuildSecede(Game game, OperationResponse response) { }

	// RVA: 0x3540130 Offset: 0x353C130 VA: 0x3540130
	private void HandleOperationGuildExile(Game game, OperationResponse response) { }

	// RVA: 0x3540224 Offset: 0x353C224 VA: 0x3540224
	private void HandleOperationGuildDissolution(Game game, OperationResponse response) { }

	// RVA: 0x354034C Offset: 0x353C34C VA: 0x354034C
	private void HandleOperationGuildGetData(Game game, OperationResponse response) { }

	// RVA: 0x3540474 Offset: 0x353C474 VA: 0x3540474
	private void HandleOperationGuildGetBoard(Game game, OperationResponse response) { }

	// RVA: 0x354059C Offset: 0x353C59C VA: 0x354059C
	private void HandleOperationGuildWriteBoard(Game game, OperationResponse response) { }

	// RVA: 0x3540690 Offset: 0x353C690 VA: 0x3540690
	private void HandleOperationGuildPostChange(Game game, OperationResponse response) { }

	// RVA: 0x35407B8 Offset: 0x353C7B8 VA: 0x35407B8
	private void HandleOperationGuild(Game game, OperationResponse response) { }

	// RVA: 0x352EF84 Offset: 0x352AF84 VA: 0x352EF84
	private void HandleEventGuild(Game game, EventData eventData) { }

	// RVA: 0x3530574 Offset: 0x352C574 VA: 0x3530574
	private void HandleEventCompanion(Game game, EventData eventData) { }

	// RVA: 0x3541860 Offset: 0x353D860 VA: 0x3541860
	private void HandleOperationMercenary(Game game, OperationResponse response) { }

	// RVA: 0x3541ACC Offset: 0x353DACC VA: 0x3541ACC
	private void HandleOperationCristaAttach(Game game, OperationResponse response) { }

	// RVA: 0x3541C00 Offset: 0x353DC00 VA: 0x3541C00
	private void HandleOperationCristaBreak(Game game, OperationResponse response) { }

	// RVA: 0x3541D34 Offset: 0x353DD34 VA: 0x3541D34
	private void HandleOperationReinforceCristaAttach(Game game, OperationResponse response) { }

	// RVA: 0x3541E68 Offset: 0x353DE68 VA: 0x3541E68
	private void HandleOperationChannelGetList(Game game, OperationResponse responseObject) { }

	// RVA: 0x3541FA8 Offset: 0x353DFA8 VA: 0x3541FA8
	private void HandleOperationChannelGetWorld(Game game, OperationResponse responseObject) { }

	// RVA: 0x35420E8 Offset: 0x353E0E8 VA: 0x35420E8
	private void HandleOperationChannelChange(Game game, OperationResponse responseObject) { }

	// RVA: 0x35421E0 Offset: 0x353E1E0 VA: 0x35421E0
	private void HandleOperationGlobal(Game game, OperationResponse response) { }

	// RVA: 0x352E4F0 Offset: 0x352A4F0 VA: 0x352E4F0
	private void HandleEventRoom(Game game, EventData eventData) { }

	// RVA: 0x3542560 Offset: 0x353E560 VA: 0x3542560
	private void HandleOperationCheckBossSymbol(Game game, OperationResponse responseObject) { }

	// RVA: 0x35426A0 Offset: 0x353E6A0 VA: 0x35426A0
	private void HandleOperationCheckDefenceRoom(Game game, OperationResponse responseObject) { }

	// RVA: 0x354E3C8 Offset: 0x354A3C8 VA: 0x354E3C8
	private void HandleOperationCheckWaveRoom(Game game, OperationResponse responseObject) { }

	// RVA: 0x35427E0 Offset: 0x353E7E0 VA: 0x35427E0
	private void HandleOperationRoomState(Game game, OperationResponse responseObject) { }

	// RVA: 0x3542920 Offset: 0x353E920 VA: 0x3542920
	private void HandleOperationRoomGroupSettingChange(Game game, OperationResponse responseObject) { }

	// RVA: 0x3542A60 Offset: 0x353EA60 VA: 0x3542A60
	private void HandleOperationRoomJoinCancel(Game game, OperationResponse responseObject) { }

	// RVA: 0x3542B54 Offset: 0x353EB54 VA: 0x3542B54
	private void HandleOperationRoomJoinReady(Game game, OperationResponse responseObject) { }

	// RVA: 0x3542C94 Offset: 0x353EC94 VA: 0x3542C94
	private void HandleOperationRoomJoinReadyCancel(Game game, OperationResponse responseObject) { }

	// RVA: 0x3542DD4 Offset: 0x353EDD4 VA: 0x3542DD4
	private void HandleOperationCheckDungeonRoom(Game game, OperationResponse responseObject) { }

	// RVA: 0x3542F48 Offset: 0x353EF48 VA: 0x3542F48
	private void HandleOperationDungeonGroupSettingChange(Game game, OperationResponse responseObject) { }

	// RVA: 0x35430BC Offset: 0x353F0BC VA: 0x35430BC
	private static void HandleOperationManaMagicCharge(Game game, OperationResponse responseObject) { }

	// RVA: 0x35417B8 Offset: 0x353D7B8 VA: 0x35417B8
	private void HandleOperationGuildHomeEnter(Game game, OperationResponse responseInstance) { }

	// RVA: 0x35417D8 Offset: 0x353D7D8 VA: 0x35417D8
	private void HandleOperationGuildHomeLeave(Game game, OperationResponse responseInstance) { }

	// RVA: 0x3543230 Offset: 0x353F230 VA: 0x3543230
	private void HandleOperationRoom(Game game, OperationResponse response) { }

	// RVA: 0x3543C3C Offset: 0x353FC3C VA: 0x3543C3C
	private void HandleOperationBCollaboration(Game game, OperationResponse response) { }

	// RVA: 0x352ECAC Offset: 0x352ACAC VA: 0x352ECAC
	private void HandleOperationDungeonTrapEvent(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352EDAC Offset: 0x352ADAC VA: 0x352EDAC
	private void HandleOperationDungeonDownstairs(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x352EE94 Offset: 0x352AE94 VA: 0x352EE94
	private static void HandleOperationDungeonBeat(Game game, Dictionary<byte, object> eventData) { }

	// RVA: 0x354CC10 Offset: 0x3548C10 VA: 0x354CC10
	private void HandleActionRoomItemBoxResult(Game game, byte archetypeType, int archetypeId, ActionData actionData) { }

	// RVA: 0x352D22C Offset: 0x352922C VA: 0x352D22C
	private void HandleEventDefence(Game game, EventData eventData) { }

	// RVA: 0x352D618 Offset: 0x3529618 VA: 0x352D618
	private void HandleEventWave(Game game, EventData eventData) { }

	// RVA: 0x3532E90 Offset: 0x352EE90 VA: 0x3532E90
	private void HandleEventTresureHunt(Game game, EventData eventData) { }

	// RVA: 0x3533750 Offset: 0x352F750 VA: 0x3533750
	private void HandleEventWaveRaid(Game game, EventData eventData) { }

	// RVA: 0x3533CD4 Offset: 0x352FCD4 VA: 0x3533CD4
	private void HandleEventRoguelike(Game game, EventData eventData) { }

	// RVA: 0x3534038 Offset: 0x3530038 VA: 0x3534038
	private void HandleEventNewWave(Game game, EventData eventData) { }

	// RVA: 0x3534534 Offset: 0x3530534 VA: 0x3534534
	private void HandleEventBCollaboration(Game game, EventData eventData) { }

	// RVA: 0x3543DA8 Offset: 0x353FDA8 VA: 0x3543DA8
	private void HandleOperationOrb(Game game, OperationResponse response) { }

	// RVA: 0x354E6A4 Offset: 0x354A6A4 VA: 0x354E6A4
	private void HandleOperationOrbItemUse(Game game, OperationResponse responseObject) { }

	// RVA: 0x354E508 Offset: 0x354A508 VA: 0x354E508
	private void HandleOperationOrbServiceBuy(Game game, OperationResponse responseObject) { }

	// RVA: 0x35447E4 Offset: 0x35407E4 VA: 0x35447E4
	private void HandleOperationBank(Game game, OperationResponse response) { }

	// RVA: 0x354543C Offset: 0x354143C VA: 0x354543C
	private void HandleOperationGameEvent(Game game, OperationResponse response) { }

	// RVA: 0x3544E70 Offset: 0x3540E70 VA: 0x3544E70
	private void HandleOperationAvatarGenericFlagList(Game game, OperationResponse responseObject) { }

	// RVA: 0x3544FE4 Offset: 0x3540FE4 VA: 0x3544FE4
	private void HandleOperationUpdateGenericFlag(Game game, OperationResponse responseObject) { }

	// RVA: 0x3545158 Offset: 0x3541158 VA: 0x3545158
	private void HandleOperationBanWordUpdate(Game game, OperationResponse responseObject) { }

	// RVA: 0x35452CC Offset: 0x35412CC VA: 0x35452CC
	private void HandleOperationGameSystem(Game game, OperationResponse responseObject) { }

	// RVA: 0x35459F8 Offset: 0x35419F8 VA: 0x35459F8
	private void HandleOperationMiniGame(Game game, OperationResponse responseObject) { }

	// RVA: 0x3530D08 Offset: 0x352CD08 VA: 0x3530D08
	private void HandleEventMiniGame(Game game, EventData eventData) { }

	// RVA: 0x354B454 Offset: 0x3547454 VA: 0x354B454
	private void ActionMiniGameActionA(Game game, GameReturnCode returnCode, Dictionary<object, object> parameters) { }

	// RVA: 0x354B61C Offset: 0x354761C VA: 0x354B61C
	private void ActionMiniGameActionC(Game game, GameReturnCode returnCode, Dictionary<object, object> parameters) { }

	// RVA: 0x354B758 Offset: 0x3547758 VA: 0x354B758
	private void ActionMiniGameActionD(Game game, GameReturnCode returnCode, Dictionary<object, object> parameters) { }

	// RVA: 0x354B894 Offset: 0x3547894 VA: 0x354B894
	private void ActionMiniGameAttack(Game game, GameReturnCode returnCode, Dictionary<object, object> parameters) { }

	// RVA: 0x354BA60 Offset: 0x3547A60 VA: 0x354BA60
	private void ActionMiniGameDamage(Game game, GameReturnCode returnCode, Dictionary<object, object> parameters) { }

	// RVA: 0x354BB9C Offset: 0x3547B9C VA: 0x354BB9C
	private void ActionMiniGameDead(Game game, GameReturnCode returnCode, Dictionary<object, object> parameters) { }

	// RVA: 0x354BCD8 Offset: 0x3547CD8 VA: 0x354BCD8
	private void ActionMiniGameResurrection(Game game, GameReturnCode returnCode, Dictionary<object, object> parameters) { }

	// RVA: 0x354BE14 Offset: 0x3547E14 VA: 0x354BE14
	private void ActionMiniGameGetItem(Game game, GameReturnCode returnCode, Dictionary<object, object> parameters) { }

	// RVA: 0x354BF50 Offset: 0x3547F50 VA: 0x354BF50
	private void ActionMiniGameUseItem(Game game, GameReturnCode returnCode, Dictionary<object, object> parameters) { }

	// RVA: 0x354D004 Offset: 0x3549004 VA: 0x354D004
	private void ActionEventMiniGameActionA(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x354D170 Offset: 0x3549170 VA: 0x354D170
	private void ActionEventMiniGameActionB(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x354D27C Offset: 0x354927C VA: 0x354D27C
	private void ActionEventMiniGameActionC(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x354D388 Offset: 0x3549388 VA: 0x354D388
	private void ActionEventMiniGameAttack(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x354D494 Offset: 0x3549494 VA: 0x354D494
	private void ActionEventMiniGameDamege(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x354D5A0 Offset: 0x35495A0 VA: 0x354D5A0
	private void ActionEventMiniGameDead(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x354D6AC Offset: 0x35496AC VA: 0x354D6AC
	private void ActionEventMiniGameResurrection(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x354D7B8 Offset: 0x35497B8 VA: 0x354D7B8
	private void ActionEventMiniGameGetItem(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x354D8C4 Offset: 0x35498C4 VA: 0x354D8C4
	private void ActionEventMiniGameUseItem(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x3545FD8 Offset: 0x3541FD8 VA: 0x3545FD8
	private void HandleOperationHouse(Game game, OperationResponse responseObject) { }

	// RVA: 0x3531854 Offset: 0x352D854 VA: 0x3531854
	private void HandleEventHouse(Game game, EventData eventData) { }

	// RVA: 0x3547FD0 Offset: 0x3543FD0 VA: 0x3547FD0
	private void HandleOperationMail(Game game, OperationResponse responseObject) { }

	// RVA: 0x3548600 Offset: 0x3544600 VA: 0x3548600
	private void HandleOperationDefenceRanking(Game game, OperationResponse responseObject) { }

	// RVA: 0x354DF78 Offset: 0x3549F78 VA: 0x354DF78
	private static void ArchetypePartyFieldAlreadyExistsJoin(Game game, int partyId, byte archetypeType, int archetypeId) { }

	// RVA: 0x354E11C Offset: 0x354A11C VA: 0x354E11C
	private static void ArchetypePartyFieldJoin(Game game, int partyId, byte archetypeType, int archetypeId) { }

	// RVA: 0x354E2C0 Offset: 0x354A2C0 VA: 0x354E2C0
	private static void ArchetypePartyFieldLeave(Game game, int partyId, byte archetypeType, int archetypeId) { }

	// RVA: 0x35489B8 Offset: 0x35449B8 VA: 0x35489B8
	private void HandleOperationTreasure(Game game, OperationResponse responseObject) { }

	// RVA: 0x3548BDC Offset: 0x3544BDC VA: 0x3548BDC
	private void HandleOperationCultivation(Game game, OperationResponse responseObject) { }

	// RVA: 0x3549094 Offset: 0x3545094 VA: 0x3549094
	private void HandleOperationCuisine(Game game, OperationResponse responseObject) { }

	// RVA: 0x35495CC Offset: 0x35455CC VA: 0x35495CC
	private void HandleOperationExchange(Game game, OperationResponse responseObject) { }

	// RVA: 0x35497F0 Offset: 0x35457F0 VA: 0x35497F0
	private void HandleOperationGuildStaff(Game game, OperationResponse responseObject) { }

	// RVA: 0x3533404 Offset: 0x352F404 VA: 0x3533404
	private void HandleEventGuildStaff(Game game, EventData eventData) { }

	// RVA: 0x3549B28 Offset: 0x3545B28 VA: 0x3549B28
	private void HandleOperationLottery(Game game, OperationResponse responseObject) { }

	// RVA: 0x353363C Offset: 0x352F63C VA: 0x353363C
	private void HandleEventLottery(Game game, EventData eventData) { }

	// RVA: 0x3549FE0 Offset: 0x3545FE0 VA: 0x3549FE0
	private void HandleOperationRegistlet(Game game, OperationResponse responseObject) { }

	// RVA: 0x354A398 Offset: 0x3546398 VA: 0x354A398
	private void HandleOperationHighRaid(Game game, OperationResponse responseObject) { }

	// RVA: 0x354A810 Offset: 0x3546810 VA: 0x354A810
	private void HandleOperationGuildQuest(Game game, OperationResponse responseObject) { }

	// RVA: 0x354AB48 Offset: 0x3546B48 VA: 0x354AB48
	private void HandleOperationGuildRaidLobbyEnter(Game game, OperationResponse responseInstance) { }

	// RVA: 0x354AB68 Offset: 0x3546B68 VA: 0x354AB68
	private void HandleOperationGuildRaidStaminaRecovery(Game game, OperationResponse response) { }

	// RVA: 0x3534884 Offset: 0x3530884 VA: 0x3534884
	private void HandleEventContents(Game game, EventData eventData) { }

	// RVA: 0x3534C60 Offset: 0x3530C60 VA: 0x3534C60
	private void HandleEventMoba(Game game, EventData eventData) { }

	// RVA: 0x354E7BC Offset: 0x354A7BC VA: 0x354E7BC
	private void HandleEventMobaArchetypeSubscribed(Game game, MobaArchetypeSubscribed subscribed) { }

	// RVA: 0x354EA48 Offset: 0x354AA48 VA: 0x354EA48
	private void HandleEventMobaArchetypeUnsubscribed(Game game, MobaArchetypeUnsubscribed unsubscribed) { }

	// RVA: 0x3535744 Offset: 0x3531744 VA: 0x3535744
	private void HandleEventItemRandomProperty(Game game, EventData eventData) { }

	// RVA: 0x354D9D0 Offset: 0x35499D0 VA: 0x354D9D0
	private void HandleActionEventMobMonsterResult(Game game, ActionData actionData) { }

	// RVA: 0x352F988 Offset: 0x352B988 VA: 0x352F988
	private void HandleEventGuildBBS(Game game, EventData eventData) { }

	// RVA: 0x353597C Offset: 0x353197C VA: 0x353597C
	private void HandleEventFishing(Game game, EventData eventData) { }

	// RVA: 0x353081C Offset: 0x352C81C VA: 0x353081C
	private void HandleEventTrade(Game game, EventData eventData) { }

	// RVA: 0x3535C98 Offset: 0x3531C98 VA: 0x3535C98
	private void HandleEventSystems(Game game, EventData eventData) { }

	// RVA: 0x3538D0C Offset: 0x3534D0C VA: 0x3538D0C
	private static void NoticeOperationFailure(Game game, OperationResponse operationResponse) { }

	// RVA: 0x354AC9C Offset: 0x3546C9C VA: 0x354AC9C
	private static void HandleOperationExplain(Game game, OperationResponse responseObject) { }

	// RVA: 0x354EAB0 Offset: 0x354AAB0 VA: 0x354EAB0
	public void .ctor() { }

	// RVA: 0x354EAB8 Offset: 0x354AAB8 VA: 0x354EAB8
	private static void .cctor() { }
}

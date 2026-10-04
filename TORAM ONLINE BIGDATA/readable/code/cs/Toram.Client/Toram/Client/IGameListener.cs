// Assembly: Toram.Client.dll
// Namespace: Toram.Client
[CLSCompliant(False)]
public interface IGameListener // TypeDefIndex: 14878
{
	// Properties
	public abstract DebugLevel DebugLogLevel { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DebugLevel get_DebugLogLevel();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LogDebug(Game game, string message);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LogError(Game game, string message);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void LogError(Game game, Exception exception);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnReportAppliLog(Game game, int code, string message);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnMasterConnectLog(GameState state, StatusCode statusCode);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void DebugPopError(Game game, GameReturnCode returnCode, string str);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void DebugChatLogError(Game game, GameReturnCode returnCode, string str);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void OnArchetypeAdded(Game game, Archetype item);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OnArchetypeRemoved(Game game, Archetype item);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnDisconnect(Game game, StatusCode returnCode);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OnDisconnectByServer(Game game, StatusCode statusCode);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void OnMasterStartConnection(Game game);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnMasterConnect(Game game);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void OnMasterReconnect(Game game);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void OnMasterLogin(Game game);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void OnMasterTimeoutDisconnect(Game game, StatusCode returnCode);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void OnMasterAllowLogin(Game game, LoginResponse login);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void OnMasterCustomerSelect(Game game);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void OnMasterSelectWorld(Game game, LoginResponse worldSelect);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void OnGameStartConnection(Game game);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void OnGameConnect(Game game);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void OnGameReconnect(Game game);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void OnGameRejoin(Game game);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void OnGameTimeoutDisconnect(Game game, StatusCode returnCode);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void OnGameConnectSwitching(Game game);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void OnLoginFailure(Game game, GameReturnCode returnCode, string debugMessage);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void OnMasterSignature(Game game, Dictionary<byte, object> parameters);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void OnOperationFailure(Game game, OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void OnGameJoinFailure(Game game, GameReturnCode returnCode, string debugMessage);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void OnGameAvatarCreate(Game game, PeerResultCode resultCode, GameJoinResponse join);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void OnGameAvatarRenaming(Game game, PeerResultCode resultCode, GameJoinResponse join);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void OnGameLoadAvatar(Game game, GameJoinResponse join);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void OnGameLoader(Game game);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract void OnGameMain(Game game, PositionData positionData);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void OnGameBlank(Game game, byte reason);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract void OnEventCustomerDisconnect(Game game, CustomerDisconnectEvent disconnect);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void OnEventCustomerConnect(Game game, CustomerConnectEvent reconnect);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void OnGameSignatureJoin(Game game, Dictionary<byte, object> parameters);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract void OnGameReJoinFailure(Game game, OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract void OnGameRejoinAvatarCreate(Game game, PeerResultCode resultCode, GameReJoinResponse rejoin);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract void OnGameRejoinRecreateScene(Game game, PeerResultCode resultCode, GameReJoinResponse rejoin);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract void OnGameRejoinRenameScene(Game game, PeerResultCode resultCode, GameReJoinResponse rejoin);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void OnGameRejoinAvatarRenaming(Game game, PeerResultCode resultCode, GameReJoinResponse rejoin);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract void OnGameRejoinParameterCreate(Game game, PeerResultCode resultCode, GameReJoinResponse rejoin);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract void OnGameRejoinLoadAvatar(Game game, GameReJoinResponse rejoin);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract void OnGameRejoinLoader(Game game, GameReJoinResponse rejoin);

	[Obsolete("Old Version")]
	// RVA: -1 Offset: -1 Slot: 47
	public abstract void OnGameRejoinMain(Game game, EnterAvatarData avatarData, GameReJoinResponse rejoin);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract void OnGameRejoinMain(Game game, EnterAvatarData2 avatarData, GameReJoinResponse rejoin);

	// RVA: -1 Offset: -1 Slot: 49
	public abstract void OnGameRejoinMain(Game game, EnterAvatarPacket avatarData, GameReJoinResponse rejoin);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract void OnGameRejoinBlank(Game game, GameReJoinResponse rejoin);

	[Obsolete("Old Version")]
	// RVA: -1 Offset: -1 Slot: 51
	public abstract void OnGameRejoinMiniGame(Game game, EnterAvatarData avatarData, GameReJoinResponse rejoin);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract void OnGameRejoinMiniGame(Game game, EnterAvatarPacket avatarData, GameReJoinResponse rejoin);

	// RVA: -1 Offset: -1 Slot: 53
	public abstract void OnGameSignatureRejoin(Game game, Dictionary<byte, object> parameters);

	// RVA: -1 Offset: -1 Slot: 54
	public abstract void OnCreateAvatarStart(Game game, string avatarName, GameReturnCode returnCode);

	// RVA: -1 Offset: -1 Slot: 55
	public abstract void OnCreateCheckName(Game game, string checkName, GameReturnCode returnCode);

	// RVA: -1 Offset: -1 Slot: 56
	public abstract void OnCreateNewAvatar(Game game, string avatarName, GameReturnCode returnCode);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract void OnRename(Game game, RenameResponse response);

	// RVA: -1 Offset: -1 Slot: 58
	public abstract void OnCreateAvatarNaming(Game game, string checkName, GameReturnCode returnCode);

	// RVA: -1 Offset: -1 Slot: 59
	public abstract void OnLoadAvatarFailure(Game game, byte operationCode, GameReturnCode returnCode, string debugMessage);

	// RVA: -1 Offset: -1 Slot: 60
	public abstract void OnLoginField(Game game, LoginFieldResponse loginFieldResponse);

	[Obsolete("Old Version")]
	// RVA: -1 Offset: -1 Slot: 61
	public abstract void OnEnterAvatar(Game game, MyArchetype avatar, EnterAvatarData avatarData);

	// RVA: -1 Offset: -1 Slot: 62
	public abstract void OnEnterAvatar(Game game, MyArchetype avatar, EnterAvatarPacket avatarData);

	// RVA: -1 Offset: -1 Slot: 63
	public abstract void OnEnterAvatar(Game game, MyArchetype avatar, EnterAvatarData2 avatarData);

	// RVA: -1 Offset: -1 Slot: 64
	public abstract void OnReturnEmergencyPoint(Game game, EmergencyPositionData emergencyPoint);

	// RVA: -1 Offset: -1 Slot: 65
	public abstract void OnNeedLoaderAgain(Game game);

	// RVA: -1 Offset: -1 Slot: 66
	public abstract void OnLoadAvatarEntry(Game game, LoadAvatarEntryResponse entry);

	// RVA: -1 Offset: -1 Slot: 67
	public abstract void OnLoadAvatarCheck(Game game, LoadAvatarCheckResponse check);

	// RVA: -1 Offset: -1 Slot: 68
	public abstract void OnEventEnterBossField(Game game, EnterBossField bossField);

	// RVA: -1 Offset: -1 Slot: 69
	public abstract void OnEventLoadAvatarResult(Game game, LoadAvatarResultEvent loadAvatar);

	// RVA: -1 Offset: -1 Slot: 70
	public abstract void OnReceiveResponse(Game game, OperationResponse operationResponse);

	// RVA: -1 Offset: -1 Slot: 71
	public abstract void OnReceiveResponse(Game game, byte subCode, OperationResponse operationResponse);

	// RVA: -1 Offset: -1 Slot: 72
	public abstract void OnEventUserLogin(Game game, UserLoginEvent userLogin);

	// RVA: -1 Offset: -1 Slot: 73
	public abstract void OnEventUserReLogin(Game game, UserReLoginEvent userLogin);

	// RVA: -1 Offset: -1 Slot: 74
	public abstract void OnMoveResponse(Game game, OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 75
	public abstract void OnActionNotReadyToRun(Game game);

	// RVA: -1 Offset: -1 Slot: 76
	public abstract void OnActionDefaultResponse(Game game, ActionCode actionCode, GameReturnCode returnCode);

	// RVA: -1 Offset: -1 Slot: 77
	public abstract void OnActionAttackStart(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, AttackStartResponseData response);

	// RVA: -1 Offset: -1 Slot: 78
	public abstract void OnActionAttack(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, AttackResponseData response);

	// RVA: -1 Offset: -1 Slot: 79
	public abstract void OnActionAttackEnd(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, AttackEndResponseData response);

	// RVA: -1 Offset: -1 Slot: 80
	public abstract void OnActionPartsAttack(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, PartsAttackResponseData response);

	// RVA: -1 Offset: -1 Slot: 81
	public abstract void OnActionSupportStart(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SupportStartResponseData response);

	// RVA: -1 Offset: -1 Slot: 82
	public abstract void OnActionSupport(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SupportResponseData response);

	// RVA: -1 Offset: -1 Slot: 83
	public abstract void OnActionSupportDelay(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SupportDelayResponseData response);

	// RVA: -1 Offset: -1 Slot: 84
	public abstract void OnActionSupportEnd(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SupportEndResponseData response);

	// RVA: -1 Offset: -1 Slot: 85
	public abstract void OnActionSkillMotionEnd(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SkillMotionEndResponseData response);

	// RVA: -1 Offset: -1 Slot: 86
	public abstract void OnActionSkillCancel(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SkillIdData response);

	// RVA: -1 Offset: -1 Slot: 87
	public abstract void OnActionSkillEvent(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SkillEventResponseData response);

	// RVA: -1 Offset: -1 Slot: 88
	public abstract void OnActionSkillSummons(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SkillSummonsResponseData response);

	// RVA: -1 Offset: -1 Slot: 89
	public abstract void OnActionSkillSummonsRemove(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SkillSummonsRemoveResponseData response);

	// RVA: -1 Offset: -1 Slot: 90
	public abstract void OnActionEventMonsterDamage(Game game, GameReturnCode returnCode, EventMonsterDamageResponseData responseData);

	// RVA: -1 Offset: -1 Slot: 91
	public abstract void OnActionBattleEndCheck(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, BattleEndCheckData response);

	// RVA: -1 Offset: -1 Slot: 92
	public abstract void OnActionMobCreate(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobResponseData response);

	// RVA: -1 Offset: -1 Slot: 93
	public abstract void OnActionMobRelease(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobIdData response);

	// RVA: -1 Offset: -1 Slot: 94
	public abstract void OnActionMobActionStart(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobActionStartResponseData response);

	// RVA: -1 Offset: -1 Slot: 95
	public abstract void OnActionMobAttack(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobAttackResponseData response);

	// RVA: -1 Offset: -1 Slot: 96
	public abstract void OnActionMobAttackToMob(Game game, GameReturnCode returnCode, MobAttackToMobResponseData response);

	// RVA: -1 Offset: -1 Slot: 97
	public abstract void OnActionMobSupport(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobAttackResponseData response);

	// RVA: -1 Offset: -1 Slot: 98
	public abstract void OnActionMobActionCancel(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobCancelData response);

	// RVA: -1 Offset: -1 Slot: 99
	public abstract void OnActionMobEmergencyMove(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobEmergencyMoveResponseData response);

	// RVA: -1 Offset: -1 Slot: 100
	public abstract void OnActionMobEventAttack(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobEventAttackResponseData response);

	// RVA: -1 Offset: -1 Slot: 101
	public abstract void OnActionMobCheck(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobResponseData response);

	// RVA: -1 Offset: -1 Slot: 102
	public abstract void OnActionMobHateCheck(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId);

	// RVA: -1 Offset: -1 Slot: 103
	public abstract void OnActionItemUse(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, ItemUseResponseData response);

	// RVA: -1 Offset: -1 Slot: 104
	public abstract void OnActionItemDurationInvoke(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, ItemDurationResponeData response);

	// RVA: -1 Offset: -1 Slot: 105
	public abstract void OnActionSetEquip(Game game, GameReturnCode returnCode, PlayerStatusData response);

	// RVA: -1 Offset: -1 Slot: 106
	public abstract void OnActionEventDamage(Game game, GameReturnCode returnCode, EventDamageResponseData events);

	// RVA: -1 Offset: -1 Slot: 107
	public abstract void OnActionGuardAndAvoid(Game game, GameReturnCode returnCode, GuardAndAvoidResponseData response);

	// RVA: -1 Offset: -1 Slot: 108
	public abstract void OnActionRemoveSkillBuffer(Game game, GameReturnCode returnCode, RemoveSkillBufferResponseData response);

	// RVA: -1 Offset: -1 Slot: 109
	public abstract void OnActionEventMove(Game game, byte archetypeType, int archetypeId, MoveData moveEvent);

	// RVA: -1 Offset: -1 Slot: 110
	public abstract void OnActionEventMove(Game game, byte archetypeType, int archetypeId, MoveDataLight moveEvent);

	// RVA: -1 Offset: -1 Slot: 111
	public abstract void OnActionEventEmotion(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 112
	public abstract void OnActionEventMoodMessage(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 113
	public abstract void OnActionEventEventAbnormal(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 114
	public abstract void OnActionEventEventMonsterDamage(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 115
	public abstract void OnActionEventAttackStart(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 116
	public abstract void OnActionEventAttack(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 117
	public abstract void OnActionEventPartsAttack(Game game, PartsAttackResponseData eventData);

	// RVA: -1 Offset: -1 Slot: 118
	public abstract void OnActionEventSupportStart(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 119
	public abstract void OnActionEventSkillCancel(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 120
	public abstract void OnActionEventSkillSummons(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 121
	public abstract void OnActionEventSkillSummonsRemove(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 122
	public abstract void OnActionEventMobCreate(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 123
	public abstract void OnActionEventMobRelease(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 124
	public abstract void OnActionEventMobMove(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 125
	public abstract void OnActionEventMobActionStart(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 126
	public abstract void OnActionEventMobAttack(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 127
	public abstract void OnActionEventMobAttackToMob(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 128
	public abstract void OnActionEventMobSupport(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 129
	public abstract void OnActionEventMobActionCancel(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 130
	public abstract void OnActionEventMobEmergencyMove(Game game, ArchetypeActionEvent data);

	// RVA: -1 Offset: -1 Slot: 131
	public abstract void OnActionEventMobEventAttack(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 132
	public abstract void OnActionEventMobCheck(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 133
	public abstract void OnActionEventSetEquip(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 134
	public abstract void OnActionEventBattleStart(Game game, byte archetypeType, int archetypeId);

	// RVA: -1 Offset: -1 Slot: 135
	public abstract void OnActionEventBattleEnd(Game game, byte archetypeType, int archetypeId);

	// RVA: -1 Offset: -1 Slot: 136
	public abstract void OnActionMobResult(Game game, BattleResultData battleResult, MobData[] mobIds, MonsterResultData[] mobResult, bool isResend);

	// RVA: -1 Offset: -1 Slot: 137
	public abstract void OnActionEventHousePetMove(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 138
	public abstract void OnActionEventSkillEvent(Game game, ArchetypeActionEvent data);

	// RVA: -1 Offset: -1 Slot: 139
	public abstract void OnActionEventGuardAndAvoid(Game game, ArchetypeActionEvent data);

	// RVA: -1 Offset: -1 Slot: 140
	public abstract void OnActionPartyResult(Game game, BattleResultData battleResult, MobData[] mobIds, MonsterResultData[] mobResult, bool isResend);

	// RVA: -1 Offset: -1 Slot: 141
	public abstract void OnActionPartyRelease(Game game, MobData[] mobList);

	// RVA: -1 Offset: -1 Slot: 142
	public abstract void OnActionPartyChangeHateMine(Game game, Archetype archetype, MobData[] mobList);

	// RVA: -1 Offset: -1 Slot: 143
	public abstract void OnActionPartyChangeHateActor(Game game, Archetype archetype, MobData[] mobList);

	// RVA: -1 Offset: -1 Slot: 144
	public abstract void OnActionRoomResult(Game game, MobData mobData, ResultData resultData, bool isResend);

	// RVA: -1 Offset: -1 Slot: 145
	public abstract void OnActionRoomBossResult(Game game, MobData mobData, ResultData resultData, BossResultData bossResult, bool isResend);

	// RVA: -1 Offset: -1 Slot: 146
	public abstract void OnActionRoomRelease(Game game, MobData[] mobList);

	// RVA: -1 Offset: -1 Slot: 147
	public abstract void OnActionRoomChangeHateMine(Game game, Archetype archetype, MobData[] mobList);

	// RVA: -1 Offset: -1 Slot: 148
	public abstract void OnActionRoomChangeHateActor(Game game, Archetype archetype, MobData[] mobList);

	// RVA: -1 Offset: -1 Slot: 149
	public abstract void OnEventSupport(Game game, SupportEventResponseData support);

	// RVA: -1 Offset: -1 Slot: 150
	public abstract void OnEventSupportDelay(Game game, SupportDelayEventResponseData support);

	// RVA: -1 Offset: -1 Slot: 151
	public abstract void OnEventHyperModeChange(Game game, HyperModeChangeEvent battleEvent);

	// RVA: -1 Offset: -1 Slot: 152
	public abstract void OnEventResendingHyperMode(Game game, ResendingHyperModeEvent battleEvent);

	// RVA: -1 Offset: -1 Slot: 153
	public abstract void OnEventMobAllRelease(Game game, MobAllReleaseEvent battleEvent);

	// RVA: -1 Offset: -1 Slot: 154
	public abstract void OnEventMobKilled(Game game, MobKilledEvent battleEvent);

	// RVA: -1 Offset: -1 Slot: 155
	public abstract void OnEventRespawnLatency(Game game, RespawnLatencyEvent battleEvent);

	// RVA: -1 Offset: -1 Slot: 156
	public abstract void OnActionEventMobAbnormalDamage(Game game, MobAbnormalDamageEvent abnormalDamage);

	// RVA: -1 Offset: -1 Slot: 157
	public abstract void OnActionEventMobAbnormalStateEnd(Game game, MobAbnormalStateEndEvent abnormalDamage);

	// RVA: -1 Offset: -1 Slot: 158
	public abstract void OnEventCaptureStart(Game game, CaptureStartEvent capture);

	// RVA: -1 Offset: -1 Slot: 159
	public abstract void OnEventCaptureUpdate(Game game, CaptureUpdateEvent capture);

	// RVA: -1 Offset: -1 Slot: 160
	public abstract void OnEventCaptureSuccess(Game game, CaptureSuccessEvent capture);

	// RVA: -1 Offset: -1 Slot: 161
	public abstract void OnEventCaptureFailed(Game game, CaptureFailedEvent capture);

	// RVA: -1 Offset: -1 Slot: 162
	public abstract void OnEventMobBuffEffect(Game game, MobBuffEffectEvent effectEvent);

	// RVA: -1 Offset: -1 Slot: 163
	public abstract void OnEventMobBuffEnd(Game game, MobBuffEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 164
	public abstract void OnEventUpdateBossScore(Game game, UpdateBossScoreEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 165
	public abstract void OnEventRemoveSkillBuffer(Game game, RemoveSkillBufferEventResponseData eventData);

	// RVA: -1 Offset: -1 Slot: 166
	public abstract void OnEventBonusDuration(Game game, BonusDurationEventResponseData eventData);

	// RVA: -1 Offset: -1 Slot: 167
	public abstract void OnEventExchangePointGetEvent(Game game, ExchangePointGetEvent eventData);

	// RVA: -1 Offset: -1 Slot: 168
	public abstract void OnActionEventFunnelAttackStartEvent(Game game, FunnelAttackStartEvent funnelEvent);

	// RVA: -1 Offset: -1 Slot: 169
	public abstract void OnDeterminePersonality(Game game, PersonalityType personalityType);

	// RVA: -1 Offset: -1 Slot: 170
	public abstract void OnAccountLevel(Game game, AccountLevelResponse accountLevel);

	// RVA: -1 Offset: -1 Slot: 171
	public abstract void OnAcceptPrison(Game game, AcceptPrisonResponse prison);

	// RVA: -1 Offset: -1 Slot: 172
	public abstract void OnGameLogout(Game game);

	// RVA: -1 Offset: -1 Slot: 173
	public abstract void OnViewPersonChange(Game game);

	// RVA: -1 Offset: -1 Slot: 174
	public abstract void OnRenameChange(Game game);

	// RVA: -1 Offset: -1 Slot: 175
	public abstract void OnEventChatMessage(Game game, ChatEvent chatEvent);

	// RVA: -1 Offset: -1 Slot: 176
	public abstract void OnEventChatMessage(Game game, ChatMessageEvent chatEvent);

	// RVA: -1 Offset: -1 Slot: 177
	public abstract void OnEventSystemChat(Game game, SystemChatEvent chatEvent);

	// RVA: -1 Offset: -1 Slot: 178
	public abstract void OnEventGameRecord(Game game, GameRecordEvent recordEvent);

	// RVA: -1 Offset: -1 Slot: 179
	public abstract void OnChangeField(Game game, byte operationCode);

	// RVA: -1 Offset: -1 Slot: 180
	public abstract void OnParameterChange(Game game);

	// RVA: -1 Offset: -1 Slot: 181
	public abstract void OnParameterCreate(Game game);

	// RVA: -1 Offset: -1 Slot: 182
	public abstract void OnParameterGetList(Game game, ParameterGetListResponse response);

	// RVA: -1 Offset: -1 Slot: 183
	public abstract void OnParameterGetStatus(Game game, ParameterGetStatusResponse response);

	// RVA: -1 Offset: -1 Slot: 184
	public abstract void OnParameterNameChange(Game game, ParameterNameChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 185
	public abstract void OnParameterDelete(Game game, ParameterDeleteResponse response);

	// RVA: -1 Offset: -1 Slot: 186
	public abstract void OnCreateNewParameter(Game game, byte parameterId, short returnCode, string debugMessage);

	// RVA: -1 Offset: -1 Slot: 187
	public abstract void OnParameterOrderChange(Game game, ParameterOrderChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 188
	public abstract void OnParameterOrderReset(Game game, ParameterOrderResetResponse response);

	// RVA: -1 Offset: -1 Slot: 189
	public abstract void OnParameterGetActionSetting(Game game, ParameterGetActionSettingResponse response);

	// RVA: -1 Offset: -1 Slot: 190
	public abstract void OnParameterSaveActionSetting(Game game);

	// RVA: -1 Offset: -1 Slot: 191
	public abstract void OnParameterChangeActionSetting(Game game, ParameterChangeActionSettingResponse response);

	// RVA: -1 Offset: -1 Slot: 192
	public abstract void OnRespawn(Game game, NormalRespawnResponse response);

	// RVA: -1 Offset: -1 Slot: 193
	public abstract void OnSystemRespawn(Game game, SystemRespawnResponse response);

	// RVA: -1 Offset: -1 Slot: 194
	public abstract void OnSaveRespawnPosition(Game game, SaveRespawnPositionResponse response);

	// RVA: -1 Offset: -1 Slot: 195
	public abstract void OnItemDiscard(Game game, _ItemDiscardResponse responseObject, short returnCode);

	// RVA: -1 Offset: -1 Slot: 196
	public abstract void OnItemUserFlagChange(Game game, _ItemUserFlagChangeResponse responseObject, short returnCode);

	// RVA: -1 Offset: -1 Slot: 197
	public abstract void OnItemBagLoad(Game game, ItemLoadResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 198
	public abstract void OnItemBagSlotRelease(Game game, ItemBagSlotReleaseResponse responseObject, short returnCode);

	// RVA: -1 Offset: -1 Slot: 199
	public abstract void OnItemBoxOpen(Game game, ItemBoxOpenResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 200
	public abstract void OnWarrantyDiscard(Game game, _WarrantyDiscardResponse responseObject, short returnCode);

	// RVA: -1 Offset: -1 Slot: 201
	public abstract void OnWarrantySwap(Game game, _WarrantySwapResponse responseObject, short returnCode);

	// RVA: -1 Offset: -1 Slot: 202
	public abstract void OnStorageGetList(Game game, StorageGetListResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 203
	public abstract void OnStorageGetItems(Game game, StorageGetItemsResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 204
	public abstract void OnStorageDataEdit(Game game, StorageDataEditResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 205
	public abstract void OnStorageTakeItem(Game game, StorageTakeItemResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 206
	public abstract void OnStoragePutItem(Game game, StoragePutItemResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 207
	public abstract void OnStorageSortItem(Game game, StorageSortItemResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 208
	public abstract void OnStorageDiscardItem(Game game, StorageDiscardItemResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 209
	public abstract void OnStorageItemFlagChange(Game game, StorageItemFlagChangeResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 210
	public abstract void OnStorageOrderChange(Game game, StorageOrderChangeResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 211
	public abstract void OnMarketSetUp(Game game, MarketSetupResponse responseObject, GameReturnCode returnCode);

	// RVA: -1 Offset: -1 Slot: 212
	public abstract void OnMarketUserSalesList(Game game, MarketUserSalesListResponse responseObject, GameReturnCode returnCode);

	// RVA: -1 Offset: -1 Slot: 213
	public abstract void OnMarketExhibit(Game game, MarketExhibitResponse responseObject, GameReturnCode returnCode);

	// RVA: -1 Offset: -1 Slot: 214
	public abstract void OnMarketExhibitCancel(Game game, MarketExhibitCancelResponse responseObject, GameReturnCode returnCode);

	// RVA: -1 Offset: -1 Slot: 215
	public abstract void OnMarketSalesAcquisitionFailed(Game game, MarketSalesResultResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 216
	public abstract void OnMarketSalesAcquisition(Game game, MarketSalesResultResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 217
	public abstract void OnMarketProductList(Game game, MarketProductListResponse responseObject, GameReturnCode returnCode);

	// RVA: -1 Offset: -1 Slot: 218
	public abstract void OnMarketPurchase(Game game, MarketPurchaseResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 219
	public abstract void OnMarketPurchaseFailed(Game game, MarketPurchaseResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 220
	public abstract void OnEventMarketUpdate(Game game, MarketUpdateEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 221
	public abstract void OnSkillLibrary(Game game, SkillLibraryResponse response);

	// RVA: -1 Offset: -1 Slot: 222
	public abstract void OnSkillLevelUp(Game game, SkillLevelUpResponse response);

	// RVA: -1 Offset: -1 Slot: 223
	public abstract void OnDeleteSkillTree(Game game, DeleteSkillTreeResponse response);

	// RVA: -1 Offset: -1 Slot: 224
	public abstract void OnSkillComboSet(Game game);

	// RVA: -1 Offset: -1 Slot: 225
	public abstract void OnCompensationSkillReset(Game game, CompensationSkillResetResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 226
	public abstract void OnCompensationInquiry(Game game, CompensationInquiryResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 227
	public abstract void OnCompensationStatusReset(Game game, CompensationStatusResetResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 228
	public abstract void OnCompensationPersonalityReset(Game game, CompensationPersonalityResetResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 229
	public abstract void OnSkillGetFamilia(Game game, GetFamiliaResponse response);

	// RVA: -1 Offset: -1 Slot: 230
	public abstract void OnSkillChangeFamilia(Game game, ChangeFamiliaResponse response);

	// RVA: -1 Offset: -1 Slot: 231
	public abstract void OnSkillUnlockFamilia(Game game, UnlockFamiliaResponse response);

	// RVA: -1 Offset: -1 Slot: 232
	public abstract void OnSkillCreateNinjutsuBook(Game game, CreateNinjutsuScrollResponse response);

	// RVA: -1 Offset: -1 Slot: 233
	public abstract void OnMissionOperationFailure(Game game, OperationResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 234
	public abstract void OnMissionGetData(Game game, MissionGetDataResponse response);

	// RVA: -1 Offset: -1 Slot: 235
	public abstract void OnMissionAbandonment(Game game, MissionAbandonmentResponse response);

	// RVA: -1 Offset: -1 Slot: 236
	public abstract void OnMissionStart(Game game, MissionStartResponse response);

	// RVA: -1 Offset: -1 Slot: 237
	public abstract void OnMissionReward(Game game, MissionCheckRewardResponse response);

	// RVA: -1 Offset: -1 Slot: 238
	public abstract void OnMissionEnd(Game game, MissionEndResponse response);

	// RVA: -1 Offset: -1 Slot: 239
	public abstract void OnQuestOperationFailure(Game game, OperationResponse responseObject);

	// RVA: -1 Offset: -1 Slot: 240
	public abstract void OnQuestGetData(Game game, QuestGetDataResponse response);

	// RVA: -1 Offset: -1 Slot: 241
	public abstract void OnQuestAbandonment(Game game, QuestAbandonmentResponse response);

	// RVA: -1 Offset: -1 Slot: 242
	public abstract void OnQuestStart(Game game, QuestStartResponse response);

	// RVA: -1 Offset: -1 Slot: 243
	public abstract void OnQuestReward(Game game, QuestCheckRewardResponse response);

	// RVA: -1 Offset: -1 Slot: 244
	public abstract void OnQuestContinuousReward(Game game, QuestCheckContinuousRewardResponse response);

	// RVA: -1 Offset: -1 Slot: 245
	public abstract void OnQuestEnd(Game game, QuestEndResponse response);

	// RVA: -1 Offset: -1 Slot: 246
	public abstract void OnRecreateChange(Game game);

	// RVA: -1 Offset: -1 Slot: 247
	public abstract void OnRecreateStyle(Game game, RecreateStyleResponse response);

	// RVA: -1 Offset: -1 Slot: 248
	public abstract void OnEventSignboard(Game game, SignboardEvent events);

	// RVA: -1 Offset: -1 Slot: 249
	public abstract void OnSignboardPutup(Game game, PutUpSignboardResponse response);

	// RVA: -1 Offset: -1 Slot: 250
	public abstract void OnSignboardPutAway(Game game, PutAwaySignboardResponse response);

	// RVA: -1 Offset: -1 Slot: 251
	public abstract void OnSignboardCheck(Game game, CheckSignboardResponse response);

	// RVA: -1 Offset: -1 Slot: 252
	public abstract void OnSignboardContentExecute(Game game, ContentExecuteSignboardResponse response);

	// RVA: -1 Offset: -1 Slot: 253
	public abstract void OnTrophyCheckReward(Game game, TrophyCheckRewardResponse response);

	// RVA: -1 Offset: -1 Slot: 254
	public abstract void OnDailyTrophyCheckReward(Game game, DailyTrophyCheckRewardResponse response);

	// RVA: -1 Offset: -1 Slot: 255
	public abstract void OnWeeklyTrophyCheckReward(Game game, WeeklyTrophyCheckRewardResponse response);

	// RVA: -1 Offset: -1 Slot: 256
	public abstract void OnStampCardCheckReward(Game game, LoginStampRewardResponse response);

	// RVA: -1 Offset: -1 Slot: 257
	public abstract void OnAvatarVariableUpdate(Game game, AvatarVariableUpdateResponse response);

	// RVA: -1 Offset: -1 Slot: 258
	public abstract void OnEventTrophy(Game game, TrophyEvent trophy);

	// RVA: -1 Offset: -1 Slot: 259
	public abstract void OnEventDailyTrophy(Game game, DailyTrophyEvent dailyTrophy);

	// RVA: -1 Offset: -1 Slot: 260
	public abstract void OnEventWeeklyTrophy(Game game, WeeklyTrophyEvent weeklyTrophy);

	// RVA: -1 Offset: -1 Slot: 261
	public abstract void OnEventLoginStamp(Game game, LoginStampEvent loginStamp);

	// RVA: -1 Offset: -1 Slot: 262
	public abstract void OnEventBagCapacity(Game game, BagCapacityEvent bagCapacity);

	// RVA: -1 Offset: -1 Slot: 263
	public abstract void OnEventLoginAvatarVariable(Game game, LoginAvatarVariableEvent login);

	// RVA: -1 Offset: -1 Slot: 264
	public abstract void OnNpcRespawn(Game game, NpcRespawnResponse response);

	// RVA: -1 Offset: -1 Slot: 265
	public abstract void OnEventGroupMemberStatus(Game game, GroupMemberStatusEvent statusEvent);

	// RVA: -1 Offset: -1 Slot: 266
	public abstract void OnNpcAvatarJoin(Game game, NpcArchetype npc, NpcAvatarJoinResponse npcResonse);

	// RVA: -1 Offset: -1 Slot: 267
	public abstract void OnNpcAvatarRejoin(Game game, NpcArchetype npc, NpcAvatarRejoinResponse npcResonse);

	// RVA: -1 Offset: -1 Slot: 268
	public abstract void OnCompanionAvatarJoin(Game game, Archetype companionArchetype);

	// RVA: -1 Offset: -1 Slot: 269
	public abstract void OnPartnerJoin(Game game, PartnerJoinResponse response);

	// RVA: -1 Offset: -1 Slot: 270
	public abstract void OnMercenaryJoin(Game game, MercenaryJoinResponse response);

	// RVA: -1 Offset: -1 Slot: 271
	public abstract void OnMercenaryRegisterGet(Game game, MercenaryRegisterGetResponse response);

	// RVA: -1 Offset: -1 Slot: 272
	public abstract void OnMercenaryRegister(Game game, MercenaryRegisterResponse response);

	// RVA: -1 Offset: -1 Slot: 273
	public abstract void OnMercenaryEmploymentList(Game game, MercenaryEmploymentListResponse response);

	// RVA: -1 Offset: -1 Slot: 274
	public abstract void OnPetJoin(Game game, PetJoinResponse response);

	// RVA: -1 Offset: -1 Slot: 275
	public abstract void OnPetList(Game game, GetPetListResponse response);

	// RVA: -1 Offset: -1 Slot: 276
	public abstract void OnEventPetUpdate(Game game, PetUpdateEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 277
	public abstract void OnEventPetLogin(Game game, PetLoginEvent loginEvent);

	// RVA: -1 Offset: -1 Slot: 278
	public abstract void OnEventPetOwnership(Game game, PetOwnershipEvent ownershipEvent);

	// RVA: -1 Offset: -1 Slot: 279
	public abstract void OnFriendUpdate(Game game, FriendUpdateResponse response);

	// RVA: -1 Offset: -1 Slot: 280
	public abstract void OnFriendRequest(Game game, FriendRequestResponse response);

	// RVA: -1 Offset: -1 Slot: 281
	public abstract void OnFriendRequestCancel(Game game, FriendCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 282
	public abstract void OnFriendSenderRequestCancel(Game game, FriendSenderCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 283
	public abstract void OnFriendAcceptance(Game game, FriendAcceptanceResponse response);

	// RVA: -1 Offset: -1 Slot: 284
	public abstract void OnFriendRemove(Game game, FriendRemoveResponse response);

	// RVA: -1 Offset: -1 Slot: 285
	public abstract void OnFriendChangeOnlineNotice(Game game);

	// RVA: -1 Offset: -1 Slot: 286
	public abstract void OnEventFriendRequest(Game game, FriendRequestEvent friendEvent);

	// RVA: -1 Offset: -1 Slot: 287
	public abstract void OnEventFriendCancel(Game game, FriendCancelEvent friendEvent);

	// RVA: -1 Offset: -1 Slot: 288
	public abstract void OnEventFriendSenderCancel(Game game, FriendSenderCancelEvent friendEvent);

	// RVA: -1 Offset: -1 Slot: 289
	public abstract void OnEventFriendAcceptance(Game game, FriendAcceptanceEvent friendEvent);

	// RVA: -1 Offset: -1 Slot: 290
	public abstract void OnEventFriendRemove(Game game, FriendRemoveEvent friendEvent);

	// RVA: -1 Offset: -1 Slot: 291
	public abstract void OnGuildNameCheck(Game game);

	// RVA: -1 Offset: -1 Slot: 292
	public abstract void OnGuildCreate(Game game, GuildCreateResponse response);

	// RVA: -1 Offset: -1 Slot: 293
	public abstract void OnGuildNameChange(Game game, GuildNameChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 294
	public abstract void OnGuildInvitation(Game game, GuildInvitationResponse response);

	// RVA: -1 Offset: -1 Slot: 295
	public abstract void OnGuildInviteCancel(Game game, GuildInviteCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 296
	public abstract void OnGuildInviteSenderCancel(Game game, GuildInviteSenderCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 297
	public abstract void OnGuildAcceptance(Game game, GuildAcceptanceResponse response);

	// RVA: -1 Offset: -1 Slot: 298
	public abstract void OnGuildSecede(Game game, GuildSecedeResponse response);

	// RVA: -1 Offset: -1 Slot: 299
	public abstract void OnGuildExile(Game game);

	// RVA: -1 Offset: -1 Slot: 300
	public abstract void OnGuildDissolution(Game game, GuildDissolutionResponse response);

	// RVA: -1 Offset: -1 Slot: 301
	public abstract void OnGuildGetData(Game game, GuildGetDataResponse response);

	// RVA: -1 Offset: -1 Slot: 302
	public abstract void OnGuildGetBoard(Game game, GuildGetBoardResponse response);

	// RVA: -1 Offset: -1 Slot: 303
	public abstract void OnGuildWriteBoard(Game game);

	// RVA: -1 Offset: -1 Slot: 304
	public abstract void OnGuildPostChange(Game game, GuildPostChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 305
	public abstract void OnGuildHomeEnter(Game game);

	// RVA: -1 Offset: -1 Slot: 306
	public abstract void OnGuildHomeLeave(Game game);

	// RVA: -1 Offset: -1 Slot: 307
	public abstract void OnGuildTransferMasterPost(Game game, GuildTransferMasterPostResponse response);

	// RVA: -1 Offset: -1 Slot: 308
	public abstract void OnGuildCandidacyMasterPost(Game game, GuildCandidacyMasterPostResponse response);

	// RVA: -1 Offset: -1 Slot: 309
	public abstract void OnGuildGetBooster(Game game, GuildGetBoosterResponse response);

	// RVA: -1 Offset: -1 Slot: 310
	public abstract void OnGuildCheckContribution(Game game, GuildCheckContributionResponse response);

	// RVA: -1 Offset: -1 Slot: 311
	public abstract void OnGuildCollectContribution(Game game, GuildCollectContributionResponse response);

	// RVA: -1 Offset: -1 Slot: 312
	public abstract void OnGuildRunBooster(Game game, GuildRunBoosterResponse response);

	// RVA: -1 Offset: -1 Slot: 313
	public abstract void OnGuildPresent(Game game, GuildPresentResponse response);

	// RVA: -1 Offset: -1 Slot: 314
	public abstract void OnGuildUnreceivedMessage(Game game, GuildUnreceivedMessageResponse response);

	// RVA: -1 Offset: -1 Slot: 315
	public abstract void OnGuildMemberList(Game game, GuildMemberListResponse response);

	// RVA: -1 Offset: -1 Slot: 316
	public abstract void OnGuildChangeOnlineNotice(Game game);

	// RVA: -1 Offset: -1 Slot: 317
	public abstract void OnGuildContrihuteGold(Game game, GuildContributeGoldResponse response);

	// RVA: -1 Offset: -1 Slot: 318
	public abstract void OnGuildChangeTenant(Game game, GuildChangeTenantResponse response);

	// RVA: -1 Offset: -1 Slot: 319
	public abstract void OnGuildUpdateTenant(Game game, GuildUpdateTenantResponse response);

	// RVA: -1 Offset: -1 Slot: 320
	public abstract void OnGuildGetStaffData(Game game, GuildGetStaffDataResponse response);

	// RVA: -1 Offset: -1 Slot: 321
	public abstract void OnGuildStartChangeStaffData(Game game, GuildStartChangeStaffDataResponse response);

	// RVA: -1 Offset: -1 Slot: 322
	public abstract void OnGuildEndChangeStaffData(Game game, GuildEndChangeStaffDataResponse response);

	// RVA: -1 Offset: -1 Slot: 323
	public abstract void OnGuildCancelChangeStaffData(Game game, GuildCancelChangeStaffDataResponse response);

	// RVA: -1 Offset: -1 Slot: 324
	public abstract void OnGuildMedalUpdate(Game game, GuildMedalUpdateResponse response);

	// RVA: -1 Offset: -1 Slot: 325
	public abstract void OnGuildOpenRenovation(Game game, GuildOpenRenovationResponse response);

	// RVA: -1 Offset: -1 Slot: 326
	public abstract void OnGuildChangeRenovation(Game game, GuildChangeRenovationResponse response);

	// RVA: -1 Offset: -1 Slot: 327
	public abstract void OnGuildHeldRaid(Game game, GuildHeldRaidResponse response);

	// RVA: -1 Offset: -1 Slot: 328
	public abstract void OnGuildGetHeldRaidData(Game game, GuildGetHeldRaidDataResponse response);

	// RVA: -1 Offset: -1 Slot: 329
	public abstract void OnGuildResetRaid(Game game);

	// RVA: -1 Offset: -1 Slot: 330
	public abstract void OnGuildGetRaidBossData(Game game, GuildGetRaidBossDataResponse response);

	// RVA: -1 Offset: -1 Slot: 331
	public abstract void OnGuildLevelUpFacility(Game game, GuildLevelUpFacilityResponse response);

	// RVA: -1 Offset: -1 Slot: 332
	public abstract void OnGuildSetFacilityFlag(Game game, GuildSetFacilityFlagResponse response);

	// RVA: -1 Offset: -1 Slot: 333
	public abstract void OnGuildGetRaidLog(Game game, GuildGetRaidLogDataResponse response);

	// RVA: -1 Offset: -1 Slot: 334
	public abstract void OnGuildEndHeldRaid(Game game);

	// RVA: -1 Offset: -1 Slot: 335
	public abstract void OnEventGuildJoin(Game game, GuildJoinEvent guildEvent);

	// RVA: -1 Offset: -1 Slot: 336
	public abstract void OnEventGuildInvitation(Game game, GuildInvitationEvent guildEvent);

	// RVA: -1 Offset: -1 Slot: 337
	public abstract void OnEventGuildInviteSenderCancel(Game game, GuildInviteSenderCancelEvent guildEvent);

	// RVA: -1 Offset: -1 Slot: 338
	public abstract void OnEventGuildSecede(Game game, GuildSecedeEvent guildEvent);

	// RVA: -1 Offset: -1 Slot: 339
	public abstract void OnEventGuildExile(Game game, GuildExileEvent guildEvent);

	// RVA: -1 Offset: -1 Slot: 340
	public abstract void OnEventGuildWriteBoard(Game game, GuildWriteBoardEvent guildEvent);

	// RVA: -1 Offset: -1 Slot: 341
	public abstract void OnEventGuildCreate(Game game, GuildCreateEvent guildEvent);

	// RVA: -1 Offset: -1 Slot: 342
	public abstract void OnEventGuildNameChange(Game game, GuildNameChangeEvent guildEvent);

	// RVA: -1 Offset: -1 Slot: 343
	public abstract void OnEventGuildLevelUp(Game game, GuildLevelUpEvent levelupEvent);

	// RVA: -1 Offset: -1 Slot: 344
	public abstract void OnEventGuildPostChange(Game game, GuildPostChangeEvent guildEvent);

	// RVA: -1 Offset: -1 Slot: 345
	public abstract void OnEventGuildTransferMaster(Game game, GuildTransferMasterEvent transEvent);

	// RVA: -1 Offset: -1 Slot: 346
	public abstract void OnEventGuildCandidacyMaster(Game game, GuildCandidacyMasterEvent transEvent);

	// RVA: -1 Offset: -1 Slot: 347
	public abstract void OnEventGuildRunBooster(Game game, GuildRunBoosterEvent boosterEvent);

	// RVA: -1 Offset: -1 Slot: 348
	public abstract void OnEventGuildStopBooster(Game game, GuildStopBoosterEvent boosterEvent);

	// RVA: -1 Offset: -1 Slot: 349
	public abstract void OnEventGuildPresent(Game game, GuildPresentEvent presentEvent);

	// RVA: -1 Offset: -1 Slot: 350
	public abstract void OnEventGuildPoint(Game game, GuildPointEvent pointEvent);

	// RVA: -1 Offset: -1 Slot: 351
	public abstract void OnEventGuildUpdateVariableData(Game game, GuildUpdateVariableEvent updateVariableEvent);

	// RVA: -1 Offset: -1 Slot: 352
	public abstract void OnEventGuildUpdateStaffDataEvent(Game game, GuildUpdateStaffDataEvent updateStaffDataEvent);

	// RVA: -1 Offset: -1 Slot: 353
	public abstract void OnEventGuildCancelChangeStaffDataEvent(Game game, GuildCancelChangeStaffDataEvent cancelEvent);

	// RVA: -1 Offset: -1 Slot: 354
	public abstract void OnEventGuildCheck(Game game, GuildCheckEvent checkEvent);

	// RVA: -1 Offset: -1 Slot: 355
	public abstract void OnEventGuildUpdateRenovation(Game game, GuildUpdateRenovationEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 356
	public abstract void OnEventGuildHeldRaid(Game game, GuildHeldRaidEvent heldEvent);

	// RVA: -1 Offset: -1 Slot: 357
	public abstract void OnEventGuildEndRaid(Game game, GuildEndRaidEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 358
	public abstract void OnEventGuildRaidEndBattle(Game game, GuildEndGuildRaidBattleEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 359
	public abstract void OnEventGuldResetRaid(Game game);

	// RVA: -1 Offset: -1 Slot: 360
	public abstract void OnEventGuildRaidInvalidRandomProperty(Game game, GuildRaidInvalidRandomPropertyEvent invalidEvent);

	// RVA: -1 Offset: -1 Slot: 361
	public abstract void OnEventGuildInitializeRaidReheld(Game game);

	// RVA: -1 Offset: -1 Slot: 362
	public abstract void OnEventGuildLevelUpFacility(Game game, GuildLevelUpFacilityEvent levelUpEvent);

	// RVA: -1 Offset: -1 Slot: 363
	public abstract void OnEventGuildOverKillRaid(Game game, GuildOverKillRaidEvent overKillEvent);

	// RVA: -1 Offset: -1 Slot: 364
	public abstract void OnEventGuildUpdateRaidMaxHpCount(Game game, GuildUpdateRaidMaxHpCountEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 365
	public abstract void OnEventGuildOpenBgm(Game game, GuildOpenBgmEvent openEvent);

	// RVA: -1 Offset: -1 Slot: 366
	public abstract void OnEventGuildAllianceInvite(Game game, GuildAllianceInviteEvent inviteEvent);

	// RVA: -1 Offset: -1 Slot: 367
	public abstract void OnEventGuildAllianceInviteCancel(Game game, GuildAllianceInviteCancelEvent cancelEvent);

	// RVA: -1 Offset: -1 Slot: 368
	public abstract void OnEventGuildAllianceConsent(Game game, GuildAllianceConsentEvent consentEvent);

	// RVA: -1 Offset: -1 Slot: 369
	public abstract void OnEventGuildAllianceRelease(Game game, GuildAllianceReleaseEvent releaseEvent);

	// RVA: -1 Offset: -1 Slot: 370
	public abstract void OnEventGuildAllianceUpdateInfo(Game game, GuildAllianceUpdateInfoEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 371
	public abstract void OnEventGuildAllianceChangeChatLink(Game game, GuildAllianceChangeChatLinkEvent changeEvent);

	// RVA: -1 Offset: -1 Slot: 372
	public abstract void OnPartyInvitation(Game game, PartyInvitationResponse response);

	// RVA: -1 Offset: -1 Slot: 373
	public abstract void OnPartyInviteCancel(Game game, PartyInviteCancelResponse response, short returnCode, string debugMessage);

	// RVA: -1 Offset: -1 Slot: 374
	public abstract void OnPartySenderInvitedCancel(Game game, PartySenderInvitedCancelResponse response, short returnCode, string debugMessage);

	// RVA: -1 Offset: -1 Slot: 375
	public abstract void OnPartyAcceptance(Game game, PartyAcceptanceResponse response);

	// RVA: -1 Offset: -1 Slot: 376
	public abstract void OnPartySecede(Game game, short returnCode);

	// RVA: -1 Offset: -1 Slot: 377
	public abstract void OnPartyUnreceivedMessage(Game game, PartyUnreceivedMessageResponse response);

	// RVA: -1 Offset: -1 Slot: 378
	public abstract void OnPartyLinkInvitation(Game game, PartyLinkInvitationResponse response);

	// RVA: -1 Offset: -1 Slot: 379
	public abstract void OnPartyLinkInviteCancel(Game game, PartyLinkInviteCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 380
	public abstract void OnPartyLinkSenderInvitedCancel(Game game);

	// RVA: -1 Offset: -1 Slot: 381
	public abstract void OnPartyLinkConsent(Game game, PartyLinkConsentResponse response);

	// RVA: -1 Offset: -1 Slot: 382
	public abstract void OnPartyLinkRelease(Game game);

	// RVA: -1 Offset: -1 Slot: 383
	public abstract void OnPartyLotteryRecruitStart(Game game, LotteryRecruitStartResponse response);

	// RVA: -1 Offset: -1 Slot: 384
	public abstract void OnPartyLotteryRecruitCancel(Game game, LotteryRecruitCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 385
	public abstract void OnPartyLotteryStart(Game game, LotteryStartResponse response);

	// RVA: -1 Offset: -1 Slot: 386
	public abstract void OnPartyLotteryJoin(Game game, LotteryJoinResponse response);

	// RVA: -1 Offset: -1 Slot: 387
	public abstract void OnPartyLotteryInfo(Game game, LotteryInfoResponse response);

	// RVA: -1 Offset: -1 Slot: 388
	public abstract void OnPartyLotteryListClear(Game game, LotteryListClearResponse response);

	// RVA: -1 Offset: -1 Slot: 389
	public abstract void OnPartyLotteryRecruitReSend(Game game, LotteryRecruitReSendResponse response);

	// RVA: -1 Offset: -1 Slot: 390
	public abstract void OnEventPartyLogin(Game game, PartyLoginEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 391
	public abstract void OnEventPartyLogout(Game game, PartyLogoutEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 392
	public abstract void OnEventPartyJoin(Game game, PartyJoinEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 393
	public abstract void OnEventPartyState(Game game, PartyStateLightEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 394
	public abstract void OnEventPartyStatus(Game game, PartyStatusLightEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 395
	public abstract void OnEventPartyFieldJoin(Game game, int partyId, Archetype joinArchetype);

	// RVA: -1 Offset: -1 Slot: 396
	public abstract void OnEventPartyFieldLeave(Game game, int partyId, byte archetypeType, int archetypeId);

	// RVA: -1 Offset: -1 Slot: 397
	public abstract void OnEventPartyRelated(Game game, PartyRelatedEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 398
	public abstract void OnEventPartyInvitation(Game game, PartyInvitationEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 399
	public abstract void OnEventPartyInviteCancel(Game game, PartyInviteCancelEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 400
	public abstract void OnEventPartySenderInvitedCancel(Game game, PartySenderInvitedCancelEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 401
	public abstract void OnEventPartyTimeoutInviteCancel(Game game, PartyInviteTimeoutEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 402
	public abstract void OnEventPartyKickout(Game game, PartyKickoutEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 403
	public abstract void OnEventPartySecede(Game game, PartySecedeEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 404
	public abstract void OnEventPartyDissolution(Game game, PartyDissolutionEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 405
	public abstract void OnEventPartyLeaderChange(Game game, PartyLeaderChangeEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 406
	public abstract void OnEventPartyLinkState(Game game, PartyLinkStateEvent linkEvent);

	// RVA: -1 Offset: -1 Slot: 407
	public abstract void OnEventPartyLinkInvite(Game game, PartyLinkInviteEvent linkEvent);

	// RVA: -1 Offset: -1 Slot: 408
	public abstract void OnEventPartyLinkCancel(Game game, PartyLinkCancelEvent linkEvent);

	// RVA: -1 Offset: -1 Slot: 409
	public abstract void OnEventPartyLinkSenderCancel(Game game, PartyLinkSenderCancelEvent linkEvent);

	// RVA: -1 Offset: -1 Slot: 410
	public abstract void OnEventPartyLinkConsent(Game game, PartyLinkConsentEvent linkEvent);

	// RVA: -1 Offset: -1 Slot: 411
	public abstract void OnEventPartyLinkRelease(Game game);

	// RVA: -1 Offset: -1 Slot: 412
	public abstract void OnEventPartyLotteryRecruit(Game game, PartyLotteryRecruitEvent partyEvent);

	// RVA: -1 Offset: -1 Slot: 413
	public abstract void OnEventPartyRecruitmentAdd(Game game, PartyRecruitmentAddEvent addEvent);

	// RVA: -1 Offset: -1 Slot: 414
	public abstract void OnEventPartyRecruitmentUpdate(Game game, PartyRecruitmentUpdateEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 415
	public abstract void OnEventPartyRecruitmentRemove(Game game, PartyRecruitmentRemoveEvent removeEvent);

	// RVA: -1 Offset: -1 Slot: 416
	public abstract void OnEventPartyRecruitmentApply(Game game, PartyRecruitmentApplyEvent applyEvent);

	// RVA: -1 Offset: -1 Slot: 417
	public abstract void OnEventPartyRecruitmentCandidateCancel(Game game, PartyRecruitmentCandidateCancelEvent cancelEvent);

	// RVA: -1 Offset: -1 Slot: 418
	public abstract void OnEventPartyRecruitmentApplyCancel(Game game, PartyRecruitmentApplyCancelEvent cancelEvent);

	// RVA: -1 Offset: -1 Slot: 419
	public abstract void OnEventRecruitmentApprove(Game game, PartyRecruitmentApproveEvent approveEvent);

	// RVA: -1 Offset: -1 Slot: 420
	public abstract void OnEventRecruitmentJoin(Game game, PartyRecruitmentJoinEvent joinEvent);

	// RVA: -1 Offset: -1 Slot: 421
	public abstract void OnEventRecruitmentQuit(Game game, PartyRecruitmentQuitEvent quitEvent);

	// RVA: -1 Offset: -1 Slot: 422
	public abstract void OnEventTradeRequest(Game game, TradeRequestEvent_ tradeEvent);

	// RVA: -1 Offset: -1 Slot: 423
	public abstract void OnEventTradeRequestSenderCancel(Game game, TradeRequestSenderCancelEvent_ tradeEvent);

	// RVA: -1 Offset: -1 Slot: 424
	public abstract void OnEventTradeStart(Game game, TradeStartEvent_ tradeEvent);

	// RVA: -1 Offset: -1 Slot: 425
	public abstract void OnEventTradeState(Game game, TradeStateEvent_ tradeEvent);

	// RVA: -1 Offset: -1 Slot: 426
	public abstract void OnEventTradeApprovalStart(Game game, TradeApprovalStartEvent_ tradeEvent);

	// RVA: -1 Offset: -1 Slot: 427
	public abstract void OnEventTradeResult(Game game, TradeResultEvent_ tradeEvent);

	// RVA: -1 Offset: -1 Slot: 428
	public abstract void OnEventTradeCancel(Game game, TradeCancelEvent_ tradeEvent);

	// RVA: -1 Offset: -1 Slot: 429
	public abstract void OnEventTradeAbnormal(Game game, TradeAbnormalEvent_ tradeEvent);

	// RVA: -1 Offset: -1 Slot: 430
	public abstract void OnCristaAttach(Game game, CristaAttachResponse response);

	// RVA: -1 Offset: -1 Slot: 431
	public abstract void OnCristaBreak(Game game, CristaBreakResponse response);

	// RVA: -1 Offset: -1 Slot: 432
	public abstract void OnReinforceCristaAttach(Game game, ReinforceCristaAttachResponse response);

	// RVA: -1 Offset: -1 Slot: 433
	public abstract void OnChannelGetList(Game game, ChannelGetListResponse response);

	// RVA: -1 Offset: -1 Slot: 434
	public abstract void OnChannelGetWorld(Game game, ChannelGetWorldResponse response);

	// RVA: -1 Offset: -1 Slot: 435
	public abstract void OnChannelChange(Game game);

	// RVA: -1 Offset: -1 Slot: 436
	public abstract void OnChannelGetGlobal(Game game, ChannelGetGlobalResponse response);

	// RVA: -1 Offset: -1 Slot: 437
	public abstract void OnGlobalChange(Game game, GlobalChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 438
	public abstract void OnCheckBossSymbol(Game game, CheckBossSymbolResponse response);

	// RVA: -1 Offset: -1 Slot: 439
	public abstract void OnCheckDefenceRoom(Game game, CheckDefenceRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 440
	public abstract void OnCheckWaveRoom(Game game, CheckWaveRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 441
	public abstract void OnRoomState(Game game, RoomStateResponse response);

	// RVA: -1 Offset: -1 Slot: 442
	public abstract void OnRoomGroupSettingChange(Game game, RoomGroupSettingChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 443
	public abstract void OnRoomJoinCancel(Game game);

	// RVA: -1 Offset: -1 Slot: 444
	public abstract void OnRoomStartEntry(Game game);

	// RVA: -1 Offset: -1 Slot: 445
	public abstract void OnRoomJoinReady(Game game, RoomJoinReadyResponse response);

	// RVA: -1 Offset: -1 Slot: 446
	public abstract void OnRoomJoinReadyCancel(Game game, RoomJoinReadyCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 447
	public abstract void OnRoomBattleStart(Game game);

	// RVA: -1 Offset: -1 Slot: 448
	public abstract void OnRoomBattleJoin(Game game);

	// RVA: -1 Offset: -1 Slot: 449
	public abstract void OnLeaveRoom(Game game);

	// RVA: -1 Offset: -1 Slot: 450
	public abstract void OnCheckDungeonRoom(Game game, CheckDungeonRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 451
	public abstract void OnDungeonGroupSettingChange(Game game, DungeonGroupSettingChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 452
	public abstract void OnManaMagicCharge(Game game, ManaMagicChargeResponse response);

	// RVA: -1 Offset: -1 Slot: 453
	public abstract void OnCheckRaidBossSymbol(Game game, CheckRaidBossSymbolResponse response);

	// RVA: -1 Offset: -1 Slot: 454
	public abstract void OnRoomLobbyState(Game game, RoomLobbyStateResponse response);

	// RVA: -1 Offset: -1 Slot: 455
	public abstract void OnRoomLobbyLeave(Game game);

	// RVA: -1 Offset: -1 Slot: 456
	public abstract void OnRoomLobbySettingChange(Game game, RoomLobbySettingChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 457
	public abstract void OnRoomLobbyJoin(Game game, RoomLobbyJoinResponse response);

	// RVA: -1 Offset: -1 Slot: 458
	public abstract void OnRoomLobbyJoinCancel(Game game, RoomLobbyJoinCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 459
	public abstract void OnRoomLobbyBattleStart(Game game);

	// RVA: -1 Offset: -1 Slot: 460
	public abstract void OnRoomLobbyBattleJoin(Game game);

	// RVA: -1 Offset: -1 Slot: 461
	public abstract void OnRoomStart(Game game, RoomStartResponse response);

	// RVA: -1 Offset: -1 Slot: 462
	public abstract void OnRoomSecondPartyRegistry(Game game);

	// RVA: -1 Offset: -1 Slot: 463
	public abstract void OnRoomSecondPartyJoin(Game game);

	// RVA: -1 Offset: -1 Slot: 464
	public abstract void OnRoomUpdateEntreeStaging(Game game);

	// RVA: -1 Offset: -1 Slot: 465
	public abstract void OnCheckTreasureHuntRoom(Game game, CheckTreasureHuntRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 466
	public abstract void OnEventRoomBattleReady(Game game, RoomBattleReadyEvent roomEvent);

	// RVA: -1 Offset: -1 Slot: 467
	public abstract void OnEventRoomManagedMonster(Game game, RoomManagedMonsterEvent roomEvent);

	// RVA: -1 Offset: -1 Slot: 468
	public abstract void OnEventRoomBattleStart(Game game, RoomBattleStartEvent startEvent);

	// RVA: -1 Offset: -1 Slot: 469
	public abstract void OnEventRoomSupportUpdate(Game game, RoomSupportUpdateEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 470
	public abstract void OnEventRoomManagedArchetype(Game game, RoomArchetypeManagedEvent managedEvent);

	// RVA: -1 Offset: -1 Slot: 471
	public abstract void OnEventRoomAnnihilated(Game game, RoomAnnihilatedEvent annihilatedEvent);

	// RVA: -1 Offset: -1 Slot: 472
	public abstract void OnEventRoomSynchronization(Game game, RoomSynchronizationEvent syncEvent);

	// RVA: -1 Offset: -1 Slot: 473
	public abstract void OnEventVisitorMemberStatus(Game game, VisitorMemberStatusEvent statusEvent);

	// RVA: -1 Offset: -1 Slot: 474
	public abstract void OnEventRoomLobbyBattle(Game game, RoomLobbyBattleEvent lobbyEvent);

	// RVA: -1 Offset: -1 Slot: 475
	public abstract void OnEventLobbyMatchingStart(Game game);

	// RVA: -1 Offset: -1 Slot: 476
	public abstract void OnEventLobbyMatchingEnd(Game game, LobbyMatchingEndEvent matchingEvent);

	// RVA: -1 Offset: -1 Slot: 477
	public abstract void OnEventLobbyMatchingCountdownStart(Game game, LobbyMatchingCountdownStartEvent countdownEvent);

	// RVA: -1 Offset: -1 Slot: 478
	public abstract void OnEventLobbyMatchingCountdownReset(Game game, LobbyMatchingCountdownResetEvent countdownEvent);

	// RVA: -1 Offset: -1 Slot: 479
	public abstract void OnEventEnterRaidBossField(Game game, EnterRaidBossField enterEvent);

	// RVA: -1 Offset: -1 Slot: 480
	public abstract void OnEventRoomMatchingEnd(Game game, RoomMatchingEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 481
	public abstract void OnEventRoomNpcJoin(Game game, NpcArchetype npc, RoomNpcJoinEvent joinEvent);

	// RVA: -1 Offset: -1 Slot: 482
	public abstract void OnEventSecondPartyLeave(Game game, RoomSecondPartyLeaveEvent leaveEvent);

	// RVA: -1 Offset: -1 Slot: 483
	public abstract void OnEventEnterHighRaidField(Game game, EnterHighRaidField enterEvent);

	// RVA: -1 Offset: -1 Slot: 484
	public abstract void OnEventGuildRaidStartOverTime(Game game);

	// RVA: -1 Offset: -1 Slot: 485
	public abstract void OnEventMonsterManageHateState(Game game, RoomMonsterManageHateStateEvent stateEvent);

	// RVA: -1 Offset: -1 Slot: 486
	public abstract void OnEventMonsterDebugState(Game game, MobDebugStateEvent stateEvent);

	// RVA: -1 Offset: -1 Slot: 487
	public abstract void OnEventEnterGuildRaidField(Game game, EnterGuildRaidField enterEvent);

	// RVA: -1 Offset: -1 Slot: 488
	public abstract void OnEventRoomLobbyLeave(Game game, RoomLobbyLeaveEvent leaveEvent);

	// RVA: -1 Offset: -1 Slot: 489
	public abstract void OnEventBCollaborationMatchingStart(Game game, BCollaborationMatchingStartEvent matchingEvent);

	// RVA: -1 Offset: -1 Slot: 490
	public abstract void OnEventScoreAttackEndBattle(Game game, ScoreAttackEndBattleEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 491
	public abstract void OnDungeonTrapActive(Game game, byte senderType, int senderId, byte trapId);

	// RVA: -1 Offset: -1 Slot: 492
	public abstract void OnEnterDungeonField(Game game, EnterDungeonField events);

	// RVA: -1 Offset: -1 Slot: 493
	public abstract void OnActionDungeonTrap(Game game, GameReturnCode returnCode, DungeonTrapDamageResponseData events);

	// RVA: -1 Offset: -1 Slot: 494
	public abstract void OnActionDungeonTrapAttackData(Game game, GameReturnCode returnCode, DungeonTrapData trapData);

	// RVA: -1 Offset: -1 Slot: 495
	public abstract void OnActionEventDungeonTrapAttackData(Game game, DungeonTrapData trapData);

	// RVA: -1 Offset: -1 Slot: 496
	public abstract void OnActionOpenItemBox(Game game, int itemBoxId, ResultData resultData);

	// RVA: -1 Offset: -1 Slot: 497
	public abstract void OnDungeonDownstairs(Game game, DownstairsDungeonField dungeonDownstairs);

	// RVA: -1 Offset: -1 Slot: 498
	public abstract void OnDungeonBeat(Game game, short floor);

	// RVA: -1 Offset: -1 Slot: 499
	public abstract void OnCheckDungeonFloorDepth(Game game);

	// RVA: -1 Offset: -1 Slot: 500
	public abstract void OnDungeonGuildHomeEscape(Game game);

	// RVA: -1 Offset: -1 Slot: 501
	public abstract void OnEnterDefenceField(Game game, EnterDefenceField events);

	// RVA: -1 Offset: -1 Slot: 502
	public abstract void OnRoomRespawn(Game game, RoomRespawnResponse respawn);

	// RVA: -1 Offset: -1 Slot: 503
	public abstract void OnRoomWarpPosition(Game game, RoomWarpPositionResponse warpPosition);

	// RVA: -1 Offset: -1 Slot: 504
	public abstract void OnOrbOperationFailure(Game game, OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 505
	public abstract void OnOrbCourseUpdate(Game game, OrbCourseUpdateResponse response);

	// RVA: -1 Offset: -1 Slot: 506
	public abstract void OnOrbStoreUpdate(Game game, OrbStoreUpdateResponse response);

	// RVA: -1 Offset: -1 Slot: 507
	public abstract void OnOrbServiceBuy(Game game, OrbServiceBuyResponse response);

	// RVA: -1 Offset: -1 Slot: 508
	public abstract void OnOrbServicePrice(Game game, OrbServicePriceResponse response);

	// RVA: -1 Offset: -1 Slot: 509
	public abstract void OnOrbRenameServicePrice(Game engine, OrbRenameServicePriceResponse response);

	// RVA: -1 Offset: -1 Slot: 510
	public abstract void OnOrbUpdate(Game game, OrbUpdateResponse response);

	// RVA: -1 Offset: -1 Slot: 511
	public abstract void OnOrbBarter(Game game, OrbBarterResponse response);

	// RVA: -1 Offset: -1 Slot: 512
	public abstract void OnOrbTicketExchange(Game game, OrbTicketExchangeResponse response);

	// RVA: -1 Offset: -1 Slot: 513
	public abstract void OnOrbItemCheck(Game game, OrbItemCheckResponse response);

	// RVA: -1 Offset: -1 Slot: 514
	public abstract void OnOrbItemUse(Game game, OrbItemUseResponse response);

	// RVA: -1 Offset: -1 Slot: 515
	public abstract void OnOrbItemRespawn(Game game, OrbItemRespawnResponse response);

	// RVA: -1 Offset: -1 Slot: 516
	public abstract void OnOrbItemMagicCharge(Game game, OrbItemMagicChargeResponse response);

	// RVA: -1 Offset: -1 Slot: 517
	public abstract void OnOrbItemUseWarpTicket(Game game, OrbItemUseResponse response);

	// RVA: -1 Offset: -1 Slot: 518
	public abstract void OnOrbWroldWarp(Game game, OrbServiceBuyResponse response);

	// RVA: -1 Offset: -1 Slot: 519
	public abstract void OnOrbRecycling(Game game, OrbRecyclingResponse response);

	// RVA: -1 Offset: -1 Slot: 520
	public abstract void OnOrbEquipFlagChange(Game game, OrbEquipFlagChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 521
	public abstract void OnOrbStarGemPurchaseCheck(Game game, OrbStarGemPurchaseCheckResponse response);

	// RVA: -1 Offset: -1 Slot: 522
	public abstract void OnOrbStarGemExchange(Game game, OrbStarGemExchangeResponse response);

	// RVA: -1 Offset: -1 Slot: 523
	public abstract void OnOrbStarGemBag(Game game, OrbStarGemBagResponse response);

	// RVA: -1 Offset: -1 Slot: 524
	public abstract void OnOrbStarGemEquip(Game game, OrbStarGemEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 525
	public abstract void OnOrbStarGemBreak(Game game, OrbStarGemBreakResponse response);

	// RVA: -1 Offset: -1 Slot: 526
	public abstract void OnOrbStarGemReinforce(Game game, OrbStarGemReinforceResponse response);

	// RVA: -1 Offset: -1 Slot: 527
	public abstract void OnOrbStarGemEvolution(Game game, OrbStarGemEvolutionResponse response);

	// RVA: -1 Offset: -1 Slot: 528
	public abstract void OnEventOrbRelated(Game game, OrbRelatedEvent events);

	// RVA: -1 Offset: -1 Slot: 529
	public abstract void OnEventOrbBonusEnd(Game game, OrbBonusEndEvent events);

	// RVA: -1 Offset: -1 Slot: 530
	public abstract void OnBankOperationFailure(Game game, OperationResponse response);

	// RVA: -1 Offset: -1 Slot: 531
	public abstract void OnBankSetup(Game game, BankSetupResponse response);

	// RVA: -1 Offset: -1 Slot: 532
	public abstract void OnBankDepositGold(Game game, BankDepositGoldResponse response);

	// RVA: -1 Offset: -1 Slot: 533
	public abstract void OnBankWithdrawGold(Game game, BankWithdrawGoldResponse response);

	// RVA: -1 Offset: -1 Slot: 534
	public abstract void OnBankDepositMaterial(Game game, BankDepositMaterialResponse response);

	// RVA: -1 Offset: -1 Slot: 535
	public abstract void OnBankWithdrawMaterial(Game game, BankWithdrawMaterialResponse response);

	// RVA: -1 Offset: -1 Slot: 536
	public abstract void OnBankExpPotionPurchase(Game game, BankExpPotionPurchaseResponse response);

	// RVA: -1 Offset: -1 Slot: 537
	public abstract void OnBankExpPotionDeposit(Game game, BankExpPotionDepositResponse response);

	// RVA: -1 Offset: -1 Slot: 538
	public abstract void OnBankExpPotionUse(Game game, BankExpPotionUseResponse response);

	// RVA: -1 Offset: -1 Slot: 539
	public abstract void OnBankMarketDepositGold(Game game, BankMarketDepositGoldResponse response);

	// RVA: -1 Offset: -1 Slot: 540
	public abstract void OnBankMarketDepositMaterial(Game game, BankMarketDepositMaterialResponse response);

	// RVA: -1 Offset: -1 Slot: 541
	public abstract void OnBankMarketDepositExpPotion(Game game, BankMarketDepositExpPotionResponse response);

	// RVA: -1 Offset: -1 Slot: 542
	public abstract void OnEventExpPotionLevelup(Game game, ExpPotionLevelupEvent levelup);

	// RVA: -1 Offset: -1 Slot: 543
	public abstract void OnGameEventSet(Game game, SetEventResponse setEvent, short returnCode);

	// RVA: -1 Offset: -1 Slot: 544
	public abstract void OnGameEventGet(Game game, GetEventResponse getEvent, short returnCode);

	// RVA: -1 Offset: -1 Slot: 545
	public abstract void OnGameEventGetScenario(Game game, GameEventGetScenarioResponse getScenario, short returnCode);

	// RVA: -1 Offset: -1 Slot: 546
	public abstract void OnGameEventGetFlag(Game game, GameEventGetFlagResponse getFlag, short returnCode);

	// RVA: -1 Offset: -1 Slot: 547
	public abstract void OnGameEventSetFlag(Game game, GameEventSetFlagResponse setFlag, short returnCode);

	// RVA: -1 Offset: -1 Slot: 548
	public abstract void OnGameEventLogin(Game game, GameEventLoginResponse login, short returnCode);

	// RVA: -1 Offset: -1 Slot: 549
	public abstract void OnGameEventChangeField(Game game);

	// RVA: -1 Offset: -1 Slot: 550
	public abstract void OnGameEventResult(Game game, GameEventResultResponse result, short returnCode);

	// RVA: -1 Offset: -1 Slot: 551
	public abstract void OnEventEnterGameEventField(Game game, EnterGameEventField eventData);

	// RVA: -1 Offset: -1 Slot: 552
	public abstract void OnEventHeldGameEvent(Game game, HeldGameEvent eventData);

	// RVA: -1 Offset: -1 Slot: 553
	public abstract void OnAvatarGenericFlagList(Game game, AvatarGenericFlagListResponse response);

	// RVA: -1 Offset: -1 Slot: 554
	public abstract void OnUpdateGenericFlag(Game game, UpdateGenericFlagResponse response);

	// RVA: -1 Offset: -1 Slot: 555
	public abstract void OnEventAreaBonusReward(Game game, AreaBonusRewardEvent areaBonus);

	// RVA: -1 Offset: -1 Slot: 556
	public abstract void OnAreaBonusReward(Game game, AreaBonusResultResponse response);

	// RVA: -1 Offset: -1 Slot: 557
	public abstract void OnEventSystemMessage(Game game, SystemMessageEvent systemEvent);

	// RVA: -1 Offset: -1 Slot: 558
	public abstract void OnGetRoomGmEventMobData(Game game, GetRoomGmEventMobDataResponse response);

	// RVA: -1 Offset: -1 Slot: 559
	public abstract void OnEventPcPurchase(Game game, PcPurchaseEvent purchaseEvent);

	// RVA: -1 Offset: -1 Slot: 560
	public abstract void OnEventServerSetting(Game game, ServerSettingEvent settingEvent);

	// RVA: -1 Offset: -1 Slot: 561
	public abstract void OnOptionSettingChange(Game game, OptionSettingChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 562
	public abstract void OnDailyDartsGameEnter(Game game, DailyDartsGameEnterResponse response);

	// RVA: -1 Offset: -1 Slot: 563
	public abstract void OnDailyDartsGameThrowDarts(Game game, DailyDartsGameThrowDarts response);

	// RVA: -1 Offset: -1 Slot: 564
	public abstract void OnDailyDartsGameRewardItem(Game game, DailyDartsGameRewardItemResponse response);

	// RVA: -1 Offset: -1 Slot: 565
	public abstract void OnMiniGameJoin(Game game, MiniGameJoinResponse response);

	// RVA: -1 Offset: -1 Slot: 566
	public abstract void OnMiniGameLobbyJoin(Game game, MiniGameLobbyJoinResponse response);

	// RVA: -1 Offset: -1 Slot: 567
	public abstract void OnMiniGameLobbyReady(Game game, MiniGameLobbyReadyResponse response);

	// RVA: -1 Offset: -1 Slot: 568
	public abstract void OnMiniGameLobbyReadyCancel(Game game, MiniGameLobbyReadyCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 569
	public abstract void OnHideSeekCheck(Game game, HideSeekCheckResponse response);

	// RVA: -1 Offset: -1 Slot: 570
	public abstract void OnEventMiniGameLobbyMemberState(Game game, MiniGameLobbyMemberStateEvent eventData);

	// RVA: -1 Offset: -1 Slot: 571
	public abstract void OnEventMiniGameLobbyMatching(Game game, MiniGameLobbyMatchingEvent eventData);

	// RVA: -1 Offset: -1 Slot: 572
	public abstract void OnEventMiniGameLobbyMatched(Game game, MiniGameLobbyMatchedEvent eventData);

	// RVA: -1 Offset: -1 Slot: 573
	public abstract void OnEventMiniGameLobbyMatchingTimeout(Game game, MiniGameMatchingTimeoutEvent eventData);

	// RVA: -1 Offset: -1 Slot: 574
	public abstract void OnEventMiniGameMatchingState(Game game, MiniGameMatchingStateEvent eventData);

	// RVA: -1 Offset: -1 Slot: 575
	public abstract void OnEventMiniGameMemberState(Game game, MiniGameMemberStateEvent eventData);

	// RVA: -1 Offset: -1 Slot: 576
	public abstract void OnEventMiniGameStart(Game game, MiniGameStartEvent eventData);

	// RVA: -1 Offset: -1 Slot: 577
	public abstract void OnEventMiniGameEnd(Game game, MiniGameEndEvent eventData);

	// RVA: -1 Offset: -1 Slot: 578
	public abstract void OnEventSnowballFightItemPop(Game game, SnowballFightItemPopEvent eventData);

	// RVA: -1 Offset: -1 Slot: 579
	public abstract void OnEventSummerFishCreate(Game game, SummerFishCreateEvent createEvent);

	// RVA: -1 Offset: -1 Slot: 580
	public abstract void OnEventSummerFishAction(Game game, SummerFishActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 581
	public abstract void OnEventSummerBossPop(Game game, SummerBossPopEvent popEvent);

	// RVA: -1 Offset: -1 Slot: 582
	public abstract void OnEventSummerOwnerLeave(Game game, SummerOwnerLeaveEvent leaveEvent);

	// RVA: -1 Offset: -1 Slot: 583
	public abstract void OnEventSummerMember(Game game, SummerMemberEvent memberEvent);

	// RVA: -1 Offset: -1 Slot: 584
	public abstract void OnEventSummerRuleChange(Game game, SummerRuleChangeEvent ruleEvent);

	// RVA: -1 Offset: -1 Slot: 585
	public abstract void OnEventSummerGameStart(Game game, SummerGameStartEvent startEvent);

	// RVA: -1 Offset: -1 Slot: 586
	public abstract void OnEventSummerGameEnd(Game game, SummerGameEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 587
	public abstract void OnEventSummerGameState(Game game, SummerGameStateEvent stateEvent);

	// RVA: -1 Offset: -1 Slot: 588
	public abstract void OnEventSummerPlayerRespawn(Game game, SummerPlayerRespawnEvent respawnEvent);

	// RVA: -1 Offset: -1 Slot: 589
	public abstract void OnEventSummerMemberDead(Game game, SummerMemberDeadEvent deadEvent);

	// RVA: -1 Offset: -1 Slot: 590
	public abstract void OnHouseEnter(Game game);

	// RVA: -1 Offset: -1 Slot: 591
	public abstract void OnHouseLeave(Game game);

	// RVA: -1 Offset: -1 Slot: 592
	public abstract void OnHouseInitialLandPurchase(Game game, HouseInitialLandPurchaseResponse response);

	// RVA: -1 Offset: -1 Slot: 593
	public abstract void OnHouseStartEditMode(Game game, HouseStartEditModeResponse response);

	// RVA: -1 Offset: -1 Slot: 594
	public abstract void OnHouseEndEditMode(Game game, HouseEndEditModeResponse response);

	// RVA: -1 Offset: -1 Slot: 595
	public abstract void OnHouseSave(Game game, HouseSaveResponse response);

	// RVA: -1 Offset: -1 Slot: 596
	public abstract void OnHouseEntryCheck(Game game, HouseEntryCheckResponse response);

	// RVA: -1 Offset: -1 Slot: 597
	public abstract void OnHouseSaveEntry(Game game, HouseSaveEntryResponse response);

	// RVA: -1 Offset: -1 Slot: 598
	public abstract void OnHouseOtherList(Game game, HouseOtherListResponse response);

	// RVA: -1 Offset: -1 Slot: 599
	public abstract void OnHousePartitionEdit(Game game, HousePartitionEditResponse response);

	// RVA: -1 Offset: -1 Slot: 600
	public abstract void OnHouseConstruction(Game game, HouseConstructionResponse response);

	// RVA: -1 Offset: -1 Slot: 601
	public abstract void OnHouseLandPurchase(Game game, HouseLandPurchaseResponse response);

	// RVA: -1 Offset: -1 Slot: 602
	public abstract void OnHouseCoordinate(Game game, HouseCoordinateResponse response);

	// RVA: -1 Offset: -1 Slot: 603
	public abstract void OnHouseCoordinate(Game game, HouseCoordinateRemovesResponse response);

	// RVA: -1 Offset: -1 Slot: 604
	public abstract void OnHouseBelonginsList(Game game, HouseBelonginsListResponse response);

	// RVA: -1 Offset: -1 Slot: 605
	public abstract void OnHouseCreateObjItem(Game game, HouseCreateObjItemResponse response);

	// RVA: -1 Offset: -1 Slot: 606
	public abstract void OnHouseUpdateObjItem(Game game, HouseUpdateObjItemResponse response);

	// RVA: -1 Offset: -1 Slot: 607
	public abstract void OnHouseBgmChange(Game game, HouseBgmChangeResponse response);

	// RVA: -1 Offset: -1 Slot: 608
	public abstract void OnHouseListAnchor(Game game, HouseListAnchorResponse response);

	// RVA: -1 Offset: -1 Slot: 609
	public abstract void OnHouseKeepPet(Game game, HouseKeepPetResponse response);

	// RVA: -1 Offset: -1 Slot: 610
	public abstract void OnHousePetNaming(Game game, HousePetNamingResponse response);

	// RVA: -1 Offset: -1 Slot: 611
	public abstract void OnHouseFeedPet(Game game, HouseFeedPetResponse response);

	// RVA: -1 Offset: -1 Slot: 612
	public abstract void OnHouseTrainPet(Game game, HouseTrainPetResponse response);

	// RVA: -1 Offset: -1 Slot: 613
	public abstract void OnHouseTrainFirstSkillPet(Game game, HouseTrainFirstSkillPetResponse response);

	// RVA: -1 Offset: -1 Slot: 614
	public abstract void OnHousePetStatusUp(Game game, HousePetStatusUpResponse response);

	// RVA: -1 Offset: -1 Slot: 615
	public abstract void OnHousePetSkillSet(Game game, HousePetSkillSetResponse response);

	// RVA: -1 Offset: -1 Slot: 616
	public abstract void OnHousePetStatusReset(Game game, HousePetStatusResetResponse response);

	// RVA: -1 Offset: -1 Slot: 617
	public abstract void OnHouseEntrustPet(Game game, HouseEntrustPetResponse response);

	// RVA: -1 Offset: -1 Slot: 618
	public abstract void OnHouseTakePet(Game game, HouseTakePetResponse response);

	// RVA: -1 Offset: -1 Slot: 619
	public abstract void OnHouseExilePet(Game game, HouseExilePetResponse response);

	// RVA: -1 Offset: -1 Slot: 620
	public abstract void OnHouseKennelPurchase(Game game, HouseKennelPurchaseResponse response);

	// RVA: -1 Offset: -1 Slot: 621
	public abstract void OnHousePetUsePotion(Game game, HousePetUsePotionResponse response);

	// RVA: -1 Offset: -1 Slot: 622
	public abstract void OnHousePetOwnershipUpdate(Game game, HousePetOwnershipUpdateResponse response);

	// RVA: -1 Offset: -1 Slot: 623
	public abstract void OnHousePetSynthesis(Game game, HousePetSynthesisResponse response);

	// RVA: -1 Offset: -1 Slot: 624
	public abstract void OnHouseFeedStray(Game game, HouseFeedStrayResponse response);

	// RVA: -1 Offset: -1 Slot: 625
	public abstract void OnHouseKeepStray(Game game, HouseKeepStrayResponse response);

	// RVA: -1 Offset: -1 Slot: 626
	public abstract void OnHouseExileStray(Game game, HouseExileStrayResponse response);

	[Obsolete("rm24855適応後削除予定")]
	// RVA: -1 Offset: -1 Slot: 627
	public abstract void OnRhythmEnter(Game game);

	[Obsolete("rm24855適応後削除予定")]
	// RVA: -1 Offset: -1 Slot: 628
	public abstract void OnRhythmJoin(Game game, RhythmJoinResponse response);

	[Obsolete("rm24855適応後削除予定")]
	// RVA: -1 Offset: -1 Slot: 629
	public abstract void OnRhythmSetting(Game game);

	[Obsolete("rm24855適応後削除予定")]
	// RVA: -1 Offset: -1 Slot: 630
	public abstract void OnRhythmReady(Game game);

	[Obsolete("rm24855適応後削除予定")]
	// RVA: -1 Offset: -1 Slot: 631
	public abstract void OnRhythmReadyCancel(Game game);

	[Obsolete("rm24855適応後削除予定")]
	// RVA: -1 Offset: -1 Slot: 632
	public abstract void OnRhythmStart(Game game);

	[Obsolete("rm24855適応後削除予定")]
	// RVA: -1 Offset: -1 Slot: 633
	public abstract void OnRhythmGiveup(Game game);

	[Obsolete("rm24855適応後削除予定")]
	// RVA: -1 Offset: -1 Slot: 634
	public abstract void OnRhythmFinish(Game game);

	[Obsolete("rm24855適応後削除予定")]
	// RVA: -1 Offset: -1 Slot: 635
	public abstract void OnRhythmResult(Game game);

	[Obsolete("rm24855適応後削除予定")]
	// RVA: -1 Offset: -1 Slot: 636
	public abstract void OnRhythmLeave(Game game);

	// RVA: -1 Offset: -1 Slot: 637
	public abstract void OnBlackKnightEnter(Game game);

	// RVA: -1 Offset: -1 Slot: 638
	public abstract void OnBlackKnightLeave(Game game);

	// RVA: -1 Offset: -1 Slot: 639
	public abstract void OnBlackKnightJoin(Game game, BlackKnightJoinResponse response);

	// RVA: -1 Offset: -1 Slot: 640
	public abstract void OnBlackKnightSelectSaveData(Game game);

	// RVA: -1 Offset: -1 Slot: 641
	public abstract void OnBlackKnightDeleteSaveData(Game game);

	// RVA: -1 Offset: -1 Slot: 642
	public abstract void OnBlackKnightChangeEquip(Game game);

	// RVA: -1 Offset: -1 Slot: 643
	public abstract void OnBlackKnightChangeAvatar(Game game);

	// RVA: -1 Offset: -1 Slot: 644
	public abstract void OnBlackKnightLootBox(Game game, BlackKnightLootBoxResponse response);

	// RVA: -1 Offset: -1 Slot: 645
	public abstract void OnBlackKnightUpdateRanking(Game game, BlackKnightUpdateRankingResponse response);

	// RVA: -1 Offset: -1 Slot: 646
	public abstract void OnBlackKnightStartGame(Game game);

	// RVA: -1 Offset: -1 Slot: 647
	public abstract void OnBlackKnightNextStage(Game game);

	// RVA: -1 Offset: -1 Slot: 648
	public abstract void OnBlackKnightEndGame(Game game);

	// RVA: -1 Offset: -1 Slot: 649
	public abstract void OnCardGameEnter(Game game);

	// RVA: -1 Offset: -1 Slot: 650
	public abstract void OnCardGameJoin(Game game, CardGameJoinResponse response);

	// RVA: -1 Offset: -1 Slot: 651
	public abstract void OnCardGameReady(Game game);

	// RVA: -1 Offset: -1 Slot: 652
	public abstract void OnCardGameReadyCancel(Game game);

	// RVA: -1 Offset: -1 Slot: 653
	public abstract void OnCardGameGiveup(Game game);

	// RVA: -1 Offset: -1 Slot: 654
	public abstract void OnCardGameResultEnd(Game game);

	// RVA: -1 Offset: -1 Slot: 655
	public abstract void OnCardGameLeave(Game game);

	// RVA: -1 Offset: -1 Slot: 656
	public abstract void OnCardGameTurnEnd(Game game);

	// RVA: -1 Offset: -1 Slot: 657
	public abstract void OnCardGameReconnectPlay(Game game, CardGameReconnectPlayResponse response);

	// RVA: -1 Offset: -1 Slot: 658
	public abstract void OnCardGameReconnectResult(Game game, CardGameReconnectResultResponse response);

	// RVA: -1 Offset: -1 Slot: 659
	public abstract void OnCardGameTableCheck(Game game, CardGameTableCheckResponse response);

	// RVA: -1 Offset: -1 Slot: 660
	public abstract void OnCardGameLastChanceEnd(Game game);

	// RVA: -1 Offset: -1 Slot: 661
	public abstract void OnCardGameSettingUpdate(Game game);

	// RVA: -1 Offset: -1 Slot: 662
	public abstract void OnEventRhythmGameState(Game game, RhythmGameStateEvent state);

	// RVA: -1 Offset: -1 Slot: 663
	public abstract void OnEventRhythmGameStartPrepare(Game game, RhythmGameStartPrepareEvent prepare);

	// RVA: -1 Offset: -1 Slot: 664
	public abstract void OnEventRhythmGameStart(Game game, RhythmGameStartEvent start);

	// RVA: -1 Offset: -1 Slot: 665
	public abstract void OnEventRhythmGameGiveup(Game game, RhythmGameGiveupEvent giveup);

	// RVA: -1 Offset: -1 Slot: 666
	public abstract void OnEventRhythmGameScoreState(Game game, RhythmGameScoreStateEvent state);

	// RVA: -1 Offset: -1 Slot: 667
	public abstract void OnEventRhythmGameResult(Game game, RhythmGameResultEvent result);

	// RVA: -1 Offset: -1 Slot: 668
	public abstract void OnEventRhythmGameEnd(Game game, RhythmGameEndEvent end);

	// RVA: -1 Offset: -1 Slot: 669
	public abstract void OnEventRhythmGameKickout(Game game, RhythmGameKickoutEvent kickout);

	// RVA: -1 Offset: -1 Slot: 670
	public abstract void OnEventHouseBgmChange(Game game, HouseBgmChangeEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 671
	public abstract void OnEventCardGameState(Game game, CardGameStateEvent state);

	// RVA: -1 Offset: -1 Slot: 672
	public abstract void OnEventCardGameStart(Game game, CardGameStartEvent start);

	// RVA: -1 Offset: -1 Slot: 673
	public abstract void OnEventCardGameGiveup(Game game, CardGameGiveupEvent giveup);

	// RVA: -1 Offset: -1 Slot: 674
	public abstract void OnEventCardGameEnd(Game game, CardGameEndEvent end);

	// RVA: -1 Offset: -1 Slot: 675
	public abstract void OnEventCardGameKickout(Game game, CardGameKickoutEvent kickout);

	// RVA: -1 Offset: -1 Slot: 676
	public abstract void OnEventCardGameTurnEnd(Game game, CardGameTurnEndEvent turn);

	// RVA: -1 Offset: -1 Slot: 677
	public abstract void OnEventCardGameLastChance(Game game, CardGameTurnEndLastChanceEvent turn);

	// RVA: -1 Offset: -1 Slot: 678
	public abstract void OnEventCardGameLastChanceEnd(Game game, CardGameLastChanceEndEvent turn);

	// RVA: -1 Offset: -1 Slot: 679
	public abstract void OnEventCraneGameGetItem(Game game, CraneGameGetItemEvent getItem);

	// RVA: -1 Offset: -1 Slot: 680
	public abstract void OnEventCuisineUpdate(Game game, CuisineUpdateEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 681
	public abstract void OnEventPetRaceState(Game game, PetRaceStateEvent state);

	// RVA: -1 Offset: -1 Slot: 682
	public abstract void OnEventPetRaceStart(Game game, PetRaceStartEvent start);

	// RVA: -1 Offset: -1 Slot: 683
	public abstract void OnEventPetRaceKickout(Game game, PetRaceKickoutEvent giveup);

	// RVA: -1 Offset: -1 Slot: 684
	public abstract void OnEventPetRaceEnd(Game game, PetRaceEndEvent end);

	// RVA: -1 Offset: -1 Slot: 685
	public abstract void OnEventPetRaceSettingPhaseEnd(Game game, PetRaceSettingPhaseEndEvent end);

	// RVA: -1 Offset: -1 Slot: 686
	public abstract void OnEventPetRaceReturnPreparation(Game game, PetRaceReturnPreparationEvent end);

	// RVA: -1 Offset: -1 Slot: 687
	public abstract void OnEventPetRaceRanking(Game game, PetRaceRankingEvent rank);

	// RVA: -1 Offset: -1 Slot: 688
	public abstract void OnEventMahjongJoinRoom(Game game, MahjongJoinRoomEvent join);

	// RVA: -1 Offset: -1 Slot: 689
	public abstract void OnEventMahjongLeaveRoom(Game game, MahjongLeaveRoomEvent leave);

	// RVA: -1 Offset: -1 Slot: 690
	public abstract void OnEventMahjongUpdateRoomState(Game game, MahjongUpdateRoomStateEvent update);

	// RVA: -1 Offset: -1 Slot: 691
	public abstract void OnEventMahjongKickoutMember(Game game, MahjongKickoutMemberEvent kickout);

	// RVA: -1 Offset: -1 Slot: 692
	public abstract void OnEventMahjongRoomDissolution(Game game);

	// RVA: -1 Offset: -1 Slot: 693
	public abstract void OnEventMahjongGameStart(Game game);

	// RVA: -1 Offset: -1 Slot: 694
	public abstract void OnEventMahjongChangeSetting(Game game, MahjongChangeSettingEvent change);

	// RVA: -1 Offset: -1 Slot: 695
	public abstract void OnEventMahjongStartRound(Game game, MahjongStartRoundEvent startEvent);

	// RVA: -1 Offset: -1 Slot: 696
	public abstract void OnEventMahjongDraw(Game game, MahjongDrawEvent drawEvent);

	// RVA: -1 Offset: -1 Slot: 697
	public abstract void OnEventMahjongDiscard(Game game, MahjongDiscardEvent discardEvent);

	// RVA: -1 Offset: -1 Slot: 698
	public abstract void OnEventMahjongWaitCall(Game game, MahjongWaitCallEvent waitEvent);

	// RVA: -1 Offset: -1 Slot: 699
	public abstract void OnEventMahjongCall(Game game, MahjongCallEvent callEvent);

	// RVA: -1 Offset: -1 Slot: 700
	public abstract void OnEventMahjongEndRound(Game game, MahjongEndRoundEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 701
	public abstract void OnEventMahjongSynchronization(Game game, MahjongSynchronizationEvent syncEvent);

	// RVA: -1 Offset: -1 Slot: 702
	public abstract void OnEventHouseBoughtPetSale(Game game, HouseBoughtPetSaleEvent boughtEvent);

	// RVA: -1 Offset: -1 Slot: 703
	public abstract void OnEventDefenceStartGame(Game game, DefenceStartGame startEvent);

	// RVA: -1 Offset: -1 Slot: 704
	public abstract void OnEventDefencePopMob(Game game, DefencePopMobEvent popEvent);

	// RVA: -1 Offset: -1 Slot: 705
	public abstract void OnEventDefenceMoveMob(Game game, DefenceMoveMobEvent moveEvent);

	// RVA: -1 Offset: -1 Slot: 706
	public abstract void OnEventDefenceTargetChangeMob(Game game, DefenceTargetChangeMobEvent targetChangeEvent);

	// RVA: -1 Offset: -1 Slot: 707
	public abstract void OnEventDefenceCrystalAttack(Game game, DefenceCrystalAttackEvent attackEvent);

	// RVA: -1 Offset: -1 Slot: 708
	public abstract void OnEventDefenceGameEnd(Game game, DefenceGameEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 709
	public abstract void OnDefenceRankingCurrentScoreResponse(Game game, DefenceCurrentScoreResponse response);

	// RVA: -1 Offset: -1 Slot: 710
	public abstract void OnDefenceRankingTop100Response(Game game, DefenceScoreRankingResponse response);

	// RVA: -1 Offset: -1 Slot: 711
	public abstract void OnDefenceWorldRankingTop100Response(Game game, DefenceScoreWorldRankingResponse response);

	// RVA: -1 Offset: -1 Slot: 712
	public abstract void OnDefenceRankingResultResponse(Game game, DefenceScoreResultRankingResponse response);

	// RVA: -1 Offset: -1 Slot: 713
	public abstract void OnDefenceRankingRewardResponse(Game game, DefenceScoreResultRewardResponse response);

	// RVA: -1 Offset: -1 Slot: 714
	public abstract void OnMailCheckResponse(Game game, MailCheckResponse checkResponse);

	// RVA: -1 Offset: -1 Slot: 715
	public abstract void OnMailChangeState(Game game, MailChangeStateResponse changeResponse);

	// RVA: -1 Offset: -1 Slot: 716
	public abstract void OnMailReceiveDeliveryResponse(Game game, MailReceiveDeliveryResponse response);

	// RVA: -1 Offset: -1 Slot: 717
	public abstract void OnMailSendResponse(Game game, MailSendResponse response);

	// RVA: -1 Offset: -1 Slot: 718
	public abstract void OnMailReplyResponse(Game game);

	// RVA: -1 Offset: -1 Slot: 719
	public abstract void OnMailHistoryCheckResponse(Game game, MailHistoryCheckResponse response);

	// RVA: -1 Offset: -1 Slot: 720
	public abstract void OnMailGetMessage(Game game, MailGetMessageResponse response);

	// RVA: -1 Offset: -1 Slot: 721
	public abstract void OnMailGetBox(Game game, MailGetBoxResponse response);

	// RVA: -1 Offset: -1 Slot: 722
	public abstract void OnMailGetBody(Game game, MailGetBodyResponse response);

	// RVA: -1 Offset: -1 Slot: 723
	public abstract void OnMailDeleteExpired(Game game, MailDeleteExpiredResponse response);

	// RVA: -1 Offset: -1 Slot: 724
	public abstract void OnReturnServer(Game game, ReturnServerResponse response);

	// RVA: -1 Offset: -1 Slot: 725
	public abstract void OnGlobalChannelGetList(Game game, GlobalChannelGetListResponse response);

	// RVA: -1 Offset: -1 Slot: 726
	public abstract void OnGlobalChannelGetWorld(Game game, GlobalChannelGetWorldResponse response);

	// RVA: -1 Offset: -1 Slot: 727
	public abstract void OnGlobalChannelChange(Game game);

	// RVA: -1 Offset: -1 Slot: 728
	public abstract void OnBanWordUpdate(Game game, BanWordUpdateResponse response);

	// RVA: -1 Offset: -1 Slot: 729
	public abstract void OnWatchEnd(Game game);

	// RVA: -1 Offset: -1 Slot: 730
	public abstract void OnEventMaintenance(Game game, MaintenanceEvent mainteEvent);

	// RVA: -1 Offset: -1 Slot: 731
	public abstract void OnEventSystemBan(Game game, SystemBanEvent banEvent);

	// RVA: -1 Offset: -1 Slot: 732
	public abstract void OnEventGameSystemUpdate(Game game, GameSystemUpdateEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 733
	public abstract void OnEventXSignature(Game game, XSignatureEvent signature);

	// RVA: -1 Offset: -1 Slot: 734
	public abstract void OnEventBanWordUpdate(Game game, BanWordUpdateEvent updateEvent);

	// RVA: -1 Offset: -1 Slot: 735
	public abstract void OnEventUserWatch(Game game, UserWatchEvent watch);

	// RVA: -1 Offset: -1 Slot: 736
	public abstract void OnEventWatchState(Game game, WatchStateEvent state);

	// RVA: -1 Offset: -1 Slot: 737
	public abstract void OnEventServerStaging(Game game, StagingEvent staging);

	// RVA: -1 Offset: -1 Slot: 738
	public abstract void OnEventWaveGameStart(Game game, WaveGameStartEvent startEvent);

	// RVA: -1 Offset: -1 Slot: 739
	public abstract void OnEventWaveNextWave(Game game, WaveNextWaveEvent nextWave);

	// RVA: -1 Offset: -1 Slot: 740
	public abstract void OnEventWavePopMob(Game game, WavePopMobEvent popEvent);

	// RVA: -1 Offset: -1 Slot: 741
	public abstract void OnEventWaveMoveMob(Game game, WaveMoveMobEvent moveEvent);

	// RVA: -1 Offset: -1 Slot: 742
	public abstract void OnEventWaveMoveDefenceObject(Game game, WaveMoveDefenceObjectEvent moveEvent);

	// RVA: -1 Offset: -1 Slot: 743
	public abstract void OnEventWaveTargetAttack(Game game, WaveTargetAttackEvent attackEvent);

	// RVA: -1 Offset: -1 Slot: 744
	public abstract void OnEventWaveMinusHate(Game game, WaveMinusHateEvent hateEvent);

	// RVA: -1 Offset: -1 Slot: 745
	public abstract void OnEventWaveTargetDamage(Game game, WaveTargetDamageEvent damageEvent);

	// RVA: -1 Offset: -1 Slot: 746
	public abstract void OnEventWaveGameEnd(Game game, WaveGameEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 747
	public abstract void OnEventTreasureHuntEnterGame(Game game, TreasureHuntEnterGameEvent enterEvent);

	// RVA: -1 Offset: -1 Slot: 748
	public abstract void OnEventTreasureHuntGameStart(Game game, TreasureHuntGameStartEvent startEvent);

	// RVA: -1 Offset: -1 Slot: 749
	public abstract void OnEventTreasureHuntPopMob(Game game, TreasureHuntPopMobEvent popEvent);

	// RVA: -1 Offset: -1 Slot: 750
	public abstract void OnEventTreasureHuntPopTreasure(Game game, TreasureHuntPopTreasureEvent popEvent);

	// RVA: -1 Offset: -1 Slot: 751
	public abstract void OnEventTreasureHuntMoveMob(Game game, TreasureHuntMoveMobEvent moveEvent);

	// RVA: -1 Offset: -1 Slot: 752
	public abstract void OnEventTreasureHuntChangeTimeLimit(Game game, TreasureHuntChangeTimeLimitEvent changeTimeLimitEvent);

	// RVA: -1 Offset: -1 Slot: 753
	public abstract void OnEventTreasurehuntAcqiureTreasure(Game game, TreasureHuntAcquireTreasureEvent acqiureTreasureEvent);

	// RVA: -1 Offset: -1 Slot: 754
	public abstract void OnEventTreasureHuntGameEnd(Game game, TreasureHuntGameEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 755
	public abstract void OnEventTreasureHuntUpdateBonusEvent(Game game, TreasureHuntUpdateBonusEvent bonusEvent);

	// RVA: -1 Offset: -1 Slot: 756
	public abstract void OnEventTreasureHuntTestGameEnd(Game game, TreasureHuntTestGameEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 757
	public abstract void OnActionSnowballFightThrow(Game game, GameReturnCode returnCode, SnowballFightThrowData response);

	// RVA: -1 Offset: -1 Slot: 758
	public abstract void OnActionSnowballFightCreate(Game game, GameReturnCode returnCode, SnowballFightCreateData response);

	// RVA: -1 Offset: -1 Slot: 759
	public abstract void OnActionSnowballFightDodge(Game game, GameReturnCode returnCode, SnowballFightDodgeData response);

	// RVA: -1 Offset: -1 Slot: 760
	public abstract void OnActionEventSnowballFightThrow(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 761
	public abstract void OnActionEventSnowballFightReload(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 762
	public abstract void OnActionEventSnowballFightDodge(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 763
	public abstract void OnActionEventSnowballFightAttack(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 764
	public abstract void OnActionSnowballFightDamage(Game game, GameReturnCode returnCode, SnowballFightDamageData response);

	// RVA: -1 Offset: -1 Slot: 765
	public abstract void OnActionEventSnowballFightDamage(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 766
	public abstract void OnActionSnowballFightDead(Game game, GameReturnCode returnCode, SnowballFightDeadData response);

	// RVA: -1 Offset: -1 Slot: 767
	public abstract void OnActionEventSnowballFightDead(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 768
	public abstract void OnActionSnowballFightResurrection(Game game, GameReturnCode returnCode, SnowballFightResurrectionData response);

	// RVA: -1 Offset: -1 Slot: 769
	public abstract void OnActionEventSnowballFightResurrection(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 770
	public abstract void OnActionSnowballFightGetItem(Game game, GameReturnCode returnCode, SnowballFightGetItemData response);

	// RVA: -1 Offset: -1 Slot: 771
	public abstract void OnActionEventSnowballFightGetItem(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 772
	public abstract void OnActionSnowballFightUseItem(Game game, GameReturnCode returnCode, SnowballFightUseItemData response);

	// RVA: -1 Offset: -1 Slot: 773
	public abstract void OnActionEventSnowballFightUseItem(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 774
	public abstract void OnActionSummerThrow(Game game, GameReturnCode returnCode, SummerThrowData response);

	// RVA: -1 Offset: -1 Slot: 775
	public abstract void OnActionSummerAttack(Game game, GameReturnCode returnCode, SummerAttackData response);

	// RVA: -1 Offset: -1 Slot: 776
	public abstract void OnActionSummerFishCreate(Game game, GameReturnCode returnCode, MobResponseData response);

	// RVA: -1 Offset: -1 Slot: 777
	public abstract void OnActionSummerFishMove(Game game, GameReturnCode returnCode, MobMoveEventData response);

	// RVA: -1 Offset: -1 Slot: 778
	public abstract void OnActionEventSummerFishResult(Game game, MobData[] mobs);

	// RVA: -1 Offset: -1 Slot: 779
	public abstract void OnActionEventSummerThrow(Game game, ArchetypeActionEvent events);

	// RVA: -1 Offset: -1 Slot: 780
	public abstract void OnEventBCollaborationEnterField(Game game, BCollaborationEnterField enterEvent);

	// RVA: -1 Offset: -1 Slot: 781
	public abstract void OnEventBCollaborationGameStart(Game game, BCollaborationGameStartEvent startEvent);

	// RVA: -1 Offset: -1 Slot: 782
	public abstract void OnEventBCollaborationGameEnd(Game game, BCollaborationGameEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 783
	public abstract void OnTreasureOpen(Game game, TreasureOpenResponse response);

	// RVA: -1 Offset: -1 Slot: 784
	public abstract void OnTreasureKeyInfo(Game game, TreasureKeyInfoResponse response);

	// RVA: -1 Offset: -1 Slot: 785
	public abstract void OnEventTreasureSetting(Game game, TreasureSettingEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 786
	public abstract void OnCultivationPlant(Game game, CultivationPlantResponse response);

	// RVA: -1 Offset: -1 Slot: 787
	public abstract void OnCultivationRemove(Game game, CultivationRemoveResponse response);

	// RVA: -1 Offset: -1 Slot: 788
	public abstract void OnCultivationHarvest(Game game, CultivationHarvestResponse response);

	// RVA: -1 Offset: -1 Slot: 789
	public abstract void OnCultivationWatering(Game game, CultivationWateringResponse response);

	// RVA: -1 Offset: -1 Slot: 790
	public abstract void OnCultivationGardenEnter(Game game, CultivationGardenEnterResponse response);

	// RVA: -1 Offset: -1 Slot: 791
	public abstract void OnCultivationGardenLeave(Game game, CultivationGardenLeaveResponse response);

	// RVA: -1 Offset: -1 Slot: 792
	public abstract void OnCultivationGetList(Game game, CultivationGetListResponse response);

	// RVA: -1 Offset: -1 Slot: 793
	public abstract void OnCuisineCooking(Game game, CuisineCookingResponse response);

	// RVA: -1 Offset: -1 Slot: 794
	public abstract void OnCuisineDineOut(Game game, CuisineDineOutResponse response);

	// RVA: -1 Offset: -1 Slot: 795
	public abstract void OnCuisineGetRecipe(Game game, CuisineGetRecipeResponse response);

	// RVA: -1 Offset: -1 Slot: 796
	public abstract void OnGetFoodPoint(Game game, GetFoodPointResponse response);

	// RVA: -1 Offset: -1 Slot: 797
	public abstract void OnGetEatingList(Game game, GetEatingListResponse response);

	// RVA: -1 Offset: -1 Slot: 798
	public abstract void OnEventCuisineBuffEnd(Game game, CuisineBuffEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 799
	public abstract void OnCuisineSubCooking(Game game, CuisineSubCookingResponse response);

	// RVA: -1 Offset: -1 Slot: 800
	public abstract void OnCuisineChangeType(Game game, CuisineChangeTypeResponse response);

	// RVA: -1 Offset: -1 Slot: 801
	public abstract void OnCuisineCleanUp(Game game, CuisineCleanUpResponse response);

	// RVA: -1 Offset: -1 Slot: 802
	public abstract void OnExchangeRun(Game game, ExchangeRunResponse response);

	// RVA: -1 Offset: -1 Slot: 803
	public abstract void OnExchangeGetMyData(Game game, ExchangeGetMyDataResponse response);

	// RVA: -1 Offset: -1 Slot: 804
	public abstract void OnGuildStaffChangeFlag(Game game, GuildStaffChangeFlagResponse response);

	// RVA: -1 Offset: -1 Slot: 805
	public abstract void OnGuildStaffChangeSupport(Game game, GuildStaffChangeSupportResponse response);

	// RVA: -1 Offset: -1 Slot: 806
	public abstract void OnGuildStaffRunningErrand(Game game, GuildStaffRunningErrandResponse response);

	// RVA: -1 Offset: -1 Slot: 807
	public abstract void OnGuildStaffRecoveryPlayer(Game game, GuildStaffRecoveryPlayerResponse response);

	// RVA: -1 Offset: -1 Slot: 808
	public abstract void OnEventGuildStaffEndHire(Game game, GuildStaffendHireEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 809
	public abstract void OnEventGuildStaffEndRunningErrand(Game game, GuildStaffEndRunningErrandEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 810
	public abstract void OnEventGuildStaffStartRunningErrand(Game game, GuildStaffStartRunningErrandEvent startEvent);

	// RVA: -1 Offset: -1 Slot: 811
	public abstract void OnHouseLotteryRecruitStart(Game game, HouseLotteryRecruitStartResponse response);

	// RVA: -1 Offset: -1 Slot: 812
	public abstract void OnHouseLotteryRecruitCancel(Game game, HouseLotteryRecruitCancelResponse response);

	// RVA: -1 Offset: -1 Slot: 813
	public abstract void OnHouseLotteryStart(Game game, HouseLotteryStartResponse response);

	// RVA: -1 Offset: -1 Slot: 814
	public abstract void OnHouseLotteryJoin(Game game, HouseLotteryJoinResponse response);

	// RVA: -1 Offset: -1 Slot: 815
	public abstract void OnHouseLotteryInfo(Game game, HouseLotteryInfoResponse response);

	// RVA: -1 Offset: -1 Slot: 816
	public abstract void OnHouseLotteryListClear(Game game, HouseLotteryListClearResponse response);

	// RVA: -1 Offset: -1 Slot: 817
	public abstract void OnHouseLotteryRecruitReSend(Game game, HouseLotteryRecruitReSendResponse response);

	// RVA: -1 Offset: -1 Slot: 818
	public abstract void OnEventHouseLotteryRecruit(Game game, HouseLotteryRecruitEvent houseEvent);

	// RVA: -1 Offset: -1 Slot: 819
	public abstract void OnEventWaveRaidEnter(Game game, WaveRaidEnterEvent enterEvent);

	// RVA: -1 Offset: -1 Slot: 820
	public abstract void OnEventWaveRaidGameStart(Game game, WaveRaidGameStartEvent startEvent);

	// RVA: -1 Offset: -1 Slot: 821
	public abstract void OnEventWaveRaidNextWave(Game game, WaveRaidNextWaveEvent nextWave);

	// RVA: -1 Offset: -1 Slot: 822
	public abstract void OnEventWaveRaidPopMob(Game game, WaveRaidPopMobEvent popEvent);

	// RVA: -1 Offset: -1 Slot: 823
	public abstract void OnEventWaveRaidMoveMob(Game game, WaveRaidMoveMobEvent moveEvent);

	// RVA: -1 Offset: -1 Slot: 824
	public abstract void OnEventWaveRaidMoveDefenceObject(Game game, WaveRaidMoveDefenceObjectEvent moveEvent);

	// RVA: -1 Offset: -1 Slot: 825
	public abstract void OnEventWaveRaidTargetAttack(Game game, WaveRaidTargetAttackEvent attackEvent);

	// RVA: -1 Offset: -1 Slot: 826
	public abstract void OnEventWaveRaidMinusHate(Game game, WaveRaidMinusHateEvent hateEvent);

	// RVA: -1 Offset: -1 Slot: 827
	public abstract void OnEventWaveRaidTargetDamage(Game game, WaveRaidTargetDamageEvent damageEvent);

	// RVA: -1 Offset: -1 Slot: 828
	public abstract void OnEventWaveRaidGameEnd(Game game, WaveRaidGameEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 829
	public abstract void OnCheckWaveRaidRoom(Game game, CheckWaveRaidRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 830
	public abstract void OnEventNewWaveEnter(Game game, NewWaveEnterEvent enterEvent);

	// RVA: -1 Offset: -1 Slot: 831
	public abstract void OnEventNewWaveGameStart(Game game, NewWaveGameStartEvent startEvent);

	// RVA: -1 Offset: -1 Slot: 832
	public abstract void OnEventNewWaveNextWave(Game game, NewWaveNextWaveEvent nextWave);

	// RVA: -1 Offset: -1 Slot: 833
	public abstract void OnEventNewWavePopMob(Game game, NewWavePopMobEvent popEvent);

	// RVA: -1 Offset: -1 Slot: 834
	public abstract void OnEventNewWaveMoveMob(Game game, NewWaveMoveMobEvent moveEvent);

	// RVA: -1 Offset: -1 Slot: 835
	public abstract void OnEventNewWaveTargetAttack(Game game, NewWaveTargetAttackEvent attackEvent);

	// RVA: -1 Offset: -1 Slot: 836
	public abstract void OnEventNewWaveMinusHate(Game game, NewWaveMinusHateEvent hateEvent);

	// RVA: -1 Offset: -1 Slot: 837
	public abstract void OnEventNewWaveTargetDamage(Game game, NewWaveTargetDamageEvent damageEvent);

	// RVA: -1 Offset: -1 Slot: 838
	public abstract void OnEventNewWaveGameEnd(Game game, NewWaveGameEndEvent endEvent);

	// RVA: -1 Offset: -1 Slot: 839
	public abstract void OnCheckNewWaveRoom(Game game, CheckNewWaveRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 840
	public abstract void OnRegistletProcessingGemCart(Game game, RegistletProcessingGemCartResponse response);

	// RVA: -1 Offset: -1 Slot: 841
	public abstract void OnRegistletEnhanceGemCart(Game game, RegistletEnhanceGemCartResponse response);

	// RVA: -1 Offset: -1 Slot: 842
	public abstract void OnRegistletExtensionSlot(Game game, RegistletExtensionSlotResponse response);

	// RVA: -1 Offset: -1 Slot: 843
	public abstract void OnregistletChangeGemCartEquip(Game game, RegistletChangeGemCartEquipResponse response);

	// RVA: -1 Offset: -1 Slot: 844
	public abstract void OnRegistletChangeGemCartFlag(Game game, RegistletChangeGemCartFlagResponse response);

	// RVA: -1 Offset: -1 Slot: 845
	public abstract void OnCheckHighRaidRoom(Game game, CheckHighRaidRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 846
	public abstract void OnGetChallengePoint(Game game, GetChallengePointResponse response);

	// RVA: -1 Offset: -1 Slot: 847
	public abstract void OnAddChallengePoint(Game game, AddChallengePointResponse response);

	// RVA: -1 Offset: -1 Slot: 848
	public abstract void OnGetHighRaidPoint(Game game, GetHighRaidPointResponse response);

	// RVA: -1 Offset: -1 Slot: 849
	public abstract void OnRunHighRaidExchange(Game game, RunHighRaidExchangeResponse response);

	// RVA: -1 Offset: -1 Slot: 850
	public abstract void OnGetHighRaidHeld(Game game, GetHighRaidListResponse response);

	// RVA: -1 Offset: -1 Slot: 851
	public abstract void OnGuildQuestGetQuest(Game game, GuildQuestGetQuestResponse response);

	// RVA: -1 Offset: -1 Slot: 852
	public abstract void OnGuildQuestReportQuest(Game game, GuildQuestReportQuestResponse response);

	// RVA: -1 Offset: -1 Slot: 853
	public abstract void OnGuildQuestDiscardQuest(Game game, GuildQuestDiscardResponse response);

	// RVA: -1 Offset: -1 Slot: 854
	public abstract void OnGuildQuestResetQuest(Game game, GuildQuestResetQuestResponse response);

	// RVA: -1 Offset: -1 Slot: 855
	public abstract void OnGuildRaidLobbyEnter(Game game);

	// RVA: -1 Offset: -1 Slot: 856
	public abstract void OnCheckGuildRaidRoom(Game game, CheckGuildRaidRoomResponse response);

	// RVA: -1 Offset: -1 Slot: 857
	public abstract void OnGuildRaidStaminaRecovery(Game game, GuildRaidStaminaRecoveryResponse response);

	// RVA: -1 Offset: -1 Slot: 858
	public abstract void OnEventMobaStartMatching(Game game, MobaStartMatchingEvent start);

	// RVA: -1 Offset: -1 Slot: 859
	public abstract void OnEventMobaCancelMatching(Game game, MobaCancelMatchingEvent start);

	// RVA: -1 Offset: -1 Slot: 860
	public abstract void OnEventMobaSuccessMatching(Game game, MobaSuccessMatchingEvent start);

	// RVA: -1 Offset: -1 Slot: 861
	public abstract void OnEventMobaPartyState(Game game, MobaPartyStateEvent state);

	// RVA: -1 Offset: -1 Slot: 862
	public abstract void OnEventMobaHeldState(Game game, MobaHeldStateEvent state);

	// RVA: -1 Offset: -1 Slot: 863
	public abstract void OnEventMobaGameEnd(Game game, MobaGameEndEvent end);

	// RVA: -1 Offset: -1 Slot: 864
	public abstract void OnMobaArchetypeAdded(Game game, Archetype item, Dictionary<byte, object> properties, int propertiesRevision);

	// RVA: -1 Offset: -1 Slot: 865
	public abstract void OnEventMobaLogin(Game game, MyArchetype avatar, MobaLoginEvent login);

	// RVA: -1 Offset: -1 Slot: 866
	public abstract void OnEventMobaRelogin(Game game, MyArchetype avatar, MobaReloginEvent relogin);

	// RVA: -1 Offset: -1 Slot: 867
	public abstract void OnEventMobaPhase(Game game, MobaPhaseEvent phase);

	// RVA: -1 Offset: -1 Slot: 868
	public abstract void OnEventMobaLevelup(Game game, MobaLevelupEvent levelup);

	// RVA: -1 Offset: -1 Slot: 869
	public abstract void OnEventMobaUpdateEquip(Game game, MobaUpdateEquipEvent equip);

	// RVA: -1 Offset: -1 Slot: 870
	public abstract void OnEventMobaKill(Game game, MobaKillEvent kill);

	// RVA: -1 Offset: -1 Slot: 871
	public abstract void OnEventMobaMember(Game game, MobaMemberEvent member);

	// RVA: -1 Offset: -1 Slot: 872
	public abstract void OnEventMobaChest(Game game, MobaChestEvent chest);

	// RVA: -1 Offset: -1 Slot: 873
	public abstract void OnEventMobaMemberState(Game game, MobaMemberStateEvent state);

	// RVA: -1 Offset: -1 Slot: 874
	public abstract void OnEventMobaMemberStatus(Game game, MobaMemberStatusEvent status);

	// RVA: -1 Offset: -1 Slot: 875
	public abstract void OnEventMobaDeadDrop(Game game, MobaDeadDropEvent drop);

	// RVA: -1 Offset: -1 Slot: 876
	public abstract void OnEventMobaSupplyEquip(Game game, MobaSupplyEquipEvent equip);

	// RVA: -1 Offset: -1 Slot: 877
	public abstract void OnEventMobaHeal(Game game, MobaHealEvent heal);

	// RVA: -1 Offset: -1 Slot: 878
	public abstract void OnEventMobaRoundResult(Game game, MobaRoundResultEvent result);

	// RVA: -1 Offset: -1 Slot: 879
	public abstract void OnEventMobaUnsuccessful(Game game, MobaUnsuccessfulEvent unsuccessful);

	// RVA: -1 Offset: -1 Slot: 880
	public abstract void OnEventMobaMobaDuelAbilityTrampleRemoveSkill(Game game, MobaDuelAbilityTrampleRemoveSupportEvent remove);

	// RVA: -1 Offset: -1 Slot: 881
	public abstract void OnActionEventMobaMobMove(Game game, byte archetypeType, int archetypeId, MoveDataLight moveEvent);

	// RVA: -1 Offset: -1 Slot: 882
	public abstract void OnActionEventMobaAreaDamage(Game game, ArchetypeActionEvent actionEvent);

	// RVA: -1 Offset: -1 Slot: 883
	public abstract void OnActionEventMobaMonsterResult(Game game, MobData[] mobs, MobaMonsterResultData resultData, bool isResend);

	// RVA: -1 Offset: -1 Slot: 884
	public abstract void OnActionEventMobaChangeHate(Game game, MobData[] mobs);

	// RVA: -1 Offset: -1 Slot: 885
	public abstract void OnEventGuildBBSJoin(Game game, GuildBBSJoinEvent guildEvent);

	// RVA: -1 Offset: -1 Slot: 886
	public abstract void OnEventGuildBBSAllowRequest(Game game, GuildBBSAllowRequestEvent guildEvent);

	// RVA: -1 Offset: -1 Slot: 887
	public abstract void OnEventGuildBBSJoinRequest(Game game, GuildBBSJoinRequestEvent guildEvent);

	// RVA: -1 Offset: -1 Slot: 888
	public abstract void OnEventItemRandomPropertyAddTriggerCount(Game game, ItemRandomPropertyAddTriggerCountEvent count);

	// RVA: -1 Offset: -1 Slot: 889
	public abstract void OnEventItemRandomPropertyStartEffect(Game game, ItemRandomPropertyStartEffectEvent start);

	// RVA: -1 Offset: -1 Slot: 890
	public abstract void OnEventItemRandomPropertyEndEffect(Game game, ItemRandomPropertyEndEffectEvent end);

	// RVA: -1 Offset: -1 Slot: 891
	public abstract void OnEventFishingHit(Game game, FishingHitEvent hit);

	// RVA: -1 Offset: -1 Slot: 892
	public abstract void OnEventFishingEndHit(Game game);

	// RVA: -1 Offset: -1 Slot: 893
	public abstract void OnEventFishingTimeOutMiniGame(Game game);

	// RVA: -1 Offset: -1 Slot: 894
	public abstract void OnEventFishingNoticeHitRateEvnet(Game game, NoticeHitRateEvent notice);

	// RVA: -1 Offset: -1 Slot: 895
	public abstract void OnEventFishingSuccessEvent(Game game, FishingSuccessEvent successEvent);

	// RVA: -1 Offset: -1 Slot: 896
	public abstract void OnEventComebackCp(Game game);

	// RVA: -1 Offset: -1 Slot: 897
	public abstract void OnEventMatchingJoinEvent(Game game, MatchingJoinEvent join);

	// RVA: -1 Offset: -1 Slot: 898
	public abstract void OnEventMatchingLeaveEvent(Game game, MatchingLeaveEvent leave);

	// RVA: -1 Offset: -1 Slot: 899
	public abstract void OnEventMatchingSuccessEvent(Game game, MatchingSuccessEvent update);

	// RVA: -1 Offset: -1 Slot: 900
	public abstract void OnEventRoguelikeEnterField(Game game, EnterRoguelikeField enterEvent);

	// RVA: -1 Offset: -1 Slot: 901
	public abstract void OnEventRoguelikeChangePhase(Game game, RoguelikeChangePhaseEvent phaseEvent);

	// RVA: -1 Offset: -1 Slot: 902
	public abstract void OnEventRoguelikeMemberBuffSelect(Game game, RoguelikeMemberBuffSelectEvent buffSelectEvent);

	// RVA: -1 Offset: -1 Slot: 903
	public abstract void OnEventRoguelikeResult(Game game, RoguelikeResultEvent resultEvent);

	// RVA: -1 Offset: -1 Slot: 904
	public abstract void OnEventRoguelikeFixedDamage(Game game, RoguelikeFixedDamageEvent fixedDamageEvent);

	// RVA: -1 Offset: -1 Slot: 905
	public abstract void OnEventRoguelikeIdleKick(Game game, RoguelikeIdleKickEvent idleKickEvent);
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PhotonListener : Singleton<PhotonListener>, IGameListener // TypeDefIndex: 4841
{
	// Fields
	private GameManager gameManager; // 0x20
	private bool isFirstLoader; // 0x28
	private bool isFirstLoadField; // 0x29
	private int recconectCount; // 0x2C
	private bool isEndXSignatureEvent; // 0x30
	private bool isFirstGuildLoginMes; // 0x31
	private bool isLoadAvatar; // 0x32
	private float loadAvatarTimer; // 0x34
	[CompilerGenerated]
	private Action<LoginResultType> OnCharacterCreateResult; // 0x38
	public Action OnCharacterCreateCall; // 0x40
	public Action<GameReturnCode> OnAvatarRenameResult; // 0x48
	[SerializeField]
	private DebugLevel debugLevel; // 0x50

	// Properties
	public bool IsFirstLoadField { get; }
	public bool IsEndXSignatureEvent { get; }
	public DebugLevel DebugLogLevel { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x25B26F4 Offset: 0x25AE6F4 VA: 0x25B26F4
	public void add_OnCharacterCreateResult(Action<LoginResultType> value) { }

	[CompilerGenerated]
	// RVA: 0x25B27A4 Offset: 0x25AE7A4 VA: 0x25B27A4
	public void remove_OnCharacterCreateResult(Action<LoginResultType> value) { }

	// RVA: 0x25B2854 Offset: 0x25AE854 VA: 0x25B2854
	public bool get_IsFirstLoadField() { }

	// RVA: 0x25B285C Offset: 0x25AE85C VA: 0x25B285C
	public bool get_IsEndXSignatureEvent() { }

	// RVA: 0x25B28EC Offset: 0x25AE8EC VA: 0x25B28EC
	public void Awake() { }

	// RVA: 0x25B298C Offset: 0x25AE98C VA: 0x25B298C
	private void Update() { }

	// RVA: 0x25B29EC Offset: 0x25AE9EC VA: 0x25B29EC Slot: 4
	public DebugLevel get_DebugLogLevel() { }

	// RVA: 0x25B29F4 Offset: 0x25AE9F4 VA: 0x25B29F4 Slot: 5
	public void LogDebug(Game game, string message) { }

	// RVA: 0x25B2AAC Offset: 0x25AEAAC VA: 0x25B2AAC Slot: 7
	public void LogError(Game game, Exception exception) { }

	// RVA: 0x25B2B64 Offset: 0x25AEB64 VA: 0x25B2B64 Slot: 6
	public void LogError(Game game, string message) { }

	// RVA: 0x25B2C1C Offset: 0x25AEC1C VA: 0x25B2C1C Slot: 10
	public void DebugPopError(Game game, GameReturnCode returnCode, string str) { }

	// RVA: 0x25B2C20 Offset: 0x25AEC20 VA: 0x25B2C20 Slot: 11
	public void DebugChatLogError(Game game, GameReturnCode returnCode, string str) { }

	// RVA: 0x25B2C24 Offset: 0x25AEC24 VA: 0x25B2C24 Slot: 12
	public void OnArchetypeAdded(Game game, Archetype item) { }

	// RVA: 0x25B2D50 Offset: 0x25AED50 VA: 0x25B2D50 Slot: 13
	public void OnArchetypeRemoved(Game game, Archetype item) { }

	// RVA: 0x25B2F24 Offset: 0x25AEF24 VA: 0x25B2F24 Slot: 139
	public void OnActionEventBattleEnd(Game game, byte archetypeType, int archetypeId) { }

	// RVA: 0x25B2FAC Offset: 0x25AEFAC VA: 0x25B2FAC Slot: 138
	public void OnActionEventBattleStart(Game game, byte archetypeType, int archetypeId) { }

	// RVA: 0x25B3034 Offset: 0x25AF034 VA: 0x25B3034 Slot: 17
	public void OnMasterConnect(Game game) { }

	// RVA: 0x25B315C Offset: 0x25AF15C VA: 0x25B315C Slot: 9
	public void OnMasterConnectLog(GameState state, StatusCode statusCode) { }

	// RVA: 0x25B32C8 Offset: 0x25AF2C8 VA: 0x25B32C8 Slot: 14
	public void OnDisconnect(Game game, StatusCode returnCode) { }

	// RVA: 0x25B32E4 Offset: 0x25AF2E4 VA: 0x25B32E4 Slot: 15
	public void OnDisconnectByServer(Game game, StatusCode statusCode) { }

	// RVA: 0x25B3560 Offset: 0x25AF560 VA: 0x25B3560
	public void OnDisconnectByServerWindow() { }

	[IteratorStateMachine(typeof(PhotonListener.<gameReconnect>d__36))]
	// RVA: 0x25B3564 Offset: 0x25AF564 VA: 0x25B3564
	private IEnumerator gameReconnect(Game game) { }

	// RVA: 0x25B35F4 Offset: 0x25AF5F4 VA: 0x25B35F4 Slot: 43
	public void OnGameReJoinFailure(Game game, OperationResponse response) { }

	[IteratorStateMachine(typeof(PhotonListener.<relogin>d__38))]
	// RVA: 0x25B3A18 Offset: 0x25AFA18 VA: 0x25B3A18
	private IEnumerator relogin(Game game) { }

	// RVA: 0x25B3AA8 Offset: 0x25AFAA8 VA: 0x25B3AA8 Slot: 44
	public void OnGameRejoinAvatarCreate(Game game, PeerResultCode resultCode, GameReJoinResponse rejoin) { }

	// RVA: 0x25B3B80 Offset: 0x25AFB80 VA: 0x25B3B80 Slot: 50
	public void OnGameRejoinLoader(Game game, GameReJoinResponse rejoin) { }

	// RVA: 0x25B3E80 Offset: 0x25AFE80 VA: 0x25B3E80
	public void OnGameRejoinMain(IEnterAvatarPacket avatarData, GameReJoinResponse rejoin) { }

	// RVA: 0x25B3F38 Offset: 0x25AFF38 VA: 0x25B3F38 Slot: 51
	public void OnGameRejoinMain(Game game, EnterAvatarData avatarData, GameReJoinResponse rejoin) { }

	// RVA: 0x25B3FDC Offset: 0x25AFFDC VA: 0x25B3FDC Slot: 53
	public void OnGameRejoinMain(Game game, EnterAvatarPacket avatarData, GameReJoinResponse rejoin) { }

	// RVA: 0x25B4080 Offset: 0x25B0080 VA: 0x25B4080 Slot: 52
	public void OnGameRejoinMain(Game game, EnterAvatarData2 avatarData, GameReJoinResponse rejoin) { }

	// RVA: 0x25B4124 Offset: 0x25B0124 VA: 0x25B4124 Slot: 55
	public void OnGameRejoinMiniGame(Game game, EnterAvatarData avatarData, GameReJoinResponse rejoin) { }

	// RVA: 0x25B418C Offset: 0x25B018C VA: 0x25B418C Slot: 56
	public void OnGameRejoinMiniGame(Game game, EnterAvatarPacket avatarData, GameReJoinResponse rejoin) { }

	// RVA: 0x25B41F4 Offset: 0x25B01F4 VA: 0x25B41F4 Slot: 48
	public void OnGameRejoinParameterCreate(Game game, PeerResultCode resultCode, GameReJoinResponse rejoin) { }

	// RVA: 0x25B42B0 Offset: 0x25B02B0 VA: 0x25B42B0 Slot: 23
	public void OnMasterSelectWorld(Game game, LoginResponse worldSelect) { }

	// RVA: 0x25B463C Offset: 0x25B063C VA: 0x25B463C Slot: 45
	public void OnGameRejoinRecreateScene(Game game, PeerResultCode resultCode, GameReJoinResponse rejoin) { }

	// RVA: 0x25B46B4 Offset: 0x25B06B4 VA: 0x25B46B4 Slot: 46
	public void OnGameRejoinRenameScene(Game game, PeerResultCode resultCode, GameReJoinResponse rejoin) { }

	// RVA: 0x25B472C Offset: 0x25B072C VA: 0x25B472C Slot: 910
	public void OnGameRejoinMiniGameLobby(Game game, EnterAvatarData avatarData, GameReJoinResponse rejoin) { }

	// RVA: 0x25B47A4 Offset: 0x25B07A4 VA: 0x25B47A4 Slot: 31
	public void OnMasterSignature(Game game, Dictionary<byte, object> parameters) { }

	// RVA: 0x25B48B8 Offset: 0x25B08B8 VA: 0x25B48B8 Slot: 42
	public void OnGameSignatureJoin(Game game, Dictionary<byte, object> parameters) { }

	// RVA: 0x25B49CC Offset: 0x25B09CC VA: 0x25B49CC Slot: 57
	public void OnGameSignatureRejoin(Game game, Dictionary<byte, object> parameters) { }

	// RVA: 0x25B4AE0 Offset: 0x25B0AE0 VA: 0x25B4AE0 Slot: 22
	public void OnMasterCustomerSelect(Game game) { }

	// RVA: 0x25B4BB0 Offset: 0x25B0BB0 VA: 0x25B4BB0 Slot: 34
	public void OnGameAvatarCreate(Game game, PeerResultCode resultCode, GameJoinResponse join) { }

	[IteratorStateMachine(typeof(PhotonListener.<registeredCustomerFunction>d__57))]
	// RVA: 0x25B4D0C Offset: 0x25B0D0C VA: 0x25B4D0C
	private IEnumerator registeredCustomerFunction() { }

	// RVA: 0x25B4D64 Offset: 0x25B0D64 VA: 0x25B4D64 Slot: 59
	public void OnCreateCheckName(Game game, string checkName, GameReturnCode returnCode) { }

	// RVA: 0x25B4E94 Offset: 0x25B0E94 VA: 0x25B4E94 Slot: 60
	public void OnCreateNewAvatar(Game game, string avatarName, GameReturnCode returnCode) { }

	// RVA: 0x25B50C0 Offset: 0x25B10C0 VA: 0x25B50C0 Slot: 35
	public void OnGameAvatarRenaming(Game game, PeerResultCode resultCode, GameJoinResponse join) { }

	// RVA: 0x25B5114 Offset: 0x25B1114 VA: 0x25B5114 Slot: 47
	public void OnGameRejoinAvatarRenaming(Game game, PeerResultCode resultCode, GameReJoinResponse rejoin) { }

	// RVA: 0x25B5190 Offset: 0x25B1190 VA: 0x25B5190 Slot: 62
	public void OnCreateAvatarNaming(Game game, string checkName, GameReturnCode returnCode) { }

	// RVA: 0x25B5220 Offset: 0x25B1220 VA: 0x25B5220 Slot: 30
	public void OnLoginFailure(Game game, GameReturnCode returnCode, string debugMessage) { }

	// RVA: 0x25B5890 Offset: 0x25B1890 VA: 0x25B5890 Slot: 33
	public void OnGameJoinFailure(Game game, GameReturnCode returnCode, string debugMessage) { }

	// RVA: 0x25B5D04 Offset: 0x25B1D04 VA: 0x25B5D04 Slot: 911
	public void OnLoadAvatarFailure(Game game, GameReturnCode returnCode, string debugMessage) { }

	// RVA: 0x25B5D08 Offset: 0x25B1D08 VA: 0x25B5D08 Slot: 734
	public void OnEventMaintenance(Game game, MaintenanceEvent mainteEvent) { }

	// RVA: 0x25B5E44 Offset: 0x25B1E44 VA: 0x25B5E44 Slot: 741
	public void OnEventServerStaging(Game game, StagingEvent staging) { }

	// RVA: 0x25B603C Offset: 0x25B203C VA: 0x25B603C Slot: 261
	public void OnAvatarVariableUpdate(Game game, AvatarVariableUpdateResponse response) { }

	// RVA: 0x25B605C Offset: 0x25B205C VA: 0x25B605C Slot: 267
	public void OnEventLoginAvatarVariable(Game game, LoginAvatarVariableEvent login) { }

	// RVA: 0x25B607C Offset: 0x25B207C VA: 0x25B607C Slot: 565
	public void OnOptionSettingChange(Game game, OptionSettingChangeResponse response) { }

	// RVA: 0x25B610C Offset: 0x25B210C VA: 0x25B610C Slot: 230
	public void OnCompensationInquiry(Game game, CompensationInquiryResponse response) { }

	// RVA: 0x25B619C Offset: 0x25B219C VA: 0x25B619C Slot: 63
	public void OnLoadAvatarFailure(Game game, byte operationCode, GameReturnCode returnCode, string debugMessage) { }

	// RVA: 0x25B61A8 Offset: 0x25B21A8 VA: 0x25B61A8 Slot: 70
	public void OnLoadAvatarEntry(Game game, LoadAvatarEntryResponse entry) { }

	// RVA: 0x25B61E8 Offset: 0x25B21E8 VA: 0x25B61E8 Slot: 71
	public void OnLoadAvatarCheck(Game game, LoadAvatarCheckResponse check) { }

	// RVA: 0x25B6294 Offset: 0x25B2294 VA: 0x25B6294 Slot: 73
	public void OnEventLoadAvatarResult(Game game, LoadAvatarResultEvent loadAvatar) { }

	// RVA: 0x25B6434 Offset: 0x25B2434 VA: 0x25B6434 Slot: 74
	public void OnReceiveResponse(Game game, OperationResponse operationResponse) { }

	// RVA: 0x25B64A4 Offset: 0x25B24A4 VA: 0x25B64A4 Slot: 75
	public void OnReceiveResponse(Game game, byte subCode, OperationResponse operationResponse) { }

	// RVA: 0x25B651C Offset: 0x25B251C VA: 0x25B651C Slot: 19
	public void OnMasterLogin(Game game) { }

	// RVA: 0x25B6598 Offset: 0x25B2598 VA: 0x25B6598 Slot: 27
	public void OnGameRejoin(Game game) { }

	// RVA: 0x25B6614 Offset: 0x25B2614 VA: 0x25B6614 Slot: 176
	public void OnGameLogout(Game game) { }

	// RVA: 0x25B6670 Offset: 0x25B2670 VA: 0x25B6670 Slot: 174
	public void OnAccountLevel(Game game, AccountLevelResponse accountLevel) { }

	// RVA: 0x25B3CD4 Offset: 0x25AFCD4 VA: 0x25B3CD4 Slot: 37
	public void OnGameLoader(Game game) { }

	// RVA: 0x25B6720 Offset: 0x25B2720 VA: 0x25B6720 Slot: 64
	public void OnLoginField(Game game, LoginFieldResponse loginData) { }

	// RVA: 0x25B6A94 Offset: 0x25B2A94 VA: 0x25B6A94 Slot: 65
	public void OnEnterAvatar(Game game, MyArchetype avatar, EnterAvatarData avatarData) { }

	// RVA: 0x25B6AF0 Offset: 0x25B2AF0 VA: 0x25B6AF0 Slot: 66
	public void OnEnterAvatar(Game game, MyArchetype avatar, EnterAvatarPacket avatarData) { }

	// RVA: 0x25B6B4C Offset: 0x25B2B4C VA: 0x25B6B4C Slot: 67
	public void OnEnterAvatar(Game game, MyArchetype avatar, EnterAvatarData2 avatarData) { }

	// RVA: 0x25B6BAC Offset: 0x25B2BAC VA: 0x25B6BAC Slot: 38
	public void OnGameMain(Game game, PositionData positionData) { }

	// RVA: 0x25B6D30 Offset: 0x25B2D30 VA: 0x25B6D30 Slot: 912
	public void OnGameMain(Game game, ContentPositionData positionData) { }

	// RVA: 0x25B6C20 Offset: 0x25B2C20 VA: 0x25B6C20
	private void GameMain(Game game, short cameraRot) { }

	// RVA: 0x25B6D3C Offset: 0x25B2D3C VA: 0x25B6D3C Slot: 183
	public void OnChangeField(Game game, byte operationCode) { }

	// RVA: 0x25B6EC8 Offset: 0x25B2EC8 VA: 0x25B6EC8
	public void OnLocationChangeField(Game game) { }

	// RVA: 0x25B6F30 Offset: 0x25B2F30 VA: 0x25B6F30 Slot: 437
	public void OnChannelGetList(Game game, ChannelGetListResponse response) { }

	// RVA: 0x25B6FB8 Offset: 0x25B2FB8 VA: 0x25B6FB8 Slot: 439
	public void OnChannelChange(Game game) { }

	// RVA: 0x25B7020 Offset: 0x25B3020 VA: 0x25B7020 Slot: 438
	public void OnChannelGetWorld(Game game, ChannelGetWorldResponse response) { }

	// RVA: 0x25B70A8 Offset: 0x25B30A8 VA: 0x25B70A8 Slot: 440
	public void OnChannelGetGlobal(Game game, ChannelGetGlobalResponse response) { }

	// RVA: 0x25B71F8 Offset: 0x25B31F8 VA: 0x25B71F8 Slot: 441
	public void OnGlobalChange(Game game, GlobalChangeResponse response) { }

	// RVA: 0x25B7264 Offset: 0x25B3264 VA: 0x25B7264 Slot: 728
	public void OnReturnServer(Game game, ReturnServerResponse response) { }

	// RVA: 0x25B72CC Offset: 0x25B32CC VA: 0x25B72CC Slot: 729
	public void OnGlobalChannelGetList(Game game, GlobalChannelGetListResponse response) { }

	// RVA: 0x25B7414 Offset: 0x25B3414 VA: 0x25B7414 Slot: 730
	public void OnGlobalChannelGetWorld(Game game, GlobalChannelGetWorldResponse response) { }

	// RVA: 0x25B755C Offset: 0x25B355C VA: 0x25B755C Slot: 731
	public void OnGlobalChannelChange(Game game) { }

	// RVA: 0x25B75C8 Offset: 0x25B35C8 VA: 0x25B75C8
	public void OnEnterRoomForcibly(Game game) { }

	// RVA: 0x25B7630 Offset: 0x25B3630 VA: 0x25B7630
	public void OnRespawnChangeField(Game game) { }

	// RVA: 0x25B7698 Offset: 0x25B3698 VA: 0x25B7698 Slot: 453
	public void OnLeaveRoom(Game game) { }

	// RVA: 0x25B7700 Offset: 0x25B3700 VA: 0x25B7700
	public void OnEmergencyChangeField(Game game) { }

	// RVA: 0x25B7768 Offset: 0x25B3768 VA: 0x25B7768 Slot: 68
	public void OnReturnEmergencyPoint(Game game, EmergencyPositionData emergencyPoint) { }

	// RVA: 0x25B7774 Offset: 0x25B3774 VA: 0x25B7774
	public void OnItemChangeField(Game game) { }

	// RVA: 0x25B7808 Offset: 0x25B3808 VA: 0x25B7808
	public void OnChangeFieldSavePoint(Game game) { }

	// RVA: 0x25B7880 Offset: 0x25B3880 VA: 0x25B7880 Slot: 32
	public void OnOperationFailure(Game game, OperationResponse response) { }

	// RVA: 0x25B94D4 Offset: 0x25B54D4 VA: 0x25B94D4
	public void OnOperationCommonFailure(short returnCode) { }

	// RVA: 0x25B9894 Offset: 0x25B5894 VA: 0x25B9894 Slot: 80
	public void OnActionDefaultResponse(Game game, ActionCode actionCode, GameReturnCode returnCode) { }

	// RVA: 0x25B99E8 Offset: 0x25B59E8 VA: 0x25B99E8 Slot: 109
	public void OnActionSetEquip(Game game, GameReturnCode returnCode, PlayerStatusData response) { }

	// RVA: 0x25B9BC4 Offset: 0x25B5BC4 VA: 0x25B9BC4 Slot: 81
	public void OnActionAttackStart(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, AttackStartResponseData response) { }

	// RVA: 0x25B9CF4 Offset: 0x25B5CF4 VA: 0x25B9CF4 Slot: 82
	public void OnActionAttack(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, AttackResponseData response) { }

	// RVA: 0x25B9D0C Offset: 0x25B5D0C VA: 0x25B9D0C Slot: 83
	public void OnActionAttackEnd(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, AttackEndResponseData response) { }

	// RVA: 0x25B9DF4 Offset: 0x25B5DF4 VA: 0x25B9DF4 Slot: 84
	public void OnActionPartsAttack(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, PartsAttackResponseData response) { }

	// RVA: 0x25B9E60 Offset: 0x25B5E60 VA: 0x25B9E60 Slot: 85
	public void OnActionSupportStart(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SupportStartResponseData response) { }

	// RVA: 0x25B9F24 Offset: 0x25B5F24 VA: 0x25B9F24 Slot: 86
	public void OnActionSupport(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SupportResponseData response) { }

	// RVA: 0x25B9FB0 Offset: 0x25B5FB0 VA: 0x25B9FB0 Slot: 88
	public void OnActionSupportEnd(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SupportEndResponseData response) { }

	// RVA: 0x25BA050 Offset: 0x25B6050 VA: 0x25BA050 Slot: 87
	public void OnActionSupportDelay(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SupportDelayResponseData response) { }

	// RVA: 0x25BA070 Offset: 0x25B6070 VA: 0x25BA070 Slot: 153
	public void OnEventSupport(Game game, SupportEventResponseData support) { }

	// RVA: 0x25BA294 Offset: 0x25B6294 VA: 0x25BA294 Slot: 154
	public void OnEventSupportDelay(Game game, SupportDelayEventResponseData support) { }

	// RVA: 0x25BA2D4 Offset: 0x25B62D4 VA: 0x25BA2D4 Slot: 89
	public void OnActionSkillMotionEnd(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SkillMotionEndResponseData response) { }

	// RVA: 0x25BA300 Offset: 0x25B6300 VA: 0x25BA300 Slot: 90
	public void OnActionSkillCancel(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SkillIdData response) { }

	// RVA: 0x25BA328 Offset: 0x25B6328 VA: 0x25BA328 Slot: 91
	public void OnActionSkillEvent(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SkillEventResponseData response) { }

	// RVA: 0x25BA374 Offset: 0x25B6374 VA: 0x25BA374 Slot: 112
	public void OnActionRemoveSkillBuffer(Game game, GameReturnCode returnCode, RemoveSkillBufferResponseData response) { }

	// RVA: 0x25BA398 Offset: 0x25B6398 VA: 0x25BA398 Slot: 96
	public void OnActionMobCreate(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobResponseData response) { }

	// RVA: 0x25BA410 Offset: 0x25B6410 VA: 0x25BA410 Slot: 98
	public void OnActionMobActionStart(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobActionStartResponseData response) { }

	// RVA: 0x25BA4A0 Offset: 0x25B64A0 VA: 0x25BA4A0 Slot: 99
	public void OnActionMobAttack(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobAttackResponseData response) { }

	// RVA: 0x25BA7D0 Offset: 0x25B67D0 VA: 0x25BA7D0 Slot: 100
	public void OnActionMobAttackToMob(Game game, GameReturnCode returnCode, MobAttackToMobResponseData response) { }

	// RVA: 0x25BAA44 Offset: 0x25B6A44 VA: 0x25BAA44 Slot: 101
	public void OnActionMobSupport(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobAttackResponseData response) { }

	// RVA: 0x25BAB58 Offset: 0x25B6B58 VA: 0x25BAB58 Slot: 102
	public void OnActionMobActionCancel(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobCancelData response) { }

	// RVA: 0x25BAB5C Offset: 0x25B6B5C VA: 0x25BAB5C Slot: 105
	public void OnActionMobCheck(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobResponseData response) { }

	// RVA: 0x25BAD20 Offset: 0x25B6D20 VA: 0x25BAD20 Slot: 106
	public void OnActionMobHateCheck(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId) { }

	// RVA: 0x25BAD24 Offset: 0x25B6D24 VA: 0x25BAD24
	public void OnActionMobResult(Game game, MobData mobData, ResultData resultData, bool isResend) { }

	// RVA: 0x25BAE70 Offset: 0x25B6E70 VA: 0x25BAE70 Slot: 140
	public void OnActionMobResult(Game game, BattleResultData battleResult, MobData[] mobIds, MonsterResultData[] mobResult, bool isResend) { }

	// RVA: 0x25BAEC0 Offset: 0x25B6EC0 VA: 0x25BAEC0 Slot: 97
	public void OnActionMobRelease(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobIdData response) { }

	// RVA: 0x25BB09C Offset: 0x25B709C VA: 0x25BB09C Slot: 160
	public void OnActionEventMobAbnormalDamage(Game game, MobAbnormalDamageEvent abnormalDamage) { }

	// RVA: 0x25BB0F4 Offset: 0x25B70F4 VA: 0x25BB0F4 Slot: 161
	public void OnActionEventMobAbnormalStateEnd(Game game, MobAbnormalStateEndEvent endEvent) { }

	// RVA: 0x25BB14C Offset: 0x25B714C VA: 0x25BB14C Slot: 121
	public void OnActionEventPartsAttack(Game game, PartsAttackResponseData eventData) { }

	// RVA: 0x25BB1A4 Offset: 0x25B71A4 VA: 0x25BB1A4 Slot: 157
	public void OnEventMobAllRelease(Game game, MobAllReleaseEvent release) { }

	// RVA: 0x25BB298 Offset: 0x25B7298 VA: 0x25BB298 Slot: 158
	public void OnEventMobKilled(Game game, MobKilledEvent killed) { }

	// RVA: 0x25BB3D8 Offset: 0x25B73D8 VA: 0x25BB3D8 Slot: 559
	public void OnEventAreaBonusReward(Game game, AreaBonusRewardEvent areaBonus) { }

	// RVA: 0x25BB400 Offset: 0x25B7400 VA: 0x25BB400 Slot: 560
	public void OnAreaBonusReward(Game game, AreaBonusResultResponse response) { }

	// RVA: 0x25BB504 Offset: 0x25B7504 VA: 0x25BB504 Slot: 166
	public void OnEventMobBuffEffect(Game game, MobBuffEffectEvent effectEvent) { }

	// RVA: 0x25BB6FC Offset: 0x25B76FC VA: 0x25BB6FC Slot: 167
	public void OnEventMobBuffEnd(Game game, MobBuffEndEvent endEvent) { }

	// RVA: 0x25BB7B0 Offset: 0x25B77B0 VA: 0x25BB7B0 Slot: 162
	public void OnEventCaptureStart(Game game, CaptureStartEvent captureStart) { }

	// RVA: 0x25BBD68 Offset: 0x25B7D68 VA: 0x25BBD68 Slot: 163
	public void OnEventCaptureUpdate(Game game, CaptureUpdateEvent updateEvent) { }

	// RVA: 0x25BBE20 Offset: 0x25B7E20 VA: 0x25BBE20 Slot: 164
	public void OnEventCaptureSuccess(Game game, CaptureSuccessEvent resultEvent) { }

	// RVA: 0x25BC164 Offset: 0x25B8164 VA: 0x25BC164 Slot: 165
	public void OnEventCaptureFailed(Game game, CaptureFailedEvent resultEvent) { }

	// RVA: 0x25BC5CC Offset: 0x25B85CC VA: 0x25BC5CC Slot: 146
	public void OnActionPartyChangeHateMine(Game game, Archetype archetype, MobData[] mobList) { }

	// RVA: 0x25BCB10 Offset: 0x25B8B10 VA: 0x25BCB10 Slot: 147
	public void OnActionPartyChangeHateActor(Game game, Archetype archetype, MobData[] mobList) { }

	// RVA: 0x25BCE58 Offset: 0x25B8E58 VA: 0x25BCE58 Slot: 145
	public void OnActionPartyRelease(Game game, MobData[] mobList) { }

	// RVA: 0x25BCF24 Offset: 0x25B8F24 VA: 0x25BCF24
	public void OnActionPartyResult(Game game, MobData mobData, ResultData resultData, bool isResend) { }

	// RVA: 0x25BCF7C Offset: 0x25B8F7C VA: 0x25BCF7C Slot: 144
	public void OnActionPartyResult(Game game, BattleResultData battleResult, MobData[] mobIds, MonsterResultData[] mobResult, bool isResend) { }

	// RVA: 0x25BCFCC Offset: 0x25B8FCC VA: 0x25BCFCC Slot: 72
	public void OnEventEnterBossField(Game game, EnterBossField bossField) { }

	// RVA: 0x25BD19C Offset: 0x25B919C VA: 0x25BD19C Slot: 483
	public void OnEventEnterRaidBossField(Game game, EnterRaidBossField enterEvent) { }

	// RVA: 0x25BD5E8 Offset: 0x25B95E8 VA: 0x25BD5E8 Slot: 151
	public void OnActionRoomChangeHateMine(Game game, Archetype archetype, MobData[] mobList) { }

	// RVA: 0x25BDB20 Offset: 0x25B9B20 VA: 0x25BDB20 Slot: 152
	public void OnActionRoomChangeHateActor(Game game, Archetype archetype, MobData[] mobList) { }

	// RVA: 0x25BDE68 Offset: 0x25B9E68 VA: 0x25BDE68 Slot: 150
	public void OnActionRoomRelease(Game game, MobData[] mobList) { }

	// RVA: 0x25BDEE8 Offset: 0x25B9EE8 VA: 0x25BDEE8 Slot: 471
	public void OnEventRoomManagedMonster(Game game, RoomManagedMonsterEvent managedMonster) { }

	// RVA: 0x25BDEEC Offset: 0x25B9EEC VA: 0x25BDEEC Slot: 148
	public void OnActionRoomResult(Game game, MobData mobData, ResultData resultData, bool isResend) { }

	// RVA: 0x25BDF2C Offset: 0x25B9F2C VA: 0x25BDF2C Slot: 149
	public void OnActionRoomBossResult(Game game, MobData mobData, ResultData resultData, BossResultData bossResult, bool isResend) { }

	// RVA: 0x25BE288 Offset: 0x25BA288 VA: 0x25BE288 Slot: 155
	public void OnEventHyperModeChange(Game game, HyperModeChangeEvent hyperMode) { }

	// RVA: 0x25BE3B8 Offset: 0x25BA3B8 VA: 0x25BE3B8 Slot: 156
	public void OnEventResendingHyperMode(Game game, ResendingHyperModeEvent battleEvent) { }

	// RVA: 0x25BE514 Offset: 0x25BA514 VA: 0x25BE514 Slot: 506
	public void OnRoomRespawn(Game game, RoomRespawnResponse respawn) { }

	// RVA: 0x25BE700 Offset: 0x25BA700 VA: 0x25BE700 Slot: 486
	public void OnEventSecondPartyLeave(Game game, RoomSecondPartyLeaveEvent leaveEvent) { }

	// RVA: 0x25BE88C Offset: 0x25BA88C VA: 0x25BE88C Slot: 507
	public void OnRoomWarpPosition(Game game, RoomWarpPositionResponse warpPosition) { }

	// RVA: 0x25BE914 Offset: 0x25BA914 VA: 0x25BE914 Slot: 240
	public void OnMissionStart(Game game, MissionStartResponse response) { }

	// RVA: 0x25BE934 Offset: 0x25BA934 VA: 0x25BE934 Slot: 242
	public void OnMissionEnd(Game game, MissionEndResponse response) { }

	// RVA: 0x25BE954 Offset: 0x25BA954 VA: 0x25BE954 Slot: 238
	public void OnMissionGetData(Game game, MissionGetDataResponse response) { }

	// RVA: 0x25BE974 Offset: 0x25BA974 VA: 0x25BE974 Slot: 239
	public void OnMissionAbandonment(Game game, MissionAbandonmentResponse response) { }

	// RVA: 0x25BE994 Offset: 0x25BA994 VA: 0x25BE994 Slot: 241
	public void OnMissionReward(Game game, MissionCheckRewardResponse response) { }

	// RVA: 0x25BE9B4 Offset: 0x25BA9B4 VA: 0x25BE9B4 Slot: 237
	public void OnMissionOperationFailure(Game game, OperationResponse responseObject) { }

	// RVA: 0x25BE9D4 Offset: 0x25BA9D4 VA: 0x25BE9D4 Slot: 246
	public void OnQuestStart(Game game, QuestStartResponse response) { }

	// RVA: 0x25BE9F4 Offset: 0x25BA9F4 VA: 0x25BE9F4 Slot: 249
	public void OnQuestEnd(Game game, QuestEndResponse response) { }

	// RVA: 0x25BEA14 Offset: 0x25BAA14 VA: 0x25BEA14 Slot: 244
	public void OnQuestGetData(Game game, QuestGetDataResponse response) { }

	// RVA: 0x25BEA34 Offset: 0x25BAA34 VA: 0x25BEA34 Slot: 245
	public void OnQuestAbandonment(Game game, QuestAbandonmentResponse response) { }

	// RVA: 0x25BEA54 Offset: 0x25BAA54 VA: 0x25BEA54 Slot: 247
	public void OnQuestReward(Game game, QuestCheckRewardResponse response) { }

	// RVA: 0x25BEA74 Offset: 0x25BAA74 VA: 0x25BEA74 Slot: 248
	public void OnQuestContinuousReward(Game game, QuestCheckContinuousRewardResponse response) { }

	// RVA: 0x25BEA94 Offset: 0x25BAA94 VA: 0x25BEA94 Slot: 243
	public void OnQuestOperationFailure(Game game, OperationResponse responseObject) { }

	// RVA: 0x25BEAB4 Offset: 0x25BAAB4 VA: 0x25BEAB4
	public void OnGMOperationGetStatusPoint(Game game, short statusPoint) { }

	// RVA: 0x25BEAEC Offset: 0x25BAAEC VA: 0x25BEAEC
	public void OnGmGameEventInit(Game game, byte id, byte[] br) { }

	// RVA: 0x25BEAF0 Offset: 0x25BAAF0 VA: 0x25BEAF0
	public void OnGmHouseInitialize(Game game) { }

	// RVA: 0x25BEAF4 Offset: 0x25BAAF4 VA: 0x25BEAF4
	public void OnGmBossRoomList(Game game, RoomStateData[] roomStateList) { }

	// RVA: 0x25BEAF8 Offset: 0x25BAAF8 VA: 0x25BEAF8
	public void OnSendOperationParameter(Game game, OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x25BEAFC Offset: 0x25BAAFC VA: 0x25BEAFC
	public void OnGmAreaBonusUpdate(Game game, AreaPopData areaPop) { }

	// RVA: 0x25BEB24 Offset: 0x25BAB24 VA: 0x25BEB24
	public void OnGmForcedWarp2(Game game) { }

	// RVA: 0x25BEB28 Offset: 0x25BAB28 VA: 0x25BEB28
	public void OnGmGetStarGemShard(Game game, int gemShard) { }

	// RVA: 0x25BEB7C Offset: 0x25BAB7C VA: 0x25BEB7C
	public void OnGmGetStarGem(Game game, StarGemData starGem) { }

	// RVA: 0x25BEC54 Offset: 0x25BAC54 VA: 0x25BEC54
	public void OnGmTreasureHistory(Game game) { }

	// RVA: 0x25BEC58 Offset: 0x25BAC58 VA: 0x25BEC58
	public void OnGmTreasureRecoverKey(Game game, byte keyNum) { }

	// RVA: 0x25BEC5C Offset: 0x25BAC5C VA: 0x25BEC5C
	public void OnGmEventCompensation(Game game) { }

	// RVA: 0x25BEC60 Offset: 0x25BAC60 VA: 0x25BEC60
	public void OnGmAddItemBagSlot(Game game, short[] inventoryCapacity) { }

	// RVA: 0x25BECB8 Offset: 0x25BACB8 VA: 0x25BECB8
	public void OnGmAddParameterSlot(Game game, byte parameterSlot) { }

	// RVA: 0x25BED10 Offset: 0x25BAD10 VA: 0x25BED10
	public void OnGmCultivationTimeRewind(Game game) { }

	// RVA: 0x25BED14 Offset: 0x25BAD14 VA: 0x25BED14
	public void OnGmUpdateMaterialPoint(Game game, MaterialData[] materialList) { }

	// RVA: 0x25BEDB4 Offset: 0x25BADB4 VA: 0x25BEDB4
	public void OnGmChangeAccountProgress(Game game, int accountProgress) { }

	// RVA: 0x25BEDB8 Offset: 0x25BADB8 VA: 0x25BEDB8
	public void OnGmOxygenRecovery(Game game, int oxygenHp) { }

	// RVA: 0x25BEDBC Offset: 0x25BADBC VA: 0x25BEDBC
	public void OnGmBossPopReserve(Game game) { }

	// RVA: 0x25BEDC0 Offset: 0x25BADC0 VA: 0x25BEDC0
	public void OnGmBossDeadReserve(Game game) { }

	// RVA: 0x25BEDC4 Offset: 0x25BADC4 VA: 0x25BEDC4
	public void OnGmCuisineRecipeSetting(Game game) { }

	// RVA: 0x25BEE14 Offset: 0x25BAE14 VA: 0x25BEE14
	public void OnGmCuisineRecipeInitialize(Game game) { }

	// RVA: 0x25BEE70 Offset: 0x25BAE70 VA: 0x25BEE70
	public void OnGmCuisineSettingInitialize(Game game) { }

	// RVA: 0x25BF1F4 Offset: 0x25BB1F4 VA: 0x25BF1F4
	public void OnGmBankTimeUpdate(Game game, BankData bank) { }

	// RVA: 0x25BF1F8 Offset: 0x25BB1F8 VA: 0x25BF1F8
	public void OnGmResetTrophy(Game game, TimeData continuousTime, TimeData totalTime, byte[] trophyData) { }

	// RVA: 0x25BF230 Offset: 0x25BB230 VA: 0x25BF230 Slot: 365
	public void OnEventGuildInitializeRaidReheld(Game game) { }

	// RVA: 0x25BF268 Offset: 0x25BB268 VA: 0x25BF268
	public void OnGmGetGuildQuestStock(Game game, byte stock, long restockTime) { }

	// RVA: 0x25BF26C Offset: 0x25BB26C VA: 0x25BF26C
	public void OnGmInitializeGuildQuestResetDate(Game game) { }

	// RVA: 0x25BF2A4 Offset: 0x25BB2A4 VA: 0x25BF2A4
	public void OnGmResetGuildQuestClear(Game game) { }

	// RVA: 0x25BF2A8 Offset: 0x25BB2A8 VA: 0x25BF2A8
	public void OnGmSoundScoreReset(Game game) { }

	// RVA: 0x25BF2AC Offset: 0x25BB2AC VA: 0x25BF2AC
	public void OnGmTreasureHuntTrialPointMax(Game game) { }

	// RVA: 0x25BF2B0 Offset: 0x25BB2B0 VA: 0x25BF2B0
	public void OnGmSetProficiency(Game game, ProficiencyData data) { }

	// RVA: 0x25BF2B4 Offset: 0x25BB2B4 VA: 0x25BF2B4
	public void OnGmGetHouseBlackKnightGold(Game game, int gold) { }

	// RVA: 0x25BF4D4 Offset: 0x25BB4D4 VA: 0x25BF4D4
	public void OnGmGetHouseBlackKnightCristaAll(Game game, long crista) { }

	// RVA: 0x25BF664 Offset: 0x25BB664 VA: 0x25BF664
	public void OnGmChangeNewWaveSeed(Game game, int seed) { }

	// RVA: 0x25BF668 Offset: 0x25BB668 VA: 0x25BF668
	public void OnGmGetNewWaveSeed(Game game, int seed) { }

	// RVA: 0x25BF66C Offset: 0x25BB66C VA: 0x25BF66C
	public void OnGmSendDebugSaveData(Game game, int value, byte type) { }

	// RVA: 0x25BF670 Offset: 0x25BB670 VA: 0x25BF670
	public void OnGmGetGemCart(Game game, GemCartData gemCart) { }

	// RVA: 0x25BF784 Offset: 0x25BB784 VA: 0x25BF784
	public void OnGmGetGemPowder(Game game, int gemPowder) { }

	// RVA: 0x25BF814 Offset: 0x25BB814 VA: 0x25BF814
	public void OnGmInitializeRegistlet(Game game) { }

	// RVA: 0x25BF8AC Offset: 0x25BB8AC VA: 0x25BF8AC
	public void OnLiveKeywordCheck(Game game, Dictionary<object, object> enableKeywords) { }

	// RVA: 0x25BFAE8 Offset: 0x25BBAE8 VA: 0x25BFAE8
	public void OnGmItemConvertReset(Game game) { }

	// RVA: 0x25BFB38 Offset: 0x25BBB38 VA: 0x25BFB38 Slot: 368
	public void OnEventGuildUpdateRaidMaxHpCount(Game game, GuildUpdateRaidMaxHpCountEvent updateEvent) { }

	// RVA: 0x25BFB3C Offset: 0x25BBB3C VA: 0x25BFB3C
	public void OnGmSendMail(Game game) { }

	// RVA: 0x25BFB40 Offset: 0x25BBB40 VA: 0x25BFB40
	public void OnGmCheckRegion(Game game, string strRegion) { }

	// RVA: 0x25BFBF8 Offset: 0x25BBBF8 VA: 0x25BFBF8
	public void OnGmBazaarInitializeSlot(Game game) { }

	// RVA: 0x25BFCC8 Offset: 0x25BBCC8 VA: 0x25BFCC8
	public void OnGmBazaarInitializeOpenSystem(Game game, byte flag) { }

	// RVA: 0x25BFD84 Offset: 0x25BBD84 VA: 0x25BFD84
	public void OnGmEndOrbBonus(Game game, OrbBonusData[] endList) { }

	// RVA: 0x25BFDF8 Offset: 0x25BBDF8 VA: 0x25BFDF8
	public void OnItemBagSort(Game game, byte bagId, Dictionary<int, short> itemLocationList) { }

	// RVA: 0x25BFE1C Offset: 0x25BBE1C VA: 0x25BFE1C
	public void OnItemLocationSwap(Game game, Dictionary<int, short> itemLocationList) { }

	// RVA: 0x25BFE3C Offset: 0x25BBE3C VA: 0x25BFE3C Slot: 107
	public void OnActionItemUse(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, ItemUseResponseData response) { }

	// RVA: 0x25C0454 Offset: 0x25BC454 VA: 0x25C0454 Slot: 203
	public void OnItemBoxOpen(Game game, ItemBoxOpenResponse responseObject) { }

	// RVA: 0x25C0590 Offset: 0x25BC590 VA: 0x25C0590 Slot: 108
	public void OnActionItemDurationInvoke(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, ItemDurationResponeData response) { }

	// RVA: 0x25C06F4 Offset: 0x25BC6F4 VA: 0x25C06F4 Slot: 170
	public void OnEventBonusDuration(Game game, BonusDurationEventResponseData eventData) { }

	// RVA: 0x25C0718 Offset: 0x25BC718 VA: 0x25C0718 Slot: 266
	public void OnEventBagCapacity(Game game, BagCapacityEvent bagCapacity) { }

	// RVA: 0x25C071C Offset: 0x25BC71C VA: 0x25C071C Slot: 199
	public void OnItemDiscard(Game game, _ItemDiscardResponse responseObject, short returnCode) { }

	// RVA: 0x25C084C Offset: 0x25BC84C VA: 0x25C084C Slot: 200
	public void OnItemUserFlagChange(Game game, _ItemUserFlagChangeResponse responseObject, short returnCode) { }

	// RVA: 0x25C0940 Offset: 0x25BC940 VA: 0x25C0940 Slot: 201
	public void OnItemBagLoad(Game game, ItemLoadResponse responseObject) { }

	// RVA: 0x25C09C0 Offset: 0x25BC9C0 VA: 0x25C09C0 Slot: 204
	public void OnWarrantyDiscard(Game game, _WarrantyDiscardResponse responseObject, short returnCode) { }

	// RVA: 0x25C09E0 Offset: 0x25BC9E0 VA: 0x25C09E0 Slot: 205
	public void OnWarrantySwap(Game game, _WarrantySwapResponse responseObject, short returnCode) { }

	// RVA: 0x25C0A5C Offset: 0x25BCA5C VA: 0x25C0A5C Slot: 202
	public void OnItemBagSlotRelease(Game game, ItemBagSlotReleaseResponse responseObject, short returnCode) { }

	// RVA: 0x25C0AEC Offset: 0x25BCAEC VA: 0x25C0AEC Slot: 892
	public void OnEventItemRandomPropertyAddTriggerCount(Game game, ItemRandomPropertyAddTriggerCountEvent count) { }

	// RVA: 0x25C0AF0 Offset: 0x25BCAF0 VA: 0x25C0AF0 Slot: 893
	public void OnEventItemRandomPropertyStartEffect(Game game, ItemRandomPropertyStartEffectEvent start) { }

	// RVA: 0x25C0B10 Offset: 0x25BCB10 VA: 0x25C0B10 Slot: 894
	public void OnEventItemRandomPropertyEndEffect(Game game, ItemRandomPropertyEndEffectEvent end) { }

	// RVA: 0x25C0B30 Offset: 0x25BCB30 VA: 0x25C0B30 Slot: 186
	public void OnParameterGetList(Game game, ParameterGetListResponse parameterList) { }

	// RVA: 0x25C0B50 Offset: 0x25BCB50 VA: 0x25C0B50 Slot: 187
	public void OnParameterGetStatus(Game game, ParameterGetStatusResponse response) { }

	// RVA: 0x25C0B70 Offset: 0x25BCB70 VA: 0x25C0B70 Slot: 188
	public void OnParameterNameChange(Game game, ParameterNameChangeResponse response) { }

	// RVA: 0x25C0B9C Offset: 0x25BCB9C VA: 0x25C0B9C Slot: 189
	public void OnParameterDelete(Game game, ParameterDeleteResponse response) { }

	// RVA: 0x25C0BBC Offset: 0x25BCBBC VA: 0x25C0BBC Slot: 184
	public void OnParameterChange(Game game) { }

	// RVA: 0x25C0C84 Offset: 0x25BCC84 VA: 0x25C0C84 Slot: 185
	public void OnParameterCreate(Game game) { }

	// RVA: 0x25C0CB4 Offset: 0x25BCCB4 VA: 0x25C0CB4 Slot: 190
	public void OnCreateNewParameter(Game game, byte parameterId, short returnCode, string debugMessage) { }

	// RVA: 0x25C0D58 Offset: 0x25BCD58 VA: 0x25C0D58 Slot: 191
	public void OnParameterOrderChange(Game game, ParameterOrderChangeResponse response) { }

	// RVA: 0x25C0DD4 Offset: 0x25BCDD4 VA: 0x25C0DD4 Slot: 192
	public void OnParameterOrderReset(Game game, ParameterOrderResetResponse response) { }

	// RVA: 0x25C0E50 Offset: 0x25BCE50 VA: 0x25C0E50 Slot: 513
	public void OnOrbRenameServicePrice(Game engine, OrbRenameServicePriceResponse response) { }

	// RVA: 0x25C0EAC Offset: 0x25BCEAC VA: 0x25C0EAC Slot: 61
	public void OnRename(Game game, RenameResponse responseObject) { }

	// RVA: 0x25C0F08 Offset: 0x25BCF08 VA: 0x25C0F08 Slot: 178
	public void OnRenameChange(Game game) { }

	// RVA: 0x25C0F5C Offset: 0x25BCF5C VA: 0x25C0F5C Slot: 293
	public void OnEventFriendAcceptance(Game game, FriendAcceptanceEvent acceptance) { }

	// RVA: 0x25C0F80 Offset: 0x25BCF80 VA: 0x25C0F80 Slot: 291
	public void OnEventFriendCancel(Game game, FriendCancelEvent cancel) { }

	// RVA: 0x25C0FAC Offset: 0x25BCFAC VA: 0x25C0FAC Slot: 283
	public void OnFriendUpdate(Game game, FriendUpdateResponse response) { }

	// RVA: 0x25C0FCC Offset: 0x25BCFCC VA: 0x25C0FCC Slot: 294
	public void OnEventFriendRemove(Game game, FriendRemoveEvent remove) { }

	// RVA: 0x25C0FF8 Offset: 0x25BCFF8 VA: 0x25C0FF8 Slot: 290
	public void OnEventFriendRequest(Game game, FriendRequestEvent request) { }

	// RVA: 0x25C1018 Offset: 0x25BD018 VA: 0x25C1018 Slot: 292
	public void OnEventFriendSenderCancel(Game game, FriendSenderCancelEvent senderCancel) { }

	// RVA: 0x25C1044 Offset: 0x25BD044 VA: 0x25C1044 Slot: 287
	public void OnFriendAcceptance(Game game, FriendAcceptanceResponse response) { }

	// RVA: 0x25C1068 Offset: 0x25BD068 VA: 0x25C1068 Slot: 288
	public void OnFriendRemove(Game game, FriendRemoveResponse response) { }

	// RVA: 0x25C1094 Offset: 0x25BD094 VA: 0x25C1094 Slot: 285
	public void OnFriendRequestCancel(Game game, FriendCancelResponse response) { }

	// RVA: 0x25C10C0 Offset: 0x25BD0C0 VA: 0x25C10C0 Slot: 284
	public void OnFriendRequest(Game game, FriendRequestResponse response) { }

	// RVA: 0x25C10E0 Offset: 0x25BD0E0 VA: 0x25C10E0 Slot: 286
	public void OnFriendSenderRequestCancel(Game game, FriendSenderCancelResponse response) { }

	// RVA: 0x25C110C Offset: 0x25BD10C VA: 0x25C110C Slot: 289
	public void OnFriendChangeOnlineNotice(Game game) { }

	// RVA: 0x25C1128 Offset: 0x25BD128 VA: 0x25C1128 Slot: 561
	public void OnEventSystemMessage(Game game, SystemMessageEvent systemEvent) { }

	// RVA: 0x25C13D4 Offset: 0x25BD3D4 VA: 0x25C13D4 Slot: 179
	public void OnEventChatMessage(Game game, ChatEvent chat) { }

	// RVA: 0x25C148C Offset: 0x25BD48C VA: 0x25C148C Slot: 180
	public void OnEventChatMessage(Game game, ChatMessageEvent chatEvent) { }

	// RVA: 0x25C1564 Offset: 0x25BD564 VA: 0x25C1564 Slot: 381
	public void OnPartyUnreceivedMessage(Game game, PartyUnreceivedMessageResponse response) { }

	// RVA: 0x25C15C4 Offset: 0x25BD5C4 VA: 0x25C15C4 Slot: 318
	public void OnGuildUnreceivedMessage(Game game, GuildUnreceivedMessageResponse response) { }

	// RVA: 0x25C1628 Offset: 0x25BD628 VA: 0x25C1628 Slot: 181
	public void OnEventSystemChat(Game game, SystemChatEvent chatEvent) { }

	// RVA: 0x25C1680 Offset: 0x25BD680 VA: 0x25C1680 Slot: 408
	public void OnEventPartyDissolution(Game game, PartyDissolutionEvent dissolution) { }

	// RVA: 0x25C173C Offset: 0x25BD73C VA: 0x25C173C Slot: 402
	public void OnEventPartyInvitation(Game game, PartyInvitationEvent invitation) { }

	// RVA: 0x25C17F0 Offset: 0x25BD7F0 VA: 0x25C17F0 Slot: 403
	public void OnEventPartyInviteCancel(Game game, PartyInviteCancelEvent cancel) { }

	// RVA: 0x25C1884 Offset: 0x25BD884 VA: 0x25C1884 Slot: 396
	public void OnEventPartyJoin(Game gane, PartyJoinEvent join) { }

	// RVA: 0x25C19D4 Offset: 0x25BD9D4 VA: 0x25C19D4 Slot: 406
	public void OnEventPartyKickout(Game game, PartyKickoutEvent kickout) { }

	// RVA: 0x25C1B20 Offset: 0x25BDB20 VA: 0x25C1B20 Slot: 409
	public void OnEventPartyLeaderChange(Game game, PartyLeaderChangeEvent change) { }

	// RVA: 0x25C1BE0 Offset: 0x25BDBE0 VA: 0x25C1BE0 Slot: 394
	public void OnEventPartyLogin(Game game, PartyLoginEvent login) { }

	// RVA: 0x25C1C74 Offset: 0x25BDC74 VA: 0x25C1C74 Slot: 395
	public void OnEventPartyLogout(Game game, PartyLogoutEvent logout) { }

	// RVA: 0x25C1D08 Offset: 0x25BDD08 VA: 0x25C1D08 Slot: 404
	public void OnEventPartySenderInvitedCancel(Game game, PartySenderInvitedCancelEvent cancel) { }

	// RVA: 0x25C1D9C Offset: 0x25BDD9C VA: 0x25C1D9C Slot: 401
	public void OnEventPartyRelated(Game game, PartyRelatedEvent related) { }

	// RVA: 0x25C1E30 Offset: 0x25BDE30 VA: 0x25C1E30 Slot: 407
	public void OnEventPartySecede(Game game, PartySecedeEvent secede) { }

	// RVA: 0x25C1EF4 Offset: 0x25BDEF4 VA: 0x25C1EF4 Slot: 397
	public void OnEventPartyState(Game game, PartyStateLightEvent partyEvent) { }

	// RVA: 0x25C1F88 Offset: 0x25BDF88 VA: 0x25C1F88 Slot: 398
	public void OnEventPartyStatus(Game game, PartyStatusLightEvent partyEvent) { }

	// RVA: 0x25C201C Offset: 0x25BE01C VA: 0x25C201C Slot: 405
	public void OnEventPartyTimeoutInviteCancel(Game game, PartyInviteTimeoutEvent timeout) { }

	// RVA: 0x25C20B0 Offset: 0x25BE0B0 VA: 0x25C20B0 Slot: 379
	public void OnPartyAcceptance(Game game, PartyAcceptanceResponse response) { }

	// RVA: 0x25C2180 Offset: 0x25BE180 VA: 0x25C2180 Slot: 377
	public void OnPartyInviteCancel(Game game, PartyInviteCancelResponse response, short returnCode, string debugMessage) { }

	// RVA: 0x25C22A8 Offset: 0x25BE2A8 VA: 0x25C22A8 Slot: 376
	public void OnPartyInvitation(Game game, PartyInvitationResponse response) { }

	// RVA: 0x25C2334 Offset: 0x25BE334 VA: 0x25C2334 Slot: 378
	public void OnPartySenderInvitedCancel(Game game, PartySenderInvitedCancelResponse response, short returnCode, string debugMessage) { }

	// RVA: 0x25C245C Offset: 0x25BE45C VA: 0x25C245C Slot: 380
	public void OnPartySecede(Game game, short returnCode) { }

	// RVA: 0x25C2514 Offset: 0x25BE514 VA: 0x25C2514
	private void UpdatePartyLotteryUsers(PartyOperationCode code, int num) { }

	// RVA: 0x25C2658 Offset: 0x25BE658 VA: 0x25C2658 Slot: 391
	public void OnPartyLotteryInfo(Game game, LotteryInfoResponse response) { }

	// RVA: 0x25C2674 Offset: 0x25BE674 VA: 0x25C2674 Slot: 392
	public void OnPartyLotteryListClear(Game game, LotteryListClearResponse response) { }

	// RVA: 0x25C2680 Offset: 0x25BE680 VA: 0x25C2680 Slot: 387
	public void OnPartyLotteryRecruitStart(Game game, LotteryRecruitStartResponse response) { }

	// RVA: 0x25C26D8 Offset: 0x25BE6D8 VA: 0x25C26D8 Slot: 388
	public void OnPartyLotteryRecruitCancel(Game game, LotteryRecruitCancelResponse response) { }

	// RVA: 0x25C2730 Offset: 0x25BE730 VA: 0x25C2730 Slot: 389
	public void OnPartyLotteryStart(Game game, LotteryStartResponse response) { }

	// RVA: 0x25C2788 Offset: 0x25BE788 VA: 0x25C2788 Slot: 390
	public void OnPartyLotteryJoin(Game game, LotteryJoinResponse response) { }

	// RVA: 0x25C2910 Offset: 0x25BE910 VA: 0x25C2910 Slot: 416
	public void OnEventPartyLotteryRecruit(Game game, PartyLotteryRecruitEvent partyEvent) { }

	// RVA: 0x25C2D7C Offset: 0x25BED7C VA: 0x25C2D7C Slot: 393
	public void OnPartyLotteryRecruitReSend(Game game, LotteryRecruitReSendResponse response) { }

	// RVA: 0x25C2DD4 Offset: 0x25BEDD4 VA: 0x25C2DD4 Slot: 382
	public void OnPartyLinkInvitation(Game game, PartyLinkInvitationResponse response) { }

	// RVA: 0x25C2E7C Offset: 0x25BEE7C VA: 0x25C2E7C Slot: 383
	public void OnPartyLinkInviteCancel(Game game, PartyLinkInviteCancelResponse response) { }

	// RVA: 0x25C2F24 Offset: 0x25BEF24 VA: 0x25C2F24 Slot: 384
	public void OnPartyLinkSenderInvitedCancel(Game game) { }

	// RVA: 0x25C2FBC Offset: 0x25BEFBC VA: 0x25C2FBC Slot: 385
	public void OnPartyLinkConsent(Game game, PartyLinkConsentResponse response) { }

	// RVA: 0x25C3064 Offset: 0x25BF064 VA: 0x25C3064 Slot: 386
	public void OnPartyLinkRelease(Game game) { }

	// RVA: 0x25C30FC Offset: 0x25BF0FC VA: 0x25C30FC Slot: 410
	public void OnEventPartyLinkState(Game game, PartyLinkStateEvent linkEvent) { }

	// RVA: 0x25C3154 Offset: 0x25BF154 VA: 0x25C3154 Slot: 411
	public void OnEventPartyLinkInvite(Game game, PartyLinkInviteEvent linkEvent) { }

	// RVA: 0x25C31AC Offset: 0x25BF1AC VA: 0x25C31AC Slot: 412
	public void OnEventPartyLinkCancel(Game game, PartyLinkCancelEvent linkEvent) { }

	// RVA: 0x25C3204 Offset: 0x25BF204 VA: 0x25C3204 Slot: 413
	public void OnEventPartyLinkSenderCancel(Game game, PartyLinkSenderCancelEvent linkEvent) { }

	// RVA: 0x25C325C Offset: 0x25BF25C VA: 0x25C325C Slot: 414
	public void OnEventPartyLinkConsent(Game game, PartyLinkConsentEvent linkEvent) { }

	// RVA: 0x25C32B4 Offset: 0x25BF2B4 VA: 0x25C32B4 Slot: 415
	public void OnEventPartyLinkRelease(Game game) { }

	// RVA: 0x25C3304 Offset: 0x25BF304 VA: 0x25C3304 Slot: 257
	public void OnTrophyCheckReward(Game game, TrophyCheckRewardResponse response) { }

	// RVA: 0x25C3330 Offset: 0x25BF330 VA: 0x25C3330 Slot: 262
	public void OnEventTrophy(Game game, TrophyEvent trophy) { }

	// RVA: 0x25C33B8 Offset: 0x25BF3B8 VA: 0x25C33B8 Slot: 259
	public void OnWeeklyTrophyCheckReward(Game game, WeeklyTrophyCheckRewardResponse response) { }

	// RVA: 0x25C33EC Offset: 0x25BF3EC VA: 0x25C33EC Slot: 264
	public void OnEventWeeklyTrophy(Game game, WeeklyTrophyEvent weeklyTrophy) { }

	// RVA: 0x25C3470 Offset: 0x25BF470 VA: 0x25C3470 Slot: 258
	public void OnDailyTrophyCheckReward(Game game, DailyTrophyCheckRewardResponse response) { }

	// RVA: 0x25C34A4 Offset: 0x25BF4A4 VA: 0x25C34A4 Slot: 263
	public void OnEventDailyTrophy(Game game, DailyTrophyEvent dailyTrophy) { }

	// RVA: 0x25C3528 Offset: 0x25BF528 VA: 0x25C3528 Slot: 226
	public void OnSkillLevelUp(Game game, SkillLevelUpResponse response) { }

	// RVA: 0x25C357C Offset: 0x25BF57C VA: 0x25C357C Slot: 225
	public void OnSkillLibrary(Game game, SkillLibraryResponse response) { }

	// RVA: 0x25C3634 Offset: 0x25BF634 VA: 0x25C3634 Slot: 229
	public void OnCompensationSkillReset(Game game, CompensationSkillResetResponse response) { }

	// RVA: 0x25C37B4 Offset: 0x25BF7B4 VA: 0x25C37B4 Slot: 227
	public void OnDeleteSkillTree(Game game, DeleteSkillTreeResponse response) { }

	// RVA: 0x25C3828 Offset: 0x25BF828 VA: 0x25C3828 Slot: 196
	public void OnRespawn(Game game, NormalRespawnResponse response) { }

	// RVA: 0x25C38C0 Offset: 0x25BF8C0 VA: 0x25C38C0 Slot: 197
	public void OnSystemRespawn(Game game, SystemRespawnResponse response) { }

	// RVA: 0x25C3A68 Offset: 0x25BFA68 VA: 0x25C3A68 Slot: 198
	public void OnSaveRespawnPosition(Game game, SaveRespawnPositionResponse response) { }

	// RVA: 0x25C3B2C Offset: 0x25BFB2C VA: 0x25C3B2C Slot: 159
	public void OnEventRespawnLatency(Game game, RespawnLatencyEvent latency) { }

	// RVA: 0x25C3C04 Offset: 0x25BFC04 VA: 0x25C3C04 Slot: 358
	public void OnEventGuildCheck(Game game, GuildCheckEvent checkEvent) { }

	// RVA: 0x25C3C24 Offset: 0x25BFC24 VA: 0x25C3C24 Slot: 340
	public void OnEventGuildInvitation(Game game, GuildInvitationEvent events) { }

	// RVA: 0x25C3C44 Offset: 0x25BFC44 VA: 0x25C3C44 Slot: 341
	public void OnEventGuildInviteSenderCancel(Game game, GuildInviteSenderCancelEvent events) { }

	// RVA: 0x25C3C64 Offset: 0x25BFC64 VA: 0x25C3C64 Slot: 339
	public void OnEventGuildJoin(Game game, GuildJoinEvent events) { }

	// RVA: 0x25C3C84 Offset: 0x25BFC84 VA: 0x25C3C84 Slot: 342
	public void OnEventGuildSecede(Game game, GuildSecedeEvent events) { }

	// RVA: 0x25C3CA4 Offset: 0x25BFCA4 VA: 0x25C3CA4 Slot: 344
	public void OnEventGuildWriteBoard(Game game, GuildWriteBoardEvent events) { }

	// RVA: 0x25C3CE8 Offset: 0x25BFCE8 VA: 0x25C3CE8 Slot: 301
	public void OnGuildAcceptance(Game game, GuildAcceptanceResponse response) { }

	// RVA: 0x25C3DB4 Offset: 0x25BFDB4 VA: 0x25C3DB4 Slot: 296
	public void OnGuildCreate(Game game, GuildCreateResponse response) { }

	// RVA: 0x25C3E4C Offset: 0x25BFE4C VA: 0x25C3E4C Slot: 304
	public void OnGuildDissolution(Game game, GuildDissolutionResponse response) { }

	// RVA: 0x25C3ED4 Offset: 0x25BFED4 VA: 0x25C3ED4 Slot: 303
	public void OnGuildExile(Game game) { }

	// RVA: 0x25C3EF0 Offset: 0x25BFEF0 VA: 0x25C3EF0 Slot: 343
	public void OnEventGuildExile(Game game, GuildExileEvent events) { }

	// RVA: 0x25C3F24 Offset: 0x25BFF24 VA: 0x25C3F24 Slot: 306
	public void OnGuildGetBoard(Game game, GuildGetBoardResponse response) { }

	// RVA: 0x25C3FC4 Offset: 0x25BFFC4 VA: 0x25C3FC4 Slot: 305
	public void OnGuildGetData(Game game, GuildGetDataResponse response) { }

	// RVA: 0x25C4064 Offset: 0x25C0064 VA: 0x25C4064 Slot: 319
	public void OnGuildMemberList(Game game, GuildMemberListResponse response) { }

	// RVA: 0x25C4138 Offset: 0x25C0138 VA: 0x25C4138 Slot: 299
	public void OnGuildInviteCancel(Game game, GuildInviteCancelResponse response) { }

	// RVA: 0x25C41AC Offset: 0x25C01AC VA: 0x25C41AC Slot: 298
	public void OnGuildInvitation(Game game, GuildInvitationResponse response) { }

	// RVA: 0x25C4208 Offset: 0x25C0208 VA: 0x25C4208 Slot: 300
	public void OnGuildInviteSenderCancel(Game game, GuildInviteSenderCancelResponse response) { }

	// RVA: 0x25C4228 Offset: 0x25C0228 VA: 0x25C4228 Slot: 302
	public void OnGuildSecede(Game game, GuildSecedeResponse response) { }

	// RVA: 0x25C425C Offset: 0x25C025C VA: 0x25C425C Slot: 307
	public void OnGuildWriteBoard(Game game) { }

	// RVA: 0x25C42DC Offset: 0x25C02DC VA: 0x25C42DC Slot: 295
	public void OnGuildNameCheck(Game game) { }

	// RVA: 0x25C435C Offset: 0x25C035C VA: 0x25C435C Slot: 346
	public void OnEventGuildNameChange(Game game, GuildNameChangeEvent guildEvent) { }

	// RVA: 0x25C437C Offset: 0x25C037C VA: 0x25C437C Slot: 297
	public void OnGuildNameChange(Game game, GuildNameChangeResponse response) { }

	// RVA: 0x25C4424 Offset: 0x25C0424 VA: 0x25C4424 Slot: 348
	public void OnEventGuildPostChange(Game game, GuildPostChangeEvent guildEvent) { }

	// RVA: 0x25C4444 Offset: 0x25C0444 VA: 0x25C4444 Slot: 308
	public void OnGuildPostChange(Game game, GuildPostChangeResponse response) { }

	// RVA: 0x25C4464 Offset: 0x25C0464 VA: 0x25C4464 Slot: 311
	public void OnGuildTransferMasterPost(Game game, GuildTransferMasterPostResponse response) { }

	// RVA: 0x25C450C Offset: 0x25C050C VA: 0x25C450C Slot: 312
	public void OnGuildCandidacyMasterPost(Game game, GuildCandidacyMasterPostResponse response) { }

	// RVA: 0x25C45B4 Offset: 0x25C05B4 VA: 0x25C45B4 Slot: 349
	public void OnEventGuildTransferMaster(Game game, GuildTransferMasterEvent transEvent) { }

	// RVA: 0x25C45D4 Offset: 0x25C05D4 VA: 0x25C45D4 Slot: 350
	public void OnEventGuildCandidacyMaster(Game game, GuildCandidacyMasterEvent transEvent) { }

	// RVA: 0x25C45F4 Offset: 0x25C05F4 VA: 0x25C45F4 Slot: 320
	public void OnGuildChangeOnlineNotice(Game game) { }

	// RVA: 0x25C4610 Offset: 0x25C0610 VA: 0x25C4610 Slot: 321
	public void OnGuildContrihuteGold(Game game, GuildContributeGoldResponse response) { }

	// RVA: 0x25C4834 Offset: 0x25C0834 VA: 0x25C4834 Slot: 355
	public void OnEventGuildUpdateVariableData(Game game, GuildUpdateVariableEvent updateVariableEvent) { }

	// RVA: 0x25C4858 Offset: 0x25C0858 VA: 0x25C4858 Slot: 313
	public void OnGuildGetBooster(Game game, GuildGetBoosterResponse response) { }

	// RVA: 0x25C491C Offset: 0x25C091C VA: 0x25C491C Slot: 314
	public void OnGuildCheckContribution(Game game, GuildCheckContributionResponse response) { }

	// RVA: 0x25C49E0 Offset: 0x25C09E0 VA: 0x25C49E0 Slot: 315
	public void OnGuildCollectContribution(Game game, GuildCollectContributionResponse response) { }

	// RVA: 0x25C4AA4 Offset: 0x25C0AA4 VA: 0x25C4AA4 Slot: 316
	public void OnGuildRunBooster(Game game, GuildRunBoosterResponse response) { }

	// RVA: 0x25C4B68 Offset: 0x25C0B68 VA: 0x25C4B68 Slot: 351
	public void OnEventGuildRunBooster(Game game, GuildRunBoosterEvent boosterEvent) { }

	// RVA: 0x25C4B88 Offset: 0x25C0B88 VA: 0x25C4B88 Slot: 352
	public void OnEventGuildStopBooster(Game game, GuildStopBoosterEvent boosterEvent) { }

	// RVA: 0x25C4CF4 Offset: 0x25C0CF4 VA: 0x25C4CF4 Slot: 317
	public void OnGuildPresent(Game game, GuildPresentResponse response) { }

	// RVA: 0x25C4DB8 Offset: 0x25C0DB8 VA: 0x25C4DB8 Slot: 353
	public void OnEventGuildPresent(Game game, GuildPresentEvent presentEvent) { }

	// RVA: 0x25C4DD8 Offset: 0x25C0DD8 VA: 0x25C4DD8 Slot: 354
	public void OnEventGuildPoint(Game game, GuildPointEvent pointEvent) { }

	// RVA: 0x25C4DDC Offset: 0x25C0DDC VA: 0x25C4DDC Slot: 322
	public void OnGuildChangeTenant(Game game, GuildChangeTenantResponse response) { }

	// RVA: 0x25C4ECC Offset: 0x25C0ECC VA: 0x25C4ECC Slot: 323
	public void OnGuildUpdateTenant(Game game, GuildUpdateTenantResponse response) { }

	// RVA: 0x25C4F44 Offset: 0x25C0F44 VA: 0x25C4F44 Slot: 324
	public void OnGuildGetStaffData(Game game, GuildGetStaffDataResponse response) { }

	// RVA: 0x25C4FC4 Offset: 0x25C0FC4 VA: 0x25C4FC4 Slot: 325
	public void OnGuildStartChangeStaffData(Game game, GuildStartChangeStaffDataResponse response) { }

	// RVA: 0x25C5094 Offset: 0x25C1094 VA: 0x25C5094 Slot: 326
	public void OnGuildEndChangeStaffData(Game game, GuildEndChangeStaffDataResponse response) { }

	// RVA: 0x25C50EC Offset: 0x25C10EC VA: 0x25C50EC Slot: 327
	public void OnGuildCancelChangeStaffData(Game game, GuildCancelChangeStaffDataResponse response) { }

	// RVA: 0x25C5144 Offset: 0x25C1144 VA: 0x25C5144 Slot: 356
	public void OnEventGuildUpdateStaffDataEvent(Game game, GuildUpdateStaffDataEvent updateStaffDataEvent) { }

	// RVA: 0x25C5178 Offset: 0x25C1178 VA: 0x25C5178 Slot: 357
	public void OnEventGuildCancelChangeStaffDataEvent(Game game, GuildCancelChangeStaffDataEvent cancelEvent) { }

	// RVA: 0x25C517C Offset: 0x25C117C VA: 0x25C517C Slot: 329
	public void OnGuildOpenRenovation(Game game, GuildOpenRenovationResponse response) { }

	// RVA: 0x25C5240 Offset: 0x25C1240 VA: 0x25C5240 Slot: 330
	public void OnGuildChangeRenovation(Game game, GuildChangeRenovationResponse response) { }

	// RVA: 0x25C52C4 Offset: 0x25C12C4 VA: 0x25C52C4 Slot: 359
	public void OnEventGuildUpdateRenovation(Game game, GuildUpdateRenovationEvent updateEvent) { }

	// RVA: 0x25C534C Offset: 0x25C134C VA: 0x25C534C Slot: 808
	public void OnGuildStaffChangeFlag(Game game, GuildStaffChangeFlagResponse response) { }

	// RVA: 0x25C53CC Offset: 0x25C13CC VA: 0x25C53CC Slot: 809
	public void OnGuildStaffChangeSupport(Game game, GuildStaffChangeSupportResponse response) { }

	// RVA: 0x25C544C Offset: 0x25C144C VA: 0x25C544C Slot: 812
	public void OnEventGuildStaffEndHire(Game game, GuildStaffendHireEvent endEvent) { }

	// RVA: 0x25C547C Offset: 0x25C147C VA: 0x25C547C Slot: 814
	public void OnEventGuildStaffStartRunningErrand(Game game, GuildStaffStartRunningErrandEvent startEvent) { }

	// RVA: 0x25C5538 Offset: 0x25C1538 VA: 0x25C5538 Slot: 810
	public void OnGuildStaffRunningErrand(Game game, GuildStaffRunningErrandResponse response) { }

	// RVA: 0x25C55BC Offset: 0x25C15BC VA: 0x25C55BC Slot: 813
	public void OnEventGuildStaffEndRunningErrand(Game game, GuildStaffEndRunningErrandEvent endEvent) { }

	// RVA: 0x25C55EC Offset: 0x25C15EC VA: 0x25C55EC Slot: 811
	public void OnGuildStaffRecoveryPlayer(Game game, GuildStaffRecoveryPlayerResponse response) { }

	// RVA: 0x25C5674 Offset: 0x25C1674 VA: 0x25C5674
	private bool TryUpdateGuildQuest(GuildQuestOperationCode code, out UIGuildQuestBoardManager basePanel) { }

	// RVA: 0x25C5820 Offset: 0x25C1820 VA: 0x25C5820 Slot: 855
	public void OnGuildQuestGetQuest(Game game, GuildQuestGetQuestResponse response) { }

	// RVA: 0x25C5890 Offset: 0x25C1890 VA: 0x25C5890 Slot: 856
	public void OnGuildQuestReportQuest(Game game, GuildQuestReportQuestResponse response) { }

	// RVA: 0x25C59D0 Offset: 0x25C19D0 VA: 0x25C59D0 Slot: 857
	public void OnGuildQuestDiscardQuest(Game game, GuildQuestDiscardResponse response) { }

	// RVA: 0x25C5ADC Offset: 0x25C1ADC VA: 0x25C5ADC Slot: 858
	public void OnGuildQuestResetQuest(Game game, GuildQuestResetQuestResponse response) { }

	// RVA: 0x25C5B38 Offset: 0x25C1B38 VA: 0x25C5B38 Slot: 328
	public void OnGuildMedalUpdate(Game game, GuildMedalUpdateResponse response) { }

	// RVA: 0x25C5BBC Offset: 0x25C1BBC VA: 0x25C5BBC Slot: 331
	public void OnGuildHeldRaid(Game game, GuildHeldRaidResponse response) { }

	// RVA: 0x25C5CD8 Offset: 0x25C1CD8 VA: 0x25C5CD8 Slot: 488
	public void OnEventGuildRaidStartOverTime(Game game) { }

	// RVA: 0x25C5DAC Offset: 0x25C1DAC VA: 0x25C5DAC Slot: 360
	public void OnEventGuildHeldRaid(Game game, GuildHeldRaidEvent heldEvent) { }

	// RVA: 0x25C5F10 Offset: 0x25C1F10 VA: 0x25C5F10 Slot: 332
	public void OnGuildGetHeldRaidData(Game game, GuildGetHeldRaidDataResponse response) { }

	// RVA: 0x25C5FCC Offset: 0x25C1FCC VA: 0x25C5FCC Slot: 338
	public void OnGuildEndHeldRaid(Game game) { }

	// RVA: 0x25C6024 Offset: 0x25C2024 VA: 0x25C6024 Slot: 335
	public void OnGuildLevelUpFacility(Game game, GuildLevelUpFacilityResponse response) { }

	// RVA: 0x25C6190 Offset: 0x25C2190 VA: 0x25C6190 Slot: 366
	public void OnEventGuildLevelUpFacility(Game game, GuildLevelUpFacilityEvent levelUpEvent) { }

	// RVA: 0x25C638C Offset: 0x25C238C VA: 0x25C638C Slot: 333
	public void OnGuildResetRaid(Game game) { }

	// RVA: 0x25C63E4 Offset: 0x25C23E4 VA: 0x25C63E4 Slot: 363
	public void OnEventGuldResetRaid(Game game) { }

	// RVA: 0x25C63E8 Offset: 0x25C23E8 VA: 0x25C63E8 Slot: 334
	public void OnGuildGetRaidBossData(Game game, GuildGetRaidBossDataResponse response) { }

	// RVA: 0x25C65CC Offset: 0x25C25CC VA: 0x25C65CC Slot: 491
	public void OnEventEnterGuildRaidField(Game game, EnterGuildRaidField enterEvent) { }

	// RVA: 0x25C68B0 Offset: 0x25C28B0 VA: 0x25C68B0 Slot: 367
	public void OnEventGuildOverKillRaid(Game game, GuildOverKillRaidEvent overKillEvent) { }

	// RVA: 0x25C69A0 Offset: 0x25C29A0 VA: 0x25C69A0 Slot: 361
	public void OnEventGuildEndRaid(Game game, GuildEndRaidEvent endEvent) { }

	// RVA: 0x25C6BA8 Offset: 0x25C2BA8 VA: 0x25C6BA8 Slot: 362
	public void OnEventGuildRaidEndBattle(Game game, GuildEndGuildRaidBattleEvent endEvent) { }

	// RVA: 0x25C6D90 Offset: 0x25C2D90 VA: 0x25C6D90 Slot: 860
	public void OnCheckGuildRaidRoom(Game game, CheckGuildRaidRoomResponse response) { }

	// RVA: 0x25C6DB0 Offset: 0x25C2DB0 VA: 0x25C6DB0 Slot: 364
	public void OnEventGuildRaidInvalidRandomProperty(Game game, GuildRaidInvalidRandomPropertyEvent invalidEvent) { }

	// RVA: 0x25C6EA0 Offset: 0x25C2EA0 VA: 0x25C6EA0 Slot: 492
	public void OnEventRoomLobbyLeave(Game game, RoomLobbyLeaveEvent leaveEvent) { }

	// RVA: 0x25C6F64 Offset: 0x25C2F64 VA: 0x25C6F64 Slot: 861
	public void OnGuildRaidStaminaRecovery(Game game, GuildRaidStaminaRecoveryResponse response) { }

	// RVA: 0x25C6F9C Offset: 0x25C2F9C VA: 0x25C6F9C Slot: 336
	public void OnGuildSetFacilityFlag(Game game, GuildSetFacilityFlagResponse response) { }

	// RVA: 0x25C706C Offset: 0x25C306C VA: 0x25C706C Slot: 337
	public void OnGuildGetRaidLog(Game game, GuildGetRaidLogDataResponse response) { }

	// RVA: 0x25C70A4 Offset: 0x25C30A4 VA: 0x25C70A4 Slot: 370
	public void OnEventGuildAllianceInvite(Game game, GuildAllianceInviteEvent inviteEvent) { }

	// RVA: 0x25C70E8 Offset: 0x25C30E8 VA: 0x25C70E8 Slot: 371
	public void OnEventGuildAllianceInviteCancel(Game game, GuildAllianceInviteCancelEvent cancelEvent) { }

	// RVA: 0x25C712C Offset: 0x25C312C VA: 0x25C712C Slot: 372
	public void OnEventGuildAllianceConsent(Game game, GuildAllianceConsentEvent consentEvent) { }

	// RVA: 0x25C7298 Offset: 0x25C3298 VA: 0x25C7298 Slot: 373
	public void OnEventGuildAllianceRelease(Game game, GuildAllianceReleaseEvent releaseEvent) { }

	// RVA: 0x25C7434 Offset: 0x25C3434 VA: 0x25C7434 Slot: 374
	public void OnEventGuildAllianceUpdateInfo(Game game, GuildAllianceUpdateInfoEvent updateEvent) { }

	// RVA: 0x25C746C Offset: 0x25C346C VA: 0x25C746C Slot: 375
	public void OnEventGuildAllianceChangeChatLink(Game game, GuildAllianceChangeChatLinkEvent changeEvent) { }

	// RVA: 0x25C74B0 Offset: 0x25C34B0 VA: 0x25C74B0 Slot: 369
	public void OnEventGuildOpenBgm(Game game, GuildOpenBgmEvent openEvent) { }

	// RVA: 0x25C751C Offset: 0x25C351C VA: 0x25C751C Slot: 556
	public void OnEventHeldGameEvent(Game game, HeldGameEvent eventData) { }

	// RVA: 0x25C7578 Offset: 0x25C3578 VA: 0x25C7578 Slot: 555
	public void OnEventEnterGameEventField(Game game, EnterGameEventField eventData) { }

	// RVA: 0x25C75D0 Offset: 0x25C35D0 VA: 0x25C75D0 Slot: 547
	public void OnGameEventSet(Game game, SetEventResponse setEvent, short returnCode) { }

	// RVA: 0x25C7668 Offset: 0x25C3668 VA: 0x25C7668 Slot: 548
	public void OnGameEventGet(Game game, GetEventResponse getEvent, short returnCode) { }

	// RVA: 0x25C7700 Offset: 0x25C3700 VA: 0x25C7700 Slot: 549
	public void OnGameEventGetScenario(Game game, GameEventGetScenarioResponse getScenario, short returnCode) { }

	// RVA: 0x25C7798 Offset: 0x25C3798 VA: 0x25C7798 Slot: 550
	public void OnGameEventGetFlag(Game game, GameEventGetFlagResponse getFlag, short returnCode) { }

	// RVA: 0x25C7830 Offset: 0x25C3830 VA: 0x25C7830 Slot: 551
	public void OnGameEventSetFlag(Game game, GameEventSetFlagResponse setFlag, short returnCode) { }

	// RVA: 0x25C78C8 Offset: 0x25C38C8 VA: 0x25C78C8 Slot: 553
	public void OnGameEventChangeField(Game game) { }

	// RVA: 0x25C7934 Offset: 0x25C3934 VA: 0x25C7934 Slot: 554
	public void OnGameEventResult(Game game, GameEventResultResponse result, short returnCode) { }

	// RVA: 0x25C7A48 Offset: 0x25C3A48 VA: 0x25C7A48 Slot: 552
	public void OnGameEventLogin(Game game, GameEventLoginResponse login, short returnCode) { }

	// RVA: 0x25C7AB0 Offset: 0x25C3AB0 VA: 0x25C7AB0 Slot: 562
	public void OnGetRoomGmEventMobData(Game game, GetRoomGmEventMobDataResponse response) { }

	// RVA: 0x25C7B38 Offset: 0x25C3B38 VA: 0x25C7B38 Slot: 806
	public void OnExchangeRun(Game game, ExchangeRunResponse response) { }

	// RVA: 0x25C7C38 Offset: 0x25C3C38 VA: 0x25C7C38 Slot: 807
	public void OnExchangeGetMyData(Game game, ExchangeGetMyDataResponse response) { }

	// RVA: 0x25C7D1C Offset: 0x25C3D1C VA: 0x25C7D1C Slot: 171
	public void OnEventExchangePointGetEvent(Game game, ExchangePointGetEvent eventData) { }

	// RVA: 0x25C7FF8 Offset: 0x25C3FF8 VA: 0x25C7FF8
	public void OnOperationPayFailure(Game game, byte operationCode, short returnCode, string debugMessage, IDictionary parameters) { }

	// RVA: 0x25C8030 Offset: 0x25C4030 VA: 0x25C8030
	public void OnReboot(Game game, OperationCode operationCode, GameReturnCode returnCode) { }

	// RVA: 0x25C8068 Offset: 0x25C4068 VA: 0x25C8068 Slot: 434
	public void OnCristaAttach(Game game, CristaAttachResponse response) { }

	// RVA: 0x25C8118 Offset: 0x25C4118 VA: 0x25C8118 Slot: 435
	public void OnCristaBreak(Game game, CristaBreakResponse response) { }

	// RVA: 0x25C81C8 Offset: 0x25C41C8 VA: 0x25C81C8 Slot: 436
	public void OnReinforceCristaAttach(Game game, ReinforceCristaAttachResponse response) { }

	// RVA: 0x25C82DC Offset: 0x25C42DC VA: 0x25C82DC Slot: 173
	public void OnDeterminePersonality(Game game, PersonalityType personalityType) { }

	// RVA: 0x25C8354 Offset: 0x25C4354 VA: 0x25C8354 Slot: 231
	public void OnCompensationStatusReset(Game game, CompensationStatusResetResponse responseObject) { }

	// RVA: 0x25C8374 Offset: 0x25C4374 VA: 0x25C8374 Slot: 232
	public void OnCompensationPersonalityReset(Game game, CompensationPersonalityResetResponse responseObject) { }

	// RVA: 0x25C8394 Offset: 0x25C4394 VA: 0x25C8394 Slot: 844
	public void OnRegistletProcessingGemCart(Game game, RegistletProcessingGemCartResponse response) { }

	// RVA: 0x25C846C Offset: 0x25C446C VA: 0x25C846C Slot: 845
	public void OnRegistletEnhanceGemCart(Game game, RegistletEnhanceGemCartResponse response) { }

	// RVA: 0x25C8548 Offset: 0x25C4548 VA: 0x25C8548 Slot: 846
	public void OnRegistletExtensionSlot(Game game, RegistletExtensionSlotResponse response) { }

	// RVA: 0x25C8620 Offset: 0x25C4620 VA: 0x25C8620 Slot: 847
	public void OnregistletChangeGemCartEquip(Game game, RegistletChangeGemCartEquipResponse response) { }

	// RVA: 0x25C8710 Offset: 0x25C4710 VA: 0x25C8710 Slot: 848
	public void OnRegistletChangeGemCartFlag(Game game, RegistletChangeGemCartFlagResponse response) { }

	// RVA: 0x25C87E4 Offset: 0x25C47E4 VA: 0x25C87E4 Slot: 442
	public void OnCheckBossSymbol(Game game, CheckBossSymbolResponse response) { }

	// RVA: 0x25C8804 Offset: 0x25C4804 VA: 0x25C8804 Slot: 457
	public void OnCheckRaidBossSymbol(Game game, CheckRaidBossSymbolResponse response) { }

	// RVA: 0x25C8824 Offset: 0x25C4824 VA: 0x25C8824 Slot: 469
	public void OnCheckTreasureHuntRoom(Game game, CheckTreasureHuntRoomResponse response) { }

	// RVA: 0x25C8844 Offset: 0x25C4844 VA: 0x25C8844 Slot: 475
	public void OnEventRoomAnnihilated(Game game, RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x25C8A18 Offset: 0x25C4A18 VA: 0x25C8A18 Slot: 470
	public void OnEventRoomBattleReady(Game game, RoomBattleReadyEvent battleReady) { }

	// RVA: 0x25C8AB4 Offset: 0x25C4AB4 VA: 0x25C8AB4 Slot: 445
	public void OnRoomState(Game game, RoomStateResponse response) { }

	// RVA: 0x25C8BE4 Offset: 0x25C4BE4 VA: 0x25C8BE4 Slot: 452
	public void OnRoomBattleJoin(Game game) { }

	// RVA: 0x25C8C74 Offset: 0x25C4C74 VA: 0x25C8C74 Slot: 451
	public void OnRoomBattleStart(Game game) { }

	// RVA: 0x25C8D04 Offset: 0x25C4D04 VA: 0x25C8D04 Slot: 446
	public void OnRoomGroupSettingChange(Game game, RoomGroupSettingChangeResponse response) { }

	// RVA: 0x25C8D60 Offset: 0x25C4D60 VA: 0x25C8D60 Slot: 447
	public void OnRoomJoinCancel(Game game) { }

	// RVA: 0x25C8DB4 Offset: 0x25C4DB4 VA: 0x25C8DB4 Slot: 449
	public void OnRoomJoinReady(Game game, RoomJoinReadyResponse response) { }

	// RVA: 0x25C8E5C Offset: 0x25C4E5C VA: 0x25C8E5C Slot: 450
	public void OnRoomJoinReadyCancel(Game game, RoomJoinReadyCancelResponse response) { }

	// RVA: 0x25C8F08 Offset: 0x25C4F08 VA: 0x25C8F08 Slot: 448
	public void OnRoomStartEntry(Game game) { }

	// RVA: 0x25C8F6C Offset: 0x25C4F6C VA: 0x25C8F6C Slot: 468
	public void OnRoomUpdateEntreeStaging(Game game) { }

	// RVA: 0x25C8FC0 Offset: 0x25C4FC0 VA: 0x25C8FC0 Slot: 478
	public void OnEventRoomLobbyBattle(Game game, RoomLobbyBattleEvent lobbyEvent) { }

	// RVA: 0x25C905C Offset: 0x25C505C VA: 0x25C905C Slot: 458
	public void OnRoomLobbyState(Game game, RoomLobbyStateResponse response) { }

	// RVA: 0x25C9238 Offset: 0x25C5238 VA: 0x25C9238 Slot: 464
	public void OnRoomLobbyBattleJoin(Game game) { }

	// RVA: 0x25C92CC Offset: 0x25C52CC VA: 0x25C92CC Slot: 463
	public void OnRoomLobbyBattleStart(Game game) { }

	// RVA: 0x25C9360 Offset: 0x25C5360 VA: 0x25C9360 Slot: 460
	public void OnRoomLobbySettingChange(Game game, RoomLobbySettingChangeResponse response) { }

	// RVA: 0x25C93BC Offset: 0x25C53BC VA: 0x25C93BC Slot: 459
	public void OnRoomLobbyLeave(Game game) { }

	// RVA: 0x25C9414 Offset: 0x25C5414 VA: 0x25C9414 Slot: 461
	public void OnRoomLobbyJoin(Game game, RoomLobbyJoinResponse response) { }

	// RVA: 0x25C95B4 Offset: 0x25C55B4 VA: 0x25C95B4 Slot: 462
	public void OnRoomLobbyJoinCancel(Game game, RoomLobbyJoinCancelResponse response) { }

	// RVA: 0x25C960C Offset: 0x25C560C VA: 0x25C960C Slot: 465
	public void OnRoomStart(Game game, RoomStartResponse response) { }

	// RVA: 0x25C9768 Offset: 0x25C5768 VA: 0x25C9768 Slot: 466
	public void OnRoomSecondPartyRegistry(Game game) { }

	// RVA: 0x25C976C Offset: 0x25C576C VA: 0x25C976C Slot: 485
	public void OnEventRoomNpcJoin(Game game, NpcArchetype npcArchetype, RoomNpcJoinEvent joinEvent) { }

	// RVA: 0x25C9790 Offset: 0x25C5790 VA: 0x25C9790 Slot: 484
	public void OnEventRoomMatchingEnd(Game game, RoomMatchingEndEvent endEvent) { }

	// RVA: 0x25C980C Offset: 0x25C580C VA: 0x25C980C Slot: 467
	public void OnRoomSecondPartyJoin(Game game) { }

	// RVA: 0x25C9810 Offset: 0x25C5810 VA: 0x25C9810 Slot: 182
	public void OnEventGameRecord(Game game, GameRecordEvent record) { }

	[Obsolete]
	// RVA: 0x25C9830 Offset: 0x25C5830 VA: 0x25C9830
	public void OnActionNpcAttack(Game game, GameReturnCode returnCode, AttackResponseData response) { }

	// RVA: 0x25C9834 Offset: 0x25C5834 VA: 0x25C9834 Slot: 113
	public void OnActionEventMove(Game game, byte archetypeType, int archetypeId, MoveData moveEvent) { }

	// RVA: 0x25C98B4 Offset: 0x25C58B4 VA: 0x25C98B4 Slot: 114
	public void OnActionEventMove(Game game, byte archetypeType, int archetypeId, MoveDataLight moveEvent) { }

	// RVA: 0x25C9934 Offset: 0x25C5934 VA: 0x25C9934 Slot: 119
	public void OnActionEventAttackStart(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C999C Offset: 0x25C599C VA: 0x25C999C Slot: 120
	public void OnActionEventAttack(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9A04 Offset: 0x25C5A04 VA: 0x25C9A04 Slot: 122
	public void OnActionEventSupportStart(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9A5C Offset: 0x25C5A5C VA: 0x25C9A5C Slot: 123
	public void OnActionEventSkillCancel(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9AB4 Offset: 0x25C5AB4 VA: 0x25C9AB4 Slot: 117
	public void OnActionEventEventAbnormal(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9B0C Offset: 0x25C5B0C VA: 0x25C9B0C Slot: 116
	public void OnActionEventMoodMessage(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9B64 Offset: 0x25C5B64 VA: 0x25C9B64 Slot: 115
	public void OnActionEventEmotion(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9BBC Offset: 0x25C5BBC VA: 0x25C9BBC Slot: 126
	public void OnActionEventMobCreate(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9C14 Offset: 0x25C5C14 VA: 0x25C9C14 Slot: 128
	public void OnActionEventMobMove(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9C6C Offset: 0x25C5C6C VA: 0x25C9C6C Slot: 129
	public void OnActionEventMobActionStart(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9CC4 Offset: 0x25C5CC4 VA: 0x25C9CC4 Slot: 130
	public void OnActionEventMobAttack(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9D1C Offset: 0x25C5D1C VA: 0x25C9D1C Slot: 131
	public void OnActionEventMobAttackToMob(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9D74 Offset: 0x25C5D74 VA: 0x25C9D74 Slot: 132
	public void OnActionEventMobSupport(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9DCC Offset: 0x25C5DCC VA: 0x25C9DCC Slot: 133
	public void OnActionEventMobActionCancel(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9E4C Offset: 0x25C5E4C VA: 0x25C9E4C Slot: 127
	public void OnActionEventMobRelease(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9ECC Offset: 0x25C5ECC VA: 0x25C9ECC Slot: 136
	public void OnActionEventMobCheck(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9F24 Offset: 0x25C5F24 VA: 0x25C9F24 Slot: 137
	public void OnActionEventSetEquip(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25C9F7C Offset: 0x25C5F7C VA: 0x25C9F7C Slot: 142
	public void OnActionEventSkillEvent(Game game, ArchetypeActionEvent data) { }

	// RVA: 0x25C9FD4 Offset: 0x25C5FD4 VA: 0x25C9FD4 Slot: 143
	public void OnActionEventGuardAndAvoid(Game game, ArchetypeActionEvent data) { }

	// RVA: 0x25CA02C Offset: 0x25C602C VA: 0x25CA02C Slot: 169
	public void OnEventRemoveSkillBuffer(Game game, RemoveSkillBufferEventResponseData eventData) { }

	// RVA: 0x25CA2B0 Offset: 0x25C62B0 VA: 0x25CA2B0 Slot: 118
	public void OnActionEventEventMonsterDamage(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25CA308 Offset: 0x25C6308 VA: 0x25CA308 Slot: 399
	public void OnEventPartyFieldJoin(Game game, int partyId, Archetype joinArchetype) { }

	// RVA: 0x25CA370 Offset: 0x25C6370 VA: 0x25CA370 Slot: 400
	public void OnEventPartyFieldLeave(Game game, int partyId, byte archetypeType, int archetypeId) { }

	// RVA: 0x25CA374 Offset: 0x25C6374 VA: 0x25CA374 Slot: 265
	public void OnEventLoginStamp(Game game, LoginStampEvent loginStamp) { }

	// RVA: 0x25CA3FC Offset: 0x25C63FC VA: 0x25CA3FC Slot: 260
	public void OnStampCardCheckReward(Game game, LoginStampRewardResponse response) { }

	// RVA: 0x25CA41C Offset: 0x25C641C VA: 0x25CA41C Slot: 206
	public void OnStorageGetList(Game game, StorageGetListResponse responseObject) { }

	// RVA: 0x25CA448 Offset: 0x25C6448 VA: 0x25CA448 Slot: 208
	public void OnStorageDataEdit(Game game, StorageDataEditResponse responseObject) { }

	// RVA: 0x25CA478 Offset: 0x25C6478 VA: 0x25CA478 Slot: 207
	public void OnStorageGetItems(Game game, StorageGetItemsResponse responseObject) { }

	// RVA: 0x25CA500 Offset: 0x25C6500 VA: 0x25CA500 Slot: 211
	public void OnStorageSortItem(Game game, StorageSortItemResponse responseObject) { }

	// RVA: 0x25CA580 Offset: 0x25C6580 VA: 0x25CA580 Slot: 212
	public void OnStorageDiscardItem(Game game, StorageDiscardItemResponse responseObject) { }

	// RVA: 0x25CA67C Offset: 0x25C667C VA: 0x25CA67C Slot: 209
	public void OnStorageTakeItem(Game game, StorageTakeItemResponse responseObject) { }

	// RVA: 0x25CA790 Offset: 0x25C6790 VA: 0x25CA790 Slot: 210
	public void OnStoragePutItem(Game game, StoragePutItemResponse responseObject) { }

	// RVA: 0x25CA824 Offset: 0x25C6824 VA: 0x25CA824 Slot: 213
	public void OnStorageItemFlagChange(Game game, StorageItemFlagChangeResponse responseObject) { }

	// RVA: 0x25CA920 Offset: 0x25C6920 VA: 0x25CA920 Slot: 214
	public void OnStorageOrderChange(Game game, StorageOrderChangeResponse responseObject) { }

	// RVA: 0x25CA9A0 Offset: 0x25C69A0 VA: 0x25CA9A0 Slot: 228
	public void OnSkillComboSet(Game game) { }

	// RVA: 0x25CA9F4 Offset: 0x25C69F4 VA: 0x25CA9F4 Slot: 426
	public void OnEventTradeRequest(Game game, TradeRequestEvent_ tradeEvent) { }

	// RVA: 0x25CAA28 Offset: 0x25C6A28 VA: 0x25CAA28 Slot: 427
	public void OnEventTradeRequestSenderCancel(Game game, TradeRequestSenderCancelEvent_ tradeEvent) { }

	// RVA: 0x25CAA5C Offset: 0x25C6A5C VA: 0x25CAA5C Slot: 428
	public void OnEventTradeStart(Game game, TradeStartEvent_ tradeEvent) { }

	// RVA: 0x25CAA90 Offset: 0x25C6A90 VA: 0x25CAA90 Slot: 429
	public void OnEventTradeState(Game game, TradeStateEvent_ tradeEvent) { }

	// RVA: 0x25CAAC4 Offset: 0x25C6AC4 VA: 0x25CAAC4 Slot: 430
	public void OnEventTradeApprovalStart(Game game, TradeApprovalStartEvent_ tradeEvent) { }

	// RVA: 0x25CAAF8 Offset: 0x25C6AF8 VA: 0x25CAAF8 Slot: 431
	public void OnEventTradeResult(Game game, TradeResultEvent_ tradeEvent) { }

	// RVA: 0x25CAB2C Offset: 0x25C6B2C VA: 0x25CAB2C Slot: 432
	public void OnEventTradeCancel(Game game, TradeCancelEvent_ tradeEvent) { }

	// RVA: 0x25CAB58 Offset: 0x25C6B58 VA: 0x25CAB58 Slot: 433
	public void OnEventTradeAbnormal(Game game, TradeAbnormalEvent_ tradeEvent) { }

	// RVA: 0x25CAB84 Offset: 0x25C6B84 VA: 0x25CAB84 Slot: 270
	public void OnNpcAvatarJoin(Game game, NpcArchetype npc, NpcAvatarJoinResponse npcResonse) { }

	// RVA: 0x25CABA8 Offset: 0x25C6BA8 VA: 0x25CABA8 Slot: 474
	public void OnEventRoomManagedArchetype(Game game, RoomArchetypeManagedEvent managedEvent) { }

	// RVA: 0x25CAC14 Offset: 0x25C6C14 VA: 0x25CAC14 Slot: 271
	public void OnNpcAvatarRejoin(Game game, NpcArchetype npc, NpcAvatarRejoinResponse npcResonse) { }

	// RVA: 0x25CAC88 Offset: 0x25C6C88 VA: 0x25CAC88 Slot: 268
	public void OnNpcRespawn(Game game, NpcRespawnResponse response) { }

	// RVA: 0x25CACF8 Offset: 0x25C6CF8 VA: 0x25CACF8 Slot: 269
	public void OnEventGroupMemberStatus(Game game, GroupMemberStatusEvent statusEvent) { }

	// RVA: 0x25CAD58 Offset: 0x25C6D58 VA: 0x25CAD58 Slot: 477
	public void OnEventVisitorMemberStatus(Game game, VisitorMemberStatusEvent statusEvent) { }

	// RVA: 0x25CADEC Offset: 0x25C6DEC VA: 0x25CADEC Slot: 273
	public void OnPartnerJoin(Game game, PartnerJoinResponse response) { }

	// RVA: 0x25CAE1C Offset: 0x25C6E1C VA: 0x25CAE1C Slot: 275
	public void OnMercenaryRegisterGet(Game game, MercenaryRegisterGetResponse response) { }

	// RVA: 0x25CAE5C Offset: 0x25C6E5C VA: 0x25CAE5C Slot: 276
	public void OnMercenaryRegister(Game game, MercenaryRegisterResponse response) { }

	// RVA: 0x25CAE9C Offset: 0x25C6E9C VA: 0x25CAE9C Slot: 277
	public void OnMercenaryEmploymentList(Game game, MercenaryEmploymentListResponse response) { }

	// RVA: 0x25CAEDC Offset: 0x25C6EDC VA: 0x25CAEDC Slot: 274
	public void OnMercenaryJoin(Game game, MercenaryJoinResponse response) { }

	// RVA: 0x25CAF1C Offset: 0x25C6F1C VA: 0x25CAF1C Slot: 272
	public void OnCompanionAvatarJoin(Game game, Archetype companionArchetype) { }

	// RVA: 0x25CAF54 Offset: 0x25C6F54 VA: 0x25CAF54 Slot: 278
	public void OnPetJoin(Game game, PetJoinResponse response) { }

	// RVA: 0x25CAF94 Offset: 0x25C6F94 VA: 0x25CAF94 Slot: 279
	public void OnPetList(Game game, GetPetListResponse response) { }

	// RVA: 0x25CAFD4 Offset: 0x25C6FD4 VA: 0x25CAFD4 Slot: 613
	public void OnHouseKeepPet(Game game, HouseKeepPetResponse response) { }

	// RVA: 0x25CB014 Offset: 0x25C7014 VA: 0x25CB014 Slot: 615
	public void OnHouseFeedPet(Game game, HouseFeedPetResponse response) { }

	// RVA: 0x25CB054 Offset: 0x25C7054 VA: 0x25CB054 Slot: 616
	public void OnHouseTrainPet(Game game, HouseTrainPetResponse response) { }

	// RVA: 0x25CB094 Offset: 0x25C7094 VA: 0x25CB094 Slot: 617
	public void OnHouseTrainFirstSkillPet(Game game, HouseTrainFirstSkillPetResponse response) { }

	// RVA: 0x25CB0D4 Offset: 0x25C70D4 VA: 0x25CB0D4 Slot: 618
	public void OnHousePetStatusUp(Game game, HousePetStatusUpResponse response) { }

	// RVA: 0x25CB114 Offset: 0x25C7114 VA: 0x25CB114 Slot: 619
	public void OnHousePetSkillSet(Game game, HousePetSkillSetResponse response) { }

	// RVA: 0x25CB154 Offset: 0x25C7154 VA: 0x25CB154 Slot: 621
	public void OnHouseEntrustPet(Game game, HouseEntrustPetResponse response) { }

	// RVA: 0x25CB194 Offset: 0x25C7194 VA: 0x25CB194 Slot: 622
	public void OnHouseTakePet(Game game, HouseTakePetResponse response) { }

	// RVA: 0x25CB1D4 Offset: 0x25C71D4 VA: 0x25CB1D4 Slot: 614
	public void OnHousePetNaming(Game game, HousePetNamingResponse response) { }

	// RVA: 0x25CB214 Offset: 0x25C7214 VA: 0x25CB214 Slot: 620
	public void OnHousePetStatusReset(Game game, HousePetStatusResetResponse response) { }

	// RVA: 0x25CB2A4 Offset: 0x25C72A4 VA: 0x25CB2A4 Slot: 623
	public void OnHouseExilePet(Game game, HouseExilePetResponse response) { }

	// RVA: 0x25CB2E4 Offset: 0x25C72E4 VA: 0x25CB2E4 Slot: 624
	public void OnHouseKennelPurchase(Game game, HouseKennelPurchaseResponse response) { }

	// RVA: 0x25CB324 Offset: 0x25C7324 VA: 0x25CB324 Slot: 280
	public void OnEventPetUpdate(Game game, PetUpdateEvent updateEvent) { }

	// RVA: 0x25CB364 Offset: 0x25C7364 VA: 0x25CB364 Slot: 281
	public void OnEventPetLogin(Game game, PetLoginEvent loginEvent) { }

	// RVA: 0x25CB3A4 Offset: 0x25C73A4 VA: 0x25CB3A4 Slot: 628
	public void OnHouseFeedStray(Game game, HouseFeedStrayResponse response) { }

	// RVA: 0x25CB3E4 Offset: 0x25C73E4 VA: 0x25CB3E4 Slot: 629
	public void OnHouseKeepStray(Game game, HouseKeepStrayResponse response) { }

	// RVA: 0x25CB424 Offset: 0x25C7424 VA: 0x25CB424 Slot: 630
	public void OnHouseExileStray(Game game, HouseExileStrayResponse response) { }

	// RVA: 0x25CB464 Offset: 0x25C7464 VA: 0x25CB464 Slot: 625
	public void OnHousePetUsePotion(Game game, HousePetUsePotionResponse response) { }

	// RVA: 0x25CB4A4 Offset: 0x25C74A4 VA: 0x25CB4A4 Slot: 627
	public void OnHousePetSynthesis(Game game, HousePetSynthesisResponse response) { }

	// RVA: 0x25CB4E4 Offset: 0x25C74E4 VA: 0x25CB4E4
	public void OnGmPetSkillLearning(Game game, PetData petData) { }

	// RVA: 0x25CB4E8 Offset: 0x25C74E8 VA: 0x25CB4E8
	public void OnGmPetLevelUp(Game game, PetData petData) { }

	// RVA: 0x25CB4EC Offset: 0x25C74EC VA: 0x25CB4EC
	public void OnGmPetSkillAddExp(Game game, PetData petData) { }

	// RVA: 0x25CB4F0 Offset: 0x25C74F0 VA: 0x25CB4F0
	public void OnGmPetSkillInitLevel(Game game, PetData petData) { }

	// RVA: 0x25CB4F4 Offset: 0x25C74F4 VA: 0x25CB4F4
	public void OnGmPetAffinity(Game game, PetData petData) { }

	// RVA: 0x25CB4F8 Offset: 0x25C74F8 VA: 0x25CB4F8
	public void OnGmPetStamina(Game game, PetData petData) { }

	// RVA: 0x25CB4FC Offset: 0x25C74FC VA: 0x25CB4FC
	public void OnGmPetIgnoringSatiety(Game game) { }

	// RVA: 0x25CB500 Offset: 0x25C7500 VA: 0x25CB500
	public void OnGmPetReset(Game game, PetInfoData petData) { }

	// RVA: 0x25CB504 Offset: 0x25C7504 VA: 0x25CB504
	public void OnGmKeepPet(Game game, PetInfoData pet) { }

	// RVA: 0x25CB580 Offset: 0x25C7580 VA: 0x25CB580 Slot: 21
	public void OnMasterAllowLogin(Game game, LoginResponse login) { }

	// RVA: 0x25CB5DC Offset: 0x25C75DC VA: 0x25CB5DC Slot: 18
	public void OnMasterReconnect(Game game) { }

	// RVA: 0x25CB638 Offset: 0x25C7638 VA: 0x25CB638 Slot: 16
	public void OnMasterStartConnection(Game game) { }

	// RVA: 0x25CB694 Offset: 0x25C7694 VA: 0x25CB694 Slot: 20
	public void OnMasterTimeoutDisconnect(Game game, StatusCode returnCode) { }

	// RVA: 0x25CB6F0 Offset: 0x25C76F0 VA: 0x25CB6F0 Slot: 41
	public void OnEventCustomerConnect(Game game, CustomerConnectEvent reconnect) { }

	// RVA: 0x25CB734 Offset: 0x25C7734 VA: 0x25CB734 Slot: 40
	public void OnEventCustomerDisconnect(Game game, CustomerDisconnectEvent disconnect) { }

	// RVA: 0x25CB790 Offset: 0x25C7790 VA: 0x25CB790 Slot: 76
	public void OnEventUserLogin(Game game, UserLoginEvent userLogin) { }

	// RVA: 0x25CBBA8 Offset: 0x25C7BA8 VA: 0x25CBBA8 Slot: 77
	public void OnEventUserReLogin(Game game, UserReLoginEvent userLogin) { }

	// RVA: 0x25CBE8C Offset: 0x25C7E8C VA: 0x25CBE8C Slot: 25
	public void OnGameConnect(Game game) { }

	// RVA: 0x25CBFFC Offset: 0x25C7FFC VA: 0x25CBFFC Slot: 29
	public void OnGameConnectSwitching(Game game) { }

	// RVA: 0x25CC190 Offset: 0x25C8190 VA: 0x25CC190 Slot: 36
	public void OnGameLoadAvatar(Game game, GameJoinResponse join) { }

	// RVA: 0x25CC25C Offset: 0x25C825C VA: 0x25CC25C Slot: 26
	public void OnGameReconnect(Game game) { }

	// RVA: 0x25CC2A4 Offset: 0x25C82A4 VA: 0x25CC2A4 Slot: 49
	public void OnGameRejoinLoadAvatar(Game game, GameReJoinResponse rejoin) { }

	// RVA: 0x25CC368 Offset: 0x25C8368 VA: 0x25CC368 Slot: 24
	public void OnGameStartConnection(Game game) { }

	// RVA: 0x25CC398 Offset: 0x25C8398 VA: 0x25CC398 Slot: 28
	public void OnGameTimeoutDisconnect(Game game, StatusCode returnCode) { }

	// RVA: 0x25CC3F0 Offset: 0x25C83F0 VA: 0x25CC3F0 Slot: 39
	public void OnGameBlank(Game game, byte reason) { }

	// RVA: 0x25CC45C Offset: 0x25C845C VA: 0x25CC45C Slot: 54
	public void OnGameRejoinBlank(Game game, GameReJoinResponse rejoin) { }

	// RVA: 0x25CC4CC Offset: 0x25C84CC VA: 0x25CC4CC Slot: 563
	public void OnEventPcPurchase(Game game, PcPurchaseEvent purchaseEvent) { }

	// RVA: 0x25CC4D0 Offset: 0x25C84D0 VA: 0x25CC4D0 Slot: 532
	public void OnEventOrbRelated(Game game, OrbRelatedEvent events) { }

	// RVA: 0x25CC5F8 Offset: 0x25C85F8 VA: 0x25CC5F8 Slot: 515
	public void OnOrbBarter(Game game, OrbBarterResponse response) { }

	// RVA: 0x25CC6BC Offset: 0x25C86BC VA: 0x25CC6BC Slot: 514
	public void OnOrbUpdate(Game game, OrbUpdateResponse response) { }

	// RVA: 0x25CC748 Offset: 0x25C8748 VA: 0x25CC748 Slot: 512
	public void OnOrbServicePrice(Game game, OrbServicePriceResponse response) { }

	// RVA: 0x25CC874 Offset: 0x25C8874 VA: 0x25CC874 Slot: 517
	public void OnOrbItemCheck(Game game, OrbItemCheckResponse response) { }

	// RVA: 0x25CC954 Offset: 0x25C8954 VA: 0x25CC954 Slot: 510
	public void OnOrbStoreUpdate(Game game, OrbStoreUpdateResponse response) { }

	// RVA: 0x25CC9E0 Offset: 0x25C89E0 VA: 0x25CC9E0 Slot: 520
	public void OnOrbItemMagicCharge(Game game, OrbItemMagicChargeResponse response) { }

	// RVA: 0x25CCB14 Offset: 0x25C8B14 VA: 0x25CCB14 Slot: 519
	public void OnOrbItemRespawn(Game game, OrbItemRespawnResponse response) { }

	// RVA: 0x25CCC60 Offset: 0x25C8C60 VA: 0x25CCC60 Slot: 516
	public void OnOrbTicketExchange(Game game, OrbTicketExchangeResponse response) { }

	// RVA: 0x25CCD3C Offset: 0x25C8D3C VA: 0x25CCD3C Slot: 518
	public void OnOrbItemUse(Game game, OrbItemUseResponse response) { }

	// RVA: 0x25CD3C4 Offset: 0x25C93C4 VA: 0x25CD3C4 Slot: 522
	public void OnOrbWroldWarp(Game game, OrbServiceBuyResponse response) { }

	// RVA: 0x25CD494 Offset: 0x25C9494 VA: 0x25CD494 Slot: 521
	public void OnOrbItemUseWarpTicket(Game game, OrbItemUseResponse response) { }

	// RVA: 0x25CD540 Offset: 0x25C9540 VA: 0x25CD540 Slot: 511
	public void OnOrbServiceBuy(Game game, OrbServiceBuyResponse response) { }

	// RVA: 0x25CE0F4 Offset: 0x25CA0F4 VA: 0x25CE0F4 Slot: 508
	public void OnOrbOperationFailure(Game game, OperationResponse response) { }

	// RVA: 0x25CE14C Offset: 0x25CA14C VA: 0x25CE14C Slot: 533
	public void OnEventOrbBonusEnd(Game game, OrbBonusEndEvent events) { }

	// RVA: 0x25CE1B8 Offset: 0x25CA1B8 VA: 0x25CE1B8 Slot: 509
	public void OnOrbCourseUpdate(Game game, OrbCourseUpdateResponse response) { }

	// RVA: 0x25CE244 Offset: 0x25CA244 VA: 0x25CE244 Slot: 523
	public void OnOrbRecycling(Game game, OrbRecyclingResponse response) { }

	// RVA: 0x25CE2E8 Offset: 0x25CA2E8 VA: 0x25CE2E8 Slot: 524
	public void OnOrbEquipFlagChange(Game game, OrbEquipFlagChangeResponse response) { }

	// RVA: 0x25CE3BC Offset: 0x25CA3BC VA: 0x25CE3BC Slot: 566
	public void OnDailyDartsGameEnter(Game game, DailyDartsGameEnterResponse response) { }

	// RVA: 0x25CE44C Offset: 0x25CA44C VA: 0x25CE44C Slot: 567
	public void OnDailyDartsGameThrowDarts(Game game, DailyDartsGameThrowDarts response) { }

	// RVA: 0x25CE4E0 Offset: 0x25CA4E0 VA: 0x25CE4E0 Slot: 568
	public void OnDailyDartsGameRewardItem(Game game, DailyDartsGameRewardItemResponse response) { }

	// RVA: 0x25CE5A4 Offset: 0x25CA5A4 VA: 0x25CE5A4 Slot: 526
	public void OnOrbStarGemExchange(Game game, OrbStarGemExchangeResponse response) { }

	// RVA: 0x25CE5FC Offset: 0x25CA5FC VA: 0x25CE5FC Slot: 527
	public void OnOrbStarGemBag(Game game, OrbStarGemBagResponse response) { }

	// RVA: 0x25CE654 Offset: 0x25CA654 VA: 0x25CE654 Slot: 528
	public void OnOrbStarGemEquip(Game game, OrbStarGemEquipResponse response) { }

	// RVA: 0x25CE6AC Offset: 0x25CA6AC VA: 0x25CE6AC Slot: 529
	public void OnOrbStarGemBreak(Game game, OrbStarGemBreakResponse response) { }

	// RVA: 0x25CE728 Offset: 0x25CA728 VA: 0x25CE728 Slot: 530
	public void OnOrbStarGemReinforce(Game game, OrbStarGemReinforceResponse response) { }

	// RVA: 0x25CE780 Offset: 0x25CA780 VA: 0x25CE780 Slot: 531
	public void OnOrbStarGemEvolution(Game game, OrbStarGemEvolutionResponse response) { }

	// RVA: 0x25CE7D8 Offset: 0x25CA7D8 VA: 0x25CE7D8 Slot: 525
	public void OnOrbStarGemPurchaseCheck(Game game, OrbStarGemPurchaseCheckResponse response) { }

	// RVA: 0x25CE830 Offset: 0x25CA830 VA: 0x25CE830
	public void OnOrbReEnchantment(Game game, OrbReEnchantmentResponse response) { }

	// RVA: 0x25CE834 Offset: 0x25CA834 VA: 0x25CE834
	public void OnOrbEnchantGetList(Game game, OrbEnchantGetListResponse response) { }

	// RVA: 0x25CE838 Offset: 0x25CA838 VA: 0x25CE838 Slot: 534
	public void OnBankOperationFailure(Game game, OperationResponse response) { }

	// RVA: 0x25CEA74 Offset: 0x25CAA74 VA: 0x25CEA74
	public UISpecialStorageManager PopUISpecialStorageManager(byte subCode) { }

	// RVA: 0x25CEB7C Offset: 0x25CAB7C VA: 0x25CEB7C Slot: 535
	public void OnBankSetup(Game game, BankSetupResponse response) { }

	// RVA: 0x25CEC28 Offset: 0x25CAC28 VA: 0x25CEC28 Slot: 536
	public void OnBankDepositGold(Game game, BankDepositGoldResponse response) { }

	// RVA: 0x25CECE0 Offset: 0x25CACE0 VA: 0x25CECE0 Slot: 537
	public void OnBankWithdrawGold(Game game, BankWithdrawGoldResponse response) { }

	// RVA: 0x25CED98 Offset: 0x25CAD98 VA: 0x25CED98 Slot: 543
	public void OnBankMarketDepositGold(Game game, BankMarketDepositGoldResponse response) { }

	// RVA: 0x25CF018 Offset: 0x25CB018 VA: 0x25CF018 Slot: 538
	public void OnBankDepositMaterial(Game game, BankDepositMaterialResponse response) { }

	// RVA: 0x25CF0D0 Offset: 0x25CB0D0 VA: 0x25CF0D0 Slot: 539
	public void OnBankWithdrawMaterial(Game game, BankWithdrawMaterialResponse response) { }

	// RVA: 0x25CF188 Offset: 0x25CB188 VA: 0x25CF188 Slot: 544
	public void OnBankMarketDepositMaterial(Game game, BankMarketDepositMaterialResponse response) { }

	// RVA: 0x25CF408 Offset: 0x25CB408 VA: 0x25CF408 Slot: 540
	public void OnBankExpPotionPurchase(Game game, BankExpPotionPurchaseResponse response) { }

	// RVA: 0x25CF4D0 Offset: 0x25CB4D0 VA: 0x25CF4D0 Slot: 541
	public void OnBankExpPotionDeposit(Game game, BankExpPotionDepositResponse response) { }

	// RVA: 0x25CF56C Offset: 0x25CB56C VA: 0x25CF56C Slot: 542
	public void OnBankExpPotionUse(Game game, BankExpPotionUseResponse response) { }

	// RVA: 0x25CF684 Offset: 0x25CB684 VA: 0x25CF684 Slot: 545
	public void OnBankMarketDepositExpPotion(Game game, BankMarketDepositExpPotionResponse response) { }

	// RVA: 0x25CF90C Offset: 0x25CB90C VA: 0x25CF90C Slot: 546
	public void OnEventExpPotionLevelup(Game game, ExpPotionLevelupEvent levelup) { }

	// RVA: 0x25CF9DC Offset: 0x25CB9DC VA: 0x25CF9DC Slot: 594
	public void OnHouseEnter(Game game) { }

	// RVA: 0x25CFA70 Offset: 0x25CBA70 VA: 0x25CFA70 Slot: 600
	public void OnHouseEntryCheck(Game game, HouseEntryCheckResponse response) { }

	// RVA: 0x25CFAFC Offset: 0x25CBAFC VA: 0x25CFAFC Slot: 601
	public void OnHouseSaveEntry(Game game, HouseSaveEntryResponse response) { }

	// RVA: 0x25CFB88 Offset: 0x25CBB88 VA: 0x25CFB88 Slot: 602
	public void OnHouseOtherList(Game game, HouseOtherListResponse response) { }

	// RVA: 0x25CFC10 Offset: 0x25CBC10 VA: 0x25CFC10 Slot: 595
	public void OnHouseLeave(Game game) { }

	// RVA: 0x25CFCA4 Offset: 0x25CBCA4 VA: 0x25CFCA4 Slot: 596
	public void OnHouseInitialLandPurchase(Game game, HouseInitialLandPurchaseResponse response) { }

	// RVA: 0x25CFD50 Offset: 0x25CBD50 VA: 0x25CFD50 Slot: 597
	public void OnHouseStartEditMode(Game game, HouseStartEditModeResponse response) { }

	// RVA: 0x25CFDDC Offset: 0x25CBDDC VA: 0x25CFDDC Slot: 598
	public void OnHouseEndEditMode(Game game, HouseEndEditModeResponse response) { }

	// RVA: 0x25CFE68 Offset: 0x25CBE68 VA: 0x25CFE68 Slot: 599
	public void OnHouseSave(Game game, HouseSaveResponse response) { }

	// RVA: 0x25CFEA0 Offset: 0x25CBEA0 VA: 0x25CFEA0 Slot: 603
	public void OnHousePartitionEdit(Game game, HousePartitionEditResponse response) { }

	// RVA: 0x25CFF28 Offset: 0x25CBF28 VA: 0x25CFF28 Slot: 605
	public void OnHouseLandPurchase(Game game, HouseLandPurchaseResponse response) { }

	// RVA: 0x25D0000 Offset: 0x25CC000 VA: 0x25D0000 Slot: 604
	public void OnHouseConstruction(Game game, HouseConstructionResponse response) { }

	// RVA: 0x25D0088 Offset: 0x25CC088 VA: 0x25D0088 Slot: 606
	public void OnHouseCoordinate(Game game, HouseCoordinateResponse response) { }

	// RVA: 0x25D0110 Offset: 0x25CC110 VA: 0x25D0110 Slot: 607
	public void OnHouseCoordinate(Game game, HouseCoordinateRemovesResponse response) { }

	// RVA: 0x25D0198 Offset: 0x25CC198 VA: 0x25D0198 Slot: 609
	public void OnHouseCreateObjItem(Game game, HouseCreateObjItemResponse response) { }

	// RVA: 0x25D02E4 Offset: 0x25CC2E4 VA: 0x25D02E4 Slot: 608
	public void OnHouseBelonginsList(Game game, HouseBelonginsListResponse response) { }

	// RVA: 0x25D036C Offset: 0x25CC36C VA: 0x25D036C Slot: 610
	public void OnHouseUpdateObjItem(Game game, HouseUpdateObjItemResponse response) { }

	// RVA: 0x25D03C4 Offset: 0x25CC3C4 VA: 0x25D03C4 Slot: 141
	public void OnActionEventHousePetMove(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25D0464 Offset: 0x25CC464 VA: 0x25D0464 Slot: 626
	public void OnHousePetOwnershipUpdate(Game game, HousePetOwnershipUpdateResponse response) { }

	// RVA: 0x25D04EC Offset: 0x25CC4EC VA: 0x25D04EC Slot: 282
	public void OnEventPetOwnership(Game game, PetOwnershipEvent ownershipEvent) { }

	// RVA: 0x25D0574 Offset: 0x25CC574 VA: 0x25D0574 Slot: 611
	public void OnHouseBgmChange(Game game, HouseBgmChangeResponse response) { }

	// RVA: 0x25D0600 Offset: 0x25CC600 VA: 0x25D0600 Slot: 674
	public void OnEventHouseBgmChange(Game game, HouseBgmChangeEvent endEvent) { }

	[Obsolete("削除予定")]
	// RVA: 0x25D065C Offset: 0x25CC65C VA: 0x25D065C
	public void OnGmHouseListAnchor(Game game) { }

	// RVA: 0x25D0660 Offset: 0x25CC660 VA: 0x25D0660 Slot: 612
	public void OnHouseListAnchor(Game game, HouseListAnchorResponse response) { }

	// RVA: 0x25D06B8 Offset: 0x25CC6B8 VA: 0x25D06B8
	private void UpdateHouseLotteryUsers(LotteryOperationCode code, int num) { }

	// RVA: 0x25D07FC Offset: 0x25CC7FC VA: 0x25D07FC Slot: 815
	public void OnHouseLotteryRecruitStart(Game game, HouseLotteryRecruitStartResponse response) { }

	// RVA: 0x25D0854 Offset: 0x25CC854 VA: 0x25D0854 Slot: 816
	public void OnHouseLotteryRecruitCancel(Game game, HouseLotteryRecruitCancelResponse response) { }

	// RVA: 0x25D08AC Offset: 0x25CC8AC VA: 0x25D08AC Slot: 817
	public void OnHouseLotteryStart(Game game, HouseLotteryStartResponse response) { }

	// RVA: 0x25D0A1C Offset: 0x25CCA1C VA: 0x25D0A1C Slot: 821
	public void OnHouseLotteryRecruitReSend(Game game, HouseLotteryRecruitReSendResponse response) { }

	// RVA: 0x25D0A74 Offset: 0x25CCA74 VA: 0x25D0A74 Slot: 819
	public void OnHouseLotteryInfo(Game game, HouseLotteryInfoResponse response) { }

	// RVA: 0x25D0A90 Offset: 0x25CCA90 VA: 0x25D0A90 Slot: 820
	public void OnHouseLotteryListClear(Game game, HouseLotteryListClearResponse response) { }

	// RVA: 0x25D0A9C Offset: 0x25CCA9C VA: 0x25D0A9C Slot: 818
	public void OnHouseLotteryJoin(Game game, HouseLotteryJoinResponse response) { }

	// RVA: 0x25D0C24 Offset: 0x25CCC24 VA: 0x25D0C24 Slot: 822
	public void OnEventHouseLotteryRecruit(Game game, HouseLotteryRecruitEvent houseEvent) { }

	// RVA: 0x25D1088 Offset: 0x25CD088 VA: 0x25D1088 Slot: 790
	public void OnCultivationPlant(Game game, CultivationPlantResponse response) { }

	// RVA: 0x25D113C Offset: 0x25CD13C VA: 0x25D113C Slot: 791
	public void OnCultivationRemove(Game game, CultivationRemoveResponse response) { }

	// RVA: 0x25D11D0 Offset: 0x25CD1D0 VA: 0x25D11D0 Slot: 792
	public void OnCultivationHarvest(Game game, CultivationHarvestResponse response) { }

	// RVA: 0x25D127C Offset: 0x25CD27C VA: 0x25D127C Slot: 793
	public void OnCultivationWatering(Game game, CultivationWateringResponse response) { }

	// RVA: 0x25D130C Offset: 0x25CD30C VA: 0x25D130C Slot: 794
	public void OnCultivationGardenEnter(Game game, CultivationGardenEnterResponse response) { }

	// RVA: 0x25D1524 Offset: 0x25CD524 VA: 0x25D1524 Slot: 795
	public void OnCultivationGardenLeave(Game game, CultivationGardenLeaveResponse response) { }

	// RVA: 0x25D1718 Offset: 0x25CD718 VA: 0x25D1718 Slot: 796
	public void OnCultivationGetList(Game game, CultivationGetListResponse response) { }

	// RVA: 0x25D17CC Offset: 0x25CD7CC VA: 0x25D17CC Slot: 797
	public void OnCuisineCooking(Game game, CuisineCookingResponse response) { }

	// RVA: 0x25D18EC Offset: 0x25CD8EC VA: 0x25D18EC Slot: 803
	public void OnCuisineSubCooking(Game game, CuisineSubCookingResponse response) { }

	// RVA: 0x25D1A10 Offset: 0x25CDA10 VA: 0x25D1A10 Slot: 798
	public void OnCuisineDineOut(Game game, CuisineDineOutResponse response) { }

	// RVA: 0x25D1B1C Offset: 0x25CDB1C VA: 0x25D1B1C Slot: 804
	public void OnCuisineChangeType(Game game, CuisineChangeTypeResponse response) { }

	// RVA: 0x25D1C1C Offset: 0x25CDC1C VA: 0x25D1C1C Slot: 799
	public void OnCuisineGetRecipe(Game game, CuisineGetRecipeResponse response) { }

	// RVA: 0x25D1CB0 Offset: 0x25CDCB0 VA: 0x25D1CB0 Slot: 801
	public void OnGetEatingList(Game game, GetEatingListResponse response) { }

	// RVA: 0x25D1D9C Offset: 0x25CDD9C VA: 0x25D1D9C Slot: 800
	public void OnGetFoodPoint(Game game, GetFoodPointResponse response) { }

	// RVA: 0x25D1E20 Offset: 0x25CDE20 VA: 0x25D1E20 Slot: 802
	public void OnEventCuisineBuffEnd(Game game, CuisineBuffEndEvent endEvent) { }

	// RVA: 0x25D202C Offset: 0x25CE02C VA: 0x25D202C Slot: 805
	public void OnCuisineCleanUp(Game game, CuisineCleanUpResponse response) { }

	// RVA: 0x25D2268 Offset: 0x25CE268 VA: 0x25D2268 Slot: 684
	public void OnEventCuisineUpdate(Game game, CuisineUpdateEvent updateEvent) { }

	// RVA: 0x25D2308 Offset: 0x25CE308 VA: 0x25D2308 Slot: 497
	public void OnActionDungeonTrap(Game game, GameReturnCode returnCode, DungeonTrapDamageResponseData events) { }

	// RVA: 0x25D2344 Offset: 0x25CE344 VA: 0x25D2344 Slot: 498
	public void OnActionDungeonTrapAttackData(Game game, GameReturnCode returnCode, DungeonTrapData trapData) { }

	// RVA: 0x25D2374 Offset: 0x25CE374 VA: 0x25D2374 Slot: 499
	public void OnActionEventDungeonTrapAttackData(Game game, DungeonTrapData trapData) { }

	// RVA: 0x25D2398 Offset: 0x25CE398 VA: 0x25D2398 Slot: 502
	public void OnDungeonBeat(Game game, short areaLevel) { }

	// RVA: 0x25D23B8 Offset: 0x25CE3B8 VA: 0x25D23B8 Slot: 500
	public void OnActionOpenItemBox(Game game, int itemBoxId, ResultData resultData) { }

	// RVA: 0x25D2420 Offset: 0x25CE420 VA: 0x25D2420 Slot: 454
	public void OnCheckDungeonRoom(Game game, CheckDungeonRoomResponse response) { }

	// RVA: 0x25D2440 Offset: 0x25CE440 VA: 0x25D2440 Slot: 501
	public void OnDungeonDownstairs(Game game, DownstairsDungeonField dungeonDownstairs) { }

	// RVA: 0x25D24A0 Offset: 0x25CE4A0 VA: 0x25D24A0 Slot: 455
	public void OnDungeonGroupSettingChange(Game game, DungeonGroupSettingChangeResponse response) { }

	// RVA: 0x25D24C0 Offset: 0x25CE4C0 VA: 0x25D24C0 Slot: 495
	public void OnDungeonTrapActive(Game game, byte senderType, int senderId, byte trapId) { }

	// RVA: 0x25D24E8 Offset: 0x25CE4E8 VA: 0x25D24E8 Slot: 496
	public void OnEnterDungeonField(Game game, EnterDungeonField events) { }

	// RVA: 0x25D2508 Offset: 0x25CE508 VA: 0x25D2508 Slot: 504
	public void OnDungeonGuildHomeEscape(Game game) { }

	// RVA: 0x25D259C Offset: 0x25CE59C VA: 0x25D259C Slot: 456
	public void OnManaMagicCharge(Game game, ManaMagicChargeResponse response) { }

	// RVA: 0x25D25BC Offset: 0x25CE5BC VA: 0x25D25BC Slot: 503
	public void OnCheckDungeonFloorDepth(Game game) { }

	// RVA: 0x25D2610 Offset: 0x25CE610 VA: 0x25D2610 Slot: 345
	public void OnEventGuildCreate(Game game, GuildCreateEvent guildEvent) { }

	// RVA: 0x25D266C Offset: 0x25CE66C VA: 0x25D266C Slot: 95
	public void OnActionBattleEndCheck(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, BattleEndCheckData response) { }

	// RVA: 0x25D2754 Offset: 0x25CE754 VA: 0x25D2754 Slot: 110
	public void OnActionEventDamage(Game game, GameReturnCode returnCode, EventDamageResponseData events) { }

	// RVA: 0x25D2790 Offset: 0x25CE790 VA: 0x25D2790 Slot: 94
	public void OnActionEventMonsterDamage(Game game, GameReturnCode returnCode, EventMonsterDamageResponseData responseData) { }

	// RVA: 0x25D27CC Offset: 0x25CE7CC VA: 0x25D27CC Slot: 472
	public void OnEventRoomBattleStart(Game game, RoomBattleStartEvent response) { }

	// RVA: 0x25D27F4 Offset: 0x25CE7F4 VA: 0x25D27F4 Slot: 473
	public void OnEventRoomSupportUpdate(Game game, RoomSupportUpdateEvent response) { }

	// RVA: 0x25D282C Offset: 0x25CE82C VA: 0x25D282C Slot: 309
	public void OnGuildHomeEnter(Game game) { }

	// RVA: 0x25D2830 Offset: 0x25CE830 VA: 0x25D2830 Slot: 310
	public void OnGuildHomeLeave(Game game) { }

	// RVA: 0x25D2898 Offset: 0x25CE898 VA: 0x25D2898 Slot: 859
	public void OnGuildRaidLobbyEnter(Game game) { }

	// RVA: 0x25D289C Offset: 0x25CE89C VA: 0x25D289C Slot: 250
	public void OnRecreateChange(Game game) { }

	// RVA: 0x25D28F0 Offset: 0x25CE8F0 VA: 0x25D28F0 Slot: 175
	public void OnAcceptPrison(Game game, AcceptPrisonResponse prison) { }

	// RVA: 0x25D2970 Offset: 0x25CE970 VA: 0x25D2970 Slot: 735
	public void OnEventSystemBan(Game game, SystemBanEvent banEvent) { }

	// RVA: 0x25D2994 Offset: 0x25CE994 VA: 0x25D2994 Slot: 58
	public void OnCreateAvatarStart(Game game, string avatarName, GameReturnCode returnCode) { }

	// RVA: 0x25D2A34 Offset: 0x25CEA34 VA: 0x25D2A34
	public void OnGameAvatarInheritCreate(Game game, PeerResultCode resultCode, GameJoinResponse join) { }

	// RVA: 0x25D2A38 Offset: 0x25CEA38 VA: 0x25D2A38
	public void OnGameRejoinAvatarInheritCreate(Game game, PeerResultCode resultCode, GameReJoinResponse rejoin) { }

	// RVA: 0x25D2A5C Offset: 0x25CEA5C VA: 0x25D2A5C Slot: 251
	public void OnRecreateStyle(Game game, RecreateStyleResponse response) { }

	// RVA: 0x25D2B38 Offset: 0x25CEB38 VA: 0x25D2B38 Slot: 347
	public void OnEventGuildLevelUp(Game game, GuildLevelUpEvent levelupEvent) { }

	// RVA: 0x25D2B58 Offset: 0x25CEB58 VA: 0x25D2B58 Slot: 736
	public void OnEventGameSystemUpdate(Game game, GameSystemUpdateEvent updateEvent) { }

	// RVA: 0x25D2B78 Offset: 0x25CEB78 VA: 0x25D2B78 Slot: 79
	public void OnActionNotReadyToRun(Game game) { }

	// RVA: 0x25D2D24 Offset: 0x25CED24 VA: 0x25D2D24 Slot: 557
	public void OnAvatarGenericFlagList(Game game, AvatarGenericFlagListResponse response) { }

	// RVA: 0x25D2D50 Offset: 0x25CED50 VA: 0x25D2D50 Slot: 558
	public void OnUpdateGenericFlag(Game game, UpdateGenericFlagResponse response) { }

	// RVA: 0x25D2E58 Offset: 0x25CEE58 VA: 0x25D2E58 Slot: 8
	public void OnReportAppliLog(Game game, int code, string message) { }

	// RVA: 0x25D2E5C Offset: 0x25CEE5C VA: 0x25D2E5C Slot: 221
	public void OnMarketProductList(Game game, MarketProductListResponse responseObject, GameReturnCode returnCode) { }

	// RVA: 0x25D2FB4 Offset: 0x25CEFB4 VA: 0x25D2FB4 Slot: 224
	public void OnEventMarketUpdate(Game game, MarketUpdateEvent updateEvent) { }

	// RVA: 0x25D3208 Offset: 0x25CF208 VA: 0x25D3208 Slot: 215
	public void OnMarketSetUp(Game game, MarketSetupResponse responseObject, GameReturnCode returnCode) { }

	// RVA: 0x25D32AC Offset: 0x25CF2AC VA: 0x25D32AC Slot: 216
	public void OnMarketUserSalesList(Game game, MarketUserSalesListResponse responseObject, GameReturnCode returnCode) { }

	// RVA: 0x25D3404 Offset: 0x25CF404 VA: 0x25D3404 Slot: 217
	public void OnMarketExhibit(Game game, MarketExhibitResponse responseObject, GameReturnCode returnCode) { }

	// RVA: 0x25D355C Offset: 0x25CF55C VA: 0x25D355C Slot: 218
	public void OnMarketExhibitCancel(Game game, MarketExhibitCancelResponse responseObject, GameReturnCode returnCode) { }

	// RVA: 0x25D36B4 Offset: 0x25CF6B4 VA: 0x25D36B4 Slot: 219
	public void OnMarketSalesAcquisitionFailed(Game game, MarketSalesResultResponse responseObject) { }

	// RVA: 0x25D3768 Offset: 0x25CF768 VA: 0x25D3768 Slot: 220
	public void OnMarketSalesAcquisition(Game game, MarketSalesResultResponse responseObject) { }

	// RVA: 0x25D381C Offset: 0x25CF81C VA: 0x25D381C Slot: 222
	public void OnMarketPurchase(Game game, MarketPurchaseResponse responseObject) { }

	// RVA: 0x25D38D0 Offset: 0x25CF8D0 VA: 0x25D38D0 Slot: 223
	public void OnMarketPurchaseFailed(Game game, MarketPurchaseResponse responseObject) { }

	// RVA: 0x25D3984 Offset: 0x25CF984 VA: 0x25D3984 Slot: 443
	public void OnCheckDefenceRoom(Game game, CheckDefenceRoomResponse response) { }

	// RVA: 0x25D3A9C Offset: 0x25CFA9C VA: 0x25D3A9C Slot: 505
	public void OnEnterDefenceField(Game game, EnterDefenceField events) { }

	// RVA: 0x25D3BA4 Offset: 0x25CFBA4 VA: 0x25D3BA4 Slot: 707
	public void OnEventDefenceStartGame(Game game, DefenceStartGame startEvent) { }

	// RVA: 0x25D3D48 Offset: 0x25CFD48 VA: 0x25D3D48 Slot: 709
	public void OnEventDefenceMoveMob(Game game, DefenceMoveMobEvent moveEvent) { }

	// RVA: 0x25D3E90 Offset: 0x25CFE90 VA: 0x25D3E90 Slot: 708
	public void OnEventDefencePopMob(Game game, DefencePopMobEvent popEvent) { }

	// RVA: 0x25D400C Offset: 0x25D000C VA: 0x25D400C Slot: 710
	public void OnEventDefenceTargetChangeMob(Game game, DefenceTargetChangeMobEvent targetChangeEvent) { }

	// RVA: 0x25D4150 Offset: 0x25D0150 VA: 0x25D4150 Slot: 711
	public void OnEventDefenceCrystalAttack(Game game, DefenceCrystalAttackEvent attackEvent) { }

	// RVA: 0x25D4264 Offset: 0x25D0264 VA: 0x25D4264 Slot: 712
	public void OnEventDefenceGameEnd(Game game, DefenceGameEndEvent endEvent) { }

	// RVA: 0x25D4480 Offset: 0x25D0480 VA: 0x25D4480 Slot: 713
	public void OnDefenceRankingCurrentScoreResponse(Game game, DefenceCurrentScoreResponse response) { }

	// RVA: 0x25D4544 Offset: 0x25D0544 VA: 0x25D4544 Slot: 714
	public void OnDefenceRankingTop100Response(Game game, DefenceScoreRankingResponse response) { }

	// RVA: 0x25D4608 Offset: 0x25D0608 VA: 0x25D4608 Slot: 716
	public void OnDefenceRankingResultResponse(Game game, DefenceScoreResultRankingResponse response) { }

	// RVA: 0x25D46CC Offset: 0x25D06CC VA: 0x25D46CC Slot: 717
	public void OnDefenceRankingRewardResponse(Game game, DefenceScoreResultRewardResponse response) { }

	// RVA: 0x25D47AC Offset: 0x25D07AC VA: 0x25D47AC Slot: 742
	public void OnEventWaveGameStart(Game game, WaveGameStartEvent startEvent) { }

	// RVA: 0x25D4864 Offset: 0x25D0864 VA: 0x25D4864 Slot: 744
	public void OnEventWavePopMob(Game game, WavePopMobEvent popEvent) { }

	// RVA: 0x25D4948 Offset: 0x25D0948 VA: 0x25D4948 Slot: 743
	public void OnEventWaveNextWave(Game game, WaveNextWaveEvent nextWave) { }

	// RVA: 0x25D49F4 Offset: 0x25D09F4 VA: 0x25D49F4 Slot: 750
	public void OnEventWaveGameEnd(Game game, WaveGameEndEvent endEvent) { }

	// RVA: 0x25D4AB0 Offset: 0x25D0AB0 VA: 0x25D4AB0 Slot: 745
	public void OnEventWaveMoveMob(Game game, WaveMoveMobEvent moveEvent) { }

	// RVA: 0x25D4B24 Offset: 0x25D0B24 VA: 0x25D4B24 Slot: 747
	public void OnEventWaveTargetAttack(Game game, WaveTargetAttackEvent attackEvent) { }

	// RVA: 0x25D4BF0 Offset: 0x25D0BF0 VA: 0x25D4BF0 Slot: 746
	public void OnEventWaveMoveDefenceObject(Game game, WaveMoveDefenceObjectEvent moveEvent) { }

	// RVA: 0x25D4CAC Offset: 0x25D0CAC VA: 0x25D4CAC Slot: 748
	public void OnEventWaveMinusHate(Game game, WaveMinusHateEvent hateEvent) { }

	// RVA: 0x25D4CB0 Offset: 0x25D0CB0 VA: 0x25D4CB0 Slot: 444
	public void OnCheckWaveRoom(Game game, CheckWaveRoomResponse response) { }

	// RVA: 0x25D4DD0 Offset: 0x25D0DD0 VA: 0x25D4DD0 Slot: 749
	public void OnEventWaveTargetDamage(Game game, WaveTargetDamageEvent damageEvent) { }

	// RVA: 0x25D4E88 Offset: 0x25D0E88 VA: 0x25D4E88 Slot: 824
	public void OnEventWaveRaidGameStart(Game game, WaveRaidGameStartEvent startEvent) { }

	// RVA: 0x25D4F40 Offset: 0x25D0F40 VA: 0x25D4F40 Slot: 825
	public void OnEventWaveRaidNextWave(Game game, WaveRaidNextWaveEvent nextWave) { }

	// RVA: 0x25D4FEC Offset: 0x25D0FEC VA: 0x25D4FEC Slot: 826
	public void OnEventWaveRaidPopMob(Game game, WaveRaidPopMobEvent popEvent) { }

	// RVA: 0x25D50D0 Offset: 0x25D10D0 VA: 0x25D50D0 Slot: 827
	public void OnEventWaveRaidMoveMob(Game game, WaveRaidMoveMobEvent moveEvent) { }

	// RVA: 0x25D5144 Offset: 0x25D1144 VA: 0x25D5144 Slot: 828
	public void OnEventWaveRaidMoveDefenceObject(Game game, WaveRaidMoveDefenceObjectEvent moveEvent) { }

	// RVA: 0x25D5200 Offset: 0x25D1200 VA: 0x25D5200 Slot: 829
	public void OnEventWaveRaidTargetAttack(Game game, WaveRaidTargetAttackEvent attackEvent) { }

	// RVA: 0x25D52CC Offset: 0x25D12CC VA: 0x25D52CC Slot: 830
	public void OnEventWaveRaidMinusHate(Game game, WaveRaidMinusHateEvent hateEvent) { }

	// RVA: 0x25D52D0 Offset: 0x25D12D0 VA: 0x25D52D0 Slot: 831
	public void OnEventWaveRaidTargetDamage(Game game, WaveRaidTargetDamageEvent damageEvent) { }

	// RVA: 0x25D5388 Offset: 0x25D1388 VA: 0x25D5388 Slot: 832
	public void OnEventWaveRaidGameEnd(Game game, WaveRaidGameEndEvent endEvent) { }

	// RVA: 0x25D5444 Offset: 0x25D1444 VA: 0x25D5444 Slot: 833
	public void OnCheckWaveRaidRoom(Game game, CheckWaveRaidRoomResponse response) { }

	// RVA: 0x25D5568 Offset: 0x25D1568 VA: 0x25D5568 Slot: 823
	public void OnEventWaveRaidEnter(Game game, WaveRaidEnterEvent enterEvent) { }

	// RVA: 0x25D5658 Offset: 0x25D1658 VA: 0x25D5658 Slot: 631
	public void OnRhythmEnter(Game game) { }

	// RVA: 0x25D571C Offset: 0x25D171C VA: 0x25D571C Slot: 632
	public void OnRhythmJoin(Game game, RhythmJoinResponse response) { }

	// RVA: 0x25D57A4 Offset: 0x25D17A4 VA: 0x25D57A4 Slot: 633
	public void OnRhythmSetting(Game game) { }

	// RVA: 0x25D57A8 Offset: 0x25D17A8 VA: 0x25D57A8 Slot: 634
	public void OnRhythmReady(Game game) { }

	// RVA: 0x25D57AC Offset: 0x25D17AC VA: 0x25D57AC Slot: 635
	public void OnRhythmReadyCancel(Game game) { }

	// RVA: 0x25D57B0 Offset: 0x25D17B0 VA: 0x25D57B0 Slot: 636
	public void OnRhythmStart(Game game) { }

	// RVA: 0x25D57B4 Offset: 0x25D17B4 VA: 0x25D57B4 Slot: 638
	public void OnRhythmFinish(Game game) { }

	// RVA: 0x25D57B8 Offset: 0x25D17B8 VA: 0x25D57B8 Slot: 639
	public void OnRhythmResult(Game game) { }

	// RVA: 0x25D57BC Offset: 0x25D17BC VA: 0x25D57BC Slot: 640
	public void OnRhythmLeave(Game game) { }

	// RVA: 0x25D583C Offset: 0x25D183C VA: 0x25D583C Slot: 666
	public void OnEventRhythmGameState(Game game, RhythmGameStateEvent state) { }

	// RVA: 0x25D58E8 Offset: 0x25D18E8 VA: 0x25D58E8 Slot: 667
	public void OnEventRhythmGameStartPrepare(Game game, RhythmGameStartPrepareEvent prepare) { }

	// RVA: 0x25D5940 Offset: 0x25D1940 VA: 0x25D5940 Slot: 668
	public void OnEventRhythmGameStart(Game game, RhythmGameStartEvent start) { }

	// RVA: 0x25D59C8 Offset: 0x25D19C8 VA: 0x25D59C8 Slot: 670
	public void OnEventRhythmGameScoreState(Game game, RhythmGameScoreStateEvent state) { }

	// RVA: 0x25D5A20 Offset: 0x25D1A20 VA: 0x25D5A20 Slot: 671
	public void OnEventRhythmGameResult(Game game, RhythmGameResultEvent result) { }

	// RVA: 0x25D5ACC Offset: 0x25D1ACC VA: 0x25D5ACC Slot: 672
	public void OnEventRhythmGameEnd(Game game, RhythmGameEndEvent end) { }

	// RVA: 0x25D5B54 Offset: 0x25D1B54 VA: 0x25D5B54 Slot: 637
	public void OnRhythmGiveup(Game game) { }

	// RVA: 0x25D5BA4 Offset: 0x25D1BA4 VA: 0x25D5BA4 Slot: 669
	public void OnEventRhythmGameGiveup(Game game, RhythmGameGiveupEvent giveup) { }

	// RVA: 0x25D5BFC Offset: 0x25D1BFC VA: 0x25D5BFC Slot: 673
	public void OnEventRhythmGameKickout(Game game, RhythmGameKickoutEvent kickout) { }

	// RVA: 0x25D5C54 Offset: 0x25D1C54 VA: 0x25D5C54 Slot: 641
	public void OnBlackKnightEnter(Game game) { }

	// RVA: 0x25D5D18 Offset: 0x25D1D18 VA: 0x25D5D18 Slot: 642
	public void OnBlackKnightLeave(Game game) { }

	// RVA: 0x25D5D84 Offset: 0x25D1D84 VA: 0x25D5D84 Slot: 643
	public void OnBlackKnightJoin(Game game, BlackKnightJoinResponse response) { }

	// RVA: 0x25D5E88 Offset: 0x25D1E88 VA: 0x25D5E88 Slot: 644
	public void OnBlackKnightSelectSaveData(Game game) { }

	// RVA: 0x25D5EE0 Offset: 0x25D1EE0 VA: 0x25D5EE0 Slot: 648
	public void OnBlackKnightLootBox(Game game, BlackKnightLootBoxResponse response) { }

	// RVA: 0x25D5FE4 Offset: 0x25D1FE4 VA: 0x25D5FE4 Slot: 650
	public void OnBlackKnightStartGame(Game game) { }

	// RVA: 0x25D60F0 Offset: 0x25D20F0 VA: 0x25D60F0 Slot: 651
	public void OnBlackKnightNextStage(Game game) { }

	// RVA: 0x25D61FC Offset: 0x25D21FC VA: 0x25D61FC Slot: 652
	public void OnBlackKnightEndGame(Game game) { }

	// RVA: 0x25D6308 Offset: 0x25D2308 VA: 0x25D6308 Slot: 645
	public void OnBlackKnightDeleteSaveData(Game game) { }

	// RVA: 0x25D6400 Offset: 0x25D2400 VA: 0x25D6400 Slot: 646
	public void OnBlackKnightChangeEquip(Game game) { }

	// RVA: 0x25D64F8 Offset: 0x25D24F8 VA: 0x25D64F8 Slot: 647
	public void OnBlackKnightChangeAvatar(Game game) { }

	// RVA: 0x25D65F0 Offset: 0x25D25F0 VA: 0x25D65F0 Slot: 649
	public void OnBlackKnightUpdateRanking(Game game, BlackKnightUpdateRankingResponse response) { }

	// RVA: 0x25D66E8 Offset: 0x25D26E8 VA: 0x25D66E8 Slot: 653
	public void OnCardGameEnter(Game game) { }

	// RVA: 0x25D67AC Offset: 0x25D27AC VA: 0x25D67AC Slot: 654
	public void OnCardGameJoin(Game game, CardGameJoinResponse response) { }

	// RVA: 0x25D6804 Offset: 0x25D2804 VA: 0x25D6804 Slot: 655
	public void OnCardGameReady(Game game) { }

	// RVA: 0x25D6808 Offset: 0x25D2808 VA: 0x25D6808 Slot: 656
	public void OnCardGameReadyCancel(Game game) { }

	// RVA: 0x25D680C Offset: 0x25D280C VA: 0x25D680C Slot: 661
	public void OnCardGameReconnectPlay(Game game, CardGameReconnectPlayResponse response) { }

	// RVA: 0x25D6894 Offset: 0x25D2894 VA: 0x25D6894 Slot: 662
	public void OnCardGameReconnectResult(Game game, CardGameReconnectResultResponse response) { }

	// RVA: 0x25D6924 Offset: 0x25D2924 VA: 0x25D6924 Slot: 657
	public void OnCardGameGiveup(Game game) { }

	// RVA: 0x25D69A4 Offset: 0x25D29A4 VA: 0x25D69A4 Slot: 663
	public void OnCardGameTableCheck(Game game, CardGameTableCheckResponse response) { }

	// RVA: 0x25D69FC Offset: 0x25D29FC VA: 0x25D69FC Slot: 659
	public void OnCardGameLeave(Game game) { }

	// RVA: 0x25D6A7C Offset: 0x25D2A7C VA: 0x25D6A7C Slot: 664
	public void OnCardGameLastChanceEnd(Game game) { }

	// RVA: 0x25D6A80 Offset: 0x25D2A80 VA: 0x25D6A80 Slot: 665
	public void OnCardGameSettingUpdate(Game game) { }

	// RVA: 0x25D6A84 Offset: 0x25D2A84 VA: 0x25D6A84 Slot: 658
	public void OnCardGameResultEnd(Game game) { }

	// RVA: 0x25D6B04 Offset: 0x25D2B04 VA: 0x25D6B04 Slot: 660
	public void OnCardGameTurnEnd(Game game) { }

	// RVA: 0x25D6B84 Offset: 0x25D2B84 VA: 0x25D6B84 Slot: 677
	public void OnEventCardGameGiveup(Game game, CardGameGiveupEvent giveup) { }

	// RVA: 0x25D6BDC Offset: 0x25D2BDC VA: 0x25D6BDC Slot: 675
	public void OnEventCardGameState(Game game, CardGameStateEvent state) { }

	// RVA: 0x25D6C34 Offset: 0x25D2C34 VA: 0x25D6C34 Slot: 676
	public void OnEventCardGameStart(Game game, CardGameStartEvent start) { }

	// RVA: 0x25D6C8C Offset: 0x25D2C8C VA: 0x25D6C8C Slot: 680
	public void OnEventCardGameTurnEnd(Game game, CardGameTurnEndEvent turn) { }

	// RVA: 0x25D6CF0 Offset: 0x25D2CF0 VA: 0x25D6CF0 Slot: 681
	public void OnEventCardGameLastChance(Game game, CardGameTurnEndLastChanceEvent turn) { }

	// RVA: 0x25D6D58 Offset: 0x25D2D58 VA: 0x25D6D58 Slot: 682
	public void OnEventCardGameLastChanceEnd(Game game, CardGameLastChanceEndEvent turn) { }

	// RVA: 0x25D6DE0 Offset: 0x25D2DE0 VA: 0x25D6DE0 Slot: 678
	public void OnEventCardGameEnd(Game game, CardGameEndEvent end) { }

	// RVA: 0x25D6E38 Offset: 0x25D2E38 VA: 0x25D6E38 Slot: 679
	public void OnEventCardGameKickout(Game game, CardGameKickoutEvent kickout) { }

	// RVA: 0x25D6E90 Offset: 0x25D2E90 VA: 0x25D6E90 Slot: 685
	public void OnEventPetRaceState(Game game, PetRaceStateEvent state) { }

	// RVA: 0x25D6F64 Offset: 0x25D2F64 VA: 0x25D6F64 Slot: 686
	public void OnEventPetRaceStart(Game game, PetRaceStartEvent start) { }

	// RVA: 0x25D7034 Offset: 0x25D3034 VA: 0x25D7034 Slot: 687
	public void OnEventPetRaceKickout(Game game, PetRaceKickoutEvent giveup) { }

	// RVA: 0x25D7088 Offset: 0x25D3088 VA: 0x25D7088 Slot: 688
	public void OnEventPetRaceEnd(Game game, PetRaceEndEvent end) { }

	// RVA: 0x25D713C Offset: 0x25D313C VA: 0x25D713C Slot: 689
	public void OnEventPetRaceSettingPhaseEnd(Game game, PetRaceSettingPhaseEndEvent end) { }

	// RVA: 0x25D7208 Offset: 0x25D3208 VA: 0x25D7208 Slot: 690
	public void OnEventPetRaceReturnPreparation(Game game, PetRaceReturnPreparationEvent end) { }

	// RVA: 0x25D72D4 Offset: 0x25D32D4 VA: 0x25D72D4 Slot: 691
	public void OnEventPetRaceRanking(Game game, PetRaceRankingEvent rank) { }

	// RVA: 0x25D7380 Offset: 0x25D3380 VA: 0x25D7380 Slot: 751
	public void OnEventTreasureHuntEnterGame(Game game, TreasureHuntEnterGameEvent enterEvent) { }

	// RVA: 0x25D764C Offset: 0x25D364C VA: 0x25D764C Slot: 752
	public void OnEventTreasureHuntGameStart(Game game, TreasureHuntGameStartEvent startEvent) { }

	// RVA: 0x25D7700 Offset: 0x25D3700 VA: 0x25D7700 Slot: 753
	public void OnEventTreasureHuntPopMob(Game game, TreasureHuntPopMobEvent popEvent) { }

	// RVA: 0x25D77F4 Offset: 0x25D37F4 VA: 0x25D77F4 Slot: 755
	public void OnEventTreasureHuntMoveMob(Game game, TreasureHuntMoveMobEvent moveEvent) { }

	// RVA: 0x25D7868 Offset: 0x25D3868 VA: 0x25D7868 Slot: 756
	public void OnEventTreasureHuntChangeTimeLimit(Game game, TreasureHuntChangeTimeLimitEvent changeTimeLimitEvent) { }

	// RVA: 0x25D7948 Offset: 0x25D3948 VA: 0x25D7948 Slot: 758
	public void OnEventTreasureHuntGameEnd(Game game, TreasureHuntGameEndEvent endEvent) { }

	// RVA: 0x25D7AA0 Offset: 0x25D3AA0 VA: 0x25D7AA0 Slot: 760
	public void OnEventTreasureHuntTestGameEnd(Game game, TreasureHuntTestGameEndEvent endEvent) { }

	// RVA: 0x25D7B94 Offset: 0x25D3B94 VA: 0x25D7B94 Slot: 754
	public void OnEventTreasureHuntPopTreasure(Game game, TreasureHuntPopTreasureEvent popEvent) { }

	// RVA: 0x25D7C80 Offset: 0x25D3C80 VA: 0x25D7C80 Slot: 757
	public void OnEventTreasurehuntAcqiureTreasure(Game game, TreasureHuntAcquireTreasureEvent acqiureTreasureEvent) { }

	// RVA: 0x25D7D70 Offset: 0x25D3D70 VA: 0x25D7D70 Slot: 759
	public void OnEventTreasureHuntUpdateBonusEvent(Game game, TreasureHuntUpdateBonusEvent bonusEvent) { }

	// RVA: 0x25D7DA0 Offset: 0x25D3DA0 VA: 0x25D7DA0 Slot: 834
	public void OnEventNewWaveEnter(Game game, NewWaveEnterEvent enterEvent) { }

	// RVA: 0x25D7ED4 Offset: 0x25D3ED4 VA: 0x25D7ED4 Slot: 835
	public void OnEventNewWaveGameStart(Game game, NewWaveGameStartEvent startEvent) { }

	// RVA: 0x25D7F8C Offset: 0x25D3F8C VA: 0x25D7F8C Slot: 836
	public void OnEventNewWaveNextWave(Game game, NewWaveNextWaveEvent nextWave) { }

	// RVA: 0x25D8040 Offset: 0x25D4040 VA: 0x25D8040 Slot: 837
	public void OnEventNewWavePopMob(Game game, NewWavePopMobEvent popEvent) { }

	// RVA: 0x25D80EC Offset: 0x25D40EC VA: 0x25D80EC Slot: 838
	public void OnEventNewWaveMoveMob(Game game, NewWaveMoveMobEvent moveEvent) { }

	// RVA: 0x25D81A0 Offset: 0x25D41A0 VA: 0x25D81A0 Slot: 839
	public void OnEventNewWaveTargetAttack(Game game, NewWaveTargetAttackEvent attackEvent) { }

	// RVA: 0x25D824C Offset: 0x25D424C VA: 0x25D824C Slot: 840
	public void OnEventNewWaveMinusHate(Game game, NewWaveMinusHateEvent hateEvent) { }

	// RVA: 0x25D82F8 Offset: 0x25D42F8 VA: 0x25D82F8 Slot: 841
	public void OnEventNewWaveTargetDamage(Game game, NewWaveTargetDamageEvent damageEvent) { }

	// RVA: 0x25D83A4 Offset: 0x25D43A4 VA: 0x25D83A4 Slot: 842
	public void OnEventNewWaveGameEnd(Game game, NewWaveGameEndEvent endEvent) { }

	// RVA: 0x25D8450 Offset: 0x25D4450 VA: 0x25D8450 Slot: 843
	public void OnCheckNewWaveRoom(Game game, CheckNewWaveRoomResponse response) { }

	// RVA: 0x25D8574 Offset: 0x25D4574 VA: 0x25D8574 Slot: 849
	public void OnCheckHighRaidRoom(Game game, CheckHighRaidRoomResponse response) { }

	// RVA: 0x25D8698 Offset: 0x25D4698 VA: 0x25D8698 Slot: 850
	public void OnGetChallengePoint(Game game, GetChallengePointResponse response) { }

	// RVA: 0x25D870C Offset: 0x25D470C VA: 0x25D870C Slot: 851
	public void OnAddChallengePoint(Game game, AddChallengePointResponse response) { }

	// RVA: 0x25D8780 Offset: 0x25D4780 VA: 0x25D8780 Slot: 852
	public void OnGetHighRaidPoint(Game game, GetHighRaidPointResponse response) { }

	// RVA: 0x25D8784 Offset: 0x25D4784 VA: 0x25D8784 Slot: 853
	public void OnRunHighRaidExchange(Game game, RunHighRaidExchangeResponse response) { }

	// RVA: 0x25D8788 Offset: 0x25D4788 VA: 0x25D8788 Slot: 487
	public void OnEventEnterHighRaidField(Game game, EnterHighRaidField enterEvent) { }

	// RVA: 0x25D8A34 Offset: 0x25D4A34 VA: 0x25D8A34 Slot: 854
	public void OnGetHighRaidHeld(Game game, GetHighRaidListResponse response) { }

	// RVA: 0x25D8AB0 Offset: 0x25D4AB0 VA: 0x25D8AB0 Slot: 177
	public void OnViewPersonChange(Game game) { }

	// RVA: 0x25D8AE8 Offset: 0x25D4AE8 VA: 0x25D8AE8 Slot: 476
	public void OnEventRoomSynchronization(Game game, RoomSynchronizationEvent syncEvent) { }

	// RVA: 0x25D8B5C Offset: 0x25D4B5C VA: 0x25D8B5C Slot: 718
	public void OnMailCheckResponse(Game game, MailCheckResponse checkResponse) { }

	// RVA: 0x25D8BF8 Offset: 0x25D4BF8 VA: 0x25D8BF8 Slot: 719
	public void OnMailChangeState(Game game, MailChangeStateResponse changeResponse) { }

	// RVA: 0x25D8C94 Offset: 0x25D4C94 VA: 0x25D8C94 Slot: 720
	public void OnMailReceiveDeliveryResponse(Game game, MailReceiveDeliveryResponse response) { }

	// RVA: 0x25D8D48 Offset: 0x25D4D48 VA: 0x25D8D48 Slot: 721
	public void OnMailSendResponse(Game game, MailSendResponse response) { }

	// RVA: 0x25D8DE4 Offset: 0x25D4DE4 VA: 0x25D8DE4
	public void OnGmChangeMailState(Game game) { }

	// RVA: 0x25D8E1C Offset: 0x25D4E1C VA: 0x25D8E1C Slot: 723
	public void OnMailHistoryCheckResponse(Game game, MailHistoryCheckResponse response) { }

	// RVA: 0x25D8EB8 Offset: 0x25D4EB8 VA: 0x25D8EB8 Slot: 724
	public void OnMailGetMessage(Game game, MailGetMessageResponse response) { }

	// RVA: 0x25D8F54 Offset: 0x25D4F54 VA: 0x25D8F54 Slot: 725
	public void OnMailGetBox(Game game, MailGetBoxResponse response) { }

	// RVA: 0x25D8FF0 Offset: 0x25D4FF0 VA: 0x25D8FF0 Slot: 726
	public void OnMailGetBody(Game game, MailGetBodyResponse response) { }

	// RVA: 0x25D908C Offset: 0x25D508C VA: 0x25D908C Slot: 722
	public void OnMailReplyResponse(Game game) { }

	// RVA: 0x25D910C Offset: 0x25D510C VA: 0x25D910C Slot: 727
	public void OnMailDeleteExpired(Game game, MailDeleteExpiredResponse response) { }

	// RVA: 0x25D91A8 Offset: 0x25D51A8 VA: 0x25D91A8 Slot: 732
	public void OnBanWordUpdate(Game game, BanWordUpdateResponse response) { }

	// RVA: 0x25D9214 Offset: 0x25D5214 VA: 0x25D9214 Slot: 738
	public void OnEventBanWordUpdate(Game game, BanWordUpdateEvent updateEvent) { }

	// RVA: 0x25D9280 Offset: 0x25D5280 VA: 0x25D9280 Slot: 737
	public void OnEventXSignature(Game game, XSignatureEvent signature) { }

	// RVA: 0x25D9314 Offset: 0x25D5314 VA: 0x25D9314 Slot: 78
	public void OnMoveResponse(Game game, OperationResponse response) { }

	// RVA: 0x25D949C Offset: 0x25D549C VA: 0x25D949C Slot: 739
	public void OnEventUserWatch(Game game, UserWatchEvent watch) { }

	// RVA: 0x25D94A0 Offset: 0x25D54A0 VA: 0x25D94A0 Slot: 733
	public void OnWatchEnd(Game game) { }

	// RVA: 0x25D9524 Offset: 0x25D5524 VA: 0x25D9524 Slot: 740
	public void OnEventWatchState(Game game, WatchStateEvent state) { }

	// RVA: 0x25D95B0 Offset: 0x25D55B0 VA: 0x25D95B0 Slot: 252
	public void OnEventSignboard(Game game, SignboardEvent events) { }

	// RVA: 0x25D95D0 Offset: 0x25D55D0 VA: 0x25D95D0 Slot: 253
	public void OnSignboardPutup(Game game, PutUpSignboardResponse response) { }

	// RVA: 0x25D9694 Offset: 0x25D5694 VA: 0x25D9694 Slot: 254
	public void OnSignboardPutAway(Game game, PutAwaySignboardResponse response) { }

	// RVA: 0x25D9758 Offset: 0x25D5758 VA: 0x25D9758 Slot: 255
	public void OnSignboardCheck(Game game, CheckSignboardResponse response) { }

	// RVA: 0x25D981C Offset: 0x25D581C VA: 0x25D981C Slot: 256
	public void OnSignboardContentExecute(Game game, ContentExecuteSignboardResponse response) { }

	// RVA: 0x25D98E0 Offset: 0x25D58E0 VA: 0x25D98E0 Slot: 569
	public void OnMiniGameJoin(Game game, MiniGameJoinResponse response) { }

	// RVA: 0x25D99BC Offset: 0x25D59BC VA: 0x25D99BC Slot: 579
	public void OnEventMiniGameMemberState(Game game, MiniGameMemberStateEvent eventData) { }

	// RVA: 0x25D9AAC Offset: 0x25D5AAC VA: 0x25D9AAC Slot: 580
	public void OnEventMiniGameStart(Game game, MiniGameStartEvent eventData) { }

	// RVA: 0x25D9B58 Offset: 0x25D5B58 VA: 0x25D9B58 Slot: 581
	public void OnEventMiniGameEnd(Game game, MiniGameEndEvent eventData) { }

	// RVA: 0x25D9C04 Offset: 0x25D5C04 VA: 0x25D9C04 Slot: 764
	public void OnActionEventSnowballFightThrow(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25D9C5C Offset: 0x25D5C5C VA: 0x25D9C5C Slot: 765
	public void OnActionEventSnowballFightReload(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25D9CB4 Offset: 0x25D5CB4 VA: 0x25D9CB4 Slot: 766
	public void OnActionEventSnowballFightDodge(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25D9D0C Offset: 0x25D5D0C VA: 0x25D9D0C Slot: 767
	public void OnActionEventSnowballFightAttack(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25D9D64 Offset: 0x25D5D64 VA: 0x25D9D64 Slot: 769
	public void OnActionEventSnowballFightDamage(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25D9DBC Offset: 0x25D5DBC VA: 0x25D9DBC Slot: 761
	public void OnActionSnowballFightThrow(Game game, GameReturnCode returnCode, SnowballFightThrowData response) { }

	// RVA: 0x25D9F94 Offset: 0x25D5F94 VA: 0x25D9F94 Slot: 768
	public void OnActionSnowballFightDamage(Game game, GameReturnCode returnCode, SnowballFightDamageData response) { }

	// RVA: 0x25D9FFC Offset: 0x25D5FFC VA: 0x25D9FFC Slot: 770
	public void OnActionSnowballFightDead(Game game, GameReturnCode returnCode, SnowballFightDeadData response) { }

	// RVA: 0x25DA064 Offset: 0x25D6064 VA: 0x25DA064 Slot: 771
	public void OnActionEventSnowballFightDead(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25DA0BC Offset: 0x25D60BC VA: 0x25DA0BC Slot: 772
	public void OnActionSnowballFightResurrection(Game game, GameReturnCode returnCode, SnowballFightResurrectionData response) { }

	// RVA: 0x25DA124 Offset: 0x25D6124 VA: 0x25DA124 Slot: 773
	public void OnActionEventSnowballFightResurrection(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25DA17C Offset: 0x25D617C VA: 0x25DA17C Slot: 582
	public void OnEventSnowballFightItemPop(Game game, SnowballFightItemPopEvent envetData) { }

	// RVA: 0x25DA244 Offset: 0x25D6244 VA: 0x25DA244 Slot: 774
	public void OnActionSnowballFightGetItem(Game game, GameReturnCode returnCode, SnowballFightGetItemData response) { }

	// RVA: 0x25DA2BC Offset: 0x25D62BC VA: 0x25DA2BC Slot: 775
	public void OnActionEventSnowballFightGetItem(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25DA314 Offset: 0x25D6314 VA: 0x25DA314 Slot: 776
	public void OnActionSnowballFightUseItem(Game game, GameReturnCode returnCode, SnowballFightUseItemData response) { }

	// RVA: 0x25DA3B0 Offset: 0x25D63B0 VA: 0x25DA3B0 Slot: 762
	public void OnActionSnowballFightCreate(Game game, GameReturnCode returnCode, SnowballFightCreateData response) { }

	// RVA: 0x25DA4FC Offset: 0x25D64FC VA: 0x25DA4FC Slot: 763
	public void OnActionSnowballFightDodge(Game game, GameReturnCode returnCode, SnowballFightDodgeData response) { }

	// RVA: 0x25DA648 Offset: 0x25D6648 VA: 0x25DA648 Slot: 777
	public void OnActionEventSnowballFightUseItem(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25DA6A0 Offset: 0x25D66A0 VA: 0x25DA6A0 Slot: 570
	public void OnMiniGameLobbyJoin(Game game, MiniGameLobbyJoinResponse response) { }

	// RVA: 0x25DA77C Offset: 0x25D677C VA: 0x25DA77C Slot: 571
	public void OnMiniGameLobbyReady(Game game, MiniGameLobbyReadyResponse response) { }

	// RVA: 0x25DA858 Offset: 0x25D6858 VA: 0x25DA858 Slot: 572
	public void OnMiniGameLobbyReadyCancel(Game game, MiniGameLobbyReadyCancelResponse response) { }

	// RVA: 0x25DA934 Offset: 0x25D6934 VA: 0x25DA934 Slot: 574
	public void OnEventMiniGameLobbyMemberState(Game game, MiniGameLobbyMemberStateEvent eventData) { }

	// RVA: 0x25DA9E0 Offset: 0x25D69E0 VA: 0x25DA9E0 Slot: 576
	public void OnEventMiniGameLobbyMatched(Game game, MiniGameLobbyMatchedEvent eventData) { }

	// RVA: 0x25DAA8C Offset: 0x25D6A8C VA: 0x25DAA8C Slot: 577
	public void OnEventMiniGameLobbyMatchingTimeout(Game game, MiniGameMatchingTimeoutEvent eventData) { }

	// RVA: 0x25DAB38 Offset: 0x25D6B38 VA: 0x25DAB38 Slot: 575
	public void OnEventMiniGameLobbyMatching(Game game, MiniGameLobbyMatchingEvent eventData) { }

	// RVA: 0x25DABE4 Offset: 0x25D6BE4 VA: 0x25DABE4 Slot: 578
	public void OnEventMiniGameMatchingState(Game game, MiniGameMatchingStateEvent eventData) { }

	// RVA: 0x25DAC90 Offset: 0x25D6C90 VA: 0x25DAC90 Slot: 778
	public void OnActionSummerThrow(Game game, GameReturnCode returnCode, SummerThrowData response) { }

	// RVA: 0x25DAD48 Offset: 0x25D6D48 VA: 0x25DAD48 Slot: 779
	public void OnActionSummerAttack(Game game, GameReturnCode returnCode, SummerAttackData response) { }

	// RVA: 0x25DADFC Offset: 0x25D6DFC VA: 0x25DADFC Slot: 780
	public void OnActionSummerFishCreate(Game game, GameReturnCode returnCode, MobResponseData response) { }

	// RVA: 0x25DAEB0 Offset: 0x25D6EB0 VA: 0x25DAEB0 Slot: 781
	public void OnActionSummerFishMove(Game game, GameReturnCode returnCode, MobMoveEventData response) { }

	// RVA: 0x25DAF68 Offset: 0x25D6F68 VA: 0x25DAF68 Slot: 782
	public void OnActionEventSummerFishResult(Game game, MobData[] mobs) { }

	// RVA: 0x25DB00C Offset: 0x25D700C VA: 0x25DB00C Slot: 583
	public void OnEventSummerFishCreate(Game game, SummerFishCreateEvent createEvent) { }

	// RVA: 0x25DB0B0 Offset: 0x25D70B0 VA: 0x25DB0B0 Slot: 584
	public void OnEventSummerFishAction(Game game, SummerFishActionEvent actionEvent) { }

	// RVA: 0x25DB154 Offset: 0x25D7154 VA: 0x25DB154 Slot: 913
	public void OnActionSummerFishAttack(Game game, GameReturnCode returnCode, MobAttackResponseData response) { }

	// RVA: 0x25DB158 Offset: 0x25D7158 VA: 0x25DB158 Slot: 783
	public void OnActionEventSummerThrow(Game game, ArchetypeActionEvent events) { }

	// RVA: 0x25DB1B0 Offset: 0x25D71B0 VA: 0x25DB1B0 Slot: 585
	public void OnEventSummerBossPop(Game game, SummerBossPopEvent popEvent) { }

	// RVA: 0x25DB1B4 Offset: 0x25D71B4 VA: 0x25DB1B4 Slot: 587
	public void OnEventSummerMember(Game game, SummerMemberEvent memberEvent) { }

	// RVA: 0x25DB260 Offset: 0x25D7260 VA: 0x25DB260 Slot: 588
	public void OnEventSummerRuleChange(Game game, SummerRuleChangeEvent ruleEvent) { }

	// RVA: 0x25DB330 Offset: 0x25D7330 VA: 0x25DB330 Slot: 589
	public void OnEventSummerGameStart(Game game, SummerGameStartEvent startEvent) { }

	// RVA: 0x25DB3D0 Offset: 0x25D73D0 VA: 0x25DB3D0 Slot: 590
	public void OnEventSummerGameEnd(Game game, SummerGameEndEvent endEvent) { }

	// RVA: 0x25DB4A0 Offset: 0x25D74A0 VA: 0x25DB4A0 Slot: 591
	public void OnEventSummerGameState(Game game, SummerGameStateEvent stateEvent) { }

	// RVA: 0x25DB570 Offset: 0x25D7570 VA: 0x25DB570 Slot: 586
	public void OnEventSummerOwnerLeave(Game game, SummerOwnerLeaveEvent leaveEvent) { }

	// RVA: 0x25DB610 Offset: 0x25D7610 VA: 0x25DB610 Slot: 592
	public void OnEventSummerPlayerRespawn(Game game, SummerPlayerRespawnEvent respawnEvent) { }

	// RVA: 0x25DB6BC Offset: 0x25D76BC VA: 0x25DB6BC Slot: 593
	public void OnEventSummerMemberDead(Game game, SummerMemberDeadEvent deadEvent) { }

	// RVA: 0x25DB764 Offset: 0x25D7764 VA: 0x25DB764 Slot: 787
	public void OnTreasureOpen(Game game, TreasureOpenResponse response) { }

	// RVA: 0x25DB784 Offset: 0x25D7784 VA: 0x25DB784 Slot: 788
	public void OnTreasureKeyInfo(Game game, TreasureKeyInfoResponse response) { }

	// RVA: 0x25DB7A4 Offset: 0x25D77A4 VA: 0x25DB7A4 Slot: 789
	public void OnEventTreasureSetting(Game game, TreasureSettingEvent endEvent) { }

	// RVA: 0x25DB87C Offset: 0x25D787C VA: 0x25DB87C Slot: 573
	public void OnHideSeekCheck(Game game, HideSeekCheckResponse response) { }

	// RVA: 0x25DB89C Offset: 0x25D789C VA: 0x25DB89C Slot: 715
	public void OnDefenceWorldRankingTop100Response(Game game, DefenceScoreWorldRankingResponse response) { }

	// RVA: 0x25DB8D4 Offset: 0x25D78D4 VA: 0x25DB8D4 Slot: 92
	public void OnActionSkillSummons(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SkillSummonsResponseData response) { }

	// RVA: 0x25DB9C8 Offset: 0x25D79C8 VA: 0x25DB9C8 Slot: 93
	public void OnActionSkillSummonsRemove(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, SkillSummonsRemoveResponseData response) { }

	// RVA: 0x25DB9FC Offset: 0x25D79FC VA: 0x25DB9FC Slot: 124
	public void OnActionEventSkillSummons(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25DBA54 Offset: 0x25D7A54 VA: 0x25DBA54 Slot: 125
	public void OnActionEventSkillSummonsRemove(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25DBAAC Offset: 0x25D7AAC VA: 0x25DBAAC Slot: 233
	public void OnSkillGetFamilia(Game game, GetFamiliaResponse response) { }

	// RVA: 0x25DBB68 Offset: 0x25D7B68 VA: 0x25DBB68 Slot: 234
	public void OnSkillChangeFamilia(Game game, ChangeFamiliaResponse response) { }

	// RVA: 0x25DBCB8 Offset: 0x25D7CB8 VA: 0x25DBCB8 Slot: 235
	public void OnSkillUnlockFamilia(Game game, UnlockFamiliaResponse response) { }

	// RVA: 0x25DBDDC Offset: 0x25D7DDC VA: 0x25DBDDC Slot: 236
	public void OnSkillCreateNinjutsuBook(Game game, CreateNinjutsuScrollResponse response) { }

	// RVA: 0x25DBE08 Offset: 0x25D7E08 VA: 0x25DBE08 Slot: 103
	public void OnActionMobEmergencyMove(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobEmergencyMoveResponseData response) { }

	// RVA: 0x25DBE0C Offset: 0x25D7E0C VA: 0x25DBE0C Slot: 104
	public void OnActionMobEventAttack(Game game, GameReturnCode returnCode, byte archetypeType, int archetypeId, MobEventAttackResponseData response) { }

	// RVA: 0x25DBE90 Offset: 0x25D7E90 VA: 0x25DBE90 Slot: 135
	public void OnActionEventMobEventAttack(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25DBEF8 Offset: 0x25D7EF8 VA: 0x25DBEF8 Slot: 111
	public void OnActionGuardAndAvoid(Game game, GameReturnCode returnCode, GuardAndAvoidResponseData response) { }

	// RVA: 0x25DBF1C Offset: 0x25D7F1C VA: 0x25DBF1C
	public void OnGmHouseInitializeLand(Game game) { }

	// RVA: 0x25DBF38 Offset: 0x25D7F38 VA: 0x25DBF38
	public void OnGmHouseInitializeObject(Game game) { }

	// RVA: 0x25DBF54 Offset: 0x25D7F54 VA: 0x25DBF54
	public void OnGmHouseInitializeAll(Game game) { }

	// RVA: 0x25DBFC0 Offset: 0x25D7FC0 VA: 0x25DBFC0
	public void OnGmHouseGetObject(Game game, int objId, byte num) { }

	// RVA: 0x25DC060 Offset: 0x25D8060 VA: 0x25DC060 Slot: 134
	public void OnActionEventMobEmergencyMove(Game game, ArchetypeActionEvent data) { }

	// RVA: 0x25DC064 Offset: 0x25D8064 VA: 0x25DC064 Slot: 193
	public void OnParameterGetActionSetting(Game game, ParameterGetActionSettingResponse response) { }

	// RVA: 0x25DC0D8 Offset: 0x25D80D8 VA: 0x25DC0D8 Slot: 194
	public void OnParameterSaveActionSetting(Game game) { }

	// RVA: 0x25DC174 Offset: 0x25D8174 VA: 0x25DC174 Slot: 195
	public void OnParameterChangeActionSetting(Game game, ParameterChangeActionSettingResponse response) { }

	// RVA: 0x25DC1E8 Offset: 0x25D81E8 VA: 0x25DC1E8 Slot: 168
	public void OnEventUpdateBossScore(Game game, UpdateBossScoreEvent updateEvent) { }

	// RVA: 0x25DC1EC Offset: 0x25D81EC VA: 0x25DC1EC Slot: 564
	public void OnEventServerSetting(Game game, ServerSettingEvent settingEvent) { }

	// RVA: 0x25DC1F0 Offset: 0x25D81F0 VA: 0x25DC1F0 Slot: 862
	public void OnEventMobaStartMatching(Game game, MobaStartMatchingEvent start) { }

	// RVA: 0x25DC2E4 Offset: 0x25D82E4 VA: 0x25DC2E4 Slot: 863
	public void OnEventMobaCancelMatching(Game game, MobaCancelMatchingEvent start) { }

	// RVA: 0x25DC3D0 Offset: 0x25D83D0 VA: 0x25DC3D0 Slot: 864
	public void OnEventMobaSuccessMatching(Game game, MobaSuccessMatchingEvent start) { }

	// RVA: 0x25DC400 Offset: 0x25D8400 VA: 0x25DC400 Slot: 869
	public void OnEventMobaLogin(Game game, MyArchetype avatar, MobaLoginEvent login) { }

	// RVA: 0x25DC55C Offset: 0x25D855C VA: 0x25DC55C Slot: 870
	public void OnEventMobaRelogin(Game game, MyArchetype avatar, MobaReloginEvent relogin) { }

	// RVA: 0x25DC6B8 Offset: 0x25D86B8 VA: 0x25DC6B8 Slot: 871
	public void OnEventMobaPhase(Game game, MobaPhaseEvent phase) { }

	// RVA: 0x25DC764 Offset: 0x25D8764 VA: 0x25DC764 Slot: 872
	public void OnEventMobaLevelup(Game game, MobaLevelupEvent levelup) { }

	// RVA: 0x25DC804 Offset: 0x25D8804 VA: 0x25DC804
	public void OnGmMobaGetGold(Game game, int gold) { }

	// RVA: 0x25DC8B4 Offset: 0x25D88B4 VA: 0x25DC8B4 Slot: 873
	public void OnEventMobaUpdateEquip(Game game, MobaUpdateEquipEvent equip) { }

	// RVA: 0x25DC98C Offset: 0x25D898C VA: 0x25DC98C Slot: 886
	public void OnActionEventMobaAreaDamage(Game game, ArchetypeActionEvent actionEvent) { }

	// RVA: 0x25DCA50 Offset: 0x25D8A50 VA: 0x25DCA50 Slot: 868
	public void OnMobaArchetypeAdded(Game game, Archetype item, Dictionary<byte, object> properties, int propertiesRevision) { }

	// RVA: 0x25DCB18 Offset: 0x25D8B18 VA: 0x25DCB18 Slot: 885
	public void OnActionEventMobaMobMove(Game game, byte archetypeType, int archetypeId, MoveDataLight moveEvent) { }

	// RVA: 0x25DCC68 Offset: 0x25D8C68 VA: 0x25DCC68 Slot: 874
	public void OnEventMobaKill(Game game, MobaKillEvent kill) { }

	// RVA: 0x25DCCFC Offset: 0x25D8CFC VA: 0x25DCCFC Slot: 875
	public void OnEventMobaMember(Game game, MobaMemberEvent member) { }

	// RVA: 0x25DCDE0 Offset: 0x25D8DE0 VA: 0x25DCDE0 Slot: 887
	public void OnActionEventMobaMonsterResult(Game game, MobData[] mobs, MobaMonsterResultData resultData, bool isResend) { }

	// RVA: 0x25DCE0C Offset: 0x25D8E0C VA: 0x25DCE0C Slot: 888
	public void OnActionEventMobaChangeHate(Game game, MobData[] mobs) { }

	// RVA: 0x25DCE64 Offset: 0x25D8E64 VA: 0x25DCE64 Slot: 876
	public void OnEventMobaChest(Game game, MobaChestEvent chest) { }

	// RVA: 0x25DCF90 Offset: 0x25D8F90 VA: 0x25DCF90
	public void OnGmMobaGameChange(Game game) { }

	// RVA: 0x25DCFC0 Offset: 0x25D8FC0 VA: 0x25DCFC0 Slot: 865
	public void OnEventMobaPartyState(Game game, MobaPartyStateEvent state) { }

	// RVA: 0x25DD014 Offset: 0x25D9014 VA: 0x25DD014 Slot: 866
	public void OnEventMobaHeldState(Game game, MobaHeldStateEvent state) { }

	// RVA: 0x25DD078 Offset: 0x25D9078 VA: 0x25DD078 Slot: 867
	public void OnEventMobaGameEnd(Game game, MobaGameEndEvent end) { }

	// RVA: 0x25DD13C Offset: 0x25D913C VA: 0x25DD13C Slot: 877
	public void OnEventMobaMemberState(Game game, MobaMemberStateEvent state) { }

	// RVA: 0x25DD1E8 Offset: 0x25D91E8 VA: 0x25DD1E8 Slot: 878
	public void OnEventMobaMemberStatus(Game game, MobaMemberStatusEvent status) { }

	// RVA: 0x25DD294 Offset: 0x25D9294 VA: 0x25DD294 Slot: 879
	public void OnEventMobaDeadDrop(Game game, MobaDeadDropEvent drop) { }

	// RVA: 0x25DD344 Offset: 0x25D9344 VA: 0x25DD344 Slot: 880
	public void OnEventMobaSupplyEquip(Game game, MobaSupplyEquipEvent equip) { }

	// RVA: 0x25DD3F8 Offset: 0x25D93F8 VA: 0x25DD3F8 Slot: 881
	public void OnEventMobaHeal(Game game, MobaHealEvent heal) { }

	// RVA: 0x25DD4A4 Offset: 0x25D94A4 VA: 0x25DD4A4 Slot: 882
	public void OnEventMobaRoundResult(Game game, MobaRoundResultEvent result) { }

	// RVA: 0x25DD550 Offset: 0x25D9550 VA: 0x25DD550 Slot: 883
	public void OnEventMobaUnsuccessful(Game game, MobaUnsuccessfulEvent unsuccessful) { }

	// RVA: 0x25DD5F4 Offset: 0x25D95F4 VA: 0x25DD5F4 Slot: 884
	public void OnEventMobaMobaDuelAbilityTrampleRemoveSkill(Game game, MobaDuelAbilityTrampleRemoveSupportEvent remove) { }

	// RVA: 0x25DD6A0 Offset: 0x25D96A0 VA: 0x25DD6A0 Slot: 69
	public void OnNeedLoaderAgain(Game game) { }

	// RVA: 0x25DD6D8 Offset: 0x25D96D8 VA: 0x25DD6D8 Slot: 172
	public void OnActionEventFunnelAttackStartEvent(Game game, FunnelAttackStartEvent funnelEvent) { }

	// RVA: 0x25DD6DC Offset: 0x25D96DC VA: 0x25DD6DC Slot: 889
	public void OnEventGuildBBSJoin(Game game, GuildBBSJoinEvent guildEvent) { }

	// RVA: 0x25DD6FC Offset: 0x25D96FC VA: 0x25DD6FC Slot: 890
	public void OnEventGuildBBSAllowRequest(Game game, GuildBBSAllowRequestEvent guildEvent) { }

	// RVA: 0x25DD71C Offset: 0x25D971C VA: 0x25DD71C Slot: 891
	public void OnEventGuildBBSJoinRequest(Game game, GuildBBSJoinRequestEvent guildEvent) { }

	// RVA: 0x25DD73C Offset: 0x25D973C VA: 0x25DD73C Slot: 683
	public void OnEventCraneGameGetItem(Game game, CraneGameGetItemEvent getItem) { }

	// RVA: 0x25DD98C Offset: 0x25D998C VA: 0x25DD98C Slot: 895
	public void OnEventFishingHit(Game game, FishingHitEvent hit) { }

	// RVA: 0x25DD9E4 Offset: 0x25D99E4 VA: 0x25DD9E4 Slot: 896
	public void OnEventFishingEndHit(Game game) { }

	// RVA: 0x25DDA34 Offset: 0x25D9A34 VA: 0x25DDA34 Slot: 897
	public void OnEventFishingTimeOutMiniGame(Game game) { }

	// RVA: 0x25DDA84 Offset: 0x25D9A84 VA: 0x25DDA84 Slot: 900
	public void OnEventComebackCp(Game game) { }

	// RVA: 0x25DDAD8 Offset: 0x25D9AD8 VA: 0x25DDAD8
	public void OnGmInitializePaletteStorage(Game game) { }

	// RVA: 0x25DDADC Offset: 0x25D9ADC VA: 0x25DDADC
	public void OnGmMaxPaletteStorage(Game game, PaletteData[] paletteList) { }

	// RVA: 0x25DDAE0 Offset: 0x25D9AE0 VA: 0x25DDAE0
	public void OnGmFishingGetFish(Game game, FishingFishData fish) { }

	// RVA: 0x25DDBFC Offset: 0x25D9BFC VA: 0x25DDBFC
	public void OnGmFishingSetFishBagCapacity(Game game, short capacity) { }

	// RVA: 0x25DDC54 Offset: 0x25D9C54 VA: 0x25DDC54
	public void OnGmFishingInitializeFieldTarget(Game game) { }

	// RVA: 0x25DDC98 Offset: 0x25D9C98 VA: 0x25DDC98
	public void OnGmFishingGetRod(Game game, FishingRodData rod) { }

	// RVA: 0x25DDDB4 Offset: 0x25D9DB4 VA: 0x25DDDB4
	public void OnGmFishingChangeRandomTargetCondition(Game game, FishingRandomTargetData[] list) { }

	// RVA: 0x25DDDB8 Offset: 0x25D9DB8 VA: 0x25DDDB8
	public void OnGmFishingVerigicationRandomTarget(Game game, FishingRandomTargetData[] target) { }

	// RVA: 0x25DDDBC Offset: 0x25D9DBC VA: 0x25DDDBC
	public void OnGmFishingInitializeRandomTarget(Game game, FishingRandomTargetData[] target) { }

	// RVA: 0x25DDDC0 Offset: 0x25D9DC0 VA: 0x25DDDC0
	public void OnGmFishingFixTarget(Game game, int targetId) { }

	// RVA: 0x25DDE28 Offset: 0x25D9E28 VA: 0x25DDE28
	public void OnGmFishingGetFieldTargetList(Game game, int worldId, int fieldId, int[] targetIdList) { }

	// RVA: 0x25DDFC8 Offset: 0x25D9FC8 VA: 0x25DDFC8 Slot: 898
	public void OnEventFishingNoticeHitRateEvnet(Game game, NoticeHitRateEvent notice) { }

	// RVA: 0x25DE2C0 Offset: 0x25DA2C0 VA: 0x25DE2C0 Slot: 899
	public void OnEventFishingSuccessEvent(Game game, FishingSuccessEvent successEvent) { }

	// RVA: 0x25DE34C Offset: 0x25DA34C VA: 0x25DE34C Slot: 417
	public void OnEventPartyRecruitmentAdd(Game game, PartyRecruitmentAddEvent addEvent) { }

	// RVA: 0x25DE41C Offset: 0x25DA41C VA: 0x25DE41C Slot: 418
	public void OnEventPartyRecruitmentUpdate(Game game, PartyRecruitmentUpdateEvent updateEvent) { }

	// RVA: 0x25DE594 Offset: 0x25DA594 VA: 0x25DE594 Slot: 419
	public void OnEventPartyRecruitmentRemove(Game game, PartyRecruitmentRemoveEvent removeEvent) { }

	// RVA: 0x25DE714 Offset: 0x25DA714 VA: 0x25DE714 Slot: 420
	public void OnEventPartyRecruitmentApply(Game game, PartyRecruitmentApplyEvent applyEvent) { }

	// RVA: 0x25DE798 Offset: 0x25DA798 VA: 0x25DE798 Slot: 421
	public void OnEventPartyRecruitmentCandidateCancel(Game game, PartyRecruitmentCandidateCancelEvent cancelEvent) { }

	// RVA: 0x25DE9B4 Offset: 0x25DA9B4 VA: 0x25DE9B4 Slot: 422
	public void OnEventPartyRecruitmentApplyCancel(Game game, PartyRecruitmentApplyCancelEvent cancelEvent) { }

	// RVA: 0x25DEA64 Offset: 0x25DAA64 VA: 0x25DEA64 Slot: 423
	public void OnEventRecruitmentApprove(Game game, PartyRecruitmentApproveEvent approveEvent) { }

	// RVA: 0x25DEAEC Offset: 0x25DAAEC VA: 0x25DEAEC Slot: 424
	public void OnEventRecruitmentJoin(Game game, PartyRecruitmentJoinEvent joinEvent) { }

	// RVA: 0x25DEE4C Offset: 0x25DAE4C VA: 0x25DEE4C Slot: 425
	public void OnEventRecruitmentQuit(Game game, PartyRecruitmentQuitEvent quitEvent) { }

	// RVA: 0x25DEF08 Offset: 0x25DAF08 VA: 0x25DEF08 Slot: 489
	public void OnEventMonsterManageHateState(Game game, RoomMonsterManageHateStateEvent stateEvent) { }

	// RVA: 0x25DEFA8 Offset: 0x25DAFA8 VA: 0x25DEFA8 Slot: 694
	public void OnEventMahjongUpdateRoomState(Game game, MahjongUpdateRoomStateEvent update) { }

	// RVA: 0x25DF0A4 Offset: 0x25DB0A4 VA: 0x25DF0A4 Slot: 695
	public void OnEventMahjongKickoutMember(Game game, MahjongKickoutMemberEvent kickout) { }

	// RVA: 0x25DF198 Offset: 0x25DB198 VA: 0x25DF198 Slot: 696
	public void OnEventMahjongRoomDissolution(Game game) { }

	// RVA: 0x25DF280 Offset: 0x25DB280 VA: 0x25DF280 Slot: 697
	public void OnEventMahjongGameStart(Game game) { }

	// RVA: 0x25DF35C Offset: 0x25DB35C VA: 0x25DF35C Slot: 692
	public void OnEventMahjongJoinRoom(Game game, MahjongJoinRoomEvent join) { }

	// RVA: 0x25DF450 Offset: 0x25DB450 VA: 0x25DF450 Slot: 693
	public void OnEventMahjongLeaveRoom(Game game, MahjongLeaveRoomEvent leave) { }

	// RVA: 0x25DF544 Offset: 0x25DB544 VA: 0x25DF544 Slot: 699
	public void OnEventMahjongStartRound(Game game, MahjongStartRoundEvent startEvent) { }

	// RVA: 0x25DF77C Offset: 0x25DB77C VA: 0x25DF77C Slot: 700
	public void OnEventMahjongDraw(Game game, MahjongDrawEvent drawEvent) { }

	// RVA: 0x25DF874 Offset: 0x25DB874 VA: 0x25DF874 Slot: 701
	public void OnEventMahjongDiscard(Game game, MahjongDiscardEvent discardEvent) { }

	// RVA: 0x25DF96C Offset: 0x25DB96C VA: 0x25DF96C Slot: 702
	public void OnEventMahjongWaitCall(Game game, MahjongWaitCallEvent waitEvent) { }

	// RVA: 0x25DFA74 Offset: 0x25DBA74 VA: 0x25DFA74 Slot: 703
	public void OnEventMahjongCall(Game game, MahjongCallEvent callEvent) { }

	// RVA: 0x25DFB6C Offset: 0x25DBB6C VA: 0x25DFB6C Slot: 704
	public void OnEventMahjongEndRound(Game game, MahjongEndRoundEvent endEvent) { }

	// RVA: 0x25DFC70 Offset: 0x25DBC70 VA: 0x25DFC70 Slot: 705
	public void OnEventMahjongSynchronization(Game game, MahjongSynchronizationEvent syncEvent) { }

	// RVA: 0x25DFD60 Offset: 0x25DBD60 VA: 0x25DFD60 Slot: 698
	public void OnEventMahjongChangeSetting(Game game, MahjongChangeSettingEvent change) { }

	// RVA: 0x25DFE50 Offset: 0x25DBE50 VA: 0x25DFE50
	public void OnGmMahjongFixParent(Game game, int parentArchetypId) { }

	// RVA: 0x25DFF30 Offset: 0x25DBF30 VA: 0x25DFF30
	public void OnGmMahjongFixDrawTile(Game game, int tileId) { }

	// RVA: 0x25E0010 Offset: 0x25DC010 VA: 0x25E0010
	public void OnGmMahjongFixHand(Game game, int[] handList) { }

	// RVA: 0x25E00F0 Offset: 0x25DC0F0 VA: 0x25E00F0
	public void OnGmMahjongFixDora(Game game, int[] doraList, int[] uraDoraList) { }

	// RVA: 0x25E01D0 Offset: 0x25DC1D0 VA: 0x25E01D0
	public void OnGmMahjongFixRinshan(Game game, int[] rinshanList) { }

	// RVA: 0x25E02B0 Offset: 0x25DC2B0 VA: 0x25E02B0
	public void OnGmMahjongFixHaitei(Game game, int tileId) { }

	// RVA: 0x25E0390 Offset: 0x25DC390 VA: 0x25E0390
	public void OnGmServantInitialize(Game game) { }

	// RVA: 0x25E03C8 Offset: 0x25DC3C8 VA: 0x25E03C8
	public void OnGmMahjongFixWareme(Game game, byte wareme) { }

	// RVA: 0x25E04A8 Offset: 0x25DC4A8 VA: 0x25E04A8 Slot: 901
	public void OnEventMatchingJoinEvent(Game game, MatchingJoinEvent join) { }

	// RVA: 0x25E05B0 Offset: 0x25DC5B0 VA: 0x25E05B0 Slot: 902
	public void OnEventMatchingLeaveEvent(Game game, MatchingLeaveEvent leave) { }

	// RVA: 0x25E06B8 Offset: 0x25DC6B8 VA: 0x25E06B8 Slot: 903
	public void OnEventMatchingSuccessEvent(Game game, MatchingSuccessEvent update) { }

	// RVA: 0x25E07A4 Offset: 0x25DC7A4 VA: 0x25E07A4 Slot: 490
	public void OnEventMonsterDebugState(Game game, MobDebugStateEvent stateEvent) { }

	// RVA: 0x25E07A8 Offset: 0x25DC7A8 VA: 0x25E07A8 Slot: 706
	public void OnEventHouseBoughtPetSale(Game game, HouseBoughtPetSaleEvent boughtEvent) { }

	// RVA: 0x25E07AC Offset: 0x25DC7AC VA: 0x25E07AC Slot: 784
	public void OnEventBCollaborationEnterField(Game game, BCollaborationEnterField enterEvent) { }

	// RVA: 0x25E0A54 Offset: 0x25DCA54 VA: 0x25E0A54 Slot: 785
	public void OnEventBCollaborationGameStart(Game game, BCollaborationGameStartEvent startEvent) { }

	// RVA: 0x25E0B00 Offset: 0x25DCB00 VA: 0x25E0B00 Slot: 786
	public void OnEventBCollaborationGameEnd(Game game, BCollaborationGameEndEvent endEvent) { }

	// RVA: 0x25E0BAC Offset: 0x25DCBAC VA: 0x25E0BAC Slot: 493
	public void OnEventBCollaborationMatchingStart(Game game, BCollaborationMatchingStartEvent matchingEvent) { }

	// RVA: 0x25E0C80 Offset: 0x25DCC80 VA: 0x25E0C80 Slot: 494
	public void OnEventScoreAttackEndBattle(Game game, ScoreAttackEndBattleEvent endEvent) { }

	// RVA: 0x25E0D40 Offset: 0x25DCD40 VA: 0x25E0D40 Slot: 904
	public void OnEventRoguelikeEnterField(Game game, EnterRoguelikeField enterEvent) { }

	// RVA: 0x25E0D78 Offset: 0x25DCD78 VA: 0x25E0D78 Slot: 905
	public void OnEventRoguelikeChangePhase(Game game, RoguelikeChangePhaseEvent phaseEvent) { }

	// RVA: 0x25E0DB0 Offset: 0x25DCDB0 VA: 0x25E0DB0 Slot: 906
	public void OnEventRoguelikeMemberBuffSelect(Game game, RoguelikeMemberBuffSelectEvent buffSelectEvent) { }

	// RVA: 0x25E0DE8 Offset: 0x25DCDE8 VA: 0x25E0DE8 Slot: 907
	public void OnEventRoguelikeResult(Game game, RoguelikeResultEvent resultEvent) { }

	// RVA: 0x25E0E20 Offset: 0x25DCE20 VA: 0x25E0E20 Slot: 908
	public void OnEventRoguelikeFixedDamage(Game game, RoguelikeFixedDamageEvent fixedDamageEvent) { }

	// RVA: 0x25E0E58 Offset: 0x25DCE58 VA: 0x25E0E58 Slot: 479
	public void OnEventLobbyMatchingStart(Game game) { }

	// RVA: 0x25E0E90 Offset: 0x25DCE90 VA: 0x25E0E90 Slot: 480
	public void OnEventLobbyMatchingEnd(Game game, LobbyMatchingEndEvent matchingEvent) { }

	// RVA: 0x25E0EC8 Offset: 0x25DCEC8 VA: 0x25E0EC8 Slot: 481
	public void OnEventLobbyMatchingCountdownStart(Game game, LobbyMatchingCountdownStartEvent countdownEvent) { }

	// RVA: 0x25E0F00 Offset: 0x25DCF00 VA: 0x25E0F00 Slot: 482
	public void OnEventLobbyMatchingCountdownReset(Game game, LobbyMatchingCountdownResetEvent countdownEvent) { }

	// RVA: 0x25E0F38 Offset: 0x25DCF38 VA: 0x25E0F38 Slot: 909
	public void OnEventRoguelikeIdleKick(Game game, RoguelikeIdleKickEvent idleKickEvent) { }

	// RVA: 0x25E0F70 Offset: 0x25DCF70 VA: 0x25E0F70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x25E0FCC Offset: 0x25DCFCC VA: 0x25E0FCC
	private void <OnLoginFailure>b__63_0() { }

	[CompilerGenerated]
	// RVA: 0x25E1034 Offset: 0x25DD034 VA: 0x25E1034
	private void <OnGameJoinFailure>b__64_0() { }

	[IteratorStateMachine(typeof(PhotonListener.<<OnEventPartyRecruitmentRemove>g__CheckIsParty|991_0>d))]
	[CompilerGenerated]
	// RVA: 0x25DE6BC Offset: 0x25DA6BC VA: 0x25DE6BC
	internal static IEnumerator <OnEventPartyRecruitmentRemove>g__CheckIsParty|991_0() { }
}

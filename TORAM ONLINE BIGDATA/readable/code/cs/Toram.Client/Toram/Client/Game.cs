// Assembly: Toram.Client.dll
// Namespace: Toram.Client
[CLSCompliant(False)]
public class Game : IPhotonPeerListener // TypeDefIndex: 14874
{
	// Fields
	private readonly Settings settings; // 0x10
	private readonly IGameListener listener; // 0x18
	private IGameLogicStrategy stateStrategy; // 0x20
	private readonly Dictionary<byte, Dictionary<int, Archetype>> archetypeCache; // 0x28
	private byte newParameterId; // 0x30
	private int outgoingOperationCount; // 0x34
	private readonly CycleActionPool<ActionData> actionPool; // 0x38
	private readonly CycleActionPool<ActionData> pastActionPool; // 0x40
	private readonly NewServerTimestamp timestamp; // 0x48
	private readonly OperationPool questOperationPool; // 0x50
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x58
	[CompilerGenerated]
	private GamePeer <Peer>k__BackingField; // 0x60
	[CompilerGenerated]
	private MyArchetype <Avatar>k__BackingField; // 0x68
	[CompilerGenerated]
	private FieldData <FieldData>k__BackingField; // 0x70
	[CompilerGenerated]
	private string <AllowAsobimoId>k__BackingField; // 0x78
	[CompilerGenerated]
	private Server <MasterServer>k__BackingField; // 0x80
	[CompilerGenerated]
	private Server <GameServer>k__BackingField; // 0x88
	[CompilerGenerated]
	private Server <GlobalServer>k__BackingField; // 0x90
	[CompilerGenerated]
	private byte <EnableServerType>k__BackingField; // 0x98
	[CompilerGenerated]
	private string <ServerAppliName>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <IsRecconect>k__BackingField; // 0xA8
	[CompilerGenerated]
	private GameScene <ProgressScene>k__BackingField; // 0xAC
	[CompilerGenerated]
	private string <GUID>k__BackingField; // 0xB0
	[CompilerGenerated]
	private bool <IsConnectLogEnabled>k__BackingField; // 0xB8
	[CompilerGenerated]
	private bool <ConnectResume>k__BackingField; // 0xB9
	[CompilerGenerated]
	private bool <OperationDetail>k__BackingField; // 0xBA
	[CompilerGenerated]
	private int <ViewPersons>k__BackingField; // 0xBC
	[CompilerGenerated]
	private byte <AsobimoLogin>k__BackingField; // 0xC0

	// Properties
	public int AvatarUuid { get; set; }
	public GamePeer Peer { get; set; }
	public MyArchetype Avatar { get; set; }
	public FieldData FieldData { get; set; }
	public string AllowAsobimoId { get; set; }
	public Server MasterServer { get; set; }
	public Server GameServer { get; set; }
	public Server GlobalServer { get; set; }
	public byte EnableServerType { get; set; }
	private string ServerAppliName { set; }
	public bool IsRecconect { get; set; }
	public IGameListener Listener { get; }
	internal CycleActionPool<ActionData> PastActionPool { get; }
	internal NewServerTimestamp Timestamp { get; }
	public OperationPool QuestOperationPool { get; }
	public GameState GameState { get; }
	public GameScene ProgressScene { get; set; }
	internal string GUID { get; set; }
	internal bool IsDebugLogEnabled { get; }
	internal bool IsConnectLogEnabled { get; }
	public bool ConnectResume { get; set; }
	public int ViewPersons { get; set; }
	public byte AsobimoLogin { get; set; }

	// Methods

	// RVA: 0x354EB20 Offset: 0x354AB20 VA: 0x354EB20
	public void .ctor(IGameListener listener, Settings settings) { }

	[CompilerGenerated]
	// RVA: 0x354EEB0 Offset: 0x354AEB0 VA: 0x354EEB0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x354EEB8 Offset: 0x354AEB8 VA: 0x354EEB8
	private void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x354EEC0 Offset: 0x354AEC0 VA: 0x354EEC0
	public GamePeer get_Peer() { }

	[CompilerGenerated]
	// RVA: 0x354EEC8 Offset: 0x354AEC8 VA: 0x354EEC8
	private void set_Peer(GamePeer value) { }

	[CompilerGenerated]
	// RVA: 0x354EED0 Offset: 0x354AED0 VA: 0x354EED0
	public MyArchetype get_Avatar() { }

	[CompilerGenerated]
	// RVA: 0x354EED8 Offset: 0x354AED8 VA: 0x354EED8
	private void set_Avatar(MyArchetype value) { }

	[CompilerGenerated]
	// RVA: 0x354EEE0 Offset: 0x354AEE0 VA: 0x354EEE0
	public FieldData get_FieldData() { }

	[CompilerGenerated]
	// RVA: 0x354EEE8 Offset: 0x354AEE8 VA: 0x354EEE8
	private void set_FieldData(FieldData value) { }

	[CompilerGenerated]
	// RVA: 0x354EEF0 Offset: 0x354AEF0 VA: 0x354EEF0
	public string get_AllowAsobimoId() { }

	[CompilerGenerated]
	// RVA: 0x354EEF8 Offset: 0x354AEF8 VA: 0x354EEF8
	private void set_AllowAsobimoId(string value) { }

	[CompilerGenerated]
	// RVA: 0x354EF00 Offset: 0x354AF00 VA: 0x354EF00
	public Server get_MasterServer() { }

	[CompilerGenerated]
	// RVA: 0x354EF08 Offset: 0x354AF08 VA: 0x354EF08
	private void set_MasterServer(Server value) { }

	[CompilerGenerated]
	// RVA: 0x354EF10 Offset: 0x354AF10 VA: 0x354EF10
	public Server get_GameServer() { }

	[CompilerGenerated]
	// RVA: 0x354EF18 Offset: 0x354AF18 VA: 0x354EF18
	private void set_GameServer(Server value) { }

	[CompilerGenerated]
	// RVA: 0x354EF20 Offset: 0x354AF20 VA: 0x354EF20
	public Server get_GlobalServer() { }

	[CompilerGenerated]
	// RVA: 0x354EF28 Offset: 0x354AF28 VA: 0x354EF28
	private void set_GlobalServer(Server value) { }

	[CompilerGenerated]
	// RVA: 0x354EF30 Offset: 0x354AF30 VA: 0x354EF30
	public byte get_EnableServerType() { }

	[CompilerGenerated]
	// RVA: 0x354EF38 Offset: 0x354AF38 VA: 0x354EF38
	private void set_EnableServerType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x354EF40 Offset: 0x354AF40 VA: 0x354EF40
	private void set_ServerAppliName(string value) { }

	[CompilerGenerated]
	// RVA: 0x354EF48 Offset: 0x354AF48 VA: 0x354EF48
	public bool get_IsRecconect() { }

	[CompilerGenerated]
	// RVA: 0x354EF50 Offset: 0x354AF50 VA: 0x354EF50
	private void set_IsRecconect(bool value) { }

	// RVA: 0x354EF5C Offset: 0x354AF5C VA: 0x354EF5C
	public IGameListener get_Listener() { }

	// RVA: 0x354EF64 Offset: 0x354AF64 VA: 0x354EF64
	internal CycleActionPool<ActionData> get_PastActionPool() { }

	// RVA: 0x354EF6C Offset: 0x354AF6C VA: 0x354EF6C
	internal NewServerTimestamp get_Timestamp() { }

	// RVA: 0x354EF74 Offset: 0x354AF74 VA: 0x354EF74
	public OperationPool get_QuestOperationPool() { }

	// RVA: 0x354EF7C Offset: 0x354AF7C VA: 0x354EF7C
	public GameState get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x354F01C Offset: 0x354B01C VA: 0x354F01C
	public GameScene get_ProgressScene() { }

	[CompilerGenerated]
	// RVA: 0x354F024 Offset: 0x354B024 VA: 0x354F024
	private void set_ProgressScene(GameScene value) { }

	[CompilerGenerated]
	// RVA: 0x354F02C Offset: 0x354B02C VA: 0x354F02C
	internal string get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x354F034 Offset: 0x354B034 VA: 0x354F034
	private void set_GUID(string value) { }

	// RVA: 0x354F03C Offset: 0x354B03C VA: 0x354F03C
	internal bool get_IsDebugLogEnabled() { }

	[CompilerGenerated]
	// RVA: 0x354F0EC Offset: 0x354B0EC VA: 0x354F0EC
	internal bool get_IsConnectLogEnabled() { }

	[CompilerGenerated]
	// RVA: 0x354F0F4 Offset: 0x354B0F4 VA: 0x354F0F4
	public bool get_ConnectResume() { }

	[CompilerGenerated]
	// RVA: 0x354F0FC Offset: 0x354B0FC VA: 0x354F0FC
	public void set_ConnectResume(bool value) { }

	[CompilerGenerated]
	// RVA: 0x354F108 Offset: 0x354B108 VA: 0x354F108
	public int get_ViewPersons() { }

	[CompilerGenerated]
	// RVA: 0x354F110 Offset: 0x354B110 VA: 0x354F110
	private void set_ViewPersons(int value) { }

	[CompilerGenerated]
	// RVA: 0x354F118 Offset: 0x354B118 VA: 0x354F118
	public byte get_AsobimoLogin() { }

	[CompilerGenerated]
	// RVA: 0x354F120 Offset: 0x354B120 VA: 0x354F120
	private void set_AsobimoLogin(byte value) { }

	// RVA: 0x354EEA8 Offset: 0x354AEA8 VA: 0x354EEA8
	internal void SetGameProgressScene(GameScene gameScene) { }

	// RVA: 0x354F128 Offset: 0x354B128 VA: 0x354F128
	internal void SetNewParameterId(byte parameterId) { }

	// RVA: 0x354F130 Offset: 0x354B130 VA: 0x354F130
	internal void SetReconnectFlag(bool isReconnect) { }

	// RVA: 0x354F13C Offset: 0x354B13C VA: 0x354F13C
	public void SetViewPersons(int viewPersons) { }

	// RVA: 0x354F144 Offset: 0x354B144 VA: 0x354F144
	public void SetCookie(string cookie) { }

	// RVA: 0x354F160 Offset: 0x354B160 VA: 0x354F160
	public void SetAsobimoLogin(bool isAsobimoAccount) { }

	// RVA: 0x354F16C Offset: 0x354B16C VA: 0x354F16C
	public void UpdateTimestamp() { }

	// RVA: 0x354F1C8 Offset: 0x354B1C8 VA: 0x354F1C8
	public void Disconnect() { }

	// RVA: 0x354F1F0 Offset: 0x354B1F0 VA: 0x354F1F0
	internal void SetDisconnected(StatusCode returnCode) { }

	// RVA: 0x354F560 Offset: 0x354B560 VA: 0x354F560
	public bool MasterConnect(GamePeer peer) { }

	// RVA: 0x354F708 Offset: 0x354B708 VA: 0x354F708
	public bool MasterChangeConnect() { }

	// RVA: 0x354F81C Offset: 0x354B81C VA: 0x354F81C
	public bool MasterReconnect() { }

	// RVA: 0x354F884 Offset: 0x354B884 VA: 0x354F884
	public void MasterLogin(string appVersion, string model) { }

	// RVA: 0x354F8A0 Offset: 0x354B8A0 VA: 0x354F8A0
	internal void MasterReLogin() { }

	// RVA: 0x354F8B0 Offset: 0x354B8B0 VA: 0x354F8B0
	internal void SetMasterConnected() { }

	// RVA: 0x354F998 Offset: 0x354B998 VA: 0x354F998
	internal void SetMasterAllowLogin(LoginResponse login) { }

	// RVA: 0x354FB50 Offset: 0x354BB50 VA: 0x354FB50
	internal void SetMasterTimeoutDisconnected(StatusCode returnCode) { }

	// RVA: 0x354FD1C Offset: 0x354BD1C VA: 0x354FD1C
	internal void SetMasterDisconnectByServer(StatusCode returnCode) { }

	// RVA: 0x354FF04 Offset: 0x354BF04 VA: 0x354FF04
	public bool GameConnect() { }

	// RVA: 0x3550018 Offset: 0x354C018 VA: 0x3550018
	public bool GamerReconnect() { }

	// RVA: 0x3550084 Offset: 0x354C084 VA: 0x3550084
	public void GameJoin(string appVersion, string model) { }

	// RVA: 0x35500B0 Offset: 0x354C0B0 VA: 0x35500B0
	public void GameReJoin(string appVersion, string model) { }

	// RVA: 0x35500DC Offset: 0x354C0DC VA: 0x35500DC
	internal void SetGameConnected() { }

	// RVA: 0x35501D8 Offset: 0x354C1D8 VA: 0x35501D8
	internal void SetGameTimeoutDisconnected(StatusCode returnCode) { }

	// RVA: 0x35503A8 Offset: 0x354C3A8 VA: 0x35503A8
	internal void SetGameDisconnectByServer(StatusCode returnCode) { }

	// RVA: 0x3550590 Offset: 0x354C590 VA: 0x3550590
	internal void SetGameConnectSwitching(GameReturnCode returnCode) { }

	// RVA: 0x3550700 Offset: 0x354C700 VA: 0x3550700
	public void AddArchetype(Archetype archetype) { }

	// RVA: 0x355088C Offset: 0x354C88C VA: 0x355088C
	public void AddMobaArchetype(Archetype archetype) { }

	// RVA: 0x3550998 Offset: 0x354C998 VA: 0x3550998
	public void AddForeignArchetype(byte archetypeType, int archetypeId) { }

	// RVA: 0x3550B24 Offset: 0x354CB24 VA: 0x3550B24
	private bool TryAddArchetype(Archetype archetype) { }

	// RVA: 0x3550D10 Offset: 0x354CD10 VA: 0x3550D10
	public bool RemoveArchetype(Archetype archetype) { }

	// RVA: 0x3550E8C Offset: 0x354CE8C VA: 0x3550E8C
	public void RemoveForeignArchetype(byte archetypeType, int archetypeId) { }

	// RVA: 0x3550A5C Offset: 0x354CA5C VA: 0x3550A5C
	public bool TryGetArchetype(byte archetypeType, int archetypeId, out Archetype archetype) { }

	// RVA: 0x3550EF0 Offset: 0x354CEF0 VA: 0x3550EF0
	internal void RemoveAllArchetypes() { }

	// RVA: 0x3551380 Offset: 0x354D380 VA: 0x3551380
	internal void RemoveExceptMineArchetypes() { }

	// RVA: 0x354F3BC Offset: 0x354B3BC VA: 0x354F3BC Slot: 4
	public void DebugReturn(DebugLevel level, string message) { }

	// RVA: 0x3551854 Offset: 0x354D854 VA: 0x3551854 Slot: 7
	public void OnEvent(EventData eventData) { }

	// RVA: 0x3551D74 Offset: 0x354DD74 VA: 0x3551D74 Slot: 5
	public void OnOperationResponse(OperationResponse operationResponse) { }

	// RVA: 0x3551FDC Offset: 0x354DFDC VA: 0x3551FDC Slot: 6
	public void OnStatusChanged(StatusCode statusCode) { }

	// RVA: 0x35521F8 Offset: 0x354E1F8 VA: 0x35521F8
	public void Update() { }

	// RVA: 0x35522A0 Offset: 0x354E2A0 VA: 0x35522A0
	internal void ReportStatusChange(GameState state, StatusCode statusCode) { }

	// RVA: 0x35523F0 Offset: 0x354E3F0 VA: 0x35523F0
	internal void OnUnexpectedEventReceive(EventData event) { }

	// RVA: 0x3552500 Offset: 0x354E500 VA: 0x3552500
	internal void OnUnexpectedOperationError(OperationResponse operationResponse) { }

	// RVA: 0x3552838 Offset: 0x354E838 VA: 0x3552838
	internal void SendOperation(OperationCode operationCode, Dictionary<byte, object> parameter, bool sendReliable, byte channelId, bool encrypt) { }

	// RVA: 0x35532E0 Offset: 0x354F2E0 VA: 0x35532E0
	internal void SetGameAvatarCreateScene(byte resultCode, GameJoinResponse join) { }

	// RVA: 0x35533E8 Offset: 0x354F3E8 VA: 0x35533E8
	internal void SetGameAvatarRenamingScene(byte resultCode, GameJoinResponse join) { }

	// RVA: 0x35534F0 Offset: 0x354F4F0 VA: 0x35534F0
	internal void SetGameLoadAvatar(GameJoinResponse join) { }

	// RVA: 0x35535F0 Offset: 0x354F5F0 VA: 0x35535F0
	internal void SetGameLoader() { }

	[Obsolete("Old Version")]
	// RVA: 0x35536E0 Offset: 0x354F6E0 VA: 0x35536E0
	internal void SetEnterAvatar(EnterAvatarData avatarData) { }

	// RVA: 0x35538E8 Offset: 0x354F8E8 VA: 0x35538E8
	internal void SetEnterAvatar(EnterAvatarPacket avatarData) { }

	// RVA: 0x35539E8 Offset: 0x354F9E8 VA: 0x35539E8
	internal void SetEnterAvatar(EnterAvatarData2 avatarData) { }

	// RVA: 0x35537E0 Offset: 0x354F7E0 VA: 0x35537E0
	internal MyArchetype CreateEnterAvatar(int avatarUuid, byte archetypeType, byte paramId, string paramName, short[] position, short rotation, Dictionary<byte, object> properties, int propertiesRevision) { }

	// RVA: 0x3553AF8 Offset: 0x354FAF8 VA: 0x3553AF8
	internal MyArchetype RecreateEnterAvatar(int avatarUuid, byte archetypeType, byte paramId, string paramName, short[] position, short rotation, Dictionary<byte, object> properties, int propertiesRevision) { }

	// RVA: 0x3553C6C Offset: 0x354FC6C VA: 0x3553C6C
	internal void SetGameMain(FieldData fieldData, PositionData positionData) { }

	// RVA: 0x3553D78 Offset: 0x354FD78 VA: 0x3553D78
	internal void SetBlank(byte reason) { }

	// RVA: 0x3553E78 Offset: 0x354FE78 VA: 0x3553E78
	internal void SetGameRejoinAvatarCreateScene(byte resultCode, GameReJoinResponse rejoin) { }

	// RVA: 0x3553F80 Offset: 0x354FF80 VA: 0x3553F80
	internal void SetGameRejoinRecreateScene(byte resultCode, GameReJoinResponse rejoin) { }

	// RVA: 0x3554088 Offset: 0x3550088 VA: 0x3554088
	internal void SetGameRejoinRenameScene(byte resultCode, GameReJoinResponse rejoin) { }

	// RVA: 0x3554190 Offset: 0x3550190 VA: 0x3554190
	internal void SetGameRejoinAvatarRenamingScene(byte resultCode, GameReJoinResponse rejoin) { }

	// RVA: 0x3554298 Offset: 0x3550298 VA: 0x3554298
	internal void SetGameRejoinParameterCreateScene(byte resultCode, GameReJoinResponse rejoin) { }

	// RVA: 0x35543A0 Offset: 0x35503A0 VA: 0x35543A0
	internal void SetGameRejoinLoadAvatar(GameReJoinResponse rejoin) { }

	// RVA: 0x35544A0 Offset: 0x35504A0 VA: 0x35544A0
	internal void SetGameRejoinLoader(GameReJoinResponse rejoin) { }

	// RVA: 0x35545A0 Offset: 0x35505A0 VA: 0x35545A0
	internal void SetGameRejoinMain(GameReJoinResponse rejoin) { }

	// RVA: 0x3554814 Offset: 0x3550814 VA: 0x3554814
	internal void SetGameRejoinBlank(GameReJoinResponse rejoin) { }

	// RVA: 0x3554914 Offset: 0x3550914 VA: 0x3554914
	internal void SetGameRejoinMiniGameLobbyScene(GameReJoinResponse rejoin) { }

	// RVA: 0x3554B2C Offset: 0x3550B2C VA: 0x3554B2C
	internal void SetGameRejoinMiniGameScene(GameReJoinResponse rejoin) { }

	// RVA: 0x35547F8 Offset: 0x35507F8 VA: 0x35547F8
	private void ReLoginOperationReSend() { }

	// RVA: 0x354FAE8 Offset: 0x354BAE8 VA: 0x354FAE8
	private void GameInitialize() { }

	// RVA: 0x3554D44 Offset: 0x3550D44 VA: 0x3554D44
	internal void ChangeField() { }

	// RVA: 0x3554DB8 Offset: 0x3550DB8 VA: 0x3554DB8
	internal void SetChangeField(byte operationCode) { }

	// RVA: 0x3555230 Offset: 0x3551230 VA: 0x3555230
	internal void SetChangeField(byte operationCode, byte subCode) { }

	// RVA: 0x3555AA4 Offset: 0x3551AA4 VA: 0x3555AA4
	internal void SetChangeField(OperationResponse responseObject, byte subCode = 0) { }

	// RVA: 0x3555C28 Offset: 0x3551C28 VA: 0x3555C28
	internal void SetUseWarpTicket(OrbItemUseResponse response) { }

	// RVA: 0x3555D2C Offset: 0x3551D2C VA: 0x3555D2C
	internal void SetOrbWorldWarp(OrbServiceBuyResponse response) { }

	// RVA: 0x3555E30 Offset: 0x3551E30 VA: 0x3555E30
	internal void SetChangeParameter() { }

	// RVA: 0x3555F24 Offset: 0x3551F24 VA: 0x3555F24
	internal void SetCreateParameter() { }

	// RVA: 0x3556018 Offset: 0x3552018 VA: 0x3556018
	internal void SetRecreateChange() { }

	// RVA: 0x355610C Offset: 0x355210C VA: 0x355610C
	internal void SetRenameChange() { }

	// RVA: 0x3556200 Offset: 0x3552200 VA: 0x3556200
	internal void SetNpcAvatarJoin(NpcAvatarJoinResponse npcJoin) { }

	// RVA: 0x3556344 Offset: 0x3552344 VA: 0x3556344
	internal void SetNpcAvatarJoin(RoomNpcJoinEvent npcJoin) { }

	// RVA: 0x3556480 Offset: 0x3552480 VA: 0x3556480
	internal void SetNpcAvatarRejoin(NpcAvatarRejoinResponse npcJoin) { }

	// RVA: 0x35565C4 Offset: 0x35525C4 VA: 0x35565C4
	internal void SetCompanionAvatarJoin(Dictionary<byte, object> companionJoin) { }

	// RVA: 0x3556750 Offset: 0x3552750 VA: 0x3556750
	internal void SetReload() { }

	// RVA: 0x3556844 Offset: 0x3552844 VA: 0x3556844
	internal void SendScenarioOperation(OperationBase operation) { }

	// RVA: 0x3556938 Offset: 0x3552938 VA: 0x3556938
	internal int SendAction(ActionData actionData, bool sendReliable, bool isGuarantee = True) { }

	// RVA: 0x35569C4 Offset: 0x35529C4 VA: 0x35569C4
	internal int SendAction(ActionData actionData, bool sendReliable, int timestamp, bool isGuarantee = True) { }

	// RVA: 0x3556BDC Offset: 0x3552BDC VA: 0x3556BDC
	internal void SendActionLight(byte actionCode, byte[] actionBinary, bool sendReliable) { }

	// RVA: 0x3556D00 Offset: 0x3552D00 VA: 0x3556D00
	internal void SendActionLight(ArchetypeUid archetype, byte actionCode, byte[] actionBinary, bool sendReliable) { }

	// RVA: 0x3556E44 Offset: 0x3552E44 VA: 0x3556E44
	internal void UpdateActionResult(byte actionCode, short revision) { }
}

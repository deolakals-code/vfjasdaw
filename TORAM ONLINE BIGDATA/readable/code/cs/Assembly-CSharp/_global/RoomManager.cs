// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RoomManager : Singleton<RoomManager>, ISceneChangeManager // TypeDefIndex: 2460
{
	// Fields
	private RoomManager.RoomMembersData roomData; // 0x20
	private RoomDataBase roomDataBase; // 0x28
	private byte secondaryMatchingState; // 0x30
	private bool annihilated; // 0x31
	private bool isBattleEnd; // 0x32
	private List<RoomManager.AttachmentNPC> attachmentNPCList; // 0x38
	private int[] resistryNpcId; // 0x40
	private int registrationScId; // 0x48
	private bool isAddSecondMember; // 0x4C
	private bool enableSecondParty; // 0x4D
	[CompilerGenerated]
	private int <TeamId>k__BackingField; // 0x50

	// Properties
	public IList<RoomManager.RoomMeberData> MemberList { get; }
	public int SecondaryMatchingState { get; }
	public RoomDataBase RoomData { get; }
	public bool IsAnnihilated { get; }
	public bool IsBattleEnd { get; }
	public bool IsFocusPropertyUpdate { get; }
	public int TeamId { get; set; }

	// Methods

	// RVA: 0x21B6F5C Offset: 0x21B2F5C VA: 0x21B6F5C
	public IList<RoomManager.RoomMeberData> get_MemberList() { }

	// RVA: 0x21B7000 Offset: 0x21B3000 VA: 0x21B7000
	public int get_SecondaryMatchingState() { }

	// RVA: 0x21B7194 Offset: 0x21B3194 VA: 0x21B7194
	public RoomDataBase get_RoomData() { }

	// RVA: 0x21B719C Offset: 0x21B319C VA: 0x21B719C
	public bool get_IsAnnihilated() { }

	// RVA: 0x21B7328 Offset: 0x21B3328 VA: 0x21B7328
	public bool get_IsBattleEnd() { }

	// RVA: 0x21B73B8 Offset: 0x21B33B8 VA: 0x21B73B8
	public bool get_IsFocusPropertyUpdate() { }

	[CompilerGenerated]
	// RVA: 0x21B747C Offset: 0x21B347C VA: 0x21B747C
	public int get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x21B7484 Offset: 0x21B3484 VA: 0x21B7484
	private void set_TeamId(int value) { }

	// RVA: 0x21B748C Offset: 0x21B348C VA: 0x21B748C
	private void Start() { }

	// RVA: 0x21B74EC Offset: 0x21B34EC VA: 0x21B74EC
	public void Initialize(List<IRoomMember> members) { }

	// RVA: 0x21B77BC Offset: 0x21B37BC VA: 0x21B77BC
	public void Claer() { }

	[IteratorStateMachine(typeof(RoomManager.<LoadRoomResource>d__33))]
	// RVA: 0x21B7864 Offset: 0x21B3864 VA: 0x21B7864
	public IEnumerator LoadRoomResource(int fieldId, byte roomId, FieldRoomType roomType) { }

	// RVA: 0x21B7908 Offset: 0x21B3908 VA: 0x21B7908
	public void CreateRoom(RoomDataBase roomData) { }

	// RVA: 0x21B7910 Offset: 0x21B3910 VA: 0x21B7910
	public void SetTeamId(int teamId) { }

	// RVA: 0x21B7918 Offset: 0x21B3918 VA: 0x21B7918
	public void SetSecondaryMatchingState(byte state) { }

	// RVA: 0x21B797C Offset: 0x21B397C VA: 0x21B797C
	private void Update() { }

	// RVA: 0x21B7998 Offset: 0x21B3998 VA: 0x21B7998
	public void OnOperationFailure(byte operationCode, short returnCode) { }

	// RVA: 0x21B79B0 Offset: 0x21B39B0 VA: 0x21B79B0
	public void OnOperationFailure(byte operationCode, byte subCode, short returnCode) { }

	// RVA: 0x21B79C8 Offset: 0x21B39C8 VA: 0x21B79C8
	public void OnEventRoomAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x21B7A10 Offset: 0x21B3A10 VA: 0x21B7A10
	public void UpdateSetting(RoomSetting setting) { }

	// RVA: 0x21B7A5C Offset: 0x21B3A5C VA: 0x21B7A5C
	public void UpdateGroupSetting(RoomGroupSetting setting) { }

	// RVA: 0x21ABD80 Offset: 0x21A7D80 VA: 0x21ABD80
	public void UpdateRoomLobbySetting(RoomLobbySetting setting) { }

	// RVA: 0x21B7A70 Offset: 0x21B3A70 VA: 0x21B7A70
	public void UpdateRoomLobbySetting(RoomLobbySetting setting, bool isAnnihilated) { }

	// RVA: 0x21B7AA4 Offset: 0x21B3AA4 VA: 0x21B7AA4
	public void EnterRoomConnection() { }

	// RVA: 0x21B7AC0 Offset: 0x21B3AC0 VA: 0x21B7AC0
	public bool OnDead() { }

	// RVA: 0x21B7AFC Offset: 0x21B3AFC VA: 0x21B7AFC
	public bool OnLoginField(LoginFieldResponse loginData) { }

	// RVA: 0x21B8B2C Offset: 0x21B4B2C VA: 0x21B8B2C
	public short GetAreaLevel() { }

	// RVA: 0x21B8B34 Offset: 0x21B4B34 VA: 0x21B8B34
	public short GetAreaLevel(short ret) { }

	// RVA: 0x21B8BD8 Offset: 0x21B4BD8 VA: 0x21B8BD8
	public short GetMobDifficulty() { }

	// RVA: 0x21B8BE0 Offset: 0x21B4BE0 VA: 0x21B8BE0
	public short GetMobDifficulty(short ret) { }

	// RVA: 0x21B8C84 Offset: 0x21B4C84 VA: 0x21B8C84
	public bool CheckRoomUniqueAction(RoomManager.RoomUniqueActionType type) { }

	// RVA: 0x21B8D30 Offset: 0x21B4D30 VA: 0x21B8D30
	public bool CheckRoomRule(RoomRuleFlag ruleFlag) { }

	// RVA: 0x21B73F0 Offset: 0x21B33F0 VA: 0x21B73F0
	private bool RoomEventCheck() { }

	// RVA: 0x21B8DD0 Offset: 0x21B4DD0 VA: 0x21B8DD0
	public bool CheckTapPlayerRoom() { }

	// RVA: 0x21B8E0C Offset: 0x21B4E0C VA: 0x21B8E0C
	public void OnGameEventLogin(GameEventLoginResponse login, short returnCode) { }

	// RVA: 0x21B8E60 Offset: 0x21B4E60 VA: 0x21B8E60
	public void OnGameRoomRejoin(IEnterAvatarPacket avatarData, GameReJoinResponse rejoin) { }

	// RVA: 0x21B8EB4 Offset: 0x21B4EB4 VA: 0x21B8EB4
	public NewArchetypeProperties UpdatePlayerProperty(NewArchetypeProperties property) { }

	// RVA: 0x21B8F04 Offset: 0x21B4F04 VA: 0x21B8F04
	public void UpdatePlayerPropertyEnd(GameObject player, SkinnedMeshRenderer skin, PlayerAnimation animation, CharacterMove move) { }

	// RVA: 0x21B8F74 Offset: 0x21B4F74 VA: 0x21B8F74
	public bool TryGetManagementAvater(ArchetypeUid archetypeUid, out GameObject avater) { }

	// RVA: 0x21B8FE0 Offset: 0x21B4FE0 VA: 0x21B8FE0
	public bool OnActionOtherMove(OtherPlayerActionManager otherPlayerActionManager, IMoveData eventData) { }

	// RVA: 0x21B9038 Offset: 0x21B5038 VA: 0x21B9038
	public void ReceiveUpdate(OperationResponse response) { }

	// RVA: 0x21B9084 Offset: 0x21B5084 VA: 0x21B9084
	public bool CheckVisibleOtherPlayerRoom(Archetype archetype) { }

	// RVA: 0x21B90D4 Offset: 0x21B50D4 VA: 0x21B90D4
	public bool OtherPlayerRoomListDataMove(ArchetypeUid archetypeUid, IMoveData moveEvent) { }

	// RVA: 0x21B912C Offset: 0x21B512C VA: 0x21B912C
	public bool OtherPlayerRoomListDataAction(ArchetypeActionEvent actionEvent) { }

	// RVA: 0x21B917C Offset: 0x21B517C VA: 0x21B917C
	public bool InitCameraUpdate(CameraManager manager) { }

	// RVA: 0x21B91CC Offset: 0x21B51CC VA: 0x21B91CC
	public IEventResultPanel OpenRoomEventResultPanel(int roomType) { }

	// RVA: 0x21B9260 Offset: 0x21B5260 VA: 0x21B9260
	public void OnRoomWarpPosition(RoomWarpPositionResponse warpPosition) { }

	// RVA: 0x21B92AC Offset: 0x21B52AC VA: 0x21B92AC
	public bool PlayerInputMoveCheck() { }

	// RVA: 0x21B92E8 Offset: 0x21B52E8 VA: 0x21B92E8
	public bool FieldScriptRoomEndCommand() { }

	// RVA: 0x21B9324 Offset: 0x21B5324 VA: 0x21B9324
	public bool IsShortcutLock() { }

	// RVA: 0x21B9360 Offset: 0x21B5360 VA: 0x21B9360
	public UIActiveState OpenOtherMenu(UIActiveState state) { }

	// RVA: 0x21ABD68 Offset: 0x21A7D68 VA: 0x21ABD68
	public void UpdateMember(List<IRoomMember> members) { }

	// RVA: 0x21B97E0 Offset: 0x21B57E0 VA: 0x21B97E0
	public void AddMember(RoomGroupMemberStateData member) { }

	// RVA: 0x21B99A0 Offset: 0x21B59A0 VA: 0x21B99A0
	public void RemoveMember(RoomGroupMemberStateData member) { }

	// RVA: 0x21B9A18 Offset: 0x21B5A18 VA: 0x21B9A18
	public void RemoveMember(byte archetypeType, int archetypeId) { }

	// RVA: 0x21B9A34 Offset: 0x21B5A34 VA: 0x21B9A34
	public RoomUserStateType GetState(byte archetypeType, int archetypeId) { }

	// RVA: 0x21B9AD8 Offset: 0x21B5AD8 VA: 0x21B9AD8
	public int GetStateUserNum(RoomUserStateType state) { }

	// RVA: 0x21B9BEC Offset: 0x21B5BEC VA: 0x21B9BEC
	public void ReceiveStartRoom(RoomStartResponse response) { }

	// RVA: 0x21B9C7C Offset: 0x21B5C7C VA: 0x21B9C7C
	public void AddSecondPartyMember(int scId, int id, Vector3 pos, short rot, int flag) { }

	// RVA: 0x21B9EDC Offset: 0x21B5EDC VA: 0x21B9EDC
	public void RoomSecondPartyRegistry(int sendScId) { }

	// RVA: 0x21BA07C Offset: 0x21B607C VA: 0x21BA07C
	public void RoomSecondPartyJoin(int[] id) { }

	// RVA: 0x21BA34C Offset: 0x21B634C VA: 0x21BA34C Slot: 4
	public void OnEnter() { }

	// RVA: 0x21BA3D8 Offset: 0x21B63D8 VA: 0x21BA3D8 Slot: 5
	public void OnLeave() { }

	// RVA: 0x21BA4C8 Offset: 0x21B64C8 VA: 0x21BA4C8
	public void SetRandom(bool isRandom) { }

	// RVA: 0x21BA4F8 Offset: 0x21B64F8 VA: 0x21BA4F8
	public bool GetRandom() { }

	// RVA: 0x21BA518 Offset: 0x21B6518 VA: 0x21BA518
	public void .ctor() { }
}

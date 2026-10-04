// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class RoomDataBase // TypeDefIndex: 2449
{
	// Fields
	private PlayerDataManager playerManager; // 0x10
	protected List<RoomManager.RoomUniqueActionType> uniqueActionTypes; // 0x18
	[CompilerGenerated]
	private RoomSetting <RoomSetting>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomGroupSetting <RoomGroupSetting>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomLobbySetting <RoomLobbySetting>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <RoomId>k__BackingField; // 0x3C
	[CompilerGenerated]
	private Vector3 <Position>k__BackingField; // 0x40
	[CompilerGenerated]
	private float <Rot>k__BackingField; // 0x4C
	[CompilerGenerated]
	private EmergencyPositionData <EmergencyPositionData>k__BackingField; // 0x50
	private SystemTextManager systemManager; // 0x58
	[CompilerGenerated]
	private RoomRuleFlag <RuleFlag>k__BackingField; // 0x60

	// Properties
	public RoomSetting RoomSetting { get; set; }
	public RoomGroupSetting RoomGroupSetting { get; set; }
	public RoomLobbySetting RoomLobbySetting { get; set; }
	public int FieldId { get; set; }
	public virtual byte RoomType { get; }
	public byte RoomId { get; set; }
	public Vector3 Position { get; set; }
	public float Rot { get; set; }
	public EmergencyPositionData EmergencyPositionData { get; set; }
	protected PlayerDataManager playerDataManager { get; }
	protected SystemTextManager systemTextManager { get; }
	public virtual string[] LoadAssetsPath { get; }
	public virtual string LoadFieldAssetsName { get; }
	public virtual short AreaLevel { get; }
	public virtual short MobDifficultyLevel { get; }
	public virtual bool IsFocusPropertyUpdate { get; }
	public RoomRuleFlag RuleFlag { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x21B6BD4 Offset: 0x21B2BD4 VA: 0x21B6BD4
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x21B6BDC Offset: 0x21B2BDC VA: 0x21B6BDC
	private void set_RoomSetting(RoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x21B6BE4 Offset: 0x21B2BE4 VA: 0x21B6BE4
	public RoomGroupSetting get_RoomGroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x21B6BEC Offset: 0x21B2BEC VA: 0x21B6BEC
	private void set_RoomGroupSetting(RoomGroupSetting value) { }

	[CompilerGenerated]
	// RVA: 0x21B6BF4 Offset: 0x21B2BF4 VA: 0x21B6BF4
	public RoomLobbySetting get_RoomLobbySetting() { }

	[CompilerGenerated]
	// RVA: 0x21B6BFC Offset: 0x21B2BFC VA: 0x21B6BFC
	private void set_RoomLobbySetting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x21B6C04 Offset: 0x21B2C04 VA: 0x21B6C04
	protected void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x21B6C0C Offset: 0x21B2C0C VA: 0x21B6C0C
	public int get_FieldId() { }

	// RVA: 0x21B6C14 Offset: 0x21B2C14 VA: 0x21B6C14 Slot: 4
	public virtual byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x21B6C1C Offset: 0x21B2C1C VA: 0x21B6C1C
	protected void set_RoomId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x21B6C24 Offset: 0x21B2C24 VA: 0x21B6C24
	public byte get_RoomId() { }

	[CompilerGenerated]
	// RVA: 0x21B6C2C Offset: 0x21B2C2C VA: 0x21B6C2C
	protected void set_Position(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x21B6C38 Offset: 0x21B2C38 VA: 0x21B6C38
	public Vector3 get_Position() { }

	[CompilerGenerated]
	// RVA: 0x21B6C44 Offset: 0x21B2C44 VA: 0x21B6C44
	protected void set_Rot(float value) { }

	[CompilerGenerated]
	// RVA: 0x21B6C4C Offset: 0x21B2C4C VA: 0x21B6C4C
	public float get_Rot() { }

	[CompilerGenerated]
	// RVA: 0x21B6C54 Offset: 0x21B2C54 VA: 0x21B6C54
	protected void set_EmergencyPositionData(EmergencyPositionData value) { }

	[CompilerGenerated]
	// RVA: 0x21B6C5C Offset: 0x21B2C5C VA: 0x21B6C5C
	public EmergencyPositionData get_EmergencyPositionData() { }

	// RVA: 0x21AA8A8 Offset: 0x21A68A8 VA: 0x21AA8A8
	protected PlayerDataManager get_playerDataManager() { }

	// RVA: 0x21ADA60 Offset: 0x21A9A60 VA: 0x21ADA60
	protected SystemTextManager get_systemTextManager() { }

	// RVA: 0x21B6C64 Offset: 0x21B2C64 VA: 0x21B6C64 Slot: 5
	public virtual string[] get_LoadAssetsPath() { }

	// RVA: 0x21B6C6C Offset: 0x21B2C6C VA: 0x21B6C6C Slot: 6
	public virtual string get_LoadFieldAssetsName() { }

	// RVA: 0x21B6CAC Offset: 0x21B2CAC VA: 0x21B6CAC Slot: 7
	public virtual short get_AreaLevel() { }

	// RVA: 0x21B6CB4 Offset: 0x21B2CB4 VA: 0x21B6CB4 Slot: 8
	public virtual short get_MobDifficultyLevel() { }

	// RVA: 0x21B6CC0 Offset: 0x21B2CC0 VA: 0x21B6CC0 Slot: 9
	public virtual bool get_IsFocusPropertyUpdate() { }

	[CompilerGenerated]
	// RVA: 0x21B6CC8 Offset: 0x21B2CC8 VA: 0x21B6CC8
	public RoomRuleFlag get_RuleFlag() { }

	[CompilerGenerated]
	// RVA: 0x21B6CD0 Offset: 0x21B2CD0 VA: 0x21B6CD0
	private void set_RuleFlag(RoomRuleFlag value) { }

	// RVA: 0x21AA7B4 Offset: 0x21A67B4 VA: 0x21AA7B4
	public void .ctor() { }

	// RVA: 0x21B6CD8 Offset: 0x21B2CD8 VA: 0x21B6CD8
	public void SetAriaData(int fieldId, byte roomId, Vector3 position, float rot, EmergencyPositionData emergency) { }

	// RVA: 0x21B6D10 Offset: 0x21B2D10 VA: 0x21B6D10
	public void UpdateSetting(RoomSetting setting) { }

	// RVA: 0x21B6D18 Offset: 0x21B2D18 VA: 0x21B6D18
	public void UpdateGroupSetting(RoomGroupSetting setting) { }

	// RVA: 0x21B6D20 Offset: 0x21B2D20 VA: 0x21B6D20
	public void UpdateRoomLobbySetting(RoomLobbySetting setting) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void OnFailure(byte operationCode, short returnCode);

	// RVA: 0x21B6D28 Offset: 0x21B2D28 VA: 0x21B6D28 Slot: 11
	public virtual void OnFailure(byte operationCode, byte subCode, short returnCode) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Enter();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void Leave();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void Update();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void LoadAsset();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent);

	// RVA: 0x21B6D2C Offset: 0x21B2D2C VA: 0x21B6D2C Slot: 18
	public virtual bool OnDead() { }

	// RVA: 0x21B6D34 Offset: 0x21B2D34 VA: 0x21B6D34 Slot: 19
	public virtual void RoomSynchronization(RoomSynchronizationEvent syncEvent) { }

	// RVA: 0x21B6D38 Offset: 0x21B2D38 VA: 0x21B6D38 Slot: 20
	public virtual void EnterRoomConnection() { }

	// RVA: 0x21B6D3C Offset: 0x21B2D3C VA: 0x21B6D3C
	public void ValieRule(RoomRuleFlag flag) { }

	// RVA: 0x21B6D4C Offset: 0x21B2D4C VA: 0x21B6D4C
	public void InvalidRule(RoomRuleFlag flag) { }

	// RVA: 0x21B6D5C Offset: 0x21B2D5C VA: 0x21B6D5C
	public bool CheckRule(RoomRuleFlag flag) { }

	// RVA: 0x21B6D6C Offset: 0x21B2D6C VA: 0x21B6D6C Slot: 21
	public virtual void OnGameEventLogin(GameEventLoginResponse login, short returnCode) { }

	// RVA: 0x21B6D70 Offset: 0x21B2D70 VA: 0x21B6D70 Slot: 22
	public virtual void OnGameRoomRejoin(IEnterAvatarPacket avatarData, GameReJoinResponse rejoin) { }

	// RVA: 0x21B6E70 Offset: 0x21B2E70 VA: 0x21B6E70 Slot: 23
	public virtual NewArchetypeProperties UpdatePlayerProperty(NewArchetypeProperties property) { }

	// RVA: 0x21B6E78 Offset: 0x21B2E78 VA: 0x21B6E78 Slot: 24
	public virtual void UpdatePlayerPropertyEnd(GameObject player, SkinnedMeshRenderer skin, PlayerAnimation animation, CharacterMove move) { }

	// RVA: 0x21B6E7C Offset: 0x21B2E7C VA: 0x21B6E7C Slot: 25
	public virtual bool TryGetManagementAvater(ArchetypeUid archetypeUid, out GameObject avater) { }

	// RVA: 0x21B6E9C Offset: 0x21B2E9C VA: 0x21B6E9C Slot: 26
	public virtual bool OnActionOtherMove(OtherPlayerActionManager otherPlayerActionManager, IMoveData eventData) { }

	// RVA: 0x21B6EA4 Offset: 0x21B2EA4 VA: 0x21B6EA4 Slot: 27
	public virtual void ReceiveUpdate(OperationResponse response) { }

	// RVA: 0x21B6EA8 Offset: 0x21B2EA8 VA: 0x21B6EA8 Slot: 28
	public virtual bool CheckTapPlayerRoom() { }

	// RVA: 0x21B6EB0 Offset: 0x21B2EB0 VA: 0x21B6EB0 Slot: 29
	public virtual bool CheckVisibleOtherPlayerRoom(Archetype archetype) { }

	// RVA: 0x21B6EB8 Offset: 0x21B2EB8 VA: 0x21B6EB8 Slot: 30
	public virtual bool OtherPlayerRoomListDataMove(ArchetypeUid archetypeUid, IMoveData moveEvent) { }

	// RVA: 0x21B6EC0 Offset: 0x21B2EC0 VA: 0x21B6EC0 Slot: 31
	public virtual bool OtherPlayerRoomListDataAction(ArchetypeActionEvent actionEvent) { }

	// RVA: 0x21B6EC8 Offset: 0x21B2EC8 VA: 0x21B6EC8 Slot: 32
	public virtual bool InitCameraUpdate(CameraManager manager) { }

	// RVA: 0x21B6ED0 Offset: 0x21B2ED0 VA: 0x21B6ED0 Slot: 33
	public virtual IEventResultPanel OpenResultPanel() { }

	// RVA: 0x21B6ED8 Offset: 0x21B2ED8 VA: 0x21B6ED8 Slot: 34
	public virtual void OnRoomWarpPosition(RoomWarpPositionResponse warpPosition) { }

	// RVA: 0x21B6EDC Offset: 0x21B2EDC VA: 0x21B6EDC Slot: 35
	public virtual bool PlayerInputMoveCheck() { }

	// RVA: 0x21B6EE4 Offset: 0x21B2EE4 VA: 0x21B6EE4 Slot: 36
	public virtual bool FieldScriptRoomEndCommand() { }

	// RVA: 0x21B6EEC Offset: 0x21B2EEC VA: 0x21B6EEC Slot: 37
	public virtual bool CheckRoomUniqueAction(RoomManager.RoomUniqueActionType type) { }

	// RVA: 0x21B6F4C Offset: 0x21B2F4C VA: 0x21B6F4C Slot: 38
	public virtual bool CheckShortcutLock() { }

	// RVA: 0x21B6F54 Offset: 0x21B2F54 VA: 0x21B6F54 Slot: 39
	public virtual UIActiveState OpenOtherMenu(UIActiveState state) { }
}

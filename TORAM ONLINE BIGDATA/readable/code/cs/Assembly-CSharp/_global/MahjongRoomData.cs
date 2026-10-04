// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MahjongRoomData : RoomDataBase // TypeDefIndex: 2381
{
	// Fields
	private MahjongController mahjongController; // 0x68
	private bool isHost; // 0x70
	private int roomId; // 0x74
	private MahjongMemberData[] memberDatas; // 0x78
	private MahjongRoomSettingData roomSettingData; // 0x80
	private List<int> kickOutRoomIds; // 0x88
	private bool isMatched; // 0x90
	private MahjongClientRoundData roundData; // 0x98
	private CameraManager cameraManager; // 0xA0
	private CameraMahjongController cameraMahjongController; // 0xA8
	private readonly Vector3 cameraStartPos; // 0xB0
	private readonly Vector3 cameraBack; // 0xBC
	private Vector3 cameraAngle; // 0xC8
	private bool isWaitOneFrame; // 0xD4
	private MahjongRoomData.WaitWinningTileData waitWinningTileData; // 0xD8
	public const int DrawWaitWinningTileListKey = -100;
	private byte usefulToolFlags; // 0xE0
	private const string PrefsDiscardTypeKey = "MahjongDiscardTypeKey";
	private MahjongRoomData.RightTopButtonType rightTopButtonType; // 0xE4
	private MahjongSettingData settingData; // 0xE8
	private Dictionary<int, long[]> voiceFlags; // 0xF0
	private Dictionary<int, long[]> localVoiceFlags; // 0xF8
	private MahjongTilesRenderer tilesRenderer; // 0x100
	private Material uiMahjongTileMaterial; // 0x108
	private MahjongSoundController soundController; // 0x110
	private bool isLoadRoom; // 0x118
	private bool isReconnecting; // 0x119
	private bool isCheckJoinRoom; // 0x11A
	private float waitTime; // 0x11C
	private const float UpdateRoomStateWaitTime = 5;
	private const string PrefsVoiceTypeKey = "MahjongVoiceTypeKey";
	private const string PrefsCameraFlagKey = "MahjongCameraFlagKey";
	private const string PrefsVoiceVolumeKey = "MahjongVoiceVolumeTypeKey";
	private const string PrefsVoiceFlagsKey = "MahjongVoiceFlagsKey";
	private const string PrefsTileLabelFlagKey = "MahjongTileLabelKey";
	[CompilerGenerated]
	private bool <InputLock>k__BackingField; // 0x120

	// Properties
	public MahjongController MainController { get; }
	public UIMahjongMainManager UIManager { get; }
	public Material UIMahjongTileMaterial { get; }
	public bool InputLock { get; set; }
	public bool IsHost { get; }
	public int MahjongRoomId { get; }
	public MahjongMemberData[] MemberDatas { get; }
	public MahjongRoomSettingData RoomSettingData { get; }
	public bool IsWaremeRule { get; }
	public bool IsPsiRule { get; }
	public bool IsMatched { get; }
	public MahjongClientRoundData RoundData { get; }
	public MahjongRoomData.WaitWinningTileData WinningTileData { get; }
	public byte UsefulToolFlags { get; }
	public bool AutoSorting { get; }
	public bool AutoWinning { get; }
	public bool AutoCallSkip { get; }
	public bool AutoTsumoDiscard { get; }
	public MahjongRoomData.RightTopButtonType ActiveRightTopButtonType { get; }
	public MahjongSettingData SettingData { get; }
	public Dictionary<int, long[]> VoiceFlags { get; }
	public Dictionary<int, long[]> LocalVoiceFlags { get; }
	public override byte RoomType { get; }
	public MahjongSoundController Sound { get; }
	public override string[] LoadAssetsPath { get; }

	// Methods

	// RVA: 0x219596C Offset: 0x219196C VA: 0x219596C
	public MahjongController get_MainController() { }

	// RVA: 0x2195B20 Offset: 0x2191B20 VA: 0x2195B20
	public UIMahjongMainManager get_UIManager() { }

	// RVA: 0x2195B3C Offset: 0x2191B3C VA: 0x2195B3C
	public Material get_UIMahjongTileMaterial() { }

	[CompilerGenerated]
	// RVA: 0x2195B44 Offset: 0x2191B44 VA: 0x2195B44
	public bool get_InputLock() { }

	[CompilerGenerated]
	// RVA: 0x2195B4C Offset: 0x2191B4C VA: 0x2195B4C
	private void set_InputLock(bool value) { }

	// RVA: 0x2195B58 Offset: 0x2191B58 VA: 0x2195B58
	public bool get_IsHost() { }

	// RVA: 0x2195B60 Offset: 0x2191B60 VA: 0x2195B60
	public int get_MahjongRoomId() { }

	// RVA: 0x2195B68 Offset: 0x2191B68 VA: 0x2195B68
	public MahjongMemberData[] get_MemberDatas() { }

	// RVA: 0x2195BB0 Offset: 0x2191BB0 VA: 0x2195BB0
	public MahjongRoomSettingData get_RoomSettingData() { }

	// RVA: 0x2195BB8 Offset: 0x2191BB8 VA: 0x2195BB8
	public bool get_IsWaremeRule() { }

	// RVA: 0x2195BD8 Offset: 0x2191BD8 VA: 0x2195BD8
	public bool get_IsPsiRule() { }

	// RVA: 0x2195BF8 Offset: 0x2191BF8 VA: 0x2195BF8
	public bool get_IsMatched() { }

	// RVA: 0x2195C00 Offset: 0x2191C00 VA: 0x2195C00
	public MahjongClientRoundData get_RoundData() { }

	// RVA: 0x2195C08 Offset: 0x2191C08 VA: 0x2195C08
	public MahjongRoomData.WaitWinningTileData get_WinningTileData() { }

	// RVA: 0x2195C10 Offset: 0x2191C10 VA: 0x2195C10
	public byte get_UsefulToolFlags() { }

	// RVA: 0x2195C18 Offset: 0x2191C18 VA: 0x2195C18
	public bool get_AutoSorting() { }

	// RVA: 0x2195C24 Offset: 0x2191C24 VA: 0x2195C24
	public bool get_AutoWinning() { }

	// RVA: 0x2195C30 Offset: 0x2191C30 VA: 0x2195C30
	public bool get_AutoCallSkip() { }

	// RVA: 0x2195C3C Offset: 0x2191C3C VA: 0x2195C3C
	public bool get_AutoTsumoDiscard() { }

	// RVA: 0x2195C48 Offset: 0x2191C48 VA: 0x2195C48
	public MahjongRoomData.RightTopButtonType get_ActiveRightTopButtonType() { }

	// RVA: 0x2195C50 Offset: 0x2191C50 VA: 0x2195C50
	public MahjongSettingData get_SettingData() { }

	// RVA: 0x2195C58 Offset: 0x2191C58 VA: 0x2195C58
	public Dictionary<int, long[]> get_VoiceFlags() { }

	// RVA: 0x2195C60 Offset: 0x2191C60 VA: 0x2195C60
	public Dictionary<int, long[]> get_LocalVoiceFlags() { }

	// RVA: 0x2195C68 Offset: 0x2191C68 VA: 0x2195C68 Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x2195C70 Offset: 0x2191C70 VA: 0x2195C70
	public MahjongSoundController get_Sound() { }

	// RVA: 0x2195C78 Offset: 0x2191C78 VA: 0x2195C78
	public void .ctor() { }

	// RVA: 0x2195DF0 Offset: 0x2191DF0 VA: 0x2195DF0 Slot: 18
	public override bool OnDead() { }

	// RVA: 0x2195DF8 Offset: 0x2191DF8 VA: 0x2195DF8 Slot: 12
	public override void Clear() { }

	// RVA: 0x2195F70 Offset: 0x2191F70 VA: 0x2195F70 Slot: 13
	public override void Enter() { }

	// RVA: 0x2196598 Offset: 0x2192598 VA: 0x2196598 Slot: 14
	public override void Leave() { }

	// RVA: 0x2196C94 Offset: 0x2192C94 VA: 0x2196C94 Slot: 5
	public override string[] get_LoadAssetsPath() { }

	// RVA: 0x2196D1C Offset: 0x2192D1C VA: 0x2196D1C Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x2196F80 Offset: 0x2192F80 VA: 0x2196F80 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x2196F84 Offset: 0x2192F84 VA: 0x2196F84 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x2196F88 Offset: 0x2192F88 VA: 0x2196F88 Slot: 15
	public override void Update() { }

	// RVA: 0x2197574 Offset: 0x2193574 VA: 0x2197574 Slot: 35
	public override bool PlayerInputMoveCheck() { }

	// RVA: 0x219757C Offset: 0x219357C VA: 0x219757C Slot: 28
	public override bool CheckTapPlayerRoom() { }

	// RVA: 0x21959E0 Offset: 0x21919E0 VA: 0x21959E0
	public void InstanceMahjongMainController() { }

	// RVA: 0x2197610 Offset: 0x2193610 VA: 0x2197610
	public void InstanceMahjongGMController() { }

	// RVA: 0x2197614 Offset: 0x2193614 VA: 0x2197614
	public void ChangeInputLockFlag(bool flag) { }

	// RVA: 0x2197620 Offset: 0x2193620 VA: 0x2197620
	public void ChangeUsefulToolFlag(byte flag) { }

	// RVA: 0x2197628 Offset: 0x2193628 VA: 0x2197628
	public void ChangeCameraAngle(Vector3 newAngle) { }

	// RVA: 0x2197634 Offset: 0x2193634 VA: 0x2197634
	public void ResetRoundData() { }

	// RVA: 0x2197640 Offset: 0x2193640 VA: 0x2197640
	public void UpdateVoiceFlags(int index, long[] flags) { }

	// RVA: 0x2196890 Offset: 0x2192890 VA: 0x2196890
	public void SaveMahjongSettings() { }

	// RVA: 0x21969A0 Offset: 0x21929A0 VA: 0x21969A0
	public void SaveMahjongVoiceFlags() { }

	// RVA: 0x2197760 Offset: 0x2193760 VA: 0x2197760
	public void CheckJoinRoomFlagToFlase() { }

	// RVA: 0x2197768 Offset: 0x2193768 VA: 0x2197768
	public void UpdateRoomDatas(MahjongMemberData[] memberDatas, int roomId, MahjongRoomSettingData roomSettingData, bool isMatched = False) { }

	// RVA: 0x2197B08 Offset: 0x2193B08 VA: 0x2197B08
	public void ResetRoomDatas() { }

	// RVA: 0x2197B3C Offset: 0x2193B3C VA: 0x2197B3C
	public void ChangeMatchedFlag(bool flag) { }

	// RVA: 0x2197930 Offset: 0x2193930 VA: 0x2197930
	public void UpdateRoomMember(MahjongMemberData[] memberDatas) { }

	// RVA: 0x2197B50 Offset: 0x2193B50 VA: 0x2197B50
	public void AddRoomMember(MahjongMemberData addMember) { }

	// RVA: 0x2197CEC Offset: 0x2193CEC VA: 0x2197CEC
	public void RemoveRoomMember(int ArchetypeId) { }

	// RVA: 0x2197F14 Offset: 0x2193F14 VA: 0x2197F14
	public void KickOut(int kickUserArchetypeId) { }

	// RVA: 0x2198044 Offset: 0x2194044 VA: 0x2198044
	public bool HasKickOutRoomId(int roomId) { }

	// RVA: 0x21981A8 Offset: 0x21941A8 VA: 0x21981A8
	public bool TryUpdateRoomMemberData(MahjongMemberData memberData) { }

	// RVA: 0x2198268 Offset: 0x2194268 VA: 0x2198268
	public void EnterUpdateVoiceType() { }

	// RVA: 0x2198404 Offset: 0x2194404 VA: 0x2198404
	public void GameStartCallBack() { }

	// RVA: 0x21984B0 Offset: 0x21944B0 VA: 0x21984B0
	public void UpdateWaitWinningTiles(bool drawTiming, MahjongTileData drawTile, bool isNonCalling = True) { }

	// RVA: 0x2198FEC Offset: 0x2194FEC VA: 0x2198FEC
	public void UpdateWaitWinningTileFuritenFlag(MahjongWaitWinningTile[] winTileIds, MahjongTileData addDiscardTile, bool isNonCalling) { }

	// RVA: 0x2199A38 Offset: 0x2195A38 VA: 0x2199A38
	public void UpdateWaitWinningTileNoRoleFlag(MahjongWaitWinningTile[] winTileids, bool isRiichiSelect, bool drawTiming, int discardTileUid) { }

	// RVA: 0x219A6D4 Offset: 0x21966D4 VA: 0x219A6D4
	public bool CheckDoraTile(int tileId, int harvestDanceTileId) { }

	// RVA: 0x219A8F8 Offset: 0x21968F8 VA: 0x219A8F8
	public bool CheckToAnkanWaitWinningTileDiff(MahjongTileData drawTile, int ankanTileId) { }

	// RVA: 0x219B5D4 Offset: 0x21975D4 VA: 0x219B5D4
	public void ChangeRightTopButtonType(MahjongRoomData.RightTopButtonType type) { }

	// RVA: 0x219B5DC Offset: 0x21975DC VA: 0x219B5DC
	public void ResponseNumError(short returnCode, byte operationSubCode) { }

	// RVA: 0x219B6B8 Offset: 0x21976B8 VA: 0x219B6B8
	public void ResponseError(MahjongErrorType.RoomErrorType errorType, byte operationSubCode) { }

	// RVA: 0x219B7B0 Offset: 0x21977B0 VA: 0x219B7B0
	public void ResponseError(MahjongErrorType.GameErrorType errorType, byte operationSubCode) { }

	// RVA: 0x219B8A8 Offset: 0x21978A8 VA: 0x219B8A8
	public void CreateRoom() { }

	// RVA: 0x219B984 Offset: 0x2197984 VA: 0x219B984
	public void LeaveMahjong() { }

	// RVA: 0x219BA60 Offset: 0x2197A60 VA: 0x219BA60
	public void JoinRoom(int roomId) { }

	// RVA: 0x219BB44 Offset: 0x2197B44 VA: 0x219BB44
	public void LeaveRoom(bool isAfterJoinRoom, int roomId) { }

	// RVA: 0x219BC58 Offset: 0x2197C58 VA: 0x219BC58
	public void RoomReady() { }

	// RVA: 0x219BD34 Offset: 0x2197D34 VA: 0x219BD34
	public void RoomReadyCancel() { }

	// RVA: 0x219BE10 Offset: 0x2197E10 VA: 0x219BE10
	public void KickOutMember(int archetypeId, Action callBack) { }

	// RVA: 0x219BF08 Offset: 0x2197F08 VA: 0x219BF08
	public void GameStart() { }

	// RVA: 0x219BFE4 Offset: 0x2197FE4 VA: 0x219BFE4
	public void ChangeRoomSetting(MahjongRoomSettingData settingData) { }

	// RVA: 0x2198340 Offset: 0x2194340 VA: 0x2198340
	public void ChangeMemberSetting(byte psiType, byte voiceId) { }

	// RVA: 0x219C0F8 Offset: 0x21980F8 VA: 0x219C0F8
	public void CheckJoinRoom() { }

	// RVA: 0x219C1A4 Offset: 0x21981A4 VA: 0x219C1A4
	public void MatchingStart() { }

	// RVA: 0x219C280 Offset: 0x2198280 VA: 0x219C280
	public void MatchingCancel() { }

	// RVA: 0x219C35C Offset: 0x219835C VA: 0x219C35C
	public void JoinAi() { }

	// RVA: 0x219C438 Offset: 0x2198438 VA: 0x219C438
	public void Game_Call(MahjongCallType callType, int[] myTileUidList) { }

	// RVA: 0x219C570 Offset: 0x2198570 VA: 0x219C570
	public void Game_Discard(int uid, bool isRiichi, bool isKyushukyuhai) { }

	// RVA: 0x219CB84 Offset: 0x2198B84 VA: 0x219CB84
	public void Game_RoundResultEnd() { }

	// RVA: 0x219CC6C Offset: 0x2198C6C VA: 0x219CC6C
	public void Game_Win(bool tsumo) { }

	// RVA: 0x219CD90 Offset: 0x2198D90 VA: 0x219CD90
	public void ChangeActiveGmPanel() { }

	// RVA: 0x219CD94 Offset: 0x2198D94 VA: 0x219CD94
	public void OnGmCommandComplete(UIMahjongGMManager.OperationType operationType) { }

	// RVA: 0x2197584 Offset: 0x2193584 VA: 0x2197584
	private MahjongController CreateMahjongManager() { }

	[CompilerGenerated]
	// RVA: 0x219CD98 Offset: 0x2198D98 VA: 0x219CD98
	private bool <EnterUpdateVoiceType>b__137_0(MahjongMemberData x) { }

	[CompilerGenerated]
	// RVA: 0x219CDCC Offset: 0x2198DCC VA: 0x219CDCC
	private bool <UpdateWaitWinningTileFuritenFlag>b__140_1(ValueTuple<int, int> x) { }
}

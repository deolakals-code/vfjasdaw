// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MiniGameLobbyRoomData : RoomDataBase // TypeDefIndex: 2385
{
	// Fields
	private MemberData[] membarData; // 0x68
	private double leftStartUpTime; // 0x70
	private double leftEndTime; // 0x78
	private float oldTime; // 0x80
	private bool isMatching; // 0x84
	private bool isMatched; // 0x85
	private bool isDoGameEnter; // 0x86
	private int battleCount; // 0x88
	private int waitingCount; // 0x8C
	private UISnowballFightManager uiSnowballManager; // 0x90

	// Properties
	public override byte RoomType { get; }
	public MemberData[] MemberData { get; }
	public MemberData MyData { get; }
	public double StartUpTime { get; }
	public double EndTime { get; }
	public bool IsMatching { get; }
	public bool IsMatched { get; }
	public int BattleCount { get; }
	public int WaitingCount { get; }

	// Methods

	// RVA: 0x219EE9C Offset: 0x219AE9C VA: 0x219EE9C Slot: 4
	public override byte get_RoomType() { }

	// RVA: 0x219EEA4 Offset: 0x219AEA4 VA: 0x219EEA4
	public MemberData[] get_MemberData() { }

	// RVA: 0x219EEAC Offset: 0x219AEAC VA: 0x219EEAC
	public MemberData get_MyData() { }

	// RVA: 0x219EF9C Offset: 0x219AF9C VA: 0x219EF9C
	public double get_StartUpTime() { }

	// RVA: 0x219F020 Offset: 0x219B020 VA: 0x219F020
	public double get_EndTime() { }

	// RVA: 0x219F0A4 Offset: 0x219B0A4 VA: 0x219F0A4
	public bool get_IsMatching() { }

	// RVA: 0x219F0AC Offset: 0x219B0AC VA: 0x219F0AC
	public bool get_IsMatched() { }

	// RVA: 0x219F0B4 Offset: 0x219B0B4 VA: 0x219F0B4
	public int get_BattleCount() { }

	// RVA: 0x219F0BC Offset: 0x219B0BC VA: 0x219F0BC
	public int get_WaitingCount() { }

	// RVA: 0x219F0C4 Offset: 0x219B0C4 VA: 0x219F0C4
	public void .ctor() { }

	// RVA: 0x219F1D4 Offset: 0x219B1D4 VA: 0x219F1D4
	public void Destroy() { }

	// RVA: 0x219F1D8 Offset: 0x219B1D8 VA: 0x219F1D8
	public void Initialize(MiniGameLobbyJoinResponse response) { }

	// RVA: 0x219F4E8 Offset: 0x219B4E8 VA: 0x219F4E8
	public void GameEnd() { }

	// RVA: 0x219F320 Offset: 0x219B320 VA: 0x219F320
	public void UpdateMemberData(MemberData[] team) { }

	// RVA: 0x219F538 Offset: 0x219B538 VA: 0x219F538
	public void ServerUpdateTimer(long leftStartUpTime, long leftEndTime) { }

	// RVA: 0x219F548 Offset: 0x219B548 VA: 0x219F548
	public void UpdateTimer() { }

	// RVA: 0x219F604 Offset: 0x219B604 VA: 0x219F604
	public void OnLobbyJoin(MiniGameLobbyJoinResponse response) { }

	// RVA: 0x219F608 Offset: 0x219B608 VA: 0x219F608
	public void OnLobbyReady(MiniGameLobbyReadyResponse response) { }

	// RVA: 0x219F630 Offset: 0x219B630 VA: 0x219F630
	public void OnLobbyReadyCancel(MiniGameLobbyReadyCancelResponse response) { }

	// RVA: 0x219F658 Offset: 0x219B658 VA: 0x219F658
	public void OnStartMatching(MiniGameLobbyMatchingEvent eventData) { }

	// RVA: 0x219F678 Offset: 0x219B678 VA: 0x219F678
	public void OnLobbyMemberState(MiniGameLobbyMemberStateEvent response) { }

	// RVA: 0x219F938 Offset: 0x219B938 VA: 0x219F938
	public void OnLobbyMatched(MiniGameLobbyMatchedEvent response) { }

	// RVA: 0x219F9B4 Offset: 0x219B9B4 VA: 0x219F9B4
	public void OnLobbyMatchingTimeout(MiniGameMatchingTimeoutEvent response) { }

	// RVA: 0x219FB28 Offset: 0x219BB28 VA: 0x219FB28
	public void OnEventMiniGameMatchingState(MiniGameMatchingStateEvent eventData) { }

	// RVA: 0x219FB48 Offset: 0x219BB48 VA: 0x219FB48
	public bool IsMyTeam(int archetypeId) { }

	// RVA: 0x219FC3C Offset: 0x219BC3C VA: 0x219FC3C
	public MemberData GetTeamMemberData(int archetypeId) { }

	// RVA: 0x219FD30 Offset: 0x219BD30 VA: 0x219FD30 Slot: 12
	public override void Clear() { }

	// RVA: 0x219FD34 Offset: 0x219BD34 VA: 0x219FD34 Slot: 13
	public override void Enter() { }

	// RVA: 0x219FE50 Offset: 0x219BE50 VA: 0x219FE50 Slot: 14
	public override void Leave() { }

	// RVA: 0x219FF10 Offset: 0x219BF10 VA: 0x219FF10 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x219FF14 Offset: 0x219BF14 VA: 0x219FF14 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x219FF18 Offset: 0x219BF18 VA: 0x219FF18 Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x219FF1C Offset: 0x219BF1C VA: 0x219FF1C Slot: 15
	public override void Update() { }

	// RVA: 0x21A000C Offset: 0x219C00C VA: 0x21A000C Slot: 23
	public override NewArchetypeProperties UpdatePlayerProperty(NewArchetypeProperties property) { }

	// RVA: 0x21A0028 Offset: 0x219C028 VA: 0x21A0028 Slot: 32
	public override bool InitCameraUpdate(CameraManager manager) { }

	// RVA: 0x219F74C Offset: 0x219B74C VA: 0x219F74C
	private bool CheckChangeMemberState() { }

	[CompilerGenerated]
	// RVA: 0x21A0090 Offset: 0x219C090 VA: 0x21A0090
	private bool <get_MyData>b__15_0(MemberData x) { }
}

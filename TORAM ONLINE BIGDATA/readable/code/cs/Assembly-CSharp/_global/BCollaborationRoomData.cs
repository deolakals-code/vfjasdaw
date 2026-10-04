// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BCollaborationRoomData : RoomDataBase // TypeDefIndex: 2306
{
	// Fields
	[CompilerGenerated]
	private int <BossCheckConnect>k__BackingField; // 0x64
	[CompilerGenerated]
	private int <NextResetTimeLeft>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <IsMatching>k__BackingField; // 0x6C
	[CompilerGenerated]
	private float <MatchingTimer>k__BackingField; // 0x70
	[CompilerGenerated]
	private short <StartHpCount>k__BackingField; // 0x74
	[CompilerGenerated]
	private short <CurrentHpCount>k__BackingField; // 0x76
	[CompilerGenerated]
	private short <MaxHpNum>k__BackingField; // 0x78
	[CompilerGenerated]
	private int <DifficultyState>k__BackingField; // 0x7C
	[CompilerGenerated]
	private bool <IsUserMatchingSettingFlag>k__BackingField; // 0x80
	private BossResultData bossResultData; // 0x88
	private BCollaborationGameEndEvent endEvent; // 0x90
	private long leftTime; // 0x98
	private byte endType; // 0xA0
	private float startTimer; // 0xA4
	private bool entreeFlag; // 0xA8
	private float updateTime; // 0xAC
	private bool isEndBattleEvent; // 0xB0
	private readonly int endScriptId; // 0xB4

	// Properties
	public override byte RoomType { get; }
	public int BossCheckConnect { get; set; }
	public int NextResetTimeLeft { get; set; }
	public bool IsMatching { get; set; }
	public float MatchingTimer { get; set; }
	public short StartHpCount { get; set; }
	public short CurrentHpCount { get; set; }
	public short MaxHpNum { get; set; }
	public BossResultData BossResultData { get; }
	public int DifficultyState { get; set; }
	public override short AreaLevel { get; }
	public BCollaborationGameEndEvent EndEventData { get; }
	public bool IsGameEnd { get; }
	public float LeftTime { get; }
	public bool IsUserMatchingSettingFlag { get; set; }

	// Methods

	// RVA: 0x217D81C Offset: 0x217981C VA: 0x217D81C Slot: 4
	public override byte get_RoomType() { }

	[CompilerGenerated]
	// RVA: 0x217D824 Offset: 0x2179824 VA: 0x217D824
	public int get_BossCheckConnect() { }

	[CompilerGenerated]
	// RVA: 0x217D82C Offset: 0x217982C VA: 0x217D82C
	private void set_BossCheckConnect(int value) { }

	[CompilerGenerated]
	// RVA: 0x217D834 Offset: 0x2179834 VA: 0x217D834
	public int get_NextResetTimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x217D83C Offset: 0x217983C VA: 0x217D83C
	private void set_NextResetTimeLeft(int value) { }

	[CompilerGenerated]
	// RVA: 0x217D844 Offset: 0x2179844 VA: 0x217D844
	private void set_IsMatching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x217D850 Offset: 0x2179850 VA: 0x217D850
	public bool get_IsMatching() { }

	[CompilerGenerated]
	// RVA: 0x217D858 Offset: 0x2179858 VA: 0x217D858
	private void set_MatchingTimer(float value) { }

	[CompilerGenerated]
	// RVA: 0x217D860 Offset: 0x2179860 VA: 0x217D860
	public float get_MatchingTimer() { }

	[CompilerGenerated]
	// RVA: 0x217D868 Offset: 0x2179868 VA: 0x217D868
	public short get_StartHpCount() { }

	[CompilerGenerated]
	// RVA: 0x217D870 Offset: 0x2179870 VA: 0x217D870
	private void set_StartHpCount(short value) { }

	[CompilerGenerated]
	// RVA: 0x217D878 Offset: 0x2179878 VA: 0x217D878
	public short get_CurrentHpCount() { }

	[CompilerGenerated]
	// RVA: 0x217D880 Offset: 0x2179880 VA: 0x217D880
	private void set_CurrentHpCount(short value) { }

	[CompilerGenerated]
	// RVA: 0x217D888 Offset: 0x2179888 VA: 0x217D888
	public short get_MaxHpNum() { }

	[CompilerGenerated]
	// RVA: 0x217D890 Offset: 0x2179890 VA: 0x217D890
	private void set_MaxHpNum(short value) { }

	// RVA: 0x217D898 Offset: 0x2179898 VA: 0x217D898
	public BossResultData get_BossResultData() { }

	[CompilerGenerated]
	// RVA: 0x217D8A0 Offset: 0x21798A0 VA: 0x217D8A0
	public int get_DifficultyState() { }

	[CompilerGenerated]
	// RVA: 0x217D8A8 Offset: 0x21798A8 VA: 0x217D8A8
	private void set_DifficultyState(int value) { }

	// RVA: 0x217D8B0 Offset: 0x21798B0 VA: 0x217D8B0 Slot: 7
	public override short get_AreaLevel() { }

	// RVA: 0x217D980 Offset: 0x2179980 VA: 0x217D980
	public BCollaborationGameEndEvent get_EndEventData() { }

	// RVA: 0x217D988 Offset: 0x2179988 VA: 0x217D988
	public bool get_IsGameEnd() { }

	// RVA: 0x217D998 Offset: 0x2179998 VA: 0x217D998
	public float get_LeftTime() { }

	[CompilerGenerated]
	// RVA: 0x217D9DC Offset: 0x21799DC VA: 0x217D9DC
	private void set_IsUserMatchingSettingFlag(bool value) { }

	[CompilerGenerated]
	// RVA: 0x217D9E8 Offset: 0x21799E8 VA: 0x217D9E8
	public bool get_IsUserMatchingSettingFlag() { }

	// RVA: 0x217D9F0 Offset: 0x21799F0 VA: 0x217D9F0
	public void .ctor() { }

	// RVA: 0x217DBD8 Offset: 0x2179BD8 VA: 0x217DBD8 Slot: 12
	public override void Clear() { }

	// RVA: 0x217DC2C Offset: 0x2179C2C VA: 0x217DC2C Slot: 13
	public override void Enter() { }

	// RVA: 0x217DD00 Offset: 0x2179D00 VA: 0x217DD00 Slot: 14
	public override void Leave() { }

	// RVA: 0x217DD64 Offset: 0x2179D64 VA: 0x217DD64 Slot: 16
	public override void LoadAsset() { }

	// RVA: 0x217DD68 Offset: 0x2179D68 VA: 0x217DD68 Slot: 17
	public override void OnAnnihilated(RoomAnnihilatedEvent annihilatedEvent) { }

	// RVA: 0x217DD6C Offset: 0x2179D6C VA: 0x217DD6C Slot: 10
	public override void OnFailure(byte operationCode, short returnCode) { }

	// RVA: 0x217DD84 Offset: 0x2179D84 VA: 0x217DD84 Slot: 11
	public override void OnFailure(byte operationCode, byte subCode, short returnCode) { }

	// RVA: 0x217DE24 Offset: 0x2179E24 VA: 0x217DE24 Slot: 15
	public override void Update() { }

	// RVA: 0x217DFB4 Offset: 0x2179FB4 VA: 0x217DFB4 Slot: 19
	public override void RoomSynchronization(RoomSynchronizationEvent syncEvent) { }

	// RVA: 0x217E0C8 Offset: 0x217A0C8 VA: 0x217E0C8
	public void CheckRoom() { }

	// RVA: 0x217E19C Offset: 0x217A19C VA: 0x217E19C
	public void MatchingStart() { }

	// RVA: 0x217E270 Offset: 0x217A270 VA: 0x217E270
	public void LobbyBattleJoin() { }

	// RVA: 0x217E350 Offset: 0x217A350 VA: 0x217E350
	public void LobbyJoin() { }

	// RVA: 0x217E3E0 Offset: 0x217A3E0 VA: 0x217E3E0
	public void LobbyJoinCancel() { }

	// RVA: 0x217E470 Offset: 0x217A470 VA: 0x217E470
	public void LobbyLeave() { }

	// RVA: 0x217E500 Offset: 0x217A500 VA: 0x217E500
	public void LobbyState() { }

	// RVA: 0x217E5D4 Offset: 0x217A5D4 VA: 0x217E5D4
	public void MatchingChange(bool partyLinkFlag) { }

	// RVA: 0x217E6AC Offset: 0x217A6AC VA: 0x217E6AC
	public void OnStartEvent(BCollaborationGameStartEvent startEvent) { }

	// RVA: 0x217E6DC Offset: 0x217A6DC VA: 0x217E6DC
	public void OnEndResultData(BCollaborationGameEndEvent endEvent) { }

	// RVA: 0x217E800 Offset: 0x217A800 VA: 0x217E800
	public void OnStartMatchingEvent(int matchingTimer) { }

	// RVA: 0x217E810 Offset: 0x217A810 VA: 0x217E810
	public void SetStartHpCount(byte hpCount) { }

	// RVA: 0x217E81C Offset: 0x217A81C VA: 0x217E81C
	public void SetCurrentHpCount(byte hpCount) { }

	// RVA: 0x217E828 Offset: 0x217A828 VA: 0x217E828
	public void ReceiveBossResultData(BossResultData data, int[] points) { }

	// RVA: 0x217E88C Offset: 0x217A88C VA: 0x217E88C
	public void UpdateUserMatchingFlag(bool isFlag) { }
}

// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaDataManager // TypeDefIndex: 1407
{
	// Fields
	[CompilerGenerated]
	private MobaProfileData <ProfileData>k__BackingField; // 0x10
	[CompilerGenerated]
	private MobaGameData[] <HoldGames>k__BackingField; // 0x18
	[CompilerGenerated]
	private MobaJoinGameData <JoinGame>k__BackingField; // 0x20
	[CompilerGenerated]
	private MobaProgressStateType <ProgressState>k__BackingField; // 0x28
	[CompilerGenerated]
	private MobaPartyStateEvent <PartyState>k__BackingField; // 0x30
	[CompilerGenerated]
	private TimeSpan <NextPartyGameTime>k__BackingField; // 0x38
	private UIMobaLobbyMatchingPanel mobaLobbyPanel; // 0x40
	private PlayerDataManager playerDataManager; // 0x48

	// Properties
	public MobaProfileData ProfileData { get; set; }
	public UIMobaLobbyMatchingPanel MobaLobbyPanel { get; }
	public MobaGameData[] HoldGames { get; set; }
	public MobaJoinGameData JoinGame { get; set; }
	public MobaProgressStateType ProgressState { get; set; }
	public MobaPartyStateEvent PartyState { get; set; }
	public TimeSpan NextPartyGameTime { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1FE7E44 Offset: 0x1FE3E44 VA: 0x1FE7E44
	public MobaProfileData get_ProfileData() { }

	[CompilerGenerated]
	// RVA: 0x1FE7E4C Offset: 0x1FE3E4C VA: 0x1FE7E4C
	private void set_ProfileData(MobaProfileData value) { }

	// RVA: 0x1FE7E54 Offset: 0x1FE3E54 VA: 0x1FE7E54
	public UIMobaLobbyMatchingPanel get_MobaLobbyPanel() { }

	[CompilerGenerated]
	// RVA: 0x1FE7E5C Offset: 0x1FE3E5C VA: 0x1FE7E5C
	public MobaGameData[] get_HoldGames() { }

	[CompilerGenerated]
	// RVA: 0x1FE7E64 Offset: 0x1FE3E64 VA: 0x1FE7E64
	private void set_HoldGames(MobaGameData[] value) { }

	[CompilerGenerated]
	// RVA: 0x1FE7E6C Offset: 0x1FE3E6C VA: 0x1FE7E6C
	public MobaJoinGameData get_JoinGame() { }

	[CompilerGenerated]
	// RVA: 0x1FE7E74 Offset: 0x1FE3E74 VA: 0x1FE7E74
	private void set_JoinGame(MobaJoinGameData value) { }

	[CompilerGenerated]
	// RVA: 0x1FE7E7C Offset: 0x1FE3E7C VA: 0x1FE7E7C
	public MobaProgressStateType get_ProgressState() { }

	[CompilerGenerated]
	// RVA: 0x1FE7E84 Offset: 0x1FE3E84 VA: 0x1FE7E84
	private void set_ProgressState(MobaProgressStateType value) { }

	[CompilerGenerated]
	// RVA: 0x1FE7E8C Offset: 0x1FE3E8C VA: 0x1FE7E8C
	public MobaPartyStateEvent get_PartyState() { }

	[CompilerGenerated]
	// RVA: 0x1FE7E94 Offset: 0x1FE3E94 VA: 0x1FE7E94
	private void set_PartyState(MobaPartyStateEvent value) { }

	[CompilerGenerated]
	// RVA: 0x1FE7E9C Offset: 0x1FE3E9C VA: 0x1FE7E9C
	public TimeSpan get_NextPartyGameTime() { }

	[CompilerGenerated]
	// RVA: 0x1FE7EA4 Offset: 0x1FE3EA4 VA: 0x1FE7EA4
	private void set_NextPartyGameTime(TimeSpan value) { }

	// RVA: 0x1FE7EAC Offset: 0x1FE3EAC VA: 0x1FE7EAC
	public void .ctor(PlayerDataManager playerDataManager) { }

	// RVA: 0x1FE7EEC Offset: 0x1FE3EEC VA: 0x1FE7EEC
	public void CreateMobaLobbyPanel() { }

	// RVA: 0x1FE80A0 Offset: 0x1FE40A0 VA: 0x1FE80A0
	public void UpdateWaitNum() { }

	// RVA: 0x1FE81AC Offset: 0x1FE41AC VA: 0x1FE81AC
	public bool TryGetHoldGameId(MobaRuleType type, out byte gameId) { }

	// RVA: 0x1FE82A8 Offset: 0x1FE42A8 VA: 0x1FE82A8
	public bool CheckPartyHoldGame() { }

	// RVA: 0x1FE83BC Offset: 0x1FE43BC VA: 0x1FE83BC
	public bool CheckHoldGame(MobaRuleType type) { }

	// RVA: 0x1FE84A8 Offset: 0x1FE44A8 VA: 0x1FE84A8
	public void Enter() { }

	// RVA: 0x1FE84F8 Offset: 0x1FE44F8 VA: 0x1FE84F8
	public void Leave() { }

	// RVA: 0x1FE85F0 Offset: 0x1FE45F0 VA: 0x1FE85F0
	public void UpdateHoldGames(MobaGameData[] holdGames) { }

	// RVA: 0x1FE876C Offset: 0x1FE476C VA: 0x1FE876C
	public void SetPartyState(MobaPartyStateEvent state) { }

	// RVA: 0x1FE85E4 Offset: 0x1FE45E4 VA: 0x1FE85E4
	public void ResetPartyState() { }

	// RVA: 0x1FE8774 Offset: 0x1FE4774 VA: 0x1FE8774
	public bool TryGetPartyMemberState(int id, out byte state) { }

	// RVA: 0x1FE882C Offset: 0x1FE482C VA: 0x1FE882C
	public bool CheckPartyLeaderReady() { }

	// RVA: 0x1FE86F0 Offset: 0x1FE46F0 VA: 0x1FE86F0
	public bool CheckMatchingState() { }

	// RVA: 0x1FE88E8 Offset: 0x1FE48E8 VA: 0x1FE88E8
	public void UpdateNextPartyGameTime(TimeSpan time) { }

	// RVA: 0x1FE890C Offset: 0x1FE490C VA: 0x1FE890C
	public static bool IsMobaNoEntry() { }

	// RVA: 0x1FE8974 Offset: 0x1FE4974 VA: 0x1FE8974
	public static bool IsMobaNoCasual() { }

	// RVA: 0x1FE89DC Offset: 0x1FE49DC VA: 0x1FE89DC
	public static bool IsMobaNoRanking() { }

	// RVA: 0x1FE8A44 Offset: 0x1FE4A44 VA: 0x1FE8A44
	public static bool IsMobaNoOneGame() { }

	// RVA: 0x1FE8AAC Offset: 0x1FE4AAC VA: 0x1FE8AAC
	public static bool IsMobaNoFourGame() { }

	// RVA: 0x1FE8B14 Offset: 0x1FE4B14 VA: 0x1FE8B14
	public void GetProfile() { }

	// RVA: 0x1FE8D0C Offset: 0x1FE4D0C VA: 0x1FE8D0C
	public void SaveProfile(MobaProfileData data) { }

	// RVA: 0x1FE8E04 Offset: 0x1FE4E04 VA: 0x1FE8E04
	public void StartMatching(byte gameId) { }

	// RVA: 0x1FE8EC0 Offset: 0x1FE4EC0 VA: 0x1FE8EC0
	public void CancelMatching() { }

	// RVA: 0x1FE8F68 Offset: 0x1FE4F68 VA: 0x1FE8F68
	public void JoinLobby() { }

	// RVA: 0x1FE900C Offset: 0x1FE500C VA: 0x1FE900C
	public void CheckStatus() { }

	// RVA: 0x1FE90F8 Offset: 0x1FE50F8 VA: 0x1FE90F8
	public void PartySelect(byte gameId) { }

	// RVA: 0x1FE91B4 Offset: 0x1FE51B4 VA: 0x1FE91B4
	public void PartyReady() { }

	// RVA: 0x1FE933C Offset: 0x1FE533C VA: 0x1FE933C
	public void PartyReadyCancel() { }

	// RVA: 0x1FE941C Offset: 0x1FE541C VA: 0x1FE941C
	public void PartyCancel() { }

	// RVA: 0x1FE8BB8 Offset: 0x1FE4BB8 VA: 0x1FE8BB8
	private bool CheckConditions() { }

	// RVA: 0x1FE92FC Offset: 0x1FE52FC VA: 0x1FE92FC
	private bool TryGetPartyGameId(out byte partyGameId) { }

	[CompilerGenerated]
	// RVA: 0x1FE94FC Offset: 0x1FE54FC VA: 0x1FE94FC
	private bool <UpdateHoldGames>b__46_0(MobaGameData x) { }
}

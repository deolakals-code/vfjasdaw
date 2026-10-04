// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi
public class DummyClient : IPlayGamesClient // TypeDefIndex: 16825
{
	// Methods

	// RVA: 0x2E3262C Offset: 0x2E2E62C VA: 0x2E3262C Slot: 4
	public void Authenticate(Action<SignInStatus> callback) { }

	// RVA: 0x2E326C4 Offset: 0x2E2E6C4 VA: 0x2E326C4 Slot: 5
	public void ManuallyAuthenticate(Action<SignInStatus> callback) { }

	// RVA: 0x2E326F4 Offset: 0x2E2E6F4 VA: 0x2E326F4 Slot: 6
	public bool IsAuthenticated() { }

	// RVA: 0x2E32708 Offset: 0x2E2E708 VA: 0x2E32708 Slot: 7
	public void RequestServerSideAccess(bool forceRefreshToken, Action<string> callback) { }

	// RVA: 0x2E32738 Offset: 0x2E2E738 VA: 0x2E32738 Slot: 8
	public void RequestServerSideAccess(bool forceRefreshToken, List<AuthScope> scopes, Action<AuthResponse> callback) { }

	// RVA: 0x2E32768 Offset: 0x2E2E768 VA: 0x2E32768 Slot: 9
	public void RequestRecallAccessToken(Action<RecallAccess> callback) { }

	// RVA: 0x2E32798 Offset: 0x2E2E798 VA: 0x2E32798 Slot: 10
	public string GetUserId() { }

	// RVA: 0x2E327DC Offset: 0x2E2E7DC VA: 0x2E327DC Slot: 14
	public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback) { }

	// RVA: 0x2E32870 Offset: 0x2E2E870 VA: 0x2E32870 Slot: 12
	public string GetUserDisplayName() { }

	// RVA: 0x2E328B4 Offset: 0x2E2E8B4 VA: 0x2E328B4 Slot: 13
	public string GetUserImageUrl() { }

	// RVA: 0x2E328C8 Offset: 0x2E2E8C8 VA: 0x2E328C8 Slot: 15
	public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback) { }

	// RVA: 0x2E328F8 Offset: 0x2E2E8F8 VA: 0x2E328F8 Slot: 16
	public void LoadAchievements(Action<Achievement[]> callback) { }

	// RVA: 0x2E32928 Offset: 0x2E2E928 VA: 0x2E32928 Slot: 17
	public void UnlockAchievement(string achId, Action<bool> callback) { }

	// RVA: 0x2E32958 Offset: 0x2E2E958 VA: 0x2E32958 Slot: 18
	public void RevealAchievement(string achId, Action<bool> callback) { }

	// RVA: 0x2E32988 Offset: 0x2E2E988 VA: 0x2E32988 Slot: 19
	public void IncrementAchievement(string achId, int steps, Action<bool> callback) { }

	// RVA: 0x2E329B8 Offset: 0x2E2E9B8 VA: 0x2E329B8 Slot: 20
	public void SetStepsAtLeast(string achId, int steps, Action<bool> callback) { }

	// RVA: 0x2E329E8 Offset: 0x2E2E9E8 VA: 0x2E329E8 Slot: 21
	public void ShowAchievementsUI(Action<UIStatus> callback) { }

	// RVA: 0x2E32A18 Offset: 0x2E2EA18 VA: 0x2E32A18 Slot: 22
	public void AskForLoadFriendsResolution(Action<UIStatus> callback) { }

	// RVA: 0x2E32A48 Offset: 0x2E2EA48 VA: 0x2E32A48 Slot: 23
	public LoadFriendsStatus GetLastLoadFriendsStatus() { }

	// RVA: 0x2E32A5C Offset: 0x2E2EA5C VA: 0x2E32A5C Slot: 26
	public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback) { }

	// RVA: 0x2E32A8C Offset: 0x2E2EA8C VA: 0x2E32A8C Slot: 27
	public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback) { }

	// RVA: 0x2E32ABC Offset: 0x2E2EABC VA: 0x2E32ABC Slot: 24
	public void ShowCompareProfileWithAlternativeNameHintsUI(string userId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback) { }

	// RVA: 0x2E32AEC Offset: 0x2E2EAEC VA: 0x2E32AEC Slot: 25
	public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback) { }

	// RVA: 0x2E32B1C Offset: 0x2E2EB1C VA: 0x2E32B1C Slot: 28
	public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback) { }

	// RVA: 0x2E32B4C Offset: 0x2E2EB4C VA: 0x2E32B4C Slot: 31
	public int LeaderboardMaxResults() { }

	// RVA: 0x2E32B54 Offset: 0x2E2EB54 VA: 0x2E32B54 Slot: 29
	public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback) { }

	// RVA: 0x2E32C84 Offset: 0x2E2EC84 VA: 0x2E32C84 Slot: 30
	public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback) { }

	// RVA: 0x2E32D10 Offset: 0x2E2ED10 VA: 0x2E32D10 Slot: 32
	public void SubmitScore(string leaderboardId, long score, Action<bool> callback) { }

	// RVA: 0x2E32D40 Offset: 0x2E2ED40 VA: 0x2E32D40 Slot: 33
	public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback) { }

	// RVA: 0x2E32D70 Offset: 0x2E2ED70 VA: 0x2E32D70 Slot: 34
	public ISavedGameClient GetSavedGameClient() { }

	// RVA: 0x2E32D84 Offset: 0x2E2ED84 VA: 0x2E32D84 Slot: 35
	public IEventsClient GetEventsClient() { }

	// RVA: 0x2E32D98 Offset: 0x2E2ED98 VA: 0x2E32D98 Slot: 11
	public void LoadFriends(Action<bool> callback) { }

	// RVA: 0x2E32DC4 Offset: 0x2E2EDC4 VA: 0x2E32DC4 Slot: 36
	public IUserProfile[] GetFriends() { }

	// RVA: 0x2E3265C Offset: 0x2E2E65C VA: 0x2E3265C
	private static void LogUsage() { }

	// RVA: 0x2E32E0C Offset: 0x2E2EE0C VA: 0x2E32E0C
	public void .ctor() { }
}

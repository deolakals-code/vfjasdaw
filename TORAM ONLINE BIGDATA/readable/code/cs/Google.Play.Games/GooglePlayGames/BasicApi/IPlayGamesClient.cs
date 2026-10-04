// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi
public interface IPlayGamesClient // TypeDefIndex: 16826
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Authenticate(Action<SignInStatus> callback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ManuallyAuthenticate(Action<SignInStatus> callback);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsAuthenticated();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void RequestServerSideAccess(bool forceRefreshToken, Action<string> callback);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RequestServerSideAccess(bool forceRefreshToken, List<AuthScope> scopes, Action<AuthResponse> callback);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RequestRecallAccessToken(Action<RecallAccess> callback);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string GetUserId();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void LoadFriends(Action<bool> callback);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string GetUserDisplayName();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string GetUserImageUrl();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void LoadUsers(string[] userIds, Action<IUserProfile[]> callback);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void LoadAchievements(Action<Achievement[]> callback);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void UnlockAchievement(string achievementId, Action<bool> successOrFailureCalllback);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void RevealAchievement(string achievementId, Action<bool> successOrFailureCalllback);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void IncrementAchievement(string achievementId, int steps, Action<bool> successOrFailureCalllback);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void SetStepsAtLeast(string achId, int steps, Action<bool> callback);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void ShowAchievementsUI(Action<UIStatus> callback);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void AskForLoadFriendsResolution(Action<UIStatus> callback);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract LoadFriendsStatus GetLastLoadFriendsStatus();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ShowCompareProfileWithAlternativeNameHintsUI(string otherUserId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract int LeaderboardMaxResults();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void SubmitScore(string leaderboardId, long score, Action<bool> successOrFailureCalllback);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> successOrFailureCalllback);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract ISavedGameClient GetSavedGameClient();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract IEventsClient GetEventsClient();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract IUserProfile[] GetFriends();
}

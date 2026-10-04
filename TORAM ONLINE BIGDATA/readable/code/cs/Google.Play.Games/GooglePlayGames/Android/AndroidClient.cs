// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.Android
public class AndroidClient : IPlayGamesClient // TypeDefIndex: 16754
{
	// Fields
	private readonly object GameServicesLock; // 0x10
	private readonly object AuthStateLock; // 0x18
	private static readonly string PlayGamesSdkClassName; // 0x0
	private ISavedGameClient mSavedGameClient; // 0x20
	private IEventsClient mEventsClient; // 0x28
	private Player mUser; // 0x30
	private AndroidClient.AuthState mAuthState; // 0x38
	private IUserProfile[] mFriends; // 0x40
	private LoadFriendsStatus mLastLoadFriendsStatus; // 0x48
	private AndroidJavaClass mGamesClass; // 0x50
	private static string TasksClassName; // 0x8
	private AndroidJavaObject mFriendsResolutionException; // 0x58
	private readonly int mLeaderboardMaxResults; // 0x60
	private readonly int mFriendsMaxResults; // 0x64

	// Methods

	// RVA: 0x2E0FDC4 Offset: 0x2E0BDC4 VA: 0x2E0FDC4
	internal void .ctor() { }

	// RVA: 0x2E10128 Offset: 0x2E0C128 VA: 0x2E10128
	private static void InitializeSdk() { }

	// RVA: 0x2E1055C Offset: 0x2E0C55C VA: 0x2E1055C Slot: 4
	public void Authenticate(Action<SignInStatus> callback) { }

	// RVA: 0x2E10BAC Offset: 0x2E0CBAC VA: 0x2E10BAC Slot: 5
	public void ManuallyAuthenticate(Action<SignInStatus> callback) { }

	// RVA: 0x2E10568 Offset: 0x2E0C568 VA: 0x2E10568
	private void Authenticate(bool isAutoSignIn, Action<SignInStatus> callback) { }

	// RVA: 0x2E10E30 Offset: 0x2E0CE30 VA: 0x2E10E30
	private void SignInOnResult(bool isAuthenticated, Action<SignInStatus> callback) { }

	// RVA: 0x2E11804 Offset: 0x2E0D804 VA: 0x2E11804 Slot: 7
	public void RequestServerSideAccess(bool forceRefreshToken, Action<string> callback) { }

	// RVA: 0x2E11DA0 Offset: 0x2E0DDA0 VA: 0x2E11DA0 Slot: 8
	public void RequestServerSideAccess(bool forceRefreshToken, List<AuthScope> scopes, Action<AuthResponse> callback) { }

	// RVA: 0x2E1279C Offset: 0x2E0E79C VA: 0x2E1279C
	private AuthResponse ToAuthResponse(AndroidJavaObject result) { }

	// RVA: 0x2E12644 Offset: 0x2E0E644 VA: 0x2E12644
	private AndroidJavaObject getJavaScopeEnum(AuthScope scope) { }

	// RVA: 0x2E12EB0 Offset: 0x2E0EEB0 VA: 0x2E12EB0 Slot: 9
	public void RequestRecallAccessToken(Action<RecallAccess> callback) { }

	// RVA: -1 Offset: -1
	private static Action<T> AsOnGameThreadCallback<T>(Action<T> callback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2689858 Offset: 0x2685858 VA: 0x2689858
	|-AndroidClient.AsOnGameThreadCallback<Int32Enum>
	|
	|-RVA: 0x2689A00 Offset: 0x2685A00 VA: 0x2689A00
	|-AndroidClient.AsOnGameThreadCallback<object>
	|
	|-RVA: 0x2689BA8 Offset: 0x2685BA8 VA: 0x2689BA8
	|-AndroidClient.AsOnGameThreadCallback<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E1340C Offset: 0x2E0F40C VA: 0x2E1340C
	private static void InvokeCallbackOnGameThread(Action callback) { }

	// RVA: -1 Offset: -1
	private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2689E00 Offset: 0x2685E00 VA: 0x2689E00
	|-AndroidClient.InvokeCallbackOnGameThread<bool>
	|
	|-RVA: 0x2689F04 Offset: 0x2685F04 VA: 0x2689F04
	|-AndroidClient.InvokeCallbackOnGameThread<Int32Enum>
	|
	|-RVA: 0x268A004 Offset: 0x2686004 VA: 0x268A004
	|-AndroidClient.InvokeCallbackOnGameThread<object>
	|
	|-RVA: 0x268A110 Offset: 0x2686110 VA: 0x268A110
	|-AndroidClient.InvokeCallbackOnGameThread<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Action<T1, T2> AsOnGameThreadCallback<T1, T2>(Action<T1, T2> toInvokeOnGameThread) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2689D5C Offset: 0x2685D5C VA: 0x2689D5C
	|-AndroidClient.AsOnGameThreadCallback<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void InvokeCallbackOnGameThread<T1, T2>(Action<T1, T2> callback, T1 t1, T2 t2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x268A2B8 Offset: 0x26862B8 VA: 0x268A2B8
	|-AndroidClient.InvokeCallbackOnGameThread<Int32Enum, object>
	|
	|-RVA: 0x268A3D8 Offset: 0x26863D8 VA: 0x268A3D8
	|-AndroidClient.InvokeCallbackOnGameThread<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E1370C Offset: 0x2E0F70C VA: 0x2E1370C Slot: 6
	public bool IsAuthenticated() { }

	// RVA: 0x2E137DC Offset: 0x2E0F7DC VA: 0x2E137DC Slot: 11
	public void LoadFriends(Action<bool> callback) { }

	// RVA: 0x2E137F4 Offset: 0x2E0F7F4 VA: 0x2E137F4
	private void LoadAllFriends(int pageSize, bool forceReload, bool loadMore, Action<bool> callback) { }

	// RVA: 0x2E13EBC Offset: 0x2E0FEBC VA: 0x2E13EBC Slot: 26
	public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback) { }

	// RVA: 0x2E13ECC Offset: 0x2E0FECC VA: 0x2E13ECC Slot: 27
	public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback) { }

	// RVA: 0x2E138FC Offset: 0x2E0F8FC VA: 0x2E138FC
	private void LoadFriendsPaginated(int pageSize, bool isLoadMore, bool forceReload, Action<LoadFriendsStatus> callback) { }

	// RVA: 0x2E13EE4 Offset: 0x2E0FEE4 VA: 0x2E13EE4
	private static bool IsApiException(AndroidJavaObject exception) { }

	// RVA: 0x2E14060 Offset: 0x2E10060 VA: 0x2E14060 Slot: 23
	public LoadFriendsStatus GetLastLoadFriendsStatus() { }

	// RVA: 0x2E14068 Offset: 0x2E10068 VA: 0x2E14068 Slot: 22
	public void AskForLoadFriendsResolution(Action<UIStatus> callback) { }

	// RVA: 0x2E14B14 Offset: 0x2E10B14 VA: 0x2E14B14 Slot: 24
	public void ShowCompareProfileWithAlternativeNameHintsUI(string playerId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback) { }

	// RVA: 0x2E1510C Offset: 0x2E1110C VA: 0x2E1510C Slot: 25
	public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback) { }

	// RVA: 0x2E15584 Offset: 0x2E11584 VA: 0x2E15584 Slot: 36
	public IUserProfile[] GetFriends() { }

	// RVA: 0x2E1558C Offset: 0x2E1158C VA: 0x2E1558C Slot: 10
	public string GetUserId() { }

	// RVA: 0x2E155CC Offset: 0x2E115CC VA: 0x2E155CC Slot: 12
	public string GetUserDisplayName() { }

	// RVA: 0x2E1560C Offset: 0x2E1160C VA: 0x2E1560C Slot: 13
	public string GetUserImageUrl() { }

	// RVA: 0x2E1564C Offset: 0x2E1164C VA: 0x2E1564C Slot: 14
	public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback) { }

	// RVA: 0x2E15BAC Offset: 0x2E11BAC VA: 0x2E15BAC Slot: 15
	public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback) { }

	// RVA: 0x2E1625C Offset: 0x2E1225C VA: 0x2E1625C Slot: 16
	public void LoadAchievements(Action<Achievement[]> callback) { }

	// RVA: 0x2E167AC Offset: 0x2E127AC VA: 0x2E167AC Slot: 17
	public void UnlockAchievement(string achId, Action<bool> callback) { }

	// RVA: 0x2E16A50 Offset: 0x2E12A50 VA: 0x2E16A50 Slot: 18
	public void RevealAchievement(string achId, Action<bool> callback) { }

	// RVA: 0x2E16CF4 Offset: 0x2E12CF4 VA: 0x2E16CF4 Slot: 19
	public void IncrementAchievement(string achId, int steps, Action<bool> callback) { }

	// RVA: 0x2E17018 Offset: 0x2E13018 VA: 0x2E17018 Slot: 20
	public void SetStepsAtLeast(string achId, int steps, Action<bool> callback) { }

	// RVA: 0x2E1733C Offset: 0x2E1333C VA: 0x2E1733C Slot: 21
	public void ShowAchievementsUI(Action<UIStatus> callback) { }

	// RVA: 0x2E17880 Offset: 0x2E13880 VA: 0x2E17880 Slot: 31
	public int LeaderboardMaxResults() { }

	// RVA: 0x2E17888 Offset: 0x2E13888 VA: 0x2E17888 Slot: 28
	public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback) { }

	// RVA: 0x2E18344 Offset: 0x2E14344 VA: 0x2E18344 Slot: 29
	public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback) { }

	// RVA: 0x2E18A64 Offset: 0x2E14A64 VA: 0x2E18A64 Slot: 30
	public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback) { }

	// RVA: 0x2E18FE8 Offset: 0x2E14FE8 VA: 0x2E18FE8
	private LeaderboardScoreData CreateLeaderboardScoreData(string leaderboardId, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ResponseStatus status, AndroidJavaObject leaderboardScoresJava) { }

	// RVA: 0x2E1A2F8 Offset: 0x2E162F8 VA: 0x2E1A2F8 Slot: 32
	public void SubmitScore(string leaderboardId, long score, Action<bool> callback) { }

	// RVA: 0x2E1A600 Offset: 0x2E16600 VA: 0x2E1A600 Slot: 33
	public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback) { }

	// RVA: 0x2E1A95C Offset: 0x2E1695C VA: 0x2E1A95C Slot: 34
	public ISavedGameClient GetSavedGameClient() { }

	// RVA: 0x2E1AA24 Offset: 0x2E16A24 VA: 0x2E1AA24 Slot: 35
	public IEventsClient GetEventsClient() { }

	// RVA: 0x2E166CC Offset: 0x2E126CC VA: 0x2E166CC
	private AndroidJavaObject getAchievementsClient() { }

	// RVA: 0x2E11724 Offset: 0x2E0D724 VA: 0x2E11724
	private AndroidJavaObject getPlayersClient() { }

	// RVA: 0x2E18960 Offset: 0x2E14960 VA: 0x2E18960
	private AndroidJavaObject getLeaderboardsClient() { }

	// RVA: 0x2E15ACC Offset: 0x2E11ACC VA: 0x2E15ACC
	private AndroidJavaObject getPlayerStatsClient() { }

	// RVA: 0x2E10BC0 Offset: 0x2E0CBC0 VA: 0x2E10BC0
	private AndroidJavaObject getGamesSignInClient() { }

	// RVA: 0x2E1332C Offset: 0x2E0F32C VA: 0x2E1332C
	private AndroidJavaObject getRecallClient() { }

	// RVA: 0x2E1AAEC Offset: 0x2E16AEC VA: 0x2E1AAEC
	private static void .cctor() { }
}

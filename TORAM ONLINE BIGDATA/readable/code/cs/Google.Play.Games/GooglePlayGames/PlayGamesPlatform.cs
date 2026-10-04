// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames
public class PlayGamesPlatform : ISocialPlatform // TypeDefIndex: 16719
{
	// Fields
	private static PlayGamesPlatform sInstance; // 0x0
	private static bool sNearbyInitializePending; // 0x8
	private static INearbyConnectionClient sNearbyConnectionClient; // 0x10
	private PlayGamesLocalUser mLocalUser; // 0x10
	private IPlayGamesClient mClient; // 0x18
	private string mDefaultLbUi; // 0x20
	private Dictionary<string, string> mIdMap; // 0x28

	// Properties
	public static bool DebugLogEnabled { get; set; }
	public static PlayGamesPlatform Instance { get; }
	public static INearbyConnectionClient Nearby { get; }
	public ISavedGameClient SavedGame { get; }
	public IEventsClient Events { get; }
	public ILocalUser localUser { get; }

	// Methods

	// RVA: 0x2E0AAB0 Offset: 0x2E06AB0 VA: 0x2E0AAB0
	internal void .ctor(IPlayGamesClient client) { }

	// RVA: 0x2E0ABAC Offset: 0x2E06BAC VA: 0x2E0ABAC
	private void .ctor() { }

	// RVA: 0x2E0ACAC Offset: 0x2E06CAC VA: 0x2E0ACAC
	public static bool get_DebugLogEnabled() { }

	// RVA: 0x2E0AD34 Offset: 0x2E06D34 VA: 0x2E0AD34
	public static void set_DebugLogEnabled(bool value) { }

	// RVA: 0x2E087E8 Offset: 0x2E047E8 VA: 0x2E087E8
	public static PlayGamesPlatform get_Instance() { }

	// RVA: 0x2E0AED8 Offset: 0x2E06ED8 VA: 0x2E0AED8
	public static INearbyConnectionClient get_Nearby() { }

	// RVA: 0x2E0B13C Offset: 0x2E0713C VA: 0x2E0B13C
	public ISavedGameClient get_SavedGame() { }

	// RVA: 0x2E0B1E0 Offset: 0x2E071E0 VA: 0x2E0B1E0
	public IEventsClient get_Events() { }

	// RVA: 0x2E0B284 Offset: 0x2E07284 VA: 0x2E0B284 Slot: 5
	public ILocalUser get_localUser() { }

	// RVA: 0x2E0AF6C Offset: 0x2E06F6C VA: 0x2E0AF6C
	public static void InitializeNearby(Action<INearbyConnectionClient> callback) { }

	// RVA: 0x2E0B3AC Offset: 0x2E073AC VA: 0x2E0B3AC
	public static PlayGamesPlatform Activate() { }

	// RVA: 0x2E0B488 Offset: 0x2E07488 VA: 0x2E0B488
	public void AddIdMapping(string fromId, string toId) { }

	// RVA: 0x2E09C04 Offset: 0x2E05C04 VA: 0x2E09C04
	public void Authenticate(Action<SignInStatus> callback) { }

	// RVA: 0x2E0B4F0 Offset: 0x2E074F0 VA: 0x2E0B4F0 Slot: 6
	public void Authenticate(ILocalUser unused, Action<bool> callback) { }

	// RVA: 0x2E0B5BC Offset: 0x2E075BC VA: 0x2E0B5BC Slot: 7
	public void Authenticate(ILocalUser unused, Action<bool, string> callback) { }

	// RVA: 0x2E0B688 Offset: 0x2E07688 VA: 0x2E0B688
	public void ManuallyAuthenticate(Action<SignInStatus> callback) { }

	// RVA: 0x2E0A008 Offset: 0x2E06008 VA: 0x2E0A008
	public bool IsAuthenticated() { }

	// RVA: 0x2E0B734 Offset: 0x2E07734 VA: 0x2E0B734
	public void RequestServerSideAccess(bool forceRefreshToken, Action<string> callback) { }

	// RVA: 0x2E0B9A4 Offset: 0x2E079A4 VA: 0x2E0B9A4
	public void RequestServerSideAccess(bool forceRefreshToken, List<AuthScope> scopes, Action<AuthResponse> callback) { }

	// RVA: 0x2E0BB10 Offset: 0x2E07B10 VA: 0x2E0BB10
	public void RequestRecallAccess(Action<RecallAccess> callback) { }

	// RVA: 0x2E0BBE4 Offset: 0x2E07BE4 VA: 0x2E0BBE4 Slot: 8
	public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback) { }

	// RVA: 0x2E0A2A0 Offset: 0x2E062A0 VA: 0x2E0A2A0
	public string GetUserId() { }

	// RVA: 0x2E0A7EC Offset: 0x2E067EC VA: 0x2E0A7EC
	public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback) { }

	// RVA: 0x2E0A184 Offset: 0x2E06184 VA: 0x2E0A184
	public string GetUserDisplayName() { }

	// RVA: 0x2E0A3B4 Offset: 0x2E063B4 VA: 0x2E0A3B4
	public string GetUserImageUrl() { }

	// RVA: 0x2E0BD30 Offset: 0x2E07D30 VA: 0x2E0BD30 Slot: 9
	public void ReportProgress(string achievementID, double progress, Action<bool> callback) { }

	// RVA: 0x2E0C1D8 Offset: 0x2E081D8 VA: 0x2E0C1D8
	internal static int progressToSteps(double progress, int totalSteps) { }

	// RVA: 0x2E0C218 Offset: 0x2E08218 VA: 0x2E0C218
	public void RevealAchievement(string achievementID, Action<bool> callback) { }

	// RVA: 0x2E0C3B0 Offset: 0x2E083B0 VA: 0x2E0C3B0
	public void UnlockAchievement(string achievementID, Action<bool> callback) { }

	// RVA: 0x2E0C548 Offset: 0x2E08548 VA: 0x2E0C548
	public void IncrementAchievement(string achievementID, int steps, Action<bool> callback) { }

	// RVA: 0x2E0C70C Offset: 0x2E0870C VA: 0x2E0C70C
	public void SetStepsAtLeast(string achievementID, int steps, Action<bool> callback) { }

	// RVA: 0x2E0C8D0 Offset: 0x2E088D0 VA: 0x2E0C8D0 Slot: 10
	public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback) { }

	// RVA: 0x2E0CA88 Offset: 0x2E08A88 VA: 0x2E0CA88 Slot: 11
	public void LoadAchievements(Action<IAchievement[]> callback) { }

	// RVA: 0x2E0CC30 Offset: 0x2E08C30 VA: 0x2E0CC30 Slot: 12
	public IAchievement CreateAchievement() { }

	// RVA: 0x2E0CC80 Offset: 0x2E08C80 VA: 0x2E0CC80 Slot: 13
	public void ReportScore(long score, string board, Action<bool> callback) { }

	// RVA: 0x2E0CE44 Offset: 0x2E08E44 VA: 0x2E0CE44
	public void ReportScore(long score, string board, string metadata, Action<bool> callback) { }

	// RVA: 0x2E0D108 Offset: 0x2E09108 VA: 0x2E0D108 Slot: 14
	public void LoadScores(string leaderboardId, Action<IScore[]> callback) { }

	// RVA: 0x2E0D274 Offset: 0x2E09274 VA: 0x2E0D274
	public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback) { }

	// RVA: 0x2E0D408 Offset: 0x2E09408 VA: 0x2E0D408
	public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback) { }

	// RVA: 0x2E0D574 Offset: 0x2E09574 VA: 0x2E0D574 Slot: 15
	public ILeaderboard CreateLeaderboard() { }

	// RVA: 0x2E0D5D0 Offset: 0x2E095D0 VA: 0x2E0D5D0 Slot: 16
	public void ShowAchievementsUI() { }

	// RVA: 0x2E0D5D8 Offset: 0x2E095D8 VA: 0x2E0D5D8
	public void ShowAchievementsUI(Action<UIStatus> callback) { }

	// RVA: 0x2E0D744 Offset: 0x2E09744 VA: 0x2E0D744 Slot: 17
	public void ShowLeaderboardUI() { }

	// RVA: 0x2E0D7D8 Offset: 0x2E097D8 VA: 0x2E0D7D8
	public void ShowLeaderboardUI(string leaderboardId) { }

	// RVA: 0x2E0D7CC Offset: 0x2E097CC VA: 0x2E0D7CC
	public void ShowLeaderboardUI(string leaderboardId, Action<UIStatus> callback) { }

	// RVA: 0x2E0D804 Offset: 0x2E09804 VA: 0x2E0D804
	public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback) { }

	// RVA: 0x2E0D9E4 Offset: 0x2E099E4 VA: 0x2E0D9E4
	public void SetDefaultLeaderboardForUI(string lbid) { }

	// RVA: 0x2E09D9C Offset: 0x2E05D9C VA: 0x2E09D9C Slot: 18
	public void LoadFriends(ILocalUser user, Action<bool> callback) { }

	// RVA: 0x2E08E24 Offset: 0x2E04E24 VA: 0x2E08E24 Slot: 19
	public void LoadScores(ILeaderboard board, Action<bool> callback) { }

	// RVA: 0x2E0DAA0 Offset: 0x2E09AA0 VA: 0x2E0DAA0 Slot: 4
	public bool GetLoading(ILeaderboard board) { }

	// RVA: 0x2E0DB48 Offset: 0x2E09B48 VA: 0x2E0DB48
	public void ShowCompareProfileWithAlternativeNameHintsUI(string userId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback) { }

	// RVA: 0x2E0DD28 Offset: 0x2E09D28 VA: 0x2E0DD28
	public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback) { }

	// RVA: 0x2E0DECC Offset: 0x2E09ECC VA: 0x2E0DECC
	public void AskForLoadFriendsResolution(Action<UIStatus> callback) { }

	// RVA: 0x2E0E05C Offset: 0x2E0A05C VA: 0x2E0E05C
	public LoadFriendsStatus GetLastLoadFriendsStatus() { }

	// RVA: 0x2E0E15C Offset: 0x2E0A15C VA: 0x2E0E15C
	public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback) { }

	// RVA: 0x2E0E29C Offset: 0x2E0A29C VA: 0x2E0E29C
	public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback) { }

	// RVA: 0x2E0E3D4 Offset: 0x2E0A3D4 VA: 0x2E0E3D4
	internal void HandleLoadingScores(PlayGamesLeaderboard board, LeaderboardScoreData scoreData, Action<bool> callback) { }

	// RVA: 0x2E09ED8 Offset: 0x2E05ED8 VA: 0x2E09ED8
	internal IUserProfile[] GetFriends() { }

	// RVA: 0x2E0C0C8 Offset: 0x2E080C8 VA: 0x2E0C0C8
	private string MapId(string id) { }

	// RVA: -1 Offset: -1
	private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DE268 Offset: 0x26DA268 VA: 0x26DE268
	|-PlayGamesPlatform.InvokeCallbackOnGameThread<Int32Enum>
	|
	|-RVA: 0x26DE368 Offset: 0x26DA368 VA: 0x26DE368
	|-PlayGamesPlatform.InvokeCallbackOnGameThread<object>
	|
	|-RVA: 0x26DE474 Offset: 0x26DA474 VA: 0x26DE474
	|-PlayGamesPlatform.InvokeCallbackOnGameThread<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static Action<T> ToOnGameThread<T>(Action<T> toConvert) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DE61C Offset: 0x26DA61C VA: 0x26DE61C
	|-PlayGamesPlatform.ToOnGameThread<bool>
	|
	|-RVA: 0x26DE7C4 Offset: 0x26DA7C4 VA: 0x26DE7C4
	|-PlayGamesPlatform.ToOnGameThread<__Il2CppFullySharedGenericType>
	*/
}

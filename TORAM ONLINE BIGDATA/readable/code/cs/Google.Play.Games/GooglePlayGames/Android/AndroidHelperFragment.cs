// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.Android
internal class AndroidHelperFragment // TypeDefIndex: 16766
{
	// Fields
	private const string HelperFragmentClass = "com.google.games.bridge.HelperFragment";

	// Methods

	// RVA: 0x2E1037C Offset: 0x2E0C37C VA: 0x2E1037C
	public static AndroidJavaObject GetActivity() { }

	// RVA: 0x2E22838 Offset: 0x2E1E838 VA: 0x2E22838
	public static AndroidJavaObject GetDefaultPopupView() { }

	// RVA: 0x2E17400 Offset: 0x2E13400 VA: 0x2E17400
	public static void ShowAchievementsUI(Action<UIStatus> cb) { }

	// RVA: 0x2E22BCC Offset: 0x2E1EBCC VA: 0x2E22BCC
	public static void ShowCaptureOverlayUI() { }

	// RVA: 0x2E1797C Offset: 0x2E1397C VA: 0x2E1797C
	public static void ShowAllLeaderboardsUI(Action<UIStatus> cb) { }

	// RVA: 0x2E17DFC Offset: 0x2E13DFC VA: 0x2E17DFC
	public static void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan timeSpan, Action<UIStatus> cb) { }

	// RVA: 0x2E14BB0 Offset: 0x2E10BB0 VA: 0x2E14BB0
	public static void ShowCompareProfileWithAlternativeNameHintsUI(string playerId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> cb) { }

	// RVA: 0x2E1CEDC Offset: 0x2E18EDC VA: 0x2E1CEDC
	public static void IsResolutionRequired(AndroidJavaObject friendsSharingConsentException, Action<bool> cb) { }

	// RVA: 0x2E14640 Offset: 0x2E10640 VA: 0x2E14640
	public static void AskForLoadFriendsResolution(AndroidJavaObject friendsSharingConsentException, Action<UIStatus> cb) { }

	// RVA: 0x2E22E24 Offset: 0x2E1EE24 VA: 0x2E22E24
	public static void ShowSelectSnapshotUI(bool showCreateSaveUI, bool showDeleteSaveUI, int maxDisplayedSavedGames, string uiTitle, Action<SelectUIStatus, ISavedGameMetadata> cb) { }

	// RVA: 0x2E2343C Offset: 0x2E1F43C VA: 0x2E2343C
	public void .ctor() { }
}

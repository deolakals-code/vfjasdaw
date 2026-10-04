// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.Android
internal class AndroidSavedGameClient : ISavedGameClient // TypeDefIndex: 16794
{
	// Fields
	private static readonly Regex ValidFilenameRegex; // 0x0
	private AndroidJavaObject mSnapshotsClient; // 0x10
	private AndroidClient mAndroidClient; // 0x18

	// Methods

	// RVA: 0x2E1B91C Offset: 0x2E1791C VA: 0x2E1B91C
	public void .ctor(AndroidClient androidClient) { }

	// RVA: 0x2E29FF0 Offset: 0x2E25FF0 VA: 0x2E29FF0 Slot: 4
	public void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback) { }

	// RVA: 0x2E2A7E0 Offset: 0x2E267E0 VA: 0x2E2A7E0 Slot: 5
	public void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback) { }

	// RVA: 0x2E2A398 Offset: 0x2E26398 VA: 0x2E2A398
	private void InternalOpen(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback) { }

	// RVA: 0x2E2A9B8 Offset: 0x2E269B8 VA: 0x2E2A9B8 Slot: 6
	public void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback) { }

	// RVA: 0x2E2AD04 Offset: 0x2E26D04 VA: 0x2E2AD04 Slot: 7
	public void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback) { }

	// RVA: 0x2E2AE6C Offset: 0x2E26E6C VA: 0x2E2AE6C Slot: 8
	public void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback) { }

	// RVA: 0x2E2C168 Offset: 0x2E28168 VA: 0x2E2C168 Slot: 9
	public void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback) { }

	// RVA: 0x2E2C540 Offset: 0x2E28540 VA: 0x2E2C540 Slot: 10
	public void Delete(ISavedGameMetadata metadata) { }

	// RVA: 0x2E2A25C Offset: 0x2E2625C VA: 0x2E2A25C
	private ConflictCallback ToOnGameThread(ConflictCallback conflictCallback) { }

	// RVA: 0x2E2A318 Offset: 0x2E26318 VA: 0x2E2A318
	internal static bool IsValidFilename(string filename) { }

	// RVA: 0x2E2B604 Offset: 0x2E27604 VA: 0x2E2B604
	private static AndroidJavaObject AsMetadataChange(SavedGameMetadataUpdate update) { }

	// RVA: -1 Offset: -1
	private static Action<T1, T2> ToOnGameThread<T1, T2>(Action<T1, T2> toConvert) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26A6728 Offset: 0x26A2728 VA: 0x26A6728
	|-AndroidSavedGameClient.ToOnGameThread<Int32Enum, object>
	|
	|-RVA: 0x26A67C4 Offset: 0x26A27C4 VA: 0x26A67C4
	|-AndroidSavedGameClient.ToOnGameThread<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2E2C728 Offset: 0x2E28728 VA: 0x2E2C728
	private static void .cctor() { }
}

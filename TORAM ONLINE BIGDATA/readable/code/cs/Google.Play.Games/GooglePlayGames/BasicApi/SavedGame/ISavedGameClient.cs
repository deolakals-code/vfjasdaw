// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.SavedGame
public interface ISavedGameClient // TypeDefIndex: 16840
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OpenWithAutomaticConflictResolution(string filename, DataSource source, ConflictResolutionStrategy resolutionStrategy, Action<SavedGameRequestStatus, ISavedGameMetadata> callback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OpenWithManualConflictResolution(string filename, DataSource source, bool prefetchDataOnConflict, ConflictCallback conflictCallback, Action<SavedGameRequestStatus, ISavedGameMetadata> completedCallback);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ReadBinaryData(ISavedGameMetadata metadata, Action<SavedGameRequestStatus, byte[]> completedCallback);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, Action<SelectUIStatus, ISavedGameMetadata> callback);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void CommitUpdate(ISavedGameMetadata metadata, SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, Action<SavedGameRequestStatus, ISavedGameMetadata> callback);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void FetchAllSavedGames(DataSource source, Action<SavedGameRequestStatus, List<ISavedGameMetadata>> callback);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Delete(ISavedGameMetadata metadata);
}

// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.SavedGame
public interface IConflictResolver // TypeDefIndex: 16841
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ChooseMetadata(ISavedGameMetadata chosenMetadata);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ResolveConflict(ISavedGameMetadata chosenMetadata, SavedGameMetadataUpdate metadataUpdate, byte[] updatedData);
}

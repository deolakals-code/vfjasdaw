// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.SavedGame
public interface ISavedGameMetadata // TypeDefIndex: 16842
{
	// Properties
	public abstract bool IsOpen { get; }
	public abstract string Filename { get; }
	public abstract string Description { get; }
	public abstract string CoverImageURL { get; }
	public abstract TimeSpan TotalTimePlayed { get; }
	public abstract DateTime LastModifiedTimestamp { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsOpen();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Filename();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Description();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_CoverImageURL();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract TimeSpan get_TotalTimePlayed();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract DateTime get_LastModifiedTimestamp();
}

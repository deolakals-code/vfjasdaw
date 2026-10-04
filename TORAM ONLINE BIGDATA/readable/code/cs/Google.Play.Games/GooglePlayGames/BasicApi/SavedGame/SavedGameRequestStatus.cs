// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi.SavedGame
public enum SavedGameRequestStatus // TypeDefIndex: 16837
{
	// Fields
	public int value__; // 0x0
	public const SavedGameRequestStatus Success = 1;
	public const SavedGameRequestStatus TimeoutError = -1;
	public const SavedGameRequestStatus InternalError = -2;
	public const SavedGameRequestStatus AuthenticationError = -3;
	public const SavedGameRequestStatus BadInputError = -4;
}

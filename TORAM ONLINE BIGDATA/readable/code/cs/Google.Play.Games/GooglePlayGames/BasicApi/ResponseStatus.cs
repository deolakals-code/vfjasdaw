// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi
public enum ResponseStatus // TypeDefIndex: 16817
{
	// Fields
	public int value__; // 0x0
	public const ResponseStatus Success = 1;
	public const ResponseStatus SuccessWithStale = 2;
	public const ResponseStatus LicenseCheckFailed = -1;
	public const ResponseStatus InternalError = -2;
	public const ResponseStatus NotAuthorized = -3;
	public const ResponseStatus VersionUpdateRequired = -4;
	public const ResponseStatus Timeout = -5;
	public const ResponseStatus ResolutionRequired = -6;
}

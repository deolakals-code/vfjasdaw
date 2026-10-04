// Assembly: Google.Play.Games.dll
// Namespace: GooglePlayGames.BasicApi
public enum CommonStatusCodes // TypeDefIndex: 16815
{
	// Fields
	public int value__; // 0x0
	public const CommonStatusCodes SuccessCached = -1;
	public const CommonStatusCodes Success = 0;
	public const CommonStatusCodes ServiceMissing = 1;
	public const CommonStatusCodes ServiceVersionUpdateRequired = 2;
	public const CommonStatusCodes ServiceDisabled = 3;
	public const CommonStatusCodes SignInRequired = 4;
	public const CommonStatusCodes InvalidAccount = 5;
	public const CommonStatusCodes ResolutionRequired = 6;
	public const CommonStatusCodes NetworkError = 7;
	public const CommonStatusCodes InternalError = 8;
	public const CommonStatusCodes ServiceInvalid = 9;
	public const CommonStatusCodes DeveloperError = 10;
	public const CommonStatusCodes LicenseCheckFailed = 11;
	public const CommonStatusCodes Error = 13;
	public const CommonStatusCodes Interrupted = 14;
	public const CommonStatusCodes Timeout = 15;
	public const CommonStatusCodes Canceled = 16;
	public const CommonStatusCodes ApiNotConnected = 17;
	public const CommonStatusCodes AuthApiInvalidCredentials = 3000;
	public const CommonStatusCodes AuthApiAccessForbidden = 3001;
	public const CommonStatusCodes AuthApiClientError = 3002;
	public const CommonStatusCodes AuthApiServerError = 3003;
	public const CommonStatusCodes AuthTokenError = 3004;
	public const CommonStatusCodes AuthUrlResolution = 3005;
}

// Assembly: System.dll
// Namespace: System.Net
internal enum FtpLoginState // TypeDefIndex: 14368
{
	// Fields
	public byte value__; // 0x0
	public const FtpLoginState NotLoggedIn = 0;
	public const FtpLoginState LoggedIn = 1;
	public const FtpLoginState LoggedInButNeedsRelogin = 2;
	public const FtpLoginState ReloginFailed = 3;
}

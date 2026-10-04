// Assembly: System.dll
// Namespace: System.Net
internal class BasicClient : IAuthenticationModule // TypeDefIndex: 14466
{
	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x3507E1C Offset: 0x3503E1C VA: 0x3507E1C Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x3508224 Offset: 0x3504224 VA: 0x3508224
	private static byte[] GetBytes(string str) { }

	// RVA: 0x3507EC8 Offset: 0x3503EC8 VA: 0x3507EC8
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x35082C0 Offset: 0x35042C0 VA: 0x35082C0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x35082CC Offset: 0x35042CC VA: 0x35082CC Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x3507250 Offset: 0x3503250 VA: 0x3507250
	public void .ctor() { }
}

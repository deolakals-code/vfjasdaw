// Assembly: System.dll
// Namespace: System.Net
internal class DigestClient : IAuthenticationModule // TypeDefIndex: 14476
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Properties
	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x350A17C Offset: 0x350617C VA: 0x350A17C
	private static Hashtable get_Cache() { }

	// RVA: 0x350A2E0 Offset: 0x35062E0 VA: 0x350A2E0
	private static void CheckExpired(int count) { }

	// RVA: 0x350AB38 Offset: 0x3506B38 VA: 0x350AB38 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x350ADD0 Offset: 0x3506DD0 VA: 0x350ADD0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x350AF50 Offset: 0x3506F50 VA: 0x350AF50 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x3507248 Offset: 0x3503248 VA: 0x3507248
	public void .ctor() { }

	// RVA: 0x350AF90 Offset: 0x3506F90 VA: 0x350AF90
	private static void .cctor() { }
}

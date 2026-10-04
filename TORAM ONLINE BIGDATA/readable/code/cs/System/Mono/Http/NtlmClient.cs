// Assembly: System.dll
// Namespace: Mono.Http
internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 14018
{
	// Fields
	private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; // 0x0

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x319FDC4 Offset: 0x319BDC4 VA: 0x319FDC4 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x31A0134 Offset: 0x319C134 VA: 0x31A0134 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x31A013C Offset: 0x319C13C VA: 0x31A013C Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x31A017C Offset: 0x319C17C VA: 0x31A017C
	public void .ctor() { }

	// RVA: 0x31A0184 Offset: 0x319C184 VA: 0x31A0184
	private static void .cctor() { }
}

// Assembly: System.dll
// Namespace: System.Net
internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 14498
{
	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x3514C3C Offset: 0x3510C3C VA: 0x3514C3C
	public void .ctor() { }

	// RVA: 0x3514CA8 Offset: 0x3510CA8 VA: 0x3514CA8 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x3514D78 Offset: 0x3510D78 VA: 0x3514D78 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x3514D80 Offset: 0x3510D80 VA: 0x3514D80 Slot: 6
	public string get_AuthenticationType() { }
}

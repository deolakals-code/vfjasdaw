// Assembly: System.dll
// Namespace: 
private struct HttpWebRequest.AuthorizationState // TypeDefIndex: 14483
{
	// Fields
	private readonly HttpWebRequest request; // 0x0
	private readonly bool isProxy; // 0x8
	private bool isCompleted; // 0x9
	private HttpWebRequest.NtlmAuthState ntlm_auth_state; // 0xC

	// Properties
	public bool IsCompleted { get; }
	public HttpWebRequest.NtlmAuthState NtlmAuthState { get; }
	public bool IsNtlmAuthenticated { get; }

	// Methods

	// RVA: 0x350FEA4 Offset: 0x350BEA4 VA: 0x350FEA4
	public bool get_IsCompleted() { }

	// RVA: 0x350FEAC Offset: 0x350BEAC VA: 0x350FEAC
	public HttpWebRequest.NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x350FEB4 Offset: 0x350BEB4 VA: 0x350FEB4
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x350C86C Offset: 0x350886C VA: 0x350C86C
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x350F300 Offset: 0x350B300 VA: 0x350F300
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x350FCD4 Offset: 0x350BCD4 VA: 0x350FCD4
	public void Reset() { }

	// RVA: 0x350FED4 Offset: 0x350BED4 VA: 0x350FED4 Slot: 3
	public override string ToString() { }
}

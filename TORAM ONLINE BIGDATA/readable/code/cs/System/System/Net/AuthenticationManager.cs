// Assembly: System.dll
// Namespace: System.Net
public class AuthenticationManager // TypeDefIndex: 14465
{
	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0x3506FCC Offset: 0x3502FCC VA: 0x3506FCC
	private static void EnsureModules() { }

	// RVA: 0x3507258 Offset: 0x3503258 VA: 0x3507258
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x3507358 Offset: 0x3503358 VA: 0x3507358
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x3507850 Offset: 0x3503850 VA: 0x3507850
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x3507D94 Offset: 0x3503D94 VA: 0x3507D94
	private static void .cctor() { }
}

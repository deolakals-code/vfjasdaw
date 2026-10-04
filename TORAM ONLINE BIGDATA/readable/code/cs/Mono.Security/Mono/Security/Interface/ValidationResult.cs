// Assembly: Mono.Security.dll
// Namespace: Mono.Security.Interface
public class ValidationResult // TypeDefIndex: 16903
{
	// Fields
	private bool trusted; // 0x10
	private bool user_denied; // 0x11
	private int error_code; // 0x14
	private Nullable<MonoSslPolicyErrors> policy_errors; // 0x18

	// Properties
	public bool Trusted { get; }
	public bool UserDenied { get; }

	// Methods

	// RVA: 0x2E57BB0 Offset: 0x2E53BB0 VA: 0x2E57BB0
	public void .ctor(bool trusted, bool user_denied, int error_code, Nullable<MonoSslPolicyErrors> policy_errors) { }

	// RVA: 0x2E57BF8 Offset: 0x2E53BF8 VA: 0x2E57BF8
	public bool get_Trusted() { }

	// RVA: 0x2E57C00 Offset: 0x2E53C00 VA: 0x2E57C00
	public bool get_UserDenied() { }
}

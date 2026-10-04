// Assembly: mscorlib.dll
// Namespace: System.Security
[ComVisible(True)]
public static class SecurityManager // TypeDefIndex: 10077
{
	// Properties
	[Obsolete("The security manager cannot be turned off on MS runtime")]
	public static bool SecurityEnabled { get; }

	// Methods

	// RVA: 0x2EA2AE4 Offset: 0x2E9EAE4 VA: 0x2EA2AE4
	public static bool get_SecurityEnabled() { }

	// RVA: 0x2EA60F4 Offset: 0x2EA20F4 VA: 0x2EA60F4
	internal static void EnsureElevatedPermissions() { }
}

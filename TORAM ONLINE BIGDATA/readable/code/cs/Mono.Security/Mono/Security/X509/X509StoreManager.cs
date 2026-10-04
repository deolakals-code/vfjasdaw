// Assembly: Mono.Security.dll
// Namespace: Mono.Security.X509
public sealed class X509StoreManager // TypeDefIndex: 16887
{
	// Fields
	private static string _userPath; // 0x0
	private static string _localMachinePath; // 0x8
	private static X509Stores _userStore; // 0x10
	private static X509Stores _machineStore; // 0x18

	// Properties
	internal static string CurrentUserPath { get; }
	internal static string LocalMachinePath { get; }
	public static X509Stores CurrentUser { get; }
	public static X509Stores LocalMachine { get; }
	public static X509CertificateCollection TrustedRootCertificates { get; }

	// Methods

	// RVA: 0x2E52C90 Offset: 0x2E4EC90 VA: 0x2E52C90
	internal static string get_CurrentUserPath() { }

	// RVA: 0x2E52DA8 Offset: 0x2E4EDA8 VA: 0x2E52DA8
	internal static string get_LocalMachinePath() { }

	// RVA: 0x2E52EB8 Offset: 0x2E4EEB8 VA: 0x2E52EB8
	public static X509Stores get_CurrentUser() { }

	// RVA: 0x2E52FA8 Offset: 0x2E4EFA8 VA: 0x2E52FA8
	public static X509Stores get_LocalMachine() { }

	// RVA: 0x2E50DF8 Offset: 0x2E4CDF8 VA: 0x2E50DF8
	public static X509CertificateCollection get_TrustedRootCertificates() { }
}

// Assembly: System.dll
// Namespace: Mono.Net.Security
internal static class MonoTlsProviderFactory // TypeDefIndex: 14008
{
	// Fields
	private static object locker; // 0x0
	private static bool initialized; // 0x8
	private static MobileTlsProvider defaultProvider; // 0x10
	private static Dictionary<string, Tuple<Guid, string>> providerRegistration; // 0x18
	private static Dictionary<Guid, MobileTlsProvider> providerCache; // 0x20
	internal static readonly Guid UnityTlsId; // 0x28
	internal static readonly Guid AppleTlsId; // 0x38
	internal static readonly Guid BtlsId; // 0x48

	// Methods

	// RVA: 0x3199D7C Offset: 0x3195D7C VA: 0x3199D7C
	internal static MobileTlsProvider GetProviderInternal() { }

	// RVA: 0x319DC2C Offset: 0x3199C2C VA: 0x319DC2C
	internal static void InitializeInternal() { }

	// RVA: 0x319E35C Offset: 0x319A35C VA: 0x319E35C
	private static MobileTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0x319DFD4 Offset: 0x3199FD4 VA: 0x319DFD4
	private static void InitializeProviderRegistration() { }

	// RVA: 0x319E8BC Offset: 0x319A8BC VA: 0x319E8BC
	private static void PopulateUnityProviders() { }

	// RVA: 0x319E9FC Offset: 0x319A9FC VA: 0x319E9FC
	private static void PopulateProviders() { }

	// RVA: 0x319E1D4 Offset: 0x319A1D4 VA: 0x319E1D4
	private static MobileTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0x319EA4C Offset: 0x319AA4C VA: 0x319EA4C
	internal static MobileTlsProvider GetProvider() { }

	// RVA: 0x319EA98 Offset: 0x319AA98 VA: 0x319EA98
	private static void .cctor() { }
}

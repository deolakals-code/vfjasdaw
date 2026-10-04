// Assembly: System.dll
// Namespace: System.Net
internal static class NclUtilities // TypeDefIndex: 14397
{
	// Fields
	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	// Properties
	internal static IPAddress[] LocalAddresses { get; }
	private static object LocalAddressesLock { get; }

	// Methods

	// RVA: 0x34EE164 Offset: 0x34EA164 VA: 0x34EE164
	internal static bool IsFatal(Exception exception) { }

	// RVA: 0x34EE224 Offset: 0x34EA224 VA: 0x34EE224
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x34EE794 Offset: 0x34EA794 VA: 0x34EE794
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x34EE2B4 Offset: 0x34EA2B4 VA: 0x34EE2B4
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x34EE7AC Offset: 0x34EA7AC VA: 0x34EE7AC
	private static object get_LocalAddressesLock() { }
}

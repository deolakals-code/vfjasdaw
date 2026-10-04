// Assembly: System.dll
// Namespace: Internal.Cryptography
internal static class OidLookup // TypeDefIndex: 14020
{
	// Fields
	private static readonly ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName; // 0x0
	private static readonly ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid; // 0x8
	private static readonly Dictionary<string, string> s_friendlyNameToOid; // 0x10
	private static readonly Dictionary<string, string> s_oidToFriendlyName; // 0x18
	private static readonly Dictionary<string, string> s_compatOids; // 0x20

	// Methods

	// RVA: 0x31A02E0 Offset: 0x319C2E0 VA: 0x31A02E0
	public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x31A0874 Offset: 0x319C874 VA: 0x31A0874
	public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x31A04BC Offset: 0x319C4BC VA: 0x31A04BC
	private static bool ShouldUseCache(OidGroup oidGroup) { }

	// RVA: 0x31A04C4 Offset: 0x319C4C4 VA: 0x31A04C4
	private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x31A0A24 Offset: 0x319CA24 VA: 0x31A0A24
	private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x31A0DE0 Offset: 0x319CDE0 VA: 0x31A0DE0
	private static void .cctor() { }
}

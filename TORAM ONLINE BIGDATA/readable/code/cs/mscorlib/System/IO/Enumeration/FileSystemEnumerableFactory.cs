// Assembly: mscorlib.dll
// Namespace: System.IO.Enumeration
internal static class FileSystemEnumerableFactory // TypeDefIndex: 10761
{
	// Fields
	private static readonly char[] s_unixEscapeChars; // 0x0

	// Methods

	// RVA: 0x2F5DBA4 Offset: 0x2F59BA4 VA: 0x2F5DBA4
	internal static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options) { }

	// RVA: 0x2F5E3E8 Offset: 0x2F5A3E8 VA: 0x2F5E3E8
	private static bool MatchesPattern(string expression, ReadOnlySpan<char> name, EnumerationOptions options) { }

	// RVA: 0x2F5E720 Offset: 0x2F5A720 VA: 0x2F5E720
	internal static IEnumerable<string> UserFiles(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x2F5E91C Offset: 0x2F5A91C VA: 0x2F5E91C
	internal static IEnumerable<string> UserDirectories(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x2F5EB18 Offset: 0x2F5AB18 VA: 0x2F5EB18
	internal static IEnumerable<string> UserEntries(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x2F5ED14 Offset: 0x2F5AD14 VA: 0x2F5ED14
	private static void .cctor() { }
}

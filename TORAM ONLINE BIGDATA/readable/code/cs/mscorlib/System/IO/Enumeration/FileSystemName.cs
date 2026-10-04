// Assembly: mscorlib.dll
// Namespace: System.IO.Enumeration
public static class FileSystemName // TypeDefIndex: 10763
{
	// Fields
	private static readonly char[] s_wildcardChars; // 0x0
	private static readonly char[] s_simpleWildcardChars; // 0x8

	// Methods

	// RVA: 0x2F5E070 Offset: 0x2F5A070 VA: 0x2F5E070
	public static string TranslateWin32Expression(string expression) { }

	// RVA: 0x2F5E698 Offset: 0x2F5A698 VA: 0x2F5E698
	public static bool MatchesWin32Expression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = True) { }

	// RVA: 0x2F5E610 Offset: 0x2F5A610 VA: 0x2F5E610
	public static bool MatchesSimpleExpression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = True) { }

	// RVA: 0x2F5F000 Offset: 0x2F5B000 VA: 0x2F5F000
	private static bool MatchPattern(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase, bool useExtendedWildcards) { }

	// RVA: 0x2F5F738 Offset: 0x2F5B738 VA: 0x2F5F738
	private static void .cctor() { }
}

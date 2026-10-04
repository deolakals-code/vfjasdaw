// Assembly: mscorlib.dll
// Namespace: System.IO
internal static class PathInternal // TypeDefIndex: 10695
{
	// Fields
	private static readonly bool s_isCaseSensitive; // 0x0

	// Properties
	internal static bool IsCaseSensitive { get; }

	// Methods

	// RVA: 0x2F423F4 Offset: 0x2F3E3F4 VA: 0x2F423F4
	internal static int GetRootLength(ReadOnlySpan<char> path) { }

	// RVA: 0x2F42470 Offset: 0x2F3E470 VA: 0x2F42470
	internal static bool IsDirectorySeparator(char c) { }

	// RVA: 0x2F42480 Offset: 0x2F3E480 VA: 0x2F42480
	internal static bool EndsInDirectorySeparator(ReadOnlySpan<char> path) { }

	// RVA: 0x2F42500 Offset: 0x2F3E500 VA: 0x2F42500
	internal static bool StartsWithDirectorySeparator(ReadOnlySpan<char> path) { }

	// RVA: 0x2F4257C Offset: 0x2F3E57C VA: 0x2F4257C
	internal static string TrimEndingDirectorySeparator(string path) { }

	// RVA: 0x2F42738 Offset: 0x2F3E738 VA: 0x2F42738
	internal static ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path) { }

	// RVA: 0x2F426BC Offset: 0x2F3E6BC VA: 0x2F426BC
	internal static bool IsRoot(ReadOnlySpan<char> path) { }

	// RVA: 0x2F42818 Offset: 0x2F3E818 VA: 0x2F42818
	internal static bool get_IsCaseSensitive() { }

	// RVA: 0x2F42870 Offset: 0x2F3E870 VA: 0x2F42870
	private static bool GetIsCaseSensitive() { }

	// RVA: 0x2F42D34 Offset: 0x2F3ED34 VA: 0x2F42D34
	public static bool IsPartiallyQualified(string path) { }

	// RVA: 0x2F42D3C Offset: 0x2F3ED3C VA: 0x2F42D3C
	private static void .cctor() { }
}

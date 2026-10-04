// Assembly: mscorlib.dll
// Namespace: System.IO
[ComVisible(True)]
public static class Path // TypeDefIndex: 10745
{
	// Fields
	[Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
	public static readonly char[] InvalidPathChars; // 0x0
	public static readonly char AltDirectorySeparatorChar; // 0x8
	public static readonly char DirectorySeparatorChar; // 0xA
	public static readonly char PathSeparator; // 0xC
	internal static readonly string DirectorySeparatorStr; // 0x10
	public static readonly char VolumeSeparatorChar; // 0x18
	internal static readonly char[] PathSeparatorChars; // 0x20
	private static readonly bool dirEqualsVolume; // 0x28
	internal static readonly char[] trimEndCharsWindows; // 0x30
	internal static readonly char[] trimEndCharsUnix; // 0x38

	// Methods

	// RVA: 0x2F58FCC Offset: 0x2F54FCC VA: 0x2F58FCC
	public static string ChangeExtension(string path, string extension) { }

	// RVA: 0x2F59250 Offset: 0x2F55250 VA: 0x2F59250
	public static string Combine(string path1, string path2) { }

	// RVA: 0x2F595D4 Offset: 0x2F555D4 VA: 0x2F595D4
	internal static string CleanPath(string s) { }

	// RVA: 0x2F54FB8 Offset: 0x2F50FB8 VA: 0x2F54FB8
	public static string GetDirectoryName(string path) { }

	// RVA: 0x2F59E50 Offset: 0x2F55E50 VA: 0x2F59E50
	public static ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path) { }

	// RVA: 0x2F59F20 Offset: 0x2F55F20 VA: 0x2F59F20
	public static string GetExtension(string path) { }

	// RVA: 0x2F50340 Offset: 0x2F4C340 VA: 0x2F50340
	public static string GetFileName(string path) { }

	// RVA: 0x2F5A048 Offset: 0x2F56048 VA: 0x2F5A048
	public static string GetFileNameWithoutExtension(string path) { }

	// RVA: 0x2F55348 Offset: 0x2F51348 VA: 0x2F55348
	public static string GetFullPath(string path) { }

	// RVA: 0x2F4BF6C Offset: 0x2F47F6C VA: 0x2F4BF6C
	internal static string GetFullPathInternal(string path) { }

	// RVA: 0x2F54888 Offset: 0x2F50888 VA: 0x2F54888
	internal static string InsecureGetFullPath(string path) { }

	// RVA: 0x2F502B4 Offset: 0x2F4C2B4 VA: 0x2F502B4
	internal static bool IsDirectorySeparator(char c) { }

	// RVA: 0x2F59A24 Offset: 0x2F55A24 VA: 0x2F59A24
	public static string GetPathRoot(string path) { }

	// RVA: 0x2F5A4A8 Offset: 0x2F564A8 VA: 0x2F5A4A8
	public static string GetTempPath() { }

	// RVA: 0x2F5A5B4 Offset: 0x2F565B4 VA: 0x2F5A5B4
	private static string get_temp_path() { }

	// RVA: 0x2F5A5B8 Offset: 0x2F565B8 VA: 0x2F5A5B8
	public static bool IsPathRooted(ReadOnlySpan<char> path) { }

	// RVA: 0x2F594B0 Offset: 0x2F554B0 VA: 0x2F594B0
	public static bool IsPathRooted(string path) { }

	// RVA: 0x2F5A6BC Offset: 0x2F566BC VA: 0x2F5A6BC
	public static char[] GetInvalidPathChars() { }

	// RVA: 0x2F591BC Offset: 0x2F551BC VA: 0x2F591BC
	private static int findExtension(string path) { }

	// RVA: 0x2F5A750 Offset: 0x2F56750 VA: 0x2F5A750
	private static void .cctor() { }

	// RVA: 0x2F5A0A4 Offset: 0x2F560A4 VA: 0x2F5A0A4
	private static string CanonicalizePath(string path) { }

	// RVA: 0x2F5A95C Offset: 0x2F5695C VA: 0x2F5A95C
	public static string Combine(string[] paths) { }

	// RVA: 0x2F5AC4C Offset: 0x2F56C4C VA: 0x2F5AC4C
	public static string Combine(string path1, string path2, string path3) { }

	// RVA: 0x2F5ADCC Offset: 0x2F56DCC VA: 0x2F5ADCC
	public static ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path) { }

	// RVA: 0x2F5AF10 Offset: 0x2F56F10 VA: 0x2F5AF10
	public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2) { }

	// RVA: 0x2F5B240 Offset: 0x2F57240 VA: 0x2F5B240
	public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3) { }

	// RVA: 0x2F5B6B0 Offset: 0x2F576B0 VA: 0x2F5B6B0
	public static bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2F5AFC8 Offset: 0x2F56FC8 VA: 0x2F5AFC8
	private static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second) { }

	// RVA: 0x2F5B350 Offset: 0x2F57350 VA: 0x2F5B350
	private static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second, ReadOnlySpan<char> third) { }
}

// Assembly: mscorlib.dll
// Namespace: System.IO
public static class Directory // TypeDefIndex: 10710
{
	// Methods

	// RVA: 0x2F492B0 Offset: 0x2F452B0 VA: 0x2F492B0
	public static DirectoryInfo CreateDirectory(string path) { }

	// RVA: 0x2F49A04 Offset: 0x2F45A04 VA: 0x2F49A04
	public static bool Exists(string path) { }

	// RVA: 0x2F49BA0 Offset: 0x2F45BA0 VA: 0x2F49BA0
	public static string[] GetFiles(string path, string searchPattern) { }

	// RVA: 0x2F49C40 Offset: 0x2F45C40 VA: 0x2F49C40
	public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x2F49CA8 Offset: 0x2F45CA8 VA: 0x2F49CA8
	internal static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

	// RVA: 0x2F49E68 Offset: 0x2F45E68 VA: 0x2F49E68
	internal static string InternalGetDirectoryRoot(string path) { }

	// RVA: 0x2F49F20 Offset: 0x2F45F20 VA: 0x2F49F20
	public static string GetCurrentDirectory() { }

	// RVA: 0x2F49F28 Offset: 0x2F45F28 VA: 0x2F49F28
	internal static string InsecureGetCurrentDirectory() { }
}

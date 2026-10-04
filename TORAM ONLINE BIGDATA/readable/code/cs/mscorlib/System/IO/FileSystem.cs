// Assembly: mscorlib.dll
// Namespace: System.IO
internal static class FileSystem // TypeDefIndex: 10716
{
	// Methods

	// RVA: 0x2F4A678 Offset: 0x2F46678 VA: 0x2F4A678
	public static void DeleteFile(string fullPath) { }

	// RVA: 0x2F493F4 Offset: 0x2F453F4 VA: 0x2F493F4
	public static void CreateDirectory(string fullPath) { }

	// RVA: 0x2F49B80 Offset: 0x2F45B80 VA: 0x2F49B80
	public static bool DirectoryExists(ReadOnlySpan<char> fullPath) { }

	// RVA: 0x2F4BA5C Offset: 0x2F47A5C VA: 0x2F4BA5C
	private static bool DirectoryExists(ReadOnlySpan<char> fullPath, out Interop.ErrorInfo errorInfo) { }

	// RVA: 0x2F4A824 Offset: 0x2F46824 VA: 0x2F4A824
	public static bool FileExists(ReadOnlySpan<char> fullPath) { }

	// RVA: 0x2F4B94C Offset: 0x2F4794C VA: 0x2F4B94C
	private static bool FileExists(ReadOnlySpan<char> fullPath, int fileType, out Interop.ErrorInfo errorInfo) { }
}

// Assembly: mscorlib.dll
// Namespace: System.IO
internal static class MonoIO // TypeDefIndex: 10741
{
	// Fields
	public static readonly IntPtr InvalidHandle; // 0x0
	private static bool dump_handles; // 0x8

	// Properties
	public static IntPtr ConsoleOutput { get; }
	public static IntPtr ConsoleInput { get; }
	public static IntPtr ConsoleError { get; }
	public static char VolumeSeparatorChar { get; }
	public static char DirectorySeparatorChar { get; }
	public static char AltDirectorySeparatorChar { get; }
	public static char PathSeparator { get; }

	// Methods

	// RVA: 0x2F58DDC Offset: 0x2F54DDC VA: 0x2F58DDC
	public static Exception GetException(MonoIOError error) { }

	// RVA: 0x2F554C4 Offset: 0x2F514C4 VA: 0x2F554C4
	public static Exception GetException(string path, MonoIOError error) { }

	// RVA: 0x2F58F04 Offset: 0x2F54F04 VA: 0x2F58F04
	public static string GetCurrentDirectory(out MonoIOError error) { }

	// RVA: 0x2F58F08 Offset: 0x2F54F08 VA: 0x2F58F08
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x2F55C08 Offset: 0x2F51C08 VA: 0x2F55C08
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x2F58F0C Offset: 0x2F54F0C VA: 0x2F58F0C
	private static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x2F553B0 Offset: 0x2F513B0 VA: 0x2F553B0
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x2F58B28 Offset: 0x2F54B28 VA: 0x2F58B28
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x2F58F10 Offset: 0x2F54F10 VA: 0x2F58F10
	private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x2F58B34 Offset: 0x2F54B34 VA: 0x2F58B34
	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x2F58F14 Offset: 0x2F54F14 VA: 0x2F58F14
	private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x2F578D4 Offset: 0x2F538D4 VA: 0x2F578D4
	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x2F58F18 Offset: 0x2F54F18 VA: 0x2F58F18
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x2F56028 Offset: 0x2F52028 VA: 0x2F56028
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x2F58F1C Offset: 0x2F54F1C VA: 0x2F58F1C
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x2F5631C Offset: 0x2F5231C VA: 0x2F5631C
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x2F58F20 Offset: 0x2F54F20 VA: 0x2F58F20
	private static bool SetLength(IntPtr handle, long length, out MonoIOError error) { }

	// RVA: 0x2F58584 Offset: 0x2F54584 VA: 0x2F58584
	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	// RVA: 0x2F58F24 Offset: 0x2F54F24 VA: 0x2F58F24
	public static IntPtr get_ConsoleOutput() { }

	// RVA: 0x2F58F28 Offset: 0x2F54F28 VA: 0x2F58F28
	public static IntPtr get_ConsoleInput() { }

	// RVA: 0x2F58F2C Offset: 0x2F54F2C VA: 0x2F58F2C
	public static IntPtr get_ConsoleError() { }

	// RVA: 0x2F58F30 Offset: 0x2F54F30 VA: 0x2F58F30
	public static char get_VolumeSeparatorChar() { }

	// RVA: 0x2F58F34 Offset: 0x2F54F34 VA: 0x2F58F34
	public static char get_DirectorySeparatorChar() { }

	// RVA: 0x2F58F38 Offset: 0x2F54F38 VA: 0x2F58F38
	public static char get_AltDirectorySeparatorChar() { }

	// RVA: 0x2F58F3C Offset: 0x2F54F3C VA: 0x2F58F3C
	public static char get_PathSeparator() { }

	// RVA: 0x2F58F00 Offset: 0x2F54F00 VA: 0x2F58F00
	private static void DumpHandles() { }

	// RVA: 0x2F58F40 Offset: 0x2F54F40 VA: 0x2F58F40
	public static bool RemapPath(string path, out string newPath) { }

	// RVA: 0x2F58F44 Offset: 0x2F54F44 VA: 0x2F58F44
	private static void .cctor() { }
}

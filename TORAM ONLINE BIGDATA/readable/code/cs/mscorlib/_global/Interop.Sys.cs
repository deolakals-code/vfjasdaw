// Assembly: mscorlib.dll
// Namespace: 
internal static class Interop.Sys // TypeDefIndex: 9415
{
	// Fields
	internal static readonly bool CanSetHiddenFlag; // 0x0

	// Methods

	// RVA: 0x2E6492C Offset: 0x2E6092C VA: 0x2E6492C
	internal static Interop.ErrorInfo GetLastErrorInfo() { }

	// RVA: 0x2E6475C Offset: 0x2E6075C VA: 0x2E6475C
	internal static string StrError(int platformErrno) { }

	// RVA: 0x2E64740 Offset: 0x2E60740 VA: 0x2E64740
	internal static extern Interop.Error ConvertErrorPlatformToPal(int platformErrno) { }

	// RVA: 0x2E64758 Offset: 0x2E60758 VA: 0x2E64758
	internal static extern int ConvertErrorPalToPlatform(Interop.Error error) { }

	// RVA: 0x2E64994 Offset: 0x2E60994 VA: 0x2E64994
	private static extern byte* StrErrorR(int platformErrno, byte* buffer, int bufferSize) { }

	// RVA: 0x2E646D4 Offset: 0x2E606D4 VA: 0x2E646D4
	internal static extern void GetNonCryptographicallySecureRandomBytes(byte* buffer, int length) { }

	// RVA: 0x2E64998 Offset: 0x2E60998 VA: 0x2E64998
	internal static extern IntPtr OpenDir(string path) { }

	// RVA: 0x2E649CC Offset: 0x2E609CC VA: 0x2E649CC
	internal static extern int GetReadDirRBufferSize() { }

	// RVA: 0x2E649D0 Offset: 0x2E609D0 VA: 0x2E649D0
	internal static extern int ReadDirR(IntPtr dir, byte* buffer, int bufferSize, out Interop.Sys.DirectoryEntry outputEntry) { }

	// RVA: 0x2E649D4 Offset: 0x2E609D4 VA: 0x2E649D4
	internal static extern int CloseDir(IntPtr dir) { }

	// RVA: 0x2E649F0 Offset: 0x2E609F0 VA: 0x2E649F0
	private static extern int ReadLink(string path, byte[] buffer, int bufferSize) { }

	// RVA: 0x2E64A3C Offset: 0x2E60A3C VA: 0x2E64A3C
	public static string ReadLink(string path) { }

	// RVA: 0x2E64C54 Offset: 0x2E60C54 VA: 0x2E64C54
	internal static extern int Stat(string path, out Interop.Sys.FileStatus output) { }

	// RVA: 0x2E64C90 Offset: 0x2E60C90 VA: 0x2E64C90
	internal static extern uint GetEGid() { }

	// RVA: 0x2E64C94 Offset: 0x2E60C94 VA: 0x2E64C94
	internal static extern uint GetEUid() { }

	// RVA: 0x2E64C98 Offset: 0x2E60C98 VA: 0x2E64C98
	private static extern int LChflagsCanSetHiddenFlag() { }

	// RVA: 0x2E64C9C Offset: 0x2E60C9C VA: 0x2E64C9C
	internal static extern int MkDir(string path, int mode) { }

	// RVA: 0x2E64CD8 Offset: 0x2E60CD8 VA: 0x2E64CD8
	internal static extern int Stat(ref byte path, out Interop.Sys.FileStatus output) { }

	// RVA: 0x2E64CF4 Offset: 0x2E60CF4 VA: 0x2E64CF4
	internal static int Stat(ReadOnlySpan<char> path, out Interop.Sys.FileStatus output) { }

	// RVA: 0x2E64E2C Offset: 0x2E60E2C VA: 0x2E64E2C
	internal static extern int LStat(ref byte path, out Interop.Sys.FileStatus output) { }

	// RVA: 0x2E64E48 Offset: 0x2E60E48 VA: 0x2E64E48
	internal static int LStat(ReadOnlySpan<char> path, out Interop.Sys.FileStatus output) { }

	// RVA: 0x2E64F80 Offset: 0x2E60F80 VA: 0x2E64F80
	internal static extern int Unlink(string pathname) { }

	// RVA: 0x2E64FB4 Offset: 0x2E60FB4 VA: 0x2E64FB4
	internal static int DoubleToString(double value, byte* format, byte* buffer, int bufferLength) { }

	// RVA: 0x2E64FB8 Offset: 0x2E60FB8 VA: 0x2E64FB8
	private static void .cctor() { }
}

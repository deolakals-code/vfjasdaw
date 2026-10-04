// Assembly: mscorlib.dll
// Namespace: System.IO
public static class File // TypeDefIndex: 10713
{
	// Methods

	// RVA: 0x2F4A494 Offset: 0x2F46494 VA: 0x2F4A494
	public static StreamReader OpenText(string path) { }

	// RVA: 0x2F4A550 Offset: 0x2F46550 VA: 0x2F4A550
	public static FileStream Create(string path) { }

	// RVA: 0x2F4A558 Offset: 0x2F46558 VA: 0x2F4A558
	public static FileStream Create(string path, int bufferSize) { }

	// RVA: 0x2F4A5D0 Offset: 0x2F465D0 VA: 0x2F4A5D0
	public static void Delete(string path) { }

	// RVA: 0x2F42B78 Offset: 0x2F3EB78 VA: 0x2F42B78
	public static bool Exists(string path) { }

	// RVA: 0x2F4A8A0 Offset: 0x2F468A0 VA: 0x2F4A8A0
	public static FileStream Open(string path, FileMode mode) { }

	// RVA: 0x2F4A8B4 Offset: 0x2F468B4 VA: 0x2F4A8B4
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x2F4A938 Offset: 0x2F46938 VA: 0x2F4A938
	public static FileStream OpenRead(string path) { }

	// RVA: 0x2F4A9A0 Offset: 0x2F469A0 VA: 0x2F4A9A0
	public static byte[] ReadAllBytes(string path) { }

	// RVA: 0x2F4AC64 Offset: 0x2F46C64 VA: 0x2F4AC64
	private static byte[] ReadAllBytesUnknownLength(FileStream fs) { }

	// RVA: 0x2F4B0AC Offset: 0x2F470AC VA: 0x2F4B0AC
	public static void WriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x2F4B1A8 Offset: 0x2F471A8 VA: 0x2F4B1A8
	private static void InternalWriteAllBytes(string path, byte[] bytes) { }
}

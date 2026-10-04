// Assembly: mscorlib.dll
// Namespace: System.Runtime
internal static class RuntimeImports // TypeDefIndex: 10187
{
	// Methods

	// RVA: 0x2ECC350 Offset: 0x2EC8350 VA: 0x2ECC350
	internal static void RhZeroMemory(ref byte b, ulong byteLength) { }

	// RVA: 0x2ECC354 Offset: 0x2EC8354 VA: 0x2ECC354
	private static void ZeroMemory(void* p, uint byteLength) { }

	// RVA: 0x2ECC358 Offset: 0x2EC8358 VA: 0x2ECC358
	internal static void Memmove(byte* dest, byte* src, uint len) { }

	// RVA: 0x2ECC35C Offset: 0x2EC835C VA: 0x2ECC35C
	internal static void Memmove_wbarrier(byte* dest, byte* src, uint len, IntPtr type_handle) { }
}

// Assembly: mscorlib.dll
// Namespace: Mono
internal static class RuntimeMarshal // TypeDefIndex: 9431
{
	// Methods

	// RVA: 0x2E65EF8 Offset: 0x2E61EF8 VA: 0x2E65EF8
	internal static string PtrToUtf8String(IntPtr ptr) { }

	// RVA: 0x2E65FC0 Offset: 0x2E61FC0 VA: 0x2E65FC0
	internal static SafeStringMarshal MarshalString(string str) { }

	// RVA: 0x2E66008 Offset: 0x2E62008 VA: 0x2E66008
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	// RVA: 0x2E66084 Offset: 0x2E62084 VA: 0x2E66084
	internal static byte[] DecodeBlobArray(IntPtr ptr) { }

	// RVA: 0x2E6613C Offset: 0x2E6213C VA: 0x2E6613C
	internal static int AsciHexDigitValue(int c) { }

	// RVA: 0x2E66168 Offset: 0x2E62168 VA: 0x2E66168
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }
}

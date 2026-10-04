// Assembly: Mono.Security.dll
// Namespace: Mono.Security
internal sealed class BitConverterLE // TypeDefIndex: 16867
{
	// Methods

	// RVA: 0x2E435F4 Offset: 0x2E3F5F4 VA: 0x2E435F4
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x2E4368C Offset: 0x2E3F68C VA: 0x2E4368C
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x2E42A88 Offset: 0x2E3EA88 VA: 0x2E42A88
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x2E43764 Offset: 0x2E3F764 VA: 0x2E43764
	internal static byte[] GetBytes(long value) { }

	// RVA: 0x2E4377C Offset: 0x2E3F77C VA: 0x2E4377C
	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x2E437C8 Offset: 0x2E3F7C8 VA: 0x2E437C8
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x2E4384C Offset: 0x2E3F84C VA: 0x2E4384C
	internal static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x2E43870 Offset: 0x2E3F870 VA: 0x2E43870
	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	// RVA: 0x2E43894 Offset: 0x2E3F894 VA: 0x2E43894
	internal static uint ToUInt32(byte[] value, int startIndex) { }
}

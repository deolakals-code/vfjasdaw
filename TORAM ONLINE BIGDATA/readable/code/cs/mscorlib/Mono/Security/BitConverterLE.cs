// Assembly: mscorlib.dll
// Namespace: Mono.Security
internal sealed class BitConverterLE // TypeDefIndex: 9471
{
	// Methods

	// RVA: 0x2E71D60 Offset: 0x2E6DD60 VA: 0x2E71D60
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x2E71DF8 Offset: 0x2E6DDF8 VA: 0x2E71DF8
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x2E71ED0 Offset: 0x2E6DED0 VA: 0x2E71ED0
	internal static byte[] GetBytes(float value) { }

	// RVA: 0x2E71EE8 Offset: 0x2E6DEE8 VA: 0x2E71EE8
	internal static byte[] GetBytes(double value) { }

	// RVA: 0x2E71F00 Offset: 0x2E6DF00 VA: 0x2E71F00
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x2E71F84 Offset: 0x2E6DF84 VA: 0x2E71F84
	private static void ULongFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x2E71FD8 Offset: 0x2E6DFD8 VA: 0x2E71FD8
	internal static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x2E71FFC Offset: 0x2E6DFFC VA: 0x2E71FFC
	internal static double ToDouble(byte[] value, int startIndex) { }
}

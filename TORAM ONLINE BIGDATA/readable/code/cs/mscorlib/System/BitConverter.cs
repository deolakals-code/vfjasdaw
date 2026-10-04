// Assembly: mscorlib.dll
// Namespace: System
public static class BitConverter // TypeDefIndex: 9557
{
	// Fields
	[Intrinsic]
	public static readonly bool IsLittleEndian; // 0x0

	// Methods

	// RVA: 0x2F737BC Offset: 0x2F6F7BC VA: 0x2F737BC
	public static byte[] GetBytes(bool value) { }

	// RVA: 0x2F73824 Offset: 0x2F6F824 VA: 0x2F73824
	public static byte[] GetBytes(char value) { }

	// RVA: 0x2F73888 Offset: 0x2F6F888 VA: 0x2F73888
	public static byte[] GetBytes(short value) { }

	// RVA: 0x2F738EC Offset: 0x2F6F8EC VA: 0x2F738EC
	public static byte[] GetBytes(int value) { }

	// RVA: 0x2F73950 Offset: 0x2F6F950 VA: 0x2F73950
	public static byte[] GetBytes(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F739B4 Offset: 0x2F6F9B4 VA: 0x2F739B4
	public static byte[] GetBytes(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F73A18 Offset: 0x2F6FA18 VA: 0x2F73A18
	public static byte[] GetBytes(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F73A7C Offset: 0x2F6FA7C VA: 0x2F73A7C
	public static bool TryWriteBytes(Span<byte> destination, uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F73AFC Offset: 0x2F6FAFC VA: 0x2F73AFC
	public static byte[] GetBytes(ulong value) { }

	// RVA: 0x2F73B60 Offset: 0x2F6FB60 VA: 0x2F73B60
	public static byte[] GetBytes(float value) { }

	// RVA: 0x2F73BCC Offset: 0x2F6FBCC VA: 0x2F73BCC
	public static byte[] GetBytes(double value) { }

	// RVA: 0x2F73C38 Offset: 0x2F6FC38 VA: 0x2F73C38
	public static short ToInt16(byte[] value, int startIndex) { }

	// RVA: 0x2F73CBC Offset: 0x2F6FCBC VA: 0x2F73CBC
	public static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x2F73D40 Offset: 0x2F6FD40 VA: 0x2F73D40
	public static long ToInt64(byte[] value, int startIndex) { }

	// RVA: 0x2F73DC4 Offset: 0x2F6FDC4 VA: 0x2F73DC4
	public static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x2F73DD8 Offset: 0x2F6FDD8 VA: 0x2F73DD8
	public static double ToDouble(byte[] value, int startIndex) { }

	// RVA: 0x2F73DEC Offset: 0x2F6FDEC VA: 0x2F73DEC
	public static string ToString(byte[] value, int startIndex, int length) { }

	// RVA: 0x2F740D8 Offset: 0x2F700D8 VA: 0x2F740D8
	public static string ToString(byte[] value) { }

	// RVA: 0x2F74100 Offset: 0x2F70100 VA: 0x2F74100
	public static long DoubleToInt64Bits(double value) { }

	// RVA: 0x2F74108 Offset: 0x2F70108 VA: 0x2F74108
	public static double Int64BitsToDouble(long value) { }

	// RVA: 0x2F74110 Offset: 0x2F70110 VA: 0x2F74110
	public static int SingleToInt32Bits(float value) { }

	// RVA: 0x2F74118 Offset: 0x2F70118 VA: 0x2F74118
	public static float Int32BitsToSingle(int value) { }

	// RVA: 0x2F74120 Offset: 0x2F70120 VA: 0x2F74120
	private static void .cctor() { }
}

// Assembly: mscorlib.dll
// Namespace: System
[Extension]
public static class Convert // TypeDefIndex: 9563
{
	// Fields
	private static readonly sbyte[] s_decodingMap; // 0x0
	internal static readonly Type[] ConvertTypes; // 0x8
	private static readonly Type EnumType; // 0x10
	internal static readonly char[] base64Table; // 0x18
	public static readonly object DBNull; // 0x20

	// Methods

	// RVA: 0x2F793C8 Offset: 0x2F753C8 VA: 0x2F793C8
	private static bool TryDecodeFromUtf16(ReadOnlySpan<char> utf16, Span<byte> bytes, out int consumed, out int written) { }

	// RVA: 0x2F79724 Offset: 0x2F75724 VA: 0x2F79724
	private static int Decode(ref char encodedChars, ref sbyte decodingMap) { }

	// RVA: 0x2F79774 Offset: 0x2F75774 VA: 0x2F79774
	private static void WriteThreeLowOrderBytes(ref byte destination, int value) { }

	// RVA: 0x2F7978C Offset: 0x2F7578C VA: 0x2F7978C
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x2F79850 Offset: 0x2F75850 VA: 0x2F79850
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x2F753D8 Offset: 0x2F713D8 VA: 0x2F753D8
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x2F7A140 Offset: 0x2F76140 VA: 0x2F7A140
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x2F7ADE8 Offset: 0x2F76DE8 VA: 0x2F7ADE8
	private static void ThrowCharOverflowException() { }

	// RVA: 0x2F7AE34 Offset: 0x2F76E34 VA: 0x2F7AE34
	private static void ThrowByteOverflowException() { }

	// RVA: 0x2F7AE80 Offset: 0x2F76E80 VA: 0x2F7AE80
	private static void ThrowSByteOverflowException() { }

	// RVA: 0x2F7AECC Offset: 0x2F76ECC VA: 0x2F7AECC
	private static void ThrowInt16OverflowException() { }

	// RVA: 0x2F7AF18 Offset: 0x2F76F18 VA: 0x2F7AF18
	private static void ThrowUInt16OverflowException() { }

	// RVA: 0x2F7AF64 Offset: 0x2F76F64 VA: 0x2F7AF64
	private static void ThrowInt32OverflowException() { }

	// RVA: 0x2F7AFB0 Offset: 0x2F76FB0 VA: 0x2F7AFB0
	private static void ThrowUInt32OverflowException() { }

	// RVA: 0x2F7AFFC Offset: 0x2F76FFC VA: 0x2F7AFFC
	private static void ThrowInt64OverflowException() { }

	// RVA: 0x2F7B048 Offset: 0x2F77048 VA: 0x2F7B048
	private static void ThrowUInt64OverflowException() { }

	// RVA: 0x2F7B094 Offset: 0x2F77094 VA: 0x2F7B094
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B198 Offset: 0x2F77198 VA: 0x2F7B198
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x2F76CC4 Offset: 0x2F72CC4 VA: 0x2F76CC4
	public static bool ToBoolean(byte value) { }

	// RVA: 0x2F7B1A4 Offset: 0x2F771A4 VA: 0x2F7B1A4
	public static bool ToBoolean(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B1B0 Offset: 0x2F771B0 VA: 0x2F7B1B0
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x2F7B1BC Offset: 0x2F771BC VA: 0x2F7B1BC
	public static bool ToBoolean(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B1C8 Offset: 0x2F771C8 VA: 0x2F7B1C8
	public static bool ToBoolean(uint value) { }

	// RVA: 0x2F7B1D4 Offset: 0x2F771D4 VA: 0x2F7B1D4
	public static bool ToBoolean(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B1E0 Offset: 0x2F771E0 VA: 0x2F7B1E0
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x2F7B1EC Offset: 0x2F771EC VA: 0x2F7B1EC
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x2F7B254 Offset: 0x2F77254 VA: 0x2F7B254
	public static bool ToBoolean(float value) { }

	// RVA: 0x2F7B260 Offset: 0x2F77260 VA: 0x2F7B260
	public static bool ToBoolean(double value) { }

	// RVA: 0x2F7B26C Offset: 0x2F7726C VA: 0x2F7B26C
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x2F7B2E0 Offset: 0x2F772E0 VA: 0x2F7B2E0
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B3E4 Offset: 0x2F773E4 VA: 0x2F7B3E4
	public static char ToChar(sbyte value) { }

	// RVA: 0x2F76D28 Offset: 0x2F72D28 VA: 0x2F76D28
	public static char ToChar(byte value) { }

	// RVA: 0x2F7B438 Offset: 0x2F77438 VA: 0x2F7B438
	public static char ToChar(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B48C Offset: 0x2F7748C VA: 0x2F7B48C
	public static char ToChar(ushort value) { }

	// RVA: 0x2F7B490 Offset: 0x2F77490 VA: 0x2F7B490
	public static char ToChar(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B4E8 Offset: 0x2F774E8 VA: 0x2F7B4E8
	public static char ToChar(uint value) { }

	// RVA: 0x2F7B540 Offset: 0x2F77540 VA: 0x2F7B540
	public static char ToChar(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B598 Offset: 0x2F77598 VA: 0x2F7B598
	public static char ToChar(ulong value) { }

	// RVA: 0x2F7B5F0 Offset: 0x2F775F0 VA: 0x2F7B5F0
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B68C Offset: 0x2F7768C VA: 0x2F7B68C
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F74E3C Offset: 0x2F70E3C VA: 0x2F74E3C
	public static sbyte ToSByte(bool value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F77C88 Offset: 0x2F73C88 VA: 0x2F77C88
	public static sbyte ToSByte(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F76D88 Offset: 0x2F72D88 VA: 0x2F76D88
	public static sbyte ToSByte(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B790 Offset: 0x2F77790 VA: 0x2F7B790
	public static sbyte ToSByte(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B7F0 Offset: 0x2F777F0 VA: 0x2F7B7F0
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B84C Offset: 0x2F7784C VA: 0x2F7B84C
	public static sbyte ToSByte(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B8A4 Offset: 0x2F778A4 VA: 0x2F7B8A4
	public static sbyte ToSByte(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B8FC Offset: 0x2F778FC VA: 0x2F7B8FC
	public static sbyte ToSByte(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B954 Offset: 0x2F77954 VA: 0x2F7B954
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7B9AC Offset: 0x2F779AC VA: 0x2F7B9AC
	public static sbyte ToSByte(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7BA08 Offset: 0x2F77A08 VA: 0x2F7BA08
	public static sbyte ToSByte(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7BB68 Offset: 0x2F77B68 VA: 0x2F7BB68
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7BBDC Offset: 0x2F77BDC VA: 0x2F7BBDC
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x2F7BBEC Offset: 0x2F77BEC VA: 0x2F7BBEC
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x2F74EA0 Offset: 0x2F70EA0 VA: 0x2F74EA0
	public static byte ToByte(bool value) { }

	// RVA: 0x2F77D3C Offset: 0x2F73D3C VA: 0x2F77D3C
	public static byte ToByte(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7BCF0 Offset: 0x2F77CF0 VA: 0x2F7BCF0
	public static byte ToByte(sbyte value) { }

	// RVA: 0x2F7BD44 Offset: 0x2F77D44 VA: 0x2F7BD44
	public static byte ToByte(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7BDA0 Offset: 0x2F77DA0 VA: 0x2F7BDA0
	public static byte ToByte(ushort value) { }

	// RVA: 0x2F7BDFC Offset: 0x2F77DFC VA: 0x2F7BDFC
	public static byte ToByte(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7BE54 Offset: 0x2F77E54 VA: 0x2F7BE54
	public static byte ToByte(uint value) { }

	// RVA: 0x2F7BEAC Offset: 0x2F77EAC VA: 0x2F7BEAC
	public static byte ToByte(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7BF04 Offset: 0x2F77F04 VA: 0x2F7BF04
	public static byte ToByte(ulong value) { }

	// RVA: 0x2F7BF5C Offset: 0x2F77F5C VA: 0x2F7BF5C
	public static byte ToByte(float value) { }

	// RVA: 0x2F7BFB8 Offset: 0x2F77FB8 VA: 0x2F7BFB8
	public static byte ToByte(double value) { }

	// RVA: 0x2F7C018 Offset: 0x2F78018 VA: 0x2F7C018
	public static byte ToByte(Decimal value) { }

	// RVA: 0x2F7C08C Offset: 0x2F7808C VA: 0x2F7C08C
	public static byte ToByte(string value) { }

	// RVA: 0x2F7C100 Offset: 0x2F78100 VA: 0x2F7C100
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x2F7C114 Offset: 0x2F78114 VA: 0x2F7C114
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x2F74F04 Offset: 0x2F70F04 VA: 0x2F74F04
	public static short ToInt16(bool value) { }

	// RVA: 0x2F77DF0 Offset: 0x2F73DF0 VA: 0x2F77DF0
	public static short ToInt16(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C218 Offset: 0x2F78218 VA: 0x2F7C218
	public static short ToInt16(sbyte value) { }

	// RVA: 0x2F76E3C Offset: 0x2F72E3C VA: 0x2F76E3C
	public static short ToInt16(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C220 Offset: 0x2F78220 VA: 0x2F7C220
	public static short ToInt16(ushort value) { }

	// RVA: 0x2F7C274 Offset: 0x2F78274 VA: 0x2F7C274
	public static short ToInt16(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C2CC Offset: 0x2F782CC VA: 0x2F7C2CC
	public static short ToInt16(uint value) { }

	// RVA: 0x2F7C324 Offset: 0x2F78324 VA: 0x2F7C324
	public static short ToInt16(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C37C Offset: 0x2F7837C VA: 0x2F7C37C
	public static short ToInt16(ulong value) { }

	// RVA: 0x2F7C3D4 Offset: 0x2F783D4 VA: 0x2F7C3D4
	public static short ToInt16(float value) { }

	// RVA: 0x2F7C430 Offset: 0x2F78430 VA: 0x2F7C430
	public static short ToInt16(double value) { }

	// RVA: 0x2F7C490 Offset: 0x2F78490 VA: 0x2F7C490
	public static short ToInt16(Decimal value) { }

	// RVA: 0x2F7C504 Offset: 0x2F78504 VA: 0x2F7C504
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C51C Offset: 0x2F7851C VA: 0x2F7C51C
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F74F68 Offset: 0x2F70F68 VA: 0x2F74F68
	public static ushort ToUInt16(bool value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F77E9C Offset: 0x2F73E9C VA: 0x2F77E9C
	public static ushort ToUInt16(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C620 Offset: 0x2F78620 VA: 0x2F7C620
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F76E9C Offset: 0x2F72E9C VA: 0x2F76E9C
	public static ushort ToUInt16(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C674 Offset: 0x2F78674 VA: 0x2F7C674
	public static ushort ToUInt16(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C6C8 Offset: 0x2F786C8 VA: 0x2F7C6C8
	public static ushort ToUInt16(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C720 Offset: 0x2F78720 VA: 0x2F7C720
	public static ushort ToUInt16(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C778 Offset: 0x2F78778 VA: 0x2F7C778
	public static ushort ToUInt16(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C7D0 Offset: 0x2F787D0 VA: 0x2F7C7D0
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C828 Offset: 0x2F78828 VA: 0x2F7C828
	public static ushort ToUInt16(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C884 Offset: 0x2F78884 VA: 0x2F7C884
	public static ushort ToUInt16(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C8E4 Offset: 0x2F788E4 VA: 0x2F7C8E4
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7C958 Offset: 0x2F78958 VA: 0x2F7C958
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x2F7C970 Offset: 0x2F78970 VA: 0x2F7C970
	public static int ToInt32(object value) { }

	// RVA: 0x2F7CA64 Offset: 0x2F78A64 VA: 0x2F7CA64
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x2F74FCC Offset: 0x2F70FCC VA: 0x2F74FCC
	public static int ToInt32(bool value) { }

	// RVA: 0x2F77EF8 Offset: 0x2F73EF8 VA: 0x2F77EF8
	public static int ToInt32(char value) { }

	// RVA: 0x2F76EFC Offset: 0x2F72EFC VA: 0x2F76EFC
	public static int ToInt32(byte value) { }

	// RVA: 0x2F7CB68 Offset: 0x2F78B68 VA: 0x2F7CB68
	public static int ToInt32(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7CB70 Offset: 0x2F78B70 VA: 0x2F7CB70
	public static int ToInt32(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7CB78 Offset: 0x2F78B78 VA: 0x2F7CB78
	public static int ToInt32(uint value) { }

	// RVA: 0x2F7CBCC Offset: 0x2F78BCC VA: 0x2F7CBCC
	public static int ToInt32(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7CC24 Offset: 0x2F78C24 VA: 0x2F7CC24
	public static int ToInt32(ulong value) { }

	// RVA: 0x2F7CC7C Offset: 0x2F78C7C VA: 0x2F7CC7C
	public static int ToInt32(float value) { }

	// RVA: 0x2F7BA68 Offset: 0x2F77A68 VA: 0x2F7BA68
	public static int ToInt32(double value) { }

	// RVA: 0x2F7CCD8 Offset: 0x2F78CD8 VA: 0x2F7CCD8
	public static int ToInt32(Decimal value) { }

	// RVA: 0x2F7CD4C Offset: 0x2F78D4C VA: 0x2F7CD4C
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7CD64 Offset: 0x2F78D64 VA: 0x2F7CD64
	public static uint ToUInt32(object value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7CE58 Offset: 0x2F78E58 VA: 0x2F7CE58
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F75030 Offset: 0x2F71030 VA: 0x2F75030
	public static uint ToUInt32(bool value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F77F58 Offset: 0x2F73F58 VA: 0x2F77F58
	public static uint ToUInt32(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7CF5C Offset: 0x2F78F5C VA: 0x2F7CF5C
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F76F5C Offset: 0x2F72F5C VA: 0x2F76F5C
	public static uint ToUInt32(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7CFB0 Offset: 0x2F78FB0 VA: 0x2F7CFB0
	public static uint ToUInt32(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D004 Offset: 0x2F79004 VA: 0x2F7D004
	public static uint ToUInt32(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D00C Offset: 0x2F7900C VA: 0x2F7D00C
	public static uint ToUInt32(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D060 Offset: 0x2F79060 VA: 0x2F7D060
	public static uint ToUInt32(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D0B8 Offset: 0x2F790B8 VA: 0x2F7D0B8
	public static uint ToUInt32(ulong value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D110 Offset: 0x2F79110 VA: 0x2F7D110
	public static uint ToUInt32(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D16C Offset: 0x2F7916C VA: 0x2F7D16C
	public static uint ToUInt32(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D214 Offset: 0x2F79214 VA: 0x2F7D214
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D288 Offset: 0x2F79288 VA: 0x2F7D288
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x2F7D2A0 Offset: 0x2F792A0 VA: 0x2F7D2A0
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x2F75094 Offset: 0x2F71094 VA: 0x2F75094
	public static long ToInt64(bool value) { }

	// RVA: 0x2F77FB8 Offset: 0x2F73FB8 VA: 0x2F77FB8
	public static long ToInt64(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D3A4 Offset: 0x2F793A4 VA: 0x2F7D3A4
	public static long ToInt64(sbyte value) { }

	// RVA: 0x2F76FBC Offset: 0x2F72FBC VA: 0x2F76FBC
	public static long ToInt64(byte value) { }

	// RVA: 0x2F7D3AC Offset: 0x2F793AC VA: 0x2F7D3AC
	public static long ToInt64(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D3B4 Offset: 0x2F793B4 VA: 0x2F7D3B4
	public static long ToInt64(ushort value) { }

	// RVA: 0x2F7D3BC Offset: 0x2F793BC VA: 0x2F7D3BC
	public static long ToInt64(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D3C4 Offset: 0x2F793C4 VA: 0x2F7D3C4
	public static long ToInt64(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D3CC Offset: 0x2F793CC VA: 0x2F7D3CC
	public static long ToInt64(ulong value) { }

	// RVA: 0x2F7D420 Offset: 0x2F79420 VA: 0x2F7D420
	public static long ToInt64(float value) { }

	// RVA: 0x2F7D47C Offset: 0x2F7947C VA: 0x2F7D47C
	public static long ToInt64(double value) { }

	// RVA: 0x2F7D58C Offset: 0x2F7958C VA: 0x2F7D58C
	public static long ToInt64(Decimal value) { }

	// RVA: 0x2F7D600 Offset: 0x2F79600 VA: 0x2F7D600
	public static long ToInt64(string value) { }

	// RVA: 0x2F7D678 Offset: 0x2F79678 VA: 0x2F7D678
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D690 Offset: 0x2F79690 VA: 0x2F7D690
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F750F8 Offset: 0x2F710F8 VA: 0x2F750F8
	public static ulong ToUInt64(bool value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F78018 Offset: 0x2F74018 VA: 0x2F78018
	public static ulong ToUInt64(char value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D794 Offset: 0x2F79794 VA: 0x2F7D794
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7701C Offset: 0x2F7301C VA: 0x2F7701C
	public static ulong ToUInt64(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D7E8 Offset: 0x2F797E8 VA: 0x2F7D7E8
	public static ulong ToUInt64(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D83C Offset: 0x2F7983C VA: 0x2F7D83C
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D844 Offset: 0x2F79844 VA: 0x2F7D844
	public static ulong ToUInt64(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D898 Offset: 0x2F79898 VA: 0x2F7D898
	public static ulong ToUInt64(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D8A0 Offset: 0x2F798A0 VA: 0x2F7D8A0
	public static ulong ToUInt64(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D8F4 Offset: 0x2F798F4 VA: 0x2F7D8F4
	public static ulong ToUInt64(float value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7D950 Offset: 0x2F79950 VA: 0x2F7D950
	public static ulong ToUInt64(double value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7DA4C Offset: 0x2F79A4C VA: 0x2F7DA4C
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7DAC0 Offset: 0x2F79AC0 VA: 0x2F7DAC0
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x2F7DAD8 Offset: 0x2F79AD8 VA: 0x2F7DAD8
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7DBDC Offset: 0x2F79BDC VA: 0x2F7DBDC
	public static float ToSingle(sbyte value) { }

	// RVA: 0x2F7707C Offset: 0x2F7307C VA: 0x2F7707C
	public static float ToSingle(byte value) { }

	// RVA: 0x2F7DBE8 Offset: 0x2F79BE8 VA: 0x2F7DBE8
	public static float ToSingle(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7DBF4 Offset: 0x2F79BF4 VA: 0x2F7DBF4
	public static float ToSingle(ushort value) { }

	// RVA: 0x2F7DC00 Offset: 0x2F79C00 VA: 0x2F7DC00
	public static float ToSingle(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7DC08 Offset: 0x2F79C08 VA: 0x2F7DC08
	public static float ToSingle(uint value) { }

	// RVA: 0x2F7DC10 Offset: 0x2F79C10 VA: 0x2F7DC10
	public static float ToSingle(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7DC18 Offset: 0x2F79C18 VA: 0x2F7DC18
	public static float ToSingle(ulong value) { }

	// RVA: 0x2F7DC24 Offset: 0x2F79C24 VA: 0x2F7DC24
	public static float ToSingle(double value) { }

	// RVA: 0x2F7DC2C Offset: 0x2F79C2C VA: 0x2F7DC2C
	public static float ToSingle(Decimal value) { }

	// RVA: 0x2F7DC94 Offset: 0x2F79C94 VA: 0x2F7DC94
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x2F75164 Offset: 0x2F71164 VA: 0x2F75164
	public static float ToSingle(bool value) { }

	// RVA: 0x2F7DCB0 Offset: 0x2F79CB0 VA: 0x2F7DCB0
	public static double ToDouble(object value) { }

	// RVA: 0x2F7DDA4 Offset: 0x2F79DA4 VA: 0x2F7DDA4
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7DEA8 Offset: 0x2F79EA8 VA: 0x2F7DEA8
	public static double ToDouble(sbyte value) { }

	// RVA: 0x2F770E0 Offset: 0x2F730E0 VA: 0x2F770E0
	public static double ToDouble(byte value) { }

	// RVA: 0x2F7DEB4 Offset: 0x2F79EB4 VA: 0x2F7DEB4
	public static double ToDouble(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7DEC0 Offset: 0x2F79EC0 VA: 0x2F7DEC0
	public static double ToDouble(ushort value) { }

	// RVA: 0x2F7DECC Offset: 0x2F79ECC VA: 0x2F7DECC
	public static double ToDouble(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7DED4 Offset: 0x2F79ED4 VA: 0x2F7DED4
	public static double ToDouble(uint value) { }

	// RVA: 0x2F7DEDC Offset: 0x2F79EDC VA: 0x2F7DEDC
	public static double ToDouble(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7DEE4 Offset: 0x2F79EE4 VA: 0x2F7DEE4
	public static double ToDouble(ulong value) { }

	// RVA: 0x2F7DEEC Offset: 0x2F79EEC VA: 0x2F7DEEC
	public static double ToDouble(float value) { }

	// RVA: 0x2F7DEF4 Offset: 0x2F79EF4 VA: 0x2F7DEF4
	public static double ToDouble(Decimal value) { }

	// RVA: 0x2F7DF5C Offset: 0x2F79F5C VA: 0x2F7DF5C
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x2F751DC Offset: 0x2F711DC VA: 0x2F751DC
	public static double ToDouble(bool value) { }

	// RVA: 0x2F7DF78 Offset: 0x2F79F78 VA: 0x2F7DF78
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7E0A0 Offset: 0x2F7A0A0 VA: 0x2F7E0A0
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x2F77144 Offset: 0x2F73144 VA: 0x2F77144
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x2F7E0F8 Offset: 0x2F7A0F8 VA: 0x2F7E0F8
	public static Decimal ToDecimal(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7E150 Offset: 0x2F7A150 VA: 0x2F7E150
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x2F7E1A8 Offset: 0x2F7A1A8 VA: 0x2F7E1A8
	public static Decimal ToDecimal(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7E200 Offset: 0x2F7A200 VA: 0x2F7E200
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x2F7E258 Offset: 0x2F7A258 VA: 0x2F7E258
	public static Decimal ToDecimal(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7E2B0 Offset: 0x2F7A2B0 VA: 0x2F7E2B0
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x2F7E308 Offset: 0x2F7A308 VA: 0x2F7E308
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x2F7E368 Offset: 0x2F7A368 VA: 0x2F7E368
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x2F7E3C8 Offset: 0x2F7A3C8 VA: 0x2F7E3C8
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x2F7524C Offset: 0x2F7124C VA: 0x2F7524C
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x2F7E450 Offset: 0x2F7A450 VA: 0x2F7E450
	public static DateTime ToDateTime(object value, IFormatProvider provider) { }

	// RVA: 0x2F7E580 Offset: 0x2F7A580 VA: 0x2F7E580
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x2F7E610 Offset: 0x2F7A610 VA: 0x2F7E610
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x2F7E7B0 Offset: 0x2F7A7B0 VA: 0x2F7E7B0
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x2F7E808 Offset: 0x2F7A808 VA: 0x2F7E808
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x2F7E824 Offset: 0x2F7A824 VA: 0x2F7E824
	public static byte ToByte(string value, int fromBase) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7E92C Offset: 0x2F7A92C VA: 0x2F7E92C
	public static sbyte ToSByte(string value, int fromBase) { }

	// RVA: 0x2F7EA44 Offset: 0x2F7AA44 VA: 0x2F7EA44
	public static short ToInt16(string value, int fromBase) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7EB5C Offset: 0x2F7AB5C VA: 0x2F7EB5C
	public static ushort ToUInt16(string value, int fromBase) { }

	// RVA: 0x2F7EC64 Offset: 0x2F7AC64 VA: 0x2F7EC64
	public static int ToInt32(string value, int fromBase) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7ED38 Offset: 0x2F7AD38 VA: 0x2F7ED38
	public static uint ToUInt32(string value, int fromBase) { }

	// RVA: 0x2F7EE0C Offset: 0x2F7AE0C VA: 0x2F7EE0C
	public static long ToInt64(string value, int fromBase) { }

	[CLSCompliant(False)]
	// RVA: 0x2F7EEE0 Offset: 0x2F7AEE0 VA: 0x2F7EEE0
	public static ulong ToUInt64(string value, int fromBase) { }

	// RVA: 0x2F7EFB4 Offset: 0x2F7AFB4 VA: 0x2F7EFB4
	public static string ToString(int value, int toBase) { }

	// RVA: 0x2F7F034 Offset: 0x2F7B034 VA: 0x2F7F034
	public static string ToString(long value, int toBase) { }

	// RVA: 0x2F7F0B4 Offset: 0x2F7B0B4 VA: 0x2F7F0B4
	public static string ToBase64String(byte[] inArray) { }

	// RVA: 0x2F7F318 Offset: 0x2F7B318 VA: 0x2F7F318
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	// RVA: 0x2F7F388 Offset: 0x2F7B388 VA: 0x2F7F388
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x2F7F168 Offset: 0x2F7B168 VA: 0x2F7F168
	public static string ToBase64String(ReadOnlySpan<byte> bytes, Base64FormattingOptions options = 0) { }

	// RVA: 0x2F7F818 Offset: 0x2F7B818 VA: 0x2F7F818
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut) { }

	// RVA: 0x2F7F8A0 Offset: 0x2F7B8A0 VA: 0x2F7F8A0
	public static int ToBase64CharArray(byte[] inArray, int offsetIn, int length, char[] outArray, int offsetOut, Base64FormattingOptions options) { }

	// RVA: 0x2F7F5D4 Offset: 0x2F7B5D4 VA: 0x2F7F5D4
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x2F7F524 Offset: 0x2F7B524 VA: 0x2F7F524
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x2F7FBAC Offset: 0x2F7BBAC VA: 0x2F7FBAC
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x2F7FDE8 Offset: 0x2F7BDE8 VA: 0x2F7FDE8
	public static bool TryFromBase64Chars(ReadOnlySpan<char> chars, Span<byte> bytes, out int bytesWritten) { }

	// RVA: 0x2F802BC Offset: 0x2F7C2BC VA: 0x2F802BC
	private static void CopyToTempBufferWithoutWhiteSpace(ReadOnlySpan<char> chars, Span<char> tempBuffer, out int consumed, out int charsWritten) { }

	[Extension]
	// RVA: 0x2F803E0 Offset: 0x2F7C3E0 VA: 0x2F803E0
	private static bool IsSpace(char c) { }

	// RVA: 0x2F8040C Offset: 0x2F7C40C VA: 0x2F8040C
	public static byte[] FromBase64CharArray(char[] inArray, int offset, int length) { }

	// RVA: 0x2F7FC60 Offset: 0x2F7BC60 VA: 0x2F7FC60
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x2F805FC Offset: 0x2F7C5FC VA: 0x2F805FC
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x2F806B8 Offset: 0x2F7C6B8 VA: 0x2F806B8
	private static void .cctor() { }
}

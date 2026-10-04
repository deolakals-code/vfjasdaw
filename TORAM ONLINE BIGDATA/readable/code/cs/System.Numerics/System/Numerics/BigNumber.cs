// Assembly: System.Numerics.dll
// Namespace: System.Numerics
internal static class BigNumber // TypeDefIndex: 17491
{
	// Methods

	// RVA: 0x32A3924 Offset: 0x329F924 VA: 0x32A3924
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	// RVA: 0x32A3A3C Offset: 0x329FA3C VA: 0x32A3A3C
	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	// RVA: 0x329F71C Offset: 0x329B71C VA: 0x329F71C
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x32A40E0 Offset: 0x32A00E0 VA: 0x32A40E0
	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x32A3D04 Offset: 0x329FD04 VA: 0x32A3D04
	private static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x32A3EB4 Offset: 0x329FEB4 VA: 0x32A3EB4
	private static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x32A421C Offset: 0x32A021C VA: 0x32A421C
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) { }

	// RVA: 0x32A430C Offset: 0x32A030C VA: 0x32A430C
	private static string FormatBigIntegerToHex(bool targetSpan, BigInteger value, char format, int digits, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) { }

	// RVA: 0x32A03A0 Offset: 0x329C3A0 VA: 0x32A03A0
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

	// RVA: 0x32A4C44 Offset: 0x32A0C44 VA: 0x32A4C44
	private static string FormatBigInteger(bool targetSpan, BigInteger value, string formatString, ReadOnlySpan<char> formatSpan, NumberFormatInfo info, Span<char> destination, out int charsWritten, out bool spanSuccess) { }
}

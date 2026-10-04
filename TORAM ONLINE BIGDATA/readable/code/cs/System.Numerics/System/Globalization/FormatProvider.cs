// Assembly: System.Numerics.dll
// Namespace: System.Globalization
internal class FormatProvider // TypeDefIndex: 17496
{
	// Methods

	// RVA: 0x32A5624 Offset: 0x32A1624 VA: 0x32A5624
	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	// RVA: 0x32A3C10 Offset: 0x329FC10 VA: 0x32A3C10
	internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }
}

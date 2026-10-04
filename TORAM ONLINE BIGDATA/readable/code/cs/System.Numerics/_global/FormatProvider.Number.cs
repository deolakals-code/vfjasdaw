// Assembly: System.Numerics.dll
// Namespace: 
private class FormatProvider.Number // TypeDefIndex: 17495
{
	// Fields
	private static string[] s_posCurrencyFormats; // 0x0
	private static string[] s_negCurrencyFormats; // 0x8
	private static string[] s_posPercentFormats; // 0x10
	private static string[] s_negPercentFormats; // 0x18
	private static string[] s_negNumberFormats; // 0x20
	private static string s_posNumberFormat; // 0x28

	// Methods

	// RVA: 0x32A6FF4 Offset: 0x32A2FF4 VA: 0x32A6FF4
	private static bool IsWhite(char ch) { }

	// RVA: 0x32A701C Offset: 0x32A301C VA: 0x32A701C
	private static char* MatchChars(char* p, char* pEnd, string str) { }

	// RVA: 0x32A70E0 Offset: 0x32A30E0 VA: 0x32A70E0
	private static char* MatchChars(char* p, char* pEnd, char* str) { }

	// RVA: 0x32A713C Offset: 0x32A313C VA: 0x32A713C
	private static bool ParseNumber(ref char* str, char* strEnd, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x32A7840 Offset: 0x32A3840 VA: 0x32A7840
	private static bool TrailingZeros(ReadOnlySpan<char> s, int index) { }

	// RVA: 0x32A6EBC Offset: 0x32A2EBC VA: 0x32A6EBC
	internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x32A78D0 Offset: 0x32A38D0 VA: 0x32A78D0
	internal static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) { }

	// RVA: 0x32A5788 Offset: 0x32A1788 VA: 0x32A5788
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) { }

	// RVA: 0x32A58CC Offset: 0x32A18CC VA: 0x32A58CC
	internal static void NumberToString(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x32A79FC Offset: 0x32A39FC VA: 0x32A79FC
	private static void FormatCurrency(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x32A8BD4 Offset: 0x32A4BD4 VA: 0x32A8BD4
	private static int wcslen(char* s) { }

	// RVA: 0x32A7C5C Offset: 0x32A3C5C VA: 0x32A7C5C
	private static void FormatFixed(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x32A8168 Offset: 0x32A4168 VA: 0x32A8168
	private static void FormatNumber(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x32A83B0 Offset: 0x32A43B0 VA: 0x32A83B0
	private static void FormatScientific(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x32A8DFC Offset: 0x32A4DFC VA: 0x32A8DFC
	private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x32A85EC Offset: 0x32A45EC VA: 0x32A85EC
	private static void FormatGeneral(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x32A8974 Offset: 0x32A4974 VA: 0x32A8974
	private static void FormatPercent(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x32A792C Offset: 0x32A392C VA: 0x32A792C
	private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos) { }

	// RVA: 0x32A90EC Offset: 0x32A50EC VA: 0x32A90EC
	private static int FindSection(ReadOnlySpan<char> format, int section) { }

	// RVA: 0x32A5E24 Offset: 0x32A1E24 VA: 0x32A5E24
	internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref FormatProvider.Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info) { }

	// RVA: 0x32A9238 Offset: 0x32A5238 VA: 0x32A9238
	private static void .cctor() { }
}

// Assembly: mscorlib.dll
// Namespace: System
internal static class Number // TypeDefIndex: 9645
{
	// Fields
	private static readonly string[] s_posCurrencyFormats; // 0x0
	private static readonly string[] s_negCurrencyFormats; // 0x8
	private static readonly string[] s_posPercentFormats; // 0x10
	private static readonly string[] s_negPercentFormats; // 0x18
	private static readonly string[] s_negNumberFormats; // 0x20
	private static readonly int[] s_charToHexLookup; // 0x28
	private static readonly ulong[] s_rgval64Power10; // 0x30
	private static readonly sbyte[] s_rgexp64Power10; // 0x38
	private static readonly ulong[] s_rgval64Power10By16; // 0x40
	private static readonly short[] s_rgexp64Power10By16; // 0x48

	// Methods

	// RVA: 0x2FE805C Offset: 0x2FE405C VA: 0x2FE805C
	public static string FormatDecimal(Decimal value, ReadOnlySpan<char> format, NumberFormatInfo info) { }

	// RVA: 0x2FE9C54 Offset: 0x2FE5C54 VA: 0x2FE9C54
	public static bool TryFormatDecimal(Decimal value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FE8350 Offset: 0x2FE4350 VA: 0x2FE8350
	private static void DecimalToNumber(Decimal value, ref Number.NumberBuffer number) { }

	// RVA: 0x2FE9E64 Offset: 0x2FE5E64 VA: 0x2FE9E64
	public static string FormatDouble(double value, string format, NumberFormatInfo info) { }

	// RVA: 0x2FEA290 Offset: 0x2FE6290 VA: 0x2FEA290
	public static bool TryFormatDouble(double value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FE9FA4 Offset: 0x2FE5FA4 VA: 0x2FE9FA4
	private static string FormatDouble(ref ValueStringBuilder sb, double value, ReadOnlySpan<char> format, NumberFormatInfo info) { }

	// RVA: 0x2FEAD80 Offset: 0x2FE6D80 VA: 0x2FEAD80
	public static string FormatSingle(float value, string format, NumberFormatInfo info) { }

	// RVA: 0x2FEB1B8 Offset: 0x2FE71B8 VA: 0x2FEB1B8
	public static bool TryFormatSingle(float value, ReadOnlySpan<char> format, NumberFormatInfo info, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FEAEC0 Offset: 0x2FE6EC0 VA: 0x2FEAEC0
	private static string FormatSingle(ref ValueStringBuilder sb, float value, ReadOnlySpan<char> format, NumberFormatInfo info) { }

	// RVA: 0x2FEA3EC Offset: 0x2FE63EC VA: 0x2FEA3EC
	private static bool TryCopyTo(string source, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FE17F0 Offset: 0x2FDD7F0 VA: 0x2FE17F0
	public static string FormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x2FE22B8 Offset: 0x2FDE2B8 VA: 0x2FE22B8
	public static bool TryFormatInt32(int value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FE1CA0 Offset: 0x2FDDCA0 VA: 0x2FE1CA0
	public static string FormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x2FE2018 Offset: 0x2FDE018 VA: 0x2FE2018
	public static bool TryFormatUInt32(uint value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FE46E0 Offset: 0x2FE06E0 VA: 0x2FE46E0
	public static string FormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x2FE4C14 Offset: 0x2FE0C14 VA: 0x2FE4C14
	public static bool TryFormatInt64(long value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FECC8C Offset: 0x2FE8C8C VA: 0x2FECC8C
	public static string FormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x2FED080 Offset: 0x2FE9080 VA: 0x2FED080
	public static bool TryFormatUInt64(ulong value, ReadOnlySpan<char> format, IFormatProvider provider, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FED31C Offset: 0x2FE931C VA: 0x2FED31C
	private static void Int32ToNumber(int value, ref Number.NumberBuffer number) { }

	// RVA: 0x2FEB4A4 Offset: 0x2FE74A4 VA: 0x2FEB4A4
	private static string NegativeInt32ToDecStr(int value, int digits, string sNegative) { }

	// RVA: 0x2FEB94C Offset: 0x2FE794C VA: 0x2FEB94C
	private static bool TryNegativeInt32ToDecStr(int value, int digits, string sNegative, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FEB650 Offset: 0x2FE7650 VA: 0x2FEB650
	private static string Int32ToHexStr(int value, char hexBase, int digits) { }

	// RVA: 0x2FEBB34 Offset: 0x2FE7B34 VA: 0x2FEBB34
	private static bool TryInt32ToHexStr(int value, char hexBase, int digits, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FED448 Offset: 0x2FE9448 VA: 0x2FED448
	private static char* Int32ToHexChars(char* buffer, uint value, int hexBase, int digits) { }

	// RVA: 0x2FED488 Offset: 0x2FE9488 VA: 0x2FED488
	private static void UInt32ToNumber(uint value, ref Number.NumberBuffer number) { }

	// RVA: 0x2FE9E18 Offset: 0x2FE5E18 VA: 0x2FE9E18
	internal static char* UInt32ToDecChars(char* bufferEnd, uint value, int digits) { }

	// RVA: 0x2FEB314 Offset: 0x2FE7314 VA: 0x2FEB314
	private static string UInt32ToDecStr(uint value, int digits) { }

	// RVA: 0x2FEB788 Offset: 0x2FE7788 VA: 0x2FEB788
	private static bool TryUInt32ToDecStr(uint value, int digits, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FEC390 Offset: 0x2FE8390 VA: 0x2FEC390
	private static void Int64ToNumber(long input, ref Number.NumberBuffer number) { }

	// RVA: 0x2FEBF00 Offset: 0x2FE7F00 VA: 0x2FEBF00
	private static string NegativeInt64ToDecStr(long input, int digits, string sNegative) { }

	// RVA: 0x2FEC7BC Offset: 0x2FE87BC VA: 0x2FEC7BC
	private static bool TryNegativeInt64ToDecStr(long input, int digits, string sNegative, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FEC1A0 Offset: 0x2FE81A0 VA: 0x2FEC1A0
	private static string Int64ToHexStr(long value, char hexBase, int digits) { }

	// RVA: 0x2FECA88 Offset: 0x2FE8A88 VA: 0x2FECA88
	private static bool TryInt64ToHexStr(long value, char hexBase, int digits, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FECEEC Offset: 0x2FE8EEC VA: 0x2FECEEC
	private static void UInt64ToNumber(ulong value, ref Number.NumberBuffer number) { }

	// RVA: 0x2FEBCA8 Offset: 0x2FE7CA8 VA: 0x2FEBCA8
	private static string UInt64ToDecStr(ulong value, int digits) { }

	// RVA: 0x2FEC538 Offset: 0x2FE8538 VA: 0x2FEC538
	private static bool TryUInt64ToDecStr(ulong value, int digits, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FE820C Offset: 0x2FE420C VA: 0x2FE820C
	internal static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits) { }

	// RVA: 0x2FE858C Offset: 0x2FE458C VA: 0x2FE858C
	internal static void NumberToString(ref ValueStringBuilder sb, ref Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x2FE8B1C Offset: 0x2FE4B1C VA: 0x2FE8B1C
	internal static void NumberToStringFormat(ref ValueStringBuilder sb, ref Number.NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info) { }

	// RVA: 0x2FED6E0 Offset: 0x2FE96E0 VA: 0x2FED6E0
	private static void FormatCurrency(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2FED948 Offset: 0x2FE9948 VA: 0x2FED948
	private static void FormatFixed(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x2FEDE78 Offset: 0x2FE9E78 VA: 0x2FEDE78
	private static void FormatNumber(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2FEE0CC Offset: 0x2FEA0CC VA: 0x2FEE0CC
	private static void FormatScientific(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x2FEEA90 Offset: 0x2FEAA90 VA: 0x2FEEA90
	private static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x2FEE324 Offset: 0x2FEA324 VA: 0x2FEE324
	private static void FormatGeneral(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x2FEE6DC Offset: 0x2FEA6DC VA: 0x2FEE6DC
	private static void FormatPercent(ref ValueStringBuilder sb, ref Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2FED5E4 Offset: 0x2FE95E4 VA: 0x2FED5E4
	private static void RoundNumber(ref Number.NumberBuffer number, int pos) { }

	// RVA: 0x2FEE944 Offset: 0x2FEA944 VA: 0x2FEE944
	private static int FindSection(ReadOnlySpan<char> format, int section) { }

	// RVA: 0x2FED5E0 Offset: 0x2FE95E0 VA: 0x2FED5E0
	private static uint Low32(ulong value) { }

	// RVA: 0x2FED5D8 Offset: 0x2FE95D8 VA: 0x2FED5D8
	private static uint High32(ulong value) { }

	// RVA: 0x2FED5A0 Offset: 0x2FE95A0 VA: 0x2FED5A0
	private static uint Int64DivMod1E9(ref ulong value) { }

	// RVA: 0x2FEED38 Offset: 0x2FEAD38 VA: 0x2FEED38
	private static bool NumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x2FEEDF4 Offset: 0x2FEADF4 VA: 0x2FEEDF4
	private static bool NumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x2FEEEAC Offset: 0x2FEAEAC VA: 0x2FEEEAC
	private static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x2FEEF5C Offset: 0x2FEAF5C VA: 0x2FEEF5C
	private static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x2FE28E8 Offset: 0x2FDE8E8 VA: 0x2FE28E8
	internal static int ParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x2FE4FC0 Offset: 0x2FE0FC0 VA: 0x2FE4FC0
	internal static long ParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x2FF0438 Offset: 0x2FEC438 VA: 0x2FF0438
	internal static uint ParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x2FF0BBC Offset: 0x2FECBBC VA: 0x2FF0BBC
	internal static ulong ParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x2FF136C Offset: 0x2FED36C VA: 0x2FF136C
	private static bool ParseNumber(ref char* str, char* strEnd, NumberStyles styles, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	// RVA: 0x2FE2C98 Offset: 0x2FDEC98 VA: 0x2FE2C98
	internal static bool TryParseInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out int result) { }

	// RVA: 0x2FEF00C Offset: 0x2FEB00C VA: 0x2FEF00C
	private static bool TryParseInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out int result, ref bool failureIsOverflow) { }

	// RVA: 0x2FEFAFC Offset: 0x2FEBAFC VA: 0x2FEFAFC
	private static bool TryParseInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out long result, ref bool failureIsOverflow) { }

	// RVA: 0x2FE5338 Offset: 0x2FE1338 VA: 0x2FE5338
	internal static bool TryParseInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out long result) { }

	// RVA: 0x2FF1CD8 Offset: 0x2FEDCD8 VA: 0x2FF1CD8
	internal static bool TryParseUInt32(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result) { }

	// RVA: 0x2FF05E8 Offset: 0x2FEC5E8 VA: 0x2FF05E8
	private static bool TryParseUInt32IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow) { }

	// RVA: 0x2FEF674 Offset: 0x2FEB674 VA: 0x2FEF674
	private static bool TryParseUInt32HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out uint result, ref bool failureIsOverflow) { }

	// RVA: 0x2FF1E5C Offset: 0x2FEDE5C VA: 0x2FF1E5C
	internal static bool TryParseUInt64(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result) { }

	// RVA: 0x2FF0D6C Offset: 0x2FECD6C VA: 0x2FF0D6C
	private static bool TryParseUInt64IntegerStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow) { }

	// RVA: 0x2FF00E8 Offset: 0x2FEC0E8 VA: 0x2FF00E8
	private static bool TryParseUInt64HexNumberStyle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out ulong result, ref bool failureIsOverflow) { }

	// RVA: 0x2FF1FE0 Offset: 0x2FEDFE0 VA: 0x2FF1FE0
	internal static Decimal ParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x2FF20E8 Offset: 0x2FEE0E8 VA: 0x2FF20E8
	private static bool NumberBufferToDecimal(ref Number.NumberBuffer number, ref Decimal value) { }

	// RVA: 0x2FF23E0 Offset: 0x2FEE3E0 VA: 0x2FF23E0
	internal static double ParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x2FF27BC Offset: 0x2FEE7BC VA: 0x2FF27BC
	internal static float ParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info) { }

	// RVA: 0x2FF2B20 Offset: 0x2FEEB20 VA: 0x2FF2B20
	internal static bool TryParseDecimal(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out Decimal result) { }

	// RVA: 0x2FF2C24 Offset: 0x2FEEC24 VA: 0x2FF2C24
	internal static bool TryParseDouble(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out double result) { }

	// RVA: 0x2FF2D28 Offset: 0x2FEED28 VA: 0x2FF2D28
	internal static bool TryParseSingle(ReadOnlySpan<char> value, NumberStyles styles, NumberFormatInfo info, out float result) { }

	// RVA: 0x2FEF9C4 Offset: 0x2FEB9C4 VA: 0x2FEF9C4
	private static void StringToNumber(ReadOnlySpan<char> value, NumberStyles styles, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	// RVA: 0x2FF1B18 Offset: 0x2FEDB18 VA: 0x2FF1B18
	internal static bool TryStringToNumber(ReadOnlySpan<char> value, NumberStyles styles, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	// RVA: 0x2FF1C48 Offset: 0x2FEDC48 VA: 0x2FF1C48
	private static bool TrailingZeros(ReadOnlySpan<char> value, int index) { }

	// RVA: 0x2FF1A84 Offset: 0x2FEDA84 VA: 0x2FF1A84
	private static char* MatchChars(char* p, char* pEnd, string value) { }

	// RVA: 0x2FF1A68 Offset: 0x2FEDA68 VA: 0x2FF1A68
	private static bool IsWhite(int ch) { }

	// RVA: 0x2FF1B08 Offset: 0x2FEDB08 VA: 0x2FF1B08
	private static bool IsDigit(int ch) { }

	// RVA: 0x2FEF5EC Offset: 0x2FEB5EC VA: 0x2FEF5EC
	private static void ThrowOverflowOrFormatException(bool overflow, string overflowResourceKey) { }

	// RVA: 0x2FF2730 Offset: 0x2FEE730 VA: 0x2FF2730
	private static bool NumberBufferToDouble(ref Number.NumberBuffer number, ref double value) { }

	// RVA: 0x2FF2E5C Offset: 0x2FEEE5C VA: 0x2FF2E5C
	private static uint DigitsToInt(char* p, int count) { }

	// RVA: 0x2FF2E90 Offset: 0x2FEEE90 VA: 0x2FF2E90
	private static ulong Mul32x32To64(uint a, uint b) { }

	// RVA: 0x2FF2E98 Offset: 0x2FEEE98 VA: 0x2FF2E98
	private static ulong Mul64Lossy(ulong a, ulong b, ref int pexp) { }

	// RVA: 0x2FF2F30 Offset: 0x2FEEF30 VA: 0x2FF2F30
	private static int abs(int value) { }

	// RVA: 0x2FEA8A0 Offset: 0x2FE68A0 VA: 0x2FEA8A0
	private static double NumberToDouble(ref Number.NumberBuffer number) { }

	// RVA: 0x2FEA4C0 Offset: 0x2FE64C0 VA: 0x2FEA4C0
	private static void DoubleToNumber(double value, int precision, ref Number.NumberBuffer number) { }

	// RVA: 0x2FF2F3C Offset: 0x2FEEF3C VA: 0x2FF2F3C
	private static void .cctor() { }
}

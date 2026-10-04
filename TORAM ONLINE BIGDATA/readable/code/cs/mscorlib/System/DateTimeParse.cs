// Assembly: mscorlib.dll
// Namespace: System
internal static class DateTimeParse // TypeDefIndex: 9590
{
	// Fields
	internal static DateTimeParse.MatchNumberDelegate m_hebrewNumberParser; // 0x0
	private static DateTimeParse.DS[][] dateParsingStates; // 0x8

	// Methods

	// RVA: 0x2FC84AC Offset: 0x2FC44AC VA: 0x2FC84AC
	internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x2FCC4AC Offset: 0x2FC84AC VA: 0x2FCC4AC
	internal static DateTime ParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out TimeSpan offset) { }

	// RVA: 0x2FC9318 Offset: 0x2FC5318 VA: 0x2FC9318
	internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x2FCD384 Offset: 0x2FC9384 VA: 0x2FCD384
	internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x2FD2798 Offset: 0x2FCE798 VA: 0x2FD2798
	internal static bool TryParseExact(ReadOnlySpan<char> s, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x2FC86F4 Offset: 0x2FC46F4 VA: 0x2FC86F4
	internal static DateTime ParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style) { }

	// RVA: 0x2FD32B0 Offset: 0x2FCF2B0 VA: 0x2FD32B0
	internal static bool TryParseExactMultiple(ReadOnlySpan<char> s, string[] formats, DateTimeFormatInfo dtfi, DateTimeStyles style, ref DateTimeResult result) { }

	// RVA: 0x2FD3518 Offset: 0x2FCF518 VA: 0x2FD3518
	private static bool MatchWord(ref __DTString str, string target) { }

	// RVA: 0x2FD36D0 Offset: 0x2FCF6D0 VA: 0x2FD36D0
	private static bool GetTimeZoneName(ref __DTString str) { }

	// RVA: 0x2FD3780 Offset: 0x2FCF780 VA: 0x2FD3780
	internal static bool IsDigit(char ch) { }

	// RVA: 0x2FD3794 Offset: 0x2FCF794 VA: 0x2FD3794
	private static bool ParseFraction(ref __DTString str, out double result) { }

	// RVA: 0x2FD3880 Offset: 0x2FCF880 VA: 0x2FD3880
	private static bool ParseTimeZone(ref __DTString str, ref TimeSpan result) { }

	// RVA: 0x2FD3B94 Offset: 0x2FCFB94 VA: 0x2FD3B94
	private static bool HandleTimeZone(ref __DTString str, ref DateTimeResult result) { }

	// RVA: 0x2FD3D2C Offset: 0x2FCFD2C VA: 0x2FD3D2C
	private static bool Lex(DateTimeParse.DS dps, ref __DTString str, ref DateTimeToken dtok, ref DateTimeRawInfo raw, ref DateTimeResult result, ref DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x2FD4E5C Offset: 0x2FD0E5C VA: 0x2FD4E5C
	private static Calendar GetJapaneseCalendarDefaultInstance() { }

	// RVA: 0x2FD4F44 Offset: 0x2FD0F44 VA: 0x2FD4F44
	internal static Calendar GetTaiwanCalendarDefaultInstance() { }

	// RVA: 0x2FD502C Offset: 0x2FD102C VA: 0x2FD502C
	private static bool VerifyValidPunctuation(ref __DTString str) { }

	// RVA: 0x2FD51F8 Offset: 0x2FD11F8 VA: 0x2FD51F8
	private static bool GetYearMonthDayOrder(string datePattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x2FD549C Offset: 0x2FD149C VA: 0x2FD549C
	private static bool GetYearMonthOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x2FD5658 Offset: 0x2FD1658 VA: 0x2FD5658
	private static bool GetMonthDayOrder(string pattern, DateTimeFormatInfo dtfi, out int order) { }

	// RVA: 0x2FD5854 Offset: 0x2FD1854 VA: 0x2FD5854
	private static bool TryAdjustYear(ref DateTimeResult result, int year, out int adjustedYear) { }

	// RVA: 0x2FD5918 Offset: 0x2FD1918 VA: 0x2FD5918
	private static bool SetDateYMD(ref DateTimeResult result, int year, int month, int day) { }

	// RVA: 0x2FD5988 Offset: 0x2FD1988 VA: 0x2FD5988
	private static bool SetDateMDY(ref DateTimeResult result, int month, int day, int year) { }

	// RVA: 0x2FD5A04 Offset: 0x2FD1A04 VA: 0x2FD5A04
	private static bool SetDateDMY(ref DateTimeResult result, int day, int month, int year) { }

	// RVA: 0x2FD5A80 Offset: 0x2FD1A80 VA: 0x2FD5A80
	private static bool SetDateYDM(ref DateTimeResult result, int year, int day, int month) { }

	// RVA: 0x2FD5AFC Offset: 0x2FD1AFC VA: 0x2FD5AFC
	private static void GetDefaultYear(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x2FD5C94 Offset: 0x2FD1C94 VA: 0x2FD5C94
	private static bool GetDayOfNN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FD5E08 Offset: 0x2FD1E08 VA: 0x2FD5E08
	private static bool GetDayOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FD60BC Offset: 0x2FD20BC VA: 0x2FD60BC
	private static bool GetDayOfMN(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FD62E0 Offset: 0x2FD22E0 VA: 0x2FD62E0
	private static bool GetHebrewDayOfNM(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FD643C Offset: 0x2FD243C VA: 0x2FD643C
	private static bool GetDayOfNM(ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FD6660 Offset: 0x2FD2660 VA: 0x2FD6660
	private static bool GetDayOfMNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FD6944 Offset: 0x2FD2944 VA: 0x2FD6944
	private static bool GetDayOfYNN(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FD6A7C Offset: 0x2FD2A7C VA: 0x2FD6A7C
	private static bool GetDayOfNNY(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FD6BF0 Offset: 0x2FD2BF0 VA: 0x2FD6BF0
	private static bool GetDayOfYMN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x2FD6CAC Offset: 0x2FD2CAC VA: 0x2FD6CAC
	private static bool GetDayOfYN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x2FD6D68 Offset: 0x2FD2D68 VA: 0x2FD6D68
	private static bool GetDayOfYM(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x2FD6E04 Offset: 0x2FD2E04 VA: 0x2FD6E04
	private static void AdjustTimeMark(DateTimeFormatInfo dtfi, ref DateTimeRawInfo raw) { }

	// RVA: 0x2FD6EC4 Offset: 0x2FD2EC4 VA: 0x2FD6EC4
	private static bool AdjustHour(ref int hour, DateTimeParse.TM timeMark) { }

	// RVA: 0x2FD6F0C Offset: 0x2FD2F0C VA: 0x2FD6F0C
	private static bool GetTimeOfN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x2FD6F68 Offset: 0x2FD2F68 VA: 0x2FD6F68
	private static bool GetTimeOfNN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x2FD6FD8 Offset: 0x2FD2FD8 VA: 0x2FD6FD8
	private static bool GetTimeOfNNN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x2FD705C Offset: 0x2FD305C VA: 0x2FD705C
	private static bool GetDateOfDSN(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x2FD70B0 Offset: 0x2FD30B0 VA: 0x2FD70B0
	private static bool GetDateOfNDS(ref DateTimeResult result, ref DateTimeRawInfo raw) { }

	// RVA: 0x2FD7164 Offset: 0x2FD3164 VA: 0x2FD7164
	private static bool GetDateOfNNDS(ref DateTimeResult result, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FD7390 Offset: 0x2FD3390 VA: 0x2FD7390
	private static bool ProcessDateTimeSuffix(ref DateTimeResult result, ref DateTimeRawInfo raw, ref DateTimeToken dtok) { }

	// RVA: 0x2FD7488 Offset: 0x2FD3488 VA: 0x2FD7488
	internal static bool ProcessHebrewTerminalState(DateTimeParse.DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FD4AE0 Offset: 0x2FD0AE0 VA: 0x2FD4AE0
	internal static bool ProcessTerminalState(DateTimeParse.DS dps, ref __DTString str, ref DateTimeResult result, ref DateTimeStyles styles, ref DateTimeRawInfo raw, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FC80F4 Offset: 0x2FC40F4 VA: 0x2FC80F4
	internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles) { }

	// RVA: 0x2FCC18C Offset: 0x2FC818C VA: 0x2FCC18C
	internal static DateTime Parse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out TimeSpan offset) { }

	// RVA: 0x2FC8F34 Offset: 0x2FC4F34 VA: 0x2FC8F34
	internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x2FCD028 Offset: 0x2FC9028 VA: 0x2FCD028
	internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, out DateTime result, out TimeSpan offset) { }

	// RVA: 0x2FD7804 Offset: 0x2FD3804 VA: 0x2FD7804
	internal static bool TryParse(ReadOnlySpan<char> s, DateTimeFormatInfo dtfi, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x2FD8848 Offset: 0x2FD4848 VA: 0x2FD8848
	private static bool DetermineTimeZoneAdjustments(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles, bool bTimeOnly) { }

	// RVA: 0x2FD8A94 Offset: 0x2FD4A94 VA: 0x2FD8A94
	private static bool DateTimeOffsetTimeZonePostProcessing(ref __DTString str, ref DateTimeResult result, DateTimeStyles styles) { }

	// RVA: 0x2FD8CCC Offset: 0x2FD4CCC VA: 0x2FD8CCC
	private static bool AdjustTimeZoneToUniversal(ref DateTimeResult result) { }

	// RVA: 0x2FD8DF4 Offset: 0x2FD4DF4 VA: 0x2FD8DF4
	private static bool AdjustTimeZoneToLocal(ref DateTimeResult result, bool bTimeOnly) { }

	// RVA: 0x2FD7FB4 Offset: 0x2FD3FB4 VA: 0x2FD7FB4
	private static bool ParseISO8601(ref DateTimeRawInfo raw, ref __DTString str, DateTimeStyles styles, ref DateTimeResult result) { }

	// RVA: 0x2FD9114 Offset: 0x2FD5114 VA: 0x2FD9114
	internal static bool MatchHebrewDigits(ref __DTString str, int digitLen, out int number) { }

	// RVA: 0x2FD908C Offset: 0x2FD508C VA: 0x2FD908C
	internal static bool ParseDigits(ref __DTString str, int digitLen, out int result) { }

	// RVA: 0x2FD9224 Offset: 0x2FD5224 VA: 0x2FD9224
	internal static bool ParseDigits(ref __DTString str, int minDigitLen, int maxDigitLen, out int result) { }

	// RVA: 0x2FD93C8 Offset: 0x2FD53C8 VA: 0x2FD93C8
	private static bool ParseFractionExact(ref __DTString str, int maxDigitLen, ref double result) { }

	// RVA: 0x2FD9630 Offset: 0x2FD5630 VA: 0x2FD9630
	private static bool ParseSign(ref __DTString str, ref bool result) { }

	// RVA: 0x2FD96E8 Offset: 0x2FD56E8 VA: 0x2FD96E8
	private static bool ParseTimeZoneOffset(ref __DTString str, int len, ref TimeSpan result) { }

	// RVA: 0x2FD98B0 Offset: 0x2FD58B0 VA: 0x2FD98B0
	private static bool MatchAbbreviatedMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x2FD9A8C Offset: 0x2FD5A8C VA: 0x2FD9A8C
	private static bool MatchMonthName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x2FD9CBC Offset: 0x2FD5CBC VA: 0x2FD9CBC
	private static bool MatchAbbreviatedDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x2FD9E20 Offset: 0x2FD5E20 VA: 0x2FD9E20
	private static bool MatchDayName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x2FD9F84 Offset: 0x2FD5F84 VA: 0x2FD9F84
	private static bool MatchEraName(ref __DTString str, DateTimeFormatInfo dtfi, ref int result) { }

	// RVA: 0x2FDA120 Offset: 0x2FD6120 VA: 0x2FDA120
	private static bool MatchTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x2FDA2B8 Offset: 0x2FD62B8 VA: 0x2FDA2B8
	private static bool MatchAbbreviatedTimeMark(ref __DTString str, DateTimeFormatInfo dtfi, ref DateTimeParse.TM result) { }

	// RVA: 0x2FDA408 Offset: 0x2FD6408 VA: 0x2FDA408
	private static bool CheckNewValue(ref int currentValue, int newValue, char patternChar, ref DateTimeResult result) { }

	// RVA: 0x2FD5B98 Offset: 0x2FD1B98 VA: 0x2FD5B98
	private static DateTime GetDateTimeNow(ref DateTimeResult result, ref DateTimeStyles styles) { }

	// RVA: 0x2FD85C0 Offset: 0x2FD45C0 VA: 0x2FD85C0
	private static bool CheckDefaultDateTime(ref DateTimeResult result, ref Calendar cal, DateTimeStyles styles) { }

	// RVA: 0x2FDA4C4 Offset: 0x2FD64C4 VA: 0x2FDA4C4
	private static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTimeFormatInfo dtfi, ref ParsingInfo parseInfo, ref DateTimeResult result) { }

	// RVA: 0x2FDA8A4 Offset: 0x2FD68A4 VA: 0x2FDA8A4
	private static bool ParseJapaneseEraStart(ref __DTString str, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FDA9AC Offset: 0x2FD69AC VA: 0x2FDA9AC
	private static bool ParseByFormat(ref __DTString str, ref __DTString format, ref ParsingInfo parseInfo, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x2FDBAEC Offset: 0x2FD7AEC VA: 0x2FDBAEC
	internal static bool TryParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result, out int returnValue) { }

	// RVA: 0x2FD2A50 Offset: 0x2FCEA50 VA: 0x2FD2A50
	private static bool DoStrictParse(ReadOnlySpan<char> s, ReadOnlySpan<char> formatParam, DateTimeStyles styles, DateTimeFormatInfo dtfi, ref DateTimeResult result) { }

	// RVA: 0x2FD289C Offset: 0x2FCE89C VA: 0x2FD289C
	private static Exception GetDateTimeParseException(ref DateTimeResult result) { }

	// RVA: 0x2FDBBDC Offset: 0x2FD7BDC VA: 0x2FDBBDC
	private static void .cctor() { }
}

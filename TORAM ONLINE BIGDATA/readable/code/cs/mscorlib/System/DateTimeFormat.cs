// Assembly: mscorlib.dll
// Namespace: System
internal static class DateTimeFormat // TypeDefIndex: 9584
{
	// Fields
	internal static readonly TimeSpan NullOffset; // 0x0
	internal static char[] allStandardFormats; // 0x8
	internal static readonly DateTimeFormatInfo InvariantFormatInfo; // 0x10
	internal static readonly string[] InvariantAbbreviatedMonthNames; // 0x18
	internal static readonly string[] InvariantAbbreviatedDayNames; // 0x20
	internal static string[] fixedNumberFormats; // 0x28

	// Methods

	// RVA: 0x2FCF264 Offset: 0x2FCB264 VA: 0x2FCF264
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len) { }

	// RVA: 0x2FCF2D4 Offset: 0x2FCB2D4 VA: 0x2FCF2D4
	internal static void FormatDigits(StringBuilder outputBuffer, int value, int len, bool overrideLengthLimit) { }

	// RVA: 0x2FCF3CC Offset: 0x2FCB3CC VA: 0x2FCF3CC
	private static void HebrewFormatDigits(StringBuilder outputBuffer, int digits) { }

	// RVA: 0x2FCF448 Offset: 0x2FCB448 VA: 0x2FCF448
	internal static int ParseRepeatPattern(ReadOnlySpan<char> format, int pos, char patternChar) { }

	// RVA: 0x2FCF4D0 Offset: 0x2FCB4D0 VA: 0x2FCF4D0
	private static string FormatDayOfWeek(int dayOfWeek, int repeat, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FCF504 Offset: 0x2FCB504 VA: 0x2FCF504
	private static string FormatMonth(int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FCF538 Offset: 0x2FCB538 VA: 0x2FCF538
	private static string FormatHebrewMonthName(DateTime time, int month, int repeatCount, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FCF5F8 Offset: 0x2FCB5F8 VA: 0x2FCF5F8
	internal static int ParseQuoteString(ReadOnlySpan<char> format, int pos, StringBuilder result) { }

	// RVA: 0x2FCF7A0 Offset: 0x2FCB7A0 VA: 0x2FCF7A0
	internal static int ParseNextChar(ReadOnlySpan<char> format, int pos) { }

	// RVA: 0x2FCF810 Offset: 0x2FCB810 VA: 0x2FCF810
	private static bool IsUseGenitiveForm(ReadOnlySpan<char> format, int index, int tokenLen, char patternToMatch) { }

	// RVA: 0x2FCF968 Offset: 0x2FCB968 VA: 0x2FCF968
	private static StringBuilder FormatCustomized(DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset, StringBuilder result) { }

	// RVA: 0x2FD0AA0 Offset: 0x2FCCAA0 VA: 0x2FD0AA0
	private static void FormatCustomizedTimeZone(DateTime dateTime, TimeSpan offset, ReadOnlySpan<char> format, int tokenLen, bool timeOnly, StringBuilder result) { }

	// RVA: 0x2FD0E4C Offset: 0x2FCCE4C VA: 0x2FD0E4C
	private static void FormatCustomizedRoundripTimeZone(DateTime dateTime, TimeSpan offset, StringBuilder result) { }

	// RVA: 0x2FD109C Offset: 0x2FCD09C VA: 0x2FD109C
	private static void Append2DigitNumber(StringBuilder result, int val) { }

	// RVA: 0x2FD10F8 Offset: 0x2FCD0F8 VA: 0x2FD10F8
	internal static string GetRealFormat(ReadOnlySpan<char> format, DateTimeFormatInfo dtfi) { }

	// RVA: 0x2FD139C Offset: 0x2FCD39C VA: 0x2FD139C
	private static string ExpandPredefinedFormat(ReadOnlySpan<char> format, ref DateTime dateTime, ref DateTimeFormatInfo dtfi, ref TimeSpan offset) { }

	// RVA: 0x2FC8AC4 Offset: 0x2FC4AC4 VA: 0x2FC8AC4
	internal static string Format(DateTime dateTime, string format, IFormatProvider provider) { }

	// RVA: 0x2FCC6BC Offset: 0x2FC86BC VA: 0x2FCC6BC
	internal static string Format(DateTime dateTime, string format, IFormatProvider provider, TimeSpan offset) { }

	// RVA: 0x2FC8D24 Offset: 0x2FC4D24 VA: 0x2FC8D24
	internal static bool TryFormat(DateTime dateTime, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x2FCCBF8 Offset: 0x2FC8BF8 VA: 0x2FCCBF8
	internal static bool TryFormat(DateTime dateTime, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider, TimeSpan offset) { }

	// RVA: 0x2FD1FA0 Offset: 0x2FCDFA0 VA: 0x2FD1FA0
	private static StringBuilder FormatStringBuilder(DateTime dateTime, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, TimeSpan offset) { }

	// RVA: 0x2FD1760 Offset: 0x2FCD760 VA: 0x2FD1760
	private static bool TryFormatO(DateTime dateTime, TimeSpan offset, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FD1C3C Offset: 0x2FCDC3C VA: 0x2FD1C3C
	private static bool TryFormatR(DateTime dateTime, TimeSpan offset, Span<char> destination, out int charsWritten) { }

	// RVA: 0x2FD22CC Offset: 0x2FCE2CC VA: 0x2FD22CC
	private static void WriteTwoDecimalDigits(uint value, Span<char> destination, int offset) { }

	// RVA: 0x2FD2318 Offset: 0x2FCE318 VA: 0x2FD2318
	private static void WriteFourDecimalDigits(uint value, Span<char> buffer, int startingIndex = 0) { }

	// RVA: 0x2FD23B8 Offset: 0x2FCE3B8 VA: 0x2FD23B8
	private static void WriteDigits(ulong value, Span<char> buffer) { }

	// RVA: 0x2FD175C Offset: 0x2FCD75C VA: 0x2FD175C
	internal static void InvalidFormatForLocal(ReadOnlySpan<char> format, DateTime dateTime) { }

	// RVA: 0x2FD2464 Offset: 0x2FCE464 VA: 0x2FD2464
	private static void .cctor() { }
}

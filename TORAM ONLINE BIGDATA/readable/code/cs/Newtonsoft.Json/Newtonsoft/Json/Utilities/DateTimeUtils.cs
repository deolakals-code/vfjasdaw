// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class DateTimeUtils // TypeDefIndex: 15892
{
	// Fields
	internal static readonly long InitialJavaScriptDateTicks; // 0x0
	private static readonly int[] DaysToMonth365; // 0x8
	private static readonly int[] DaysToMonth366; // 0x10

	// Methods

	// RVA: 0x3088E74 Offset: 0x3084E74 VA: 0x3088E74
	private static void .cctor() { }

	[Extension]
	// RVA: 0x3088F6C Offset: 0x3084F6C VA: 0x3088F6C
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0x3088FD4 Offset: 0x3084FD4 VA: 0x3088FD4
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0x308914C Offset: 0x308514C VA: 0x308914C
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0x308929C Offset: 0x308529C VA: 0x308929C
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x3089374 Offset: 0x3085374 VA: 0x3089374
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x308944C Offset: 0x308544C VA: 0x308944C
	private static long ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0x308950C Offset: 0x308550C VA: 0x308950C
	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x3089668 Offset: 0x3085668 VA: 0x3089668
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x308974C Offset: 0x308574C VA: 0x308974C
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0x30897A4 Offset: 0x30857A4 VA: 0x30897A4
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0x30896D0 Offset: 0x30856D0 VA: 0x30896D0
	private static long UniversalTicksToJavaScriptTicks(long universalTicks) { }

	// RVA: 0x3089860 Offset: 0x3085860 VA: 0x3089860
	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	// RVA: 0x30898E8 Offset: 0x30858E8 VA: 0x30898E8
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x3089E24 Offset: 0x3085E24 VA: 0x3089E24
	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x3089D2C Offset: 0x3085D2C VA: 0x3089D2C
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0x308A0B0 Offset: 0x30860B0 VA: 0x308A0B0
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x308A700 Offset: 0x3086700 VA: 0x308A700
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x308A9F8 Offset: 0x30869F8 VA: 0x308A9F8
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x308AE20 Offset: 0x3086E20 VA: 0x308AE20
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x308B0F4 Offset: 0x30870F4 VA: 0x308B0F4
	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	// RVA: 0x308A494 Offset: 0x3086494 VA: 0x308A494
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x308A61C Offset: 0x308661C VA: 0x308A61C
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x308AC10 Offset: 0x3086C10 VA: 0x308AC10
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x308AD74 Offset: 0x3086D74 VA: 0x308AD74
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x308B2EC Offset: 0x30872EC VA: 0x308B2EC
	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	// RVA: 0x308B470 Offset: 0x3087470 VA: 0x308B470
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x308B5E8 Offset: 0x30875E8 VA: 0x308B5E8
	internal static int WriteDateTimeString(char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0x308BAB0 Offset: 0x3087AB0 VA: 0x308BAB0
	internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt) { }

	// RVA: 0x308C10C Offset: 0x308810C VA: 0x308C10C
	private static void CopyIntToCharArray(char[] chars, int start, int value, int digits) { }

	// RVA: 0x308B8F8 Offset: 0x30878F8 VA: 0x308B8F8
	internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0x308C174 Offset: 0x3088174 VA: 0x308C174
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x308BEDC Offset: 0x3087EDC VA: 0x308BEDC
	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }
}

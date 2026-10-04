// Assembly: mscorlib.dll
// Namespace: System.Globalization
internal class CultureData // TypeDefIndex: 10819
{
	// Fields
	private string sAM1159; // 0x10
	private string sPM2359; // 0x18
	private string sTimeSeparator; // 0x20
	private string[] saLongTimes; // 0x28
	private string[] saShortTimes; // 0x30
	private int iFirstDayOfWeek; // 0x38
	private int iFirstWeekOfYear; // 0x3C
	private int[] waCalendars; // 0x40
	private CalendarData[] calendars; // 0x48
	private string sISO639Language; // 0x50
	private readonly string sRealName; // 0x58
	private bool bUseOverrides; // 0x60
	private int calendarId; // 0x64
	private int numberIndex; // 0x68
	private int iDefaultAnsiCodePage; // 0x6C
	private int iDefaultOemCodePage; // 0x70
	private int iDefaultMacCodePage; // 0x74
	private int iDefaultEbcdicCodePage; // 0x78
	private bool isRightToLeft; // 0x7C
	private string sListSeparator; // 0x80
	private static CultureData s_Invariant; // 0x0

	// Properties
	public static CultureData Invariant { get; }
	internal string[] LongTimes { get; }
	internal string[] ShortTimes { get; }
	internal string SISO639LANGNAME { get; }
	internal int IFIRSTDAYOFWEEK { get; }
	internal int IFIRSTWEEKOFYEAR { get; }
	internal string SAM1159 { get; }
	internal string SPM2359 { get; }
	internal string TimeSeparator { get; }
	internal int[] CalendarIds { get; }
	internal bool IsInvariantCulture { get; }
	internal string CultureName { get; }
	internal string SCOMPAREINFO { get; }
	internal string STEXTINFO { get; }
	internal bool UseUserOverride { get; }

	// Methods

	// RVA: 0x2F9DDD8 Offset: 0x2F99DD8 VA: 0x2F9DDD8
	private void .ctor(string name) { }

	// RVA: 0x2F9A2DC Offset: 0x2F962DC VA: 0x2F9A2DC
	public static CultureData get_Invariant() { }

	// RVA: 0x2F9DE08 Offset: 0x2F99E08 VA: 0x2F9DE08
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	// RVA: 0x2F9DEF0 Offset: 0x2F99EF0 VA: 0x2F9DEF0
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	// RVA: 0x2F9E028 Offset: 0x2F9A028 VA: 0x2F9E028
	private void fill_culture_data(int datetimeIndex) { }

	// RVA: 0x2F9E02C Offset: 0x2F9A02C VA: 0x2F9E02C
	public CalendarData GetCalendar(int calendarId) { }

	// RVA: 0x2F9E160 Offset: 0x2F9A160 VA: 0x2F9E160
	internal string[] get_LongTimes() { }

	// RVA: 0x2F9E178 Offset: 0x2F9A178 VA: 0x2F9E178
	internal string[] get_ShortTimes() { }

	// RVA: 0x2F9E190 Offset: 0x2F9A190 VA: 0x2F9E190
	internal string get_SISO639LANGNAME() { }

	// RVA: 0x2F9E198 Offset: 0x2F9A198 VA: 0x2F9E198
	internal int get_IFIRSTDAYOFWEEK() { }

	// RVA: 0x2F9E1A0 Offset: 0x2F9A1A0 VA: 0x2F9E1A0
	internal int get_IFIRSTWEEKOFYEAR() { }

	// RVA: 0x2F9E1A8 Offset: 0x2F9A1A8 VA: 0x2F9E1A8
	internal string get_SAM1159() { }

	// RVA: 0x2F9E1B0 Offset: 0x2F9A1B0 VA: 0x2F9E1B0
	internal string get_SPM2359() { }

	// RVA: 0x2F9E1B8 Offset: 0x2F9A1B8 VA: 0x2F9E1B8
	internal string get_TimeSeparator() { }

	// RVA: 0x2F9E1C0 Offset: 0x2F9A1C0 VA: 0x2F9E1C0
	internal int[] get_CalendarIds() { }

	// RVA: 0x2F9E38C Offset: 0x2F9A38C VA: 0x2F9E38C
	internal CalendarId[] GetCalendarIds() { }

	// RVA: 0x2F99010 Offset: 0x2F95010 VA: 0x2F99010
	internal bool get_IsInvariantCulture() { }

	// RVA: 0x2F9E464 Offset: 0x2F9A464 VA: 0x2F9E464
	internal string get_CultureName() { }

	// RVA: 0x2F9E46C Offset: 0x2F9A46C VA: 0x2F9E46C
	internal string get_SCOMPAREINFO() { }

	// RVA: 0x2F9E4AC Offset: 0x2F9A4AC VA: 0x2F9E4AC
	internal string get_STEXTINFO() { }

	// RVA: 0x2F9E4B4 Offset: 0x2F9A4B4 VA: 0x2F9E4B4
	internal bool get_UseUserOverride() { }

	// RVA: 0x2F9E4BC Offset: 0x2F9A4BC VA: 0x2F9E4BC
	internal string[] EraNames(int calendarId) { }

	// RVA: 0x2F9E4D8 Offset: 0x2F9A4D8 VA: 0x2F9E4D8
	internal string[] AbbrevEraNames(int calendarId) { }

	// RVA: 0x2F9E4F4 Offset: 0x2F9A4F4 VA: 0x2F9E4F4
	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	// RVA: 0x2F9E510 Offset: 0x2F9A510 VA: 0x2F9E510
	internal string[] ShortDates(int calendarId) { }

	// RVA: 0x2F9E52C Offset: 0x2F9A52C VA: 0x2F9E52C
	internal string[] LongDates(int calendarId) { }

	// RVA: 0x2F9E548 Offset: 0x2F9A548 VA: 0x2F9E548
	internal string[] YearMonths(int calendarId) { }

	// RVA: 0x2F9E564 Offset: 0x2F9A564 VA: 0x2F9E564
	internal string[] DayNames(int calendarId) { }

	// RVA: 0x2F9E580 Offset: 0x2F9A580 VA: 0x2F9E580
	internal string[] AbbreviatedDayNames(int calendarId) { }

	// RVA: 0x2F9E59C Offset: 0x2F9A59C VA: 0x2F9E59C
	internal string[] MonthNames(int calendarId) { }

	// RVA: 0x2F9E5B8 Offset: 0x2F9A5B8 VA: 0x2F9E5B8
	internal string[] GenitiveMonthNames(int calendarId) { }

	// RVA: 0x2F9E5D4 Offset: 0x2F9A5D4 VA: 0x2F9E5D4
	internal string[] AbbreviatedMonthNames(int calendarId) { }

	// RVA: 0x2F9E5F0 Offset: 0x2F9A5F0 VA: 0x2F9E5F0
	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	// RVA: 0x2F9E60C Offset: 0x2F9A60C VA: 0x2F9E60C
	internal string[] LeapYearMonthNames(int calendarId) { }

	// RVA: 0x2F9E628 Offset: 0x2F9A628 VA: 0x2F9E628
	internal string MonthDay(int calendarId) { }

	// RVA: 0x2F9E644 Offset: 0x2F9A644 VA: 0x2F9E644
	internal string DateSeparator(int calendarId) { }

	// RVA: 0x2F9E6F0 Offset: 0x2F9A6F0 VA: 0x2F9E6F0
	private static string GetDateSeparator(string format) { }

	// RVA: 0x2F9E738 Offset: 0x2F9A738 VA: 0x2F9E738
	private static string GetSeparator(string format, string timeParts) { }

	// RVA: 0x2F9E83C Offset: 0x2F9A83C VA: 0x2F9E83C
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	// RVA: 0x2F9E928 Offset: 0x2F9A928 VA: 0x2F9E928
	private static string UnescapeNlsString(string str, int start, int end) { }

	// RVA: 0x2F9EAC4 Offset: 0x2F9AAC4 VA: 0x2F9EAC4
	internal static string[] ReescapeWin32Strings(string[] array) { }

	// RVA: 0x2F9EAC8 Offset: 0x2F9AAC8 VA: 0x2F9EAC8
	internal static string ReescapeWin32String(string str) { }

	// RVA: 0x2F9EACC Offset: 0x2F9AACC VA: 0x2F9EACC
	private static int strlen(byte* s) { }

	// RVA: 0x2F9EAE4 Offset: 0x2F9AAE4 VA: 0x2F9EAE4
	private static string idx2string(byte* data, int idx) { }

	// RVA: 0x2F9EB28 Offset: 0x2F9AB28 VA: 0x2F9EB28
	private int[] create_group_sizes_array(int gs0, int gs1) { }

	// RVA: 0x2F98DBC Offset: 0x2F94DBC VA: 0x2F98DBC
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	// RVA: 0x2F9EBDC Offset: 0x2F9ABDC VA: 0x2F9EBDC
	private static byte* fill_number_data(int index, ref CultureData.NumberFormatEntryManaged nfe) { }
}

// Assembly: mscorlib.dll
// Namespace: System.Globalization
internal class CalendarData // TypeDefIndex: 10803
{
	// Fields
	internal const int MAX_CALENDARS = 23;
	internal string sNativeName; // 0x10
	internal string[] saShortDates; // 0x18
	internal string[] saYearMonths; // 0x20
	internal string[] saLongDates; // 0x28
	internal string sMonthDay; // 0x30
	internal string[] saEraNames; // 0x38
	internal string[] saAbbrevEraNames; // 0x40
	internal string[] saAbbrevEnglishEraNames; // 0x48
	internal string[] saDayNames; // 0x50
	internal string[] saAbbrevDayNames; // 0x58
	internal string[] saSuperShortDayNames; // 0x60
	internal string[] saMonthNames; // 0x68
	internal string[] saAbbrevMonthNames; // 0x70
	internal string[] saMonthGenitiveNames; // 0x78
	internal string[] saAbbrevMonthGenitiveNames; // 0x80
	internal string[] saLeapYearMonthNames; // 0x88
	internal int iTwoDigitYearMax; // 0x90
	internal int iCurrentEra; // 0x94
	internal bool bUseUserOverrides; // 0x98
	internal static CalendarData Invariant; // 0x0
	private static string[] HEBREW_MONTH_NAMES; // 0x8
	private static string[] HEBREW_LEAP_MONTH_NAMES; // 0x10

	// Methods

	// RVA: 0x2F91020 Offset: 0x2F8D020 VA: 0x2F91020
	private void .ctor() { }

	// RVA: 0x2F91030 Offset: 0x2F8D030 VA: 0x2F91030
	private static void .cctor() { }

	// RVA: 0x2F92230 Offset: 0x2F8E230 VA: 0x2F92230
	internal void .ctor(string localeName, int calendarId, bool bUseUserOverrides) { }

	// RVA: 0x2F9295C Offset: 0x2F8E95C VA: 0x2F9295C
	private void InitializeEraNames(string localeName, int calendarId) { }

	// RVA: 0x2F93214 Offset: 0x2F8F214 VA: 0x2F93214
	private static string[] GetJapaneseEraNames() { }

	// RVA: 0x2F9312C Offset: 0x2F8F12C VA: 0x2F9312C
	private static string[] GetJapaneseEnglishEraNames() { }

	// RVA: 0x2F92DC0 Offset: 0x2F8EDC0 VA: 0x2F92DC0
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	// RVA: 0x2F90930 Offset: 0x2F8C930 VA: 0x2F90930
	internal static CalendarData GetCalendarData(int calendarId) { }

	// RVA: 0x2F932FC Offset: 0x2F8F2FC VA: 0x2F932FC
	private static string CalendarIdToCultureName(int calendarId) { }

	// RVA: 0x2F91018 Offset: 0x2F8D018 VA: 0x2F91018
	public static int nativeGetTwoDigitYearMax(int calID) { }

	// RVA: 0x2F9288C Offset: 0x2F8E88C VA: 0x2F9288C
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	// RVA: 0x2F933C8 Offset: 0x2F8F3C8 VA: 0x2F933C8
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }
}

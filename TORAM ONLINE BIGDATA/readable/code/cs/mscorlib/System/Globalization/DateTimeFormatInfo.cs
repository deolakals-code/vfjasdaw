// Assembly: mscorlib.dll
// Namespace: System.Globalization
[Serializable]
public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable // TypeDefIndex: 10772
{
	// Fields
	private static DateTimeFormatInfo s_invariantInfo; // 0x0
	private CultureData _cultureData; // 0x10
	private string _name; // 0x18
	private string _langName; // 0x20
	private CompareInfo _compareInfo; // 0x28
	private CultureInfo _cultureInfo; // 0x30
	private string amDesignator; // 0x38
	private string pmDesignator; // 0x40
	private string dateSeparator; // 0x48
	private string generalShortTimePattern; // 0x50
	private string generalLongTimePattern; // 0x58
	private string timeSeparator; // 0x60
	private string monthDayPattern; // 0x68
	private string dateTimeOffsetPattern; // 0x70
	private const string rfc1123Pattern = "ddd, dd MMM yyyy HH\':\'mm\':\'ss \'GMT\'";
	private const string sortableDateTimePattern = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss";
	private const string universalSortableDateTimePattern = "yyyy\'-\'MM\'-\'dd HH\':\'mm\':\'ss\'Z\'";
	private Calendar calendar; // 0x78
	private int firstDayOfWeek; // 0x80
	private int calendarWeekRule; // 0x84
	private string fullDateTimePattern; // 0x88
	private string[] abbreviatedDayNames; // 0x90
	private string[] m_superShortDayNames; // 0x98
	private string[] dayNames; // 0xA0
	private string[] abbreviatedMonthNames; // 0xA8
	private string[] monthNames; // 0xB0
	private string[] genitiveMonthNames; // 0xB8
	private string[] m_genitiveAbbreviatedMonthNames; // 0xC0
	private string[] leapYearMonthNames; // 0xC8
	private string longDatePattern; // 0xD0
	private string shortDatePattern; // 0xD8
	private string yearMonthPattern; // 0xE0
	private string longTimePattern; // 0xE8
	private string shortTimePattern; // 0xF0
	private string[] allYearMonthPatterns; // 0xF8
	private string[] allShortDatePatterns; // 0x100
	private string[] allLongDatePatterns; // 0x108
	private string[] allShortTimePatterns; // 0x110
	private string[] allLongTimePatterns; // 0x118
	private string[] m_eraNames; // 0x120
	private string[] m_abbrevEraNames; // 0x128
	private string[] m_abbrevEnglishEraNames; // 0x130
	private CalendarId[] optionalCalendars; // 0x138
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132;
	internal bool _isReadOnly; // 0x140
	private DateTimeFormatFlags formatFlags; // 0x144
	private static readonly char[] s_monthSpaces; // 0x8
	internal const string RoundtripFormat = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.fffffffK";
	internal const string RoundtripDateTimeUnfixed = "yyyy\'-\'MM\'-\'ddTHH\':\'mm\':\'ss zzz";
	private string _fullTimeSpanPositivePattern; // 0x148
	private string _fullTimeSpanNegativePattern; // 0x150
	internal const DateTimeStyles InvalidDateTimeStyles = -256;
	private DateTimeFormatInfo.TokenHashValue[] _dtfiTokenHash; // 0x158
	private const int TOKEN_HASH_SIZE = 199;
	private const int SECOND_PRIME = 197;
	private const string dateSeparatorOrTimeZoneOffset = "-";
	private const string invariantDateSeparator = "/";
	private const string invariantTimeSeparator = ":";
	internal const string IgnorablePeriod = ".";
	internal const string IgnorableComma = ",";
	internal const string CJKYearSuff = "年";
	internal const string CJKMonthSuff = "月";
	internal const string CJKDaySuff = "日";
	internal const string KoreanYearSuff = "년";
	internal const string KoreanMonthSuff = "월";
	internal const string KoreanDaySuff = "일";
	internal const string KoreanHourSuff = "시";
	internal const string KoreanMinuteSuff = "분";
	internal const string KoreanSecondSuff = "초";
	internal const string CJKHourSuff = "時";
	internal const string ChineseHourSuff = "时";
	internal const string CJKMinuteSuff = "分";
	internal const string CJKSecondSuff = "秒";
	internal const string JapaneseEraStart = "元";
	internal const string LocalTimeMark = "T";
	internal const string GMTName = "GMT";
	internal const string ZuluName = "Z";
	internal const string KoreanLangName = "ko";
	internal const string JapaneseLangName = "ja";
	internal const string EnglishLangName = "en";
	private static DateTimeFormatInfo s_jajpDTFI; // 0x10
	private static DateTimeFormatInfo s_zhtwDTFI; // 0x18

	// Properties
	private string CultureName { get; }
	private CultureInfo Culture { get; }
	private string LanguageName { get; }
	public static DateTimeFormatInfo InvariantInfo { get; }
	public static DateTimeFormatInfo CurrentInfo { get; }
	public string AMDesignator { get; }
	public Calendar Calendar { get; set; }
	private CalendarId[] OptionalCalendars { get; }
	internal string[] EraNames { get; }
	internal string[] AbbreviatedEraNames { get; }
	internal string[] AbbreviatedEnglishEraNames { get; }
	public string DateSeparator { get; }
	public string FullDateTimePattern { get; }
	public string LongDatePattern { get; }
	public string LongTimePattern { get; }
	public string MonthDayPattern { get; }
	public string PMDesignator { get; }
	public string RFC1123Pattern { get; }
	public string ShortDatePattern { get; }
	public string ShortTimePattern { get; }
	public string SortableDateTimePattern { get; }
	internal string GeneralShortTimePattern { get; }
	internal string GeneralLongTimePattern { get; }
	internal string DateTimeOffsetPattern { get; }
	public string TimeSeparator { get; }
	public string UniversalSortableDateTimePattern { get; }
	public string YearMonthPattern { get; }
	public string[] AbbreviatedDayNames { get; }
	public string[] DayNames { get; }
	public string[] AbbreviatedMonthNames { get; }
	public string[] MonthNames { get; }
	internal bool HasSpacesInMonthNames { get; }
	internal bool HasSpacesInDayNames { get; }
	private string[] AllYearMonthPatterns { get; }
	private string[] AllShortDatePatterns { get; }
	private string[] AllShortTimePatterns { get; }
	private string[] AllLongDatePatterns { get; }
	private string[] AllLongTimePatterns { get; }
	private string[] UnclonedYearMonthPatterns { get; }
	private string[] UnclonedShortDatePatterns { get; }
	private string[] UnclonedLongDatePatterns { get; }
	private string[] UnclonedShortTimePatterns { get; }
	private string[] UnclonedLongTimePatterns { get; }
	public bool IsReadOnly { get; }
	public string[] MonthGenitiveNames { get; }
	internal string FullTimeSpanPositivePattern { get; }
	internal string FullTimeSpanNegativePattern { get; }
	internal CompareInfo CompareInfo { get; }
	internal DateTimeFormatFlags FormatFlags { get; }
	internal bool HasForceTwoDigitYears { get; }
	internal bool HasYearMonthAdjustment { get; }

	// Methods

	// RVA: 0x2F814F8 Offset: 0x2F7D4F8 VA: 0x2F814F8
	private string get_CultureName() { }

	// RVA: 0x2F81534 Offset: 0x2F7D534 VA: 0x2F81534
	private CultureInfo get_Culture() { }

	// RVA: 0x2F815C0 Offset: 0x2F7D5C0 VA: 0x2F815C0
	private string get_LanguageName() { }

	// RVA: 0x2F815FC Offset: 0x2F7D5FC VA: 0x2F815FC
	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	// RVA: 0x2F81610 Offset: 0x2F7D610 VA: 0x2F81610
	private string[] internalGetAbbreviatedDayOfWeekNamesCore() { }

	// RVA: 0x2F8166C Offset: 0x2F7D66C VA: 0x2F8166C
	private string[] internalGetDayOfWeekNames() { }

	// RVA: 0x2F81680 Offset: 0x2F7D680 VA: 0x2F81680
	private string[] internalGetDayOfWeekNamesCore() { }

	// RVA: 0x2F816DC Offset: 0x2F7D6DC VA: 0x2F816DC
	private string[] internalGetAbbreviatedMonthNames() { }

	// RVA: 0x2F816F0 Offset: 0x2F7D6F0 VA: 0x2F816F0
	private string[] internalGetAbbreviatedMonthNamesCore() { }

	// RVA: 0x2F8174C Offset: 0x2F7D74C VA: 0x2F8174C
	private string[] internalGetMonthNames() { }

	// RVA: 0x2F81760 Offset: 0x2F7D760 VA: 0x2F81760
	private string[] internalGetMonthNamesCore() { }

	// RVA: 0x2F817BC Offset: 0x2F7D7BC VA: 0x2F817BC
	public void .ctor() { }

	// RVA: 0x2F81AFC Offset: 0x2F7DAFC VA: 0x2F81AFC
	internal void .ctor(CultureData cultureData, Calendar cal) { }

	// RVA: 0x2F8197C Offset: 0x2F7D97C VA: 0x2F8197C
	private void InitializeOverridableProperties(CultureData cultureData, int calendarId) { }

	// RVA: 0x2F81F48 Offset: 0x2F7DF48 VA: 0x2F81F48
	public static DateTimeFormatInfo get_InvariantInfo() { }

	// RVA: 0x2F82028 Offset: 0x2F7E028 VA: 0x2F82028
	public static DateTimeFormatInfo get_CurrentInfo() { }

	// RVA: 0x2F82134 Offset: 0x2F7E134 VA: 0x2F82134
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	// RVA: 0x2F822E4 Offset: 0x2F7E2E4 VA: 0x2F822E4 Slot: 4
	public object GetFormat(Type formatType) { }

	// RVA: 0x2F8237C Offset: 0x2F7E37C VA: 0x2F8237C Slot: 5
	public object Clone() { }

	// RVA: 0x2F82494 Offset: 0x2F7E494 VA: 0x2F82494
	public string get_AMDesignator() { }

	// RVA: 0x2F824D0 Offset: 0x2F7E4D0 VA: 0x2F824D0
	public Calendar get_Calendar() { }

	// RVA: 0x2F81B4C Offset: 0x2F7DB4C VA: 0x2F81B4C
	public void set_Calendar(Calendar value) { }

	// RVA: 0x2F8257C Offset: 0x2F7E57C VA: 0x2F8257C
	private CalendarId[] get_OptionalCalendars() { }

	// RVA: 0x2F825EC Offset: 0x2F7E5EC VA: 0x2F825EC
	internal string[] get_EraNames() { }

	// RVA: 0x2F82654 Offset: 0x2F7E654 VA: 0x2F82654
	public string GetEraName(int era) { }

	// RVA: 0x2F8272C Offset: 0x2F7E72C VA: 0x2F8272C
	internal string[] get_AbbreviatedEraNames() { }

	// RVA: 0x2F82794 Offset: 0x2F7E794 VA: 0x2F82794
	public string GetAbbreviatedEraName(int era) { }

	// RVA: 0x2F8287C Offset: 0x2F7E87C VA: 0x2F8287C
	internal string[] get_AbbreviatedEnglishEraNames() { }

	// RVA: 0x2F828E4 Offset: 0x2F7E8E4 VA: 0x2F828E4
	public string get_DateSeparator() { }

	// RVA: 0x2F82950 Offset: 0x2F7E950 VA: 0x2F82950
	public string get_FullDateTimePattern() { }

	// RVA: 0x2F829D8 Offset: 0x2F7E9D8 VA: 0x2F829D8
	public string get_LongDatePattern() { }

	// RVA: 0x2F82A24 Offset: 0x2F7EA24 VA: 0x2F82A24
	public string get_LongTimePattern() { }

	// RVA: 0x2F82B20 Offset: 0x2F7EB20 VA: 0x2F82B20
	public string get_MonthDayPattern() { }

	// RVA: 0x2F82B8C Offset: 0x2F7EB8C VA: 0x2F82B8C
	public string get_PMDesignator() { }

	// RVA: 0x2F82BC8 Offset: 0x2F7EBC8 VA: 0x2F82BC8
	public string get_RFC1123Pattern() { }

	// RVA: 0x2F82C08 Offset: 0x2F7EC08 VA: 0x2F82C08
	public string get_ShortDatePattern() { }

	// RVA: 0x2F82CBC Offset: 0x2F7ECBC VA: 0x2F82CBC
	public string get_ShortTimePattern() { }

	// RVA: 0x2F82D50 Offset: 0x2F7ED50 VA: 0x2F82D50
	public string get_SortableDateTimePattern() { }

	// RVA: 0x2F82D90 Offset: 0x2F7ED90 VA: 0x2F82D90
	internal string get_GeneralShortTimePattern() { }

	// RVA: 0x2F82E18 Offset: 0x2F7EE18 VA: 0x2F82E18
	internal string get_GeneralLongTimePattern() { }

	// RVA: 0x2F82EA0 Offset: 0x2F7EEA0 VA: 0x2F82EA0
	internal string get_DateTimeOffsetPattern() { }

	// RVA: 0x2F8304C Offset: 0x2F7F04C VA: 0x2F8304C
	public string get_TimeSeparator() { }

	// RVA: 0x2F83088 Offset: 0x2F7F088 VA: 0x2F83088
	public string get_UniversalSortableDateTimePattern() { }

	// RVA: 0x2F830C8 Offset: 0x2F7F0C8 VA: 0x2F830C8
	public string get_YearMonthPattern() { }

	// RVA: 0x2F83180 Offset: 0x2F7F180 VA: 0x2F83180
	public string[] get_AbbreviatedDayNames() { }

	// RVA: 0x2F83204 Offset: 0x2F7F204 VA: 0x2F83204
	public string[] get_DayNames() { }

	// RVA: 0x2F83288 Offset: 0x2F7F288 VA: 0x2F83288
	public string[] get_AbbreviatedMonthNames() { }

	// RVA: 0x2F8330C Offset: 0x2F7F30C VA: 0x2F8330C
	public string[] get_MonthNames() { }

	// RVA: 0x2F83390 Offset: 0x2F7F390 VA: 0x2F83390
	internal bool get_HasSpacesInMonthNames() { }

	// RVA: 0x2F833D0 Offset: 0x2F7F3D0 VA: 0x2F833D0
	internal bool get_HasSpacesInDayNames() { }

	// RVA: 0x2F833F8 Offset: 0x2F7F3F8 VA: 0x2F833F8
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	// RVA: 0x2F83558 Offset: 0x2F7F558 VA: 0x2F83558
	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	// RVA: 0x2F83600 Offset: 0x2F7F600 VA: 0x2F83600
	internal string[] internalGetLeapYearMonthNames() { }

	// RVA: 0x2F8366C Offset: 0x2F7F66C VA: 0x2F8366C
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	// RVA: 0x2F83768 Offset: 0x2F7F768 VA: 0x2F83768
	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	// RVA: 0x2F838B4 Offset: 0x2F7F8B4 VA: 0x2F838B4
	public string[] GetAllDateTimePatterns(char format) { }

	// RVA: 0x2F83E70 Offset: 0x2F7FE70 VA: 0x2F83E70
	public string GetDayName(DayOfWeek dayofweek) { }

	// RVA: 0x2F83F6C Offset: 0x2F7FF6C VA: 0x2F83F6C
	public string GetAbbreviatedMonthName(int month) { }

	// RVA: 0x2F8406C Offset: 0x2F8006C VA: 0x2F8406C
	public string GetMonthName(int month) { }

	// RVA: 0x2F8416C Offset: 0x2F8016C VA: 0x2F8416C
	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	// RVA: 0x2F83DFC Offset: 0x2F7FDFC VA: 0x2F83DFC
	private string[] get_AllYearMonthPatterns() { }

	// RVA: 0x2F83C2C Offset: 0x2F7FC2C VA: 0x2F83C2C
	private string[] get_AllShortDatePatterns() { }

	// RVA: 0x2F83D14 Offset: 0x2F7FD14 VA: 0x2F83D14
	private string[] get_AllShortTimePatterns() { }

	// RVA: 0x2F83CA0 Offset: 0x2F7FCA0 VA: 0x2F83CA0
	private string[] get_AllLongDatePatterns() { }

	// RVA: 0x2F83D88 Offset: 0x2F7FD88 VA: 0x2F83D88
	private string[] get_AllLongTimePatterns() { }

	// RVA: 0x2F83114 Offset: 0x2F7F114 VA: 0x2F83114
	private string[] get_UnclonedYearMonthPatterns() { }

	// RVA: 0x2F82C54 Offset: 0x2F7EC54 VA: 0x2F82C54
	private string[] get_UnclonedShortDatePatterns() { }

	// RVA: 0x2F82A70 Offset: 0x2F7EA70 VA: 0x2F82A70
	private string[] get_UnclonedLongDatePatterns() { }

	// RVA: 0x2F82D08 Offset: 0x2F7ED08 VA: 0x2F82D08
	private string[] get_UnclonedShortTimePatterns() { }

	// RVA: 0x2F82AD8 Offset: 0x2F7EAD8 VA: 0x2F82AD8
	private string[] get_UnclonedLongTimePatterns() { }

	// RVA: 0x2F824D8 Offset: 0x2F7E4D8 VA: 0x2F824D8
	public bool get_IsReadOnly() { }

	// RVA: 0x2F8432C Offset: 0x2F8032C VA: 0x2F8432C
	public string[] get_MonthGenitiveNames() { }

	// RVA: 0x2F843AC Offset: 0x2F803AC VA: 0x2F843AC
	internal string get_FullTimeSpanPositivePattern() { }

	// RVA: 0x2F8448C Offset: 0x2F8048C VA: 0x2F8448C
	internal string get_FullTimeSpanNegativePattern() { }

	// RVA: 0x2F84508 Offset: 0x2F80508 VA: 0x2F84508
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x2F845A0 Offset: 0x2F805A0 VA: 0x2F845A0
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x2F833B8 Offset: 0x2F7F3B8 VA: 0x2F833B8
	internal DateTimeFormatFlags get_FormatFlags() { }

	// RVA: 0x2F8466C Offset: 0x2F8066C VA: 0x2F8466C
	private DateTimeFormatFlags InitializeFormatFlags() { }

	// RVA: 0x2F848E8 Offset: 0x2F808E8 VA: 0x2F848E8
	internal bool get_HasForceTwoDigitYears() { }

	// RVA: 0x2F8491C Offset: 0x2F8091C VA: 0x2F8491C
	internal bool get_HasYearMonthAdjustment() { }

	// RVA: 0x2F84944 Offset: 0x2F80944 VA: 0x2F84944
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

	// RVA: 0x2F84A78 Offset: 0x2F80A78 VA: 0x2F84A78
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	// RVA: 0x2F84C14 Offset: 0x2F80C14 VA: 0x2F84C14
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	// RVA: 0x2F825C4 Offset: 0x2F7E5C4 VA: 0x2F825C4
	private void ClearTokenHashTable() { }

	// RVA: 0x2F84DB0 Offset: 0x2F80DB0 VA: 0x2F84DB0
	internal DateTimeFormatInfo.TokenHashValue[] CreateTokenHashTable() { }

	// RVA: 0x2F85950 Offset: 0x2F81950 VA: 0x2F85950
	private void PopulateSpecialTokenHashTable(DateTimeFormatInfo.TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol) { }

	// RVA: 0x2F86608 Offset: 0x2F82608 VA: 0x2F86608
	private static bool IsJapaneseCalendar(Calendar calendar) { }

	// RVA: 0x2F86228 Offset: 0x2F82228 VA: 0x2F86228
	private void AddMonthNames(DateTimeFormatInfo.TokenHashValue[] temp, string monthPostfix) { }

	// RVA: 0x2F8673C Offset: 0x2F8273C VA: 0x2F8673C
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	// RVA: 0x2F86B18 Offset: 0x2F82B18 VA: 0x2F86B18
	private static bool IsHebrewChar(char ch) { }

	// RVA: 0x2F86B2C Offset: 0x2F82B2C VA: 0x2F86B2C
	private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh) { }

	// RVA: 0x2F86C34 Offset: 0x2F82C34 VA: 0x2F86C34
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	// RVA: 0x2F871D0 Offset: 0x2F831D0 VA: 0x2F871D0
	private void InsertAtCurrentHashNode(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	// RVA: 0x2F85628 Offset: 0x2F81628 VA: 0x2F85628
	private void InsertHash(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	// RVA: 0x2F873E8 Offset: 0x2F833E8 VA: 0x2F873E8
	private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	// RVA: 0x2F874DC Offset: 0x2F834DC VA: 0x2F874DC
	private static void .cctor() { }
}

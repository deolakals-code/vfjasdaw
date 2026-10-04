// Assembly: mscorlib.dll
// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class JapaneseCalendar : Calendar // TypeDefIndex: 10809
{
	// Fields
	internal static readonly DateTime calendarMinValue; // 0x0
	internal static EraInfo[] japaneseEraInfo; // 0x8
	internal static Calendar s_defaultInstance; // 0x10
	internal GregorianCalendarHelper helper; // 0x20

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x2F97940 Offset: 0x2F93940 VA: 0x2F97940 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x2F97998 Offset: 0x2F93998 VA: 0x2F97998 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x2F979F0 Offset: 0x2F939F0 VA: 0x2F979F0
	internal static EraInfo[] GetEraInfo() { }

	// RVA: 0x2F97EA8 Offset: 0x2F93EA8 VA: 0x2F97EA8
	private static EraInfo[] GetErasFromRegistry() { }

	// RVA: 0x2F97EB0 Offset: 0x2F93EB0 VA: 0x2F97EB0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x2F97F6C Offset: 0x2F93F6C VA: 0x2F97F6C
	public void .ctor() { }

	// RVA: 0x2F98120 Offset: 0x2F94120 VA: 0x2F98120 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x2F98128 Offset: 0x2F94128 VA: 0x2F98128 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x2F98140 Offset: 0x2F94140 VA: 0x2F98140 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x2F98158 Offset: 0x2F94158 VA: 0x2F98158 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x2F98170 Offset: 0x2F94170 VA: 0x2F98170 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x2F98188 Offset: 0x2F94188 VA: 0x2F98188 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x2F981AC Offset: 0x2F941AC VA: 0x2F981AC Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x2F981C4 Offset: 0x2F941C4 VA: 0x2F981C4 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x2F981DC Offset: 0x2F941DC VA: 0x2F981DC Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x2F981F4 Offset: 0x2F941F4 VA: 0x2F981F4 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x2F9820C Offset: 0x2F9420C VA: 0x2F9820C Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x2F9822C Offset: 0x2F9422C VA: 0x2F9822C Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x2F98378 Offset: 0x2F94378 VA: 0x2F98378 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x2F98390 Offset: 0x2F94390 VA: 0x2F98390
	internal static string[] EraNames() { }

	// RVA: 0x2F98484 Offset: 0x2F94484 VA: 0x2F98484
	internal static string[] EnglishEraNames() { }

	// RVA: 0x2F98578 Offset: 0x2F94578 VA: 0x2F98578 Slot: 25
	internal override bool IsValidYear(int year, int era) { }

	// RVA: 0x2F985A0 Offset: 0x2F945A0 VA: 0x2F985A0 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x2F985DC Offset: 0x2F945DC VA: 0x2F985DC Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x2F98718 Offset: 0x2F94718 VA: 0x2F98718
	private static void .cctor() { }
}

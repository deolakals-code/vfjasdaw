// Assembly: mscorlib.dll
// Namespace: System.Globalization
[Serializable]
internal class GregorianCalendarHelper // TypeDefIndex: 10806
{
	// Fields
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	[OptionalField(VersionAdded = 1)]
	internal int m_maxYear; // 0x10
	[OptionalField(VersionAdded = 1)]
	internal int m_minYear; // 0x14
	internal Calendar m_Cal; // 0x18
	[OptionalField(VersionAdded = 1)]
	internal EraInfo[] m_EraInfo; // 0x20
	[OptionalField(VersionAdded = 1)]
	internal int[] m_eras; // 0x28
	[OptionalField(VersionAdded = 1)]
	internal DateTime m_minDate; // 0x30

	// Properties
	internal int MaxYear { get; }
	public int[] Eras { get; }

	// Methods

	// RVA: 0x2F94C58 Offset: 0x2F90C58 VA: 0x2F94C58
	internal int get_MaxYear() { }

	// RVA: 0x2F94C60 Offset: 0x2F90C60 VA: 0x2F94C60
	internal void .ctor(Calendar cal, EraInfo[] eraInfo) { }

	// RVA: 0x2F94D00 Offset: 0x2F90D00 VA: 0x2F94D00
	private int GetYearOffset(int year, int era, bool throwOnError) { }

	// RVA: 0x2F94FE8 Offset: 0x2F90FE8 VA: 0x2F94FE8
	internal int GetGregorianYear(int year, int era) { }

	// RVA: 0x2F95004 Offset: 0x2F91004 VA: 0x2F95004
	internal bool IsValidYear(int year, int era) { }

	// RVA: 0x2F95020 Offset: 0x2F91020 VA: 0x2F95020 Slot: 4
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x2F95414 Offset: 0x2F91414 VA: 0x2F95414
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x2F95604 Offset: 0x2F91604 VA: 0x2F95604
	internal static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x2F95684 Offset: 0x2F91684 VA: 0x2F95684
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x2F95230 Offset: 0x2F91230 VA: 0x2F95230
	internal void CheckTicksRange(long ticks) { }

	// RVA: 0x2F95834 Offset: 0x2F91834 VA: 0x2F95834
	public int GetDayOfMonth(DateTime time) { }

	// RVA: 0x2F958B4 Offset: 0x2F918B4 VA: 0x2F958B4
	public DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x2F95980 Offset: 0x2F91980 VA: 0x2F95980
	public int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x2F95B1C Offset: 0x2F91B1C VA: 0x2F95B1C
	public int GetDaysInYear(int year, int era) { }

	// RVA: 0x2F95B88 Offset: 0x2F91B88 VA: 0x2F95B88
	public int GetEra(DateTime time) { }

	// RVA: 0x2F95C90 Offset: 0x2F91C90 VA: 0x2F95C90
	public int[] get_Eras() { }

	// RVA: 0x2F95D98 Offset: 0x2F91D98 VA: 0x2F95D98
	public int GetMonth(DateTime time) { }

	// RVA: 0x2F95E18 Offset: 0x2F91E18 VA: 0x2F95E18
	public int GetMonthsInYear(int year, int era) { }

	// RVA: 0x2F95E30 Offset: 0x2F91E30 VA: 0x2F95E30
	public int GetYear(DateTime time) { }

	// RVA: 0x2F95F58 Offset: 0x2F91F58 VA: 0x2F95F58
	public bool IsLeapYear(int year, int era) { }

	// RVA: 0x2F95FC8 Offset: 0x2F91FC8 VA: 0x2F95FC8
	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x2F960CC Offset: 0x2F920CC VA: 0x2F960CC
	public int ToFourDigitYear(int year, int twoDigitYearMax) { }

	// RVA: 0x2F96250 Offset: 0x2F92250 VA: 0x2F96250
	private static void .cctor() { }
}

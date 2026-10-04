// Assembly: mscorlib.dll
// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class HijriCalendar : Calendar // TypeDefIndex: 10808
{
	// Fields
	public static readonly int HijriEra; // 0x0
	internal static readonly int[] HijriMonthDays; // 0x8
	private int m_HijriAdvance; // 0x1C
	internal static readonly DateTime calendarMinValue; // 0x10
	internal static readonly DateTime calendarMaxValue; // 0x18

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public int HijriAdjustment { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x2F96334 Offset: 0x2F92334 VA: 0x2F96334 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x2F9638C Offset: 0x2F9238C VA: 0x2F9638C Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x2F963E4 Offset: 0x2F923E4 VA: 0x2F963E4
	public void .ctor() { }

	// RVA: 0x2F963F4 Offset: 0x2F923F4 VA: 0x2F963F4 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x2F963FC Offset: 0x2F923FC VA: 0x2F963FC
	private long GetAbsoluteDateHijri(int y, int m, int d) { }

	// RVA: 0x2F964C4 Offset: 0x2F924C4 VA: 0x2F964C4
	private long DaysUpToHijriYear(int HijriYear) { }

	// RVA: 0x2F96580 Offset: 0x2F92580 VA: 0x2F96580
	public int get_HijriAdjustment() { }

	// RVA: 0x2F965E8 Offset: 0x2F925E8 VA: 0x2F965E8
	private static int GetAdvanceHijriDate() { }

	// RVA: 0x2F965F0 Offset: 0x2F925F0 VA: 0x2F965F0
	internal static void CheckTicksRange(long ticks) { }

	// RVA: 0x2F967D0 Offset: 0x2F927D0 VA: 0x2F967D0
	internal static void CheckEraRange(int era) { }

	// RVA: 0x2F9689C Offset: 0x2F9289C VA: 0x2F9689C
	internal static void CheckYearRange(int year, int era) { }

	// RVA: 0x2F969F0 Offset: 0x2F929F0 VA: 0x2F969F0
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	// RVA: 0x2F96B74 Offset: 0x2F92B74 VA: 0x2F96B74 Slot: 31
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x2F96DE4 Offset: 0x2F92DE4 VA: 0x2F96DE4 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x2F96E68 Offset: 0x2F92E68 VA: 0x2F96E68 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x2F96F10 Offset: 0x2F92F10 VA: 0x2F96F10 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x2F96FDC Offset: 0x2F92FDC VA: 0x2F96FDC Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x2F97070 Offset: 0x2F93070 VA: 0x2F97070 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x2F9710C Offset: 0x2F9310C VA: 0x2F9710C Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x2F971A8 Offset: 0x2F931A8 VA: 0x2F971A8 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x2F9722C Offset: 0x2F9322C VA: 0x2F9722C Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x2F97298 Offset: 0x2F93298 VA: 0x2F97298 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x2F9731C Offset: 0x2F9331C VA: 0x2F9731C Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x2F973BC Offset: 0x2F933BC VA: 0x2F973BC Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x2F97594 Offset: 0x2F93594 VA: 0x2F97594 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x2F975D0 Offset: 0x2F935D0 VA: 0x2F975D0 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x2F976E8 Offset: 0x2F936E8 VA: 0x2F976E8 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x2F97824 Offset: 0x2F93824 VA: 0x2F97824
	private static void .cctor() { }
}

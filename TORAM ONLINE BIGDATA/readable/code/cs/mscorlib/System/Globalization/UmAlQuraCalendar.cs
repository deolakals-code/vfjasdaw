// Assembly: mscorlib.dll
// Namespace: System.Globalization
[Serializable]
public class UmAlQuraCalendar : Calendar // TypeDefIndex: 10815
{
	// Fields
	private static readonly UmAlQuraCalendar.DateMapping[] HijriYearInfo; // 0x0
	internal static DateTime minDate; // 0x8
	internal static DateTime maxDate; // 0x10

	// Properties
	public override DateTime MinSupportedDateTime { get; }
	public override DateTime MaxSupportedDateTime { get; }
	internal override int BaseCalendarID { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x2F9BFD8 Offset: 0x2F97FD8 VA: 0x2F9BFD8
	private static UmAlQuraCalendar.DateMapping[] InitDateMapping() { }

	// RVA: 0x2F9C17C Offset: 0x2F9817C VA: 0x2F9C17C Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x2F9C1D4 Offset: 0x2F981D4 VA: 0x2F9C1D4 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x2F9C22C Offset: 0x2F9822C VA: 0x2F9C22C
	public void .ctor() { }

	// RVA: 0x2F9C234 Offset: 0x2F98234 VA: 0x2F9C234 Slot: 8
	internal override int get_BaseCalendarID() { }

	// RVA: 0x2F9C23C Offset: 0x2F9823C VA: 0x2F9C23C Slot: 7
	internal override int get_ID() { }

	// RVA: 0x2F9C244 Offset: 0x2F98244 VA: 0x2F9C244
	private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg) { }

	// RVA: 0x2F9C3A8 Offset: 0x2F983A8 VA: 0x2F9C3A8
	private static long GetAbsoluteDateUmAlQura(int year, int month, int day) { }

	// RVA: 0x2F9C470 Offset: 0x2F98470 VA: 0x2F9C470
	internal static void CheckTicksRange(long ticks) { }

	// RVA: 0x2F9C650 Offset: 0x2F98650 VA: 0x2F9C650
	internal static void CheckEraRange(int era) { }

	// RVA: 0x2F9C6C8 Offset: 0x2F986C8 VA: 0x2F9C6C8
	internal static void CheckYearRange(int year, int era) { }

	// RVA: 0x2F9C810 Offset: 0x2F98810 VA: 0x2F9C810
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	// RVA: 0x2F9C8EC Offset: 0x2F988EC VA: 0x2F9C8EC
	private static void ConvertGregorianToHijri(DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay) { }

	// RVA: 0x2F9CBD8 Offset: 0x2F98BD8 VA: 0x2F9CBD8 Slot: 31
	internal virtual int GetDatePart(DateTime time, int part) { }

	// RVA: 0x2F9CD60 Offset: 0x2F98D60 VA: 0x2F9CD60 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x2F9CD74 Offset: 0x2F98D74 VA: 0x2F9CD74 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x2F9CE1C Offset: 0x2F98E1C VA: 0x2F9CE1C Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x2F9CED0 Offset: 0x2F98ED0 VA: 0x2F9CED0
	internal static int RealGetDaysInYear(int year) { }

	// RVA: 0x2F9CF70 Offset: 0x2F98F70 VA: 0x2F9CF70 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x2F9CFDC Offset: 0x2F98FDC VA: 0x2F9CFDC Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x2F9D070 Offset: 0x2F99070 VA: 0x2F9D070 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x2F9D0D4 Offset: 0x2F990D4 VA: 0x2F9D0D4 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x2F9D0E8 Offset: 0x2F990E8 VA: 0x2F9D0E8 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x2F9D154 Offset: 0x2F99154 VA: 0x2F9D154 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x2F9D168 Offset: 0x2F99168 VA: 0x2F9D168 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x2F9D1E0 Offset: 0x2F991E0 VA: 0x2F9D1E0 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x2F9D42C Offset: 0x2F9942C VA: 0x2F9D42C Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x2F9D468 Offset: 0x2F99468 VA: 0x2F9D468 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x2F9D588 Offset: 0x2F99588 VA: 0x2F9D588 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x2F9D6C4 Offset: 0x2F996C4 VA: 0x2F9D6C4
	private static void .cctor() { }
}

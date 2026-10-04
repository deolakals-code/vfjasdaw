// Assembly: mscorlib.dll
// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class TaiwanCalendar : Calendar // TypeDefIndex: 10811
{
	// Fields
	internal static EraInfo[] taiwanEraInfo; // 0x0
	internal static Calendar s_defaultInstance; // 0x8
	internal GregorianCalendarHelper helper; // 0x20
	internal static readonly DateTime calendarMinValue; // 0x10

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x2F999F0 Offset: 0x2F959F0 VA: 0x2F999F0
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x2F99C60 Offset: 0x2F95C60 VA: 0x2F99C60 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x2F99CB8 Offset: 0x2F95CB8 VA: 0x2F99CB8 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x2F99AAC Offset: 0x2F95AAC VA: 0x2F99AAC
	public void .ctor() { }

	// RVA: 0x2F99D10 Offset: 0x2F95D10 VA: 0x2F99D10 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x2F99D18 Offset: 0x2F95D18 VA: 0x2F99D18 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x2F99D30 Offset: 0x2F95D30 VA: 0x2F99D30 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x2F99D48 Offset: 0x2F95D48 VA: 0x2F99D48 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x2F99D60 Offset: 0x2F95D60 VA: 0x2F99D60 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x2F99D78 Offset: 0x2F95D78 VA: 0x2F99D78 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x2F99D9C Offset: 0x2F95D9C VA: 0x2F99D9C Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x2F99DB4 Offset: 0x2F95DB4 VA: 0x2F99DB4 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x2F99DCC Offset: 0x2F95DCC VA: 0x2F99DCC Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x2F99DE4 Offset: 0x2F95DE4 VA: 0x2F99DE4 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x2F99DFC Offset: 0x2F95DFC VA: 0x2F99DFC Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x2F99E1C Offset: 0x2F95E1C VA: 0x2F99E1C Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x2F99E34 Offset: 0x2F95E34 VA: 0x2F99E34 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x2F99E70 Offset: 0x2F95E70 VA: 0x2F99E70 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x2F99FAC Offset: 0x2F95FAC VA: 0x2F99FAC Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x2F9A0F8 Offset: 0x2F960F8 VA: 0x2F9A0F8
	private static void .cctor() { }
}

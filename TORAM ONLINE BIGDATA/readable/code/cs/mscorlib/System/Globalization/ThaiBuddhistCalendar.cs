// Assembly: mscorlib.dll
// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class ThaiBuddhistCalendar : Calendar // TypeDefIndex: 10813
{
	// Fields
	internal static EraInfo[] thaiBuddhistEraInfo; // 0x0
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

	// RVA: 0x2F9BA34 Offset: 0x2F97A34 VA: 0x2F9BA34 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x2F9BA8C Offset: 0x2F97A8C VA: 0x2F9BA8C Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x2F9BAE4 Offset: 0x2F97AE4 VA: 0x2F9BAE4
	public void .ctor() { }

	// RVA: 0x2F9BB84 Offset: 0x2F97B84 VA: 0x2F9BB84 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x2F9BB8C Offset: 0x2F97B8C VA: 0x2F9BB8C Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x2F9BBA4 Offset: 0x2F97BA4 VA: 0x2F9BBA4 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x2F9BBBC Offset: 0x2F97BBC VA: 0x2F9BBBC Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x2F9BBD4 Offset: 0x2F97BD4 VA: 0x2F9BBD4 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x2F9BBEC Offset: 0x2F97BEC VA: 0x2F9BBEC Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x2F9BC10 Offset: 0x2F97C10 VA: 0x2F9BC10 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x2F9BC28 Offset: 0x2F97C28 VA: 0x2F9BC28 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x2F9BC40 Offset: 0x2F97C40 VA: 0x2F9BC40 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x2F9BC58 Offset: 0x2F97C58 VA: 0x2F9BC58 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x2F9BC70 Offset: 0x2F97C70 VA: 0x2F9BC70 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x2F9BC90 Offset: 0x2F97C90 VA: 0x2F9BC90 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x2F9BCA8 Offset: 0x2F97CA8 VA: 0x2F9BCA8 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x2F9BCE4 Offset: 0x2F97CE4 VA: 0x2F9BCE4 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x2F9BE20 Offset: 0x2F97E20 VA: 0x2F9BE20 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x2F9BEC8 Offset: 0x2F97EC8 VA: 0x2F9BEC8
	private static void .cctor() { }
}

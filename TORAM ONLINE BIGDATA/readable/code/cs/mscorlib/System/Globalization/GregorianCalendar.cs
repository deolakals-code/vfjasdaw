// Assembly: mscorlib.dll
// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class GregorianCalendar : Calendar // TypeDefIndex: 10804
{
	// Fields
	internal GregorianCalendarTypes m_type; // 0x1C
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	private static Calendar s_defaultInstance; // 0x10

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	[OnDeserialized]
	// RVA: 0x2F933CC Offset: 0x2F8F3CC VA: 0x2F933CC
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x2F934A0 Offset: 0x2F8F4A0 VA: 0x2F934A0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x2F934F8 Offset: 0x2F8F4F8 VA: 0x2F934F8 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x2F818A8 Offset: 0x2F7D8A8 VA: 0x2F818A8
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x2F93550 Offset: 0x2F8F550 VA: 0x2F93550
	public void .ctor() { }

	// RVA: 0x2F9357C Offset: 0x2F8F57C VA: 0x2F9357C
	public void .ctor(GregorianCalendarTypes type) { }

	// RVA: 0x2F936CC Offset: 0x2F8F6CC VA: 0x2F936CC Slot: 7
	internal override int get_ID() { }

	// RVA: 0x2F936D4 Offset: 0x2F8F6D4 VA: 0x2F936D4 Slot: 31
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x2F938D4 Offset: 0x2F8F8D4 VA: 0x2F938D4
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x2F93AC4 Offset: 0x2F8FAC4 VA: 0x2F93AC4 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x2F93B48 Offset: 0x2F8FB48 VA: 0x2F93B48 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x2F93BF0 Offset: 0x2F8FBF0 VA: 0x2F93BF0 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x2F93E94 Offset: 0x2F8FE94 VA: 0x2F93E94 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x2F94020 Offset: 0x2F90020 VA: 0x2F94020 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x2F94028 Offset: 0x2F90028 VA: 0x2F94028 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x2F9408C Offset: 0x2F9008C VA: 0x2F9408C Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x2F94110 Offset: 0x2F90110 VA: 0x2F94110 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x2F94258 Offset: 0x2F90258 VA: 0x2F94258 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x2F942DC Offset: 0x2F902DC VA: 0x2F942DC Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x2F94470 Offset: 0x2F90470 VA: 0x2F94470 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x2F9450C Offset: 0x2F9050C VA: 0x2F9450C Slot: 24
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x2F945F8 Offset: 0x2F905F8 VA: 0x2F945F8 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x2F9463C Offset: 0x2F9063C VA: 0x2F9463C Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x2F94750 Offset: 0x2F90750 VA: 0x2F94750 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x2F9486C Offset: 0x2F9086C VA: 0x2F9486C
	private static void .cctor() { }
}

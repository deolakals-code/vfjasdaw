// Assembly: mscorlib.dll
// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public abstract class Calendar : ICloneable // TypeDefIndex: 10802
{
	// Fields
	internal const long TicksPerMillisecond = 10000;
	internal const long TicksPerSecond = 10000000;
	internal const long TicksPerMinute = 600000000;
	internal const long TicksPerHour = 36000000000;
	internal const long TicksPerDay = 864000000000;
	internal const int MillisPerSecond = 1000;
	internal const int MillisPerMinute = 60000;
	internal const int MillisPerHour = 3600000;
	internal const int MillisPerDay = 86400000;
	internal const int DaysPerYear = 365;
	internal const int DaysPer4Years = 1461;
	internal const int DaysPer100Years = 36524;
	internal const int DaysPer400Years = 146097;
	internal const int DaysTo10000 = 3652059;
	internal const long MaxMillis = 315537897600000;
	internal const int CAL_GREGORIAN = 1;
	internal const int CAL_GREGORIAN_US = 2;
	internal const int CAL_JAPAN = 3;
	internal const int CAL_TAIWAN = 4;
	internal const int CAL_KOREA = 5;
	internal const int CAL_HIJRI = 6;
	internal const int CAL_THAI = 7;
	internal const int CAL_HEBREW = 8;
	internal const int CAL_GREGORIAN_ME_FRENCH = 9;
	internal const int CAL_GREGORIAN_ARABIC = 10;
	internal const int CAL_GREGORIAN_XLIT_ENGLISH = 11;
	internal const int CAL_GREGORIAN_XLIT_FRENCH = 12;
	internal const int CAL_JULIAN = 13;
	internal const int CAL_JAPANESELUNISOLAR = 14;
	internal const int CAL_CHINESELUNISOLAR = 15;
	internal const int CAL_SAKA = 16;
	internal const int CAL_LUNAR_ETO_CHN = 17;
	internal const int CAL_LUNAR_ETO_KOR = 18;
	internal const int CAL_LUNAR_ETO_ROKUYOU = 19;
	internal const int CAL_KOREANLUNISOLAR = 20;
	internal const int CAL_TAIWANLUNISOLAR = 21;
	internal const int CAL_PERSIAN = 22;
	internal const int CAL_UMALQURA = 23;
	internal int m_currentEraValue; // 0x10
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x14
	public const int CurrentEra = 0;
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisible(False)]
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x2F906CC Offset: 0x2F8C6CC VA: 0x2F906CC Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x2F90724 Offset: 0x2F8C724 VA: 0x2F90724 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x2F9077C Offset: 0x2F8C77C VA: 0x2F9077C
	protected void .ctor() { }

	// RVA: 0x2F90790 Offset: 0x2F8C790 VA: 0x2F90790 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x2F90798 Offset: 0x2F8C798 VA: 0x2F90798 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisible(False)]
	// RVA: 0x2F907A4 Offset: 0x2F8C7A4 VA: 0x2F907A4 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x2F9082C Offset: 0x2F8C82C VA: 0x2F9082C
	internal void VerifyWritable() { }

	// RVA: 0x2F90898 Offset: 0x2F8C898 VA: 0x2F90898
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x2F908A4 Offset: 0x2F8C8A4 VA: 0x2F908A4 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetDaysInYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int GetEra(DateTime time);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int[] get_Eras();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetMonthsInYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetYear(DateTime time);

	// RVA: 0x2F909D8 Offset: 0x2F8C9D8 VA: 0x2F909D8 Slot: 20
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool IsLeapYear(int year, int era);

	// RVA: 0x2F909EC Offset: 0x2F8C9EC VA: 0x2F909EC Slot: 22
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

	// RVA: 0x2F90A14 Offset: 0x2F8CA14 VA: 0x2F90A14 Slot: 24
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x2F90B74 Offset: 0x2F8CB74 VA: 0x2F90B74 Slot: 25
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x2F90BF8 Offset: 0x2F8CBF8 VA: 0x2F90BF8 Slot: 26
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x2F90C70 Offset: 0x2F8CC70 VA: 0x2F90C70 Slot: 27
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x2F90CF0 Offset: 0x2F8CCF0 VA: 0x2F90CF0 Slot: 28
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x2F90CF8 Offset: 0x2F8CCF8 VA: 0x2F90CF8 Slot: 29
	public virtual void set_TwoDigitYearMax(int value) { }

	// RVA: 0x2F90D1C Offset: 0x2F8CD1C VA: 0x2F90D1C Slot: 30
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x2F90E14 Offset: 0x2F8CE14 VA: 0x2F90E14
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x2F90FC4 Offset: 0x2F8CFC4 VA: 0x2F90FC4
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}

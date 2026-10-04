// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct TimeSpan : IComparable, IComparable<TimeSpan>, IEquatable<TimeSpan>, IFormattable, ISpanFormattable // TypeDefIndex: 9677
{
	// Fields
	public const long TicksPerMillisecond = 10000;
	private const double MillisecondsPerTick = 0.0001;
	public const long TicksPerSecond = 10000000;
	private const double SecondsPerTick = 1E-07;
	public const long TicksPerMinute = 600000000;
	private const double MinutesPerTick = 1.6666666666666667E-09;
	public const long TicksPerHour = 36000000000;
	private const double HoursPerTick = 2.7777777777777777E-11;
	public const long TicksPerDay = 864000000000;
	private const double DaysPerTick = 1.1574074074074074E-12;
	private const int MillisPerSecond = 1000;
	private const int MillisPerMinute = 60000;
	private const int MillisPerHour = 3600000;
	private const int MillisPerDay = 86400000;
	internal const long MaxSeconds = 922337203685;
	internal const long MinSeconds = -922337203685;
	internal const long MaxMilliSeconds = 922337203685477;
	internal const long MinMilliSeconds = -922337203685477;
	internal const long TicksPerTenthSecond = 1000000;
	public static readonly TimeSpan Zero; // 0x0
	public static readonly TimeSpan MaxValue; // 0x8
	public static readonly TimeSpan MinValue; // 0x10
	internal readonly long _ticks; // 0x0

	// Properties
	public long Ticks { get; }
	public int Days { get; }
	public int Hours { get; }
	public int Milliseconds { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public double TotalDays { get; }
	public double TotalHours { get; }
	public double TotalMilliseconds { get; }
	public double TotalMinutes { get; }
	public double TotalSeconds { get; }

	// Methods

	// RVA: 0x2FFBF20 Offset: 0x2FF7F20 VA: 0x2FFBF20
	public void .ctor(long ticks) { }

	// RVA: 0x2FFBF28 Offset: 0x2FF7F28 VA: 0x2FFBF28
	public void .ctor(int hours, int minutes, int seconds) { }

	// RVA: 0x2FFC040 Offset: 0x2FF8040 VA: 0x2FFC040
	public void .ctor(int days, int hours, int minutes, int seconds) { }

	// RVA: 0x2FFC0C8 Offset: 0x2FF80C8 VA: 0x2FFC0C8
	public void .ctor(int days, int hours, int minutes, int seconds, int milliseconds) { }

	// RVA: 0x2FFC184 Offset: 0x2FF8184 VA: 0x2FFC184
	public long get_Ticks() { }

	// RVA: 0x2FFC18C Offset: 0x2FF818C VA: 0x2FFC18C
	public int get_Days() { }

	// RVA: 0x2FFC1B8 Offset: 0x2FF81B8 VA: 0x2FFC1B8
	public int get_Hours() { }

	// RVA: 0x2FFC1FC Offset: 0x2FF81FC VA: 0x2FFC1FC
	public int get_Milliseconds() { }

	// RVA: 0x2FFC248 Offset: 0x2FF8248 VA: 0x2FFC248
	public int get_Minutes() { }

	// RVA: 0x2FFC290 Offset: 0x2FF8290 VA: 0x2FFC290
	public int get_Seconds() { }

	// RVA: 0x2FFC2DC Offset: 0x2FF82DC VA: 0x2FFC2DC
	public double get_TotalDays() { }

	// RVA: 0x2FFC2F4 Offset: 0x2FF82F4 VA: 0x2FFC2F4
	public double get_TotalHours() { }

	// RVA: 0x2FFC30C Offset: 0x2FF830C VA: 0x2FFC30C
	public double get_TotalMilliseconds() { }

	// RVA: 0x2FFC340 Offset: 0x2FF8340 VA: 0x2FFC340
	public double get_TotalMinutes() { }

	// RVA: 0x2FFC358 Offset: 0x2FF8358 VA: 0x2FFC358
	public double get_TotalSeconds() { }

	// RVA: 0x2FFC370 Offset: 0x2FF8370 VA: 0x2FFC370
	public TimeSpan Add(TimeSpan ts) { }

	// RVA: 0x2FFC3D8 Offset: 0x2FF83D8 VA: 0x2FFC3D8
	public static int Compare(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x2FFC3F0 Offset: 0x2FF83F0 VA: 0x2FFC3F0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x2FFC4B4 Offset: 0x2FF84B4 VA: 0x2FFC4B4 Slot: 5
	public int CompareTo(TimeSpan value) { }

	// RVA: 0x2FFC4D0 Offset: 0x2FF84D0 VA: 0x2FFC4D0
	public static TimeSpan FromDays(double value) { }

	// RVA: 0x2FFC628 Offset: 0x2FF8628 VA: 0x2FFC628 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2FFC6A0 Offset: 0x2FF86A0 VA: 0x2FFC6A0 Slot: 6
	public bool Equals(TimeSpan obj) { }

	// RVA: 0x2FFC6B0 Offset: 0x2FF86B0 VA: 0x2FFC6B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FFC6BC Offset: 0x2FF86BC VA: 0x2FFC6BC
	public static TimeSpan FromHours(double value) { }

	// RVA: 0x2FFC534 Offset: 0x2FF8534 VA: 0x2FFC534
	private static TimeSpan Interval(double value, int scale) { }

	// RVA: 0x2FFC720 Offset: 0x2FF8720 VA: 0x2FFC720
	public static TimeSpan FromMilliseconds(double value) { }

	// RVA: 0x2FFC780 Offset: 0x2FF8780 VA: 0x2FFC780
	public static TimeSpan FromMinutes(double value) { }

	// RVA: 0x2FFC7E0 Offset: 0x2FF87E0 VA: 0x2FFC7E0
	public TimeSpan Negate() { }

	// RVA: 0x2FFC890 Offset: 0x2FF8890 VA: 0x2FFC890
	public static TimeSpan FromSeconds(double value) { }

	// RVA: 0x2FFC8F0 Offset: 0x2FF88F0 VA: 0x2FFC8F0
	public TimeSpan Subtract(TimeSpan ts) { }

	// RVA: 0x2FFC958 Offset: 0x2FF8958 VA: 0x2FFC958
	public static TimeSpan FromTicks(long value) { }

	// RVA: 0x2FFBFA8 Offset: 0x2FF7FA8 VA: 0x2FFBFA8
	internal static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x2FFC95C Offset: 0x2FF895C VA: 0x2FFC95C
	public static TimeSpan Parse(string s) { }

	// RVA: 0x2FFC9B8 Offset: 0x2FF89B8 VA: 0x2FFC9B8
	public static TimeSpan Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x2FFCA18 Offset: 0x2FF8A18 VA: 0x2FFCA18
	public static bool TryParse(string s, out TimeSpan result) { }

	// RVA: 0x2FFCA84 Offset: 0x2FF8A84 VA: 0x2FFCA84
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, out TimeSpan result) { }

	// RVA: 0x2FFCB58 Offset: 0x2FF8B58 VA: 0x2FFCB58 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FFCBBC Offset: 0x2FF8BBC VA: 0x2FFCBBC
	public string ToString(string format) { }

	// RVA: 0x2FFCC2C Offset: 0x2FF8C2C VA: 0x2FFCC2C Slot: 7
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2FFCCA0 Offset: 0x2FF8CA0 VA: 0x2FFCCA0 Slot: 8
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x2FFCD44 Offset: 0x2FF8D44 VA: 0x2FFCD44
	public static TimeSpan op_UnaryNegation(TimeSpan t) { }

	// RVA: 0x2FFCDF0 Offset: 0x2FF8DF0 VA: 0x2FFCDF0
	public static TimeSpan op_Subtraction(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x2FFCE58 Offset: 0x2FF8E58 VA: 0x2FFCE58
	public static TimeSpan op_Addition(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x2FFCEC0 Offset: 0x2FF8EC0 VA: 0x2FFCEC0
	public static bool op_Equality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x2FFCECC Offset: 0x2FF8ECC VA: 0x2FFCECC
	public static bool op_Inequality(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x2FFCED8 Offset: 0x2FF8ED8 VA: 0x2FFCED8
	public static bool op_LessThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x2FFCEE4 Offset: 0x2FF8EE4 VA: 0x2FFCEE4
	public static bool op_LessThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x2FFCEF0 Offset: 0x2FF8EF0 VA: 0x2FFCEF0
	public static bool op_GreaterThan(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x2FFCEFC Offset: 0x2FF8EFC VA: 0x2FFCEFC
	public static bool op_GreaterThanOrEqual(TimeSpan t1, TimeSpan t2) { }

	// RVA: 0x2FFCF08 Offset: 0x2FF8F08 VA: 0x2FFCF08
	private static void .cctor() { }
}

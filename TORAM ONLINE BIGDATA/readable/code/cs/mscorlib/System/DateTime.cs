// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct DateTime : IComparable, IFormattable, IConvertible, IComparable<DateTime>, IEquatable<DateTime>, ISerializable, ISpanFormattable // TypeDefIndex: 9567
{
	// Fields
	private const long TicksPerMillisecond = 10000;
	private const long TicksPerSecond = 10000000;
	private const long TicksPerMinute = 600000000;
	private const long TicksPerHour = 36000000000;
	private const long TicksPerDay = 864000000000;
	private const int MillisPerSecond = 1000;
	private const int MillisPerMinute = 60000;
	private const int MillisPerHour = 3600000;
	private const int MillisPerDay = 86400000;
	private const int DaysPerYear = 365;
	private const int DaysPer4Years = 1461;
	private const int DaysPer100Years = 36524;
	private const int DaysPer400Years = 146097;
	private const int DaysTo1601 = 584388;
	private const int DaysTo1899 = 693593;
	internal const int DaysTo1970 = 719162;
	private const int DaysTo10000 = 3652059;
	internal const long MinTicks = 0;
	internal const long MaxTicks = 3155378975999999999;
	private const long MaxMillis = 315537897600000;
	internal const long UnixEpochTicks = 621355968000000000;
	private const long FileTimeOffset = 504911232000000000;
	private const long DoubleDateOffset = 599264352000000000;
	private const long OADateMinAsTicks = 31241376000000000;
	private const double OADateMinAsDouble = -657435;
	private const double OADateMaxAsDouble = 2958466;
	private const int DatePartYear = 0;
	private const int DatePartDayOfYear = 1;
	private const int DatePartMonth = 2;
	private const int DatePartDay = 3;
	private static readonly int[] s_daysToMonth365; // 0x0
	private static readonly int[] s_daysToMonth366; // 0x8
	public static readonly DateTime MinValue; // 0x10
	public static readonly DateTime MaxValue; // 0x18
	public static readonly DateTime UnixEpoch; // 0x20
	private const ulong TicksMask = 4611686018427387903;
	private const ulong FlagsMask = 13835058055282163712;
	private const ulong LocalMask = 9223372036854775808;
	private const long TicksCeiling = 4611686018427387904;
	private const ulong KindUnspecified = 0;
	private const ulong KindUtc = 4611686018427387904;
	private const ulong KindLocal = 9223372036854775808;
	private const ulong KindLocalAmbiguousDst = 13835058055282163712;
	private const int KindShift = 62;
	private const string TicksField = "ticks";
	private const string DateDataField = "dateData";
	private readonly ulong _dateData; // 0x0

	// Properties
	internal long InternalTicks { get; }
	private ulong InternalKind { get; }
	public DateTime Date { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public int DayOfYear { get; }
	public int Hour { get; }
	public DateTimeKind Kind { get; }
	public int Millisecond { get; }
	public int Minute { get; }
	public int Month { get; }
	public static DateTime Now { get; }
	public int Second { get; }
	public long Ticks { get; }
	public TimeSpan TimeOfDay { get; }
	public static DateTime Today { get; }
	public int Year { get; }
	public static DateTime UtcNow { get; }

	// Methods

	// RVA: 0x2FC52A0 Offset: 0x2FC12A0 VA: 0x2FC52A0
	public void .ctor(long ticks) { }

	// RVA: 0x2FC532C Offset: 0x2FC132C VA: 0x2FC532C
	private void .ctor(ulong dateData) { }

	// RVA: 0x2FC5334 Offset: 0x2FC1334 VA: 0x2FC5334
	public void .ctor(long ticks, DateTimeKind kind) { }

	// RVA: 0x2FC5414 Offset: 0x2FC1414 VA: 0x2FC5414
	internal void .ctor(long ticks, DateTimeKind kind, bool isAmbiguousDst) { }

	// RVA: 0x2FC54B4 Offset: 0x2FC14B4 VA: 0x2FC54B4
	public void .ctor(int year, int month, int day) { }

	// RVA: 0x2FC56EC Offset: 0x2FC16EC VA: 0x2FC56EC
	public void .ctor(int year, int month, int day, int hour, int minute, int second) { }

	// RVA: 0x2FC586C Offset: 0x2FC186C VA: 0x2FC586C
	public void .ctor(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind) { }

	// RVA: 0x2FC5984 Offset: 0x2FC1984 VA: 0x2FC5984
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: 0x2FC5B54 Offset: 0x2FC1B54 VA: 0x2FC5B54
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, DateTimeKind kind) { }

	// RVA: 0x2FC5D7C Offset: 0x2FC1D7C VA: 0x2FC5D7C
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar) { }

	// RVA: 0x2FC6004 Offset: 0x2FC2004 VA: 0x2FC6004
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FC62C8 Offset: 0x2FC22C8 VA: 0x2FC62C8
	internal long get_InternalTicks() { }

	// RVA: 0x2FC62D4 Offset: 0x2FC22D4 VA: 0x2FC62D4
	private ulong get_InternalKind() { }

	// RVA: 0x2FC62E0 Offset: 0x2FC22E0 VA: 0x2FC62E0
	public DateTime Add(TimeSpan value) { }

	// RVA: 0x2FC644C Offset: 0x2FC244C VA: 0x2FC644C
	private DateTime Add(double value, int scale) { }

	// RVA: 0x2FC6574 Offset: 0x2FC2574 VA: 0x2FC6574
	public DateTime AddDays(double value) { }

	// RVA: 0x2FC65E0 Offset: 0x2FC25E0 VA: 0x2FC65E0
	public DateTime AddHours(double value) { }

	// RVA: 0x2FC664C Offset: 0x2FC264C VA: 0x2FC664C
	public DateTime AddMilliseconds(double value) { }

	// RVA: 0x2FC66B4 Offset: 0x2FC26B4 VA: 0x2FC66B4
	public DateTime AddMinutes(double value) { }

	// RVA: 0x2FC671C Offset: 0x2FC271C VA: 0x2FC671C
	public DateTime AddMonths(int months) { }

	// RVA: 0x2FC6C80 Offset: 0x2FC2C80 VA: 0x2FC6C80
	public DateTime AddSeconds(double value) { }

	// RVA: 0x2FC6344 Offset: 0x2FC2344 VA: 0x2FC6344
	public DateTime AddTicks(long value) { }

	// RVA: 0x2FC6CE8 Offset: 0x2FC2CE8 VA: 0x2FC6CE8
	public DateTime AddYears(int value) { }

	// RVA: 0x2FC6DB8 Offset: 0x2FC2DB8 VA: 0x2FC6DB8
	public static int Compare(DateTime t1, DateTime t2) { }

	// RVA: 0x2FC6E30 Offset: 0x2FC2E30 VA: 0x2FC6E30 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x2FC6F24 Offset: 0x2FC2F24 VA: 0x2FC6F24 Slot: 23
	public int CompareTo(DateTime value) { }

	// RVA: 0x2FC5534 Offset: 0x2FC1534 VA: 0x2FC5534
	private static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x2FC5798 Offset: 0x2FC1798 VA: 0x2FC5798
	private static long TimeToTicks(int hour, int minute, int second) { }

	// RVA: 0x2FC6B54 Offset: 0x2FC2B54 VA: 0x2FC6B54
	public static int DaysInMonth(int year, int month) { }

	// RVA: 0x2FC7054 Offset: 0x2FC3054 VA: 0x2FC7054 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x2FC7104 Offset: 0x2FC3104 VA: 0x2FC7104 Slot: 24
	public bool Equals(DateTime value) { }

	// RVA: 0x2FC7170 Offset: 0x2FC3170 VA: 0x2FC7170
	public static DateTime FromBinary(long dateData) { }

	// RVA: 0x2FC73D8 Offset: 0x2FC33D8 VA: 0x2FC73D8
	internal static DateTime FromBinaryRaw(long dateData) { }

	// RVA: 0x2FC745C Offset: 0x2FC345C VA: 0x2FC745C Slot: 25
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FC7554 Offset: 0x2FC3554 VA: 0x2FC7554
	public static DateTime SpecifyKind(DateTime value, DateTimeKind kind) { }

	// RVA: 0x2FC75C8 Offset: 0x2FC35C8 VA: 0x2FC75C8
	public DateTime get_Date() { }

	// RVA: 0x2FC7650 Offset: 0x2FC3650 VA: 0x2FC7650
	private int GetDatePart(int part) { }

	// RVA: 0x2FC695C Offset: 0x2FC295C VA: 0x2FC695C
	internal void GetDatePart(out int year, out int month, out int day) { }

	// RVA: 0x2FC784C Offset: 0x2FC384C VA: 0x2FC784C
	public int get_Day() { }

	// RVA: 0x2FC78A4 Offset: 0x2FC38A4 VA: 0x2FC78A4
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x2FC793C Offset: 0x2FC393C VA: 0x2FC793C
	public int get_DayOfYear() { }

	// RVA: 0x2FC7994 Offset: 0x2FC3994 VA: 0x2FC7994 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FC79F0 Offset: 0x2FC39F0 VA: 0x2FC79F0
	public int get_Hour() { }

	// RVA: 0x2FC7A78 Offset: 0x2FC3A78 VA: 0x2FC7A78
	internal bool IsAmbiguousDaylightSavingTime() { }

	// RVA: 0x2FC7AD8 Offset: 0x2FC3AD8 VA: 0x2FC7AD8
	public DateTimeKind get_Kind() { }

	// RVA: 0x2FC7B4C Offset: 0x2FC3B4C VA: 0x2FC7B4C
	public int get_Millisecond() { }

	// RVA: 0x2FC7BE0 Offset: 0x2FC3BE0 VA: 0x2FC7BE0
	public int get_Minute() { }

	// RVA: 0x2FC7C68 Offset: 0x2FC3C68 VA: 0x2FC7C68
	public int get_Month() { }

	// RVA: 0x2FC7CC0 Offset: 0x2FC3CC0 VA: 0x2FC7CC0
	public static DateTime get_Now() { }

	// RVA: 0x2FC7E44 Offset: 0x2FC3E44 VA: 0x2FC7E44
	public int get_Second() { }

	// RVA: 0x2FC5FAC Offset: 0x2FC1FAC VA: 0x2FC5FAC
	public long get_Ticks() { }

	// RVA: 0x2FC7ECC Offset: 0x2FC3ECC VA: 0x2FC7ECC
	public TimeSpan get_TimeOfDay() { }

	// RVA: 0x2FC7F4C Offset: 0x2FC3F4C VA: 0x2FC7F4C
	public static DateTime get_Today() { }

	// RVA: 0x2FC7FA8 Offset: 0x2FC3FA8 VA: 0x2FC7FA8
	public int get_Year() { }

	// RVA: 0x2FC6F8C Offset: 0x2FC2F8C VA: 0x2FC6F8C
	public static bool IsLeapYear(int year) { }

	// RVA: 0x2FC8000 Offset: 0x2FC4000 VA: 0x2FC8000
	public static DateTime Parse(string s, IFormatProvider provider) { }

	// RVA: 0x2FC81E4 Offset: 0x2FC41E4 VA: 0x2FC81E4
	public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles) { }

	// RVA: 0x2FC8314 Offset: 0x2FC4314 VA: 0x2FC8314
	public static DateTime ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x2FC85B4 Offset: 0x2FC45B4 VA: 0x2FC85B4
	public static DateTime ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style) { }

	// RVA: 0x2FC87EC Offset: 0x2FC47EC VA: 0x2FC87EC
	public TimeSpan Subtract(DateTime value) { }

	// RVA: 0x2FC8858 Offset: 0x2FC4858 VA: 0x2FC8858
	public DateTime ToLocalTime() { }

	// RVA: 0x2FC88B0 Offset: 0x2FC48B0 VA: 0x2FC88B0
	internal DateTime ToLocalTime(bool throwOnOverflow) { }

	// RVA: 0x2FC8A64 Offset: 0x2FC4A64 VA: 0x2FC8A64 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FC8B3C Offset: 0x2FC4B3C VA: 0x2FC8B3C
	public string ToString(string format) { }

	// RVA: 0x2FC8BA8 Offset: 0x2FC4BA8 VA: 0x2FC8BA8 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2FC8C14 Offset: 0x2FC4C14 VA: 0x2FC8C14 Slot: 5
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x2FC8C84 Offset: 0x2FC4C84 VA: 0x2FC8C84 Slot: 26
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider) { }

	// RVA: 0x2FC8DDC Offset: 0x2FC4DDC VA: 0x2FC8DDC
	public DateTime ToUniversalTime() { }

	// RVA: 0x2FC8E3C Offset: 0x2FC4E3C VA: 0x2FC8E3C
	public static bool TryParse(string s, out DateTime result) { }

	// RVA: 0x2FC9044 Offset: 0x2FC5044 VA: 0x2FC9044
	public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result) { }

	// RVA: 0x2FC9188 Offset: 0x2FC5188 VA: 0x2FC9188
	public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out DateTime result) { }

	// RVA: 0x2FC9440 Offset: 0x2FC5440 VA: 0x2FC9440
	public static DateTime op_Addition(DateTime d, TimeSpan t) { }

	// RVA: 0x2FC9540 Offset: 0x2FC5540 VA: 0x2FC9540
	public static DateTime op_Subtraction(DateTime d, TimeSpan t) { }

	// RVA: 0x2FC9638 Offset: 0x2FC5638 VA: 0x2FC9638
	public static TimeSpan op_Subtraction(DateTime d1, DateTime d2) { }

	// RVA: 0x2FC96A0 Offset: 0x2FC56A0 VA: 0x2FC96A0
	public static bool op_Equality(DateTime d1, DateTime d2) { }

	// RVA: 0x2FC9708 Offset: 0x2FC5708 VA: 0x2FC9708
	public static bool op_Inequality(DateTime d1, DateTime d2) { }

	// RVA: 0x2FC9770 Offset: 0x2FC5770 VA: 0x2FC9770
	public static bool op_LessThan(DateTime t1, DateTime t2) { }

	// RVA: 0x2FC97DC Offset: 0x2FC57DC VA: 0x2FC97DC
	public static bool op_LessThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x2FC9848 Offset: 0x2FC5848 VA: 0x2FC9848
	public static bool op_GreaterThan(DateTime t1, DateTime t2) { }

	// RVA: 0x2FC98B4 Offset: 0x2FC58B4 VA: 0x2FC98B4
	public static bool op_GreaterThanOrEqual(DateTime t1, DateTime t2) { }

	// RVA: 0x2FC9920 Offset: 0x2FC5920 VA: 0x2FC9920 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x2FC9928 Offset: 0x2FC5928 VA: 0x2FC9928 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2FC99AC Offset: 0x2FC59AC VA: 0x2FC99AC Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x2FC9A30 Offset: 0x2FC5A30 VA: 0x2FC9A30 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2FC9AB4 Offset: 0x2FC5AB4 VA: 0x2FC9AB4 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2FC9B38 Offset: 0x2FC5B38 VA: 0x2FC9B38 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2FC9BBC Offset: 0x2FC5BBC VA: 0x2FC9BBC Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2FC9C40 Offset: 0x2FC5C40 VA: 0x2FC9C40 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2FC9CC4 Offset: 0x2FC5CC4 VA: 0x2FC9CC4 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2FC9D48 Offset: 0x2FC5D48 VA: 0x2FC9D48 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2FC9DCC Offset: 0x2FC5DCC VA: 0x2FC9DCC Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2FC9E50 Offset: 0x2FC5E50 VA: 0x2FC9E50 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2FC9ED4 Offset: 0x2FC5ED4 VA: 0x2FC9ED4 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2FC9F58 Offset: 0x2FC5F58 VA: 0x2FC9F58 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2FC9FDC Offset: 0x2FC5FDC VA: 0x2FC9FDC Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x2FC9FE4 Offset: 0x2FC5FE4 VA: 0x2FC9FE4 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x2FCA090 Offset: 0x2FC6090 VA: 0x2FCA090
	internal static bool TryCreate(int year, int month, int day, int hour, int minute, int second, int millisecond, out DateTime result) { }

	// RVA: 0x2FC7DE0 Offset: 0x2FC3DE0 VA: 0x2FC7DE0
	public static DateTime get_UtcNow() { }

	// RVA: 0x2FCA280 Offset: 0x2FC6280 VA: 0x2FCA280
	internal static long GetSystemTimeAsFileTime() { }

	// RVA: 0x2FCA284 Offset: 0x2FC6284 VA: 0x2FCA284
	internal long ToBinaryRaw() { }

	// RVA: 0x2FCA28C Offset: 0x2FC628C VA: 0x2FCA28C
	private static void .cctor() { }
}

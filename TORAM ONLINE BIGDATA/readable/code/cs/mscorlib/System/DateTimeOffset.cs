// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct DateTimeOffset : IComparable, IFormattable, IComparable<DateTimeOffset>, IEquatable<DateTimeOffset>, ISerializable, IDeserializationCallback, ISpanFormattable // TypeDefIndex: 9569
{
	// Fields
	public static readonly DateTimeOffset MinValue; // 0x0
	public static readonly DateTimeOffset MaxValue; // 0x10
	public static readonly DateTimeOffset UnixEpoch; // 0x20
	private readonly DateTime _dateTime; // 0x0
	private readonly short _offsetMinutes; // 0x8

	// Properties
	public static DateTimeOffset Now { get; }
	public DateTime DateTime { get; }
	public DateTime UtcDateTime { get; }
	public DateTime LocalDateTime { get; }
	private DateTime ClockDateTime { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Millisecond { get; }
	public int Minute { get; }
	public int Month { get; }
	public TimeSpan Offset { get; }
	public int Second { get; }
	public long Ticks { get; }
	public TimeSpan TimeOfDay { get; }
	public int Year { get; }

	// Methods

	// RVA: 0x2FCA39C Offset: 0x2FC639C VA: 0x2FCA39C
	public void .ctor(long ticks, TimeSpan offset) { }

	// RVA: 0x2FCA6C8 Offset: 0x2FC66C8 VA: 0x2FCA6C8
	public void .ctor(DateTime dateTime) { }

	// RVA: 0x2FCA7DC Offset: 0x2FC67DC VA: 0x2FCA7DC
	public void .ctor(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x2FCA9D4 Offset: 0x2FC69D4 VA: 0x2FCA9D4
	public void .ctor(int year, int month, int day, int hour, int minute, int second, TimeSpan offset) { }

	// RVA: 0x2FCAAA0 Offset: 0x2FC6AA0 VA: 0x2FCAAA0
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, TimeSpan offset) { }

	// RVA: 0x2FCAB7C Offset: 0x2FC6B7C VA: 0x2FCAB7C
	public void .ctor(int year, int month, int day, int hour, int minute, int second, int millisecond, Calendar calendar, TimeSpan offset) { }

	// RVA: 0x2FCAC60 Offset: 0x2FC6C60 VA: 0x2FCAC60
	public static DateTimeOffset get_Now() { }

	// RVA: 0x2FCACCC Offset: 0x2FC6CCC VA: 0x2FCACCC
	public DateTime get_DateTime() { }

	// RVA: 0x2FCADF0 Offset: 0x2FC6DF0 VA: 0x2FCADF0
	public DateTime get_UtcDateTime() { }

	// RVA: 0x2FCAE4C Offset: 0x2FC6E4C VA: 0x2FCAE4C
	public DateTime get_LocalDateTime() { }

	// RVA: 0x2FCAD20 Offset: 0x2FC6D20 VA: 0x2FCAD20
	private DateTime get_ClockDateTime() { }

	// RVA: 0x2FCAF0C Offset: 0x2FC6F0C VA: 0x2FCAF0C
	public int get_Day() { }

	// RVA: 0x2FCAFA0 Offset: 0x2FC6FA0 VA: 0x2FCAFA0
	public int get_Hour() { }

	// RVA: 0x2FCB034 Offset: 0x2FC7034 VA: 0x2FCB034
	public int get_Millisecond() { }

	// RVA: 0x2FCB0C8 Offset: 0x2FC70C8 VA: 0x2FCB0C8
	public int get_Minute() { }

	// RVA: 0x2FCB15C Offset: 0x2FC715C VA: 0x2FCB15C
	public int get_Month() { }

	// RVA: 0x2FCAEE0 Offset: 0x2FC6EE0 VA: 0x2FCAEE0
	public TimeSpan get_Offset() { }

	// RVA: 0x2FCB1F0 Offset: 0x2FC71F0 VA: 0x2FCB1F0
	public int get_Second() { }

	// RVA: 0x2FCB284 Offset: 0x2FC7284 VA: 0x2FCB284
	public long get_Ticks() { }

	// RVA: 0x2FCB318 Offset: 0x2FC7318 VA: 0x2FCB318
	public TimeSpan get_TimeOfDay() { }

	// RVA: 0x2FCB3AC Offset: 0x2FC73AC VA: 0x2FCB3AC
	public int get_Year() { }

	// RVA: 0x2FCB440 Offset: 0x2FC7440 VA: 0x2FCB440
	public static int Compare(DateTimeOffset first, DateTimeOffset second) { }

	// RVA: 0x2FCB4E4 Offset: 0x2FC74E4 VA: 0x2FCB4E4 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x2FCB62C Offset: 0x2FC762C VA: 0x2FCB62C Slot: 6
	public int CompareTo(DateTimeOffset other) { }

	// RVA: 0x2FCB700 Offset: 0x2FC7700 VA: 0x2FCB700 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2FCB7F0 Offset: 0x2FC77F0 VA: 0x2FCB7F0 Slot: 7
	public bool Equals(DateTimeOffset other) { }

	// RVA: 0x2FCB89C Offset: 0x2FC789C VA: 0x2FCB89C
	public static DateTimeOffset FromUnixTimeSeconds(long seconds) { }

	// RVA: 0x2FCBA0C Offset: 0x2FC7A0C VA: 0x2FCBA0C Slot: 9
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x2FCBB8C Offset: 0x2FC7B8C VA: 0x2FCBB8C Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FCBC54 Offset: 0x2FC7C54 VA: 0x2FCBC54
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FCBE10 Offset: 0x2FC7E10 VA: 0x2FCBE10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FCBEA4 Offset: 0x2FC7EA4 VA: 0x2FCBEA4
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider) { }

	// RVA: 0x2FCBF14 Offset: 0x2FC7F14 VA: 0x2FCBF14
	public static DateTimeOffset Parse(string input, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x2FCC294 Offset: 0x2FC8294 VA: 0x2FCC294
	public static DateTimeOffset ParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles) { }

	// RVA: 0x2FCC600 Offset: 0x2FC8600 VA: 0x2FCC600 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FCC96C Offset: 0x2FC896C VA: 0x2FCC96C
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0x2FCCA2C Offset: 0x2FC8A2C VA: 0x2FCCA2C Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x2FCCAF8 Offset: 0x2FC8AF8 VA: 0x2FCCAF8 Slot: 10
	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x2FCCE04 Offset: 0x2FC8E04 VA: 0x2FCCE04
	public DateTimeOffset ToUniversalTime() { }

	// RVA: 0x2FCCE78 Offset: 0x2FC8E78 VA: 0x2FCCE78
	public static bool TryParse(string input, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x2FCD18C Offset: 0x2FC918C VA: 0x2FCD18C
	public static bool TryParseExact(string input, string format, IFormatProvider formatProvider, DateTimeStyles styles, out DateTimeOffset result) { }

	// RVA: 0x2FCA454 Offset: 0x2FC6454 VA: 0x2FCA454
	private static short ValidateOffset(TimeSpan offset) { }

	// RVA: 0x2FCA5AC Offset: 0x2FC65AC VA: 0x2FCA5AC
	private static DateTime ValidateDate(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x2FCC0C0 Offset: 0x2FC80C0 VA: 0x2FCC0C0
	private static DateTimeStyles ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x2FCD500 Offset: 0x2FC9500 VA: 0x2FCD500
	public static DateTimeOffset op_Implicit(DateTime dateTime) { }

	// RVA: 0x2FCD528 Offset: 0x2FC9528 VA: 0x2FCD528
	public static TimeSpan op_Subtraction(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x2FCD5CC Offset: 0x2FC95CC VA: 0x2FCD5CC
	public static bool op_Equality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x2FCD670 Offset: 0x2FC9670 VA: 0x2FCD670
	public static bool op_Inequality(DateTimeOffset left, DateTimeOffset right) { }

	// RVA: 0x2FCD714 Offset: 0x2FC9714 VA: 0x2FCD714
	private static void .cctor() { }
}

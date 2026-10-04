// Assembly: System.Xml.dll
// Namespace: System.Xml
internal abstract class BinXmlDateTime // TypeDefIndex: 13262
{
	// Fields
	internal static int[] KatmaiTimeScaleMultiplicator; // 0x0
	private static readonly double SQLTicksPerMillisecond; // 0x8
	public static readonly int SQLTicksPerSecond; // 0x10
	public static readonly int SQLTicksPerMinute; // 0x14
	public static readonly int SQLTicksPerHour; // 0x18
	private static readonly int SQLTicksPerDay; // 0x1C

	// Methods

	// RVA: 0x32AC000 Offset: 0x32A8000 VA: 0x32AC000
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x32AC05C Offset: 0x32A805C VA: 0x32AC05C
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x32AC100 Offset: 0x32A8100 VA: 0x32AC100
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x32AC1AC Offset: 0x32A81AC VA: 0x32AC1AC
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x32AC260 Offset: 0x32A8260 VA: 0x32AC260
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x32AC34C Offset: 0x32A834C VA: 0x32AC34C
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x32AC540 Offset: 0x32A8540 VA: 0x32AC540
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x32AC63C Offset: 0x32A863C VA: 0x32AC63C
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x32AC710 Offset: 0x32A8710 VA: 0x32AC710
	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x32AC8E0 Offset: 0x32A88E0 VA: 0x32AC8E0
	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	// RVA: 0x32ACA50 Offset: 0x32A8A50 VA: 0x32ACA50
	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x32ACB58 Offset: 0x32A8B58 VA: 0x32ACB58
	public static string XsdDateTimeToString(long val) { }

	// RVA: 0x32ACC60 Offset: 0x32A8C60 VA: 0x32ACC60
	public static string XsdDateToString(long val) { }

	// RVA: 0x32ACD44 Offset: 0x32A8D44 VA: 0x32ACD44
	public static string XsdTimeToString(long val) { }

	// RVA: 0x32ACE18 Offset: 0x32A8E18 VA: 0x32ACE18
	public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

	// RVA: 0x32ACF54 Offset: 0x32A8F54 VA: 0x32ACF54
	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

	// RVA: 0x32AD048 Offset: 0x32A9048 VA: 0x32AD048
	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

	// RVA: 0x32AD138 Offset: 0x32A9138 VA: 0x32AD138
	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

	// RVA: 0x32AD1AC Offset: 0x32A91AC VA: 0x32AD1AC
	public static DateTime XsdKatmaiDateToDateTime(byte[] data, int offset) { }

	// RVA: 0x32AD2A0 Offset: 0x32A92A0 VA: 0x32AD2A0
	public static DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x32AD558 Offset: 0x32A9558 VA: 0x32AD558
	public static DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x32AD5BC Offset: 0x32A95BC VA: 0x32AD5BC
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x32AD620 Offset: 0x32A9620 VA: 0x32AD620
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x32AD71C Offset: 0x32A971C VA: 0x32AD71C
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x32AD780 Offset: 0x32A9780 VA: 0x32AD780
	public static string XsdKatmaiDateToString(byte[] data, int offset) { }

	// RVA: 0x32AD898 Offset: 0x32A9898 VA: 0x32AD898
	public static string XsdKatmaiDateTimeToString(byte[] data, int offset) { }

	// RVA: 0x32ADB28 Offset: 0x32A9B28 VA: 0x32ADB28
	public static string XsdKatmaiTimeToString(byte[] data, int offset) { }

	// RVA: 0x32ADC54 Offset: 0x32A9C54 VA: 0x32ADC54
	public static string XsdKatmaiDateOffsetToString(byte[] data, int offset) { }

	// RVA: 0x32ADD8C Offset: 0x32A9D8C VA: 0x32ADD8C
	public static string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x32AE064 Offset: 0x32AA064 VA: 0x32AE064
	public static string XsdKatmaiTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x32AD22C Offset: 0x32A922C VA: 0x32AD22C
	private static long GetKatmaiDateTicks(byte[] data, ref int pos) { }

	// RVA: 0x32AD330 Offset: 0x32A9330 VA: 0x32AD330
	private static long GetKatmaiTimeTicks(byte[] data, ref int pos) { }

	// RVA: 0x32AD6C8 Offset: 0x32A96C8 VA: 0x32AD6C8
	private static long GetKatmaiTimeZoneTicks(byte[] data, int pos) { }

	// RVA: 0x32ADA14 Offset: 0x32A9A14 VA: 0x32ADA14
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x32ADF28 Offset: 0x32A9F28 VA: 0x32ADF28
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x32AE1B0 Offset: 0x32AA1B0 VA: 0x32AE1B0
	private static void .cctor() { }
}

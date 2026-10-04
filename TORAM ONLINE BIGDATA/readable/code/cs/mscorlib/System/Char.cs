// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[Serializable]
public struct Char : IComparable, IComparable<char>, IEquatable<char>, IConvertible // TypeDefIndex: 9561
{
	// Fields
	private readonly char m_value; // 0x0
	public const char MaxValue = '\xffff';
	public const char MinValue = '\x0';
	private static readonly byte[] s_categoryForLatin1; // 0x0
	internal const int UNICODE_PLANE00_END = 65535;
	internal const int UNICODE_PLANE01_START = 65536;
	internal const int UNICODE_PLANE16_END = 1114111;
	internal const int HIGH_SURROGATE_START = 55296;
	internal const int LOW_SURROGATE_END = 57343;

	// Methods

	// RVA: 0x2F772F0 Offset: 0x2F732F0 VA: 0x2F772F0
	private static bool IsLatin1(char ch) { }

	// RVA: 0x2F77300 Offset: 0x2F73300 VA: 0x2F77300
	private static bool IsAscii(char ch) { }

	// RVA: 0x2F77310 Offset: 0x2F73310 VA: 0x2F77310
	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	// RVA: 0x2F7738C Offset: 0x2F7338C VA: 0x2F7738C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F77398 Offset: 0x2F73398 VA: 0x2F77398 Slot: 0
	public override bool Equals(object obj) { }

	[NonVersionable]
	// RVA: 0x2F77410 Offset: 0x2F73410 VA: 0x2F77410 Slot: 6
	public bool Equals(char obj) { }

	// RVA: 0x2F77420 Offset: 0x2F73420 VA: 0x2F77420 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x2F774D8 Offset: 0x2F734D8 VA: 0x2F774D8 Slot: 5
	public int CompareTo(char value) { }

	// RVA: 0x2F66DC4 Offset: 0x2F62DC4 VA: 0x2F66DC4 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F774EC Offset: 0x2F734EC VA: 0x2F774EC Slot: 22
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x2F774E4 Offset: 0x2F734E4 VA: 0x2F774E4
	public static string ToString(char c) { }

	// RVA: 0x2F77548 Offset: 0x2F73548 VA: 0x2F77548
	public static char Parse(string s) { }

	// RVA: 0x2F775E4 Offset: 0x2F735E4 VA: 0x2F775E4
	public static bool TryParse(string s, out char result) { }

	// RVA: 0x2F70AE4 Offset: 0x2F6CAE4 VA: 0x2F70AE4
	public static bool IsDigit(char c) { }

	// RVA: 0x2F77624 Offset: 0x2F73624 VA: 0x2F77624
	internal static bool CheckLetter(UnicodeCategory uc) { }

	// RVA: 0x2F77630 Offset: 0x2F73630 VA: 0x2F77630
	public static bool IsLetter(char c) { }

	// RVA: 0x2F77708 Offset: 0x2F73708 VA: 0x2F77708
	private static bool IsWhiteSpaceLatin1(char c) { }

	// RVA: 0x2F74C8C Offset: 0x2F70C8C VA: 0x2F74C8C
	public static bool IsWhiteSpace(char c) { }

	// RVA: 0x2F77744 Offset: 0x2F73744 VA: 0x2F77744
	public static bool IsUpper(char c) { }

	// RVA: 0x2F77800 Offset: 0x2F73800 VA: 0x2F77800
	public static bool IsLower(char c) { }

	// RVA: 0x2F778BC Offset: 0x2F738BC VA: 0x2F778BC
	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	// RVA: 0x2F778DC Offset: 0x2F738DC VA: 0x2F778DC
	public static bool IsLetterOrDigit(char c) { }

	// RVA: 0x2F779A4 Offset: 0x2F739A4 VA: 0x2F779A4
	public static char ToUpper(char c, CultureInfo culture) { }

	// RVA: 0x2F77A24 Offset: 0x2F73A24 VA: 0x2F77A24
	public static char ToUpperInvariant(char c) { }

	// RVA: 0x2F77AA0 Offset: 0x2F73AA0 VA: 0x2F77AA0
	public static char ToLower(char c, CultureInfo culture) { }

	// RVA: 0x2F77B20 Offset: 0x2F73B20 VA: 0x2F77B20
	public static char ToLowerInvariant(char c) { }

	// RVA: 0x2F77B9C Offset: 0x2F73B9C VA: 0x2F77B9C Slot: 7
	public TypeCode GetTypeCode() { }

	// RVA: 0x2F77BA4 Offset: 0x2F73BA4 VA: 0x2F77BA4 Slot: 8
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x2F77C28 Offset: 0x2F73C28 VA: 0x2F77C28 Slot: 9
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x2F77C30 Offset: 0x2F73C30 VA: 0x2F77C30 Slot: 10
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x2F77CE4 Offset: 0x2F73CE4 VA: 0x2F77CE4 Slot: 11
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x2F77D98 Offset: 0x2F73D98 VA: 0x2F77D98 Slot: 12
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x2F77E44 Offset: 0x2F73E44 VA: 0x2F77E44 Slot: 13
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x2F77EA0 Offset: 0x2F73EA0 VA: 0x2F77EA0 Slot: 14
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x2F77F00 Offset: 0x2F73F00 VA: 0x2F77F00 Slot: 15
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x2F77F60 Offset: 0x2F73F60 VA: 0x2F77F60 Slot: 16
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x2F77FC0 Offset: 0x2F73FC0 VA: 0x2F77FC0 Slot: 17
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x2F78020 Offset: 0x2F74020 VA: 0x2F78020 Slot: 18
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x2F780A4 Offset: 0x2F740A4 VA: 0x2F780A4 Slot: 19
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x2F78128 Offset: 0x2F74128 VA: 0x2F78128 Slot: 20
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x2F781AC Offset: 0x2F741AC VA: 0x2F781AC Slot: 21
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x2F78230 Offset: 0x2F74230 VA: 0x2F78230 Slot: 23
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x2F782D8 Offset: 0x2F742D8 VA: 0x2F782D8
	public static bool IsControl(char c) { }

	// RVA: 0x2F78364 Offset: 0x2F74364 VA: 0x2F78364
	public static bool IsLetterOrDigit(string s, int index) { }

	// RVA: 0x2F784D8 Offset: 0x2F744D8 VA: 0x2F784D8
	internal static bool CheckNumber(UnicodeCategory uc) { }

	// RVA: 0x2F784E8 Offset: 0x2F744E8 VA: 0x2F784E8
	public static bool IsNumber(char c) { }

	// RVA: 0x2F785C0 Offset: 0x2F745C0 VA: 0x2F785C0
	public static bool IsNumber(string s, int index) { }

	// RVA: 0x2F78744 Offset: 0x2F74744 VA: 0x2F78744
	internal static bool CheckSeparator(UnicodeCategory uc) { }

	// RVA: 0x2F78754 Offset: 0x2F74754 VA: 0x2F78754
	private static bool IsSeparatorLatin1(char c) { }

	// RVA: 0x2F78768 Offset: 0x2F74768 VA: 0x2F78768
	public static bool IsSeparator(char c) { }

	// RVA: 0x2F78818 Offset: 0x2F74818 VA: 0x2F78818
	public static bool IsSurrogate(char c) { }

	// RVA: 0x2F78828 Offset: 0x2F74828 VA: 0x2F78828
	public static bool IsSurrogate(string s, int index) { }

	// RVA: 0x2F78924 Offset: 0x2F74924 VA: 0x2F78924
	public static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x2F78A9C Offset: 0x2F74A9C VA: 0x2F78A9C
	public static UnicodeCategory GetUnicodeCategory(char c) { }

	// RVA: 0x2F78B1C Offset: 0x2F74B1C VA: 0x2F78B1C
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x2F78C60 Offset: 0x2F74C60 VA: 0x2F78C60
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x2F78C70 Offset: 0x2F74C70 VA: 0x2F78C70
	public static bool IsHighSurrogate(string s, int index) { }

	// RVA: 0x2F78D70 Offset: 0x2F74D70 VA: 0x2F78D70
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x2F78D80 Offset: 0x2F74D80 VA: 0x2F78D80
	public static bool IsSurrogatePair(string s, int index) { }

	// RVA: 0x2F78EB8 Offset: 0x2F74EB8 VA: 0x2F78EB8
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x2F78ED8 Offset: 0x2F74ED8 VA: 0x2F78ED8
	public static string ConvertFromUtf32(int utf32) { }

	// RVA: 0x2F78FFC Offset: 0x2F74FFC VA: 0x2F78FFC
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x2F79120 Offset: 0x2F75120 VA: 0x2F79120
	private static void .cctor() { }
}

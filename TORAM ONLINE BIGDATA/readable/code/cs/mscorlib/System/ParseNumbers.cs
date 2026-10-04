// Assembly: mscorlib.dll
// Namespace: System
internal static class ParseNumbers // TypeDefIndex: 9652
{
	// Methods

	// RVA: 0x2FF4D30 Offset: 0x2FF0D30 VA: 0x2FF4D30
	public static long StringToLong(ReadOnlySpan<char> s, int radix, int flags) { }

	// RVA: 0x2FF4D48 Offset: 0x2FF0D48 VA: 0x2FF4D48
	public static long StringToLong(ReadOnlySpan<char> s, int radix, int flags, ref int currPos) { }

	// RVA: 0x2FF536C Offset: 0x2FF136C VA: 0x2FF536C
	public static int StringToInt(ReadOnlySpan<char> s, int radix, int flags) { }

	// RVA: 0x2FF5384 Offset: 0x2FF1384 VA: 0x2FF5384
	public static int StringToInt(ReadOnlySpan<char> s, int radix, int flags, ref int currPos) { }

	// RVA: 0x2FF5960 Offset: 0x2FF1960 VA: 0x2FF5960
	public static string IntToString(int n, int radix, int width, char paddingChar, int flags) { }

	// RVA: 0x2FF5C88 Offset: 0x2FF1C88 VA: 0x2FF5C88
	public static string LongToString(long n, int radix, int width, char paddingChar, int flags) { }

	// RVA: 0x2FF50AC Offset: 0x2FF10AC VA: 0x2FF50AC
	private static void EatWhiteSpace(ReadOnlySpan<char> s, ref int i) { }

	// RVA: 0x2FF5178 Offset: 0x2FF1178 VA: 0x2FF5178
	private static long GrabLongs(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned) { }

	// RVA: 0x2FF5740 Offset: 0x2FF1740 VA: 0x2FF5740
	private static int GrabInts(int radix, ReadOnlySpan<char> s, ref int i, bool isUnsigned) { }

	// RVA: 0x2FF60B8 Offset: 0x2FF20B8 VA: 0x2FF60B8
	private static void ThrowOverflowInt32Exception() { }

	// RVA: 0x2FF6028 Offset: 0x2FF2028 VA: 0x2FF6028
	private static void ThrowOverflowInt64Exception() { }

	// RVA: 0x2FF6100 Offset: 0x2FF2100 VA: 0x2FF6100
	private static void ThrowOverflowUInt32Exception() { }

	// RVA: 0x2FF6070 Offset: 0x2FF2070 VA: 0x2FF6070
	private static void ThrowOverflowUInt64Exception() { }

	// RVA: 0x2FF6148 Offset: 0x2FF2148 VA: 0x2FF6148
	private static bool IsDigit(char c, int radix, out int result) { }
}

// Assembly: System.dll
// Namespace: System
internal static class UriHelper // TypeDefIndex: 14045
{
	// Fields
	private static readonly char[] HexUpperChars; // 0x0

	// Methods

	// RVA: 0x346515C Offset: 0x346115C VA: 0x346515C
	internal static bool TestForSubPath(char* pMe, ushort meLength, char* pShe, ushort sheLength, bool ignoreCase) { }

	// RVA: 0x3465358 Offset: 0x3461358 VA: 0x3465358
	internal static char[] EscapeString(string input, int start, int end, char[] dest, ref int destPos, bool isUriString, char force1, char force2, char rsvd) { }

	// RVA: 0x346586C Offset: 0x346186C VA: 0x346586C
	private static char[] EnsureDestinationSize(char* pStr, char[] dest, int currentInputPos, short charsToAdd, short minReallocateChars, ref int destPos, int prevInputPos) { }

	// RVA: 0x3465B80 Offset: 0x3461B80 VA: 0x3465B80
	internal static char[] UnescapeString(string input, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x3465C60 Offset: 0x3461C60 VA: 0x3465C60
	internal static char[] UnescapeString(char* pStr, int start, int end, char[] dest, ref int destPosition, char rsvd1, char rsvd2, char rsvd3, UnescapeMode unescapeMode, UriParser syntax, bool isQuery) { }

	// RVA: 0x3464B50 Offset: 0x3460B50 VA: 0x3464B50
	internal static void MatchUTF8Sequence(char* pDest, char[] dest, ref int destOffset, char[] unescapedChars, int charCount, byte[] bytes, int byteCount, bool isQuery, bool iriParsing) { }

	// RVA: 0x346502C Offset: 0x346102C VA: 0x346502C
	internal static void EscapeAsciiChar(char ch, char[] to, ref int pos) { }

	// RVA: 0x3464A08 Offset: 0x3460A08 VA: 0x3464A08
	internal static char EscapedAscii(char digit, char next) { }

	// RVA: 0x3464AC4 Offset: 0x3460AC4 VA: 0x3464AC4
	internal static bool IsNotSafeForUnescape(char ch) { }

	// RVA: 0x3465A78 Offset: 0x3461A78 VA: 0x3465A78
	private static bool IsReservedUnreservedOrHash(char c) { }

	// RVA: 0x3465998 Offset: 0x3461998 VA: 0x3465998
	internal static bool IsUnreserved(char c) { }

	// RVA: 0x3466674 Offset: 0x3462674 VA: 0x3466674
	internal static bool Is3986Unreserved(char c) { }

	// RVA: 0x3466710 Offset: 0x3462710 VA: 0x3466710
	private static void .cctor() { }
}

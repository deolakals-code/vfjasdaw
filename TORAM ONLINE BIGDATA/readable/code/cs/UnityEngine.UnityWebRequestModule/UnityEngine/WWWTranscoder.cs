// Assembly: UnityEngine.UnityWebRequestModule.dll
// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UnityWebRequestWWWModule" })]
internal class WWWTranscoder // TypeDefIndex: 17602
{
	// Fields
	private static byte[] ucHexChars; // 0x0
	private static byte[] lcHexChars; // 0x8
	private static byte urlEscapeChar; // 0x10
	private static byte[] urlSpace; // 0x18
	private static byte[] dataSpace; // 0x20
	private static byte[] urlForbidden; // 0x28
	private static byte qpEscapeChar; // 0x30
	private static byte[] qpSpace; // 0x38
	private static byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0x3826430 Offset: 0x3822430 VA: 0x3826430
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x38264DC Offset: 0x38224DC VA: 0x38264DC
	private static void Byte2Hex(byte b, byte[] hexChars, out byte byte0, out byte byte1) { }

	// RVA: 0x3826130 Offset: 0x3822130 VA: 0x3826130
	public static byte[] DataEncode(byte[] toEncode) { }

	// RVA: 0x382603C Offset: 0x382203C VA: 0x382603C
	public static string QPEncode(string toEncode, Encoding e) { }

	// RVA: 0x3826530 Offset: 0x3822530 VA: 0x3826530
	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase) { }

	// RVA: 0x382690C Offset: 0x382290C VA: 0x382690C
	private static bool ByteArrayContains(byte[] array, byte b) { }

	// RVA: 0x38249D4 Offset: 0x38209D4 VA: 0x38249D4
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x3826C8C Offset: 0x3822C8C VA: 0x3826C8C
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x3826974 Offset: 0x3822974 VA: 0x3826974
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x3825EC8 Offset: 0x3821EC8 VA: 0x3825EC8
	public static bool SevenBitClean(string s, Encoding e) { }

	// RVA: 0x3826D1C Offset: 0x3822D1C VA: 0x3826D1C
	public static bool SevenBitClean(byte* input, int inputLength) { }

	// RVA: 0x3826D78 Offset: 0x3822D78 VA: 0x3826D78
	private static void .cctor() { }
}

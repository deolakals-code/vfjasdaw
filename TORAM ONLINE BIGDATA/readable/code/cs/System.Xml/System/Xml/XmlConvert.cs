// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlConvert // TypeDefIndex: 13445
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0
	internal static char[] crt; // 0x8
	private static readonly int c_EncodedCharLength; // 0x10
	private static Regex c_EncodeCharPattern; // 0x18
	private static Regex c_DecodeCharPattern; // 0x20
	private static string[] s_allDateTimeFormats; // 0x28
	internal static readonly char[] WhitespaceChars; // 0x30

	// Properties
	private static string[] AllDateTimeFormats { get; }

	// Methods

	// RVA: 0x33D6024 Offset: 0x33D2024 VA: 0x33D6024
	public static string EncodeName(string name) { }

	// RVA: 0x33D6A44 Offset: 0x33D2A44 VA: 0x33D6A44
	public static string EncodeLocalName(string name) { }

	// RVA: 0x33D6AA0 Offset: 0x33D2AA0 VA: 0x33D6AA0
	public static string DecodeName(string name) { }

	// RVA: 0x33D6080 Offset: 0x33D2080 VA: 0x33D6080
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0x33D73B4 Offset: 0x33D33B4 VA: 0x33D73B4
	private static int FromHex(char digit) { }

	// RVA: 0x33D73E4 Offset: 0x33D33E4 VA: 0x33D73E4
	internal static byte[] FromBinHexString(string s) { }

	// RVA: 0x33D743C Offset: 0x33D343C VA: 0x33D743C
	internal static byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0x33D74A8 Offset: 0x33D34A8 VA: 0x33D74A8
	internal static string ToBinHexString(byte[] inArray) { }

	// RVA: 0x33D750C Offset: 0x33D350C VA: 0x33D750C
	public static string VerifyName(string name) { }

	// RVA: 0x33D7720 Offset: 0x33D3720 VA: 0x33D7720
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0x33D7874 Offset: 0x33D3874 VA: 0x33D7874
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0x33D7A74 Offset: 0x33D3A74 VA: 0x33D7A74
	public static string VerifyNCName(string name) { }

	// RVA: 0x33D7ACC Offset: 0x33D3ACC VA: 0x33D7ACC
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0x33D7C1C Offset: 0x33D3C1C VA: 0x33D7C1C
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0x33D7CBC Offset: 0x33D3CBC VA: 0x33D7CBC
	public static string VerifyTOKEN(string token) { }

	// RVA: 0x33D7DF0 Offset: 0x33D3DF0 VA: 0x33D7DF0
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0x33D7F24 Offset: 0x33D3F24 VA: 0x33D7F24
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0x33D8058 Offset: 0x33D4058 VA: 0x33D8058
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0x33D8120 Offset: 0x33D4120 VA: 0x33D8120
	public static string ToString(bool value) { }

	// RVA: 0x33D8188 Offset: 0x33D4188 VA: 0x33D8188
	public static string ToString(char value) { }

	// RVA: 0x33D81E8 Offset: 0x33D41E8 VA: 0x33D81E8
	public static string ToString(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x33D8284 Offset: 0x33D4284 VA: 0x33D8284
	public static string ToString(sbyte value) { }

	// RVA: 0x33D82B0 Offset: 0x33D42B0 VA: 0x33D82B0
	public static string ToString(short value) { }

	// RVA: 0x33D82DC Offset: 0x33D42DC VA: 0x33D82DC
	public static string ToString(int value) { }

	// RVA: 0x33D8308 Offset: 0x33D4308 VA: 0x33D8308
	public static string ToString(long value) { }

	// RVA: 0x33D8334 Offset: 0x33D4334 VA: 0x33D8334
	public static string ToString(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x33D8360 Offset: 0x33D4360 VA: 0x33D8360
	public static string ToString(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x33D838C Offset: 0x33D438C VA: 0x33D838C
	public static string ToString(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x33D83B8 Offset: 0x33D43B8 VA: 0x33D83B8
	public static string ToString(ulong value) { }

	// RVA: 0x33D83E4 Offset: 0x33D43E4 VA: 0x33D83E4
	public static string ToString(float value) { }

	// RVA: 0x33D8554 Offset: 0x33D4554 VA: 0x33D8554
	public static string ToString(double value) { }

	// RVA: 0x33D8650 Offset: 0x33D4650 VA: 0x33D8650
	public static string ToString(TimeSpan value) { }

	// RVA: 0x33D86A8 Offset: 0x33D46A8 VA: 0x33D86A8
	public static string ToString(DateTime value, string format) { }

	// RVA: 0x33D874C Offset: 0x33D474C VA: 0x33D874C
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x33D8B24 Offset: 0x33D4B24 VA: 0x33D8B24
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0x33D8BAC Offset: 0x33D4BAC VA: 0x33D8BAC
	public static string ToString(Guid value) { }

	// RVA: 0x33D8BD0 Offset: 0x33D4BD0 VA: 0x33D8BD0
	public static bool ToBoolean(string s) { }

	// RVA: 0x33D8E04 Offset: 0x33D4E04 VA: 0x33D8E04
	internal static Exception TryToBoolean(string s, out bool result) { }

	// RVA: 0x33D9040 Offset: 0x33D5040 VA: 0x33D9040
	public static char ToChar(string s) { }

	// RVA: 0x33D90FC Offset: 0x33D50FC VA: 0x33D90FC
	internal static Exception TryToChar(string s, out char result) { }

	// RVA: 0x33D9288 Offset: 0x33D5288 VA: 0x33D9288
	public static Decimal ToDecimal(string s) { }

	// RVA: 0x33D92F8 Offset: 0x33D52F8 VA: 0x33D92F8
	internal static Exception TryToDecimal(string s, out Decimal result) { }

	// RVA: 0x33D949C Offset: 0x33D549C VA: 0x33D949C
	internal static Decimal ToInteger(string s) { }

	// RVA: 0x33D950C Offset: 0x33D550C VA: 0x33D950C
	internal static Exception TryToInteger(string s, out Decimal result) { }

	[CLSCompliant(False)]
	// RVA: 0x33D96B0 Offset: 0x33D56B0 VA: 0x33D96B0
	public static sbyte ToSByte(string s) { }

	// RVA: 0x33D96D8 Offset: 0x33D56D8 VA: 0x33D96D8
	internal static Exception TryToSByte(string s, out sbyte result) { }

	// RVA: 0x33D9848 Offset: 0x33D5848 VA: 0x33D9848
	public static short ToInt16(string s) { }

	// RVA: 0x33D9870 Offset: 0x33D5870 VA: 0x33D9870
	internal static Exception TryToInt16(string s, out short result) { }

	// RVA: 0x33D99E0 Offset: 0x33D59E0 VA: 0x33D99E0
	public static int ToInt32(string s) { }

	// RVA: 0x33D9A08 Offset: 0x33D5A08 VA: 0x33D9A08
	internal static Exception TryToInt32(string s, out int result) { }

	// RVA: 0x33D9B78 Offset: 0x33D5B78 VA: 0x33D9B78
	public static long ToInt64(string s) { }

	// RVA: 0x33D9BA0 Offset: 0x33D5BA0 VA: 0x33D9BA0
	internal static Exception TryToInt64(string s, out long result) { }

	// RVA: 0x33D9D10 Offset: 0x33D5D10 VA: 0x33D9D10
	public static byte ToByte(string s) { }

	// RVA: 0x33D9D38 Offset: 0x33D5D38 VA: 0x33D9D38
	internal static Exception TryToByte(string s, out byte result) { }

	[CLSCompliant(False)]
	// RVA: 0x33D9EA8 Offset: 0x33D5EA8 VA: 0x33D9EA8
	public static ushort ToUInt16(string s) { }

	// RVA: 0x33D9ED0 Offset: 0x33D5ED0 VA: 0x33D9ED0
	internal static Exception TryToUInt16(string s, out ushort result) { }

	[CLSCompliant(False)]
	// RVA: 0x33DA040 Offset: 0x33D6040 VA: 0x33DA040
	public static uint ToUInt32(string s) { }

	// RVA: 0x33DA068 Offset: 0x33D6068 VA: 0x33DA068
	internal static Exception TryToUInt32(string s, out uint result) { }

	[CLSCompliant(False)]
	// RVA: 0x33DA1D8 Offset: 0x33D61D8 VA: 0x33DA1D8
	public static ulong ToUInt64(string s) { }

	// RVA: 0x33DA200 Offset: 0x33D6200 VA: 0x33DA200
	internal static Exception TryToUInt64(string s, out ulong result) { }

	// RVA: 0x33DA370 Offset: 0x33D6370 VA: 0x33DA370
	public static float ToSingle(string s) { }

	// RVA: 0x33DA488 Offset: 0x33D6488 VA: 0x33DA488
	internal static Exception TryToSingle(string s, out float result) { }

	// RVA: 0x33DA6D8 Offset: 0x33D66D8 VA: 0x33DA6D8
	public static double ToDouble(string s) { }

	// RVA: 0x33DA7F0 Offset: 0x33D67F0 VA: 0x33DA7F0
	internal static Exception TryToDouble(string s, out double result) { }

	// RVA: 0x33DAA40 Offset: 0x33D6A40 VA: 0x33DAA40
	internal static double ToXPathDouble(object o) { }

	// RVA: 0x33DAC94 Offset: 0x33D6C94 VA: 0x33DAC94
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0x33DAE28 Offset: 0x33D6E28 VA: 0x33DAE28
	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	// RVA: 0x33DAED4 Offset: 0x33D6ED4 VA: 0x33DAED4
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0x33DAF6C Offset: 0x33D6F6C VA: 0x33DAF6C
	private static void CreateAllDateTimeFormats() { }

	[Obsolete("Use XmlConvert.ToDateTime() that takes in XmlDateTimeSerializationMode")]
	// RVA: 0x33DB504 Offset: 0x33D7504 VA: 0x33DB504
	public static DateTime ToDateTime(string s) { }

	// RVA: 0x33DB560 Offset: 0x33D7560 VA: 0x33DB560
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0x33DB604 Offset: 0x33D7604 VA: 0x33DB604
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x33DB844 Offset: 0x33D7844 VA: 0x33DB844
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0x33DB90C Offset: 0x33D790C VA: 0x33DB90C
	public static Guid ToGuid(string s) { }

	// RVA: 0x33DB938 Offset: 0x33D7938 VA: 0x33DB938
	internal static Exception TryToGuid(string s, out Guid result) { }

	// RVA: 0x33D897C Offset: 0x33D497C VA: 0x33D897C
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x33D8A50 Offset: 0x33D4A50 VA: 0x33D8A50
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x33DBB30 Offset: 0x33D7B30 VA: 0x33DBB30
	internal static Uri ToUri(string s) { }

	// RVA: 0x33DBCE4 Offset: 0x33D7CE4 VA: 0x33DBCE4
	internal static Exception TryToUri(string s, out Uri result) { }

	// RVA: 0x33DBF18 Offset: 0x33D7F18 VA: 0x33DBF18
	internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0x33D8D98 Offset: 0x33D4D98 VA: 0x33D8D98
	internal static string TrimString(string value) { }

	// RVA: 0x33DBFE4 Offset: 0x33D7FE4 VA: 0x33DBFE4
	internal static string TrimStringStart(string value) { }

	// RVA: 0x33DC050 Offset: 0x33D8050 VA: 0x33DC050
	internal static string TrimStringEnd(string value) { }

	// RVA: 0x33DC0BC Offset: 0x33D80BC VA: 0x33DC0BC
	internal static string[] SplitString(string value) { }

	// RVA: 0x33D84E0 Offset: 0x33D44E0 VA: 0x33D84E0
	internal static bool IsNegativeZero(double value) { }

	// RVA: 0x33DC12C Offset: 0x33D812C VA: 0x33DC12C
	private static long DoubleToInt64Bits(double value) { }

	// RVA: 0x33DC134 Offset: 0x33D8134 VA: 0x33DC134
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0x33DC324 Offset: 0x33D8324 VA: 0x33DC324
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x33DC6CC Offset: 0x33D86CC VA: 0x33DC6CC
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x33DC808 Offset: 0x33D8808 VA: 0x33DC808
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0x33D799C Offset: 0x33D399C VA: 0x33D799C
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x33DC890 Offset: 0x33D8890 VA: 0x33DC890
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

	// RVA: 0x33DC8F8 Offset: 0x33D88F8 VA: 0x33DC8F8
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

	// RVA: 0x33DC3F0 Offset: 0x33D83F0 VA: 0x33DC3F0
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x33DC96C Offset: 0x33D896C VA: 0x33DC96C
	internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

	// RVA: 0x33DC9C4 Offset: 0x33D89C4 VA: 0x33DC9C4
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

	// RVA: 0x33DCA30 Offset: 0x33D8A30 VA: 0x33DCA30
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x33DC580 Offset: 0x33D8580 VA: 0x33DC580
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0x33DCB2C Offset: 0x33D8B2C VA: 0x33DCB2C
	internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

	// RVA: 0x33DCB94 Offset: 0x33D8B94 VA: 0x33DCB94
	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

	// RVA: 0x33D765C Offset: 0x33D365C VA: 0x33D765C
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0x33DCC28 Offset: 0x33D8C28 VA: 0x33DCC28
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0x33DCCDC Offset: 0x33D8CDC VA: 0x33DCCDC
	private static void .cctor() { }
}

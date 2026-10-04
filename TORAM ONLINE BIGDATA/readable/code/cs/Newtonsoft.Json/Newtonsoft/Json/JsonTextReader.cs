// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 15858
{
	// Fields
	private readonly bool _safeAsync; // 0x72
	private readonly TextReader _reader; // 0x78
	[Nullable(2)]
	private char[] _chars; // 0x80
	private int _charsUsed; // 0x88
	private int _charPos; // 0x8C
	private int _lineStartPos; // 0x90
	private int _lineNumber; // 0x94
	private bool _isEndOfFile; // 0x98
	private StringBuffer _stringBuffer; // 0xA0
	private StringReference _stringReference; // 0xB0
	[Nullable(2)]
	private IArrayPool<char> _arrayPool; // 0xC0
	[Nullable(2)]
	[CompilerGenerated]
	private JsonNameTable <PropertyNameTable>k__BackingField; // 0xC8

	// Properties
	[Nullable(2)]
	public JsonNameTable PropertyNameTable { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x3075148 Offset: 0x3071148 VA: 0x3075148
	public void .ctor(TextReader reader) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3075260 Offset: 0x3071260 VA: 0x3075260
	public JsonNameTable get_PropertyNameTable() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x3075268 Offset: 0x3071268 VA: 0x3075268
	public void set_PropertyNameTable(JsonNameTable value) { }

	// RVA: 0x3075270 Offset: 0x3071270 VA: 0x3075270
	private void EnsureBufferNotEmpty() { }

	// RVA: 0x30752D0 Offset: 0x30712D0 VA: 0x30752D0
	private void SetNewLine(bool hasNextChar) { }

	// RVA: 0x3075330 Offset: 0x3071330 VA: 0x3075330
	private void OnNewLine(int pos) { }

	// RVA: 0x3075340 Offset: 0x3071340 VA: 0x3075340
	private void ParseString(char quote, ReadType readType) { }

	// RVA: 0x30758A8 Offset: 0x30718A8 VA: 0x30758A8
	private void ParseReadString(char quote, ReadType readType) { }

	// RVA: 0x3075BE4 Offset: 0x3071BE4 VA: 0x3075BE4
	private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0x3075388 Offset: 0x3071388 VA: 0x3075388
	private void ShiftBufferIfNeeded() { }

	// RVA: 0x3075BF8 Offset: 0x3071BF8 VA: 0x3075BF8
	private int ReadData(bool append) { }

	// RVA: 0x3075C94 Offset: 0x3071C94 VA: 0x3075C94
	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	// RVA: 0x3075C04 Offset: 0x3071C04 VA: 0x3075C04
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0x3075E50 Offset: 0x3071E50 VA: 0x3075E50
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0x3075E70 Offset: 0x3071E70 VA: 0x3075E70
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0x3075EE0 Offset: 0x3071EE0 VA: 0x3075EE0 Slot: 10
	public override bool Read() { }

	// RVA: 0x3076D70 Offset: 0x3072D70 VA: 0x3076D70 Slot: 11
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0x30771D8 Offset: 0x30731D8 VA: 0x30771D8 Slot: 17
	public override Nullable<DateTime> ReadAsDateTime() { }

	[NullableContext(2)]
	// RVA: 0x3077728 Offset: 0x3073728 VA: 0x3077728 Slot: 12
	public override string ReadAsString() { }

	[NullableContext(2)]
	// RVA: 0x307778C Offset: 0x307378C VA: 0x307778C Slot: 13
	public override byte[] ReadAsBytes() { }

	[NullableContext(2)]
	// RVA: 0x3077268 Offset: 0x3073268 VA: 0x3077268
	private object ReadStringValue(ReadType readType) { }

	[NullableContext(2)]
	// RVA: 0x3078018 Offset: 0x3074018 VA: 0x3078018
	private object FinishReadQuotedStringValue(ReadType readType) { }

	// RVA: 0x3077D80 Offset: 0x3073D80 VA: 0x3077D80
	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	// RVA: 0x30784E4 Offset: 0x30744E4 VA: 0x30784E4 Slot: 15
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x3077D14 Offset: 0x3073D14 VA: 0x3077D14
	private void ProcessValueComma() { }

	[NullableContext(2)]
	// RVA: 0x3076E00 Offset: 0x3072E00 VA: 0x3076E00
	private object ReadNumberValue(ReadType readType) { }

	[NullableContext(2)]
	// RVA: 0x3078A24 Offset: 0x3074A24 VA: 0x3078A24
	private object FinishReadQuotedNumber(ReadType readType) { }

	// RVA: 0x3078BAC Offset: 0x3074BAC VA: 0x3078BAC Slot: 18
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x3078C78 Offset: 0x3074C78 VA: 0x3078C78 Slot: 16
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x3078D44 Offset: 0x3074D44 VA: 0x3078D44 Slot: 14
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x3077C44 Offset: 0x3073C44 VA: 0x3077C44
	private void HandleNull() { }

	// RVA: 0x3077EB4 Offset: 0x3073EB4 VA: 0x3077EB4
	private void ReadFinished() { }

	// RVA: 0x3077BF4 Offset: 0x3073BF4 VA: 0x3077BF4
	private bool ReadNullChar() { }

	// RVA: 0x3076118 Offset: 0x3072118 VA: 0x3076118
	private void EnsureBuffer() { }

	// RVA: 0x307543C Offset: 0x307143C VA: 0x307543C
	private void ReadStringIntoBuffer(char quote) { }

	// RVA: 0x3078F34 Offset: 0x3074F34 VA: 0x3078F34
	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	// RVA: 0x3078EE4 Offset: 0x3074EE4 VA: 0x3078EE4
	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0x3078FD8 Offset: 0x3074FD8 VA: 0x3078FD8
	private char ConvertUnicode(bool enoughChars) { }

	// RVA: 0x3078EA4 Offset: 0x3074EA4 VA: 0x3078EA4
	private char ParseUnicode() { }

	// RVA: 0x307912C Offset: 0x307512C VA: 0x307912C
	private void ReadNumberIntoBuffer() { }

	// RVA: 0x30791B0 Offset: 0x30751B0 VA: 0x30791B0
	private bool ReadNumberCharIntoBuffer(char currentChar, int charPos) { }

	// RVA: 0x307932C Offset: 0x307532C VA: 0x307932C
	private void ClearRecentString() { }

	// RVA: 0x3076728 Offset: 0x3072728 VA: 0x3076728
	private bool ParsePostValue(bool ignoreComments) { }

	// RVA: 0x3076598 Offset: 0x3072598 VA: 0x3076598
	private bool ParseObject() { }

	// RVA: 0x3079338 Offset: 0x3075338 VA: 0x3079338
	private bool ParseProperty() { }

	// RVA: 0x307955C Offset: 0x307555C VA: 0x307955C
	private bool ValidIdentifierChar(char value) { }

	// RVA: 0x30795D8 Offset: 0x30755D8 VA: 0x30795D8
	private void ParseUnquotedProperty() { }

	// RVA: 0x30796D8 Offset: 0x30756D8 VA: 0x30796D8
	private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition) { }

	// RVA: 0x3076178 Offset: 0x3072178 VA: 0x3076178
	private bool ParseValue() { }

	// RVA: 0x3077E98 Offset: 0x3073E98 VA: 0x3077E98
	private void ProcessLineFeed() { }

	// RVA: 0x3077E50 Offset: 0x3073E50 VA: 0x3077E50
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0x30769D0 Offset: 0x30729D0 VA: 0x30769D0
	private void EatWhitespace() { }

	// RVA: 0x30799E4 Offset: 0x30759E4 VA: 0x30799E4
	private void ParseConstructor() { }

	// RVA: 0x30782E0 Offset: 0x30742E0 VA: 0x30782E0
	private void ParseNumber(ReadType readType) { }

	// RVA: 0x3079DBC Offset: 0x3075DBC VA: 0x3079DBC
	private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition) { }

	// RVA: 0x307AD94 Offset: 0x3076D94 VA: 0x307AD94
	private JsonReaderException ThrowReaderError(string message, Exception ex) { }

	// RVA: 0x307ADD0 Offset: 0x3076DD0 VA: 0x307ADD0
	private static object BigIntegerParse(string number, CultureInfo culture) { }

	// RVA: 0x3076AE4 Offset: 0x3072AE4 VA: 0x3076AE4
	private void ParseComment(bool setToken) { }

	// RVA: 0x307AE58 Offset: 0x3076E58 VA: 0x307AE58
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0x307AEC4 Offset: 0x3076EC4 VA: 0x307AEC4
	private bool MatchValue(string value) { }

	// RVA: 0x307AF20 Offset: 0x3076F20 VA: 0x307AF20
	private bool MatchValue(bool enoughChars, string value) { }

	// RVA: 0x3078348 Offset: 0x3074348 VA: 0x3078348
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0x307B000 Offset: 0x3077000 VA: 0x307B000
	private bool IsSeparator(char c) { }

	// RVA: 0x3079834 Offset: 0x3075834 VA: 0x3079834
	private void ParseTrue() { }

	// RVA: 0x3078DF8 Offset: 0x3074DF8 VA: 0x3078DF8
	private void ParseNull() { }

	// RVA: 0x3079D10 Offset: 0x3075D10 VA: 0x3079D10
	private void ParseUndefined() { }

	// RVA: 0x307990C Offset: 0x307590C VA: 0x307990C
	private void ParseFalse() { }

	// RVA: 0x3078264 Offset: 0x3074264 VA: 0x3078264
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0x307B158 Offset: 0x3077158 VA: 0x307B158
	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	// RVA: 0x30783EC Offset: 0x30743EC VA: 0x30783EC
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0x307B2AC Offset: 0x30772AC VA: 0x307B2AC
	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	// RVA: 0x3078468 Offset: 0x3074468 VA: 0x3078468
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0x307B400 Offset: 0x3077400 VA: 0x307B400
	private object ParseNumberNaN(ReadType readType, bool matched) { }

	// RVA: 0x307B554 Offset: 0x3077554 VA: 0x307B554 Slot: 20
	public override void Close() { }

	// RVA: 0x307B5D4 Offset: 0x30775D4 VA: 0x307B5D4 Slot: 21
	public bool HasLineInfo() { }

	// RVA: 0x307B5DC Offset: 0x30775DC VA: 0x307B5DC Slot: 22
	public int get_LineNumber() { }

	// RVA: 0x307B624 Offset: 0x3077624 VA: 0x307B624 Slot: 23
	public int get_LinePosition() { }
}

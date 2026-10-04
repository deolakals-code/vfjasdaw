// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
public class JsonTextWriter : JsonWriter // TypeDefIndex: 15860
{
	// Fields
	private readonly bool _safeAsync; // 0x60
	private readonly TextWriter _writer; // 0x68
	[Nullable(2)]
	private Base64Encoder _base64Encoder; // 0x70
	private char _indentChar; // 0x78
	private int _indentation; // 0x7C
	private char _quoteChar; // 0x80
	private bool _quoteName; // 0x82
	[Nullable(2)]
	private bool[] _charEscapeFlags; // 0x88
	[Nullable(2)]
	private char[] _writeBuffer; // 0x90
	[Nullable(2)]
	private IArrayPool<char> _arrayPool; // 0x98
	[Nullable(2)]
	private char[] _indentChars; // 0xA0

	// Properties
	private Base64Encoder Base64Encoder { get; }
	public char QuoteChar { get; }

	// Methods

	// RVA: 0x307B630 Offset: 0x3077630 VA: 0x307B630
	private Base64Encoder get_Base64Encoder() { }

	// RVA: 0x307B6B4 Offset: 0x30776B4 VA: 0x307B6B4
	public char get_QuoteChar() { }

	// RVA: 0x307B6BC Offset: 0x30776BC VA: 0x307B6BC
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0x307B8D0 Offset: 0x30778D0 VA: 0x307B8D0 Slot: 6
	public override void Close() { }

	// RVA: 0x307B904 Offset: 0x3077904 VA: 0x307B904
	private void CloseBufferAndWriter() { }

	// RVA: 0x307B968 Offset: 0x3077968 VA: 0x307B968 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0x307B9E0 Offset: 0x30779E0 VA: 0x307B9E0 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0x307BA18 Offset: 0x3077A18 VA: 0x307BA18 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x307BAC0 Offset: 0x3077AC0 VA: 0x307BAC0 Slot: 17
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0x307BBB4 Offset: 0x3077BB4 VA: 0x307BBB4 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0x307BCEC Offset: 0x3077CEC VA: 0x307BCEC Slot: 14
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x307BDBC Offset: 0x3077DBC VA: 0x307BDBC Slot: 5
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0x307B85C Offset: 0x307785C VA: 0x307B85C
	private void UpdateCharEscapeFlags() { }

	// RVA: 0x307BDC0 Offset: 0x3077DC0 VA: 0x307BDC0 Slot: 18
	protected override void WriteIndent() { }

	// RVA: 0x307BF34 Offset: 0x3077F34 VA: 0x307BF34
	private int SetIndentChars() { }

	// RVA: 0x307C028 Offset: 0x3078028 VA: 0x307C028 Slot: 19
	protected override void WriteValueDelimiter() { }

	// RVA: 0x307C050 Offset: 0x3078050 VA: 0x307C050 Slot: 20
	protected override void WriteIndentSpace() { }

	// RVA: 0x307C078 Offset: 0x3078078 VA: 0x307C078
	private void WriteValueInternal(string value, JsonToken token) { }

	[NullableContext(2)]
	// RVA: 0x307C09C Offset: 0x307809C VA: 0x307C09C Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0x307C304 Offset: 0x3078304 VA: 0x307C304 Slot: 21
	public override void WriteNull() { }

	// RVA: 0x307C398 Offset: 0x3078398 VA: 0x307C398 Slot: 22
	public override void WriteUndefined() { }

	[NullableContext(2)]
	// RVA: 0x307C42C Offset: 0x307842C VA: 0x307C42C Slot: 23
	public override void WriteRaw(string json) { }

	[NullableContext(2)]
	// RVA: 0x307C454 Offset: 0x3078454 VA: 0x307C454 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0x307BC30 Offset: 0x3077C30 VA: 0x307BC30
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0x307C554 Offset: 0x3078554 VA: 0x307C554 Slot: 26
	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x307C5E4 Offset: 0x30785E4 VA: 0x307C5E4 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0x307C674 Offset: 0x3078674 VA: 0x307C674 Slot: 28
	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x307C6B8 Offset: 0x30786B8 VA: 0x307C6B8 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0x307C770 Offset: 0x3078770 VA: 0x307C770 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0x307C828 Offset: 0x3078828 VA: 0x307C828 Slot: 47
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0x307C928 Offset: 0x3078928 VA: 0x307C928 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0x307C9E0 Offset: 0x30789E0 VA: 0x307C9E0 Slot: 48
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0x307CAEC Offset: 0x3078AEC VA: 0x307CAEC Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0x307CB88 Offset: 0x3078B88 VA: 0x307CB88 Slot: 33
	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x307CBCC Offset: 0x3078BCC VA: 0x307CBCC Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0x307CC10 Offset: 0x3078C10 VA: 0x307CC10 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0x307CCAC Offset: 0x3078CAC VA: 0x307CCAC Slot: 36
	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x307CCF0 Offset: 0x3078CF0 VA: 0x307CCF0 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0x307CD34 Offset: 0x3078D34 VA: 0x307CD34 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0x307CDE0 Offset: 0x3078DE0 VA: 0x307CDE0 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0x307CF70 Offset: 0x3078F70 VA: 0x307CF70
	private int WriteValueToBuffer(DateTime value) { }

	[NullableContext(2)]
	// RVA: 0x307D088 Offset: 0x3079088 VA: 0x307D088 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0x307D150 Offset: 0x3079150 VA: 0x307D150 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x307D2B8 Offset: 0x30792B8 VA: 0x307D2B8
	private int WriteValueToBuffer(DateTimeOffset value) { }

	// RVA: 0x307D418 Offset: 0x3079418 VA: 0x307D418 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0x307D524 Offset: 0x3079524 VA: 0x307D524 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	[NullableContext(2)]
	// RVA: 0x307D648 Offset: 0x3079648 VA: 0x307D648 Slot: 61
	public override void WriteValue(Uri value) { }

	[NullableContext(2)]
	// RVA: 0x307D718 Offset: 0x3079718 VA: 0x307D718 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0x307C508 Offset: 0x3078508 VA: 0x307C508
	private void EnsureWriteBuffer() { }

	// RVA: 0x307C628 Offset: 0x3078628 VA: 0x307C628
	private void WriteIntegerValue(long value) { }

	// RVA: 0x307C700 Offset: 0x3078700 VA: 0x307C700
	private void WriteIntegerValue(ulong value, bool negative) { }

	// RVA: 0x307D7D8 Offset: 0x30797D8 VA: 0x307D7D8
	private int WriteNumberToBuffer(ulong value, bool negative) { }

	// RVA: 0x307C598 Offset: 0x3078598 VA: 0x307C598
	private void WriteIntegerValue(int value) { }

	// RVA: 0x307D94C Offset: 0x307994C VA: 0x307D94C
	private void WriteIntegerValue(uint value, bool negative) { }

	// RVA: 0x307D8A4 Offset: 0x30798A4 VA: 0x307D8A4
	private int WriteNumberToBuffer(uint value, bool negative) { }
}

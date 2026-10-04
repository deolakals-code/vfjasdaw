// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 16032
{
	// Fields
	private readonly JsonReader _innerReader; // 0x78
	private readonly JsonTextWriter _textWriter; // 0x80
	private readonly StringWriter _sw; // 0x88

	// Properties
	public override int Depth { get; }
	public override string Path { get; }
	public override JsonToken TokenType { get; }
	[Nullable(2)]
	public override object Value { get; }
	[Nullable(2)]
	public override Type ValueType { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x30BF8A0 Offset: 0x30BB8A0 VA: 0x30BF8A0
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0x30BFA0C Offset: 0x30BBA0C VA: 0x30BFA0C
	public string GetDeserializedJsonMessage() { }

	// RVA: 0x30BFA2C Offset: 0x30BBA2C VA: 0x30BFA2C Slot: 10
	public override bool Read() { }

	// RVA: 0x30BFAA4 Offset: 0x30BBAA4 VA: 0x30BFAA4 Slot: 11
	public override Nullable<int> ReadAsInt32() { }

	[NullableContext(2)]
	// RVA: 0x30BFAE4 Offset: 0x30BBAE4 VA: 0x30BFAE4 Slot: 12
	public override string ReadAsString() { }

	[NullableContext(2)]
	// RVA: 0x30BFB24 Offset: 0x30BBB24 VA: 0x30BFB24 Slot: 13
	public override byte[] ReadAsBytes() { }

	// RVA: 0x30BFB68 Offset: 0x30BBB68 VA: 0x30BFB68 Slot: 16
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x30BFBE4 Offset: 0x30BBBE4 VA: 0x30BFBE4 Slot: 14
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x30BFC30 Offset: 0x30BBC30 VA: 0x30BFC30 Slot: 15
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x30BFC74 Offset: 0x30BBC74 VA: 0x30BFC74 Slot: 17
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x30BFCC0 Offset: 0x30BBCC0 VA: 0x30BFCC0 Slot: 18
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x30BFA6C Offset: 0x30BBA6C VA: 0x30BFA6C
	public void WriteCurrentToken() { }

	// RVA: 0x30BFD1C Offset: 0x30BBD1C VA: 0x30BFD1C Slot: 8
	public override int get_Depth() { }

	// RVA: 0x30BFD3C Offset: 0x30BBD3C VA: 0x30BFD3C Slot: 9
	public override string get_Path() { }

	// RVA: 0x30BFD5C Offset: 0x30BBD5C VA: 0x30BFD5C Slot: 5
	public override JsonToken get_TokenType() { }

	[NullableContext(2)]
	// RVA: 0x30BFD7C Offset: 0x30BBD7C VA: 0x30BFD7C Slot: 6
	public override object get_Value() { }

	[NullableContext(2)]
	// RVA: 0x30BFD9C Offset: 0x30BBD9C VA: 0x30BFD9C Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x30BFDBC Offset: 0x30BBDBC VA: 0x30BFDBC Slot: 20
	public override void Close() { }

	// RVA: 0x30BFDE0 Offset: 0x30BBDE0 VA: 0x30BFDE0 Slot: 21
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x30BFE94 Offset: 0x30BBE94 VA: 0x30BFE94 Slot: 22
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x30BFF4C Offset: 0x30BBF4C VA: 0x30BFF4C Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }
}

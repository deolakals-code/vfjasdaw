// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 16033
{
	// Fields
	private readonly JsonWriter _innerWriter; // 0x60
	private readonly JsonTextWriter _textWriter; // 0x68
	private readonly StringWriter _sw; // 0x70

	// Methods

	// RVA: 0x30C0004 Offset: 0x30BC004 VA: 0x30C0004
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0x30C020C Offset: 0x30BC20C VA: 0x30C020C
	public string GetSerializedJsonMessage() { }

	// RVA: 0x30C022C Offset: 0x30BC22C VA: 0x30C022C Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0x30C0298 Offset: 0x30BC298 VA: 0x30C0298 Slot: 55
	public override void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0x30C03B4 Offset: 0x30BC3B4 VA: 0x30C03B4 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0x30C0418 Offset: 0x30BC418 VA: 0x30C0418 Slot: 49
	public override void WriteValue(Nullable<bool> value) { }

	// RVA: 0x30C04CC Offset: 0x30BC4CC VA: 0x30C04CC Slot: 36
	public override void WriteValue(byte value) { }

	// RVA: 0x30C052C Offset: 0x30BC52C VA: 0x30C052C Slot: 53
	public override void WriteValue(Nullable<byte> value) { }

	// RVA: 0x30C05DC Offset: 0x30BC5DC VA: 0x30C05DC Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0x30C063C Offset: 0x30BC63C VA: 0x30C063C Slot: 52
	public override void WriteValue(Nullable<char> value) { }

	[NullableContext(2)]
	// RVA: 0x30C06EC Offset: 0x30BC6EC VA: 0x30C06EC Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0x30C0760 Offset: 0x30BC760 VA: 0x30C0760 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0x30C07C0 Offset: 0x30BC7C0 VA: 0x30C07C0 Slot: 56
	public override void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0x30C0880 Offset: 0x30BC880 VA: 0x30C0880 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x30C08EC Offset: 0x30BC8EC VA: 0x30C08EC Slot: 57
	public override void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0x30C09E0 Offset: 0x30BC9E0 VA: 0x30C09E0 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0x30C0A40 Offset: 0x30BCA40 VA: 0x30C0A40 Slot: 48
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0x30C0B04 Offset: 0x30BCB04 VA: 0x30C0B04 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0x30C0B50 Offset: 0x30BCB50 VA: 0x30C0B50 Slot: 21
	public override void WriteNull() { }

	// RVA: 0x30C0B9C Offset: 0x30BCB9C VA: 0x30C0B9C Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0x30C0BFC Offset: 0x30BCBFC VA: 0x30C0BFC Slot: 47
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0x30C0CAC Offset: 0x30BCCAC VA: 0x30C0CAC Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0x30C0D18 Offset: 0x30BCD18 VA: 0x30C0D18 Slot: 58
	public override void WriteValue(Nullable<Guid> value) { }

	// RVA: 0x30C0E10 Offset: 0x30BCE10 VA: 0x30C0E10 Slot: 26
	public override void WriteValue(int value) { }

	// RVA: 0x30C0E70 Offset: 0x30BCE70 VA: 0x30C0E70 Slot: 43
	public override void WriteValue(Nullable<int> value) { }

	// RVA: 0x30C0F1C Offset: 0x30BCF1C VA: 0x30C0F1C Slot: 28
	public override void WriteValue(long value) { }

	// RVA: 0x30C0F7C Offset: 0x30BCF7C VA: 0x30C0F7C Slot: 45
	public override void WriteValue(Nullable<long> value) { }

	[NullableContext(2)]
	// RVA: 0x30C103C Offset: 0x30BD03C VA: 0x30C103C Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0x30C1108 Offset: 0x30BD108 VA: 0x30C1108 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0x30C1168 Offset: 0x30BD168 VA: 0x30C1168 Slot: 54
	public override void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0x30C1218 Offset: 0x30BD218 VA: 0x30C1218 Slot: 33
	public override void WriteValue(short value) { }

	// RVA: 0x30C1278 Offset: 0x30BD278 VA: 0x30C1278 Slot: 50
	public override void WriteValue(Nullable<short> value) { }

	[NullableContext(2)]
	// RVA: 0x30C1328 Offset: 0x30BD328 VA: 0x30C1328 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0x30C1388 Offset: 0x30BD388 VA: 0x30C1388 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x30C13E8 Offset: 0x30BD3E8 VA: 0x30C13E8 Slot: 59
	public override void WriteValue(Nullable<TimeSpan> value) { }

	// RVA: 0x30C14A8 Offset: 0x30BD4A8 VA: 0x30C14A8 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0x30C1508 Offset: 0x30BD508 VA: 0x30C1508 Slot: 44
	public override void WriteValue(Nullable<uint> value) { }

	// RVA: 0x30C15B4 Offset: 0x30BD5B4 VA: 0x30C15B4 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0x30C1614 Offset: 0x30BD614 VA: 0x30C1614 Slot: 46
	public override void WriteValue(Nullable<ulong> value) { }

	[NullableContext(2)]
	// RVA: 0x30C16D4 Offset: 0x30BD6D4 VA: 0x30C16D4 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0x30C1798 Offset: 0x30BD798 VA: 0x30C1798 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0x30C17F8 Offset: 0x30BD7F8 VA: 0x30C17F8 Slot: 51
	public override void WriteValue(Nullable<ushort> value) { }

	[NullableContext(2)]
	// RVA: 0x30C18A8 Offset: 0x30BD8A8 VA: 0x30C18A8 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0x30C1908 Offset: 0x30BD908 VA: 0x30C1908 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0x30C194C Offset: 0x30BD94C VA: 0x30C194C Slot: 10
	public override void WriteEndArray() { }

	// RVA: 0x30C1990 Offset: 0x30BD990 VA: 0x30C1990 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x30C19E8 Offset: 0x30BD9E8 VA: 0x30C19E8 Slot: 12
	public override void WriteEndConstructor() { }

	// RVA: 0x30C1A2C Offset: 0x30BDA2C VA: 0x30C1A2C Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0x30C1A8C Offset: 0x30BDA8C VA: 0x30C1A8C Slot: 14
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x30C1AF8 Offset: 0x30BDAF8 VA: 0x30C1AF8 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0x30C1B3C Offset: 0x30BDB3C VA: 0x30C1B3C Slot: 8
	public override void WriteEndObject() { }

	[NullableContext(2)]
	// RVA: 0x30C1B80 Offset: 0x30BDB80 VA: 0x30C1B80 Slot: 24
	public override void WriteRawValue(string json) { }

	[NullableContext(2)]
	// RVA: 0x30C1BE0 Offset: 0x30BDBE0 VA: 0x30C1BE0 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0x30C1C40 Offset: 0x30BDC40 VA: 0x30C1C40 Slot: 6
	public override void Close() { }
}

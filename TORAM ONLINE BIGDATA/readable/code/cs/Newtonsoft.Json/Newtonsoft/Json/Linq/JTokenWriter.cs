// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Linq
[Nullable(0)]
[NullableContext(2)]
public class JTokenWriter : JsonWriter // TypeDefIndex: 16056
{
	// Fields
	private JContainer _token; // 0x60
	private JContainer _parent; // 0x68
	private JValue _value; // 0x70
	private JToken _current; // 0x78

	// Properties
	public JToken Token { get; }

	// Methods

	// RVA: 0x30D29A4 Offset: 0x30CE9A4 VA: 0x30D29A4
	public JToken get_Token() { }

	// RVA: 0x30D29C0 Offset: 0x30CE9C0 VA: 0x30D29C0
	public void .ctor() { }

	// RVA: 0x30D2A18 Offset: 0x30CEA18 VA: 0x30D2A18 Slot: 6
	public override void Close() { }

	// RVA: 0x30D2A20 Offset: 0x30CEA20 VA: 0x30D2A20 Slot: 7
	public override void WriteStartObject() { }

	[NullableContext(1)]
	// RVA: 0x30D2A84 Offset: 0x30CEA84 VA: 0x30D2A84
	private void AddParent(JContainer container) { }

	// RVA: 0x30D2AE4 Offset: 0x30CEAE4 VA: 0x30D2AE4
	private void RemoveParent() { }

	// RVA: 0x30D2B54 Offset: 0x30CEB54 VA: 0x30D2B54 Slot: 9
	public override void WriteStartArray() { }

	[NullableContext(1)]
	// RVA: 0x30D2BB8 Offset: 0x30CEBB8 VA: 0x30D2BB8 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x30D2C30 Offset: 0x30CEC30 VA: 0x30D2C30 Slot: 17
	protected override void WriteEnd(JsonToken token) { }

	[NullableContext(1)]
	// RVA: 0x30D2C34 Offset: 0x30CEC34 VA: 0x30D2C34 Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0x30D2CF4 Offset: 0x30CECF4 VA: 0x30D2CF4
	private void AddRawValue(object value, JTokenType type, JsonToken token) { }

	// RVA: 0x30D2D64 Offset: 0x30CED64 VA: 0x30D2D64
	internal void AddJValue(JValue value, JsonToken token) { }

	// RVA: 0x30D2E24 Offset: 0x30CEE24 VA: 0x30D2E24 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0x30D2EB4 Offset: 0x30CEEB4 VA: 0x30D2EB4 Slot: 21
	public override void WriteNull() { }

	// RVA: 0x30D2ED8 Offset: 0x30CEED8 VA: 0x30D2ED8 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0x30D2EFC Offset: 0x30CEEFC VA: 0x30D2EFC Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0x30D2F78 Offset: 0x30CEF78 VA: 0x30D2F78 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0x30D2FAC Offset: 0x30CEFAC VA: 0x30D2FAC Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0x30D3030 Offset: 0x30CF030 VA: 0x30D3030 Slot: 26
	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x30D30B0 Offset: 0x30CF0B0 VA: 0x30D30B0 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0x30D3130 Offset: 0x30CF130 VA: 0x30D3130 Slot: 28
	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x30D321C Offset: 0x30CF21C VA: 0x30D321C Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0x30D3300 Offset: 0x30CF300 VA: 0x30D3300 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0x30D33E4 Offset: 0x30CF3E4 VA: 0x30D33E4 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0x30D34D0 Offset: 0x30CF4D0 VA: 0x30D34D0 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0x30D35C0 Offset: 0x30CF5C0 VA: 0x30D35C0 Slot: 33
	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x30D3640 Offset: 0x30CF640 VA: 0x30D3640 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0x30D36C0 Offset: 0x30CF6C0 VA: 0x30D36C0 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0x30D37B4 Offset: 0x30CF7B4 VA: 0x30D37B4 Slot: 36
	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x30D3834 Offset: 0x30CF834 VA: 0x30D3834 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0x30D38B4 Offset: 0x30CF8B4 VA: 0x30D38B4 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0x30D39B4 Offset: 0x30CF9B4 VA: 0x30D39B4 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0x30D3AD8 Offset: 0x30CFAD8 VA: 0x30D3AD8 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x30D3BD4 Offset: 0x30CFBD4 VA: 0x30D3BD4 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0x30D3C50 Offset: 0x30CFC50 VA: 0x30D3C50 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x30D3D34 Offset: 0x30CFD34 VA: 0x30D3D34 Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0x30D3E30 Offset: 0x30CFE30 VA: 0x30D3E30 Slot: 61
	public override void WriteValue(Uri value) { }

	[NullableContext(1)]
	// RVA: 0x30D3F2C Offset: 0x30CFF2C VA: 0x30D3F2C Slot: 16
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }
}

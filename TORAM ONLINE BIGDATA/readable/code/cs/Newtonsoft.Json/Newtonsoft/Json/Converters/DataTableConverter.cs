// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class DataTableConverter : JsonConverter // TypeDefIndex: 16064
{
	// Methods

	// RVA: 0x30D8CB0 Offset: 0x30D4CB0 VA: 0x30D8CB0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30D94AC Offset: 0x30D54AC VA: 0x30D94AC Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x30D9798 Offset: 0x30D5798 VA: 0x30D9798
	private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	// RVA: 0x30D9CB8 Offset: 0x30D5CB8 VA: 0x30D9CB8
	private static Type GetColumnDataType(JsonReader reader) { }

	// RVA: 0x30D9E84 Offset: 0x30D5E84 VA: 0x30D9E84 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x30D8924 Offset: 0x30D4924 VA: 0x30D8924
	public void .ctor() { }
}

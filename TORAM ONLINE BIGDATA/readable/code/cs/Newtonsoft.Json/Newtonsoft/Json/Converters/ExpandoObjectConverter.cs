// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class ExpandoObjectConverter : JsonConverter // TypeDefIndex: 16072
{
	// Properties
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x30DC338 Offset: 0x30D8338 VA: 0x30DC338 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30DC33C Offset: 0x30D833C VA: 0x30DC33C Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x30DC340 Offset: 0x30D8340 VA: 0x30DC340
	private object ReadValue(JsonReader reader) { }

	// RVA: 0x30DC658 Offset: 0x30D8658 VA: 0x30DC658
	private object ReadList(JsonReader reader) { }

	// RVA: 0x30DC49C Offset: 0x30D849C VA: 0x30DC49C
	private object ReadObject(JsonReader reader) { }

	// RVA: 0x30DC7E0 Offset: 0x30D87E0 VA: 0x30DC7E0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x30DC868 Offset: 0x30D8868 VA: 0x30DC868 Slot: 8
	public override bool get_CanWrite() { }

	// RVA: 0x30DC870 Offset: 0x30D8870 VA: 0x30DC870
	public void .ctor() { }
}

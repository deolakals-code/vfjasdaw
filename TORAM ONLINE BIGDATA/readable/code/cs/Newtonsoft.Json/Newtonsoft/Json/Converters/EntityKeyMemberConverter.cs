// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class EntityKeyMemberConverter : JsonConverter // TypeDefIndex: 16071
{
	// Fields
	private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";
	private const string KeyPropertyName = "Key";
	private const string TypePropertyName = "Type";
	private const string ValuePropertyName = "Value";
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0x30DBAC8 Offset: 0x30D7AC8 VA: 0x30DBAC8 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30DBF3C Offset: 0x30D7F3C VA: 0x30DBF3C
	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	// RVA: 0x30DC028 Offset: 0x30D8028 VA: 0x30DC028 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x30DBE1C Offset: 0x30D7E1C VA: 0x30DBE1C
	private static void EnsureReflectionObject(Type objectType) { }

	// RVA: 0x30DC2E0 Offset: 0x30D82E0 VA: 0x30DC2E0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x30DC330 Offset: 0x30D8330 VA: 0x30DC330
	public void .ctor() { }
}

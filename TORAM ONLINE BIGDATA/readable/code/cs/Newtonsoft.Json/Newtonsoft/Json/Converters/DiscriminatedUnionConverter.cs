// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class DiscriminatedUnionConverter : JsonConverter // TypeDefIndex: 16070
{
	// Fields
	private const string CasePropertyName = "Case";
	private const string FieldsPropertyName = "Fields";
	private static readonly ThreadSafeStore<Type, DiscriminatedUnionConverter.Union> UnionCache; // 0x0
	private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache; // 0x8

	// Methods

	// RVA: 0x30DA094 Offset: 0x30D6094 VA: 0x30DA094
	private static Type CreateUnionTypeLookup(Type t) { }

	// RVA: 0x30DA2A0 Offset: 0x30D62A0 VA: 0x30DA2A0
	private static DiscriminatedUnionConverter.Union CreateUnion(Type t) { }

	// RVA: 0x30DAB38 Offset: 0x30D6B38 VA: 0x30DAB38 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30DAFC4 Offset: 0x30D6FC4 VA: 0x30DAFC4 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x30DB64C Offset: 0x30D764C VA: 0x30DB64C Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x30DB8E8 Offset: 0x30D78E8 VA: 0x30DB8E8
	public void .ctor() { }

	// RVA: 0x30DB8F0 Offset: 0x30D78F0 VA: 0x30DB8F0
	private static void .cctor() { }
}

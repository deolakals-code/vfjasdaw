// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(new[] { 0, 1, 1 })]
public class JsonPropertyCollection : KeyedCollection<string, JsonProperty> // TypeDefIndex: 16011
{
	// Fields
	private readonly Type _type; // 0x30
	private readonly List<JsonProperty> _list; // 0x38

	// Methods

	// RVA: 0x30A825C Offset: 0x30A425C VA: 0x30A825C
	public void .ctor(Type type) { }

	// RVA: 0x30A9BB8 Offset: 0x30A5BB8 VA: 0x30A9BB8 Slot: 39
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0x30A9BD0 Offset: 0x30A5BD0 VA: 0x30A9BD0
	public void AddProperty(JsonProperty property) { }

	// RVA: 0x30A9E8C Offset: 0x30A5E8C VA: 0x30A9E8C
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0x30A9FB8 Offset: 0x30A5FB8 VA: 0x30A9FB8
	private bool TryGetProperty(string key, out JsonProperty item) { }

	// RVA: 0x30A9ECC Offset: 0x30A5ECC VA: 0x30A9ECC
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }
}

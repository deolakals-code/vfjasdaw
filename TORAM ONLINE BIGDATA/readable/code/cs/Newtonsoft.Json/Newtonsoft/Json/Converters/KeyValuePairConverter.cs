// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class KeyValuePairConverter : JsonConverter // TypeDefIndex: 16075
{
	// Fields
	private const string KeyName = "Key";
	private const string ValueName = "Value";
	private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType; // 0x0

	// Methods

	// RVA: 0x30DD61C Offset: 0x30D961C VA: 0x30DD61C
	private static ReflectionObject InitializeReflectionObject(Type t) { }

	// RVA: 0x30DD898 Offset: 0x30D9898 VA: 0x30DD898 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30DDAEC Offset: 0x30D9AEC VA: 0x30DDAEC Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x30DDFB4 Offset: 0x30D9FB4 VA: 0x30DDFB4 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x30DE0CC Offset: 0x30DA0CC VA: 0x30DE0CC
	public void .ctor() { }

	// RVA: 0x30DE0D4 Offset: 0x30DA0D4 VA: 0x30DE0D4
	private static void .cctor() { }
}

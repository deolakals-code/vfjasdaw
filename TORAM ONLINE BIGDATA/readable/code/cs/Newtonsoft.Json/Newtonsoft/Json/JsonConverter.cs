// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[Nullable(0)]
[NullableContext(1)]
public abstract class JsonConverter // TypeDefIndex: 15839
{
	// Properties
	public virtual bool CanRead { get; }
	public virtual bool CanWrite { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool CanConvert(Type objectType);

	// RVA: 0x306D90C Offset: 0x306990C VA: 0x306D90C Slot: 7
	public virtual bool get_CanRead() { }

	// RVA: 0x306D914 Offset: 0x3069914 VA: 0x306D914 Slot: 8
	public virtual bool get_CanWrite() { }

	// RVA: 0x306D91C Offset: 0x306991C VA: 0x306D91C
	protected void .ctor() { }
}

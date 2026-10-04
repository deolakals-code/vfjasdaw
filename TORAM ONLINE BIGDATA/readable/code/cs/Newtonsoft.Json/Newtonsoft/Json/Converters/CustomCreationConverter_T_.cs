// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public abstract class CustomCreationConverter<T> : JsonConverter // TypeDefIndex: 16062
{
	// Properties
	public override bool CanWrite { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC95C8 Offset: 0x2DC55C8 VA: 0x2DC95C8
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.WriteJson
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9610 Offset: 0x2DC5610 VA: 0x2DC9610
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.ReadJson
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract T Create(Type objectType);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool CanConvert(Type objectType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC97EC Offset: 0x2DC57EC VA: 0x2DC97EC
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.CanConvert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool get_CanWrite() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9878 Offset: 0x2DC5878 VA: 0x2DC9878
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.get_CanWrite
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9880 Offset: 0x2DC5880 VA: 0x2DC9880
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

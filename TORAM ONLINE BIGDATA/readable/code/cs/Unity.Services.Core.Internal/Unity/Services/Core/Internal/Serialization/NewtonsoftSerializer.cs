// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal.Serialization
internal class NewtonsoftSerializer : IJsonSerializer // TypeDefIndex: 17598
{
	// Fields
	private readonly JsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x37B1780 Offset: 0x37AD780 VA: 0x37B1780
	public void .ctor(JsonSerializerSettings settings) { }

	// RVA: 0x37B17C0 Offset: 0x37AD7C0 VA: 0x37B17C0
	internal void .ctor(JsonSerializer serializer) { }

	// RVA: -1 Offset: -1 Slot: 4
	public T DeserializeObject<T>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DCA08 Offset: 0x26D8A08 VA: 0x26DCA08
	|-NewtonsoftSerializer.DeserializeObject<SerializableProjectConfiguration>
	|
	|-RVA: 0x26DCC8C Offset: 0x26D8C8C VA: 0x26DCC8C
	|-NewtonsoftSerializer.DeserializeObject<__Il2CppFullySharedGenericType>
	*/
}

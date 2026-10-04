// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 16005
{
	// Fields
	private readonly JsonSerializerInternalReader _reader; // 0x10
	private readonly JsonISerializableContract _contract; // 0x18
	[Nullable(2)]
	private readonly JsonProperty _member; // 0x20

	// Methods

	// RVA: 0x30A85FC Offset: 0x30A45FC VA: 0x30A85FC
	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: -1 Offset: -1
	private T GetTokenValue<T>(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C654C Offset: 0x26C254C VA: 0x26C654C
	|-JsonFormatterConverter.GetTokenValue<bool>
	|
	|-RVA: 0x26C66F4 Offset: 0x26C26F4 VA: 0x26C66F4
	|-JsonFormatterConverter.GetTokenValue<int>
	|
	|-RVA: 0x26C689C Offset: 0x26C289C VA: 0x26C689C
	|-JsonFormatterConverter.GetTokenValue<long>
	|
	|-RVA: 0x26C6A44 Offset: 0x26C2A44 VA: 0x26C6A44
	|-JsonFormatterConverter.GetTokenValue<object>
	|
	|-RVA: 0x26C6BE8 Offset: 0x26C2BE8 VA: 0x26C6BE8
	|-JsonFormatterConverter.GetTokenValue<float>
	|
	|-RVA: 0x26C6D90 Offset: 0x26C2D90 VA: 0x26C6D90
	|-JsonFormatterConverter.GetTokenValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x30A86C4 Offset: 0x30A46C4 VA: 0x30A86C4 Slot: 4
	public object Convert(object value, Type type) { }

	// RVA: 0x30A8900 Offset: 0x30A4900 VA: 0x30A8900 Slot: 5
	public bool ToBoolean(object value) { }

	// RVA: 0x30A8958 Offset: 0x30A4958 VA: 0x30A8958 Slot: 6
	public int ToInt32(object value) { }

	// RVA: 0x30A89B0 Offset: 0x30A49B0 VA: 0x30A89B0 Slot: 7
	public long ToInt64(object value) { }

	// RVA: 0x30A8A08 Offset: 0x30A4A08 VA: 0x30A8A08 Slot: 8
	public float ToSingle(object value) { }

	// RVA: 0x30A8A60 Offset: 0x30A4A60 VA: 0x30A8A60 Slot: 9
	public string ToString(object value) { }
}

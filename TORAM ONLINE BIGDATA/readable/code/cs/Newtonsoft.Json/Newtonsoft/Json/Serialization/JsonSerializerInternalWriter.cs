// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 16019
{
	// Fields
	[Nullable(2)]
	private Type _rootType; // 0x38
	private int _rootLevel; // 0x40
	private readonly List<object> _serializeStack; // 0x48

	// Methods

	// RVA: 0x30B6AD0 Offset: 0x30B2AD0 VA: 0x30B6AD0
	public void .ctor(JsonSerializer serializer) { }

	[NullableContext(2)]
	// RVA: 0x30B6B5C Offset: 0x30B2B5C VA: 0x30B6B5C
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x30B78F0 Offset: 0x30B38F0 VA: 0x30B78F0
	private JsonSerializerProxy GetInternalSerializer() { }

	[NullableContext(2)]
	// RVA: 0x30B6DFC Offset: 0x30B2DFC VA: 0x30B6DFC
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0x30B7968 Offset: 0x30B3968 VA: 0x30B7968
	private JsonContract GetContract(object value) { }

	// RVA: 0x30B7A2C Offset: 0x30B3A2C VA: 0x30B7A2C
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x30B721C Offset: 0x30B321C VA: 0x30B721C
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x30BAAEC Offset: 0x30B6AEC VA: 0x30BAAEC
	private Nullable<bool> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x30B6E0C Offset: 0x30B2E0C VA: 0x30B6E0C
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x30BABA8 Offset: 0x30B6BA8 VA: 0x30BABA8
	private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property) { }

	[NullableContext(2)]
	// RVA: 0x30BAC80 Offset: 0x30B6C80 VA: 0x30BAC80
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x30B6FA0 Offset: 0x30B2FA0 VA: 0x30B6FA0
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0x30BB1F0 Offset: 0x30B71F0 VA: 0x30BB1F0
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0x30BB3DC Offset: 0x30B73DC VA: 0x30BB3DC
	internal static bool TryConvertToString(object value, Type type, out string s) { }

	// RVA: 0x30B95A8 Offset: 0x30B55A8 VA: 0x30B95A8
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0x30BB4F8 Offset: 0x30B74F8 VA: 0x30BB4F8
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x30BB6FC Offset: 0x30B76FC VA: 0x30BB6FC
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x30B8564 Offset: 0x30B4564 VA: 0x30B8564
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x30BBA40 Offset: 0x30B7A40 VA: 0x30BBA40
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	// RVA: 0x30BB900 Offset: 0x30B7900 VA: 0x30BB900
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x30BC84C Offset: 0x30B884C VA: 0x30BC84C
	private bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property) { }

	// RVA: 0x30BC900 Offset: 0x30B8900 VA: 0x30BC900
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0x30B7DC0 Offset: 0x30B3DC0 VA: 0x30B7DC0
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0x30BAC74 Offset: 0x30B6C74 VA: 0x30BAC74
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0x30BAB9C Offset: 0x30B6B9C VA: 0x30BAB9C
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0x30BCB4C Offset: 0x30B8B4C VA: 0x30BCB4C
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0x30B8040 Offset: 0x30B4040 VA: 0x30B8040
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x30B8CB4 Offset: 0x30B4CB4 VA: 0x30B8CB4
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x30B93A8 Offset: 0x30B53A8 VA: 0x30B93A8
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x30BCE04 Offset: 0x30B8E04 VA: 0x30BCE04
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0x30BCB58 Offset: 0x30B8B58 VA: 0x30BCB58
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x30BA674 Offset: 0x30B6674 VA: 0x30BA674
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x30B9ED8 Offset: 0x30B5ED8 VA: 0x30B9ED8
	private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x30BD170 Offset: 0x30B9170 VA: 0x30BD170
	private bool ShouldWriteDynamicProperty(object memberValue) { }

	[NullableContext(2)]
	// RVA: 0x30B7B94 Offset: 0x30B3B94 VA: 0x30B7B94
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x30B962C Offset: 0x30B562C VA: 0x30B962C
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x30BBE98 Offset: 0x30B7E98 VA: 0x30BBE98
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	// RVA: 0x30B787C Offset: 0x30B387C VA: 0x30B787C
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0x30BC38C Offset: 0x30B838C VA: 0x30BC38C
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0x30BC5EC Offset: 0x30B85EC VA: 0x30BC5EC
	private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }
}

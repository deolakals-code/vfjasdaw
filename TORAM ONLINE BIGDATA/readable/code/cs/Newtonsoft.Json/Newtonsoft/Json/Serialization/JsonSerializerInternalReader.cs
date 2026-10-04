// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(1)]
internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 16018
{
	// Methods

	// RVA: 0x30AA718 Offset: 0x30A6718 VA: 0x30AA718
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x30AA71C Offset: 0x30A671C VA: 0x30AA71C
	public void Populate(JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x30AC5B8 Offset: 0x30A85B8 VA: 0x30AC5B8
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0x30AC644 Offset: 0x30A8644 VA: 0x30AC644
	private JsonContract GetContract(Type type) { }

	[NullableContext(2)]
	// RVA: 0x30AC6F4 Offset: 0x30A86F4 VA: 0x30AC6F4
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0x30AD3B0 Offset: 0x30A93B0 VA: 0x30AD3B0
	private JsonSerializerProxy GetInternalSerializer() { }

	[NullableContext(2)]
	// RVA: 0x30AD428 Offset: 0x30A9428 VA: 0x30AD428
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0x30AD844 Offset: 0x30A9844 VA: 0x30AD844
	private JToken CreateJObject(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x30ACEA4 Offset: 0x30A8EA4 VA: 0x30ACEA4
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[NullableContext(2)]
	// RVA: 0x30AF3E0 Offset: 0x30AB3E0 VA: 0x30AF3E0
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0x30AF514 Offset: 0x30AB514 VA: 0x30AF514
	internal string GetExpectedDescription(JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x30ACA24 Offset: 0x30A8A24 VA: 0x30ACA24
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x30ADCA8 Offset: 0x30A9CA8 VA: 0x30ADCA8
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[NullableContext(2)]
	// RVA: 0x30AF5CC Offset: 0x30AB5CC VA: 0x30AF5CC
	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[NullableContext(2)]
	// RVA: 0x30AFD34 Offset: 0x30ABD34 VA: 0x30AFD34
	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[NullableContext(2)]
	// RVA: 0x30B162C Offset: 0x30AD62C VA: 0x30B162C
	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0x30B1C50 Offset: 0x30ADC50 VA: 0x30B1C50
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x30AE7D8 Offset: 0x30AA7D8 VA: 0x30AE7D8
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	[NullableContext(2)]
	// RVA: 0x30B03F4 Offset: 0x30AC3F4 VA: 0x30B03F4
	private bool HasNoDefinedType(JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x30AEE1C Offset: 0x30AAE1C VA: 0x30AEE1C
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0x30B271C Offset: 0x30AE71C VA: 0x30B271C
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x30B2BEC Offset: 0x30AEBEC VA: 0x30B2BEC
	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue) { }

	// RVA: 0x30B32C0 Offset: 0x30AF2C0 VA: 0x30B32C0
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0x30B32B4 Offset: 0x30AF2B4 VA: 0x30B32B4
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	[NullableContext(2)]
	// RVA: 0x30B31BC Offset: 0x30AF1BC VA: 0x30B31BC
	private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value) { }

	// RVA: 0x30B1DD0 Offset: 0x30ADDD0 VA: 0x30B1DD0
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x30B0714 Offset: 0x30AC714 VA: 0x30B0714
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x30B3684 Offset: 0x30AF684 VA: 0x30B3684
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x30B38B0 Offset: 0x30AF8B0 VA: 0x30B38B0
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x30AB164 Offset: 0x30A7164 VA: 0x30AB164
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x30B2058 Offset: 0x30AE058 VA: 0x30B2058
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x30B3ADC Offset: 0x30AFADC VA: 0x30B3ADC
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0x30AAC3C Offset: 0x30A6C3C VA: 0x30AAC3C
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x30B0F8C Offset: 0x30ACF8C VA: 0x30B0F8C
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0x30A87DC Offset: 0x30A47DC VA: 0x30A87DC
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x30B0940 Offset: 0x30AC940 VA: 0x30B0940
	private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id) { }

	// RVA: 0x30B3C10 Offset: 0x30AFC10 VA: 0x30B3C10
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id) { }

	// RVA: 0x30ACA90 Offset: 0x30A8A90 VA: 0x30ACA90
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0x30B58E0 Offset: 0x30B18E0 VA: 0x30B58E0
	private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0x30B04F0 Offset: 0x30AC4F0 VA: 0x30B04F0
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x30ABB30 Offset: 0x30A7B30 VA: 0x30ABB30
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0x30B6690 Offset: 0x30B2690 VA: 0x30B6690
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0x30ADB8C Offset: 0x30A9B8C VA: 0x30ADB8C
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0x30B651C Offset: 0x30B251C VA: 0x30B651C
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0x30B6460 Offset: 0x30B2460 VA: 0x30B6460
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0x30B5FBC Offset: 0x30B1FBC VA: 0x30B5FBC
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0x30B68F4 Offset: 0x30B28F4 VA: 0x30B68F4
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0x30AD348 Offset: 0x30A9348 VA: 0x30AD348
	private void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }
}

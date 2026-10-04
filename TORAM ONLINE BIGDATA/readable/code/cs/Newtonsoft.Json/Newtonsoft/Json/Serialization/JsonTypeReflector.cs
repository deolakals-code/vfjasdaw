// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal static class JsonTypeReflector // TypeDefIndex: 16024
{
	// Fields
	private static Nullable<bool> _fullyTrusted; // 0x0
	[Nullable(new[] { 1, 1, 1, 2, 1, 1 })]
	private static readonly ThreadSafeStore<Type, Func<object[], object>> CreatorCache; // 0x8
	[Nullable(new[] { 1, 1, 2 })]
	private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; // 0x10
	[Nullable(2)]
	private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18

	// Properties
	public static bool FullyTrusted { get; }
	public static ReflectionDelegateFactory ReflectionDelegateFactory { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T GetCachedAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C76EC Offset: 0x26C36EC VA: 0x26C76EC
	|-JsonTypeReflector.GetCachedAttribute<object>
	*/

	// RVA: 0x30BD7F8 Offset: 0x30B97F8 VA: 0x30BD7F8
	public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter) { }

	// RVA: 0x30BD9F4 Offset: 0x30B99F4 VA: 0x30BD9F4
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0x30BDAC0 Offset: 0x30B9AC0 VA: 0x30BDAC0
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0x30BDD44 Offset: 0x30B9D44 VA: 0x30BDD44
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0x30BDE98 Offset: 0x30B9E98 VA: 0x30BDE98
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0x30BDFB8 Offset: 0x30B9FB8 VA: 0x30BDFB8
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] args) { }

	// RVA: 0x30BE0AC Offset: 0x30BA0AC VA: 0x30BE0AC
	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[] args) { }

	// RVA: 0x30BE1A0 Offset: 0x30BA1A0 VA: 0x30BE1A0
	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	// RVA: 0x30BE26C Offset: 0x30BA26C VA: 0x30BE26C
	private static Func<object[], object> GetCreator(Type type) { }

	// RVA: 0x30BE480 Offset: 0x30BA480 VA: 0x30BE480
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0x30BE500 Offset: 0x30BA500 VA: 0x30BE500
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C754C Offset: 0x26C354C VA: 0x26C754C
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C7184 Offset: 0x26C3184 VA: 0x26C7184
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: 0x30BE748 Offset: 0x30BA748 VA: 0x30BE748
	public static bool IsNonSerializable(object provider) { }

	// RVA: 0x30BDE1C Offset: 0x30B9E1C VA: 0x30BDE1C
	public static bool IsSerializable(object provider) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object provider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C73F8 Offset: 0x26C33F8 VA: 0x26C73F8
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: 0x30BE7C4 Offset: 0x30BA7C4 VA: 0x30BE7C4
	public static bool get_FullyTrusted() { }

	// RVA: 0x30BE3F8 Offset: 0x30BA3F8 VA: 0x30BE3F8
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0x30BE8D0 Offset: 0x30BA8D0 VA: 0x30BE8D0
	private static void .cctor() { }
}

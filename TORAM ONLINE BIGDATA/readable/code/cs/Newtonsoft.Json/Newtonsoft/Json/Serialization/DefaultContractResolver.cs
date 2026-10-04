// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class DefaultContractResolver : IContractResolver // TypeDefIndex: 15981
{
	// Fields
	private static readonly IContractResolver _instance; // 0x0
	private static readonly string[] BlacklistedTypeNames; // 0x8
	private static readonly JsonConverter[] BuiltInConverters; // 0x10
	private readonly DefaultJsonNameTable _nameTable; // 0x10
	private readonly ThreadSafeStore<Type, JsonContract> _contractCache; // 0x18
	[CompilerGenerated]
	private BindingFlags <DefaultMembersSearchFlags>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <SerializeCompilerGeneratedMembers>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IgnoreSerializableInterface>k__BackingField; // 0x25
	[CompilerGenerated]
	private bool <IgnoreSerializableAttribute>k__BackingField; // 0x26
	[CompilerGenerated]
	private bool <IgnoreIsSpecifiedMembers>k__BackingField; // 0x27
	[CompilerGenerated]
	private bool <IgnoreShouldSerializeMembers>k__BackingField; // 0x28
	[CompilerGenerated]
	[Nullable(2)]
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x30

	// Properties
	internal static IContractResolver Instance { get; }
	[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
	public BindingFlags DefaultMembersSearchFlags { get; set; }
	public bool SerializeCompilerGeneratedMembers { get; }
	public bool IgnoreSerializableInterface { get; }
	public bool IgnoreSerializableAttribute { get; set; }
	public bool IgnoreIsSpecifiedMembers { get; }
	public bool IgnoreShouldSerializeMembers { get; }
	[Nullable(2)]
	public NamingStrategy NamingStrategy { get; }

	// Methods

	// RVA: 0x309AB4C Offset: 0x3096B4C VA: 0x309AB4C
	internal static IContractResolver get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x309ABA4 Offset: 0x3096BA4 VA: 0x309ABA4
	public BindingFlags get_DefaultMembersSearchFlags() { }

	[CompilerGenerated]
	// RVA: 0x309ABAC Offset: 0x3096BAC VA: 0x309ABAC
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CompilerGenerated]
	// RVA: 0x309ABB4 Offset: 0x3096BB4 VA: 0x309ABB4
	public bool get_SerializeCompilerGeneratedMembers() { }

	[CompilerGenerated]
	// RVA: 0x309ABBC Offset: 0x3096BBC VA: 0x309ABBC
	public bool get_IgnoreSerializableInterface() { }

	[CompilerGenerated]
	// RVA: 0x309ABC4 Offset: 0x3096BC4 VA: 0x309ABC4
	public bool get_IgnoreSerializableAttribute() { }

	[CompilerGenerated]
	// RVA: 0x309ABCC Offset: 0x3096BCC VA: 0x309ABCC
	public void set_IgnoreSerializableAttribute(bool value) { }

	[CompilerGenerated]
	// RVA: 0x309ABD8 Offset: 0x3096BD8 VA: 0x309ABD8
	public bool get_IgnoreIsSpecifiedMembers() { }

	[CompilerGenerated]
	// RVA: 0x309ABE0 Offset: 0x3096BE0 VA: 0x309ABE0
	public bool get_IgnoreShouldSerializeMembers() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x309ABE8 Offset: 0x3096BE8 VA: 0x309ABE8
	public NamingStrategy get_NamingStrategy() { }

	// RVA: 0x309ABF0 Offset: 0x3096BF0 VA: 0x309ABF0
	public void .ctor() { }

	// RVA: 0x309AD00 Offset: 0x3096D00 VA: 0x309AD00 Slot: 5
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0x309AD80 Offset: 0x3096D80 VA: 0x309AD80
	private static bool FilterMembers(MemberInfo member) { }

	// RVA: 0x309AEC4 Offset: 0x3096EC4 VA: 0x309AEC4 Slot: 6
	protected virtual List<MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0x309BC68 Offset: 0x3097C68 VA: 0x309BC68
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0x309BD70 Offset: 0x3097D70 VA: 0x309BD70 Slot: 7
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0x309D840 Offset: 0x3099840 VA: 0x309D840
	private static void ThrowUnableToSerializeError(object o, StreamingContext context) { }

	// RVA: 0x309CDF0 Offset: 0x3098DF0 VA: 0x309CDF0
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0x309CFBC Offset: 0x3098FBC VA: 0x309CFBC
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0x309C5D0 Offset: 0x30985D0 VA: 0x309C5D0
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0x309CB3C Offset: 0x3098B3C VA: 0x309CB3C
	private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties) { }

	// RVA: 0x309CAF4 Offset: 0x3098AF4 VA: 0x309CAF4
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0x309DB34 Offset: 0x3099B34 VA: 0x309DB34 Slot: 8
	protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0x309DA8C Offset: 0x3099A8C VA: 0x309DA8C
	private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type) { }

	// RVA: 0x309DCB0 Offset: 0x3099CB0 VA: 0x309DCB0 Slot: 9
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0x309E624 Offset: 0x309A624 VA: 0x309E624 Slot: 10
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0x309E67C Offset: 0x309A67C VA: 0x309E67C
	private Func<object> GetDefaultCreator(Type createdType) { }

	// RVA: 0x309C36C Offset: 0x309836C VA: 0x309C36C
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0x309E71C Offset: 0x309A71C VA: 0x309E71C
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0x309E85C Offset: 0x309A85C VA: 0x309E85C
	private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError) { }

	// RVA: 0x309FA28 Offset: 0x309BA28 VA: 0x309FA28
	private static bool IsConcurrentOrObservableCollection(Type t) { }

	// RVA: 0x309F2E8 Offset: 0x309B2E8 VA: 0x309F2E8
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0x309F214 Offset: 0x309B214 VA: 0x309F214
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0x309D8D4 Offset: 0x30998D4 VA: 0x309D8D4
	private List<Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0x309FB70 Offset: 0x309BB70 VA: 0x309FB70 Slot: 11
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0x30A00EC Offset: 0x309C0EC VA: 0x30A00EC Slot: 12
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0x30A0434 Offset: 0x309C434 VA: 0x30A0434 Slot: 13
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0x30A04A8 Offset: 0x309C4A8 VA: 0x30A04A8 Slot: 14
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0x30A051C Offset: 0x309C51C VA: 0x30A051C Slot: 15
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0x30A0764 Offset: 0x309C764 VA: 0x30A0764 Slot: 16
	protected virtual JsonDynamicContract CreateDynamicContract(Type objectType) { }

	// RVA: 0x30A0988 Offset: 0x309C988 VA: 0x30A0988 Slot: 17
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0x30A09FC Offset: 0x309C9FC VA: 0x30A09FC Slot: 18
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0x30A0E00 Offset: 0x309CE00 VA: 0x30A0E00
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0x30A0F78 Offset: 0x309CF78 VA: 0x30A0F78
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0x30A0E60 Offset: 0x309CE60 VA: 0x30A0E60
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0x309F3BC Offset: 0x309B3BC VA: 0x309F3BC
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	// RVA: 0x30A10F0 Offset: 0x309D0F0 VA: 0x30A10F0
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x30A11F0 Offset: 0x309D1F0 VA: 0x30A11F0 Slot: 19
	protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0x30A1610 Offset: 0x309D610 VA: 0x30A1610 Slot: 20
	internal virtual DefaultJsonNameTable GetNameTable() { }

	// RVA: 0x30A1618 Offset: 0x309D618 VA: 0x30A1618 Slot: 21
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0x30A1674 Offset: 0x309D674 VA: 0x30A1674 Slot: 22
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0x309DF60 Offset: 0x3099F60 VA: 0x309DF60
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	// RVA: 0x30A188C Offset: 0x309D88C VA: 0x30A188C
	private Predicate<object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0x30A1AF0 Offset: 0x309DAF0 VA: 0x30A1AF0
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0x30A1E08 Offset: 0x309DE08 VA: 0x30A1E08 Slot: 23
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0x30A1E28 Offset: 0x309DE28 VA: 0x30A1E28 Slot: 24
	protected virtual string ResolveExtensionDataName(string extensionDataName) { }

	// RVA: 0x30A1E44 Offset: 0x309DE44 VA: 0x30A1E44 Slot: 25
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0x30A1E70 Offset: 0x309DE70 VA: 0x30A1E70
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0x30A1E80 Offset: 0x309DE80 VA: 0x30A1E80
	private static void .cctor() { }
}

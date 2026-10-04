// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[Nullable(0)]
[NullableContext(2)]
public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 16008
{
	// Fields
	[CompilerGenerated]
	private MemberSerialization <MemberSerialization>k__BackingField; // 0xBC
	[CompilerGenerated]
	private Nullable<MissingMemberHandling> <MissingMemberHandling>k__BackingField; // 0xC0
	[CompilerGenerated]
	private Nullable<Required> <ItemRequired>k__BackingField; // 0xC8
	[CompilerGenerated]
	private Nullable<NullValueHandling> <ItemNullValueHandling>k__BackingField; // 0xD0
	[Nullable(1)]
	[CompilerGenerated]
	private readonly JsonPropertyCollection <Properties>k__BackingField; // 0xD8
	[CompilerGenerated]
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; // 0xE0
	[CompilerGenerated]
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; // 0xE8
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <ExtensionDataNameResolver>k__BackingField; // 0xF0
	internal bool ExtensionDataIsJToken; // 0xF8
	private Nullable<bool> _hasRequiredOrDefaultValueProperties; // 0xF9
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x100
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x108
	private JsonPropertyCollection _creatorParameters; // 0x110
	private Type _extensionDataValueType; // 0x118

	// Properties
	public MemberSerialization MemberSerialization { get; set; }
	public Nullable<MissingMemberHandling> MissingMemberHandling { get; set; }
	public Nullable<Required> ItemRequired { get; set; }
	public Nullable<NullValueHandling> ItemNullValueHandling { get; set; }
	[Nullable(1)]
	public JsonPropertyCollection Properties { get; }
	[Nullable(1)]
	public JsonPropertyCollection CreatorParameters { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; set; }
	public ExtensionDataSetter ExtensionDataSetter { get; set; }
	public ExtensionDataGetter ExtensionDataGetter { get; set; }
	public Type ExtensionDataValueType { set; }
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> ExtensionDataNameResolver { get; set; }
	internal bool HasRequiredOrDefaultValueProperties { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x30A8B00 Offset: 0x30A4B00 VA: 0x30A8B00
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGenerated]
	// RVA: 0x30A8B08 Offset: 0x30A4B08 VA: 0x30A8B08
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGenerated]
	// RVA: 0x30A8B10 Offset: 0x30A4B10 VA: 0x30A8B10
	public Nullable<MissingMemberHandling> get_MissingMemberHandling() { }

	[CompilerGenerated]
	// RVA: 0x30A8B18 Offset: 0x30A4B18 VA: 0x30A8B18
	public void set_MissingMemberHandling(Nullable<MissingMemberHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x30A8B20 Offset: 0x30A4B20 VA: 0x30A8B20
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGenerated]
	// RVA: 0x30A8B28 Offset: 0x30A4B28 VA: 0x30A8B28
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGenerated]
	// RVA: 0x30A8B30 Offset: 0x30A4B30 VA: 0x30A8B30
	public Nullable<NullValueHandling> get_ItemNullValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x30A8B38 Offset: 0x30A4B38 VA: 0x30A8B38
	public void set_ItemNullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGenerated]
	[NullableContext(1)]
	// RVA: 0x30A8B40 Offset: 0x30A4B40 VA: 0x30A8B40
	public JsonPropertyCollection get_Properties() { }

	[NullableContext(1)]
	// RVA: 0x30A8B48 Offset: 0x30A4B48 VA: 0x30A8B48
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0x30A8BC8 Offset: 0x30A4BC8 VA: 0x30A8BC8
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x30A8BD0 Offset: 0x30A4BD0 VA: 0x30A8BD0
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	// RVA: 0x30A8BE0 Offset: 0x30A4BE0 VA: 0x30A8BE0
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x30A8BE8 Offset: 0x30A4BE8 VA: 0x30A8BE8
	internal void set_ParameterizedCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x30A8BF8 Offset: 0x30A4BF8 VA: 0x30A8BF8
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[CompilerGenerated]
	// RVA: 0x30A8C00 Offset: 0x30A4C00 VA: 0x30A8C00
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[CompilerGenerated]
	// RVA: 0x30A8C08 Offset: 0x30A4C08 VA: 0x30A8C08
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGenerated]
	// RVA: 0x30A8C10 Offset: 0x30A4C10 VA: 0x30A8C10
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0x30A8C18 Offset: 0x30A4C18 VA: 0x30A8C18
	public void set_ExtensionDataValueType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x30A8CF8 Offset: 0x30A4CF8 VA: 0x30A8CF8
	public Func<string, string> get_ExtensionDataNameResolver() { }

	[CompilerGenerated]
	// RVA: 0x30A8D00 Offset: 0x30A4D00 VA: 0x30A8D00
	public void set_ExtensionDataNameResolver(Func<string, string> value) { }

	// RVA: 0x30A8D08 Offset: 0x30A4D08 VA: 0x30A8D08
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	[NullableContext(1)]
	// RVA: 0x30A915C Offset: 0x30A515C VA: 0x30A915C
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x30A91E0 Offset: 0x30A51E0 VA: 0x30A91E0
	internal object GetUninitializedObject() { }
}

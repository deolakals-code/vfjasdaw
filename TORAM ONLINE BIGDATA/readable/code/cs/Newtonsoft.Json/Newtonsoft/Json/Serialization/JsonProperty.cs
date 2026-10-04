// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonProperty // TypeDefIndex: 16010
{
	// Fields
	internal Nullable<Required> _required; // 0x10
	internal bool _hasExplicitDefaultValue; // 0x18
	private object _defaultValue; // 0x20
	private bool _hasGeneratedDefaultValue; // 0x28
	private string _propertyName; // 0x30
	internal bool _skipPropertyNameEscape; // 0x38
	private Type _propertyType; // 0x40
	[CompilerGenerated]
	private JsonContract <PropertyContract>k__BackingField; // 0x48
	[CompilerGenerated]
	private Type <DeclaringType>k__BackingField; // 0x50
	[CompilerGenerated]
	private Nullable<int> <Order>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <UnderlyingName>k__BackingField; // 0x60
	[CompilerGenerated]
	private IValueProvider <ValueProvider>k__BackingField; // 0x68
	[CompilerGenerated]
	private IAttributeProvider <AttributeProvider>k__BackingField; // 0x70
	[CompilerGenerated]
	private JsonConverter <Converter>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <Ignored>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <Readable>k__BackingField; // 0x81
	[CompilerGenerated]
	private bool <Writable>k__BackingField; // 0x82
	[CompilerGenerated]
	private bool <HasMemberAttribute>k__BackingField; // 0x83
	[CompilerGenerated]
	private Nullable<bool> <IsReference>k__BackingField; // 0x84
	[CompilerGenerated]
	private Nullable<NullValueHandling> <NullValueHandling>k__BackingField; // 0x88
	[CompilerGenerated]
	private Nullable<DefaultValueHandling> <DefaultValueHandling>k__BackingField; // 0x90
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField; // 0x98
	[CompilerGenerated]
	private Nullable<ObjectCreationHandling> <ObjectCreationHandling>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <TypeNameHandling>k__BackingField; // 0xA8
	[CompilerGenerated]
	[Nullable(new[] { 2, 1 })]
	private Predicate<object> <ShouldSerialize>k__BackingField; // 0xB0
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Predicate<object> <ShouldDeserialize>k__BackingField; // 0xB8
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Predicate<object> <GetIsSpecified>k__BackingField; // 0xC0
	[Nullable(new[] { 2, 1, 2 })]
	[CompilerGenerated]
	private Action<object, object> <SetIsSpecified>k__BackingField; // 0xC8
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; // 0xD0
	[CompilerGenerated]
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xD8
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xDC
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xE4

	// Properties
	internal JsonContract PropertyContract { get; set; }
	public string PropertyName { get; set; }
	public Type DeclaringType { get; set; }
	public Nullable<int> Order { get; set; }
	public string UnderlyingName { get; set; }
	public IValueProvider ValueProvider { get; set; }
	public IAttributeProvider AttributeProvider { set; }
	public Type PropertyType { get; set; }
	public JsonConverter Converter { get; set; }
	public bool Ignored { get; set; }
	public bool Readable { get; set; }
	public bool Writable { get; set; }
	public bool HasMemberAttribute { get; set; }
	public object DefaultValue { get; set; }
	public Required Required { get; }
	public Nullable<bool> IsReference { get; set; }
	public Nullable<NullValueHandling> NullValueHandling { get; set; }
	public Nullable<DefaultValueHandling> DefaultValueHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ReferenceLoopHandling { get; set; }
	public Nullable<ObjectCreationHandling> ObjectCreationHandling { get; set; }
	public Nullable<TypeNameHandling> TypeNameHandling { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> ShouldSerialize { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> ShouldDeserialize { get; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> GetIsSpecified { get; set; }
	[Nullable(new[] { 2, 1, 2 })]
	public Action<object, object> SetIsSpecified { get; set; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x30A974C Offset: 0x30A574C VA: 0x30A974C
	internal JsonContract get_PropertyContract() { }

	[CompilerGenerated]
	// RVA: 0x30A9754 Offset: 0x30A5754 VA: 0x30A9754
	internal void set_PropertyContract(JsonContract value) { }

	// RVA: 0x30A975C Offset: 0x30A575C VA: 0x30A975C
	public string get_PropertyName() { }

	// RVA: 0x30A9764 Offset: 0x30A5764 VA: 0x30A9764
	public void set_PropertyName(string value) { }

	[CompilerGenerated]
	// RVA: 0x30A97FC Offset: 0x30A57FC VA: 0x30A97FC
	public Type get_DeclaringType() { }

	[CompilerGenerated]
	// RVA: 0x30A9804 Offset: 0x30A5804 VA: 0x30A9804
	public void set_DeclaringType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x30A980C Offset: 0x30A580C VA: 0x30A980C
	public Nullable<int> get_Order() { }

	[CompilerGenerated]
	// RVA: 0x30A9814 Offset: 0x30A5814 VA: 0x30A9814
	public void set_Order(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x30A981C Offset: 0x30A581C VA: 0x30A981C
	public string get_UnderlyingName() { }

	[CompilerGenerated]
	// RVA: 0x30A9824 Offset: 0x30A5824 VA: 0x30A9824
	public void set_UnderlyingName(string value) { }

	[CompilerGenerated]
	// RVA: 0x30A982C Offset: 0x30A582C VA: 0x30A982C
	public IValueProvider get_ValueProvider() { }

	[CompilerGenerated]
	// RVA: 0x30A9834 Offset: 0x30A5834 VA: 0x30A9834
	public void set_ValueProvider(IValueProvider value) { }

	[CompilerGenerated]
	// RVA: 0x30A983C Offset: 0x30A583C VA: 0x30A983C
	public void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0x30A9844 Offset: 0x30A5844 VA: 0x30A9844
	public Type get_PropertyType() { }

	// RVA: 0x30A984C Offset: 0x30A584C VA: 0x30A984C
	public void set_PropertyType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x30A98D8 Offset: 0x30A58D8 VA: 0x30A98D8
	public JsonConverter get_Converter() { }

	[CompilerGenerated]
	// RVA: 0x30A98E0 Offset: 0x30A58E0 VA: 0x30A98E0
	public void set_Converter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x30A98E8 Offset: 0x30A58E8 VA: 0x30A98E8
	public bool get_Ignored() { }

	[CompilerGenerated]
	// RVA: 0x30A98F0 Offset: 0x30A58F0 VA: 0x30A98F0
	public void set_Ignored(bool value) { }

	[CompilerGenerated]
	// RVA: 0x30A98FC Offset: 0x30A58FC VA: 0x30A98FC
	public bool get_Readable() { }

	[CompilerGenerated]
	// RVA: 0x30A9904 Offset: 0x30A5904 VA: 0x30A9904
	public void set_Readable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x30A9910 Offset: 0x30A5910 VA: 0x30A9910
	public bool get_Writable() { }

	[CompilerGenerated]
	// RVA: 0x30A9918 Offset: 0x30A5918 VA: 0x30A9918
	public void set_Writable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x30A9924 Offset: 0x30A5924 VA: 0x30A9924
	public bool get_HasMemberAttribute() { }

	[CompilerGenerated]
	// RVA: 0x30A992C Offset: 0x30A592C VA: 0x30A992C
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0x30A9938 Offset: 0x30A5938 VA: 0x30A9938
	public object get_DefaultValue() { }

	// RVA: 0x30A9950 Offset: 0x30A5950 VA: 0x30A9950
	public void set_DefaultValue(object value) { }

	// RVA: 0x30A9960 Offset: 0x30A5960 VA: 0x30A9960
	internal object GetResolvedDefaultValue() { }

	// RVA: 0x30A9120 Offset: 0x30A5120 VA: 0x30A9120
	public Required get_Required() { }

	[CompilerGenerated]
	// RVA: 0x30A9A34 Offset: 0x30A5A34 VA: 0x30A9A34
	public Nullable<bool> get_IsReference() { }

	[CompilerGenerated]
	// RVA: 0x30A9A3C Offset: 0x30A5A3C VA: 0x30A9A3C
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x30A9A44 Offset: 0x30A5A44 VA: 0x30A9A44
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x30A9A4C Offset: 0x30A5A4C VA: 0x30A9A4C
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x30A9A54 Offset: 0x30A5A54 VA: 0x30A9A54
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x30A9A5C Offset: 0x30A5A5C VA: 0x30A9A5C
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x30A9A64 Offset: 0x30A5A64 VA: 0x30A9A64
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x30A9A6C Offset: 0x30A5A6C VA: 0x30A9A6C
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x30A9A74 Offset: 0x30A5A74 VA: 0x30A9A74
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGenerated]
	// RVA: 0x30A9A7C Offset: 0x30A5A7C VA: 0x30A9A7C
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x30A9A84 Offset: 0x30A5A84 VA: 0x30A9A84
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x30A9A8C Offset: 0x30A5A8C VA: 0x30A9A8C
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x30A9A94 Offset: 0x30A5A94 VA: 0x30A9A94
	public Predicate<object> get_ShouldSerialize() { }

	[CompilerGenerated]
	// RVA: 0x30A9A9C Offset: 0x30A5A9C VA: 0x30A9A9C
	public void set_ShouldSerialize(Predicate<object> value) { }

	[CompilerGenerated]
	// RVA: 0x30A9AA4 Offset: 0x30A5AA4 VA: 0x30A9AA4
	public Predicate<object> get_ShouldDeserialize() { }

	[CompilerGenerated]
	// RVA: 0x30A9AAC Offset: 0x30A5AAC VA: 0x30A9AAC
	public Predicate<object> get_GetIsSpecified() { }

	[CompilerGenerated]
	// RVA: 0x30A9AB4 Offset: 0x30A5AB4 VA: 0x30A9AB4
	public void set_GetIsSpecified(Predicate<object> value) { }

	[CompilerGenerated]
	// RVA: 0x30A9ABC Offset: 0x30A5ABC VA: 0x30A9ABC
	public Action<object, object> get_SetIsSpecified() { }

	[CompilerGenerated]
	// RVA: 0x30A9AC4 Offset: 0x30A5AC4 VA: 0x30A9AC4
	public void set_SetIsSpecified(Action<object, object> value) { }

	[NullableContext(1)]
	// RVA: 0x30A9ACC Offset: 0x30A5ACC VA: 0x30A9ACC Slot: 3
	public override string ToString() { }

	[CompilerGenerated]
	// RVA: 0x30A9B20 Offset: 0x30A5B20 VA: 0x30A9B20
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	// RVA: 0x30A9B28 Offset: 0x30A5B28 VA: 0x30A9B28
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x30A9B30 Offset: 0x30A5B30 VA: 0x30A9B30
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGenerated]
	// RVA: 0x30A9B38 Offset: 0x30A5B38 VA: 0x30A9B38
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x30A9B40 Offset: 0x30A5B40 VA: 0x30A9B40
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x30A9B48 Offset: 0x30A5B48 VA: 0x30A9B48
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x30A9B50 Offset: 0x30A5B50 VA: 0x30A9B50
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x30A9B58 Offset: 0x30A5B58 VA: 0x30A9B58
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[NullableContext(1)]
	// RVA: 0x30A9B60 Offset: 0x30A5B60 VA: 0x30A9B60
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0x30A9BB0 Offset: 0x30A5BB0 VA: 0x30A9BB0
	public void .ctor() { }
}

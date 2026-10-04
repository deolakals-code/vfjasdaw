// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonDictionaryContract : JsonContainerContract // TypeDefIndex: 16003
{
	// Fields
	[CompilerGenerated]
	[Nullable(new[] { 2, 1, 1 })]
	private Func<string, string> <DictionaryKeyResolver>k__BackingField; // 0xC0
	[CompilerGenerated]
	private readonly Type <DictionaryKeyType>k__BackingField; // 0xC8
	[CompilerGenerated]
	private readonly Type <DictionaryValueType>k__BackingField; // 0xD0
	[CompilerGenerated]
	private JsonContract <KeyContract>k__BackingField; // 0xD8
	private readonly Type _genericCollectionDefinitionType; // 0xE0
	private Type _genericWrapperType; // 0xE8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _genericWrapperCreator; // 0xF0
	[Nullable(new[] { 2, 1 })]
	private Func<object> _genericTemporaryDictionaryCreator; // 0xF8
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; // 0x100
	private readonly ConstructorInfo _parameterizedConstructor; // 0x108
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x110
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x118
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; // 0x120

	// Properties
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> DictionaryKeyResolver { get; set; }
	public Type DictionaryKeyType { get; }
	public Type DictionaryValueType { get; }
	internal JsonContract KeyContract { get; set; }
	internal bool ShouldCreateWrapper { get; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x30A6CA0 Offset: 0x30A2CA0 VA: 0x30A6CA0
	public Func<string, string> get_DictionaryKeyResolver() { }

	[CompilerGenerated]
	// RVA: 0x30A6CA8 Offset: 0x30A2CA8 VA: 0x30A6CA8
	public void set_DictionaryKeyResolver(Func<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x30A6CB0 Offset: 0x30A2CB0 VA: 0x30A6CB0
	public Type get_DictionaryKeyType() { }

	[CompilerGenerated]
	// RVA: 0x30A6CB8 Offset: 0x30A2CB8 VA: 0x30A6CB8
	public Type get_DictionaryValueType() { }

	[CompilerGenerated]
	// RVA: 0x30A6CC0 Offset: 0x30A2CC0 VA: 0x30A6CC0
	internal JsonContract get_KeyContract() { }

	[CompilerGenerated]
	// RVA: 0x30A6CC8 Offset: 0x30A2CC8 VA: 0x30A6CC8
	internal void set_KeyContract(JsonContract value) { }

	[CompilerGenerated]
	// RVA: 0x30A6CD0 Offset: 0x30A2CD0 VA: 0x30A6CD0
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0x30A6CD8 Offset: 0x30A2CD8 VA: 0x30A6CD8
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x30A6DA4 Offset: 0x30A2DA4 VA: 0x30A6DA4
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x30A6DAC Offset: 0x30A2DAC VA: 0x30A6DAC
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x30A6DBC Offset: 0x30A2DBC VA: 0x30A6DBC
	public bool get_HasParameterizedCreator() { }

	[CompilerGenerated]
	// RVA: 0x30A6DC4 Offset: 0x30A2DC4 VA: 0x30A6DC4
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x30A6DD0 Offset: 0x30A2DD0 VA: 0x30A6DD0
	internal bool get_HasParameterizedCreatorInternal() { }

	[NullableContext(1)]
	// RVA: 0x30A6E50 Offset: 0x30A2E50 VA: 0x30A6E50
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x30A78A4 Offset: 0x30A38A4 VA: 0x30A78A4
	internal IWrappedDictionary CreateWrapper(object dictionary) { }

	[NullableContext(1)]
	// RVA: 0x30A7B78 Offset: 0x30A3B78 VA: 0x30A7B78
	internal IDictionary CreateTemporaryDictionary() { }
}

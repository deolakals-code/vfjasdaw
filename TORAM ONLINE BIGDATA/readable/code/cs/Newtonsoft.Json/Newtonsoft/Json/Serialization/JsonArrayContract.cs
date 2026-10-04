// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 15993
{
	// Fields
	[CompilerGenerated]
	private readonly Type <CollectionItemType>k__BackingField; // 0xC0
	[CompilerGenerated]
	private readonly bool <IsMultidimensionalArray>k__BackingField; // 0xC8
	private readonly Type _genericCollectionDefinitionType; // 0xD0
	private Type _genericWrapperType; // 0xD8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
	[Nullable(new[] { 2, 1 })]
	private Func<object> _genericTemporaryCollectionCreator; // 0xE8
	[CompilerGenerated]
	private readonly bool <IsArray>k__BackingField; // 0xF0
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; // 0xF1
	[CompilerGenerated]
	private bool <CanDeserialize>k__BackingField; // 0xF2
	private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x100
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x108
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; // 0x110

	// Properties
	public Type CollectionItemType { get; }
	public bool IsMultidimensionalArray { get; }
	internal bool IsArray { get; }
	internal bool ShouldCreateWrapper { get; }
	internal bool CanDeserialize { get; set; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x30A3F1C Offset: 0x309FF1C VA: 0x30A3F1C
	public Type get_CollectionItemType() { }

	[CompilerGenerated]
	// RVA: 0x30A3F24 Offset: 0x309FF24 VA: 0x30A3F24
	public bool get_IsMultidimensionalArray() { }

	[CompilerGenerated]
	// RVA: 0x30A3F2C Offset: 0x309FF2C VA: 0x30A3F2C
	internal bool get_IsArray() { }

	[CompilerGenerated]
	// RVA: 0x30A3F34 Offset: 0x309FF34 VA: 0x30A3F34
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGenerated]
	// RVA: 0x30A3F3C Offset: 0x309FF3C VA: 0x30A3F3C
	internal bool get_CanDeserialize() { }

	[CompilerGenerated]
	// RVA: 0x30A3F44 Offset: 0x309FF44 VA: 0x30A3F44
	private void set_CanDeserialize(bool value) { }

	// RVA: 0x30A3F50 Offset: 0x309FF50 VA: 0x30A3F50
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x30A401C Offset: 0x30A001C VA: 0x30A401C
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x30A4024 Offset: 0x30A0024 VA: 0x30A4024
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x30A4048 Offset: 0x30A0048 VA: 0x30A4048
	public bool get_HasParameterizedCreator() { }

	[CompilerGenerated]
	// RVA: 0x30A4050 Offset: 0x30A0050 VA: 0x30A4050
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x30A405C Offset: 0x30A005C VA: 0x30A405C
	internal bool get_HasParameterizedCreatorInternal() { }

	[NullableContext(1)]
	// RVA: 0x30A40DC Offset: 0x30A00DC VA: 0x30A40DC
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x30A51C0 Offset: 0x30A11C0 VA: 0x30A51C0
	internal IWrappedCollection CreateWrapper(object list) { }

	[NullableContext(1)]
	// RVA: 0x30A55DC Offset: 0x30A15DC VA: 0x30A55DC
	internal IList CreateTemporaryCollection() { }

	[NullableContext(1)]
	// RVA: 0x30A50A0 Offset: 0x30A10A0 VA: 0x30A50A0
	private void StoreFSharpListCreatorIfNecessary(Type underlyingType) { }
}

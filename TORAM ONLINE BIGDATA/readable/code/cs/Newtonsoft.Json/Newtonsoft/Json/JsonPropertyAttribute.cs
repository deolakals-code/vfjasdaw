// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[Usage(2432, AllowMultiple = False)]
[NullableContext(2)]
[Nullable(0)]
public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 15850
{
	// Fields
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x10
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x18
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x20
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x28
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0x30
	internal Nullable<bool> _isReference; // 0x38
	internal Nullable<int> _order; // 0x3C
	internal Nullable<Required> _required; // 0x44
	internal Nullable<bool> _itemIsReference; // 0x4C
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x50
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x58
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; // 0x60
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private object[] <ItemConverterParameters>k__BackingField; // 0x68
	[CompilerGenerated]
	private Type <NamingStrategyType>k__BackingField; // 0x70
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private object[] <NamingStrategyParameters>k__BackingField; // 0x78
	[CompilerGenerated]
	private string <PropertyName>k__BackingField; // 0x80

	// Properties
	public Type ItemConverterType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] ItemConverterParameters { get; }
	public Type NamingStrategyType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] NamingStrategyParameters { get; }
	public string PropertyName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x306E564 Offset: 0x306A564 VA: 0x306E564
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	// RVA: 0x306E56C Offset: 0x306A56C VA: 0x306E56C
	public object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	// RVA: 0x306E574 Offset: 0x306A574 VA: 0x306E574
	public Type get_NamingStrategyType() { }

	[CompilerGenerated]
	// RVA: 0x306E57C Offset: 0x306A57C VA: 0x306E57C
	public object[] get_NamingStrategyParameters() { }

	[CompilerGenerated]
	// RVA: 0x306E584 Offset: 0x306A584 VA: 0x306E584
	public string get_PropertyName() { }
}

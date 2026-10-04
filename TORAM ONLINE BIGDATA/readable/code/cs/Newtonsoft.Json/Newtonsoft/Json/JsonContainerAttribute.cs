// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json
[NullableContext(2)]
[Usage(1028, AllowMultiple = False)]
[Nullable(0)]
public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 15837
{
	// Fields
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; // 0x10
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private object[] <ItemConverterParameters>k__BackingField; // 0x18
	[CompilerGenerated]
	private NamingStrategy <NamingStrategyInstance>k__BackingField; // 0x20
	internal Nullable<bool> _isReference; // 0x28
	internal Nullable<bool> _itemIsReference; // 0x2A
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x2C
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x34
	private Type _namingStrategyType; // 0x40
	[Nullable(new[] { 2, 1 })]
	private object[] _namingStrategyParameters; // 0x48

	// Properties
	public Type ItemConverterType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] ItemConverterParameters { get; }
	public Type NamingStrategyType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] NamingStrategyParameters { get; }
	internal NamingStrategy NamingStrategyInstance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x306CF54 Offset: 0x3068F54 VA: 0x306CF54
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	// RVA: 0x306CF5C Offset: 0x3068F5C VA: 0x306CF5C
	public object[] get_ItemConverterParameters() { }

	// RVA: 0x306CF64 Offset: 0x3068F64 VA: 0x306CF64
	public Type get_NamingStrategyType() { }

	// RVA: 0x306CF6C Offset: 0x3068F6C VA: 0x306CF6C
	public object[] get_NamingStrategyParameters() { }

	[CompilerGenerated]
	// RVA: 0x306CF74 Offset: 0x3068F74 VA: 0x306CF74
	internal NamingStrategy get_NamingStrategyInstance() { }

	[CompilerGenerated]
	// RVA: 0x306CF7C Offset: 0x3068F7C VA: 0x306CF7C
	internal void set_NamingStrategyInstance(NamingStrategy value) { }
}

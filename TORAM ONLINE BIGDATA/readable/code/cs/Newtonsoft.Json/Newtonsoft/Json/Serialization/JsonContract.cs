// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public abstract class JsonContract // TypeDefIndex: 16002
{
	// Fields
	internal bool IsNullable; // 0x10
	internal bool IsConvertable; // 0x11
	internal bool IsEnum; // 0x12
	internal Type NonNullableUnderlyingType; // 0x18
	internal ReadType InternalReadType; // 0x20
	internal JsonContractType ContractType; // 0x24
	internal bool IsReadOnlyOrFixedSize; // 0x28
	internal bool IsSealed; // 0x29
	internal bool IsInstantiable; // 0x2A
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onDeserializedCallbacks; // 0x30
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onDeserializingCallbacks; // 0x38
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onSerializedCallbacks; // 0x40
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onSerializingCallbacks; // 0x48
	[Nullable(new[] { 2, 1 })]
	private List<SerializationErrorCallback> _onErrorCallbacks; // 0x50
	private Type _createdType; // 0x58
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<bool> <IsReference>k__BackingField; // 0x68
	[Nullable(2)]
	[CompilerGenerated]
	private JsonConverter <Converter>k__BackingField; // 0x70
	[CompilerGenerated]
	[Nullable(2)]
	private JsonConverter <InternalConverter>k__BackingField; // 0x78
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Func<object> <DefaultCreator>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <DefaultCreatorNonPublic>k__BackingField; // 0x88

	// Properties
	public Type UnderlyingType { get; }
	public Type CreatedType { get; set; }
	public Nullable<bool> IsReference { get; set; }
	[Nullable(2)]
	public JsonConverter Converter { get; set; }
	[Nullable(2)]
	public JsonConverter InternalConverter { get; set; }
	public IList<SerializationCallback> OnDeserializedCallbacks { get; }
	public IList<SerializationCallback> OnDeserializingCallbacks { get; }
	public IList<SerializationCallback> OnSerializedCallbacks { get; }
	public IList<SerializationCallback> OnSerializingCallbacks { get; }
	public IList<SerializationErrorCallback> OnErrorCallbacks { get; }
	[Nullable(new[] { 2, 1 })]
	public Func<object> DefaultCreator { get; set; }
	public bool DefaultCreatorNonPublic { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x30A5EF8 Offset: 0x30A1EF8 VA: 0x30A5EF8
	public Type get_UnderlyingType() { }

	// RVA: 0x30A5F00 Offset: 0x30A1F00 VA: 0x30A5F00
	public Type get_CreatedType() { }

	// RVA: 0x30A4FE8 Offset: 0x30A0FE8 VA: 0x30A4FE8
	public void set_CreatedType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x30A5F08 Offset: 0x30A1F08 VA: 0x30A5F08
	public Nullable<bool> get_IsReference() { }

	[CompilerGenerated]
	// RVA: 0x30A5F10 Offset: 0x30A1F10 VA: 0x30A5F10
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x30A5F18 Offset: 0x30A1F18 VA: 0x30A5F18
	public JsonConverter get_Converter() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x30A5F20 Offset: 0x30A1F20 VA: 0x30A5F20
	public void set_Converter(JsonConverter value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x30A5F28 Offset: 0x30A1F28 VA: 0x30A5F28
	public JsonConverter get_InternalConverter() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x30A5F30 Offset: 0x30A1F30 VA: 0x30A5F30
	internal void set_InternalConverter(JsonConverter value) { }

	// RVA: 0x30A5F38 Offset: 0x30A1F38 VA: 0x30A5F38
	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0x30A5FBC Offset: 0x30A1FBC VA: 0x30A5FBC
	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0x30A6040 Offset: 0x30A2040 VA: 0x30A6040
	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0x30A60C4 Offset: 0x30A20C4 VA: 0x30A60C4
	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0x30A6148 Offset: 0x30A2148 VA: 0x30A6148
	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[CompilerGenerated]
	// RVA: 0x30A61CC Offset: 0x30A21CC VA: 0x30A61CC
	public Func<object> get_DefaultCreator() { }

	[CompilerGenerated]
	// RVA: 0x30A61D4 Offset: 0x30A21D4 VA: 0x30A61D4
	public void set_DefaultCreator(Func<object> value) { }

	[CompilerGenerated]
	// RVA: 0x30A61DC Offset: 0x30A21DC VA: 0x30A61DC
	public bool get_DefaultCreatorNonPublic() { }

	[CompilerGenerated]
	// RVA: 0x30A61E4 Offset: 0x30A21E4 VA: 0x30A61E4
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0x30A5900 Offset: 0x30A1900 VA: 0x30A5900
	internal void .ctor(Type underlyingType) { }

	// RVA: 0x30A61F0 Offset: 0x30A21F0 VA: 0x30A61F0
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0x30A6350 Offset: 0x30A2350 VA: 0x30A6350
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0x30A64B0 Offset: 0x30A24B0 VA: 0x30A64B0
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0x30A6610 Offset: 0x30A2610 VA: 0x30A6610
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0x30A6770 Offset: 0x30A2770 VA: 0x30A6770
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x30A68E0 Offset: 0x30A28E0 VA: 0x30A68E0
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0x30A69A0 Offset: 0x30A29A0 VA: 0x30A69A0
	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }
}

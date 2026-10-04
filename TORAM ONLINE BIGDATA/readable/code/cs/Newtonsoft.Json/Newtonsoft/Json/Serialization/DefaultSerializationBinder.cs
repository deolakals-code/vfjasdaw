// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder // TypeDefIndex: 15984
{
	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	[Nullable(new[] { 1, 0, 2, 1, 1 })]
	private readonly ThreadSafeStore<StructMultiKey<string, string>, Type> _typeCache; // 0x10

	// Methods

	// RVA: 0x30A34A8 Offset: 0x309F4A8 VA: 0x30A34A8
	public void .ctor() { }

	// RVA: 0x30A3580 Offset: 0x309F580 VA: 0x30A3580
	private Type GetTypeFromTypeNameKey(StructMultiKey<string, string> typeNameKey) { }

	// RVA: 0x30A3978 Offset: 0x309F978 VA: 0x30A3978
	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	// RVA: 0x30A3C38 Offset: 0x309FC38 VA: 0x30A3C38
	private Type GetTypeByName(StructMultiKey<string, string> typeNameKey) { }

	// RVA: 0x30A3CA0 Offset: 0x309FCA0 VA: 0x30A3CA0 Slot: 5
	public override Type BindToType(string assemblyName, string typeName) { }

	[NullableContext(2)]
	// RVA: 0x30A3D1C Offset: 0x309FD1C VA: 0x30A3D1C Slot: 4
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: 0x30A3D98 Offset: 0x309FD98 VA: 0x30A3D98
	private static void .cctor() { }
}

// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface ISerializationBinder // TypeDefIndex: 15990
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type BindToType(string assemblyName, string typeName);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void BindToName(Type serializedType, out string assemblyName, out string typeName);
}

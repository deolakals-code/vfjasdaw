// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization
[Serializable]
public abstract class SerializationBinder // TypeDefIndex: 10343
{
	// Methods

	// RVA: 0x2EFB20C Offset: 0x2EF720C VA: 0x2EFB20C Slot: 4
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Type BindToType(string assemblyName, string typeName);

	// RVA: 0x2EFB238 Offset: 0x2EF7238 VA: 0x2EFB238
	protected void .ctor() { }
}

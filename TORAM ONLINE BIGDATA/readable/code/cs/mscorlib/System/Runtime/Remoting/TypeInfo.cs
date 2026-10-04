// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
[Serializable]
internal class TypeInfo : IRemotingTypeInfo // TypeDefIndex: 10216
{
	// Fields
	private string serverType; // 0x10
	private string[] serverHierarchy; // 0x18
	private string[] interfacesImplemented; // 0x20

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x2ECE3A8 Offset: 0x2ECA3A8 VA: 0x2ECE3A8
	public void .ctor(Type type) { }

	// RVA: 0x2EDEF0C Offset: 0x2EDAF0C VA: 0x2EDEF0C Slot: 4
	public string get_TypeName() { }

	// RVA: 0x2EDEF14 Offset: 0x2EDAF14 VA: 0x2EDEF14 Slot: 5
	public bool CanCastTo(Type fromType, object o) { }
}

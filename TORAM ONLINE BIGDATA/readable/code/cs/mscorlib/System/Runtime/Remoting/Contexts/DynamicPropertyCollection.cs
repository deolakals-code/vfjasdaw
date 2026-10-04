// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Contexts
internal class DynamicPropertyCollection // TypeDefIndex: 10236
{
	// Fields
	private ArrayList _properties; // 0x10

	// Properties
	public bool HasProperties { get; }

	// Methods

	// RVA: 0x2ECCE60 Offset: 0x2EC8E60 VA: 0x2ECCE60
	public bool get_HasProperties() { }

	// RVA: 0x2EE4AA4 Offset: 0x2EE0AA4 VA: 0x2EE4AA4
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	// RVA: 0x2EE4E2C Offset: 0x2EE0E2C VA: 0x2EE4E2C
	public bool UnregisterDynamicProperty(string name) { }

	// RVA: 0x2ECCF14 Offset: 0x2EC8F14 VA: 0x2ECCF14
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	// RVA: 0x2EE6760 Offset: 0x2EE2760 VA: 0x2EE6760
	private int FindProperty(string name) { }

	// RVA: 0x2ECCDB4 Offset: 0x2EC8DB4 VA: 0x2ECCDB4
	public void .ctor() { }
}

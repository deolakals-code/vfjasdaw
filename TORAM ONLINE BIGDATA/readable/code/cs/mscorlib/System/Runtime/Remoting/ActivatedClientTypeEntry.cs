// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class ActivatedClientTypeEntry : TypeEntry // TypeDefIndex: 10189
{
	// Fields
	private string applicationUrl; // 0x20
	private Type obj_type; // 0x28

	// Properties
	public string ApplicationUrl { get; }
	public IContextAttribute[] ContextAttributes { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x2ECC99C Offset: 0x2EC899C VA: 0x2ECC99C
	public void .ctor(string typeName, string assemblyName, string appUrl) { }

	// RVA: 0x2ECCB08 Offset: 0x2EC8B08 VA: 0x2ECCB08
	public string get_ApplicationUrl() { }

	// RVA: 0x2ECCB10 Offset: 0x2EC8B10 VA: 0x2ECCB10
	public IContextAttribute[] get_ContextAttributes() { }

	// RVA: 0x2ECCB18 Offset: 0x2EC8B18 VA: 0x2ECCB18
	public Type get_ObjectType() { }

	// RVA: 0x2ECCB20 Offset: 0x2EC8B20 VA: 0x2ECCB20 Slot: 3
	public override string ToString() { }
}

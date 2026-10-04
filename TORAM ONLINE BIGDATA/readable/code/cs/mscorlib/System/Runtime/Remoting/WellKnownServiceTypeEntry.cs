// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class WellKnownServiceTypeEntry : TypeEntry // TypeDefIndex: 10219
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_uri; // 0x28
	private WellKnownObjectMode obj_mode; // 0x30

	// Properties
	public WellKnownObjectMode Mode { get; }
	public Type ObjectType { get; }
	public string ObjectUri { get; }

	// Methods

	// RVA: 0x2ED71F4 Offset: 0x2ED31F4 VA: 0x2ED71F4
	public void .ctor(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x2EDF1C0 Offset: 0x2EDB1C0 VA: 0x2EDF1C0
	public WellKnownObjectMode get_Mode() { }

	// RVA: 0x2EDF1C8 Offset: 0x2EDB1C8 VA: 0x2EDF1C8
	public Type get_ObjectType() { }

	// RVA: 0x2EDF1D0 Offset: 0x2EDB1D0 VA: 0x2EDF1D0
	public string get_ObjectUri() { }

	// RVA: 0x2EDF1D8 Offset: 0x2EDB1D8 VA: 0x2EDF1D8 Slot: 3
	public override string ToString() { }
}

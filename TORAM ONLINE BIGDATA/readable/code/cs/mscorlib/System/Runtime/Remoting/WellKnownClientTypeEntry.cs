// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class WellKnownClientTypeEntry : TypeEntry // TypeDefIndex: 10217
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_url; // 0x28
	private string app_url; // 0x30

	// Properties
	public string ApplicationUrl { get; }
	public Type ObjectType { get; }
	public string ObjectUrl { get; }

	// Methods

	// RVA: 0x2ED7098 Offset: 0x2ED3098 VA: 0x2ED7098
	public void .ctor(string typeName, string assemblyName, string objectUrl) { }

	// RVA: 0x2EDF188 Offset: 0x2EDB188 VA: 0x2EDF188
	public string get_ApplicationUrl() { }

	// RVA: 0x2EDF190 Offset: 0x2EDB190 VA: 0x2EDF190
	public Type get_ObjectType() { }

	// RVA: 0x2EDF198 Offset: 0x2EDB198 VA: 0x2EDF198
	public string get_ObjectUrl() { }

	// RVA: 0x2EDF1A0 Offset: 0x2EDB1A0 VA: 0x2EDF1A0 Slot: 3
	public override string ToString() { }
}

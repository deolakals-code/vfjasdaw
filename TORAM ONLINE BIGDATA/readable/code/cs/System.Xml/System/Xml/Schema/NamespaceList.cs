// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class NamespaceList // TypeDefIndex: 13706
{
	// Fields
	private NamespaceList.ListType type; // 0x10
	private Hashtable set; // 0x18
	private string targetNamespace; // 0x20

	// Properties
	public NamespaceList.ListType Type { get; }
	public string Excluded { get; }
	public ICollection Enumerate { get; }

	// Methods

	// RVA: 0x32E1CEC Offset: 0x32DDCEC VA: 0x32E1CEC
	public void .ctor() { }

	// RVA: 0x32E1CF4 Offset: 0x32DDCF4 VA: 0x32E1CF4
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x32E1FA8 Offset: 0x32DDFA8 VA: 0x32E1FA8
	public NamespaceList Clone() { }

	// RVA: 0x32E20E8 Offset: 0x32DE0E8 VA: 0x32E20E8
	public NamespaceList.ListType get_Type() { }

	// RVA: 0x32E20F0 Offset: 0x32DE0F0 VA: 0x32E20F0
	public string get_Excluded() { }

	// RVA: 0x32E20F8 Offset: 0x32DE0F8 VA: 0x32E20F8
	public ICollection get_Enumerate() { }

	// RVA: 0x32E215C Offset: 0x32DE15C VA: 0x32E215C Slot: 4
	public virtual bool Allows(string ns) { }

	// RVA: 0x32E21E0 Offset: 0x32DE1E0 VA: 0x32E21E0
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x32E2200 Offset: 0x32DE200 VA: 0x32E2200 Slot: 3
	public override string ToString() { }

	// RVA: 0x32E2708 Offset: 0x32DE708 VA: 0x32E2708
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0x32E2AEC Offset: 0x32DEAEC VA: 0x32E2AEC
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x32E3084 Offset: 0x32DF084 VA: 0x32E3084
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0x32E31B0 Offset: 0x32DF1B0 VA: 0x32E31B0
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x32E3708 Offset: 0x32DF708 VA: 0x32E3708
	private void RemoveNamespace(string tns) { }
}

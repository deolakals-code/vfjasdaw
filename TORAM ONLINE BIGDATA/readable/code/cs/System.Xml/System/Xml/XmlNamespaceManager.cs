// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable // TypeDefIndex: 13468
{
	// Fields
	private XmlNamespaceManager.NamespaceDeclaration[] nsdecls; // 0x10
	private int lastDecl; // 0x18
	private XmlNameTable nameTable; // 0x20
	private int scopeId; // 0x28
	private Dictionary<string, int> hashTable; // 0x30
	private bool useHashtable; // 0x38
	private string xml; // 0x40
	private string xmlNs; // 0x48

	// Properties
	public virtual XmlNameTable NameTable { get; }
	public virtual string DefaultNamespace { get; }

	// Methods

	// RVA: 0x33E0F5C Offset: 0x33DCF5C VA: 0x33E0F5C
	internal void .ctor() { }

	// RVA: 0x33E0F64 Offset: 0x33DCF64 VA: 0x33E0F64
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x33E1214 Offset: 0x33DD214 VA: 0x33E1214 Slot: 8
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x33E121C Offset: 0x33DD21C VA: 0x33E121C Slot: 9
	public virtual string get_DefaultNamespace() { }

	// RVA: 0x33E128C Offset: 0x33DD28C VA: 0x33E128C Slot: 10
	public virtual void PushScope() { }

	// RVA: 0x33E129C Offset: 0x33DD29C VA: 0x33E129C Slot: 11
	public virtual bool PopScope() { }

	// RVA: 0x33E1370 Offset: 0x33DD370 VA: 0x33E1370 Slot: 12
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x33E18E8 Offset: 0x33DD8E8 VA: 0x33E18E8 Slot: 13
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x33E1A24 Offset: 0x33DDA24 VA: 0x33E1A24 Slot: 14
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x33E1B98 Offset: 0x33DDB98 VA: 0x33E1B98 Slot: 15
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x33E1D50 Offset: 0x33DDD50 VA: 0x33E1D50 Slot: 16
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x33E1758 Offset: 0x33DD758 VA: 0x33E1758
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x33E1D9C Offset: 0x33DDD9C VA: 0x33E1D9C Slot: 17
	public virtual string LookupPrefix(string uri) { }
}

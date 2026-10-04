// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
public class XmlSerializerNamespaces // TypeDefIndex: 13486
{
	// Fields
	private Hashtable namespaces; // 0x10

	// Properties
	public int Count { get; }
	internal ArrayList NamespaceList { get; }
	internal Hashtable Namespaces { get; set; }

	// Methods

	// RVA: 0x33E65AC Offset: 0x33E25AC VA: 0x33E65AC
	public void .ctor() { }

	// RVA: 0x33E65B4 Offset: 0x33E25B4 VA: 0x33E65B4
	public void Add(string prefix, string ns) { }

	// RVA: 0x33E6668 Offset: 0x33E2668 VA: 0x33E6668
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0x33E6714 Offset: 0x33E2714 VA: 0x33E6714
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0x33E6C50 Offset: 0x33E2C50 VA: 0x33E6C50
	public int get_Count() { }

	// RVA: 0x33E681C Offset: 0x33E281C VA: 0x33E681C
	internal ArrayList get_NamespaceList() { }

	// RVA: 0x33E66A4 Offset: 0x33E26A4 VA: 0x33E66A4
	internal Hashtable get_Namespaces() { }

	// RVA: 0x33E6C74 Offset: 0x33E2C74 VA: 0x33E6C74
	internal void set_Namespaces(Hashtable value) { }
}

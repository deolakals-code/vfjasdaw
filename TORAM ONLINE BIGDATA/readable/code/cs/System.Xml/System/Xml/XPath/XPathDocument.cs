// Assembly: System.Xml.dll
// Namespace: System.Xml.XPath
public class XPathDocument // TypeDefIndex: 13477
{
	// Fields
	private XPathNode[] pageXmlNmsp; // 0x10
	private int idxXmlNmsp; // 0x18
	private XmlNameTable nameTable; // 0x20
	private bool hasLineInfo; // 0x28
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; // 0x30

	// Properties
	internal XmlNameTable NameTable { get; }
	internal bool HasLineInfo { get; }

	// Methods

	// RVA: 0x33E3534 Offset: 0x33DF534 VA: 0x33E3534
	internal XmlNameTable get_NameTable() { }

	// RVA: 0x33E353C Offset: 0x33DF53C VA: 0x33E353C
	internal bool get_HasLineInfo() { }

	// RVA: 0x33E3544 Offset: 0x33DF544 VA: 0x33E3544
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	// RVA: 0x33E356C Offset: 0x33DF56C VA: 0x33E356C
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }
}

// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlNamedNodeMap : IEnumerable // TypeDefIndex: 13409
{
	// Fields
	internal XmlNode parent; // 0x10
	internal XmlNamedNodeMap.SmallXmlNodeList nodes; // 0x18

	// Properties
	public virtual int Count { get; }

	// Methods

	// RVA: 0x33BFED8 Offset: 0x33BBED8 VA: 0x33BFED8
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x33BFF08 Offset: 0x33BBF08 VA: 0x33BFF08 Slot: 5
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x33C0160 Offset: 0x33BC160 VA: 0x33C0160 Slot: 6
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x33C0394 Offset: 0x33BC394 VA: 0x33C0394 Slot: 7
	public virtual int get_Count() { }

	// RVA: 0x33C0440 Offset: 0x33BC440 VA: 0x33C0440 Slot: 8
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x33BFFA0 Offset: 0x33BBFA0 VA: 0x33BFFA0
	internal int FindNodeOffset(string name) { }

	// RVA: 0x33C021C Offset: 0x33BC21C VA: 0x33C021C
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x33C054C Offset: 0x33BC54C VA: 0x33C054C Slot: 9
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x33C07FC Offset: 0x33BC7FC VA: 0x33C07FC Slot: 10
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x33C08A4 Offset: 0x33BC8A4 VA: 0x33C08A4 Slot: 11
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x33C0340 Offset: 0x33BC340 VA: 0x33C0340
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x33C0AF4 Offset: 0x33BCAF4 VA: 0x33C0AF4 Slot: 12
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }
}

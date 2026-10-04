// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlElement : XmlLinkedNode // TypeDefIndex: 13398
{
	// Fields
	private XmlName name; // 0x20
	private XmlAttributeCollection attributes; // 0x28
	private XmlLinkedNode lastChild; // 0x30

	// Properties
	internal XmlName XmlName { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	internal override bool IsContainer { get; }
	public bool IsEmpty { get; set; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlAttributeCollection Attributes { get; }
	public virtual bool HasAttributes { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerXml { set; }
	public override string InnerText { get; set; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x33B72B0 Offset: 0x33B32B0 VA: 0x33B72B0
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x33B92C4 Offset: 0x33B52C4 VA: 0x33B92C4
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x33B9308 Offset: 0x33B5308 VA: 0x33B9308
	internal XmlName get_XmlName() { }

	// RVA: 0x33B9310 Offset: 0x33B5310 VA: 0x33B9310
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x33B9318 Offset: 0x33B5318 VA: 0x33B9318 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33B98D0 Offset: 0x33B58D0 VA: 0x33B98D0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33B98EC Offset: 0x33B58EC VA: 0x33B98EC Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33B9908 Offset: 0x33B5908 VA: 0x33B9908 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0x33B9924 Offset: 0x33B5924 VA: 0x33B9924 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0x33B9940 Offset: 0x33B5940 VA: 0x33B9940 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x33B99EC Offset: 0x33B59EC VA: 0x33B99EC Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33B99F4 Offset: 0x33B59F4 VA: 0x33B99F4 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x33B99FC Offset: 0x33B59FC VA: 0x33B99FC Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x33B9A18 Offset: 0x33B5A18 VA: 0x33B9A18 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x33B9A20 Offset: 0x33B5A20 VA: 0x33B9A20 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x33B9858 Offset: 0x33B5858 VA: 0x33B9858
	public bool get_IsEmpty() { }

	// RVA: 0x33B9868 Offset: 0x33B5868 VA: 0x33B9868
	public void set_IsEmpty(bool value) { }

	// RVA: 0x33B9BE0 Offset: 0x33B5BE0 VA: 0x33B9BE0 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x33B9BF0 Offset: 0x33B5BF0 VA: 0x33B9BF0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x33B9BF8 Offset: 0x33B5BF8 VA: 0x33B9BF8 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x33B9C1C Offset: 0x33B5C1C VA: 0x33B9C1C Slot: 14
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x33B9D58 Offset: 0x33B5D58 VA: 0x33B9D58 Slot: 56
	public virtual bool get_HasAttributes() { }

	// RVA: 0x33B9D80 Offset: 0x33B5D80 VA: 0x33B9D80 Slot: 57
	public virtual string GetAttribute(string name) { }

	// RVA: 0x33B9E00 Offset: 0x33B5E00 VA: 0x33B9E00 Slot: 58
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x33B9EA4 Offset: 0x33B5EA4 VA: 0x33B9EA4 Slot: 59
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x33B9F08 Offset: 0x33B5F08 VA: 0x33B9F08 Slot: 60
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x33BA018 Offset: 0x33B6018 VA: 0x33BA018 Slot: 61
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x33BA0AC Offset: 0x33B60AC VA: 0x33BA0AC Slot: 62
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x33BA1B0 Offset: 0x33B61B0 VA: 0x33BA1B0 Slot: 63
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x33BA21C Offset: 0x33B621C VA: 0x33BA21C Slot: 64
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x33BA2F8 Offset: 0x33B62F8 VA: 0x33BA2F8 Slot: 65
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x33BA31C Offset: 0x33B631C VA: 0x33BA31C Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33BA430 Offset: 0x33B6430 VA: 0x33BA430
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x33BA618 Offset: 0x33B6618 VA: 0x33BA618
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0x33BA730 Offset: 0x33B6730 VA: 0x33BA730 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x33BA798 Offset: 0x33B6798 VA: 0x33BA798 Slot: 66
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x33BA7D0 Offset: 0x33B67D0 VA: 0x33BA7D0 Slot: 45
	public override void RemoveAll() { }

	// RVA: 0x33B9BD8 Offset: 0x33B5BD8 VA: 0x33B9BD8
	internal void RemoveAllChildren() { }

	// RVA: 0x33BA7F8 Offset: 0x33B67F8 VA: 0x33BA7F8 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x33BA800 Offset: 0x33B6800 VA: 0x33BA800 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x33BA8F4 Offset: 0x33B68F4 VA: 0x33BA8F4 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x33BA8FC Offset: 0x33B68FC VA: 0x33BA8FC Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x33BA9B8 Offset: 0x33B69B8 VA: 0x33BA9B8 Slot: 13
	public override XmlNode get_NextSibling() { }

	// RVA: 0x33BA9F4 Offset: 0x33B69F4 VA: 0x33BA9F4 Slot: 47
	internal override void SetParent(XmlNode node) { }
}

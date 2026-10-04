// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlAttribute : XmlNode // TypeDefIndex: 13387
{
	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Properties
	internal int LocalNameHash { get; }
	internal XmlName XmlName { get; set; }
	public override XmlNode ParentNode { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string Value { get; set; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerText { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public virtual bool Specified { get; }
	public virtual XmlElement OwnerElement { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }
	internal override XmlSpace XmlSpace { get; }
	internal override string XmlLang { get; }

	// Methods

	// RVA: 0x33B093C Offset: 0x33AC93C VA: 0x33B093C
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0x33B0B2C Offset: 0x33ACB2C VA: 0x33B0B2C
	internal int get_LocalNameHash() { }

	// RVA: 0x33B0B48 Offset: 0x33ACB48 VA: 0x33B0B48
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x33B0C98 Offset: 0x33ACC98 VA: 0x33B0C98
	internal XmlName get_XmlName() { }

	// RVA: 0x33B0CA0 Offset: 0x33ACCA0 VA: 0x33B0CA0
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x33B0CA8 Offset: 0x33ACCA8 VA: 0x33B0CA8 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33B0D70 Offset: 0x33ACD70 VA: 0x33B0D70 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x33B0D78 Offset: 0x33ACD78 VA: 0x33B0D78 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33B0D94 Offset: 0x33ACD94 VA: 0x33B0D94 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33B0DB0 Offset: 0x33ACDB0 VA: 0x33B0DB0 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0x33B0DCC Offset: 0x33ACDCC VA: 0x33B0DCC Slot: 34
	public override string get_Prefix() { }

	// RVA: 0x33B0DE8 Offset: 0x33ACDE8 VA: 0x33B0DE8 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x33B0E90 Offset: 0x33ACE90 VA: 0x33B0E90 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33B0E98 Offset: 0x33ACE98 VA: 0x33B0E98 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x33B0EB4 Offset: 0x33ACEB4 VA: 0x33B0EB4 Slot: 7
	public override string get_Value() { }

	// RVA: 0x33B0EC4 Offset: 0x33ACEC4 VA: 0x33B0EC4 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x33B0ED4 Offset: 0x33ACED4 VA: 0x33B0ED4 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x33B0EDC Offset: 0x33ACEDC VA: 0x33B0EDC Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x33B0F40 Offset: 0x33ACF40 VA: 0x33B0F40
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0x33B0FF0 Offset: 0x33ACFF0 VA: 0x33B0FF0
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x33B1220 Offset: 0x33AD220 VA: 0x33B1220 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x33B1228 Offset: 0x33AD228 VA: 0x33B1228 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x33B1488 Offset: 0x33AD488 VA: 0x33B1488 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x33B1490 Offset: 0x33AD490 VA: 0x33B1490 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x33B1498 Offset: 0x33AD498 VA: 0x33B1498 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x33B14B0 Offset: 0x33AD4B0 VA: 0x33B14B0 Slot: 56
	public virtual bool get_Specified() { }

	// RVA: 0x33B14B8 Offset: 0x33AD4B8 VA: 0x33B14B8 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x33B1548 Offset: 0x33AD548 VA: 0x33B1548 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x33B15D8 Offset: 0x33AD5D8 VA: 0x33B15D8 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x33B1650 Offset: 0x33AD650 VA: 0x33B1650 Slot: 24
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x33B16C8 Offset: 0x33AD6C8 VA: 0x33B16C8 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x33B1740 Offset: 0x33AD740 VA: 0x33B1740 Slot: 57
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0x33B17BC Offset: 0x33AD7BC VA: 0x33B17BC Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x33B1858 Offset: 0x33AD858 VA: 0x33B1858 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33B190C Offset: 0x33AD90C VA: 0x33B190C Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x33B1974 Offset: 0x33AD974 VA: 0x33B1974 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x33B1A0C Offset: 0x33ADA0C VA: 0x33B1A0C Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x33B1A14 Offset: 0x33ADA14 VA: 0x33B1A14 Slot: 53
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0x33B1A68 Offset: 0x33ADA68 VA: 0x33B1A68 Slot: 54
	internal override string get_XmlLang() { }
}

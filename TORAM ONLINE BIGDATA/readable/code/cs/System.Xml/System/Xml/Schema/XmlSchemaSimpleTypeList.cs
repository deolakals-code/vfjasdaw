// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent // TypeDefIndex: 13826
{
	// Fields
	private XmlQualifiedName itemTypeName; // 0x50
	private XmlSchemaSimpleType itemType; // 0x58
	private XmlSchemaSimpleType baseItemType; // 0x60

	// Properties
	[Xml("itemType")]
	public XmlQualifiedName ItemTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType ItemType { get; set; }
	[XmlIgnore]
	public XmlSchemaSimpleType BaseItemType { get; set; }

	// Methods

	// RVA: 0x3343498 Offset: 0x333F498 VA: 0x3343498
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0x33434A0 Offset: 0x333F4A0 VA: 0x33434A0
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x3343540 Offset: 0x333F540 VA: 0x3343540
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x3343548 Offset: 0x333F548 VA: 0x3343548
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x3343550 Offset: 0x333F550 VA: 0x3343550
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x3343558 Offset: 0x333F558 VA: 0x3343558
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x3343560 Offset: 0x333F560 VA: 0x3343560 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x3343610 Offset: 0x333F610 VA: 0x3343610
	public void .ctor() { }
}

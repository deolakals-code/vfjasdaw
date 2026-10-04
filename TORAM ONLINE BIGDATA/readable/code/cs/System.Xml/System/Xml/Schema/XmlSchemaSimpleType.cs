// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaSimpleType : XmlSchemaType // TypeDefIndex: 13824
{
	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Properties
	[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
	[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
	[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
	public XmlSchemaSimpleTypeContent Content { get; set; }

	// Methods

	// RVA: 0x33432F0 Offset: 0x333F2F0 VA: 0x33432F0
	public void .ctor() { }

	// RVA: 0x3343374 Offset: 0x333F374 VA: 0x3343374
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x334337C Offset: 0x333F37C VA: 0x334337C
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0x3343384 Offset: 0x333F384 VA: 0x3343384 Slot: 13
	internal override XmlSchemaObject Clone() { }
}

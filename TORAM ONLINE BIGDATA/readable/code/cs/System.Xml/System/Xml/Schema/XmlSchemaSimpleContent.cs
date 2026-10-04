// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContent : XmlSchemaContentModel // TypeDefIndex: 13821
{
	// Fields
	private XmlSchemaContent content; // 0x50

	// Properties
	[XmlElement("restriction", typeof(XmlSchemaSimpleContentRestriction))]
	[XmlElement("extension", typeof(XmlSchemaSimpleContentExtension))]
	public override XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: 0x3342FB4 Offset: 0x333EFB4 VA: 0x3342FB4 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x3342FBC Offset: 0x333EFBC VA: 0x3342FBC Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x3342FC4 Offset: 0x333EFC4 VA: 0x3342FC4
	public void .ctor() { }
}

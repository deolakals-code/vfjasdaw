// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaDocumentation : XmlSchemaObject // TypeDefIndex: 13774
{
	// Fields
	private string source; // 0x38
	private string language; // 0x40
	private XmlNode[] markup; // 0x48
	private static XmlSchemaSimpleType languageType; // 0x0

	// Properties
	[Xml("source", DataType = "anyURI")]
	public string Source { set; }
	[Xml("xml:lang")]
	public string Language { set; }
	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup { set; }

	// Methods

	// RVA: 0x3336FA4 Offset: 0x3332FA4 VA: 0x3336FA4
	public void set_Source(string value) { }

	// RVA: 0x3336FAC Offset: 0x3332FAC VA: 0x3336FAC
	public void set_Language(string value) { }

	// RVA: 0x333708C Offset: 0x333308C VA: 0x333708C
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x3337094 Offset: 0x3333094 VA: 0x3337094
	public void .ctor() { }

	// RVA: 0x333709C Offset: 0x333309C VA: 0x333709C
	private static void .cctor() { }
}

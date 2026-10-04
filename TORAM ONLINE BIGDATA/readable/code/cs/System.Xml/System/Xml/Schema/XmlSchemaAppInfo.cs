// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaAppInfo : XmlSchemaObject // TypeDefIndex: 13755
{
	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Properties
	[Xml("source", DataType = "anyURI")]
	public string Source { set; }
	[XmlText]
	[XmlAnyElement]
	public XmlNode[] Markup { get; set; }

	// Methods

	// RVA: 0x333325C Offset: 0x332F25C VA: 0x333325C
	public void set_Source(string value) { }

	// RVA: 0x3333264 Offset: 0x332F264 VA: 0x3333264
	public XmlNode[] get_Markup() { }

	// RVA: 0x333326C Offset: 0x332F26C VA: 0x333326C
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x3333274 Offset: 0x332F274 VA: 0x3333274
	public void .ctor() { }
}

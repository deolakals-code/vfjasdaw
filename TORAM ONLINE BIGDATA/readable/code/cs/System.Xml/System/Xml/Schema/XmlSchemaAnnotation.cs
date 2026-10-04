// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaAnnotation : XmlSchemaObject // TypeDefIndex: 13752
{
	// Fields
	private string id; // 0x38
	private XmlSchemaObjectCollection items; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlElement("documentation", typeof(XmlSchemaDocumentation))]
	[XmlElement("appinfo", typeof(XmlSchemaAppInfo))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x333272C Offset: 0x332E72C VA: 0x333272C
	public string get_Id() { }

	// RVA: 0x3332734 Offset: 0x332E734 VA: 0x3332734
	public void set_Id(string value) { }

	// RVA: 0x333273C Offset: 0x332E73C VA: 0x333273C
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x3332744 Offset: 0x332E744 VA: 0x3332744 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x333274C Offset: 0x332E74C VA: 0x333274C Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x3332754 Offset: 0x332E754 VA: 0x3332754 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x333275C Offset: 0x332E75C VA: 0x333275C
	public void .ctor() { }
}

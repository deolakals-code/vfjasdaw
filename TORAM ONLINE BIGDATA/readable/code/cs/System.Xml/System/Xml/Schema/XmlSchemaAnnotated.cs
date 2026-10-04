// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaAnnotated : XmlSchemaObject // TypeDefIndex: 13751
{
	// Fields
	private string id; // 0x38
	private XmlSchemaAnnotation annotation; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	public XmlSchemaAnnotation Annotation { get; set; }
	[XmlAny]
	public XmlAttribute[] UnhandledAttributes { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x33326D4 Offset: 0x332E6D4 VA: 0x33326D4
	public string get_Id() { }

	// RVA: 0x33326DC Offset: 0x332E6DC VA: 0x33326DC
	public void set_Id(string value) { }

	// RVA: 0x33326E4 Offset: 0x332E6E4 VA: 0x33326E4
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x33326EC Offset: 0x332E6EC VA: 0x33326EC
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x33326F4 Offset: 0x332E6F4 VA: 0x33326F4
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x33326FC Offset: 0x332E6FC VA: 0x33326FC
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x3332704 Offset: 0x332E704 VA: 0x3332704 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x333270C Offset: 0x332E70C VA: 0x333270C Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x3332714 Offset: 0x332E714 VA: 0x3332714 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x333271C Offset: 0x332E71C VA: 0x333271C Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x3332724 Offset: 0x332E724 VA: 0x3332724
	public void .ctor() { }
}

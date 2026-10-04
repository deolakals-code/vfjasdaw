// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaNotation : XmlSchemaAnnotated // TypeDefIndex: 13805
{
	// Fields
	private string name; // 0x50
	private string publicId; // 0x58
	private string systemId; // 0x60
	private XmlQualifiedName qname; // 0x68

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[Xml("public")]
	public string Public { get; set; }
	[Xml("system")]
	public string System { get; set; }
	[XmlIgnore]
	internal XmlQualifiedName QualifiedName { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x33389A0 Offset: 0x33349A0 VA: 0x33389A0
	public string get_Name() { }

	// RVA: 0x33389A8 Offset: 0x33349A8 VA: 0x33389A8
	public void set_Name(string value) { }

	// RVA: 0x33389B0 Offset: 0x33349B0 VA: 0x33389B0
	public string get_Public() { }

	// RVA: 0x33389B8 Offset: 0x33349B8 VA: 0x33389B8
	public void set_Public(string value) { }

	// RVA: 0x33389C0 Offset: 0x33349C0 VA: 0x33389C0
	public string get_System() { }

	// RVA: 0x33389C8 Offset: 0x33349C8 VA: 0x33389C8
	public void set_System(string value) { }

	// RVA: 0x33389D0 Offset: 0x33349D0 VA: 0x33389D0
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x33389D8 Offset: 0x33349D8 VA: 0x33389D8
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x33389E0 Offset: 0x33349E0 VA: 0x33389E0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x33389E8 Offset: 0x33349E8 VA: 0x33389E8 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x33389F0 Offset: 0x33349F0 VA: 0x33389F0
	public void .ctor() { }
}

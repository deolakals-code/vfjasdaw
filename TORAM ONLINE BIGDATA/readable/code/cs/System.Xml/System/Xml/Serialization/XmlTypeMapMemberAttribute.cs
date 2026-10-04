// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAttribute : XmlTypeMapMember // TypeDefIndex: 13559
{
	// Fields
	private string _attributeName; // 0x58
	private string _namespace; // 0x60
	private XmlSchemaForm _form; // 0x68
	private XmlTypeMapping _mappedType; // 0x70

	// Properties
	public string AttributeName { get; set; }
	public string Namespace { get; set; }
	public XmlSchemaForm Form { set; }
	public XmlTypeMapping MappedType { get; set; }

	// Methods

	// RVA: 0x3410AA0 Offset: 0x340CAA0 VA: 0x3410AA0
	public void .ctor() { }

	// RVA: 0x3410AF4 Offset: 0x340CAF4 VA: 0x3410AF4
	public string get_AttributeName() { }

	// RVA: 0x3410AFC Offset: 0x340CAFC VA: 0x3410AFC
	public void set_AttributeName(string value) { }

	// RVA: 0x3410B04 Offset: 0x340CB04 VA: 0x3410B04
	public string get_Namespace() { }

	// RVA: 0x3410B0C Offset: 0x340CB0C VA: 0x3410B0C
	public void set_Namespace(string value) { }

	// RVA: 0x3410B14 Offset: 0x340CB14 VA: 0x3410B14
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x3410B1C Offset: 0x340CB1C VA: 0x3410B1C
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x3410B24 Offset: 0x340CB24 VA: 0x3410B24
	public void set_MappedType(XmlTypeMapping value) { }
}

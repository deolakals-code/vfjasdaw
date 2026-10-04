// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaAttribute : XmlSchemaAnnotated // TypeDefIndex: 13756
{
	// Fields
	private string defaultValue; // 0x50
	private string fixedValue; // 0x58
	private string name; // 0x60
	private XmlSchemaForm form; // 0x68
	private XmlSchemaUse use; // 0x6C
	private XmlQualifiedName refName; // 0x70
	private XmlQualifiedName typeName; // 0x78
	private XmlQualifiedName qualifiedName; // 0x80
	private XmlSchemaSimpleType type; // 0x88
	private XmlSchemaSimpleType attributeType; // 0x90
	private SchemaAttDef attDef; // 0x98

	// Properties
	[DefaultValue(null)]
	[Xml("default")]
	public string DefaultValue { get; set; }
	[Xml("fixed")]
	[DefaultValue(null)]
	public string FixedValue { get; set; }
	[Xml("form")]
	[DefaultValue(0)]
	public XmlSchemaForm Form { get; set; }
	[Xml("name")]
	public string Name { get; set; }
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[Xml("type")]
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElement("simpleType")]
	public XmlSchemaSimpleType SchemaType { get; set; }
	[DefaultValue(0)]
	[Xml("use")]
	public XmlSchemaUse Use { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaSimpleType AttributeSchemaType { get; }
	[XmlIgnore]
	internal XmlSchemaDatatype Datatype { get; }
	internal SchemaAttDef AttDef { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x333327C Offset: 0x332F27C VA: 0x333327C
	public string get_DefaultValue() { }

	// RVA: 0x3333284 Offset: 0x332F284 VA: 0x3333284
	public void set_DefaultValue(string value) { }

	// RVA: 0x333328C Offset: 0x332F28C VA: 0x333328C
	public string get_FixedValue() { }

	// RVA: 0x3333294 Offset: 0x332F294 VA: 0x3333294
	public void set_FixedValue(string value) { }

	// RVA: 0x333329C Offset: 0x332F29C VA: 0x333329C
	public XmlSchemaForm get_Form() { }

	// RVA: 0x33332A4 Offset: 0x332F2A4 VA: 0x33332A4
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x33332AC Offset: 0x332F2AC VA: 0x33332AC
	public string get_Name() { }

	// RVA: 0x33332B4 Offset: 0x332F2B4 VA: 0x33332B4
	public void set_Name(string value) { }

	// RVA: 0x33332BC Offset: 0x332F2BC VA: 0x33332BC
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x33332C4 Offset: 0x332F2C4 VA: 0x33332C4
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x3333364 Offset: 0x332F364 VA: 0x3333364
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x333336C Offset: 0x332F36C VA: 0x333336C
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x333340C Offset: 0x332F40C VA: 0x333340C
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x3333414 Offset: 0x332F414 VA: 0x3333414
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x333341C Offset: 0x332F41C VA: 0x333341C
	public XmlSchemaUse get_Use() { }

	// RVA: 0x3333424 Offset: 0x332F424 VA: 0x3333424
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x333342C Offset: 0x332F42C VA: 0x333342C
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x3333434 Offset: 0x332F434 VA: 0x3333434
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x333343C Offset: 0x332F43C VA: 0x333343C
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x3333454 Offset: 0x332F454 VA: 0x3333454
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x333345C Offset: 0x332F45C VA: 0x333345C
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x3333464 Offset: 0x332F464 VA: 0x3333464
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0x333346C Offset: 0x332F46C VA: 0x333346C
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x3333474 Offset: 0x332F474 VA: 0x3333474 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x333347C Offset: 0x332F47C VA: 0x333347C Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x3333484 Offset: 0x332F484 VA: 0x3333484 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x3333578 Offset: 0x332F578 VA: 0x3333578
	public void .ctor() { }
}

// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaElement : XmlSchemaParticle // TypeDefIndex: 13775
{
	// Fields
	private bool isAbstract; // 0x74
	private bool hasAbstractAttribute; // 0x75
	private bool isNillable; // 0x76
	private bool hasNillableAttribute; // 0x77
	private bool isLocalTypeDerivationChecked; // 0x78
	private XmlSchemaDerivationMethod block; // 0x7C
	private XmlSchemaDerivationMethod final; // 0x80
	private XmlSchemaForm form; // 0x84
	private string defaultValue; // 0x88
	private string fixedValue; // 0x90
	private string name; // 0x98
	private XmlQualifiedName refName; // 0xA0
	private XmlQualifiedName substitutionGroup; // 0xA8
	private XmlQualifiedName typeName; // 0xB0
	private XmlSchemaType type; // 0xB8
	private XmlQualifiedName qualifiedName; // 0xC0
	private XmlSchemaType elementType; // 0xC8
	private XmlSchemaDerivationMethod blockResolved; // 0xD0
	private XmlSchemaDerivationMethod finalResolved; // 0xD4
	private XmlSchemaObjectCollection constraints; // 0xD8
	private SchemaElementDecl elementDecl; // 0xE0

	// Properties
	[Xml("abstract")]
	[DefaultValue(False)]
	public bool IsAbstract { get; set; }
	[DefaultValue(256)]
	[Xml("block")]
	public XmlSchemaDerivationMethod Block { get; set; }
	[Xml("default")]
	[DefaultValue(null)]
	public string DefaultValue { get; set; }
	[DefaultValue(256)]
	[Xml("final")]
	public XmlSchemaDerivationMethod Final { get; set; }
	[DefaultValue(null)]
	[Xml("fixed")]
	public string FixedValue { get; set; }
	[DefaultValue(0)]
	[Xml("form")]
	public XmlSchemaForm Form { get; set; }
	[DefaultValue("")]
	[Xml("name")]
	public string Name { get; set; }
	[Xml("nillable")]
	[DefaultValue(False)]
	public bool IsNillable { get; set; }
	[XmlIgnore]
	internal bool HasNillableAttribute { get; }
	[XmlIgnore]
	internal bool HasAbstractAttribute { get; }
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[Xml("substitutionGroup")]
	public XmlQualifiedName SubstitutionGroup { get; set; }
	[Xml("type")]
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	public XmlSchemaType SchemaType { get; set; }
	[XmlElement("keyref", typeof(XmlSchemaKeyref))]
	[XmlElement("unique", typeof(XmlSchemaUnique))]
	[XmlElement("key", typeof(XmlSchemaKey))]
	public XmlSchemaObjectCollection Constraints { get; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaType ElementSchemaType { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved { get; }
	internal bool HasConstraints { get; }
	internal bool IsLocalTypeDerivationChecked { get; set; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }
	[XmlIgnore]
	internal override string NameString { get; }

	// Methods

	// RVA: 0x3337180 Offset: 0x3333180 VA: 0x3337180
	public bool get_IsAbstract() { }

	// RVA: 0x3337188 Offset: 0x3333188 VA: 0x3337188
	public void set_IsAbstract(bool value) { }

	// RVA: 0x333719C Offset: 0x333319C VA: 0x333719C
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x33371A4 Offset: 0x33331A4 VA: 0x33371A4
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x33371AC Offset: 0x33331AC VA: 0x33371AC
	public string get_DefaultValue() { }

	// RVA: 0x33371B4 Offset: 0x33331B4 VA: 0x33371B4
	public void set_DefaultValue(string value) { }

	// RVA: 0x33371BC Offset: 0x33331BC VA: 0x33371BC
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x33371C4 Offset: 0x33331C4 VA: 0x33371C4
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x33371CC Offset: 0x33331CC VA: 0x33371CC
	public string get_FixedValue() { }

	// RVA: 0x33371D4 Offset: 0x33331D4 VA: 0x33371D4
	public void set_FixedValue(string value) { }

	// RVA: 0x33371DC Offset: 0x33331DC VA: 0x33371DC
	public XmlSchemaForm get_Form() { }

	// RVA: 0x33371E4 Offset: 0x33331E4 VA: 0x33371E4
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x33371EC Offset: 0x33331EC VA: 0x33371EC
	public string get_Name() { }

	// RVA: 0x33371F4 Offset: 0x33331F4 VA: 0x33371F4
	public void set_Name(string value) { }

	// RVA: 0x33371FC Offset: 0x33331FC VA: 0x33371FC
	public bool get_IsNillable() { }

	// RVA: 0x3337204 Offset: 0x3333204 VA: 0x3337204
	public void set_IsNillable(bool value) { }

	// RVA: 0x3337218 Offset: 0x3333218 VA: 0x3337218
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x3337220 Offset: 0x3333220 VA: 0x3337220
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x3337228 Offset: 0x3333228 VA: 0x3337228
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x3337230 Offset: 0x3333230 VA: 0x3337230
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x33372D0 Offset: 0x33332D0 VA: 0x33372D0
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x33372D8 Offset: 0x33332D8 VA: 0x33372D8
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x3337378 Offset: 0x3333378 VA: 0x3337378
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x3337380 Offset: 0x3333380 VA: 0x3337380
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x3337420 Offset: 0x3333420 VA: 0x3337420
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x3337428 Offset: 0x3333428 VA: 0x3337428
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x3337430 Offset: 0x3333430 VA: 0x3337430
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0x33374A0 Offset: 0x33334A0 VA: 0x33374A0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x33374A8 Offset: 0x33334A8 VA: 0x33374A8
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x33374B0 Offset: 0x33334B0 VA: 0x33374B0
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x33374B8 Offset: 0x33334B8 VA: 0x33374B8
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x33374C0 Offset: 0x33334C0 VA: 0x33374C0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x33374C8 Offset: 0x33334C8 VA: 0x33374C8
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x33374D0 Offset: 0x33334D0 VA: 0x33374D0
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x33374D8 Offset: 0x33334D8 VA: 0x33374D8
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x33374E0 Offset: 0x33334E0 VA: 0x33374E0
	internal bool get_HasConstraints() { }

	// RVA: 0x3337504 Offset: 0x3333504 VA: 0x3337504
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x333750C Offset: 0x333350C VA: 0x333750C
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x3337518 Offset: 0x3333518 VA: 0x3337518
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x3337520 Offset: 0x3333520 VA: 0x3337520
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x3337528 Offset: 0x3333528 VA: 0x3337528 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x3337530 Offset: 0x3333530 VA: 0x3337530 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x3337538 Offset: 0x3333538 VA: 0x3337538 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x3337558 Offset: 0x3333558 VA: 0x3337558 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x3331DF4 Offset: 0x332DDF4 VA: 0x3331DF4
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x3337560 Offset: 0x3333560 VA: 0x3337560
	public void .ctor() { }
}

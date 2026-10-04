// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaType : XmlSchemaAnnotated // TypeDefIndex: 13831
{
	// Fields
	private string name; // 0x50
	private XmlSchemaDerivationMethod final; // 0x58
	private XmlSchemaDerivationMethod derivedBy; // 0x5C
	private XmlSchemaType baseSchemaType; // 0x60
	private XmlSchemaDatatype datatype; // 0x68
	private XmlSchemaDerivationMethod finalResolved; // 0x70
	private SchemaElementDecl elementDecl; // 0x78
	private XmlQualifiedName qname; // 0x80
	private XmlSchemaType redefined; // 0x88
	private XmlSchemaContentType contentType; // 0x90

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[Xml("final")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod Final { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved { get; }
	[XmlIgnore]
	public XmlSchemaType BaseXmlSchemaType { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod DerivedBy { get; }
	[XmlIgnore]
	public XmlSchemaDatatype Datatype { get; }
	[XmlIgnore]
	public virtual bool IsMixed { get; set; }
	[XmlIgnore]
	public XmlTypeCode TypeCode { get; }
	[XmlIgnore]
	internal XmlValueConverter ValueConverter { get; }
	internal XmlSchemaContentType SchemaContentType { get; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnore]
	internal XmlSchemaType Redefined { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x3343BE4 Offset: 0x333FBE4 VA: 0x3343BE4
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x3343CBC Offset: 0x333FCBC VA: 0x3343CBC
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0x3343D14 Offset: 0x333FD14 VA: 0x3343D14
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x3343F5C Offset: 0x333FF5C VA: 0x3343F5C
	public string get_Name() { }

	// RVA: 0x3343F64 Offset: 0x333FF64 VA: 0x3343F64
	public void set_Name(string value) { }

	// RVA: 0x3343F6C Offset: 0x333FF6C VA: 0x3343F6C
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x3343F74 Offset: 0x333FF74 VA: 0x3343F74
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x3342DB8 Offset: 0x333EDB8 VA: 0x3342DB8
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x3343F7C Offset: 0x333FF7C VA: 0x3343F7C
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x3343F84 Offset: 0x333FF84 VA: 0x3343F84
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x3343F8C Offset: 0x333FF8C VA: 0x3343F8C
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x3343F94 Offset: 0x333FF94 VA: 0x3343F94
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x3343F9C Offset: 0x333FF9C VA: 0x3343F9C Slot: 14
	public virtual bool get_IsMixed() { }

	// RVA: 0x3343FA4 Offset: 0x333FFA4 VA: 0x3343FA4 Slot: 15
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0x3343FA8 Offset: 0x333FFA8 VA: 0x3343FA8
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0x334405C Offset: 0x334005C VA: 0x334405C
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0x33440D4 Offset: 0x33400D4 VA: 0x33440D4
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0x33440DC Offset: 0x33400DC VA: 0x33440DC
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x3344108 Offset: 0x3340108 VA: 0x3344108
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x3344110 Offset: 0x3340110 VA: 0x3344110
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x3344118 Offset: 0x3340118 VA: 0x3344118
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x3344120 Offset: 0x3340120 VA: 0x3344120
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0x3344128 Offset: 0x3340128 VA: 0x3344128
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x3344140 Offset: 0x3340140 VA: 0x3344140
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x334416C Offset: 0x334016C VA: 0x334416C
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x3344174 Offset: 0x3340174 VA: 0x3344174
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0x334417C Offset: 0x334017C VA: 0x334417C
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0x3344184 Offset: 0x3340184 VA: 0x3344184
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x334437C Offset: 0x334037C VA: 0x334437C
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x3344450 Offset: 0x3340450 VA: 0x3344450 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x3344458 Offset: 0x3340458 VA: 0x3344458 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x33432F4 Offset: 0x333F2F4 VA: 0x33432F4
	public void .ctor() { }
}

// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class SchemaCollectionPreprocessor : BaseProcessor // TypeDefIndex: 13717
{
	// Fields
	private XmlSchema schema; // 0x40
	private string targetNamespace; // 0x48
	private bool buildinIncluded; // 0x50
	private XmlSchemaForm elementFormDefault; // 0x54
	private XmlSchemaForm attributeFormDefault; // 0x58
	private XmlSchemaDerivationMethod blockDefault; // 0x5C
	private XmlSchemaDerivationMethod finalDefault; // 0x60
	private Hashtable schemaLocations; // 0x68
	private Hashtable referenceNamespaces; // 0x70
	private string Xmlns; // 0x78
	private XmlResolver xmlResolver; // 0x80

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0x33000A4 Offset: 0x32FC0A4 VA: 0x33000A4
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x33000AC Offset: 0x32FC0AC VA: 0x33000AC
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0x33002F8 Offset: 0x32FC2F8 VA: 0x33002F8
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x33036D8 Offset: 0x32FF6D8 VA: 0x33036D8
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x3300514 Offset: 0x32FC514 VA: 0x3300514
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0x33038A0 Offset: 0x32FF8A0 VA: 0x33038A0
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x3301164 Offset: 0x32FD164 VA: 0x3301164
	private void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor) { }

	// RVA: 0x3303BBC Offset: 0x32FFBBC VA: 0x3303BBC
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0x3306B68 Offset: 0x3302B68 VA: 0x3306B68
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0x3306548 Offset: 0x3302548 VA: 0x3306548
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x33065E0 Offset: 0x33025E0 VA: 0x33065E0
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x3306A5C Offset: 0x3302A5C VA: 0x3306A5C
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x3306748 Offset: 0x3302748 VA: 0x3306748
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x3304D60 Offset: 0x3300D60 VA: 0x3304D60
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x3307340 Offset: 0x3303340 VA: 0x3307340
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x3307100 Offset: 0x3303100 VA: 0x3307100
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x3304ED0 Offset: 0x3300ED0 VA: 0x3304ED0
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x3305E7C Offset: 0x3301E7C VA: 0x3305E7C
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x3307D30 Offset: 0x3303D30 VA: 0x3307D30
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x33079D8 Offset: 0x33039D8 VA: 0x33079D8
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x33080CC Offset: 0x33040CC VA: 0x33080CC
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x3305890 Offset: 0x3301890 VA: 0x3305890
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x3304FD0 Offset: 0x3300FD0 VA: 0x3304FD0
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x33060D0 Offset: 0x33020D0 VA: 0x33060D0
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x330629C Offset: 0x330229C VA: 0x330629C
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x3308428 Offset: 0x3304428 VA: 0x3308428
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x33076B0 Offset: 0x33036B0 VA: 0x33076B0
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x3300F08 Offset: 0x32FCF08 VA: 0x3300F08
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x3306E34 Offset: 0x3302E34 VA: 0x3306E34
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x3307528 Offset: 0x3303528 VA: 0x3307528
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x3303AB0 Offset: 0x32FFAB0 VA: 0x3303AB0
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x3303AD0 Offset: 0x32FFAD0 VA: 0x3303AD0
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x33036E0 Offset: 0x32FF6E0 VA: 0x33036E0
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x330378C Offset: 0x32FF78C VA: 0x330378C
	private Stream GetSchemaEntity(Uri ruri) { }
}

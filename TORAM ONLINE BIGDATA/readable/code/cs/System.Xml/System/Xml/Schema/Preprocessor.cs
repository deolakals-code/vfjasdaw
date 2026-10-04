// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class Preprocessor : BaseProcessor // TypeDefIndex: 13711
{
	// Fields
	private string Xmlns; // 0x40
	private string NsXsi; // 0x48
	private string targetNamespace; // 0x50
	private XmlSchema rootSchema; // 0x58
	private XmlSchema currentSchema; // 0x60
	private XmlSchemaForm elementFormDefault; // 0x68
	private XmlSchemaForm attributeFormDefault; // 0x6C
	private XmlSchemaDerivationMethod blockDefault; // 0x70
	private XmlSchemaDerivationMethod finalDefault; // 0x74
	private Hashtable schemaLocations; // 0x78
	private Hashtable chameleonSchemas; // 0x80
	private Hashtable referenceNamespaces; // 0x88
	private Hashtable processedExternals; // 0x90
	private SortedList lockList; // 0x98
	private XmlReaderSettings readerSettings; // 0xA0
	private XmlSchema rootSchemaForRedefine; // 0xA8
	private ArrayList redefinedList; // 0xB0
	private static XmlSchema builtInSchemaForXmlNS; // 0x0
	private XmlResolver xmlResolver; // 0xB8

	// Properties
	internal XmlResolver XmlResolver { set; }
	internal XmlReaderSettings ReaderSettings { set; }
	internal Hashtable SchemaLocations { set; }
	internal Hashtable ChameleonSchemas { set; }
	internal XmlSchema RootSchema { get; }

	// Methods

	// RVA: 0x32E5008 Offset: 0x32E1008 VA: 0x32E5008
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x32E5108 Offset: 0x32E1108 VA: 0x32E5108
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0x32E83A8 Offset: 0x32E43A8 VA: 0x32E83A8
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x32E8A7C Offset: 0x32E4A7C VA: 0x32E8A7C
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0x32E8B1C Offset: 0x32E4B1C VA: 0x32E8B1C
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x32E8B24 Offset: 0x32E4B24 VA: 0x32E8B24
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x32E8B2C Offset: 0x32E4B2C VA: 0x32E8B2C
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x32E8B34 Offset: 0x32E4B34 VA: 0x32E8B34
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x32E8B3C Offset: 0x32E4B3C VA: 0x32E8B3C
	internal XmlSchema get_RootSchema() { }

	// RVA: 0x32E6408 Offset: 0x32E2408 VA: 0x32E6408
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0x32E574C Offset: 0x32E174C VA: 0x32E574C
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0x32E847C Offset: 0x32E447C VA: 0x32E847C
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0x32E8BAC Offset: 0x32E4BAC VA: 0x32E8BAC
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x32E8DCC Offset: 0x32E4DCC VA: 0x32E8DCC
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0x32E6580 Offset: 0x32E2580 VA: 0x32E6580
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0x32E93F8 Offset: 0x32E53F8 VA: 0x32E93F8
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0x32E7838 Offset: 0x32E3838 VA: 0x32E7838
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0x32EBF68 Offset: 0x32E7F68 VA: 0x32EBF68
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0x32EBED4 Offset: 0x32E7ED4 VA: 0x32EBED4
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0x32E92EC Offset: 0x32E52EC VA: 0x32E92EC
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0x32EC6AC Offset: 0x32E86AC VA: 0x32EC6AC
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0x32EC094 Offset: 0x32E8094 VA: 0x32EC094
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x32EC134 Offset: 0x32E8134 VA: 0x32EC134
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x32EC5A0 Offset: 0x32E85A0 VA: 0x32EC5A0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x32EC28C Offset: 0x32E828C VA: 0x32EC28C
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x32EA6BC Offset: 0x32E66BC VA: 0x32EA6BC
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x32ECE98 Offset: 0x32E8E98 VA: 0x32ECE98
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x32ECC68 Offset: 0x32E8C68 VA: 0x32ECC68
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x32EA82C Offset: 0x32E682C VA: 0x32EA82C
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x32EB7D0 Offset: 0x32E77D0 VA: 0x32EB7D0
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x32ED980 Offset: 0x32E9980 VA: 0x32ED980
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x32ED648 Offset: 0x32E9648 VA: 0x32ED648
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x32EDD20 Offset: 0x32E9D20 VA: 0x32EDD20
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x32EB1FC Offset: 0x32E71FC VA: 0x32EB1FC
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x32EA930 Offset: 0x32E6930 VA: 0x32EA930
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x32EBA24 Offset: 0x32E7A24 VA: 0x32EBA24
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x32EBBF4 Offset: 0x32E7BF4 VA: 0x32EBBF4
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x32EE080 Offset: 0x32EA080 VA: 0x32EE080
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x32ED2C0 Offset: 0x32E92C0 VA: 0x32ED2C0
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x32E8FE0 Offset: 0x32E4FE0 VA: 0x32E8FE0
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x32EC99C Offset: 0x32E899C VA: 0x32EC99C
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x32ED084 Offset: 0x32E9084 VA: 0x32ED084
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x32E8B44 Offset: 0x32E4B44 VA: 0x32E8B44
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x32E8B84 Offset: 0x32E4B84 VA: 0x32E8B84
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0x32E560C Offset: 0x32E160C VA: 0x32E560C
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x32E8F20 Offset: 0x32E4F20 VA: 0x32E8F20
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x32E8F40 Offset: 0x32E4F40 VA: 0x32E8F40
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x32EBE5C Offset: 0x32E7E5C VA: 0x32EBE5C
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }
}

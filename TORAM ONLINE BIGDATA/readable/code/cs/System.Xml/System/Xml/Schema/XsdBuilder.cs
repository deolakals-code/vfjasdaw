// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class XsdBuilder : SchemaBuilder // TypeDefIndex: 13862
{
	// Fields
	private static readonly XsdBuilder.State[] SchemaElement; // 0x0
	private static readonly XsdBuilder.State[] SchemaSubelements; // 0x8
	private static readonly XsdBuilder.State[] AttributeSubelements; // 0x10
	private static readonly XsdBuilder.State[] ElementSubelements; // 0x18
	private static readonly XsdBuilder.State[] ComplexTypeSubelements; // 0x20
	private static readonly XsdBuilder.State[] SimpleContentSubelements; // 0x28
	private static readonly XsdBuilder.State[] SimpleContentExtensionSubelements; // 0x30
	private static readonly XsdBuilder.State[] SimpleContentRestrictionSubelements; // 0x38
	private static readonly XsdBuilder.State[] ComplexContentSubelements; // 0x40
	private static readonly XsdBuilder.State[] ComplexContentExtensionSubelements; // 0x48
	private static readonly XsdBuilder.State[] ComplexContentRestrictionSubelements; // 0x50
	private static readonly XsdBuilder.State[] SimpleTypeSubelements; // 0x58
	private static readonly XsdBuilder.State[] SimpleTypeRestrictionSubelements; // 0x60
	private static readonly XsdBuilder.State[] SimpleTypeListSubelements; // 0x68
	private static readonly XsdBuilder.State[] SimpleTypeUnionSubelements; // 0x70
	private static readonly XsdBuilder.State[] RedefineSubelements; // 0x78
	private static readonly XsdBuilder.State[] AttributeGroupSubelements; // 0x80
	private static readonly XsdBuilder.State[] GroupSubelements; // 0x88
	private static readonly XsdBuilder.State[] AllSubelements; // 0x90
	private static readonly XsdBuilder.State[] ChoiceSequenceSubelements; // 0x98
	private static readonly XsdBuilder.State[] IdentityConstraintSubelements; // 0xA0
	private static readonly XsdBuilder.State[] AnnotationSubelements; // 0xA8
	private static readonly XsdBuilder.State[] AnnotatedSubelements; // 0xB0
	private static readonly XsdBuilder.XsdAttributeEntry[] SchemaAttributes; // 0xB8
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeAttributes; // 0xC0
	private static readonly XsdBuilder.XsdAttributeEntry[] ElementAttributes; // 0xC8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes; // 0xD0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes; // 0xD8
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes; // 0xE0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes; // 0xE8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes; // 0xF0
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes; // 0xF8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes; // 0x100
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes; // 0x108
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes; // 0x110
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes; // 0x118
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes; // 0x120
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes; // 0x128
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes; // 0x130
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupAttributes; // 0x138
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupRefAttributes; // 0x140
	private static readonly XsdBuilder.XsdAttributeEntry[] ParticleAttributes; // 0x148
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributes; // 0x150
	private static readonly XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes; // 0x158
	private static readonly XsdBuilder.XsdAttributeEntry[] SelectorAttributes; // 0x160
	private static readonly XsdBuilder.XsdAttributeEntry[] FieldAttributes; // 0x168
	private static readonly XsdBuilder.XsdAttributeEntry[] NotationAttributes; // 0x170
	private static readonly XsdBuilder.XsdAttributeEntry[] IncludeAttributes; // 0x178
	private static readonly XsdBuilder.XsdAttributeEntry[] ImportAttributes; // 0x180
	private static readonly XsdBuilder.XsdAttributeEntry[] FacetAttributes; // 0x188
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes; // 0x190
	private static readonly XsdBuilder.XsdAttributeEntry[] DocumentationAttributes; // 0x198
	private static readonly XsdBuilder.XsdAttributeEntry[] AppinfoAttributes; // 0x1A0
	private static readonly XsdBuilder.XsdAttributeEntry[] RedefineAttributes; // 0x1A8
	private static readonly XsdBuilder.XsdAttributeEntry[] AnnotationAttributes; // 0x1B0
	private static readonly XsdBuilder.XsdEntry[] SchemaEntries; // 0x1B8
	private static readonly int[] DerivationMethodValues; // 0x1C0
	private static readonly string[] DerivationMethodStrings; // 0x1C8
	private static readonly string[] FormStringValues; // 0x1D0
	private static readonly string[] UseStringValues; // 0x1D8
	private static readonly string[] ProcessContentsStringValues; // 0x1E0
	private XmlReader reader; // 0x10
	private PositionInfo positionInfo; // 0x18
	private XsdBuilder.XsdEntry currentEntry; // 0x20
	private XsdBuilder.XsdEntry nextEntry; // 0x28
	private bool hasChild; // 0x30
	private HWStack stateHistory; // 0x38
	private Stack containerStack; // 0x40
	private XmlNameTable nameTable; // 0x48
	private SchemaNames schemaNames; // 0x50
	private XmlNamespaceManager namespaceManager; // 0x58
	private bool canIncludeImport; // 0x60
	private XmlSchema schema; // 0x68
	private XmlSchemaObject xso; // 0x70
	private XmlSchemaElement element; // 0x78
	private XmlSchemaAny anyElement; // 0x80
	private XmlSchemaAttribute attribute; // 0x88
	private XmlSchemaAnyAttribute anyAttribute; // 0x90
	private XmlSchemaComplexType complexType; // 0x98
	private XmlSchemaSimpleType simpleType; // 0xA0
	private XmlSchemaComplexContent complexContent; // 0xA8
	private XmlSchemaComplexContentExtension complexContentExtension; // 0xB0
	private XmlSchemaComplexContentRestriction complexContentRestriction; // 0xB8
	private XmlSchemaSimpleContent simpleContent; // 0xC0
	private XmlSchemaSimpleContentExtension simpleContentExtension; // 0xC8
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; // 0xD0
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; // 0xD8
	private XmlSchemaSimpleTypeList simpleTypeList; // 0xE0
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; // 0xE8
	private XmlSchemaGroup group; // 0xF0
	private XmlSchemaGroupRef groupRef; // 0xF8
	private XmlSchemaAll all; // 0x100
	private XmlSchemaChoice choice; // 0x108
	private XmlSchemaSequence sequence; // 0x110
	private XmlSchemaParticle particle; // 0x118
	private XmlSchemaAttributeGroup attributeGroup; // 0x120
	private XmlSchemaAttributeGroupRef attributeGroupRef; // 0x128
	private XmlSchemaNotation notation; // 0x130
	private XmlSchemaIdentityConstraint identityConstraint; // 0x138
	private XmlSchemaXPath xpath; // 0x140
	private XmlSchemaInclude include; // 0x148
	private XmlSchemaImport import; // 0x150
	private XmlSchemaAnnotation annotation; // 0x158
	private XmlSchemaAppInfo appInfo; // 0x160
	private XmlSchemaDocumentation documentation; // 0x168
	private XmlSchemaFacet facet; // 0x170
	private XmlNode[] markup; // 0x178
	private XmlSchemaRedefine redefine; // 0x180
	private ValidationEventHandler validationEventHandler; // 0x188
	private ArrayList unhandledAttributes; // 0x190
	private Hashtable namespaces; // 0x198

	// Properties
	private SchemaNames.Token CurrentElement { get; }
	private SchemaNames.Token ParentElement { get; }
	private XmlSchemaObject ParentContainer { get; }

	// Methods

	// RVA: 0x336C6B8 Offset: 0x33686B8 VA: 0x336C6B8
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x336C914 Offset: 0x3368914 VA: 0x336C914 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x336CE14 Offset: 0x3368E14 VA: 0x336CE14 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x336D398 Offset: 0x3369398 VA: 0x336D398 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0x336D3B4 Offset: 0x33693B4 VA: 0x336D3B4 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x336D3C4 Offset: 0x33693C4 VA: 0x336D3C4 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0x336D41C Offset: 0x336941C VA: 0x336D41C Slot: 9
	internal override void StartChildren() { }

	// RVA: 0x336D5B4 Offset: 0x33695B4 VA: 0x336D5B4 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0x336CBA0 Offset: 0x3368BA0 VA: 0x336CBA0
	private void Push() { }

	// RVA: 0x336D5F0 Offset: 0x33695F0 VA: 0x336D5F0
	private void Pop() { }

	// RVA: 0x336E578 Offset: 0x336A578 VA: 0x336E578
	private SchemaNames.Token get_CurrentElement() { }

	// RVA: 0x336E594 Offset: 0x336A594 VA: 0x336E594
	private SchemaNames.Token get_ParentElement() { }

	// RVA: 0x336E60C Offset: 0x336A60C VA: 0x336E60C
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0x336D6C8 Offset: 0x33696C8 VA: 0x336D6C8
	private XmlSchemaObject GetContainer(XsdBuilder.State state) { }

	// RVA: 0x336D800 Offset: 0x3369800 VA: 0x336D800
	private void SetContainer(XsdBuilder.State state, object container) { }

	// RVA: 0x336E69C Offset: 0x336A69C VA: 0x336E69C
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0x336E6C0 Offset: 0x336A6C0 VA: 0x336E6C0
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x336E834 Offset: 0x336A834 VA: 0x336E834
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x336E8D4 Offset: 0x336A8D4 VA: 0x336E8D4
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0x336E8F4 Offset: 0x336A8F4 VA: 0x336E8F4
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0x336E914 Offset: 0x336A914 VA: 0x336E914
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0x336EBD0 Offset: 0x336ABD0 VA: 0x336EBD0
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0x336EC38 Offset: 0x336AC38 VA: 0x336EC38
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0x336EC5C Offset: 0x336AC5C VA: 0x336EC5C
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0x336ED20 Offset: 0x336AD20 VA: 0x336ED20
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x336ED40 Offset: 0x336AD40 VA: 0x336ED40
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0x336EE04 Offset: 0x336AE04 VA: 0x336EE04
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x336EE24 Offset: 0x336AE24 VA: 0x336EE24
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x336EE44 Offset: 0x336AE44 VA: 0x336EE44
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0x336EF08 Offset: 0x336AF08 VA: 0x336EF08
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x336EF28 Offset: 0x336AF28 VA: 0x336EF28
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0x336EF44 Offset: 0x336AF44 VA: 0x336EF44
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x336F234 Offset: 0x336B234 VA: 0x336F234
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0x336F254 Offset: 0x336B254 VA: 0x336F254
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x336F274 Offset: 0x336B274 VA: 0x336F274
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0x336F314 Offset: 0x336B314 VA: 0x336F314
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0x336F3B4 Offset: 0x336B3B4 VA: 0x336F3B4
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x336F588 Offset: 0x336B588 VA: 0x336F588
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0x336F5A8 Offset: 0x336B5A8 VA: 0x336F5A8
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0x336F618 Offset: 0x336B618 VA: 0x336F618
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0x336F728 Offset: 0x336B728 VA: 0x336F728
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x336F8A4 Offset: 0x336B8A4 VA: 0x336F8A4
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0x336F90C Offset: 0x336B90C VA: 0x336F90C
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0x336F92C Offset: 0x336B92C VA: 0x336F92C
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0x336F9CC Offset: 0x336B9CC VA: 0x336F9CC
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0x336FA3C Offset: 0x336BA3C VA: 0x336FA3C
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0x336FAA4 Offset: 0x336BAA4 VA: 0x336FAA4
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x336FAC4 Offset: 0x336BAC4 VA: 0x336FAC4
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x336FBA0 Offset: 0x336BBA0 VA: 0x336FBA0
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x336FC7C Offset: 0x336BC7C VA: 0x336FC7C
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0x336FC9C Offset: 0x336BC9C VA: 0x336FC9C
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0x336FD0C Offset: 0x336BD0C VA: 0x336FD0C
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x336FD7C Offset: 0x336BD7C VA: 0x336FD7C
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0x336FDEC Offset: 0x336BDEC VA: 0x336FDEC
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0x3370118 Offset: 0x336C118 VA: 0x3370118
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x3370138 Offset: 0x336C138 VA: 0x3370138
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x33701A0 Offset: 0x336C1A0 VA: 0x33701A0
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0x3370264 Offset: 0x336C264 VA: 0x3370264
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0x3370454 Offset: 0x336C454 VA: 0x3370454
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0x3370518 Offset: 0x336C518 VA: 0x3370518
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0x3370588 Offset: 0x336C588 VA: 0x3370588
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x337064C Offset: 0x336C64C VA: 0x337064C
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x33706BC Offset: 0x336C6BC VA: 0x33706BC
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0x3370840 Offset: 0x336C840 VA: 0x3370840
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x33708B0 Offset: 0x336C8B0 VA: 0x33708B0
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0x3370918 Offset: 0x336C918 VA: 0x3370918
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x3370980 Offset: 0x336C980 VA: 0x3370980
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x33709F8 Offset: 0x336C9F8 VA: 0x33709F8
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x3370A18 Offset: 0x336CA18 VA: 0x3370A18
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0x3370B20 Offset: 0x336CB20 VA: 0x3370B20
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x3370B90 Offset: 0x336CB90 VA: 0x3370B90
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x3370C7C Offset: 0x336CC7C VA: 0x3370C7C
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x3370CEC Offset: 0x336CCEC VA: 0x3370CEC
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x3370D84 Offset: 0x336CD84 VA: 0x3370D84
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x3370DF4 Offset: 0x336CDF4 VA: 0x3370DF4
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0x3370EFC Offset: 0x336CEFC VA: 0x3370EFC
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x3370FE8 Offset: 0x336CFE8 VA: 0x3370FE8
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x3371058 Offset: 0x336D058 VA: 0x3371058
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x3371144 Offset: 0x336D144 VA: 0x3371144
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x33711B4 Offset: 0x336D1B4 VA: 0x33711B4
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0x3371288 Offset: 0x336D288 VA: 0x3371288
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x33712A8 Offset: 0x336D2A8 VA: 0x33712A8
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x337132C Offset: 0x336D32C VA: 0x337132C
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x337139C Offset: 0x336D39C VA: 0x337139C
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x337163C Offset: 0x336D63C VA: 0x337163C
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x337165C Offset: 0x336D65C VA: 0x337165C
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x33716FC Offset: 0x336D6FC VA: 0x33716FC
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0x33717D0 Offset: 0x336D7D0 VA: 0x33717D0
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x33717F0 Offset: 0x336D7F0 VA: 0x33717F0
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x3371B70 Offset: 0x336DB70 VA: 0x3371B70
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x3371B8C Offset: 0x336DB8C VA: 0x3371B8C
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x3371BA8 Offset: 0x336DBA8 VA: 0x3371BA8
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x3371C18 Offset: 0x336DC18 VA: 0x3371C18
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0x3371CAC Offset: 0x336DCAC VA: 0x3371CAC
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0x3371D40 Offset: 0x336DD40 VA: 0x3371D40
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0x3371DD4 Offset: 0x336DDD4 VA: 0x3371DD4
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0x3371E6C Offset: 0x336DE6C VA: 0x3371E6C
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x3371E8C Offset: 0x336DE8C VA: 0x3371E8C
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x3371F2C Offset: 0x336DF2C VA: 0x3371F2C
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0x3371FC8 Offset: 0x336DFC8 VA: 0x3371FC8
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0x3371FE8 Offset: 0x336DFE8 VA: 0x3371FE8
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0x3372008 Offset: 0x336E008 VA: 0x3372008
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0x3372028 Offset: 0x336E028 VA: 0x3372028
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0x337233C Offset: 0x336E33C VA: 0x337233C
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x33723B4 Offset: 0x336E3B4 VA: 0x33723B4
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0x33723D4 Offset: 0x336E3D4 VA: 0x33723D4
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0x3372528 Offset: 0x336E528 VA: 0x3372528
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0x3372548 Offset: 0x336E548 VA: 0x3372548
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0x3372668 Offset: 0x336E668 VA: 0x3372668
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0x3372740 Offset: 0x336E740 VA: 0x3372740
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x3372760 Offset: 0x336E760 VA: 0x3372760
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0x3372838 Offset: 0x336E838 VA: 0x3372838
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x3372858 Offset: 0x336E858 VA: 0x3372858
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0x337293C Offset: 0x336E93C VA: 0x337293C
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0x3372A04 Offset: 0x336EA04 VA: 0x3372A04
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0x3372A78 Offset: 0x336EA78 VA: 0x3372A78
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0x3372AA0 Offset: 0x336EAA0 VA: 0x3372AA0
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0x3372B68 Offset: 0x336EB68 VA: 0x3372B68
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0x3372BD8 Offset: 0x336EBD8 VA: 0x3372BD8
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0x3372D18 Offset: 0x336ED18 VA: 0x3372D18
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0x336F004 Offset: 0x336B004 VA: 0x336F004
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0x3371888 Offset: 0x336D888 VA: 0x3371888
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0x336CA3C Offset: 0x3368A3C VA: 0x336CA3C
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x336CD04 Offset: 0x3368D04 VA: 0x336CD04
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x336FBBC Offset: 0x336BBBC VA: 0x336FBBC
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x336FAE0 Offset: 0x336BAE0 VA: 0x336FAE0
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x336F798 Offset: 0x336B798 VA: 0x336F798
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0x336E760 Offset: 0x336A760 VA: 0x336E760
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0x336F424 Offset: 0x336B424 VA: 0x336F424
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0x336E97C Offset: 0x336A97C VA: 0x336E97C
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x3372A74 Offset: 0x336EA74 VA: 0x3372A74
	private static string ParseUriReference(string s) { }

	// RVA: 0x3372D40 Offset: 0x336ED40 VA: 0x3372D40
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0x336CD2C Offset: 0x3368D2C VA: 0x336CD2C
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x336D2A4 Offset: 0x33692A4 VA: 0x336D2A4
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x3372EB4 Offset: 0x336EEB4 VA: 0x3372EB4
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x337044C Offset: 0x336C44C VA: 0x337044C
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x336CC48 Offset: 0x3368C48 VA: 0x336CC48
	private void RecordPosition() { }

	// RVA: 0x3372F90 Offset: 0x336EF90 VA: 0x3372F90
	private static void .cctor() { }
}

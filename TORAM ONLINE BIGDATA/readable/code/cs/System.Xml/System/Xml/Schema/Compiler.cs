// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class Compiler : BaseProcessor // TypeDefIndex: 13728
{
	// Fields
	private string restrictionErrorMsg; // 0x40
	private XmlSchemaObjectTable attributes; // 0x48
	private XmlSchemaObjectTable attributeGroups; // 0x50
	private XmlSchemaObjectTable elements; // 0x58
	private XmlSchemaObjectTable schemaTypes; // 0x60
	private XmlSchemaObjectTable groups; // 0x68
	private XmlSchemaObjectTable notations; // 0x70
	private XmlSchemaObjectTable examplars; // 0x78
	private XmlSchemaObjectTable identityConstraints; // 0x80
	private Stack complexTypeStack; // 0x88
	private Hashtable schemasToCompile; // 0x90
	private Hashtable importedSchemas; // 0x98
	private XmlSchema schemaForSchema; // 0xA0

	// Methods

	// RVA: 0x3310BD4 Offset: 0x330CBD4 VA: 0x3310BD4
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x3310E18 Offset: 0x330CE18 VA: 0x3310E18
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0x3313FBC Offset: 0x330FFBC VA: 0x3313FBC
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0x3315E10 Offset: 0x3311E10 VA: 0x3315E10
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0x3312EC0 Offset: 0x330EEC0 VA: 0x3312EC0
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x3315F60 Offset: 0x3311F60 VA: 0x3315F60
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0x3310EB4 Offset: 0x330CEB4 VA: 0x3310EB4
	internal bool Compile() { }

	// RVA: 0x3315850 Offset: 0x3311850 VA: 0x3315850
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x33158C8 Offset: 0x33118C8 VA: 0x33158C8
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x3315928 Offset: 0x3311928 VA: 0x3315928
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x3315D5C Offset: 0x3311D5C VA: 0x3315D5C
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x33156B8 Offset: 0x33116B8 VA: 0x33156B8
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x331ACD0 Offset: 0x3316CD0 VA: 0x331ACD0
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x3315880 Offset: 0x3311880 VA: 0x3315880
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x331ADA8 Offset: 0x3316DA8 VA: 0x331ADA8
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x3319CFC Offset: 0x3315CFC VA: 0x3319CFC
	private void ProcessSubstitutionGroups() { }

	// RVA: 0x331AF44 Offset: 0x3316F44 VA: 0x331AF44
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x331AB7C Offset: 0x3316B7C VA: 0x331AB7C
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0x331AC58 Offset: 0x3316C58 VA: 0x331AC58
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0x3316068 Offset: 0x3312068 VA: 0x3316068
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x33174BC Offset: 0x33134BC VA: 0x33174BC
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x331C354 Offset: 0x3318354 VA: 0x331C354
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x331C704 Offset: 0x3318704 VA: 0x331C704
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x33169DC Offset: 0x33129DC VA: 0x33169DC
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x331C81C Offset: 0x331881C VA: 0x331C81C
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x331CA74 Offset: 0x3318A74 VA: 0x331CA74
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x331CEC0 Offset: 0x3318EC0 VA: 0x331CEC0
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x331D260 Offset: 0x3319260 VA: 0x331D260
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x331A578 Offset: 0x3316578 VA: 0x331A578
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x331B7F0 Offset: 0x33177F0 VA: 0x331B7F0
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x331EAE4 Offset: 0x331AAE4 VA: 0x331EAE4
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0x331B44C Offset: 0x331744C VA: 0x331B44C
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0x332173C Offset: 0x331D73C VA: 0x332173C
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0x33205F0 Offset: 0x331C5F0 VA: 0x33205F0
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0x3320B10 Offset: 0x331CB10 VA: 0x3320B10
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0x3320D94 Offset: 0x331CD94 VA: 0x3320D94
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0x3321288 Offset: 0x331D288 VA: 0x3321288
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0x331F8FC Offset: 0x331B8FC VA: 0x331F8FC
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0x331FB60 Offset: 0x331BB60 VA: 0x331FB60
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x3321A78 Offset: 0x331DA78 VA: 0x3321A78
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x3321C84 Offset: 0x331DC84 VA: 0x3321C84
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x3321E38 Offset: 0x331DE38 VA: 0x3321E38
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x3321F38 Offset: 0x331DF38 VA: 0x3321F38
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x3322340 Offset: 0x331E340 VA: 0x3322340
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0x33231FC Offset: 0x331F1FC VA: 0x33231FC
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0x3322C00 Offset: 0x331EC00 VA: 0x3322C00
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x3322EF0 Offset: 0x331EEF0 VA: 0x3322EF0
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x3323390 Offset: 0x331F390 VA: 0x3323390
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x33236D4 Offset: 0x331F6D4 VA: 0x33236D4
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x3324038 Offset: 0x3320038 VA: 0x3324038
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x3324120 Offset: 0x3320120 VA: 0x3324120
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x33219B4 Offset: 0x331D9B4 VA: 0x33219B4
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x3323874 Offset: 0x331F874 VA: 0x3323874
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x3324214 Offset: 0x3320214 VA: 0x3324214
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x331EC40 Offset: 0x331AC40 VA: 0x331EC40
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x331614C Offset: 0x331214C VA: 0x331614C
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x331D528 Offset: 0x3319528 VA: 0x331D528
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x331B8D4 Offset: 0x33178D4 VA: 0x331B8D4
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0x3324360 Offset: 0x3320360 VA: 0x3324360
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0x33242CC Offset: 0x33202CC VA: 0x33242CC
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x3324238 Offset: 0x3320238 VA: 0x3324238
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x3318CB0 Offset: 0x3314CB0 VA: 0x3318CB0
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x332443C Offset: 0x332043C VA: 0x332443C
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0x331953C Offset: 0x331553C VA: 0x331953C
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x3317E50 Offset: 0x3313E50 VA: 0x3317E50
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x331ECB0 Offset: 0x331ACB0 VA: 0x331ECB0
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x3324620 Offset: 0x3320620 VA: 0x3324620
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x3324B20 Offset: 0x3320B20 VA: 0x3324B20
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x331B668 Offset: 0x3317668 VA: 0x331B668
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0x3319BE0 Offset: 0x3315BE0 VA: 0x3319BE0
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x331C27C Offset: 0x331827C VA: 0x331C27C
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x331F854 Offset: 0x331B854 VA: 0x331F854
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x331F6FC Offset: 0x331B6FC VA: 0x331F6FC
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0x3321940 Offset: 0x331D940 VA: 0x3321940
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0x3323718 Offset: 0x331F718 VA: 0x3323718
	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }
}

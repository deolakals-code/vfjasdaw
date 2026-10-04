// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class SchemaCollectionCompiler : BaseProcessor // TypeDefIndex: 13715
{
	// Fields
	private bool compileContentModel; // 0x40
	private XmlSchemaObjectTable examplars; // 0x48
	private Stack complexTypeStack; // 0x50
	private XmlSchema schema; // 0x58

	// Methods

	// RVA: 0x32EEECC Offset: 0x32EAECC VA: 0x32EEECC
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0x32EEF94 Offset: 0x32EAF94 VA: 0x32EEF94
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0x32EF008 Offset: 0x32EB008 VA: 0x32EF008
	private void Prepare() { }

	// RVA: 0x32EF490 Offset: 0x32EB490 VA: 0x32EF490
	private void Cleanup() { }

	// RVA: 0x32F3998 Offset: 0x32EF998 VA: 0x32F3998
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0x32F038C Offset: 0x32EC38C VA: 0x32F038C
	private void Compile() { }

	// RVA: 0x32F23E4 Offset: 0x32EE3E4 VA: 0x32F23E4
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x32F3960 Offset: 0x32EF960 VA: 0x32F3960
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x32F3448 Offset: 0x32EF448 VA: 0x32F3448
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x32F348C Offset: 0x32EF48C VA: 0x32F348C
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x32F37C4 Offset: 0x32EF7C4 VA: 0x32F37C4
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x32F37DC Offset: 0x32EF7DC VA: 0x32F37DC
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x32F84EC Offset: 0x32F44EC VA: 0x32F84EC
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x32F341C Offset: 0x32EF41C VA: 0x32F341C
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x32F85B0 Offset: 0x32F45B0 VA: 0x32F85B0
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x32F3FA8 Offset: 0x32EFFA8 VA: 0x32F3FA8
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0x32F8318 Offset: 0x32F4318 VA: 0x32F8318
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x32F4428 Offset: 0x32F0428 VA: 0x32F4428
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x32F596C Offset: 0x32F196C VA: 0x32F596C
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x32F8AAC Offset: 0x32F4AAC VA: 0x32F8AAC
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x32F8E5C Offset: 0x32F4E5C VA: 0x32F8E5C
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x32F4C68 Offset: 0x32F0C68 VA: 0x32F4C68
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x32F8F74 Offset: 0x32F4F74 VA: 0x32F8F74
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x32F91CC Offset: 0x32F51CC VA: 0x32F91CC
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x32F9618 Offset: 0x32F5618 VA: 0x32F9618
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x32F9A04 Offset: 0x32F5A04 VA: 0x32F9A04
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x32F81EC Offset: 0x32F41EC VA: 0x32F81EC
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x32FB228 Offset: 0x32F7228 VA: 0x32FB228
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0x32F8714 Offset: 0x32F4714 VA: 0x32F8714
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0x32FC608 Offset: 0x32F8608 VA: 0x32FC608
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0x32FC758 Offset: 0x32F8758 VA: 0x32FC758
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0x32FCCAC Offset: 0x32F8CAC VA: 0x32FCCAC
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0x32FD14C Offset: 0x32F914C VA: 0x32FD14C
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0x32FD64C Offset: 0x32F964C VA: 0x32FD64C
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0x32FC040 Offset: 0x32F8040 VA: 0x32FC040
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x32FDBB0 Offset: 0x32F9BB0 VA: 0x32FDBB0
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x32FDCC4 Offset: 0x32F9CC4 VA: 0x32FDCC4
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x32FDD20 Offset: 0x32F9D20 VA: 0x32FDD20
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x32FDD6C Offset: 0x32F9D6C VA: 0x32FDD6C
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x32FDF74 Offset: 0x32F9F74 VA: 0x32FDF74
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x32FE2DC Offset: 0x32FA2DC VA: 0x32FE2DC
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x32FE550 Offset: 0x32FA550 VA: 0x32FE550
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x32FE85C Offset: 0x32FA85C VA: 0x32FE85C
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x32FF454 Offset: 0x32FB454 VA: 0x32FF454
	private void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x32FEA5C Offset: 0x32FAA5C VA: 0x32FEA5C
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x32FF278 Offset: 0x32FB278 VA: 0x32FF278
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x32FF360 Offset: 0x32FB360 VA: 0x32FF360
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x32FDAEC Offset: 0x32F9AEC VA: 0x32FDAEC
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x32FEAA0 Offset: 0x32FAAA0 VA: 0x32FEAA0
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x32FF810 Offset: 0x32FB810 VA: 0x32FF810
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x32FB38C Offset: 0x32F738C VA: 0x32FB38C
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x32F4510 Offset: 0x32F0510 VA: 0x32F4510
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x32F9CF4 Offset: 0x32F5CF4 VA: 0x32F9CF4
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x32FF8C8 Offset: 0x32FB8C8 VA: 0x32FF8C8
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x32FF834 Offset: 0x32FB834 VA: 0x32FF834
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x32F6FCC Offset: 0x32F2FCC VA: 0x32F6FCC
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x32F7A70 Offset: 0x32F3A70 VA: 0x32F7A70
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x32F62C8 Offset: 0x32F22C8 VA: 0x32F62C8
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x32FB3FC Offset: 0x32F73FC VA: 0x32FB3FC
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x32FF95C Offset: 0x32FB95C VA: 0x32FF95C
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x32FFE50 Offset: 0x32FBE50 VA: 0x32FFE50
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x32F8118 Offset: 0x32F4118 VA: 0x32F8118
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x32F8960 Offset: 0x32F4960 VA: 0x32F8960
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x32FBF8C Offset: 0x32F7F8C VA: 0x32FBF8C
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x32FBE28 Offset: 0x32F7E28 VA: 0x32FBE28
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }
}

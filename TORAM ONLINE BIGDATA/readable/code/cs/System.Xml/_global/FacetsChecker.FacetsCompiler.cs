// Assembly: System.Xml.dll
// Namespace: 
private struct FacetsChecker.FacetsCompiler // TypeDefIndex: 13689
{
	// Fields
	private DatatypeImplementation datatype; // 0x0
	private RestrictionFacets derivedRestriction; // 0x8
	private RestrictionFlags baseFlags; // 0x10
	private RestrictionFlags baseFixedFlags; // 0x14
	private RestrictionFlags validRestrictionFlags; // 0x18
	private XmlSchemaDatatype nonNegativeInt; // 0x20
	private XmlSchemaDatatype builtInType; // 0x28
	private XmlTypeCode builtInEnum; // 0x30
	private bool firstPattern; // 0x34
	private StringBuilder regStr; // 0x38
	private XmlSchemaPatternFacet pattern_facet; // 0x40
	private static readonly FacetsChecker.FacetsCompiler.Map[] c_map; // 0x0

	// Methods

	// RVA: 0x3437290 Offset: 0x3433290 VA: 0x3437290
	public void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	// RVA: 0x34374D8 Offset: 0x34334D8 VA: 0x34374D8
	internal void CompileLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x3437838 Offset: 0x3433838 VA: 0x3437838
	internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x3437B5C Offset: 0x3433B5C VA: 0x3437B5C
	internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x3437E80 Offset: 0x3433E80 VA: 0x3437E80
	internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	// RVA: 0x3438004 Offset: 0x3434004 VA: 0x3438004
	internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x343815C Offset: 0x343415C VA: 0x343815C
	internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	// RVA: 0x3438864 Offset: 0x3434864 VA: 0x3438864
	internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x3438A34 Offset: 0x3434A34 VA: 0x3438A34
	internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x34384C4 Offset: 0x34344C4 VA: 0x34384C4
	internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x3438694 Offset: 0x3434694 VA: 0x3438694
	internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x3438C04 Offset: 0x3434C04 VA: 0x3438C04
	internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x3438F20 Offset: 0x3434F20 VA: 0x3438F20
	internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x34391D4 Offset: 0x34351D4 VA: 0x34391D4
	internal void FinishFacetCompile() { }

	// RVA: 0x3439CFC Offset: 0x3435CFC VA: 0x3439CFC
	private void CheckValue(object value, XmlSchemaFacet facet) { }

	// RVA: 0x3439548 Offset: 0x3435548 VA: 0x3439548
	internal void CompileFacetCombinations() { }

	// RVA: 0x343A3EC Offset: 0x34363EC VA: 0x343A3EC
	private void CopyFacetsFromBaseType() { }

	// RVA: 0x3439B50 Offset: 0x3435B50 VA: 0x3439B50
	private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x343A190 Offset: 0x3436190 VA: 0x343A190
	private static string Preprocess(string pattern) { }

	// RVA: 0x3439A54 Offset: 0x3435A54 VA: 0x3439A54
	private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x3439AE0 Offset: 0x3435AE0 VA: 0x3439AE0
	private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x3439C94 Offset: 0x3435C94 VA: 0x3439C94
	private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	// RVA: 0x343A7E4 Offset: 0x34367E4 VA: 0x343A7E4
	private void SetFlag(RestrictionFlags flag) { }

	// RVA: 0x343A820 Offset: 0x3436820 VA: 0x343A820
	private static void .cctor() { }
}

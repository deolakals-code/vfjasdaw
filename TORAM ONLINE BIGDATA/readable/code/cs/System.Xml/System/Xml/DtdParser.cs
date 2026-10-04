// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class DtdParser : IDtdParser // TypeDefIndex: 13438
{
	// Fields
	private IDtdParserAdapter readerAdapter; // 0x10
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaInfo schemaInfo; // 0x28
	private XmlCharType xmlCharType; // 0x30
	private string systemId; // 0x38
	private string publicId; // 0x40
	private bool normalize; // 0x48
	private bool validate; // 0x49
	private bool supportNamespaces; // 0x4A
	private bool v1Compat; // 0x4B
	private char[] chars; // 0x50
	private int charsUsed; // 0x58
	private int curPos; // 0x5C
	private DtdParser.ScanningFunction scanningFunction; // 0x60
	private DtdParser.ScanningFunction nextScaningFunction; // 0x64
	private DtdParser.ScanningFunction savedScanningFunction; // 0x68
	private bool whitespaceSeen; // 0x6C
	private int tokenStartPos; // 0x70
	private int colonPos; // 0x74
	private StringBuilder internalSubsetValueSb; // 0x78
	private int externalEntitiesDepth; // 0x80
	private int currentEntityId; // 0x84
	private bool freeFloatingDtd; // 0x88
	private bool hasFreeFloatingInternalSubset; // 0x89
	private StringBuilder stringBuilder; // 0x90
	private int condSectionDepth; // 0x98
	private LineInfo literalLineInfo; // 0x9C
	private char literalQuoteChar; // 0xA4
	private string documentBaseUri; // 0xA8
	private string externalDtdBaseUri; // 0xB0
	private Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations; // 0xB8
	private int[] condSectionEntityIds; // 0xC0

	// Properties
	private bool ParsingInternalSubset { get; }
	private bool IgnoreEntityReferences { get; }
	private bool SaveInternalSubsetValue { get; }
	private bool ParsingTopLevelMarkup { get; }
	private bool SupportNamespaces { get; }
	private bool Normalize { get; }
	private int LineNo { get; }
	private int LinePos { get; }
	private string BaseUriStr { get; }

	// Methods

	// RVA: 0x33CA19C Offset: 0x33C619C VA: 0x33CA19C
	private void .ctor() { }

	// RVA: 0x33CA278 Offset: 0x33C6278 VA: 0x33CA278
	internal static IDtdParser Create() { }

	// RVA: 0x33CA2C8 Offset: 0x33C62C8 VA: 0x33CA2C8
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x33CA6E8 Offset: 0x33C66E8 VA: 0x33CA6E8
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x33CAB5C Offset: 0x33C6B5C VA: 0x33CAB5C Slot: 4
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x33CADC8 Offset: 0x33C6DC8 VA: 0x33CADC8 Slot: 5
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x33CADEC Offset: 0x33C6DEC VA: 0x33CADEC
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x33CADFC Offset: 0x33C6DFC VA: 0x33CADFC
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x33CAE0C Offset: 0x33C6E0C VA: 0x33CAE0C
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x33CAECC Offset: 0x33C6ECC VA: 0x33CAECC
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0x33CAEFC Offset: 0x33C6EFC VA: 0x33CAEFC
	private bool get_SupportNamespaces() { }

	// RVA: 0x33CAF04 Offset: 0x33C6F04 VA: 0x33CAF04
	private bool get_Normalize() { }

	// RVA: 0x33CAB8C Offset: 0x33C6B8C VA: 0x33CAB8C
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x33CAF60 Offset: 0x33C6F60 VA: 0x33CAF60
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x33CAF0C Offset: 0x33C6F0C VA: 0x33CAF0C
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x33CC3DC Offset: 0x33C83DC VA: 0x33CC3DC
	private void ParseInternalSubset() { }

	// RVA: 0x33CC3E0 Offset: 0x33C83E0 VA: 0x33CC3E0
	private void ParseExternalSubset() { }

	// RVA: 0x33CC590 Offset: 0x33C8590 VA: 0x33CC590
	private void ParseSubset() { }

	// RVA: 0x33CC8EC Offset: 0x33C88EC VA: 0x33CC8EC
	private void ParseAttlistDecl() { }

	// RVA: 0x33CE39C Offset: 0x33CA39C VA: 0x33CE39C
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x33CE920 Offset: 0x33CA920 VA: 0x33CE920
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x33CCEA8 Offset: 0x33C8EA8 VA: 0x33CCEA8
	private void ParseElementDecl() { }

	// RVA: 0x33CF0B8 Offset: 0x33CB0B8 VA: 0x33CF0B8
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x33CF400 Offset: 0x33CB400 VA: 0x33CF400
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x33CEE24 Offset: 0x33CAE24 VA: 0x33CEE24
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x33CD250 Offset: 0x33C9250 VA: 0x33CD250
	private void ParseEntityDecl() { }

	// RVA: 0x33CD5D8 Offset: 0x33C95D8 VA: 0x33CD5D8
	private void ParseNotationDecl() { }

	// RVA: 0x33CEBC8 Offset: 0x33CABC8 VA: 0x33CEBC8
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x33CD7DC Offset: 0x33C97DC VA: 0x33CD7DC
	private void ParseComment() { }

	// RVA: 0x33CDA28 Offset: 0x33C9A28 VA: 0x33CDA28
	private void ParsePI() { }

	// RVA: 0x33CDBF4 Offset: 0x33C9BF4 VA: 0x33CDBF4
	private void ParseCondSection() { }

	// RVA: 0x33CBEB0 Offset: 0x33C7EB0 VA: 0x33CBEB0
	private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId) { }

	// RVA: 0x33CB4B8 Offset: 0x33C74B8 VA: 0x33CB4B8
	private DtdParser.Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x33CFBA0 Offset: 0x33CBBA0 VA: 0x33CFBA0
	private DtdParser.Token ScanSubsetContent() { }

	// RVA: 0x33CFB38 Offset: 0x33CBB38 VA: 0x33CFB38
	private DtdParser.Token ScanNameExpected() { }

	// RVA: 0x33CFB5C Offset: 0x33CBB5C VA: 0x33CFB5C
	private DtdParser.Token ScanQNameExpected() { }

	// RVA: 0x33CFB80 Offset: 0x33CBB80 VA: 0x33CFB80
	private DtdParser.Token ScanNmtokenExpected() { }

	// RVA: 0x33D02A4 Offset: 0x33CC2A4 VA: 0x33D02A4
	private DtdParser.Token ScanDoctype1() { }

	// RVA: 0x33D03D0 Offset: 0x33CC3D0 VA: 0x33D03D0
	private DtdParser.Token ScanDoctype2() { }

	// RVA: 0x33D2614 Offset: 0x33CE614 VA: 0x33D2614
	private DtdParser.Token ScanClosingTag() { }

	// RVA: 0x33D0478 Offset: 0x33CC478 VA: 0x33D0478
	private DtdParser.Token ScanElement1() { }

	// RVA: 0x33D0648 Offset: 0x33CC648 VA: 0x33D0648
	private DtdParser.Token ScanElement2() { }

	// RVA: 0x33D07EC Offset: 0x33CC7EC VA: 0x33D07EC
	private DtdParser.Token ScanElement3() { }

	// RVA: 0x33D086C Offset: 0x33CC86C VA: 0x33D086C
	private DtdParser.Token ScanElement4() { }

	// RVA: 0x33D0938 Offset: 0x33CC938 VA: 0x33D0938
	private DtdParser.Token ScanElement5() { }

	// RVA: 0x33D0A24 Offset: 0x33CCA24 VA: 0x33D0A24
	private DtdParser.Token ScanElement6() { }

	// RVA: 0x33D0AF4 Offset: 0x33CCAF4 VA: 0x33D0AF4
	private DtdParser.Token ScanElement7() { }

	// RVA: 0x33D0B54 Offset: 0x33CCB54 VA: 0x33D0B54
	private DtdParser.Token ScanAttlist1() { }

	// RVA: 0x33D0C18 Offset: 0x33CCC18 VA: 0x33D0C18
	private DtdParser.Token ScanAttlist2() { }

	// RVA: 0x33D1298 Offset: 0x33CD298 VA: 0x33D1298
	private DtdParser.Token ScanAttlist3() { }

	// RVA: 0x33D1338 Offset: 0x33CD338 VA: 0x33D1338
	private DtdParser.Token ScanAttlist4() { }

	// RVA: 0x33D1408 Offset: 0x33CD408 VA: 0x33D1408
	private DtdParser.Token ScanAttlist5() { }

	// RVA: 0x33D14D8 Offset: 0x33CD4D8 VA: 0x33D14D8
	private DtdParser.Token ScanAttlist6() { }

	// RVA: 0x33D184C Offset: 0x33CD84C VA: 0x33D184C
	private DtdParser.Token ScanAttlist7() { }

	// RVA: 0x33D2C4C Offset: 0x33CEC4C VA: 0x33D2C4C
	private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType) { }

	// RVA: 0x33D36CC Offset: 0x33CF6CC VA: 0x33D36CC
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x33D1908 Offset: 0x33CD908 VA: 0x33D1908
	private DtdParser.Token ScanNotation1() { }

	// RVA: 0x33D1A08 Offset: 0x33CDA08 VA: 0x33D1A08
	private DtdParser.Token ScanSystemId() { }

	// RVA: 0x33D1BD8 Offset: 0x33CDBD8 VA: 0x33D1BD8
	private DtdParser.Token ScanEntity1() { }

	// RVA: 0x33D1C4C Offset: 0x33CDC4C VA: 0x33D1C4C
	private DtdParser.Token ScanEntity2() { }

	// RVA: 0x33D1D80 Offset: 0x33CDD80 VA: 0x33D1D80
	private DtdParser.Token ScanEntity3() { }

	// RVA: 0x33D1ABC Offset: 0x33CDABC VA: 0x33D1ABC
	private DtdParser.Token ScanPublicId1() { }

	// RVA: 0x33D1B70 Offset: 0x33CDB70 VA: 0x33D1B70
	private DtdParser.Token ScanPublicId2() { }

	// RVA: 0x33D1E94 Offset: 0x33CDE94 VA: 0x33D1E94
	private DtdParser.Token ScanCondSection1() { }

	// RVA: 0x33D2130 Offset: 0x33CE130 VA: 0x33D2130
	private DtdParser.Token ScanCondSection2() { }

	// RVA: 0x33D21C8 Offset: 0x33CE1C8 VA: 0x33D21C8
	private DtdParser.Token ScanCondSection3() { }

	// RVA: 0x33D2914 Offset: 0x33CE914 VA: 0x33D2914
	private void ScanName() { }

	// RVA: 0x33D291C Offset: 0x33CE91C VA: 0x33D291C
	private void ScanQName() { }

	// RVA: 0x33D3A54 Offset: 0x33CFA54 VA: 0x33D3A54
	private void ScanQName(bool isQName) { }

	// RVA: 0x33D3CD4 Offset: 0x33CFCD4 VA: 0x33D3CD4
	private bool ReadDataInName() { }

	// RVA: 0x33D2924 Offset: 0x33CE924 VA: 0x33D2924
	private void ScanNmtoken() { }

	// RVA: 0x33D2A84 Offset: 0x33CEA84 VA: 0x33D2A84
	private bool EatPublicKeyword() { }

	// RVA: 0x33D2B68 Offset: 0x33CEB68 VA: 0x33D2B68
	private bool EatSystemKeyword() { }

	// RVA: 0x33CBD3C Offset: 0x33C7D3C VA: 0x33CBD3C
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x33CEBAC Offset: 0x33CABAC VA: 0x33CEBAC
	private string GetNameString() { }

	// RVA: 0x33CED4C Offset: 0x33CAD4C VA: 0x33CED4C
	private string GetNmtokenString() { }

	// RVA: 0x33CEDC8 Offset: 0x33CADC8 VA: 0x33CEDC8
	private string GetValue() { }

	// RVA: 0x33CED68 Offset: 0x33CAD68 VA: 0x33CED68
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x33D26A8 Offset: 0x33CE6A8 VA: 0x33D26A8
	private int ReadData() { }

	// RVA: 0x33CB32C Offset: 0x33C732C VA: 0x33CB32C
	private void LoadParsingBuffer() { }

	// RVA: 0x33CC3D4 Offset: 0x33C83D4 VA: 0x33CC3D4
	private void SaveParsingBuffer() { }

	// RVA: 0x33CDF28 Offset: 0x33C9F28 VA: 0x33CDF28
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x33CFA2C Offset: 0x33CBA2C VA: 0x33CFA2C
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x33D3F3C Offset: 0x33CFF3C VA: 0x33D3F3C
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x33D276C Offset: 0x33CE76C VA: 0x33D276C
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x33D382C Offset: 0x33CF82C VA: 0x33D382C
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x33CDE54 Offset: 0x33C9E54 VA: 0x33CDE54
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x33CEAEC Offset: 0x33CAAEC VA: 0x33CEAEC
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x33CB1E8 Offset: 0x33C71E8 VA: 0x33CB1E8
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x33CEAE0 Offset: 0x33CAAE0 VA: 0x33CEAE0
	private bool IsAttributeValueType(DtdParser.Token token) { }

	// RVA: 0x33CE07C Offset: 0x33CA07C VA: 0x33CE07C
	private int get_LineNo() { }

	// RVA: 0x33CE120 Offset: 0x33CA120 VA: 0x33CE120
	private int get_LinePos() { }

	// RVA: 0x33CB0C4 Offset: 0x33C70C4 VA: 0x33CB0C4
	private string get_BaseUriStr() { }

	// RVA: 0x33CBCF0 Offset: 0x33C7CF0 VA: 0x33CBCF0
	private void OnUnexpectedError() { }

	// RVA: 0x33CDB8C Offset: 0x33C9B8C VA: 0x33CDB8C
	private void Throw(int curPos, string res) { }

	// RVA: 0x33CF470 Offset: 0x33CB470 VA: 0x33CF470
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x33CF7C8 Offset: 0x33CB7C8 VA: 0x33CF7C8
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x33CE1D0 Offset: 0x33CA1D0 VA: 0x33CE1D0
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x33CAAE0 Offset: 0x33C6AE0 VA: 0x33CAAE0
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x33CF9AC Offset: 0x33CB9AC VA: 0x33CF9AC
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x33CE074 Offset: 0x33CA074 VA: 0x33CE074
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x33CF654 Offset: 0x33CB654 VA: 0x33CF654
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x33CFA7C Offset: 0x33CBA7C VA: 0x33CFA7C
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x33D3D18 Offset: 0x33CFD18 VA: 0x33D3D18
	internal static string StripSpaces(string value) { }
}

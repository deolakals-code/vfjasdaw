// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 13346
{
	// Fields
	private readonly bool useAsync; // 0x10
	private XmlTextReaderImpl.LaterInitParam laterInitParam; // 0x18
	private XmlCharType xmlCharType; // 0x20
	private XmlTextReaderImpl.ParsingState ps; // 0x28
	private XmlTextReaderImpl.ParsingFunction parsingFunction; // 0xA0
	private XmlTextReaderImpl.ParsingFunction nextParsingFunction; // 0xA4
	private XmlTextReaderImpl.ParsingFunction nextNextParsingFunction; // 0xA8
	private XmlTextReaderImpl.NodeData[] nodes; // 0xB0
	private XmlTextReaderImpl.NodeData curNode; // 0xB8
	private int index; // 0xC0
	private int curAttrIndex; // 0xC4
	private int attrCount; // 0xC8
	private int attrHashtable; // 0xCC
	private int attrDuplWalkCount; // 0xD0
	private bool attrNeedNamespaceLookup; // 0xD4
	private bool fullAttrCleanup; // 0xD5
	private XmlTextReaderImpl.NodeData[] attrDuplSortingArray; // 0xD8
	private XmlNameTable nameTable; // 0xE0
	private bool nameTableFromSettings; // 0xE8
	private XmlResolver xmlResolver; // 0xF0
	private string url; // 0xF8
	private bool normalize; // 0x100
	private bool supportNamespaces; // 0x101
	private WhitespaceHandling whitespaceHandling; // 0x104
	private DtdProcessing dtdProcessing; // 0x108
	private EntityHandling entityHandling; // 0x10C
	private bool ignorePIs; // 0x110
	private bool ignoreComments; // 0x111
	private bool checkCharacters; // 0x112
	private int lineNumberOffset; // 0x114
	private int linePositionOffset; // 0x118
	private bool closeInput; // 0x11C
	private long maxCharactersInDocument; // 0x120
	private long maxCharactersFromEntities; // 0x128
	private bool v1Compat; // 0x130
	private XmlNamespaceManager namespaceManager; // 0x138
	private string lastPrefix; // 0x140
	private XmlTextReaderImpl.XmlContext xmlContext; // 0x148
	private XmlTextReaderImpl.ParsingState[] parsingStatesStack; // 0x150
	private int parsingStatesStackTop; // 0x158
	private string reportedBaseUri; // 0x160
	private Encoding reportedEncoding; // 0x168
	private IDtdInfo dtdInfo; // 0x170
	private XmlNodeType fragmentType; // 0x178
	private XmlParserContext fragmentParserContext; // 0x180
	private bool fragment; // 0x188
	private IncrementalReadDecoder incReadDecoder; // 0x190
	private XmlTextReaderImpl.IncrementalReadState incReadState; // 0x198
	private LineInfo incReadLineInfo; // 0x19C
	private int incReadDepth; // 0x1A4
	private int incReadLeftStartPos; // 0x1A8
	private int incReadLeftEndPos; // 0x1AC
	private int attributeValueBaseEntityId; // 0x1B0
	private bool emptyEntityInAttributeResolved; // 0x1B4
	private IValidationEventHandling validationEventHandling; // 0x1B8
	private XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse; // 0x1C0
	private bool validatingReaderCompatFlag; // 0x1C8
	private bool addDefaultAttributesAndNormalize; // 0x1C9
	private StringBuilder stringBuilder; // 0x1D0
	private bool rootElementParsed; // 0x1D8
	private bool standalone; // 0x1D9
	private int nextEntityId; // 0x1DC
	private XmlTextReaderImpl.ParsingMode parsingMode; // 0x1E0
	private ReadState readState; // 0x1E4
	private IDtdEntityInfo lastEntity; // 0x1E8
	private bool afterResetState; // 0x1F0
	private int documentStartBytePos; // 0x1F4
	private int readValueOffset; // 0x1F8
	private long charactersInDocument; // 0x200
	private long charactersFromEntities; // 0x208
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; // 0x210
	private bool disableUndeclaredEntityCheck; // 0x218
	private XmlReader outerReader; // 0x220
	private bool xmlResolverIsSet; // 0x228
	private string Xml; // 0x230
	private string XmlNs; // 0x238
	private Task<Tuple<int, int, int, bool>> parseText_dummyTask; // 0x240

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override int AttributeCount { get; }
	internal XmlReader OuterReader { set; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal bool Namespaces { get; set; }
	internal bool Normalization { get; set; }
	internal WhitespaceHandling WhitespaceHandling { set; }
	internal EntityHandling EntityHandling { set; }
	internal bool IsResolverSet { get; }
	internal XmlResolver XmlResolver { set; }
	internal XmlNameTable DtdParserProxy_NameTable { get; }
	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver { get; }
	internal bool DtdParserProxy_DtdValidation { get; }
	internal bool DtdParserProxy_Normalization { get; }
	internal bool DtdParserProxy_Namespaces { get; }
	internal bool DtdParserProxy_V1CompatibilityMode { get; }
	internal Uri DtdParserProxy_BaseUri { get; }
	internal bool DtdParserProxy_IsEof { get; }
	internal char[] DtdParserProxy_ParsingBuffer { get; }
	internal int DtdParserProxy_ParsingBufferLength { get; }
	internal int DtdParserProxy_CurrentPosition { get; set; }
	internal int DtdParserProxy_EntityStackLength { get; }
	internal bool DtdParserProxy_IsEntityEolNormalized { get; }
	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling { get; }
	internal int DtdParserProxy_LineNo { get; }
	internal int DtdParserProxy_LineStartPosition { get; }
	private bool IsResolverNull { get; }
	private bool InAttributeValueIterator { get; }
	private bool DtdValidation { get; }
	private bool InEntity { get; }
	internal override IDtdInfo DtdInfo { get; }
	internal IValidationEventHandling ValidationEventHandling { set; }
	internal XmlTextReaderImpl.OnDefaultAttributeUseDelegate OnDefaultAttributeUse { set; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal XmlNodeType FragmentType { get; }
	internal object InternalSchemaType { set; }
	internal object InternalTypedValue { get; set; }
	internal bool StandAlone { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool V1Compat { get; }
	internal bool DisableUndeclaredEntityCheck { set; }

	// Methods

	// RVA: 0x32C3BF8 Offset: 0x32BFBF8 VA: 0x32C3BF8
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0x32C402C Offset: 0x32C002C VA: 0x32C402C
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0x32C47C8 Offset: 0x32C07C8 VA: 0x32C47C8
	internal void .ctor(Stream input) { }

	// RVA: 0x32C4858 Offset: 0x32C0858 VA: 0x32C4858
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x32C49D4 Offset: 0x32C09D4 VA: 0x32C49D4
	internal void .ctor(TextReader input) { }

	// RVA: 0x32C4B48 Offset: 0x32C0B48 VA: 0x32C4B48
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x32C4A64 Offset: 0x32C0A64 VA: 0x32C4A64
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0x32C4BBC Offset: 0x32C0BBC VA: 0x32C4BBC
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0x32C5054 Offset: 0x32C1054 VA: 0x32C5054
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0x32C51B0 Offset: 0x32C11B0 VA: 0x32C51B0
	private void FinishInitUriString() { }

	// RVA: 0x32C57F4 Offset: 0x32C17F4 VA: 0x32C57F4
	internal void .ctor(Stream stream, byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0x32C5AF8 Offset: 0x32C1AF8 VA: 0x32C5AF8
	private void FinishInitStream() { }

	// RVA: 0x32C5B94 Offset: 0x32C1B94 VA: 0x32C5B94
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0x32C5CC0 Offset: 0x32C1CC0 VA: 0x32C5CC0
	private void FinishInitTextReader() { }

	// RVA: 0x32C5D40 Offset: 0x32C1D40 VA: 0x32C5D40
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x32C5DF4 Offset: 0x32C1DF4 VA: 0x32C5DF4 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x32C5F68 Offset: 0x32C1F68 VA: 0x32C5F68 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32C5F84 Offset: 0x32C1F84 VA: 0x32C5F84 Slot: 7
	public override string get_Name() { }

	// RVA: 0x32C5FA8 Offset: 0x32C1FA8 VA: 0x32C5FA8 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x32C5FC4 Offset: 0x32C1FC4 VA: 0x32C5FC4 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x32C5FE0 Offset: 0x32C1FE0 VA: 0x32C5FE0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x32C5FFC Offset: 0x32C1FFC VA: 0x32C5FFC Slot: 11
	public override string get_Value() { }

	// RVA: 0x32C620C Offset: 0x32C220C VA: 0x32C620C Slot: 12
	public override int get_Depth() { }

	// RVA: 0x32C6228 Offset: 0x32C2228 VA: 0x32C6228 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x32C6230 Offset: 0x32C2230 VA: 0x32C6230 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x32C624C Offset: 0x32C224C VA: 0x32C624C Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x32C6268 Offset: 0x32C2268 VA: 0x32C6268 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x32C6298 Offset: 0x32C2298 VA: 0x32C6298 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x32C62B4 Offset: 0x32C22B4 VA: 0x32C62B4 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x32C62D0 Offset: 0x32C22D0 VA: 0x32C62D0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x32C62D8 Offset: 0x32C22D8 VA: 0x32C62D8 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x32C62E8 Offset: 0x32C22E8 VA: 0x32C62E8 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x32C62F0 Offset: 0x32C22F0 VA: 0x32C62F0 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x32C62F8 Offset: 0x32C22F8 VA: 0x32C62F8 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x32C6300 Offset: 0x32C2300 VA: 0x32C6300 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x32C6530 Offset: 0x32C2530 VA: 0x32C6530 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x32C66AC Offset: 0x32C26AC VA: 0x32C66AC Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x32C6748 Offset: 0x32C2748 VA: 0x32C6748 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x32C68D0 Offset: 0x32C28D0 VA: 0x32C68D0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x32C699C Offset: 0x32C299C VA: 0x32C699C Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x32C6A1C Offset: 0x32C2A1C VA: 0x32C6A1C Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x32C6ABC Offset: 0x32C2ABC VA: 0x32C6ABC Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x32C6B4C Offset: 0x32C2B4C VA: 0x32C6B4C
	private void FinishInit() { }

	// RVA: 0x32C6B94 Offset: 0x32C2B94 VA: 0x32C6B94 Slot: 31
	public override bool Read() { }

	// RVA: 0x32C8D7C Offset: 0x32C4D7C VA: 0x32C8D7C Slot: 33
	public override void Close() { }

	// RVA: 0x32C8E70 Offset: 0x32C4E70 VA: 0x32C8E70 Slot: 35
	public override void Skip() { }

	// RVA: 0x32C8FF8 Offset: 0x32C4FF8 VA: 0x32C8FF8 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x32C9030 Offset: 0x32C5030 VA: 0x32C9030 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x32C9758 Offset: 0x32C5758 VA: 0x32C9758 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x32C9E50 Offset: 0x32C5E50 VA: 0x32C9E50
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0x32C9E60 Offset: 0x32C5E60 VA: 0x32C9E60
	internal void MoveOffEntityReference() { }

	// RVA: 0x32C9F10 Offset: 0x32C5F10 VA: 0x32C9F10 Slot: 42
	public override string ReadString() { }

	// RVA: 0x32C9F2C Offset: 0x32C5F2C VA: 0x32C9F2C Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x32C9F34 Offset: 0x32C5F34 VA: 0x32C9F34 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x32CA960 Offset: 0x32C6960 VA: 0x32CA960 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0x32CA968 Offset: 0x32C6968 VA: 0x32CA968 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0x32CA984 Offset: 0x32C6984 VA: 0x32CA984 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0x32CA9A0 Offset: 0x32C69A0 VA: 0x32CA9A0 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x32CA9E8 Offset: 0x32C69E8 VA: 0x32CA9E8 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x32CA9F8 Offset: 0x32C69F8 VA: 0x32CA9F8 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x32CA9C4 Offset: 0x32C69C4 VA: 0x32CA9C4
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x32CAA1C Offset: 0x32C6A1C VA: 0x32CAA1C
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x32CAA40 Offset: 0x32C6A40 VA: 0x32CAA40
	internal bool get_Namespaces() { }

	// RVA: 0x32CAA48 Offset: 0x32C6A48 VA: 0x32CAA48
	internal void set_Namespaces(bool value) { }

	// RVA: 0x32CAC34 Offset: 0x32C6C34 VA: 0x32CAC34
	internal bool get_Normalization() { }

	// RVA: 0x32CAC3C Offset: 0x32C6C3C VA: 0x32CAC3C
	internal void set_Normalization(bool value) { }

	// RVA: 0x32CAD58 Offset: 0x32C6D58 VA: 0x32CAD58
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x32CAE20 Offset: 0x32C6E20 VA: 0x32CAE20
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x32CAEA4 Offset: 0x32C6EA4 VA: 0x32CAEA4
	internal bool get_IsResolverSet() { }

	// RVA: 0x32CAEAC Offset: 0x32C6EAC VA: 0x32CAEAC
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x32CAF34 Offset: 0x32C6F34 VA: 0x32CAF34
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0x32CAF3C Offset: 0x32C6F3C VA: 0x32CAF3C
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0x32CAF44 Offset: 0x32C6F44 VA: 0x32CAF44
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0x32CAF64 Offset: 0x32C6F64 VA: 0x32CAF64
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0x32CAF6C Offset: 0x32C6F6C VA: 0x32CAF6C
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0x32CAF74 Offset: 0x32C6F74 VA: 0x32CAF74
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0x32CAF7C Offset: 0x32C6F7C VA: 0x32CAF7C
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x32CB030 Offset: 0x32C7030 VA: 0x32CB030
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x32CB038 Offset: 0x32C7038 VA: 0x32CB038
	internal char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x32CB040 Offset: 0x32C7040 VA: 0x32CB040
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0x32CB048 Offset: 0x32C7048 VA: 0x32CB048
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0x32CB050 Offset: 0x32C7050 VA: 0x32CB050
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0x32CB058 Offset: 0x32C7058 VA: 0x32CB058
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0x32CB064 Offset: 0x32C7064 VA: 0x32CB064
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x32CB06C Offset: 0x32C706C VA: 0x32CB06C
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0x32CB074 Offset: 0x32C7074 VA: 0x32CB074
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x32CB09C Offset: 0x32C709C VA: 0x32CB09C
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0x32CB0A4 Offset: 0x32C70A4 VA: 0x32CB0A4
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0x32CB0AC Offset: 0x32C70AC VA: 0x32CB0AC
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0x32CB508 Offset: 0x32C7508 VA: 0x32CB508
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x32CB5D4 Offset: 0x32C75D4 VA: 0x32CB5D4
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x32CB640 Offset: 0x32C7640 VA: 0x32CB640
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0x32CB9F4 Offset: 0x32C79F4 VA: 0x32CB9F4
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0x32CBDA0 Offset: 0x32C7DA0 VA: 0x32CBDA0
	private bool get_IsResolverNull() { }

	// RVA: 0x32CBDE0 Offset: 0x32C7DE0 VA: 0x32CBDE0
	private XmlResolver GetTempResolver() { }

	// RVA: 0x32CBE40 Offset: 0x32C7E40 VA: 0x32CBE40
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x32CC604 Offset: 0x32C8604 VA: 0x32CC604
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x32CC6B4 Offset: 0x32C86B4 VA: 0x32CC6B4
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x32CCDE8 Offset: 0x32C8DE8 VA: 0x32CCDE8
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x32CD090 Offset: 0x32C9090 VA: 0x32CD090
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0x32CD120 Offset: 0x32C9120 VA: 0x32CD120
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x32CD228 Offset: 0x32C9228 VA: 0x32CD228
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x32CD2B4 Offset: 0x32C92B4 VA: 0x32CD2B4
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0x32CD35C Offset: 0x32C935C VA: 0x32CD35C
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0x32CD404 Offset: 0x32C9404 VA: 0x32CD404
	private void Throw(int pos, string res) { }

	// RVA: 0x32C5AA4 Offset: 0x32C1AA4 VA: 0x32C5AA4
	private void Throw(string res) { }

	// RVA: 0x32CD460 Offset: 0x32C9460 VA: 0x32CD460
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0x32CD2C8 Offset: 0x32C92C8 VA: 0x32CD2C8
	private void Throw(string res, string arg) { }

	// RVA: 0x32CD500 Offset: 0x32C9500 VA: 0x32CD500
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x32CD370 Offset: 0x32C9370 VA: 0x32CD370
	private void Throw(string res, string[] args) { }

	// RVA: 0x32CD584 Offset: 0x32C9584 VA: 0x32CD584
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0x32CD604 Offset: 0x32C9604 VA: 0x32CD604
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0x32CD098 Offset: 0x32C9098 VA: 0x32CD098
	private void Throw(Exception e) { }

	// RVA: 0x32CD6B8 Offset: 0x32C96B8 VA: 0x32CD6B8
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0x32C8B78 Offset: 0x32C4B78 VA: 0x32C8B78
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0x32CD758 Offset: 0x32C9758 VA: 0x32CD758
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0x32CD7C8 Offset: 0x32C97C8 VA: 0x32CD7C8
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0x32CD84C Offset: 0x32C984C VA: 0x32CD84C
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x32CD6A4 Offset: 0x32C96A4 VA: 0x32CD6A4
	private void SetErrorState() { }

	// RVA: 0x32CBCFC Offset: 0x32C7CFC VA: 0x32CBCFC
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0x32CD8BC Offset: 0x32C98BC VA: 0x32CD8BC
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0x32C680C Offset: 0x32C280C VA: 0x32C680C
	private bool get_InAttributeValueIterator() { }

	// RVA: 0x32C6830 Offset: 0x32C2830 VA: 0x32C6830
	private void FinishAttributeValueIterator() { }

	// RVA: 0x32CAF54 Offset: 0x32C6F54 VA: 0x32CAF54
	private bool get_DtdValidation() { }

	// RVA: 0x32C4944 Offset: 0x32C0944 VA: 0x32C4944
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0x32C49B8 Offset: 0x32C09B8 VA: 0x32C49B8
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x32CDACC Offset: 0x32C9ACC VA: 0x32CDACC
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0x32CDB2C Offset: 0x32C9B2C VA: 0x32CDB2C
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x32C54B0 Offset: 0x32C14B0 VA: 0x32C54B0
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0x32C4BB0 Offset: 0x32C0BB0 VA: 0x32C4BB0
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0x32CDED0 Offset: 0x32C9ED0 VA: 0x32CDED0
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0x32C4CD0 Offset: 0x32C0CD0 VA: 0x32C4CD0
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0x32C4DD8 Offset: 0x32C0DD8 VA: 0x32C4DD8
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0x32C5788 Offset: 0x32C1788 VA: 0x32C5788
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0x32C77F4 Offset: 0x32C37F4 VA: 0x32C77F4
	private void OpenUrl() { }

	// RVA: 0x32CE1F8 Offset: 0x32CA1F8 VA: 0x32CE1F8
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0x32CDB3C Offset: 0x32C9B3C VA: 0x32CDB3C
	private Encoding DetectEncoding() { }

	// RVA: 0x32CDD64 Offset: 0x32C9D64 VA: 0x32CDD64
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0x32CE32C Offset: 0x32CA32C VA: 0x32CE32C
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0x32CE4C8 Offset: 0x32CA4C8 VA: 0x32CE4C8
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0x32CE41C Offset: 0x32CA41C VA: 0x32CE41C
	private void UnDecodeChars() { }

	// RVA: 0x32CE80C Offset: 0x32CA80C VA: 0x32CE80C
	private void SwitchEncodingToUTF8() { }

	// RVA: 0x32CB0B0 Offset: 0x32C70B0 VA: 0x32CB0B0
	private int ReadData() { }

	// RVA: 0x32CE878 Offset: 0x32CA878 VA: 0x32CE878
	private int GetChars(int maxCharsCount) { }

	// RVA: 0x32CE990 Offset: 0x32CA990 VA: 0x32CE990
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	// RVA: 0x32C8D84 Offset: 0x32C4D84 VA: 0x32C8D84
	internal void Close(bool closeInput) { }

	// RVA: 0x32CEB80 Offset: 0x32CAB80 VA: 0x32CEB80
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0x32C79AC Offset: 0x32C39AC VA: 0x32C79AC
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0x32C7304 Offset: 0x32C3304 VA: 0x32C7304
	private bool ParseDocumentContent() { }

	// RVA: 0x32C6FCC Offset: 0x32C2FCC VA: 0x32C6FCC
	private bool ParseElementContent() { }

	// RVA: 0x32D00E0 Offset: 0x32CC0E0 VA: 0x32D00E0
	private void ThrowUnclosedElements() { }

	// RVA: 0x32CF014 Offset: 0x32CB014 VA: 0x32CF014
	private void ParseElement() { }

	// RVA: 0x32D08AC Offset: 0x32CC8AC VA: 0x32D08AC
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0x32CFCE8 Offset: 0x32CBCE8 VA: 0x32CFCE8
	private void ParseEndElement() { }

	// RVA: 0x32D1A38 Offset: 0x32CDA38 VA: 0x32D1A38
	private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag) { }

	// RVA: 0x32D0288 Offset: 0x32CC288 VA: 0x32D0288
	private void ParseAttributes() { }

	// RVA: 0x32D12C4 Offset: 0x32CD2C4 VA: 0x32D12C4
	private void ElementNamespaceLookup() { }

	// RVA: 0x32D1988 Offset: 0x32CD988 VA: 0x32D1988
	private void AttributeNamespaceLookup() { }

	// RVA: 0x32D2B34 Offset: 0x32CEB34 VA: 0x32D2B34
	private void AttributeDuplCheck() { }

	// RVA: 0x32D2748 Offset: 0x32CE748 VA: 0x32D2748
	private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x32D2864 Offset: 0x32CE864 VA: 0x32D2864
	private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x32D2934 Offset: 0x32CE934 VA: 0x32D2934
	private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x32D1E30 Offset: 0x32CDE30 VA: 0x32D1E30
	private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x32D3264 Offset: 0x32CF264 VA: 0x32D3264
	private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk) { }

	// RVA: 0x32CF778 Offset: 0x32CB778 VA: 0x32CF778
	private bool ParseText() { }

	// RVA: 0x32CA374 Offset: 0x32C6374 VA: 0x32CA374
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	// RVA: 0x32C6044 Offset: 0x32C2044 VA: 0x32C6044
	private void FinishPartialValue() { }

	// RVA: 0x32C60FC Offset: 0x32C20FC VA: 0x32C60FC
	private void FinishOtherValueIterator() { }

	// RVA: 0x32C8C04 Offset: 0x32C4C04 VA: 0x32C8C04
	private void SkipPartialTextValue() { }

	// RVA: 0x32C8C44 Offset: 0x32C4C44 VA: 0x32C8C44
	private void FinishReadValueChunk() { }

	// RVA: 0x32C8C64 Offset: 0x32C4C64 VA: 0x32C8C64
	private void FinishReadContentAsBinary() { }

	// RVA: 0x32C8CB4 Offset: 0x32C4CB4 VA: 0x32C8CB4
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0x32CFAEC Offset: 0x32CBAEC VA: 0x32CFAEC
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0x32C8740 Offset: 0x32C4740 VA: 0x32C8740
	private void ParseEntityReference() { }

	// RVA: 0x32CF4B0 Offset: 0x32CB4B0 VA: 0x32CF4B0
	private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos) { }

	// RVA: 0x32C99A0 Offset: 0x32C59A0 VA: 0x32C99A0
	private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0x32CE7FC Offset: 0x32CA7FC VA: 0x32CE7FC
	private bool get_InEntity() { }

	// RVA: 0x32CD984 Offset: 0x32C9984 VA: 0x32CD984
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0x32C87B4 Offset: 0x32C47B4 VA: 0x32C87B4
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0x32D3634 Offset: 0x32CF634 VA: 0x32D3634
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0x32CED0C Offset: 0x32CAD0C VA: 0x32CED0C
	private bool ParsePI() { }

	// RVA: 0x32CB684 Offset: 0x32C7684 VA: 0x32CB684
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0x32D36AC Offset: 0x32CF6AC VA: 0x32D36AC
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	// RVA: 0x32CED14 Offset: 0x32CAD14 VA: 0x32CED14
	private bool ParseComment() { }

	// RVA: 0x32CED78 Offset: 0x32CAD78 VA: 0x32CED78
	private void ParseCData() { }

	// RVA: 0x32CBBA4 Offset: 0x32C7BA4 VA: 0x32CBBA4
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0x32D3A3C Offset: 0x32CFA3C VA: 0x32D3A3C
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	// RVA: 0x32CED80 Offset: 0x32CAD80 VA: 0x32CED80
	private bool ParseDoctypeDecl() { }

	// RVA: 0x32D3E78 Offset: 0x32CFE78 VA: 0x32D3E78
	private void ParseDtd() { }

	// RVA: 0x32D41A0 Offset: 0x32D01A0 VA: 0x32D41A0
	private void SkipDtd() { }

	// RVA: 0x32D450C Offset: 0x32D050C VA: 0x32D450C
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0x32D45C4 Offset: 0x32D05C4 VA: 0x32D45C4
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	// RVA: 0x32CCB90 Offset: 0x32C8B90 VA: 0x32CCB90
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0x32D345C Offset: 0x32CF45C VA: 0x32D345C
	private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x32CB528 Offset: 0x32C7528 VA: 0x32CB528
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x32D4A00 Offset: 0x32D0A00 VA: 0x32D4A00
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x32CB5DC Offset: 0x32C75DC VA: 0x32CB5DC
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x32D5084 Offset: 0x32D1084 VA: 0x32D5084
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x32CEBA8 Offset: 0x32CABA8 VA: 0x32CEBA8
	private int ParseName() { }

	// RVA: 0x32D0278 Offset: 0x32CC278 VA: 0x32D0278
	private int ParseQName(out int colonPos) { }

	// RVA: 0x32D5360 Offset: 0x32D1360 VA: 0x32D5360
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	// RVA: 0x32D55F4 Offset: 0x32D15F4 VA: 0x32D55F4
	private bool ReadDataInName(ref int pos) { }

	// RVA: 0x32D32C8 Offset: 0x32CF2C8 VA: 0x32D32C8
	private string ParseEntityName() { }

	// RVA: 0x32C86B8 Offset: 0x32C46B8 VA: 0x32C86B8
	private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x32D5634 Offset: 0x32D1634 VA: 0x32D5634
	private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x32CD1AC Offset: 0x32C91AC VA: 0x32CD1AC
	private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0x32D1C80 Offset: 0x32CDC80 VA: 0x32D1C80
	private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0x32D5788 Offset: 0x32D1788 VA: 0x32D5788
	private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x32C86FC Offset: 0x32C46FC VA: 0x32C86FC
	private void PopElementContext() { }

	// RVA: 0x32CB088 Offset: 0x32C7088 VA: 0x32CB088
	private void OnNewLine(int pos) { }

	// RVA: 0x32C8AD8 Offset: 0x32C4AD8 VA: 0x32C8AD8
	private void OnEof() { }

	// RVA: 0x32D2EB8 Offset: 0x32CEEB8 VA: 0x32D2EB8
	private string LookupNamespace(XmlTextReaderImpl.NodeData node) { }

	// RVA: 0x32D3008 Offset: 0x32CF008 VA: 0x32D3008
	private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x32C868C Offset: 0x32C468C VA: 0x32C868C
	private void ResetAttributes() { }

	// RVA: 0x32D58F4 Offset: 0x32D18F4 VA: 0x32D58F4
	private void FullAttributeCleanup() { }

	// RVA: 0x32D2F7C Offset: 0x32CEF7C VA: 0x32D2F7C
	private void PushXmlContext() { }

	// RVA: 0x32D58BC Offset: 0x32D18BC VA: 0x32D58BC
	private void PopXmlContext() { }

	// RVA: 0x32D35EC Offset: 0x32CF5EC VA: 0x32D35EC
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0x32D3404 Offset: 0x32CF404 VA: 0x32D3404
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0x32CC7FC Offset: 0x32C87FC VA: 0x32CC7FC
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0x32D597C Offset: 0x32D197C VA: 0x32D597C
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0x32CBF4C Offset: 0x32C7F4C VA: 0x32CBF4C
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x32CC2DC Offset: 0x32C82DC VA: 0x32CC2DC
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x32CC668 Offset: 0x32C8668 VA: 0x32CC668
	private void PopEntity() { }

	// RVA: 0x32D5BB0 Offset: 0x32D1BB0 VA: 0x32D5BB0
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0x32D5DC0 Offset: 0x32D1DC0 VA: 0x32D5DC0
	private void UnregisterEntity() { }

	// RVA: 0x32CCE58 Offset: 0x32C8E58 VA: 0x32CCE58
	private void PushParsingState() { }

	// RVA: 0x32CEB0C Offset: 0x32CAB0C VA: 0x32CEB0C
	private void PopParsingState() { }

	// RVA: 0x32D5E24 Offset: 0x32D1E24 VA: 0x32D5E24
	private int IncrementalRead() { }

	// RVA: 0x32C8918 Offset: 0x32C4918 VA: 0x32C8918
	private void FinishIncrementalRead() { }

	// RVA: 0x32C8994 Offset: 0x32C4994 VA: 0x32C8994
	private bool ParseFragmentAttribute() { }

	// RVA: 0x32C92C0 Offset: 0x32C52C0 VA: 0x32C92C0
	private bool ParseAttributeValueChunk() { }

	// RVA: 0x32C8A1C Offset: 0x32C4A1C VA: 0x32C8A1C
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0x32CED68 Offset: 0x32CAD68 VA: 0x32CED68
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x32CEBA0 Offset: 0x32CABA0 VA: 0x32CEBA0
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0x32CF004 Offset: 0x32CB004 VA: 0x32CF004
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x32CEBC8 Offset: 0x32CABC8 VA: 0x32CEBC8
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0x32CEFFC Offset: 0x32CAFFC VA: 0x32CEFFC
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0x32D6748 Offset: 0x32D2748 VA: 0x32D6748
	private string ParseUnexpectedToken() { }

	// RVA: 0x32D1C00 Offset: 0x32CDC00 VA: 0x32D1C00
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0x32C6394 Offset: 0x32C2394 VA: 0x32C6394
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0x32C647C Offset: 0x32C247C VA: 0x32C647C
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0x32D34C8 Offset: 0x32CF4C8 VA: 0x32D34C8
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0x32CDFC4 Offset: 0x32C9FC4 VA: 0x32CDFC4
	private void ParseDtdFromParserContext() { }

	// RVA: 0x32D3544 Offset: 0x32CF544 VA: 0x32D3544
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0x32C456C Offset: 0x32C056C VA: 0x32C456C
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x32D6810 Offset: 0x32D2810 VA: 0x32D6810 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x32D6818 Offset: 0x32D2818 VA: 0x32D6818
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0x32D6968 Offset: 0x32D2968 VA: 0x32D6968
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0x32D6978 Offset: 0x32D2978 VA: 0x32D6978
	internal void set_OnDefaultAttributeUse(XmlTextReaderImpl.OnDefaultAttributeUseDelegate value) { }

	// RVA: 0x32D6988 Offset: 0x32D2988 VA: 0x32D6988
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x32D6A60 Offset: 0x32D2A60 VA: 0x32D6A60
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0x32D6A68 Offset: 0x32D2A68 VA: 0x32D6A68
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0x32D6A84 Offset: 0x32D2A84 VA: 0x32D6A84
	internal XmlResolver GetResolver() { }

	// RVA: 0x32D6ABC Offset: 0x32D2ABC VA: 0x32D6ABC
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0x32D6AD8 Offset: 0x32D2AD8 VA: 0x32D6AD8
	internal object get_InternalTypedValue() { }

	// RVA: 0x32D6AF4 Offset: 0x32D2AF4 VA: 0x32D6AF4
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0x32D6B10 Offset: 0x32D2B10 VA: 0x32D6B10
	internal bool get_StandAlone() { }

	// RVA: 0x32D6B18 Offset: 0x32D2B18 VA: 0x32D6B18 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x32D6B20 Offset: 0x32D2B20 VA: 0x32D6B20
	internal bool get_V1Compat() { }

	// RVA: 0x32D1310 Offset: 0x32CD310 VA: 0x32D1310
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData) { }

	// RVA: 0x32D6D84 Offset: 0x32D2D84 VA: 0x32D6D84
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0x32D6B28 Offset: 0x32D2B28 VA: 0x32D6B28
	private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0x32D6F98 Offset: 0x32D2F98 VA: 0x32D6F98
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0x32C59C0 Offset: 0x32C19C0 VA: 0x32C59C0
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0x32CCFA8 Offset: 0x32C8FA8 VA: 0x32CCFA8
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	// RVA: 0x32D6FA4 Offset: 0x32D2FA4 VA: 0x32D6FA4
	internal static string StripSpaces(string value) { }

	// RVA: 0x32D71C8 Offset: 0x32D31C8 VA: 0x32D71C8
	internal static void StripSpaces(char[] value, int index, ref int len) { }

	// RVA: 0x32CA94C Offset: 0x32C694C VA: 0x32CA94C
	internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0x32CE870 Offset: 0x32CA870 VA: 0x32CE870
	internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count) { }
}

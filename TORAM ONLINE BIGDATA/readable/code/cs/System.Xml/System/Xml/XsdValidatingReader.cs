// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 13385
{
	// Fields
	private XmlReader coreReader; // 0x10
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x18
	private IXmlNamespaceResolver thisNSResolver; // 0x20
	private XmlSchemaValidator validator; // 0x28
	private XmlResolver xmlResolver; // 0x30
	private ValidationEventHandler validationEvent; // 0x38
	private XsdValidatingReader.ValidatingReaderState validationState; // 0x40
	private XmlValueGetter valueGetter; // 0x48
	private XmlNamespaceManager nsManager; // 0x50
	private bool manageNamespaces; // 0x58
	private bool processInlineSchema; // 0x59
	private bool replayCache; // 0x5A
	private ValidatingReaderNodeData cachedNode; // 0x60
	private AttributePSVIInfo attributePSVI; // 0x68
	private int attributeCount; // 0x70
	private int coreReaderAttributeCount; // 0x74
	private int currentAttrIndex; // 0x78
	private AttributePSVIInfo[] attributePSVINodes; // 0x80
	private ArrayList defaultAttributes; // 0x88
	private Parser inlineSchemaParser; // 0x90
	private object atomicValue; // 0x98
	private XmlSchemaInfo xmlSchemaInfo; // 0xA0
	private string originalAtomicValueString; // 0xA8
	private XmlNameTable coreReaderNameTable; // 0xB0
	private XsdCachingReader cachingReader; // 0xB8
	private ValidatingReaderNodeData textNode; // 0xC0
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsdSchema; // 0xF0
	private string XsiSchemaLocation; // 0xF8
	private string XsiNoNamespaceSchemaLocation; // 0x100
	private XmlCharType xmlCharType; // 0x108
	private IXmlLineInfo lineInfo; // 0x110
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x118
	private XsdValidatingReader.ValidatingReaderState savedState; // 0x120
	private static Type TypeOfString; // 0x0

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
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	private XmlSchemaInfo AttributeSchemaInfo { get; }

	// Methods

	// RVA: 0x33AC86C Offset: 0x33A886C VA: 0x33AC86C
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x33AD04C Offset: 0x33A904C VA: 0x33AD04C
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x33ACA78 Offset: 0x33A8A78 VA: 0x33ACA78
	private void Init() { }

	// RVA: 0x33ACE3C Offset: 0x33A8E3C VA: 0x33ACE3C
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x33AD054 Offset: 0x33A9054 VA: 0x33AD054 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x33AD124 Offset: 0x33A9124 VA: 0x33AD124 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33AD1AC Offset: 0x33A91AC VA: 0x33AD1AC Slot: 7
	public override string get_Name() { }

	// RVA: 0x33AD2C4 Offset: 0x33A92C4 VA: 0x33AD2C4 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x33AD300 Offset: 0x33A9300 VA: 0x33AD300 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x33AD33C Offset: 0x33A933C VA: 0x33AD33C Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x33AD378 Offset: 0x33A9378 VA: 0x33AD378 Slot: 11
	public override string get_Value() { }

	// RVA: 0x33AD3B4 Offset: 0x33A93B4 VA: 0x33AD3B4 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x33AD3F0 Offset: 0x33A93F0 VA: 0x33AD3F0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x33AD414 Offset: 0x33A9414 VA: 0x33AD414 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x33AD438 Offset: 0x33A9438 VA: 0x33AD438 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x33AD474 Offset: 0x33A9474 VA: 0x33AD474 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x33AD498 Offset: 0x33A9498 VA: 0x33AD498 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x33AD4BC Offset: 0x33A94BC VA: 0x33AD4BC Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x33AD4E0 Offset: 0x33A94E0 VA: 0x33AD4E0 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x33AD4E4 Offset: 0x33A94E4 VA: 0x33AD4E4 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x33AD5C8 Offset: 0x33A95C8 VA: 0x33AD5C8 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x33AD5D0 Offset: 0x33A95D0 VA: 0x33AD5D0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x33AD7C0 Offset: 0x33A97C0 VA: 0x33AD7C0 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x33ADA04 Offset: 0x33A9A04 VA: 0x33ADA04 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x33ADAE0 Offset: 0x33A9AE0 VA: 0x33ADAE0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x33ADD3C Offset: 0x33A9D3C VA: 0x33ADD3C Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x33ADF08 Offset: 0x33A9F08 VA: 0x33ADF08 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x33AE098 Offset: 0x33AA098 VA: 0x33AE098 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x33AE228 Offset: 0x33AA228 VA: 0x33AE228 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x33AE27C Offset: 0x33AA27C VA: 0x33AE27C Slot: 31
	public override bool Read() { }

	// RVA: 0x33AE684 Offset: 0x33AA684 VA: 0x33AE684 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x33AE6A8 Offset: 0x33AA6A8 VA: 0x33AE6A8 Slot: 33
	public override void Close() { }

	// RVA: 0x33AE6DC Offset: 0x33AA6DC VA: 0x33AE6DC Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x33AE718 Offset: 0x33AA718 VA: 0x33AE718 Slot: 35
	public override void Skip() { }

	// RVA: 0x33AE884 Offset: 0x33AA884 VA: 0x33AE884 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x33AE88C Offset: 0x33AA88C VA: 0x33AE88C Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x33AE938 Offset: 0x33AA938 VA: 0x33AE938 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x33AE970 Offset: 0x33AA970 VA: 0x33AE970 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x33AEAD8 Offset: 0x33AAAD8 VA: 0x33AEAD8 Slot: 54
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x33AEE00 Offset: 0x33AAE00 VA: 0x33AEE00 Slot: 55
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x33AEE4C Offset: 0x33AAE4C VA: 0x33AEE4C Slot: 53
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x33AEEE0 Offset: 0x33AAEE0 VA: 0x33AEEE0 Slot: 56
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x33AF068 Offset: 0x33AB068 VA: 0x33AF068 Slot: 57
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x33AF0C4 Offset: 0x33AB0C4 VA: 0x33AF0C4 Slot: 58
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x33AF118 Offset: 0x33AB118 VA: 0x33AF118 Slot: 59
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x33AF15C Offset: 0x33AB15C VA: 0x33AF15C Slot: 60
	public bool HasLineInfo() { }

	// RVA: 0x33AF164 Offset: 0x33AB164 VA: 0x33AF164 Slot: 61
	public int get_LineNumber() { }

	// RVA: 0x33AF214 Offset: 0x33AB214 VA: 0x33AF214 Slot: 62
	public int get_LinePosition() { }

	// RVA: 0x33AF2C4 Offset: 0x33AB2C4 VA: 0x33AF2C4 Slot: 63
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x33AF384 Offset: 0x33AB384 VA: 0x33AF384 Slot: 64
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x33AF448 Offset: 0x33AB448 VA: 0x33AF448 Slot: 65
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x33AF50C Offset: 0x33AB50C VA: 0x33AF50C
	private object GetStringValue() { }

	// RVA: 0x33AD5AC Offset: 0x33A95AC VA: 0x33AD5AC
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x33AE3CC Offset: 0x33AA3CC VA: 0x33AE3CC
	private void ProcessReaderEvent() { }

	// RVA: 0x33AF52C Offset: 0x33AB52C VA: 0x33AF52C
	private void ProcessElementEvent() { }

	// RVA: 0x33AF9F0 Offset: 0x33AB9F0 VA: 0x33AF9F0
	private void ProcessEndElementEvent() { }

	// RVA: 0x33AFBA4 Offset: 0x33ABBA4 VA: 0x33AFBA4
	private void ValidateAttributes() { }

	// RVA: 0x33AE640 Offset: 0x33AA640 VA: 0x33AE640
	private void ClearAttributesInfo() { }

	// RVA: 0x33ADBBC Offset: 0x33A9BBC VA: 0x33ADBBC
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x33B0064 Offset: 0x33AC064 VA: 0x33B0064
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x33AD63C Offset: 0x33A963C VA: 0x33AD63C
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x33AD8C0 Offset: 0x33A98C0 VA: 0x33AD8C0
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x33AFF00 Offset: 0x33ABF00 VA: 0x33AFF00
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x33AFB54 Offset: 0x33ABB54 VA: 0x33AFB54
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x33AE578 Offset: 0x33AA578 VA: 0x33AE578
	private void ProcessInlineSchema() { }

	// RVA: 0x33B010C Offset: 0x33AC10C VA: 0x33B010C
	private void ReadAheadForMemberType() { }

	// RVA: 0x33AEB60 Offset: 0x33AAB60 VA: 0x33AEB60
	private void GetIsDefault() { }

	// RVA: 0x33AEF60 Offset: 0x33AAF60 VA: 0x33AEF60
	private void GetMemberType() { }

	// RVA: 0x33AFE00 Offset: 0x33ABE00 VA: 0x33AFE00
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x33AEA38 Offset: 0x33AAA38 VA: 0x33AEA38
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x33B0300 Offset: 0x33AC300 VA: 0x33B0300
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x33AFD70 Offset: 0x33ABD70 VA: 0x33AFD70
	private string GetOriginalAtomicValueStringOfElement() { }
}

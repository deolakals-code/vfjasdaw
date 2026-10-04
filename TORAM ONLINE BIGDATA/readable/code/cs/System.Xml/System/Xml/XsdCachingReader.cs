// Assembly: System.Xml.dll
// Namespace: System.Xml
[DefaultMember("Item")]
internal class XsdCachingReader : XmlReader, IXmlLineInfo // TypeDefIndex: 13381
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlNameTable coreReaderNameTable; // 0x18
	private ValidatingReaderNodeData[] contentEvents; // 0x20
	private ValidatingReaderNodeData[] attributeEvents; // 0x28
	private ValidatingReaderNodeData cachedNode; // 0x30
	private XsdCachingReader.CachingReaderState cacheState; // 0x38
	private int contentIndex; // 0x3C
	private int attributeCount; // 0x40
	private bool returnOriginalStringValues; // 0x44
	private CachingEventHandler cacheHandler; // 0x48
	private int currentAttrIndex; // 0x50
	private int currentContentIndex; // 0x54
	private bool readAhead; // 0x58
	private IXmlLineInfo lineInfo; // 0x60
	private ValidatingReaderNodeData textNode; // 0x68

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
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x33AAEE0 Offset: 0x33A6EE0 VA: 0x33AAEE0
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x33AAFD8 Offset: 0x33A6FD8 VA: 0x33AAFD8
	private void Init() { }

	// RVA: 0x33AB458 Offset: 0x33A7458 VA: 0x33AB458
	internal void Reset(XmlReader reader) { }

	// RVA: 0x33AB474 Offset: 0x33A7474 VA: 0x33AB474 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x33AB494 Offset: 0x33A7494 VA: 0x33AB494 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33AB4B0 Offset: 0x33A74B0 VA: 0x33AB4B0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x33AB4D4 Offset: 0x33A74D4 VA: 0x33AB4D4 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x33AB4F0 Offset: 0x33A74F0 VA: 0x33AB4F0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x33AB50C Offset: 0x33A750C VA: 0x33AB50C Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x33AB528 Offset: 0x33A7528 VA: 0x33AB528 Slot: 11
	public override string get_Value() { }

	// RVA: 0x33AB558 Offset: 0x33A7558 VA: 0x33AB558 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x33AB574 Offset: 0x33A7574 VA: 0x33AB574 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x33AB598 Offset: 0x33A7598 VA: 0x33AB598 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x33AB5A0 Offset: 0x33A75A0 VA: 0x33AB5A0 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x33AB5A8 Offset: 0x33A75A8 VA: 0x33AB5A8 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x33AB5CC Offset: 0x33A75CC VA: 0x33AB5CC Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x33AB5F0 Offset: 0x33A75F0 VA: 0x33AB5F0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x33AB614 Offset: 0x33A7614 VA: 0x33AB614 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x33AB61C Offset: 0x33A761C VA: 0x33AB61C Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x33AB7F8 Offset: 0x33A77F8 VA: 0x33AB7F8 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x33AB910 Offset: 0x33A7910 VA: 0x33AB910 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x33AB9A0 Offset: 0x33A79A0 VA: 0x33AB9A0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x33ABA38 Offset: 0x33A7A38 VA: 0x33ABA38 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x33ABAC8 Offset: 0x33A7AC8 VA: 0x33ABAC8 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x33ABB0C Offset: 0x33A7B0C VA: 0x33ABB0C Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x33ABB6C Offset: 0x33A7B6C VA: 0x33ABB6C Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x33ABBC0 Offset: 0x33A7BC0 VA: 0x33ABBC0 Slot: 31
	public override bool Read() { }

	// RVA: 0x33ABEB0 Offset: 0x33A7EB0 VA: 0x33ABEB0
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x33ABF28 Offset: 0x33A7F28 VA: 0x33ABF28
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x33AC038 Offset: 0x33A8038 VA: 0x33AC038
	internal void RecordEndElementNode() { }

	// RVA: 0x33AC168 Offset: 0x33A8168 VA: 0x33AC168 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x33AC1A4 Offset: 0x33A81A4 VA: 0x33AC1A4 Slot: 33
	public override void Close() { }

	// RVA: 0x33AC1D8 Offset: 0x33A81D8 VA: 0x33AC1D8 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x33AC1FC Offset: 0x33A81FC VA: 0x33AC1FC Slot: 35
	public override void Skip() { }

	// RVA: 0x33AC310 Offset: 0x33A8310 VA: 0x33AC310 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x33AC318 Offset: 0x33A8318 VA: 0x33AC318 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x33AC33C Offset: 0x33A833C VA: 0x33AC33C Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x33AC374 Offset: 0x33A8374 VA: 0x33AC374 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x33AC470 Offset: 0x33A8470 VA: 0x33AC470 Slot: 53
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x33AC478 Offset: 0x33A8478 VA: 0x33AC478 Slot: 54
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x33AC494 Offset: 0x33A8494 VA: 0x33AC494 Slot: 55
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x33AC4B0 Offset: 0x33A84B0 VA: 0x33AC4B0
	internal void SetToReplayMode() { }

	// RVA: 0x33AC4D0 Offset: 0x33A84D0 VA: 0x33AC4D0
	internal XmlReader GetCoreReader() { }

	// RVA: 0x33AC4D8 Offset: 0x33A84D8 VA: 0x33AC4D8
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x33ABEA0 Offset: 0x33A7EA0 VA: 0x33ABEA0
	private void ClearAttributesInfo() { }

	// RVA: 0x33AC4E0 Offset: 0x33A84E0 VA: 0x33AC4E0
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x33AB144 Offset: 0x33A7144 VA: 0x33AB144
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x33AB2D4 Offset: 0x33A72D4 VA: 0x33AB2D4
	private void RecordAttributes() { }

	// RVA: 0x33AB6A8 Offset: 0x33A76A8 VA: 0x33AB6A8
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x33AB758 Offset: 0x33A7758 VA: 0x33AB758
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x33AC3D0 Offset: 0x33A83D0 VA: 0x33AC3D0
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }
}

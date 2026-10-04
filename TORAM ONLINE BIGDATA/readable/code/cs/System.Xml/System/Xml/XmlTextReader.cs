// Assembly: System.Xml.dll
// Namespace: System.Xml
[EditorBrowsable(1)]
public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 13331
{
	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Properties
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
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public bool Namespaces { get; }
	public bool Normalization { get; set; }
	public WhitespaceHandling WhitespaceHandling { set; }
	public EntityHandling EntityHandling { set; }
	public XmlResolver XmlResolver { set; }
	internal XmlTextReaderImpl Impl { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x3395AB4 Offset: 0x3391AB4 VA: 0x3395AB4
	public void .ctor(Stream input) { }

	// RVA: 0x3395B74 Offset: 0x3391B74 VA: 0x3395B74
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x3395C4C Offset: 0x3391C4C VA: 0x3395C4C
	public void .ctor(TextReader input) { }

	// RVA: 0x3395D0C Offset: 0x3391D0C VA: 0x3395D0C
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x3395DD4 Offset: 0x3391DD4 VA: 0x3395DD4 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x3395DF4 Offset: 0x3391DF4 VA: 0x3395DF4 Slot: 7
	public override string get_Name() { }

	// RVA: 0x3395E14 Offset: 0x3391E14 VA: 0x3395E14 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x3395E34 Offset: 0x3391E34 VA: 0x3395E34 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x3395E54 Offset: 0x3391E54 VA: 0x3395E54 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x3395E74 Offset: 0x3391E74 VA: 0x3395E74 Slot: 11
	public override string get_Value() { }

	// RVA: 0x3395E94 Offset: 0x3391E94 VA: 0x3395E94 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x3395EB4 Offset: 0x3391EB4 VA: 0x3395EB4 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x3395ED8 Offset: 0x3391ED8 VA: 0x3395ED8 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x3395EFC Offset: 0x3391EFC VA: 0x3395EFC Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x3395F20 Offset: 0x3391F20 VA: 0x3395F20 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x3395F44 Offset: 0x3391F44 VA: 0x3395F44 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x3395F68 Offset: 0x3391F68 VA: 0x3395F68 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x3395F8C Offset: 0x3391F8C VA: 0x3395F8C Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x3395FB0 Offset: 0x3391FB0 VA: 0x3395FB0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x3395FD4 Offset: 0x3391FD4 VA: 0x3395FD4 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x3395FF8 Offset: 0x3391FF8 VA: 0x3395FF8 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x339601C Offset: 0x339201C VA: 0x339601C Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x3396040 Offset: 0x3392040 VA: 0x3396040 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x3396064 Offset: 0x3392064 VA: 0x3396064 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x3396088 Offset: 0x3392088 VA: 0x3396088 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x33960AC Offset: 0x33920AC VA: 0x33960AC Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x33960D0 Offset: 0x33920D0 VA: 0x33960D0 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x33960F4 Offset: 0x33920F4 VA: 0x33960F4 Slot: 31
	public override bool Read() { }

	// RVA: 0x3396118 Offset: 0x3392118 VA: 0x3396118 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x339613C Offset: 0x339213C VA: 0x339613C Slot: 33
	public override void Close() { }

	// RVA: 0x3396160 Offset: 0x3392160 VA: 0x3396160 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x3396184 Offset: 0x3392184 VA: 0x3396184 Slot: 35
	public override void Skip() { }

	// RVA: 0x33961A8 Offset: 0x33921A8 VA: 0x33961A8 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x33961CC Offset: 0x33921CC VA: 0x33961CC Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x3396204 Offset: 0x3392204 VA: 0x3396204 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x339620C Offset: 0x339220C VA: 0x339620C Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x3396230 Offset: 0x3392230 VA: 0x3396230 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x3396238 Offset: 0x3392238 VA: 0x3396238 Slot: 42
	public override string ReadString() { }

	// RVA: 0x3396260 Offset: 0x3392260 VA: 0x3396260 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0x3396268 Offset: 0x3392268 VA: 0x3396268 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0x3396284 Offset: 0x3392284 VA: 0x3396284 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0x33962A0 Offset: 0x33922A0 VA: 0x33962A0 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x33962BC Offset: 0x33922BC VA: 0x33962BC Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x33962E0 Offset: 0x33922E0 VA: 0x33962E0 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x3393080 Offset: 0x338F080 VA: 0x3393080
	public bool get_Namespaces() { }

	// RVA: 0x33962FC Offset: 0x33922FC VA: 0x33962FC
	public bool get_Normalization() { }

	// RVA: 0x3396318 Offset: 0x3392318 VA: 0x3396318
	public void set_Normalization(bool value) { }

	// RVA: 0x3396338 Offset: 0x3392338 VA: 0x3396338
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x3396354 Offset: 0x3392354 VA: 0x3396354
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x3396370 Offset: 0x3392370 VA: 0x3396370
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x339638C Offset: 0x339238C VA: 0x339638C
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0x3396394 Offset: 0x3392394 VA: 0x3396394 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x33963B8 Offset: 0x33923B8 VA: 0x33963B8
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x33963D8 Offset: 0x33923D8 VA: 0x33963D8 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }
}

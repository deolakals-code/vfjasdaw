// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlNodeReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 13416
{
	// Fields
	private XmlNodeReaderNavigator readerNav; // 0x10
	private XmlNodeType nodeType; // 0x18
	private int curDepth; // 0x1C
	private ReadState readState; // 0x20
	private bool fEOF; // 0x24
	private bool bResolveEntity; // 0x25
	private bool bStartFromDocument; // 0x26
	private bool bInReadBinary; // 0x27
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool CanResolveEntity { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override bool HasAttributes { get; }
	public override XmlNameTable NameTable { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x33C7020 Offset: 0x33C3020 VA: 0x33C7020
	public void .ctor(XmlNode node) { }

	// RVA: 0x33C7114 Offset: 0x33C3114 VA: 0x33C7114
	internal bool IsInReadingStates() { }

	// RVA: 0x33C7124 Offset: 0x33C3124 VA: 0x33C7124 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33C7140 Offset: 0x33C3140 VA: 0x33C7140 Slot: 7
	public override string get_Name() { }

	// RVA: 0x33C71B0 Offset: 0x33C31B0 VA: 0x33C71B0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x33C7220 Offset: 0x33C3220 VA: 0x33C7220 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x33C72A4 Offset: 0x33C32A4 VA: 0x33C72A4 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x33C7328 Offset: 0x33C3328 VA: 0x33C7328 Slot: 11
	public override string get_Value() { }

	// RVA: 0x33C7398 Offset: 0x33C3398 VA: 0x33C7398 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x33C73A0 Offset: 0x33C33A0 VA: 0x33C73A0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x33C73CC Offset: 0x33C33CC VA: 0x33C73CC Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x33C73D4 Offset: 0x33C33D4 VA: 0x33C73D4 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x33C7404 Offset: 0x33C3404 VA: 0x33C7404 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x33C7434 Offset: 0x33C3434 VA: 0x33C7434 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x33C7478 Offset: 0x33C3478 VA: 0x33C7478 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x33C74FC Offset: 0x33C34FC VA: 0x33C74FC Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x33C7540 Offset: 0x33C3540 VA: 0x33C7540 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x33C757C Offset: 0x33C357C VA: 0x33C757C Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x33C75AC Offset: 0x33C35AC VA: 0x33C75AC Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x33C7640 Offset: 0x33C3640 VA: 0x33C7640 Slot: 24
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x33C76AC Offset: 0x33C36AC VA: 0x33C76AC Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x33C77A0 Offset: 0x33C37A0 VA: 0x33C77A0 Slot: 26
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x33C7978 Offset: 0x33C3978 VA: 0x33C7978 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x33C7A58 Offset: 0x33C3A58 VA: 0x33C7A58 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x33C7B50 Offset: 0x33C3B50 VA: 0x33C7B50 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x33C7C48 Offset: 0x33C3C48 VA: 0x33C7C48 Slot: 31
	public override bool Read() { }

	// RVA: 0x33C7C50 Offset: 0x33C3C50 VA: 0x33C7C50
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x33C7D54 Offset: 0x33C3D54 VA: 0x33C7D54
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x33C8008 Offset: 0x33C4008 VA: 0x33C8008
	private void SetEndOfFile() { }

	// RVA: 0x33C8020 Offset: 0x33C4020 VA: 0x33C8020
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x33C7F24 Offset: 0x33C3F24 VA: 0x33C7F24
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x33C7F00 Offset: 0x33C3F00 VA: 0x33C7F00
	private void ReSetReadingMarks() { }

	// RVA: 0x33C8090 Offset: 0x33C4090 VA: 0x33C8090 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x33C80B4 Offset: 0x33C40B4 VA: 0x33C80B4 Slot: 33
	public override void Close() { }

	// RVA: 0x33C80C0 Offset: 0x33C40C0 VA: 0x33C80C0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x33C80C8 Offset: 0x33C40C8 VA: 0x33C80C8 Slot: 35
	public override void Skip() { }

	// RVA: 0x33C80D0 Offset: 0x33C40D0 VA: 0x33C80D0 Slot: 42
	public override string ReadString() { }

	// RVA: 0x33C8174 Offset: 0x33C4174 VA: 0x33C8174 Slot: 49
	public override bool get_HasAttributes() { }

	// RVA: 0x33C8198 Offset: 0x33C4198 VA: 0x33C8198 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x33C81B4 Offset: 0x33C41B4 VA: 0x33C81B4 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x33C81EC Offset: 0x33C41EC VA: 0x33C81EC Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x33C8270 Offset: 0x33C4270 VA: 0x33C8270 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x33C777C Offset: 0x33C377C VA: 0x33C777C
	private void FinishReadBinary() { }

	// RVA: 0x33C82BC Offset: 0x33C42BC VA: 0x33C82BC Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x33C82D4 Offset: 0x33C42D4 VA: 0x33C82D4 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x33C82EC Offset: 0x33C42EC VA: 0x33C82EC Slot: 54
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x33C8348 Offset: 0x33C4348 VA: 0x33C8348 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }
}

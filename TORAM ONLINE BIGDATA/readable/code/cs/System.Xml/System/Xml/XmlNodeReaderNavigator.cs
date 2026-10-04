// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class XmlNodeReaderNavigator // TypeDefIndex: 13415
{
	// Fields
	private XmlNode curNode; // 0x10
	private XmlNode elemNode; // 0x18
	private XmlNode logNode; // 0x20
	private int attrIndex; // 0x28
	private int logAttrIndex; // 0x2C
	private XmlNameTable nameTable; // 0x30
	private XmlDocument doc; // 0x38
	private int nAttrInd; // 0x40
	private int nDeclarationAttrCount; // 0x44
	private int nDocTypeAttrCount; // 0x48
	private int nLogLevel; // 0x4C
	private int nLogAttrInd; // 0x50
	private bool bLogOnAttrVal; // 0x54
	private bool bCreatedOnAttribute; // 0x55
	internal XmlNodeReaderNavigator.VirtualAttribute[] decNodeAttributes; // 0x58
	internal XmlNodeReaderNavigator.VirtualAttribute[] docTypeNodeAttributes; // 0x60
	private bool bOnAttrVal; // 0x68

	// Properties
	public XmlNodeType NodeType { get; }
	public string NamespaceURI { get; }
	public string Name { get; }
	public string LocalName { get; }
	internal bool CreatedOnAttribute { get; }
	public string Prefix { get; }
	public string Value { get; }
	public string BaseURI { get; }
	public XmlSpace XmlSpace { get; }
	public string XmlLang { get; }
	public bool IsEmptyElement { get; }
	public bool IsDefault { get; }
	public IXmlSchemaInfo SchemaInfo { get; }
	public XmlNameTable NameTable { get; }
	public int AttributeCount { get; }
	private bool IsOnDeclOrDocType { get; }
	public XmlDocument Document { get; }

	// Methods

	// RVA: 0x33C3DDC Offset: 0x33BFDDC VA: 0x33C3DDC
	public void .ctor(XmlNode node) { }

	// RVA: 0x33C41A0 Offset: 0x33C01A0 VA: 0x33C41A0
	public XmlNodeType get_NodeType() { }

	// RVA: 0x33C41E4 Offset: 0x33C01E4 VA: 0x33C41E4
	public string get_NamespaceURI() { }

	// RVA: 0x33C4208 Offset: 0x33C0208 VA: 0x33C4208
	public string get_Name() { }

	// RVA: 0x33C431C Offset: 0x33C031C VA: 0x33C431C
	public string get_LocalName() { }

	// RVA: 0x33C43C8 Offset: 0x33C03C8 VA: 0x33C43C8
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0x33C42F8 Offset: 0x33C02F8 VA: 0x33C42F8
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0x33C43D0 Offset: 0x33C03D0 VA: 0x33C43D0
	public string get_Prefix() { }

	// RVA: 0x33C43F4 Offset: 0x33C03F4 VA: 0x33C43F4
	public string get_Value() { }

	// RVA: 0x33C4840 Offset: 0x33C0840 VA: 0x33C4840
	public string get_BaseURI() { }

	// RVA: 0x33C4864 Offset: 0x33C0864 VA: 0x33C4864
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x33C4888 Offset: 0x33C0888 VA: 0x33C4888
	public string get_XmlLang() { }

	// RVA: 0x33C48AC Offset: 0x33C08AC VA: 0x33C48AC
	public bool get_IsEmptyElement() { }

	// RVA: 0x33C4958 Offset: 0x33C0958 VA: 0x33C4958
	public bool get_IsDefault() { }

	// RVA: 0x33C4A0C Offset: 0x33C0A0C VA: 0x33C4A0C
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x33C4A30 Offset: 0x33C0A30 VA: 0x33C4A30
	public XmlNameTable get_NameTable() { }

	// RVA: 0x33C4A38 Offset: 0x33C0A38 VA: 0x33C4A38
	public int get_AttributeCount() { }

	// RVA: 0x33C4CA8 Offset: 0x33C0CA8 VA: 0x33C4CA8
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0x33C4674 Offset: 0x33C0674 VA: 0x33C4674
	private void InitDecAttr() { }

	// RVA: 0x33C4D10 Offset: 0x33C0D10 VA: 0x33C4D10
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0x33C4DF0 Offset: 0x33C0DF0 VA: 0x33C4DF0
	public string GetDeclarationAttr(int i) { }

	// RVA: 0x33C4E44 Offset: 0x33C0E44 VA: 0x33C4E44
	public int GetDecAttrInd(string name) { }

	// RVA: 0x33C4B74 Offset: 0x33C0B74 VA: 0x33C4B74
	private void InitDocTypeAttr() { }

	// RVA: 0x33C4EDC Offset: 0x33C0EDC VA: 0x33C4EDC
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0x33C4F88 Offset: 0x33C0F88 VA: 0x33C4F88
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0x33C4FDC Offset: 0x33C0FDC VA: 0x33C4FDC
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0x33C5074 Offset: 0x33C1074 VA: 0x33C5074
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0x33C50B8 Offset: 0x33C10B8 VA: 0x33C50B8
	public string GetAttribute(string name) { }

	// RVA: 0x33C5254 Offset: 0x33C1254 VA: 0x33C5254
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x33C529C Offset: 0x33C129C VA: 0x33C529C
	public string GetAttribute(string name, string ns) { }

	// RVA: 0x33C546C Offset: 0x33C146C VA: 0x33C546C
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0x33C5614 Offset: 0x33C1614 VA: 0x33C5614
	public void LogMove(int level) { }

	// RVA: 0x33C5658 Offset: 0x33C1658 VA: 0x33C5658
	public void RollBackMove(ref int level) { }

	// RVA: 0x33C56A4 Offset: 0x33C16A4 VA: 0x33C56A4
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0x33C56DC Offset: 0x33C16DC VA: 0x33C56DC
	public void ResetToAttribute(ref int level) { }

	// RVA: 0x33C5790 Offset: 0x33C1790 VA: 0x33C5790
	public void ResetMove(ref int level, ref XmlNodeType nt) { }

	// RVA: 0x33C5970 Offset: 0x33C1970 VA: 0x33C5970
	public bool MoveToAttribute(string name) { }

	// RVA: 0x33C5B28 Offset: 0x33C1B28 VA: 0x33C5B28
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x33C59D0 Offset: 0x33C19D0 VA: 0x33C59D0
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0x33C5BFC Offset: 0x33C1BFC VA: 0x33C5BFC
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x33C5DBC Offset: 0x33C1DBC VA: 0x33C5DBC
	public bool MoveToNextAttribute(ref int level) { }

	// RVA: 0x33C5FA8 Offset: 0x33C1FA8 VA: 0x33C5FA8
	public bool MoveToParent() { }

	// RVA: 0x33C6000 Offset: 0x33C2000 VA: 0x33C6000
	public bool MoveToFirstChild() { }

	// RVA: 0x33C6060 Offset: 0x33C2060 VA: 0x33C6060
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0x33C60C4 Offset: 0x33C20C4 VA: 0x33C60C4
	public bool MoveToNext() { }

	// RVA: 0x33C6104 Offset: 0x33C2104 VA: 0x33C6104
	public bool MoveToElement() { }

	// RVA: 0x33C6198 Offset: 0x33C2198 VA: 0x33C6198
	public string LookupNamespace(string prefix) { }

	// RVA: 0x33C643C Offset: 0x33C243C VA: 0x33C643C
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0x33C6574 Offset: 0x33C2574 VA: 0x33C6574
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x33C693C Offset: 0x33C293C VA: 0x33C693C
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x33C6E10 Offset: 0x33C2E10 VA: 0x33C6E10
	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	// RVA: 0x33C7018 Offset: 0x33C3018 VA: 0x33C7018
	public XmlDocument get_Document() { }
}

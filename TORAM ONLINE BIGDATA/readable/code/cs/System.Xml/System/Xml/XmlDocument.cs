// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlDocument : XmlNode // TypeDefIndex: 13395
{
	// Fields
	private XmlImplementation implementation; // 0x18
	private DomNameTable domNameTable; // 0x20
	private XmlLinkedNode lastChild; // 0x28
	private XmlNamedNodeMap entities; // 0x30
	private Hashtable htElementIdMap; // 0x38
	private Hashtable htElementIDAttrDecl; // 0x40
	private SchemaInfo schemaInfo; // 0x48
	private XmlSchemaSet schemas; // 0x50
	private bool reportValidity; // 0x58
	private bool actualLoadingStatus; // 0x59
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; // 0x60
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; // 0x68
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; // 0x70
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; // 0x78
	private XmlNodeChangedEventHandler onNodeChangingDelegate; // 0x80
	private XmlNodeChangedEventHandler onNodeChangedDelegate; // 0x88
	internal bool fEntRefNodesPresent; // 0x90
	internal bool fCDataNodesPresent; // 0x91
	private bool preserveWhitespace; // 0x92
	private bool isLoading; // 0x93
	internal string strDocumentName; // 0x98
	internal string strDocumentFragmentName; // 0xA0
	internal string strCommentName; // 0xA8
	internal string strTextName; // 0xB0
	internal string strCDataSectionName; // 0xB8
	internal string strEntityName; // 0xC0
	internal string strID; // 0xC8
	internal string strXmlns; // 0xD0
	internal string strXml; // 0xD8
	internal string strSpace; // 0xE0
	internal string strLang; // 0xE8
	internal string strEmpty; // 0xF0
	internal string strNonSignificantWhitespaceName; // 0xF8
	internal string strSignificantWhitespaceName; // 0x100
	internal string strReservedXmlns; // 0x108
	internal string strReservedXml; // 0x110
	internal string baseURI; // 0x118
	private XmlResolver resolver; // 0x120
	internal bool bSetResolver; // 0x128
	internal object objLock; // 0x130
	internal static EmptyEnumerator EmptyEnumerator; // 0x0
	internal static IXmlSchemaInfo NotKnownSchemaInfo; // 0x8
	internal static IXmlSchemaInfo ValidSchemaInfo; // 0x10
	internal static IXmlSchemaInfo InvalidSchemaInfo; // 0x18

	// Properties
	internal SchemaInfo DtdSchemaInfo { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public virtual XmlDocumentType DocumentType { get; }
	internal virtual XmlDeclaration Declaration { get; }
	public XmlImplementation Implementation { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public XmlElement DocumentElement { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlDocument OwnerDocument { get; }
	public XmlSchemaSet Schemas { set; }
	internal bool CanReportValidity { get; }
	internal bool HasSetResolver { get; }
	public virtual XmlResolver XmlResolver { set; }
	public XmlNameTable NameTable { get; }
	public override bool IsReadOnly { get; }
	internal XmlNamedNodeMap Entities { get; set; }
	internal bool IsLoading { get; set; }
	internal bool ActualLoadingStatus { get; }
	public override string InnerText { set; }
	public override string InnerXml { set; }
	internal string Version { get; }
	internal string Encoding { get; }
	internal string Standalone { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x33B44E4 Offset: 0x33B04E4 VA: 0x33B44E4
	public void .ctor() { }

	// RVA: 0x33B4A54 Offset: 0x33B0A54 VA: 0x33B4A54
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x33B45A8 Offset: 0x33B05A8 VA: 0x33B45A8
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x33B4AFC Offset: 0x33B0AFC VA: 0x33B4AFC
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x33B4B04 Offset: 0x33B0B04 VA: 0x33B4B04
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0x33B0A58 Offset: 0x33ACA58 VA: 0x33B0A58
	internal static void CheckName(string name) { }

	// RVA: 0x33B4B0C Offset: 0x33B0B0C VA: 0x33B4B0C
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x33B4B24 Offset: 0x33B0B24 VA: 0x33B4B24
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x33B0B84 Offset: 0x33ACB84 VA: 0x33B0B84
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x33B4B3C Offset: 0x33B0B3C VA: 0x33B4B3C
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0x33B4C08 Offset: 0x33B0C08 VA: 0x33B4C08
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0x33B2F70 Offset: 0x33AEF70 VA: 0x33B2F70
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0x33B4CDC Offset: 0x33B0CDC VA: 0x33B4CDC
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0x33B2F84 Offset: 0x33AEF84 VA: 0x33B2F84
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0x33B3178 Offset: 0x33AF178 VA: 0x33B3178
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0x33B5338 Offset: 0x33B1338 VA: 0x33B5338 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33B543C Offset: 0x33B143C VA: 0x33B543C Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33B5444 Offset: 0x33B1444 VA: 0x33B5444 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x33B544C Offset: 0x33B144C VA: 0x33B544C Slot: 56
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0x33B54D8 Offset: 0x33B14D8 VA: 0x33B54D8 Slot: 57
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x33B557C Offset: 0x33B157C VA: 0x33B557C
	public XmlImplementation get_Implementation() { }

	// RVA: 0x33B5584 Offset: 0x33B1584 VA: 0x33B5584 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33B558C Offset: 0x33B158C VA: 0x33B558C Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33B5594 Offset: 0x33B1594 VA: 0x33B5594
	public XmlElement get_DocumentElement() { }

	// RVA: 0x33B5620 Offset: 0x33B1620 VA: 0x33B5620 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x33B5628 Offset: 0x33B1628 VA: 0x33B5628 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x33B5630 Offset: 0x33B1630 VA: 0x33B5630 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x33B5638 Offset: 0x33B1638 VA: 0x33B5638 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x33B5640 Offset: 0x33B1640 VA: 0x33B5640
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x33B5648 Offset: 0x33B1648 VA: 0x33B5648
	internal bool get_CanReportValidity() { }

	// RVA: 0x33B5650 Offset: 0x33B1650 VA: 0x33B5650
	internal bool get_HasSetResolver() { }

	// RVA: 0x33B5658 Offset: 0x33B1658 VA: 0x33B5658
	internal XmlResolver GetResolver() { }

	// RVA: 0x33B5660 Offset: 0x33B1660 VA: 0x33B5660 Slot: 58
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x33B57F8 Offset: 0x33B17F8 VA: 0x33B57F8 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x33B58E0 Offset: 0x33B18E0 VA: 0x33B58E0
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x33B5990 Offset: 0x33B1990 VA: 0x33B5990
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x33B59F4 Offset: 0x33B19F4 VA: 0x33B59F4 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x33B5B58 Offset: 0x33B1B58 VA: 0x33B5B58 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x33B5C54 Offset: 0x33B1C54 VA: 0x33B5C54
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0x33B5D14 Offset: 0x33B1D14 VA: 0x33B5D14
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	// RVA: 0x33B5DB8 Offset: 0x33B1DB8 VA: 0x33B5DB8 Slot: 59
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0x33B5E28 Offset: 0x33B1E28 VA: 0x33B5E28 Slot: 60
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0x33B5E90 Offset: 0x33B1E90 VA: 0x33B5E90 Slot: 61
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x33B6024 Offset: 0x33B2024 VA: 0x33B6024 Slot: 62
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0x33B6100 Offset: 0x33B2100 VA: 0x33B6100
	public XmlElement CreateElement(string name) { }

	// RVA: 0x33B61B0 Offset: 0x33B21B0 VA: 0x33B61B0
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0x33B6438 Offset: 0x33B2438 VA: 0x33B6438
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0x33B6544 Offset: 0x33B2544 VA: 0x33B6544
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x33B6640 Offset: 0x33B2640 VA: 0x33B6640 Slot: 63
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0x33B67A8 Offset: 0x33B27A8 VA: 0x33B67A8 Slot: 64
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x33B681C Offset: 0x33B281C VA: 0x33B681C Slot: 65
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0x33B689C Offset: 0x33B289C VA: 0x33B689C Slot: 66
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0x33B6908 Offset: 0x33B2908 VA: 0x33B6908 Slot: 67
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0x33B6974 Offset: 0x33B2974 VA: 0x33B6974 Slot: 68
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0x33B69E0 Offset: 0x33B29E0 VA: 0x33B69E0
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0x33B6A84 Offset: 0x33B2A84 VA: 0x33B6A84
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0x33B6B28 Offset: 0x33B2B28 VA: 0x33B6B28
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0x33B6FD0 Offset: 0x33B2FD0 VA: 0x33B6FD0
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0x33B53A0 Offset: 0x33B13A0 VA: 0x33B53A0
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0x33B03EC Offset: 0x33AC3EC VA: 0x33B03EC
	public XmlNameTable get_NameTable() { }

	// RVA: 0x33B70E4 Offset: 0x33B30E4 VA: 0x33B70E4 Slot: 69
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x33B717C Offset: 0x33B317C VA: 0x33B717C Slot: 70
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x33B7200 Offset: 0x33B3200 VA: 0x33B7200 Slot: 71
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x33B7404 Offset: 0x33B3404 VA: 0x33B7404 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x33B740C Offset: 0x33B340C VA: 0x33B740C
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x33B7484 Offset: 0x33B3484 VA: 0x33B7484
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0x33B748C Offset: 0x33B348C VA: 0x33B748C
	internal bool get_IsLoading() { }

	// RVA: 0x33B7494 Offset: 0x33B3494 VA: 0x33B7494
	internal void set_IsLoading(bool value) { }

	// RVA: 0x33B74A0 Offset: 0x33B34A0 VA: 0x33B74A0
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0x33B74A8 Offset: 0x33B34A8 VA: 0x33B74A8 Slot: 72
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0x33B76C4 Offset: 0x33B36C4 VA: 0x33B76C4
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0x33B7724 Offset: 0x33B3724 VA: 0x33B7724 Slot: 73
	public virtual void Load(XmlReader reader) { }

	// RVA: 0x33B7AA0 Offset: 0x33B3AA0 VA: 0x33B7AA0 Slot: 74
	public virtual void LoadXml(string xml) { }

	// RVA: 0x33B7BF0 Offset: 0x33B3BF0 VA: 0x33B7BF0 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x33B7C48 Offset: 0x33B3C48 VA: 0x33B7C48 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x33B7C58 Offset: 0x33B3C58 VA: 0x33B7C58 Slot: 75
	public virtual void Save(XmlWriter w) { }

	// RVA: 0x33B7E70 Offset: 0x33B3E70 VA: 0x33B7E70 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33B7E80 Offset: 0x33B3E80 VA: 0x33B7E80 Slot: 44
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0x33B8150 Offset: 0x33B4150 VA: 0x33B8150 Slot: 50
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x33B13D0 Offset: 0x33AD3D0 VA: 0x33B13D0
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0x33B8248 Offset: 0x33B4248 VA: 0x33B8248 Slot: 51
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x33B829C Offset: 0x33B429C VA: 0x33B829C Slot: 52
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x33B2CDC Offset: 0x33AECDC VA: 0x33B2CDC
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x33B82F0 Offset: 0x33B42F0 VA: 0x33B82F0
	internal string get_Version() { }

	// RVA: 0x33B8314 Offset: 0x33B4314 VA: 0x33B8314
	internal string get_Encoding() { }

	// RVA: 0x33B7E4C Offset: 0x33B3E4C VA: 0x33B7E4C
	internal string get_Standalone() { }

	// RVA: 0x33B8338 Offset: 0x33B4338 VA: 0x33B8338
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0x33B8474 Offset: 0x33B4474 VA: 0x33B8474 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x33B85B8 Offset: 0x33B45B8 VA: 0x33B85B8 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x33B85C0 Offset: 0x33B45C0 VA: 0x33B85C0
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0x33B85D0 Offset: 0x33B45D0 VA: 0x33B85D0 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x33B87C8 Offset: 0x33B47C8 VA: 0x33B87C8
	private static void .cctor() { }
}

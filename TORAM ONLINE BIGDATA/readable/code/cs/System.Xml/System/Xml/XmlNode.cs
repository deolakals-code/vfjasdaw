// Assembly: System.Xml.dll
// Namespace: System.Xml
[DefaultMember("Item")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
public abstract class XmlNode : ICloneable, IEnumerable // TypeDefIndex: 13410
{
	// Fields
	internal XmlNode parentNode; // 0x10

	// Properties
	public abstract string Name { get; }
	public virtual string Value { get; set; }
	public abstract XmlNodeType NodeType { get; }
	public virtual XmlNode ParentNode { get; }
	public virtual XmlNodeList ChildNodes { get; }
	public virtual XmlNode PreviousSibling { get; }
	public virtual XmlNode NextSibling { get; }
	public virtual XmlAttributeCollection Attributes { get; }
	public virtual XmlDocument OwnerDocument { get; }
	public virtual XmlNode FirstChild { get; }
	public virtual XmlNode LastChild { get; }
	internal virtual bool IsContainer { get; }
	internal virtual XmlLinkedNode LastNode { get; set; }
	public virtual bool HasChildNodes { get; }
	public virtual string NamespaceURI { get; }
	public virtual string Prefix { get; set; }
	public abstract string LocalName { get; }
	public virtual bool IsReadOnly { get; }
	public virtual string InnerText { get; set; }
	public virtual string InnerXml { set; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual string BaseURI { get; }
	internal XmlDocument Document { get; }
	internal virtual XmlSpace XmlSpace { get; }
	internal virtual string XmlLang { get; }
	internal virtual bool IsText { get; }

	// Methods

	// RVA: 0x33C0EE0 Offset: 0x33BCEE0 VA: 0x33C0EE0
	internal void .ctor() { }

	// RVA: 0x33C0EE8 Offset: 0x33BCEE8 VA: 0x33C0EE8
	internal void .ctor(XmlDocument doc) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_Name();

	// RVA: 0x33C0F6C Offset: 0x33BCF6C VA: 0x33C0F6C Slot: 7
	public virtual string get_Value() { }

	// RVA: 0x33C0F74 Offset: 0x33BCF74 VA: 0x33C0F74 Slot: 8
	public virtual void set_Value(string value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x33C1040 Offset: 0x33BD040 VA: 0x33C1040 Slot: 10
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x33C1124 Offset: 0x33BD124 VA: 0x33C1124 Slot: 11
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x33C1180 Offset: 0x33BD180 VA: 0x33C1180 Slot: 12
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x33C1188 Offset: 0x33BD188 VA: 0x33C1188 Slot: 13
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x33C1190 Offset: 0x33BD190 VA: 0x33C1190 Slot: 14
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x33C1198 Offset: 0x33BD198 VA: 0x33C1198 Slot: 15
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x33C1250 Offset: 0x33BD250 VA: 0x33C1250 Slot: 16
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x33C1274 Offset: 0x33BD274 VA: 0x33C1274 Slot: 17
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x33C1284 Offset: 0x33BD284 VA: 0x33C1284 Slot: 18
	internal virtual bool get_IsContainer() { }

	// RVA: 0x33C128C Offset: 0x33BD28C VA: 0x33C128C Slot: 19
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x33C1294 Offset: 0x33BD294 VA: 0x33C1294 Slot: 20
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x33C1298 Offset: 0x33BD298 VA: 0x33C1298
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x33C12F4 Offset: 0x33BD2F4 VA: 0x33C12F4 Slot: 21
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x33C18FC Offset: 0x33BD8FC VA: 0x33C18FC Slot: 22
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x33C1E80 Offset: 0x33BDE80 VA: 0x33C1E80 Slot: 23
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x33C2254 Offset: 0x33BE254 VA: 0x33C2254 Slot: 24
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x33C229C Offset: 0x33BE29C VA: 0x33C229C Slot: 25
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x33C2774 Offset: 0x33BE774 VA: 0x33C2774 Slot: 26
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x33C2940 Offset: 0x33BE940 VA: 0x33C2940 Slot: 27
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x33C2948 Offset: 0x33BE948 VA: 0x33C2948 Slot: 28
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x33C2950 Offset: 0x33BE950 VA: 0x33C2950 Slot: 29
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x33C2958 Offset: 0x33BE958 VA: 0x33C2958 Slot: 30
	public virtual bool get_HasChildNodes() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract XmlNode CloneNode(bool deep);

	// RVA: 0x33C297C Offset: 0x33BE97C VA: 0x33C297C Slot: 32
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x33C2A1C Offset: 0x33BEA1C VA: 0x33C2A1C Slot: 33
	public virtual string get_NamespaceURI() { }

	// RVA: 0x33C2A64 Offset: 0x33BEA64 VA: 0x33C2A64 Slot: 34
	public virtual string get_Prefix() { }

	// RVA: 0x33C2AAC Offset: 0x33BEAAC VA: 0x33C2AAC Slot: 35
	public virtual void set_Prefix(string value) { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract string get_LocalName();

	// RVA: 0x33C2AB0 Offset: 0x33BEAB0 VA: 0x33C2AB0 Slot: 37
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x33C2AD4 Offset: 0x33BEAD4 VA: 0x33C2AD4
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x33C2BA0 Offset: 0x33BEBA0 VA: 0x33C2BA0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x33C2BB4 Offset: 0x33BEBB4 VA: 0x33C2BB4 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x33C2C10 Offset: 0x33BEC10 VA: 0x33C2C10
	public IEnumerator GetEnumerator() { }

	// RVA: 0x33C2C6C Offset: 0x33BEC6C VA: 0x33C2C6C
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x33C2D70 Offset: 0x33BED70 VA: 0x33C2D70 Slot: 38
	public virtual string get_InnerText() { }

	// RVA: 0x33C2E78 Offset: 0x33BEE78 VA: 0x33C2E78 Slot: 39
	public virtual void set_InnerText(string value) { }

	// RVA: 0x33C2F48 Offset: 0x33BEF48 VA: 0x33C2F48 Slot: 40
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x33C2FA0 Offset: 0x33BEFA0 VA: 0x33C2FA0 Slot: 41
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x33C2FF8 Offset: 0x33BEFF8 VA: 0x33C2FF8 Slot: 42
	public virtual string get_BaseURI() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void WriteTo(XmlWriter w);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract void WriteContentTo(XmlWriter w);

	// RVA: 0x33C3120 Offset: 0x33BF120 VA: 0x33C3120 Slot: 45
	public virtual void RemoveAll() { }

	// RVA: 0x33C3188 Offset: 0x33BF188 VA: 0x33C3188
	internal XmlDocument get_Document() { }

	// RVA: 0x33C3234 Offset: 0x33BF234 VA: 0x33C3234 Slot: 46
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x33C3294 Offset: 0x33BF294 VA: 0x33C3294
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x33C35EC Offset: 0x33BF5EC VA: 0x33C35EC Slot: 47
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x33C3628 Offset: 0x33BF628 VA: 0x33C3628 Slot: 48
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x33C3630 Offset: 0x33BF630 VA: 0x33C3630
	internal static void SplitName(string name, out string prefix, out string localName) { }

	// RVA: 0x33C3720 Offset: 0x33BF720 VA: 0x33C3720 Slot: 49
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x33C3784 Offset: 0x33BF784 VA: 0x33C3784 Slot: 50
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x33C38A8 Offset: 0x33BF8A8 VA: 0x33C38A8 Slot: 51
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x33C38EC Offset: 0x33BF8EC VA: 0x33C38EC Slot: 52
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x33C3930 Offset: 0x33BF930 VA: 0x33C3930 Slot: 53
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x33C3AA8 Offset: 0x33BFAA8 VA: 0x33C3AA8 Slot: 54
	internal virtual string get_XmlLang() { }

	// RVA: 0x33C3BAC Offset: 0x33BFBAC VA: 0x33C3BAC Slot: 55
	internal virtual bool get_IsText() { }

	// RVA: 0x33C18A4 Offset: 0x33BD8A4 VA: 0x33C18A4
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x33C18C8 Offset: 0x33BD8C8 VA: 0x33C18C8
	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }
}

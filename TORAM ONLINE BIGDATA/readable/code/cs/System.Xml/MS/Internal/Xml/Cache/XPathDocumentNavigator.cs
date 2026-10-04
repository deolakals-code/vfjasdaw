// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 13889
{
	// Fields
	private XPathNode[] _pageCurrent; // 0x10
	private XPathNode[] _pageParent; // 0x18
	private int _idxCurrent; // 0x20
	private int _idxParent; // 0x24

	// Properties
	public override string Value { get; }
	public override XPathNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override XmlNameTable NameTable { get; }
	public override object UnderlyingObject { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x33864EC Offset: 0x33824EC VA: 0x33864EC
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x338658C Offset: 0x338258C VA: 0x338658C Slot: 5
	public override string get_Value() { }

	// RVA: 0x338699C Offset: 0x338299C VA: 0x338699C Slot: 23
	public override XPathNavigator Clone() { }

	// RVA: 0x3386A10 Offset: 0x3382A10 VA: 0x3386A10 Slot: 24
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x3386A54 Offset: 0x3382A54 VA: 0x3386A54 Slot: 25
	public override string get_LocalName() { }

	// RVA: 0x3386AAC Offset: 0x3382AAC VA: 0x3386AAC Slot: 26
	public override string get_NamespaceURI() { }

	// RVA: 0x3386B04 Offset: 0x3382B04 VA: 0x3386B04 Slot: 27
	public override string get_Prefix() { }

	// RVA: 0x3386B5C Offset: 0x3382B5C VA: 0x3386B5C Slot: 19
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x3386BBC Offset: 0x3382BBC VA: 0x3386BBC Slot: 30
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x3386ED8 Offset: 0x3382ED8 VA: 0x3386ED8 Slot: 31
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x3387050 Offset: 0x3383050 VA: 0x3387050 Slot: 32
	public override bool MoveToParent() { }

	// RVA: 0x3387134 Offset: 0x3383134 VA: 0x3387134 Slot: 33
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x33871D8 Offset: 0x33831D8 VA: 0x33871D8 Slot: 28
	public override object get_UnderlyingObject() { }

	// RVA: 0x33871E8 Offset: 0x33831E8 VA: 0x33871E8 Slot: 35
	public bool HasLineInfo() { }

	// RVA: 0x338722C Offset: 0x338322C VA: 0x338722C Slot: 36
	public int get_LineNumber() { }

	// RVA: 0x33872D8 Offset: 0x33832D8 VA: 0x33872D8 Slot: 37
	public int get_LinePosition() { }

	// RVA: 0x33873CC Offset: 0x33833CC VA: 0x33873CC
	public int GetPositionHashCode() { }
}

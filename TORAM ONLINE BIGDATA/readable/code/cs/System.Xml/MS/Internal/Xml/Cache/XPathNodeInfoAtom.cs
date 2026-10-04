// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodeInfoAtom // TypeDefIndex: 13894
{
	// Fields
	private string _localName; // 0x10
	private string _namespaceUri; // 0x18
	private string _prefix; // 0x20
	private XPathNode[] _pageParent; // 0x28
	private XPathNode[] _pageSibling; // 0x30
	private XPathDocument _doc; // 0x38
	private int _lineNumBase; // 0x40
	private int _linePosBase; // 0x44
	private XPathNodePageInfo _pageInfo; // 0x48

	// Properties
	public XPathNodePageInfo PageInfo { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public string Prefix { get; }
	public XPathNode[] SiblingPage { get; }
	public XPathNode[] ParentPage { get; }
	public XPathDocument Document { get; }
	public int LineNumberBase { get; }
	public int LinePositionBase { get; }

	// Methods

	// RVA: 0x3387518 Offset: 0x3383518 VA: 0x3387518
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x3387520 Offset: 0x3383520 VA: 0x3387520
	public string get_LocalName() { }

	// RVA: 0x3387528 Offset: 0x3383528 VA: 0x3387528
	public string get_NamespaceUri() { }

	// RVA: 0x3387530 Offset: 0x3383530 VA: 0x3387530
	public string get_Prefix() { }

	// RVA: 0x3387538 Offset: 0x3383538 VA: 0x3387538
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x3387540 Offset: 0x3383540 VA: 0x3387540
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x3387548 Offset: 0x3383548 VA: 0x3387548
	public XPathDocument get_Document() { }

	// RVA: 0x3387550 Offset: 0x3383550 VA: 0x3387550
	public int get_LineNumberBase() { }

	// RVA: 0x3387558 Offset: 0x3383558 VA: 0x3387558
	public int get_LinePositionBase() { }
}

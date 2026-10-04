// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.Cache
internal struct XPathNode // TypeDefIndex: 13890
{
	// Fields
	private XPathNodeInfoAtom _info; // 0x0
	private ushort _idxSibling; // 0x8
	private ushort _idxParent; // 0xA
	private ushort _idxSimilar; // 0xC
	private ushort _posOffset; // 0xE
	private uint _props; // 0x10
	private string _value; // 0x18

	// Properties
	public XPathNodeType NodeType { get; }
	public string Prefix { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public XPathDocument Document { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public int CollapsedLinePosition { get; }
	public XPathNodePageInfo PageInfo { get; }
	public bool IsXmlNamespaceNode { get; }
	public bool HasSibling { get; }
	public bool HasCollapsedText { get; }
	public bool IsText { get; }
	public bool HasNamespaceDecls { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x3386A48 Offset: 0x3382A48 VA: 0x3386A48
	public XPathNodeType get_NodeType() { }

	// RVA: 0x3386B40 Offset: 0x3382B40 VA: 0x3386B40
	public string get_Prefix() { }

	// RVA: 0x3386A90 Offset: 0x3382A90 VA: 0x3386A90
	public string get_LocalName() { }

	// RVA: 0x3386AE8 Offset: 0x3382AE8 VA: 0x3386AE8
	public string get_NamespaceUri() { }

	// RVA: 0x3386BA0 Offset: 0x3382BA0 VA: 0x3386BA0
	public XPathDocument get_Document() { }

	// RVA: 0x33872B0 Offset: 0x33832B0 VA: 0x33872B0
	public int get_LineNumber() { }

	// RVA: 0x33873A8 Offset: 0x33833A8 VA: 0x33873A8
	public int get_LinePosition() { }

	// RVA: 0x338737C Offset: 0x338337C VA: 0x338737C
	public int get_CollapsedLinePosition() { }

	// RVA: 0x33873D8 Offset: 0x33833D8 VA: 0x33873D8
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x338701C Offset: 0x338301C VA: 0x338701C
	public int GetParent(out XPathNode[] pageNode) { }

	// RVA: 0x3386EA4 Offset: 0x3382EA4 VA: 0x3386EA4
	public int GetSibling(out XPathNode[] pageNode) { }

	// RVA: 0x3386E1C Offset: 0x3382E1C VA: 0x3386E1C
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x33873F4 Offset: 0x33833F4 VA: 0x33873F4
	public bool get_HasSibling() { }

	// RVA: 0x3387404 Offset: 0x3383404 VA: 0x3387404
	public bool get_HasCollapsedText() { }

	// RVA: 0x3387410 Offset: 0x3383410 VA: 0x3387410
	public bool get_IsText() { }

	// RVA: 0x338746C Offset: 0x338346C VA: 0x338746C
	public bool get_HasNamespaceDecls() { }

	// RVA: 0x3387478 Offset: 0x3383478 VA: 0x3387478
	public string get_Value() { }
}

// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodePageInfo // TypeDefIndex: 13893
{
	// Fields
	private int _pageNum; // 0x10
	private int _nodeCount; // 0x14
	private XPathNode[] _pageNext; // 0x18

	// Properties
	public int PageNumber { get; }
	public int NodeCount { get; }
	public XPathNode[] NextPage { get; }

	// Methods

	// RVA: 0x3387500 Offset: 0x3383500 VA: 0x3387500
	public int get_PageNumber() { }

	// RVA: 0x3387508 Offset: 0x3383508 VA: 0x3387508
	public int get_NodeCount() { }

	// RVA: 0x3387510 Offset: 0x3383510 VA: 0x3387510
	public XPathNode[] get_NextPage() { }
}

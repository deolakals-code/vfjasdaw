// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.Cache
internal struct XPathNodeRef // TypeDefIndex: 13891
{
	// Fields
	private XPathNode[] _page; // 0x0
	private int _idx; // 0x8

	// Properties
	public XPathNode[] Page { get; }
	public int Index { get; }

	// Methods

	// RVA: 0x3387480 Offset: 0x3383480 VA: 0x3387480
	public void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0x33874A8 Offset: 0x33834A8 VA: 0x33874A8
	public XPathNode[] get_Page() { }

	// RVA: 0x33874B0 Offset: 0x33834B0 VA: 0x33874B0
	public int get_Index() { }

	// RVA: 0x33874B8 Offset: 0x33834B8 VA: 0x33874B8 Slot: 2
	public override int GetHashCode() { }
}

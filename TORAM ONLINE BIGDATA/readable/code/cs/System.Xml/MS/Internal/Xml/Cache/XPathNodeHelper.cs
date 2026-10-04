// Assembly: System.Xml.dll
// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathNodeHelper // TypeDefIndex: 13892
{
	// Methods

	// RVA: 0x3386CCC Offset: 0x3382CCC VA: 0x3386CCC
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x3386D3C Offset: 0x3382D3C VA: 0x3386D3C
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x33870B8 Offset: 0x33830B8 VA: 0x33870B8
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x33874C8 Offset: 0x33834C8 VA: 0x33874C8
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x3386830 Offset: 0x3382830 VA: 0x3386830
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x3386784 Offset: 0x3382784 VA: 0x3386784
	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }
}

// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Asttree // TypeDefIndex: 13580
{
	// Fields
	private ArrayList _fAxisArray; // 0x10
	private string _xpathexpr; // 0x18
	private bool _isField; // 0x20
	private XmlNamespaceManager _nsmgr; // 0x28

	// Properties
	internal ArrayList SubtreeArray { get; }

	// Methods

	// RVA: 0x3415BF4 Offset: 0x3411BF4 VA: 0x3415BF4
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0x3415BFC Offset: 0x3411BFC VA: 0x3415BFC
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x341645C Offset: 0x341245C VA: 0x341645C
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0x3414D0C Offset: 0x3410D0C VA: 0x3414D0C
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0x3416490 Offset: 0x3412490 VA: 0x3416490
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0x3415BB4 Offset: 0x3411BB4 VA: 0x3415BB4
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0x3415C68 Offset: 0x3411C68 VA: 0x3415C68
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x34164D0 Offset: 0x34124D0 VA: 0x34164D0
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }
}

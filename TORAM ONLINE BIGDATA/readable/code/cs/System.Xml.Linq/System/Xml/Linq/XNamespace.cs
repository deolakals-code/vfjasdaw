// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
public sealed class XNamespace // TypeDefIndex: 17526
{
	// Fields
	private static XHashtable<WeakReference> s_namespaces; // 0x0
	private static WeakReference s_refNone; // 0x8
	private static WeakReference s_refXml; // 0x10
	private static WeakReference s_refXmlns; // 0x18
	private string _namespaceName; // 0x10
	private int _hashCode; // 0x18
	private XHashtable<XName> _names; // 0x20

	// Properties
	public string NamespaceName { get; }
	public static XNamespace None { get; }
	public static XNamespace Xml { get; }
	public static XNamespace Xmlns { get; }

	// Methods

	// RVA: 0x32C2A1C Offset: 0x32BEA1C VA: 0x32C2A1C
	internal void .ctor(string namespaceName) { }

	// RVA: 0x32C2B28 Offset: 0x32BEB28 VA: 0x32C2B28
	public string get_NamespaceName() { }

	// RVA: 0x32BF1C4 Offset: 0x32BB1C4 VA: 0x32BF1C4
	public XName GetName(string localName) { }

	// RVA: 0x32C2B30 Offset: 0x32BEB30 VA: 0x32C2B30 Slot: 3
	public override string ToString() { }

	// RVA: 0x32C28F4 Offset: 0x32BE8F4 VA: 0x32C28F4
	public static XNamespace get_None() { }

	// RVA: 0x32C2C18 Offset: 0x32BEC18 VA: 0x32C2C18
	public static XNamespace get_Xml() { }

	// RVA: 0x32C2C78 Offset: 0x32BEC78 VA: 0x32C2C78
	public static XNamespace get_Xmlns() { }

	// RVA: 0x32C145C Offset: 0x32BD45C VA: 0x32C145C
	public static XNamespace Get(string namespaceName) { }

	[CLSCompliant(False)]
	// RVA: 0x32C2CD8 Offset: 0x32BECD8 VA: 0x32C2CD8
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0x32C2CEC Offset: 0x32BECEC VA: 0x32C2CEC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x32C2CF8 Offset: 0x32BECF8 VA: 0x32C2CF8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x32C0690 Offset: 0x32BC690 VA: 0x32C0690
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x32C2D00 Offset: 0x32BED00 VA: 0x32C2D00
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x32C27EC Offset: 0x32BE7EC VA: 0x32C27EC
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x32C2514 Offset: 0x32BE514 VA: 0x32C2514
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x32C2D0C Offset: 0x32BED0C VA: 0x32C2D0C
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x32C2D24 Offset: 0x32BED24 VA: 0x32C2D24
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x32C2B38 Offset: 0x32BEB38 VA: 0x32C2B38
	private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }
}

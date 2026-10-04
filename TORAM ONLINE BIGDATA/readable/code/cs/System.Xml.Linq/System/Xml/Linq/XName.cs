// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
[Serializable]
public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 17525
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _localName; // 0x18
	private int _hashCode; // 0x20

	// Properties
	public string LocalName { get; }
	public XNamespace Namespace { get; }
	public string NamespaceName { get; }

	// Methods

	// RVA: 0x32C225C Offset: 0x32BE25C VA: 0x32C225C
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x32C232C Offset: 0x32BE32C VA: 0x32C232C
	public string get_LocalName() { }

	// RVA: 0x32C2334 Offset: 0x32BE334 VA: 0x32C2334
	public XNamespace get_Namespace() { }

	// RVA: 0x32BB46C Offset: 0x32B746C VA: 0x32BB46C
	public string get_NamespaceName() { }

	// RVA: 0x32C233C Offset: 0x32BE33C VA: 0x32C233C Slot: 3
	public override string ToString() { }

	// RVA: 0x32C23CC Offset: 0x32BE3CC VA: 0x32C23CC
	public static XName Get(string expandedName) { }

	// RVA: 0x32C295C Offset: 0x32BE95C VA: 0x32C295C
	public static XName Get(string localName, string namespaceName) { }

	[CLSCompliant(False)]
	// RVA: 0x32C2980 Offset: 0x32BE980 VA: 0x32C2980
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0x32C298C Offset: 0x32BE98C VA: 0x32C298C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x32C2998 Offset: 0x32BE998 VA: 0x32C2998 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x32BACE0 Offset: 0x32B6CE0 VA: 0x32BACE0
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0x32C29A0 Offset: 0x32BE9A0 VA: 0x32C29A0 Slot: 4
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x32C29AC Offset: 0x32BE9AC VA: 0x32C29AC Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x32C29E4 Offset: 0x32BE9E4 VA: 0x32C29E4
	internal void .ctor() { }
}

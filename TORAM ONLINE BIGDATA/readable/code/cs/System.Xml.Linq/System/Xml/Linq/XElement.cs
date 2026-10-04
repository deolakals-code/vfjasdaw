// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
[XmlSchemaProvider(null, IsAny = True)]
[XmlTypeConvertor("ConvertForAssignment")]
public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 17513
{
	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Properties
	public bool HasAttributes { get; }
	public bool IsEmpty { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x32BF224 Offset: 0x32BB224 VA: 0x32BF224
	public void .ctor(XName name) { }

	// RVA: 0x32C0444 Offset: 0x32BC444 VA: 0x32C0444
	public void .ctor(XElement other) { }

	// RVA: 0x32BD02C Offset: 0x32B902C VA: 0x32BD02C
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x32C04F0 Offset: 0x32BC4F0 VA: 0x32C04F0
	public bool get_HasAttributes() { }

	// RVA: 0x32C0500 Offset: 0x32BC500 VA: 0x32C0500
	public bool get_IsEmpty() { }

	// RVA: 0x32C0510 Offset: 0x32BC510 VA: 0x32C0510
	public XName get_Name() { }

	// RVA: 0x32C0518 Offset: 0x32BC518 VA: 0x32C0518 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32C0520 Offset: 0x32BC520 VA: 0x32C0520
	public string get_Value() { }

	// RVA: 0x32C05B4 Offset: 0x32BC5B4 VA: 0x32C05B4
	public XAttribute Attribute(XName name) { }

	// RVA: 0x32C05F0 Offset: 0x32BC5F0 VA: 0x32C05F0
	public IEnumerable<XAttribute> Attributes() { }

	// RVA: 0x32BB9B4 Offset: 0x32B79B4 VA: 0x32BB9B4
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x32C0790 Offset: 0x32BC790 VA: 0x32C0790 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x32C09E8 Offset: 0x32BC9E8 VA: 0x32C09E8 Slot: 15
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x32C09F0 Offset: 0x32BC9F0 VA: 0x32C09F0 Slot: 16
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x32C0BF4 Offset: 0x32BCBF4 VA: 0x32C0BF4 Slot: 17
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x32C0C00 Offset: 0x32BCC00 VA: 0x32C0C00 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x32C0DFC Offset: 0x32BCDFC VA: 0x32C0DFC Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x32C0CE8 Offset: 0x32BCCE8 VA: 0x32C0CE8
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x32BF2A0 Offset: 0x32BB2A0 VA: 0x32BF2A0
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x32C0EE4 Offset: 0x32BCEE4 VA: 0x32C0EE4 Slot: 10
	internal override XNode CloneNode() { }

	[IteratorStateMachine(typeof(XElement.<GetAttributes>d__116))]
	// RVA: 0x32C05F8 Offset: 0x32BC5F8 VA: 0x32C05F8
	private IEnumerable<XAttribute> GetAttributes(XName name) { }

	// RVA: 0x32C069C Offset: 0x32BC69C VA: 0x32C069C
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x32C0B7C Offset: 0x32BCB7C VA: 0x32C0B7C
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x32C0F70 Offset: 0x32BCF70 VA: 0x32C0F70
	private void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	// RVA: 0x32BF554 Offset: 0x32BB554 VA: 0x32BF554
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x32C1718 Offset: 0x32BD718 VA: 0x32C1718 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }
}

// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlDocumentFragment : XmlNode // TypeDefIndex: 13396
{
	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string InnerXml { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }

	// Methods

	// RVA: 0x33B607C Offset: 0x33B207C VA: 0x33B607C
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x33B88E4 Offset: 0x33B48E4 VA: 0x33B88E4 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33B890C Offset: 0x33B490C VA: 0x33B890C Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33B8934 Offset: 0x33B4934 VA: 0x33B8934 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33B893C Offset: 0x33B493C VA: 0x33B893C Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x33B8944 Offset: 0x33B4944 VA: 0x33B8944 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x33B89BC Offset: 0x33B49BC VA: 0x33B89BC Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x33B8C68 Offset: 0x33B4C68 VA: 0x33B8C68 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33B8CEC Offset: 0x33B4CEC VA: 0x33B8CEC Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x33B8CF4 Offset: 0x33B4CF4 VA: 0x33B8CF4 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x33B8CFC Offset: 0x33B4CFC VA: 0x33B8CFC Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x33B8D04 Offset: 0x33B4D04 VA: 0x33B8D04 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x33B8D70 Offset: 0x33B4D70 VA: 0x33B8D70 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x33B8DE0 Offset: 0x33B4DE0 VA: 0x33B8DE0 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x33B8E48 Offset: 0x33B4E48 VA: 0x33B8E48 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33B8E58 Offset: 0x33B4E58 VA: 0x33B8E58 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }
}

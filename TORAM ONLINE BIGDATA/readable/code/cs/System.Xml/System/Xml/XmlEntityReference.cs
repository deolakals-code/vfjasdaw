// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlEntityReference : XmlLinkedNode // TypeDefIndex: 13400
{
	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override string BaseURI { get; }
	internal string ChildBaseURI { get; }

	// Methods

	// RVA: 0x33B66A8 Offset: 0x33B26A8 VA: 0x33B66A8
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x33BAD20 Offset: 0x33B6D20 VA: 0x33BAD20 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33BAD28 Offset: 0x33B6D28 VA: 0x33BAD28 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33BAD30 Offset: 0x33B6D30 VA: 0x33BAD30 Slot: 7
	public override string get_Value() { }

	// RVA: 0x33BAD38 Offset: 0x33B6D38 VA: 0x33BAD38 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x33BAD90 Offset: 0x33B6D90 VA: 0x33BAD90 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33BAD98 Offset: 0x33B6D98 VA: 0x33BAD98 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33BADD0 Offset: 0x33B6DD0 VA: 0x33BADD0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x33BADD8 Offset: 0x33B6DD8 VA: 0x33BADD8 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x33BADE0 Offset: 0x33B6DE0 VA: 0x33BADE0 Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x33BB4B8 Offset: 0x33B74B8 VA: 0x33BB4B8 Slot: 48
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x33BB4C8 Offset: 0x33B74C8 VA: 0x33BB4C8 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x33BB4D0 Offset: 0x33B74D0 VA: 0x33BB4D0 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x33BB4D8 Offset: 0x33B74D8 VA: 0x33BB4D8 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x33BB4FC Offset: 0x33B74FC VA: 0x33BB4FC Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33BB528 Offset: 0x33B7528 VA: 0x33BB528 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x33BB7F8 Offset: 0x33B77F8 VA: 0x33BB7F8 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x33BB828 Offset: 0x33B7828 VA: 0x33BB828
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x33BB8FC Offset: 0x33B78FC VA: 0x33BB8FC
	internal string get_ChildBaseURI() { }
}

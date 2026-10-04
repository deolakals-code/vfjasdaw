// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlEntity : XmlNode // TypeDefIndex: 13399
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string notationName; // 0x28
	private string name; // 0x30
	private string unparsedReplacementStr; // 0x38
	private string baseURI; // 0x40
	private XmlLinkedNode lastChild; // 0x48
	private bool childrenFoliating; // 0x50

	// Properties
	public override bool IsReadOnly { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string InnerText { get; set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlNodeType NodeType { get; }
	public string SystemId { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x33BA9FC Offset: 0x33B69FC VA: 0x33BA9FC
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x33BAAC4 Offset: 0x33B6AC4 VA: 0x33BAAC4 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33BAB1C Offset: 0x33B6B1C VA: 0x33BAB1C Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x33BAB24 Offset: 0x33B6B24 VA: 0x33BAB24 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33BAB2C Offset: 0x33B6B2C VA: 0x33BAB2C Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33BAB34 Offset: 0x33B6B34 VA: 0x33BAB34 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x33BAB3C Offset: 0x33B6B3C VA: 0x33BAB3C Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x33BAB94 Offset: 0x33B6B94 VA: 0x33BAB94 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x33BAB9C Offset: 0x33B6B9C VA: 0x33BAB9C Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x33BAC74 Offset: 0x33B6C74 VA: 0x33BAC74 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x33BAC7C Offset: 0x33B6C7C VA: 0x33BAC7C Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x33BACA0 Offset: 0x33B6CA0 VA: 0x33BACA0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33BACA8 Offset: 0x33B6CA8 VA: 0x33BACA8
	public string get_SystemId() { }

	// RVA: 0x33BACB0 Offset: 0x33B6CB0 VA: 0x33BACB0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x33BAD08 Offset: 0x33B6D08 VA: 0x33BAD08 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33BAD0C Offset: 0x33B6D0C VA: 0x33BAD0C Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x33BAD10 Offset: 0x33B6D10 VA: 0x33BAD10 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x33BAD18 Offset: 0x33B6D18 VA: 0x33BAD18
	internal void SetBaseURI(string inBaseURI) { }
}

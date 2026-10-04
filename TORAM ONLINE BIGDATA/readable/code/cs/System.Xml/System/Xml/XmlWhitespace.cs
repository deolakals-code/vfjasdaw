// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlWhitespace : XmlCharacterData // TypeDefIndex: 13422
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x33C8DF0 Offset: 0x33C4DF0 VA: 0x33C8DF0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x33C8E8C Offset: 0x33C4E8C VA: 0x33C8E8C Slot: 6
	public override string get_Name() { }

	// RVA: 0x33C8EB4 Offset: 0x33C4EB4 VA: 0x33C8EB4 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33C8EDC Offset: 0x33C4EDC VA: 0x33C8EDC Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33C8EE4 Offset: 0x33C4EE4 VA: 0x33C8EE4 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x33C8F6C Offset: 0x33C4F6C VA: 0x33C8F6C Slot: 7
	public override string get_Value() { }

	// RVA: 0x33C8F7C Offset: 0x33C4F7C VA: 0x33C8F7C Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x33C9008 Offset: 0x33C5008 VA: 0x33C9008 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33C9064 Offset: 0x33C5064 VA: 0x33C9064 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33C90A4 Offset: 0x33C50A4 VA: 0x33C90A4 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x33C90A8 Offset: 0x33C50A8 VA: 0x33C90A8 Slot: 55
	internal override bool get_IsText() { }
}

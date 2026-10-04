// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlSignificantWhitespace : XmlCharacterData // TypeDefIndex: 13419
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x33C86C4 Offset: 0x33C46C4 VA: 0x33C86C4
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x33C8760 Offset: 0x33C4760 VA: 0x33C8760 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33C8788 Offset: 0x33C4788 VA: 0x33C8788 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33C87B0 Offset: 0x33C47B0 VA: 0x33C87B0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33C87B8 Offset: 0x33C47B8 VA: 0x33C87B8 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x33C8840 Offset: 0x33C4840 VA: 0x33C8840 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33C889C Offset: 0x33C489C VA: 0x33C889C Slot: 7
	public override string get_Value() { }

	// RVA: 0x33C88AC Offset: 0x33C48AC VA: 0x33C88AC Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x33C8938 Offset: 0x33C4938 VA: 0x33C8938 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33C8978 Offset: 0x33C4978 VA: 0x33C8978 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x33C897C Offset: 0x33C497C VA: 0x33C897C Slot: 55
	internal override bool get_IsText() { }
}

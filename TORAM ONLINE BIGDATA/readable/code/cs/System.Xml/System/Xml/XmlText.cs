// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlText : XmlCharacterData // TypeDefIndex: 13420
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x33C8984 Offset: 0x33C4984 VA: 0x33C8984
	internal void .ctor(string strData) { }

	// RVA: 0x33C8990 Offset: 0x33C4990 VA: 0x33C8990
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x33C8998 Offset: 0x33C4998 VA: 0x33C8998 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33C89C0 Offset: 0x33C49C0 VA: 0x33C89C0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33C89E8 Offset: 0x33C49E8 VA: 0x33C89E8 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33C89F0 Offset: 0x33C49F0 VA: 0x33C89F0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x33C8A74 Offset: 0x33C4A74 VA: 0x33C8A74 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33C8AD0 Offset: 0x33C4AD0 VA: 0x33C8AD0 Slot: 7
	public override string get_Value() { }

	// RVA: 0x33C8AE0 Offset: 0x33C4AE0 VA: 0x33C8AE0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x33C8BA4 Offset: 0x33C4BA4 VA: 0x33C8BA4 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33C8BE4 Offset: 0x33C4BE4 VA: 0x33C8BE4 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x33C8BE8 Offset: 0x33C4BE8 VA: 0x33C8BE8 Slot: 55
	internal override bool get_IsText() { }
}

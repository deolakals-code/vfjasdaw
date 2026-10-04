// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
public class XComment : XNode // TypeDefIndex: 17505
{
	// Fields
	internal string value; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x32BBD98 Offset: 0x32B7D98 VA: 0x32BBD98
	public void .ctor(string value) { }

	// RVA: 0x32BBE1C Offset: 0x32B7E1C VA: 0x32BBE1C
	public void .ctor(XComment other) { }

	// RVA: 0x32BBE98 Offset: 0x32B7E98 VA: 0x32BBE98 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32BBEA0 Offset: 0x32B7EA0 VA: 0x32BBEA0
	public string get_Value() { }

	// RVA: 0x32BBEA8 Offset: 0x32B7EA8 VA: 0x32BBEA8 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x32BBF18 Offset: 0x32B7F18 VA: 0x32BBF18 Slot: 10
	internal override XNode CloneNode() { }
}

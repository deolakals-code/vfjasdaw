// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlProcessingInstruction : XmlLinkedNode // TypeDefIndex: 13418
{
	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public string Data { set; }
	public override string InnerText { get; set; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x33C84D0 Offset: 0x33C44D0 VA: 0x33C84D0
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0x33C8518 Offset: 0x33C4518 VA: 0x33C8518 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33C856C Offset: 0x33C456C VA: 0x33C856C Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33C8578 Offset: 0x33C4578 VA: 0x33C8578 Slot: 7
	public override string get_Value() { }

	// RVA: 0x33C8580 Offset: 0x33C4580 VA: 0x33C8580 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x33C8584 Offset: 0x33C4584 VA: 0x33C8584
	public void set_Data(string value) { }

	// RVA: 0x33C8648 Offset: 0x33C4648 VA: 0x33C8648 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x33C8650 Offset: 0x33C4650 VA: 0x33C8650 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x33C8654 Offset: 0x33C4654 VA: 0x33C8654 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33C865C Offset: 0x33C465C VA: 0x33C865C Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33C8694 Offset: 0x33C4694 VA: 0x33C8694 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33C86C0 Offset: 0x33C46C0 VA: 0x33C86C0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }
}

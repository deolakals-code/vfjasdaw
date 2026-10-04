// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
public class XText : XNode // TypeDefIndex: 17533
{
	// Fields
	internal string text; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x32BBBCC Offset: 0x32B7BCC VA: 0x32BBBCC
	public void .ctor(string value) { }

	// RVA: 0x32BBC4C Offset: 0x32B7C4C VA: 0x32BBC4C
	public void .ctor(XText other) { }

	// RVA: 0x32C39C8 Offset: 0x32BF9C8 VA: 0x32C39C8 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32C39D0 Offset: 0x32BF9D0 VA: 0x32C39D0
	public string get_Value() { }

	// RVA: 0x32BD6C0 Offset: 0x32B96C0 VA: 0x32BD6C0
	public void set_Value(string value) { }

	// RVA: 0x32C39D8 Offset: 0x32BF9D8 VA: 0x32C39D8 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x32C3AC4 Offset: 0x32BFAC4 VA: 0x32C3AC4 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x32C3AE8 Offset: 0x32BFAE8 VA: 0x32C3AE8 Slot: 10
	internal override XNode CloneNode() { }
}

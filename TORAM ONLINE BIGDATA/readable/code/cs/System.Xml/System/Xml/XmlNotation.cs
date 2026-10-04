// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlNotation : XmlNode // TypeDefIndex: 13417
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string name; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public override string InnerXml { set; }

	// Methods

	// RVA: 0x33C836C Offset: 0x33C436C VA: 0x33C836C
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x33C83F8 Offset: 0x33C43F8 VA: 0x33C83F8 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33C8400 Offset: 0x33C4400 VA: 0x33C8400 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33C8408 Offset: 0x33C4408 VA: 0x33C8408 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33C8410 Offset: 0x33C4410 VA: 0x33C8410 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33C8468 Offset: 0x33C4468 VA: 0x33C8468 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x33C8470 Offset: 0x33C4470 VA: 0x33C8470 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x33C84C8 Offset: 0x33C44C8 VA: 0x33C84C8 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33C84CC Offset: 0x33C44CC VA: 0x33C84CC Slot: 44
	public override void WriteContentTo(XmlWriter w) { }
}

// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlCDataSection : XmlCharacterData // TypeDefIndex: 13389
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x33B32BC Offset: 0x33AF2BC VA: 0x33B32BC
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x33B3304 Offset: 0x33AF304 VA: 0x33B3304 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33B332C Offset: 0x33AF32C VA: 0x33B332C Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33B3354 Offset: 0x33AF354 VA: 0x33B3354 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33B335C Offset: 0x33AF35C VA: 0x33B335C Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x33B33E0 Offset: 0x33AF3E0 VA: 0x33B33E0 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33B343C Offset: 0x33AF43C VA: 0x33B343C Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33B347C Offset: 0x33AF47C VA: 0x33B347C Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x33B3480 Offset: 0x33AF480 VA: 0x33B3480 Slot: 55
	internal override bool get_IsText() { }
}

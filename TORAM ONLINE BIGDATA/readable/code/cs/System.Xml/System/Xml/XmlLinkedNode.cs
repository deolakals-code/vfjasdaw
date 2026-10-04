// Assembly: System.Xml.dll
// Namespace: System.Xml
public abstract class XmlLinkedNode : XmlNode // TypeDefIndex: 13403
{
	// Fields
	internal XmlLinkedNode next; // 0x18

	// Properties
	public override XmlNode PreviousSibling { get; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x33B3488 Offset: 0x33AF488 VA: 0x33B3488
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x33BBA2C Offset: 0x33B7A2C VA: 0x33BBA2C Slot: 12
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x33BBA94 Offset: 0x33B7A94 VA: 0x33BBA94 Slot: 13
	public override XmlNode get_NextSibling() { }
}

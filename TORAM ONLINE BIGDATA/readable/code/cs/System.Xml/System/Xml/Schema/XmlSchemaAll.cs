// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaAll : XmlSchemaGroupBase // TypeDefIndex: 13750
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("element", typeof(XmlSchemaElement))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x33325C4 Offset: 0x332E5C4 VA: 0x33325C4 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x33325CC Offset: 0x332E5CC VA: 0x33325CC Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x333260C Offset: 0x332E60C VA: 0x333260C Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x3332614 Offset: 0x332E614 VA: 0x3332614
	public void .ctor() { }
}

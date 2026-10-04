// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaChoice : XmlSchemaGroupBase // TypeDefIndex: 13759
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x3333D68 Offset: 0x332FD68 VA: 0x3333D68 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x3333D70 Offset: 0x332FD70 VA: 0x3333D70 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x3333D78 Offset: 0x332FD78 VA: 0x3333D78 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x3333D80 Offset: 0x332FD80 VA: 0x3333D80
	public void .ctor() { }
}

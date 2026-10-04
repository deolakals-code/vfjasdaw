// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaSequence : XmlSchemaGroupBase // TypeDefIndex: 13819
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x333B318 Offset: 0x3337318 VA: 0x333B318 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x333B320 Offset: 0x3337320 VA: 0x333B320 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x333B35C Offset: 0x333735C VA: 0x333B35C Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x333B364 Offset: 0x3337364 VA: 0x333B364
	public void .ctor() { }
}

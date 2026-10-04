// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public abstract class XmlSchemaGroupBase : XmlSchemaParticle // TypeDefIndex: 13795
{
	// Properties
	[XmlIgnore]
	public abstract XmlSchemaObjectCollection Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract XmlSchemaObjectCollection get_Items();

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void SetItems(XmlSchemaObjectCollection newItems);

	// RVA: 0x333267C Offset: 0x332E67C VA: 0x333267C
	protected void .ctor() { }
}

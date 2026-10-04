// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
public interface IXmlSerializable // TypeDefIndex: 13495
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlSchema GetSchema();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReadXml(XmlReader reader);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void WriteXml(XmlWriter writer);
}

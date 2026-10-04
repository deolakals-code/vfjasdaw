// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
public class XmlAttributeEventArgs : EventArgs // TypeDefIndex: 13488
{
	// Fields
	private object o; // 0x10
	private XmlAttribute attr; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x33E6D9C Offset: 0x33E2D9C VA: 0x33E6D9C
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }
}

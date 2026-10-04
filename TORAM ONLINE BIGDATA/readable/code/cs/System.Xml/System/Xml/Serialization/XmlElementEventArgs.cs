// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
public class XmlElementEventArgs : EventArgs // TypeDefIndex: 13490
{
	// Fields
	private object o; // 0x10
	private XmlElement elem; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x33E6F78 Offset: 0x33E2F78 VA: 0x33E6F78
	internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }
}

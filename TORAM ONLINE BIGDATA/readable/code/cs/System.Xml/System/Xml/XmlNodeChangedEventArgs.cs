// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlNodeChangedEventArgs : EventArgs // TypeDefIndex: 13411
{
	// Fields
	private XmlNodeChangedAction action; // 0x10
	private XmlNode node; // 0x18
	private XmlNode oldParent; // 0x20
	private XmlNode newParent; // 0x28
	private string oldValue; // 0x30
	private string newValue; // 0x38

	// Properties
	public XmlNodeChangedAction Action { get; }

	// Methods

	// RVA: 0x33C3BB4 Offset: 0x33BFBB4 VA: 0x33C3BB4
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x33C3C90 Offset: 0x33BFC90 VA: 0x33C3C90
	public XmlNodeChangedAction get_Action() { }
}

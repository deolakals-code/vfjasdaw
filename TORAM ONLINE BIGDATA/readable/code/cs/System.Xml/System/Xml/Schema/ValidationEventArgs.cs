// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class ValidationEventArgs : EventArgs // TypeDefIndex: 13730
{
	// Fields
	private XmlSchemaException ex; // 0x10
	private XmlSeverityType severity; // 0x18

	// Properties
	public XmlSeverityType Severity { get; }
	public XmlSchemaException Exception { get; }

	// Methods

	// RVA: 0x3324D74 Offset: 0x3320D74 VA: 0x3324D74
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0x3324DF0 Offset: 0x3320DF0 VA: 0x3324DF0
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x3324E70 Offset: 0x3320E70 VA: 0x3324E70
	public XmlSeverityType get_Severity() { }

	// RVA: 0x3324E78 Offset: 0x3320E78 VA: 0x3324E78
	public XmlSchemaException get_Exception() { }
}

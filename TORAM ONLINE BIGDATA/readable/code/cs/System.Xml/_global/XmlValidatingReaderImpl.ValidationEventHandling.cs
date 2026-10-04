// Assembly: System.Xml.dll
// Namespace: 
internal class XmlValidatingReaderImpl.ValidationEventHandling : IValidationEventHandling // TypeDefIndex: 13359
{
	// Fields
	private XmlValidatingReaderImpl reader; // 0x10
	private ValidationEventHandler eventHandler; // 0x18

	// Properties
	private object System.Xml.IValidationEventHandling.EventHandler { get; }

	// Methods

	// RVA: 0x33A08EC Offset: 0x339C8EC VA: 0x33A08EC
	internal void .ctor(XmlValidatingReaderImpl reader) { }

	// RVA: 0x33A1B2C Offset: 0x339DB2C VA: 0x33A1B2C Slot: 4
	private object System.Xml.IValidationEventHandling.get_EventHandler() { }

	// RVA: 0x33A1B34 Offset: 0x339DB34 VA: 0x33A1B34 Slot: 5
	private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x33A091C Offset: 0x339C91C VA: 0x33A091C
	internal void AddHandler(ValidationEventHandler handler) { }
}

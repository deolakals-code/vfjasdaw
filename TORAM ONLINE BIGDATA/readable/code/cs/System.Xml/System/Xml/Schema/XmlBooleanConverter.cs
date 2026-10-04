// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class XmlBooleanConverter : XmlBaseConverter // TypeDefIndex: 13847
{
	// Methods

	// RVA: 0x335D158 Offset: 0x3359158 VA: 0x335D158
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x335D1C0 Offset: 0x33591C0 VA: 0x335D1C0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x335D218 Offset: 0x3359218 VA: 0x335D218 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x335D2BC Offset: 0x33592BC VA: 0x335D2BC Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x335D59C Offset: 0x335959C VA: 0x335D59C Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x335D5F4 Offset: 0x33595F4 VA: 0x335D5F4 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335D8AC Offset: 0x33598AC VA: 0x335D8AC Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x335DBCC Offset: 0x3359BCC VA: 0x335DBCC Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335DF00 Offset: 0x3359F00 VA: 0x335DF00 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

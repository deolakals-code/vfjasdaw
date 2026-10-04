// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class XmlDateTimeConverter : XmlBaseConverter // TypeDefIndex: 13846
{
	// Methods

	// RVA: 0x335B018 Offset: 0x3357018 VA: 0x335B018
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x335B080 Offset: 0x3357080 VA: 0x335B080
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x335B0D8 Offset: 0x33570D8 VA: 0x335B0D8 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x335B140 Offset: 0x3357140 VA: 0x335B140 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x335B344 Offset: 0x3357344 VA: 0x335B344 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x335B6A4 Offset: 0x33576A4 VA: 0x335B6A4 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x335B6CC Offset: 0x33576CC VA: 0x335B6CC Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x335B8D0 Offset: 0x33578D0 VA: 0x335B8D0 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x335BC3C Offset: 0x3357C3C VA: 0x335BC3C Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x335BDF4 Offset: 0x3357DF4 VA: 0x335BDF4 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x335BFF4 Offset: 0x3357FF4 VA: 0x335BFF4 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335C334 Offset: 0x3358334 VA: 0x335C334 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x335C6BC Offset: 0x33586BC VA: 0x335C6BC Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335CA4C Offset: 0x3358A4C VA: 0x335CA4C Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

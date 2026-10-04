// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class XmlNumeric10Converter : XmlBaseConverter // TypeDefIndex: 13844
{
	// Methods

	// RVA: 0x3355788 Offset: 0x3351788 VA: 0x3355788
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x33557F0 Offset: 0x33517F0 VA: 0x33557F0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x3355848 Offset: 0x3351848 VA: 0x3355848 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x335590C Offset: 0x335190C VA: 0x335590C Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x3356164 Offset: 0x3352164 VA: 0x3356164 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x33561BC Offset: 0x33521BC VA: 0x33561BC Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x33562BC Offset: 0x33522BC VA: 0x33562BC Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x33566AC Offset: 0x33526AC VA: 0x33566AC Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x33566B4 Offset: 0x33526B4 VA: 0x33566B4 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x33567B4 Offset: 0x33527B4 VA: 0x33567B4 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x3356B88 Offset: 0x3352B88 VA: 0x3356B88 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x3356C44 Offset: 0x3352C44 VA: 0x3356C44 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x3356C9C Offset: 0x3352C9C VA: 0x3356C9C Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x3356CF4 Offset: 0x3352CF4 VA: 0x3356CF4 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x33570EC Offset: 0x33530EC VA: 0x33570EC Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x335798C Offset: 0x335398C VA: 0x335798C Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x3357DA8 Offset: 0x3353DA8 VA: 0x3357DA8 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x33581D4 Offset: 0x33541D4 VA: 0x33581D4 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x33585F4 Offset: 0x33545F4 VA: 0x33585F4 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x3355D04 Offset: 0x3351D04 VA: 0x3355D04
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335752C Offset: 0x335352C VA: 0x335752C
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

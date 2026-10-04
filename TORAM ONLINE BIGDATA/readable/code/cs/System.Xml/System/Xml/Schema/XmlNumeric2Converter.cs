// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class XmlNumeric2Converter : XmlBaseConverter // TypeDefIndex: 13845
{
	// Methods

	// RVA: 0x33594F8 Offset: 0x33554F8 VA: 0x33594F8
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x3359560 Offset: 0x3355560 VA: 0x3359560
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x33595B8 Offset: 0x33555B8 VA: 0x33595B8 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x3359684 Offset: 0x3355684 VA: 0x3359684 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x33599C8 Offset: 0x33559C8 VA: 0x33599C8 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x33599D0 Offset: 0x33559D0 VA: 0x33599D0 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x3359A9C Offset: 0x3355A9C VA: 0x3359A9C Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x3359DE8 Offset: 0x3355DE8 VA: 0x3359DE8 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x3359E9C Offset: 0x3355E9C VA: 0x3359E9C Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x3359F24 Offset: 0x3355F24 VA: 0x3359F24 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335A264 Offset: 0x3356264 VA: 0x335A264 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x335A5C0 Offset: 0x33565C0 VA: 0x335A5C0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335A950 Offset: 0x3356950 VA: 0x335A950 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

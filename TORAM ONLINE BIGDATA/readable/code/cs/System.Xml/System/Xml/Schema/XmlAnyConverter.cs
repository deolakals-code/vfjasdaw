// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class XmlAnyConverter : XmlBaseConverter // TypeDefIndex: 13851
{
	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x33675C8 Offset: 0x33635C8 VA: 0x33675C8
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x3367630 Offset: 0x3363630 VA: 0x3367630 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x336791C Offset: 0x336391C VA: 0x336791C Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x3367ACC Offset: 0x3363ACC VA: 0x3367ACC Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x3367C88 Offset: 0x3363C88 VA: 0x3367C88 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x3367E44 Offset: 0x3363E44 VA: 0x3367E44 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x3367FF4 Offset: 0x3363FF4 VA: 0x3367FF4 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x33681A4 Offset: 0x33641A4 VA: 0x33681A4 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x3368354 Offset: 0x3364354 VA: 0x3368354 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x3368510 Offset: 0x3364510 VA: 0x3368510 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x3368864 Offset: 0x3364864 VA: 0x3368864 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x3368A50 Offset: 0x3364A50 VA: 0x3368A50 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x3368C8C Offset: 0x3364C8C VA: 0x3368C8C Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x3368E78 Offset: 0x3364E78 VA: 0x3368E78 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x3369064 Offset: 0x3365064 VA: 0x3369064 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x3369250 Offset: 0x3365250 VA: 0x3369250 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x3369448 Offset: 0x3365448 VA: 0x3369448 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x33677E0 Offset: 0x33637E0 VA: 0x33677E0
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x3368700 Offset: 0x3364700 VA: 0x3368700
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x336A910 Offset: 0x3366910 VA: 0x336A910
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x336A998 Offset: 0x3366998 VA: 0x336A998
	private static void .cctor() { }
}

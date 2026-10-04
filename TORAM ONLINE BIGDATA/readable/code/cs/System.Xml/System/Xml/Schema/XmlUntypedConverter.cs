// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class XmlUntypedConverter : XmlListConverter // TypeDefIndex: 13850
{
	// Fields
	private bool allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0x33608BC Offset: 0x335C8BC VA: 0x33608BC
	protected void .ctor() { }

	// RVA: 0x33609B4 Offset: 0x335C9B4 VA: 0x33609B4
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0x3360AC0 Offset: 0x335CAC0 VA: 0x3360AC0 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x3360B64 Offset: 0x335CB64 VA: 0x3360B64 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x3360E6C Offset: 0x335CE6C VA: 0x3360E6C Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x3360F10 Offset: 0x335CF10 VA: 0x3360F10 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x33610C4 Offset: 0x335D0C4 VA: 0x33610C4 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x3361168 Offset: 0x335D168 VA: 0x3361168 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x336131C Offset: 0x335D31C VA: 0x336131C Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x33613C0 Offset: 0x335D3C0 VA: 0x33613C0 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x336158C Offset: 0x335D58C VA: 0x336158C Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x3361630 Offset: 0x335D630 VA: 0x3361630 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x33617FC Offset: 0x335D7FC VA: 0x33617FC Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x33618A0 Offset: 0x335D8A0 VA: 0x33618A0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x3361A6C Offset: 0x335DA6C VA: 0x3361A6C Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x3361B10 Offset: 0x335DB10 VA: 0x3361B10 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x3361CDC Offset: 0x335DCDC VA: 0x3361CDC Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x3361D80 Offset: 0x335DD80 VA: 0x3361D80 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x3361F4C Offset: 0x335DF4C VA: 0x3361F4C Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x3361FA4 Offset: 0x335DFA4 VA: 0x3361FA4 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x3361FFC Offset: 0x335DFFC VA: 0x3361FFC Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x3362064 Offset: 0x335E064 VA: 0x3362064 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x33620CC Offset: 0x335E0CC VA: 0x33620CC Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x336212C Offset: 0x335E12C VA: 0x336212C Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x3362184 Offset: 0x335E184 VA: 0x3362184 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x33621DC Offset: 0x335E1DC VA: 0x33621DC Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x336223C Offset: 0x335E23C VA: 0x336223C Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x3362FE8 Offset: 0x335EFE8 VA: 0x3362FE8 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x3363358 Offset: 0x335F358 VA: 0x3363358 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x3363520 Offset: 0x335F520 VA: 0x3363520 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x3363728 Offset: 0x335F728 VA: 0x3363728 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x3363904 Offset: 0x335F904 VA: 0x3363904 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x3363AE0 Offset: 0x335FAE0 VA: 0x3363AE0 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x3363CBC Offset: 0x335FCBC VA: 0x3363CBC Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x336490C Offset: 0x336090C VA: 0x336490C Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x3360D30 Offset: 0x335CD30 VA: 0x3360D30
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x33631C8 Offset: 0x335F1C8 VA: 0x33631C8
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x3365EE8 Offset: 0x3361EE8 VA: 0x3365EE8 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x33661E8 Offset: 0x33621E8 VA: 0x33661E8
	private bool SupportsType(Type clrType) { }

	// RVA: 0x3367510 Offset: 0x3363510 VA: 0x3367510
	private static void .cctor() { }
}

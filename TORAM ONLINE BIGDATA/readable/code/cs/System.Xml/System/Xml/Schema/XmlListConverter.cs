// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class XmlListConverter : XmlBaseConverter // TypeDefIndex: 13853
{
	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x336AA2C Offset: 0x3366A2C VA: 0x336AA2C
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x3360A40 Offset: 0x335CA40 VA: 0x3360A40
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x336094C Offset: 0x335C94C VA: 0x336094C
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x336AE60 Offset: 0x3366E60 VA: 0x336AE60
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x336B00C Offset: 0x336700C VA: 0x336B00C Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x3366718 Offset: 0x3362718 VA: 0x3366718 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x336B10C Offset: 0x336710C VA: 0x336B10C
	private bool IsListType(Type type) { }

	// RVA: -1 Offset: -1
	private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FC274 Offset: 0x26F8274 VA: 0x26FC274
	|-XmlListConverter.ToArray<bool>
	|
	|-RVA: 0x26FC98C Offset: 0x26F898C VA: 0x26FC98C
	|-XmlListConverter.ToArray<byte>
	|
	|-RVA: 0x26FD09C Offset: 0x26F909C VA: 0x26FD09C
	|-XmlListConverter.ToArray<DateTime>
	|
	|-RVA: 0x26FD7AC Offset: 0x26F97AC VA: 0x26FD7AC
	|-XmlListConverter.ToArray<DateTimeOffset>
	|
	|-RVA: 0x26FDEBC Offset: 0x26F9EBC VA: 0x26FDEBC
	|-XmlListConverter.ToArray<Decimal>
	|
	|-RVA: 0x26FE5CC Offset: 0x26FA5CC VA: 0x26FE5CC
	|-XmlListConverter.ToArray<double>
	|
	|-RVA: 0x26FECDC Offset: 0x26FACDC VA: 0x26FECDC
	|-XmlListConverter.ToArray<short>
	|
	|-RVA: 0x26FF3EC Offset: 0x26FB3EC VA: 0x26FF3EC
	|-XmlListConverter.ToArray<int>
	|
	|-RVA: 0x26FFAFC Offset: 0x26FBAFC VA: 0x26FFAFC
	|-XmlListConverter.ToArray<long>
	|
	|-RVA: 0x270020C Offset: 0x26FC20C VA: 0x270020C
	|-XmlListConverter.ToArray<object>
	|
	|-RVA: 0x2700924 Offset: 0x26FC924 VA: 0x2700924
	|-XmlListConverter.ToArray<sbyte>
	|
	|-RVA: 0x2701034 Offset: 0x26FD034 VA: 0x2701034
	|-XmlListConverter.ToArray<float>
	|
	|-RVA: 0x2701744 Offset: 0x26FD744 VA: 0x2701744
	|-XmlListConverter.ToArray<TimeSpan>
	|
	|-RVA: 0x2701E54 Offset: 0x26FDE54 VA: 0x2701E54
	|-XmlListConverter.ToArray<ushort>
	|
	|-RVA: 0x2702564 Offset: 0x26FE564 VA: 0x2702564
	|-XmlListConverter.ToArray<uint>
	|
	|-RVA: 0x2702C74 Offset: 0x26FEC74 VA: 0x2702C74
	|-XmlListConverter.ToArray<ulong>
	|
	|-RVA: 0x2703384 Offset: 0x26FF384 VA: 0x2703384
	|-XmlListConverter.ToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x336B994 Offset: 0x3367994 VA: 0x336B994
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x336B8EC Offset: 0x33678EC VA: 0x336B8EC
	private List<string> StringAsList(string value) { }

	// RVA: 0x336B534 Offset: 0x3367534 VA: 0x336B534
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x336B29C Offset: 0x336729C VA: 0x336B29C
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }
}

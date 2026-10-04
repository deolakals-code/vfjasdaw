// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal abstract class XmlBaseConverter : XmlValueConverter // TypeDefIndex: 13843
{
	// Fields
	private XmlSchemaType schemaType; // 0x10
	private XmlTypeCode typeCode; // 0x18
	private Type clrTypeDefault; // 0x20
	protected static readonly Type ICollectionType; // 0x0
	protected static readonly Type IEnumerableType; // 0x8
	protected static readonly Type IListType; // 0x10
	protected static readonly Type ObjectArrayType; // 0x18
	protected static readonly Type StringArrayType; // 0x20
	protected static readonly Type XmlAtomicValueArrayType; // 0x28
	protected static readonly Type DecimalType; // 0x30
	protected static readonly Type Int32Type; // 0x38
	protected static readonly Type Int64Type; // 0x40
	protected static readonly Type StringType; // 0x48
	protected static readonly Type XmlAtomicValueType; // 0x50
	protected static readonly Type ObjectType; // 0x58
	protected static readonly Type ByteType; // 0x60
	protected static readonly Type Int16Type; // 0x68
	protected static readonly Type SByteType; // 0x70
	protected static readonly Type UInt16Type; // 0x78
	protected static readonly Type UInt32Type; // 0x80
	protected static readonly Type UInt64Type; // 0x88
	protected static readonly Type XPathItemType; // 0x90
	protected static readonly Type DoubleType; // 0x98
	protected static readonly Type SingleType; // 0xA0
	protected static readonly Type DateTimeType; // 0xA8
	protected static readonly Type DateTimeOffsetType; // 0xB0
	protected static readonly Type BooleanType; // 0xB8
	protected static readonly Type ByteArrayType; // 0xC0
	protected static readonly Type XmlQualifiedNameType; // 0xC8
	protected static readonly Type UriType; // 0xD0
	protected static readonly Type TimeSpanType; // 0xD8
	protected static readonly Type XPathNavigatorType; // 0xE0

	// Properties
	protected XmlSchemaType SchemaType { get; }
	protected XmlTypeCode TypeCode { get; }
	protected string XmlTypeName { get; }
	protected Type DefaultClrType { get; }

	// Methods

	// RVA: 0x334F380 Offset: 0x334B380 VA: 0x334F380
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x334F468 Offset: 0x334B468 VA: 0x334F468
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x334F54C Offset: 0x334B54C VA: 0x334F54C
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x334F5BC Offset: 0x334B5BC VA: 0x334F5BC
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x334F610 Offset: 0x334B610 VA: 0x334F610 Slot: 7
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x334F708 Offset: 0x334B708 VA: 0x334F708 Slot: 6
	public override bool ToBoolean(double value) { }

	// RVA: 0x334F808 Offset: 0x334B808 VA: 0x334F808 Slot: 5
	public override bool ToBoolean(int value) { }

	// RVA: 0x334F900 Offset: 0x334B900 VA: 0x334F900 Slot: 4
	public override bool ToBoolean(long value) { }

	// RVA: 0x334F9F8 Offset: 0x334B9F8 VA: 0x334F9F8 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x334FABC Offset: 0x334BABC VA: 0x334FABC Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x334FB80 Offset: 0x334BB80 VA: 0x334FB80 Slot: 33
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x334FC7C Offset: 0x334BC7C VA: 0x334FC7C Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x334FD80 Offset: 0x334BD80 VA: 0x334FD80 Slot: 36
	public override DateTime ToDateTime(double value) { }

	// RVA: 0x334FE80 Offset: 0x334BE80 VA: 0x334FE80 Slot: 34
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x334FF78 Offset: 0x334BF78 VA: 0x334FF78 Slot: 35
	public override DateTime ToDateTime(long value) { }

	// RVA: 0x3350070 Offset: 0x334C070 VA: 0x3350070 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x3350134 Offset: 0x334C134 VA: 0x3350134 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x33501F8 Offset: 0x334C1F8 VA: 0x33501F8 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x33502F4 Offset: 0x334C2F4 VA: 0x33502F4 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x33503BC Offset: 0x334C3BC VA: 0x33503BC Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x3350484 Offset: 0x334C484 VA: 0x3350484 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x335054C Offset: 0x334C54C VA: 0x335054C Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x3350614 Offset: 0x334C614 VA: 0x3350614 Slot: 24
	public override double ToDouble(bool value) { }

	// RVA: 0x3350710 Offset: 0x334C710 VA: 0x3350710 Slot: 27
	public override double ToDouble(DateTime value) { }

	// RVA: 0x3350808 Offset: 0x334C808 VA: 0x3350808 Slot: 25
	public override double ToDouble(int value) { }

	// RVA: 0x3350900 Offset: 0x334C900 VA: 0x3350900 Slot: 26
	public override double ToDouble(long value) { }

	// RVA: 0x33509F8 Offset: 0x334C9F8 VA: 0x33509F8 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x3350ABC Offset: 0x334CABC VA: 0x3350ABC Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x3350B80 Offset: 0x334CB80 VA: 0x3350B80 Slot: 10
	public override int ToInt32(bool value) { }

	// RVA: 0x3350C7C Offset: 0x334CC7C VA: 0x3350C7C Slot: 13
	public override int ToInt32(DateTime value) { }

	// RVA: 0x3350D74 Offset: 0x334CD74 VA: 0x3350D74 Slot: 12
	public override int ToInt32(double value) { }

	// RVA: 0x3350E74 Offset: 0x334CE74 VA: 0x3350E74 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x3350F6C Offset: 0x334CF6C VA: 0x3350F6C Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x3351030 Offset: 0x334D030 VA: 0x3351030 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x33510F4 Offset: 0x334D0F4 VA: 0x33510F4 Slot: 16
	public override long ToInt64(bool value) { }

	// RVA: 0x33511F0 Offset: 0x334D1F0 VA: 0x33511F0 Slot: 19
	public override long ToInt64(DateTime value) { }

	// RVA: 0x33512E8 Offset: 0x334D2E8 VA: 0x33512E8 Slot: 18
	public override long ToInt64(double value) { }

	// RVA: 0x33513E8 Offset: 0x334D3E8 VA: 0x33513E8 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x33514E0 Offset: 0x334D4E0 VA: 0x33514E0 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x33515A4 Offset: 0x334D5A4 VA: 0x33515A4 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x3351668 Offset: 0x334D668 VA: 0x3351668 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x3351768 Offset: 0x334D768 VA: 0x3351768 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x335182C Offset: 0x334D82C VA: 0x335182C Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x33518F0 Offset: 0x334D8F0 VA: 0x33518F0 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x33519D8 Offset: 0x334D9D8 VA: 0x33519D8 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x3351ABC Offset: 0x334DABC VA: 0x3351ABC Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x3351BAC Offset: 0x334DBAC VA: 0x3351BAC Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x3351CBC Offset: 0x334DCBC VA: 0x3351CBC Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x3351DA8 Offset: 0x334DDA8 VA: 0x3351DA8 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x3351E8C Offset: 0x334DE8C VA: 0x3351E8C Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x3351F70 Offset: 0x334DF70 VA: 0x3351F70 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x335205C Offset: 0x334E05C VA: 0x335205C Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x3352110 Offset: 0x334E110 VA: 0x3352110 Slot: 51
	public override string ToString(object value) { }

	// RVA: 0x3352124 Offset: 0x334E124 VA: 0x3352124 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x33521B0 Offset: 0x334E1B0 VA: 0x33521B0 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x3352238 Offset: 0x334E238 VA: 0x3352238 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x33522EC Offset: 0x334E2EC VA: 0x33522EC Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x335237C Offset: 0x334E37C VA: 0x335237C Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x3352404 Offset: 0x334E404 VA: 0x3352404 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x335248C Offset: 0x334E48C VA: 0x335248C Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335249C Offset: 0x334E49C VA: 0x335249C Slot: 60
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x33524B0 Offset: 0x334E4B0 VA: 0x33524B0
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x33524B8 Offset: 0x334E4B8 VA: 0x33524B8
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x33524C0 Offset: 0x334E4C0 VA: 0x33524C0
	protected string get_XmlTypeName() { }

	// RVA: 0x33526D4 Offset: 0x334E6D4 VA: 0x33526D4
	protected Type get_DefaultClrType() { }

	// RVA: 0x33526DC Offset: 0x334E6DC VA: 0x33526DC
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x335279C Offset: 0x334E79C VA: 0x335279C
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x33525B4 Offset: 0x334E5B4 VA: 0x33525B4
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x3352A2C Offset: 0x334EA2C VA: 0x3352A2C Slot: 62
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x3352A80 Offset: 0x334EA80 VA: 0x3352A80
	protected static byte[] StringToBase64Binary(string value) { }

	// RVA: 0x3352B10 Offset: 0x334EB10 VA: 0x3352B10
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x3352B8C Offset: 0x334EB8C VA: 0x3352B8C
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x3352C08 Offset: 0x334EC08 VA: 0x3352C08
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x3352C68 Offset: 0x334EC68 VA: 0x3352C68
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x3352CC8 Offset: 0x334ECC8 VA: 0x3352CC8
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x3352D44 Offset: 0x334ED44 VA: 0x3352D44
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x3352DC0 Offset: 0x334EDC0 VA: 0x3352DC0
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x3352E3C Offset: 0x334EE3C VA: 0x3352E3C
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x3352EB8 Offset: 0x334EEB8 VA: 0x3352EB8
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x3352F34 Offset: 0x334EF34 VA: 0x3352F34
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x3352FB0 Offset: 0x334EFB0 VA: 0x3352FB0
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x335302C Offset: 0x334F02C VA: 0x335302C
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x33530A8 Offset: 0x334F0A8 VA: 0x33530A8
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x3353124 Offset: 0x334F124 VA: 0x3353124
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x33531A0 Offset: 0x334F1A0 VA: 0x33531A0
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x335321C Offset: 0x334F21C VA: 0x335321C
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x3353298 Offset: 0x334F298 VA: 0x3353298
	protected static byte[] StringToHexBinary(string value) { }

	// RVA: 0x33533CC Offset: 0x334F3CC VA: 0x33533CC
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x335367C Offset: 0x334F67C VA: 0x335367C
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x33536F8 Offset: 0x334F6F8 VA: 0x33536F8
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x3353774 Offset: 0x334F774 VA: 0x3353774
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x33537D4 Offset: 0x334F7D4 VA: 0x33537D4
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x33537E8 Offset: 0x334F7E8 VA: 0x33537E8
	protected static string Base64BinaryToString(byte[] value) { }

	// RVA: 0x3353840 Offset: 0x334F840 VA: 0x3353840
	protected static string DateToString(DateTime value) { }

	// RVA: 0x33538C8 Offset: 0x334F8C8 VA: 0x33538C8
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x3353950 Offset: 0x334F950 VA: 0x3353950
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x33539B0 Offset: 0x334F9B0 VA: 0x33539B0
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x3353A10 Offset: 0x334FA10 VA: 0x3353A10
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x3353A98 Offset: 0x334FA98 VA: 0x3353A98
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x3353B20 Offset: 0x334FB20 VA: 0x3353B20
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x3353BA8 Offset: 0x334FBA8 VA: 0x3353BA8
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x3353C30 Offset: 0x334FC30 VA: 0x3353C30
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x3353CB8 Offset: 0x334FCB8 VA: 0x3353CB8
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x3353D50 Offset: 0x334FD50 VA: 0x3353D50
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x3353DE8 Offset: 0x334FDE8 VA: 0x3353DE8
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x3353E80 Offset: 0x334FE80 VA: 0x3353E80
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x3353F18 Offset: 0x334FF18 VA: 0x3353F18
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x3353FB0 Offset: 0x334FFB0 VA: 0x3353FB0
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x3354048 Offset: 0x3350048 VA: 0x3354048
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x33540E0 Offset: 0x33500E0 VA: 0x33540E0
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x33542F4 Offset: 0x33502F4 VA: 0x33542F4
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x335437C Offset: 0x335037C VA: 0x335437C
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x3354414 Offset: 0x3350414 VA: 0x3354414
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x3354474 Offset: 0x3350474 VA: 0x3354474
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x33544D8 Offset: 0x33504D8 VA: 0x33544D8
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x33546B0 Offset: 0x33506B0 VA: 0x33546B0
	protected static long DecimalToInt64(Decimal value) { }

	// RVA: 0x3354888 Offset: 0x3350888 VA: 0x3354888
	protected static ulong DecimalToUInt64(Decimal value) { }

	// RVA: 0x3354A54 Offset: 0x3350A54 VA: 0x3354A54
	protected static byte Int32ToByte(int value) { }

	// RVA: 0x3354B38 Offset: 0x3350B38 VA: 0x3354B38
	protected static short Int32ToInt16(int value) { }

	// RVA: 0x3354C1C Offset: 0x3350C1C VA: 0x3354C1C
	protected static sbyte Int32ToSByte(int value) { }

	// RVA: 0x3354D00 Offset: 0x3350D00 VA: 0x3354D00
	protected static ushort Int32ToUInt16(int value) { }

	// RVA: 0x3354DE4 Offset: 0x3350DE4 VA: 0x3354DE4
	protected static int Int64ToInt32(long value) { }

	// RVA: 0x3354EC8 Offset: 0x3350EC8 VA: 0x3354EC8
	protected static uint Int64ToUInt32(long value) { }

	// RVA: 0x3354FAC Offset: 0x3350FAC VA: 0x3354FAC
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x3355028 Offset: 0x3351028 VA: 0x3355028
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x33550A4 Offset: 0x33510A4 VA: 0x33550A4
	private static void .cctor() { }
}

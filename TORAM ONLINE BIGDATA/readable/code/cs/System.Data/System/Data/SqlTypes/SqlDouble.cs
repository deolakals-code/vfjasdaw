// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDouble : INullable, IComparable, IXmlSerializable // TypeDefIndex: 14808
{
	// Fields
	private bool m_fNotNull; // 0x0
	private double m_value; // 0x8
	public static readonly SqlDouble Null; // 0x0
	public static readonly SqlDouble Zero; // 0x10
	public static readonly SqlDouble MinValue; // 0x20
	public static readonly SqlDouble MaxValue; // 0x30

	// Properties
	public bool IsNull { get; }
	public double Value { get; }

	// Methods

	// RVA: 0x32541E8 Offset: 0x32501E8 VA: 0x32541E8
	private void .ctor(bool fNull) { }

	// RVA: 0x32541F4 Offset: 0x32501F4 VA: 0x32541F4
	public void .ctor(double value) { }

	// RVA: 0x3254264 Offset: 0x3250264 VA: 0x3254264 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x3254274 Offset: 0x3250274 VA: 0x3254274
	public double get_Value() { }

	// RVA: 0x32542C0 Offset: 0x32502C0 VA: 0x32542C0
	public static SqlDouble op_Implicit(double x) { }

	// RVA: 0x32542E4 Offset: 0x32502E4 VA: 0x32542E4 Slot: 3
	public override string ToString() { }

	// RVA: 0x3254380 Offset: 0x3250380 VA: 0x3254380
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0x3254428 Offset: 0x3250428 VA: 0x3254428
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0x3254550 Offset: 0x3250550 VA: 0x3254550
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0x3254678 Offset: 0x3250678 VA: 0x3254678
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0x32547A0 Offset: 0x32507A0 VA: 0x32547A0
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0x324A564 Offset: 0x3246564 VA: 0x324A564
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0x32548FC Offset: 0x32508FC VA: 0x32548FC
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0x32549C8 Offset: 0x32509C8 VA: 0x32549C8
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0x3254A90 Offset: 0x3250A90 VA: 0x3254A90
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0x3254B58 Offset: 0x3250B58 VA: 0x3254B58
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0x3254C24 Offset: 0x3250C24 VA: 0x3254C24
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0x3253168 Offset: 0x324F168 VA: 0x3253168
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0x3254D78 Offset: 0x3250D78 VA: 0x3254D78
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0x3254E50 Offset: 0x3250E50 VA: 0x3254E50
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x3254F28 Offset: 0x3250F28 VA: 0x3254F28
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x3255000 Offset: 0x3251000 VA: 0x3255000
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x3255084 Offset: 0x3251084 VA: 0x3255084
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x3255108 Offset: 0x3251108 VA: 0x3255108
	public SqlSingle ToSqlSingle() { }

	// RVA: 0x3255168 Offset: 0x3251168 VA: 0x3255168 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x3255270 Offset: 0x3251270 VA: 0x3255270
	public int CompareTo(SqlDouble value) { }

	// RVA: 0x32553D0 Offset: 0x32513D0 VA: 0x32553D0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3255510 Offset: 0x3251510 VA: 0x3255510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x32555A4 Offset: 0x32515A4 VA: 0x32555A4 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x32555AC Offset: 0x32515AC VA: 0x32555AC Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x32556CC Offset: 0x32516CC VA: 0x32556CC Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x3255808 Offset: 0x3251808 VA: 0x3255808
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x3255894 Offset: 0x3251894 VA: 0x3255894
	private static void .cctor() { }
}

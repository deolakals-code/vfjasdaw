// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlByte : INullable, IComparable, IXmlSerializable // TypeDefIndex: 14802
{
	// Fields
	private bool m_fNotNull; // 0x0
	private byte m_value; // 0x1
	private static readonly int s_iBitNotByteMax; // 0x0
	public static readonly SqlByte Null; // 0x4
	public static readonly SqlByte Zero; // 0x6
	public static readonly SqlByte MinValue; // 0x8
	public static readonly SqlByte MaxValue; // 0xA

	// Properties
	public bool IsNull { get; }
	public byte Value { get; }

	// Methods

	// RVA: 0x3249A80 Offset: 0x3245A80 VA: 0x3249A80
	private void .ctor(bool fNull) { }

	// RVA: 0x3249A88 Offset: 0x3245A88 VA: 0x3249A88
	public void .ctor(byte value) { }

	// RVA: 0x3249A98 Offset: 0x3245A98 VA: 0x3249A98 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x3249AA8 Offset: 0x3245AA8 VA: 0x3249AA8
	public byte get_Value() { }

	// RVA: 0x3249AF4 Offset: 0x3245AF4 VA: 0x3249AF4
	public static SqlByte op_Implicit(byte x) { }

	// RVA: 0x3249B04 Offset: 0x3245B04 VA: 0x3249B04 Slot: 3
	public override string ToString() { }

	// RVA: 0x3249BA0 Offset: 0x3245BA0 VA: 0x3249BA0
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0x3249CCC Offset: 0x3245CCC VA: 0x3249CCC
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0x3249DF8 Offset: 0x3245DF8 VA: 0x3249DF8
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0x3249F28 Offset: 0x3245F28 VA: 0x3249F28
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0x324A02C Offset: 0x324602C VA: 0x324A02C
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0x324A1DC Offset: 0x32461DC VA: 0x324A1DC
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0x324A2A4 Offset: 0x32462A4 VA: 0x324A2A4
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x324A36C Offset: 0x324636C VA: 0x324A36C
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x324A434 Offset: 0x3246434 VA: 0x324A434
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x324A4A0 Offset: 0x32464A0 VA: 0x324A4A0
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x324A50C Offset: 0x324650C VA: 0x324A50C
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x324A630 Offset: 0x3246630 VA: 0x324A630
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x324A750 Offset: 0x3246750 VA: 0x324A750 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x324A854 Offset: 0x3246854 VA: 0x324A854
	public int CompareTo(SqlByte value) { }

	// RVA: 0x324A99C Offset: 0x324699C VA: 0x324A99C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x324AAD4 Offset: 0x3246AD4 VA: 0x324AAD4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x324AB64 Offset: 0x3246B64 VA: 0x324AB64 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x324AB6C Offset: 0x3246B6C VA: 0x324AB6C Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x324AC8C Offset: 0x3246C8C VA: 0x324AC8C Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x324ADBC Offset: 0x3246DBC VA: 0x324ADBC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x324AE48 Offset: 0x3246E48 VA: 0x324AE48
	private static void .cctor() { }
}

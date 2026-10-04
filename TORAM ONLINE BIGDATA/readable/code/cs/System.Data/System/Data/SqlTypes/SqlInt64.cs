// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt64 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 14812
{
	// Fields
	private bool m_fNotNull; // 0x0
	private long m_value; // 0x8
	private static readonly long s_lLowIntMask; // 0x0
	private static readonly long s_lHighIntMask; // 0x8
	public static readonly SqlInt64 Null; // 0x10
	public static readonly SqlInt64 Zero; // 0x20
	public static readonly SqlInt64 MinValue; // 0x30
	public static readonly SqlInt64 MaxValue; // 0x40

	// Properties
	public bool IsNull { get; }
	public long Value { get; }

	// Methods

	// RVA: 0x3258FF4 Offset: 0x3254FF4 VA: 0x3258FF4
	private void .ctor(bool fNull) { }

	// RVA: 0x3259000 Offset: 0x3255000 VA: 0x3259000
	public void .ctor(long value) { }

	// RVA: 0x324A180 Offset: 0x3246180 VA: 0x324A180 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x324A190 Offset: 0x3246190 VA: 0x324A190
	public long get_Value() { }

	// RVA: 0x3259010 Offset: 0x3255010 VA: 0x3259010
	public static SqlInt64 op_Implicit(long x) { }

	// RVA: 0x325901C Offset: 0x325501C VA: 0x325901C Slot: 3
	public override string ToString() { }

	// RVA: 0x32590B8 Offset: 0x32550B8 VA: 0x32590B8
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0x3259154 Offset: 0x3255154 VA: 0x3259154
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x325929C Offset: 0x325529C VA: 0x325929C
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x32593D4 Offset: 0x32553D4 VA: 0x32593D4
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x3259558 Offset: 0x3255558 VA: 0x3259558
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x32596A0 Offset: 0x32556A0 VA: 0x32596A0
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x324A688 Offset: 0x3246688 VA: 0x324A688
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0x3257268 Offset: 0x3253268 VA: 0x3257268
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0x32587BC Offset: 0x32547BC VA: 0x32587BC
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0x32532AC Offset: 0x324F2AC VA: 0x32532AC
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0x325928C Offset: 0x325528C VA: 0x325928C
	private static bool SameSignLong(long x, long y) { }

	// RVA: 0x32597EC Offset: 0x32557EC VA: 0x32597EC
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x32598BC Offset: 0x32558BC VA: 0x32598BC
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x325998C Offset: 0x325598C VA: 0x325998C
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x3259A5C Offset: 0x3255A5C VA: 0x3259A5C
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x3259AE0 Offset: 0x3255AE0 VA: 0x3259AE0
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x3259B64 Offset: 0x3255B64 VA: 0x3259B64
	public SqlByte ToSqlByte() { }

	// RVA: 0x3259BC8 Offset: 0x3255BC8 VA: 0x3259BC8
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x3259C24 Offset: 0x3255C24 VA: 0x3259C24
	public SqlInt16 ToSqlInt16() { }

	// RVA: 0x3259C88 Offset: 0x3255C88 VA: 0x3259C88
	public SqlInt32 ToSqlInt32() { }

	// RVA: 0x3259CE4 Offset: 0x3255CE4 VA: 0x3259CE4
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x3259D6C Offset: 0x3255D6C VA: 0x3259D6C Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x3259E74 Offset: 0x3255E74 VA: 0x3259E74
	public int CompareTo(SqlInt64 value) { }

	// RVA: 0x3259FD4 Offset: 0x3255FD4 VA: 0x3259FD4 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x325A114 Offset: 0x3256114 VA: 0x325A114 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x325A1A4 Offset: 0x32561A4 VA: 0x325A1A4 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x325A1AC Offset: 0x32561AC VA: 0x325A1AC Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x325A2CC Offset: 0x32562CC VA: 0x325A2CC Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x325A3FC Offset: 0x32563FC VA: 0x325A3FC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x325A488 Offset: 0x3256488 VA: 0x325A488
	private static void .cctor() { }
}

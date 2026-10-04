// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlMoney : INullable, IComparable, IXmlSerializable // TypeDefIndex: 14813
{
	// Fields
	private bool _fNotNull; // 0x0
	private long _value; // 0x8
	internal static readonly int s_iMoneyScale; // 0x0
	private static readonly long s_lTickBase; // 0x8
	private static readonly double s_dTickBase; // 0x10
	private static readonly long s_minLong; // 0x18
	private static readonly long s_maxLong; // 0x20
	public static readonly SqlMoney Null; // 0x28
	public static readonly SqlMoney Zero; // 0x38
	public static readonly SqlMoney MinValue; // 0x48
	public static readonly SqlMoney MaxValue; // 0x58

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }

	// Methods

	// RVA: 0x325A520 Offset: 0x3256520 VA: 0x325A520
	private void .ctor(bool fNull) { }

	// RVA: 0x325A52C Offset: 0x325652C VA: 0x325A52C
	internal void .ctor(long value, int ignored) { }

	// RVA: 0x325A53C Offset: 0x325653C VA: 0x325A53C
	public void .ctor(int value) { }

	// RVA: 0x325A5B8 Offset: 0x32565B8 VA: 0x325A5B8
	public void .ctor(long value) { }

	// RVA: 0x325A6B0 Offset: 0x32566B0 VA: 0x325A6B0
	public void .ctor(Decimal value) { }

	// RVA: 0x3252470 Offset: 0x324E470 VA: 0x3252470 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x325A808 Offset: 0x3256808 VA: 0x325A808
	public Decimal get_Value() { }

	// RVA: 0x3252480 Offset: 0x324E480 VA: 0x3252480
	public Decimal ToDecimal() { }

	// RVA: 0x3254CE8 Offset: 0x3250CE8 VA: 0x3254CE8
	public double ToDouble() { }

	// RVA: 0x325A898 Offset: 0x3256898 VA: 0x325A898
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0x325A8C4 Offset: 0x32568C4 VA: 0x325A8C4
	public static SqlMoney op_Implicit(long x) { }

	// RVA: 0x325A920 Offset: 0x3256920 VA: 0x325A920 Slot: 3
	public override string ToString() { }

	// RVA: 0x325AA44 Offset: 0x3256A44 VA: 0x325AA44
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0x325AB3C Offset: 0x3256B3C VA: 0x325AB3C
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0x325ACE8 Offset: 0x3256CE8 VA: 0x325ACE8
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0x325AE90 Offset: 0x3256E90 VA: 0x325AE90
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0x325AFCC Offset: 0x3256FCC VA: 0x325AFCC
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0x325B108 Offset: 0x3257108 VA: 0x325B108
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0x325B1D0 Offset: 0x32571D0 VA: 0x325B1D0
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0x325B298 Offset: 0x3257298 VA: 0x325B298
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0x325B360 Offset: 0x3257360 VA: 0x325B360
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0x32534F0 Offset: 0x324F4F0 VA: 0x32534F0
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0x325B428 Offset: 0x3257428 VA: 0x325B428
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0x325B4F8 Offset: 0x32574F8 VA: 0x325B4F8
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x325B5C8 Offset: 0x32575C8 VA: 0x325B5C8
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x325B698 Offset: 0x3257698 VA: 0x325B698
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x325B71C Offset: 0x325771C VA: 0x325B71C
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x325B7A0 Offset: 0x32577A0 VA: 0x325B7A0
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x325B7FC Offset: 0x32577FC VA: 0x325B7FC
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x325B884 Offset: 0x3257884 VA: 0x325B884 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x325B98C Offset: 0x325798C VA: 0x325B98C
	public int CompareTo(SqlMoney value) { }

	// RVA: 0x325BAEC Offset: 0x3257AEC VA: 0x325BAEC Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x325BC2C Offset: 0x3257C2C VA: 0x325BC2C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x325BC9C Offset: 0x3257C9C VA: 0x325BC9C Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x325BCA4 Offset: 0x3257CA4 VA: 0x325BCA4 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x325BE14 Offset: 0x3257E14 VA: 0x325BE14 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x325BF64 Offset: 0x3257F64 VA: 0x325BF64
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x325BFF0 Offset: 0x3257FF0 VA: 0x325BFF0
	private static void .cctor() { }
}

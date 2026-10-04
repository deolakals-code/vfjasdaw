// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt16 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 14810
{
	// Fields
	private bool m_fNotNull; // 0x0
	private short m_value; // 0x2
	private static readonly int s_MASKI2; // 0x0
	public static readonly SqlInt16 Null; // 0x4
	public static readonly SqlInt16 Zero; // 0x8
	public static readonly SqlInt16 MinValue; // 0xC
	public static readonly SqlInt16 MaxValue; // 0x10

	// Properties
	public bool IsNull { get; }
	public short Value { get; }

	// Methods

	// RVA: 0x3256694 Offset: 0x3252694 VA: 0x3256694
	private void .ctor(bool fNull) { }

	// RVA: 0x32566A0 Offset: 0x32526A0 VA: 0x32566A0
	public void .ctor(short value) { }

	// RVA: 0x32520BC Offset: 0x324E0BC VA: 0x32520BC Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x32520CC Offset: 0x324E0CC VA: 0x32520CC
	public short get_Value() { }

	// RVA: 0x32566B0 Offset: 0x32526B0 VA: 0x32566B0
	public static SqlInt16 op_Implicit(short x) { }

	// RVA: 0x32566C0 Offset: 0x32526C0 VA: 0x32566C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x325675C Offset: 0x325275C VA: 0x325675C
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0x32567F8 Offset: 0x32527F8 VA: 0x32567F8
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x3256904 Offset: 0x3252904 VA: 0x3256904
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x3256A10 Offset: 0x3252A10 VA: 0x3256A10
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x3256B58 Offset: 0x3252B58 VA: 0x3256B58
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x3256CB0 Offset: 0x3252CB0 VA: 0x3256CB0
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0x3256D80 Offset: 0x3252D80 VA: 0x3256D80
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0x3256E94 Offset: 0x3252E94 VA: 0x3256E94
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x3256F58 Offset: 0x3252F58 VA: 0x3256F58
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x325701C Offset: 0x325301C VA: 0x325701C
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x32570E0 Offset: 0x32530E0 VA: 0x32570E0
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x325714C Offset: 0x325314C VA: 0x325714C
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x32571B8 Offset: 0x32531B8 VA: 0x32571B8
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x3257210 Offset: 0x3253210 VA: 0x3257210
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x3257330 Offset: 0x3253330 VA: 0x3257330 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x3257434 Offset: 0x3253434 VA: 0x3257434
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0x325757C Offset: 0x325357C VA: 0x325757C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x32576B4 Offset: 0x32536B4 VA: 0x32576B4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3257744 Offset: 0x3253744 VA: 0x3257744 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x325774C Offset: 0x325374C VA: 0x325774C Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x325786C Offset: 0x325386C VA: 0x325786C Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x325799C Offset: 0x325399C VA: 0x325799C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x3257A28 Offset: 0x3253A28 VA: 0x3257A28
	private static void .cctor() { }
}

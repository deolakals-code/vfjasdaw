// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt32 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 14811
{
	// Fields
	private bool m_fNotNull; // 0x0
	private int m_value; // 0x4
	private static readonly long s_iIntMin; // 0x0
	private static readonly long s_lBitNotIntMax; // 0x8
	public static readonly SqlInt32 Null; // 0x10
	public static readonly SqlInt32 Zero; // 0x18
	public static readonly SqlInt32 MinValue; // 0x20
	public static readonly SqlInt32 MaxValue; // 0x28

	// Properties
	public bool IsNull { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x3257AA4 Offset: 0x3253AA4 VA: 0x3257AA4
	private void .ctor(bool fNull) { }

	// RVA: 0x3257AB0 Offset: 0x3253AB0 VA: 0x3257AB0
	public void .ctor(int value) { }

	// RVA: 0x32521F4 Offset: 0x324E1F4 VA: 0x32521F4 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x3252204 Offset: 0x324E204 VA: 0x3252204
	public int get_Value() { }

	// RVA: 0x3257AC0 Offset: 0x3253AC0 VA: 0x3257AC0
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0x3257AD0 Offset: 0x3253AD0 VA: 0x3257AD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3257B6C Offset: 0x3253B6C VA: 0x3257B6C
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0x3257C08 Offset: 0x3253C08 VA: 0x3257C08
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x3257D48 Offset: 0x3253D48 VA: 0x3257D48
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x3257E7C Offset: 0x3253E7C VA: 0x3257E7C
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x3257FC4 Offset: 0x3253FC4 VA: 0x3257FC4
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x3258128 Offset: 0x3254128 VA: 0x3258128
	public static SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0x32581F8 Offset: 0x32541F8 VA: 0x32581F8
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0x32582C8 Offset: 0x32542C8 VA: 0x32582C8
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0x3257D3C Offset: 0x3253D3C VA: 0x3257D3C
	private static bool SameSignInt(int x, int y) { }

	// RVA: 0x32583DC Offset: 0x32543DC VA: 0x32583DC
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x32584A4 Offset: 0x32544A4 VA: 0x32584A4
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x325856C Offset: 0x325456C VA: 0x325856C
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x3258634 Offset: 0x3254634 VA: 0x3258634
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x32586A0 Offset: 0x32546A0 VA: 0x32586A0
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x325870C Offset: 0x325470C VA: 0x325870C
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x3258764 Offset: 0x3254764 VA: 0x3258764
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x3258884 Offset: 0x3254884 VA: 0x3258884 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x3258988 Offset: 0x3254988 VA: 0x3258988
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0x3258ACC Offset: 0x3254ACC VA: 0x3258ACC Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3258C04 Offset: 0x3254C04 VA: 0x3258C04 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3258C94 Offset: 0x3254C94 VA: 0x3258C94 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x3258C9C Offset: 0x3254C9C VA: 0x3258C9C Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x3258DBC Offset: 0x3254DBC VA: 0x3258DBC Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x3258EEC Offset: 0x3254EEC VA: 0x3258EEC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x3258F78 Offset: 0x3254F78 VA: 0x3258F78
	private static void .cctor() { }
}

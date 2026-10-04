// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlSingle : INullable, IComparable, IXmlSerializable // TypeDefIndex: 14814
{
	// Fields
	private bool _fNotNull; // 0x0
	private float _value; // 0x4
	public static readonly SqlSingle Null; // 0x0
	public static readonly SqlSingle Zero; // 0x8
	public static readonly SqlSingle MinValue; // 0x10
	public static readonly SqlSingle MaxValue; // 0x18

	// Properties
	public bool IsNull { get; }
	public float Value { get; }

	// Methods

	// RVA: 0x325C0B8 Offset: 0x32580B8 VA: 0x325C0B8
	private void .ctor(bool fNull) { }

	// RVA: 0x325C0C4 Offset: 0x32580C4 VA: 0x325C0C4
	public void .ctor(float value) { }

	// RVA: 0x325C138 Offset: 0x3258138 VA: 0x325C138
	public void .ctor(double value) { }

	// RVA: 0x325C19C Offset: 0x325819C VA: 0x325C19C Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x325C1AC Offset: 0x32581AC VA: 0x325C1AC
	public float get_Value() { }

	// RVA: 0x325C22C Offset: 0x325822C VA: 0x325C22C
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0x325C248 Offset: 0x3258248 VA: 0x325C248 Slot: 3
	public override string ToString() { }

	// RVA: 0x325C2BC Offset: 0x32582BC VA: 0x325C2BC
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0x325C35C Offset: 0x325835C VA: 0x325C35C
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0x325C478 Offset: 0x3258478 VA: 0x325C478
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0x325C594 Offset: 0x3258594 VA: 0x325C594
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0x325C6B0 Offset: 0x32586B0 VA: 0x325C6B0
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0x325C804 Offset: 0x3258804 VA: 0x325C804
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0x325C8D8 Offset: 0x32588D8 VA: 0x325C8D8
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0x325C9AC Offset: 0x32589AC VA: 0x325C9AC
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0x325CA78 Offset: 0x3258A78 VA: 0x325CA78
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0x325CB48 Offset: 0x3258B48 VA: 0x325CB48
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0x325CC14 Offset: 0x3258C14 VA: 0x325CC14
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0x325CCE0 Offset: 0x3258CE0 VA: 0x325CCE0
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0x325CDAC Offset: 0x3258DAC VA: 0x325CDAC
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0x325CE90 Offset: 0x3258E90 VA: 0x325CE90
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x325CF74 Offset: 0x3258F74 VA: 0x325CF74
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x325D058 Offset: 0x3259058 VA: 0x325D058
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x325D0C4 Offset: 0x32590C4 VA: 0x325D0C4
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x325D130 Offset: 0x3259130 VA: 0x325D130
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x325D18C Offset: 0x325918C VA: 0x325D18C Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x325D28C Offset: 0x325928C VA: 0x325D28C
	public int CompareTo(SqlSingle value) { }

	// RVA: 0x325D49C Offset: 0x325949C VA: 0x325D49C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x325D5D8 Offset: 0x32595D8 VA: 0x325D5D8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x325D668 Offset: 0x3259668 VA: 0x325D668 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x325D670 Offset: 0x3259670 VA: 0x325D670 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x325D790 Offset: 0x3259790 VA: 0x325D790 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x325D8CC Offset: 0x32598CC VA: 0x325D8CC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x325D958 Offset: 0x3259958 VA: 0x325D958
	private static void .cctor() { }
}

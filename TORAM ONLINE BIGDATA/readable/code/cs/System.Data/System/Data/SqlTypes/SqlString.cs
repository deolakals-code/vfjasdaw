// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlString : INullable, IComparable, IXmlSerializable // TypeDefIndex: 14816
{
	// Fields
	private string m_value; // 0x0
	private CompareInfo m_cmpInfo; // 0x8
	private int m_lcid; // 0x10
	private SqlCompareOptions m_flag; // 0x14
	private bool m_fNotNull; // 0x18
	public static readonly SqlString Null; // 0x0
	internal static readonly UnicodeEncoding s_unicodeEncoding; // 0x20
	public static readonly int IgnoreCase; // 0x28
	public static readonly int IgnoreWidth; // 0x2C
	public static readonly int IgnoreNonSpace; // 0x30
	public static readonly int IgnoreKanaType; // 0x34
	public static readonly int BinarySort; // 0x38
	public static readonly int BinarySort2; // 0x3C
	private static readonly SqlCompareOptions s_iDefaultFlag; // 0x40
	private static readonly CompareOptions s_iValidCompareOptionMask; // 0x44
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; // 0x48
	internal static readonly int s_lcidUSEnglish; // 0x4C
	private static readonly int s_lcidBinary; // 0x50

	// Properties
	public bool IsNull { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x325D9E8 Offset: 0x32599E8 VA: 0x325D9E8
	private void .ctor(bool fNull) { }

	// RVA: 0x325DA1C Offset: 0x3259A1C VA: 0x325DA1C
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0x325DB80 Offset: 0x3259B80 VA: 0x325DB80
	public void .ctor(string data) { }

	// RVA: 0x325DC3C Offset: 0x3259C3C VA: 0x325DC3C
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0x325DD1C Offset: 0x3259D1C VA: 0x325DD1C Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x325DD2C Offset: 0x3259D2C VA: 0x325DD2C
	public string get_Value() { }

	// RVA: 0x325DDB8 Offset: 0x3259DB8 VA: 0x325DDB8
	private void SetCompareInfo() { }

	// RVA: 0x325DE50 Offset: 0x3259E50 VA: 0x325DE50
	public static SqlString op_Implicit(string x) { }

	// RVA: 0x325DE64 Offset: 0x3259E64 VA: 0x325DE64 Slot: 3
	public override string ToString() { }

	// RVA: 0x325DED0 Offset: 0x3259ED0 VA: 0x325DED0
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0x325E040 Offset: 0x325A040 VA: 0x325E040
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0x325E658 Offset: 0x325A658 VA: 0x325E658
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0x325E7C4 Offset: 0x325A7C4 VA: 0x325E7C4
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0x325DAD4 Offset: 0x3259AD4 VA: 0x325DAD4
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x325E5B4 Offset: 0x325A5B4 VA: 0x325E5B4
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x325E8EC Offset: 0x325A8EC VA: 0x325E8EC
	private bool FBinarySort() { }

	// RVA: 0x325E274 Offset: 0x325A274 VA: 0x325E274
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0x325E43C Offset: 0x325A43C VA: 0x325E43C
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0x325E958 Offset: 0x325A958 VA: 0x325E958 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x325EA6C Offset: 0x325AA6C VA: 0x325EA6C
	public int CompareTo(SqlString value) { }

	// RVA: 0x325EB6C Offset: 0x325AB6C VA: 0x325EB6C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x325ED28 Offset: 0x325AD28 VA: 0x325ED28 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x325EF48 Offset: 0x325AF48 VA: 0x325EF48 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x325EF50 Offset: 0x325AF50 VA: 0x325EF50 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x325F050 Offset: 0x325B050 VA: 0x325F050 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x325F14C Offset: 0x325B14C VA: 0x325F14C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x325F1D8 Offset: 0x325B1D8 VA: 0x325F1D8
	private static void .cctor() { }
}

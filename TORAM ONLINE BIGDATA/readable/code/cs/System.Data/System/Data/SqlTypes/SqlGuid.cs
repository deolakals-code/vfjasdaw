// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlGuid : INullable, IComparable, IXmlSerializable // TypeDefIndex: 14809
{
	// Fields
	private static readonly int s_sizeOfGuid; // 0x0
	private static readonly int[] s_rgiGuidOrder; // 0x8
	private byte[] m_value; // 0x0
	public static readonly SqlGuid Null; // 0x10

	// Properties
	public bool IsNull { get; }
	public Guid Value { get; }

	// Methods

	// RVA: 0x3255924 Offset: 0x3251924 VA: 0x3255924
	private void .ctor(bool fNull) { }

	// RVA: 0x3255930 Offset: 0x3251930 VA: 0x3255930
	public void .ctor(Guid g) { }

	// RVA: 0x3255968 Offset: 0x3251968 VA: 0x3255968 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x3255978 Offset: 0x3251978 VA: 0x3255978
	public Guid get_Value() { }

	// RVA: 0x3255A20 Offset: 0x3251A20 VA: 0x3255A20
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0x3255A54 Offset: 0x3251A54 VA: 0x3255A54 Slot: 3
	public override string ToString() { }

	// RVA: 0x3255B00 Offset: 0x3251B00 VA: 0x3255B00
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0x3255BF8 Offset: 0x3251BF8 VA: 0x3255BF8
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0x3255CD8 Offset: 0x3251CD8 VA: 0x3255CD8
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x3255DB8 Offset: 0x3251DB8 VA: 0x3255DB8
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x3255E98 Offset: 0x3251E98 VA: 0x3255E98 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x3255F9C Offset: 0x3251F9C VA: 0x3255F9C
	public int CompareTo(SqlGuid value) { }

	// RVA: 0x32560E0 Offset: 0x32520E0 VA: 0x32560E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3256214 Offset: 0x3252214 VA: 0x3256214 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x32562A4 Offset: 0x32522A4 VA: 0x32562A4 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x32562AC Offset: 0x32522AC VA: 0x32562AC Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x32563E0 Offset: 0x32523E0 VA: 0x32563E0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x325652C Offset: 0x325252C VA: 0x325652C
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x32565B8 Offset: 0x32525B8 VA: 0x32565B8
	private static void .cctor() { }
}

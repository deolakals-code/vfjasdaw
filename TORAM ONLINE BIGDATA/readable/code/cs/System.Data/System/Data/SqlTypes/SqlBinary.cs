// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[DefaultMember("Item")]
[Serializable]
public struct SqlBinary : INullable, IComparable, IXmlSerializable // TypeDefIndex: 14800
{
	// Fields
	private byte[] _value; // 0x0
	public static readonly SqlBinary Null; // 0x0

	// Properties
	public bool IsNull { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x3247DFC Offset: 0x3243DFC VA: 0x3247DFC
	private void .ctor(bool fNull) { }

	// RVA: 0x3247E08 Offset: 0x3243E08 VA: 0x3247E08
	public void .ctor(byte[] value) { }

	// RVA: 0x3247E94 Offset: 0x3243E94 VA: 0x3247E94 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x3247EA4 Offset: 0x3243EA4 VA: 0x3247EA4
	public byte[] get_Value() { }

	// RVA: 0x3247F78 Offset: 0x3243F78 VA: 0x3247F78
	public static SqlBinary op_Implicit(byte[] x) { }

	// RVA: 0x3247F98 Offset: 0x3243F98 VA: 0x3247F98 Slot: 3
	public override string ToString() { }

	// RVA: 0x32480AC Offset: 0x32440AC VA: 0x32480AC
	private static EComparison PerformCompareByte(byte[] x, byte[] y) { }

	// RVA: 0x32481A8 Offset: 0x32441A8 VA: 0x32481A8
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0x32482BC Offset: 0x32442BC VA: 0x32482BC
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x32483BC Offset: 0x32443BC VA: 0x32483BC
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x32484BC Offset: 0x32444BC VA: 0x32484BC Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x32485C0 Offset: 0x32445C0 VA: 0x32485C0
	public int CompareTo(SqlBinary value) { }

	// RVA: 0x3248760 Offset: 0x3244760 VA: 0x3248760 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x32488EC Offset: 0x32448EC VA: 0x32488EC
	internal static int HashByteArray(byte[] rgbValue, int length) { }

	// RVA: 0x3248954 Offset: 0x3244954 VA: 0x3248954 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3248A18 Offset: 0x3244A18 VA: 0x3248A18 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x3248A20 Offset: 0x3244A20 VA: 0x3248A20 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x3248BD4 Offset: 0x3244BD4 VA: 0x3248BD4 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x3248D00 Offset: 0x3244D00 VA: 0x3248D00
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x3248D8C Offset: 0x3244D8C VA: 0x3248D8C
	private static void .cctor() { }
}

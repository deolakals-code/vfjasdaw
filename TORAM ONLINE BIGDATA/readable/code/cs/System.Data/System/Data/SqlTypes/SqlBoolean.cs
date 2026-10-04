// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlBoolean : INullable, IComparable, IXmlSerializable // TypeDefIndex: 14801
{
	// Fields
	private byte m_value; // 0x0
	public static readonly SqlBoolean True; // 0x0
	public static readonly SqlBoolean False; // 0x1
	public static readonly SqlBoolean Null; // 0x2
	public static readonly SqlBoolean Zero; // 0x3
	public static readonly SqlBoolean One; // 0x4

	// Properties
	public bool IsNull { get; }
	public bool Value { get; }
	public bool IsTrue { get; }
	public bool IsFalse { get; }
	public byte ByteValue { get; }

	// Methods

	// RVA: 0x32482A8 Offset: 0x32442A8 VA: 0x32482A8
	public void .ctor(bool value) { }

	// RVA: 0x3248DF8 Offset: 0x3244DF8 VA: 0x3248DF8
	public void .ctor(int value) { }

	// RVA: 0x3248E64 Offset: 0x3244E64 VA: 0x3248E64
	private void .ctor(int value, bool fNull) { }

	// RVA: 0x3248E80 Offset: 0x3244E80 VA: 0x3248E80 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x3248894 Offset: 0x3244894 VA: 0x3248894
	public bool get_Value() { }

	// RVA: 0x3248E90 Offset: 0x3244E90 VA: 0x3248E90
	public bool get_IsTrue() { }

	// RVA: 0x3248EA0 Offset: 0x3244EA0 VA: 0x3248EA0
	public bool get_IsFalse() { }

	// RVA: 0x3248EB0 Offset: 0x3244EB0 VA: 0x3248EB0
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0x3248704 Offset: 0x3244704 VA: 0x3248704
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0x3248EC0 Offset: 0x3244EC0 VA: 0x3248EC0
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x3248F78 Offset: 0x3244F78 VA: 0x3248F78
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x3249030 Offset: 0x3245030 VA: 0x3249030
	public byte get_ByteValue() { }

	// RVA: 0x32490C4 Offset: 0x32450C4 VA: 0x32490C4 Slot: 3
	public override string ToString() { }

	// RVA: 0x32491A8 Offset: 0x32451A8 VA: 0x32491A8
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x3249258 Offset: 0x3245258 VA: 0x3249258
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x32492C4 Offset: 0x32452C4 VA: 0x32492C4
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x3249330 Offset: 0x3245330 VA: 0x3249330 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x3249434 Offset: 0x3245434 VA: 0x3249434
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0x3249538 Offset: 0x3245538 VA: 0x3249538 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3249644 Offset: 0x3245644 VA: 0x3249644 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3249700 Offset: 0x3245700 VA: 0x3249700 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x3249708 Offset: 0x3245708 VA: 0x3249708 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x324982C Offset: 0x324582C VA: 0x324982C Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x3249944 Offset: 0x3245944 VA: 0x3249944
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x32499D0 Offset: 0x32459D0 VA: 0x32499D0
	private static void .cctor() { }
}

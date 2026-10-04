// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[DefaultMember("Item")]
[Serializable]
public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 14804
{
	// Fields
	internal byte[] _rgbBuf; // 0x10
	private long _lCurLen; // 0x18
	internal Stream _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private byte[] _rgbWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public byte[] Buffer { get; }
	public long Length { get; }
	public byte[] Value { get; }
	public static SqlBytes Null { get; }

	// Methods

	// RVA: 0x324AEC0 Offset: 0x3246EC0 VA: 0x324AEC0
	public void .ctor() { }

	// RVA: 0x324AF20 Offset: 0x3246F20 VA: 0x324AF20
	public void .ctor(byte[] buffer) { }

	// RVA: 0x324AF98 Offset: 0x3246F98 VA: 0x324AF98
	public void .ctor(SqlBinary value) { }

	// RVA: 0x324B028 Offset: 0x3247028 VA: 0x324B028 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x324B038 Offset: 0x3247038 VA: 0x324B038
	public byte[] get_Buffer() { }

	// RVA: 0x324B1E4 Offset: 0x32471E4 VA: 0x324B1E4
	public long get_Length() { }

	// RVA: 0x324B254 Offset: 0x3247254 VA: 0x324B254
	public byte[] get_Value() { }

	// RVA: 0x324AEF4 Offset: 0x3246EF4 VA: 0x324AEF4
	public void SetNull() { }

	// RVA: 0x324B070 Offset: 0x3247070 VA: 0x324B070
	private void CopyStreamToBuffer() { }

	// RVA: 0x324B060 Offset: 0x3247060 VA: 0x324B060
	internal bool FStream() { }

	// RVA: 0x324B438 Offset: 0x3247438 VA: 0x324B438
	private void SetBuffer(byte[] buffer) { }

	// RVA: 0x324B498 Offset: 0x3247498 VA: 0x324B498 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x324B4A0 Offset: 0x32474A0 VA: 0x324B4A0 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x324B664 Offset: 0x3247664 VA: 0x324B664 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x324B798 Offset: 0x3247798 VA: 0x324B798
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x324B824 Offset: 0x3247824 VA: 0x324B824 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x324B85C Offset: 0x324785C VA: 0x324B85C
	public static SqlBytes get_Null() { }
}

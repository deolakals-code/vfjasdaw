// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public sealed class SqlChars : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 14805
{
	// Fields
	internal char[] _rgchBuf; // 0x10
	private long _lCurLen; // 0x18
	internal SqlStreamChars _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private char[] _rgchWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public char[] Buffer { get; }
	public long Length { get; }
	public char[] Value { get; }
	public static SqlChars Null { get; }

	// Methods

	// RVA: 0x324B8B0 Offset: 0x32478B0 VA: 0x324B8B0
	public void .ctor() { }

	// RVA: 0x324B910 Offset: 0x3247910 VA: 0x324B910
	public void .ctor(char[] buffer) { }

	// RVA: 0x324B988 Offset: 0x3247988 VA: 0x324B988
	public void .ctor(SqlString value) { }

	// RVA: 0x324BA2C Offset: 0x3247A2C VA: 0x324BA2C Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x324BA3C Offset: 0x3247A3C VA: 0x324BA3C
	public char[] get_Buffer() { }

	// RVA: 0x324BBE0 Offset: 0x3247BE0 VA: 0x324BBE0
	public long get_Length() { }

	// RVA: 0x324BC50 Offset: 0x3247C50 VA: 0x324BC50
	public char[] get_Value() { }

	// RVA: 0x324B8E4 Offset: 0x32478E4 VA: 0x324B8E4
	public void SetNull() { }

	// RVA: 0x324BA64 Offset: 0x3247A64 VA: 0x324BA64
	internal bool FStream() { }

	// RVA: 0x324BA74 Offset: 0x3247A74 VA: 0x324BA74
	private void CopyStreamToBuffer() { }

	// RVA: 0x324BE2C Offset: 0x3247E2C VA: 0x324BE2C
	private void SetBuffer(char[] buffer) { }

	// RVA: 0x324BE8C Offset: 0x3247E8C VA: 0x324BE8C Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x324BE94 Offset: 0x3247E94 VA: 0x324BE94 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x324BFB0 Offset: 0x3247FB0 VA: 0x324BFB0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x324C0B0 Offset: 0x32480B0 VA: 0x324C0B0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x324C13C Offset: 0x324813C VA: 0x324C13C Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x324C174 Offset: 0x3248174 VA: 0x324C174
	public static SqlChars get_Null() { }
}

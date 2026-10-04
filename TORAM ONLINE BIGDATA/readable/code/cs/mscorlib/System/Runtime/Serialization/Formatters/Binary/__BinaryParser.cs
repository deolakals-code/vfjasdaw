// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class __BinaryParser // TypeDefIndex: 10423
{
	// Fields
	internal ObjectReader objectReader; // 0x10
	internal Stream input; // 0x18
	internal long topId; // 0x20
	internal long headerId; // 0x28
	internal SizedArray objectMapIdTable; // 0x30
	internal SizedArray assemIdToAssemblyTable; // 0x38
	internal SerStack stack; // 0x40
	internal BinaryTypeEnum expectedType; // 0x48
	internal object expectedTypeInformation; // 0x50
	internal ParseRecord PRS; // 0x58
	private BinaryAssemblyInfo systemAssemblyInfo; // 0x60
	private BinaryReader dataReader; // 0x68
	private static Encoding encoding; // 0x0
	private SerStack opPool; // 0x70
	private BinaryObject binaryObject; // 0x78
	private BinaryObjectWithMap bowm; // 0x80
	private BinaryObjectWithMapTyped bowmt; // 0x88
	internal BinaryObjectString objectString; // 0x90
	internal BinaryCrossAppDomainString crossAppDomainString; // 0x98
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0xA0
	private byte[] byteBuffer; // 0xA8
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0xB0
	internal MemberReference memberReference; // 0xB8
	internal ObjectNull objectNull; // 0xC0
	internal static MessageEnd messageEnd; // 0x8

	// Properties
	internal BinaryAssemblyInfo SystemAssemblyInfo { get; }
	internal SizedArray ObjectMapIdTable { get; }
	internal SizedArray AssemIdToAssemblyTable { get; }
	internal ParseRecord prs { get; }

	// Methods

	// RVA: 0x2F0D34C Offset: 0x2F0934C VA: 0x2F0D34C
	internal void .ctor(Stream stream, ObjectReader objectReader) { }

	// RVA: 0x2F17958 Offset: 0x2F13958 VA: 0x2F17958
	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	// RVA: 0x2F17A04 Offset: 0x2F13A04 VA: 0x2F17A04
	internal SizedArray get_ObjectMapIdTable() { }

	// RVA: 0x2F17A74 Offset: 0x2F13A74 VA: 0x2F17A74
	internal SizedArray get_AssemIdToAssemblyTable() { }

	// RVA: 0x2F17AE8 Offset: 0x2F13AE8 VA: 0x2F17AE8
	internal ParseRecord get_prs() { }

	// RVA: 0x2F12690 Offset: 0x2F0E690 VA: 0x2F12690
	internal void Run() { }

	// RVA: 0x2F17B58 Offset: 0x2F13B58 VA: 0x2F17B58
	internal void ReadBegin() { }

	// RVA: 0x2F19878 Offset: 0x2F15878 VA: 0x2F19878
	internal void ReadEnd() { }

	// RVA: 0x2F19B90 Offset: 0x2F15B90 VA: 0x2F19B90
	internal bool ReadBoolean() { }

	// RVA: 0x2F06B3C Offset: 0x2F02B3C VA: 0x2F06B3C
	internal byte ReadByte() { }

	// RVA: 0x2F080CC Offset: 0x2F040CC VA: 0x2F080CC
	internal byte[] ReadBytes(int length) { }

	// RVA: 0x2F19BB0 Offset: 0x2F15BB0 VA: 0x2F19BB0
	internal void ReadBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x2F19C2C Offset: 0x2F15C2C VA: 0x2F19C2C
	internal char ReadChar() { }

	// RVA: 0x2F19C4C Offset: 0x2F15C4C VA: 0x2F19C4C
	internal char[] ReadChars(int length) { }

	// RVA: 0x2F19C70 Offset: 0x2F15C70 VA: 0x2F19C70
	internal Decimal ReadDecimal() { }

	// RVA: 0x2F19D24 Offset: 0x2F15D24 VA: 0x2F19D24
	internal float ReadSingle() { }

	// RVA: 0x2F19D48 Offset: 0x2F15D48 VA: 0x2F19D48
	internal double ReadDouble() { }

	// RVA: 0x2F19D6C Offset: 0x2F15D6C VA: 0x2F19D6C
	internal short ReadInt16() { }

	// RVA: 0x2F06B80 Offset: 0x2F02B80 VA: 0x2F06B80
	internal int ReadInt32() { }

	// RVA: 0x2F19D90 Offset: 0x2F15D90 VA: 0x2F19D90
	internal long ReadInt64() { }

	// RVA: 0x2F19DB4 Offset: 0x2F15DB4 VA: 0x2F19DB4
	internal sbyte ReadSByte() { }

	// RVA: 0x2F06B5C Offset: 0x2F02B5C VA: 0x2F06B5C
	internal string ReadString() { }

	// RVA: 0x2F19DD4 Offset: 0x2F15DD4 VA: 0x2F19DD4
	internal TimeSpan ReadTimeSpan() { }

	// RVA: 0x2F19DF8 Offset: 0x2F15DF8 VA: 0x2F19DF8
	internal DateTime ReadDateTime() { }

	// RVA: 0x2F19E74 Offset: 0x2F15E74 VA: 0x2F19E74
	internal ushort ReadUInt16() { }

	// RVA: 0x2F19E98 Offset: 0x2F15E98 VA: 0x2F19E98
	internal uint ReadUInt32() { }

	// RVA: 0x2F19EBC Offset: 0x2F15EBC VA: 0x2F19EBC
	internal ulong ReadUInt64() { }

	// RVA: 0x2F17B5C Offset: 0x2F13B5C VA: 0x2F17B5C
	internal void ReadSerializationHeaderRecord() { }

	// RVA: 0x2F17C14 Offset: 0x2F13C14 VA: 0x2F17C14
	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x2F17E98 Offset: 0x2F13E98 VA: 0x2F17E98
	private void ReadObject() { }

	// RVA: 0x2F18260 Offset: 0x2F14260 VA: 0x2F18260
	internal void ReadCrossAppDomainMap() { }

	// RVA: 0x2F18404 Offset: 0x2F14404 VA: 0x2F18404
	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x2F19F88 Offset: 0x2F15F88 VA: 0x2F19F88
	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	// RVA: 0x2F184AC Offset: 0x2F144AC VA: 0x2F184AC
	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x2F1A3F8 Offset: 0x2F163F8 VA: 0x2F1A3F8
	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	// RVA: 0x2F18550 Offset: 0x2F14550 VA: 0x2F18550
	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x2F19064 Offset: 0x2F15064 VA: 0x2F19064
	private void ReadMemberPrimitiveTyped() { }

	// RVA: 0x2F18AAC Offset: 0x2F14AAC VA: 0x2F18AAC
	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x2F1A890 Offset: 0x2F16890 VA: 0x2F1A890
	private void ReadArrayAsBytes(ParseRecord pr) { }

	// RVA: 0x2F1987C Offset: 0x2F1587C VA: 0x2F1987C
	private void ReadMemberPrimitiveUnTyped() { }

	// RVA: 0x2F193B8 Offset: 0x2F153B8 VA: 0x2F193B8
	private void ReadMemberReference() { }

	// RVA: 0x2F19564 Offset: 0x2F15564 VA: 0x2F19564
	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x2F19724 Offset: 0x2F15724 VA: 0x2F19724
	private void ReadMessageEnd() { }

	// RVA: 0x2F08900 Offset: 0x2F04900 VA: 0x2F08900
	internal object ReadValue(InternalPrimitiveTypeE code) { }

	// RVA: 0x2F19EE0 Offset: 0x2F15EE0 VA: 0x2F19EE0
	private ObjectProgress GetOp() { }

	// RVA: 0x2F19AF4 Offset: 0x2F15AF4 VA: 0x2F19AF4
	private void PutOp(ObjectProgress op) { }

	// RVA: 0x2F1AB20 Offset: 0x2F16B20 VA: 0x2F1AB20
	private static void .cctor() { }
}

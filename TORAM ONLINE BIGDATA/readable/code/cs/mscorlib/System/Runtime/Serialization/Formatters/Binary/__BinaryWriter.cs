// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class __BinaryWriter // TypeDefIndex: 10412
{
	// Fields
	internal Stream sout; // 0x10
	internal FormatterTypeStyle formatterTypeStyle; // 0x18
	internal Hashtable objectMapTable; // 0x20
	internal ObjectWriter objectWriter; // 0x28
	internal BinaryWriter dataWriter; // 0x30
	internal int m_nestedObjectCount; // 0x38
	private int nullCount; // 0x3C
	internal BinaryMethodCall binaryMethodCall; // 0x40
	internal BinaryMethodReturn binaryMethodReturn; // 0x48
	internal BinaryObject binaryObject; // 0x50
	internal BinaryObjectWithMap binaryObjectWithMap; // 0x58
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; // 0x60
	internal BinaryObjectString binaryObjectString; // 0x68
	internal BinaryArray binaryArray; // 0x70
	private byte[] byteBuffer; // 0x78
	private int chunkSize; // 0x80
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0x88
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0x90
	internal ObjectNull objectNull; // 0x98
	internal MemberReference memberReference; // 0xA0
	internal BinaryAssembly binaryAssembly; // 0xA8

	// Methods

	// RVA: 0x2F0DB4C Offset: 0x2F09B4C VA: 0x2F0DB4C
	internal void .ctor(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	// RVA: 0x2F0E378 Offset: 0x2F0A378 VA: 0x2F0E378
	internal void WriteBegin() { }

	// RVA: 0x2F0E37C Offset: 0x2F0A37C VA: 0x2F0E37C
	internal void WriteEnd() { }

	// RVA: 0x2F0E39C Offset: 0x2F0A39C VA: 0x2F0E39C
	internal void WriteBoolean(bool value) { }

	// RVA: 0x2F06900 Offset: 0x2F02900 VA: 0x2F06900
	internal void WriteByte(byte value) { }

	// RVA: 0x2F0E3C0 Offset: 0x2F0A3C0 VA: 0x2F0E3C0
	private void WriteBytes(byte[] value) { }

	// RVA: 0x2F0E3E0 Offset: 0x2F0A3E0 VA: 0x2F0E3E0
	private void WriteBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x2F0E400 Offset: 0x2F0A400 VA: 0x2F0E400
	internal void WriteChar(char value) { }

	// RVA: 0x2F0E420 Offset: 0x2F0A420 VA: 0x2F0E420
	internal void WriteChars(char[] value) { }

	// RVA: 0x2F0E440 Offset: 0x2F0A440 VA: 0x2F0E440
	internal void WriteDecimal(Decimal value) { }

	// RVA: 0x2F0E52C Offset: 0x2F0A52C VA: 0x2F0E52C
	internal void WriteSingle(float value) { }

	// RVA: 0x2F0E550 Offset: 0x2F0A550 VA: 0x2F0E550
	internal void WriteDouble(double value) { }

	// RVA: 0x2F0E574 Offset: 0x2F0A574 VA: 0x2F0E574
	internal void WriteInt16(short value) { }

	// RVA: 0x2F06944 Offset: 0x2F02944 VA: 0x2F06944
	internal void WriteInt32(int value) { }

	// RVA: 0x2F0E598 Offset: 0x2F0A598 VA: 0x2F0E598
	internal void WriteInt64(long value) { }

	// RVA: 0x2F0E5BC Offset: 0x2F0A5BC VA: 0x2F0E5BC
	internal void WriteSByte(sbyte value) { }

	// RVA: 0x2F06920 Offset: 0x2F02920 VA: 0x2F06920
	internal void WriteString(string value) { }

	// RVA: 0x2F0E5DC Offset: 0x2F0A5DC VA: 0x2F0E5DC
	internal void WriteTimeSpan(TimeSpan value) { }

	// RVA: 0x2F0E654 Offset: 0x2F0A654 VA: 0x2F0E654
	internal void WriteDateTime(DateTime value) { }

	// RVA: 0x2F0E6CC Offset: 0x2F0A6CC VA: 0x2F0E6CC
	internal void WriteUInt16(ushort value) { }

	// RVA: 0x2F0E6F0 Offset: 0x2F0A6F0 VA: 0x2F0E6F0
	internal void WriteUInt32(uint value) { }

	// RVA: 0x2F0E714 Offset: 0x2F0A714 VA: 0x2F0E714
	internal void WriteUInt64(ulong value) { }

	// RVA: 0x2F0E738 Offset: 0x2F0A738 VA: 0x2F0E738
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x2F0E73C Offset: 0x2F0A73C VA: 0x2F0E73C
	internal void WriteSerializationHeaderEnd() { }

	// RVA: 0x2F0E79C Offset: 0x2F0A79C VA: 0x2F0E79C
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	// RVA: 0x2F0E82C Offset: 0x2F0A82C VA: 0x2F0E82C
	internal void WriteMethodCall() { }

	// RVA: 0x2F0E8B8 Offset: 0x2F0A8B8 VA: 0x2F0E8B8
	internal void WriteMethodReturn() { }

	// RVA: 0x2F0E944 Offset: 0x2F0A944 VA: 0x2F0E944
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x2F0F0C8 Offset: 0x2F0B0C8 VA: 0x2F0F0C8
	internal void WriteObjectString(int objectId, string value) { }

	// RVA: 0x2F0F178 Offset: 0x2F0B178 VA: 0x2F0F178
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	// RVA: 0x2F0F43C Offset: 0x2F0B43C VA: 0x2F0F43C
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	// RVA: 0x2F0F594 Offset: 0x2F0B594 VA: 0x2F0F594
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	// RVA: 0x2F0F734 Offset: 0x2F0B734 VA: 0x2F0F734
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA) { }

	// RVA: 0x2F0F8A8 Offset: 0x2F0B8A8 VA: 0x2F0F8A8
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA) { }

	// RVA: 0x2F0F908 Offset: 0x2F0B908 VA: 0x2F0F908
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x2F0FA44 Offset: 0x2F0BA44 VA: 0x2F0FA44
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x2F0FAF4 Offset: 0x2F0BAF4 VA: 0x2F0FAF4
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	// RVA: 0x2F0FB94 Offset: 0x2F0BB94 VA: 0x2F0FB94
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	// RVA: 0x2F0FBB0 Offset: 0x2F0BBB0 VA: 0x2F0FBB0
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	// RVA: 0x2F0FBF8 Offset: 0x2F0BBF8 VA: 0x2F0FBF8
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x2F0FC38 Offset: 0x2F0BC38 VA: 0x2F0FC38
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x2F0FC48 Offset: 0x2F0BC48 VA: 0x2F0FC48
	internal void WriteDelayedNullItem() { }

	// RVA: 0x2F0FC58 Offset: 0x2F0BC58 VA: 0x2F0FC58
	internal void WriteItemEnd() { }

	// RVA: 0x2F0EE98 Offset: 0x2F0AE98 VA: 0x2F0EE98
	private void InternalWriteItemNull() { }

	// RVA: 0x2F0FC5C Offset: 0x2F0BC5C VA: 0x2F0FC5C
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	// RVA: 0x2F0FC8C Offset: 0x2F0BC8C VA: 0x2F0FC8C
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	// RVA: 0x2F074EC Offset: 0x2F034EC VA: 0x2F074EC
	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }
}

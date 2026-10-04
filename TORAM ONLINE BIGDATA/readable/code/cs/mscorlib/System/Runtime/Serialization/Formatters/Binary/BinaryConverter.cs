// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal static class BinaryConverter // TypeDefIndex: 10388
{
	// Methods

	// RVA: 0x2F05CAC Offset: 0x2F01CAC VA: 0x2F05CAC
	internal static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId) { }

	// RVA: 0x2F063C0 Offset: 0x2F023C0 VA: 0x2F063C0
	internal static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out object typeInformation) { }

	// RVA: 0x2F066DC Offset: 0x2F026DC VA: 0x2F066DC
	internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout) { }

	// RVA: 0x2F06968 Offset: 0x2F02968 VA: 0x2F06968
	internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId) { }

	// RVA: 0x2F06BA4 Offset: 0x2F02BA4 VA: 0x2F06BA4
	internal static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant) { }
}

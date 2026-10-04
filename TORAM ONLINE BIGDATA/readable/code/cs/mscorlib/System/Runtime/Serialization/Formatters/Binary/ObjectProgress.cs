// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectProgress // TypeDefIndex: 10409
{
	// Fields
	internal static int opRecordIdCount; // 0x0
	internal bool isInitial; // 0x10
	internal int count; // 0x14
	internal BinaryTypeEnum expectedType; // 0x18
	internal object expectedTypeInformation; // 0x20
	internal string name; // 0x28
	internal InternalObjectTypeE objectTypeEnum; // 0x30
	internal InternalMemberTypeE memberTypeEnum; // 0x34
	internal InternalMemberValueE memberValueEnum; // 0x38
	internal Type dtType; // 0x40
	internal int numItems; // 0x48
	internal BinaryTypeEnum binaryTypeEnum; // 0x4C
	internal object typeInformation; // 0x50
	internal int nullCount; // 0x58
	internal int memberLength; // 0x5C
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x60
	internal object[] typeInformationA; // 0x68
	internal string[] memberNames; // 0x70
	internal Type[] memberTypes; // 0x78
	internal ParseRecord pr; // 0x80

	// Methods

	// RVA: 0x2F0AE9C Offset: 0x2F06E9C VA: 0x2F0AE9C
	internal void .ctor() { }

	// RVA: 0x2F0AF10 Offset: 0x2F06F10 VA: 0x2F0AF10
	internal void Init() { }

	// RVA: 0x2F0AFD0 Offset: 0x2F06FD0 VA: 0x2F0AFD0
	internal void ArrayCountIncrement(int value) { }

	// RVA: 0x2F0AFE0 Offset: 0x2F06FE0 VA: 0x2F0AFE0
	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

	// RVA: 0x2F0B144 Offset: 0x2F07144 VA: 0x2F0B144
	private static void .cctor() { }
}

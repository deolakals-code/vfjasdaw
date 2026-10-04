// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectWithMapTyped // TypeDefIndex: 10402
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x30
	internal object[] typeInformationA; // 0x38
	internal int[] memberAssemIds; // 0x40
	internal int assemId; // 0x48

	// Methods

	// RVA: 0x2F09040 Offset: 0x2F05040 VA: 0x2F09040
	internal void .ctor() { }

	// RVA: 0x2F09048 Offset: 0x2F05048 VA: 0x2F09048
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x2F09070 Offset: 0x2F05070 VA: 0x2F09070
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	// RVA: 0x2F09120 Offset: 0x2F05120 VA: 0x2F09120 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x2F092F8 Offset: 0x2F052F8 VA: 0x2F092F8 Slot: 5
	public void Read(__BinaryParser input) { }
}

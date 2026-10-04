// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectMap // TypeDefIndex: 10408
{
	// Fields
	internal string objectName; // 0x10
	internal Type objectType; // 0x18
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x20
	internal object[] typeInformationA; // 0x28
	internal Type[] memberTypes; // 0x30
	internal string[] memberNames; // 0x38
	internal ReadObjectInfo objectInfo; // 0x40
	internal bool isInitObjectInfo; // 0x48
	internal ObjectReader objectReader; // 0x50
	internal int objectId; // 0x58
	internal BinaryAssemblyInfo assemblyInfo; // 0x60

	// Methods

	// RVA: 0x2F0A0DC Offset: 0x2F060DC VA: 0x2F0A0DC
	internal void .ctor(string objectName, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x2F0A860 Offset: 0x2F06860 VA: 0x2F0A860
	internal void .ctor(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	// RVA: 0x2F0AC14 Offset: 0x2F06C14 VA: 0x2F0AC14
	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x2F0AD48 Offset: 0x2F06D48 VA: 0x2F0AD48
	internal static ObjectMap Create(string name, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x2F0ADE0 Offset: 0x2F06DE0 VA: 0x2F0ADE0
	internal static ObjectMap Create(string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }
}

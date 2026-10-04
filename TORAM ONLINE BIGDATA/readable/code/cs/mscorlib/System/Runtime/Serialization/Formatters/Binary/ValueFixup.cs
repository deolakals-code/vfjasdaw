// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ValueFixup // TypeDefIndex: 10429
{
	// Fields
	internal ValueFixupEnum valueFixupEnum; // 0x10
	internal Array arrayObj; // 0x18
	internal int[] indexMap; // 0x20
	internal object header; // 0x28
	internal object memberObject; // 0x30
	internal static MemberInfo valueInfo; // 0x0
	internal ReadObjectInfo objectInfo; // 0x38
	internal string memberName; // 0x40

	// Methods

	// RVA: 0x2F1BD40 Offset: 0x2F17D40 VA: 0x2F1BD40
	internal void .ctor(Array arrayObj, int[] indexMap) { }

	// RVA: 0x2F1BD8C Offset: 0x2F17D8C VA: 0x2F1BD8C
	internal void .ctor(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	// RVA: 0x2F1BDF4 Offset: 0x2F17DF4 VA: 0x2F1BDF4
	internal void Fixup(ParseRecord record, ParseRecord parent) { }
}

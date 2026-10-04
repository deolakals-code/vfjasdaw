// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MemberPrimitiveUnTyped // TypeDefIndex: 10404
{
	// Fields
	internal InternalPrimitiveTypeE typeInformation; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x2F09E54 Offset: 0x2F05E54 VA: 0x2F09E54
	internal void .ctor() { }

	// RVA: 0x2F09E5C Offset: 0x2F05E5C VA: 0x2F09E5C
	internal void Set(InternalPrimitiveTypeE typeInformation, object value) { }

	// RVA: 0x2F09E6C Offset: 0x2F05E6C VA: 0x2F09E6C
	internal void Set(InternalPrimitiveTypeE typeInformation) { }

	// RVA: 0x2F09E74 Offset: 0x2F05E74 VA: 0x2F09E74 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x2F09E98 Offset: 0x2F05E98 VA: 0x2F09E98 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x2F09ECC Offset: 0x2F05ECC VA: 0x2F09ECC
	public void Dump() { }
}

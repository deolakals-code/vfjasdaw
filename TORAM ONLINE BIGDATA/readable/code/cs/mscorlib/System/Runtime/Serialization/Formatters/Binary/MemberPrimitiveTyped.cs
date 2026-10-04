// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MemberPrimitiveTyped // TypeDefIndex: 10400
{
	// Fields
	internal InternalPrimitiveTypeE primitiveTypeEnum; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x2F08834 Offset: 0x2F04834 VA: 0x2F08834
	internal void .ctor() { }

	// RVA: 0x2F0883C Offset: 0x2F0483C VA: 0x2F0883C
	internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value) { }

	// RVA: 0x2F0884C Offset: 0x2F0484C VA: 0x2F0884C Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x2F088AC Offset: 0x2F048AC VA: 0x2F088AC Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x2F08D24 Offset: 0x2F04D24 VA: 0x2F08D24
	public void Dump() { }
}

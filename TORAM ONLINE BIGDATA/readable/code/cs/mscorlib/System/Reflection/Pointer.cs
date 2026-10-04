// Assembly: mscorlib.dll
// Namespace: System.Reflection
[CLSCompliant(False)]
public sealed class Pointer : ISerializable // TypeDefIndex: 10612
{
	// Fields
	private readonly void* _ptr; // 0x10
	private readonly Type _ptrType; // 0x18

	// Methods

	// RVA: 0x2F2CE84 Offset: 0x2F28E84 VA: 0x2F2CE84
	private void .ctor(void* ptr, Type ptrType) { }

	// RVA: 0x2F2CEBC Offset: 0x2F28EBC VA: 0x2F2CEBC
	public static object Box(void* ptr, Type type) { }

	// RVA: 0x2F2D044 Offset: 0x2F29044 VA: 0x2F2D044 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
}

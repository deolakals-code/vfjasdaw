// Assembly: mscorlib.dll
// Namespace: System.Numerics
[Intrinsic]
public static class Vector // TypeDefIndex: 10682
{
	// Properties
	public static bool IsHardwareAccelerated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FBDDC Offset: 0x26F7DDC VA: 0x26FBDDC
	|-Vector.Equals<ushort>
	|
	|-RVA: 0x26FBE54 Offset: 0x26F7E54 VA: 0x26FBE54
	|-Vector.Equals<__Il2CppFullySharedGenericStructType>
	*/

	[Intrinsic]
	// RVA: 0x2F3F144 Offset: 0x2F3B144 VA: 0x2F3F144
	public static bool get_IsHardwareAccelerated() { }

	[CLSCompliant(False)]
	// RVA: -1 Offset: -1
	public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26FBD18 Offset: 0x26F7D18 VA: 0x26FBD18
	|-Vector.AsVectorUInt64<ushort>
	|
	|-RVA: 0x26FBD78 Offset: 0x26F7D78 VA: 0x26FBD78
	|-Vector.AsVectorUInt64<__Il2CppFullySharedGenericStructType>
	*/
}

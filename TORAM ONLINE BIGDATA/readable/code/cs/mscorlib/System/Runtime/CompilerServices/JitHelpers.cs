// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
internal static class JitHelpers // TypeDefIndex: 10542
{
	// Methods

	// RVA: -1 Offset: -1
	internal static T UnsafeCast<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C62D4 Offset: 0x26C22D4 VA: 0x26C62D4
	|-JitHelpers.UnsafeCast<object>
	*/

	// RVA: -1 Offset: -1
	internal static int UnsafeEnumCast<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C630C Offset: 0x26C230C VA: 0x26C630C
	|-JitHelpers.UnsafeEnumCast<ByteEnum>
	|
	|-RVA: 0x26C6344 Offset: 0x26C2344 VA: 0x26C6344
	|-JitHelpers.UnsafeEnumCast<Int16Enum>
	|
	|-RVA: 0x26C637C Offset: 0x26C237C VA: 0x26C637C
	|-JitHelpers.UnsafeEnumCast<Int32Enum>
	|
	|-RVA: 0x26C63B4 Offset: 0x26C23B4 VA: 0x26C63B4
	|-JitHelpers.UnsafeEnumCast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static long UnsafeEnumCastLong<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C6464 Offset: 0x26C2464 VA: 0x26C6464
	|-JitHelpers.UnsafeEnumCastLong<Int64Enum>
	|
	|-RVA: 0x26C649C Offset: 0x26C249C VA: 0x26C649C
	|-JitHelpers.UnsafeEnumCastLong<__Il2CppFullySharedGenericStructType>
	*/
}

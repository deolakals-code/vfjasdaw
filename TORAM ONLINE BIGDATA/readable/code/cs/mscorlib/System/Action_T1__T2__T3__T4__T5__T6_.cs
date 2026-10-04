// Assembly: mscorlib.dll
// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5, T6> : MulticastDelegate // TypeDefIndex: 9526
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28303CC Offset: 0x282C3CC VA: 0x28303CC
	|-Action<int, bool, bool, bool, bool, object>..ctor
	|
	|-RVA: 0x2830490 Offset: 0x282C490 VA: 0x2830490
	|-Action<object, IntPtr, IntPtr, int, int, object>..ctor
	|
	|-RVA: 0x28305B0 Offset: 0x282C5B0 VA: 0x28305B0
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x283046C Offset: 0x282C46C VA: 0x283046C
	|-Action<int, bool, bool, bool, bool, object>.Invoke
	|
	|-RVA: 0x283059C Offset: 0x282C59C VA: 0x283059C
	|-Action<object, IntPtr, IntPtr, int, int, object>.Invoke
	|
	|-RVA: 0x28306BC Offset: 0x282C6BC VA: 0x28306BC
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

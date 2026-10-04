// Assembly: mscorlib.dll
// Namespace: System
public sealed class Action<T1, T2, T3, T4, T5> : MulticastDelegate // TypeDefIndex: 9525
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x283013C Offset: 0x282C13C VA: 0x283013C
	|-Action<bool, int, int, int, int>..ctor
	|
	|-RVA: 0x28301F4 Offset: 0x282C1F4 VA: 0x28301F4
	|-Action<bool, object, int, int, object>..ctor
	|
	|-RVA: 0x28302AC Offset: 0x282C2AC VA: 0x28302AC
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28301DC Offset: 0x282C1DC VA: 0x28301DC
	|-Action<bool, int, int, int, int>.Invoke
	|
	|-RVA: 0x2830294 Offset: 0x282C294 VA: 0x2830294
	|-Action<bool, object, int, int, object>.Invoke
	|
	|-RVA: 0x28303B8 Offset: 0x282C3B8 VA: 0x28303B8
	|-Action<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Assembly: mscorlib.dll
// Namespace: System
public sealed class Func<T1, T2, T3, TResult> : MulticastDelegate // TypeDefIndex: 9532
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A09420 Offset: 0x2A05420 VA: 0x2A09420
	|-Func<object, object, bool, object>..ctor
	|
	|-RVA: 0x2A09544 Offset: 0x2A05544 VA: 0x2A09544
	|-Func<object, object, object, object>..ctor
	|
	|-RVA: 0x2A09664 Offset: 0x2A05664 VA: 0x2A09664
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A0952C Offset: 0x2A0552C VA: 0x2A0952C
	|-Func<object, object, bool, object>.Invoke
	|
	|-RVA: 0x2A09650 Offset: 0x2A05650 VA: 0x2A09650
	|-Func<object, object, object, object>.Invoke
	|
	|-RVA: 0x2A09770 Offset: 0x2A05770 VA: 0x2A09770
	|-Func<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

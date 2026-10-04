// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
internal sealed class MethodCall<T, TResult> : MulticastDelegate // TypeDefIndex: 15944
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA8050 Offset: 0x2BA4050 VA: 0x2BA8050
	|-MethodCall<object, object>..ctor
	|
	|-RVA: 0x2BA8170 Offset: 0x2BA4170 VA: 0x2BA8170
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 12
	public virtual TResult Invoke(T target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BA815C Offset: 0x2BA415C VA: 0x2BA815C
	|-MethodCall<object, object>.Invoke
	|
	|-RVA: 0x2BA827C Offset: 0x2BA427C VA: 0x2BA827C
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

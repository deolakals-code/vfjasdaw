// Assembly: mscorlib.dll
// Namespace: System
public sealed class Converter<TInput, TOutput> : MulticastDelegate // TypeDefIndex: 9539
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC8F88 Offset: 0x2DC4F88 VA: 0x2DC8F88
	|-Converter<Int32Enum, short>..ctor
	|
	|-RVA: 0x2DC903C Offset: 0x2DC503C VA: 0x2DC903C
	|-Converter<object, short>..ctor
	|
	|-RVA: 0x2DC9158 Offset: 0x2DC5158 VA: 0x2DC9158
	|-Converter<object, int>..ctor
	|
	|-RVA: 0x2DC9274 Offset: 0x2DC5274 VA: 0x2DC9274
	|-Converter<object, object>..ctor
	|
	|-RVA: 0x2DC9390 Offset: 0x2DC5390 VA: 0x2DC9390
	|-Converter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TOutput Invoke(TInput input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DC9028 Offset: 0x2DC5028 VA: 0x2DC9028
	|-Converter<Int32Enum, short>.Invoke
	|
	|-RVA: 0x2DC9144 Offset: 0x2DC5144 VA: 0x2DC9144
	|-Converter<object, short>.Invoke
	|
	|-RVA: 0x2DC9260 Offset: 0x2DC5260 VA: 0x2DC9260
	|-Converter<object, int>.Invoke
	|
	|-RVA: 0x2DC937C Offset: 0x2DC537C VA: 0x2DC937C
	|-Converter<object, object>.Invoke
	|
	|-RVA: 0x2DC9498 Offset: 0x2DC5498 VA: 0x2DC9498
	|-Converter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

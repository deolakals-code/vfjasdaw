// Assembly: mscorlib.dll
// Namespace: System.Buffers
public sealed class SpanAction<T, TArg> : MulticastDelegate // TypeDefIndex: 10986
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B764 Offset: 0x2C97764 VA: 0x2C9B764
	|-SpanAction<char, ValueTuple<object, int, int>>..ctor
	|
	|-RVA: 0x2C9B818 Offset: 0x2C97818 VA: 0x2C9B818
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, bool>>..ctor
	|
	|-RVA: 0x2C9B8EC Offset: 0x2C978EC VA: 0x2C9B8EC
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>..ctor
	|
	|-RVA: 0x2C9B9C8 Offset: 0x2C979C8 VA: 0x2C9B9C8
	|-SpanAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(Span<T> span, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9B804 Offset: 0x2C97804 VA: 0x2C9B804
	|-SpanAction<char, ValueTuple<object, int, int>>.Invoke
	|
	|-RVA: 0x2C9B8B8 Offset: 0x2C978B8 VA: 0x2C9B8B8
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, bool>>.Invoke
	|
	|-RVA: 0x2C9B98C Offset: 0x2C9798C VA: 0x2C9B98C
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>.Invoke
	|
	|-RVA: 0x2C9BA68 Offset: 0x2C97A68 VA: 0x2C9BA68
	|-SpanAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

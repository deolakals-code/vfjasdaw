// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[IsReadOnly]
internal struct StructMultiKey<T1, T2> : IEquatable<StructMultiKey<T1, T2>> // TypeDefIndex: 15964
{
	// Fields
	public readonly T1 Value1; // 0x0
	public readonly T2 Value2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 v1, T2 v2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA3458 Offset: 0x2C9F458 VA: 0x2CA3458
	|-StructMultiKey<object, object>..ctor
	|
	|-RVA: 0x2CA3624 Offset: 0x2C9F624 VA: 0x2CA3624
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA3488 Offset: 0x2C9F488 VA: 0x2CA3488
	|-StructMultiKey<object, object>.GetHashCode
	|
	|-RVA: 0x2CA3808 Offset: 0x2C9F808 VA: 0x2CA3808
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA3500 Offset: 0x2C9F500 VA: 0x2CA3500
	|-StructMultiKey<object, object>.Equals
	|
	|-RVA: 0x2CA3C0C Offset: 0x2C9FC0C VA: 0x2CA3C0C
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(StructMultiKey<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA35DC Offset: 0x2C9F5DC VA: 0x2CA35DC
	|-StructMultiKey<object, object>.Equals
	|
	|-RVA: 0x2CA3E00 Offset: 0x2C9FE00 VA: 0x2CA3E00
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/
}

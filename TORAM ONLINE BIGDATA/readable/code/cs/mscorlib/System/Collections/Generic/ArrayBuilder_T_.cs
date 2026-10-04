// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[DefaultMember("Item")]
internal struct ArrayBuilder<T> // TypeDefIndex: 10951
{
	// Fields
	private T[] _array; // 0x0
	private int _count; // 0x0

	// Properties
	public int Capacity { get; }
	public int Count { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2830C94 Offset: 0x282CC94 VA: 0x2830C94
	|-ArrayBuilder<object>.get_Capacity
	|
	|-RVA: 0x28311D0 Offset: 0x282D1D0 VA: 0x28311D0
	|-ArrayBuilder<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2830CAC Offset: 0x282CCAC VA: 0x2830CAC
	|-ArrayBuilder<object>.get_Count
	|
	|-RVA: 0x28311E8 Offset: 0x282D1E8 VA: 0x28311E8
	|-ArrayBuilder<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2830CB4 Offset: 0x282CCB4 VA: 0x2830CB4
	|-ArrayBuilder<object>.get_Item
	|
	|-RVA: 0x28311F0 Offset: 0x282D1F0 VA: 0x28311F0
	|-ArrayBuilder<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2830CE4 Offset: 0x282CCE4 VA: 0x2830CE4
	|-ArrayBuilder<object>.Add
	|
	|-RVA: 0x28312D4 Offset: 0x282D2D4 VA: 0x28312D4
	|-ArrayBuilder<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void UncheckedAdd(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2830D78 Offset: 0x282CD78 VA: 0x2830D78
	|-ArrayBuilder<object>.UncheckedAdd
	|
	|-RVA: 0x2831528 Offset: 0x282D528 VA: 0x2831528
	|-ArrayBuilder<__Il2CppFullySharedGenericType>.UncheckedAdd
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int minimum) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2830DB4 Offset: 0x282CDB4 VA: 0x2830DB4
	|-ArrayBuilder<object>.EnsureCapacity
	|
	|-RVA: 0x283169C Offset: 0x282D69C VA: 0x283169C
	|-ArrayBuilder<__Il2CppFullySharedGenericType>.EnsureCapacity
	*/
}

// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
internal struct LargeArrayBuilder<T> // TypeDefIndex: 10953
{
	// Fields
	private readonly int _maxCapacity; // 0x0
	private T[] _first; // 0x0
	private ArrayBuilder<T[]> _buffers; // 0x0
	private T[] _current; // 0x0
	private int _index; // 0x0
	private int _count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(bool initialize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA5998 Offset: 0x2AA1998 VA: 0x2AA5998
	|-LargeArrayBuilder<object>..ctor
	|
	|-RVA: 0x2AA62EC Offset: 0x2AA22EC VA: 0x2AA62EC
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int maxCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA59D0 Offset: 0x2AA19D0 VA: 0x2AA59D0
	|-LargeArrayBuilder<object>..ctor
	|
	|-RVA: 0x2AA6368 Offset: 0x2AA2368 VA: 0x2AA6368
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> items) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA5A80 Offset: 0x2AA1A80 VA: 0x2AA5A80
	|-LargeArrayBuilder<object>.AddRange
	|
	|-RVA: 0x2AA6410 Offset: 0x2AA2410 VA: 0x2AA6410
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1
	private void AddWithBufferAllocation(T item, ref T[] destination, ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA5E14 Offset: 0x2AA1E14 VA: 0x2AA5E14
	|-LargeArrayBuilder<object>.AddWithBufferAllocation
	|
	|-RVA: 0x2AA6964 Offset: 0x2AA2964 VA: 0x2AA6964
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.AddWithBufferAllocation
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int arrayIndex, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA5EBC Offset: 0x2AA1EBC VA: 0x2AA5EBC
	|-LargeArrayBuilder<object>.CopyTo
	|
	|-RVA: 0x2AA6B60 Offset: 0x2AA2B60 VA: 0x2AA6B60
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public T[] GetBuffer(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA5FB4 Offset: 0x2AA1FB4 VA: 0x2AA5FB4
	|-LargeArrayBuilder<object>.GetBuffer
	|
	|-RVA: 0x2AA6C90 Offset: 0x2AA2C90 VA: 0x2AA6C90
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.GetBuffer
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA6034 Offset: 0x2AA2034 VA: 0x2AA6034
	|-LargeArrayBuilder<object>.ToArray
	|
	|-RVA: 0x2AA6DB4 Offset: 0x2AA2DB4 VA: 0x2AA6DB4
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public bool TryMove(out T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA60EC Offset: 0x2AA20EC VA: 0x2AA60EC
	|-LargeArrayBuilder<object>.TryMove
	|
	|-RVA: 0x2AA6EE0 Offset: 0x2AA2EE0 VA: 0x2AA6EE0
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.TryMove
	*/

	// RVA: -1 Offset: -1
	private void AllocateBuffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA612C Offset: 0x2AA212C VA: 0x2AA612C
	|-LargeArrayBuilder<object>.AllocateBuffer
	|
	|-RVA: 0x2AA6F20 Offset: 0x2AA2F20 VA: 0x2AA6F20
	|-LargeArrayBuilder<__Il2CppFullySharedGenericType>.AllocateBuffer
	*/
}

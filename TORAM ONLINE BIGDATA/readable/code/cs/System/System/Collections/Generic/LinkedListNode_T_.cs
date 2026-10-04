// Assembly: System.dll
// Namespace: System.Collections.Generic
public sealed class LinkedListNode<T> // TypeDefIndex: 14314
{
	// Fields
	internal LinkedList<T> list; // 0x0
	internal LinkedListNode<T> next; // 0x0
	internal LinkedListNode<T> prev; // 0x0
	internal T item; // 0x0

	// Properties
	public LinkedListNode<T> Next { get; }
	public T Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(LinkedList<T> list, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7134 Offset: 0x2AA3134 VA: 0x2AA7134
	|-LinkedListNode<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2AA7200 Offset: 0x2AA3200 VA: 0x2AA7200
	|-LinkedListNode<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2AA72D0 Offset: 0x2AA32D0 VA: 0x2AA72D0
	|-LinkedListNode<object>..ctor
	|
	|-RVA: 0x2AA7388 Offset: 0x2AA3388 VA: 0x2AA7388
	|-LinkedListNode<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_Next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7188 Offset: 0x2AA3188 VA: 0x2AA7188
	|-LinkedListNode<ValueTuple<object, object>>.get_Next
	|
	|-RVA: 0x2AA7250 Offset: 0x2AA3250 VA: 0x2AA7250
	|-LinkedListNode<ValueTuple<object, object, object>>.get_Next
	|
	|-RVA: 0x2AA7314 Offset: 0x2AA3314 VA: 0x2AA7314
	|-LinkedListNode<object>.get_Next
	|
	|-RVA: 0x2AA7484 Offset: 0x2AA3484 VA: 0x2AA7484
	|-LinkedListNode<__Il2CppFullySharedGenericType>.get_Next
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA71BC Offset: 0x2AA31BC VA: 0x2AA71BC
	|-LinkedListNode<ValueTuple<object, object>>.get_Value
	|
	|-RVA: 0x2AA7284 Offset: 0x2AA3284 VA: 0x2AA7284
	|-LinkedListNode<ValueTuple<object, object, object>>.get_Value
	|
	|-RVA: 0x2AA7348 Offset: 0x2AA3348 VA: 0x2AA7348
	|-LinkedListNode<object>.get_Value
	|
	|-RVA: 0x2AA7538 Offset: 0x2AA3538 VA: 0x2AA7538
	|-LinkedListNode<__Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1
	internal void Invalidate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA71C8 Offset: 0x2AA31C8 VA: 0x2AA71C8
	|-LinkedListNode<ValueTuple<object, object>>.Invalidate
	|
	|-RVA: 0x2AA7298 Offset: 0x2AA3298 VA: 0x2AA7298
	|-LinkedListNode<ValueTuple<object, object, object>>.Invalidate
	|
	|-RVA: 0x2AA7350 Offset: 0x2AA3350 VA: 0x2AA7350
	|-LinkedListNode<object>.Invalidate
	|
	|-RVA: 0x2AA75D4 Offset: 0x2AA35D4 VA: 0x2AA75D4
	|-LinkedListNode<__Il2CppFullySharedGenericType>.Invalidate
	*/
}

// Assembly: System.dll
// Namespace: 
[Serializable]
public struct LinkedList.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback // TypeDefIndex: 14312
{
	// Fields
	private LinkedList<T> _list; // 0x0
	private LinkedListNode<T> _node; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0
	private int _index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(LinkedList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DB80 Offset: 0x2969B80 VA: 0x296DB80
	|-LinkedList.Enumerator<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x296E0F4 Offset: 0x296A0F4 VA: 0x296E0F4
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x297352C Offset: 0x296F52C VA: 0x297352C
	|-LinkedList.Enumerator<object>..ctor
	|
	|-RVA: 0x29781F4 Offset: 0x29741F4 VA: 0x29781F4
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DBCC Offset: 0x2969BCC VA: 0x296DBCC
	|-LinkedList.Enumerator<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x296E144 Offset: 0x296A144 VA: 0x296E144
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2973578 Offset: 0x296F578 VA: 0x2973578
	|-LinkedList.Enumerator<object>..ctor
	|
	|-RVA: 0x2978340 Offset: 0x2974340 VA: 0x2978340
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DC00 Offset: 0x2969C00 VA: 0x296DC00
	|-LinkedList.Enumerator<ValueTuple<object, object>>.get_Current
	|
	|-RVA: 0x296E178 Offset: 0x296A178 VA: 0x296E178
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.get_Current
	|
	|-RVA: 0x29735AC Offset: 0x296F5AC VA: 0x29735AC
	|-LinkedList.Enumerator<object>.get_Current
	|
	|-RVA: 0x2978374 Offset: 0x2974374 VA: 0x2978374
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DC0C Offset: 0x2969C0C VA: 0x296DC0C
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x296E18C Offset: 0x296A18C VA: 0x296E18C
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29735B4 Offset: 0x296F5B4 VA: 0x29735B4
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2978464 Offset: 0x2974464 VA: 0x2978464
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DCD0 Offset: 0x2969CD0 VA: 0x296DCD0
	|-LinkedList.Enumerator<ValueTuple<object, object>>.MoveNext
	|
	|-RVA: 0x296E258 Offset: 0x296A258 VA: 0x296E258
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.MoveNext
	|
	|-RVA: 0x297364C Offset: 0x296F64C VA: 0x297364C
	|-LinkedList.Enumerator<object>.MoveNext
	|
	|-RVA: 0x2978698 Offset: 0x2974698 VA: 0x2978698
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DDE0 Offset: 0x2969DE0 VA: 0x296DDE0
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x296E370 Offset: 0x296A370 VA: 0x296E370
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x297375C Offset: 0x296F75C VA: 0x297375C
	|-LinkedList.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x2978AD8 Offset: 0x2974AD8 VA: 0x2978AD8
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DE6C Offset: 0x2969E6C VA: 0x296DE6C
	|-LinkedList.Enumerator<ValueTuple<object, object>>.Dispose
	|
	|-RVA: 0x296E400 Offset: 0x296A400 VA: 0x296E400
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.Dispose
	|
	|-RVA: 0x29737E8 Offset: 0x296F7E8 VA: 0x29737E8
	|-LinkedList.Enumerator<object>.Dispose
	|
	|-RVA: 0x2978C94 Offset: 0x2974C94 VA: 0x2978C94
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DE70 Offset: 0x2969E70 VA: 0x296DE70
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x296E404 Offset: 0x296A404 VA: 0x296E404
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x29737EC Offset: 0x296F7EC VA: 0x29737EC
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x2978C98 Offset: 0x2974C98 VA: 0x2978C98
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x296DEA4 Offset: 0x2969EA4 VA: 0x296DEA4
	|-LinkedList.Enumerator<ValueTuple<object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x296E438 Offset: 0x296A438 VA: 0x296E438
	|-LinkedList.Enumerator<ValueTuple<object, object, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x2973820 Offset: 0x296F820 VA: 0x2973820
	|-LinkedList.Enumerator<object>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x2978CCC Offset: 0x2974CCC VA: 0x2978CCC
	|-LinkedList.Enumerator<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/
}

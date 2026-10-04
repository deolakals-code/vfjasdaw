// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[DebuggerTypeProxy(typeof(QueueDebugView<T>))]
[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 10959
{
	// Fields
	private T[] _array; // 0x0
	private int _head; // 0x0
	private int _tail; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private const int MinimumGrow = 4;
	private const int GrowFactor = 200;

	// Properties
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEEAF4 Offset: 0x2BEAAF4 VA: 0x2BEEAF4
	|-Queue<DefencePoint2>..ctor
	|
	|-RVA: 0x2BEF358 Offset: 0x2BEB358 VA: 0x2BEF358
	|-Queue<int>..ctor
	|
	|-RVA: 0x2BEFBB0 Offset: 0x2BEBBB0 VA: 0x2BEFBB0
	|-Queue<object>..ctor
	|
	|-RVA: 0x2BF0498 Offset: 0x2BEC498 VA: 0x2BF0498
	|-Queue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEEB78 Offset: 0x2BEAB78 VA: 0x2BEEB78
	|-Queue<DefencePoint2>..ctor
	|
	|-RVA: 0x2BEF3DC Offset: 0x2BEB3DC VA: 0x2BEF3DC
	|-Queue<int>..ctor
	|
	|-RVA: 0x2BEFC34 Offset: 0x2BEBC34 VA: 0x2BEFC34
	|-Queue<object>..ctor
	|
	|-RVA: 0x2BF04DC Offset: 0x2BEC4DC VA: 0x2BF04DC
	|-Queue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEEC48 Offset: 0x2BEAC48 VA: 0x2BEEC48
	|-Queue<DefencePoint2>.get_Count
	|
	|-RVA: 0x2BEF4AC Offset: 0x2BEB4AC VA: 0x2BEF4AC
	|-Queue<int>.get_Count
	|
	|-RVA: 0x2BEFD04 Offset: 0x2BEBD04 VA: 0x2BEFD04
	|-Queue<object>.get_Count
	|
	|-RVA: 0x2BF05AC Offset: 0x2BEC5AC VA: 0x2BF05AC
	|-Queue<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEEC50 Offset: 0x2BEAC50 VA: 0x2BEEC50
	|-Queue<DefencePoint2>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2BEF4B4 Offset: 0x2BEB4B4 VA: 0x2BEF4B4
	|-Queue<int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2BEFD0C Offset: 0x2BEBD0C VA: 0x2BEFD0C
	|-Queue<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2BF05B4 Offset: 0x2BEC5B4 VA: 0x2BF05B4
	|-Queue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEEC58 Offset: 0x2BEAC58 VA: 0x2BEEC58
	|-Queue<DefencePoint2>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2BEF4BC Offset: 0x2BEB4BC VA: 0x2BEF4BC
	|-Queue<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2BEFD14 Offset: 0x2BEBD14 VA: 0x2BEFD14
	|-Queue<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2BF05BC Offset: 0x2BEC5BC VA: 0x2BF05BC
	|-Queue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEECC8 Offset: 0x2BEACC8 VA: 0x2BEECC8
	|-Queue<DefencePoint2>.Clear
	|
	|-RVA: 0x2BEF52C Offset: 0x2BEB52C VA: 0x2BEF52C
	|-Queue<int>.Clear
	|
	|-RVA: 0x2BEFD84 Offset: 0x2BEBD84 VA: 0x2BEFD84
	|-Queue<object>.Clear
	|
	|-RVA: 0x2BF062C Offset: 0x2BEC62C VA: 0x2BF062C
	|-Queue<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEECE8 Offset: 0x2BEACE8 VA: 0x2BEECE8
	|-Queue<DefencePoint2>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2BEF54C Offset: 0x2BEB54C VA: 0x2BEF54C
	|-Queue<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2BEFDF4 Offset: 0x2BEBDF4 VA: 0x2BEFDF4
	|-Queue<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2BF06B4 Offset: 0x2BEC6B4 VA: 0x2BF06B4
	|-Queue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEEFB8 Offset: 0x2BEAFB8 VA: 0x2BEEFB8
	|-Queue<DefencePoint2>.Enqueue
	|
	|-RVA: 0x2BEF81C Offset: 0x2BEB81C VA: 0x2BEF81C
	|-Queue<int>.Enqueue
	|
	|-RVA: 0x2BF00C4 Offset: 0x2BEC0C4 VA: 0x2BF00C4
	|-Queue<object>.Enqueue
	|
	|-RVA: 0x2BF0984 Offset: 0x2BEC984 VA: 0x2BF0984
	|-Queue<__Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	public Queue.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEF068 Offset: 0x2BEB068 VA: 0x2BEF068
	|-Queue<DefencePoint2>.GetEnumerator
	|
	|-RVA: 0x2BEF8C0 Offset: 0x2BEB8C0 VA: 0x2BEF8C0
	|-Queue<int>.GetEnumerator
	|
	|-RVA: 0x2BF017C Offset: 0x2BEC17C VA: 0x2BF017C
	|-Queue<object>.GetEnumerator
	|
	|-RVA: 0x2BF0B28 Offset: 0x2BECB28 VA: 0x2BF0B28
	|-Queue<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEF088 Offset: 0x2BEB088 VA: 0x2BEF088
	|-Queue<DefencePoint2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BEF8E0 Offset: 0x2BEB8E0 VA: 0x2BEF8E0
	|-Queue<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BF019C Offset: 0x2BEC19C VA: 0x2BF019C
	|-Queue<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2BF0BD8 Offset: 0x2BECBD8 VA: 0x2BF0BD8
	|-Queue<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEF0E4 Offset: 0x2BEB0E4 VA: 0x2BEF0E4
	|-Queue<DefencePoint2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BEF93C Offset: 0x2BEB93C VA: 0x2BEF93C
	|-Queue<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF01F8 Offset: 0x2BEC1F8 VA: 0x2BF01F8
	|-Queue<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2BF0C88 Offset: 0x2BECC88 VA: 0x2BF0C88
	|-Queue<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Dequeue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEF140 Offset: 0x2BEB140 VA: 0x2BEF140
	|-Queue<DefencePoint2>.Dequeue
	|
	|-RVA: 0x2BEF998 Offset: 0x2BEB998 VA: 0x2BEF998
	|-Queue<int>.Dequeue
	|
	|-RVA: 0x2BF0254 Offset: 0x2BEC254 VA: 0x2BF0254
	|-Queue<object>.Dequeue
	|
	|-RVA: 0x2BF0D38 Offset: 0x2BECD38 VA: 0x2BF0D38
	|-Queue<__Il2CppFullySharedGenericType>.Dequeue
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEF1B0 Offset: 0x2BEB1B0 VA: 0x2BEF1B0
	|-Queue<DefencePoint2>.Peek
	|
	|-RVA: 0x2BEFA08 Offset: 0x2BEBA08 VA: 0x2BEFA08
	|-Queue<int>.Peek
	|
	|-RVA: 0x2BF02F0 Offset: 0x2BEC2F0 VA: 0x2BF02F0
	|-Queue<object>.Peek
	|
	|-RVA: 0x2BF0F88 Offset: 0x2BECF88 VA: 0x2BF0F88
	|-Queue<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	private void SetCapacity(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEF1FC Offset: 0x2BEB1FC VA: 0x2BEF1FC
	|-Queue<DefencePoint2>.SetCapacity
	|
	|-RVA: 0x2BEFA54 Offset: 0x2BEBA54 VA: 0x2BEFA54
	|-Queue<int>.SetCapacity
	|
	|-RVA: 0x2BF033C Offset: 0x2BEC33C VA: 0x2BF033C
	|-Queue<object>.SetCapacity
	|
	|-RVA: 0x2BF106C Offset: 0x2BED06C VA: 0x2BF106C
	|-Queue<__Il2CppFullySharedGenericType>.SetCapacity
	*/

	// RVA: -1 Offset: -1
	private void MoveNext(ref int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEF2E0 Offset: 0x2BEB2E0 VA: 0x2BEF2E0
	|-Queue<DefencePoint2>.MoveNext
	|
	|-RVA: 0x2BEFB38 Offset: 0x2BEBB38 VA: 0x2BEFB38
	|-Queue<int>.MoveNext
	|
	|-RVA: 0x2BF0420 Offset: 0x2BEC420 VA: 0x2BF0420
	|-Queue<object>.MoveNext
	|
	|-RVA: 0x2BF1150 Offset: 0x2BED150 VA: 0x2BF1150
	|-Queue<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void ThrowForEmptyQueue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2BEF310 Offset: 0x2BEB310 VA: 0x2BEF310
	|-Queue<DefencePoint2>.ThrowForEmptyQueue
	|
	|-RVA: 0x2BEFB68 Offset: 0x2BEBB68 VA: 0x2BEFB68
	|-Queue<int>.ThrowForEmptyQueue
	|
	|-RVA: 0x2BF0450 Offset: 0x2BEC450 VA: 0x2BF0450
	|-Queue<object>.ThrowForEmptyQueue
	|
	|-RVA: 0x2BF1180 Offset: 0x2BED180 VA: 0x2BF1180
	|-Queue<__Il2CppFullySharedGenericType>.ThrowForEmptyQueue
	*/
}

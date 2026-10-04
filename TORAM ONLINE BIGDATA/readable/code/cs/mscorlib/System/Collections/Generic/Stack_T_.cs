// Assembly: mscorlib.dll
// Namespace: System.Collections.Generic
[TypeForwardedFrom("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
[DebuggerTypeProxy(typeof(StackDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class Stack<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 10962
{
	// Fields
	private T[] _array; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0
	private object _syncRoot; // 0x0
	private const int DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA0C1C Offset: 0x2C9CC1C VA: 0x2CA0C1C
	|-Stack<object>..ctor
	|
	|-RVA: 0x2CA1364 Offset: 0x2C9D364 VA: 0x2CA1364
	|-Stack<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2CA2024 Offset: 0x2C9E024 VA: 0x2CA2024
	|-Stack<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-RVA: 0x2CA2858 Offset: 0x2C9E858 VA: 0x2CA2858
	|-Stack<BindingRestrictions.TestBuilder.AndNode>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA0CA0 Offset: 0x2C9CCA0 VA: 0x2CA0CA0
	|-Stack<object>..ctor
	|
	|-RVA: 0x2CA13A8 Offset: 0x2C9D3A8 VA: 0x2CA13A8
	|-Stack<__Il2CppFullySharedGenericType>..ctor
	|
	|-RVA: 0x2CA20A8 Offset: 0x2C9E0A8 VA: 0x2CA20A8
	|-Stack<SequenceNode.SequenceConstructPosContext>..ctor
	|
	|-RVA: 0x2CA28DC Offset: 0x2C9E8DC VA: 0x2CA28DC
	|-Stack<BindingRestrictions.TestBuilder.AndNode>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA0D70 Offset: 0x2C9CD70 VA: 0x2CA0D70
	|-Stack<object>.get_Count
	|
	|-RVA: 0x2CA1478 Offset: 0x2C9D478 VA: 0x2CA1478
	|-Stack<__Il2CppFullySharedGenericType>.get_Count
	|
	|-RVA: 0x2CA2178 Offset: 0x2C9E178 VA: 0x2CA2178
	|-Stack<SequenceNode.SequenceConstructPosContext>.get_Count
	|
	|-RVA: 0x2CA29AC Offset: 0x2C9E9AC VA: 0x2CA29AC
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA0D78 Offset: 0x2C9CD78 VA: 0x2CA0D78
	|-Stack<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2CA1480 Offset: 0x2C9D480 VA: 0x2CA1480
	|-Stack<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2CA2180 Offset: 0x2C9E180 VA: 0x2CA2180
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2CA29B4 Offset: 0x2C9E9B4 VA: 0x2CA29B4
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA0D80 Offset: 0x2C9CD80 VA: 0x2CA0D80
	|-Stack<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2CA1488 Offset: 0x2C9D488 VA: 0x2CA1488
	|-Stack<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2CA2188 Offset: 0x2C9E188 VA: 0x2CA2188
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2CA29BC Offset: 0x2C9E9BC VA: 0x2CA29BC
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA0DF0 Offset: 0x2C9CDF0 VA: 0x2CA0DF0
	|-Stack<object>.Clear
	|
	|-RVA: 0x2CA14F8 Offset: 0x2C9D4F8 VA: 0x2CA14F8
	|-Stack<__Il2CppFullySharedGenericType>.Clear
	|
	|-RVA: 0x2CA21F8 Offset: 0x2C9E1F8 VA: 0x2CA21F8
	|-Stack<SequenceNode.SequenceConstructPosContext>.Clear
	|
	|-RVA: 0x2CA2A2C Offset: 0x2C9EA2C VA: 0x2CA2A2C
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA0E20 Offset: 0x2C9CE20 VA: 0x2CA0E20
	|-Stack<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2CA1540 Offset: 0x2C9D540 VA: 0x2CA1540
	|-Stack<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2CA2228 Offset: 0x2C9E228 VA: 0x2CA2228
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2CA2A5C Offset: 0x2C9EA5C VA: 0x2CA2A5C
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public Stack.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA10AC Offset: 0x2C9D0AC VA: 0x2CA10AC
	|-Stack<object>.GetEnumerator
	|
	|-RVA: 0x2CA17CC Offset: 0x2C9D7CC VA: 0x2CA17CC
	|-Stack<__Il2CppFullySharedGenericType>.GetEnumerator
	|
	|-RVA: 0x2CA24B4 Offset: 0x2C9E4B4 VA: 0x2CA24B4
	|-Stack<SequenceNode.SequenceConstructPosContext>.GetEnumerator
	|
	|-RVA: 0x2CA2CE8 Offset: 0x2C9ECE8 VA: 0x2CA2CE8
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA10CC Offset: 0x2C9D0CC VA: 0x2CA10CC
	|-Stack<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2CA187C Offset: 0x2C9D87C VA: 0x2CA187C
	|-Stack<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2CA24DC Offset: 0x2C9E4DC VA: 0x2CA24DC
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2CA2D08 Offset: 0x2C9ED08 VA: 0x2CA2D08
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA1128 Offset: 0x2C9D128 VA: 0x2CA1128
	|-Stack<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CA192C Offset: 0x2C9D92C VA: 0x2CA192C
	|-Stack<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CA2548 Offset: 0x2C9E548 VA: 0x2CA2548
	|-Stack<SequenceNode.SequenceConstructPosContext>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CA2D5C Offset: 0x2C9ED5C VA: 0x2CA2D5C
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA1184 Offset: 0x2C9D184 VA: 0x2CA1184
	|-Stack<object>.Peek
	|
	|-RVA: 0x2CA19DC Offset: 0x2C9D9DC VA: 0x2CA19DC
	|-Stack<__Il2CppFullySharedGenericType>.Peek
	|
	|-RVA: 0x2CA25B4 Offset: 0x2C9E5B4 VA: 0x2CA25B4
	|-Stack<SequenceNode.SequenceConstructPosContext>.Peek
	|
	|-RVA: 0x2CA2DB0 Offset: 0x2C9EDB0 VA: 0x2CA2DB0
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.Peek
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA11C8 Offset: 0x2C9D1C8 VA: 0x2CA11C8
	|-Stack<object>.Pop
	|
	|-RVA: 0x2CA1AC4 Offset: 0x2C9DAC4 VA: 0x2CA1AC4
	|-Stack<__Il2CppFullySharedGenericType>.Pop
	|
	|-RVA: 0x2CA2608 Offset: 0x2C9E608 VA: 0x2CA2608
	|-Stack<SequenceNode.SequenceConstructPosContext>.Pop
	|
	|-RVA: 0x2CA2DF4 Offset: 0x2C9EDF4 VA: 0x2CA2DF4
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.Pop
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA1228 Offset: 0x2C9D228 VA: 0x2CA1228
	|-Stack<object>.Push
	|
	|-RVA: 0x2CA1CF4 Offset: 0x2C9DCF4 VA: 0x2CA1CF4
	|-Stack<__Il2CppFullySharedGenericType>.Push
	|
	|-RVA: 0x2CA26A8 Offset: 0x2C9E6A8 VA: 0x2CA26A8
	|-Stack<SequenceNode.SequenceConstructPosContext>.Push
	|
	|-RVA: 0x2CA2E64 Offset: 0x2C9EE64 VA: 0x2CA2E64
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.Push
	*/

	// RVA: -1 Offset: -1
	private void PushWithResize(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA1294 Offset: 0x2C9D294 VA: 0x2CA1294
	|-Stack<object>.PushWithResize
	|
	|-RVA: 0x2CA1E70 Offset: 0x2C9DE70 VA: 0x2CA1E70
	|-Stack<__Il2CppFullySharedGenericType>.PushWithResize
	|
	|-RVA: 0x2CA274C Offset: 0x2C9E74C VA: 0x2CA274C
	|-Stack<SequenceNode.SequenceConstructPosContext>.PushWithResize
	|
	|-RVA: 0x2CA2ED8 Offset: 0x2C9EED8 VA: 0x2CA2ED8
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.PushWithResize
	*/

	// RVA: -1 Offset: -1
	private void ThrowForEmptyStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA131C Offset: 0x2C9D31C VA: 0x2CA131C
	|-Stack<object>.ThrowForEmptyStack
	|
	|-RVA: 0x2CA1FDC Offset: 0x2C9DFDC VA: 0x2CA1FDC
	|-Stack<__Il2CppFullySharedGenericType>.ThrowForEmptyStack
	|
	|-RVA: 0x2CA2810 Offset: 0x2C9E810 VA: 0x2CA2810
	|-Stack<SequenceNode.SequenceConstructPosContext>.ThrowForEmptyStack
	|
	|-RVA: 0x2CA2F68 Offset: 0x2C9EF68 VA: 0x2CA2F68
	|-Stack<BindingRestrictions.TestBuilder.AndNode>.ThrowForEmptyStack
	*/
}

// Assembly: System.dll
// Namespace: System.Collections.Generic
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[Serializable]
public class LinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 14313
{
	// Fields
	internal LinkedListNode<T> head; // 0x0
	internal int count; // 0x0
	internal int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo _siInfo; // 0x0
	private const string VersionName = "Version";
	private const string CountName = "Count";
	private const string ValuesName = "Data";

	// Properties
	public int Count { get; }
	public LinkedListNode<T> First { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7644 Offset: 0x2AA3644 VA: 0x2AA7644
	|-LinkedList<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2AA8840 Offset: 0x2AA4840 VA: 0x2AA8840
	|-LinkedList<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2AA9BB4 Offset: 0x2AA5BB4 VA: 0x2AA9BB4
	|-LinkedList<object>..ctor
	|
	|-RVA: 0x2AAAD70 Offset: 0x2AA6D70 VA: 0x2AAAD70
	|-LinkedList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA764C Offset: 0x2AA364C VA: 0x2AA764C
	|-LinkedList<ValueTuple<object, object>>..ctor
	|
	|-RVA: 0x2AA8848 Offset: 0x2AA4848 VA: 0x2AA8848
	|-LinkedList<ValueTuple<object, object, object>>..ctor
	|
	|-RVA: 0x2AA9BBC Offset: 0x2AA5BBC VA: 0x2AA9BBC
	|-LinkedList<object>..ctor
	|
	|-RVA: 0x2AAAD78 Offset: 0x2AA6D78 VA: 0x2AAAD78
	|-LinkedList<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA767C Offset: 0x2AA367C VA: 0x2AA767C
	|-LinkedList<ValueTuple<object, object>>.get_Count
	|
	|-RVA: 0x2AA8878 Offset: 0x2AA4878 VA: 0x2AA8878
	|-LinkedList<ValueTuple<object, object, object>>.get_Count
	|
	|-RVA: 0x2AA9BEC Offset: 0x2AA5BEC VA: 0x2AA9BEC
	|-LinkedList<object>.get_Count
	|
	|-RVA: 0x2AAADA8 Offset: 0x2AA6DA8 VA: 0x2AAADA8
	|-LinkedList<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> get_First() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7684 Offset: 0x2AA3684 VA: 0x2AA7684
	|-LinkedList<ValueTuple<object, object>>.get_First
	|
	|-RVA: 0x2AA8880 Offset: 0x2AA4880 VA: 0x2AA8880
	|-LinkedList<ValueTuple<object, object, object>>.get_First
	|
	|-RVA: 0x2AA9BF4 Offset: 0x2AA5BF4 VA: 0x2AA9BF4
	|-LinkedList<object>.get_First
	|
	|-RVA: 0x2AAADB0 Offset: 0x2AA6DB0 VA: 0x2AAADB0
	|-LinkedList<__Il2CppFullySharedGenericType>.get_First
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA768C Offset: 0x2AA368C VA: 0x2AA768C
	|-LinkedList<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AA8888 Offset: 0x2AA4888 VA: 0x2AA8888
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AA9BFC Offset: 0x2AA5BFC VA: 0x2AA9BFC
	|-LinkedList<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2AAADB8 Offset: 0x2AA6DB8 VA: 0x2AAADB8
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7694 Offset: 0x2AA3694 VA: 0x2AA7694
	|-LinkedList<ValueTuple<object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2AA8890 Offset: 0x2AA4890 VA: 0x2AA8890
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2AA9C04 Offset: 0x2AA5C04 VA: 0x2AA9C04
	|-LinkedList<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2AAADC0 Offset: 0x2AA6DC0 VA: 0x2AAADC0
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA76A4 Offset: 0x2AA36A4 VA: 0x2AA76A4
	|-LinkedList<ValueTuple<object, object>>.AddBefore
	|
	|-RVA: 0x2AA88D0 Offset: 0x2AA48D0 VA: 0x2AA88D0
	|-LinkedList<ValueTuple<object, object, object>>.AddBefore
	|
	|-RVA: 0x2AA9C14 Offset: 0x2AA5C14 VA: 0x2AA9C14
	|-LinkedList<object>.AddBefore
	|
	|-RVA: 0x2AAAE7C Offset: 0x2AA6E7C VA: 0x2AAAE7C
	|-LinkedList<__Il2CppFullySharedGenericType>.AddBefore
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddFirst(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7758 Offset: 0x2AA3758 VA: 0x2AA7758
	|-LinkedList<ValueTuple<object, object>>.AddFirst
	|
	|-RVA: 0x2AA899C Offset: 0x2AA499C VA: 0x2AA899C
	|-LinkedList<ValueTuple<object, object, object>>.AddFirst
	|
	|-RVA: 0x2AA9CB8 Offset: 0x2AA5CB8 VA: 0x2AA9CB8
	|-LinkedList<object>.AddFirst
	|
	|-RVA: 0x2AAAFFC Offset: 0x2AA6FFC VA: 0x2AAAFFC
	|-LinkedList<__Il2CppFullySharedGenericType>.AddFirst
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> AddLast(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA77F8 Offset: 0x2AA37F8 VA: 0x2AA77F8
	|-LinkedList<ValueTuple<object, object>>.AddLast
	|
	|-RVA: 0x2AA8A50 Offset: 0x2AA4A50 VA: 0x2AA8A50
	|-LinkedList<ValueTuple<object, object, object>>.AddLast
	|
	|-RVA: 0x2AA9D48 Offset: 0x2AA5D48 VA: 0x2AA9D48
	|-LinkedList<object>.AddLast
	|
	|-RVA: 0x2AAB140 Offset: 0x2AA7140 VA: 0x2AAB140
	|-LinkedList<__Il2CppFullySharedGenericType>.AddLast
	*/

	// RVA: -1 Offset: -1
	public void AddLast(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7884 Offset: 0x2AA3884 VA: 0x2AA7884
	|-LinkedList<ValueTuple<object, object>>.AddLast
	|
	|-RVA: 0x2AA8AF0 Offset: 0x2AA4AF0 VA: 0x2AA8AF0
	|-LinkedList<ValueTuple<object, object, object>>.AddLast
	|
	|-RVA: 0x2AA9DC4 Offset: 0x2AA5DC4 VA: 0x2AA9DC4
	|-LinkedList<object>.AddLast
	|
	|-RVA: 0x2AAB270 Offset: 0x2AA7270 VA: 0x2AAB270
	|-LinkedList<__Il2CppFullySharedGenericType>.AddLast
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA78E8 Offset: 0x2AA38E8 VA: 0x2AA78E8
	|-LinkedList<ValueTuple<object, object>>.Clear
	|
	|-RVA: 0x2AA8B54 Offset: 0x2AA4B54 VA: 0x2AA8B54
	|-LinkedList<ValueTuple<object, object, object>>.Clear
	|
	|-RVA: 0x2AA9E28 Offset: 0x2AA5E28 VA: 0x2AA9E28
	|-LinkedList<object>.Clear
	|
	|-RVA: 0x2AAB300 Offset: 0x2AA7300 VA: 0x2AAB300
	|-LinkedList<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA796C Offset: 0x2AA396C VA: 0x2AA796C
	|-LinkedList<ValueTuple<object, object>>.Contains
	|
	|-RVA: 0x2AA8BD8 Offset: 0x2AA4BD8 VA: 0x2AA8BD8
	|-LinkedList<ValueTuple<object, object, object>>.Contains
	|
	|-RVA: 0x2AA9EAC Offset: 0x2AA5EAC VA: 0x2AA9EAC
	|-LinkedList<object>.Contains
	|
	|-RVA: 0x2AAB388 Offset: 0x2AA7388 VA: 0x2AAB388
	|-LinkedList<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7990 Offset: 0x2AA3990 VA: 0x2AA7990
	|-LinkedList<ValueTuple<object, object>>.CopyTo
	|
	|-RVA: 0x2AA8C20 Offset: 0x2AA4C20 VA: 0x2AA8C20
	|-LinkedList<ValueTuple<object, object, object>>.CopyTo
	|
	|-RVA: 0x2AA9ED0 Offset: 0x2AA5ED0 VA: 0x2AA9ED0
	|-LinkedList<object>.CopyTo
	|
	|-RVA: 0x2AAB454 Offset: 0x2AA7454 VA: 0x2AAB454
	|-LinkedList<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public LinkedListNode<T> Find(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7B5C Offset: 0x2AA3B5C VA: 0x2AA7B5C
	|-LinkedList<ValueTuple<object, object>>.Find
	|
	|-RVA: 0x2AA8E14 Offset: 0x2AA4E14 VA: 0x2AA8E14
	|-LinkedList<ValueTuple<object, object, object>>.Find
	|
	|-RVA: 0x2AAA094 Offset: 0x2AA6094 VA: 0x2AAA094
	|-LinkedList<object>.Find
	|
	|-RVA: 0x2AAB71C Offset: 0x2AA771C VA: 0x2AAB71C
	|-LinkedList<__Il2CppFullySharedGenericType>.Find
	*/

	// RVA: -1 Offset: -1
	public LinkedList.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7BE4 Offset: 0x2AA3BE4 VA: 0x2AA7BE4
	|-LinkedList<ValueTuple<object, object>>.GetEnumerator
	|
	|-RVA: 0x2AA8EE0 Offset: 0x2AA4EE0 VA: 0x2AA8EE0
	|-LinkedList<ValueTuple<object, object, object>>.GetEnumerator
	|
	|-RVA: 0x2AAA138 Offset: 0x2AA6138 VA: 0x2AAA138
	|-LinkedList<object>.GetEnumerator
	|
	|-RVA: 0x2AAB968 Offset: 0x2AA7968 VA: 0x2AAB968
	|-LinkedList<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7C08 Offset: 0x2AA3C08 VA: 0x2AA7C08
	|-LinkedList<ValueTuple<object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AA8F08 Offset: 0x2AA4F08 VA: 0x2AA8F08
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AAA15C Offset: 0x2AA615C VA: 0x2AAA15C
	|-LinkedList<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2AABA18 Offset: 0x2AA7A18 VA: 0x2AABA18
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7C78 Offset: 0x2AA3C78 VA: 0x2AA7C78
	|-LinkedList<ValueTuple<object, object>>.Remove
	|
	|-RVA: 0x2AA8F8C Offset: 0x2AA4F8C VA: 0x2AA8F8C
	|-LinkedList<ValueTuple<object, object, object>>.Remove
	|
	|-RVA: 0x2AAA1D0 Offset: 0x2AA61D0 VA: 0x2AAA1D0
	|-LinkedList<object>.Remove
	|
	|-RVA: 0x2AABABC Offset: 0x2AA7ABC VA: 0x2AABABC
	|-LinkedList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Remove(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7CCC Offset: 0x2AA3CCC VA: 0x2AA7CCC
	|-LinkedList<ValueTuple<object, object>>.Remove
	|
	|-RVA: 0x2AA9004 Offset: 0x2AA5004 VA: 0x2AA9004
	|-LinkedList<ValueTuple<object, object, object>>.Remove
	|
	|-RVA: 0x2AAA224 Offset: 0x2AA6224 VA: 0x2AAA224
	|-LinkedList<object>.Remove
	|
	|-RVA: 0x2AABBB4 Offset: 0x2AA7BB4 VA: 0x2AABBB4
	|-LinkedList<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void RemoveFirst() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7D10 Offset: 0x2AA3D10 VA: 0x2AA7D10
	|-LinkedList<ValueTuple<object, object>>.RemoveFirst
	|
	|-RVA: 0x2AA9048 Offset: 0x2AA5048 VA: 0x2AA9048
	|-LinkedList<ValueTuple<object, object, object>>.RemoveFirst
	|
	|-RVA: 0x2AAA268 Offset: 0x2AA6268 VA: 0x2AAA268
	|-LinkedList<object>.RemoveFirst
	|
	|-RVA: 0x2AABC00 Offset: 0x2AA7C00 VA: 0x2AABC00
	|-LinkedList<__Il2CppFullySharedGenericType>.RemoveFirst
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7D7C Offset: 0x2AA3D7C VA: 0x2AA7D7C
	|-LinkedList<ValueTuple<object, object>>.GetObjectData
	|
	|-RVA: 0x2AA90B4 Offset: 0x2AA50B4 VA: 0x2AA90B4
	|-LinkedList<ValueTuple<object, object, object>>.GetObjectData
	|
	|-RVA: 0x2AAA2D4 Offset: 0x2AA62D4 VA: 0x2AAA2D4
	|-LinkedList<object>.GetObjectData
	|
	|-RVA: 0x2AABC70 Offset: 0x2AA7C70 VA: 0x2AABC70
	|-LinkedList<__Il2CppFullySharedGenericType>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7F10 Offset: 0x2AA3F10 VA: 0x2AA7F10
	|-LinkedList<ValueTuple<object, object>>.OnDeserialization
	|
	|-RVA: 0x2AA9248 Offset: 0x2AA5248 VA: 0x2AA9248
	|-LinkedList<ValueTuple<object, object, object>>.OnDeserialization
	|
	|-RVA: 0x2AAA468 Offset: 0x2AA6468 VA: 0x2AAA468
	|-LinkedList<object>.OnDeserialization
	|
	|-RVA: 0x2AABE08 Offset: 0x2AA7E08 VA: 0x2AABE08
	|-LinkedList<__Il2CppFullySharedGenericType>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA812C Offset: 0x2AA412C VA: 0x2AA812C
	|-LinkedList<ValueTuple<object, object>>.InternalInsertNodeBefore
	|
	|-RVA: 0x2AA9484 Offset: 0x2AA5484 VA: 0x2AA9484
	|-LinkedList<ValueTuple<object, object, object>>.InternalInsertNodeBefore
	|
	|-RVA: 0x2AAA680 Offset: 0x2AA6680 VA: 0x2AAA680
	|-LinkedList<object>.InternalInsertNodeBefore
	|
	|-RVA: 0x2AAC0B0 Offset: 0x2AA80B0 VA: 0x2AAC0B0
	|-LinkedList<__Il2CppFullySharedGenericType>.InternalInsertNodeBefore
	*/

	// RVA: -1 Offset: -1
	private void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA81A8 Offset: 0x2AA41A8 VA: 0x2AA81A8
	|-LinkedList<ValueTuple<object, object>>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x2AA9500 Offset: 0x2AA5500 VA: 0x2AA9500
	|-LinkedList<ValueTuple<object, object, object>>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x2AAA6FC Offset: 0x2AA66FC VA: 0x2AAA6FC
	|-LinkedList<object>.InternalInsertNodeToEmptyList
	|
	|-RVA: 0x2AAC1B4 Offset: 0x2AA81B4 VA: 0x2AAC1B4
	|-LinkedList<__Il2CppFullySharedGenericType>.InternalInsertNodeToEmptyList
	*/

	// RVA: -1 Offset: -1
	internal void InternalRemoveNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA8208 Offset: 0x2AA4208 VA: 0x2AA8208
	|-LinkedList<ValueTuple<object, object>>.InternalRemoveNode
	|
	|-RVA: 0x2AA9560 Offset: 0x2AA5560 VA: 0x2AA9560
	|-LinkedList<ValueTuple<object, object, object>>.InternalRemoveNode
	|
	|-RVA: 0x2AAA75C Offset: 0x2AA675C VA: 0x2AAA75C
	|-LinkedList<object>.InternalRemoveNode
	|
	|-RVA: 0x2AAC23C Offset: 0x2AA823C VA: 0x2AAC23C
	|-LinkedList<__Il2CppFullySharedGenericType>.InternalRemoveNode
	*/

	// RVA: -1 Offset: -1
	internal void ValidateNewNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA82A4 Offset: 0x2AA42A4 VA: 0x2AA82A4
	|-LinkedList<ValueTuple<object, object>>.ValidateNewNode
	|
	|-RVA: 0x2AA95FC Offset: 0x2AA55FC VA: 0x2AA95FC
	|-LinkedList<ValueTuple<object, object, object>>.ValidateNewNode
	|
	|-RVA: 0x2AAA7F8 Offset: 0x2AA67F8 VA: 0x2AAA7F8
	|-LinkedList<object>.ValidateNewNode
	|
	|-RVA: 0x2AAC3CC Offset: 0x2AA83CC VA: 0x2AAC3CC
	|-LinkedList<__Il2CppFullySharedGenericType>.ValidateNewNode
	*/

	// RVA: -1 Offset: -1
	internal void ValidateNode(LinkedListNode<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA833C Offset: 0x2AA433C VA: 0x2AA833C
	|-LinkedList<ValueTuple<object, object>>.ValidateNode
	|
	|-RVA: 0x2AA9694 Offset: 0x2AA5694 VA: 0x2AA9694
	|-LinkedList<ValueTuple<object, object, object>>.ValidateNode
	|
	|-RVA: 0x2AAA890 Offset: 0x2AA6890 VA: 0x2AAA890
	|-LinkedList<object>.ValidateNode
	|
	|-RVA: 0x2AAC47C Offset: 0x2AA847C VA: 0x2AAC47C
	|-LinkedList<__Il2CppFullySharedGenericType>.ValidateNode
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA83D8 Offset: 0x2AA43D8 VA: 0x2AA83D8
	|-LinkedList<ValueTuple<object, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AA9730 Offset: 0x2AA5730 VA: 0x2AA9730
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AAA92C Offset: 0x2AA692C VA: 0x2AAA92C
	|-LinkedList<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2AAC534 Offset: 0x2AA8534 VA: 0x2AAC534
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA83E0 Offset: 0x2AA43E0 VA: 0x2AA83E0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AA9738 Offset: 0x2AA5738 VA: 0x2AA9738
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AAA934 Offset: 0x2AA6934 VA: 0x2AAA934
	|-LinkedList<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2AAC53C Offset: 0x2AA853C VA: 0x2AAC53C
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA8450 Offset: 0x2AA4450 VA: 0x2AA8450
	|-LinkedList<ValueTuple<object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AA97A8 Offset: 0x2AA57A8 VA: 0x2AA97A8
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AAA9A4 Offset: 0x2AA69A4 VA: 0x2AAA9A4
	|-LinkedList<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2AAC5AC Offset: 0x2AA85AC VA: 0x2AAC5AC
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA87D0 Offset: 0x2AA47D0 VA: 0x2AA87D0
	|-LinkedList<ValueTuple<object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AA9B30 Offset: 0x2AA5B30 VA: 0x2AA9B30
	|-LinkedList<ValueTuple<object, object, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AAACFC Offset: 0x2AA6CFC VA: 0x2AAACFC
	|-LinkedList<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2AAC9CC Offset: 0x2AA89CC VA: 0x2AAC9CC
	|-LinkedList<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

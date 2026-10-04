// Assembly: System.dll
// Namespace: System.Collections.Generic
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[Serializable]
public class SortedSet<T> : ISet<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback // TypeDefIndex: 14333
{
	// Fields
	private SortedSet.Node<T> root; // 0x0
	private IComparer<T> comparer; // 0x0
	private int count; // 0x0
	private int version; // 0x0
	private object _syncRoot; // 0x0
	private SerializationInfo siInfo; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C95FC4 Offset: 0x2C91FC4 VA: 0x2C95FC4
	|-SortedSet<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2C97A00 Offset: 0x2C93A00 VA: 0x2C97A00
	|-SortedSet<KeyValuePair<double, int>>..ctor
	|
	|-RVA: 0x2C9943C Offset: 0x2C9543C VA: 0x2C9943C
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C96004 Offset: 0x2C92004 VA: 0x2C96004
	|-SortedSet<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2C97A40 Offset: 0x2C93A40 VA: 0x2C97A40
	|-SortedSet<KeyValuePair<double, int>>..ctor
	|
	|-RVA: 0x2C99480 Offset: 0x2C95480 VA: 0x2C99480
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C96058 Offset: 0x2C92058 VA: 0x2C96058
	|-SortedSet<KeyValuePair<byte, object>>..ctor
	|
	|-RVA: 0x2C97A94 Offset: 0x2C93A94 VA: 0x2C97A94
	|-SortedSet<KeyValuePair<double, int>>..ctor
	|
	|-RVA: 0x2C994D8 Offset: 0x2C954D8 VA: 0x2C994D8
	|-SortedSet<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 20
	internal virtual bool InOrderTreeWalk(TreeWalkPredicate<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C96088 Offset: 0x2C92088 VA: 0x2C96088
	|-SortedSet<KeyValuePair<byte, object>>.InOrderTreeWalk
	|
	|-RVA: 0x2C97AC4 Offset: 0x2C93AC4 VA: 0x2C97AC4
	|-SortedSet<KeyValuePair<double, int>>.InOrderTreeWalk
	|
	|-RVA: 0x2C99508 Offset: 0x2C95508 VA: 0x2C99508
	|-SortedSet<__Il2CppFullySharedGenericType>.InOrderTreeWalk
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C961D8 Offset: 0x2C921D8 VA: 0x2C961D8
	|-SortedSet<KeyValuePair<byte, object>>.get_Count
	|
	|-RVA: 0x2C97C14 Offset: 0x2C93C14 VA: 0x2C97C14
	|-SortedSet<KeyValuePair<double, int>>.get_Count
	|
	|-RVA: 0x2C99710 Offset: 0x2C95710 VA: 0x2C99710
	|-SortedSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C961FC Offset: 0x2C921FC VA: 0x2C961FC
	|-SortedSet<KeyValuePair<byte, object>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C97C38 Offset: 0x2C93C38 VA: 0x2C97C38
	|-SortedSet<KeyValuePair<double, int>>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C99734 Offset: 0x2C95734 VA: 0x2C99734
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C96204 Offset: 0x2C92204 VA: 0x2C96204
	|-SortedSet<KeyValuePair<byte, object>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C97C40 Offset: 0x2C93C40 VA: 0x2C97C40
	|-SortedSet<KeyValuePair<double, int>>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C9973C Offset: 0x2C9573C VA: 0x2C9973C
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9620C Offset: 0x2C9220C VA: 0x2C9620C
	|-SortedSet<KeyValuePair<byte, object>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C97C48 Offset: 0x2C93C48 VA: 0x2C97C48
	|-SortedSet<KeyValuePair<double, int>>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C99744 Offset: 0x2C95744 VA: 0x2C99744
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 21
	internal virtual void VersionCheck() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C96280 Offset: 0x2C92280 VA: 0x2C96280
	|-SortedSet<KeyValuePair<byte, object>>.VersionCheck
	|
	|-RVA: 0x2C97CBC Offset: 0x2C93CBC VA: 0x2C97CBC
	|-SortedSet<KeyValuePair<double, int>>.VersionCheck
	|
	|-RVA: 0x2C997B8 Offset: 0x2C957B8 VA: 0x2C997B8
	|-SortedSet<__Il2CppFullySharedGenericType>.VersionCheck
	*/

	// RVA: -1 Offset: -1 Slot: 22
	internal virtual bool IsWithinRange(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C96284 Offset: 0x2C92284 VA: 0x2C96284
	|-SortedSet<KeyValuePair<byte, object>>.IsWithinRange
	|
	|-RVA: 0x2C97CC0 Offset: 0x2C93CC0 VA: 0x2C97CC0
	|-SortedSet<KeyValuePair<double, int>>.IsWithinRange
	|
	|-RVA: 0x2C997BC Offset: 0x2C957BC VA: 0x2C997BC
	|-SortedSet<__Il2CppFullySharedGenericType>.IsWithinRange
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9628C Offset: 0x2C9228C VA: 0x2C9628C
	|-SortedSet<KeyValuePair<byte, object>>.Add
	|
	|-RVA: 0x2C97CC8 Offset: 0x2C93CC8 VA: 0x2C97CC8
	|-SortedSet<KeyValuePair<double, int>>.Add
	|
	|-RVA: 0x2C997C4 Offset: 0x2C957C4 VA: 0x2C997C4
	|-SortedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<T>.Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9629C Offset: 0x2C9229C VA: 0x2C9629C
	|-SortedSet<KeyValuePair<byte, object>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C97CD8 Offset: 0x2C93CD8 VA: 0x2C97CD8
	|-SortedSet<KeyValuePair<double, int>>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x2C99890 Offset: 0x2C95890 VA: 0x2C99890
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 24
	internal virtual bool AddIfNotPresent(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C962AC Offset: 0x2C922AC VA: 0x2C962AC
	|-SortedSet<KeyValuePair<byte, object>>.AddIfNotPresent
	|
	|-RVA: 0x2C97CE8 Offset: 0x2C93CE8 VA: 0x2C97CE8
	|-SortedSet<KeyValuePair<double, int>>.AddIfNotPresent
	|
	|-RVA: 0x2C99950 Offset: 0x2C95950 VA: 0x2C99950
	|-SortedSet<__Il2CppFullySharedGenericType>.AddIfNotPresent
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9659C Offset: 0x2C9259C VA: 0x2C9659C
	|-SortedSet<KeyValuePair<byte, object>>.Remove
	|
	|-RVA: 0x2C97FD8 Offset: 0x2C93FD8 VA: 0x2C97FD8
	|-SortedSet<KeyValuePair<double, int>>.Remove
	|
	|-RVA: 0x2C99DF4 Offset: 0x2C95DF4 VA: 0x2C99DF4
	|-SortedSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 25
	internal virtual bool DoRemove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C965AC Offset: 0x2C925AC VA: 0x2C965AC
	|-SortedSet<KeyValuePair<byte, object>>.DoRemove
	|
	|-RVA: 0x2C97FE8 Offset: 0x2C93FE8 VA: 0x2C97FE8
	|-SortedSet<KeyValuePair<double, int>>.DoRemove
	|
	|-RVA: 0x2C99EC0 Offset: 0x2C95EC0 VA: 0x2C99EC0
	|-SortedSet<__Il2CppFullySharedGenericType>.DoRemove
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C96920 Offset: 0x2C92920 VA: 0x2C96920
	|-SortedSet<KeyValuePair<byte, object>>.Clear
	|
	|-RVA: 0x2C9835C Offset: 0x2C9435C VA: 0x2C9835C
	|-SortedSet<KeyValuePair<double, int>>.Clear
	|
	|-RVA: 0x2C9A3B8 Offset: 0x2C963B8 VA: 0x2C9A3B8
	|-SortedSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public virtual bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9694C Offset: 0x2C9294C VA: 0x2C9694C
	|-SortedSet<KeyValuePair<byte, object>>.Contains
	|
	|-RVA: 0x2C98388 Offset: 0x2C94388 VA: 0x2C98388
	|-SortedSet<KeyValuePair<double, int>>.Contains
	|
	|-RVA: 0x2C9A3E4 Offset: 0x2C963E4 VA: 0x2C9A3E4
	|-SortedSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C96970 Offset: 0x2C92970 VA: 0x2C96970
	|-SortedSet<KeyValuePair<byte, object>>.CopyTo
	|
	|-RVA: 0x2C983AC Offset: 0x2C943AC VA: 0x2C983AC
	|-SortedSet<KeyValuePair<double, int>>.CopyTo
	|
	|-RVA: 0x2C9A4B0 Offset: 0x2C964B0 VA: 0x2C9A4B0
	|-SortedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(T[] array, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C969CC Offset: 0x2C929CC VA: 0x2C969CC
	|-SortedSet<KeyValuePair<byte, object>>.CopyTo
	|
	|-RVA: 0x2C98408 Offset: 0x2C94408 VA: 0x2C98408
	|-SortedSet<KeyValuePair<double, int>>.CopyTo
	|
	|-RVA: 0x2C9A510 Offset: 0x2C96510 VA: 0x2C9A510
	|-SortedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C96C04 Offset: 0x2C92C04 VA: 0x2C96C04
	|-SortedSet<KeyValuePair<byte, object>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C98640 Offset: 0x2C94640 VA: 0x2C98640
	|-SortedSet<KeyValuePair<double, int>>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C9A750 Offset: 0x2C96750 VA: 0x2C9A750
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1
	public SortedSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C96FF0 Offset: 0x2C92FF0 VA: 0x2C96FF0
	|-SortedSet<KeyValuePair<byte, object>>.GetEnumerator
	|
	|-RVA: 0x2C98A2C Offset: 0x2C94A2C VA: 0x2C98A2C
	|-SortedSet<KeyValuePair<double, int>>.GetEnumerator
	|
	|-RVA: 0x2C9AB1C Offset: 0x2C96B1C VA: 0x2C9AB1C
	|-SortedSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C97014 Offset: 0x2C93014 VA: 0x2C97014
	|-SortedSet<KeyValuePair<byte, object>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2C98A50 Offset: 0x2C94A50 VA: 0x2C98A50
	|-SortedSet<KeyValuePair<double, int>>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2C9AB40 Offset: 0x2C96B40 VA: 0x2C9AB40
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C97088 Offset: 0x2C93088 VA: 0x2C97088
	|-SortedSet<KeyValuePair<byte, object>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C98AC4 Offset: 0x2C94AC4 VA: 0x2C98AC4
	|-SortedSet<KeyValuePair<double, int>>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C9AB9C Offset: 0x2C96B9C VA: 0x2C9AB9C
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void InsertionBalance(SortedSet.Node<T> current, ref SortedSet.Node<T> parent, SortedSet.Node<T> grandParent, SortedSet.Node<T> greatGrandParent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C970FC Offset: 0x2C930FC VA: 0x2C970FC
	|-SortedSet<KeyValuePair<byte, object>>.InsertionBalance
	|
	|-RVA: 0x2C98B38 Offset: 0x2C94B38 VA: 0x2C98B38
	|-SortedSet<KeyValuePair<double, int>>.InsertionBalance
	|
	|-RVA: 0x2C9ABF8 Offset: 0x2C96BF8 VA: 0x2C9ABF8
	|-SortedSet<__Il2CppFullySharedGenericType>.InsertionBalance
	*/

	// RVA: -1 Offset: -1
	private void ReplaceChildOrRoot(SortedSet.Node<T> parent, SortedSet.Node<T> child, SortedSet.Node<T> newChild) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C97218 Offset: 0x2C93218 VA: 0x2C97218
	|-SortedSet<KeyValuePair<byte, object>>.ReplaceChildOrRoot
	|
	|-RVA: 0x2C98C54 Offset: 0x2C94C54 VA: 0x2C98C54
	|-SortedSet<KeyValuePair<double, int>>.ReplaceChildOrRoot
	|
	|-RVA: 0x2C9AD50 Offset: 0x2C96D50 VA: 0x2C9AD50
	|-SortedSet<__Il2CppFullySharedGenericType>.ReplaceChildOrRoot
	*/

	// RVA: -1 Offset: -1
	private void ReplaceNode(SortedSet.Node<T> match, SortedSet.Node<T> parentOfMatch, SortedSet.Node<T> successor, SortedSet.Node<T> parentOfSuccessor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C97248 Offset: 0x2C93248 VA: 0x2C97248
	|-SortedSet<KeyValuePair<byte, object>>.ReplaceNode
	|
	|-RVA: 0x2C98C84 Offset: 0x2C94C84 VA: 0x2C98C84
	|-SortedSet<KeyValuePair<double, int>>.ReplaceNode
	|
	|-RVA: 0x2C9AD84 Offset: 0x2C96D84 VA: 0x2C9AD84
	|-SortedSet<__Il2CppFullySharedGenericType>.ReplaceNode
	*/

	// RVA: -1 Offset: -1 Slot: 28
	internal virtual SortedSet.Node<T> FindNode(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C97330 Offset: 0x2C93330 VA: 0x2C97330
	|-SortedSet<KeyValuePair<byte, object>>.FindNode
	|
	|-RVA: 0x2C98D6C Offset: 0x2C94D6C VA: 0x2C98D6C
	|-SortedSet<KeyValuePair<double, int>>.FindNode
	|
	|-RVA: 0x2C9AF34 Offset: 0x2C96F34 VA: 0x2C9AF34
	|-SortedSet<__Il2CppFullySharedGenericType>.FindNode
	*/

	// RVA: -1 Offset: -1
	internal void UpdateVersion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C97430 Offset: 0x2C93430 VA: 0x2C97430
	|-SortedSet<KeyValuePair<byte, object>>.UpdateVersion
	|
	|-RVA: 0x2C98E6C Offset: 0x2C94E6C VA: 0x2C98E6C
	|-SortedSet<KeyValuePair<double, int>>.UpdateVersion
	|
	|-RVA: 0x2C9B120 Offset: 0x2C97120 VA: 0x2C9B120
	|-SortedSet<__Il2CppFullySharedGenericType>.UpdateVersion
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C97440 Offset: 0x2C93440 VA: 0x2C97440
	|-SortedSet<KeyValuePair<byte, object>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x2C98E7C Offset: 0x2C94E7C VA: 0x2C98E7C
	|-SortedSet<KeyValuePair<double, int>>.System.Runtime.Serialization.ISerializable.GetObjectData
	|
	|-RVA: 0x2C9B130 Offset: 0x2C97130 VA: 0x2C9B130
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.ISerializable.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C97450 Offset: 0x2C93450 VA: 0x2C97450
	|-SortedSet<KeyValuePair<byte, object>>.GetObjectData
	|
	|-RVA: 0x2C98E8C Offset: 0x2C94E8C VA: 0x2C98E8C
	|-SortedSet<KeyValuePair<double, int>>.GetObjectData
	|
	|-RVA: 0x2C9B140 Offset: 0x2C97140 VA: 0x2C9B140
	|-SortedSet<__Il2CppFullySharedGenericType>.GetObjectData
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C97684 Offset: 0x2C93684 VA: 0x2C97684
	|-SortedSet<KeyValuePair<byte, object>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x2C990C0 Offset: 0x2C950C0 VA: 0x2C990C0
	|-SortedSet<KeyValuePair<double, int>>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	|
	|-RVA: 0x2C9B364 Offset: 0x2C97364 VA: 0x2C9B364
	|-SortedSet<__Il2CppFullySharedGenericType>.System.Runtime.Serialization.IDeserializationCallback.OnDeserialization
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected virtual void OnDeserialization(object sender) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C97694 Offset: 0x2C93694 VA: 0x2C97694
	|-SortedSet<KeyValuePair<byte, object>>.OnDeserialization
	|
	|-RVA: 0x2C990D0 Offset: 0x2C950D0 VA: 0x2C990D0
	|-SortedSet<KeyValuePair<double, int>>.OnDeserialization
	|
	|-RVA: 0x2C9B374 Offset: 0x2C97374 VA: 0x2C9B374
	|-SortedSet<__Il2CppFullySharedGenericType>.OnDeserialization
	*/

	// RVA: -1 Offset: -1
	private static int Log2(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C979D8 Offset: 0x2C939D8 VA: 0x2C979D8
	|-SortedSet<KeyValuePair<byte, object>>.Log2
	|
	|-RVA: 0x2C99414 Offset: 0x2C95414 VA: 0x2C99414
	|-SortedSet<KeyValuePair<double, int>>.Log2
	|
	|-RVA: 0x2C9B73C Offset: 0x2C9773C VA: 0x2C9B73C
	|-SortedSet<__Il2CppFullySharedGenericType>.Log2
	*/
}

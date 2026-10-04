// Assembly: mscorlib.dll
// Namespace: System.Collections.Concurrent
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView<K, V>))]
[Serializable]
public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 10913
{
	// Fields
	private ConcurrentDictionary.Tables<TKey, TValue> _tables; // 0x0
	private IEqualityComparer<TKey> _comparer; // 0x0
	private readonly bool _growLockArray; // 0x0
	private int _budget; // 0x0
	private KeyValuePair<TKey, TValue>[] _serializationArray; // 0x0
	private int _serializationConcurrencyLevel; // 0x0
	private int _serializationCapacity; // 0x0
	private static readonly bool s_isValueWriteAtomic; // 0x0

	// Properties
	public TValue Item { get; set; }
	public int Count { get; }
	public ICollection<TKey> Keys { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public ICollection<TValue> Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private static int DefaultConcurrencyLevel { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static bool IsValueWriteAtomic() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB34D4 Offset: 0x2DAF4D4 VA: 0x2DB34D4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.IsValueWriteAtomic
	|
	|-RVA: 0x2DB7D3C Offset: 0x2DB3D3C VA: 0x2DB7D3C
	|-ConcurrentDictionary<object, object>.IsValueWriteAtomic
	|
	|-RVA: 0x2DBC5D0 Offset: 0x2DB85D0 VA: 0x2DBC5D0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsValueWriteAtomic
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB35C8 Offset: 0x2DAF5C8 VA: 0x2DB35C8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x2DB7E30 Offset: 0x2DB3E30 VA: 0x2DB7E30
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0x2DBC6C4 Offset: 0x2DB86C4 VA: 0x2DBC6C4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB3638 Offset: 0x2DAF638 VA: 0x2DB3638
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x2DB7EA0 Offset: 0x2DB3EA0 VA: 0x2DB7EA0
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0x2DBC748 Offset: 0x2DB8748 VA: 0x2DBC748
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB36AC Offset: 0x2DAF6AC VA: 0x2DB36AC
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.InitializeFromCollection
	|
	|-RVA: 0x2DB7F14 Offset: 0x2DB3F14 VA: 0x2DB7F14
	|-ConcurrentDictionary<object, object>.InitializeFromCollection
	|
	|-RVA: 0x2DBC7D0 Offset: 0x2DB87D0 VA: 0x2DBC7D0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InitializeFromCollection
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB3B08 Offset: 0x2DAFB08 VA: 0x2DB3B08
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x2DB838C Offset: 0x2DB438C VA: 0x2DB838C
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0x2DBCE88 Offset: 0x2DB8E88 VA: 0x2DBCE88
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB3DC0 Offset: 0x2DAFDC0 VA: 0x2DB3DC0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryAdd
	|
	|-RVA: 0x2DB8644 Offset: 0x2DB4644 VA: 0x2DB8644
	|-ConcurrentDictionary<object, object>.TryAdd
	|
	|-RVA: 0x2DBD148 Offset: 0x2DB9148 VA: 0x2DBD148
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB3EC4 Offset: 0x2DAFEC4 VA: 0x2DB3EC4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ContainsKey
	|
	|-RVA: 0x2DB876C Offset: 0x2DB476C VA: 0x2DB876C
	|-ConcurrentDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x2DBD434 Offset: 0x2DB9434 VA: 0x2DBD434
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool TryRemove(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB3EEC Offset: 0x2DAFEEC VA: 0x2DB3EEC
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryRemove
	|
	|-RVA: 0x2DB87D0 Offset: 0x2DB47D0 VA: 0x2DB87D0
	|-ConcurrentDictionary<object, object>.TryRemove
	|
	|-RVA: 0x2DBD5C4 Offset: 0x2DB95C4 VA: 0x2DBD5C4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryRemove
	*/

	// RVA: -1 Offset: -1
	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB3F04 Offset: 0x2DAFF04 VA: 0x2DB3F04
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryRemoveInternal
	|
	|-RVA: 0x2DB8828 Offset: 0x2DB4828 VA: 0x2DB8828
	|-ConcurrentDictionary<object, object>.TryRemoveInternal
	|
	|-RVA: 0x2DBD798 Offset: 0x2DB9798 VA: 0x2DBD798
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryRemoveInternal
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB43B0 Offset: 0x2DB03B0 VA: 0x2DB43B0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryGetValue
	|
	|-RVA: 0x2DB8CC8 Offset: 0x2DB4CC8 VA: 0x2DB8CC8
	|-ConcurrentDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x2DBDF2C Offset: 0x2DB9F2C VA: 0x2DBDF2C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB4494 Offset: 0x2DB0494 VA: 0x2DB4494
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryGetValueInternal
	|
	|-RVA: 0x2DB8DD0 Offset: 0x2DB4DD0 VA: 0x2DB8DD0
	|-ConcurrentDictionary<object, object>.TryGetValueInternal
	|
	|-RVA: 0x2DBE17C Offset: 0x2DBA17C VA: 0x2DBE17C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValueInternal
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB461C Offset: 0x2DB061C VA: 0x2DB461C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.Clear
	|
	|-RVA: 0x2DB8F44 Offset: 0x2DB4F44 VA: 0x2DB8F44
	|-ConcurrentDictionary<object, object>.Clear
	|
	|-RVA: 0x2DBE4B0 Offset: 0x2DBA4B0 VA: 0x2DBE4B0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB4858 Offset: 0x2DB0858 VA: 0x2DB4858
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DB9180 Offset: 0x2DB5180 VA: 0x2DB9180
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x2DBE70C Offset: 0x2DBA70C VA: 0x2DBE70C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<TKey, TValue>[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB4AC0 Offset: 0x2DB0AC0 VA: 0x2DB4AC0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ToArray
	|
	|-RVA: 0x2DB93E8 Offset: 0x2DB53E8 VA: 0x2DB93E8
	|-ConcurrentDictionary<object, object>.ToArray
	|
	|-RVA: 0x2DBE994 Offset: 0x2DBA994 VA: 0x2DBE994
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB4CD0 Offset: 0x2DB0CD0 VA: 0x2DB4CD0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToPairs
	|
	|-RVA: 0x2DB95F8 Offset: 0x2DB55F8 VA: 0x2DB95F8
	|-ConcurrentDictionary<object, object>.CopyToPairs
	|
	|-RVA: 0x2DBEB84 Offset: 0x2DBAB84 VA: 0x2DBEB84
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToPairs
	*/

	// RVA: -1 Offset: -1
	private void CopyToEntries(DictionaryEntry[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB4DD8 Offset: 0x2DB0DD8 VA: 0x2DB4DD8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToEntries
	|
	|-RVA: 0x2DB96D8 Offset: 0x2DB56D8 VA: 0x2DB96D8
	|-ConcurrentDictionary<object, object>.CopyToEntries
	|
	|-RVA: 0x2DBEE6C Offset: 0x2DBAE6C VA: 0x2DBEE6C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToEntries
	*/

	// RVA: -1 Offset: -1
	private void CopyToObjects(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB4ED0 Offset: 0x2DB0ED0 VA: 0x2DB4ED0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToObjects
	|
	|-RVA: 0x2DB97A4 Offset: 0x2DB57A4 VA: 0x2DB97A4
	|-ConcurrentDictionary<object, object>.CopyToObjects
	|
	|-RVA: 0x2DBF068 Offset: 0x2DBB068 VA: 0x2DBF068
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToObjects
	*/

	[IteratorStateMachine(typeof(ConcurrentDictionary.<GetEnumerator>d__35<TKey, TValue>))]
	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB4FFC Offset: 0x2DB0FFC VA: 0x2DB4FFC
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetEnumerator
	|
	|-RVA: 0x2DB98C0 Offset: 0x2DB58C0 VA: 0x2DB98C0
	|-ConcurrentDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x2DBF328 Offset: 0x2DBB328 VA: 0x2DBF328
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5074 Offset: 0x2DB1074 VA: 0x2DB5074
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryAddInternal
	|
	|-RVA: 0x2DB9938 Offset: 0x2DB5938 VA: 0x2DB9938
	|-ConcurrentDictionary<object, object>.TryAddInternal
	|
	|-RVA: 0x2DBF3B4 Offset: 0x2DBB3B4 VA: 0x2DBF3B4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAddInternal
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB56A0 Offset: 0x2DB16A0 VA: 0x2DB56A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Item
	|
	|-RVA: 0x2DB9F34 Offset: 0x2DB5F34 VA: 0x2DB9F34
	|-ConcurrentDictionary<object, object>.get_Item
	|
	|-RVA: 0x2DBFDC0 Offset: 0x2DBBDC0 VA: 0x2DBFDC0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5730 Offset: 0x2DB1730 VA: 0x2DB5730
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.set_Item
	|
	|-RVA: 0x2DB9F98 Offset: 0x2DB5F98 VA: 0x2DB9F98
	|-ConcurrentDictionary<object, object>.set_Item
	|
	|-RVA: 0x2DBFF98 Offset: 0x2DBBF98 VA: 0x2DBFF98
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNotFoundException(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5830 Offset: 0x2DB1830 VA: 0x2DB5830
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ThrowKeyNotFoundException
	|
	|-RVA: 0x2DBA0BC Offset: 0x2DB60BC VA: 0x2DBA0BC
	|-ConcurrentDictionary<object, object>.ThrowKeyNotFoundException
	|
	|-RVA: 0x2DC0278 Offset: 0x2DBC278 VA: 0x2DC0278
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowKeyNotFoundException
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNullException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB58A0 Offset: 0x2DB18A0 VA: 0x2DB58A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ThrowKeyNullException
	|
	|-RVA: 0x2DBA12C Offset: 0x2DB612C VA: 0x2DBA12C
	|-ConcurrentDictionary<object, object>.ThrowKeyNullException
	|
	|-RVA: 0x2DC02E8 Offset: 0x2DBC2E8 VA: 0x2DC02E8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowKeyNullException
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB58E8 Offset: 0x2DB18E8 VA: 0x2DB58E8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Count
	|
	|-RVA: 0x2DBA174 Offset: 0x2DB6174 VA: 0x2DBA174
	|-ConcurrentDictionary<object, object>.get_Count
	|
	|-RVA: 0x2DC0330 Offset: 0x2DBC330 VA: 0x2DC0330
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	private int GetCountInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB59B4 Offset: 0x2DB19B4 VA: 0x2DB59B4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetCountInternal
	|
	|-RVA: 0x2DBA240 Offset: 0x2DB6240 VA: 0x2DBA240
	|-ConcurrentDictionary<object, object>.GetCountInternal
	|
	|-RVA: 0x2DC042C Offset: 0x2DBC42C VA: 0x2DC042C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetCountInternal
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5A4C Offset: 0x2DB1A4C VA: 0x2DB5A4C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetOrAdd
	|
	|-RVA: 0x2DBA2D8 Offset: 0x2DB62D8 VA: 0x2DBA2D8
	|-ConcurrentDictionary<object, object>.GetOrAdd
	|
	|-RVA: 0x2DC04C4 Offset: 0x2DBC4C4 VA: 0x2DC04C4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetOrAdd
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5BD0 Offset: 0x2DB1BD0 VA: 0x2DB5BD0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetOrAdd
	|
	|-RVA: 0x2DBA47C Offset: 0x2DB647C VA: 0x2DBA47C
	|-ConcurrentDictionary<object, object>.GetOrAdd
	|
	|-RVA: 0x2DC08C8 Offset: 0x2DBC8C8 VA: 0x2DC08C8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetOrAdd
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5CFC Offset: 0x2DB1CFC VA: 0x2DB5CFC
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x2DBA5CC Offset: 0x2DB65CC VA: 0x2DBA5CC
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x2DC0C44 Offset: 0x2DBCC44 VA: 0x2DC0C44
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5D64 Offset: 0x2DB1D64 VA: 0x2DB5D64
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0x2DBA634 Offset: 0x2DB6634 VA: 0x2DBA634
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0x2DC0DB0 Offset: 0x2DBCDB0 VA: 0x2DC0DB0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5DA0 Offset: 0x2DB1DA0 VA: 0x2DB5DA0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Keys
	|
	|-RVA: 0x2DBA65C Offset: 0x2DB665C VA: 0x2DBA65C
	|-ConcurrentDictionary<object, object>.get_Keys
	|
	|-RVA: 0x2DC0EC4 Offset: 0x2DBCEC4 VA: 0x2DC0EC4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 38
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5DB0 Offset: 0x2DB1DB0 VA: 0x2DB5DB0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DBA66C Offset: 0x2DB666C VA: 0x2DBA66C
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2DC0ED8 Offset: 0x2DBCED8 VA: 0x2DC0ED8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5DC0 Offset: 0x2DB1DC0 VA: 0x2DB5DC0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Values
	|
	|-RVA: 0x2DBA67C Offset: 0x2DB667C VA: 0x2DBA67C
	|-ConcurrentDictionary<object, object>.get_Values
	|
	|-RVA: 0x2DC0EEC Offset: 0x2DBCEEC VA: 0x2DC0EEC
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5DD0 Offset: 0x2DB1DD0 VA: 0x2DB5DD0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x2DBA68C Offset: 0x2DB668C VA: 0x2DBA68C
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x2DC0F00 Offset: 0x2DBCF00 VA: 0x2DC0F00
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5DE0 Offset: 0x2DB1DE0 VA: 0x2DB5DE0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DBA69C Offset: 0x2DB669C VA: 0x2DBA69C
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2DC0F14 Offset: 0x2DBCF14 VA: 0x2DC0F14
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5E94 Offset: 0x2DB1E94 VA: 0x2DB5E94
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DBA740 Offset: 0x2DB6740 VA: 0x2DBA740
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2DC10B0 Offset: 0x2DBD0B0 VA: 0x2DC10B0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5F0C Offset: 0x2DB1F0C VA: 0x2DB5F0C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DBA7B0 Offset: 0x2DB67B0 VA: 0x2DBA7B0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2DC1290 Offset: 0x2DBD290 VA: 0x2DC1290
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5F14 Offset: 0x2DB1F14 VA: 0x2DB5F14
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DBA7B8 Offset: 0x2DB67B8 VA: 0x2DBA7B8
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2DC1298 Offset: 0x2DBD298 VA: 0x2DC1298
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5F4C Offset: 0x2DB1F4C VA: 0x2DB5F4C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DBA850 Offset: 0x2DB6850 VA: 0x2DBA850
	|-ConcurrentDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2DC1494 Offset: 0x2DBD494 VA: 0x2DC1494
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB5F5C Offset: 0x2DB1F5C VA: 0x2DB5F5C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DBA860 Offset: 0x2DB6860 VA: 0x2DBA860
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2DC14A8 Offset: 0x2DBD4A8 VA: 0x2DC14A8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB61D0 Offset: 0x2DB21D0 VA: 0x2DB61D0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DBAACC Offset: 0x2DB6ACC VA: 0x2DBAACC
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2DC17E0 Offset: 0x2DBD7E0 VA: 0x2DC17E0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB62C4 Offset: 0x2DB22C4 VA: 0x2DB62C4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DBABB0 Offset: 0x2DB6BB0 VA: 0x2DBABB0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2DC1934 Offset: 0x2DBD934 VA: 0x2DC1934
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB6324 Offset: 0x2DB2324 VA: 0x2DB6324
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x2DBAC10 Offset: 0x2DB6C10 VA: 0x2DBAC10
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x2DC1998 Offset: 0x2DBD998 VA: 0x2DC1998
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB632C Offset: 0x2DB232C VA: 0x2DB632C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DBAC18 Offset: 0x2DB6C18 VA: 0x2DBAC18
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2DC19A0 Offset: 0x2DBD9A0 VA: 0x2DC19A0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB633C Offset: 0x2DB233C VA: 0x2DB633C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x2DBAC28 Offset: 0x2DB6C28 VA: 0x2DBAC28
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x2DC19B4 Offset: 0x2DBD9B4 VA: 0x2DC19B4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB6434 Offset: 0x2DB2434 VA: 0x2DB6434
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x2DBAD08 Offset: 0x2DB6D08 VA: 0x2DBAD08
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x2DC1B30 Offset: 0x2DBDB30 VA: 0x2DC1B30
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB6444 Offset: 0x2DB2444 VA: 0x2DB6444
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DBAD18 Offset: 0x2DB6D18 VA: 0x2DBAD18
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2DC1B44 Offset: 0x2DBDB44 VA: 0x2DC1B44
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB6534 Offset: 0x2DB2534 VA: 0x2DB6534
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DBAE04 Offset: 0x2DB6E04 VA: 0x2DBAE04
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2DC1D0C Offset: 0x2DBDD0C VA: 0x2DC1D0C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB66F0 Offset: 0x2DB26F0 VA: 0x2DB66F0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DBAFB8 Offset: 0x2DB6FB8 VA: 0x2DBAFB8
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2DC1F44 Offset: 0x2DBDF44 VA: 0x2DC1F44
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB6A84 Offset: 0x2DB2A84 VA: 0x2DB6A84
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2DBB340 Offset: 0x2DB7340 VA: 0x2DBB340
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2DC2300 Offset: 0x2DBE300 VA: 0x2DC2300
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB6A8C Offset: 0x2DB2A8C VA: 0x2DB6A8C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2DBB348 Offset: 0x2DB7348 VA: 0x2DBB348
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2DC2308 Offset: 0x2DBE308 VA: 0x2DC2308
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	private void GrowTable(ConcurrentDictionary.Tables<TKey, TValue> tables) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB6AD4 Offset: 0x2DB2AD4 VA: 0x2DB6AD4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GrowTable
	|
	|-RVA: 0x2DBB390 Offset: 0x2DB7390 VA: 0x2DBB390
	|-ConcurrentDictionary<object, object>.GrowTable
	|
	|-RVA: 0x2DC2350 Offset: 0x2DBE350 VA: 0x2DC2350
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GrowTable
	*/

	// RVA: -1 Offset: -1
	private static int GetBucket(int hashcode, int bucketCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB7248 Offset: 0x2DB3248 VA: 0x2DB7248
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetBucket
	|
	|-RVA: 0x2DBBAE4 Offset: 0x2DB7AE4 VA: 0x2DBBAE4
	|-ConcurrentDictionary<object, object>.GetBucket
	|
	|-RVA: 0x2DC2C58 Offset: 0x2DBEC58 VA: 0x2DC2C58
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetBucket
	*/

	// RVA: -1 Offset: -1
	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB7258 Offset: 0x2DB3258 VA: 0x2DB7258
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetBucketAndLockNo
	|
	|-RVA: 0x2DBBAF4 Offset: 0x2DB7AF4 VA: 0x2DBBAF4
	|-ConcurrentDictionary<object, object>.GetBucketAndLockNo
	|
	|-RVA: 0x2DC2C68 Offset: 0x2DBEC68 VA: 0x2DC2C68
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetBucketAndLockNo
	*/

	// RVA: -1 Offset: -1
	private static int get_DefaultConcurrencyLevel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB7278 Offset: 0x2DB3278 VA: 0x2DB7278
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0x2DBBB14 Offset: 0x2DB7B14 VA: 0x2DBBB14
	|-ConcurrentDictionary<object, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0x2DC2C88 Offset: 0x2DBEC88 VA: 0x2DC2C88
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_DefaultConcurrencyLevel
	*/

	// RVA: -1 Offset: -1
	private void AcquireAllLocks(ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB72C8 Offset: 0x2DB32C8 VA: 0x2DB72C8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.AcquireAllLocks
	|
	|-RVA: 0x2DBBB64 Offset: 0x2DB7B64 VA: 0x2DBBB64
	|-ConcurrentDictionary<object, object>.AcquireAllLocks
	|
	|-RVA: 0x2DC2CD8 Offset: 0x2DBECD8 VA: 0x2DC2CD8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AcquireAllLocks
	*/

	// RVA: -1 Offset: -1
	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB73C0 Offset: 0x2DB33C0 VA: 0x2DB73C0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.AcquireLocks
	|
	|-RVA: 0x2DBBC5C Offset: 0x2DB7C5C VA: 0x2DBBC5C
	|-ConcurrentDictionary<object, object>.AcquireLocks
	|
	|-RVA: 0x2DC2DF4 Offset: 0x2DBEDF4 VA: 0x2DC2DF4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AcquireLocks
	*/

	// RVA: -1 Offset: -1
	private void ReleaseLocks(int fromInclusive, int toExclusive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB74DC Offset: 0x2DB34DC VA: 0x2DB74DC
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ReleaseLocks
	|
	|-RVA: 0x2DBBD78 Offset: 0x2DB7D78 VA: 0x2DBBD78
	|-ConcurrentDictionary<object, object>.ReleaseLocks
	|
	|-RVA: 0x2DC2F10 Offset: 0x2DBEF10 VA: 0x2DC2F10
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ReleaseLocks
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyCollection<TKey> GetKeys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB7550 Offset: 0x2DB3550 VA: 0x2DB7550
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetKeys
	|
	|-RVA: 0x2DBBDEC Offset: 0x2DB7DEC VA: 0x2DBBDEC
	|-ConcurrentDictionary<object, object>.GetKeys
	|
	|-RVA: 0x2DC2F84 Offset: 0x2DBEF84 VA: 0x2DC2F84
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeys
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyCollection<TValue> GetValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB77E0 Offset: 0x2DB37E0 VA: 0x2DB77E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetValues
	|
	|-RVA: 0x2DBC074 Offset: 0x2DB8074 VA: 0x2DBC074
	|-ConcurrentDictionary<object, object>.GetValues
	|
	|-RVA: 0x2DC32A4 Offset: 0x2DBF2A4 VA: 0x2DC32A4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValues
	*/

	[OnSerializing]
	// RVA: -1 Offset: -1
	private void OnSerializing(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB7A68 Offset: 0x2DB3A68 VA: 0x2DB7A68
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnSerializing
	|
	|-RVA: 0x2DBC2FC Offset: 0x2DB82FC VA: 0x2DBC2FC
	|-ConcurrentDictionary<object, object>.OnSerializing
	|
	|-RVA: 0x2DC35C8 Offset: 0x2DBF5C8 VA: 0x2DC35C8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnSerializing
	*/

	[OnSerialized]
	// RVA: -1 Offset: -1
	private void OnSerialized(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB7AD8 Offset: 0x2DB3AD8 VA: 0x2DB7AD8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnSerialized
	|
	|-RVA: 0x2DBC36C Offset: 0x2DB836C VA: 0x2DBC36C
	|-ConcurrentDictionary<object, object>.OnSerialized
	|
	|-RVA: 0x2DC363C Offset: 0x2DBF63C VA: 0x2DC363C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnSerialized
	*/

	[OnDeserialized]
	// RVA: -1 Offset: -1
	private void OnDeserialized(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB7AE4 Offset: 0x2DB3AE4 VA: 0x2DB7AE4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnDeserialized
	|
	|-RVA: 0x2DBC378 Offset: 0x2DB8378 VA: 0x2DBC378
	|-ConcurrentDictionary<object, object>.OnDeserialized
	|
	|-RVA: 0x2DC3648 Offset: 0x2DBF648 VA: 0x2DC3648
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnDeserialized
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DB7CD4 Offset: 0x2DB3CD4 VA: 0x2DB7CD4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..cctor
	|
	|-RVA: 0x2DBC568 Offset: 0x2DB8568 VA: 0x2DBC568
	|-ConcurrentDictionary<object, object>..cctor
	|
	|-RVA: 0x2DC3840 Offset: 0x2DBF840 VA: 0x2DC3840
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

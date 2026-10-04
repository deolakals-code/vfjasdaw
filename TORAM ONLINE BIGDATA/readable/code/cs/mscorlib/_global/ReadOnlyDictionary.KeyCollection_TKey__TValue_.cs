// Assembly: mscorlib.dll
// Namespace: 
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public sealed class ReadOnlyDictionary.KeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 10919
{
	// Fields
	private readonly ICollection<TKey> _collection; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ICollection<TKey> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9A52C Offset: 0x2A9652C VA: 0x2A9A52C
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9A5A0 Offset: 0x2A965A0 VA: 0x2A9A5A0
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9A5E8 Offset: 0x2A965E8 VA: 0x2A9A5E8
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9A630 Offset: 0x2A96630 VA: 0x2A9A630
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TKey[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9A778 Offset: 0x2A96778 VA: 0x2A9A778
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9A81C Offset: 0x2A9681C VA: 0x2A9A81C
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9A8A4 Offset: 0x2A968A4 VA: 0x2A9A8A4
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9A8AC Offset: 0x2A968AC VA: 0x2A9A8AC
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<TKey> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9A8F4 Offset: 0x2A968F4 VA: 0x2A9A8F4
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9A97C Offset: 0x2A9697C VA: 0x2A9A97C
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9AA1C Offset: 0x2A96A1C VA: 0x2A9AA1C
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9AA34 Offset: 0x2A96A34 VA: 0x2A9AA34
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9AA3C Offset: 0x2A96A3C VA: 0x2A9AA3C
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A9AB48 Offset: 0x2A96B48 VA: 0x2A9AB48
	|-ReadOnlyDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

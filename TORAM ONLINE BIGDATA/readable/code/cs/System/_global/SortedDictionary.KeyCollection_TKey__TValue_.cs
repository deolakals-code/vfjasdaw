// Assembly: System.dll
// Namespace: 
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(DictionaryKeyCollectionDebugView<TKey, TValue>))]
[Serializable]
public sealed class SortedDictionary.KeyCollection<TKey, TValue> : ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IReadOnlyCollection<TKey> // TypeDefIndex: 14319
{
	// Fields
	private SortedDictionary<TKey, TValue> _dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TKey>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SortedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7F79C Offset: 0x2A7B79C VA: 0x2A7F79C
	|-SortedDictionary.KeyCollection<byte, object>..ctor
	|
	|-RVA: 0x2A81F18 Offset: 0x2A7DF18 VA: 0x2A81F18
	|-SortedDictionary.KeyCollection<double, int>..ctor
	|
	|-RVA: 0x2A9AB54 Offset: 0x2A96B54 VA: 0x2A9AB54
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TKey> System.Collections.Generic.IEnumerable<TKey>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7F810 Offset: 0x2A7B810 VA: 0x2A7F810
	|-SortedDictionary.KeyCollection<byte, object>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A81F8C Offset: 0x2A7DF8C VA: 0x2A81F8C
	|-SortedDictionary.KeyCollection<double, int>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	|
	|-RVA: 0x2A9ABC8 Offset: 0x2A96BC8 VA: 0x2A9ABC8
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TKey>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7F870 Offset: 0x2A7B870 VA: 0x2A7F870
	|-SortedDictionary.KeyCollection<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A81FEC Offset: 0x2A7DFEC VA: 0x2A81FEC
	|-SortedDictionary.KeyCollection<double, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2A9AC28 Offset: 0x2A96C28 VA: 0x2A9AC28
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TKey[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7F8D0 Offset: 0x2A7B8D0 VA: 0x2A7F8D0
	|-SortedDictionary.KeyCollection<byte, object>.CopyTo
	|
	|-RVA: 0x2A8204C Offset: 0x2A7E04C VA: 0x2A8204C
	|-SortedDictionary.KeyCollection<double, int>.CopyTo
	|
	|-RVA: 0x2A9AC88 Offset: 0x2A96C88 VA: 0x2A9AC88
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7FAC8 Offset: 0x2A7BAC8 VA: 0x2A7FAC8
	|-SortedDictionary.KeyCollection<byte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A82244 Offset: 0x2A7E244 VA: 0x2A82244
	|-SortedDictionary.KeyCollection<double, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2A9AE8C Offset: 0x2A96E8C VA: 0x2A9AE8C
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7FECC Offset: 0x2A7BECC VA: 0x2A7FECC
	|-SortedDictionary.KeyCollection<byte, object>.get_Count
	|
	|-RVA: 0x2A82648 Offset: 0x2A7E648 VA: 0x2A82648
	|-SortedDictionary.KeyCollection<double, int>.get_Count
	|
	|-RVA: 0x2A9B2A0 Offset: 0x2A972A0 VA: 0x2A9B2A0
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TKey>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7FEF0 Offset: 0x2A7BEF0 VA: 0x2A7FEF0
	|-SortedDictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A8266C Offset: 0x2A7E66C VA: 0x2A8266C
	|-SortedDictionary.KeyCollection<double, int>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	|
	|-RVA: 0x2A9B2C8 Offset: 0x2A972C8 VA: 0x2A9B2C8
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TKey>.Add(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7FEF8 Offset: 0x2A7BEF8 VA: 0x2A7FEF8
	|-SortedDictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A82674 Offset: 0x2A7E674 VA: 0x2A82674
	|-SortedDictionary.KeyCollection<double, int>.System.Collections.Generic.ICollection<TKey>.Add
	|
	|-RVA: 0x2A9B2D0 Offset: 0x2A972D0 VA: 0x2A9B2D0
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TKey>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7FF40 Offset: 0x2A7BF40 VA: 0x2A7FF40
	|-SortedDictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A826BC Offset: 0x2A7E6BC VA: 0x2A826BC
	|-SortedDictionary.KeyCollection<double, int>.System.Collections.Generic.ICollection<TKey>.Clear
	|
	|-RVA: 0x2A9B318 Offset: 0x2A97318 VA: 0x2A9B318
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TKey>.Contains(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7FF88 Offset: 0x2A7BF88 VA: 0x2A7FF88
	|-SortedDictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A82704 Offset: 0x2A7E704 VA: 0x2A82704
	|-SortedDictionary.KeyCollection<double, int>.System.Collections.Generic.ICollection<TKey>.Contains
	|
	|-RVA: 0x2A9B360 Offset: 0x2A97360 VA: 0x2A9B360
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TKey>.Remove(TKey item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7FFAC Offset: 0x2A7BFAC VA: 0x2A7FFAC
	|-SortedDictionary.KeyCollection<byte, object>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A82728 Offset: 0x2A7E728 VA: 0x2A82728
	|-SortedDictionary.KeyCollection<double, int>.System.Collections.Generic.ICollection<TKey>.Remove
	|
	|-RVA: 0x2A9B430 Offset: 0x2A97430 VA: 0x2A9B430
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TKey>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7FFF4 Offset: 0x2A7BFF4 VA: 0x2A7FFF4
	|-SortedDictionary.KeyCollection<byte, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A82770 Offset: 0x2A7E770 VA: 0x2A82770
	|-SortedDictionary.KeyCollection<double, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2A9B478 Offset: 0x2A97478 VA: 0x2A9B478
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A7FFFC Offset: 0x2A7BFFC VA: 0x2A7FFFC
	|-SortedDictionary.KeyCollection<byte, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A82778 Offset: 0x2A7E778 VA: 0x2A82778
	|-SortedDictionary.KeyCollection<double, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2A9B480 Offset: 0x2A97480 VA: 0x2A9B480
	|-SortedDictionary.KeyCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/
}

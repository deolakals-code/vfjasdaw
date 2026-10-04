// Assembly: System.dll
// Namespace: 
[DebuggerTypeProxy(typeof(DictionaryValueCollectionDebugView<TKey, TValue>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public sealed class SortedDictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 14323
{
	// Fields
	private SortedDictionary<TKey, TValue> _dictionary; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SortedDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE5D9C Offset: 0x2CE1D9C VA: 0x2CE5D9C
	|-SortedDictionary.ValueCollection<byte, object>..ctor
	|
	|-RVA: 0x2CE8534 Offset: 0x2CE4534 VA: 0x2CE8534
	|-SortedDictionary.ValueCollection<double, int>..ctor
	|
	|-RVA: 0x2D01508 Offset: 0x2CFD508 VA: 0x2D01508
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.ValueCollection.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE5E10 Offset: 0x2CE1E10 VA: 0x2CE5E10
	|-SortedDictionary.ValueCollection<byte, object>.GetEnumerator
	|
	|-RVA: 0x2CE85A8 Offset: 0x2CE45A8 VA: 0x2CE85A8
	|-SortedDictionary.ValueCollection<double, int>.GetEnumerator
	|
	|-RVA: 0x2D0157C Offset: 0x2CFD57C VA: 0x2D0157C
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private IEnumerator<TValue> System.Collections.Generic.IEnumerable<TValue>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE5E38 Offset: 0x2CE1E38 VA: 0x2CE5E38
	|-SortedDictionary.ValueCollection<byte, object>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2CE85D0 Offset: 0x2CE45D0 VA: 0x2CE85D0
	|-SortedDictionary.ValueCollection<double, int>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	|
	|-RVA: 0x2D015A4 Offset: 0x2CFD5A4 VA: 0x2D015A4
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<TValue>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE5E98 Offset: 0x2CE1E98 VA: 0x2CE5E98
	|-SortedDictionary.ValueCollection<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2CE8630 Offset: 0x2CE4630 VA: 0x2CE8630
	|-SortedDictionary.ValueCollection<double, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2D01604 Offset: 0x2CFD604 VA: 0x2D01604
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE5EF8 Offset: 0x2CE1EF8 VA: 0x2CE5EF8
	|-SortedDictionary.ValueCollection<byte, object>.CopyTo
	|
	|-RVA: 0x2CE8690 Offset: 0x2CE4690 VA: 0x2CE8690
	|-SortedDictionary.ValueCollection<double, int>.CopyTo
	|
	|-RVA: 0x2D01664 Offset: 0x2CFD664 VA: 0x2D01664
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE60F0 Offset: 0x2CE20F0 VA: 0x2CE60F0
	|-SortedDictionary.ValueCollection<byte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2CE8888 Offset: 0x2CE4888 VA: 0x2CE8888
	|-SortedDictionary.ValueCollection<double, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2D01868 Offset: 0x2CFD868 VA: 0x2D01868
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE64F4 Offset: 0x2CE24F4 VA: 0x2CE64F4
	|-SortedDictionary.ValueCollection<byte, object>.get_Count
	|
	|-RVA: 0x2CE8C8C Offset: 0x2CE4C8C VA: 0x2CE8C8C
	|-SortedDictionary.ValueCollection<double, int>.get_Count
	|
	|-RVA: 0x2D01C7C Offset: 0x2CFDC7C VA: 0x2D01C7C
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE6518 Offset: 0x2CE2518 VA: 0x2CE6518
	|-SortedDictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2CE8CB0 Offset: 0x2CE4CB0 VA: 0x2CE8CB0
	|-SortedDictionary.ValueCollection<double, int>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x2D01CA4 Offset: 0x2CFDCA4 VA: 0x2D01CA4
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE6520 Offset: 0x2CE2520 VA: 0x2CE6520
	|-SortedDictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2CE8CB8 Offset: 0x2CE4CB8 VA: 0x2CE8CB8
	|-SortedDictionary.ValueCollection<double, int>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x2D01CAC Offset: 0x2CFDCAC VA: 0x2D01CAC
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE6568 Offset: 0x2CE2568 VA: 0x2CE6568
	|-SortedDictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2CE8D00 Offset: 0x2CE4D00 VA: 0x2CE8D00
	|-SortedDictionary.ValueCollection<double, int>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x2D01CF4 Offset: 0x2CFDCF4 VA: 0x2D01CF4
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE65B0 Offset: 0x2CE25B0 VA: 0x2CE65B0
	|-SortedDictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2CE8D48 Offset: 0x2CE4D48 VA: 0x2CE8D48
	|-SortedDictionary.ValueCollection<double, int>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x2D01D3C Offset: 0x2CFDD3C VA: 0x2D01D3C
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE65D4 Offset: 0x2CE25D4 VA: 0x2CE65D4
	|-SortedDictionary.ValueCollection<byte, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2CE8D6C Offset: 0x2CE4D6C VA: 0x2CE8D6C
	|-SortedDictionary.ValueCollection<double, int>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x2D01E0C Offset: 0x2CFDE0C VA: 0x2D01E0C
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE661C Offset: 0x2CE261C VA: 0x2CE661C
	|-SortedDictionary.ValueCollection<byte, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2CE8DB4 Offset: 0x2CE4DB4 VA: 0x2CE8DB4
	|-SortedDictionary.ValueCollection<double, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2D01E54 Offset: 0x2CFDE54 VA: 0x2D01E54
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CE6624 Offset: 0x2CE2624 VA: 0x2CE6624
	|-SortedDictionary.ValueCollection<byte, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2CE8DBC Offset: 0x2CE4DBC VA: 0x2CE8DBC
	|-SortedDictionary.ValueCollection<double, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2D01E5C Offset: 0x2CFDE5C VA: 0x2D01E5C
	|-SortedDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/
}

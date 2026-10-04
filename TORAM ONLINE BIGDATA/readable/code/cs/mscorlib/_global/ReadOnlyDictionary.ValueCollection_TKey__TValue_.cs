// Assembly: mscorlib.dll
// Namespace: 
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[Serializable]
public sealed class ReadOnlyDictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 10920
{
	// Fields
	private readonly ICollection<TValue> _collection; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ICollection<TValue> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D00EE0 Offset: 0x2CFCEE0 VA: 0x2D00EE0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D00F54 Offset: 0x2CFCF54 VA: 0x2D00F54
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D00F9C Offset: 0x2CFCF9C VA: 0x2D00F9C
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D00FE4 Offset: 0x2CFCFE4 VA: 0x2D00FE4
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D0112C Offset: 0x2CFD12C VA: 0x2D0112C
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D011D0 Offset: 0x2CFD1D0 VA: 0x2D011D0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D01258 Offset: 0x2CFD258 VA: 0x2D01258
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D01260 Offset: 0x2CFD260 VA: 0x2D01260
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D012A8 Offset: 0x2CFD2A8 VA: 0x2D012A8
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D01330 Offset: 0x2CFD330 VA: 0x2D01330
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D013D0 Offset: 0x2CFD3D0 VA: 0x2D013D0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D013E8 Offset: 0x2CFD3E8 VA: 0x2D013E8
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D013F0 Offset: 0x2CFD3F0 VA: 0x2D013F0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D014FC Offset: 0x2CFD4FC VA: 0x2D014FC
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

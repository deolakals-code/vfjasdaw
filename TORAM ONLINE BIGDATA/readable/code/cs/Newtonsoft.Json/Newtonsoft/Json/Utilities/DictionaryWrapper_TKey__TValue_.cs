// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Utilities
[DefaultMember("Item")]
[NullableContext(1)]
[Nullable(0)]
internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection // TypeDefIndex: 15896
{
	// Fields
	[Nullable(2)]
	private readonly IDictionary _dictionary; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private readonly IDictionary<TKey, TValue> _genericDictionary; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private readonly IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary; // 0x0
	[Nullable(2)]
	private object _syncRoot; // 0x0

	// Properties
	internal IDictionary<TKey, TValue> GenericDictionary { get; }
	public ICollection<TKey> Keys { get; }
	public ICollection<TValue> Values { get; }
	public TValue Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }
	[Nullable(2)]
	private object System.Collections.IDictionary.Item { get; set; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object UnderlyingDictionary { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal IDictionary<TKey, TValue> get_GenericDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCD86C Offset: 0x2DC986C VA: 0x2DCD86C
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_GenericDictionary
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCD874 Offset: 0x2DC9874 VA: 0x2DCD874
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCDB3C Offset: 0x2DC9B3C VA: 0x2DCDB3C
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCDE18 Offset: 0x2DC9E18 VA: 0x2DCDE18
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCE000 Offset: 0x2DCA000 VA: 0x2DCE000
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCE328 Offset: 0x2DCA328 VA: 0x2DCE328
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCE6F8 Offset: 0x2DCA6F8 VA: 0x2DCE6F8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCE8E0 Offset: 0x2DCA8E0 VA: 0x2DCE8E0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCEC34 Offset: 0x2DCAC34 VA: 0x2DCEC34
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCEF38 Offset: 0x2DCAF38 VA: 0x2DCEF38
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCF180 Offset: 0x2DCB180 VA: 0x2DCF180
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCF2D8 Offset: 0x2DCB2D8 VA: 0x2DCF2D8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCF55C Offset: 0x2DCB55C VA: 0x2DCF55C
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCFBE8 Offset: 0x2DCBBE8 VA: 0x2DCFBE8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCFD6C Offset: 0x2DCBD6C VA: 0x2DCFD6C
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public bool Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DCFEAC Offset: 0x2DCBEAC VA: 0x2DCFEAC
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD02E4 Offset: 0x2DCC2E4 VA: 0x2DD02E4
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD05C8 Offset: 0x2DCC5C8 VA: 0x2DD05C8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD05DC Offset: 0x2DCC5DC VA: 0x2DD05DC
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD0878 Offset: 0x2DCC878 VA: 0x2DD0878
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD0B54 Offset: 0x2DCCB54 VA: 0x2DD0B54
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD0DF0 Offset: 0x2DCCDF0 VA: 0x2DD0DF0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD0FC8 Offset: 0x2DCCFC8 VA: 0x2DD0FC8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD1274 Offset: 0x2DCD274 VA: 0x2DD1274
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public void Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD1418 Offset: 0x2DCD418 VA: 0x2DD1418
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD1648 Offset: 0x2DCD648 VA: 0x2DD1648
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD17EC Offset: 0x2DCD7EC VA: 0x2DD17EC
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD19C8 Offset: 0x2DCD9C8 VA: 0x2DD19C8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD1A78 Offset: 0x2DCDA78 VA: 0x2DD1A78
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public object get_UnderlyingDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2DD1AEC Offset: 0x2DCDAEC VA: 0x2DD1AEC
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_UnderlyingDictionary
	*/
}

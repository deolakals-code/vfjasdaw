// Assembly: System.dll
// Namespace: System.Collections.Generic
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView<K, V>))]
[Serializable]
public class SortedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 14327
{
	// Fields
	private SortedDictionary.KeyCollection<TKey, TValue> _keys; // 0x0
	private SortedDictionary.ValueCollection<TKey, TValue> _values; // 0x0
	private TreeSet<KeyValuePair<TKey, TValue>> _set; // 0x0

	// Properties
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	public TValue Item { get; set; }
	public int Count { get; }
	public SortedDictionary.KeyCollection<TKey, TValue> Keys { get; }
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.Keys { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public SortedDictionary.ValueCollection<TKey, TValue> Values { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8FB20 Offset: 0x2C8BB20 VA: 0x2C8FB20
	|-SortedDictionary<byte, object>..ctor
	|
	|-RVA: 0x2C913AC Offset: 0x2C8D3AC VA: 0x2C913AC
	|-SortedDictionary<double, int>..ctor
	|
	|-RVA: 0x2C92C20 Offset: 0x2C8EC20 VA: 0x2C92C20
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8FB34 Offset: 0x2C8BB34 VA: 0x2C8FB34
	|-SortedDictionary<byte, object>..ctor
	|
	|-RVA: 0x2C913C0 Offset: 0x2C8D3C0 VA: 0x2C913C0
	|-SortedDictionary<double, int>..ctor
	|
	|-RVA: 0x2C92C38 Offset: 0x2C8EC38 VA: 0x2C92C38
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary, IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8FB48 Offset: 0x2C8BB48 VA: 0x2C8FB48
	|-SortedDictionary<byte, object>..ctor
	|
	|-RVA: 0x2C913D4 Offset: 0x2C8D3D4 VA: 0x2C913D4
	|-SortedDictionary<double, int>..ctor
	|
	|-RVA: 0x2C92C50 Offset: 0x2C8EC50 VA: 0x2C92C50
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8FF10 Offset: 0x2C8BF10 VA: 0x2C8FF10
	|-SortedDictionary<byte, object>..ctor
	|
	|-RVA: 0x2C9179C Offset: 0x2C8D79C VA: 0x2C9179C
	|-SortedDictionary<double, int>..ctor
	|
	|-RVA: 0x2C930F0 Offset: 0x2C8F0F0 VA: 0x2C930F0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8FFB4 Offset: 0x2C8BFB4 VA: 0x2C8FFB4
	|-SortedDictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2C91840 Offset: 0x2C8D840 VA: 0x2C91840
	|-SortedDictionary<double, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x2C9319C Offset: 0x2C8F19C VA: 0x2C9319C
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C8FFD8 Offset: 0x2C8BFD8 VA: 0x2C8FFD8
	|-SortedDictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2C91864 Offset: 0x2C8D864 VA: 0x2C91864
	|-SortedDictionary<double, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x2C93240 Offset: 0x2C8F240 VA: 0x2C93240
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90058 Offset: 0x2C8C058 VA: 0x2C90058
	|-SortedDictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2C918D4 Offset: 0x2C8D8D4 VA: 0x2C918D4
	|-SortedDictionary<double, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x2C93510 Offset: 0x2C8F510 VA: 0x2C93510
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90100 Offset: 0x2C8C100 VA: 0x2C90100
	|-SortedDictionary<byte, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2C9197C Offset: 0x2C8D97C VA: 0x2C9197C
	|-SortedDictionary<double, int>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x2C93768 Offset: 0x2C8F768 VA: 0x2C93768
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90108 Offset: 0x2C8C108 VA: 0x2C90108
	|-SortedDictionary<byte, object>.get_Item
	|
	|-RVA: 0x2C91984 Offset: 0x2C8D984 VA: 0x2C91984
	|-SortedDictionary<double, int>.get_Item
	|
	|-RVA: 0x2C93770 Offset: 0x2C8F770 VA: 0x2C93770
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C901D4 Offset: 0x2C8C1D4 VA: 0x2C901D4
	|-SortedDictionary<byte, object>.set_Item
	|
	|-RVA: 0x2C91A50 Offset: 0x2C8DA50 VA: 0x2C91A50
	|-SortedDictionary<double, int>.set_Item
	|
	|-RVA: 0x2C93B44 Offset: 0x2C8FB44 VA: 0x2C93B44
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C902E0 Offset: 0x2C8C2E0 VA: 0x2C902E0
	|-SortedDictionary<byte, object>.get_Count
	|
	|-RVA: 0x2C91B54 Offset: 0x2C8DB54 VA: 0x2C91B54
	|-SortedDictionary<double, int>.get_Count
	|
	|-RVA: 0x2C94080 Offset: 0x2C90080 VA: 0x2C94080
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.KeyCollection<TKey, TValue> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90310 Offset: 0x2C8C310 VA: 0x2C90310
	|-SortedDictionary<byte, object>.get_Keys
	|
	|-RVA: 0x2C91B84 Offset: 0x2C8DB84 VA: 0x2C91B84
	|-SortedDictionary<double, int>.get_Keys
	|
	|-RVA: 0x2C940A8 Offset: 0x2C900A8 VA: 0x2C940A8
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TKey> System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90380 Offset: 0x2C8C380 VA: 0x2C90380
	|-SortedDictionary<byte, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2C91BF4 Offset: 0x2C8DBF4 VA: 0x2C91BF4
	|-SortedDictionary<double, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2C9411C Offset: 0x2C9011C VA: 0x2C9411C
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 38
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90390 Offset: 0x2C8C390 VA: 0x2C90390
	|-SortedDictionary<byte, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2C91C04 Offset: 0x2C8DC04 VA: 0x2C91C04
	|-SortedDictionary<double, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x2C94130 Offset: 0x2C90130 VA: 0x2C94130
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C903A0 Offset: 0x2C8C3A0 VA: 0x2C903A0
	|-SortedDictionary<byte, object>.get_Values
	|
	|-RVA: 0x2C91C14 Offset: 0x2C8DC14 VA: 0x2C91C14
	|-SortedDictionary<double, int>.get_Values
	|
	|-RVA: 0x2C94144 Offset: 0x2C90144 VA: 0x2C94144
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90410 Offset: 0x2C8C410 VA: 0x2C90410
	|-SortedDictionary<byte, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x2C91C84 Offset: 0x2C8DC84 VA: 0x2C91C84
	|-SortedDictionary<double, int>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x2C941B8 Offset: 0x2C901B8 VA: 0x2C941B8
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90420 Offset: 0x2C8C420 VA: 0x2C90420
	|-SortedDictionary<byte, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x2C91C94 Offset: 0x2C8DC94 VA: 0x2C91C94
	|-SortedDictionary<double, int>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x2C941CC Offset: 0x2C901CC VA: 0x2C941CC
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90430 Offset: 0x2C8C430 VA: 0x2C90430
	|-SortedDictionary<byte, object>.Add
	|
	|-RVA: 0x2C91CA4 Offset: 0x2C8DCA4 VA: 0x2C91CA4
	|-SortedDictionary<double, int>.Add
	|
	|-RVA: 0x2C941E0 Offset: 0x2C901E0 VA: 0x2C941E0
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90480 Offset: 0x2C8C480 VA: 0x2C90480
	|-SortedDictionary<byte, object>.Clear
	|
	|-RVA: 0x2C91CF4 Offset: 0x2C8DCF4 VA: 0x2C91CF4
	|-SortedDictionary<double, int>.Clear
	|
	|-RVA: 0x2C94448 Offset: 0x2C90448 VA: 0x2C94448
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C904A4 Offset: 0x2C8C4A4 VA: 0x2C904A4
	|-SortedDictionary<byte, object>.ContainsKey
	|
	|-RVA: 0x2C91D18 Offset: 0x2C8DD18 VA: 0x2C91D18
	|-SortedDictionary<double, int>.ContainsKey
	|
	|-RVA: 0x2C9446C Offset: 0x2C9046C VA: 0x2C9446C
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C904FC Offset: 0x2C8C4FC VA: 0x2C904FC
	|-SortedDictionary<byte, object>.ContainsValue
	|
	|-RVA: 0x2C91D70 Offset: 0x2C8DD70 VA: 0x2C91D70
	|-SortedDictionary<double, int>.ContainsValue
	|
	|-RVA: 0x2C946E8 Offset: 0x2C906E8 VA: 0x2C946E8
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90680 Offset: 0x2C8C680 VA: 0x2C90680
	|-SortedDictionary<byte, object>.CopyTo
	|
	|-RVA: 0x2C91EA4 Offset: 0x2C8DEA4 VA: 0x2C91EA4
	|-SortedDictionary<double, int>.CopyTo
	|
	|-RVA: 0x2C949A4 Offset: 0x2C909A4 VA: 0x2C949A4
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public SortedDictionary.Enumerator<TKey, TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C906EC Offset: 0x2C8C6EC VA: 0x2C906EC
	|-SortedDictionary<byte, object>.GetEnumerator
	|
	|-RVA: 0x2C91F10 Offset: 0x2C8DF10 VA: 0x2C91F10
	|-SortedDictionary<double, int>.GetEnumerator
	|
	|-RVA: 0x2C949CC Offset: 0x2C909CC VA: 0x2C949CC
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90714 Offset: 0x2C8C714 VA: 0x2C90714
	|-SortedDictionary<byte, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2C91F38 Offset: 0x2C8DF38 VA: 0x2C91F38
	|-SortedDictionary<double, int>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	|
	|-RVA: 0x2C949F4 Offset: 0x2C909F4 VA: 0x2C949F4
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90778 Offset: 0x2C8C778 VA: 0x2C90778
	|-SortedDictionary<byte, object>.Remove
	|
	|-RVA: 0x2C91F9C Offset: 0x2C8DF9C VA: 0x2C91F9C
	|-SortedDictionary<double, int>.Remove
	|
	|-RVA: 0x2C94A58 Offset: 0x2C90A58 VA: 0x2C94A58
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C907D0 Offset: 0x2C8C7D0 VA: 0x2C907D0
	|-SortedDictionary<byte, object>.TryGetValue
	|
	|-RVA: 0x2C91FF4 Offset: 0x2C8DFF4 VA: 0x2C91FF4
	|-SortedDictionary<double, int>.TryGetValue
	|
	|-RVA: 0x2C94CE4 Offset: 0x2C90CE4 VA: 0x2C94CE4
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90858 Offset: 0x2C8C858 VA: 0x2C90858
	|-SortedDictionary<byte, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C92070 Offset: 0x2C8E070 VA: 0x2C92070
	|-SortedDictionary<double, int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C95040 Offset: 0x2C91040 VA: 0x2C95040
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90910 Offset: 0x2C8C910 VA: 0x2C90910
	|-SortedDictionary<byte, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x2C92128 Offset: 0x2C8E128 VA: 0x2C92128
	|-SortedDictionary<double, int>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x2C950F8 Offset: 0x2C910F8 VA: 0x2C950F8
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90918 Offset: 0x2C8C918 VA: 0x2C90918
	|-SortedDictionary<byte, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2C92130 Offset: 0x2C8E130 VA: 0x2C92130
	|-SortedDictionary<double, int>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x2C95100 Offset: 0x2C91100 VA: 0x2C95100
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90928 Offset: 0x2C8C928 VA: 0x2C90928
	|-SortedDictionary<byte, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x2C92140 Offset: 0x2C8E140 VA: 0x2C92140
	|-SortedDictionary<double, int>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x2C95114 Offset: 0x2C91114 VA: 0x2C95114
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90938 Offset: 0x2C8C938 VA: 0x2C90938
	|-SortedDictionary<byte, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2C92150 Offset: 0x2C8E150 VA: 0x2C92150
	|-SortedDictionary<double, int>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x2C95128 Offset: 0x2C91128 VA: 0x2C95128
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C909F4 Offset: 0x2C8C9F4 VA: 0x2C909F4
	|-SortedDictionary<byte, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2C92220 Offset: 0x2C8E220 VA: 0x2C92220
	|-SortedDictionary<double, int>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x2C952A4 Offset: 0x2C912A4 VA: 0x2C952A4
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C90D28 Offset: 0x2C8CD28 VA: 0x2C90D28
	|-SortedDictionary<byte, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2C92578 Offset: 0x2C8E578 VA: 0x2C92578
	|-SortedDictionary<double, int>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x2C95728 Offset: 0x2C91728 VA: 0x2C95728
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9105C Offset: 0x2C8D05C VA: 0x2C9105C
	|-SortedDictionary<byte, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2C928D0 Offset: 0x2C8E8D0 VA: 0x2C928D0
	|-SortedDictionary<double, int>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x2C95BAC Offset: 0x2C91BAC VA: 0x2C95BAC
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C91100 Offset: 0x2C8D100 VA: 0x2C91100
	|-SortedDictionary<byte, object>.IsCompatibleKey
	|
	|-RVA: 0x2C92974 Offset: 0x2C8E974 VA: 0x2C92974
	|-SortedDictionary<double, int>.IsCompatibleKey
	|
	|-RVA: 0x2C95CBC Offset: 0x2C91CBC VA: 0x2C95CBC
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C91198 Offset: 0x2C8D198 VA: 0x2C91198
	|-SortedDictionary<byte, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2C92A0C Offset: 0x2C8EA0C VA: 0x2C92A0C
	|-SortedDictionary<double, int>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x2C95D54 Offset: 0x2C91D54 VA: 0x2C95D54
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C911FC Offset: 0x2C8D1FC VA: 0x2C911FC
	|-SortedDictionary<byte, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x2C92A70 Offset: 0x2C8EA70 VA: 0x2C92A70
	|-SortedDictionary<double, int>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x2C95DB8 Offset: 0x2C91DB8 VA: 0x2C95DB8
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C9129C Offset: 0x2C8D29C VA: 0x2C9129C
	|-SortedDictionary<byte, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C92B10 Offset: 0x2C8EB10 VA: 0x2C92B10
	|-SortedDictionary<double, int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C95EB4 Offset: 0x2C91EB4 VA: 0x2C95EB4
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C912A4 Offset: 0x2C8D2A4 VA: 0x2C912A4
	|-SortedDictionary<byte, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C92B18 Offset: 0x2C8EB18 VA: 0x2C92B18
	|-SortedDictionary<double, int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C95EBC Offset: 0x2C91EBC VA: 0x2C95EBC
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C91348 Offset: 0x2C8D348 VA: 0x2C91348
	|-SortedDictionary<byte, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C92BBC Offset: 0x2C8EBBC VA: 0x2C92BBC
	|-SortedDictionary<double, int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C95F60 Offset: 0x2C91F60 VA: 0x2C95F60
	|-SortedDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

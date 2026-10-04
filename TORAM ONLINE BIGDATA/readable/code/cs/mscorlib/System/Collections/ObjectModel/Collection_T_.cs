// Assembly: mscorlib.dll
// Namespace: System.Collections.ObjectModel
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 10915
{
	// Fields
	private IList<T> items; // 0x0

	// Properties
	public int Count { get; }
	protected IList<T> Items { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79A3C Offset: 0x2C75A3C VA: 0x2C79A3C
	|-Collection<object>..ctor
	|
	|-RVA: 0x2C7B964 Offset: 0x2C77964 VA: 0x2C7B964
	|-Collection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79A9C Offset: 0x2C75A9C VA: 0x2C79A9C
	|-Collection<object>..ctor
	|
	|-RVA: 0x2C7B9C8 Offset: 0x2C779C8 VA: 0x2C7B9C8
	|-Collection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79ADC Offset: 0x2C75ADC VA: 0x2C79ADC
	|-Collection<object>.get_Count
	|
	|-RVA: 0x2C7BA08 Offset: 0x2C77A08 VA: 0x2C7BA08
	|-Collection<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	protected IList<T> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79B64 Offset: 0x2C75B64 VA: 0x2C79B64
	|-Collection<object>.get_Items
	|
	|-RVA: 0x2C7BA90 Offset: 0x2C77A90 VA: 0x2C7BA90
	|-Collection<__Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79B6C Offset: 0x2C75B6C VA: 0x2C79B6C
	|-Collection<object>.get_Item
	|
	|-RVA: 0x2C7BA98 Offset: 0x2C77A98 VA: 0x2C7BA98
	|-Collection<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79C04 Offset: 0x2C75C04 VA: 0x2C79C04
	|-Collection<object>.set_Item
	|
	|-RVA: 0x2C7BBB4 Offset: 0x2C77BB4 VA: 0x2C7BBB4
	|-Collection<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79D68 Offset: 0x2C75D68 VA: 0x2C79D68
	|-Collection<object>.Add
	|
	|-RVA: 0x2C7BDC0 Offset: 0x2C77DC0 VA: 0x2C7BDC0
	|-Collection<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79EB8 Offset: 0x2C75EB8 VA: 0x2C79EB8
	|-Collection<object>.Clear
	|
	|-RVA: 0x2C7BFBC Offset: 0x2C77FBC VA: 0x2C7BFBC
	|-Collection<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C79F74 Offset: 0x2C75F74 VA: 0x2C79F74
	|-Collection<object>.CopyTo
	|
	|-RVA: 0x2C7C078 Offset: 0x2C78078 VA: 0x2C7C078
	|-Collection<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A018 Offset: 0x2C76018 VA: 0x2C7A018
	|-Collection<object>.Contains
	|
	|-RVA: 0x2C7C11C Offset: 0x2C7811C VA: 0x2C7C11C
	|-Collection<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A0B4 Offset: 0x2C760B4 VA: 0x2C7A0B4
	|-Collection<object>.GetEnumerator
	|
	|-RVA: 0x2C7C264 Offset: 0x2C78264 VA: 0x2C7C264
	|-Collection<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A13C Offset: 0x2C7613C VA: 0x2C7A13C
	|-Collection<object>.IndexOf
	|
	|-RVA: 0x2C7C2EC Offset: 0x2C782EC VA: 0x2C7C2EC
	|-Collection<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A1D8 Offset: 0x2C761D8 VA: 0x2C7A1D8
	|-Collection<object>.Insert
	|
	|-RVA: 0x2C7C42C Offset: 0x2C7842C VA: 0x2C7C42C
	|-Collection<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A33C Offset: 0x2C7633C VA: 0x2C7A33C
	|-Collection<object>.Remove
	|
	|-RVA: 0x2C7C638 Offset: 0x2C78638 VA: 0x2C7C638
	|-Collection<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A4A4 Offset: 0x2C764A4 VA: 0x2C7A4A4
	|-Collection<object>.RemoveAt
	|
	|-RVA: 0x2C7C844 Offset: 0x2C78844 VA: 0x2C7C844
	|-Collection<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected virtual void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A600 Offset: 0x2C76600 VA: 0x2C7A600
	|-Collection<object>.ClearItems
	|
	|-RVA: 0x2C7C9A0 Offset: 0x2C789A0 VA: 0x2C7C9A0
	|-Collection<__Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected virtual void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A68C Offset: 0x2C7668C VA: 0x2C7A68C
	|-Collection<object>.InsertItem
	|
	|-RVA: 0x2C7CA2C Offset: 0x2C78A2C VA: 0x2C7CA2C
	|-Collection<__Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A730 Offset: 0x2C76730 VA: 0x2C7A730
	|-Collection<object>.RemoveItem
	|
	|-RVA: 0x2C7CB78 Offset: 0x2C78B78 VA: 0x2C7CB78
	|-Collection<__Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected virtual void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A7CC Offset: 0x2C767CC VA: 0x2C7A7CC
	|-Collection<object>.SetItem
	|
	|-RVA: 0x2C7CC14 Offset: 0x2C78C14 VA: 0x2C7CC14
	|-Collection<__Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A870 Offset: 0x2C76870 VA: 0x2C7A870
	|-Collection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C7CD60 Offset: 0x2C78D60 VA: 0x2C7CD60
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A8FC Offset: 0x2C768FC VA: 0x2C7A8FC
	|-Collection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C7CDEC Offset: 0x2C78DEC VA: 0x2C7CDEC
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A99C Offset: 0x2C7699C VA: 0x2C7A99C
	|-Collection<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C7CE8C Offset: 0x2C78E8C VA: 0x2C7CE8C
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7A9A4 Offset: 0x2C769A4 VA: 0x2C7A9A4
	|-Collection<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C7CE94 Offset: 0x2C78E94 VA: 0x2C7CE94
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7AA60 Offset: 0x2C76A60 VA: 0x2C7AA60
	|-Collection<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C7CF50 Offset: 0x2C78F50 VA: 0x2C7CF50
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7AEE4 Offset: 0x2C76EE4 VA: 0x2C7AEE4
	|-Collection<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C7D44C Offset: 0x2C7944C VA: 0x2C7D44C
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7AF7C Offset: 0x2C76F7C VA: 0x2C7AF7C
	|-Collection<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C7D56C Offset: 0x2C7956C VA: 0x2C7D56C
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7B0D8 Offset: 0x2C770D8 VA: 0x2C7B0D8
	|-Collection<object>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C7D720 Offset: 0x2C79720 VA: 0x2C7D720
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7B164 Offset: 0x2C77164 VA: 0x2C7B164
	|-Collection<object>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C7D7AC Offset: 0x2C797AC VA: 0x2C7D7AC
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7B288 Offset: 0x2C77288 VA: 0x2C7B288
	|-Collection<object>.System.Collections.IList.Add
	|
	|-RVA: 0x2C7D8D0 Offset: 0x2C798D0 VA: 0x2C7D8D0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7B480 Offset: 0x2C77480 VA: 0x2C7B480
	|-Collection<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C7DB28 Offset: 0x2C79B28 VA: 0x2C7DB28
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7B52C Offset: 0x2C7752C VA: 0x2C7B52C
	|-Collection<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C7DC38 Offset: 0x2C79C38 VA: 0x2C7DC38
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7B5D8 Offset: 0x2C775D8 VA: 0x2C7B5D8
	|-Collection<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C7DD40 Offset: 0x2C79D40 VA: 0x2C7DD40
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7B7C8 Offset: 0x2C777C8 VA: 0x2C7B7C8
	|-Collection<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C7DF90 Offset: 0x2C79F90 VA: 0x2C7DF90
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C7B904 Offset: 0x2C77904 VA: 0x2C7B904
	|-Collection<object>.IsCompatibleObject
	|
	|-RVA: 0x2C7E120 Offset: 0x2C7A120 VA: 0x2C7E120
	|-Collection<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/
}

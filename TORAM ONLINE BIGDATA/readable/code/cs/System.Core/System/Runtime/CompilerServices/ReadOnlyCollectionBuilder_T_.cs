// Assembly: System.Core.dll
// Namespace: System.Runtime.CompilerServices
[DefaultMember("Item")]
[Serializable]
public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection // TypeDefIndex: 15751
{
	// Fields
	private T[] _items; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0

	// Properties
	public int Capacity { set; }
	public int Count { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01344 Offset: 0x2BFD344 VA: 0x2C01344
	|-ReadOnlyCollectionBuilder<object>..ctor
	|
	|-RVA: 0x2C024E0 Offset: 0x2BFE4E0 VA: 0x2C024E0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C013C8 Offset: 0x2BFD3C8 VA: 0x2C013C8
	|-ReadOnlyCollectionBuilder<object>..ctor
	|
	|-RVA: 0x2C02524 Offset: 0x2BFE524 VA: 0x2C02524
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C0145C Offset: 0x2BFD45C VA: 0x2C0145C
	|-ReadOnlyCollectionBuilder<object>.set_Capacity
	|
	|-RVA: 0x2C025B8 Offset: 0x2BFE5B8 VA: 0x2C025B8
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C015A4 Offset: 0x2BFD5A4 VA: 0x2C015A4
	|-ReadOnlyCollectionBuilder<object>.get_Count
	|
	|-RVA: 0x2C026C0 Offset: 0x2BFE6C0 VA: 0x2C026C0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C015AC Offset: 0x2BFD5AC VA: 0x2C015AC
	|-ReadOnlyCollectionBuilder<object>.IndexOf
	|
	|-RVA: 0x2C026C8 Offset: 0x2BFE6C8 VA: 0x2C026C8
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C015CC Offset: 0x2BFD5CC VA: 0x2C015CC
	|-ReadOnlyCollectionBuilder<object>.Insert
	|
	|-RVA: 0x2C027A8 Offset: 0x2BFE7A8 VA: 0x2C027A8
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C016C4 Offset: 0x2BFD6C4 VA: 0x2C016C4
	|-ReadOnlyCollectionBuilder<object>.RemoveAt
	|
	|-RVA: 0x2C02984 Offset: 0x2BFE984 VA: 0x2C02984
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01790 Offset: 0x2BFD790 VA: 0x2C01790
	|-ReadOnlyCollectionBuilder<object>.get_Item
	|
	|-RVA: 0x2C02B4C Offset: 0x2BFEB4C VA: 0x2C02B4C
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01814 Offset: 0x2BFD814 VA: 0x2C01814
	|-ReadOnlyCollectionBuilder<object>.set_Item
	|
	|-RVA: 0x2C02C54 Offset: 0x2BFEC54 VA: 0x2C02C54
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C018B0 Offset: 0x2BFD8B0 VA: 0x2C018B0
	|-ReadOnlyCollectionBuilder<object>.Add
	|
	|-RVA: 0x2C02DD0 Offset: 0x2BFEDD0 VA: 0x2C02DD0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01944 Offset: 0x2BFD944 VA: 0x2C01944
	|-ReadOnlyCollectionBuilder<object>.Clear
	|
	|-RVA: 0x2C02F48 Offset: 0x2BFEF48 VA: 0x2C02F48
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01980 Offset: 0x2BFD980 VA: 0x2C01980
	|-ReadOnlyCollectionBuilder<object>.Contains
	|
	|-RVA: 0x2C02F84 Offset: 0x2BFEF84 VA: 0x2C02F84
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01A70 Offset: 0x2BFDA70 VA: 0x2C01A70
	|-ReadOnlyCollectionBuilder<object>.CopyTo
	|
	|-RVA: 0x2C031CC Offset: 0x2BFF1CC VA: 0x2C031CC
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01A90 Offset: 0x2BFDA90 VA: 0x2C01A90
	|-ReadOnlyCollectionBuilder<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x2C031EC Offset: 0x2BFF1EC VA: 0x2C031EC
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01A98 Offset: 0x2BFDA98 VA: 0x2C01A98
	|-ReadOnlyCollectionBuilder<object>.Remove
	|
	|-RVA: 0x2C031F4 Offset: 0x2BFF1F4 VA: 0x2C031F4
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01B04 Offset: 0x2BFDB04 VA: 0x2C01B04
	|-ReadOnlyCollectionBuilder<object>.GetEnumerator
	|
	|-RVA: 0x2C032EC Offset: 0x2BFF2EC VA: 0x2C032EC
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01B64 Offset: 0x2BFDB64 VA: 0x2C01B64
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2C03350 Offset: 0x2BFF350 VA: 0x2C03350
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01B74 Offset: 0x2BFDB74 VA: 0x2C01B74
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x2C03364 Offset: 0x2BFF364 VA: 0x2C03364
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01B7C Offset: 0x2BFDB7C VA: 0x2C01B7C
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Add
	|
	|-RVA: 0x2C0336C Offset: 0x2BFF36C VA: 0x2C0336C
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01CE8 Offset: 0x2BFDCE8 VA: 0x2C01CE8
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x2C03568 Offset: 0x2BFF568 VA: 0x2C03568
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01D94 Offset: 0x2BFDD94 VA: 0x2C01D94
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x2C03678 Offset: 0x2BFF678 VA: 0x2C03678
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01E54 Offset: 0x2BFDE54 VA: 0x2C01E54
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x2C03780 Offset: 0x2BFF780 VA: 0x2C03780
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01FC0 Offset: 0x2BFDFC0 VA: 0x2C01FC0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x2C03974 Offset: 0x2BFF974 VA: 0x2C03974
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C01FC8 Offset: 0x2BFDFC8 VA: 0x2C01FC8
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x2C0397C Offset: 0x2BFF97C VA: 0x2C0397C
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C02070 Offset: 0x2BFE070 VA: 0x2C02070
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x2C03A78 Offset: 0x2BFFA78 VA: 0x2C03A78
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C02080 Offset: 0x2BFE080 VA: 0x2C02080
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x2C03B28 Offset: 0x2BFFB28 VA: 0x2C03B28
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C021EC Offset: 0x2BFE1EC VA: 0x2C021EC
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x2C03D1C Offset: 0x2BFFD1C VA: 0x2C03D1C
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C022B8 Offset: 0x2BFE2B8 VA: 0x2C022B8
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x2C03DE8 Offset: 0x2BFFDE8 VA: 0x2C03DE8
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C022C0 Offset: 0x2BFE2C0 VA: 0x2C022C0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x2C03DF0 Offset: 0x2BFFDF0 VA: 0x2C03DF0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C022C4 Offset: 0x2BFE2C4 VA: 0x2C022C4
	|-ReadOnlyCollectionBuilder<object>.ToArray
	|
	|-RVA: 0x2C03DF4 Offset: 0x2BFFDF4 VA: 0x2C03DF4
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> ToReadOnlyCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C02328 Offset: 0x2BFE328 VA: 0x2C02328
	|-ReadOnlyCollectionBuilder<object>.ToReadOnlyCollection
	|
	|-RVA: 0x2C03E58 Offset: 0x2BFFE58 VA: 0x2C03E58
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ToReadOnlyCollection
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C0242C Offset: 0x2BFE42C VA: 0x2C0242C
	|-ReadOnlyCollectionBuilder<object>.EnsureCapacity
	|
	|-RVA: 0x2C03F24 Offset: 0x2BFFF24 VA: 0x2C03F24
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C0247C Offset: 0x2BFE47C VA: 0x2C0247C
	|-ReadOnlyCollectionBuilder<object>.IsCompatibleObject
	|
	|-RVA: 0x2C03F78 Offset: 0x2BFFF78 VA: 0x2C03F78
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1
	private static void ValidateNullValue(object value, string argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C024DC Offset: 0x2BFE4DC VA: 0x2C024DC
	|-ReadOnlyCollectionBuilder<object>.ValidateNullValue
	|
	|-RVA: 0x2C040D4 Offset: 0x2C000D4 VA: 0x2C040D4
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ValidateNullValue
	*/
}

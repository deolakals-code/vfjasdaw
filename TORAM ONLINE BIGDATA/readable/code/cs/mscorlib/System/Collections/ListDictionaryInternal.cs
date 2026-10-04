// Assembly: mscorlib.dll
// Namespace: System.Collections
[DefaultMember("Item")]
[Serializable]
internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable // TypeDefIndex: 10875
{
	// Fields
	private ListDictionaryInternal.DictionaryNode head; // 0x10
	private int version; // 0x18
	private int count; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public object Item { get; set; }
	public int Count { get; }
	public ICollection Keys { get; }
	public bool IsReadOnly { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x2FB3E3C Offset: 0x2FAFE3C VA: 0x2FB3E3C
	public void .ctor() { }

	// RVA: 0x2FB3E44 Offset: 0x2FAFE44 VA: 0x2FB3E44 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x2FB3EF8 Offset: 0x2FAFEF8 VA: 0x2FB3EF8 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x2FB4080 Offset: 0x2FB0080 VA: 0x2FB4080 Slot: 15
	public int get_Count() { }

	// RVA: 0x2FB4088 Offset: 0x2FB0088 VA: 0x2FB4088 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x2FB4134 Offset: 0x2FB0134 VA: 0x2FB4134 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x2FB413C Offset: 0x2FB013C VA: 0x2FB413C Slot: 17
	public bool get_IsSynchronized() { }

	// RVA: 0x2FB4144 Offset: 0x2FB0144 VA: 0x2FB4144 Slot: 16
	public object get_SyncRoot() { }

	// RVA: 0x2FB41B4 Offset: 0x2FB01B4 VA: 0x2FB41B4 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x2FB4220 Offset: 0x2FB0220 VA: 0x2FB4220 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x2FB43DC Offset: 0x2FB03DC VA: 0x2FB43DC Slot: 10
	public void Clear() { }

	// RVA: 0x2FB440C Offset: 0x2FB040C VA: 0x2FB440C Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x2FB44C0 Offset: 0x2FB04C0 VA: 0x2FB44C0 Slot: 14
	public void CopyTo(Array array, int index) { }

	// RVA: 0x2FB46C8 Offset: 0x2FB06C8 VA: 0x2FB46C8 Slot: 12
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2FB4778 Offset: 0x2FB0778 VA: 0x2FB4778 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2FB47D0 Offset: 0x2FB07D0 VA: 0x2FB47D0 Slot: 13
	public void Remove(object key) { }
}

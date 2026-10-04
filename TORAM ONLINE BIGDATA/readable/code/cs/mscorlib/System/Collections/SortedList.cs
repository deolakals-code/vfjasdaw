// Assembly: mscorlib.dll
// Namespace: System.Collections
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(SortedList.SortedListDebugView))]
[Serializable]
public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable // TypeDefIndex: 10889
{
	// Fields
	private object[] keys; // 0x10
	private object[] values; // 0x18
	private int _size; // 0x20
	private int version; // 0x24
	private IComparer comparer; // 0x28
	private SortedList.KeyList keyList; // 0x30
	private SortedList.ValueList valueList; // 0x38
	private object _syncRoot; // 0x40

	// Properties
	public virtual int Capacity { set; }
	public virtual int Count { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x2FB7254 Offset: 0x2FB3254 VA: 0x2FB7254
	public void .ctor() { }

	// RVA: 0x2FB7270 Offset: 0x2FB3270 VA: 0x2FB7270
	private void Init() { }

	// RVA: 0x2FB73DC Offset: 0x2FB33DC VA: 0x2FB73DC
	public void .ctor(int initialCapacity) { }

	// RVA: 0x2FB7530 Offset: 0x2FB3530 VA: 0x2FB7530
	public void .ctor(IComparer comparer) { }

	// RVA: 0x2FB7578 Offset: 0x2FB3578 VA: 0x2FB7578 Slot: 20
	public virtual void Add(object key, object value) { }

	// RVA: 0x2FB77DC Offset: 0x2FB37DC VA: 0x2FB77DC Slot: 21
	public virtual void set_Capacity(int value) { }

	// RVA: 0x2FB7A20 Offset: 0x2FB3A20 VA: 0x2FB7A20 Slot: 22
	public virtual int get_Count() { }

	// RVA: 0x2FB7A28 Offset: 0x2FB3A28 VA: 0x2FB7A28 Slot: 23
	public virtual ICollection get_Keys() { }

	// RVA: 0x2FB7A38 Offset: 0x2FB3A38 VA: 0x2FB7A38 Slot: 24
	public virtual ICollection get_Values() { }

	// RVA: 0x2FB7A48 Offset: 0x2FB3A48 VA: 0x2FB7A48 Slot: 25
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x2FB7A50 Offset: 0x2FB3A50 VA: 0x2FB7A50 Slot: 26
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x2FB7A58 Offset: 0x2FB3A58 VA: 0x2FB7A58 Slot: 27
	public virtual object get_SyncRoot() { }

	// RVA: 0x2FB7AC8 Offset: 0x2FB3AC8 VA: 0x2FB7AC8 Slot: 28
	public virtual void Clear() { }

	// RVA: 0x2FB7B10 Offset: 0x2FB3B10 VA: 0x2FB7B10 Slot: 29
	public virtual object Clone() { }

	// RVA: 0x2FB7BC4 Offset: 0x2FB3BC4 VA: 0x2FB7BC4 Slot: 30
	public virtual bool Contains(object key) { }

	// RVA: 0x2FB7BE8 Offset: 0x2FB3BE8 VA: 0x2FB7BE8 Slot: 31
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x2FB7C0C Offset: 0x2FB3C0C VA: 0x2FB7C0C Slot: 32
	public virtual bool ContainsValue(object value) { }

	// RVA: 0x2FB7C30 Offset: 0x2FB3C30 VA: 0x2FB7C30 Slot: 33
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2FB7ED4 Offset: 0x2FB3ED4 VA: 0x2FB7ED4
	private void EnsureCapacity(int min) { }

	// RVA: 0x2FB7F20 Offset: 0x2FB3F20 VA: 0x2FB7F20 Slot: 34
	public virtual object GetByIndex(int index) { }

	// RVA: 0x2FB7FD8 Offset: 0x2FB3FD8 VA: 0x2FB7FD8 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2FB80B8 Offset: 0x2FB40B8 VA: 0x2FB80B8 Slot: 35
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2FB8120 Offset: 0x2FB4120 VA: 0x2FB8120 Slot: 36
	public virtual object GetKey(int index) { }

	// RVA: 0x2FB81D8 Offset: 0x2FB41D8 VA: 0x2FB81D8 Slot: 37
	public virtual IList GetKeyList() { }

	// RVA: 0x2FB828C Offset: 0x2FB428C VA: 0x2FB828C Slot: 38
	public virtual IList GetValueList() { }

	// RVA: 0x2FB8340 Offset: 0x2FB4340 VA: 0x2FB8340 Slot: 39
	public virtual object get_Item(object key) { }

	// RVA: 0x2FB8390 Offset: 0x2FB4390 VA: 0x2FB8390 Slot: 40
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x2FB84B8 Offset: 0x2FB44B8 VA: 0x2FB84B8 Slot: 41
	public virtual int IndexOfKey(object key) { }

	// RVA: 0x2FB8554 Offset: 0x2FB4554 VA: 0x2FB8554 Slot: 42
	public virtual int IndexOfValue(object value) { }

	// RVA: 0x2FB769C Offset: 0x2FB369C VA: 0x2FB769C
	private void Insert(int index, object key, object value) { }

	// RVA: 0x2FB85B4 Offset: 0x2FB45B4 VA: 0x2FB85B4 Slot: 43
	public virtual void RemoveAt(int index) { }

	// RVA: 0x2FB86FC Offset: 0x2FB46FC VA: 0x2FB86FC Slot: 44
	public virtual void Remove(object key) { }

	// RVA: 0x2FB873C Offset: 0x2FB473C VA: 0x2FB873C
	public static SortedList Synchronized(SortedList list) { }
}

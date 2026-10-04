// Assembly: mscorlib.dll
// Namespace: 
[DefaultMember("Item")]
[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
[Serializable]
private class SortedList.KeyList : IList, ICollection, IEnumerable // TypeDefIndex: 10886
{
	// Fields
	private SortedList sortedList; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x2FB825C Offset: 0x2FB425C VA: 0x2FB825C
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x2FB9ECC Offset: 0x2FB5ECC VA: 0x2FB9ECC Slot: 20
	public virtual int get_Count() { }

	// RVA: 0x2FB9EE8 Offset: 0x2FB5EE8 VA: 0x2FB9EE8 Slot: 21
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x2FB9EF0 Offset: 0x2FB5EF0 VA: 0x2FB9EF0 Slot: 22
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x2FB9EF8 Offset: 0x2FB5EF8 VA: 0x2FB9EF8 Slot: 23
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x2FB9F1C Offset: 0x2FB5F1C VA: 0x2FB9F1C Slot: 24
	public virtual object get_SyncRoot() { }

	// RVA: 0x2FB9F40 Offset: 0x2FB5F40 VA: 0x2FB9F40 Slot: 25
	public virtual int Add(object key) { }

	// RVA: 0x2FB9F8C Offset: 0x2FB5F8C VA: 0x2FB9F8C Slot: 26
	public virtual void Clear() { }

	// RVA: 0x2FB9FD8 Offset: 0x2FB5FD8 VA: 0x2FB9FD8 Slot: 27
	public virtual bool Contains(object key) { }

	// RVA: 0x2FB9FFC Offset: 0x2FB5FFC VA: 0x2FB9FFC Slot: 28
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2FBA0C8 Offset: 0x2FB60C8 VA: 0x2FBA0C8 Slot: 29
	public virtual void Insert(int index, object value) { }

	// RVA: 0x2FBA114 Offset: 0x2FB6114 VA: 0x2FBA114 Slot: 30
	public virtual object get_Item(int index) { }

	// RVA: 0x2FBA138 Offset: 0x2FB6138 VA: 0x2FBA138 Slot: 31
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x2FBA184 Offset: 0x2FB6184 VA: 0x2FBA184 Slot: 32
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2FBA210 Offset: 0x2FB6210 VA: 0x2FBA210 Slot: 33
	public virtual int IndexOf(object key) { }

	// RVA: 0x2FBA2D8 Offset: 0x2FB62D8 VA: 0x2FBA2D8 Slot: 34
	public virtual void Remove(object key) { }

	// RVA: 0x2FBA324 Offset: 0x2FB6324 VA: 0x2FBA324 Slot: 35
	public virtual void RemoveAt(int index) { }
}

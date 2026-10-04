// Assembly: mscorlib.dll
// Namespace: 
[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
[DefaultMember("Item")]
[Serializable]
private class SortedList.ValueList : IList, ICollection, IEnumerable // TypeDefIndex: 10887
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

	// RVA: 0x2FB8310 Offset: 0x2FB4310 VA: 0x2FB8310
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x2FBA370 Offset: 0x2FB6370 VA: 0x2FBA370 Slot: 20
	public virtual int get_Count() { }

	// RVA: 0x2FBA38C Offset: 0x2FB638C VA: 0x2FBA38C Slot: 21
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x2FBA394 Offset: 0x2FB6394 VA: 0x2FBA394 Slot: 22
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x2FBA39C Offset: 0x2FB639C VA: 0x2FBA39C Slot: 23
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x2FBA3C0 Offset: 0x2FB63C0 VA: 0x2FBA3C0 Slot: 24
	public virtual object get_SyncRoot() { }

	// RVA: 0x2FBA3E4 Offset: 0x2FB63E4 VA: 0x2FBA3E4 Slot: 25
	public virtual int Add(object key) { }

	// RVA: 0x2FBA430 Offset: 0x2FB6430 VA: 0x2FBA430 Slot: 26
	public virtual void Clear() { }

	// RVA: 0x2FBA47C Offset: 0x2FB647C VA: 0x2FBA47C Slot: 27
	public virtual bool Contains(object value) { }

	// RVA: 0x2FBA4A0 Offset: 0x2FB64A0 VA: 0x2FBA4A0 Slot: 28
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2FBA56C Offset: 0x2FB656C VA: 0x2FBA56C Slot: 29
	public virtual void Insert(int index, object value) { }

	// RVA: 0x2FBA5B8 Offset: 0x2FB65B8 VA: 0x2FBA5B8 Slot: 30
	public virtual object get_Item(int index) { }

	// RVA: 0x2FBA5DC Offset: 0x2FB65DC VA: 0x2FBA5DC Slot: 31
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x2FBA628 Offset: 0x2FB6628 VA: 0x2FBA628 Slot: 32
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2FBA6B4 Offset: 0x2FB66B4 VA: 0x2FBA6B4 Slot: 33
	public virtual int IndexOf(object value) { }

	// RVA: 0x2FBA72C Offset: 0x2FB672C VA: 0x2FBA72C Slot: 34
	public virtual void Remove(object value) { }

	// RVA: 0x2FBA778 Offset: 0x2FB6778 VA: 0x2FBA778 Slot: 35
	public virtual void RemoveAt(int index) { }
}

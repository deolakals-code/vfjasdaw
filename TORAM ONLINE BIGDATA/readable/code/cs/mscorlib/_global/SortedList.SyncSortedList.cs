// Assembly: mscorlib.dll
// Namespace: 
[DefaultMember("Item")]
[Serializable]
private class SortedList.SyncSortedList : SortedList // TypeDefIndex: 10884
{
	// Fields
	private SortedList _list; // 0x48
	private object _root; // 0x50

	// Properties
	public override int Count { get; }
	public override object SyncRoot { get; }
	public override bool IsReadOnly { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }

	// Methods

	// RVA: 0x2FB87E0 Offset: 0x2FB47E0 VA: 0x2FB87E0
	internal void .ctor(SortedList list) { }

	// RVA: 0x2FB8844 Offset: 0x2FB4844 VA: 0x2FB8844 Slot: 22
	public override int get_Count() { }

	// RVA: 0x2FB8928 Offset: 0x2FB4928 VA: 0x2FB8928 Slot: 27
	public override object get_SyncRoot() { }

	// RVA: 0x2FB8930 Offset: 0x2FB4930 VA: 0x2FB8930 Slot: 25
	public override bool get_IsReadOnly() { }

	// RVA: 0x2FB8954 Offset: 0x2FB4954 VA: 0x2FB8954 Slot: 26
	public override bool get_IsSynchronized() { }

	// RVA: 0x2FB895C Offset: 0x2FB495C VA: 0x2FB895C Slot: 39
	public override object get_Item(object key) { }

	// RVA: 0x2FB8A48 Offset: 0x2FB4A48 VA: 0x2FB8A48 Slot: 40
	public override void set_Item(object key, object value) { }

	// RVA: 0x2FB8B2C Offset: 0x2FB4B2C VA: 0x2FB8B2C Slot: 20
	public override void Add(object key, object value) { }

	// RVA: 0x2FB8C10 Offset: 0x2FB4C10 VA: 0x2FB8C10 Slot: 28
	public override void Clear() { }

	// RVA: 0x2FB8CE4 Offset: 0x2FB4CE4 VA: 0x2FB8CE4 Slot: 29
	public override object Clone() { }

	// RVA: 0x2FB8DC8 Offset: 0x2FB4DC8 VA: 0x2FB8DC8 Slot: 30
	public override bool Contains(object key) { }

	// RVA: 0x2FB8EB4 Offset: 0x2FB4EB4 VA: 0x2FB8EB4 Slot: 31
	public override bool ContainsKey(object key) { }

	// RVA: 0x2FB8FA0 Offset: 0x2FB4FA0 VA: 0x2FB8FA0 Slot: 32
	public override bool ContainsValue(object key) { }

	// RVA: 0x2FB908C Offset: 0x2FB508C VA: 0x2FB908C Slot: 33
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x2FB9170 Offset: 0x2FB5170 VA: 0x2FB9170 Slot: 34
	public override object GetByIndex(int index) { }

	// RVA: 0x2FB925C Offset: 0x2FB525C VA: 0x2FB925C Slot: 35
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2FB9340 Offset: 0x2FB5340 VA: 0x2FB9340 Slot: 36
	public override object GetKey(int index) { }

	// RVA: 0x2FB942C Offset: 0x2FB542C VA: 0x2FB942C Slot: 37
	public override IList GetKeyList() { }

	// RVA: 0x2FB9510 Offset: 0x2FB5510 VA: 0x2FB9510 Slot: 38
	public override IList GetValueList() { }

	// RVA: 0x2FB95F4 Offset: 0x2FB55F4 VA: 0x2FB95F4 Slot: 41
	public override int IndexOfKey(object key) { }

	// RVA: 0x2FB9740 Offset: 0x2FB5740 VA: 0x2FB9740 Slot: 42
	public override int IndexOfValue(object value) { }

	// RVA: 0x2FB982C Offset: 0x2FB582C VA: 0x2FB982C Slot: 43
	public override void RemoveAt(int index) { }

	// RVA: 0x2FB9908 Offset: 0x2FB5908 VA: 0x2FB9908 Slot: 44
	public override void Remove(object key) { }
}

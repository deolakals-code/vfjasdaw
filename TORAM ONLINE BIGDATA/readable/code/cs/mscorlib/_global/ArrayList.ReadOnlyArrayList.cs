// Assembly: mscorlib.dll
// Namespace: 
[DefaultMember("Item")]
[Serializable]
private class ArrayList.ReadOnlyArrayList : ArrayList // TypeDefIndex: 10896
{
	// Fields
	private ArrayList _list; // 0x28

	// Properties
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override bool IsFixedSize { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override int Capacity { set; }

	// Methods

	// RVA: 0x2FBD4A0 Offset: 0x2FB94A0 VA: 0x2FBD4A0
	internal void .ctor(ArrayList l) { }

	// RVA: 0x2FBF5F8 Offset: 0x2FBB5F8 VA: 0x2FBF5F8 Slot: 22
	public override int get_Count() { }

	// RVA: 0x2FBF61C Offset: 0x2FBB61C VA: 0x2FBF61C Slot: 24
	public override bool get_IsReadOnly() { }

	// RVA: 0x2FBF624 Offset: 0x2FBB624 VA: 0x2FBF624 Slot: 23
	public override bool get_IsFixedSize() { }

	// RVA: 0x2FBF62C Offset: 0x2FBB62C VA: 0x2FBF62C Slot: 25
	public override bool get_IsSynchronized() { }

	// RVA: 0x2FBF650 Offset: 0x2FBB650 VA: 0x2FBF650 Slot: 27
	public override object get_Item(int index) { }

	// RVA: 0x2FBF674 Offset: 0x2FBB674 VA: 0x2FBF674 Slot: 28
	public override void set_Item(int index, object value) { }

	// RVA: 0x2FBF6C0 Offset: 0x2FBB6C0 VA: 0x2FBF6C0 Slot: 26
	public override object get_SyncRoot() { }

	// RVA: 0x2FBF6E4 Offset: 0x2FBB6E4 VA: 0x2FBF6E4 Slot: 29
	public override int Add(object obj) { }

	// RVA: 0x2FBF730 Offset: 0x2FBB730 VA: 0x2FBF730 Slot: 30
	public override void AddRange(ICollection c) { }

	// RVA: 0x2FBF77C Offset: 0x2FBB77C VA: 0x2FBF77C Slot: 21
	public override void set_Capacity(int value) { }

	// RVA: 0x2FBF7C8 Offset: 0x2FBB7C8 VA: 0x2FBF7C8 Slot: 31
	public override void Clear() { }

	// RVA: 0x2FBF814 Offset: 0x2FBB814 VA: 0x2FBF814 Slot: 32
	public override object Clone() { }

	// RVA: 0x2FBF928 Offset: 0x2FBB928 VA: 0x2FBF928 Slot: 33
	public override bool Contains(object obj) { }

	// RVA: 0x2FBF94C Offset: 0x2FBB94C VA: 0x2FBF94C Slot: 35
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x2FBF970 Offset: 0x2FBB970 VA: 0x2FBF970 Slot: 36
	public override void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x2FBF994 Offset: 0x2FBB994 VA: 0x2FBF994 Slot: 37
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x2FBF9B8 Offset: 0x2FBB9B8 VA: 0x2FBF9B8 Slot: 38
	public override int IndexOf(object value) { }

	// RVA: 0x2FBF9DC Offset: 0x2FBB9DC VA: 0x2FBF9DC Slot: 39
	public override void Insert(int index, object obj) { }

	// RVA: 0x2FBFA28 Offset: 0x2FBBA28 VA: 0x2FBFA28 Slot: 40
	public override void InsertRange(int index, ICollection c) { }

	// RVA: 0x2FBFA74 Offset: 0x2FBBA74 VA: 0x2FBFA74 Slot: 41
	public override void Remove(object value) { }

	// RVA: 0x2FBFAC0 Offset: 0x2FBBAC0 VA: 0x2FBFAC0 Slot: 42
	public override void RemoveAt(int index) { }

	// RVA: 0x2FBFB0C Offset: 0x2FBBB0C VA: 0x2FBFB0C Slot: 43
	public override void RemoveRange(int index, int count) { }

	// RVA: 0x2FBFB58 Offset: 0x2FBBB58 VA: 0x2FBFB58 Slot: 45
	public override void Sort(int index, int count, IComparer comparer) { }

	// RVA: 0x2FBFBA4 Offset: 0x2FBBBA4 VA: 0x2FBFBA4 Slot: 46
	public override object[] ToArray() { }

	// RVA: 0x2FBFBC8 Offset: 0x2FBBBC8 VA: 0x2FBFBC8 Slot: 47
	public override Array ToArray(Type type) { }
}

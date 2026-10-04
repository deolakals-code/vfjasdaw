// Assembly: mscorlib.dll
// Namespace: 
[DefaultMember("Item")]
[Serializable]
private class ArrayList.IListWrapper : ArrayList // TypeDefIndex: 10895
{
	// Fields
	private IList _list; // 0x28

	// Properties
	public override int Capacity { set; }
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override bool IsFixedSize { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }

	// Methods

	// RVA: 0x2FBCA24 Offset: 0x2FB8A24 VA: 0x2FBCA24
	internal void .ctor(IList list) { }

	// RVA: 0x2FBDA88 Offset: 0x2FB9A88 VA: 0x2FBDA88 Slot: 21
	public override void set_Capacity(int value) { }

	// RVA: 0x2FBDB18 Offset: 0x2FB9B18 VA: 0x2FBDB18 Slot: 22
	public override int get_Count() { }

	// RVA: 0x2FBDBBC Offset: 0x2FB9BBC VA: 0x2FBDBBC Slot: 24
	public override bool get_IsReadOnly() { }

	// RVA: 0x2FBDC60 Offset: 0x2FB9C60 VA: 0x2FBDC60 Slot: 23
	public override bool get_IsFixedSize() { }

	// RVA: 0x2FBDD04 Offset: 0x2FB9D04 VA: 0x2FBDD04 Slot: 25
	public override bool get_IsSynchronized() { }

	// RVA: 0x2FBDDA8 Offset: 0x2FB9DA8 VA: 0x2FBDDA8 Slot: 27
	public override object get_Item(int index) { }

	// RVA: 0x2FBDE50 Offset: 0x2FB9E50 VA: 0x2FBDE50 Slot: 28
	public override void set_Item(int index, object value) { }

	// RVA: 0x2FBDF1C Offset: 0x2FB9F1C VA: 0x2FBDF1C Slot: 26
	public override object get_SyncRoot() { }

	// RVA: 0x2FBDFC0 Offset: 0x2FB9FC0 VA: 0x2FBDFC0 Slot: 29
	public override int Add(object obj) { }

	// RVA: 0x2FBE07C Offset: 0x2FBA07C VA: 0x2FBE07C Slot: 30
	public override void AddRange(ICollection c) { }

	// RVA: 0x2FBE0C4 Offset: 0x2FBA0C4 VA: 0x2FBE0C4 Slot: 31
	public override void Clear() { }

	// RVA: 0x2FBE228 Offset: 0x2FBA228 VA: 0x2FBE228 Slot: 32
	public override object Clone() { }

	// RVA: 0x2FBE294 Offset: 0x2FBA294 VA: 0x2FBE294 Slot: 33
	public override bool Contains(object obj) { }

	// RVA: 0x2FBE340 Offset: 0x2FBA340 VA: 0x2FBE340 Slot: 35
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x2FBE3F8 Offset: 0x2FBA3F8 VA: 0x2FBE3F8 Slot: 36
	public override void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x2FBE72C Offset: 0x2FBA72C VA: 0x2FBE72C Slot: 37
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x2FBE7CC Offset: 0x2FBA7CC VA: 0x2FBE7CC Slot: 38
	public override int IndexOf(object value) { }

	// RVA: 0x2FBE878 Offset: 0x2FBA878 VA: 0x2FBE878 Slot: 39
	public override void Insert(int index, object obj) { }

	// RVA: 0x2FBE944 Offset: 0x2FBA944 VA: 0x2FBE944 Slot: 40
	public override void InsertRange(int index, ICollection c) { }

	// RVA: 0x2FBED0C Offset: 0x2FBAD0C VA: 0x2FBED0C Slot: 41
	public override void Remove(object value) { }

	// RVA: 0x2FBED4C Offset: 0x2FBAD4C VA: 0x2FBED4C Slot: 42
	public override void RemoveAt(int index) { }

	// RVA: 0x2FBEE08 Offset: 0x2FBAE08 VA: 0x2FBEE08 Slot: 43
	public override void RemoveRange(int index, int count) { }

	// RVA: 0x2FBF020 Offset: 0x2FBB020 VA: 0x2FBF020 Slot: 45
	public override void Sort(int index, int count, IComparer comparer) { }

	// RVA: 0x2FBF2D8 Offset: 0x2FBB2D8 VA: 0x2FBF2D8 Slot: 46
	public override object[] ToArray() { }

	// RVA: 0x2FBF444 Offset: 0x2FBB444 VA: 0x2FBF444 Slot: 47
	public override Array ToArray(Type type) { }
}

// Assembly: mscorlib.dll
// Namespace: 
[DefaultMember("Item")]
[Serializable]
private class Hashtable.SyncHashtable : Hashtable, IEnumerable // TypeDefIndex: 10903
{
	// Fields
	protected Hashtable _table; // 0x50

	// Properties
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override ICollection Keys { get; }
	public override ICollection Values { get; }

	// Methods

	// RVA: 0x2FC1CC4 Offset: 0x2FBDCC4 VA: 0x2FC1CC4
	internal void .ctor(Hashtable table) { }

	// RVA: 0x2FC2FD0 Offset: 0x2FBEFD0 VA: 0x2FC2FD0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FC300C Offset: 0x2FBF00C VA: 0x2FC300C Slot: 40
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FC3044 Offset: 0x2FBF044 VA: 0x2FC3044 Slot: 39
	public override int get_Count() { }

	// RVA: 0x2FC3068 Offset: 0x2FBF068 VA: 0x2FC3068 Slot: 32
	public override bool get_IsReadOnly() { }

	// RVA: 0x2FC308C Offset: 0x2FBF08C VA: 0x2FC308C Slot: 33
	public override bool get_IsSynchronized() { }

	// RVA: 0x2FC3094 Offset: 0x2FBF094 VA: 0x2FC3094 Slot: 28
	public override object get_Item(object key) { }

	// RVA: 0x2FC30B8 Offset: 0x2FBF0B8 VA: 0x2FC30B8 Slot: 29
	public override void set_Item(object key, object value) { }

	// RVA: 0x2FC31B4 Offset: 0x2FBF1B4 VA: 0x2FC31B4 Slot: 38
	public override object get_SyncRoot() { }

	// RVA: 0x2FC31D8 Offset: 0x2FBF1D8 VA: 0x2FC31D8 Slot: 22
	public override void Add(object key, object value) { }

	// RVA: 0x2FC32D4 Offset: 0x2FBF2D4 VA: 0x2FC32D4 Slot: 23
	public override void Clear() { }

	// RVA: 0x2FC33C0 Offset: 0x2FBF3C0 VA: 0x2FC33C0 Slot: 25
	public override bool Contains(object key) { }

	// RVA: 0x2FC33E4 Offset: 0x2FBF3E4 VA: 0x2FC33E4 Slot: 26
	public override bool ContainsKey(object key) { }

	// RVA: 0x2FC3470 Offset: 0x2FBF470 VA: 0x2FC3470 Slot: 27
	public override void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2FC356C Offset: 0x2FBF56C VA: 0x2FC356C Slot: 24
	public override object Clone() { }

	// RVA: 0x2FC36CC Offset: 0x2FBF6CC VA: 0x2FC36CC Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2FC36F0 Offset: 0x2FBF6F0 VA: 0x2FC36F0 Slot: 30
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2FC3714 Offset: 0x2FBF714 VA: 0x2FC3714 Slot: 35
	public override ICollection get_Keys() { }

	// RVA: 0x2FC3810 Offset: 0x2FBF810 VA: 0x2FC3810 Slot: 36
	public override ICollection get_Values() { }

	// RVA: 0x2FC390C Offset: 0x2FBF90C VA: 0x2FC390C Slot: 37
	public override void Remove(object key) { }

	// RVA: 0x2FC3A00 Offset: 0x2FBFA00 VA: 0x2FC3A00 Slot: 41
	public override void OnDeserialization(object sender) { }
}

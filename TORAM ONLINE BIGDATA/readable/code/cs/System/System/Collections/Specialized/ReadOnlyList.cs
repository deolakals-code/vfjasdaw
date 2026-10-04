// Assembly: System.dll
// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
internal sealed class ReadOnlyList : IList, ICollection, IEnumerable // TypeDefIndex: 14302
{
	// Fields
	private readonly IList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public bool IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x34D41B4 Offset: 0x34D01B4 VA: 0x34D41B4
	internal void .ctor(IList list) { }

	// RVA: 0x34D4304 Offset: 0x34D0304 VA: 0x34D4304 Slot: 16
	public int get_Count() { }

	// RVA: 0x34D43A8 Offset: 0x34D03A8 VA: 0x34D43A8 Slot: 9
	public bool get_IsReadOnly() { }

	// RVA: 0x34D43B0 Offset: 0x34D03B0 VA: 0x34D43B0 Slot: 10
	public bool get_IsFixedSize() { }

	// RVA: 0x34D43B8 Offset: 0x34D03B8 VA: 0x34D43B8 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x34D445C Offset: 0x34D045C VA: 0x34D445C Slot: 4
	public object get_Item(int index) { }

	// RVA: 0x34D4504 Offset: 0x34D0504 VA: 0x34D4504 Slot: 5
	public void set_Item(int index, object value) { }

	// RVA: 0x34D4550 Offset: 0x34D0550 VA: 0x34D4550 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x34D45F4 Offset: 0x34D05F4 VA: 0x34D45F4 Slot: 6
	public int Add(object value) { }

	// RVA: 0x34D4640 Offset: 0x34D0640 VA: 0x34D4640 Slot: 8
	public void Clear() { }

	// RVA: 0x34D468C Offset: 0x34D068C VA: 0x34D468C Slot: 7
	public bool Contains(object value) { }

	// RVA: 0x34D4738 Offset: 0x34D0738 VA: 0x34D4738 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x34D47F0 Offset: 0x34D07F0 VA: 0x34D47F0 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x34D4890 Offset: 0x34D0890 VA: 0x34D4890 Slot: 11
	public int IndexOf(object value) { }

	// RVA: 0x34D493C Offset: 0x34D093C VA: 0x34D493C Slot: 12
	public void Insert(int index, object value) { }

	// RVA: 0x34D4988 Offset: 0x34D0988 VA: 0x34D4988 Slot: 13
	public void Remove(object value) { }

	// RVA: 0x34D49D4 Offset: 0x34D09D4 VA: 0x34D49D4 Slot: 14
	public void RemoveAt(int index) { }
}

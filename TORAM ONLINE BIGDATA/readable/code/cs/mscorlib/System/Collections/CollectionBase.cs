// Assembly: mscorlib.dll
// Namespace: System.Collections
[Serializable]
public abstract class CollectionBase : IList, ICollection, IEnumerable // TypeDefIndex: 10879
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	protected IList List { get; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x2FB577C Offset: 0x2FB177C VA: 0x2FB577C
	protected void .ctor() { }

	// RVA: 0x2FB57E8 Offset: 0x2FB17E8 VA: 0x2FB57E8
	protected ArrayList get_InnerList() { }

	// RVA: 0x2FB57F0 Offset: 0x2FB17F0 VA: 0x2FB57F0
	protected IList get_List() { }

	// RVA: 0x2FB57F4 Offset: 0x2FB17F4 VA: 0x2FB57F4 Slot: 16
	public int get_Count() { }

	// RVA: 0x2FB5818 Offset: 0x2FB1818 VA: 0x2FB5818 Slot: 8
	public void Clear() { }

	// RVA: 0x2FB5864 Offset: 0x2FB1864 VA: 0x2FB5864 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x2FB5A38 Offset: 0x2FB1A38 VA: 0x2FB5A38 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x2FB5A5C Offset: 0x2FB1A5C VA: 0x2FB5A5C Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x2FB5A80 Offset: 0x2FB1A80 VA: 0x2FB5A80 Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FB5AA4 Offset: 0x2FB1AA4 VA: 0x2FB5AA4 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2FB5AC8 Offset: 0x2FB1AC8 VA: 0x2FB5AC8 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2FB5AEC Offset: 0x2FB1AEC VA: 0x2FB5AEC Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x2FB5BA4 Offset: 0x2FB1BA4 VA: 0x2FB5BA4 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x2FB5D88 Offset: 0x2FB1D88 VA: 0x2FB5D88 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x2FB5DAC Offset: 0x2FB1DAC VA: 0x2FB5DAC Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x2FB5EEC Offset: 0x2FB1EEC VA: 0x2FB5EEC Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x2FB6084 Offset: 0x2FB2084 VA: 0x2FB6084 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x2FB60A8 Offset: 0x2FB20A8 VA: 0x2FB60A8 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x2FB6258 Offset: 0x2FB2258 VA: 0x2FB6258 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x2FB627C Offset: 0x2FB227C VA: 0x2FB627C Slot: 20
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x2FB6280 Offset: 0x2FB2280 VA: 0x2FB6280 Slot: 21
	protected virtual void OnInsert(int index, object value) { }

	// RVA: 0x2FB6284 Offset: 0x2FB2284 VA: 0x2FB6284 Slot: 22
	protected virtual void OnClear() { }

	// RVA: 0x2FB6288 Offset: 0x2FB2288 VA: 0x2FB6288 Slot: 23
	protected virtual void OnRemove(int index, object value) { }

	// RVA: 0x2FB628C Offset: 0x2FB228C VA: 0x2FB628C Slot: 24
	protected virtual void OnValidate(object value) { }

	// RVA: 0x2FB62E0 Offset: 0x2FB22E0 VA: 0x2FB62E0 Slot: 25
	protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }

	// RVA: 0x2FB62E4 Offset: 0x2FB22E4 VA: 0x2FB62E4 Slot: 26
	protected virtual void OnInsertComplete(int index, object value) { }

	// RVA: 0x2FB62E8 Offset: 0x2FB22E8 VA: 0x2FB62E8 Slot: 27
	protected virtual void OnClearComplete() { }

	// RVA: 0x2FB62EC Offset: 0x2FB22EC VA: 0x2FB62EC Slot: 28
	protected virtual void OnRemoveComplete(int index, object value) { }
}

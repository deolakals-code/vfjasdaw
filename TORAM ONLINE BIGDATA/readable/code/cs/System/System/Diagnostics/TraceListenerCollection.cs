// Assembly: System.dll
// Namespace: System.Diagnostics
[DefaultMember("Item")]
public class TraceListenerCollection : IList, ICollection, IEnumerable // TypeDefIndex: 14103
{
	// Fields
	private ArrayList list; // 0x10

	// Properties
	public int Count { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: 0x3487C3C Offset: 0x3483C3C VA: 0x3487C3C
	internal void .ctor() { }

	// RVA: 0x34882E4 Offset: 0x34842E4 VA: 0x34882E4 Slot: 16
	public int get_Count() { }

	// RVA: 0x3487DDC Offset: 0x3483DDC VA: 0x3487DDC
	public int Add(TraceListener listener) { }

	// RVA: 0x34883F8 Offset: 0x34843F8 VA: 0x34883F8 Slot: 8
	public void Clear() { }

	// RVA: 0x3488088 Offset: 0x3484088 VA: 0x3488088 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x3488308 Offset: 0x3484308 VA: 0x3488308
	internal void InitializeListener(TraceListener listener) { }

	// RVA: 0x3488458 Offset: 0x3484458 VA: 0x3488458 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x3488574 Offset: 0x3484574 VA: 0x3488574 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x3488598 Offset: 0x3484598 VA: 0x3488598 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x34886A4 Offset: 0x34846A4 VA: 0x34886A4 Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x34886AC Offset: 0x34846AC VA: 0x34886AC Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x34886B4 Offset: 0x34846B4 VA: 0x34886B4 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x3488890 Offset: 0x3484890 VA: 0x3488890 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x34888B4 Offset: 0x34848B4 VA: 0x34888B4 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x34888D8 Offset: 0x34848D8 VA: 0x34888D8 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x3488AAC Offset: 0x3484AAC VA: 0x3488AAC Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x3488BC8 Offset: 0x3484BC8 VA: 0x3488BC8 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x3488BCC Offset: 0x3484BCC VA: 0x3488BCC Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x3488BD4 Offset: 0x3484BD4 VA: 0x3488BD4 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
}

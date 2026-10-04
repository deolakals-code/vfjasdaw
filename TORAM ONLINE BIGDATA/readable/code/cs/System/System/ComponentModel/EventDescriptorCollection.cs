// Assembly: System.dll
// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class EventDescriptorCollection : ICollection, IEnumerable, IList // TypeDefIndex: 14203
{
	// Fields
	private EventDescriptor[] _events; // 0x10
	private string[] _namedSort; // 0x18
	private readonly IComparer _comparer; // 0x20
	private bool _eventsOwned; // 0x28
	private bool _needSort; // 0x29
	private readonly bool _readOnly; // 0x2A
	public static readonly EventDescriptorCollection Empty; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x2C

	// Properties
	public int Count { get; set; }
	public virtual EventDescriptor Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: 0x34A8768 Offset: 0x34A4768 VA: 0x34A8768
	public void .ctor(EventDescriptor[] events) { }

	// RVA: 0x34A8840 Offset: 0x34A4840 VA: 0x34A8840
	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	[CompilerGenerated]
	// RVA: 0x34A8864 Offset: 0x34A4864 VA: 0x34A8864
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x34A886C Offset: 0x34A486C VA: 0x34A886C
	private void set_Count(int value) { }

	// RVA: 0x34A8874 Offset: 0x34A4874 VA: 0x34A8874 Slot: 20
	public virtual EventDescriptor get_Item(int index) { }

	// RVA: 0x34A89B4 Offset: 0x34A49B4 VA: 0x34A89B4
	public int Add(EventDescriptor value) { }

	// RVA: 0x34A8BAC Offset: 0x34A4BAC VA: 0x34A8BAC
	public void Clear() { }

	// RVA: 0x34A8BF8 Offset: 0x34A4BF8 VA: 0x34A8BF8
	public bool Contains(EventDescriptor value) { }

	// RVA: 0x34A8C70 Offset: 0x34A4C70 VA: 0x34A8C70 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x34A88F8 Offset: 0x34A48F8 VA: 0x34A88F8
	private void EnsureEventsOwned() { }

	// RVA: 0x34A8A84 Offset: 0x34A4A84 VA: 0x34A8A84
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x34A8C10 Offset: 0x34A4C10 VA: 0x34A8C10
	public int IndexOf(EventDescriptor value) { }

	// RVA: 0x34A8F2C Offset: 0x34A4F2C VA: 0x34A8F2C
	public void Insert(int index, EventDescriptor value) { }

	// RVA: 0x34A901C Offset: 0x34A501C VA: 0x34A901C
	public void Remove(EventDescriptor value) { }

	// RVA: 0x34A9084 Offset: 0x34A5084 VA: 0x34A9084
	public void RemoveAt(int index) { }

	// RVA: 0x34A9140 Offset: 0x34A5140 VA: 0x34A9140
	public IEnumerator GetEnumerator() { }

	// RVA: 0x34A8CAC Offset: 0x34A4CAC VA: 0x34A8CAC
	protected void InternalSort(string[] names) { }

	// RVA: 0x34A9220 Offset: 0x34A5220 VA: 0x34A9220
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x34A9298 Offset: 0x34A5298 VA: 0x34A9298 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x34A92A0 Offset: 0x34A52A0 VA: 0x34A92A0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x34A92A8 Offset: 0x34A52A8 VA: 0x34A92A8 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x34A92B0 Offset: 0x34A52B0 VA: 0x34A92B0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x34A92B4 Offset: 0x34A52B4 VA: 0x34A92B4 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x34A92C4 Offset: 0x34A52C4 VA: 0x34A92C4 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x34A9430 Offset: 0x34A5430 VA: 0x34A9430 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x34A94B4 Offset: 0x34A54B4 VA: 0x34A94B4 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x34A9544 Offset: 0x34A5544 VA: 0x34A9544 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x34A9548 Offset: 0x34A5548 VA: 0x34A9548 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x34A95CC Offset: 0x34A55CC VA: 0x34A95CC Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x34A9660 Offset: 0x34A5660 VA: 0x34A9660 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x34A96E4 Offset: 0x34A56E4 VA: 0x34A96E4 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x34A96E8 Offset: 0x34A56E8 VA: 0x34A96E8 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x34A96F0 Offset: 0x34A56F0 VA: 0x34A96F0 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x34A96F8 Offset: 0x34A56F8 VA: 0x34A96F8
	private static void .cctor() { }
}

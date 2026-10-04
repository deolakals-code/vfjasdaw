// Assembly: System.dll
// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class StringCollection : IList, ICollection, IEnumerable // TypeDefIndex: 14298
{
	// Fields
	private readonly ArrayList data; // 0x10

	// Properties
	public string Item { get; set; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x34D33B8 Offset: 0x34CF3B8 VA: 0x34D33B8
	public string get_Item(int index) { }

	// RVA: 0x34D3434 Offset: 0x34CF434 VA: 0x34D3434
	public void set_Item(int index, string value) { }

	// RVA: 0x34D3458 Offset: 0x34CF458 VA: 0x34D3458 Slot: 16
	public int get_Count() { }

	// RVA: 0x34D347C Offset: 0x34CF47C VA: 0x34D347C Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x34D3484 Offset: 0x34CF484 VA: 0x34D3484 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x34D348C Offset: 0x34CF48C VA: 0x34D348C
	public int Add(string value) { }

	// RVA: 0x34D34B0 Offset: 0x34CF4B0 VA: 0x34D34B0 Slot: 8
	public void Clear() { }

	// RVA: 0x34D34D4 Offset: 0x34CF4D4 VA: 0x34D34D4
	public bool Contains(string value) { }

	// RVA: 0x34D34F8 Offset: 0x34CF4F8 VA: 0x34D34F8
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x34D351C Offset: 0x34CF51C VA: 0x34D351C
	public int IndexOf(string value) { }

	// RVA: 0x34D3540 Offset: 0x34CF540 VA: 0x34D3540
	public void Insert(int index, string value) { }

	// RVA: 0x34D3564 Offset: 0x34CF564 VA: 0x34D3564 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x34D356C Offset: 0x34CF56C VA: 0x34D356C
	public void Remove(string value) { }

	// RVA: 0x34D3590 Offset: 0x34CF590 VA: 0x34D3590 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x34D35B4 Offset: 0x34CF5B4 VA: 0x34D35B4 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x34D35D8 Offset: 0x34CF5D8 VA: 0x34D35D8 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x34D35DC Offset: 0x34CF5DC VA: 0x34D35DC Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x34D3668 Offset: 0x34CF668 VA: 0x34D3668 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x34D36E4 Offset: 0x34CF6E4 VA: 0x34D36E4 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x34D3760 Offset: 0x34CF760 VA: 0x34D3760 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x34D37DC Offset: 0x34CF7DC VA: 0x34D37DC Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x34D3868 Offset: 0x34CF868 VA: 0x34D3868 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x34D38E4 Offset: 0x34CF8E4 VA: 0x34D38E4 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x34D3908 Offset: 0x34CF908 VA: 0x34D3908 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x34D392C Offset: 0x34CF92C VA: 0x34D392C
	public void .ctor() { }
}

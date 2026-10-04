// Assembly: System.dll
// Namespace: System.Net
[DefaultMember("Item")]
[Serializable]
internal class PathList // TypeDefIndex: 14449
{
	// Fields
	private SortedList m_list; // 0x10

	// Properties
	public int Count { get; }
	public ICollection Values { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x34FD8E8 Offset: 0x34F98E8 VA: 0x34FD8E8
	public void .ctor() { }

	// RVA: 0x34FF600 Offset: 0x34FB600 VA: 0x34FF600
	public int get_Count() { }

	// RVA: 0x34FD994 Offset: 0x34F9994 VA: 0x34FD994
	public int GetCookiesCount() { }

	// RVA: 0x34FF470 Offset: 0x34FB470 VA: 0x34FF470
	public ICollection get_Values() { }

	// RVA: 0x34FDE04 Offset: 0x34F9E04 VA: 0x34FDE04
	public object get_Item(string s) { }

	// RVA: 0x34FDE28 Offset: 0x34F9E28 VA: 0x34FDE28
	public void set_Item(string s, object value) { }

	// RVA: 0x3500C6C Offset: 0x34FCC6C VA: 0x3500C6C
	public IEnumerator GetEnumerator() { }

	// RVA: 0x34FDDE0 Offset: 0x34F9DE0 VA: 0x34FDDE0
	public object get_SyncRoot() { }
}

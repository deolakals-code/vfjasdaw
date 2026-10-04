// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Group>))]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class GroupCollection : IList<Group>, ICollection<Group>, IEnumerable<Group>, IEnumerable, IReadOnlyList<Group>, IReadOnlyCollection<Group>, IList, ICollection // TypeDefIndex: 14066
{
	// Fields
	private readonly Match _match; // 0x10
	private readonly Hashtable _captureMap; // 0x18
	private Group[] _groups; // 0x20

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	public Group Item { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x346A8B0 Offset: 0x34668B0 VA: 0x346A8B0
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x346A8F4 Offset: 0x34668F4 VA: 0x346A8F4 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x346A8FC Offset: 0x34668FC VA: 0x346A8FC Slot: 32
	public int get_Count() { }

	// RVA: 0x346A920 Offset: 0x3466920 VA: 0x346A920 Slot: 18
	public Group get_Item(int groupnum) { }

	// RVA: 0x346AA28 Offset: 0x3466A28 VA: 0x346AA28 Slot: 17
	public IEnumerator GetEnumerator() { }

	// RVA: 0x346AAD4 Offset: 0x3466AD4 VA: 0x346AAD4 Slot: 16
	private IEnumerator<Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }

	// RVA: 0x346A924 Offset: 0x3466924 VA: 0x346A924
	private Group GetGroup(int groupnum) { }

	// RVA: 0x346AB44 Offset: 0x3466B44 VA: 0x346AB44
	private Group GetGroupImpl(int groupnum) { }

	// RVA: 0x346AE74 Offset: 0x3466E74 VA: 0x346AE74 Slot: 34
	public bool get_IsSynchronized() { }

	// RVA: 0x346AE7C Offset: 0x3466E7C VA: 0x346AE7C Slot: 33
	public object get_SyncRoot() { }

	// RVA: 0x346AE84 Offset: 0x3466E84 VA: 0x346AE84 Slot: 31
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x346AF40 Offset: 0x3466F40 VA: 0x346AF40 Slot: 14
	public void CopyTo(Group[] array, int arrayIndex) { }

	// RVA: 0x346B0C0 Offset: 0x34670C0 VA: 0x346B0C0 Slot: 6
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item) { }

	// RVA: 0x346B178 Offset: 0x3467178 VA: 0x346B178 Slot: 7
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item) { }

	// RVA: 0x346B1C4 Offset: 0x34671C4 VA: 0x346B1C4 Slot: 8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }

	// RVA: 0x346B210 Offset: 0x3467210 VA: 0x346B210 Slot: 4
	private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index) { }

	// RVA: 0x346B214 Offset: 0x3467214 VA: 0x346B214 Slot: 5
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, Group value) { }

	// RVA: 0x346B260 Offset: 0x3467260 VA: 0x346B260 Slot: 11
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item) { }

	// RVA: 0x346B2AC Offset: 0x34672AC VA: 0x346B2AC Slot: 12
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }

	// RVA: 0x346B2F8 Offset: 0x34672F8 VA: 0x346B2F8 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item) { }

	// RVA: 0x346B3AC Offset: 0x34673AC VA: 0x346B3AC Slot: 15
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item) { }

	// RVA: 0x346B3F8 Offset: 0x34673F8 VA: 0x346B3F8 Slot: 22
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x346B444 Offset: 0x3467444 VA: 0x346B444 Slot: 24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x346B490 Offset: 0x3467490 VA: 0x346B490 Slot: 23
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x346B584 Offset: 0x3467584 VA: 0x346B584 Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x346B678 Offset: 0x3467678 VA: 0x346B678 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x346B6C4 Offset: 0x34676C4 VA: 0x346B6C4 Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x346B6CC Offset: 0x34676CC VA: 0x346B6CC Slot: 29
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x346B718 Offset: 0x3467718 VA: 0x346B718 Slot: 30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x346B764 Offset: 0x3467764 VA: 0x346B764 Slot: 20
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x346B768 Offset: 0x3467768 VA: 0x346B768 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x346B7B4 Offset: 0x34677B4 VA: 0x346B7B4
	internal void .ctor() { }
}

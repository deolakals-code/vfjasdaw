// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Match>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class MatchCollection : IList<Match>, ICollection<Match>, IEnumerable<Match>, IEnumerable, IReadOnlyList<Match>, IReadOnlyCollection<Match>, IList, ICollection // TypeDefIndex: 14070
{
	// Fields
	private readonly Regex _regex; // 0x10
	private readonly List<Match> _matches; // 0x18
	private bool _done; // 0x20
	private readonly string _input; // 0x28
	private readonly int _beginning; // 0x30
	private readonly int _length; // 0x34
	private int _startat; // 0x38
	private int _prevlen; // 0x3C

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	public virtual Match Item { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x346C854 Offset: 0x3468854 VA: 0x346C854
	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x346C9A8 Offset: 0x34689A8 VA: 0x346C9A8 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x346C9B0 Offset: 0x34689B0 VA: 0x346C9B0 Slot: 32
	public int get_Count() { }

	// RVA: 0x346CA20 Offset: 0x3468A20 VA: 0x346CA20 Slot: 35
	public virtual Match get_Item(int i) { }

	// RVA: 0x346CBF4 Offset: 0x3468BF4 VA: 0x346CBF4 Slot: 17
	public IEnumerator GetEnumerator() { }

	// RVA: 0x346CCA0 Offset: 0x3468CA0 VA: 0x346CCA0 Slot: 16
	private IEnumerator<Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { }

	// RVA: 0x346CA80 Offset: 0x3468A80 VA: 0x346CA80
	private Match GetMatch(int i) { }

	// RVA: 0x346CA0C Offset: 0x3468A0C VA: 0x346CA0C
	private void EnsureInitialized() { }

	// RVA: 0x346CD10 Offset: 0x3468D10 VA: 0x346CD10 Slot: 34
	public bool get_IsSynchronized() { }

	// RVA: 0x346CD18 Offset: 0x3468D18 VA: 0x346CD18 Slot: 33
	public object get_SyncRoot() { }

	// RVA: 0x346CD1C Offset: 0x3468D1C VA: 0x346CD1C Slot: 31
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x346CDE8 Offset: 0x3468DE8 VA: 0x346CDE8 Slot: 14
	public void CopyTo(Match[] array, int arrayIndex) { }

	// RVA: 0x346CE64 Offset: 0x3468E64 VA: 0x346CE64 Slot: 6
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item) { }

	// RVA: 0x346CED0 Offset: 0x3468ED0 VA: 0x346CED0 Slot: 7
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item) { }

	// RVA: 0x346CF1C Offset: 0x3468F1C VA: 0x346CF1C Slot: 8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) { }

	// RVA: 0x346CF68 Offset: 0x3468F68 VA: 0x346CF68 Slot: 4
	private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index) { }

	// RVA: 0x346CF78 Offset: 0x3468F78 VA: 0x346CF78 Slot: 5
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, Match value) { }

	// RVA: 0x346CFC4 Offset: 0x3468FC4 VA: 0x346CFC4 Slot: 11
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item) { }

	// RVA: 0x346D010 Offset: 0x3469010 VA: 0x346D010 Slot: 12
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }

	// RVA: 0x346D05C Offset: 0x346905C VA: 0x346D05C Slot: 13
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item) { }

	// RVA: 0x346D0C8 Offset: 0x34690C8 VA: 0x346D0C8 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item) { }

	// RVA: 0x346D114 Offset: 0x3469114 VA: 0x346D114 Slot: 22
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x346D160 Offset: 0x3469160 VA: 0x346D160 Slot: 24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x346D1AC Offset: 0x34691AC VA: 0x346D1AC Slot: 23
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x346D2A0 Offset: 0x34692A0 VA: 0x346D2A0 Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x346D394 Offset: 0x3469394 VA: 0x346D394 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x346D3E0 Offset: 0x34693E0 VA: 0x346D3E0 Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x346D3E8 Offset: 0x34693E8 VA: 0x346D3E8 Slot: 29
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x346D434 Offset: 0x3469434 VA: 0x346D434 Slot: 30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x346D480 Offset: 0x3469480 VA: 0x346D480 Slot: 20
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x346D490 Offset: 0x3469490 VA: 0x346D490 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x346D4DC Offset: 0x34694DC VA: 0x346D4DC
	internal void .ctor() { }
}

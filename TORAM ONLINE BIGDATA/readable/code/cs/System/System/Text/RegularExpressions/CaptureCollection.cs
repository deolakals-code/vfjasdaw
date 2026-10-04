// Assembly: System.dll
// Namespace: System.Text.RegularExpressions
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Capture>))]
[DebuggerDisplay("Count = {Count}")]
public class CaptureCollection : IList<Capture>, ICollection<Capture>, IEnumerable<Capture>, IEnumerable, IReadOnlyList<Capture>, IReadOnlyCollection<Capture>, IList, ICollection // TypeDefIndex: 14062
{
	// Fields
	private readonly Group _group; // 0x10
	private readonly int _capcount; // 0x18
	private Capture[] _captures; // 0x20

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	public Capture Item { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x3469900 Offset: 0x3465900 VA: 0x3469900 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x3469908 Offset: 0x3465908 VA: 0x3469908 Slot: 32
	public int get_Count() { }

	// RVA: 0x3469910 Offset: 0x3465910 VA: 0x3469910 Slot: 18
	public Capture get_Item(int i) { }

	// RVA: 0x34699D8 Offset: 0x34659D8 VA: 0x34699D8 Slot: 17
	public IEnumerator GetEnumerator() { }

	// RVA: 0x3469A84 Offset: 0x3465A84 VA: 0x3469A84 Slot: 16
	private IEnumerator<Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator() { }

	// RVA: 0x3469914 Offset: 0x3465914 VA: 0x3469914
	private Capture GetCapture(int i) { }

	// RVA: 0x3469AF4 Offset: 0x3465AF4 VA: 0x3469AF4
	internal void ForceInitialized() { }

	// RVA: 0x3469C7C Offset: 0x3465C7C VA: 0x3469C7C Slot: 34
	public bool get_IsSynchronized() { }

	// RVA: 0x3469C84 Offset: 0x3465C84 VA: 0x3469C84 Slot: 33
	public object get_SyncRoot() { }

	// RVA: 0x3469C8C Offset: 0x3465C8C VA: 0x3469C8C Slot: 31
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x3469D44 Offset: 0x3465D44 VA: 0x3469D44 Slot: 14
	public void CopyTo(Capture[] array, int arrayIndex) { }

	// RVA: 0x3469EB0 Offset: 0x3465EB0 VA: 0x3469EB0 Slot: 6
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(Capture item) { }

	// RVA: 0x3469F60 Offset: 0x3465F60 VA: 0x3469F60 Slot: 7
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, Capture item) { }

	// RVA: 0x3469FAC Offset: 0x3465FAC VA: 0x3469FAC Slot: 8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index) { }

	// RVA: 0x3469FF8 Offset: 0x3465FF8 VA: 0x3469FF8 Slot: 4
	private Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index) { }

	// RVA: 0x3469FFC Offset: 0x3465FFC VA: 0x3469FFC Slot: 5
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, Capture value) { }

	// RVA: 0x346A048 Offset: 0x3466048 VA: 0x346A048 Slot: 11
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(Capture item) { }

	// RVA: 0x346A094 Offset: 0x3466094 VA: 0x346A094 Slot: 12
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear() { }

	// RVA: 0x346A0E0 Offset: 0x34660E0 VA: 0x346A0E0 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(Capture item) { }

	// RVA: 0x346A194 Offset: 0x3466194 VA: 0x346A194 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(Capture item) { }

	// RVA: 0x346A1E0 Offset: 0x34661E0 VA: 0x346A1E0 Slot: 22
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x346A22C Offset: 0x346622C VA: 0x346A22C Slot: 24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x346A278 Offset: 0x3466278 VA: 0x346A278 Slot: 23
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x346A36C Offset: 0x346636C VA: 0x346A36C Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x346A460 Offset: 0x3466460 VA: 0x346A460 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x346A4AC Offset: 0x34664AC VA: 0x346A4AC Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x346A4B4 Offset: 0x34664B4 VA: 0x346A4B4 Slot: 29
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x346A500 Offset: 0x3466500 VA: 0x346A500 Slot: 30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x346A54C Offset: 0x346654C VA: 0x346A54C Slot: 20
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x346A550 Offset: 0x3466550 VA: 0x346A550 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x346A59C Offset: 0x346659C VA: 0x346A59C
	internal void .ctor() { }
}

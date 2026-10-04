// Assembly: Firebase.App.dll
// Namespace: Firebase
[DefaultMember("Item")]
internal class StringList : IDisposable, IEnumerable, IList<string>, ICollection<string>, IEnumerable<string> // TypeDefIndex: 17210
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Properties
	public bool IsReadOnly { get; }
	public string Item { get; set; }
	public int Count { get; }

	// Methods

	// RVA: 0x2654DA8 Offset: 0x2650DA8 VA: 0x2654DA8
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x2654E08 Offset: 0x2650E08 VA: 0x2654E08 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2654EAC Offset: 0x2650EAC VA: 0x2654EAC Slot: 4
	public void Dispose() { }

	// RVA: 0x2654F1C Offset: 0x2650F1C VA: 0x2654F1C Slot: 19
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x2655154 Offset: 0x2651154 VA: 0x2655154 Slot: 12
	public bool get_IsReadOnly() { }

	// RVA: 0x265515C Offset: 0x265115C VA: 0x265515C Slot: 6
	public string get_Item(int index) { }

	// RVA: 0x2655238 Offset: 0x2651238 VA: 0x2655238 Slot: 7
	public void set_Item(int index, string value) { }

	// RVA: 0x2655310 Offset: 0x2651310 VA: 0x2655310 Slot: 11
	public int get_Count() { }

	// RVA: 0x26553DC Offset: 0x26513DC VA: 0x26553DC Slot: 16
	public void CopyTo(string[] array, int arrayIndex) { }

	// RVA: 0x2655414 Offset: 0x2651414 VA: 0x2655414
	public void CopyTo(int index, string[] array, int arrayIndex, int count) { }

	// RVA: 0x26556E8 Offset: 0x26516E8 VA: 0x26556E8 Slot: 18
	private IEnumerator<string> global::System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

	// RVA: 0x26557A4 Offset: 0x26517A4 VA: 0x26557A4 Slot: 5
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26557FC Offset: 0x26517FC VA: 0x26557FC Slot: 14
	public void Clear() { }

	// RVA: 0x2655934 Offset: 0x2651934 VA: 0x2655934 Slot: 13
	public void Add(string x) { }

	// RVA: 0x2655314 Offset: 0x2651314 VA: 0x2655314
	private uint size() { }

	// RVA: 0x2655610 Offset: 0x2651610 VA: 0x2655610
	private string getitemcopy(int index) { }

	// RVA: 0x2655160 Offset: 0x2651160 VA: 0x2655160
	private string getitem(int index) { }

	// RVA: 0x265523C Offset: 0x265123C VA: 0x265523C
	private void setitem(int index, string val) { }

	// RVA: 0x2655CF4 Offset: 0x2651CF4 VA: 0x2655CF4 Slot: 9
	public void Insert(int index, string x) { }

	// RVA: 0x2655E70 Offset: 0x2651E70 VA: 0x2655E70 Slot: 10
	public void RemoveAt(int index) { }

	// RVA: 0x2655FC0 Offset: 0x2651FC0 VA: 0x2655FC0 Slot: 15
	public bool Contains(string value) { }

	// RVA: 0x265613C Offset: 0x265213C VA: 0x265613C Slot: 8
	public int IndexOf(string value) { }

	// RVA: 0x26562B4 Offset: 0x26522B4 VA: 0x26562B4 Slot: 17
	public bool Remove(string value) { }
}

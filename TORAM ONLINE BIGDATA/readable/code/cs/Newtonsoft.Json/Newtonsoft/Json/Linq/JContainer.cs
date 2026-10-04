// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, IBindingList, ICollection, IList // TypeDefIndex: 16038
{
	// Fields
	[Nullable(2)]
	internal ListChangedEventHandler _listChanged; // 0x30
	[Nullable(2)]
	internal NotifyCollectionChangedEventHandler _collectionChanged; // 0x38
	[Nullable(2)]
	private object _syncRoot; // 0x40
	private bool _busy; // 0x48

	// Properties
	protected abstract IList<JToken> ChildrenTokens { get; }
	public override bool HasValues { get; }
	[Nullable(2)]
	public override JToken First { get; }
	[Nullable(2)]
	public override JToken Last { get; }
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item { get; set; }
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	[Nullable(2)]
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 46
	protected abstract IList<JToken> get_ChildrenTokens();

	// RVA: 0x30C1D18 Offset: 0x30BDD18 VA: 0x30C1D18
	internal void .ctor() { }

	// RVA: 0x30C1E0C Offset: 0x30BDE0C VA: 0x30C1E0C
	internal void .ctor(JContainer other, JsonCloneSettings settings) { }

	// RVA: 0x30C3360 Offset: 0x30BF360 VA: 0x30C3360
	internal void CheckReentrancy() { }

	// RVA: 0x30C3408 Offset: 0x30BF408 VA: 0x30C3408 Slot: 47
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x30C3490 Offset: 0x30BF490 VA: 0x30C3490 Slot: 48
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	// RVA: 0x30C3518 Offset: 0x30BF518 VA: 0x30C3518 Slot: 13
	public override bool get_HasValues() { }

	[NullableContext(2)]
	// RVA: 0x30C35D8 Offset: 0x30BF5D8 VA: 0x30C35D8 Slot: 14
	public override JToken get_First() { }

	[NullableContext(2)]
	// RVA: 0x30C3714 Offset: 0x30BF714 VA: 0x30C3714 Slot: 15
	public override JToken get_Last() { }

	// RVA: 0x30C3850 Offset: 0x30BF850 VA: 0x30C3850 Slot: 16
	public override JEnumerable<JToken> Children() { }

	[NullableContext(2)]
	// RVA: 0x30C38C4 Offset: 0x30BF8C4 VA: 0x30C38C4
	internal bool IsMultiContent(object content) { }

	// RVA: 0x30C39A8 Offset: 0x30BF9A8 VA: 0x30C39A8
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 49
	internal abstract int IndexOfItem(JToken item);

	[NullableContext(2)]
	// RVA: 0x30C3B14 Offset: 0x30BFB14 VA: 0x30C3B14 Slot: 50
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x30C3F48 Offset: 0x30BFF48 VA: 0x30C3F48 Slot: 51
	internal virtual void RemoveItemAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x30C43DC Offset: 0x30C03DC VA: 0x30C43DC Slot: 52
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0x30C4428 Offset: 0x30C0428 VA: 0x30C4428 Slot: 53
	internal virtual JToken GetItem(int index) { }

	[NullableContext(2)]
	// RVA: 0x30C44E4 Offset: 0x30C04E4 VA: 0x30C44E4 Slot: 54
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0x30C4AAC Offset: 0x30C0AAC VA: 0x30C4AAC Slot: 55
	internal virtual void ClearItems() { }

	// RVA: 0x30C4EF0 Offset: 0x30C0EF0 VA: 0x30C4EF0 Slot: 56
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	[NullableContext(2)]
	// RVA: 0x30C4F54 Offset: 0x30C0F54 VA: 0x30C4F54 Slot: 57
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0x30C4F78 Offset: 0x30C0F78 VA: 0x30C4F78 Slot: 58
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0x30C4A00 Offset: 0x30C0A00 VA: 0x30C4A00
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0x30C5458 Offset: 0x30C1458 VA: 0x30C5458 Slot: 59
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	[NullableContext(2)]
	// RVA: 0x30C5574 Offset: 0x30C1574 VA: 0x30C5574 Slot: 60
	public virtual void Add(object content) { }

	[NullableContext(2)]
	// RVA: 0x30C5644 Offset: 0x30C1644 VA: 0x30C5644
	internal bool TryAdd(object content) { }

	// RVA: 0x30C5714 Offset: 0x30C1714 VA: 0x30C5714
	internal void AddAndSkipParentCheck(JToken token) { }

	[NullableContext(2)]
	// RVA: 0x30C2FC4 Offset: 0x30BEFC4 VA: 0x30C2FC4
	internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x30C57E4 Offset: 0x30C17E4 VA: 0x30C57E4
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0x30C58C8 Offset: 0x30C18C8 VA: 0x30C58C8
	public void RemoveAll() { }

	// RVA: 0x30C25B8 Offset: 0x30BE5B8 VA: 0x30C25B8
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0x30C58D8 Offset: 0x30C18D8 VA: 0x30C58D8
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x30C5E10 Offset: 0x30C1E10 VA: 0x30C5E10
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	// RVA: 0x30C6288 Offset: 0x30C2288 VA: 0x30C6288 Slot: 21
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0x30C6298 Offset: 0x30C2298 VA: 0x30C6298 Slot: 22
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0x30C62B0 Offset: 0x30C22B0 VA: 0x30C62B0 Slot: 23
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0x30C62C0 Offset: 0x30C22C0 VA: 0x30C62C0 Slot: 19
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0x30C62D0 Offset: 0x30C22D0 VA: 0x30C62D0 Slot: 20
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0x30C62E0 Offset: 0x30C22E0 VA: 0x30C62E0 Slot: 26
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0x30C62F0 Offset: 0x30C22F0 VA: 0x30C62F0 Slot: 27
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0x30C6300 Offset: 0x30C2300 VA: 0x30C6300 Slot: 28
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0x30C6310 Offset: 0x30C2310 VA: 0x30C6310 Slot: 29
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x30C6320 Offset: 0x30C2320 VA: 0x30C6320 Slot: 25
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0x30C6328 Offset: 0x30C2328 VA: 0x30C6328 Slot: 30
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x30C6338 Offset: 0x30C2338 VA: 0x30C6338
	private JToken EnsureValue(object value) { }

	[NullableContext(2)]
	// RVA: 0x30C63F4 Offset: 0x30C23F4 VA: 0x30C63F4 Slot: 33
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x30C642C Offset: 0x30C242C VA: 0x30C642C Slot: 35
	private void System.Collections.IList.Clear() { }

	[NullableContext(2)]
	// RVA: 0x30C643C Offset: 0x30C243C VA: 0x30C643C Slot: 34
	private bool System.Collections.IList.Contains(object value) { }

	[NullableContext(2)]
	// RVA: 0x30C6464 Offset: 0x30C2464 VA: 0x30C6464 Slot: 38
	private int System.Collections.IList.IndexOf(object value) { }

	[NullableContext(2)]
	// RVA: 0x30C648C Offset: 0x30C248C VA: 0x30C648C Slot: 39
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x30C64D0 Offset: 0x30C24D0 VA: 0x30C64D0 Slot: 37
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x30C64D8 Offset: 0x30C24D8 VA: 0x30C64D8 Slot: 36
	private bool System.Collections.IList.get_IsReadOnly() { }

	[NullableContext(2)]
	// RVA: 0x30C64E0 Offset: 0x30C24E0 VA: 0x30C64E0 Slot: 40
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x30C6508 Offset: 0x30C2508 VA: 0x30C6508 Slot: 41
	private void System.Collections.IList.RemoveAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x30C6518 Offset: 0x30C2518 VA: 0x30C6518 Slot: 31
	private object System.Collections.IList.get_Item(int index) { }

	[NullableContext(2)]
	// RVA: 0x30C6528 Offset: 0x30C2528 VA: 0x30C6528 Slot: 32
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x30C6564 Offset: 0x30C2564 VA: 0x30C6564 Slot: 42
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x30C53A4 Offset: 0x30C13A4 VA: 0x30C53A4 Slot: 43
	public int get_Count() { }

	// RVA: 0x30C6574 Offset: 0x30C2574 VA: 0x30C6574 Slot: 45
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x30C657C Offset: 0x30C257C VA: 0x30C657C Slot: 44
	private object System.Collections.ICollection.get_SyncRoot() { }
}

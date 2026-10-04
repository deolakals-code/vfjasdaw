// Assembly: Firebase.App.dll
// Namespace: Firebase
[DefaultMember("Item")]
internal class StringStringMap : IDisposable, IDictionary<string, string>, ICollection<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>, IEnumerable // TypeDefIndex: 17208
{
	// Fields
	private HandleRef swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x20

	// Properties
	public string Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }
	public ICollection<string> Keys { get; }
	public ICollection<string> Values { get; }

	// Methods

	// RVA: 0x2652C38 Offset: 0x264EC38 VA: 0x2652C38
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x2652C98 Offset: 0x264EC98 VA: 0x2652C98
	internal static HandleRef getCPtr(StringStringMap obj) { }

	// RVA: 0x2652CDC Offset: 0x264ECDC VA: 0x2652CDC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2652D80 Offset: 0x264ED80 VA: 0x2652D80 Slot: 4
	public void Dispose() { }

	// RVA: 0x2652DF0 Offset: 0x264EDF0 VA: 0x2652DF0 Slot: 22
	public virtual void Dispose(bool disposing) { }

	// RVA: 0x2653028 Offset: 0x264F028 VA: 0x2653028 Slot: 5
	public string get_Item(string key) { }

	// RVA: 0x2653104 Offset: 0x264F104 VA: 0x2653104 Slot: 6
	public void set_Item(string key, string value) { }

	// RVA: 0x26531DC Offset: 0x264F1DC VA: 0x26531DC Slot: 12
	public bool TryGetValue(string key, out string value) { }

	// RVA: 0x2653318 Offset: 0x264F318 VA: 0x2653318 Slot: 13
	public int get_Count() { }

	// RVA: 0x26533E4 Offset: 0x264F3E4 VA: 0x26533E4 Slot: 14
	public bool get_IsReadOnly() { }

	// RVA: 0x26533EC Offset: 0x264F3EC VA: 0x26533EC Slot: 7
	public ICollection<string> get_Keys() { }

	// RVA: 0x265379C Offset: 0x264F79C VA: 0x265379C Slot: 8
	public ICollection<string> get_Values() { }

	// RVA: 0x2653CD0 Offset: 0x264FCD0 VA: 0x2653CD0 Slot: 15
	public void Add(KeyValuePair<string, string> item) { }

	// RVA: 0x2653E04 Offset: 0x264FE04 VA: 0x2653E04 Slot: 19
	public bool Remove(KeyValuePair<string, string> item) { }

	// RVA: 0x2653E7C Offset: 0x264FE7C VA: 0x2653E7C Slot: 17
	public bool Contains(KeyValuePair<string, string> item) { }

	// RVA: 0x2653FBC Offset: 0x264FFBC VA: 0x2653FBC Slot: 18
	public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex) { }

	// RVA: 0x2654318 Offset: 0x2650318 VA: 0x2654318 Slot: 20
	private IEnumerator<KeyValuePair<string, string>> global::System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	// RVA: 0x2654458 Offset: 0x2650458 VA: 0x2654458 Slot: 21
	private IEnumerator global::System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26539F4 Offset: 0x264F9F4 VA: 0x26539F4
	public StringStringMap.StringStringMapEnumerator GetEnumerator() { }

	// RVA: 0x26544B0 Offset: 0x26504B0 VA: 0x26544B0
	public void .ctor() { }

	// RVA: 0x265331C Offset: 0x264F31C VA: 0x265331C
	private uint size() { }

	// RVA: 0x2654654 Offset: 0x2650654 VA: 0x2654654 Slot: 16
	public void Clear() { }

	// RVA: 0x265302C Offset: 0x264F02C VA: 0x265302C
	private string getitem(string key) { }

	// RVA: 0x2653108 Offset: 0x264F108 VA: 0x2653108
	private void setitem(string key, string x) { }

	// RVA: 0x2653240 Offset: 0x264F240 VA: 0x2653240 Slot: 9
	public bool ContainsKey(string key) { }

	// RVA: 0x2653D30 Offset: 0x264FD30 VA: 0x2653D30 Slot: 10
	public void Add(string key, string value) { }

	// RVA: 0x2653EE4 Offset: 0x264FEE4 VA: 0x2653EE4 Slot: 11
	public bool Remove(string key) { }

	// RVA: 0x2653530 Offset: 0x264F530 VA: 0x2653530
	private IntPtr create_iterator_begin() { }

	// RVA: 0x26535F8 Offset: 0x264F5F8 VA: 0x26535F8
	private string get_next_key(IntPtr swigiterator) { }

	// RVA: 0x26536D0 Offset: 0x264F6D0 VA: 0x26536D0
	private void destroy_iterator(IntPtr swigiterator) { }
}

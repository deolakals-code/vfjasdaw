// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[DefaultMember("Item")]
[Serializable]
internal class MessageDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 10313
{
	// Fields
	private IDictionary _internalProperties; // 0x10
	protected IMethodMessage _message; // 0x18
	private string[] _methodKeys; // 0x20
	private bool _ownProperties; // 0x28

	// Properties
	internal IDictionary InternalDictionary { get; }
	public string[] MethodKeys { set; }
	public bool IsReadOnly { get; }
	public object Item { get; set; }
	public ICollection Keys { get; }
	public ICollection Values { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x2EF2458 Offset: 0x2EEE458 VA: 0x2EF2458
	public void .ctor(IMethodMessage message) { }

	// RVA: 0x2EEEFE0 Offset: 0x2EEAFE0 VA: 0x2EEEFE0
	internal bool HasUserData() { }

	// RVA: 0x2EEF0DC Offset: 0x2EEB0DC VA: 0x2EEF0DC
	internal IDictionary get_InternalDictionary() { }

	// RVA: 0x2EF514C Offset: 0x2EF114C VA: 0x2EF514C
	public void set_MethodKeys(string[] value) { }

	// RVA: 0x2EF5154 Offset: 0x2EF1154 VA: 0x2EF5154 Slot: 19
	protected virtual IDictionary AllocInternalProperties() { }

	// RVA: 0x2EF1528 Offset: 0x2EED528 VA: 0x2EF1528
	public IDictionary GetInternalProperties() { }

	// RVA: 0x2EF51B4 Offset: 0x2EF11B4 VA: 0x2EF51B4
	private bool IsOverridenKey(string key) { }

	// RVA: 0x2EF523C Offset: 0x2EF123C VA: 0x2EF523C Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x2EF5244 Offset: 0x2EF1244 VA: 0x2EF5244 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x2EF5384 Offset: 0x2EF1384 VA: 0x2EF5384 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x2EF2854 Offset: 0x2EEE854 VA: 0x2EF2854 Slot: 20
	protected virtual object GetMethodProperty(string key) { }

	// RVA: 0x2EF3020 Offset: 0x2EEF020 VA: 0x2EF3020 Slot: 21
	protected virtual void SetMethodProperty(string key, object value) { }

	// RVA: 0x2EF5508 Offset: 0x2EF1508 VA: 0x2EF5508 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x2EF5948 Offset: 0x2EF1948 VA: 0x2EF5948 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x2EF5388 Offset: 0x2EF1388 VA: 0x2EF5388 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x2EF5D70 Offset: 0x2EF1D70 VA: 0x2EF5D70 Slot: 10
	public void Clear() { }

	// RVA: 0x2EF5E1C Offset: 0x2EF1E1C VA: 0x2EF5E1C Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x2EF5F58 Offset: 0x2EF1F58 VA: 0x2EF5F58 Slot: 13
	public void Remove(object key) { }

	// RVA: 0x2EF60DC Offset: 0x2EF20DC VA: 0x2EF60DC Slot: 15
	public int get_Count() { }

	// RVA: 0x2EF61A4 Offset: 0x2EF21A4 VA: 0x2EF61A4 Slot: 17
	public bool get_IsSynchronized() { }

	// RVA: 0x2EF61AC Offset: 0x2EF21AC VA: 0x2EF61AC Slot: 16
	public object get_SyncRoot() { }

	// RVA: 0x2EF61B0 Offset: 0x2EF21B0 VA: 0x2EF61B0 Slot: 14
	public void CopyTo(Array array, int index) { }

	// RVA: 0x2EF6270 Offset: 0x2EF2270 VA: 0x2EF6270 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2EF63CC Offset: 0x2EF23CC VA: 0x2EF63CC Slot: 12
	public IDictionaryEnumerator GetEnumerator() { }
}

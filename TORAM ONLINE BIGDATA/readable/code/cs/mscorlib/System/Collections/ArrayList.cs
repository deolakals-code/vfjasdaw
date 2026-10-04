// Assembly: mscorlib.dll
// Namespace: System.Collections
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ArrayList.ArrayListDebugView))]
[DefaultMember("Item")]
[Serializable]
public class ArrayList : IList, ICollection, IEnumerable, ICloneable // TypeDefIndex: 10899
{
	// Fields
	private object[] _items; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public virtual int Capacity { set; }
	public virtual int Count { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x2FBC254 Offset: 0x2FB8254 VA: 0x2FBC254
	public void .ctor() { }

	// RVA: 0x2FBC2F8 Offset: 0x2FB82F8 VA: 0x2FBC2F8
	public void .ctor(int capacity) { }

	// RVA: 0x2FBC450 Offset: 0x2FB8450 VA: 0x2FBC450
	public void .ctor(ICollection c) { }

	// RVA: 0x2FBC61C Offset: 0x2FB861C VA: 0x2FBC61C Slot: 21
	public virtual void set_Capacity(int value) { }

	// RVA: 0x2FBC74C Offset: 0x2FB874C VA: 0x2FBC74C Slot: 22
	public virtual int get_Count() { }

	// RVA: 0x2FBC754 Offset: 0x2FB8754 VA: 0x2FBC754 Slot: 23
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x2FBC75C Offset: 0x2FB875C VA: 0x2FBC75C Slot: 24
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x2FBC764 Offset: 0x2FB8764 VA: 0x2FBC764 Slot: 25
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x2FBC76C Offset: 0x2FB876C VA: 0x2FBC76C Slot: 26
	public virtual object get_SyncRoot() { }

	// RVA: 0x2FBC7DC Offset: 0x2FB87DC VA: 0x2FBC7DC Slot: 27
	public virtual object get_Item(int index) { }

	// RVA: 0x2FBC880 Offset: 0x2FB8880 VA: 0x2FBC880 Slot: 28
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x2FBC970 Offset: 0x2FB8970 VA: 0x2FBC970
	public static ArrayList Adapter(IList list) { }

	// RVA: 0x2FBCA58 Offset: 0x2FB8A58 VA: 0x2FBCA58 Slot: 29
	public virtual int Add(object value) { }

	// RVA: 0x2FBCB64 Offset: 0x2FB8B64 VA: 0x2FBCB64 Slot: 30
	public virtual void AddRange(ICollection c) { }

	// RVA: 0x2FBCB80 Offset: 0x2FB8B80 VA: 0x2FBCB80 Slot: 31
	public virtual void Clear() { }

	// RVA: 0x2FBCBBC Offset: 0x2FB8BBC VA: 0x2FBCBBC Slot: 32
	public virtual object Clone() { }

	// RVA: 0x2FBCC44 Offset: 0x2FB8C44 VA: 0x2FBCC44 Slot: 33
	public virtual bool Contains(object item) { }

	// RVA: 0x2FBCD10 Offset: 0x2FB8D10 VA: 0x2FBCD10 Slot: 34
	public virtual void CopyTo(Array array) { }

	// RVA: 0x2FBCD24 Offset: 0x2FB8D24 VA: 0x2FBCD24 Slot: 35
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2FBCDD0 Offset: 0x2FB8DD0 VA: 0x2FBCDD0 Slot: 36
	public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x2FBCB08 Offset: 0x2FB8B08 VA: 0x2FBCB08
	private void EnsureCapacity(int min) { }

	// RVA: 0x2FBCED0 Offset: 0x2FB8ED0 VA: 0x2FBCED0 Slot: 37
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2FBD044 Offset: 0x2FB9044 VA: 0x2FBD044 Slot: 38
	public virtual int IndexOf(object value) { }

	// RVA: 0x2FBD05C Offset: 0x2FB905C VA: 0x2FBD05C Slot: 39
	public virtual void Insert(int index, object value) { }

	// RVA: 0x2FBD194 Offset: 0x2FB9194 VA: 0x2FBD194 Slot: 40
	public virtual void InsertRange(int index, ICollection c) { }

	// RVA: 0x2FBD3F0 Offset: 0x2FB93F0 VA: 0x2FBD3F0
	public static ArrayList ReadOnly(ArrayList list) { }

	// RVA: 0x2FBD4CC Offset: 0x2FB94CC VA: 0x2FBD4CC Slot: 41
	public virtual void Remove(object obj) { }

	// RVA: 0x2FBD50C Offset: 0x2FB950C VA: 0x2FBD50C Slot: 42
	public virtual void RemoveAt(int index) { }

	// RVA: 0x2FBD5F4 Offset: 0x2FB95F4 VA: 0x2FBD5F4 Slot: 43
	public virtual void RemoveRange(int index, int count) { }

	// RVA: 0x2FBD774 Offset: 0x2FB9774 VA: 0x2FBD774 Slot: 44
	public virtual void Sort(IComparer comparer) { }

	// RVA: 0x2FBD7C0 Offset: 0x2FB97C0 VA: 0x2FBD7C0 Slot: 45
	public virtual void Sort(int index, int count, IComparer comparer) { }

	// RVA: 0x2FBD8B8 Offset: 0x2FB98B8 VA: 0x2FBD8B8 Slot: 46
	public virtual object[] ToArray() { }

	// RVA: 0x2FBD998 Offset: 0x2FB9998 VA: 0x2FBD998 Slot: 47
	public virtual Array ToArray(Type type) { }
}

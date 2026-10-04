// Assembly: System.dll
// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class OrderedDictionary : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 14297
{
	// Fields
	private ArrayList _objectsArray; // 0x10
	private Hashtable _objectsTable; // 0x18
	private int _initialCapacity; // 0x20
	private IEqualityComparer _comparer; // 0x28
	private bool _readOnly; // 0x30
	private object _syncRoot; // 0x38
	private SerializationInfo _siInfo; // 0x40

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	public ICollection Keys { get; }
	private ArrayList objectsArray { get; }
	private Hashtable objectsTable { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object Item { get; set; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x34D1B64 Offset: 0x34CDB64 VA: 0x34D1B64
	public void .ctor() { }

	// RVA: 0x34C18B4 Offset: 0x34BD8B4 VA: 0x34C18B4
	public void .ctor(int capacity) { }

	// RVA: 0x34D1B8C Offset: 0x34CDB8C VA: 0x34D1B8C
	public void .ctor(int capacity, IEqualityComparer comparer) { }

	// RVA: 0x34D1BC4 Offset: 0x34CDBC4 VA: 0x34D1BC4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34C1A90 Offset: 0x34BDA90 VA: 0x34C1A90 Slot: 15
	public int get_Count() { }

	// RVA: 0x34D1C78 Offset: 0x34CDC78 VA: 0x34D1C78 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x34D1C80 Offset: 0x34CDC80 VA: 0x34D1C80 Slot: 17
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x34D1C88 Offset: 0x34CDC88 VA: 0x34D1C88 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x34D1BF4 Offset: 0x34CDBF4 VA: 0x34D1BF4
	private ArrayList get_objectsArray() { }

	// RVA: 0x34D1D44 Offset: 0x34CDD44 VA: 0x34D1D44
	private Hashtable get_objectsTable() { }

	// RVA: 0x34D1DD0 Offset: 0x34CDDD0 VA: 0x34D1DD0 Slot: 16
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x34CB4B4 Offset: 0x34C74B4 VA: 0x34CB4B4 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x34C1914 Offset: 0x34BD914 VA: 0x34C1914 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x34C1AB4 Offset: 0x34BDAB4 VA: 0x34C1AB4 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x34D1FC4 Offset: 0x34CDFC4 VA: 0x34D1FC4 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x34D20E8 Offset: 0x34CE0E8 VA: 0x34D20E8 Slot: 10
	public void Clear() { }

	// RVA: 0x34C18E8 Offset: 0x34BD8E8 VA: 0x34C18E8 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x34D217C Offset: 0x34CE17C VA: 0x34D217C Slot: 14
	public void CopyTo(Array array, int index) { }

	// RVA: 0x34D1E44 Offset: 0x34CDE44 VA: 0x34D1E44
	private int IndexOfKey(object key) { }

	// RVA: 0x34CB4E0 Offset: 0x34C74E0 VA: 0x34CB4E0 Slot: 13
	public void Remove(object key) { }

	// RVA: 0x34D21B8 Offset: 0x34CE1B8 VA: 0x34D21B8 Slot: 21
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x34D227C Offset: 0x34CE27C VA: 0x34D227C Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x34D22E8 Offset: 0x34CE2E8 VA: 0x34D22E8 Slot: 22
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34D24BC Offset: 0x34CE4BC VA: 0x34D24BC Slot: 20
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x34D24CC Offset: 0x34CE4CC VA: 0x34D24CC Slot: 23
	protected virtual void OnDeserialization(object sender) { }
}

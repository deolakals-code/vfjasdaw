// Assembly: System.dll
// Namespace: System.Collections.Specialized
[Serializable]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 14305
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private object _syncRoot; // 0x48
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: 0x34D0CE4 Offset: 0x34CCCE4 VA: 0x34D0CE4
	protected void .ctor() { }

	// RVA: 0x34D4A20 Offset: 0x34D0A20 VA: 0x34D4A20
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x34D0DB8 Offset: 0x34CCDB8 VA: 0x34D0DB8
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x34D1B5C Offset: 0x34CDB5C VA: 0x34D1B5C
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x34D0E58 Offset: 0x34CCE58 VA: 0x34D0E58
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34D4C58 Offset: 0x34D0C58 VA: 0x34D4C58 Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x34D53D0 Offset: 0x34D13D0 VA: 0x34D53D0 Slot: 12
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x34D4AAC Offset: 0x34D0AAC VA: 0x34D4AAC
	private void Reset() { }

	// RVA: 0x34D4B7C Offset: 0x34D0B7C VA: 0x34D4B7C
	private void Reset(int capacity) { }

	// RVA: 0x34D5B70 Offset: 0x34D1B70 VA: 0x34D5B70
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x34D5C28 Offset: 0x34D1C28 VA: 0x34D5C28
	protected bool get_IsReadOnly() { }

	// RVA: 0x34D129C Offset: 0x34CD29C VA: 0x34D129C
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x34D1710 Offset: 0x34CD710 VA: 0x34D1710
	protected void BaseRemove(string name) { }

	// RVA: 0x34D1284 Offset: 0x34CD284 VA: 0x34D1284
	protected object BaseGet(string name) { }

	// RVA: 0x34D1620 Offset: 0x34CD620 VA: 0x34D1620
	protected void BaseSet(string name, object value) { }

	// RVA: 0x34D19C8 Offset: 0x34CD9C8 VA: 0x34D19C8
	protected object BaseGet(int index) { }

	// RVA: 0x34D1A68 Offset: 0x34CDA68 VA: 0x34D1A68
	protected string BaseGetKey(int index) { }

	// RVA: 0x34D5C74 Offset: 0x34D1C74 VA: 0x34D5C74 Slot: 13
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x34D5D20 Offset: 0x34D1D20 VA: 0x34D5D20 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x34D5D44 Offset: 0x34D1D44 VA: 0x34D5D44 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x34D6050 Offset: 0x34D2050 VA: 0x34D6050 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x34D60C4 Offset: 0x34D20C4 VA: 0x34D60C4 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x34D60CC Offset: 0x34D20CC VA: 0x34D60CC
	private static void .cctor() { }
}

// Assembly: mscorlib.dll
// Namespace: System.Collections
[DebuggerTypeProxy(typeof(Hashtable.HashtableDebugView))]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 10906
{
	// Fields
	internal const int HashPrime = 101;
	private const int InitialSize = 3;
	private const string LoadFactorName = "LoadFactor";
	private const string VersionName = "Version";
	private const string ComparerName = "Comparer";
	private const string HashCodeProviderName = "HashCodeProvider";
	private const string HashSizeName = "HashSize";
	private const string KeysName = "Keys";
	private const string ValuesName = "Values";
	private const string KeyComparerName = "KeyComparer";
	private Hashtable.bucket[] _buckets; // 0x10
	private int _count; // 0x18
	private int _occupancy; // 0x1C
	private int _loadsize; // 0x20
	private float _loadFactor; // 0x24
	private int _version; // 0x28
	private bool _isWriterInProgress; // 0x2C
	private ICollection _keys; // 0x30
	private ICollection _values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48
	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable; // 0x0

	// Properties
	private static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }
	public virtual object Item { get; set; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsSynchronized { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x2FBFFEC Offset: 0x2FBBFEC VA: 0x2FBFFEC
	private static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	// RVA: 0x2FC0048 Offset: 0x2FBC048 VA: 0x2FC0048
	internal void .ctor(bool trash) { }

	// RVA: 0x2FC0050 Offset: 0x2FBC050 VA: 0x2FC0050
	public void .ctor() { }

	// RVA: 0x2FC030C Offset: 0x2FBC30C VA: 0x2FC030C
	public void .ctor(int capacity) { }

	// RVA: 0x2FC005C Offset: 0x2FBC05C VA: 0x2FC005C
	public void .ctor(int capacity, float loadFactor) { }

	// RVA: 0x2FC0314 Offset: 0x2FBC314 VA: 0x2FC0314
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	// RVA: 0x2FC0340 Offset: 0x2FBC340 VA: 0x2FC0340
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x2FC0374 Offset: 0x2FBC374 VA: 0x2FC0374
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x2FC03A4 Offset: 0x2FBC3A4 VA: 0x2FC03A4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FC040C Offset: 0x2FBC40C VA: 0x2FC040C
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x2FC0460 Offset: 0x2FBC460 VA: 0x2FC0460 Slot: 22
	public virtual void Add(object key, object value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x2FC08C8 Offset: 0x2FBC8C8 VA: 0x2FC08C8 Slot: 23
	public virtual void Clear() { }

	// RVA: 0x2FC09C8 Offset: 0x2FBC9C8 VA: 0x2FC09C8 Slot: 24
	public virtual object Clone() { }

	// RVA: 0x2FC0AE4 Offset: 0x2FBCAE4 VA: 0x2FC0AE4 Slot: 25
	public virtual bool Contains(object key) { }

	// RVA: 0x2FC0AF4 Offset: 0x2FBCAF4 VA: 0x2FC0AF4 Slot: 26
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x2FC0C58 Offset: 0x2FBCC58 VA: 0x2FC0C58
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x2FC0CFC Offset: 0x2FBCCFC VA: 0x2FC0CFC
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x2FC0DFC Offset: 0x2FBCDFC VA: 0x2FC0DFC Slot: 27
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x2FC0F9C Offset: 0x2FBCF9C VA: 0x2FC0F9C
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x2FC1044 Offset: 0x2FBD044 VA: 0x2FC1044 Slot: 28
	public virtual object get_Item(object key) { }

	// RVA: 0x2FC1260 Offset: 0x2FBD260 VA: 0x2FC1260 Slot: 29
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x2FC1268 Offset: 0x2FBD268 VA: 0x2FC1268
	private void expand() { }

	// RVA: 0x2FC1410 Offset: 0x2FBD410 VA: 0x2FC1410
	private void rehash() { }

	// RVA: 0x2FC099C Offset: 0x2FBC99C VA: 0x2FC099C
	private void UpdateVersion() { }

	// RVA: 0x2FC12D8 Offset: 0x2FBD2D8 VA: 0x2FC12D8
	private void rehash(int newsize) { }

	// RVA: 0x2FC152C Offset: 0x2FBD52C VA: 0x2FC152C Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2FC15EC Offset: 0x2FBD5EC VA: 0x2FC15EC Slot: 30
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x2FC1648 Offset: 0x2FBD648 VA: 0x2FC1648 Slot: 31
	protected virtual int GetHash(object key) { }

	// RVA: 0x2FC1710 Offset: 0x2FBD710 VA: 0x2FC1710 Slot: 32
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x2FC1718 Offset: 0x2FBD718 VA: 0x2FC1718 Slot: 33
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x2FC1720 Offset: 0x2FBD720 VA: 0x2FC1720 Slot: 34
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x2FC1828 Offset: 0x2FBD828 VA: 0x2FC1828 Slot: 35
	public virtual ICollection get_Keys() { }

	// RVA: 0x2FC18DC Offset: 0x2FBD8DC VA: 0x2FC18DC Slot: 36
	public virtual ICollection get_Values() { }

	// RVA: 0x2FC0468 Offset: 0x2FBC468 VA: 0x2FC0468
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x2FC142C Offset: 0x2FBD42C VA: 0x2FC142C
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x2FC1990 Offset: 0x2FBD990 VA: 0x2FC1990 Slot: 37
	public virtual void Remove(object key) { }

	// RVA: 0x2FC1B98 Offset: 0x2FBDB98 VA: 0x2FC1B98 Slot: 38
	public virtual object get_SyncRoot() { }

	// RVA: 0x2FC1C08 Offset: 0x2FBDC08 VA: 0x2FC1C08 Slot: 39
	public virtual int get_Count() { }

	// RVA: 0x2FC1C10 Offset: 0x2FBDC10 VA: 0x2FC1C10
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x2FC1CF4 Offset: 0x2FBDCF4 VA: 0x2FC1CF4 Slot: 40
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2FC2230 Offset: 0x2FBE230 VA: 0x2FC2230 Slot: 41
	public virtual void OnDeserialization(object sender) { }
}

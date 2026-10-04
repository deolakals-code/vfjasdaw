// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
public sealed class X509ChainElementCollection : ICollection, IEnumerable // TypeDefIndex: 14145
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsSynchronized { get; }
	public X509ChainElement Item { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x349682C Offset: 0x349282C VA: 0x349682C
	internal void .ctor() { }

	// RVA: 0x3496898 Offset: 0x3492898 VA: 0x3496898 Slot: 5
	public int get_Count() { }

	// RVA: 0x34968BC Offset: 0x34928BC VA: 0x34968BC Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x34968E0 Offset: 0x34928E0 VA: 0x34968E0
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x3496978 Offset: 0x3492978 VA: 0x3496978 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x349699C Offset: 0x349299C VA: 0x349699C Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x34969C0 Offset: 0x34929C0 VA: 0x34969C0
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x3496AD8 Offset: 0x3492AD8 VA: 0x3496AD8 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x3496B34 Offset: 0x3492B34 VA: 0x3496B34
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0x3496BB4 Offset: 0x3492BB4 VA: 0x3496BB4
	internal void Clear() { }

	// RVA: 0x3496BD8 Offset: 0x3492BD8 VA: 0x3496BD8
	internal bool Contains(X509Certificate2 certificate) { }
}

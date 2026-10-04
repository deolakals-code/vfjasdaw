// Assembly: System.dll
// Namespace: System.Security.Cryptography
[DefaultMember("Item")]
public sealed class OidCollection : ICollection, IEnumerable // TypeDefIndex: 14114
{
	// Fields
	private readonly List<Oid> _list; // 0x10

	// Properties
	public Oid Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x348B588 Offset: 0x3487588 VA: 0x348B588
	public void .ctor() { }

	// RVA: 0x348B610 Offset: 0x3487610 VA: 0x348B610
	public int Add(Oid oid) { }

	// RVA: 0x348B6CC Offset: 0x34876CC VA: 0x348B6CC
	public Oid get_Item(int index) { }

	// RVA: 0x348B724 Offset: 0x3487724 VA: 0x348B724 Slot: 5
	public int get_Count() { }

	// RVA: 0x348B76C Offset: 0x348776C VA: 0x348B76C
	public OidEnumerator GetEnumerator() { }

	// RVA: 0x348B818 Offset: 0x3487818 VA: 0x348B818 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x348B81C Offset: 0x348781C VA: 0x348B81C Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x348B9C8 Offset: 0x34879C8 VA: 0x348B9C8 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x348B9D0 Offset: 0x34879D0 VA: 0x348B9D0 Slot: 6
	public object get_SyncRoot() { }
}

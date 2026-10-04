// Assembly: mscorlib.dll
// Namespace: System.Collections
[Serializable]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 10883
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	public virtual int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x2FB7110 Offset: 0x2FB3110 VA: 0x2FB7110
	protected ArrayList get_InnerList() { }

	// RVA: 0x2FB7180 Offset: 0x2FB3180 VA: 0x2FB7180 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x2FB71A4 Offset: 0x2FB31A4 VA: 0x2FB71A4 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x2FB71C8 Offset: 0x2FB31C8 VA: 0x2FB71C8 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x2FB71EC Offset: 0x2FB31EC VA: 0x2FB71EC Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2FB7228 Offset: 0x2FB3228 VA: 0x2FB7228 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x2FB724C Offset: 0x2FB324C VA: 0x2FB724C
	protected void .ctor() { }
}

// Assembly: System.dll
// Namespace: 
[DefaultMember("Item")]
public class TypeConverter.StandardValuesCollection : ICollection, IEnumerable // TypeDefIndex: 14259
{
	// Fields
	private ICollection values; // 0x10
	private Array valueArray; // 0x18

	// Properties
	public int Count { get; }
	public object Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x34C3CE4 Offset: 0x34BFCE4 VA: 0x34C3CE4
	public void .ctor(ICollection values) { }

	// RVA: 0x34C3DA8 Offset: 0x34BFDA8 VA: 0x34C3DA8
	public int get_Count() { }

	// RVA: 0x34C3E64 Offset: 0x34BFE64 VA: 0x34C3E64
	public object get_Item(int index) { }

	// RVA: 0x34C4064 Offset: 0x34C0064 VA: 0x34C4064
	public void CopyTo(Array array, int index) { }

	// RVA: 0x34C411C Offset: 0x34C011C VA: 0x34C411C
	public IEnumerator GetEnumerator() { }

	// RVA: 0x34C41BC Offset: 0x34C01BC VA: 0x34C41BC Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x34C41C0 Offset: 0x34C01C0 VA: 0x34C41C0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x34C41C8 Offset: 0x34C01C8 VA: 0x34C41C8 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x34C41D0 Offset: 0x34C01D0 VA: 0x34C41D0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x34C41D4 Offset: 0x34C01D4 VA: 0x34C41D4 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultMember("Item")]
public sealed class DataRowCollection : InternalDataCollectionBase // TypeDefIndex: 14699
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataRowCollection.DataRowTree _list; // 0x18
	internal int _nullInList; // 0x20

	// Properties
	public override int Count { get; }
	public DataRow Item { get; }

	// Methods

	// RVA: 0x31EF2FC Offset: 0x31EB2FC VA: 0x31EF2FC
	internal void .ctor(DataTable table) { }

	// RVA: 0x31EF3F0 Offset: 0x31EB3F0 VA: 0x31EF3F0 Slot: 9
	public override int get_Count() { }

	// RVA: 0x31E38B8 Offset: 0x31DF8B8 VA: 0x31E38B8
	public DataRow get_Item(int index) { }

	// RVA: 0x31EF440 Offset: 0x31EB440 VA: 0x31EF440
	public void Add(DataRow row) { }

	// RVA: 0x31EF460 Offset: 0x31EB460 VA: 0x31EF460
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0x31EF668 Offset: 0x31EB668 VA: 0x31EF668
	public int IndexOf(DataRow row) { }

	// RVA: 0x31EF700 Offset: 0x31EB700 VA: 0x31EF700
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0x31EF760 Offset: 0x31EB760 VA: 0x31EF760
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0x31EF7C8 Offset: 0x31EB7C8 VA: 0x31EF7C8
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0x31EF840 Offset: 0x31EB840 VA: 0x31EF840
	internal void ArrayClear() { }

	// RVA: 0x31EF890 Offset: 0x31EB890 VA: 0x31EF890
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0x31EF924 Offset: 0x31EB924 VA: 0x31EF924 Slot: 10
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0x31EF98C Offset: 0x31EB98C VA: 0x31EF98C
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0x31EF9F4 Offset: 0x31EB9F4 VA: 0x31EF9F4 Slot: 11
	public override IEnumerator GetEnumerator() { }
}

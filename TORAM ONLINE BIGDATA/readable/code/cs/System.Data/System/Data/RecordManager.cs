// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultMember("Item")]
internal sealed class RecordManager // TypeDefIndex: 14762
{
	// Fields
	private readonly DataTable _table; // 0x10
	private int _lastFreeRecord; // 0x18
	private int _minimumCapacity; // 0x1C
	private int _recordCapacity; // 0x20
	private readonly List<int> _freeRecordList; // 0x28
	private DataRow[] _rows; // 0x30

	// Properties
	internal int LastFreeRecord { get; }
	internal int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; set; }
	internal DataRow Item { get; set; }

	// Methods

	// RVA: 0x320D0B0 Offset: 0x32090B0 VA: 0x320D0B0
	internal void .ctor(DataTable table) { }

	// RVA: 0x320D188 Offset: 0x3209188 VA: 0x320D188
	private void GrowRecordCapacity() { }

	// RVA: 0x320D374 Offset: 0x3209374 VA: 0x320D374
	internal int get_LastFreeRecord() { }

	// RVA: 0x320D37C Offset: 0x320937C VA: 0x320D37C
	internal int get_MinimumCapacity() { }

	// RVA: 0x320D384 Offset: 0x3209384 VA: 0x320D384
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0x320D3C8 Offset: 0x32093C8 VA: 0x320D3C8
	internal int get_RecordCapacity() { }

	// RVA: 0x320D2E4 Offset: 0x32092E4 VA: 0x320D2E4
	internal void set_RecordCapacity(int value) { }

	// RVA: 0x320D298 Offset: 0x3209298 VA: 0x320D298
	internal static int NewCapacity(int capacity) { }

	// RVA: 0x320D2AC Offset: 0x32092AC VA: 0x320D2AC
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0x320D3D0 Offset: 0x32093D0 VA: 0x320D3D0
	internal int NewRecordBase() { }

	// RVA: 0x320D49C Offset: 0x320949C VA: 0x320D49C
	internal void FreeRecord(ref int record) { }

	// RVA: 0x320D654 Offset: 0x3209654 VA: 0x320D654
	internal void Clear(bool clearAll) { }

	// RVA: 0x320D854 Offset: 0x3209854 VA: 0x320D854
	internal DataRow get_Item(int record) { }

	// RVA: 0x320D5EC Offset: 0x32095EC VA: 0x320D5EC
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0x320D884 Offset: 0x3209884 VA: 0x320D884
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0x320D88C Offset: 0x320988C VA: 0x320D88C
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0x320DBA0 Offset: 0x3209BA0 VA: 0x320DBA0
	internal void SetRowCache(DataRow[] newRows) { }
}

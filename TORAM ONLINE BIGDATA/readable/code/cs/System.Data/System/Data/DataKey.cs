// Assembly: System.Data.dll
// Namespace: System.Data
[IsReadOnly]
internal struct DataKey // TypeDefIndex: 14687
{
	// Fields
	private readonly DataColumn[] _columns; // 0x0

	// Properties
	internal DataColumn[] ColumnsReference { get; }
	internal bool HasValue { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x31E4FB4 Offset: 0x31E0FB4 VA: 0x31E4FB4
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0x31E5264 Offset: 0x31E1264 VA: 0x31E5264
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0x31E526C Offset: 0x31E126C VA: 0x31E526C
	internal bool get_HasValue() { }

	// RVA: 0x31E1160 Offset: 0x31DD160 VA: 0x31E1160
	internal DataTable get_Table() { }

	// RVA: 0x31E51CC Offset: 0x31E11CC VA: 0x31E51CC
	internal void CheckState() { }

	// RVA: 0x31E527C Offset: 0x31E127C VA: 0x31E527C
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0x31E5284 Offset: 0x31E1284 VA: 0x31E5284
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0x31E3938 Offset: 0x31DF938 VA: 0x31E3938
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0x31E539C Offset: 0x31E139C VA: 0x31E539C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31E5400 Offset: 0x31E1400 VA: 0x31E5400 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x31E5478 Offset: 0x31E1478 VA: 0x31E5478
	internal bool Equals(DataKey value) { }

	// RVA: 0x31E5530 Offset: 0x31E1530 VA: 0x31E5530
	internal string[] GetColumnNames() { }

	// RVA: 0x31E55FC Offset: 0x31E15FC VA: 0x31E55FC
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0x31E56E8 Offset: 0x31E16E8 VA: 0x31E56E8
	internal object[] GetKeyValues(int record) { }

	// RVA: 0x31E57F8 Offset: 0x31E17F8 VA: 0x31E57F8
	internal Index GetSortIndex() { }

	// RVA: 0x31E5800 Offset: 0x31E1800 VA: 0x31E5800
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0x31E5858 Offset: 0x31E1858 VA: 0x31E5858
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0x31E58DC Offset: 0x31E18DC VA: 0x31E58DC
	internal DataColumn[] ToArray() { }
}

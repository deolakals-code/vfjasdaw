// Assembly: System.Data.dll
// Namespace: System.Data
[TypeConverter(typeof(ExpandableObjectConverter))]
public class DataViewSetting // TypeDefIndex: 14718
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private DataTable _table; // 0x18
	private string _sort; // 0x20
	private string _rowFilter; // 0x28
	private DataViewRowState _rowStateFilter; // 0x30
	private bool _applyDefaultSort; // 0x34

	// Properties
	public bool ApplyDefaultSort { get; }
	public string RowFilter { get; }
	public DataViewRowState RowStateFilter { get; }
	public string Sort { get; }

	// Methods

	// RVA: 0x31F6468 Offset: 0x31F2468 VA: 0x31F6468
	internal void .ctor() { }

	// RVA: 0x31F64E8 Offset: 0x31F24E8 VA: 0x31F64E8
	public bool get_ApplyDefaultSort() { }

	// RVA: 0x31F64F0 Offset: 0x31F24F0 VA: 0x31F64F0
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x31F6508 Offset: 0x31F2508 VA: 0x31F6508
	internal void SetDataTable(DataTable table) { }

	// RVA: 0x31F6520 Offset: 0x31F2520 VA: 0x31F6520
	public string get_RowFilter() { }

	// RVA: 0x31F6528 Offset: 0x31F2528 VA: 0x31F6528
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x31F6530 Offset: 0x31F2530 VA: 0x31F6530
	public string get_Sort() { }
}

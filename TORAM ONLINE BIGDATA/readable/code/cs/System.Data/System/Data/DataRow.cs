// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultMember("Item")]
public class DataRow // TypeDefIndex: 14693
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataColumnCollection _columns; // 0x18
	internal int _oldRecord; // 0x20
	internal int _newRecord; // 0x24
	internal int _tempRecord; // 0x28
	internal long _rowID; // 0x30
	internal DataRowAction _action; // 0x38
	internal bool _inChangingEvent; // 0x3C
	internal bool _inDeletingEvent; // 0x3D
	internal bool _inCascade; // 0x3E
	private DataColumn _lastChangedColumn; // 0x40
	private int _countColumnChange; // 0x48
	private DataError _error; // 0x50
	private int _rbTreeNodeId; // 0x58
	private static int s_objectTypeCount; // 0x0
	internal readonly int _objectID; // 0x5C

	// Properties
	internal DataColumn LastChangedColumn { get; set; }
	internal bool HasPropertyChanged { get; }
	internal int RBTreeNodeId { get; set; }
	public string RowError { get; set; }
	internal long rowID { get; set; }
	public DataRowState RowState { get; }
	public DataTable Table { get; }
	public string Item { set; }
	public object Item { get; set; }
	public object Item { get; }
	public object[] ItemArray { set; }
	public bool HasErrors { get; }

	// Methods

	// RVA: 0x31EBD88 Offset: 0x31E7D88 VA: 0x31EBD88
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0x31EBE3C Offset: 0x31E7E3C VA: 0x31EBE3C
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0x31EBE58 Offset: 0x31E7E58 VA: 0x31EBE58
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0x31EBE6C Offset: 0x31E7E6C VA: 0x31EBE6C
	internal bool get_HasPropertyChanged() { }

	// RVA: 0x31EBE7C Offset: 0x31E7E7C VA: 0x31EBE7C
	internal int get_RBTreeNodeId() { }

	// RVA: 0x31EBE84 Offset: 0x31E7E84 VA: 0x31EBE84
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0x31EBF34 Offset: 0x31E7F34 VA: 0x31EBF34
	public string get_RowError() { }

	// RVA: 0x31EBF90 Offset: 0x31E7F90 VA: 0x31EBF90
	public void set_RowError(string value) { }

	// RVA: 0x31EC0CC Offset: 0x31E80CC VA: 0x31EC0CC
	private void RowErrorChanged() { }

	// RVA: 0x31EC11C Offset: 0x31E811C VA: 0x31EC11C
	internal long get_rowID() { }

	// RVA: 0x31EC124 Offset: 0x31E8124 VA: 0x31EC124
	internal void set_rowID(long value) { }

	// RVA: 0x31EC17C Offset: 0x31E817C VA: 0x31EC17C
	public DataRowState get_RowState() { }

	// RVA: 0x31EC3A0 Offset: 0x31E83A0 VA: 0x31EC3A0
	public DataTable get_Table() { }

	// RVA: 0x31E85D4 Offset: 0x31E45D4 VA: 0x31E85D4
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0x31EC3A8 Offset: 0x31E83A8 VA: 0x31EC3A8
	internal int GetNestedParentCount() { }

	// RVA: 0x31EC470 Offset: 0x31E8470 VA: 0x31EC470
	public void set_Item(string columnName, object value) { }

	// RVA: 0x31EC364 Offset: 0x31E8364 VA: 0x31EC364
	public object get_Item(DataColumn column) { }

	// RVA: 0x31EC504 Offset: 0x31E8504 VA: 0x31EC504
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0x31ECB5C Offset: 0x31E8B5C VA: 0x31ECB5C
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0x31ECC00 Offset: 0x31E8C00 VA: 0x31ECC00
	public void set_ItemArray(object[] value) { }

	// RVA: 0x31ECFE8 Offset: 0x31E8FE8 VA: 0x31ECFE8
	public void AcceptChanges() { }

	[EditorBrowsable(2)]
	// RVA: 0x31ED368 Offset: 0x31E9368 VA: 0x31ED368
	public void BeginEdit() { }

	// RVA: 0x31EC8E0 Offset: 0x31E88E0 VA: 0x31EC8E0
	private bool BeginEditInternal() { }

	[EditorBrowsable(2)]
	// RVA: 0x31EC9F4 Offset: 0x31E89F4 VA: 0x31EC9F4
	public void CancelEdit() { }

	// RVA: 0x31EC804 Offset: 0x31E8804 VA: 0x31EC804
	private void CheckColumn(DataColumn column) { }

	// RVA: 0x31ED36C Offset: 0x31E936C VA: 0x31ED36C
	internal void CheckInTable() { }

	// RVA: 0x31ED3A8 Offset: 0x31E93A8 VA: 0x31ED3A8
	public void Delete() { }

	[EditorBrowsable(2)]
	// RVA: 0x31ECA5C Offset: 0x31E8A5C VA: 0x31ECA5C
	public void EndEdit() { }

	// RVA: 0x31ED408 Offset: 0x31E9408 VA: 0x31ED408
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0x31ED46C Offset: 0x31E946C VA: 0x31ED46C
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x31ED67C Offset: 0x31E967C VA: 0x31ED67C
	public string GetColumnError(DataColumn column) { }

	// RVA: 0x31ED704 Offset: 0x31E9704 VA: 0x31ED704
	public void ClearErrors() { }

	// RVA: 0x31E3910 Offset: 0x31DF910 VA: 0x31E3910
	internal void ClearError(DataColumn column) { }

	// RVA: 0x31ED72C Offset: 0x31E972C VA: 0x31ED72C
	public bool get_HasErrors() { }

	// RVA: 0x31ED770 Offset: 0x31E9770 VA: 0x31ED770
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0x31ED814 Offset: 0x31E9814 VA: 0x31ED814
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0x31ED81C Offset: 0x31E981C VA: 0x31ED81C
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x31EC49C Offset: 0x31E849C VA: 0x31EC49C
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0x31E86A8 Offset: 0x31E46A8 VA: 0x31E86A8
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0x31ED934 Offset: 0x31E9934 VA: 0x31ED934
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x31EDA3C Offset: 0x31E9A3C VA: 0x31EDA3C
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0x31EDAF8 Offset: 0x31E9AF8 VA: 0x31EDAF8
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0x31EDB00 Offset: 0x31E9B00 VA: 0x31EDB00
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x31EDC18 Offset: 0x31E9C18 VA: 0x31EDC18
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0x31EDC20 Offset: 0x31E9C20 VA: 0x31EDC20
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0x31EDC70 Offset: 0x31E9C70 VA: 0x31EDC70
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0x31E6510 Offset: 0x31E2510 VA: 0x31E6510
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0x31EDC90 Offset: 0x31E9C90 VA: 0x31EDC90
	internal int GetCurrentRecordNo() { }

	// RVA: 0x31EC87C Offset: 0x31E887C VA: 0x31EC87C
	internal int GetDefaultRecord() { }

	// RVA: 0x31EDCCC Offset: 0x31E9CCC VA: 0x31EDCCC
	internal int GetOriginalRecordNo() { }

	// RVA: 0x31EC9B8 Offset: 0x31E89B8 VA: 0x31EC9B8
	private int GetProposedRecordNo() { }

	// RVA: 0x31ECBA0 Offset: 0x31E8BA0 VA: 0x31ECBA0
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0x31EDD08 Offset: 0x31E9D08 VA: 0x31EDD08
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0x31EDD44 Offset: 0x31E9D44 VA: 0x31EDD44
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0x31EDD9C Offset: 0x31E9D9C VA: 0x31EDD9C
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0x31EDDA8 Offset: 0x31E9DA8 VA: 0x31EDDA8
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0x31E6720 Offset: 0x31E2720 VA: 0x31E6720
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0x31EDE2C Offset: 0x31E9E2C VA: 0x31EDE2C
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0x31EDE38 Offset: 0x31E9E38 VA: 0x31EDE38
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0x31EDEE0 Offset: 0x31E9EE0 VA: 0x31EDEE0
	public void RejectChanges() { }

	// RVA: 0x31EC158 Offset: 0x31E8158 VA: 0x31EC158
	internal void ResetLastChangedColumn() { }

	// RVA: 0x31EE4D4 Offset: 0x31EA4D4 VA: 0x31EE4D4
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0x31EE5EC Offset: 0x31EA5EC VA: 0x31EE5EC
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0x31EE9DC Offset: 0x31EA9DC VA: 0x31EE9DC
	internal void SetParentRowToDBNull() { }

	// RVA: 0x31EECC0 Offset: 0x31EACC0 VA: 0x31EECC0
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0x31EEE34 Offset: 0x31EAE34 VA: 0x31EEE34
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }
}

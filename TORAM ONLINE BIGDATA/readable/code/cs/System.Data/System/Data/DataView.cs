// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultProperty("Table")]
[DefaultMember("Item")]
[DefaultEvent("PositionChanged")]
public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable // TypeDefIndex: 14714
{
	// Fields
	private DataViewManager _dataViewManager; // 0x20
	private DataTable _table; // 0x28
	private bool _locked; // 0x30
	private Index _index; // 0x38
	private Dictionary<string, Index> _findIndexes; // 0x40
	private string _sort; // 0x48
	private Comparison<DataRow> _comparison; // 0x50
	private IFilter _rowFilter; // 0x58
	private DataViewRowState _recordStates; // 0x60
	private bool _shouldOpen; // 0x64
	private bool _open; // 0x65
	private bool _allowNew; // 0x66
	private bool _allowEdit; // 0x67
	private bool _allowDelete; // 0x68
	private bool _applyDefaultSort; // 0x69
	internal DataRow _addNewRow; // 0x70
	private ListChangedEventArgs _addNewMoved; // 0x78
	private ListChangedEventHandler _onListChanged; // 0x80
	internal static ListChangedEventArgs s_resetEventArgs; // 0x0
	private DataViewRowState _delayedRecordStates; // 0x88
	private bool _fEndInitInProgress; // 0x8C
	private Dictionary<DataRow, DataRowView> _rowViewCache; // 0x90
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; // 0x98
	private DataViewListener _dvListener; // 0xA0
	private static int s_objectTypeCount; // 0x8
	private readonly int _objectID; // 0xA8

	// Properties
	[DefaultValue(True)]
	public bool AllowDelete { get; }
	[DefaultValue(True)]
	public bool AllowNew { get; }
	[Browsable(False)]
	public int Count { get; }
	private int CountFromIndex { get; }
	[Browsable(False)]
	public DataViewManager DataViewManager { get; }
	[Browsable(False)]
	protected bool IsOpen { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	[DefaultValue(22)]
	public DataViewRowState RowStateFilter { get; }
	[DefaultValue("")]
	public string Sort { get; }
	internal Comparison<DataRow> SortComparison { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	[RefreshProperties(1)]
	[TypeConverter(typeof(DataTableTypeConverter))]
	[DefaultValue(null)]
	public DataTable Table { get; }
	private object System.Collections.IList.Item { get; set; }
	public DataRowView Item { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x31F294C Offset: 0x31EE94C VA: 0x31F294C
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0x31F2E98 Offset: 0x31EEE98 VA: 0x31F2E98
	public bool get_AllowDelete() { }

	// RVA: 0x31F2EA0 Offset: 0x31EEEA0 VA: 0x31F2EA0
	public bool get_AllowNew() { }

	// RVA: 0x31F2EA8 Offset: 0x31EEEA8 VA: 0x31F2EA8 Slot: 22
	public int get_Count() { }

	// RVA: 0x31F2EF8 Offset: 0x31EEEF8 VA: 0x31F2EF8
	private int get_CountFromIndex() { }

	// RVA: 0x31F2F14 Offset: 0x31EEF14 VA: 0x31F2F14
	public DataViewManager get_DataViewManager() { }

	// RVA: 0x31F2F1C Offset: 0x31EEF1C VA: 0x31F2F1C
	protected bool get_IsOpen() { }

	// RVA: 0x31F2F24 Offset: 0x31EEF24 VA: 0x31F2F24 Slot: 24
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x31F2F2C Offset: 0x31EEF2C VA: 0x31F2F2C
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x31F2F34 Offset: 0x31EEF34 VA: 0x31F2F34
	public string get_Sort() { }

	// RVA: 0x31F2F88 Offset: 0x31EEF88 VA: 0x31F2F88
	internal Comparison<DataRow> get_SortComparison() { }

	// RVA: 0x31F2F90 Offset: 0x31EEF90 VA: 0x31F2F90 Slot: 23
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x31F2F94 Offset: 0x31EEF94 VA: 0x31F2F94
	public DataTable get_Table() { }

	// RVA: 0x31F2F9C Offset: 0x31EEF9C VA: 0x31F2F9C Slot: 10
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0x31F2FD4 Offset: 0x31EEFD4 VA: 0x31F2FD4 Slot: 11
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0x31F2FB8 Offset: 0x31EEFB8 VA: 0x31F2FB8
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0x31F30F0 Offset: 0x31EF0F0 VA: 0x31F30F0 Slot: 26
	public virtual DataRowView AddNew() { }

	// RVA: 0x31F33D4 Offset: 0x31EF3D4 VA: 0x31F33D4
	private void CheckOpen() { }

	// RVA: 0x31F34DC Offset: 0x31EF4DC VA: 0x31F34DC
	protected void Close() { }

	// RVA: 0x31F3530 Offset: 0x31EF530 VA: 0x31F3530 Slot: 21
	public void CopyTo(Array array, int index) { }

	// RVA: 0x31F36B4 Offset: 0x31EF6B4 VA: 0x31F36B4
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0x31F3874 Offset: 0x31EF874 VA: 0x31F3874
	public void Delete(int index) { }

	// RVA: 0x31F3890 Offset: 0x31EF890 VA: 0x31F3890
	internal void Delete(DataRow row) { }

	// RVA: 0x31F3C10 Offset: 0x31EFC10 VA: 0x31F3C10 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x31F3A5C Offset: 0x31EFA5C VA: 0x31F3A5C
	internal void FinishAddNew(bool success) { }

	// RVA: 0x31F3C44 Offset: 0x31EFC44 VA: 0x31F3C44 Slot: 25
	public IEnumerator GetEnumerator() { }

	// RVA: 0x31F3CC0 Offset: 0x31EFCC0 VA: 0x31F3CC0 Slot: 15
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x31F3CC8 Offset: 0x31EFCC8 VA: 0x31F3CC8 Slot: 16
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x31F3CD0 Offset: 0x31EFCD0 VA: 0x31F3CD0 Slot: 12
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x31F3D24 Offset: 0x31EFD24 VA: 0x31F3D24 Slot: 14
	private void System.Collections.IList.Clear() { }

	// RVA: 0x31F3D4C Offset: 0x31EFD4C VA: 0x31F3D4C Slot: 13
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x31F3DD8 Offset: 0x31EFDD8 VA: 0x31F3DD8 Slot: 17
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x31F340C Offset: 0x31EF40C VA: 0x31F340C
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0x31F3E58 Offset: 0x31EFE58 VA: 0x31F3E58
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0x31F3EB0 Offset: 0x31EFEB0 VA: 0x31F3EB0 Slot: 18
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x31F3ED8 Offset: 0x31EFED8 VA: 0x31F3ED8 Slot: 19
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x31F3FF8 Offset: 0x31EFFF8 VA: 0x31F3FF8 Slot: 20
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x31F4014 Offset: 0x31F0014 VA: 0x31F4014 Slot: 27
	internal virtual IFilter GetFilter() { }

	// RVA: 0x31F401C Offset: 0x31F001C VA: 0x31F401C
	private int GetRecord(int recordIndex) { }

	// RVA: 0x31F2FFC Offset: 0x31EEFFC VA: 0x31F2FFC
	internal DataRow GetRow(int index) { }

	// RVA: 0x31F3680 Offset: 0x31EF680 VA: 0x31F3680
	private DataRowView GetRowView(int record) { }

	// RVA: 0x31F3098 Offset: 0x31EF098 VA: 0x31F3098
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0x31F40A4 Offset: 0x31F00A4 VA: 0x31F40A4 Slot: 28
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0x31F4134 Offset: 0x31F0134 VA: 0x31F4134
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0x31F41F4 Offset: 0x31F01F4 VA: 0x31F41F4
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x31F46AC Offset: 0x31F06AC VA: 0x31F46AC Slot: 29
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x31F49C4 Offset: 0x31F09C4 VA: 0x31F49C4
	protected void Reset() { }

	// RVA: 0x31F4464 Offset: 0x31F0464 VA: 0x31F4464
	internal void ResetRowViewCache() { }

	// RVA: 0x31F49F0 Offset: 0x31F09F0 VA: 0x31F49F0
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x31F4C38 Offset: 0x31F0C38 VA: 0x31F4C38 Slot: 30
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0x31F4C40 Offset: 0x31F0C40 VA: 0x31F4C40
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0x31F3514 Offset: 0x31EF514 VA: 0x31F3514
	protected void UpdateIndex() { }

	// RVA: 0x31F51CC Offset: 0x31F11CC VA: 0x31F51CC Slot: 31
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0x31F4EA4 Offset: 0x31F0EA4 VA: 0x31F4EA4
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0x31F53C4 Offset: 0x31F13C4 VA: 0x31F53C4
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x31F55E8 Offset: 0x31F15E8 VA: 0x31F55E8
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x31F580C Offset: 0x31F180C VA: 0x31F580C Slot: 32
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x31F5A30 Offset: 0x31F1A30 VA: 0x31F5A30
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x31F5A40 Offset: 0x31F1A40 VA: 0x31F5A40
	internal int get_ObjectID() { }

	// RVA: 0x31F5A48 Offset: 0x31F1A48 VA: 0x31F5A48
	private static void .cctor() { }
}

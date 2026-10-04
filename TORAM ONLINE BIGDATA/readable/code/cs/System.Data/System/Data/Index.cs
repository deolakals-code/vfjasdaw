// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class Index // TypeDefIndex: 14771
{
	// Fields
	private readonly DataTable _table; // 0x10
	internal readonly IndexField[] _indexFields; // 0x18
	private readonly Comparison<DataRow> _comparison; // 0x20
	private readonly DataViewRowState _recordStates; // 0x28
	private WeakReference _rowFilter; // 0x30
	private Index.IndexTree _records; // 0x38
	private int _recordCount; // 0x40
	private int _refCount; // 0x44
	private Listeners<DataViewListener> _listeners; // 0x48
	private bool _suspendEvents; // 0x50
	private readonly bool _isSharable; // 0x51
	private readonly bool _hasRemoteAggregate; // 0x52
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x54

	// Properties
	internal bool HasRemoteAggregate { get; }
	internal int ObjectID { get; }
	public DataViewRowState RecordStates { get; }
	public IFilter RowFilter { get; }
	public bool HasDuplicates { get; }
	public int RecordCount { get; }
	public int RefCount { get; }
	private bool DoListChanged { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x320EF34 Offset: 0x320AF34 VA: 0x320EF34
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x320F25C Offset: 0x320B25C VA: 0x320F25C
	public void .ctor(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x320F2B4 Offset: 0x320B2B4 VA: 0x320F2B4
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0x320EF44 Offset: 0x320AF44 VA: 0x320EF44
	private void .ctor(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x320F7B0 Offset: 0x320B7B0 VA: 0x320F7B0
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x320F858 Offset: 0x320B858 VA: 0x320F858
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0x320F860 Offset: 0x320B860 VA: 0x320F860
	internal int get_ObjectID() { }

	// RVA: 0x320F868 Offset: 0x320B868 VA: 0x320F868
	public DataViewRowState get_RecordStates() { }

	// RVA: 0x320F870 Offset: 0x320B870 VA: 0x320F870
	public IFilter get_RowFilter() { }

	// RVA: 0x320F8E8 Offset: 0x320B8E8 VA: 0x320F8E8
	public int GetRecord(int recordIndex) { }

	// RVA: 0x320F940 Offset: 0x320B940 VA: 0x320F940
	public bool get_HasDuplicates() { }

	// RVA: 0x320F990 Offset: 0x320B990 VA: 0x320F990
	public int get_RecordCount() { }

	// RVA: 0x320F998 Offset: 0x320B998 VA: 0x320F998
	private bool AcceptRecord(int record) { }

	// RVA: 0x320F9C4 Offset: 0x320B9C4 VA: 0x320F9C4
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0x320FB58 Offset: 0x320BB58 VA: 0x320FB58
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0x320FBB0 Offset: 0x320BBB0 VA: 0x320FBB0
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0x320FC08 Offset: 0x320BC08 VA: 0x320FC08
	public int get_RefCount() { }

	// RVA: 0x320FC10 Offset: 0x320BC10 VA: 0x320FC10
	public void AddRef() { }

	// RVA: 0x320FE0C Offset: 0x320BE0C VA: 0x320FE0C
	public int RemoveRef() { }

	// RVA: 0x320FFC8 Offset: 0x320BFC8 VA: 0x320FFC8
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0x32103F8 Offset: 0x320C3F8 VA: 0x32103F8
	public bool CheckUnique() { }

	// RVA: 0x3210410 Offset: 0x320C410 VA: 0x3210410
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0x321055C Offset: 0x320C55C VA: 0x321055C
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0x32105C8 Offset: 0x320C5C8 VA: 0x32105C8
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0x3210714 Offset: 0x320C714 VA: 0x3210714
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0x32107E4 Offset: 0x320C7E4 VA: 0x32107E4
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0x3210398 Offset: 0x320C398 VA: 0x3210398
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0x32107EC Offset: 0x320C7EC VA: 0x32107EC
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0x3210ABC Offset: 0x320CABC VA: 0x3210ABC
	public RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex) { }

	// RVA: 0x32103A0 Offset: 0x320C3A0 VA: 0x32103A0
	public int GetIndex(int record) { }

	// RVA: 0x3210260 Offset: 0x320C260 VA: 0x3210260
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0x3206F20 Offset: 0x3202F20 VA: 0x3206F20
	public object[] GetUniqueKeyValues() { }

	// RVA: 0x3210D48 Offset: 0x320CD48 VA: 0x3210D48
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0x3210F5C Offset: 0x320CF5C VA: 0x3210F5C
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0x32111A0 Offset: 0x320D1A0 VA: 0x32111A0
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0x3211294 Offset: 0x320D294 VA: 0x3211294
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0x32113BC Offset: 0x320D3BC VA: 0x32113BC
	public Range FindRecords(object key) { }

	// RVA: 0x320705C Offset: 0x320305C VA: 0x320705C
	public Range FindRecords(object[] key) { }

	// RVA: 0x32113E0 Offset: 0x320D3E0 VA: 0x32113E0
	internal void FireResetEvent() { }

	// RVA: 0x32116C8 Offset: 0x320D6C8 VA: 0x32116C8
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x32116E4 Offset: 0x320D6E4 VA: 0x32116E4
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0x32079C8 Offset: 0x32039C8 VA: 0x32079C8
	public DataRow GetRow(int i) { }

	// RVA: 0x321170C Offset: 0x320D70C VA: 0x321170C
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0x3207080 Offset: 0x3203080 VA: 0x3207080
	public DataRow[] GetRows(Range range) { }

	// RVA: 0x320F3AC Offset: 0x320B3AC VA: 0x320F3AC
	private void InitRecords(IFilter filter) { }

	// RVA: 0x32117A0 Offset: 0x320D7A0 VA: 0x32117A0
	public int InsertRecordToIndex(int record) { }

	// RVA: 0x321006C Offset: 0x320C06C VA: 0x321006C
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0x32117F0 Offset: 0x320D7F0 VA: 0x32117F0
	public bool IsKeyInIndex(object key) { }

	// RVA: 0x3207044 Offset: 0x3203044 VA: 0x3207044
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0x3211808 Offset: 0x320D808 VA: 0x3211808
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0x32114C8 Offset: 0x320D4C8 VA: 0x32114C8
	private bool get_DoListChanged() { }

	// RVA: 0x3211820 Offset: 0x320D820 VA: 0x3211820
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0x3210A2C Offset: 0x320CA2C VA: 0x3210A2C
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0x3211548 Offset: 0x320D548 VA: 0x3211548
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x3210910 Offset: 0x320C910 VA: 0x3210910
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0x32118C0 Offset: 0x320D8C0 VA: 0x32118C0
	public void Reset() { }

	// RVA: 0x3211988 Offset: 0x320D988 VA: 0x3211988
	public void RecordChanged(int record) { }

	// RVA: 0x3211A6C Offset: 0x320DA6C VA: 0x3211A6C
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0x3211BA4 Offset: 0x320DBA4 VA: 0x3211BA4
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x3211CA4 Offset: 0x320DCA4 VA: 0x3211CA4
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0x3212008 Offset: 0x320E008 VA: 0x3212008
	internal DataTable get_Table() { }

	// RVA: 0x3210B24 Offset: 0x320CB24 VA: 0x3210B24
	private void GetUniqueKeyValues(List<object[]> list, int curNodeId) { }

	// RVA: -1 Offset: -1
	internal static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C592C Offset: 0x26C192C VA: 0x26C592C
	|-Index.IndexOfReference<object>
	*/
}

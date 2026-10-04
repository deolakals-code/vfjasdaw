// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultEvent("RowChanging")]
[XmlSchemaProvider("GetDataTableSchema")]
[ToolboxItem(False)]
[DesignTimeVisible(False)]
[DefaultProperty("TableName")]
[Serializable]
public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable // TypeDefIndex: 14661
{
	// Fields
	private DataSet _dataSet; // 0x20
	private DataView _defaultView; // 0x28
	internal long _nextRowID; // 0x30
	internal readonly DataRowCollection _rowCollection; // 0x38
	internal readonly DataColumnCollection _columnCollection; // 0x40
	private readonly ConstraintCollection _constraintCollection; // 0x48
	private int _elementColumnCount; // 0x50
	internal DataRelationCollection _parentRelationsCollection; // 0x58
	internal DataRelationCollection _childRelationsCollection; // 0x60
	internal readonly RecordManager _recordManager; // 0x68
	internal readonly List<Index> _indexes; // 0x70
	private List<Index> _shadowIndexes; // 0x78
	private int _shadowCount; // 0x80
	internal PropertyCollection _extendedProperties; // 0x88
	private string _tableName; // 0x90
	internal string _tableNamespace; // 0x98
	private string _tablePrefix; // 0xA0
	internal DataExpression _displayExpression; // 0xA8
	internal bool _fNestedInDataset; // 0xB0
	private CultureInfo _culture; // 0xB8
	private bool _cultureUserSet; // 0xC0
	private CompareInfo _compareInfo; // 0xC8
	private CompareOptions _compareFlags; // 0xD0
	private IFormatProvider _formatProvider; // 0xD8
	private StringComparer _hashCodeProvider; // 0xE0
	private bool _caseSensitive; // 0xE8
	private bool _caseSensitiveUserSet; // 0xE9
	internal string _encodedTableName; // 0xF0
	internal DataColumn _xmlText; // 0xF8
	internal DataColumn _colUnique; // 0x100
	internal Decimal _minOccurs; // 0x108
	internal Decimal _maxOccurs; // 0x118
	internal bool _repeatableElement; // 0x128
	private object _typeName; // 0x130
	internal UniqueConstraint _primaryKey; // 0x138
	internal IndexField[] _primaryIndex; // 0x140
	private DataColumn[] _delayedSetPrimaryKey; // 0x148
	private Index _loadIndex; // 0x150
	private Index _loadIndexwithOriginalAdded; // 0x158
	private Index _loadIndexwithCurrentDeleted; // 0x160
	private int _suspendIndexEvents; // 0x168
	private bool _inDataLoad; // 0x16C
	private bool _schemaLoading; // 0x16D
	private bool _enforceConstraints; // 0x16E
	internal bool _suspendEnforceConstraints; // 0x16F
	protected internal bool fInitInProgress; // 0x170
	private bool _inLoad; // 0x171
	internal bool _fInLoadDiffgram; // 0x172
	private byte _isTypedDataTable; // 0x173
	private DataRow[] _emptyDataRowArray; // 0x178
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; // 0x180
	private DataRelation[] _nestedParentRelations; // 0x188
	internal List<DataColumn> _dependentColumns; // 0x190
	private bool _mergingData; // 0x198
	private DataRowChangeEventHandler _onRowChangedDelegate; // 0x1A0
	private DataRowChangeEventHandler _onRowChangingDelegate; // 0x1A8
	private DataRowChangeEventHandler _onRowDeletingDelegate; // 0x1B0
	private DataRowChangeEventHandler _onRowDeletedDelegate; // 0x1B8
	private DataColumnChangeEventHandler _onColumnChangedDelegate; // 0x1C0
	private DataColumnChangeEventHandler _onColumnChangingDelegate; // 0x1C8
	private DataTableClearEventHandler _onTableClearingDelegate; // 0x1D0
	private DataTableClearEventHandler _onTableClearedDelegate; // 0x1D8
	private DataTableNewRowEventHandler _onTableNewRowDelegate; // 0x1E0
	private PropertyChangedEventHandler _onPropertyChangingDelegate; // 0x1E8
	private readonly DataRowBuilder _rowBuilder; // 0x1F0
	internal readonly List<DataView> _delayedViews; // 0x1F8
	private readonly List<DataViewListener> _dataViewListeners; // 0x200
	internal Hashtable _rowDiffId; // 0x208
	internal readonly ReaderWriterLockSlim _indexesLock; // 0x210
	internal int _ukColumnPositionForInference; // 0x218
	private SerializationFormat _remotingFormat; // 0x21C
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x220

	// Properties
	public bool CaseSensitive { get; set; }
	internal bool AreIndexEventsSuspended { get; }
	private bool IsTypedDataTable { get; }
	internal bool SelfNested { get; }
	[DebuggerBrowsable(0)]
	internal List<Index> LiveIndexes { get; }
	[DefaultValue(0)]
	public SerializationFormat RemotingFormat { get; set; }
	internal int UKColumnPositionForInference { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataRelationCollection ChildRelations { get; }
	[DesignerSerializationVisibility(2)]
	public DataColumnCollection Columns { get; }
	private CompareInfo CompareInfo { get; }
	[DesignerSerializationVisibility(2)]
	public ConstraintCollection Constraints { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataSet DataSet { get; }
	internal string DisplayExpressionInternal { get; }
	internal bool EnforceConstraints { get; set; }
	internal bool SuspendEnforceConstraints { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal IFormatProvider FormatProvider { get; }
	public CultureInfo Locale { get; set; }
	[DefaultValue(50)]
	public int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; }
	internal int ElementColumnCount { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataRelationCollection ParentRelations { get; }
	internal bool MergingData { get; set; }
	internal DataRelation[] NestedParentRelations { get; }
	internal bool SchemaLoading { get; }
	internal int NestedParentsCount { get; }
	[TypeConverter(typeof(PrimaryKeyTypeConverter))]
	public DataColumn[] PrimaryKey { get; set; }
	[Browsable(False)]
	public DataRowCollection Rows { get; }
	[DefaultValue("")]
	[RefreshProperties(1)]
	public string TableName { get; set; }
	internal string EncodedTableName { get; }
	public string Namespace { get; set; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	internal DataColumn XmlText { get; set; }
	internal Decimal MaxOccurs { get; set; }
	internal Decimal MinOccurs { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public override ISite Site { get; }
	internal bool NeedColumnChangeEvents { get; }
	internal XmlQualifiedName TypeName { get; set; }
	internal Hashtable RowDiffId { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x31A4C80 Offset: 0x31A0C80 VA: 0x31A4C80
	public void .ctor() { }

	// RVA: 0x31A51D8 Offset: 0x31A11D8 VA: 0x31A51D8
	public void .ctor(string tableName) { }

	// RVA: 0x31A5248 Offset: 0x31A1248 VA: 0x31A5248
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x31A56FC Offset: 0x31A16FC VA: 0x31A56FC Slot: 14
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x31A57D4 Offset: 0x31A17D4 VA: 0x31A57D4
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0x31A53E0 Offset: 0x31A13E0 VA: 0x31A53E0
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0x31A5AB4 Offset: 0x31A1AB4 VA: 0x31A5AB4
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0x31A6DD4 Offset: 0x31A2DD4 VA: 0x31A6DD4
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0x31A9CA4 Offset: 0x31A5CA4 VA: 0x31A9CA4
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0x31AAD28 Offset: 0x31A6D28 VA: 0x31AAD28
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0x31ABA74 Offset: 0x31A7A74 VA: 0x31ABA74
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x31ABBD0 Offset: 0x31A7BD0 VA: 0x31ABBD0
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x31A6784 Offset: 0x31A2784 VA: 0x31A6784
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x31A7D08 Offset: 0x31A3D08 VA: 0x31A7D08
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x31ABFEC Offset: 0x31A7FEC VA: 0x31ABFEC
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0x31ABD34 Offset: 0x31A7D34 VA: 0x31ABD34
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0x31AC094 Offset: 0x31A8094 VA: 0x31AC094
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0x31AC368 Offset: 0x31A8368 VA: 0x31AC368
	public bool get_CaseSensitive() { }

	// RVA: 0x31AC370 Offset: 0x31A8370 VA: 0x31AC370
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x31AC410 Offset: 0x31A8410 VA: 0x31AC410
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0x31AC420 Offset: 0x31A8420 VA: 0x31AC420
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0x31AC7D4 Offset: 0x31A87D4 VA: 0x31AC7D4
	internal void SuspendIndexEvents() { }

	// RVA: 0x31AC880 Offset: 0x31A8880 VA: 0x31AC880
	private bool get_IsTypedDataTable() { }

	// RVA: 0x31AA3D8 Offset: 0x31A63D8 VA: 0x31AA3D8
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0x31AC93C Offset: 0x31A893C VA: 0x31AC93C
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0x31AC944 Offset: 0x31A8944 VA: 0x31AC944
	internal bool get_SelfNested() { }

	// RVA: 0x31ACCDC Offset: 0x31A8CDC VA: 0x31ACCDC
	internal List<Index> get_LiveIndexes() { }

	// RVA: 0x31ACD84 Offset: 0x31A8D84 VA: 0x31ACD84
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0x31ACD8C Offset: 0x31A8D8C VA: 0x31ACD8C
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x31ACDEC Offset: 0x31A8DEC VA: 0x31ACDEC
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0x31ACDF4 Offset: 0x31A8DF4 VA: 0x31ACDF4
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0x31ACDFC Offset: 0x31A8DFC VA: 0x31ACDFC
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0x31ACE78 Offset: 0x31A8E78 VA: 0x31ACE78
	public DataColumnCollection get_Columns() { }

	// RVA: 0x31ACE80 Offset: 0x31A8E80 VA: 0x31ACE80
	private CompareInfo get_CompareInfo() { }

	// RVA: 0x31ACED0 Offset: 0x31A8ED0 VA: 0x31ACED0
	public ConstraintCollection get_Constraints() { }

	// RVA: 0x31ACED8 Offset: 0x31A8ED8 VA: 0x31ACED8
	private void ResetConstraints() { }

	// RVA: 0x31ACEF4 Offset: 0x31A8EF4 VA: 0x31ACEF4
	public DataSet get_DataSet() { }

	// RVA: 0x31ACEFC Offset: 0x31A8EFC VA: 0x31ACEFC
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x31ACFC0 Offset: 0x31A8FC0 VA: 0x31ACFC0
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0x31AD024 Offset: 0x31A9024 VA: 0x31AD024
	internal bool get_EnforceConstraints() { }

	// RVA: 0x31AD054 Offset: 0x31A9054 VA: 0x31AD054
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0x31AD66C Offset: 0x31A966C VA: 0x31AD66C
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0x31AD674 Offset: 0x31A9674 VA: 0x31AD674
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0x31AD094 Offset: 0x31A9094 VA: 0x31AD094
	internal void EnableConstraints() { }

	// RVA: 0x31A972C Offset: 0x31A572C VA: 0x31A972C
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x31AD680 Offset: 0x31A9680 VA: 0x31AD680
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x31AD720 Offset: 0x31A9720 VA: 0x31AD720
	public CultureInfo get_Locale() { }

	// RVA: 0x31AD728 Offset: 0x31A9728 VA: 0x31AD728
	public void set_Locale(CultureInfo value) { }

	// RVA: 0x31AA700 Offset: 0x31A6700 VA: 0x31AA700
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0x31ADBE4 Offset: 0x31A9BE4 VA: 0x31ADBE4
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x31ADBEC Offset: 0x31A9BEC VA: 0x31ADBEC
	public int get_MinimumCapacity() { }

	// RVA: 0x31AACF8 Offset: 0x31A6CF8 VA: 0x31AACF8
	public void set_MinimumCapacity(int value) { }

	// RVA: 0x31ADC08 Offset: 0x31A9C08 VA: 0x31ADC08
	internal int get_RecordCapacity() { }

	// RVA: 0x31ADC24 Offset: 0x31A9C24 VA: 0x31ADC24
	internal int get_ElementColumnCount() { }

	// RVA: 0x31ADC2C Offset: 0x31A9C2C VA: 0x31ADC2C
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0x31ACC60 Offset: 0x31A8C60 VA: 0x31ACC60
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0x31ADC70 Offset: 0x31A9C70 VA: 0x31ADC70
	internal bool get_MergingData() { }

	// RVA: 0x31ADC78 Offset: 0x31A9C78 VA: 0x31ADC78
	internal void set_MergingData(bool value) { }

	// RVA: 0x31ADC84 Offset: 0x31A9C84 VA: 0x31ADC84
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0x31ADC8C Offset: 0x31A9C8C VA: 0x31ADC8C
	internal bool get_SchemaLoading() { }

	// RVA: 0x31ADC94 Offset: 0x31A9C94 VA: 0x31ADC94
	internal void CacheNestedParent() { }

	// RVA: 0x31ADCB4 Offset: 0x31A9CB4 VA: 0x31ADCB4
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0x31AE138 Offset: 0x31AA138 VA: 0x31AE138
	internal int get_NestedParentsCount() { }

	// RVA: 0x31AE418 Offset: 0x31AA418 VA: 0x31AE418
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0x31AE4CC Offset: 0x31AA4CC VA: 0x31AE4CC
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0x31AE934 Offset: 0x31AA934 VA: 0x31AE934
	public DataRowCollection get_Rows() { }

	// RVA: 0x31AE93C Offset: 0x31AA93C VA: 0x31AE93C
	public string get_TableName() { }

	// RVA: 0x31AE944 Offset: 0x31AA944 VA: 0x31AE944
	public void set_TableName(string value) { }

	// RVA: 0x31AEF14 Offset: 0x31AAF14 VA: 0x31AEF14
	internal string get_EncodedTableName() { }

	// RVA: 0x31AEF98 Offset: 0x31AAF98 VA: 0x31AEF98
	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	// RVA: 0x31A6D50 Offset: 0x31A2D50 VA: 0x31A6D50
	public string get_Namespace() { }

	// RVA: 0x31A93E4 Offset: 0x31A53E4 VA: 0x31A93E4
	public void set_Namespace(string value) { }

	// RVA: 0x31AFFB4 Offset: 0x31ABFB4 VA: 0x31AFFB4
	internal bool IsNamespaceInherited() { }

	// RVA: 0x31AF1E8 Offset: 0x31AB1E8 VA: 0x31AF1E8
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0x31AF5C4 Offset: 0x31AB5C4 VA: 0x31AF5C4
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0x31AFFC4 Offset: 0x31ABFC4 VA: 0x31AFFC4
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0x31AF9E8 Offset: 0x31AB9E8 VA: 0x31AF9E8
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0x31B0344 Offset: 0x31AC344 VA: 0x31B0344
	public string get_Prefix() { }

	// RVA: 0x31B034C Offset: 0x31AC34C VA: 0x31B034C
	public void set_Prefix(string value) { }

	// RVA: 0x31B04B4 Offset: 0x31AC4B4 VA: 0x31B04B4
	internal DataColumn get_XmlText() { }

	// RVA: 0x31B04BC Offset: 0x31AC4BC VA: 0x31B04BC
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0x31B057C Offset: 0x31AC57C VA: 0x31B057C
	internal Decimal get_MaxOccurs() { }

	// RVA: 0x31B0588 Offset: 0x31AC588 VA: 0x31B0588
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0x31B0590 Offset: 0x31AC590 VA: 0x31B0590
	internal Decimal get_MinOccurs() { }

	// RVA: 0x31B059C Offset: 0x31AC59C VA: 0x31B059C
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0x31B05A4 Offset: 0x31AC5A4 VA: 0x31B05A4
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0x31B0634 Offset: 0x31AC634 VA: 0x31B0634
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0x31B06C4 Offset: 0x31AC6C4 VA: 0x31B06C4
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0x31B0744 Offset: 0x31AC744 VA: 0x31B0744
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0x31B0AD0 Offset: 0x31ACAD0 VA: 0x31B0AD0
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0x31B14AC Offset: 0x31AD4AC VA: 0x31B14AC Slot: 15
	protected virtual DataTable CreateInstance() { }

	// RVA: 0x31B1538 Offset: 0x31AD538 VA: 0x31B1538 Slot: 16
	public virtual DataTable Clone() { }

	// RVA: 0x31B1540 Offset: 0x31AD540 VA: 0x31B1540
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0x31B1734 Offset: 0x31AD734 VA: 0x31B1734
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0x31B1A74 Offset: 0x31ADA74 VA: 0x31B1A74
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0x31A86C0 Offset: 0x31A46C0 VA: 0x31A86C0
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0x31B1EF4 Offset: 0x31ADEF4 VA: 0x31B1EF4 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0x31B1EFC Offset: 0x31ADEFC VA: 0x31B1EFC
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0x31B1F0C Offset: 0x31ADF0C VA: 0x31B1F0C
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0x31B1F18 Offset: 0x31ADF18 VA: 0x31B1F18
	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	// RVA: 0x31B2AA0 Offset: 0x31AEAA0 VA: 0x31B2AA0
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0x31B2AD0 Offset: 0x31AEAD0 VA: 0x31B2AD0
	public void Clear() { }

	// RVA: 0x31B2AD8 Offset: 0x31AEAD8 VA: 0x31B2AD8
	internal void Clear(bool clearAll) { }

	// RVA: 0x31B34BC Offset: 0x31AF4BC VA: 0x31B34BC
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0x31B3574 Offset: 0x31AF574 VA: 0x31B3574
	internal void CommitRow(DataRow row) { }

	// RVA: 0x31B372C Offset: 0x31AF72C VA: 0x31B372C
	internal int Compare(string s1, string s2) { }

	// RVA: 0x31B3734 Offset: 0x31AF734 VA: 0x31B3734
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0x31B3898 Offset: 0x31AF898 VA: 0x31B3898
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0x31B38D8 Offset: 0x31AF8D8 VA: 0x31B38D8
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0x31B3918 Offset: 0x31AF918 VA: 0x31B3918
	internal void DeleteRow(DataRow row) { }

	// RVA: 0x31B3970 Offset: 0x31AF970 VA: 0x31B3970
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0x31B3A9C Offset: 0x31AFA9C VA: 0x31B3A9C
	internal void FreeRecord(ref int record) { }

	// RVA: 0x31B3AB8 Offset: 0x31AFAB8 VA: 0x31B3AB8
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x31B3E5C Offset: 0x31AFE5C VA: 0x31B3E5C
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x31B4024 Offset: 0x31B0024 VA: 0x31B4024
	internal List<DataViewListener> GetListeners() { }

	// RVA: 0x31ADAE0 Offset: 0x31A9AE0 VA: 0x31ADAE0
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0x31B1000 Offset: 0x31AD000 VA: 0x31B1000
	internal void InsertRow(DataRow row, long proposedID) { }

	// RVA: 0x31B4D2C Offset: 0x31B0D2C VA: 0x31B4D2C
	internal int NewRecord() { }

	// RVA: 0x31B4E18 Offset: 0x31B0E18 VA: 0x31B4E18
	internal int NewUninitializedRecord() { }

	// RVA: 0x31B4D34 Offset: 0x31B0D34 VA: 0x31B4D34
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0x31ABF98 Offset: 0x31A7F98 VA: 0x31ABF98
	internal DataRow NewEmptyRow() { }

	// RVA: 0x31B4E34 Offset: 0x31B0E34 VA: 0x31B4E34
	private DataRow NewUninitializedRow() { }

	// RVA: 0x31B4EEC Offset: 0x31B0EEC VA: 0x31B4EEC
	public DataRow NewRow() { }

	// RVA: 0x31B4FA4 Offset: 0x31B0FA4 VA: 0x31B4FA4
	internal DataRow CreateEmptyRow() { }

	// RVA: 0x31B4F20 Offset: 0x31B0F20 VA: 0x31B4F20
	private void NewRowCreated(DataRow row) { }

	// RVA: 0x31B4E60 Offset: 0x31B0E60 VA: 0x31B4E60
	internal DataRow NewRow(int record) { }

	// RVA: 0x31B537C Offset: 0x31B137C VA: 0x31B537C Slot: 17
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0x31B53D8 Offset: 0x31B13D8 VA: 0x31B53D8 Slot: 18
	protected virtual Type GetRowType() { }

	// RVA: 0x31B5444 Offset: 0x31B1444 VA: 0x31B5444
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0x31B55F8 Offset: 0x31B15F8 VA: 0x31B55F8
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0x31B562C Offset: 0x31B162C VA: 0x31B562C Slot: 19
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0x31B56FC Offset: 0x31B16FC VA: 0x31B56FC Slot: 20
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0x31B57CC Offset: 0x31B17CC VA: 0x31B57CC Slot: 21
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x31B589C Offset: 0x31B189C VA: 0x31B589C
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0x31B58AC Offset: 0x31B18AC VA: 0x31B58AC Slot: 22
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0x31B3688 Offset: 0x31AF688 VA: 0x31B3688
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x31B35E4 Offset: 0x31AF5E4 VA: 0x31B35E4
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x31B58B0 Offset: 0x31B18B0 VA: 0x31B58B0 Slot: 23
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0x31B5980 Offset: 0x31B1980 VA: 0x31B5980 Slot: 24
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0x31B5A50 Offset: 0x31B1A50 VA: 0x31B5A50 Slot: 25
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0x31B5B20 Offset: 0x31B1B20 VA: 0x31B5B20 Slot: 26
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0x31B5BF0 Offset: 0x31B1BF0 VA: 0x31B5BF0 Slot: 27
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0x31B5CC0 Offset: 0x31B1CC0 VA: 0x31B5CC0 Slot: 28
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0x31B5D90 Offset: 0x31B1D90 VA: 0x31B5D90 Slot: 29
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0x31B3AEC Offset: 0x31AFAEC VA: 0x31B3AEC
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0x31AEE9C Offset: 0x31AAE9C VA: 0x31AEE9C
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0x31B5E60 Offset: 0x31B1E60 VA: 0x31B5E60
	internal void RecordChanged(int record) { }

	// RVA: 0x31B5FDC Offset: 0x31B1FDC VA: 0x31B5FDC
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0x31B41C0 Offset: 0x31B01C0 VA: 0x31B41C0
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x31B4354 Offset: 0x31B0354 VA: 0x31B4354
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0x31B61B4 Offset: 0x31B21B4 VA: 0x31B61B4
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0x31B6378 Offset: 0x31B2378 VA: 0x31B6378
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0x31B64EC Offset: 0x31B24EC VA: 0x31B64EC
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0x31B6DCC Offset: 0x31B2DCC VA: 0x31B6DCC
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0x31B6F68 Offset: 0x31B2F68 VA: 0x31B6F68 Slot: 30
	public virtual void Reset() { }

	// RVA: 0x31A86B8 Offset: 0x31A46B8 VA: 0x31A86B8
	internal void ResetIndexes() { }

	// RVA: 0x31B71F0 Offset: 0x31B31F0 VA: 0x31B71F0
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0x31B73D0 Offset: 0x31B33D0 VA: 0x31B73D0
	internal void RollbackRow(DataRow row) { }

	// RVA: 0x31B4B44 Offset: 0x31B0B44 VA: 0x31B4B44
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x31B7444 Offset: 0x31B3444 VA: 0x31B7444
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x31B402C Offset: 0x31B002C VA: 0x31B402C
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0x31B0800 Offset: 0x31AC800 VA: 0x31B0800
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = False, bool fireEvent = True, bool suppressEnsurePropertyChanged = False) { }

	// RVA: 0x31B22A4 Offset: 0x31AE2A4 VA: 0x31B22A4
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	// RVA: 0x31B0858 Offset: 0x31AC858 VA: 0x31B0858
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0x31B75F4 Offset: 0x31B35F4 VA: 0x31B75F4
	private void RestoreShadowIndexes() { }

	// RVA: 0x31AC784 Offset: 0x31A8784 VA: 0x31AC784
	private void SetShadowIndexes() { }

	// RVA: 0x31B7614 Offset: 0x31B3614 VA: 0x31B7614
	internal void ShadowIndexCopy() { }

	// RVA: 0x31B76A8 Offset: 0x31B36A8 VA: 0x31B76A8 Slot: 3
	public override string ToString() { }

	// RVA: 0x31B741C Offset: 0x31B341C VA: 0x31B741C
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0x31B771C Offset: 0x31B371C VA: 0x31B771C
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0x31B79B0 Offset: 0x31B39B0 VA: 0x31B79B0
	internal DataColumn AddUniqueKey() { }

	// RVA: 0x31B79B8 Offset: 0x31B39B8 VA: 0x31B79B8
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0x31B7A64 Offset: 0x31B3A64 VA: 0x31B7A64
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0x31B7A78 Offset: 0x31B3A78 VA: 0x31B7A78
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0x31A9698 Offset: 0x31A5698 VA: 0x31A9698
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0x31B7CE4 Offset: 0x31B3CE4 VA: 0x31B7CE4
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0x31B7CF4 Offset: 0x31B3CF4 VA: 0x31B7CF4
	public void Merge(DataTable table) { }

	// RVA: 0x31B7D00 Offset: 0x31B3D00 VA: 0x31B7D00
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x31B7F70 Offset: 0x31B3F70 VA: 0x31B7F70
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0x31B832C Offset: 0x31B432C VA: 0x31B832C
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x31A979C Offset: 0x31A579C VA: 0x31A979C
	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	// RVA: 0x31B8828 Offset: 0x31B4828 VA: 0x31B8828
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0x31B8B68 Offset: 0x31B4B68 VA: 0x31B8B68
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0x31B8BBC Offset: 0x31B4BBC VA: 0x31B8BBC
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0x31B8D8C Offset: 0x31B4D8C VA: 0x31B8D8C
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0x31BA760 Offset: 0x31B6760 VA: 0x31BA760
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0x31BA7F4 Offset: 0x31B67F4 VA: 0x31BA7F4
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0x31BBC88 Offset: 0x31B7C88 VA: 0x31BBC88
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0x31B9D5C Offset: 0x31B5D5C VA: 0x31B9D5C
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0x31BBD3C Offset: 0x31B7D3C VA: 0x31BBD3C
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x31BA864 Offset: 0x31B6864 VA: 0x31BA864
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x31B8440 Offset: 0x31B4440 VA: 0x31B8440
	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	// RVA: 0x31BBED0 Offset: 0x31B7ED0 VA: 0x31BBED0
	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	// RVA: 0x31BC3F0 Offset: 0x31B83F0 VA: 0x31BC3F0
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0x31BC62C Offset: 0x31B862C VA: 0x31BC62C Slot: 11
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x31BC63C Offset: 0x31B863C VA: 0x31BC63C Slot: 31
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0x31BC810 Offset: 0x31B8810 VA: 0x31BC810 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x31BC9BC Offset: 0x31B89BC VA: 0x31BC9BC Slot: 13
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x31BC9F0 Offset: 0x31B89F0 VA: 0x31BC9F0 Slot: 32
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0x31BC9FC Offset: 0x31B89FC VA: 0x31BC9FC
	internal Hashtable get_RowDiffId() { }

	// RVA: 0x31BCA70 Offset: 0x31B8A70 VA: 0x31BCA70
	internal int get_ObjectID() { }

	// RVA: 0x31BCA78 Offset: 0x31B8A78 VA: 0x31BCA78
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x31BCBB4 Offset: 0x31B8BB4 VA: 0x31BCBB4
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x31BCC44 Offset: 0x31B8C44 VA: 0x31BCC44
	internal void EvaluateExpressions() { }

	// RVA: 0x31B4594 Offset: 0x31B0594 VA: 0x31B4594
	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	// RVA: 0x31BCFBC Offset: 0x31B8FBC VA: 0x31BCFBC
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0x31B335C Offset: 0x31AF35C VA: 0x31B335C
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0x31B665C Offset: 0x31B265C VA: 0x31B665C
	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }
}

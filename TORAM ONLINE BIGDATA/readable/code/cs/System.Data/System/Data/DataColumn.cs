// Assembly: System.Data.dll
// Namespace: System.Data
[DesignTimeVisible(False)]
[DefaultMember("Item")]
[DefaultProperty("ColumnName")]
[ToolboxItem(False)]
public class DataColumn : MarshalByValueComponent // TypeDefIndex: 14643
{
	// Fields
	private bool _allowNull; // 0x20
	private string _caption; // 0x28
	private string _columnName; // 0x30
	private Type _dataType; // 0x38
	private StorageType _storageType; // 0x40
	internal object _defaultValue; // 0x48
	private DataSetDateTime _dateTimeMode; // 0x50
	private DataExpression _expression; // 0x58
	private int _maxLength; // 0x60
	private int _ordinal; // 0x64
	private bool _readOnly; // 0x68
	internal Index _sortIndex; // 0x70
	internal DataTable _table; // 0x78
	private bool _unique; // 0x80
	internal MappingType _columnMapping; // 0x84
	internal int _hashCode; // 0x88
	internal int _errors; // 0x8C
	private bool _isSqlType; // 0x90
	private bool _implementsINullable; // 0x91
	private bool _implementsIChangeTracking; // 0x92
	private bool _implementsIRevertibleChangeTracking; // 0x93
	private bool _implementsIXMLSerializable; // 0x94
	private bool _defaultValueIsNull; // 0x95
	internal List<DataColumn> _dependentColumns; // 0x98
	internal PropertyCollection _extendedProperties; // 0xA0
	private DataStorage _storage; // 0xA8
	private AutoIncrementValue _autoInc; // 0xB0
	internal string _columnUri; // 0xB8
	private string _columnPrefix; // 0xC0
	internal string _encodedColumnName; // 0xC8
	internal SimpleType _simpleType; // 0xD0
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0xD8
	[CompilerGenerated]
	private string <XmlDataType>k__BackingField; // 0xE0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0xE8

	// Properties
	[DefaultValue(True)]
	public bool AllowDBNull { get; set; }
	[RefreshProperties(1)]
	[DefaultValue(False)]
	public bool AutoIncrement { get; set; }
	internal object AutoIncrementCurrent { get; set; }
	internal AutoIncrementValue AutoInc { get; }
	[DefaultValue(0)]
	public long AutoIncrementSeed { get; set; }
	[DefaultValue(1)]
	public long AutoIncrementStep { get; set; }
	public string Caption { get; set; }
	[DefaultValue("")]
	[RefreshProperties(1)]
	public string ColumnName { get; set; }
	internal string EncodedColumnName { get; }
	internal IFormatProvider FormatProvider { get; }
	internal CultureInfo Locale { get; }
	internal int ObjectID { get; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	internal bool Computed { get; }
	internal DataExpression DataExpression { get; }
	[DefaultValue(typeof(string))]
	[RefreshProperties(1)]
	[TypeConverter(typeof(ColumnTypeConverter))]
	public Type DataType { get; set; }
	[RefreshProperties(1)]
	[DefaultValue(3)]
	public DataSetDateTime DateTimeMode { get; set; }
	[TypeConverter(typeof(DefaultValueTypeConverter))]
	public object DefaultValue { get; set; }
	internal bool DefaultValueIsNull { get; }
	[DefaultValue("")]
	[RefreshProperties(1)]
	public string Expression { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal bool HasData { get; }
	internal bool ImplementsINullable { get; }
	internal bool ImplementsIChangeTracking { get; }
	internal bool ImplementsIRevertibleChangeTracking { get; }
	internal bool IsValueType { get; }
	internal bool IsSqlType { get; }
	[DefaultValue(-1)]
	public int MaxLength { get; set; }
	public string Namespace { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public int Ordinal { get; }
	[DefaultValue(False)]
	public bool ReadOnly { get; set; }
	[DebuggerBrowsable(0)]
	private Index SortIndex { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataTable Table { get; }
	internal object Item { get; set; }
	[DesignerSerializationVisibility(0)]
	[DefaultValue(False)]
	public bool Unique { get; set; }
	internal string XmlDataType { get; set; }
	internal SimpleType SimpleType { get; set; }
	[DefaultValue(1)]
	public virtual MappingType ColumnMapping { get; set; }
	internal bool IsCustomType { get; }
	internal bool ImplementsIXMLSerializable { get; }

	// Methods

	// RVA: 0x31BD744 Offset: 0x31B9744 VA: 0x31BD744
	public void .ctor() { }

	// RVA: 0x31BDAF4 Offset: 0x31B9AF4 VA: 0x31BDAF4
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0x31BD7D4 Offset: 0x31B97D4 VA: 0x31BD7D4
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0x31BDC10 Offset: 0x31B9C10 VA: 0x31BDC10
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0x31BE520 Offset: 0x31BA520 VA: 0x31BE520
	public bool get_AllowDBNull() { }

	// RVA: 0x31BE528 Offset: 0x31BA528 VA: 0x31BE528
	public void set_AllowDBNull(bool value) { }

	// RVA: 0x31BEB00 Offset: 0x31BAB00 VA: 0x31BEB00
	public bool get_AutoIncrement() { }

	// RVA: 0x31BEB20 Offset: 0x31BAB20 VA: 0x31BEB20
	public void set_AutoIncrement(bool value) { }

	// RVA: 0x31BFA18 Offset: 0x31BBA18 VA: 0x31BFA18
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0x31BFA9C Offset: 0x31BBA9C VA: 0x31BFA9C
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0x31BF914 Offset: 0x31BB914 VA: 0x31BF914
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0x31BFA84 Offset: 0x31BBA84 VA: 0x31BFA84
	public long get_AutoIncrementSeed() { }

	// RVA: 0x31BFC94 Offset: 0x31BBC94 VA: 0x31BFC94
	public void set_AutoIncrementSeed(long value) { }

	// RVA: 0x31BFD84 Offset: 0x31BBD84 VA: 0x31BFD84
	public long get_AutoIncrementStep() { }

	// RVA: 0x31BFDA0 Offset: 0x31BBDA0 VA: 0x31BFDA0
	public void set_AutoIncrementStep(long value) { }

	// RVA: 0x31BFE98 Offset: 0x31BBE98 VA: 0x31BFE98
	public string get_Caption() { }

	// RVA: 0x31BFEB4 Offset: 0x31BBEB4 VA: 0x31BFEB4
	public void set_Caption(string value) { }

	// RVA: 0x31BFFC8 Offset: 0x31BBFC8 VA: 0x31BFFC8
	public string get_ColumnName() { }

	// RVA: 0x31BFFD0 Offset: 0x31BBFD0 VA: 0x31BFFD0
	public void set_ColumnName(string value) { }

	// RVA: 0x31C0428 Offset: 0x31BC428 VA: 0x31C0428
	internal string get_EncodedColumnName() { }

	// RVA: 0x31BFBA0 Offset: 0x31BBBA0 VA: 0x31BFBA0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x31BFF5C Offset: 0x31BBF5C VA: 0x31BFF5C
	internal CultureInfo get_Locale() { }

	// RVA: 0x31C04A8 Offset: 0x31BC4A8 VA: 0x31C04A8
	internal int get_ObjectID() { }

	// RVA: 0x31C04B0 Offset: 0x31BC4B0 VA: 0x31C04B0
	public string get_Prefix() { }

	// RVA: 0x31C04B8 Offset: 0x31BC4B8 VA: 0x31C04B8
	public void set_Prefix(string value) { }

	// RVA: 0x31C0668 Offset: 0x31BC668 VA: 0x31C0668
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0x31C078C Offset: 0x31BC78C VA: 0x31C078C
	internal bool get_Computed() { }

	// RVA: 0x31C079C Offset: 0x31BC79C VA: 0x31C079C
	internal DataExpression get_DataExpression() { }

	// RVA: 0x31C07A4 Offset: 0x31BC7A4 VA: 0x31C07A4
	public Type get_DataType() { }

	// RVA: 0x31BF088 Offset: 0x31BB088 VA: 0x31BF088
	public void set_DataType(Type value) { }

	// RVA: 0x31C0F48 Offset: 0x31BCF48 VA: 0x31C0F48
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x31C0F50 Offset: 0x31BCF50 VA: 0x31C0F50
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0x31C09BC Offset: 0x31BC9BC VA: 0x31C09BC
	public object get_DefaultValue() { }

	// RVA: 0x31C0AFC Offset: 0x31BCAFC VA: 0x31C0AFC
	public void set_DefaultValue(object value) { }

	// RVA: 0x31C12A4 Offset: 0x31BD2A4 VA: 0x31C12A4
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0x31C12AC Offset: 0x31BD2AC VA: 0x31C12AC
	public string get_Expression() { }

	// RVA: 0x31BDD38 Offset: 0x31B9D38 VA: 0x31BDD38
	public void set_Expression(string value) { }

	// RVA: 0x31C1740 Offset: 0x31BD740 VA: 0x31C1740
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x31BF02C Offset: 0x31BB02C VA: 0x31BF02C
	internal bool get_HasData() { }

	// RVA: 0x31C17B0 Offset: 0x31BD7B0 VA: 0x31C17B0
	internal bool get_ImplementsINullable() { }

	// RVA: 0x31C17B8 Offset: 0x31BD7B8 VA: 0x31C17B8
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0x31C17C0 Offset: 0x31BD7C0 VA: 0x31C17C0
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0x31C17C8 Offset: 0x31BD7C8 VA: 0x31C17C8
	internal bool get_IsValueType() { }

	// RVA: 0x31C17E4 Offset: 0x31BD7E4 VA: 0x31C17E4
	internal bool get_IsSqlType() { }

	// RVA: 0x31C17EC Offset: 0x31BD7EC VA: 0x31C17EC
	private void SetMaxLengthSimpleType() { }

	// RVA: 0x31C1890 Offset: 0x31BD890 VA: 0x31C1890
	public int get_MaxLength() { }

	// RVA: 0x31C1898 Offset: 0x31BD898 VA: 0x31C1898
	public void set_MaxLength(int value) { }

	// RVA: 0x31C20B4 Offset: 0x31BE0B4 VA: 0x31C20B4
	public string get_Namespace() { }

	// RVA: 0x31C212C Offset: 0x31BE12C VA: 0x31C212C
	public void set_Namespace(string value) { }

	// RVA: 0x31C22C4 Offset: 0x31BE2C4 VA: 0x31C22C4
	public int get_Ordinal() { }

	// RVA: 0x31C22CC Offset: 0x31BE2CC VA: 0x31C22CC
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0x31C240C Offset: 0x31BE40C VA: 0x31C240C
	public bool get_ReadOnly() { }

	// RVA: 0x31C13C0 Offset: 0x31BD3C0 VA: 0x31C13C0
	public void set_ReadOnly(bool value) { }

	// RVA: 0x31C2454 Offset: 0x31BE454 VA: 0x31C2454
	private Index get_SortIndex() { }

	// RVA: 0x31C2538 Offset: 0x31BE538 VA: 0x31C2538
	public DataTable get_Table() { }

	// RVA: 0x31C2540 Offset: 0x31BE540 VA: 0x31C2540
	internal void SetTable(DataTable table) { }

	// RVA: 0x31C2614 Offset: 0x31BE614 VA: 0x31C2614
	private DataRow GetDataRow(int index) { }

	// RVA: 0x31C0730 Offset: 0x31BC730 VA: 0x31C0730
	internal object get_Item(int record) { }

	// RVA: 0x31C2638 Offset: 0x31BE638 VA: 0x31C2638
	internal void set_Item(int record, object value) { }

	// RVA: 0x31C16B4 Offset: 0x31BD6B4 VA: 0x31C16B4
	internal void InitializeRecord(int record) { }

	// RVA: 0x31C2890 Offset: 0x31BE890 VA: 0x31C2890
	internal void SetValue(int record, object value) { }

	// RVA: 0x31C2998 Offset: 0x31BE998 VA: 0x31C2998
	internal void FreeRecord(int record) { }

	// RVA: 0x31C29BC Offset: 0x31BE9BC VA: 0x31C29BC
	public bool get_Unique() { }

	// RVA: 0x31C29C4 Offset: 0x31BE9C4 VA: 0x31C29C4
	public void set_Unique(bool value) { }

	// RVA: 0x31C2EB8 Offset: 0x31BEEB8 VA: 0x31C2EB8
	internal void InternalUnique(bool value) { }

	[CompilerGenerated]
	// RVA: 0x31C2EC4 Offset: 0x31BEEC4 VA: 0x31C2EC4
	internal string get_XmlDataType() { }

	[CompilerGenerated]
	// RVA: 0x31C2ECC Offset: 0x31BEECC VA: 0x31C2ECC
	internal void set_XmlDataType(string value) { }

	// RVA: 0x31C2ED4 Offset: 0x31BEED4 VA: 0x31C2ED4
	internal SimpleType get_SimpleType() { }

	// RVA: 0x31BDBBC Offset: 0x31B9BBC VA: 0x31BDBBC
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0x31C2EDC Offset: 0x31BEEDC VA: 0x31C2EDC Slot: 10
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0x31C2EE4 Offset: 0x31BEEE4 VA: 0x31C2EE4 Slot: 11
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0x31C3228 Offset: 0x31BF228 VA: 0x31C3228
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x31C1C94 Offset: 0x31BDC94 VA: 0x31C1C94
	internal bool CheckMaxLength() { }

	// RVA: 0x31C32F4 Offset: 0x31BF2F4 VA: 0x31C32F4
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0x31BE6C8 Offset: 0x31BA6C8 VA: 0x31BE6C8
	protected internal void CheckNotAllowNull() { }

	// RVA: 0x31C327C Offset: 0x31BF27C VA: 0x31C327C
	internal void CheckNullable(DataRow row) { }

	// RVA: 0x31C2E6C Offset: 0x31BEE6C VA: 0x31C2E6C
	protected void CheckUnique() { }

	// RVA: 0x31C34C8 Offset: 0x31BF4C8 VA: 0x31C34C8
	internal int Compare(int record1, int record2) { }

	// RVA: 0x31C34E8 Offset: 0x31BF4E8 VA: 0x31C34E8
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0x31C36C8 Offset: 0x31BF6C8 VA: 0x31C36C8
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0x31C36E8 Offset: 0x31BF6E8 VA: 0x31C36E8
	internal object ConvertValue(object value) { }

	// RVA: 0x31C3708 Offset: 0x31BF708 VA: 0x31C3708
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0x31C3728 Offset: 0x31BF728 VA: 0x31C3728
	internal DataColumn Clone() { }

	// RVA: 0x31C3D58 Offset: 0x31BFD58 VA: 0x31C3D58
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0x31C3370 Offset: 0x31BF370 VA: 0x31C3370
	private int GetStringLength(int record) { }

	// RVA: 0x31C3E1C Offset: 0x31BFE1C VA: 0x31C3E1C
	internal void Init(int record) { }

	// RVA: 0x31BED50 Offset: 0x31BAD50 VA: 0x31BED50
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0x31C3EA8 Offset: 0x31BFEA8 VA: 0x31C3EA8
	internal bool get_IsCustomType() { }

	// RVA: 0x31C3F1C Offset: 0x31BFF1C VA: 0x31C3F1C
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0x31C3FE8 Offset: 0x31BFFE8 VA: 0x31C3FE8
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0x31C082C Offset: 0x31BC82C VA: 0x31C082C
	internal bool IsInRelation() { }

	// RVA: 0x31C3FF0 Offset: 0x31BFFF0 VA: 0x31C3FF0
	internal bool IsMaxLengthViolated() { }

	// RVA: 0x31C45A4 Offset: 0x31C05A4 VA: 0x31C45A4
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0x31C4714 Offset: 0x31C0714 VA: 0x31C4714 Slot: 12
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x31C03B4 Offset: 0x31BC3B4 VA: 0x31C03B4
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x31C473C Offset: 0x31C073C VA: 0x31C473C
	private void InsureStorage() { }

	// RVA: 0x31C47D8 Offset: 0x31C07D8 VA: 0x31C47D8
	internal void SetCapacity(int capacity) { }

	// RVA: 0x31C4814 Offset: 0x31C0814 VA: 0x31C4814
	internal void OnSetDataSet() { }

	// RVA: 0x31C4818 Offset: 0x31C0818 VA: 0x31C4818 Slot: 3
	public override string ToString() { }

	// RVA: 0x31C488C Offset: 0x31C088C VA: 0x31C488C
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0x31C48C8 Offset: 0x31C08C8 VA: 0x31C48C8
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x31C0750 Offset: 0x31BC750 VA: 0x31C0750
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0x31C490C Offset: 0x31C090C VA: 0x31C490C
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x31C4960 Offset: 0x31C0960 VA: 0x31C4960
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0x31C4994 Offset: 0x31C0994 VA: 0x31C4994
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x31C49B0 Offset: 0x31C09B0 VA: 0x31C49B0
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x31C49EC Offset: 0x31C09EC VA: 0x31C49EC
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x31C4B08 Offset: 0x31C0B08 VA: 0x31C4B08
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x31C157C Offset: 0x31BD57C VA: 0x31C157C
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }
}

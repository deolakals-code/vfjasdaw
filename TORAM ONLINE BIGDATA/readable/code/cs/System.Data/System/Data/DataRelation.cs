// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultProperty("RelationName")]
[TypeConverter(typeof(RelationshipConverter))]
public class DataRelation // TypeDefIndex: 14688
{
	// Fields
	private DataSet _dataSet; // 0x10
	internal PropertyCollection _extendedProperties; // 0x18
	internal string _relationName; // 0x20
	private DataKey _childKey; // 0x28
	private DataKey _parentKey; // 0x30
	private UniqueConstraint _parentKeyConstraint; // 0x38
	private ForeignKeyConstraint _childKeyConstraint; // 0x40
	internal string[] _parentColumnNames; // 0x48
	internal string[] _childColumnNames; // 0x50
	internal string _parentTableName; // 0x58
	internal string _childTableName; // 0x60
	internal string _parentTableNamespace; // 0x68
	internal string _childTableNamespace; // 0x70
	internal bool _nested; // 0x78
	internal bool _createConstraints; // 0x79
	private bool _checkMultipleNested; // 0x7A
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x7C
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0x80

	// Properties
	public virtual DataColumn[] ChildColumns { get; }
	internal DataColumn[] ChildColumnsReference { get; }
	internal DataKey ChildKey { get; }
	public virtual DataTable ChildTable { get; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public virtual DataSet DataSet { get; }
	internal string[] ParentColumnNames { get; }
	internal string[] ChildColumnNames { get; }
	public virtual DataColumn[] ParentColumns { get; }
	internal DataColumn[] ParentColumnsReference { get; }
	internal DataKey ParentKey { get; }
	public virtual DataTable ParentTable { get; }
	[DefaultValue("")]
	public virtual string RelationName { get; }
	[DefaultValue(False)]
	public virtual bool Nested { get; set; }
	public virtual UniqueConstraint ParentKeyConstraint { get; }
	public virtual ForeignKeyConstraint ChildKeyConstraint { get; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal bool CheckMultipleNested { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x31E59D4 Offset: 0x31E19D4 VA: 0x31E59D4
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0x31E5F08 Offset: 0x31E1F08 VA: 0x31E5F08
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x31E5F10 Offset: 0x31E1F10 VA: 0x31E5F10
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	[Browsable(False)]
	// RVA: 0x31E5FE0 Offset: 0x31E1FE0 VA: 0x31E5FE0
	public void .ctor(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	[Browsable(False)]
	// RVA: 0x31E6108 Offset: 0x31E2108 VA: 0x31E6108
	public void .ctor(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0x31E6258 Offset: 0x31E2258 VA: 0x31E6258 Slot: 4
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0x31E635C Offset: 0x31E235C VA: 0x31E635C
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0x31E3998 Offset: 0x31DF998 VA: 0x31E3998
	internal DataKey get_ChildKey() { }

	// RVA: 0x31E6374 Offset: 0x31E2374 VA: 0x31E6374 Slot: 5
	public virtual DataTable get_ChildTable() { }

	// RVA: 0x31E638C Offset: 0x31E238C VA: 0x31E638C Slot: 6
	public virtual DataSet get_DataSet() { }

	// RVA: 0x31E63A4 Offset: 0x31E23A4 VA: 0x31E63A4
	internal string[] get_ParentColumnNames() { }

	// RVA: 0x31E63AC Offset: 0x31E23AC VA: 0x31E63AC
	internal string[] get_ChildColumnNames() { }

	// RVA: 0x31E63B4 Offset: 0x31E23B4 VA: 0x31E63B4
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0x31E6478 Offset: 0x31E2478 VA: 0x31E6478
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0x31E6534 Offset: 0x31E2534 VA: 0x31E6534
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x31E65CC Offset: 0x31E25CC VA: 0x31E65CC
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x31E67A8 Offset: 0x31E27A8 VA: 0x31E67A8
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x31E67C0 Offset: 0x31E27C0 VA: 0x31E67C0 Slot: 7
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0x31E67D8 Offset: 0x31E27D8 VA: 0x31E67D8
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0x31E39B0 Offset: 0x31DF9B0 VA: 0x31E39B0
	internal DataKey get_ParentKey() { }

	// RVA: 0x31E67E0 Offset: 0x31E27E0 VA: 0x31E67E0 Slot: 8
	public virtual DataTable get_ParentTable() { }

	// RVA: 0x31E67F8 Offset: 0x31E27F8 VA: 0x31E67F8 Slot: 9
	public virtual string get_RelationName() { }

	// RVA: 0x31E6810 Offset: 0x31E2810 VA: 0x31E6810
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0x31E6BB4 Offset: 0x31E2BB4 VA: 0x31E6BB4
	internal void CheckNestedRelations() { }

	// RVA: 0x31E6FCC Offset: 0x31E2FCC VA: 0x31E6FCC Slot: 10
	public virtual bool get_Nested() { }

	// RVA: 0x31E6FE4 Offset: 0x31E2FE4 VA: 0x31E6FE4 Slot: 11
	public virtual void set_Nested(bool value) { }

	// RVA: 0x31E86B0 Offset: 0x31E46B0 VA: 0x31E86B0 Slot: 12
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0x31E86C8 Offset: 0x31E46C8 VA: 0x31E86C8
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0x31E86D0 Offset: 0x31E46D0 VA: 0x31E86D0 Slot: 13
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0x31E86E8 Offset: 0x31E46E8 VA: 0x31E86E8
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x31E8758 Offset: 0x31E4758 VA: 0x31E8758
	internal bool get_CheckMultipleNested() { }

	// RVA: 0x31E8760 Offset: 0x31E4760 VA: 0x31E8760
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0x31E876C Offset: 0x31E476C VA: 0x31E876C
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0x31E8774 Offset: 0x31E4774 VA: 0x31E8774
	internal void CheckState() { }

	// RVA: 0x31E6270 Offset: 0x31E2270 VA: 0x31E6270
	protected void CheckStateForProperty() { }

	// RVA: 0x31E5BEC Offset: 0x31E1BEC VA: 0x31E5BEC
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x31E89B0 Offset: 0x31E49B0 VA: 0x31E89B0
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0x31E9118 Offset: 0x31E5118 VA: 0x31E9118
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x31E8568 Offset: 0x31E4568 VA: 0x31E8568
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x31E91E8 Offset: 0x31E51E8 VA: 0x31E91E8 Slot: 3
	public override string ToString() { }

	// RVA: 0x31E8098 Offset: 0x31E4098 VA: 0x31E8098
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0x31E91F4 Offset: 0x31E51F4 VA: 0x31E91F4
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0x31E93C8 Offset: 0x31E53C8 VA: 0x31E93C8
	internal int get_ObjectID() { }
}

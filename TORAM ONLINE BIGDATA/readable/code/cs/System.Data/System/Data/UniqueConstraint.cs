// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultProperty("ConstraintName")]
public class UniqueConstraint : Constraint // TypeDefIndex: 14776
{
	// Fields
	private DataKey _key; // 0x38
	private Index _constraintIndex; // 0x40
	internal bool _bPrimaryKey; // 0x48
	internal string _constraintName; // 0x50
	internal string[] _columnNames; // 0x58

	// Properties
	internal string[] ColumnNames { get; }
	internal Index ConstraintIndex { get; }
	[ReadOnly(True)]
	public virtual DataColumn[] Columns { get; }
	internal DataColumn[] ColumnsReference { get; }
	public bool IsPrimaryKey { get; }
	internal override bool InCollection { set; }
	internal DataKey Key { get; }
	[ReadOnly(True)]
	public override DataTable Table { get; }

	// Methods

	// RVA: 0x3213A84 Offset: 0x320FA84 VA: 0x3213A84
	public void .ctor(DataColumn column) { }

	// RVA: 0x3213C38 Offset: 0x320FC38 VA: 0x3213C38
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0x3213C6C Offset: 0x320FC6C VA: 0x3213C6C
	public void .ctor(DataColumn[] columns) { }

	[Browsable(False)]
	// RVA: 0x3213C9C Offset: 0x320FC9C VA: 0x3213C9C
	public void .ctor(string name, string[] columnNames, bool isPrimaryKey) { }

	// RVA: 0x3213CF4 Offset: 0x320FCF4 VA: 0x3213CF4
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0x3213D38 Offset: 0x320FD38 VA: 0x3213D38
	internal string[] get_ColumnNames() { }

	// RVA: 0x3213D44 Offset: 0x320FD44 VA: 0x3213D44
	internal Index get_ConstraintIndex() { }

	// RVA: 0x3213D4C Offset: 0x320FD4C VA: 0x3213D4C
	internal void ConstraintIndexClear() { }

	// RVA: 0x3213D7C Offset: 0x320FD7C VA: 0x3213D7C
	internal void ConstraintIndexInitialize() { }

	// RVA: 0x3213DD4 Offset: 0x320FDD4 VA: 0x3213DD4 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x3213DE0 Offset: 0x320FDE0 VA: 0x3213DE0
	private void NonVirtualCheckState() { }

	// RVA: 0x3213DEC Offset: 0x320FDEC VA: 0x3213DEC Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x3213DF0 Offset: 0x320FDF0 VA: 0x3213DF0 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x3213F5C Offset: 0x320FF5C VA: 0x3213F5C Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x3213FA8 Offset: 0x320FFA8 VA: 0x3213FA8 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x3214208 Offset: 0x3210208 VA: 0x3214208 Slot: 15
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x3214308 Offset: 0x3210308 VA: 0x3214308 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0x3214314 Offset: 0x3210314 VA: 0x3214314 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x3214324 Offset: 0x3210324 VA: 0x3214324 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x321487C Offset: 0x321087C VA: 0x321487C
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0x3214D38 Offset: 0x3210D38 VA: 0x3214D38 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x3214300 Offset: 0x3210300 VA: 0x3214300
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0x3214D44 Offset: 0x3210D44 VA: 0x3214D44
	public bool get_IsPrimaryKey() { }

	// RVA: 0x3213B40 Offset: 0x320FB40 VA: 0x3213B40
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0x3214D88 Offset: 0x3210D88 VA: 0x3214D88 Slot: 0
	public override bool Equals(object key2) { }

	// RVA: 0x3214E40 Offset: 0x3210E40 VA: 0x3214E40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3214E48 Offset: 0x3210E48 VA: 0x3214E48 Slot: 7
	internal override void set_InCollection(bool value) { }

	// RVA: 0x3214E98 Offset: 0x3210E98 VA: 0x3214E98
	internal DataKey get_Key() { }

	// RVA: 0x3214EA0 Offset: 0x3210EA0 VA: 0x3214EA0 Slot: 8
	public override DataTable get_Table() { }
}

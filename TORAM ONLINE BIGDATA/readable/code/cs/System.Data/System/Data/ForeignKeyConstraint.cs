// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultProperty("ConstraintName")]
public class ForeignKeyConstraint : Constraint // TypeDefIndex: 14745
{
	// Fields
	internal Rule _deleteRule; // 0x38
	internal Rule _updateRule; // 0x3C
	internal AcceptRejectRule _acceptRejectRule; // 0x40
	private DataKey _childKey; // 0x48
	private DataKey _parentKey; // 0x50
	internal string _constraintName; // 0x58
	internal string[] _parentColumnNames; // 0x60
	internal string[] _childColumnNames; // 0x68
	internal string _parentTableName; // 0x70

	// Properties
	internal DataKey ChildKey { get; }
	[ReadOnly(True)]
	public virtual DataColumn[] Columns { get; }
	[ReadOnly(True)]
	public override DataTable Table { get; }
	internal string[] ParentColumnNames { get; }
	internal string[] ChildColumnNames { get; }
	[DefaultValue(0)]
	public virtual AcceptRejectRule AcceptRejectRule { get; set; }
	[DefaultValue(1)]
	public virtual Rule DeleteRule { get; set; }
	[ReadOnly(True)]
	public virtual DataColumn[] RelatedColumns { get; }
	internal DataColumn[] RelatedColumnsReference { get; }
	internal DataKey ParentKey { get; }
	[ReadOnly(True)]
	public virtual DataTable RelatedTable { get; }
	[DefaultValue(1)]
	public virtual Rule UpdateRule { get; set; }

	// Methods

	// RVA: 0x320680C Offset: 0x320280C VA: 0x320680C
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x320684C Offset: 0x320284C VA: 0x320684C
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[Browsable(False)]
	// RVA: 0x3206A18 Offset: 0x3202A18 VA: 0x3206A18
	public void .ctor(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	// RVA: 0x3206AC0 Offset: 0x3202AC0 VA: 0x3206AC0
	internal DataKey get_ChildKey() { }

	// RVA: 0x3206ADC Offset: 0x3202ADC VA: 0x3206ADC Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x3206AFC Offset: 0x3202AFC VA: 0x3206AFC Slot: 8
	public override DataTable get_Table() { }

	// RVA: 0x3206B1C Offset: 0x3202B1C VA: 0x3206B1C
	internal string[] get_ParentColumnNames() { }

	// RVA: 0x3206B28 Offset: 0x3202B28 VA: 0x3206B28
	internal string[] get_ChildColumnNames() { }

	// RVA: 0x3206B34 Offset: 0x3202B34 VA: 0x3206B34 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x3206C5C Offset: 0x3202C5C VA: 0x3206C5C Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x3206C64 Offset: 0x3202C64 VA: 0x3206C64
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0x3206D28 Offset: 0x3202D28 VA: 0x3206D28 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x32071F8 Offset: 0x32031F8 VA: 0x32071F8 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x3207364 Offset: 0x3203364 VA: 0x3207364
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0x32074C4 Offset: 0x32034C4 VA: 0x32074C4
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0x32079F4 Offset: 0x32039F4 VA: 0x32079F4
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0x3207BE0 Offset: 0x3203BE0 VA: 0x3207BE0
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0x3208078 Offset: 0x3204078 VA: 0x3208078
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0x3208154 Offset: 0x3204154 VA: 0x3208154
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0x320821C Offset: 0x320421C VA: 0x320821C
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0x320831C Offset: 0x320431C VA: 0x320831C Slot: 15
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0x32085F0 Offset: 0x32045F0 VA: 0x32085F0
	private void NonVirtualCheckState() { }

	// RVA: 0x3208850 Offset: 0x3204850 VA: 0x3208850 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x3208854 Offset: 0x3204854 VA: 0x3208854 Slot: 20
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0x3208870 Offset: 0x3204870 VA: 0x3208870 Slot: 21
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x32088C4 Offset: 0x32048C4 VA: 0x32088C4 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0x320890C Offset: 0x320490C VA: 0x320890C Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x320891C Offset: 0x320491C VA: 0x320891C Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x3209080 Offset: 0x3205080 VA: 0x3209080
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0x3206898 Offset: 0x3202898 VA: 0x3206898
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x3209694 Offset: 0x3205694 VA: 0x3209694 Slot: 22
	public virtual Rule get_DeleteRule() { }

	// RVA: 0x32096B0 Offset: 0x32056B0 VA: 0x32096B0 Slot: 23
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0x3209704 Offset: 0x3205704 VA: 0x3209704 Slot: 0
	public override bool Equals(object key) { }

	// RVA: 0x32097F4 Offset: 0x32057F4 VA: 0x32097F4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x32097FC Offset: 0x32057FC VA: 0x32097FC Slot: 24
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0x3209064 Offset: 0x3205064 VA: 0x3209064
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0x3208200 Offset: 0x3204200 VA: 0x3208200
	internal DataKey get_ParentKey() { }

	// RVA: 0x320981C Offset: 0x320581C VA: 0x320981C
	internal DataRelation FindParentRelation() { }

	// RVA: 0x32098E4 Offset: 0x32058E4 VA: 0x32098E4 Slot: 25
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0x3209904 Offset: 0x3205904 VA: 0x3209904 Slot: 26
	public virtual Rule get_UpdateRule() { }

	// RVA: 0x3209920 Offset: 0x3205920 VA: 0x3209920 Slot: 27
	public virtual void set_UpdateRule(Rule value) { }
}

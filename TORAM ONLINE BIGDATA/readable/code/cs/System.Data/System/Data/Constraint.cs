// Assembly: System.Data.dll
// Namespace: System.Data
[TypeConverter(typeof(ConstraintConverter))]
[DefaultProperty("ConstraintName")]
public abstract class Constraint // TypeDefIndex: 14674
{
	// Fields
	private string _schemaName; // 0x10
	private bool _inCollection; // 0x18
	private DataSet _dataSet; // 0x20
	internal string _name; // 0x28
	internal PropertyCollection _extendedProperties; // 0x30

	// Properties
	[DefaultValue("")]
	public virtual string ConstraintName { get; set; }
	internal string SchemaName { get; set; }
	internal virtual bool InCollection { get; set; }
	public abstract DataTable Table { get; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	[CLSCompliant(False)]
	protected virtual DataSet _DataSet { get; }

	// Methods

	// RVA: 0x31DE1D8 Offset: 0x31DA1D8 VA: 0x31DE1D8 Slot: 4
	public virtual string get_ConstraintName() { }

	// RVA: 0x31DE1E0 Offset: 0x31DA1E0 VA: 0x31DE1E0 Slot: 5
	public virtual void set_ConstraintName(string value) { }

	// RVA: 0x31DE640 Offset: 0x31DA640 VA: 0x31DE640
	internal string get_SchemaName() { }

	// RVA: 0x31DE678 Offset: 0x31DA678 VA: 0x31DE678
	internal void set_SchemaName(string value) { }

	// RVA: 0x31DE6BC Offset: 0x31DA6BC VA: 0x31DE6BC Slot: 6
	internal virtual bool get_InCollection() { }

	// RVA: 0x31DE6C4 Offset: 0x31DA6C4 VA: 0x31DE6C4 Slot: 7
	internal virtual void set_InCollection(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DataTable get_Table();

	// RVA: 0x31DE70C Offset: 0x31DA70C VA: 0x31DE70C
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool ContainsColumn(DataColumn column);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool CanEnableConstraint();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract Constraint Clone(DataSet destination);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

	// RVA: 0x31DE77C Offset: 0x31DA77C VA: 0x31DE77C
	internal void CheckConstraint() { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void CheckConstraint(DataRow row, DataRowAction action);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void CheckState();

	// RVA: 0x31DE7D0 Offset: 0x31DA7D0 VA: 0x31DE7D0
	protected void CheckStateForProperty() { }

	// RVA: 0x31DE8C8 Offset: 0x31DA8C8 VA: 0x31DE8C8 Slot: 17
	protected virtual DataSet get__DataSet() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract bool IsConstraintViolated();

	// RVA: 0x31DE8D0 Offset: 0x31DA8D0 VA: 0x31DE8D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x31DE8DC Offset: 0x31DA8DC VA: 0x31DE8DC
	protected void .ctor() { }
}

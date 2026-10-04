// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class Merger // TypeDefIndex: 14749
{
	// Fields
	private DataSet _dataSet; // 0x10
	private DataTable _dataTable; // 0x18
	private bool _preserveChanges; // 0x20
	private MissingSchemaAction _missingSchemaAction; // 0x24
	private bool _isStandAlonetable; // 0x28
	private bool _IgnoreNSforTableLookup; // 0x29

	// Methods

	// RVA: 0x3209B24 Offset: 0x3205B24 VA: 0x3209B24
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x3209B78 Offset: 0x3205B78 VA: 0x3209B78
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x3209BD4 Offset: 0x3205BD4 VA: 0x3209BD4
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0x320B7D8 Offset: 0x32077D8 VA: 0x320B7D8
	internal void MergeTable(DataTable src) { }

	// RVA: 0x320BA04 Offset: 0x3207A04 VA: 0x320BA04
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0x320C008 Offset: 0x3208008 VA: 0x320C008
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0x320ACC8 Offset: 0x3206CC8 VA: 0x320ACC8
	private void MergeTableData(DataTable src) { }

	// RVA: 0x320AD50 Offset: 0x3206D50 VA: 0x320AD50
	private void MergeConstraints(DataSet source) { }

	// RVA: 0x320C72C Offset: 0x320872C VA: 0x320C72C
	private void MergeConstraints(DataTable table) { }

	// RVA: 0x320ADC0 Offset: 0x3206DC0 VA: 0x320ADC0
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0x320B584 Offset: 0x3207584 VA: 0x320B584
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0x320BEAC Offset: 0x3207EAC VA: 0x320BEAC
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }
}

// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class XmlDataTreeWriter // TypeDefIndex: 14795
{
	// Fields
	private XmlWriter _xmlw; // 0x10
	private DataSet _ds; // 0x18
	private DataTable _dt; // 0x20
	private ArrayList _dTables; // 0x28
	private DataTable[] _topLevelTables; // 0x30
	private bool _fFromTable; // 0x38
	private bool _isDiffgram; // 0x39
	private Hashtable _rowsOrder; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x324363C Offset: 0x323F63C VA: 0x324363C
	internal void .ctor(DataSet ds) { }

	// RVA: 0x32439A8 Offset: 0x323F9A8 VA: 0x32439A8
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x3243EC4 Offset: 0x323FEC4 VA: 0x3243EC4
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x3243B40 Offset: 0x323FB40 VA: 0x3243B40
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x32441B0 Offset: 0x32401B0 VA: 0x32441B0
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0x3244278 Offset: 0x3240278 VA: 0x3244278
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0x32462FC Offset: 0x32422FC VA: 0x32462FC
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0x3246BE0 Offset: 0x3242BE0 VA: 0x3246BE0
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0x32449A8 Offset: 0x32409A8 VA: 0x32449A8
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0x3246F28 Offset: 0x3242F28 VA: 0x3246F28
	internal static bool PreserveSpace(object value) { }
}

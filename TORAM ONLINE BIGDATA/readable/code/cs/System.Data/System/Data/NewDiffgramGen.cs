// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class NewDiffgramGen // TypeDefIndex: 14794
{
	// Fields
	internal XmlDocument _doc; // 0x10
	internal DataSet _ds; // 0x18
	internal DataTable _dt; // 0x20
	internal XmlWriter _xmlw; // 0x28
	private bool _fBefore; // 0x30
	private bool _fErrors; // 0x31
	internal Hashtable _rowsOrder; // 0x38
	private ArrayList _tables; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x3241360 Offset: 0x323D360 VA: 0x3241360
	internal void .ctor(DataSet ds) { }

	// RVA: 0x3241718 Offset: 0x323D718 VA: 0x3241718
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x324183C Offset: 0x323D83C VA: 0x324183C
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0x32414A8 Offset: 0x323D4A8 VA: 0x32414A8
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0x3241BC0 Offset: 0x323DBC0 VA: 0x3241BC0
	private bool EmptyData() { }

	// RVA: 0x3241CB4 Offset: 0x323DCB4 VA: 0x3241CB4
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0x3241CBC Offset: 0x323DCBC VA: 0x3241CBC
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0x32420D4 Offset: 0x323E0D4 VA: 0x32420D4
	private void GenerateTable(DataTable table) { }

	// RVA: 0x3242150 Offset: 0x323E150 VA: 0x3242150
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0x3242690 Offset: 0x323E690 VA: 0x3242690
	private void GenerateRow(DataRow row) { }

	// RVA: 0x3242C30 Offset: 0x323EC30 VA: 0x3242C30
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0x32412F8 Offset: 0x323D2F8 VA: 0x32412F8
	internal static string QualifiedName(string prefix, string name) { }
}

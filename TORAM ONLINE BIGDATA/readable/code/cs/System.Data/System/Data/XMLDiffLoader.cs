// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class XMLDiffLoader // TypeDefIndex: 14779
{
	// Fields
	private ArrayList _tables; // 0x10
	private DataSet _dataSet; // 0x18
	private DataTable _dataTable; // 0x20

	// Methods

	// RVA: 0x3218AEC Offset: 0x3214AEC VA: 0x3218AEC
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0x3219330 Offset: 0x3215330 VA: 0x3219330
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x32196B4 Offset: 0x32156B4 VA: 0x32196B4
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0x3218CA0 Offset: 0x3214CA0 VA: 0x3218CA0
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0x32198C4 Offset: 0x32158C4 VA: 0x32198C4
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0x3218F90 Offset: 0x3214F90 VA: 0x3218F90
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0x3219BA8 Offset: 0x3215BA8 VA: 0x3219BA8
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0x321AF9C Offset: 0x3216F9C VA: 0x321AF9C
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0x321A0B8 Offset: 0x32160B8 VA: 0x321A0B8
	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	// RVA: 0x321A058 Offset: 0x3216058 VA: 0x321A058
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0x321B170 Offset: 0x3217170 VA: 0x321B170
	public void .ctor() { }
}

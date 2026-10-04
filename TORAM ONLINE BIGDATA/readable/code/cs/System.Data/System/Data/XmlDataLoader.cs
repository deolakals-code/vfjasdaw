// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class XmlDataLoader // TypeDefIndex: 14785
{
	// Fields
	private DataSet _dataSet; // 0x10
	private XmlToDatasetMap _nodeToSchemaMap; // 0x18
	private Hashtable _nodeToRowMap; // 0x20
	private Stack _childRowsStack; // 0x28
	private Hashtable _htableExcludedNS; // 0x30
	private bool _fIsXdr; // 0x38
	internal bool _isDiffgram; // 0x39
	private XmlElement _topMostNode; // 0x40
	private bool _ignoreSchema; // 0x48
	private DataTable _dataTable; // 0x50
	private bool _isTableLevel; // 0x58
	private bool _fromInference; // 0x59
	private XmlReader _dataReader; // 0x60
	private object _XSD_XMLNS_NS; // 0x68
	private object _XDR_SCHEMA; // 0x70
	private object _XDRNS; // 0x78
	private object _SQL_SYNC; // 0x80
	private object _UPDGNS; // 0x88
	private object _XSD_SCHEMA; // 0x90
	private object _XSDNS; // 0x98
	private object _DFFNS; // 0xA0
	private object _MSDNS; // 0xA8
	private object _DIFFID; // 0xB0
	private object _HASCHANGES; // 0xB8
	private object _ROWORDER; // 0xC0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x322BBC8 Offset: 0x3227BC8 VA: 0x322BBC8
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x322BC74 Offset: 0x3227C74 VA: 0x322BC74
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x322BD78 Offset: 0x3227D78 VA: 0x322BD78
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x322BE3C Offset: 0x3227E3C VA: 0x322BE3C
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x322BF58 Offset: 0x3227F58 VA: 0x322BF58
	internal bool get_FromInference() { }

	// RVA: 0x322BF60 Offset: 0x3227F60 VA: 0x322BF60
	internal void set_FromInference(bool value) { }

	// RVA: 0x322BF6C Offset: 0x3227F6C VA: 0x322BF6C
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x322C160 Offset: 0x3228160 VA: 0x322C160
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0x322C2E0 Offset: 0x32282E0 VA: 0x322C2E0
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0x322C504 Offset: 0x3228504 VA: 0x322C504
	private string GetInitialTextFromNodes(ref XmlNode n) { }

	// RVA: 0x322C70C Offset: 0x322870C VA: 0x322C70C
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0x322C0C8 Offset: 0x32280C8 VA: 0x322C0C8
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0x322C7D0 Offset: 0x32287D0 VA: 0x322C7D0
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0x322C254 Offset: 0x3228254 VA: 0x322C254
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0x322C8B8 Offset: 0x32288B8 VA: 0x322C8B8
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0x322CB6C Offset: 0x3228B6C VA: 0x322CB6C
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0x322C4B0 Offset: 0x32284B0 VA: 0x322C4B0
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0x322C7A0 Offset: 0x32287A0 VA: 0x322C7A0
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0x322CBF4 Offset: 0x3228BF4 VA: 0x322CBF4
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0x322D040 Offset: 0x3229040 VA: 0x322D040
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0x322DCD0 Offset: 0x3229CD0 VA: 0x322DCD0
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x322E010 Offset: 0x322A010 VA: 0x322E010
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0x322E080 Offset: 0x322A080 VA: 0x322E080
	private void InitNameTable() { }

	// RVA: 0x322E388 Offset: 0x322A388 VA: 0x322E388
	internal void LoadData(XmlReader reader) { }

	// RVA: 0x322E748 Offset: 0x322A748 VA: 0x322E748
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0x322F3A8 Offset: 0x322B3A8 VA: 0x322F3A8
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0x32301E8 Offset: 0x322C1E8 VA: 0x32301E8
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0x322F188 Offset: 0x322B188 VA: 0x322F188
	private bool ProcessXsdSchema() { }
}

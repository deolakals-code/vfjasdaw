// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class XmlToDatasetMap // TypeDefIndex: 14790
{
	// Fields
	private XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0x322CF24 Offset: 0x3228F24 VA: 0x322CF24
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x322E6E0 Offset: 0x322A6E0 VA: 0x322E6E0
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x322CEF0 Offset: 0x3228EF0 VA: 0x322CEF0
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x322E714 Offset: 0x322A714 VA: 0x322E714
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x322E058 Offset: 0x322A058 VA: 0x322E058
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0x3232B3C Offset: 0x322EB3C VA: 0x3232B3C
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0x3232D44 Offset: 0x322ED44 VA: 0x3232D44
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0x3232ECC Offset: 0x322EECC VA: 0x3232ECC
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x323315C Offset: 0x322F15C VA: 0x323315C
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x3230B50 Offset: 0x322CB50 VA: 0x3230B50
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x3231174 Offset: 0x322D174 VA: 0x3231174
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x3231CC4 Offset: 0x322DCC4 VA: 0x3231CC4
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x3232030 Offset: 0x322E030 VA: 0x3232030
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x32333C0 Offset: 0x322F3C0 VA: 0x32333C0
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0x322C998 Offset: 0x3228998 VA: 0x322C998
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x32300B0 Offset: 0x322C0B0 VA: 0x32300B0
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0x322CF58 Offset: 0x3228F58 VA: 0x322CF58
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x322F0B0 Offset: 0x322B0B0 VA: 0x322F0B0
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0x3233000 Offset: 0x322F000 VA: 0x3233000
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }
}

// Assembly: System.Data.dll
// Namespace: System.Data
[ToolboxItem("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[XmlRoot("DataSet")]
[XmlSchemaProvider("GetDataSetSchema")]
[DefaultProperty("DataSetName")]
[Serializable]
public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable // TypeDefIndex: 14658
{
	// Fields
	private DataViewManager _defaultViewManager; // 0x20
	private readonly DataTableCollection _tableCollection; // 0x28
	private readonly DataRelationCollection _relationCollection; // 0x30
	internal PropertyCollection _extendedProperties; // 0x38
	private string _dataSetName; // 0x40
	private string _datasetPrefix; // 0x48
	internal string _namespaceURI; // 0x50
	private bool _enforceConstraints; // 0x58
	private bool _caseSensitive; // 0x59
	private CultureInfo _culture; // 0x60
	private bool _cultureUserSet; // 0x68
	internal bool _fInReadXml; // 0x69
	internal bool _fInLoadDiffgram; // 0x6A
	internal bool _fTopLevelTable; // 0x6B
	internal bool _fInitInProgress; // 0x6C
	internal bool _fEnableCascading; // 0x6D
	internal bool _fIsSchemaLoading; // 0x6E
	internal string _mainTableName; // 0x70
	private SerializationFormat _remotingFormat; // 0x78
	private object _defaultViewManagerLock; // 0x80
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x88
	private static XmlSchemaComplexType s_schemaTypeForWSDL; // 0x8
	internal bool _useDataSetSchemaOnly; // 0x8C
	internal bool _udtIsWrapped; // 0x8D
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0x90
	[CompilerGenerated]
	private MergeFailedEventHandler MergeFailed; // 0x98
	[CompilerGenerated]
	private DataRowCreatedEventHandler DataRowCreated; // 0xA0
	[CompilerGenerated]
	private DataSetClearEventhandler ClearFunctionCalled; // 0xA8

	// Properties
	[DefaultValue(0)]
	public SerializationFormat RemotingFormat { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual SchemaSerializationMode SchemaSerializationMode { get; }
	[DefaultValue(False)]
	public bool CaseSensitive { get; set; }
	[DefaultValue(True)]
	public bool EnforceConstraints { get; set; }
	[DefaultValue("")]
	public string DataSetName { get; set; }
	[DefaultValue("")]
	public string Namespace { get; set; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	public CultureInfo Locale { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public override ISite Site { get; }
	[DesignerSerializationVisibility(2)]
	public DataRelationCollection Relations { get; }
	[DesignerSerializationVisibility(2)]
	public DataTableCollection Tables { get; }
	internal string MainTableName { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x31CA398 Offset: 0x31C6398 VA: 0x31CA398
	public void .ctor() { }

	// RVA: 0x31CA644 Offset: 0x31C6644 VA: 0x31CA644
	public void .ctor(string dataSetName) { }

	// RVA: 0x31CA7C8 Offset: 0x31C67C8 VA: 0x31CA7C8
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0x31CA7D0 Offset: 0x31C67D0 VA: 0x31CA7D0
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x31CA870 Offset: 0x31C6870 VA: 0x31CA870 Slot: 14
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0x31CA878 Offset: 0x31C6878 VA: 0x31CA878
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x31CA880 Offset: 0x31C6880 VA: 0x31CA880
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0x31CAAC0 Offset: 0x31C6AC0 VA: 0x31CAAC0 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x31CB0E8 Offset: 0x31C70E8 VA: 0x31CB0E8 Slot: 16
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0x31CAAC8 Offset: 0x31C6AC8 VA: 0x31CAAC8
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0x31CAA78 Offset: 0x31C6A78 VA: 0x31CAA78
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0x31CBE0C Offset: 0x31C7E0C VA: 0x31CBE0C
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0x31CC2FC Offset: 0x31C82FC VA: 0x31CC2FC
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0x31CB0EC Offset: 0x31C70EC VA: 0x31CB0EC
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x31CC4D0 Offset: 0x31C84D0 VA: 0x31CC4D0
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x31CB25C Offset: 0x31C725C VA: 0x31CB25C
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x31CC7D4 Offset: 0x31C87D4 VA: 0x31CC7D4
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x31CDA08 Offset: 0x31C9A08 VA: 0x31CDA08
	internal void FailedEnableConstraints() { }

	// RVA: 0x31CDBBC Offset: 0x31C9BBC VA: 0x31CDBBC
	public bool get_CaseSensitive() { }

	// RVA: 0x31CDBC4 Offset: 0x31C9BC4 VA: 0x31CDBC4
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x31CE2F0 Offset: 0x31CA2F0 VA: 0x31CE2F0
	public bool get_EnforceConstraints() { }

	// RVA: 0x31CDA34 Offset: 0x31C9A34 VA: 0x31CDA34
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0x31CEAA8 Offset: 0x31CAAA8 VA: 0x31CEAA8
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0x31CE2F8 Offset: 0x31CA2F8 VA: 0x31CE2F8
	internal void EnableConstraints() { }

	// RVA: 0x31CEAB4 Offset: 0x31CAAB4 VA: 0x31CEAB4
	public string get_DataSetName() { }

	// RVA: 0x31CA66C Offset: 0x31C666C VA: 0x31CA66C
	public void set_DataSetName(string value) { }

	// RVA: 0x31CEB34 Offset: 0x31CAB34 VA: 0x31CEB34
	public string get_Namespace() { }

	// RVA: 0x31CEB3C Offset: 0x31CAB3C VA: 0x31CEB3C
	public void set_Namespace(string value) { }

	// RVA: 0x31CF01C Offset: 0x31CB01C VA: 0x31CF01C
	public string get_Prefix() { }

	// RVA: 0x31CF024 Offset: 0x31CB024 VA: 0x31CF024
	public void set_Prefix(string value) { }

	// RVA: 0x31CD998 Offset: 0x31C9998 VA: 0x31CD998
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x31CF158 Offset: 0x31CB158 VA: 0x31CF158
	public CultureInfo get_Locale() { }

	// RVA: 0x31CF160 Offset: 0x31CB160 VA: 0x31CF160
	public void set_Locale(CultureInfo value) { }

	// RVA: 0x31CF300 Offset: 0x31CB300 VA: 0x31CF300
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0x31CFF10 Offset: 0x31CBF10 VA: 0x31CFF10
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x31CFF18 Offset: 0x31CBF18 VA: 0x31CFF18 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0x31CFF20 Offset: 0x31CBF20 VA: 0x31CFF20
	public DataRelationCollection get_Relations() { }

	// RVA: 0x31CFF28 Offset: 0x31CBF28 VA: 0x31CFF28
	public DataTableCollection get_Tables() { }

	// RVA: 0x31CFF30 Offset: 0x31CBF30 VA: 0x31CFF30
	public void Clear() { }

	// RVA: 0x31D0164 Offset: 0x31CC164 VA: 0x31D0164 Slot: 17
	public virtual DataSet Clone() { }

	// RVA: 0x31CBAD0 Offset: 0x31C7AD0 VA: 0x31CBAD0
	internal int EstimatedXmlStringSize() { }

	// RVA: 0x31D11D0 Offset: 0x31CD1D0 VA: 0x31D11D0
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0x31CB938 Offset: 0x31C7938 VA: 0x31CB938
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0x31D1300 Offset: 0x31CD300 VA: 0x31D1300
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0x31CD0B8 Offset: 0x31C90B8 VA: 0x31CD0B8
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x31D1708 Offset: 0x31CD708 VA: 0x31D1708
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0x31D1BB4 Offset: 0x31CDBB4 VA: 0x31D1BB4
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0x31D17BC Offset: 0x31CD7BC VA: 0x31D17BC
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0x31D1460 Offset: 0x31CD460 VA: 0x31D1460
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x31D1308 Offset: 0x31CD308 VA: 0x31D1308
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0x31D1C2C Offset: 0x31CDC2C VA: 0x31D1C2C
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x31D1E68 Offset: 0x31CDE68 VA: 0x31D1E68
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0x31D1E70 Offset: 0x31CDE70 VA: 0x31D1E70
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0x31D1850 Offset: 0x31CD850 VA: 0x31D1850
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0x31D4310 Offset: 0x31D0310 VA: 0x31D4310
	private bool IsEmpty() { }

	// RVA: 0x31D2F84 Offset: 0x31CEF84 VA: 0x31D2F84
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0x31CD990 Offset: 0x31C9990 VA: 0x31CD990
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0x31D4784 Offset: 0x31D0784 VA: 0x31D4784
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0x31CBBF0 Offset: 0x31C7BF0 VA: 0x31CBBF0
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0x31D4600 Offset: 0x31D0600 VA: 0x31D4600
	public void Merge(DataSet dataSet) { }

	// RVA: 0x31D5538 Offset: 0x31D1538 VA: 0x31D5538
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x31D57A4 Offset: 0x31D17A4 VA: 0x31D57A4 Slot: 18
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x31D57CC Offset: 0x31D17CC VA: 0x31D57CC
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0x31D5828 Offset: 0x31D1828 VA: 0x31D5828
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x31D58CC Offset: 0x31D18CC VA: 0x31D58CC
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0x31D013C Offset: 0x31CC13C VA: 0x31D013C
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0x31D58F4 Offset: 0x31D18F4 VA: 0x31D58F4 Slot: 19
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0x31D58F8 Offset: 0x31D18F8 VA: 0x31D58F8
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0x31D5924 Offset: 0x31D1924 VA: 0x31D5924 Slot: 20
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0x31D5928 Offset: 0x31D1928 VA: 0x31D5928
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0x31CEABC Offset: 0x31CAABC VA: 0x31CEABC
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x31D5938 Offset: 0x31D1938 VA: 0x31D5938
	internal DataTable[] TopLevelTables() { }

	// RVA: 0x31D5940 Offset: 0x31D1940 VA: 0x31D5940
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0x31D5C30 Offset: 0x31D1C30 VA: 0x31D5C30 Slot: 21
	public virtual void Reset() { }

	// RVA: 0x31CDEF0 Offset: 0x31C9EF0 VA: 0x31CDEF0
	internal bool ValidateCaseConstraint() { }

	// RVA: 0x31CFAB8 Offset: 0x31CBAB8 VA: 0x31CFAB8
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0x31D5EF0 Offset: 0x31D1EF0 VA: 0x31D5EF0 Slot: 22
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0x31D61D8 Offset: 0x31D21D8 VA: 0x31D61D8
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0x31D6454 Offset: 0x31D2454 VA: 0x31D6454 Slot: 10
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x31D6628 Offset: 0x31D2628 VA: 0x31D6628 Slot: 11
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x31D6878 Offset: 0x31D2878 VA: 0x31D6878 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x31D68AC Offset: 0x31D28AC VA: 0x31D68AC
	internal string get_MainTableName() { }

	// RVA: 0x31D68B4 Offset: 0x31D28B4 VA: 0x31D68B4
	internal void set_MainTableName(string value) { }

	// RVA: 0x31D68BC Offset: 0x31D28BC VA: 0x31D68BC
	internal int get_ObjectID() { }
}

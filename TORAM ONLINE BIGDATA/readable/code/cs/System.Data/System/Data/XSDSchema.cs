// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class XSDSchema : XMLSchema // TypeDefIndex: 14783
{
	// Fields
	private XmlSchemaSet _schemaSet; // 0x10
	private XmlSchemaElement _dsElement; // 0x18
	private DataSet _ds; // 0x20
	private string _schemaName; // 0x28
	private ArrayList _columnExpressions; // 0x30
	private Hashtable _constraintNodes; // 0x38
	private ArrayList _refTables; // 0x40
	private ArrayList _complexTypes; // 0x48
	private XmlSchemaObjectCollection _annotations; // 0x50
	private XmlSchemaObjectCollection _elements; // 0x58
	private Hashtable _attributes; // 0x60
	private Hashtable _elementsTable; // 0x68
	private Hashtable _attributeGroups; // 0x70
	private Hashtable _schemaTypes; // 0x78
	private Hashtable _expressions; // 0x80
	private Dictionary<DataTable, List<DataTable>> _tableDictionary; // 0x88
	private Hashtable _udSimpleTypes; // 0x90
	private Hashtable _existingSimpleTypeMap; // 0x98
	private bool _fromInference; // 0xA0
	private static readonly XSDSchema.NameType[] s_mapNameTypeXsd; // 0x0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x321B364 Offset: 0x3217364 VA: 0x321B364
	internal bool get_FromInference() { }

	// RVA: 0x321B36C Offset: 0x321736C VA: 0x321B36C
	internal void set_FromInference(bool value) { }

	// RVA: 0x321B378 Offset: 0x3217378 VA: 0x321B378
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0x321B400 Offset: 0x3217400 VA: 0x321B400
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0x3213004 Offset: 0x320F004 VA: 0x3213004
	internal static string QualifiedName(string name) { }

	// RVA: 0x321BDA8 Offset: 0x3217DA8 VA: 0x321BDA8
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x321C30C Offset: 0x321830C VA: 0x321C30C
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x321C69C Offset: 0x321869C VA: 0x321C69C
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x3212DBC Offset: 0x320EDBC VA: 0x3212DBC
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0x321C89C Offset: 0x321889C VA: 0x321C89C
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0x321CAE0 Offset: 0x3218AE0 VA: 0x321CAE0
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0x321CC9C Offset: 0x3218C9C VA: 0x321CC9C
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0x321D4F4 Offset: 0x32194F4 VA: 0x321D4F4
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x321D774 Offset: 0x3219774 VA: 0x321D774
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0x321E19C Offset: 0x321A19C VA: 0x321E19C
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0x321E534 Offset: 0x321A534 VA: 0x321E534
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0x321EB20 Offset: 0x321AB20 VA: 0x321EB20
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0x321EB44 Offset: 0x321AB44 VA: 0x321EB44
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0x3222538 Offset: 0x321E538 VA: 0x3222538
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0x321DD20 Offset: 0x3219D20 VA: 0x321DD20
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0x3222860 Offset: 0x321E860 VA: 0x3222860
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0x3223F34 Offset: 0x321FF34 VA: 0x3223F34
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0x3224BE8 Offset: 0x3220BE8 VA: 0x3224BE8
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0x3224FD0 Offset: 0x3220FD0 VA: 0x3224FD0
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0x321EA04 Offset: 0x321AA04 VA: 0x321EA04
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0x32266D4 Offset: 0x32226D4 VA: 0x32266D4
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0x3226850 Offset: 0x3222850 VA: 0x3226850
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0x321E3DC Offset: 0x321A3DC VA: 0x321E3DC
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0x3220DA8 Offset: 0x321CDA8 VA: 0x3220DA8
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0x3226B24 Offset: 0x3222B24 VA: 0x3226B24
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0x3226BA8 Offset: 0x3222BA8 VA: 0x3226BA8
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0x3226C94 Offset: 0x3222C94 VA: 0x3226C94
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0x322756C Offset: 0x322356C VA: 0x322756C
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0x322799C Offset: 0x322399C VA: 0x322799C
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0x321CBC4 Offset: 0x3218BC4 VA: 0x321CBC4
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0x32284EC Offset: 0x32244EC VA: 0x32284EC
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0x3229B70 Offset: 0x3225B70 VA: 0x3229B70
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0x3229C4C Offset: 0x3225C4C VA: 0x3229C4C
	private static XSDSchema.NameType FindNameType(string name) { }

	// RVA: 0x3229D20 Offset: 0x3225D20 VA: 0x3229D20
	private Type ParseDataType(string dt) { }

	// RVA: 0x3229E84 Offset: 0x3225E84 VA: 0x3229E84
	internal static bool IsXsdType(string name) { }

	// RVA: 0x3220E2C Offset: 0x321CE2C VA: 0x3220E2C
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0x3225D44 Offset: 0x3221D44 VA: 0x3225D44
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0x32255BC Offset: 0x32215BC VA: 0x32255BC
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0x3224230 Offset: 0x3220230 VA: 0x3224230
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0x3223228 Offset: 0x321F228 VA: 0x3223228
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0x3221250 Offset: 0x321D250 VA: 0x3221250
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0x3229EF4 Offset: 0x3225EF4 VA: 0x3229EF4
	private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

	// RVA: 0x32280DC Offset: 0x32240DC VA: 0x32280DC
	private string GetPrefix(string ns) { }

	// RVA: 0x322A108 Offset: 0x3226108 VA: 0x322A108
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0x32299E0 Offset: 0x32259E0 VA: 0x32299E0
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0x3227454 Offset: 0x3223454 VA: 0x3227454
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0x321DF30 Offset: 0x3219F30 VA: 0x321DF30
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0x32210D8 Offset: 0x321D0D8 VA: 0x32210D8
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0x322A520 Offset: 0x3226520 VA: 0x322A520
	public void .ctor() { }

	// RVA: 0x322A528 Offset: 0x3226528 VA: 0x322A528
	private static void .cctor() { }
}

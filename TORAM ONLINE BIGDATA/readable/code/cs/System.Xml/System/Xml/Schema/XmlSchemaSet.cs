// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaSet // TypeDefIndex: 13820
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private SortedList schemas; // 0x20
	private ValidationEventHandler internalEventHandler; // 0x28
	private ValidationEventHandler eventHandler; // 0x30
	private bool isCompiled; // 0x38
	private Hashtable schemaLocations; // 0x40
	private Hashtable chameleonSchemas; // 0x48
	private Hashtable targetNamespaces; // 0x50
	private bool compileAll; // 0x58
	private SchemaInfo cachedCompiledInfo; // 0x60
	private XmlReaderSettings readerSettings; // 0x68
	private XmlSchema schemaForSchema; // 0x70
	private XmlSchemaCompilationSettings compilationSettings; // 0x78
	internal XmlSchemaObjectTable elements; // 0x80
	internal XmlSchemaObjectTable attributes; // 0x88
	internal XmlSchemaObjectTable schemaTypes; // 0x90
	internal XmlSchemaObjectTable substitutionGroups; // 0x98
	private XmlSchemaObjectTable typeExtensions; // 0xA0
	private object internalSyncObject; // 0xA8

	// Properties
	internal object InternalSyncObject { get; }
	public bool IsCompiled { get; }
	public XmlResolver XmlResolver { set; }
	public XmlSchemaCompilationSettings CompilationSettings { get; set; }
	public int Count { get; }
	public XmlSchemaObjectTable GlobalElements { get; }
	public XmlSchemaObjectTable GlobalAttributes { get; }
	public XmlSchemaObjectTable GlobalTypes { get; }
	internal XmlSchemaObjectTable SubstitutionGroups { get; }
	internal Hashtable SchemaLocations { get; }
	internal XmlSchemaObjectTable TypeExtensions { get; }
	internal SchemaInfo CompiledInfo { get; }
	internal XmlReaderSettings ReaderSettings { get; }
	internal SortedList SortedSchemas { get; }

	// Methods

	// RVA: 0x333B3D0 Offset: 0x33373D0 VA: 0x333B3D0
	internal object get_InternalSyncObject() { }

	// RVA: 0x333B440 Offset: 0x3337440 VA: 0x333B440
	public void .ctor() { }

	// RVA: 0x333B49C Offset: 0x333749C VA: 0x333B49C
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x333B794 Offset: 0x3337794 VA: 0x333B794
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x333B8A4 Offset: 0x33378A4 VA: 0x333B8A4
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x333B95C Offset: 0x333795C VA: 0x333B95C
	public bool get_IsCompiled() { }

	// RVA: 0x333B964 Offset: 0x3337964 VA: 0x333B964
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x333B980 Offset: 0x3337980 VA: 0x333B980
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x333B988 Offset: 0x3337988 VA: 0x333B988
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x333B990 Offset: 0x3337990 VA: 0x333B990
	public int get_Count() { }

	// RVA: 0x333B9B4 Offset: 0x33379B4 VA: 0x333B9B4
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x333BA20 Offset: 0x3337A20 VA: 0x333BA20
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x333BA8C Offset: 0x3337A8C VA: 0x333BA8C
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x333BAF8 Offset: 0x3337AF8 VA: 0x333BAF8
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x333BB64 Offset: 0x3337B64 VA: 0x333BB64
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x333BB6C Offset: 0x3337B6C VA: 0x333BB6C
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x333BBD8 Offset: 0x3337BD8 VA: 0x333BBD8
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x333E304 Offset: 0x333A304 VA: 0x333E304
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x333E4A8 Offset: 0x333A4A8 VA: 0x333E4A8
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x333F354 Offset: 0x333B354 VA: 0x333F354
	public bool Contains(string targetNamespace) { }

	// RVA: 0x333F3D0 Offset: 0x333B3D0 VA: 0x333F3D0
	public void Compile() { }

	// RVA: 0x333F8F8 Offset: 0x333B8F8 VA: 0x333F8F8
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x334138C Offset: 0x333D38C VA: 0x334138C
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x33414F0 Offset: 0x333D4F0 VA: 0x33414F0
	public ICollection Schemas() { }

	// RVA: 0x33410FC Offset: 0x333D0FC VA: 0x33410FC
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x333E2AC Offset: 0x333A2AC VA: 0x333E2AC
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x33418AC Offset: 0x333D8AC VA: 0x33418AC
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x333E02C Offset: 0x333A02C VA: 0x333E02C
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x3341514 Offset: 0x333D514 VA: 0x3341514
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x3342074 Offset: 0x333E074 VA: 0x3342074
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x334254C Offset: 0x333E54C VA: 0x334254C
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x333EFF4 Offset: 0x333AFF4 VA: 0x333EFF4
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x333F89C Offset: 0x333B89C VA: 0x333F89C
	private void ClearTables() { }

	// RVA: 0x3341260 Offset: 0x333D260 VA: 0x3341260
	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	// RVA: 0x3341EFC Offset: 0x333DEFC VA: 0x3341EFC
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x333C548 Offset: 0x3338548 VA: 0x333C548
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x3342DD0 Offset: 0x333EDD0 VA: 0x3342DD0
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x3342DD8 Offset: 0x333EDD8 VA: 0x3342DD8
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x3342DE0 Offset: 0x333EDE0 VA: 0x3342DE0
	internal XmlResolver GetResolver() { }

	// RVA: 0x3342DFC Offset: 0x333EDFC VA: 0x3342DFC
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x3342C08 Offset: 0x333EC08 VA: 0x3342C08
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x3341C40 Offset: 0x333DC40 VA: 0x3341C40
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	// RVA: 0x3342E04 Offset: 0x333EE04 VA: 0x3342E04
	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	// RVA: 0x333EEF8 Offset: 0x333AEF8 VA: 0x333EEF8
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x3342F68 Offset: 0x333EF68 VA: 0x3342F68
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x3340AF4 Offset: 0x333CAF4 VA: 0x3340AF4
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x3340064 Offset: 0x333C064 VA: 0x3340064
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x3342928 Offset: 0x333E928 VA: 0x3342928
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x3342CAC Offset: 0x333ECAC VA: 0x3342CAC
	private void VerifyTables() { }

	// RVA: 0x3342F70 Offset: 0x333EF70 VA: 0x3342F70
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x333EF54 Offset: 0x333AF54 VA: 0x333EF54
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }
}

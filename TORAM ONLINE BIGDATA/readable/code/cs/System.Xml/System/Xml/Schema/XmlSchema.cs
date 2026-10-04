// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
[XmlRoot("schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
public class XmlSchema : XmlSchemaObject // TypeDefIndex: 13749
{
	// Fields
	private XmlSchemaForm attributeFormDefault; // 0x34
	private XmlSchemaForm elementFormDefault; // 0x38
	private XmlSchemaDerivationMethod blockDefault; // 0x3C
	private XmlSchemaDerivationMethod finalDefault; // 0x40
	private string targetNs; // 0x48
	private string version; // 0x50
	private XmlSchemaObjectCollection includes; // 0x58
	private XmlSchemaObjectCollection items; // 0x60
	private string id; // 0x68
	private XmlAttribute[] moreAttributes; // 0x70
	private bool isCompiled; // 0x78
	private bool isCompiledBySet; // 0x79
	private bool isPreprocessed; // 0x7A
	private bool isRedefined; // 0x7B
	private int errorCount; // 0x7C
	private XmlSchemaObjectTable attributes; // 0x80
	private XmlSchemaObjectTable attributeGroups; // 0x88
	private XmlSchemaObjectTable elements; // 0x90
	private XmlSchemaObjectTable types; // 0x98
	private XmlSchemaObjectTable groups; // 0xA0
	private XmlSchemaObjectTable notations; // 0xA8
	private XmlSchemaObjectTable identityConstraints; // 0xB0
	private static int globalIdCounter; // 0x0
	private ArrayList importedSchemas; // 0xB8
	private ArrayList importedNamespaces; // 0xC0
	private int schemaId; // 0xC8
	private Uri baseUri; // 0xD0
	private bool isChameleon; // 0xD8
	private Hashtable ids; // 0xE0
	private XmlDocument document; // 0xE8

	// Properties
	[DefaultValue(0)]
	[Xml("attributeFormDefault")]
	public XmlSchemaForm AttributeFormDefault { get; set; }
	[Xml("blockDefault")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod BlockDefault { get; set; }
	[DefaultValue(256)]
	[Xml("finalDefault")]
	public XmlSchemaDerivationMethod FinalDefault { get; set; }
	[DefaultValue(0)]
	[Xml("elementFormDefault")]
	public XmlSchemaForm ElementFormDefault { get; set; }
	[Xml("targetNamespace", DataType = "anyURI")]
	public string TargetNamespace { get; set; }
	[Xml("version", DataType = "token")]
	public string Version { get; set; }
	[XmlElement("include", typeof(XmlSchemaInclude))]
	[XmlElement("import", typeof(XmlSchemaImport))]
	[XmlElement("redefine", typeof(XmlSchemaRedefine))]
	public XmlSchemaObjectCollection Includes { get; }
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	[XmlElement("notation", typeof(XmlSchemaNotation))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	internal bool IsCompiledBySet { get; set; }
	[XmlIgnore]
	internal bool IsPreprocessed { get; set; }
	[XmlIgnore]
	internal bool IsRedefined { get; set; }
	[XmlIgnore]
	public XmlSchemaObjectTable Attributes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Elements { get; }
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlIgnore]
	public XmlSchemaObjectTable Groups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Notations { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable IdentityConstraints { get; }
	[XmlIgnore]
	internal Uri BaseUri { get; set; }
	[XmlIgnore]
	internal int SchemaId { get; }
	[XmlIgnore]
	internal bool IsChameleon { get; set; }
	[XmlIgnore]
	internal Hashtable Ids { get; }
	[XmlIgnore]
	internal XmlDocument Document { get; }
	[XmlIgnore]
	internal int ErrorCount { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }
	internal ArrayList ImportedSchemas { get; }
	internal ArrayList ImportedNamespaces { get; }

	// Methods

	// RVA: 0x3330890 Offset: 0x332C890 VA: 0x3330890
	public void .ctor() { }

	// RVA: 0x3330A6C Offset: 0x332CA6C VA: 0x3330A6C
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x3330C20 Offset: 0x332CC20 VA: 0x3330C20
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x3330E08 Offset: 0x332CE08 VA: 0x3330E08
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x3330EB8 Offset: 0x332CEB8 VA: 0x3330EB8
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0x3330EC0 Offset: 0x332CEC0 VA: 0x3330EC0
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x3330EC8 Offset: 0x332CEC8 VA: 0x3330EC8
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x3330ED0 Offset: 0x332CED0 VA: 0x3330ED0
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x3330ED8 Offset: 0x332CED8 VA: 0x3330ED8
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x3330EE0 Offset: 0x332CEE0 VA: 0x3330EE0
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x3330EE8 Offset: 0x332CEE8 VA: 0x3330EE8
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x3330EF0 Offset: 0x332CEF0 VA: 0x3330EF0
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x3330EF8 Offset: 0x332CEF8 VA: 0x3330EF8
	public string get_TargetNamespace() { }

	// RVA: 0x3330F00 Offset: 0x332CF00 VA: 0x3330F00
	public void set_TargetNamespace(string value) { }

	// RVA: 0x3330F08 Offset: 0x332CF08 VA: 0x3330F08
	public string get_Version() { }

	// RVA: 0x3330F10 Offset: 0x332CF10 VA: 0x3330F10
	public void set_Version(string value) { }

	// RVA: 0x3330F18 Offset: 0x332CF18 VA: 0x3330F18
	public XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x3330F20 Offset: 0x332CF20 VA: 0x3330F20
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x3330F28 Offset: 0x332CF28 VA: 0x3330F28
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x3330F30 Offset: 0x332CF30 VA: 0x3330F30
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x3330F3C Offset: 0x332CF3C VA: 0x3330F3C
	internal bool get_IsPreprocessed() { }

	// RVA: 0x3330F44 Offset: 0x332CF44 VA: 0x3330F44
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x3330F50 Offset: 0x332CF50 VA: 0x3330F50
	internal bool get_IsRedefined() { }

	// RVA: 0x3330F58 Offset: 0x332CF58 VA: 0x3330F58
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x3330F64 Offset: 0x332CF64 VA: 0x3330F64
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x3330FD4 Offset: 0x332CFD4 VA: 0x3330FD4
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x3331044 Offset: 0x332D044 VA: 0x3331044
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x33310B4 Offset: 0x332D0B4 VA: 0x33310B4
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x3331124 Offset: 0x332D124 VA: 0x3331124
	public string get_Id() { }

	// RVA: 0x333112C Offset: 0x332D12C VA: 0x333112C
	public void set_Id(string value) { }

	// RVA: 0x3331134 Offset: 0x332D134 VA: 0x3331134
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x333113C Offset: 0x332D13C VA: 0x333113C
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x3331144 Offset: 0x332D144 VA: 0x3331144
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0x333114C Offset: 0x332D14C VA: 0x333114C
	internal Uri get_BaseUri() { }

	// RVA: 0x3331154 Offset: 0x332D154 VA: 0x3331154
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x333115C Offset: 0x332D15C VA: 0x333115C
	internal int get_SchemaId() { }

	// RVA: 0x33311CC Offset: 0x332D1CC VA: 0x33311CC
	internal bool get_IsChameleon() { }

	// RVA: 0x33311D4 Offset: 0x332D1D4 VA: 0x33311D4
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x33311E0 Offset: 0x332D1E0 VA: 0x33311E0
	internal Hashtable get_Ids() { }

	// RVA: 0x33311E8 Offset: 0x332D1E8 VA: 0x33311E8
	internal XmlDocument get_Document() { }

	// RVA: 0x3331258 Offset: 0x332D258 VA: 0x3331258
	internal int get_ErrorCount() { }

	// RVA: 0x3331260 Offset: 0x332D260 VA: 0x3331260
	internal void set_ErrorCount(int value) { }

	// RVA: 0x3331268 Offset: 0x332D268 VA: 0x3331268
	internal XmlSchema Clone() { }

	// RVA: 0x33313B0 Offset: 0x332D3B0 VA: 0x33313B0
	internal XmlSchema DeepClone() { }

	// RVA: 0x333229C Offset: 0x332E29C VA: 0x333229C Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x33322A4 Offset: 0x332E2A4 VA: 0x33322A4 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x33322AC Offset: 0x332E2AC VA: 0x33322AC
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x33322B8 Offset: 0x332E2B8 VA: 0x33322B8 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x33322C0 Offset: 0x332E2C0 VA: 0x33322C0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x33322D8 Offset: 0x332E2D8 VA: 0x33322D8
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x3332348 Offset: 0x332E348 VA: 0x3332348
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x33323B8 Offset: 0x332E3B8 VA: 0x33323B8
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x3332578 Offset: 0x332E578 VA: 0x3332578
	private static void .cctor() { }
}

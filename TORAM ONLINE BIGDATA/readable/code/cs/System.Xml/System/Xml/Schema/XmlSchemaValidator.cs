// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public sealed class XmlSchemaValidator // TypeDefIndex: 13838
{
	// Fields
	private XmlSchemaSet schemaSet; // 0x10
	private XmlSchemaValidationFlags validationFlags; // 0x18
	private int startIDConstraint; // 0x1C
	private bool isRoot; // 0x20
	private bool rootHasSchema; // 0x21
	private bool attrValid; // 0x22
	private bool checkEntity; // 0x23
	private SchemaInfo compiledSchemaInfo; // 0x28
	private IDtdInfo dtdSchemaInfo; // 0x30
	private Hashtable validatedNamespaces; // 0x38
	private HWStack validationStack; // 0x40
	private ValidationState context; // 0x48
	private ValidatorState currentState; // 0x50
	private Hashtable attPresence; // 0x58
	private SchemaAttDef wildID; // 0x60
	private Hashtable IDs; // 0x68
	private IdRefNode idRefListHead; // 0x70
	private XmlQualifiedName contextQName; // 0x78
	private string NsXs; // 0x80
	private string NsXsi; // 0x88
	private string NsXmlNs; // 0x90
	private string NsXml; // 0x98
	private XmlSchemaObject partialValidationType; // 0xA0
	private StringBuilder textValue; // 0xA8
	private ValidationEventHandler eventHandler; // 0xB0
	private object validationEventSender; // 0xB8
	private XmlNameTable nameTable; // 0xC0
	private IXmlLineInfo positionInfo; // 0xC8
	private IXmlLineInfo dummyPositionInfo; // 0xD0
	private XmlResolver xmlResolver; // 0xD8
	private Uri sourceUri; // 0xE0
	private string sourceUriString; // 0xE8
	private IXmlNamespaceResolver nsResolver; // 0xF0
	private XmlSchemaContentProcessing processContents; // 0xF8
	private string xsiTypeString; // 0x100
	private string xsiNilString; // 0x108
	private string xsiSchemaLocationString; // 0x110
	private string xsiNoNamespaceSchemaLocationString; // 0x118
	private static readonly XmlSchemaDatatype dtQName; // 0x0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private static XmlSchemaParticle[] EmptyParticleArray; // 0x18
	private static XmlSchemaAttribute[] EmptyAttributeArray; // 0x20
	private XmlCharType xmlCharType; // 0x120
	internal static bool[,] ValidStates; // 0x28
	private static string[] MethodNames; // 0x30

	// Properties
	public XmlResolver XmlResolver { set; }
	public IXmlLineInfo LineInfoProvider { set; }
	public Uri SourceUri { set; }
	public object ValidationEventSender { set; }
	internal XmlSchemaSet SchemaSet { get; }
	internal XmlSchemaValidationFlags ValidationFlags { get; }
	internal XmlSchemaContentType CurrentContentType { get; }
	private bool StrictlyAssessed { get; }
	private bool HasSchema { get; }
	private bool HasIdentityConstraints { get; }
	internal bool ProcessIdentityConstraints { get; }
	internal bool ReportValidationWarnings { get; }
	internal bool ProcessSchemaHints { get; }

	// Methods

	// RVA: 0x33446A4 Offset: 0x33406A4 VA: 0x33446A4
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0x33448D4 Offset: 0x33408D4 VA: 0x33448D4
	private void Init() { }

	// RVA: 0x3344DE8 Offset: 0x3340DE8 VA: 0x3344DE8
	private void Reset() { }

	// RVA: 0x3344F64 Offset: 0x3340F64 VA: 0x3344F64
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x3344F6C Offset: 0x3340F6C VA: 0x3344F6C
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0x3344F7C Offset: 0x3340F7C VA: 0x3344F7C
	public void set_SourceUri(Uri value) { }

	// RVA: 0x3344FC8 Offset: 0x3340FC8 VA: 0x3344FC8
	public void set_ValidationEventSender(object value) { }

	// RVA: 0x3344FD0 Offset: 0x3340FD0 VA: 0x3344FD0
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x3345060 Offset: 0x3341060 VA: 0x3345060
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x33450F0 Offset: 0x33410F0 VA: 0x33450F0
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0x3345850 Offset: 0x3341850 VA: 0x3345850
	public void Initialize() { }

	// RVA: 0x3345990 Offset: 0x3341990 VA: 0x3345990
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0x3345C30 Offset: 0x3341C30 VA: 0x3345C30
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x33474D4 Offset: 0x33434D4 VA: 0x33474D4
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x3347530 Offset: 0x3343530 VA: 0x3347530
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x3348964 Offset: 0x3344964 VA: 0x3348964
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x3348C30 Offset: 0x3344C30 VA: 0x3348C30
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0x3348C8C Offset: 0x3344C8C VA: 0x3348C8C
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x33495C4 Offset: 0x33455C4 VA: 0x33495C4
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0x3349620 Offset: 0x3345620 VA: 0x3349620
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x33497EC Offset: 0x33457EC VA: 0x33497EC
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x3349CEC Offset: 0x3345CEC VA: 0x3349CEC
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x334A024 Offset: 0x3346024 VA: 0x334A024
	public void EndValidation() { }

	// RVA: 0x334A218 Offset: 0x3346218 VA: 0x334A218
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x334ABF0 Offset: 0x3346BF0 VA: 0x334ABF0
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x334ABF8 Offset: 0x3346BF8 VA: 0x334ABF8
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x334AC00 Offset: 0x3346C00 VA: 0x334AC00
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0x334AC34 Offset: 0x3346C34 VA: 0x334AC34
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0x334AC58 Offset: 0x3346C58 VA: 0x334AC58
	private bool get_StrictlyAssessed() { }

	// RVA: 0x334AC9C Offset: 0x3346C9C VA: 0x334AC9C
	private bool get_HasSchema() { }

	// RVA: 0x334ACE4 Offset: 0x3346CE4 VA: 0x334ACE4
	internal string GetConcatenatedValue() { }

	// RVA: 0x33497F4 Offset: 0x33457F4 VA: 0x33497F4
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0x3346874 Offset: 0x3342874 VA: 0x3346874
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x33461F4 Offset: 0x33421F4 VA: 0x33461F4
	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	// RVA: 0x334C838 Offset: 0x3348838 VA: 0x334C838
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0x334AD04 Offset: 0x3346D04 VA: 0x334AD04
	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x334AF88 Offset: 0x3346F88 VA: 0x334AF88
	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x334D58C Offset: 0x334958C VA: 0x334D58C
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0x3349054 Offset: 0x3345054 VA: 0x3349054
	private void SaveTextValue(object value) { }

	// RVA: 0x3344C94 Offset: 0x3340C94 VA: 0x3344C94
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x3349EF4 Offset: 0x3345EF4 VA: 0x3349EF4
	private void Pop() { }

	// RVA: 0x3346624 Offset: 0x3342624 VA: 0x3346624
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0x3346B9C Offset: 0x3342B9C VA: 0x3346B9C
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	// RVA: 0x334715C Offset: 0x334315C VA: 0x334715C
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0x334729C Offset: 0x334329C VA: 0x334729C
	private void CheckElementProperties() { }

	// RVA: 0x3347350 Offset: 0x3343350 VA: 0x3347350
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x3348078 Offset: 0x3344078 VA: 0x3348078
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0x334DE14 Offset: 0x3349E14 VA: 0x334DE14
	private void AddXmlNamespaceSchema() { }

	// RVA: 0x334B2A0 Offset: 0x33472A0 VA: 0x334B2A0
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0x334C334 Offset: 0x3348334 VA: 0x334C334
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x3344E90 Offset: 0x3340E90 VA: 0x3344E90
	internal void RecompileSchemaSet() { }

	// RVA: 0x334E064 Offset: 0x334A064 VA: 0x334E064
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0x33482CC Offset: 0x33442CC VA: 0x33482CC
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0x334D370 Offset: 0x3349370 VA: 0x334D370
	private object CheckElementValue(string stringValue) { }

	// RVA: 0x3348514 Offset: 0x3344514 VA: 0x3348514
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0x334E330 Offset: 0x334A330 VA: 0x334E330
	private object FindId(string name) { }

	// RVA: 0x334A110 Offset: 0x3346110 VA: 0x334A110
	private void CheckForwardRefs() { }

	// RVA: 0x33486A0 Offset: 0x33446A0 VA: 0x33486A0
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x334D654 Offset: 0x3349654 VA: 0x334D654
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0x334E5DC Offset: 0x334A5DC VA: 0x334E5DC
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0x3344F54 Offset: 0x3340F54 VA: 0x3344F54
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0x3345F90 Offset: 0x3341F90 VA: 0x3345F90
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0x33461A8 Offset: 0x33421A8 VA: 0x33461A8
	private void ClearPSVI() { }

	// RVA: 0x3348A2C Offset: 0x3344A2C VA: 0x3348A2C
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0x33473AC Offset: 0x33433AC VA: 0x33473AC
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0x334A824 Offset: 0x3346824 VA: 0x334A824
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0x334D660 Offset: 0x3349660 VA: 0x334D660
	private void AddIdentityConstraints() { }

	// RVA: 0x334DA64 Offset: 0x3349A64 VA: 0x334DA64
	private void ElementIdentityConstraints() { }

	// RVA: 0x33486C0 Offset: 0x33446C0 VA: 0x33486C0
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0x334B7A0 Offset: 0x33477A0 VA: 0x334B7A0
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0x334CC7C Offset: 0x3348C7C VA: 0x334CC7C
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x334B37C Offset: 0x334737C VA: 0x334B37C
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x33491E4 Offset: 0x33451E4 VA: 0x33491E4
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0x334EB5C Offset: 0x334AB5C VA: 0x334EB5C
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0x334E6A4 Offset: 0x334A6A4 VA: 0x334E6A4
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0x334ECD8 Offset: 0x334ACD8 VA: 0x334ECD8
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0x3348FE0 Offset: 0x3344FE0 VA: 0x3348FE0
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0x334CA24 Offset: 0x3348A24 VA: 0x334CA24
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0x3349094 Offset: 0x3345094 VA: 0x3349094
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0x334E34C Offset: 0x334A34C VA: 0x334E34C
	private void ProcessEntity(string name) { }

	// RVA: 0x334D5F4 Offset: 0x33495F4 VA: 0x334D5F4
	private void SendValidationEvent(string code) { }

	// RVA: 0x3348140 Offset: 0x3344140 VA: 0x3348140
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x3347F00 Offset: 0x3343F00 VA: 0x3347F00
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0x334CA88 Offset: 0x3348A88 VA: 0x334CA88
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0x334DE9C Offset: 0x3349E9C VA: 0x334DE9C
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0x33456B8 Offset: 0x33416B8 VA: 0x33456B8
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0x334E5E8 Offset: 0x334A5E8 VA: 0x334E5E8
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0x334C78C Offset: 0x334878C VA: 0x334C78C
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x334550C Offset: 0x334150C VA: 0x334550C
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x334E4C0 Offset: 0x334A4C0 VA: 0x334E4C0
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x334E5F0 Offset: 0x334A5F0 VA: 0x334E5F0
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x334EF18 Offset: 0x334AF18 VA: 0x334EF18
	private static void .cctor() { }
}

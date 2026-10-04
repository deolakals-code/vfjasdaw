// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class XsdValidator : BaseValidator // TypeDefIndex: 13871
{
	// Fields
	private int startIDConstraint; // 0x7C
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlNamespaceManager nsManager; // 0x90
	private bool bManageNamespaces; // 0x98
	private Hashtable IDs; // 0xA0
	private IdRefNode idRefListHead; // 0xA8
	private Parser inlineSchemaParser; // 0xB0
	private XmlSchemaContentProcessing processContents; // 0xB8
	private static readonly XmlSchemaDatatype dtCDATA; // 0x0
	private static readonly XmlSchemaDatatype dtQName; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private string NsXmlNs; // 0xC0
	private string NsXs; // 0xC8
	private string NsXsi; // 0xD0
	private string XsiType; // 0xD8
	private string XsiNil; // 0xE0
	private string XsiSchemaLocation; // 0xE8
	private string XsiNoNamespaceSchemaLocation; // 0xF0
	private string XsdSchema; // 0xF8

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }
	private bool HasIdentityConstraints { get; }

	// Methods

	// RVA: 0x337D448 Offset: 0x3379448 VA: 0x337D448
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x337D854 Offset: 0x3379854 VA: 0x337D854
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x337D46C Offset: 0x337946C VA: 0x337D46C
	private void Init() { }

	// RVA: 0x337D9B0 Offset: 0x33799B0 VA: 0x337D9B0 Slot: 5
	public override void Validate() { }

	// RVA: 0x337E068 Offset: 0x337A068 VA: 0x337E068 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x337DA68 Offset: 0x3379A68 VA: 0x337DA68
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x337DA78 Offset: 0x3379A78 VA: 0x337DA78
	private void ProcessInlineSchema() { }

	// RVA: 0x337DD1C Offset: 0x3379D1C VA: 0x337DD1C
	private void ValidateElement() { }

	// RVA: 0x337E190 Offset: 0x337A190 VA: 0x337E190
	private object ValidateChildElement() { }

	// RVA: 0x337E3CC Offset: 0x337A3CC VA: 0x337E3CC
	private void ProcessElement(object particle) { }

	// RVA: 0x337E6D8 Offset: 0x337A6D8 VA: 0x337E6D8
	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	// RVA: 0x337DE88 Offset: 0x3379E88 VA: 0x337DE88
	private void ValidateEndElement() { }

	// RVA: 0x337E5FC Offset: 0x337A5FC VA: 0x337E5FC
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x337EEEC Offset: 0x337AEEC VA: 0x337EEEC
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x337F344 Offset: 0x337B344 VA: 0x337F344
	private void ValidateStartElement() { }

	// RVA: 0x337FA0C Offset: 0x337BA0C VA: 0x337FA0C
	private void ValidateEndStartElement() { }

	// RVA: 0x33814E0 Offset: 0x337D4E0 VA: 0x33814E0
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x337FDF8 Offset: 0x337BDF8 VA: 0x337FDF8
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x337F2D4 Offset: 0x337B2D4 VA: 0x337F2D4
	private bool get_HasSchema() { }

	// RVA: 0x3381A58 Offset: 0x337DA58 VA: 0x3381A58 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x3381A90 Offset: 0x337DA90 VA: 0x3381A90
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x337FFB8 Offset: 0x337BFB8 VA: 0x337FFB8
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x3381CB4 Offset: 0x337DCB4 VA: 0x3381CB4
	internal void AddID(string name, object node) { }

	// RVA: 0x3381D50 Offset: 0x337DD50 VA: 0x3381D50 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x337E37C Offset: 0x337A37C VA: 0x337E37C
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x337D878 Offset: 0x3379878 VA: 0x337D878
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x33810A0 Offset: 0x337D0A0 VA: 0x33810A0
	private void Pop() { }

	// RVA: 0x337E06C Offset: 0x337A06C VA: 0x337E06C
	private void CheckForwardRefs() { }

	// RVA: 0x337F2F8 Offset: 0x337B2F8 VA: 0x337F2F8
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x338041C Offset: 0x337C41C VA: 0x338041C
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x3381D6C Offset: 0x337DD6C VA: 0x3381D6C
	private void AddIdentityConstraints() { }

	// RVA: 0x338217C Offset: 0x337E17C VA: 0x338217C
	private void ElementIdentityConstraints() { }

	// RVA: 0x3381204 Offset: 0x337D204 VA: 0x3381204
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x3381180 Offset: 0x337D180 VA: 0x3381180
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x338042C Offset: 0x337C42C VA: 0x338042C
	private void EndElementIdentityConstraints() { }

	// RVA: 0x33824C4 Offset: 0x337E4C4 VA: 0x33824C4
	private static void .cctor() { }
}

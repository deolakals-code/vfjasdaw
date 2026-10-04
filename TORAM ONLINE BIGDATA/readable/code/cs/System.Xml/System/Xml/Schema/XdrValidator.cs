// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class XdrValidator : BaseValidator // TypeDefIndex: 13745
{
	// Fields
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool isProcessContents; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x332C824 Offset: 0x3328824 VA: 0x332C824
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x332CAA0 Offset: 0x3328AA0 VA: 0x332CAA0
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x332C8AC Offset: 0x33288AC VA: 0x332C8AC
	private void Init() { }

	// RVA: 0x332CC64 Offset: 0x3328C64 VA: 0x332CC64 Slot: 5
	public override void Validate() { }

	// RVA: 0x332CF54 Offset: 0x3328F54 VA: 0x332CF54
	private void ValidateElement() { }

	// RVA: 0x332D2BC Offset: 0x33292BC VA: 0x332D2BC
	private void ValidateChildElement() { }

	// RVA: 0x332CD1C Offset: 0x3328D1C VA: 0x332CD1C
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x332CD2C Offset: 0x3328D2C VA: 0x332CD2C
	private void ProcessInlineSchema() { }

	// RVA: 0x332D400 Offset: 0x3329400 VA: 0x332D400
	private void ProcessElement() { }

	// RVA: 0x332D0F4 Offset: 0x33290F4 VA: 0x332D0F4
	private void ValidateEndElement() { }

	// RVA: 0x332D4C0 Offset: 0x33294C0 VA: 0x332D4C0
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x332D7EC Offset: 0x33297EC VA: 0x332D7EC
	private void ValidateStartElement() { }

	// RVA: 0x332DBE4 Offset: 0x3329BE4 VA: 0x332DBE4
	private void ValidateEndStartElement() { }

	// RVA: 0x332E854 Offset: 0x332A854 VA: 0x332E854
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x332E5FC Offset: 0x332A5FC VA: 0x332E5FC
	private void LoadSchema(string uri) { }

	// RVA: 0x332EED8 Offset: 0x332AED8 VA: 0x332EED8
	private bool get_HasSchema() { }

	// RVA: 0x332EEFC Offset: 0x332AEFC VA: 0x332EEFC Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x332EF34 Offset: 0x332AF34 VA: 0x332EF34
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x332F1F4 Offset: 0x332B1F4 VA: 0x332F1F4 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x332DF58 Offset: 0x3329F58 VA: 0x332DF58
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x332A540 Offset: 0x3326540 VA: 0x332A540
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x332F158 Offset: 0x332B158 VA: 0x332F158
	internal void AddID(string name, object node) { }

	// RVA: 0x332F484 Offset: 0x332B484 VA: 0x332F484 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x332CB40 Offset: 0x3328B40 VA: 0x332CB40
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x332E544 Offset: 0x332A544 VA: 0x332E544
	private void Pop() { }

	// RVA: 0x332F2B4 Offset: 0x332B2B4 VA: 0x332F2B4
	private void CheckForwardRefs() { }

	// RVA: 0x332E78C Offset: 0x332A78C VA: 0x332E78C
	private XmlQualifiedName QualifiedName(string name, string ns) { }
}

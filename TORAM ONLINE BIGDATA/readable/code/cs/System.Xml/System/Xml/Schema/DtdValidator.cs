// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class DtdValidator : BaseValidator // TypeDefIndex: 13687
{
	// Fields
	private static DtdValidator.NamespaceManager namespaceManager; // 0x0
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private Hashtable IDs; // 0x98
	private IdRefNode idRefListHead; // 0xA0
	private bool processIdentityConstraints; // 0xA8

	// Properties
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x34344A4 Offset: 0x34304A4 VA: 0x34344A4
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x343454C Offset: 0x343054C VA: 0x343454C
	private void Init() { }

	// RVA: 0x34347E0 Offset: 0x34307E0 VA: 0x34347E0 Slot: 5
	public override void Validate() { }

	// RVA: 0x3434AE0 Offset: 0x3430AE0 VA: 0x3434AE0
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x3434B80 Offset: 0x3430B80 VA: 0x3434B80
	private void ValidatePIComment() { }

	// RVA: 0x34349D8 Offset: 0x34309D8 VA: 0x34349D8
	private void ValidateElement() { }

	// RVA: 0x3434F30 Offset: 0x3430F30 VA: 0x3434F30
	private void ValidateChildElement() { }

	// RVA: 0x3435190 Offset: 0x3431190 VA: 0x3435190
	private void ValidateStartElement() { }

	// RVA: 0x3435B5C Offset: 0x3431B5C VA: 0x3435B5C
	private void ValidateEndStartElement() { }

	// RVA: 0x3435074 Offset: 0x3431074 VA: 0x3435074
	private void ProcessElement() { }

	// RVA: 0x3435D38 Offset: 0x3431D38 VA: 0x3435D38 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x3434D84 Offset: 0x3430D84 VA: 0x3434D84
	private void ValidateEndElement() { }

	// RVA: 0x3435F5C Offset: 0x3431F5C VA: 0x3435F5C Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x3435F94 Offset: 0x3431F94 VA: 0x3435F94
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x34355EC Offset: 0x34315EC VA: 0x34355EC
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x34361C8 Offset: 0x34321C8 VA: 0x34361C8
	internal void AddID(string name, object node) { }

	// RVA: 0x3436264 Offset: 0x3432264 VA: 0x3436264 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x3434C30 Offset: 0x3430C30 VA: 0x3434C30
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x3436280 Offset: 0x3432280 VA: 0x3436280
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x3435E38 Offset: 0x3431E38 VA: 0x3435E38
	private void CheckForwardRefs() { }

	// RVA: 0x34346B8 Offset: 0x34306B8 VA: 0x34346B8
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x3435D80 Offset: 0x3431D80 VA: 0x3435D80
	private bool Pop() { }

	// RVA: 0x3436314 Offset: 0x3432314 VA: 0x3436314
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x34366D4 Offset: 0x34326D4 VA: 0x34366D4
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x3436AE8 Offset: 0x3432AE8 VA: 0x3436AE8
	private static void .cctor() { }
}

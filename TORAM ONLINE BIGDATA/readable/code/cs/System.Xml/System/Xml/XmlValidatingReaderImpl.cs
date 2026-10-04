// Assembly: System.Xml.dll
// Namespace: System.Xml
internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 13360
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlTextReaderImpl coreReaderImpl; // 0x18
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x20
	private ValidationType validationType; // 0x28
	private BaseValidator validator; // 0x30
	private XmlSchemaCollection schemaCollection; // 0x38
	private bool processIdentityConstraints; // 0x40
	private XmlValidatingReaderImpl.ParsingFunction parsingFunction; // 0x44
	private XmlValidatingReaderImpl.ValidationEventHandling eventHandling; // 0x48
	private XmlParserContext parserContext; // 0x50
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x58
	private XmlReader outerReader; // 0x60
	private static XmlResolver s_tempResolver; // 0x0

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override int AttributeCount { get; }
	public override bool CanResolveEntity { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal ValidationType ValidationType { get; }
	internal XmlSchemaCollection Schemas { get; }
	internal bool Namespaces { get; }
	internal BaseValidator Validator { get; set; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool StandAlone { get; }
	internal object SchemaTypeObject { set; }
	internal object TypedValueObject { get; set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x33A03EC Offset: 0x339C3EC VA: 0x33A03EC
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x33A0B14 Offset: 0x339CB14 VA: 0x33A0B14 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x33A0BE4 Offset: 0x339CBE4 VA: 0x33A0BE4 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33A0C04 Offset: 0x339CC04 VA: 0x33A0C04 Slot: 7
	public override string get_Name() { }

	// RVA: 0x33A0C24 Offset: 0x339CC24 VA: 0x33A0C24 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x33A0C44 Offset: 0x339CC44 VA: 0x33A0C44 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x33A0C64 Offset: 0x339CC64 VA: 0x33A0C64 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x33A0C84 Offset: 0x339CC84 VA: 0x33A0C84 Slot: 11
	public override string get_Value() { }

	// RVA: 0x33A0CA4 Offset: 0x339CCA4 VA: 0x33A0CA4 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x33A0CC4 Offset: 0x339CCC4 VA: 0x33A0CC4 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x33A0CE8 Offset: 0x339CCE8 VA: 0x33A0CE8 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x33A0D0C Offset: 0x339CD0C VA: 0x33A0D0C Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x33A0D30 Offset: 0x339CD30 VA: 0x33A0D30 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x33A0D54 Offset: 0x339CD54 VA: 0x33A0D54 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x33A0D78 Offset: 0x339CD78 VA: 0x33A0D78 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x33A0D9C Offset: 0x339CD9C VA: 0x33A0D9C Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x33A0DD8 Offset: 0x339CDD8 VA: 0x33A0DD8 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x33A0DFC Offset: 0x339CDFC VA: 0x33A0DFC Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x33A0E20 Offset: 0x339CE20 VA: 0x33A0E20 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x33A0E44 Offset: 0x339CE44 VA: 0x33A0E44 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x33A0E68 Offset: 0x339CE68 VA: 0x33A0E68 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x33A0E8C Offset: 0x339CE8C VA: 0x33A0E8C Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x33A0EB0 Offset: 0x339CEB0 VA: 0x33A0EB0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x33A0EE8 Offset: 0x339CEE8 VA: 0x33A0EE8 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x33A0F18 Offset: 0x339CF18 VA: 0x33A0F18 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x33A0F50 Offset: 0x339CF50 VA: 0x33A0F50 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x33A0F88 Offset: 0x339CF88 VA: 0x33A0F88 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x33A0FC0 Offset: 0x339CFC0 VA: 0x33A0FC0 Slot: 31
	public override bool Read() { }

	// RVA: 0x33A1380 Offset: 0x339D380 VA: 0x33A1380 Slot: 33
	public override void Close() { }

	// RVA: 0x33A13B4 Offset: 0x339D3B4 VA: 0x33A13B4 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x33A13D8 Offset: 0x339D3D8 VA: 0x33A13D8 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x33A1430 Offset: 0x339D430 VA: 0x33A1430 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x33A1438 Offset: 0x339D438 VA: 0x33A1438 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x33A146C Offset: 0x339D46C VA: 0x33A146C
	internal void MoveOffEntityReference() { }

	// RVA: 0x33A151C Offset: 0x339D51C VA: 0x33A151C Slot: 42
	public override string ReadString() { }

	// RVA: 0x33A1538 Offset: 0x339D538 VA: 0x33A1538 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0x33A1540 Offset: 0x339D540 VA: 0x33A1540 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0x33A1628 Offset: 0x339D628 VA: 0x33A1628 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0x33A1710 Offset: 0x339D710 VA: 0x33A1710 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x33A17BC Offset: 0x339D7BC VA: 0x33A17BC Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x33A17CC Offset: 0x339D7CC VA: 0x33A17CC Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x33A1714 Offset: 0x339D714 VA: 0x33A1714
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x33A17D0 Offset: 0x339D7D0 VA: 0x33A17D0
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x33A187C Offset: 0x339D87C VA: 0x33A187C
	internal ValidationType get_ValidationType() { }

	// RVA: 0x33A1884 Offset: 0x339D884 VA: 0x33A1884
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x33A03D0 Offset: 0x339C3D0 VA: 0x33A03D0
	internal bool get_Namespaces() { }

	// RVA: 0x33A1184 Offset: 0x339D184 VA: 0x33A1184
	private void ParseDtdFromParserContext() { }

	// RVA: 0x33A188C Offset: 0x339D88C VA: 0x33A188C
	private void ValidateDtd() { }

	// RVA: 0x33A12F8 Offset: 0x339D2F8 VA: 0x33A12F8
	private void ResolveEntityInternally() { }

	// RVA: 0x33A09AC Offset: 0x339C9AC VA: 0x33A09AC
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x33A0808 Offset: 0x339C808 VA: 0x33A0808
	private XmlResolver GetResolver() { }

	// RVA: 0x33A1098 Offset: 0x339D098 VA: 0x33A1098
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x33A1908 Offset: 0x339D908 VA: 0x33A1908
	internal BaseValidator get_Validator() { }

	// RVA: 0x33A1910 Offset: 0x339D910 VA: 0x33A1910
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x33A1918 Offset: 0x339D918 VA: 0x33A1918 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x33A193C Offset: 0x339D93C VA: 0x33A193C
	internal bool get_StandAlone() { }

	// RVA: 0x33A1958 Offset: 0x339D958 VA: 0x33A1958
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x33A1974 Offset: 0x339D974 VA: 0x33A1974
	internal object get_TypedValueObject() { }

	// RVA: 0x33A1990 Offset: 0x339D990 VA: 0x33A1990
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x33A19AC Offset: 0x339D9AC VA: 0x33A19AC
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x33A19C8 Offset: 0x339D9C8 VA: 0x33A19C8 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x33A19EC Offset: 0x339D9EC VA: 0x33A19EC
	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }
}

// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class BaseValidator // TypeDefIndex: 13583
{
	// Fields
	private XmlSchemaCollection schemaCollection; // 0x10
	private IValidationEventHandling eventHandling; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaNames schemaNames; // 0x28
	private PositionInfo positionInfo; // 0x30
	private XmlResolver xmlResolver; // 0x38
	private Uri baseUri; // 0x40
	protected SchemaInfo schemaInfo; // 0x48
	protected XmlValidatingReaderImpl reader; // 0x50
	protected XmlQualifiedName elementName; // 0x58
	protected ValidationState context; // 0x60
	protected StringBuilder textValue; // 0x68
	protected string textString; // 0x70
	protected bool hasSibling; // 0x78
	protected bool checkDatatype; // 0x79

	// Properties
	public XmlValidatingReaderImpl Reader { get; }
	public XmlSchemaCollection SchemaCollection { get; }
	public XmlNameTable NameTable { get; }
	public SchemaNames SchemaNames { get; }
	public PositionInfo PositionInfo { get; }
	public XmlResolver XmlResolver { get; set; }
	public Uri BaseUri { get; set; }
	public ValidationEventHandler EventHandler { get; }
	public SchemaInfo SchemaInfo { get; }
	public IDtdInfo DtdInfo { set; }
	public virtual bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x3417C64 Offset: 0x3413C64 VA: 0x3417C64
	public void .ctor(BaseValidator other) { }

	// RVA: 0x3416680 Offset: 0x3412680 VA: 0x3416680
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x3417D1C Offset: 0x3413D1C VA: 0x3417D1C
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x3417D24 Offset: 0x3413D24 VA: 0x3417D24
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x3417D2C Offset: 0x3413D2C VA: 0x3417D2C
	public XmlNameTable get_NameTable() { }

	// RVA: 0x3416BB8 Offset: 0x3412BB8 VA: 0x3416BB8
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x3417D34 Offset: 0x3413D34 VA: 0x3417D34
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x3417D3C Offset: 0x3413D3C VA: 0x3417D3C
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x3417D44 Offset: 0x3413D44 VA: 0x3417D44
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x3417D4C Offset: 0x3413D4C VA: 0x3417D4C
	public Uri get_BaseUri() { }

	// RVA: 0x3417D54 Offset: 0x3413D54 VA: 0x3417D54
	public void set_BaseUri(Uri value) { }

	// RVA: 0x3417D5C Offset: 0x3413D5C VA: 0x3417D5C
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x3417E2C Offset: 0x3413E2C VA: 0x3417E2C
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0x3417E34 Offset: 0x3413E34 VA: 0x3417E34
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x3417F14 Offset: 0x3413F14 VA: 0x3417F14 Slot: 4
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x3417F1C Offset: 0x3413F1C VA: 0x3417F1C Slot: 5
	public virtual void Validate() { }

	// RVA: 0x3417F20 Offset: 0x3413F20 VA: 0x3417F20 Slot: 6
	public virtual void CompleteValidation() { }

	// RVA: 0x3417F24 Offset: 0x3413F24 VA: 0x3417F24 Slot: 7
	public virtual object FindId(string name) { }

	// RVA: 0x3417F2C Offset: 0x3413F2C VA: 0x3417F2C
	public void ValidateText() { }

	// RVA: 0x3418400 Offset: 0x3414400 VA: 0x3418400
	public void ValidateWhitespace() { }

	// RVA: 0x3418388 Offset: 0x3414388 VA: 0x3418388
	private void SaveTextValue(string value) { }

	// RVA: 0x341853C Offset: 0x341453C VA: 0x341853C
	protected void SendValidationEvent(string code) { }

	// RVA: 0x34182A0 Offset: 0x34142A0 VA: 0x34182A0
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x34181B8 Offset: 0x34141B8 VA: 0x34181B8
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0x341859C Offset: 0x341459C VA: 0x341859C
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x3418688 Offset: 0x3414688 VA: 0x3418688
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x341877C Offset: 0x341477C VA: 0x341877C
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x34185A4 Offset: 0x34145A4 VA: 0x34185A4
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x3418870 Offset: 0x3414870 VA: 0x3418870
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0x3418A30 Offset: 0x3414A30 VA: 0x3418A30
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0x3418C24 Offset: 0x3414C24 VA: 0x3418C24
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }
}

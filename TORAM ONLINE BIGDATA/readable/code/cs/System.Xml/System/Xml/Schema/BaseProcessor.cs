// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class BaseProcessor // TypeDefIndex: 13582
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private ValidationEventHandler eventHandler; // 0x20
	private XmlSchemaCompilationSettings compilationSettings; // 0x28
	private int errorCount; // 0x30
	private string NsXml; // 0x38

	// Properties
	protected XmlNameTable NameTable { get; }
	protected SchemaNames SchemaNames { get; }
	protected ValidationEventHandler EventHandler { get; }
	protected XmlSchemaCompilationSettings CompilationSettings { get; }
	protected bool HasErrors { get; }

	// Methods

	// RVA: 0x3416C58 Offset: 0x3412C58 VA: 0x3416C58
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x3416CDC Offset: 0x3412CDC VA: 0x3416CDC
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x3416DB0 Offset: 0x3412DB0 VA: 0x3416DB0
	protected XmlNameTable get_NameTable() { }

	// RVA: 0x3416DB8 Offset: 0x3412DB8 VA: 0x3416DB8
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x3416E3C Offset: 0x3412E3C VA: 0x3416E3C
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x3416E44 Offset: 0x3412E44 VA: 0x3416E44
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x3416E4C Offset: 0x3412E4C VA: 0x3416E4C
	protected bool get_HasErrors() { }

	// RVA: 0x3416E5C Offset: 0x3412E5C VA: 0x3416E5C
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x34172BC Offset: 0x34132BC VA: 0x34172BC
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x341750C Offset: 0x341350C VA: 0x341750C
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x34173E4 Offset: 0x34133E4 VA: 0x34173E4
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x34176A8 Offset: 0x34136A8 VA: 0x34176A8
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0x3417620 Offset: 0x3413620 VA: 0x3417620
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0x34177E8 Offset: 0x34137E8 VA: 0x34177E8
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0x34178DC Offset: 0x34138DC VA: 0x34178DC
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0x3417998 Offset: 0x3413998 VA: 0x3417998
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x3417AA4 Offset: 0x3413AA4 VA: 0x3417AA4
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x3417B28 Offset: 0x3413B28 VA: 0x3417B28
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x3417B30 Offset: 0x3413B30 VA: 0x3417B30
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x3417720 Offset: 0x3413720 VA: 0x3417720
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x3417BBC Offset: 0x3413BBC VA: 0x3417BBC
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }
}

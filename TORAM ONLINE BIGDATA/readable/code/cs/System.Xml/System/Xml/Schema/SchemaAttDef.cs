// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo // TypeDefIndex: 13713
{
	// Fields
	private string defExpanded; // 0x60
	private int lineNum; // 0x68
	private int linePos; // 0x6C
	private int valueLineNum; // 0x70
	private int valueLinePos; // 0x74
	private SchemaAttDef.Reserve reserved; // 0x78
	private bool defaultValueChecked; // 0x7C
	private XmlSchemaAttribute schemaAttribute; // 0x80
	public static readonly SchemaAttDef Empty; // 0x0

	// Properties
	private string System.Xml.IDtdAttributeInfo.Prefix { get; }
	private string System.Xml.IDtdAttributeInfo.LocalName { get; }
	private int System.Xml.IDtdAttributeInfo.LineNumber { get; }
	private int System.Xml.IDtdAttributeInfo.LinePosition { get; }
	private bool System.Xml.IDtdAttributeInfo.IsNonCDataType { get; }
	private bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdAttributeInfo.IsXmlAttribute { get; }
	private string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded { get; }
	private object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition { get; }
	internal int LinePosition { get; set; }
	internal int LineNumber { get; set; }
	internal int ValueLinePosition { get; set; }
	internal int ValueLineNumber { get; set; }
	internal string DefaultValueExpanded { get; set; }
	internal XmlTokenizedType TokenizedType { get; set; }
	internal SchemaAttDef.Reserve Reserved { get; set; }
	internal bool DefaultValueChecked { get; }
	internal XmlSchemaAttribute SchemaAttribute { get; set; }

	// Methods

	// RVA: 0x32EE974 Offset: 0x32EA974 VA: 0x32EE974
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x32EE97C Offset: 0x32EA97C VA: 0x32EE97C
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0x32EE988 Offset: 0x32EA988 VA: 0x32EE988
	private void .ctor() { }

	// RVA: 0x32EE990 Offset: 0x32EA990 VA: 0x32EE990 Slot: 8
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0x32EE998 Offset: 0x32EA998 VA: 0x32EE998 Slot: 9
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x32EE9B4 Offset: 0x32EA9B4 VA: 0x32EE9B4 Slot: 10
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x32EE9BC Offset: 0x32EA9BC VA: 0x32EE9BC Slot: 11
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0x32EE9C4 Offset: 0x32EA9C4 VA: 0x32EE9C4 Slot: 12
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0x32EEA10 Offset: 0x32EAA10 VA: 0x32EEA10 Slot: 13
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x32EEA18 Offset: 0x32EAA18 VA: 0x32EEA18 Slot: 14
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0x32EEA28 Offset: 0x32EAA28 VA: 0x32EEA28 Slot: 4
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x32EEAD0 Offset: 0x32EAAD0 VA: 0x32EEAD0 Slot: 5
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x32EEAD8 Offset: 0x32EAAD8 VA: 0x32EEAD8 Slot: 6
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0x32EEAE0 Offset: 0x32EAAE0 VA: 0x32EEAE0 Slot: 7
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x32EEAE8 Offset: 0x32EAAE8 VA: 0x32EEAE8
	internal int get_LinePosition() { }

	// RVA: 0x32EEAF0 Offset: 0x32EAAF0 VA: 0x32EEAF0
	internal void set_LinePosition(int value) { }

	// RVA: 0x32EEAF8 Offset: 0x32EAAF8 VA: 0x32EEAF8
	internal int get_LineNumber() { }

	// RVA: 0x32EEB00 Offset: 0x32EAB00 VA: 0x32EEB00
	internal void set_LineNumber(int value) { }

	// RVA: 0x32EEB08 Offset: 0x32EAB08 VA: 0x32EEB08
	internal int get_ValueLinePosition() { }

	// RVA: 0x32EEB10 Offset: 0x32EAB10 VA: 0x32EEB10
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x32EEB18 Offset: 0x32EAB18 VA: 0x32EEB18
	internal int get_ValueLineNumber() { }

	// RVA: 0x32EEB20 Offset: 0x32EAB20 VA: 0x32EEB20
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0x32EEA7C Offset: 0x32EAA7C VA: 0x32EEA7C
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x32EEB28 Offset: 0x32EAB28 VA: 0x32EEB28
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0x32EE9F0 Offset: 0x32EA9F0 VA: 0x32EE9F0
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x32EEB30 Offset: 0x32EAB30 VA: 0x32EEB30
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0x32EEB58 Offset: 0x32EAB58 VA: 0x32EEB58
	internal SchemaAttDef.Reserve get_Reserved() { }

	// RVA: 0x32EEB60 Offset: 0x32EAB60 VA: 0x32EEB60
	internal void set_Reserved(SchemaAttDef.Reserve value) { }

	// RVA: 0x32EEB68 Offset: 0x32EAB68 VA: 0x32EEB68
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x32EEB70 Offset: 0x32EAB70 VA: 0x32EEB70
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x32EEB78 Offset: 0x32EAB78 VA: 0x32EEB78
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x32EEB80 Offset: 0x32EAB80 VA: 0x32EEB80
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0x32EEDF8 Offset: 0x32EADF8 VA: 0x32EEDF8
	internal SchemaAttDef Clone() { }

	// RVA: 0x32EEE5C Offset: 0x32EAE5C VA: 0x32EEE5C
	private static void .cctor() { }
}

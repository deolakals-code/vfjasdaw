// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal abstract class SchemaDeclBase // TypeDefIndex: 13719
{
	// Fields
	protected XmlQualifiedName name; // 0x10
	protected string prefix; // 0x18
	protected bool isDeclaredInExternal; // 0x20
	protected SchemaDeclBase.Use presence; // 0x24
	protected XmlSchemaType schemaType; // 0x28
	protected XmlSchemaDatatype datatype; // 0x30
	protected string defaultValueRaw; // 0x38
	protected object defaultValueTyped; // 0x40
	protected long maxLength; // 0x48
	protected long minLength; // 0x50
	protected List<string> values; // 0x58

	// Properties
	internal XmlQualifiedName Name { get; set; }
	internal string Prefix { get; set; }
	internal bool IsDeclaredInExternal { get; set; }
	internal SchemaDeclBase.Use Presence { get; set; }
	internal long MaxLength { get; set; }
	internal long MinLength { get; set; }
	internal XmlSchemaType SchemaType { get; set; }
	internal XmlSchemaDatatype Datatype { get; set; }
	internal List<string> Values { get; set; }
	internal string DefaultValueRaw { get; set; }
	internal object DefaultValueTyped { get; set; }

	// Methods

	// RVA: 0x3308C90 Offset: 0x3304C90 VA: 0x3308C90
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x3308D40 Offset: 0x3304D40 VA: 0x3308D40
	protected void .ctor() { }

	// RVA: 0x3308DB0 Offset: 0x3304DB0 VA: 0x3308DB0
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x3308DB8 Offset: 0x3304DB8 VA: 0x3308DB8
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0x3308DC0 Offset: 0x3304DC0 VA: 0x3308DC0
	internal string get_Prefix() { }

	// RVA: 0x3308E14 Offset: 0x3304E14 VA: 0x3308E14
	internal void set_Prefix(string value) { }

	// RVA: 0x3308E1C Offset: 0x3304E1C VA: 0x3308E1C
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x3308E24 Offset: 0x3304E24 VA: 0x3308E24
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x3308E30 Offset: 0x3304E30 VA: 0x3308E30
	internal SchemaDeclBase.Use get_Presence() { }

	// RVA: 0x3308E38 Offset: 0x3304E38 VA: 0x3308E38
	internal void set_Presence(SchemaDeclBase.Use value) { }

	// RVA: 0x3308E40 Offset: 0x3304E40 VA: 0x3308E40
	internal long get_MaxLength() { }

	// RVA: 0x3308E48 Offset: 0x3304E48 VA: 0x3308E48
	internal void set_MaxLength(long value) { }

	// RVA: 0x3308E50 Offset: 0x3304E50 VA: 0x3308E50
	internal long get_MinLength() { }

	// RVA: 0x3308E58 Offset: 0x3304E58 VA: 0x3308E58
	internal void set_MinLength(long value) { }

	// RVA: 0x3308E60 Offset: 0x3304E60 VA: 0x3308E60
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x3308E68 Offset: 0x3304E68 VA: 0x3308E68
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x3308E70 Offset: 0x3304E70 VA: 0x3308E70
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x3308E78 Offset: 0x3304E78 VA: 0x3308E78
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0x3308E80 Offset: 0x3304E80 VA: 0x3308E80
	internal void AddValue(string value) { }

	// RVA: 0x3308F80 Offset: 0x3304F80 VA: 0x3308F80
	internal List<string> get_Values() { }

	// RVA: 0x3308F88 Offset: 0x3304F88 VA: 0x3308F88
	internal void set_Values(List<string> value) { }

	// RVA: 0x3308F90 Offset: 0x3304F90 VA: 0x3308F90
	internal string get_DefaultValueRaw() { }

	// RVA: 0x3308FE4 Offset: 0x3304FE4 VA: 0x3308FE4
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x3308FEC Offset: 0x3304FEC VA: 0x3308FEC
	internal object get_DefaultValueTyped() { }

	// RVA: 0x3308FF4 Offset: 0x3304FF4 VA: 0x3308FF4
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0x3308FFC Offset: 0x3304FFC VA: 0x3308FFC
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0x33090B4 Offset: 0x33050B4 VA: 0x33090B4
	internal bool CheckValue(object pVal) { }
}

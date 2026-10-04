// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class Datatype_string : Datatype_anySimpleType // TypeDefIndex: 13629
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x342C360 Offset: 0x3428360 VA: 0x342C360 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x342C36C Offset: 0x342836C VA: 0x342C36C Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x342C374 Offset: 0x3428374 VA: 0x342C374 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x342C3CC Offset: 0x34283CC VA: 0x342C3CC Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x342C3D4 Offset: 0x34283D4 VA: 0x342C3D4 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x342C3DC Offset: 0x34283DC VA: 0x342C3DC Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x342C3E4 Offset: 0x34283E4 VA: 0x342C3E4 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x34279DC Offset: 0x34239DC VA: 0x34279DC
	public void .ctor() { }
}

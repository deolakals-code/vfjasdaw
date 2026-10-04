// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public abstract class XmlSchemaDatatype // TypeDefIndex: 13772
{
	// Properties
	public abstract Type ValueType { get; }
	public abstract XmlTokenizedType TokenizedType { get; }
	public virtual XmlSchemaDatatypeVariety Variety { get; }
	public virtual XmlTypeCode TypeCode { get; }
	internal abstract bool HasLexicalFacets { get; }
	internal abstract bool HasValueFacets { get; }
	internal abstract XmlValueConverter ValueConverter { get; }
	internal abstract RestrictionFacets Restriction { get; }
	internal abstract FacetsChecker FacetsChecker { get; }
	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal string TypeCodeString { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlTokenizedType get_TokenizedType();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

	// RVA: 0x333621C Offset: 0x333221C VA: 0x333621C Slot: 7
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x3336224 Offset: 0x3332224 VA: 0x3336224 Slot: 8
	public virtual XmlTypeCode get_TypeCode() { }

	// RVA: 0x333622C Offset: 0x333222C VA: 0x333622C Slot: 9
	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool get_HasLexicalFacets();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool get_HasValueFacets();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract XmlValueConverter get_ValueConverter();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract RestrictionFacets get_Restriction();

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int Compare(object value1, object value2);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract FacetsChecker get_FacetsChecker();

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 22
	internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller);

	// RVA: -1 Offset: -1 Slot: 23
	internal abstract bool IsEqual(object o1, object o2);

	// RVA: -1 Offset: -1 Slot: 24
	internal abstract bool IsComparable(XmlSchemaDatatype dtype);

	// RVA: 0x3336234 Offset: 0x3332234 VA: 0x3336234
	internal string get_TypeCodeString() { }

	// RVA: 0x333635C Offset: 0x333235C VA: 0x333635C
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x3336808 Offset: 0x3332808 VA: 0x3336808
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x3329000 Offset: 0x3325000 VA: 0x3329000
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x3336EDC Offset: 0x3332EDC VA: 0x3336EDC
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x3327900 Offset: 0x3323900 VA: 0x3327900
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x3336F34 Offset: 0x3332F34 VA: 0x3336F34
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x33253F8 Offset: 0x33213F8 VA: 0x33253F8
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x3336F9C Offset: 0x3332F9C VA: 0x3336F9C
	protected void .ctor() { }
}

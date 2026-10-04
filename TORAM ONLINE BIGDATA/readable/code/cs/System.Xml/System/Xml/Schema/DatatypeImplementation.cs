// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal abstract class DatatypeImplementation : XmlSchemaDatatype // TypeDefIndex: 13623
{
	// Fields
	private XmlSchemaDatatypeVariety variety; // 0x10
	private RestrictionFacets restriction; // 0x18
	private DatatypeImplementation baseType; // 0x20
	private XmlValueConverter valueConverter; // 0x28
	private XmlSchemaType parentSchemaType; // 0x30
	private static Hashtable builtinTypes; // 0x0
	private static XmlSchemaSimpleType[] enumToTypeCode; // 0x8
	private static XmlSchemaSimpleType anySimpleType; // 0x10
	private static XmlSchemaSimpleType anyAtomicType; // 0x18
	private static XmlSchemaSimpleType untypedAtomicType; // 0x20
	private static XmlSchemaSimpleType yearMonthDurationType; // 0x28
	private static XmlSchemaSimpleType dayTimeDurationType; // 0x30
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; // 0x38
	private static XmlSchemaSimpleType tokenTypeV1Compat; // 0x40
	internal static XmlQualifiedName QnAnySimpleType; // 0x48
	internal static XmlQualifiedName QnAnyType; // 0x50
	internal static FacetsChecker stringFacetsChecker; // 0x58
	internal static FacetsChecker miscFacetsChecker; // 0x60
	internal static FacetsChecker numeric2FacetsChecker; // 0x68
	internal static FacetsChecker binaryFacetsChecker; // 0x70
	internal static FacetsChecker dateTimeFacetsChecker; // 0x78
	internal static FacetsChecker durationFacetsChecker; // 0x80
	internal static FacetsChecker listFacetsChecker; // 0x88
	internal static FacetsChecker qnameFacetsChecker; // 0x90
	internal static FacetsChecker unionFacetsChecker; // 0x98
	private static readonly DatatypeImplementation c_anySimpleType; // 0xA0
	private static readonly DatatypeImplementation c_anyURI; // 0xA8
	private static readonly DatatypeImplementation c_base64Binary; // 0xB0
	private static readonly DatatypeImplementation c_boolean; // 0xB8
	private static readonly DatatypeImplementation c_byte; // 0xC0
	private static readonly DatatypeImplementation c_char; // 0xC8
	private static readonly DatatypeImplementation c_date; // 0xD0
	private static readonly DatatypeImplementation c_dateTime; // 0xD8
	private static readonly DatatypeImplementation c_dateTimeNoTz; // 0xE0
	private static readonly DatatypeImplementation c_dateTimeTz; // 0xE8
	private static readonly DatatypeImplementation c_day; // 0xF0
	private static readonly DatatypeImplementation c_decimal; // 0xF8
	private static readonly DatatypeImplementation c_double; // 0x100
	private static readonly DatatypeImplementation c_doubleXdr; // 0x108
	private static readonly DatatypeImplementation c_duration; // 0x110
	private static readonly DatatypeImplementation c_ENTITY; // 0x118
	private static readonly DatatypeImplementation c_ENTITIES; // 0x120
	private static readonly DatatypeImplementation c_ENUMERATION; // 0x128
	private static readonly DatatypeImplementation c_fixed; // 0x130
	private static readonly DatatypeImplementation c_float; // 0x138
	private static readonly DatatypeImplementation c_floatXdr; // 0x140
	private static readonly DatatypeImplementation c_hexBinary; // 0x148
	private static readonly DatatypeImplementation c_ID; // 0x150
	private static readonly DatatypeImplementation c_IDREF; // 0x158
	private static readonly DatatypeImplementation c_IDREFS; // 0x160
	private static readonly DatatypeImplementation c_int; // 0x168
	private static readonly DatatypeImplementation c_integer; // 0x170
	private static readonly DatatypeImplementation c_language; // 0x178
	private static readonly DatatypeImplementation c_long; // 0x180
	private static readonly DatatypeImplementation c_month; // 0x188
	private static readonly DatatypeImplementation c_monthDay; // 0x190
	private static readonly DatatypeImplementation c_Name; // 0x198
	private static readonly DatatypeImplementation c_NCName; // 0x1A0
	private static readonly DatatypeImplementation c_negativeInteger; // 0x1A8
	private static readonly DatatypeImplementation c_NMTOKEN; // 0x1B0
	private static readonly DatatypeImplementation c_NMTOKENS; // 0x1B8
	private static readonly DatatypeImplementation c_nonNegativeInteger; // 0x1C0
	private static readonly DatatypeImplementation c_nonPositiveInteger; // 0x1C8
	private static readonly DatatypeImplementation c_normalizedString; // 0x1D0
	private static readonly DatatypeImplementation c_NOTATION; // 0x1D8
	private static readonly DatatypeImplementation c_positiveInteger; // 0x1E0
	private static readonly DatatypeImplementation c_QName; // 0x1E8
	private static readonly DatatypeImplementation c_QNameXdr; // 0x1F0
	private static readonly DatatypeImplementation c_short; // 0x1F8
	private static readonly DatatypeImplementation c_string; // 0x200
	private static readonly DatatypeImplementation c_time; // 0x208
	private static readonly DatatypeImplementation c_timeNoTz; // 0x210
	private static readonly DatatypeImplementation c_timeTz; // 0x218
	private static readonly DatatypeImplementation c_token; // 0x220
	private static readonly DatatypeImplementation c_unsignedByte; // 0x228
	private static readonly DatatypeImplementation c_unsignedInt; // 0x230
	private static readonly DatatypeImplementation c_unsignedLong; // 0x238
	private static readonly DatatypeImplementation c_unsignedShort; // 0x240
	private static readonly DatatypeImplementation c_uuid; // 0x248
	private static readonly DatatypeImplementation c_year; // 0x250
	private static readonly DatatypeImplementation c_yearMonth; // 0x258
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; // 0x260
	internal static readonly DatatypeImplementation c_tokenV1Compat; // 0x268
	private static readonly DatatypeImplementation c_anyAtomicType; // 0x270
	private static readonly DatatypeImplementation c_dayTimeDuration; // 0x278
	private static readonly DatatypeImplementation c_untypedAtomicType; // 0x280
	private static readonly DatatypeImplementation c_yearMonthDuration; // 0x288
	private static readonly DatatypeImplementation[] c_tokenizedTypes; // 0x290
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; // 0x298
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes; // 0x2A0
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes; // 0x2A8

	// Properties
	internal static XmlSchemaSimpleType AnySimpleType { get; }
	internal static XmlSchemaSimpleType UntypedAtomicType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override XmlValueConverter ValueConverter { get; }
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	public override XmlSchemaDatatypeVariety Variety { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFacets Restriction { get; }
	internal override bool HasLexicalFacets { get; }
	internal override bool HasValueFacets { get; }
	protected DatatypeImplementation Base { get; }
	internal abstract Type ListValueType { get; }
	internal abstract RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x3423108 Offset: 0x341F108 VA: 0x3423108
	private static void .cctor() { }

	// RVA: 0x3428804 Offset: 0x3424804 VA: 0x3428804
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x342885C Offset: 0x342485C VA: 0x342885C
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x34288B4 Offset: 0x34248B4 VA: 0x34288B4
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x3428930 Offset: 0x3424930 VA: 0x3428930
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x34289AC Offset: 0x34249AC VA: 0x34289AC
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x3428A6C Offset: 0x3424A6C VA: 0x3428A6C
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x3428B2C Offset: 0x3424B2C VA: 0x3428B2C
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x3428C10 Offset: 0x3424C10 VA: 0x3428C10
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x3427F34 Offset: 0x3423F34 VA: 0x3427F34
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x3428E54 Offset: 0x3424E54 VA: 0x3428E54
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x3428ED0 Offset: 0x3424ED0 VA: 0x3428ED0
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x3428F90 Offset: 0x3424F90 VA: 0x3428F90
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x3429128 Offset: 0x3425128 VA: 0x3429128
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x34292C0 Offset: 0x34252C0 VA: 0x34292C0
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x3429318 Offset: 0x3425318 VA: 0x3429318
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x3429448 Offset: 0x3425448 VA: 0x3429448 Slot: 20
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x3429564 Offset: 0x3425564 VA: 0x3429564 Slot: 21
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x3427370 Offset: 0x3423370 VA: 0x3427370
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x3429668 Offset: 0x3425668 VA: 0x3429668
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x3429798 Offset: 0x3425798 VA: 0x3429798 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x342979C Offset: 0x342579C VA: 0x342979C Slot: 9
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x3429A34 Offset: 0x3425A34 VA: 0x3429A34 Slot: 23
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x3429A58 Offset: 0x3425A58 VA: 0x3429A58 Slot: 24
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x3429B44 Offset: 0x3425B44 VA: 0x3429B44 Slot: 25
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x3429B4C Offset: 0x3425B4C VA: 0x3429B4C Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x3429BA4 Offset: 0x3425BA4 VA: 0x3429BA4 Slot: 12
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0x3429BF4 Offset: 0x3425BF4 VA: 0x3429BF4 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x3429BFC Offset: 0x3425BFC VA: 0x3429BFC Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x3429C68 Offset: 0x3425C68 VA: 0x3429C68 Slot: 7
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x3429C70 Offset: 0x3425C70 VA: 0x3429C70 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x3429C78 Offset: 0x3425C78 VA: 0x3429C78 Slot: 13
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x3429C80 Offset: 0x3425C80 VA: 0x3429C80 Slot: 10
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x3429CA8 Offset: 0x3425CA8 VA: 0x3429CA8 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x3429CD0 Offset: 0x3425CD0 VA: 0x3429CD0
	protected DatatypeImplementation get_Base() { }

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract Type get_ListValueType();

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract RestrictionFlags get_ValidRestrictionFlags();

	// RVA: 0x3429CD8 Offset: 0x3425CD8 VA: 0x3429CD8 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x3429CE0 Offset: 0x3425CE0 VA: 0x3429CE0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x3429F20 Offset: 0x3425F20 VA: 0x3429F20 Slot: 15
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x342A074 Offset: 0x3426074 VA: 0x342A074 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x3429EB4 Offset: 0x3425EB4 VA: 0x3429EB4
	internal string GetTypeName() { }

	// RVA: 0x342A474 Offset: 0x3426474 VA: 0x342A474
	protected int Compare(byte[] value1, byte[] value2) { }

	// RVA: 0x342A4E8 Offset: 0x34264E8 VA: 0x342A4E8
	protected void .ctor() { }
}

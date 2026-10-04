// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo // TypeDefIndex: 13720
{
	// Fields
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; // 0x60
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; // 0x68
	private bool isIdDeclared; // 0x70
	private bool hasNonCDataAttribute; // 0x71
	private bool isAbstract; // 0x72
	private bool isNillable; // 0x73
	private bool hasRequiredAttribute; // 0x74
	private bool isNotationDeclared; // 0x75
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; // 0x78
	private ContentValidator contentValidator; // 0x80
	private XmlSchemaAnyAttribute anyAttribute; // 0x88
	private XmlSchemaDerivationMethod block; // 0x90
	private CompiledIdentityConstraint[] constraints; // 0x98
	private XmlSchemaElement schemaElement; // 0xA0
	internal static readonly SchemaElementDecl Empty; // 0x0

	// Properties
	private bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes { get; }
	internal bool IsIdDeclared { get; set; }
	internal bool HasNonCDataAttribute { get; set; }
	internal bool IsAbstract { get; set; }
	internal bool IsNillable { get; set; }
	internal XmlSchemaDerivationMethod Block { get; set; }
	internal bool IsNotationDeclared { get; set; }
	internal bool HasDefaultAttribute { get; }
	internal bool HasRequiredAttribute { get; }
	internal ContentValidator ContentValidator { get; set; }
	internal XmlSchemaAnyAttribute AnyAttribute { get; set; }
	internal CompiledIdentityConstraint[] Constraints { get; set; }
	internal XmlSchemaElement SchemaElement { get; set; }
	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs { get; }
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes { get; }

	// Methods

	// RVA: 0x3309104 Offset: 0x3305104 VA: 0x3309104
	internal void .ctor() { }

	// RVA: 0x33091DC Offset: 0x33051DC VA: 0x33091DC
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0x330930C Offset: 0x330530C VA: 0x330930C
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x33093FC Offset: 0x33053FC VA: 0x33093FC
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0x33094C8 Offset: 0x33054C8 VA: 0x33094C8 Slot: 4
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x33094D0 Offset: 0x33054D0 VA: 0x33094D0 Slot: 5
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x3309584 Offset: 0x3305584 VA: 0x3309584 Slot: 6
	private IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0x330958C Offset: 0x330558C VA: 0x330958C
	internal bool get_IsIdDeclared() { }

	// RVA: 0x3309594 Offset: 0x3305594 VA: 0x3309594
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0x33095A0 Offset: 0x33055A0 VA: 0x33095A0
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0x33095A8 Offset: 0x33055A8 VA: 0x33095A8
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0x33095B4 Offset: 0x33055B4 VA: 0x33095B4
	internal SchemaElementDecl Clone() { }

	// RVA: 0x3309618 Offset: 0x3305618 VA: 0x3309618
	internal bool get_IsAbstract() { }

	// RVA: 0x3309620 Offset: 0x3305620 VA: 0x3309620
	internal void set_IsAbstract(bool value) { }

	// RVA: 0x330962C Offset: 0x330562C VA: 0x330962C
	internal bool get_IsNillable() { }

	// RVA: 0x3309634 Offset: 0x3305634 VA: 0x3309634
	internal void set_IsNillable(bool value) { }

	// RVA: 0x3309640 Offset: 0x3305640 VA: 0x3309640
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x3309648 Offset: 0x3305648 VA: 0x3309648
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x3309650 Offset: 0x3305650 VA: 0x3309650
	internal bool get_IsNotationDeclared() { }

	// RVA: 0x3309658 Offset: 0x3305658 VA: 0x3309658
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0x3309664 Offset: 0x3305664 VA: 0x3309664
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0x3309674 Offset: 0x3305674 VA: 0x3309674
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x330967C Offset: 0x330567C VA: 0x330967C
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x3309684 Offset: 0x3305684 VA: 0x3309684
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x330968C Offset: 0x330568C VA: 0x330968C
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x3309694 Offset: 0x3305694 VA: 0x3309694
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x330969C Offset: 0x330569C VA: 0x330969C
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x33096A4 Offset: 0x33056A4 VA: 0x33096A4
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x33096AC Offset: 0x33056AC VA: 0x33096AC
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x33096B4 Offset: 0x33056B4 VA: 0x33096B4
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x33096BC Offset: 0x33056BC VA: 0x33096BC
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0x330982C Offset: 0x330582C VA: 0x330982C
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x33098A4 Offset: 0x33058A4 VA: 0x33098A4
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x33098AC Offset: 0x33058AC VA: 0x33098AC
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	// RVA: 0x33098B4 Offset: 0x33058B4 VA: 0x33098B4
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0x33098BC Offset: 0x33058BC VA: 0x33098BC
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0x3309B54 Offset: 0x3305B54 VA: 0x3309B54
	private static void .cctor() { }
}

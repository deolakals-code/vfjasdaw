// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class SchemaInfo : IDtdInfo // TypeDefIndex: 13723
{
	// Fields
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; // 0x10
	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls; // 0x18
	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities; // 0x20
	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities; // 0x28
	private XmlQualifiedName docTypeName; // 0x30
	private string internalDtdSubset; // 0x38
	private bool hasNonCDataAttributes; // 0x40
	private bool hasDefaultAttributes; // 0x41
	private Dictionary<string, bool> targetNamespaces; // 0x48
	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls; // 0x50
	private int errorCount; // 0x58
	private SchemaType schemaType; // 0x5C
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType; // 0x60
	private Dictionary<string, SchemaNotation> notations; // 0x68

	// Properties
	public XmlQualifiedName DocTypeName { get; set; }
	internal string InternalDtdSubset { set; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities { get; }
	internal SchemaType SchemaType { get; set; }
	internal Dictionary<string, bool> TargetNamespaces { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls { get; }
	internal Dictionary<string, SchemaNotation> Notations { get; }
	internal int ErrorCount { get; set; }
	private bool System.Xml.IDtdInfo.HasDefaultAttributes { get; }
	private bool System.Xml.IDtdInfo.HasNonCDataAttributes { get; }
	private XmlQualifiedName System.Xml.IDtdInfo.Name { get; }
	private string System.Xml.IDtdInfo.InternalDtdSubset { get; }

	// Methods

	// RVA: 0x330A00C Offset: 0x330600C VA: 0x330A00C
	internal void .ctor() { }

	// RVA: 0x330A1FC Offset: 0x33061FC VA: 0x330A1FC
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x330A204 Offset: 0x3306204 VA: 0x330A204
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x330A20C Offset: 0x330620C VA: 0x330A20C
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x330A214 Offset: 0x3306214 VA: 0x330A214
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x330A21C Offset: 0x330621C VA: 0x330A21C
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0x330A224 Offset: 0x3306224 VA: 0x330A224
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	// RVA: 0x330A2A8 Offset: 0x33062A8 VA: 0x330A2A8
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x330A32C Offset: 0x330632C VA: 0x330A32C
	internal SchemaType get_SchemaType() { }

	// RVA: 0x330A334 Offset: 0x3306334 VA: 0x330A334
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x330A33C Offset: 0x330633C VA: 0x330A33C
	internal Dictionary<string, bool> get_TargetNamespaces() { }

	// RVA: 0x330A344 Offset: 0x3306344 VA: 0x330A344
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x330A34C Offset: 0x330634C VA: 0x330A34C
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0x330A354 Offset: 0x3306354 VA: 0x330A354
	internal Dictionary<string, SchemaNotation> get_Notations() { }

	// RVA: 0x330A3D8 Offset: 0x33063D8 VA: 0x330A3D8
	internal int get_ErrorCount() { }

	// RVA: 0x330A3E0 Offset: 0x33063E0 VA: 0x330A3E0
	internal void set_ErrorCount(int value) { }

	// RVA: 0x330A3E8 Offset: 0x33063E8 VA: 0x330A3E8
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0x330A460 Offset: 0x3306460 VA: 0x330A460
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0x330A4D8 Offset: 0x33064D8 VA: 0x330A4D8
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0x330A4F0 Offset: 0x33064F0 VA: 0x330A4F0
	internal bool HasSchema(string ns) { }

	// RVA: 0x330A548 Offset: 0x3306548 VA: 0x330A548
	internal bool Contains(string ns) { }

	// RVA: 0x330A5A0 Offset: 0x33065A0 VA: 0x330A5A0
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0x330A6EC Offset: 0x33066EC VA: 0x330A6EC
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	// RVA: 0x330A90C Offset: 0x330690C VA: 0x330A90C
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	// RVA: 0x330AA04 Offset: 0x3306A04 VA: 0x330AA04
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0x330B2DC Offset: 0x33072DC VA: 0x330B2DC
	internal void Finish() { }

	// RVA: 0x330B490 Offset: 0x3307490 VA: 0x330B490 Slot: 6
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x330B498 Offset: 0x3307498 VA: 0x330B498 Slot: 7
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x330B4A0 Offset: 0x33074A0 VA: 0x330B4A0 Slot: 8
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0x330B568 Offset: 0x3307568 VA: 0x330B568 Slot: 9
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x330B61C Offset: 0x330761C VA: 0x330B61C Slot: 4
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x330B624 Offset: 0x3307624 VA: 0x330B624 Slot: 5
	private string System.Xml.IDtdInfo.get_InternalDtdSubset() { }
}

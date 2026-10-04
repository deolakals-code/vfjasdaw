// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
public class XmlTypeMapping : XmlMapping // TypeDefIndex: 13567
{
	// Fields
	private string xmlType; // 0x48
	private string xmlTypeNamespace; // 0x50
	private TypeData type; // 0x58
	private XmlTypeMapping baseMap; // 0x60
	private bool multiReferenceType; // 0x68
	private bool includeInSchema; // 0x69
	private bool isNullable; // 0x6A
	private bool isAny; // 0x6B
	private ArrayList _derivedTypes; // 0x70

	// Properties
	public string TypeFullName { get; }
	internal TypeData TypeData { get; }
	internal string XmlType { get; set; }
	internal string XmlTypeNamespace { get; set; }
	internal bool HasXmlTypeNamespace { get; }
	internal ArrayList DerivedTypes { get; }
	internal bool MultiReferenceType { get; }
	internal XmlTypeMapping BaseMap { get; set; }
	internal bool IncludeInSchema { set; }
	internal bool IsNullable { get; set; }
	internal bool IsAny { get; set; }

	// Methods

	// RVA: 0x3410E98 Offset: 0x340CE98 VA: 0x3410E98
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0x340E150 Offset: 0x340A150 VA: 0x340E150
	public string get_TypeFullName() { }

	// RVA: 0x3410F70 Offset: 0x340CF70 VA: 0x3410F70
	internal TypeData get_TypeData() { }

	// RVA: 0x3410F78 Offset: 0x340CF78 VA: 0x3410F78
	internal string get_XmlType() { }

	// RVA: 0x3410F80 Offset: 0x340CF80 VA: 0x3410F80
	internal void set_XmlType(string value) { }

	// RVA: 0x3408E20 Offset: 0x3404E20 VA: 0x3408E20
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x3410F88 Offset: 0x340CF88 VA: 0x3410F88
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0x3410F90 Offset: 0x340CF90 VA: 0x3410F90
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x3410FA0 Offset: 0x340CFA0 VA: 0x3410FA0
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0x3410FA8 Offset: 0x340CFA8 VA: 0x3410FA8
	internal bool get_MultiReferenceType() { }

	// RVA: 0x3410FB0 Offset: 0x340CFB0 VA: 0x3410FB0
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0x3410FB8 Offset: 0x340CFB8 VA: 0x3410FB8
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0x3410FC0 Offset: 0x340CFC0 VA: 0x3410FC0
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0x3410FCC Offset: 0x340CFCC VA: 0x3410FCC
	internal bool get_IsNullable() { }

	// RVA: 0x3410FD4 Offset: 0x340CFD4 VA: 0x3410FD4
	internal void set_IsNullable(bool value) { }

	// RVA: 0x3410FE0 Offset: 0x340CFE0 VA: 0x3410FE0
	internal bool get_IsAny() { }

	// RVA: 0x3410FE8 Offset: 0x340CFE8 VA: 0x3410FE8
	internal void set_IsAny(bool value) { }

	// RVA: 0x3408CB0 Offset: 0x3404CB0 VA: 0x3408CB0
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0x3410FF4 Offset: 0x340CFF4 VA: 0x3410FF4
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0x34113B8 Offset: 0x340D3B8 VA: 0x34113B8
	internal void UpdateRoot(XmlQualifiedName qname) { }
}

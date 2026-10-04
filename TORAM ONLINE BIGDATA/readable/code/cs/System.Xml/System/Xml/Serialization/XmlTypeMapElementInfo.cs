// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfo // TypeDefIndex: 13556
{
	// Fields
	private string _elementName; // 0x10
	private string _namespace; // 0x18
	private XmlSchemaForm _form; // 0x20
	private XmlTypeMapMember _member; // 0x28
	private object _choiceValue; // 0x30
	private bool _isNullable; // 0x38
	private int _nestingLevel; // 0x3C
	private XmlTypeMapping _mappedType; // 0x40
	private TypeData _type; // 0x48
	private bool _wrappedElement; // 0x50
	private int _explicitOrder; // 0x54

	// Properties
	public TypeData TypeData { get; }
	public object ChoiceValue { get; set; }
	public string ElementName { get; set; }
	public string Namespace { get; set; }
	public string DataTypeNamespace { get; }
	public string DataTypeName { get; }
	public XmlSchemaForm Form { get; set; }
	public XmlTypeMapping MappedType { get; set; }
	public bool IsNullable { get; set; }
	public XmlTypeMapMember Member { get; }
	public int NestingLevel { set; }
	public bool MultiReferenceType { get; }
	public bool WrappedElement { get; set; }
	public bool IsTextElement { get; set; }
	public bool IsUnnamedAnyElement { get; set; }
	public int ExplicitOrder { get; set; }

	// Methods

	// RVA: 0x340FAE4 Offset: 0x340BAE4 VA: 0x340FAE4
	public void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x340FBB0 Offset: 0x340BBB0 VA: 0x340FBB0
	public TypeData get_TypeData() { }

	// RVA: 0x340FBB8 Offset: 0x340BBB8 VA: 0x340FBB8
	public object get_ChoiceValue() { }

	// RVA: 0x340FBC0 Offset: 0x340BBC0 VA: 0x340FBC0
	public void set_ChoiceValue(object value) { }

	// RVA: 0x340FBC8 Offset: 0x340BBC8 VA: 0x340FBC8
	public string get_ElementName() { }

	// RVA: 0x340FBD0 Offset: 0x340BBD0 VA: 0x340FBD0
	public void set_ElementName(string value) { }

	// RVA: 0x340FBD8 Offset: 0x340BBD8 VA: 0x340FBD8
	public string get_Namespace() { }

	// RVA: 0x340FBE0 Offset: 0x340BBE0 VA: 0x340FBE0
	public void set_Namespace(string value) { }

	// RVA: 0x340CC60 Offset: 0x3408C60 VA: 0x340CC60
	public string get_DataTypeNamespace() { }

	// RVA: 0x340CC30 Offset: 0x3408C30 VA: 0x340CC30
	public string get_DataTypeName() { }

	// RVA: 0x340FBE8 Offset: 0x340BBE8 VA: 0x340FBE8
	public XmlSchemaForm get_Form() { }

	// RVA: 0x340FBF0 Offset: 0x340BBF0 VA: 0x340FBF0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x340FBF8 Offset: 0x340BBF8 VA: 0x340FBF8
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x340FC00 Offset: 0x340BC00 VA: 0x340FC00
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x340FC08 Offset: 0x340BC08 VA: 0x340FC08
	public bool get_IsNullable() { }

	// RVA: 0x340FC10 Offset: 0x340BC10 VA: 0x340FC10
	public void set_IsNullable(bool value) { }

	// RVA: 0x340FC1C Offset: 0x340BC1C VA: 0x340FC1C
	public XmlTypeMapMember get_Member() { }

	// RVA: 0x340FC24 Offset: 0x340BC24 VA: 0x340FC24
	public void set_NestingLevel(int value) { }

	// RVA: 0x340FC2C Offset: 0x340BC2C VA: 0x340FC2C
	public bool get_MultiReferenceType() { }

	// RVA: 0x340FC4C Offset: 0x340BC4C VA: 0x340FC4C
	public bool get_WrappedElement() { }

	// RVA: 0x340FC54 Offset: 0x340BC54 VA: 0x340FC54
	public void set_WrappedElement(bool value) { }

	// RVA: 0x340FC60 Offset: 0x340BC60 VA: 0x340FC60
	public bool get_IsTextElement() { }

	// RVA: 0x340FCAC Offset: 0x340BCAC VA: 0x340FCAC
	public void set_IsTextElement(bool value) { }

	// RVA: 0x340FD74 Offset: 0x340BD74 VA: 0x340FD74
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0x340FDC8 Offset: 0x340BDC8 VA: 0x340FDC8
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x340FE84 Offset: 0x340BE84 VA: 0x340FE84
	public int get_ExplicitOrder() { }

	// RVA: 0x340FE8C Offset: 0x340BE8C VA: 0x340FE8C
	public void set_ExplicitOrder(int value) { }

	// RVA: 0x340FE94 Offset: 0x340BE94 VA: 0x340FE94 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x340FFCC Offset: 0x340BFCC VA: 0x340FFCC Slot: 2
	public override int GetHashCode() { }
}

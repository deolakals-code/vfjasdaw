// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal class TypeData // TypeDefIndex: 13503
{
	// Fields
	private Type type; // 0x10
	private string elementName; // 0x18
	private SchemaTypes sType; // 0x20
	private Type listItemType; // 0x28
	private string typeName; // 0x30
	private string fullTypeName; // 0x38
	private TypeData listItemTypeData; // 0x40
	private TypeData mappedType; // 0x48
	private XmlSchemaPatternFacet facet; // 0x50
	private MethodInfo typeConvertor; // 0x58
	private bool hasPublicConstructor; // 0x60
	private bool nullableOverride; // 0x61
	private static string[] keywords; // 0x0

	// Properties
	public string TypeName { get; }
	public string XmlType { get; }
	public Type Type { get; }
	public string FullTypeName { get; }
	public SchemaTypes SchemaType { get; }
	public bool IsListType { get; }
	public bool IsComplexType { get; }
	public bool IsValueType { get; }
	public bool IsNullable { get; set; }
	public TypeData ListItemTypeData { get; }
	public Type ListItemType { get; }
	public bool IsXsdType { get; }
	public bool HasPublicConstructor { get; }

	// Methods

	// RVA: 0x33E82E8 Offset: 0x33E42E8 VA: 0x33E82E8
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x33E82F8 Offset: 0x33E42F8 VA: 0x33E82F8
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x33E88E4 Offset: 0x33E48E4 VA: 0x33E88E4
	private void LookupTypeConvertor() { }

	// RVA: 0x33E8998 Offset: 0x33E4998 VA: 0x33E8998
	internal void ConvertForAssignment(ref object value) { }

	// RVA: 0x33E8A8C Offset: 0x33E4A8C VA: 0x33E8A8C
	public string get_TypeName() { }

	// RVA: 0x33E8A94 Offset: 0x33E4A94 VA: 0x33E8A94
	public string get_XmlType() { }

	// RVA: 0x33E8A9C Offset: 0x33E4A9C VA: 0x33E8A9C
	public Type get_Type() { }

	// RVA: 0x33E8AA4 Offset: 0x33E4AA4 VA: 0x33E8AA4
	public string get_FullTypeName() { }

	// RVA: 0x33E8AAC Offset: 0x33E4AAC VA: 0x33E8AAC
	public SchemaTypes get_SchemaType() { }

	// RVA: 0x33E7E20 Offset: 0x33E3E20 VA: 0x33E7E20
	public bool get_IsListType() { }

	// RVA: 0x33E8AB4 Offset: 0x33E4AB4 VA: 0x33E8AB4
	public bool get_IsComplexType() { }

	// RVA: 0x33E8AEC Offset: 0x33E4AEC VA: 0x33E8AEC
	public bool get_IsValueType() { }

	// RVA: 0x33E8B80 Offset: 0x33E4B80 VA: 0x33E8B80
	public bool get_IsNullable() { }

	// RVA: 0x33E8C94 Offset: 0x33E4C94 VA: 0x33E8C94
	public void set_IsNullable(bool value) { }

	// RVA: 0x33E8714 Offset: 0x33E4714 VA: 0x33E8714
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x33E8CA0 Offset: 0x33E4CA0 VA: 0x33E8CA0
	public Type get_ListItemType() { }

	// RVA: 0x33E8ADC Offset: 0x33E4ADC VA: 0x33E8ADC
	public bool get_IsXsdType() { }

	// RVA: 0x33E97FC Offset: 0x33E57FC VA: 0x33E97FC
	public bool get_HasPublicConstructor() { }

	// RVA: 0x33E95A8 Offset: 0x33E55A8 VA: 0x33E95A8
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x33E96E8 Offset: 0x33E56E8 VA: 0x33E96E8
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x33E93B4 Offset: 0x33E53B4 VA: 0x33E93B4
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x33E9804 Offset: 0x33E5804 VA: 0x33E9804
	private static void .cctor() { }
}

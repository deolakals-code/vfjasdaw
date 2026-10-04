// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal class XmlSerializationReaderInterpreter : XmlSerializationReader // TypeDefIndex: 13544
{
	// Fields
	private XmlMapping _typeMap; // 0xD0
	private SerializationFormat _format; // 0xD8
	private static readonly XmlQualifiedName AnyType; // 0x0
	private static readonly object[] empty_array; // 0x8

	// Methods

	// RVA: 0x33FEE24 Offset: 0x33FAE24 VA: 0x33FEE24
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x33FEE68 Offset: 0x33FAE68 VA: 0x33FEE68 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x33FF284 Offset: 0x33FB284 VA: 0x33FF284 Slot: 5
	protected override void InitIDs() { }

	// RVA: 0x33FF288 Offset: 0x33FB288 VA: 0x33FF288
	public object ReadRoot() { }

	// RVA: 0x33FF468 Offset: 0x33FB468 VA: 0x33FF468
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x33FF56C Offset: 0x33FB56C VA: 0x33FF56C Slot: 6
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x33FF390 Offset: 0x33FB390 VA: 0x33FF390
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x34020F0 Offset: 0x33FE0F0 VA: 0x34020F0 Slot: 7
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x3402850 Offset: 0x33FE850 VA: 0x3402850 Slot: 8
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x3402B38 Offset: 0x33FEB38 VA: 0x3402B38 Slot: 9
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x33FFB18 Offset: 0x33FBB18 VA: 0x33FFB18
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x33FFF1C Offset: 0x33FBF1C VA: 0x33FFF1C
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x340327C Offset: 0x33FF27C VA: 0x340327C
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x3403800 Offset: 0x33FF800 VA: 0x3403800
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x3403C00 Offset: 0x33FFC00 VA: 0x3403C00 Slot: 10
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x3403C34 Offset: 0x33FFC34 VA: 0x3403C34 Slot: 11
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x34033C4 Offset: 0x33FF3C4 VA: 0x34033C4
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x3402D18 Offset: 0x33FED18 VA: 0x3402D18
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x33FFA58 Offset: 0x33FBA58 VA: 0x33FFA58
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x3402EAC Offset: 0x33FEEAC VA: 0x3402EAC
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x34035A8 Offset: 0x33FF5A8 VA: 0x34035A8
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x3403C68 Offset: 0x33FFC68 VA: 0x3403C68
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x3402BE0 Offset: 0x33FEBE0 VA: 0x3402BE0
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x34021D4 Offset: 0x33FE1D4 VA: 0x34021D4
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x3403D80 Offset: 0x33FFD80 VA: 0x3403D80
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x3402F78 Offset: 0x33FEF78 VA: 0x3402F78
	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x3402B2C Offset: 0x33FEB2C VA: 0x3402B2C
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x33FF9F4 Offset: 0x33FB9F4 VA: 0x33FF9F4
	private object CreateInstance(Type type) { }

	// RVA: 0x340350C Offset: 0x33FF50C VA: 0x340350C
	private object CreateList(Type listType) { }

	// RVA: 0x3403428 Offset: 0x33FF428 VA: 0x3403428
	private object InitializeList(TypeData listType) { }

	// RVA: 0x34040E0 Offset: 0x34000E0 VA: 0x34040E0
	private void FillList(object list, object items) { }

	// RVA: 0x34040F0 Offset: 0x34000F0 VA: 0x34040F0
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x34020D4 Offset: 0x33FE0D4 VA: 0x34020D4
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x3403740 Offset: 0x33FF740 VA: 0x3403740
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x3402594 Offset: 0x33FE594 VA: 0x3402594
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x340264C Offset: 0x33FE64C VA: 0x340264C
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x3403FB0 Offset: 0x33FFFB0 VA: 0x3403FB0
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x34026BC Offset: 0x33FE6BC VA: 0x34026BC
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x3404540 Offset: 0x3400540 VA: 0x3404540
	private static void .cctor() { }
}

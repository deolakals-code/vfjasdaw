// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal class XmlSerializationWriterInterpreter : XmlSerializationWriter // TypeDefIndex: 13549
{
	// Fields
	private XmlMapping _typeMap; // 0x48
	private SerializationFormat _format; // 0x50

	// Methods

	// RVA: 0x3407B00 Offset: 0x3403B00 VA: 0x3407B00
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x3407B44 Offset: 0x3403B44 VA: 0x3407B44 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x3407FA4 Offset: 0x3403FA4 VA: 0x3407FA4
	public void WriteRoot(object ob) { }

	// RVA: 0x34081B8 Offset: 0x34041B8 VA: 0x34081B8 Slot: 5
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x3408E74 Offset: 0x3404E74 VA: 0x3408E74 Slot: 6
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x34090A8 Offset: 0x34050A8 VA: 0x34090A8 Slot: 7
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x34092E0 Offset: 0x34052E0 VA: 0x34092E0 Slot: 8
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x3409AE4 Offset: 0x3405AE4 VA: 0x3409AE4 Slot: 9
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x3409064 Offset: 0x3405064 VA: 0x3409064
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x3409384 Offset: 0x3405384 VA: 0x3409384
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x3409B88 Offset: 0x3405B88 VA: 0x3409B88
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x340A50C Offset: 0x340650C VA: 0x340A50C
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x340A2E4 Offset: 0x34062E4 VA: 0x340A2E4
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x340ACB4 Offset: 0x3406CB4 VA: 0x340ACB4
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x34089C0 Offset: 0x34049C0 VA: 0x34089C0
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x340C9E0 Offset: 0x34089E0 VA: 0x340C9E0
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x340CCE8 Offset: 0x3408CE8 VA: 0x340CCE8
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x340CF64 Offset: 0x3408F64 VA: 0x340CF64 Slot: 10
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x340B228 Offset: 0x3407228 VA: 0x340B228
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x340D150 Offset: 0x3409150 VA: 0x340D150
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x340BA3C Offset: 0x3407A3C VA: 0x340BA3C
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x340E03C Offset: 0x340A03C VA: 0x340E03C Slot: 11
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x340E078 Offset: 0x340A078 VA: 0x340E078 Slot: 12
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x340A9FC Offset: 0x34069FC VA: 0x340A9FC
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x340E0A8 Offset: 0x340A0A8 VA: 0x340E0A8
	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }
}

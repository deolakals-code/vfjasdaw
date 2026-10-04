// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent // TypeDefIndex: 13828
{
	// Fields
	private XmlSchemaObjectCollection baseTypes; // 0x50
	private XmlQualifiedName[] memberTypes; // 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; // 0x60

	// Properties
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection BaseTypes { get; }
	[Xml("memberTypes")]
	public XmlQualifiedName[] MemberTypes { get; set; }
	[XmlIgnore]
	public XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x3343898 Offset: 0x333F898 VA: 0x3343898
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x33438A0 Offset: 0x333F8A0 VA: 0x33438A0
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x33438A8 Offset: 0x333F8A8 VA: 0x33438A8
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x33438B0 Offset: 0x333F8B0 VA: 0x33438B0
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x33438B8 Offset: 0x333F8B8 VA: 0x33438B8
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0x33438C0 Offset: 0x333F8C0 VA: 0x33438C0 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x3343A40 Offset: 0x333FA40 VA: 0x3343A40
	public void .ctor() { }
}

// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroup : XmlSchemaObject // TypeDefIndex: 13829
{
	// Fields
	private ArrayList membersList; // 0x38
	private XmlQualifiedName examplar; // 0x40

	// Properties
	[XmlIgnore]
	internal ArrayList Members { get; }
	[XmlIgnore]
	internal XmlQualifiedName Examplar { get; set; }

	// Methods

	// RVA: 0x3343AAC Offset: 0x333FAAC VA: 0x3343AAC
	internal ArrayList get_Members() { }

	// RVA: 0x3343AB4 Offset: 0x333FAB4 VA: 0x3343AB4
	internal XmlQualifiedName get_Examplar() { }

	// RVA: 0x3343ABC Offset: 0x333FABC VA: 0x3343ABC
	internal void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0x3343AC4 Offset: 0x333FAC4 VA: 0x3343AC4
	public void .ctor() { }
}

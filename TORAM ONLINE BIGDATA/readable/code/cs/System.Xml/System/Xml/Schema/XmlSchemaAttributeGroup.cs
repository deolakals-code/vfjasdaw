// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroup : XmlSchemaAnnotated // TypeDefIndex: 13757
{
	// Fields
	private string name; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaAttributeGroup redefined; // 0x70
	private XmlSchemaObjectTable attributeUses; // 0x78
	private XmlSchemaAnyAttribute attributeWildcard; // 0x80
	private int selfReferenceCount; // 0x88

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnore]
	internal XmlSchemaAnyAttribute AttributeWildcard { get; set; }
	[XmlIgnore]
	public XmlSchemaAttributeGroup RedefinedAttributeGroup { get; }
	[XmlIgnore]
	internal XmlSchemaAttributeGroup Redefined { get; set; }
	[XmlIgnore]
	internal int SelfReferenceCount { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x3333618 Offset: 0x332F618 VA: 0x3333618
	public string get_Name() { }

	// RVA: 0x3333620 Offset: 0x332F620 VA: 0x3333620
	public void set_Name(string value) { }

	// RVA: 0x3333628 Offset: 0x332F628 VA: 0x3333628
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x3333630 Offset: 0x332F630 VA: 0x3333630
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x3333638 Offset: 0x332F638 VA: 0x3333638
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x3333640 Offset: 0x332F640 VA: 0x3333640
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x3333648 Offset: 0x332F648 VA: 0x3333648
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x33336B8 Offset: 0x332F6B8 VA: 0x33336B8
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x33336C0 Offset: 0x332F6C0 VA: 0x33336C0
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x33336C8 Offset: 0x332F6C8 VA: 0x33336C8
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x33336D0 Offset: 0x332F6D0 VA: 0x33336D0
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x33336D8 Offset: 0x332F6D8 VA: 0x33336D8
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x33336E0 Offset: 0x332F6E0 VA: 0x33336E0
	internal int get_SelfReferenceCount() { }

	// RVA: 0x33336E8 Offset: 0x332F6E8 VA: 0x33336E8
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x33336F0 Offset: 0x332F6F0 VA: 0x33336F0 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x33336F8 Offset: 0x332F6F8 VA: 0x33336F8 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x3333700 Offset: 0x332F700 VA: 0x3333700
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x3333708 Offset: 0x332F708 VA: 0x3333708 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x3333BA0 Offset: 0x332FBA0 VA: 0x3333BA0
	public void .ctor() { }
}

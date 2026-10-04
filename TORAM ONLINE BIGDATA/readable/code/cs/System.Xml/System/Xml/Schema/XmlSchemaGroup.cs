// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaGroup : XmlSchemaAnnotated // TypeDefIndex: 13794
{
	// Fields
	private string name; // 0x50
	private XmlSchemaGroupBase particle; // 0x58
	private XmlSchemaParticle canonicalParticle; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaGroup redefined; // 0x70
	private int selfReferenceCount; // 0x78

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	public XmlSchemaGroupBase Particle { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal XmlSchemaParticle CanonicalParticle { get; set; }
	[XmlIgnore]
	internal XmlSchemaGroup Redefined { get; set; }
	[XmlIgnore]
	internal int SelfReferenceCount { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x3338308 Offset: 0x3334308 VA: 0x3338308
	public string get_Name() { }

	// RVA: 0x3338310 Offset: 0x3334310 VA: 0x3338310
	public void set_Name(string value) { }

	// RVA: 0x3338318 Offset: 0x3334318 VA: 0x3338318
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x3338320 Offset: 0x3334320 VA: 0x3338320
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x3338328 Offset: 0x3334328 VA: 0x3338328
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x3338330 Offset: 0x3334330 VA: 0x3338330
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x3338338 Offset: 0x3334338 VA: 0x3338338
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x3338340 Offset: 0x3334340 VA: 0x3338340
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x3338348 Offset: 0x3334348 VA: 0x3338348
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x3338350 Offset: 0x3334350 VA: 0x3338350
	internal int get_SelfReferenceCount() { }

	// RVA: 0x3338358 Offset: 0x3334358 VA: 0x3338358
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x3338360 Offset: 0x3334360 VA: 0x3338360 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x3338368 Offset: 0x3334368 VA: 0x3338368 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x3338370 Offset: 0x3334370 VA: 0x3338370
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x3338378 Offset: 0x3334378 VA: 0x3338378 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x3332014 Offset: 0x332E014 VA: 0x3332014
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x3338380 Offset: 0x3334380 VA: 0x3338380
	public void .ctor() { }
}

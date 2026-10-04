// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaGroupRef : XmlSchemaParticle // TypeDefIndex: 13796
{
	// Fields
	private XmlQualifiedName refName; // 0x78
	private XmlSchemaGroupBase particle; // 0x80
	private XmlSchemaGroup refined; // 0x88

	// Properties
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[XmlIgnore]
	public XmlSchemaGroupBase Particle { get; }
	[XmlIgnore]
	internal XmlSchemaGroup Redefined { get; set; }

	// Methods

	// RVA: 0x33383F0 Offset: 0x33343F0 VA: 0x33383F0
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x3336154 Offset: 0x3332154 VA: 0x3336154
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x33383F8 Offset: 0x33343F8 VA: 0x33383F8
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x3338400 Offset: 0x3334400 VA: 0x3338400
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x3338408 Offset: 0x3334408 VA: 0x3338408
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x3338410 Offset: 0x3334410 VA: 0x3338410
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x3338418 Offset: 0x3334418 VA: 0x3338418
	public void .ctor() { }
}

// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaComplexContent : XmlSchemaContentModel // TypeDefIndex: 13764
{
	// Fields
	private XmlSchemaContent content; // 0x50
	private bool isMixed; // 0x58
	private bool hasMixedAttribute; // 0x59

	// Properties
	[Xml("mixed")]
	public bool IsMixed { get; set; }
	[XmlElement("extension", typeof(XmlSchemaComplexContentExtension))]
	[XmlElement("restriction", typeof(XmlSchemaComplexContentRestriction))]
	public override XmlSchemaContent Content { get; set; }
	[XmlIgnore]
	internal bool HasMixedAttribute { get; }

	// Methods

	// RVA: 0x3334998 Offset: 0x3330998 VA: 0x3334998
	public bool get_IsMixed() { }

	// RVA: 0x33349A0 Offset: 0x33309A0 VA: 0x33349A0
	public void set_IsMixed(bool value) { }

	// RVA: 0x33349B4 Offset: 0x33309B4 VA: 0x33349B4 Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x33349BC Offset: 0x33309BC VA: 0x33349BC Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x33349C4 Offset: 0x33309C4 VA: 0x33349C4
	internal bool get_HasMixedAttribute() { }

	// RVA: 0x33349CC Offset: 0x33309CC VA: 0x33349CC
	public void .ctor() { }
}

// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated // TypeDefIndex: 13797
{
	// Fields
	private string name; // 0x50
	private XmlSchemaXPath selector; // 0x58
	private XmlSchemaObjectCollection fields; // 0x60
	private XmlQualifiedName qualifiedName; // 0x68
	private CompiledIdentityConstraint compiledConstraint; // 0x70

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("selector", typeof(XmlSchemaXPath))]
	public XmlSchemaXPath Selector { get; set; }
	[XmlElement("field", typeof(XmlSchemaXPath))]
	public XmlSchemaObjectCollection Fields { get; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal CompiledIdentityConstraint CompiledConstraint { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x33384AC Offset: 0x33344AC VA: 0x33384AC
	public string get_Name() { }

	// RVA: 0x33384B4 Offset: 0x33344B4 VA: 0x33384B4
	public void set_Name(string value) { }

	// RVA: 0x33384BC Offset: 0x33344BC VA: 0x33384BC
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0x33384C4 Offset: 0x33344C4 VA: 0x33384C4
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x33384CC Offset: 0x33344CC VA: 0x33384CC
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x33384D4 Offset: 0x33344D4 VA: 0x33384D4
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x33384DC Offset: 0x33344DC VA: 0x33384DC
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x33384E4 Offset: 0x33344E4 VA: 0x33384E4
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x33384EC Offset: 0x33344EC VA: 0x33384EC
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x33384F4 Offset: 0x33344F4 VA: 0x33384F4 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x33384FC Offset: 0x33344FC VA: 0x33384FC Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x3338504 Offset: 0x3334504 VA: 0x3338504
	public void .ctor() { }
}

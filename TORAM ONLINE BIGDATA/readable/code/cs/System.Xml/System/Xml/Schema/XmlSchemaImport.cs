// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaImport : XmlSchemaExternal // TypeDefIndex: 13802
{
	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Properties
	[Xml("namespace", DataType = "anyURI")]
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x33386E8 Offset: 0x33346E8 VA: 0x33386E8
	public void .ctor() { }

	// RVA: 0x3338708 Offset: 0x3334708 VA: 0x3338708
	public string get_Namespace() { }

	// RVA: 0x3338710 Offset: 0x3334710 VA: 0x3338710
	public void set_Namespace(string value) { }

	// RVA: 0x3338718 Offset: 0x3334718 VA: 0x3338718 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}

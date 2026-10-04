// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class SchemaNotation // TypeDefIndex: 13727
{
	// Fields
	private XmlQualifiedName name; // 0x10
	private string systemLiteral; // 0x18
	private string pubid; // 0x20

	// Properties
	internal XmlQualifiedName Name { get; }
	internal string SystemLiteral { get; set; }
	internal string Pubid { get; set; }

	// Methods

	// RVA: 0x3310B7C Offset: 0x330CB7C VA: 0x3310B7C
	internal void .ctor(XmlQualifiedName name) { }

	// RVA: 0x3310BAC Offset: 0x330CBAC VA: 0x3310BAC
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x3310BB4 Offset: 0x330CBB4 VA: 0x3310BB4
	internal string get_SystemLiteral() { }

	// RVA: 0x3310BBC Offset: 0x330CBBC VA: 0x3310BBC
	internal void set_SystemLiteral(string value) { }

	// RVA: 0x3310BC4 Offset: 0x330CBC4 VA: 0x3310BC4
	internal string get_Pubid() { }

	// RVA: 0x3310BCC Offset: 0x330CBCC VA: 0x3310BCC
	internal void set_Pubid(string value) { }
}

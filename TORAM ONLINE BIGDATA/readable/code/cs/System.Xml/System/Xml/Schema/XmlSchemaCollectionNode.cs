// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class XmlSchemaCollectionNode // TypeDefIndex: 13761
{
	// Fields
	private string namespaceUri; // 0x10
	private SchemaInfo schemaInfo; // 0x18
	private XmlSchema schema; // 0x20

	// Properties
	internal string NamespaceURI { set; }
	internal SchemaInfo SchemaInfo { get; set; }
	internal XmlSchema Schema { get; set; }

	// Methods

	// RVA: 0x333472C Offset: 0x333072C VA: 0x333472C
	internal void set_NamespaceURI(string value) { }

	// RVA: 0x3334734 Offset: 0x3330734 VA: 0x3334734
	internal SchemaInfo get_SchemaInfo() { }

	// RVA: 0x333473C Offset: 0x333073C VA: 0x333473C
	internal void set_SchemaInfo(SchemaInfo value) { }

	// RVA: 0x3334744 Offset: 0x3330744 VA: 0x3334744
	internal XmlSchema get_Schema() { }

	// RVA: 0x333474C Offset: 0x333074C VA: 0x333474C
	internal void set_Schema(XmlSchema value) { }

	// RVA: 0x33345D8 Offset: 0x33305D8 VA: 0x33345D8
	public void .ctor() { }
}

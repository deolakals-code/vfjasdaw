// Assembly: System.Xml.dll
// Namespace: System.Xml
public class XmlDocumentType : XmlLinkedNode // TypeDefIndex: 13397
{
	// Fields
	private string name; // 0x20
	private string publicId; // 0x28
	private string systemId; // 0x30
	private string internalSubset; // 0x38
	private bool namespaces; // 0x40
	private XmlNamedNodeMap entities; // 0x48
	private XmlNamedNodeMap notations; // 0x50
	private SchemaInfo schemaInfo; // 0x58

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public XmlNamedNodeMap Entities { get; }
	public XmlNamedNodeMap Notations { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string InternalSubset { get; }
	internal bool ParseWithNamespaces { get; }
	internal SchemaInfo DtdSchemaInfo { get; set; }

	// Methods

	// RVA: 0x33B5F18 Offset: 0x33B1F18 VA: 0x33B5F18
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x33B9190 Offset: 0x33B5190 VA: 0x33B9190 Slot: 6
	public override string get_Name() { }

	// RVA: 0x33B9198 Offset: 0x33B5198 VA: 0x33B9198 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x33B91A0 Offset: 0x33B51A0 VA: 0x33B91A0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x33B91A8 Offset: 0x33B51A8 VA: 0x33B91A8 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x33B91E4 Offset: 0x33B51E4 VA: 0x33B91E4 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x33B83FC Offset: 0x33B43FC VA: 0x33B83FC
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x33B91EC Offset: 0x33B51EC VA: 0x33B91EC
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x33B9264 Offset: 0x33B5264 VA: 0x33B9264
	public string get_PublicId() { }

	// RVA: 0x33B926C Offset: 0x33B526C VA: 0x33B926C
	public string get_SystemId() { }

	// RVA: 0x33B9274 Offset: 0x33B5274 VA: 0x33B9274
	public string get_InternalSubset() { }

	// RVA: 0x33B927C Offset: 0x33B527C VA: 0x33B927C
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x33B9284 Offset: 0x33B5284 VA: 0x33B9284 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x33B92B0 Offset: 0x33B52B0 VA: 0x33B92B0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x33B92B4 Offset: 0x33B52B4 VA: 0x33B92B4
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x33B92BC Offset: 0x33B52BC VA: 0x33B92BC
	internal void set_DtdSchemaInfo(SchemaInfo value) { }
}

// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaAny : XmlSchemaParticle // TypeDefIndex: 13753
{
	// Fields
	private string ns; // 0x78
	private XmlSchemaContentProcessing processContents; // 0x80
	private NamespaceList namespaceList; // 0x88

	// Properties
	[Xml("namespace")]
	public string Namespace { get; set; }
	[Xml("processContents")]
	[DefaultValue(0)]
	public XmlSchemaContentProcessing ProcessContents { set; }
	[XmlIgnore]
	internal NamespaceList NamespaceList { get; }
	[XmlIgnore]
	internal string ResolvedNamespace { get; }
	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }
	internal override string NameString { get; }

	// Methods

	// RVA: 0x33327C8 Offset: 0x332E7C8 VA: 0x33327C8
	public string get_Namespace() { }

	// RVA: 0x33327D0 Offset: 0x332E7D0 VA: 0x33327D0
	public void set_Namespace(string value) { }

	// RVA: 0x33327D8 Offset: 0x332E7D8 VA: 0x33327D8
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x33327E0 Offset: 0x332E7E0 VA: 0x33327E0
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x33327E8 Offset: 0x332E7E8 VA: 0x33327E8
	internal string get_ResolvedNamespace() { }

	// RVA: 0x3332840 Offset: 0x332E840 VA: 0x3332840
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x3332854 Offset: 0x332E854 VA: 0x3332854 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x3332D6C Offset: 0x332ED6C VA: 0x3332D6C
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x3332DF4 Offset: 0x332EDF4 VA: 0x3332DF4
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x3332E9C Offset: 0x332EE9C VA: 0x3332E9C
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x3332EC4 Offset: 0x332EEC4 VA: 0x3332EC4
	public void .ctor() { }
}
